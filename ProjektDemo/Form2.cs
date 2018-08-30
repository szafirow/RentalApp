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
        List<Type> listType;

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            using (db = new DataClassesDataContext(c.connectionString))
            {

                video v = new video();
                v.name = textBox1.Text;
                v.status_id = 1;
                v.type = comboBox1.SelectedValue.ToString();
                v.year = Convert.ToString(numericUpDown1.Value);

               
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

        private void Form2_Load(object sender, EventArgs e)
        {
            listType = new List<Type>();
            listType.AddRange(new Type[] {
                new Type { id = 1, name = "Movie" },
                new Type {id = 0, name = "Serials" }
                });

            comboBox1.DataSource = listType;
            comboBox1.DisplayMember = "name";
            comboBox1.ValueMember = "id";
        }
    }
}
