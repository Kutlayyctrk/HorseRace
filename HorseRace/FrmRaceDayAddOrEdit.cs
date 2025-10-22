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
    public partial class FrmRaceDayAddOrEdit : FrmBase
    {
        public FrmRaceDayAddOrEdit(string ButtonText, int RacedayId)
        {
            InitializeComponent();
            BtnAddOrEdit.Text = ButtonText;
            _db = new MyContext();
            _raceDay = _db.RaceDays.Find(RacedayId);
            CmbBulletin.DataSource = _db.RaceCards.Where(x=>x.DataStatus==Models.Enums.DataStatus.Updated||x.DataStatus==Models.Enums.DataStatus.Inserted).ToList();
            foreach (RaceCard card in _raceDay.RaceCards)
            {
                LstBulletin.Items.Add(card);
            }
            TxtName.Text = _raceDay.Name;
            DtpDate.Value = _raceDay.Date;
            CmbBulletin.SelectedIndex = -1;
            if(_raceDay.DataStatus==Models.Enums.DataStatus.Updated||_raceDay.DataStatus==Models.Enums.DataStatus.Inserted)
            {
                BtnActivate.Visible = true;
            }
            else
            {
                BtnActivate.Visible=false;
            }
        }
        MyContext _db;
        RaceDay _raceDay;
        public FrmRaceDayAddOrEdit(string ButtonText)
        {
            InitializeComponent();
            BtnAddOrEdit.Text = ButtonText;
            _db = new MyContext();
            CmbBulletin.DataSource = _db.RaceCards.ToList();
            CmbBulletin.DisplayMember = "Name";
            LstBulletin.DisplayMember = "Name";
            CmbBulletin.SelectedIndex=-1;
            CmbBulletin.DataSource = _db.RaceCards.Where(x => x.DataStatus == Models.Enums.DataStatus.Updated || x.DataStatus == Models.Enums.DataStatus.Inserted).ToList();
        }

        private void BtnAddOrEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(TxtName.Text))
                {
                    MessageBox.Show("Race Day Name cannot be empty");
                    return;
                }
                else
                {
                    if (BtnAddOrEdit.Text == "Add")
                    {
                        RaceDay raceDay = new RaceDay();

                        raceDay.Name = TxtName.Text;
                        raceDay.Date = DtpDate.Value;
                        foreach (RaceCard item in LstBulletin.Items)
                        {
                            raceDay.RaceCards.Add(item);
                        }
                        _db.RaceDays.Add(raceDay);
                        _db.SaveChanges();
                        MessageBox.Show("RaceDay Added Succesfully.");
                        DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                        if (BtnAddOrEdit.Text == "Edit")
                    {
                        _raceDay.Name = TxtName.Text;
                        _raceDay.Date = DtpDate.Value;
                        _raceDay.RaceCards.Clear();
                        foreach(RaceCard item in LstBulletin.Items)
                        {
                            _raceDay.RaceCards.Add(item);
                        }
                        _raceDay.DataStatus = Models.Enums.DataStatus.Updated;
                        _raceDay.UpdatedDate = DateTime.Now;
                        _db.SaveChanges();
                        DialogResult = DialogResult.OK;
                        MessageBox.Show("Raceday updated succesfully");

                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void BtnAddBulletin_Click(object sender, EventArgs e)
        {
            LstBulletin.Items.Add(CmbBulletin.SelectedItem);
        }

        private void BtnDeleteBulletin_Click(object sender, EventArgs e)
        {
            LstBulletin.Items.Remove(LstBulletin.SelectedItem);
            _raceDay.RaceCards.Remove(LstBulletin.SelectedItem as RaceCard);
        }

        private void BtnActivate_Click(object sender, EventArgs e)
        {
            _raceDay.DataStatus = Models.Enums.DataStatus.Updated;
            _raceDay.UpdatedDate= DateTime.Now;
            _raceDay.DeletedDate = null;
            _db.SaveChanges();
        }
    }
}
