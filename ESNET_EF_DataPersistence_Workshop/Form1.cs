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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DafestyEntities context = new DafestyEntities();
            Movie m = context.Movies.
                Where(x => x.VideoCode.ToString() == "5").First();
            label1.Text = m.MovieTitle;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DafestyEntities context = new DafestyEntities();
            Movie m = context.Movies.
                Where(x => x.VideoCode.ToString() == "5").First();
            m.RentalCost = 1.80f;
            context.SaveChanges();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DafestyEntities context = new DafestyEntities();

            Movie m = new Movie();
            m.VideoCode = 400;
            m.MovieTitle = "Sully";
            m.Genre = "Drama";
            m.ProducerID = "Warner";
            m.RentalCost = 2.50f;
            m.Rating = "U";
            m.TotalStock = 4;

            context.Movies.Add(m);
            context.SaveChanges();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DafestyEntities context = new DafestyEntities();

            Movie m = context.Movies.
                Where(x => x.VideoCode == 4).First();
            Producer p = context.Producers.
                Where(x => x.ProducerID == "Pixar").First();

            m.Producer = p;

            context.SaveChanges();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DafestyEntities context = new DafestyEntities();

            Movie m = context.Movies.
                Where(x => x.VideoCode == 11).First();
            Producer p = context.Producers.
                Where(x => x.ProducerID == "Warner").First();

            p.Movies.Add(m);

            context.SaveChanges();


        }

        private void button6_Click(object sender, EventArgs e)
        {
            DafestyEntities context = new DafestyEntities();

            Movie m = context.Movies.
                Where(x => x.VideoCode == 400).First();

            context.Movies.Remove(m);

            context.SaveChanges();
        }
    }
}
