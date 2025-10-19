using HorseRace.Models.ContextClasses;
using HorseRace.Models.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HorseRace
{
    public partial class FrmJockeyAddOrEdit : FrmBase
    {
        public FrmJockeyAddOrEdit(string ButtonText, int jockeyId) // Edit constructor
        {
            InitializeComponent();
            BtnAddOrEdit.Text = ButtonText;
            _db = new MyContext();
            _jockey = _db.Jockeys.Find(jockeyId);


            TxtJockeyName.Text = _jockey.Name;
            TxtJockeyAge.Text = _jockey.Age.ToString();


        }


        public FrmJockeyAddOrEdit(string ButtonText)
        {
            InitializeComponent();
            BtnAddOrEdit.Text = ButtonText;
            _db = new MyContext();
        }
        MyContext _db;
        Jockey _jockey;

        private void BtnAddOrEdit_Click(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrWhiteSpace(TxtJockeyName.Text) || (string.IsNullOrEmpty(TxtJockeyAge.Text)))
                {
                    MessageBox.Show("Jockey Name or Jockey Age cannot be empty");
                    return;
                }
                else
                {
                    if (BtnAddOrEdit.Text == "Add")
                    {

                        Jockey jockey = new Jockey()
                        {
                            Name = TxtJockeyName.Text,
                            Age = Convert.ToInt32(TxtJockeyAge.Text)
                        };
                        _db.Jockeys.Add(jockey);
                        _db.SaveChanges();
                        MessageBox.Show("Jockey added successfully");
                        DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        _jockey.Name = TxtJockeyName.Text;
                        _jockey.Age = Convert.ToInt32(TxtJockeyAge.Text);
                        _db.SaveChanges();
                        DialogResult = DialogResult.OK;
                        MessageBox.Show("Jockey updated successfully");
                        this.Close();

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }


    }
}
