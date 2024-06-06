namespace MovieInfo
{
    partial class ratings
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.movieID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.year = new System.Windows.Forms.TextBox();
            this.onebtn = new System.Windows.Forms.Button();
            this.twobtn = new System.Windows.Forms.Button();
            this.threebtn = new System.Windows.Forms.Button();
            this.fourbtn = new System.Windows.Forms.Button();
            this.fivebtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(366, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(422, 136);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(363, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Movie to Rate";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(369, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "Movie ID";
            // 
            // movieID
            // 
            this.movieID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.movieID.Location = new System.Drawing.Point(372, 245);
            this.movieID.Name = "movieID";
            this.movieID.Size = new System.Drawing.Size(63, 20);
            this.movieID.TabIndex = 38;
            this.movieID.TextChanged += new System.EventHandler(this.movieID_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(731, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Year";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(452, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Title";
            // 
            // title
            // 
            this.title.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.title.Location = new System.Drawing.Point(455, 245);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(259, 20);
            this.title.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(373, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Rate Movie";
            // 
            // year
            // 
            this.year.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.year.Location = new System.Drawing.Point(734, 245);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(54, 20);
            this.year.TabIndex = 41;
            // 
            // onebtn
            // 
            this.onebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.onebtn.Location = new System.Drawing.Point(429, 329);
            this.onebtn.Name = "onebtn";
            this.onebtn.Size = new System.Drawing.Size(43, 43);
            this.onebtn.TabIndex = 42;
            this.onebtn.Text = "1";
            this.onebtn.UseVisualStyleBackColor = false;
            this.onebtn.Click += new System.EventHandler(this.onebtn_Click);
            // 
            // twobtn
            // 
            this.twobtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.twobtn.Location = new System.Drawing.Point(500, 329);
            this.twobtn.Name = "twobtn";
            this.twobtn.Size = new System.Drawing.Size(43, 43);
            this.twobtn.TabIndex = 43;
            this.twobtn.Text = "2";
            this.twobtn.UseVisualStyleBackColor = false;
            this.twobtn.Click += new System.EventHandler(this.twobtn_Click);
            // 
            // threebtn
            // 
            this.threebtn.BackColor = System.Drawing.Color.Khaki;
            this.threebtn.Location = new System.Drawing.Point(571, 329);
            this.threebtn.Name = "threebtn";
            this.threebtn.Size = new System.Drawing.Size(43, 43);
            this.threebtn.TabIndex = 44;
            this.threebtn.Text = "3";
            this.threebtn.UseVisualStyleBackColor = false;
            this.threebtn.Click += new System.EventHandler(this.threebtn_Click);
            // 
            // fourbtn
            // 
            this.fourbtn.BackColor = System.Drawing.Color.Yellow;
            this.fourbtn.Location = new System.Drawing.Point(639, 329);
            this.fourbtn.Name = "fourbtn";
            this.fourbtn.Size = new System.Drawing.Size(43, 43);
            this.fourbtn.TabIndex = 45;
            this.fourbtn.Text = "4";
            this.fourbtn.UseVisualStyleBackColor = false;
            this.fourbtn.Click += new System.EventHandler(this.fourbtn_Click);
            // 
            // fivebtn
            // 
            this.fivebtn.BackColor = System.Drawing.Color.Gold;
            this.fivebtn.Location = new System.Drawing.Point(709, 329);
            this.fivebtn.Name = "fivebtn";
            this.fivebtn.Size = new System.Drawing.Size(43, 43);
            this.fivebtn.TabIndex = 46;
            this.fivebtn.Text = "5";
            this.fivebtn.UseVisualStyleBackColor = false;
            this.fivebtn.Click += new System.EventHandler(this.fivebtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 47;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.backToolStripMenuItem.Text = "Log Out";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // ratings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = global::MovieInfo.Properties.Resources.Sixty_and_Me_Film_Review_Fonda_and_Tomlin_in_Moving_On;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.fivebtn);
            this.Controls.Add(this.fourbtn);
            this.Controls.Add(this.threebtn);
            this.Controls.Add(this.twobtn);
            this.Controls.Add(this.onebtn);
            this.Controls.Add(this.year);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.movieID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.title);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "ratings";
            this.Text = "MovieInfo | Ratings";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox movieID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox year;
        private System.Windows.Forms.Button onebtn;
        private System.Windows.Forms.Button twobtn;
        private System.Windows.Forms.Button threebtn;
        private System.Windows.Forms.Button fourbtn;
        private System.Windows.Forms.Button fivebtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
    }
}