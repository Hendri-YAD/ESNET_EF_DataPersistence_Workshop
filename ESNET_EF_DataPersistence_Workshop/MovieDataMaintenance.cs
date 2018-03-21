using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESNET_EF_DataPersistence_Workshop
{
    public partial class MovieDataMaintenance : Form
    {
        List<Movie> movieList;
        Movie currMovie;

        DafestyEntities context;

        public MovieDataMaintenance()
        {
            InitializeComponent();

            context = new DafestyEntities();
            movieList = context.Movies.ToList();
            

        }

        private void btn_load_Click(object sender, EventArgs e)
        {

            if(tb_videoCode.Text != "")
            {
                currMovie = context.Movies.
                    Where(x => x.VideoCode.ToString() == tb_videoCode.Text).First();

                tb_movieTitle.Text = currMovie.MovieTitle;
                tb_genre.Text = currMovie.Genre;
                tb_rentalCost.Text = currMovie.RentalCost.ToString();

                btn_update.Enabled = true;
                btn_delete.Enabled = true;
            }
            else if(tb_videoCode.Text == "")
            {
                tb_movieTitle.Text = "";
                tb_genre.Text = "";
                tb_rentalCost.Text = "";

                btn_update.Enabled = false;
                btn_delete.Enabled = false;

            }




        }

        private void btn_next_Click(object sender, EventArgs e)
        {            
            Movie current = context.Movies.
                Where(x => x.VideoCode.ToString() == tb_videoCode.Text).First();

            Movie last = movieList.Last();

            if (current != last)
            {
                Movie m = movieList.SkipWhile(x => !x.Equals(current)).
                Skip(1).First();

                tb_videoCode.Text = m.VideoCode.ToString();
                tb_movieTitle.Text = m.MovieTitle;
                tb_genre.Text = m.Genre;
                tb_rentalCost.Text = m.RentalCost.ToString();
            }

            
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            Movie current = context.Movies.
                Where(x => x.VideoCode.ToString() == tb_videoCode.Text).First();

            Movie first = movieList.First();

            if(first != current)
            {
                Movie m = movieList.TakeWhile(x => !x.Equals(current)).
                Last();

                tb_videoCode.Text = m.VideoCode.ToString();
                tb_movieTitle.Text = m.MovieTitle;
                tb_genre.Text = m.Genre;
                tb_rentalCost.Text = m.RentalCost.ToString();
            }
            
        }

        private void btn_first_Click(object sender, EventArgs e)
        {
            Movie m = movieList.First();

            tb_videoCode.Text = m.VideoCode.ToString();
            tb_movieTitle.Text = m.MovieTitle;
            tb_genre.Text = m.Genre;
            tb_rentalCost.Text = m.RentalCost.ToString();
        }

        private void btn_end_Click(object sender, EventArgs e)
        {
            Movie m = movieList.Last();

            tb_videoCode.Text = m.VideoCode.ToString();
            tb_movieTitle.Text = m.MovieTitle;
            tb_genre.Text = m.Genre;
            tb_rentalCost.Text = m.RentalCost.ToString();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Movie current = context.Movies.
                Where(x => x.VideoCode.ToString() == tb_videoCode.Text).First();

            current.MovieTitle = tb_movieTitle.Text;
            current.Genre = tb_genre.Text;
            current.RentalCost = Convert.ToSingle(tb_rentalCost.Text);

            context.SaveChanges();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            Movie m = new Movie();

            m.VideoCode = Convert.ToInt16(tb_videoCode.Text);
            m.MovieTitle  = tb_movieTitle.Text;
            m.Genre = tb_genre.Text;
            m.RentalCost = Convert.ToSingle(tb_rentalCost.Text);

            context.Movies.Add(m);

            context.SaveChanges();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            Movie m = context.Movies.
                Where(x => x.VideoCode.ToString() == tb_videoCode.Text).First();

            context.Movies.Remove(m);

            context.SaveChanges();
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            currMovie = context.Movies.
                    Where(x => x.MovieTitle == tb_find.Text).First();

            tb_videoCode.Text = currMovie.VideoCode.ToString();
            tb_movieTitle.Text = tb_find.Text;
            tb_genre.Text = currMovie.Genre;
            tb_rentalCost.Text = currMovie.RentalCost.ToString();

        }
    }
}
