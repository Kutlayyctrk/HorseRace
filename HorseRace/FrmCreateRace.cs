using HorseRace.Models.ContextClasses;
using HorseRace.Models.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HorseRace
{
    public partial class FrmCreateRace : FrmBase
    {
        public FrmCreateRace()
        {
            InitializeComponent();
            _db = new MyContext();
            dgvResultRace.DataSource = _db.Races.ToList();
            dgvResultRace.CellClick += dgvResultRace_CellClick;
        }
        MyContext _db;
        Race _selectedRace;
        private void BtnAddRace_Click(object sender, EventArgs e)
        {
            FrmRaceAddorEdit frmRaceAddorEdit = new FrmRaceAddorEdit("Add"); //Ekleme Constructor'ı
            frmRaceAddorEdit.Text = "Add";
            if (frmRaceAddorEdit.ShowDialog() == DialogResult.OK)
            {
                _db.Dispose();
                _db = new MyContext();
                dgvResultRace.DataSource = _db.Races.ToList();
            }

        }

        private void BtnEditRace_Click(object sender, EventArgs e)
        {
            if (_selectedRace == null)
            {
                MessageBox.Show("Please select a Race to edit");
            }
            else
            {
                FrmRaceAddorEdit frmRaceAddorEdit = new FrmRaceAddorEdit("Edit", _selectedRace.Id);//Edit Constructor'ı
                frmRaceAddorEdit.Text = "Edit";
                if (frmRaceAddorEdit.ShowDialog() == DialogResult.OK)
                {
                    _db.Dispose();
                    _db = new MyContext();
                    dgvResultRace.DataSource = _db.Races.ToList();
                }

            }

        }


        private void dgvResultRace_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                return;
            }
            else
            {
                _selectedRace = dgvResultRace.Rows[e.RowIndex].DataBoundItem as Race;
            }
        }

        private void BtnDeleteRace_Click(object sender, EventArgs e)
        {
            try
            {
                if (_selectedRace == null)
                {
                    MessageBox.Show("Please select a Race to Delete");
                    return;
                }
                if (_selectedRace.RaceCardId.HasValue)
                {
                    MessageBox.Show("This race has been assigned to an active newsletter.Remove the newsletter assignment before deleting the race.");
                    return;
                }
                else
                {
                    _selectedRace.DataStatus = Models.Enums.DataStatus.Deleted;
                    _selectedRace.DeletedDate = DateTime.Now;
                    _db.SaveChanges();
                    dgvResultRace.DataSource = _db.Races.ToList();
                    MessageBox.Show("The Race was successfully deleted.");
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
