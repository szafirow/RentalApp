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
                db.video.InsertOnSubmit(v);
                db.SubmitChanges();
                MessageBox.Show("Great!");

            }



        }
    }
}
