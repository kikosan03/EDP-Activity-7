namespace MovieInfo
{
    partial class Dashboard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelSubtitle = new System.Windows.Forms.Label();
            this.labelMoviesCount = new System.Windows.Forms.Label();
            this.labelActorsCount = new System.Windows.Forms.Label();
            this.labelDirectorsCount = new System.Windows.Forms.Label();
            this.labelGenresCount = new System.Windows.Forms.Label();
            this.btnDisplayMovie = new System.Windows.Forms.Button();
            this.btnDisplayActor = new System.Windows.Forms.Button();
            this.btnDisplayDirector = new System.Windows.Forms.Button();
            this.btnDisplayGenre = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.totalMovies = new System.Windows.Forms.Label();
            this.TotalActors = new System.Windows.Forms.Label();
            this.totalDirectors = new System.Windows.Forms.Label();
            this.totalGenres = new System.Windows.Forms.Label();
            this.reportbtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addmoviebtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.managebtn = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.labelTitle.ForeColor = System.Drawing.Color.Black;
            this.labelTitle.Location = new System.Drawing.Point(12, 24);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(165, 39);
            this.labelTitle.TabIndex = 12;
            this.labelTitle.Text = "MovieInfo";
            // 
            // labelSubtitle
            // 
            this.labelSubtitle.AutoSize = true;
            this.labelSubtitle.BackColor = System.Drawing.Color.Transparent;
            this.labelSubtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubtitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelSubtitle.Location = new System.Drawing.Point(183, 39);
            this.labelSubtitle.Name = "labelSubtitle";
            this.labelSubtitle.Size = new System.Drawing.Size(122, 20);
            this.labelSubtitle.TabIndex = 22;
            this.labelSubtitle.Text = "DASHBOARD";
            // 
            // labelMoviesCount
            // 
            this.labelMoviesCount.AutoSize = true;
            this.labelMoviesCount.BackColor = System.Drawing.Color.Transparent;
            this.labelMoviesCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelMoviesCount.Location = new System.Drawing.Point(309, 93);
            this.labelMoviesCount.Name = "labelMoviesCount";
            this.labelMoviesCount.Size = new System.Drawing.Size(114, 20);
            this.labelMoviesCount.TabIndex = 23;
            this.labelMoviesCount.Text = "Total Movies:";
            // 
            // labelActorsCount
            // 
            this.labelActorsCount.AutoSize = true;
            this.labelActorsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelActorsCount.Location = new System.Drawing.Point(309, 123);
            this.labelActorsCount.Name = "labelActorsCount";
            this.labelActorsCount.Size = new System.Drawing.Size(111, 20);
            this.labelActorsCount.TabIndex = 24;
            this.labelActorsCount.Text = "Total Actors:";
            // 
            // labelDirectorsCount
            // 
            this.labelDirectorsCount.AutoSize = true;
            this.labelDirectorsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelDirectorsCount.Location = new System.Drawing.Point(309, 153);
            this.labelDirectorsCount.Name = "labelDirectorsCount";
            this.labelDirectorsCount.Size = new System.Drawing.Size(132, 20);
            this.labelDirectorsCount.TabIndex = 25;
            this.labelDirectorsCount.Text = "Total Directors:";
            // 
            // labelGenresCount
            // 
            this.labelGenresCount.AutoSize = true;
            this.labelGenresCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelGenresCount.Location = new System.Drawing.Point(309, 183);
            this.labelGenresCount.Name = "labelGenresCount";
            this.labelGenresCount.Size = new System.Drawing.Size(123, 20);
            this.labelGenresCount.TabIndex = 26;
            this.labelGenresCount.Text = "Total Genres: ";
            // 
            // btnDisplayMovie
            // 
            this.btnDisplayMovie.Location = new System.Drawing.Point(207, 242);
            this.btnDisplayMovie.Name = "btnDisplayMovie";
            this.btnDisplayMovie.Size = new System.Drawing.Size(100, 23);
            this.btnDisplayMovie.TabIndex = 28;
            this.btnDisplayMovie.Text = "Display Movie";
            this.btnDisplayMovie.UseVisualStyleBackColor = true;
            this.btnDisplayMovie.Click += new System.EventHandler(this.btnDisplayMovie_Click);
            // 
            // btnDisplayActor
            // 
            this.btnDisplayActor.Location = new System.Drawing.Point(207, 272);
            this.btnDisplayActor.Name = "btnDisplayActor";
            this.btnDisplayActor.Size = new System.Drawing.Size(100, 23);
            this.btnDisplayActor.TabIndex = 29;
            this.btnDisplayActor.Text = "Display Actor";
            this.btnDisplayActor.UseVisualStyleBackColor = true;
            this.btnDisplayActor.Click += new System.EventHandler(this.btnDisplayActor_Click);
            // 
            // btnDisplayDirector
            // 
            this.btnDisplayDirector.Location = new System.Drawing.Point(207, 302);
            this.btnDisplayDirector.Name = "btnDisplayDirector";
            this.btnDisplayDirector.Size = new System.Drawing.Size(100, 23);
            this.btnDisplayDirector.TabIndex = 30;
            this.btnDisplayDirector.Text = "Display Director";
            this.btnDisplayDirector.UseVisualStyleBackColor = true;
            this.btnDisplayDirector.Click += new System.EventHandler(this.btnDisplayDirector_Click);
            // 
            // btnDisplayGenre
            // 
            this.btnDisplayGenre.Location = new System.Drawing.Point(207, 332);
            this.btnDisplayGenre.Name = "btnDisplayGenre";
            this.btnDisplayGenre.Size = new System.Drawing.Size(100, 23);
            this.btnDisplayGenre.TabIndex = 31;
            this.btnDisplayGenre.Text = "Display Genre";
            this.btnDisplayGenre.UseVisualStyleBackColor = true;
            this.btnDisplayGenre.Click += new System.EventHandler(this.btnDisplayGenre_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(313, 219);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(460, 198);
            this.dataGridView1.TabIndex = 34;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(429, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 35;
            // 
            // totalMovies
            // 
            this.totalMovies.AutoSize = true;
            this.totalMovies.BackColor = System.Drawing.Color.Transparent;
            this.totalMovies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.totalMovies.Location = new System.Drawing.Point(435, 93);
            this.totalMovies.Name = "totalMovies";
            this.totalMovies.Size = new System.Drawing.Size(19, 20);
            this.totalMovies.TabIndex = 36;
            this.totalMovies.Text = "#";
            this.totalMovies.Click += new System.EventHandler(this.totalMovies_Click);
            // 
            // TotalActors
            // 
            this.TotalActors.AutoSize = true;
            this.TotalActors.BackColor = System.Drawing.Color.Transparent;
            this.TotalActors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.TotalActors.Location = new System.Drawing.Point(435, 123);
            this.TotalActors.Name = "TotalActors";
            this.TotalActors.Size = new System.Drawing.Size(19, 20);
            this.TotalActors.TabIndex = 37;
            this.TotalActors.Text = "#";
            this.TotalActors.Click += new System.EventHandler(this.TotalActors_Click);
            // 
            // totalDirectors
            // 
            this.totalDirectors.AutoSize = true;
            this.totalDirectors.BackColor = System.Drawing.Color.Transparent;
            this.totalDirectors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.totalDirectors.Location = new System.Drawing.Point(435, 153);
            this.totalDirectors.Name = "totalDirectors";
            this.totalDirectors.Size = new System.Drawing.Size(19, 20);
            this.totalDirectors.TabIndex = 38;
            this.totalDirectors.Text = "#";
            this.totalDirectors.Click += new System.EventHandler(this.totalDirectors_Click);
            // 
            // totalGenres
            // 
            this.totalGenres.AutoSize = true;
            this.totalGenres.BackColor = System.Drawing.Color.Transparent;
            this.totalGenres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.totalGenres.Location = new System.Drawing.Point(435, 183);
            this.totalGenres.Name = "totalGenres";
            this.totalGenres.Size = new System.Drawing.Size(19, 20);
            this.totalGenres.TabIndex = 39;
            this.totalGenres.Text = "#";
            this.totalGenres.Click += new System.EventHandler(this.totalGenres_Click);
            // 
            // reportbtn
            // 
            this.reportbtn.Location = new System.Drawing.Point(209, 361);
            this.reportbtn.Name = "reportbtn";
            this.reportbtn.Size = new System.Drawing.Size(100, 23);
            this.reportbtn.TabIndex = 40;
            this.reportbtn.Text = "Generate Report";
            this.reportbtn.UseVisualStyleBackColor = true;
            this.reportbtn.Click += new System.EventHandler(this.reportbtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 41;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.backToolStripMenuItem.Text = "Log Out";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // addmoviebtn
            // 
            this.addmoviebtn.Location = new System.Drawing.Point(563, 190);
            this.addmoviebtn.Name = "addmoviebtn";
            this.addmoviebtn.Size = new System.Drawing.Size(100, 23);
            this.addmoviebtn.TabIndex = 42;
            this.addmoviebtn.Text = "Add | Edit Movie";
            this.addmoviebtn.UseVisualStyleBackColor = true;
            this.addmoviebtn.Click += new System.EventHandler(this.addmoviebtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.Location = new System.Drawing.Point(669, 190);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(100, 23);
            this.deletebtn.TabIndex = 43;
            this.deletebtn.Text = "Delete Movie";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // managebtn
            // 
            this.managebtn.Location = new System.Drawing.Point(209, 390);
            this.managebtn.Name = "managebtn";
            this.managebtn.Size = new System.Drawing.Size(100, 23);
            this.managebtn.TabIndex = 44;
            this.managebtn.Text = "Manage User";
            this.managebtn.UseVisualStyleBackColor = true;
            this.managebtn.Click += new System.EventHandler(this.managebtn_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(354, 46);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(309, 20);
            this.textBoxSearch.TabIndex = 32;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(673, 46);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 23);
            this.btnSearch.TabIndex = 33;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::MovieInfo.Properties.Resources.Sixty_and_Me_Film_Review_Fonda_and_Tomlin_in_Moving_On;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.managebtn);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.addmoviebtn);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.reportbtn);
            this.Controls.Add(this.totalGenres);
            this.Controls.Add(this.totalDirectors);
            this.Controls.Add(this.TotalActors);
            this.Controls.Add(this.totalMovies);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.btnDisplayGenre);
            this.Controls.Add(this.btnDisplayDirector);
            this.Controls.Add(this.btnDisplayActor);
            this.Controls.Add(this.btnDisplayMovie);
            this.Controls.Add(this.labelGenresCount);
            this.Controls.Add(this.labelDirectorsCount);
            this.Controls.Add(this.labelActorsCount);
            this.Controls.Add(this.labelMoviesCount);
            this.Controls.Add(this.labelSubtitle);
            this.Controls.Add(this.labelTitle);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard";
            this.RightToLeftLayout = true;
            this.Text = "MovieInfo | Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelSubtitle;
        private System.Windows.Forms.Label labelMoviesCount;
        private System.Windows.Forms.Label labelActorsCount;
        private System.Windows.Forms.Label labelDirectorsCount;
        private System.Windows.Forms.Label labelGenresCount;
        private System.Windows.Forms.Button btnDisplayMovie;
        private System.Windows.Forms.Button btnDisplayActor;
        private System.Windows.Forms.Button btnDisplayDirector;
        private System.Windows.Forms.Button btnDisplayGenre;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalMovies;
        private System.Windows.Forms.Label TotalActors;
        private System.Windows.Forms.Label totalDirectors;
        private System.Windows.Forms.Label totalGenres;
        private System.Windows.Forms.Button reportbtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button addmoviebtn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button managebtn;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button btnSearch;
    }
}
