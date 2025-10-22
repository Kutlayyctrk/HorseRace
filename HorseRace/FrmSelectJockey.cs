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
    public partial class FrmSelectJockey : FrmBase
    {
        public FrmSelectJockey(int horseId)
        {
            InitializeComponent();
            _db = new MyContext();
            DgvJockeys.DataSource = _db.Jockeys.Where(x => x.DataStatus == Models.Enums.DataStatus.Updated || x.DataStatus == Models.Enums.DataStatus.Inserted).ToList();
            _horse = _db.Horses.Find(horseId);
        }
        MyContext _db;
        Horse _horse;



        private void TxtJockeyName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtJockeyName.Text))
            {
                DgvJockeys.DataSource = _db.Jockeys.ToList();
            }
            else
            {
                DgvJockeys.DataSource = _db.Jockeys.Where(x => x.Name.Contains(TxtJockeyName.Text)).ToList();

            }
        }

        private void DgvJockeys_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            else
            {
                _horse.Jockey = DgvJockeys.Rows[e.RowIndex].DataBoundItem as Jockey;
            }
        }

        private void BtnSelectJockey_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            _db.SaveChanges();
            Close();
        }
    }
}
