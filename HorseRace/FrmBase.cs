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
    public partial class FrmBase : Form
    {
        public FrmBase()
        {
            InitializeComponent();
            StartPosition=FormStartPosition.CenterScreen;
            ShowIcon = false;
            KeyPreview = true;
            KeyDown += FrmBase_KeyDown;
        }

        private void FrmBase_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Escape&&(sender is FrmBase))
            {
                Close();
            }
        }
    }
}
