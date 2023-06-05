namespace Movie_Tracker.User_Controls
{
    partial class MoviePage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.moviePoster = new System.Windows.Forms.PictureBox();
            this.movieDesc = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.movieLength = new System.Windows.Forms.TextBox();
            this.movieUserWatched = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.movieName = new System.Windows.Forms.Label();
            this.movieRating = new System.Windows.Forms.Label();
            this.movieReviewCount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.genresTextBox = new System.Windows.Forms.RichTextBox();
            this.flwPanelGenres = new System.Windows.Forms.FlowLayoutPanel();
            this.movieUserWatchlist = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.moviePoster)).BeginInit();
            this.SuspendLayout();
            // 
            // moviePoster
            // 
            this.moviePoster.Location = new System.Drawing.Point(22, 27);
            this.moviePoster.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.moviePoster.Name = "moviePoster";
            this.moviePoster.Size = new System.Drawing.Size(160, 280);
            this.moviePoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.moviePoster.TabIndex = 1;
            this.moviePoster.TabStop = false;
            // 
            // movieDesc
            // 
            this.movieDesc.BackColor = System.Drawing.SystemColors.Control;
            this.movieDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.movieDesc.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.movieDesc.Location = new System.Drawing.Point(216, 81);
            this.movieDesc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.movieDesc.Name = "movieDesc";
            this.movieDesc.ReadOnly = true;
            this.movieDesc.Size = new System.Drawing.Size(367, 226);
            this.movieDesc.TabIndex = 2;
            this.movieDesc.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(642, -39);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(570, 27);
            this.textBox1.TabIndex = 4;
            // 
            // movieLength
            // 
            this.movieLength.BackColor = System.Drawing.SystemColors.Control;
            this.movieLength.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.movieLength.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.movieLength.Location = new System.Drawing.Point(22, 315);
            this.movieLength.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.movieLength.Name = "movieLength";
            this.movieLength.ReadOnly = true;
            this.movieLength.Size = new System.Drawing.Size(160, 20);
            this.movieLength.TabIndex = 5;
            this.movieLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // movieUserWatched
            // 
            this.movieUserWatched.Appearance = System.Windows.Forms.Appearance.Button;
            this.movieUserWatched.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.movieUserWatched.FlatAppearance.BorderSize = 0;
            this.movieUserWatched.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.movieUserWatched.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.movieUserWatched.ForeColor = System.Drawing.Color.White;
            this.movieUserWatched.Image = global::Movie_Tracker.Resource1.icons8_eye_26px_1;
            this.movieUserWatched.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.movieUserWatched.Location = new System.Drawing.Point(628, 81);
            this.movieUserWatched.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.movieUserWatched.Name = "movieUserWatched";
            this.movieUserWatched.Size = new System.Drawing.Size(137, 35);
            this.movieUserWatched.TabIndex = 6;
            this.movieUserWatched.Text = "         WATCHED ";
            this.movieUserWatched.UseVisualStyleBackColor = false;
            this.movieUserWatched.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::Movie_Tracker.Resource1.icons8_comments_26px_2;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(628, 167);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 45);
            this.button1.TabIndex = 9;
            this.button1.Text = "         REVIEW";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(640, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "See all reviews";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // movieName
            // 
            this.movieName.AutoSize = true;
            this.movieName.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.movieName.Location = new System.Drawing.Point(205, 27);
            this.movieName.Name = "movieName";
            this.movieName.Size = new System.Drawing.Size(96, 37);
            this.movieName.TabIndex = 22;
            this.movieName.Text = "label1";
            // 
            // movieRating
            // 
            this.movieRating.AutoSize = true;
            this.movieRating.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.movieRating.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.movieRating.Location = new System.Drawing.Point(628, 304);
            this.movieRating.Name = "movieRating";
            this.movieRating.Size = new System.Drawing.Size(142, 31);
            this.movieRating.TabIndex = 23;
            this.movieRating.Text = "Rating: 5.55";
            // 
            // movieReviewCount
            // 
            this.movieReviewCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.movieReviewCount.Location = new System.Drawing.Point(640, 280);
            this.movieReviewCount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.movieReviewCount.Name = "movieReviewCount";
            this.movieReviewCount.ReadOnly = true;
            this.movieReviewCount.Size = new System.Drawing.Size(114, 20);
            this.movieReviewCount.TabIndex = 24;
            this.movieReviewCount.Text = "10 total reviews";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(22, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 32);
            this.label1.TabIndex = 25;
            this.label1.Text = "Genres:";
            // 
            // genresTextBox
            // 
            this.genresTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.genresTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.genresTextBox.Location = new System.Drawing.Point(119, 375);
            this.genresTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.genresTextBox.Name = "genresTextBox";
            this.genresTextBox.ReadOnly = true;
            this.genresTextBox.Size = new System.Drawing.Size(464, 33);
            this.genresTextBox.TabIndex = 26;
            this.genresTextBox.Text = "";
            // 
            // flwPanelGenres
            // 
            this.flwPanelGenres.Location = new System.Drawing.Point(22, 387);
            this.flwPanelGenres.Name = "flwPanelGenres";
            this.flwPanelGenres.Size = new System.Drawing.Size(519, 61);
            this.flwPanelGenres.TabIndex = 27;
            // 
            // movieUserWatchlist
            // 
            this.movieUserWatchlist.Appearance = System.Windows.Forms.Appearance.Button;
            this.movieUserWatchlist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.movieUserWatchlist.FlatAppearance.BorderSize = 0;
            this.movieUserWatchlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.movieUserWatchlist.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.movieUserWatchlist.ForeColor = System.Drawing.Color.White;
            this.movieUserWatchlist.Image = global::Movie_Tracker.Resource1.icons8_list_26px;
            this.movieUserWatchlist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.movieUserWatchlist.Location = new System.Drawing.Point(628, 124);
            this.movieUserWatchlist.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.movieUserWatchlist.Name = "movieUserWatchlist";
            this.movieUserWatchlist.Size = new System.Drawing.Size(137, 35);
            this.movieUserWatchlist.TabIndex = 7;
            this.movieUserWatchlist.Text = "         WATCHLIST";
            this.movieUserWatchlist.UseVisualStyleBackColor = false;
            this.movieUserWatchlist.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // MoviePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.movieUserWatchlist);
            this.Controls.Add(this.flwPanelGenres);
            this.Controls.Add(this.genresTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.movieReviewCount);
            this.Controls.Add(this.movieRating);
            this.Controls.Add(this.movieName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.movieUserWatched);
            this.Controls.Add(this.movieLength);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.movieDesc);
            this.Controls.Add(this.moviePoster);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MoviePage";
            this.Size = new System.Drawing.Size(800, 544);
            this.Load += new System.EventHandler(this.MoviePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.moviePoster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox moviePoster;
        private RichTextBox movieDesc;
        private TextBox textBox1;
        private TextBox movieLength;
        private CheckBox movieUserWatched;
        private Button button1;
        private Label label4;
        private Label movieName;
        private Label movieRating;
        private TextBox movieReviewCount;
        private Label label1;
        private RichTextBox genresTextBox;
        private FlowLayoutPanel flwPanelGenres;
        private CheckBox movieUserWatchlist;
    }
}
