using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriggeredDatabase
{
    public partial class RecycleBin : Form
    {
        public RecycleBin()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-HPJO022;Initial Catalog=BackupTable;Integrated Security=True");
        void list()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Books_BackUp", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void RecycleBin_Load(object sender, EventArgs e)
        {
            list();
        }

        private void mainpage_bttn_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            this.Close();
            fr.ShowDialog();
        }

        private void mainpage_bttn_MouseEnter(object sender, EventArgs e)
        {
            mainpage_bttn.BackColor = Color.DarkSlateBlue;
        }

        private void mainpage_bttn_MouseLeave(object sender, EventArgs e)
        {
            mainpage_bttn.BackColor = Color.Transparent;
        }

        private void exit_bttn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exit_bttn_MouseEnter(object sender, EventArgs e)
        {
            exit_bttn.BackColor = Color.DarkSlateBlue;
        }

        private void exit_bttn_MouseLeave(object sender, EventArgs e)
        {
            exit_bttn.BackColor = Color.Transparent;
        }

        private void save_bttn_MouseEnter(object sender, EventArgs e)
        {
            save_bttn.BackColor = Color.DarkSlateBlue;
        }

        private void save_bttn_MouseLeave(object sender, EventArgs e)
        {
            save_bttn.BackColor = Color.Transparent;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int no = dataGridView1.SelectedCells[0].RowIndex;
            id_txtbox.Text = dataGridView1.Rows[no].Cells[0].Value.ToString();
        }

        private void save_bttn_Click(object sender, EventArgs e)
        {
            if(id_txtbox.Text == "")
            {
                MessageBox.Show("Select a book you want to save.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);   
            }
            else
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Delete from Tbl_Books_BackUp where ID=@p1", conn);
                cmd.Parameters.AddWithValue("@p1", id_txtbox.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Selected book is saved.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                list();
                id_txtbox.Text = "";
            }
        }
    }
}
