using HorseRace.Models.ContextClasses;
using HorseRace.Models.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HorseRace
{
    public partial class FrmInfo : FrmBase
    {
        MyContext _db;
        public FrmInfo()
        {
            InitializeComponent();
            _db = new MyContext();
            DgvRaceDayResult.DataSource = _db.RaceDays.ToList();
            DgvRaceDayResult.CellClick += DgvRaceDayResult_CellClick;
            DgvRaceCardResult.CellClick -= DgvRaceCardResult_CellClick;
        }

        private void DgvRaceDayResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DgvRaceDayResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            else
            {
                RaceDay raceDay = DgvRaceDayResult.Rows[e.RowIndex].DataBoundItem as RaceDay;
                if (raceDay != null)
                {
                    DgvRaceCardResult.DataSource = raceDay.RaceCards;
                }

            }


        }

        private void DgvRaceCardResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            else
            {
                RaceCard racecard = DgvRaceCardResult.Rows[e.RowIndex].DataBoundItem as RaceCard;
                if (racecard != null)
                {
                    DgvRaceResult.DataSource = racecard.Races;
                }
            }
        }

        private void DgvRaceResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            else
            {
                Race race = DgvRaceResult.Rows[e.RowIndex].DataBoundItem as Race;
                if (race != null)
                {
                    DgvHorseResult.DataSource = race.Horses;
                }
            }
        }


    }
}

