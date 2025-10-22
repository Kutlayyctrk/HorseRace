using HorseRace.Models.ContextClasses;
using HorseRace.Models.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HorseRace
{
    public partial class FrmCreateJockey : FrmBase
    {
        public FrmCreateJockey()
        {
            InitializeComponent();
            _db = new MyContext();
            dgvResultJockey.CellClick += dgvResultJockey_CellClick;
            dgvResultJockey.DataSource = _db.Jockeys.ToList();

        }
        MyContext _db;
        Jockey _selectedJockey;
        private void BtnAddJockey_Click(object sender, EventArgs e)
        {
            FrmJockeyAddOrEdit frmJockeyAddOrEdit = new FrmJockeyAddOrEdit("Add"); //Ekleme constructor'ı
            frmJockeyAddOrEdit.Text = "Add";
            if (frmJockeyAddOrEdit.ShowDialog() == DialogResult.OK)
            {
                dgvResultJockey.DataSource = _db.Jockeys.ToList();
            }



        }

        private void BtnEditJockey_Click(object sender, EventArgs e)
        {
            if (_selectedJockey == null)
            {
                MessageBox.Show("Please select a jockey to edit.");
                return;
            }
            else
            {
                FrmJockeyAddOrEdit frmJockeyAddOrEdit = new FrmJockeyAddOrEdit("Edit", _selectedJockey.Id); //Edit consturctor'ı
                frmJockeyAddOrEdit.Text = "Edit";
                if (frmJockeyAddOrEdit.ShowDialog() == DialogResult.OK)
                {
                    _db.Dispose();
                    _db = new MyContext();
                    dgvResultJockey.DataSource = _db.Jockeys.ToList();

                }


            }
        }




        private void dgvResultJockey_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            else
            {
                _selectedJockey = dgvResultJockey.Rows[e.RowIndex].DataBoundItem as Jockey;
            }

        }
        private void BtnDeleteJockey_Click(object sender, EventArgs e)
        {
            try
            {
                if (_selectedJockey == null)
                {
                    MessageBox.Show("Please select a jockey to delete.");
                    return;
                }
                else
                {
                    if (_db.Horses.Any(x => x.JokeyId == _selectedJockey.Id))
                    {
                        MessageBox.Show("This jockey has been assigned to an active horse. Remove the horse assignment before deleting the horse.");
                        return;
                    }
                    else
                    {
                        _selectedJockey.DataStatus = Models.Enums.DataStatus.Deleted;
                        _selectedJockey.DeletedDate = DateTime.Now;
                        _db.SaveChanges();
                        dgvResultJockey.DataSource = _db.Jockeys.ToList();
                        MessageBox.Show("The jockey was successfully deleted.");

                    }


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }


    }
}
