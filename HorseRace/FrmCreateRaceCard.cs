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
    public partial class FrmCreateRaceCard : FrmBase
    {
        public FrmCreateRaceCard()
        {
            InitializeComponent();
            _db = new MyContext();
            dgvResultRaceCard.DataSource = _db.RaceCards.ToList();
            dgvResultRaceCard.CellClick += dgvResultRaceCard_CellClick;
        }



        MyContext _db;
        RaceCard _selectedRaceCard;
        private void BtnAddRaceCard_Click(object sender, EventArgs e)
        {
            FrmRaceCardAddOrEdit frmRaceCardAddOrEdit = new FrmRaceCardAddOrEdit("Add");//Ekleme Constructor'ı
            frmRaceCardAddOrEdit.Text = "Add";
            if (frmRaceCardAddOrEdit.ShowDialog() == DialogResult.OK)
            {
                _db.Dispose();
                _db = new MyContext();
                dgvResultRaceCard.DataSource = _db.RaceCards.ToList();
            }
        }

        private void BtnEditBulletin_Click(object sender, EventArgs e)
        {
            FrmRaceCardAddOrEdit frmRaceCardAddOrEdit = new FrmRaceCardAddOrEdit("Edit", _selectedRaceCard.Id);//Editleme Constructor'ı
            frmRaceCardAddOrEdit.Text = "Edit";
            if (frmRaceCardAddOrEdit.ShowDialog() == DialogResult.OK)
            {
                _db.Dispose();
                _db = new MyContext();
                dgvResultRaceCard.DataSource = _db.RaceCards.ToList();
            }
        }

        private void dgvResultRaceCard_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {

                return;
            }
            else
            {
                _selectedRaceCard = dgvResultRaceCard.Rows[e.RowIndex].DataBoundItem as RaceCard;
            }
        }

        private void BtnDeleteBulletin_Click(object sender, EventArgs e)
        {
            try
            {
                if (_selectedRaceCard == null)
                {
                    MessageBox.Show("Please select a Bulletin to delete");
                    return;
                }
                if(_selectedRaceCard.RaceDayId.HasValue)
                {
                    MessageBox.Show("This bulletin has been assigned to an active race day. Remove the race day assignment before deleting the bulletin.");
                    return;
                }
                else
                {
                    _selectedRaceCard.DataStatus = Models.Enums.DataStatus.Deleted;
                    _selectedRaceCard.DeletedDate= DateTime.Now;
                    _db.SaveChanges();
                    dgvResultRaceCard.DataSource = _db.RaceCards.ToList();
                    MessageBox.Show("The RaceCard was succesfully deleted. ");
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
