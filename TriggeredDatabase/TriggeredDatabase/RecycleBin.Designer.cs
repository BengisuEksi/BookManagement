namespace TriggeredDatabase
{
    partial class RecycleBin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecycleBin));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mainpage_bttn = new System.Windows.Forms.Button();
            this.exit_bttn = new System.Windows.Forms.Button();
            this.save_bttn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.id_txtbox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(736, 264);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Deleted Books";
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
            this.dataGridView1.Size = new System.Drawing.Size(730, 238);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // mainpage_bttn
            // 
            this.mainpage_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainpage_bttn.Location = new System.Drawing.Point(374, 337);
            this.mainpage_bttn.Name = "mainpage_bttn";
            this.mainpage_bttn.Size = new System.Drawing.Size(331, 30);
            this.mainpage_bttn.TabIndex = 1;
            this.mainpage_bttn.Text = "Return to the Main Page";
            this.mainpage_bttn.UseVisualStyleBackColor = true;
            this.mainpage_bttn.Click += new System.EventHandler(this.mainpage_bttn_Click);
            this.mainpage_bttn.MouseEnter += new System.EventHandler(this.mainpage_bttn_MouseEnter);
            this.mainpage_bttn.MouseLeave += new System.EventHandler(this.mainpage_bttn_MouseLeave);
            // 
            // exit_bttn
            // 
            this.exit_bttn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exit_bttn.BackgroundImage")));
            this.exit_bttn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exit_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_bttn.Location = new System.Drawing.Point(733, 0);
            this.exit_bttn.Name = "exit_bttn";
            this.exit_bttn.Size = new System.Drawing.Size(27, 27);
            this.exit_bttn.TabIndex = 10;
            this.exit_bttn.UseVisualStyleBackColor = true;
            this.exit_bttn.Click += new System.EventHandler(this.exit_bttn_Click);
            this.exit_bttn.MouseEnter += new System.EventHandler(this.exit_bttn_MouseEnter);
            this.exit_bttn.MouseLeave += new System.EventHandler(this.exit_bttn_MouseLeave);
            // 
            // save_bttn
            // 
            this.save_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_bttn.Location = new System.Drawing.Point(374, 303);
            this.save_bttn.Name = "save_bttn";
            this.save_bttn.Size = new System.Drawing.Size(331, 30);
            this.save_bttn.TabIndex = 11;
            this.save_bttn.Text = "Save the Selected Book";
            this.save_bttn.UseVisualStyleBackColor = true;
            this.save_bttn.Click += new System.EventHandler(this.save_bttn_Click);
            this.save_bttn.MouseEnter += new System.EventHandler(this.save_bttn_MouseEnter);
            this.save_bttn.MouseLeave += new System.EventHandler(this.save_bttn_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "ID: ";
            // 
            // id_txtbox
            // 
            this.id_txtbox.Enabled = false;
            this.id_txtbox.Location = new System.Drawing.Point(132, 324);
            this.id_txtbox.Name = "id_txtbox";
            this.id_txtbox.Size = new System.Drawing.Size(200, 27);
            this.id_txtbox.TabIndex = 13;
            // 
            // RecycleBin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(760, 379);
            this.Controls.Add(this.id_txtbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.save_bttn);
            this.Controls.Add(this.exit_bttn);
            this.Controls.Add(this.mainpage_bttn);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "RecycleBin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RecycleBin";
            this.Load += new System.EventHandler(this.RecycleBin_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button mainpage_bttn;
        private System.Windows.Forms.Button exit_bttn;
        private System.Windows.Forms.Button save_bttn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox id_txtbox;
    }
}