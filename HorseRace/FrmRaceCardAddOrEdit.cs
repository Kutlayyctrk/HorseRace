using HorseRace.Models.ContextClasses;
using HorseRace.Models.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HorseRace
{
    public partial class FrmRaceCardAddOrEdit : FrmBase
    {
        public FrmRaceCardAddOrEdit(string ButtonText, int raceCardId)
        {
            InitializeComponent();
            BtnAddOrEdit.Text = ButtonText;
            _db = new MyContext();
            _raceCard = _db.RaceCards.Find(raceCardId);
            CmbRace.DataSource = _db.Races.Where(x=>x.DataStatus==Models.Enums.DataStatus.Inserted||x.DataStatus==Models.Enums.DataStatus.Updated).ToList();
            foreach (Race item in _raceCard.Races)
            {
                LstRaces.Items.Add(item);
            }
            TxtName.Text = _raceCard.Name;
            TxtPlace.Text = _raceCard.Place;
            CmbRace.DisplayMember = "Name";
            LstRaces.DisplayMember = "Name";
            CmbRace.SelectedIndex = -1;
            if(_raceCard.DataStatus==Models.Enums.DataStatus.Inserted||_raceCard.DataStatus==Models.Enums.DataStatus.Updated)
            {
                BtnActivate.Visible = true;
            }
            else
            {
                BtnActivate.Visible = false;
            }
        }

        MyContext _db;
        RaceCard _raceCard;

        public FrmRaceCardAddOrEdit(string ButtonText)
        {
            InitializeComponent();
            BtnAddOrEdit.Text = ButtonText;
            _db = new MyContext();
            CmbRace.DataSource = _db.Races.ToList();
            CmbRace.DisplayMember = "Name";
            LstRaces.DisplayMember = "Name";
            CmbRace.SelectedIndex = -1;
            CmbRace.DataSource = _db.Races.Where(x => x.DataStatus == Models.Enums.DataStatus.Inserted || x.DataStatus == Models.Enums.DataStatus.Updated).ToList();
        }

        private void BtnAddOrEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(TxtName.Text) && string.IsNullOrWhiteSpace(TxtPlace.Text))
                {
                    MessageBox.Show("Cannot be empty Bulletin Name or Place");
                    return;
                }
                else
                {
                    if (BtnAddOrEdit.Text == "Add")
                    {
                        RaceCard raceCard = new RaceCard();
                        raceCard.Name = TxtName.Text;
                        raceCard.Place = TxtPlace.Text;
                        foreach (Race item in LstRaces.Items)
                        {
                            raceCard.Races.Add(item);
                        }
                        _db.RaceCards.Add(raceCard);
                        _db.SaveChanges();
                        MessageBox.Show("Bulletin added succusfully");
                        DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        _raceCard.Name = TxtName.Text;
                        _raceCard.Place = TxtPlace.Text;
                        _raceCard.Races.Clear();
                        foreach (Race item in LstRaces.Items)
                        {
                            _raceCard.Races.Add(item);
                        }
                        _raceCard.DataStatus = Models.Enums.DataStatus.Updated;
                        _raceCard.UpdatedDate=DateTime.Now;

                        _db.SaveChanges();
                        DialogResult = DialogResult.OK;
                        MessageBox.Show("Bulletin updated succesfully");
                        this.Close();
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message); ;
            }
        }

        private void BtnRaceAdd_Click(object sender, EventArgs e)
        {
            LstRaces.Items.Add(CmbRace.SelectedItem);
        }

        private void BtnDeleteRace_Click(object sender, EventArgs e)
        {
            LstRaces.Items.Remove(CmbRace.SelectedItem);
            _raceCard.Races.Remove(LstRaces.SelectedItem as Race);
        }

        private void BtnActivate_Click(object sender, EventArgs e)
        {
            _raceCard.DataStatus = Models.Enums.DataStatus.Updated;
            _raceCard.UpdatedDate = DateTime.Now;
            _raceCard.DeletedDate = null;
            _db.SaveChanges();
        }
    }
}
