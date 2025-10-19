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
            FrmRaceCardAddOrEdit frmRaceCardAddOrEdit = new FrmRaceCardAddOrEdit("Add");
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
            FrmRaceCardAddOrEdit frmRaceCardAddOrEdit = new FrmRaceCardAddOrEdit("Edit", _selectedRaceCard.Id);
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
                else
                {
                    _db.RaceCards.Remove(_selectedRaceCard);
                    _db.SaveChanges();
                    dgvResultRaceCard.DataSource = _db.RaceCards.ToList();
                    MessageBox.Show("The RaceCard was succesfully deleted. ");
                }

            }
            catch (DbUpdateException)
            {
                MessageBox.Show("To delete a Bulletin, you must first remove it from the race days.");
                return;
            }




        }
    }
}
