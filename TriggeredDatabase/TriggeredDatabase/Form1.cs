using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TriggeredDatabase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-HPJO022;Initial Catalog=BackupTable;Integrated Security=True");

        void list()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Books", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        void counter()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from Tbl_Counter", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                count_lbl.Text = dr[0].ToString();
            }
            conn.Close();
        }
        void clean()
        {
            id_txtbox.Text = "";
            name_txtbox.Text = "";
            author_txtbox.Text = "";
            page_txtbox.Text = "";
            publisher_txtbox.Text = "";
            genre_txtbox.Text = "";
        }
        private void add_bttn_MouseEnter(object sender, EventArgs e)
        {
            add_bttn.BackColor = Color.Thistle;
        }

        private void add_bttn_MouseLeave(object sender, EventArgs e)
        {
            add_bttn.BackColor = Color.Transparent;
        }

        private void delete_bttn_MouseEnter(object sender, EventArgs e)
        {
            delete_bttn.BackColor = Color.Thistle;
        }

        private void delete_bttn_MouseLeave(object sender, EventArgs e)
        {
            delete_bttn.BackColor = Color.Transparent;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.TabStop = false;
            list();
            counter();
        }

        private void add_bttn_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into Tbl_Books (Name,Author,Page,Publisher,Genre) values (@p1,@p2,@p3,@p4,@p5)", conn);
            cmd.Parameters.AddWithValue("@p1", name_txtbox.Text);
            cmd.Parameters.AddWithValue("@p2",author_txtbox.Text);
            cmd.Parameters.AddWithValue("@p3", page_txtbox.Text);
            cmd.Parameters.AddWithValue("@p4", publisher_txtbox.Text);
            cmd.Parameters.AddWithValue("@p5", genre_txtbox.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("New book is added.","",MessageBoxButtons.OK,MessageBoxIcon.Information);
            list();
            counter();
            clean();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int no = dataGridView1.SelectedCells[0].RowIndex;
            id_txtbox.Text = dataGridView1.Rows[no].Cells[0].Value.ToString();
            name_txtbox.Text = dataGridView1.Rows[no].Cells[1].Value.ToString();
            author_txtbox.Text = dataGridView1.Rows[no].Cells[2].Value.ToString();
            page_txtbox.Text = dataGridView1.Rows[no].Cells[3].Value.ToString();
            publisher_txtbox.Text = dataGridView1.Rows[no].Cells[4].Value.ToString();
            genre_txtbox.Text = dataGridView1.Rows[no].Cells[5].Value.ToString();
        }

        private void update_bttn_MouseEnter(object sender, EventArgs e)
        {
            update_bttn.BackColor = Color.Thistle;
        }

        private void update_bttn_MouseLeave(object sender, EventArgs e)
        {
            update_bttn.BackColor = Color.Transparent;
        }

        private void clean_bttn_MouseEnter(object sender, EventArgs e)
        {
            clean_bttn.BackColor = Color.Thistle;
        }

        private void clean_bttn_MouseLeave(object sender, EventArgs e)
        {
            clean_bttn.BackColor = Color.Transparent;
        }

        private void clean_bttn_Click(object sender, EventArgs e)
        {
            clean();
        }

        private void delete_bttn_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Delete from Tbl_Books where ID = @p1",conn);
            cmd.Parameters.AddWithValue("@p1", id_txtbox.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Book is deleted.","",MessageBoxButtons.OK,MessageBoxIcon.Information);
            list();
            counter();
            clean();
        }

        private void update_bttn_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Update Tbl_Books set Name = @p1,Author = @p2,Page = @p3,Publisher = @p4,Genre = @p5 where ID = @p6", conn);
            cmd.Parameters.AddWithValue("@p1", name_txtbox.Text);
            cmd.Parameters.AddWithValue("@p2", author_txtbox.Text);
            cmd.Parameters.AddWithValue("@p3", page_txtbox.Text);
            cmd.Parameters.AddWithValue("@p4", publisher_txtbox.Text);
            cmd.Parameters.AddWithValue("@p5", genre_txtbox.Text);
            cmd.Parameters.AddWithValue("@p6", id_txtbox.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Book information is updated.","",MessageBoxButtons.OK,MessageBoxIcon.Information);
            list();
            clean();
        }

        private void recycle_bttn_MouseEnter(object sender, EventArgs e)
        {
            recycle_bttn.BackColor = Color.Thistle;
        }

        private void recycle_bttn_MouseLeave(object sender, EventArgs e)
        {
            recycle_bttn.BackColor = Color.Transparent;
        }

        private void recycle_bttn_Click(object sender, EventArgs e)
        {
            RecycleBin fr = new RecycleBin();
            this.Hide();
            fr.ShowDialog();
        }

        private void exit_bttn_MouseEnter(object sender, EventArgs e)
        {
            exit_bttn.BackColor = Color.Thistle;
        }

        private void exit_bttn_MouseLeave(object sender, EventArgs e)
        {
            exit_bttn.BackColor = Color.Transparent;
        }

        private void exit_bttn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
