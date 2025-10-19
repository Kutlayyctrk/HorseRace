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
    public partial class FrmMain : FrmBase
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnAddJockey_Click(object sender, EventArgs e)
        {
            FrmCreateJockey frmCreateJockey = new FrmCreateJockey();
            frmCreateJockey.Show();
        }

        private void BtnAddHorse_Click(object sender, EventArgs e)
        {
            FrmCreateHorse frmCreateHorse = new FrmCreateHorse();
            frmCreateHorse.Show();
        }

        private void BtnAddRaceDay_Click(object sender, EventArgs e)
        {
            FrmCreateRaceDay frmCreateRaceDay = new FrmCreateRaceDay();
            frmCreateRaceDay.Show();
        }

        private void BtnAddBulletin_Click(object sender, EventArgs e)
        {
            FrmCreateRaceCard frmCreateRaceCard = new FrmCreateRaceCard();
            frmCreateRaceCard.Show();
        }

        private void BtnAddRace_Click(object sender, EventArgs e)
        {
            FrmCreateRace frmCreateRace = new FrmCreateRace();
            frmCreateRace.Show();
        }

        private void BtnShowInfo_Click(object sender, EventArgs e)
        {
            FrmInfo frmInfo = new FrmInfo();
            frmInfo.Show();
        }
    }
}
