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
    public partial class FrmRaceAddorEdit : FrmBase
    {
        public FrmRaceAddorEdit(string ButtonText, int raceId)
        {
            InitializeComponent();
            BtnAddOrEdit.Text = ButtonText;
            _db = new MyContext();
            _race = _db.Races.Find(raceId);
            CmbHorse.DataSource = _db.Horses.ToList();
            foreach (Horse item in _race.Horses)
            {
                LstHorses.Items.Add(item);
            }
            TxtName.Text = _race.Name;
            CmbHorse.DisplayMember = "Name";
            LstHorses.DisplayMember = "Name";
            CmbHorse.SelectedIndex = -1;



        }
        MyContext _db;
        Race _race;

        public FrmRaceAddorEdit(string ButtonText)
        {
            InitializeComponent();
            BtnAddOrEdit.Text = ButtonText;
            _db = new MyContext();
            CmbHorse.DataSource = _db.Horses.ToList();
            CmbHorse.DisplayMember = "Name";
            LstHorses.DisplayMember = "Name";
            CmbHorse.SelectedIndex = -1;

        }

        private void BtnAddOrEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(TxtName.Text))
                {
                    MessageBox.Show("Cannot be empty Race name");

                    return;
                }
                else
                {
                    if (BtnAddOrEdit.Text == "Add")
                    {
                        Race race = new Race();
                        race.Name = TxtName.Text;
                        foreach (Horse item in LstHorses.Items)
                        {
                            race.Horses.Add(item);
                        }
                        _db.Races.Add(race);
                        _db.SaveChanges();
                        MessageBox.Show("Race has added succcesfully");
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                    else
                    {
                        _race.Name = TxtName.Text;
                        _race.Horses.Clear();
                        foreach (Horse item in LstHorses.Items)
                        {
                            _race.Horses.Add(item);
                        }
                        _db.SaveChanges();
                        DialogResult = DialogResult.OK;
                        MessageBox.Show("Race has updated succesfully");
                        Close();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void BtnHorseAdd_Click(object sender, EventArgs e)
        {
            LstHorses.Items.Add(CmbHorse.SelectedItem);
        }

        private void BtnHorseDelete_Click(object sender, EventArgs e)
        {
            LstHorses.Items.Remove(LstHorses.SelectedItem);
            _race.Horses.Remove(LstHorses.SelectedItem as Horse);
        }
    }
}
