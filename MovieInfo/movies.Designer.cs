namespace MovieInfo
{
    partial class movies
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(movies));
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.TextBox();
            this.updatebtn = new System.Windows.Forms.Button();
            this.Addnewbtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.movieID = new System.Windows.Forms.TextBox();
            this.year = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plot = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.budget = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.earning = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.duration = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(351, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "Movie ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(12, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(230, 25);
            this.label6.TabIndex = 41;
            this.label6.Text = "Add | Update Movies";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(570, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Release Year";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(434, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Title";
            // 
            // title
            // 
            this.title.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.title.Location = new System.Drawing.Point(437, 65);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(111, 20);
            this.title.TabIndex = 37;
            // 
            // updatebtn
            // 
            this.updatebtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.updatebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.updatebtn.ForeColor = System.Drawing.Color.White;
            this.updatebtn.Location = new System.Drawing.Point(690, 198);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.updatebtn.Size = new System.Drawing.Size(98, 32);
            this.updatebtn.TabIndex = 36;
            this.updatebtn.Text = "Update";
            this.updatebtn.UseVisualStyleBackColor = false;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // Addnewbtn
            // 
            this.Addnewbtn.BackColor = System.Drawing.Color.ForestGreen;
            this.Addnewbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Addnewbtn.ForeColor = System.Drawing.Color.White;
            this.Addnewbtn.Location = new System.Drawing.Point(531, 198);
            this.Addnewbtn.Name = "Addnewbtn";
            this.Addnewbtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Addnewbtn.Size = new System.Drawing.Size(142, 32);
            this.Addnewbtn.TabIndex = 35;
            this.Addnewbtn.Text = "Add New Movies";
            this.Addnewbtn.UseVisualStyleBackColor = false;
            this.Addnewbtn.Click += new System.EventHandler(this.Addnewbtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(288, 236);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(500, 202);
            this.dataGridView1.TabIndex = 34;
            // 
            // movieID
            // 
            this.movieID.Location = new System.Drawing.Point(354, 65);
            this.movieID.Name = "movieID";
            this.movieID.Size = new System.Drawing.Size(63, 20);
            this.movieID.TabIndex = 45;
            // 
            // year
            // 
            this.year.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.year.Location = new System.Drawing.Point(573, 65);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(111, 20);
            this.year.TabIndex = 46;
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
            this.backToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.backToolStripMenuItem.Text = "Return";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // plot
            // 
            this.plot.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.plot.Location = new System.Drawing.Point(354, 118);
            this.plot.Name = "plot";
            this.plot.Size = new System.Drawing.Size(434, 20);
            this.plot.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(351, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "Plot Summary";
            // 
            // budget
            // 
            this.budget.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.budget.Location = new System.Drawing.Point(354, 167);
            this.budget.Name = "budget";
            this.budget.Size = new System.Drawing.Size(148, 20);
            this.budget.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(351, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "Budget";
            // 
            // earning
            // 
            this.earning.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.earning.Location = new System.Drawing.Point(531, 167);
            this.earning.Name = "earning";
            this.earning.Size = new System.Drawing.Size(153, 20);
            this.earning.TabIndex = 53;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(528, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 13);
            this.label8.TabIndex = 52;
            this.label8.Text = "Box Office Earnings";
            // 
            // duration
            // 
            this.duration.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.duration.Location = new System.Drawing.Point(706, 65);
            this.duration.Name = "duration";
            this.duration.Size = new System.Drawing.Size(82, 20);
            this.duration.TabIndex = 55;
            this.duration.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(703, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 54;
            this.label4.Text = "Duration";
            // 
            // movies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MovieInfo.Properties.Resources.Sixty_and_Me_Film_Review_Fonda_and_Tomlin_in_Moving_On;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.duration);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.earning);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.budget);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.plot);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.year);
            this.Controls.Add(this.movieID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.title);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.Addnewbtn);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "movies";
            this.Text = "MovieInfo | Movies";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button Addnewbtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox movieID;
        private System.Windows.Forms.TextBox year;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.TextBox plot;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox budget;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox earning;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox duration;
        private System.Windows.Forms.Label label4;
    }
}