namespace TriggeredDatabase
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.id_txtbox = new System.Windows.Forms.TextBox();
            this.name_txtbox = new System.Windows.Forms.TextBox();
            this.author_txtbox = new System.Windows.Forms.TextBox();
            this.page_txtbox = new System.Windows.Forms.TextBox();
            this.publisher_txtbox = new System.Windows.Forms.TextBox();
            this.genre_txtbox = new System.Windows.Forms.TextBox();
            this.add_bttn = new System.Windows.Forms.Button();
            this.delete_bttn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.count_lbl = new System.Windows.Forms.Label();
            this.update_bttn = new System.Windows.Forms.Button();
            this.clean_bttn = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.recycle_bttn = new System.Windows.Forms.Button();
            this.exit_bttn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clean_bttn);
            this.groupBox1.Controls.Add(this.update_bttn);
            this.groupBox1.Controls.Add(this.delete_bttn);
            this.groupBox1.Controls.Add(this.add_bttn);
            this.groupBox1.Controls.Add(this.genre_txtbox);
            this.groupBox1.Controls.Add(this.publisher_txtbox);
            this.groupBox1.Controls.Add(this.page_txtbox);
            this.groupBox1.Controls.Add(this.author_txtbox);
            this.groupBox1.Controls.Add(this.name_txtbox);
            this.groupBox1.Controls.Add(this.id_txtbox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(23, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 340);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Book Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Author: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Page: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Publisher: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Genre: ";
            // 
            // id_txtbox
            // 
            this.id_txtbox.Enabled = false;
            this.id_txtbox.Location = new System.Drawing.Point(113, 26);
            this.id_txtbox.Name = "id_txtbox";
            this.id_txtbox.Size = new System.Drawing.Size(215, 27);
            this.id_txtbox.TabIndex = 0;
            // 
            // name_txtbox
            // 
            this.name_txtbox.Location = new System.Drawing.Point(113, 65);
            this.name_txtbox.Name = "name_txtbox";
            this.name_txtbox.Size = new System.Drawing.Size(215, 27);
            this.name_txtbox.TabIndex = 1;
            // 
            // author_txtbox
            // 
            this.author_txtbox.Location = new System.Drawing.Point(113, 105);
            this.author_txtbox.Name = "author_txtbox";
            this.author_txtbox.Size = new System.Drawing.Size(215, 27);
            this.author_txtbox.TabIndex = 2;
            // 
            // page_txtbox
            // 
            this.page_txtbox.Location = new System.Drawing.Point(113, 144);
            this.page_txtbox.Name = "page_txtbox";
            this.page_txtbox.Size = new System.Drawing.Size(215, 27);
            this.page_txtbox.TabIndex = 3;
            // 
            // publisher_txtbox
            // 
            this.publisher_txtbox.Location = new System.Drawing.Point(113, 185);
            this.publisher_txtbox.Name = "publisher_txtbox";
            this.publisher_txtbox.Size = new System.Drawing.Size(215, 27);
            this.publisher_txtbox.TabIndex = 4;
            // 
            // genre_txtbox
            // 
            this.genre_txtbox.Location = new System.Drawing.Point(113, 226);
            this.genre_txtbox.Name = "genre_txtbox";
            this.genre_txtbox.Size = new System.Drawing.Size(215, 27);
            this.genre_txtbox.TabIndex = 5;
            // 
            // add_bttn
            // 
            this.add_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_bttn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.add_bttn.Location = new System.Drawing.Point(64, 263);
            this.add_bttn.Name = "add_bttn";
            this.add_bttn.Size = new System.Drawing.Size(117, 29);
            this.add_bttn.TabIndex = 6;
            this.add_bttn.Text = "Add";
            this.add_bttn.UseVisualStyleBackColor = true;
            this.add_bttn.Click += new System.EventHandler(this.add_bttn_Click);
            this.add_bttn.MouseEnter += new System.EventHandler(this.add_bttn_MouseEnter);
            this.add_bttn.MouseLeave += new System.EventHandler(this.add_bttn_MouseLeave);
            // 
            // delete_bttn
            // 
            this.delete_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_bttn.Location = new System.Drawing.Point(187, 298);
            this.delete_bttn.Name = "delete_bttn";
            this.delete_bttn.Size = new System.Drawing.Size(117, 29);
            this.delete_bttn.TabIndex = 7;
            this.delete_bttn.Text = "Delete";
            this.delete_bttn.UseVisualStyleBackColor = true;
            this.delete_bttn.Click += new System.EventHandler(this.delete_bttn_Click);
            this.delete_bttn.MouseEnter += new System.EventHandler(this.delete_bttn_MouseEnter);
            this.delete_bttn.MouseLeave += new System.EventHandler(this.delete_bttn_MouseLeave);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(397, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(602, 340);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(596, 314);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.count_lbl);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(23, 368);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(368, 50);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(103, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 19);
            this.label7.TabIndex = 7;
            this.label7.Text = "Book Count: ";
            // 
            // count_lbl
            // 
            this.count_lbl.AutoSize = true;
            this.count_lbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.count_lbl.Location = new System.Drawing.Point(223, 19);
            this.count_lbl.Name = "count_lbl";
            this.count_lbl.Size = new System.Drawing.Size(18, 19);
            this.count_lbl.TabIndex = 8;
            this.count_lbl.Text = "0";
            // 
            // update_bttn
            // 
            this.update_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_bttn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.update_bttn.Location = new System.Drawing.Point(187, 263);
            this.update_bttn.Name = "update_bttn";
            this.update_bttn.Size = new System.Drawing.Size(117, 29);
            this.update_bttn.TabIndex = 8;
            this.update_bttn.Text = "Update";
            this.update_bttn.UseVisualStyleBackColor = true;
            this.update_bttn.Click += new System.EventHandler(this.update_bttn_Click);
            this.update_bttn.MouseEnter += new System.EventHandler(this.update_bttn_MouseEnter);
            this.update_bttn.MouseLeave += new System.EventHandler(this.update_bttn_MouseLeave);
            // 
            // clean_bttn
            // 
            this.clean_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clean_bttn.Location = new System.Drawing.Point(64, 298);
            this.clean_bttn.Name = "clean_bttn";
            this.clean_bttn.Size = new System.Drawing.Size(117, 29);
            this.clean_bttn.TabIndex = 9;
            this.clean_bttn.Text = "Clean";
            this.clean_bttn.UseVisualStyleBackColor = true;
            this.clean_bttn.Click += new System.EventHandler(this.clean_bttn_Click);
            this.clean_bttn.MouseEnter += new System.EventHandler(this.clean_bttn_MouseEnter);
            this.clean_bttn.MouseLeave += new System.EventHandler(this.clean_bttn_MouseLeave);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.recycle_bttn);
            this.groupBox4.Location = new System.Drawing.Point(400, 368);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(599, 50);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // recycle_bttn
            // 
            this.recycle_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.recycle_bttn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.recycle_bttn.Location = new System.Drawing.Point(6, 15);
            this.recycle_bttn.Name = "recycle_bttn";
            this.recycle_bttn.Size = new System.Drawing.Size(587, 29);
            this.recycle_bttn.TabIndex = 8;
            this.recycle_bttn.Text = "Recycle Bin";
            this.recycle_bttn.UseVisualStyleBackColor = true;
            this.recycle_bttn.Click += new System.EventHandler(this.recycle_bttn_Click);
            this.recycle_bttn.MouseEnter += new System.EventHandler(this.recycle_bttn_MouseEnter);
            this.recycle_bttn.MouseLeave += new System.EventHandler(this.recycle_bttn_MouseLeave);
            // 
            // exit_bttn
            // 
            this.exit_bttn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exit_bttn.BackgroundImage")));
            this.exit_bttn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exit_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_bttn.Location = new System.Drawing.Point(998, 0);
            this.exit_bttn.Name = "exit_bttn";
            this.exit_bttn.Size = new System.Drawing.Size(27, 27);
            this.exit_bttn.TabIndex = 9;
            this.exit_bttn.UseVisualStyleBackColor = true;
            this.exit_bttn.Click += new System.EventHandler(this.exit_bttn_Click);
            this.exit_bttn.MouseEnter += new System.EventHandler(this.exit_bttn_MouseEnter);
            this.exit_bttn.MouseLeave += new System.EventHandler(this.exit_bttn_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(1024, 446);
            this.Controls.Add(this.exit_bttn);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Back Up Database";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button delete_bttn;
        private System.Windows.Forms.Button add_bttn;
        private System.Windows.Forms.TextBox genre_txtbox;
        private System.Windows.Forms.TextBox publisher_txtbox;
        private System.Windows.Forms.TextBox page_txtbox;
        private System.Windows.Forms.TextBox author_txtbox;
        private System.Windows.Forms.TextBox name_txtbox;
        private System.Windows.Forms.TextBox id_txtbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label count_lbl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button update_bttn;
        private System.Windows.Forms.Button clean_bttn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button recycle_bttn;
        private System.Windows.Forms.Button exit_bttn;
    }
}

