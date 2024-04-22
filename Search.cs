using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.ComponentModel.DataAnnotations;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Final_Eda.Authenticate;
using Final_Eda;

namespace FinalEda
{
    public partial class Search : Form
    {
        private Users authenticatedUser;

        public Search()
        {
            authenticatedUser = User;
            InitializeComponent();

            hi_user.Text = $"Welcome: {authenticatedUser.first_name}";
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAB109PC02\SQLEXPRESS; Initial Catalog=GoodWatch; Integrated Security=True;"))
            {
                sqlCon.Open();

                string query = "SELECT * FROM Movies WHERE 1 = 1";


                if (category.SelectedItem != null)
                {
                    string query2 = "SELECT * FROM Movies WHERE @category LIKE @search_box";

                    SqlCommand cmd = new SqlCommand(query2, sqlCon);

                    cmd.Parameters.Add(new SqlParameter("@category", category.SelectedItem.ToString()));
                    cmd.Parameters.Add(new SqlParameter("@search_box", search_box.Text));

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        dataGridView1.DataSource = ds.Tables.Count > 0 ? ds.Tables[0] : null;
                    }
                }
            }
        }


        private void add_watchlist_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAB109PC02\SQLEXPRESS; Initial Catalog=GoodWatch; Integrated Security=True;"))
            {
                sqlCon.Open();

                if (movieID1.Text != null)
                {
                    string query3 = "UPDATE Watchlist SET status = 'Watching' WHERE movieID=@movieID1";

                    SqlCommand updateStatusCmd = new SqlCommand(query3, sqlCon);
                    updateStatusCmd.Parameters.AddWithValue("@movieID1", movieID1.Text);
                    updateStatusCmd.ExecuteNonQuery();

                    MessageBox.Show("Added Succesfully!");
                }
                else
                {
                    MessageBox.Show("Failed.");
                }

            }
        }

        private void add_watched_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAB109PC02\SQLEXPRESS; Initial Catalog=GoodWatch; Integrated Security=True;"))
            {
                sqlCon.Open();

                if (movieID2.Text != null)
                {
                    string query4 = "UPDATE Watched SET status = 'Watched' WHERE movieID=@movieID2";

                    SqlCommand updateStatusCmd = new SqlCommand(query4, sqlCon);
                    updateStatusCmd.Parameters.AddWithValue("@movieID2", movieID2.Text);
                    updateStatusCmd.ExecuteNonQuery();

                    MessageBox.Show("Added Succesfully!");
                }
                else
                {
                    MessageBox.Show("Failed.");
                }

            }
        }
        private void go_watchlist_Click(object sender, EventArgs e)
        {
            this.Hide();
            Watchlist Watchlist = new Watchlist();
            Watchlist.ShowDialog();
        }

        private void go_watched_Click(object sender, EventArgs e)
        {
            this.Hide();
            Watched Watched = new Watched();
            Watched.ShowDialog();
        }
    }
}

