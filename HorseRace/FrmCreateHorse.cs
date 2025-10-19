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
    public partial class FrmCreateHorse : FrmBase
    {
        public FrmCreateHorse()
        {
            InitializeComponent();
            _db = new MyContext();
            dgvResultHorse.CellClick += dgvResultHorse_CellClick;
            dgvResultHorse.DataSource = _db.Horses.ToList();
        }
        MyContext _db;
        Horse _selectedHorse;



        private void BtnAddHorse_Click(object sender, EventArgs e)
        {
            FrmHorseAddOrEdit frmHorseAddOrEdit = new FrmHorseAddOrEdit("Add"); //Ekleme constructor'ı
            frmHorseAddOrEdit.Text = "Add Horse";
            if (frmHorseAddOrEdit.ShowDialog() == DialogResult.OK)
            {
                _db.Dispose();
                _db = new MyContext();
                dgvResultHorse.DataSource = _db.Horses.ToList();
            }
        }

        private void BtnEditHorse_Click(object sender, EventArgs e)
        {
            if (_selectedHorse == null)
            {
                MessageBox.Show("Please select a horse to edit.");
                return;
            }
            else
            {
                FrmHorseAddOrEdit frmHorseAddOrEdit = new FrmHorseAddOrEdit("Edit",_selectedHorse.Id); //Edit constructor'ı
                frmHorseAddOrEdit.Text = "Edit Horse";
                if (frmHorseAddOrEdit.ShowDialog() == DialogResult.OK)
                {
                    _db.Dispose();
                    _db = new MyContext();
                    dgvResultHorse.DataSource = _db.Horses.ToList();
                }

            }

        }

        private void dgvResultHorse_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;

            }
            else
            {
                _selectedHorse = dgvResultHorse.Rows[e.RowIndex].DataBoundItem as Horse;
            }
        }

        private void BtnDeleteHorse_Click(object sender, EventArgs e)
        {
            try
            {
            if(_selectedHorse==null)
            {
                MessageBox.Show("Please select a horse to delete.");
                return;
            }
            else
            {
                
                _db.Horses.Remove(_selectedHorse);
                _db.SaveChanges();
                dgvResultHorse.DataSource = _db.Horses.ToList();
                MessageBox.Show("The horse was successfully deleted.");
            }

            }
            catch (DbUpdateException)
            {

                MessageBox.Show("You cannot remove a horse that has been assigned to another race. You must first remove the horse from all races.");
                return;
            }
        }
    }
}
