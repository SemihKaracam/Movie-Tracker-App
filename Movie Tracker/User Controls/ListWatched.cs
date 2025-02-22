﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movie_Tracker.User_Controls
{
    public partial class ListWatched : UserControl
    {
        public ListWatched()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-PO7LRD3\SQLEXPRESS01;Initial Catalog=DbMovieTracker;Integrated Security=True");

        private void FormTest_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string sqlQuery = "Select TableWatchedlist.mov_id,mov_poster from TableWatchedlist INNER JOIN TableMovie ON TableWatchedlist.mov_id = TableMovie.mov_id WHERE user_id = " + Program.userID;
                SqlCommand sqlCommand = new SqlCommand(sqlQuery, con);
                SqlDataReader sqlDR = sqlCommand.ExecuteReader();

                int x = 20;
                int y = 20;
                int width = 140;
                int height = 210;
                int i = 1;
                while (sqlDR.Read())
                {
                    string movId = sqlDR[0].ToString();
                    string imageLoc = sqlDR[1].ToString();
                    if (i % 5 == 0)
                    {
                        i = 1;
                        x = 20;
                        y += height + 20;
                    }
                    var picture = new PictureBox
                    {
                        Name = "pictureBox" + movId,
                        Size = new Size(width, height),
                        Location = new Point(x, y),
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Cursor = Cursors.Hand,
                        ImageLocation = imageLoc
                    };

                    string id = movId;

                    picture.Click += (s, e2) => navigateToMovie(s, e2, id);
                    this.Controls.Add(picture);
                    i++;
                    x += width + 20;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQL Query sirasinda hata olustu!" + ex.ToString());
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }

        private void navigateToMovie(object sender, EventArgs e, string id)
        {
            MoviePage uc = new MoviePage(Int16.Parse(id));
            var mainForm = Application.OpenForms.OfType<MainForm>().Single();
            mainForm.addUserControl(uc);
        }
    }
}
