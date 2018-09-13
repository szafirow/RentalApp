using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektDemo
{
    public partial class Form2 : Form
    {
        Connection c = new Connection();
        DataClassesDataContext db;
        List<Temp> listTemp;

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("You must enter the name of the movie!");
            }
            else
            {
                using (db = new DataClassesDataContext(c.connectionString))
                {


                    video v = new video();
                    v.name = textBox1.Text;
                    v.status_id = 1;
                    v.type_id = Int32.Parse((comboBox1.SelectedValue.ToString()));
                    v.year = Convert.ToString(numericUpDown1.Value);
                    v.@new = Int32.Parse((comboBox2.SelectedValue.ToString()));
                    v.data_add = Convert.ToDateTime(DateTime.Now.ToShortDateString().ToString());
                   


                    db.video.InsertOnSubmit(v);
                    try
                    {
                        db.SubmitChanges();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        db.SubmitChanges();
                    }

                    MessageBox.Show("Great!");
                }
            }



        }

        private void Form2_Load(object sender, EventArgs e)
        {
            using (db = new DataClassesDataContext(c.connectionString))
            {
                comboBox1.DisplayMember = "name";
                comboBox1.ValueMember = "id";
                comboBox1.DataSource = db.type.ToList<type>();
            }

            listTemp = new List<Temp>();
            listTemp.AddRange(new Temp[] {
                new Temp { id = 1, name = "Tak" },
                new Temp {id = 0, name = "Nie" }
            });

            comboBox2.DataSource = listTemp;
            comboBox2.DisplayMember = "name";
            comboBox2.ValueMember = "id";


        }
    }
}
