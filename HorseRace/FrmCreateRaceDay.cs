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
    public partial class FrmCreateRaceDay : FrmBase
    {
        public FrmCreateRaceDay()
        {
            InitializeComponent();
            _db = new MyContext();
            dgvResultRaceDay.CellClick += dgvResultRaceDay_CellClick;
            dgvResultRaceDay.DataSource = _db.RaceDays.ToList();
        }
        MyContext _db;
        RaceDay _selectedRaceDay;

        private void BtnAddRaceDay_Click(object sender, EventArgs e)
        {
            FrmRaceDayAddOrEdit frmRaceDayAddOrEdit = new FrmRaceDayAddOrEdit("Add");//Ekleme Constructor'ı
            frmRaceDayAddOrEdit.Text = "Add";
            if (frmRaceDayAddOrEdit.ShowDialog() == DialogResult.OK)
            {
                _db.Dispose();
                _db = new MyContext();
                dgvResultRaceDay.DataSource = _db.RaceDays.ToList();
            }

        }

        private void BtnEditRaceDay_Click(object sender, EventArgs e)
        {

            if (_selectedRaceDay == null)
            {
                MessageBox.Show("Please select a RaceDay to edit.");
            }
            else
            {
                FrmRaceDayAddOrEdit frmRaceDayAddOrEdit = new FrmRaceDayAddOrEdit("Edit", _selectedRaceDay.Id);//Ekleme Constructor'ı
                frmRaceDayAddOrEdit.Text = "Edit";
                if (frmRaceDayAddOrEdit.ShowDialog() == DialogResult.OK)
                {
                    _db.Dispose();
                    _db = new MyContext();
                    dgvResultRaceDay.DataSource = _db.RaceDays.ToList();
                }
            }

        }

        private void dgvResultRaceDay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            else
            {
                _selectedRaceDay = dgvResultRaceDay.Rows[e.RowIndex].DataBoundItem as RaceDay;
            }
        }

        private void BtnDeleteRaceDay_Click(object sender, EventArgs e)
        {

            if (_selectedRaceDay == null)
            {
                MessageBox.Show("Please select a RaceDay to delete.");
                return;
            }
            else
            {
                _db.RaceDays.Remove(_selectedRaceDay);
                _db.SaveChanges();
                dgvResultRaceDay.DataSource = _db.RaceDays.ToList();
                MessageBox.Show("The RaceDay was successfully deleted.");
            }



        }
    }
}
