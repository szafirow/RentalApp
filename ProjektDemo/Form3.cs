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

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

            using (db = new DataClassesDataContext(c.connectionString))
            {
                var video_query = (from v in db.video
                                   orderby v.id descending
                                   select new
                                   {
                                       name = v.name
                                   });
                                   


            dataGridView1.DataSource = video_query.ToList();
            }
        }
    }
}
