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
    public partial class FrmHorseAddOrEdit : FrmBase
    {
        MyContext _db;
        Horse _horse;
        public FrmHorseAddOrEdit(string ButtonText, int horseId) // Edit constructor
        {
            InitializeComponent();
            BtnAddOrEdit.Text = ButtonText;
            _db = new MyContext();
            _horse = _db.Horses.Find(horseId);
            TxtAge.Text = _horse.Age.ToString();
            TxtName.Text = _horse.Name;
            TxtRegion.Text = _horse.Region;



        }
        public FrmHorseAddOrEdit(string ButtonText)
        {
            InitializeComponent();
            BtnAddOrEdit.Text = ButtonText;
            _db = new MyContext();
            _horse = new Horse();

        }


        private void BtnAddOrEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(TxtAge.Text) && string.IsNullOrWhiteSpace(TxtName.Text) && string.IsNullOrWhiteSpace(TxtRegion.Text))
                {
                    MessageBox.Show("Horse Name, Age or Region cannot be empty");
                    return;
                }
                else
                {
                    if (BtnAddOrEdit.Text == "Add")
                    {

                        _horse.Name = TxtName.Text;
                        _horse.Age = Convert.ToInt32(TxtAge.Text);
                        _horse.Region = TxtRegion.Text;



                        _db.Horses.Add(_horse);
                        _db.SaveChanges();

                        MessageBox.Show("Horse added successfully");

                        if (_horse.Id == 0)
                        {
                            MessageBox.Show("First create the horse, then add the Jockey");
                            return;

                        }
                        else
                        {
                            FrmSelectJockey f1 = new FrmSelectJockey(_horse.Id);
                            if (f1.ShowDialog() == DialogResult.OK)
                            {
                                _db.Entry(_horse).Reload();
                                DialogResult = DialogResult.OK;
                                Close();
                            }
                            else
                            {
                                _db.Entry(_horse).Reload();
                            }

                        }

                    }
                    else
                    {
                        _horse.Name = TxtName.Text;
                        _horse.Age = Convert.ToInt32(TxtAge.Text);
                        _horse.Region = TxtRegion.Text;
                        _db.SaveChanges();

                        DialogResult = DialogResult.OK;
                        MessageBox.Show("Horse updated successfully");

                    }
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show($"Genel Hata: {ex.Message}");
            }
        }

        private void BtnSelectJockey_Click(object sender, EventArgs e)
        {

        }
    }
}
