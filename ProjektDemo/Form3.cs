using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektDemo
{

    public partial class Form3 : Form
    {
        Connection c = new Connection();
        DataClassesDataContext db;
        //List<Temp> listTemp;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;

            using (db = new DataClassesDataContext(c.connectionString))
            {
                var video_query = (from v in db.video
                                   join s in db.status on v.status_id equals s.id
                                   orderby v.id descending
                                   select new
                                   {
                                       name = v.name,
                                       status = s.name,
                                       type = v.type,
                                       year = v.year
                                   });
                                   


            dataGridView1.DataSource = video_query.ToList();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

/*
            listTemp = new List<Temp>();
            listTemp.AddRange(new Temp[] {
                new Temp {id = 0, name = "Nie" },
                new Temp { id = 1, name = "Tak" }
            });
           */

            using (db = new DataClassesDataContext())
            {
              

                comboBox1.DisplayMember = "name";
                comboBox1.ValueMember = "id";
                comboBox1.DataSource = db.status.ToList<status>();
            } 


        }
    }
}
