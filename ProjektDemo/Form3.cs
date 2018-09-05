namespace ProjektDemo
{
    using System;
    using System.Data;
    using System.Linq;
    using System.Windows.Forms;

    /// <summary>
    /// Defines the <see cref="Form3" />
    /// </summary>
    public partial class Form3 : Form
    {
        /// <summary>
        /// Defines the c
        /// </summary>
        internal Connection c = new Connection();

        /// <summary>
        /// Defines the db
        /// </summary>
        internal DataClassesDataContext db;

        /// <summary>
        /// Initializes a new instance of the <see cref="Form3"/> class.
        /// </summary>
        public Form3()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Loading a form video
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void Form3_Load(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;
            textBox1.Enabled = false;
            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
            numericUpDown1.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;

            using (db = new DataClassesDataContext(c.connectionString))
            {
                /*   var video_query = (from v in db.video
                                      join s in db.status on v.status_id equals s.id
                                      orderby v.id descending
                                      select new
                                      {
                                          id = v.id,
                                          name = v.name,
                                          status = s.name,
                                          type = v.type,
                                          year = v.year
                                      });
                     */


                // dataGridView1.DataSource = video_query.ToList();
                dataGridView1.DataSource = db.v_video;
            }
        }

        /// <summary>
        /// Deleting video
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (db = new DataClassesDataContext(c.connectionString))
                {
                    int videoID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

                    var results1 = (
                    from v in db.video
                    where v.id == videoID
                    select v).FirstOrDefault();

                    db.video.DeleteOnSubmit(results1);
                    db.SubmitChanges();

                    var count = (from r in db.rental
                                 where r.video_id == videoID
                                 select r).Count();

                    if (count > 0)
                    {
                        var results2 = (
                        from r in db.rental
                        where r.video_id == videoID
                        select r).FirstOrDefault();

                        db.rental.DeleteOnSubmit(results2);
                        db.SubmitChanges();
                    }

                    dataGridView1.DataSource = db.v_video;
                    MessageBox.Show("Deleted!");


                    textBox1.Clear();
                    comboBox1.DataSource = null;
                    comboBox2.DataSource = null;
                    numericUpDown1.Value = 1895;

                    textBox1.Enabled = false;
                    comboBox1.Enabled = false;
                    comboBox2.Enabled = false;
                    numericUpDown1.Enabled = false;
                    button1.Enabled = false;
                    button2.Enabled = false;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Clicking in dataGridView1/ Filling blocked fields
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="DataGridViewCellEventArgs"/></param>
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Enabled = true;
            comboBox1.Enabled = true;
            comboBox2.Enabled = true;
            numericUpDown1.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = true;

            textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            numericUpDown1.Value = Convert.ToDecimal(dataGridView1.SelectedRows[0].Cells[2].Value);

            using (db = new DataClassesDataContext(c.connectionString))
            {
                int videoID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

                var results3 = (
                      from v in db.video
                      where v.id == videoID
                      select v.type_id).Concat(

                    (from t in db.type
                     select t.id).Except(from v in db.video
                                         where v.id == videoID
                                         select v.type_id));

                comboBox1.DisplayMember = "name";
                comboBox1.ValueMember = "type_id";
                comboBox1.DataSource = results3.ToList();


                var results4 = (
                      from v in db.video
                      where v.id == videoID
                      select v.status_id).Concat(

                    (from s in db.status
                     select s.id).Except(from v in db.video
                                         where v.id == videoID
                                         select v.status_id));

                comboBox2.DisplayMember = "status_id";
                comboBox2.ValueMember = "status_id";
                comboBox2.DataSource = results4.ToList();

            }
        }

        /// <summary>
        /// Update
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void button2_Click(object sender, EventArgs e)
        {
            int videoID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

            using (db = new DataClassesDataContext(c.connectionString))
            {
                var results = (
                   from v in db.video
                   where v.id == videoID
                   select v);

                foreach (var res in results)
                {
                    video v_now = db.video.Single(v => v.id == res.id);
                    v_now.name = textBox1.Text;
                    v_now.type_id = Int32.Parse((comboBox1.SelectedValue.ToString()));
                    v_now.year = Convert.ToString(numericUpDown1.Value);
                    v_now.status_id = Int32.Parse((comboBox2.SelectedValue.ToString()));
                    v_now.data_edit = Convert.ToDateTime(DateTime.Now.ToShortDateString().ToString());
                    db.SubmitChanges();

                    dataGridView1.DataSource = db.v_video;
                    MessageBox.Show("Updated!");
                }

                /*  var count = (from r in db.rental
                               where r.video_id == videoID
                               select r).Count();

                  if (count > 0)
                  {
                  }
                  */
            }
        }
    }
}
