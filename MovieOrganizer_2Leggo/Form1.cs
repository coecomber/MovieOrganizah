using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieOrganizer_2Leggo
{
    public partial class Form1 : Form
    {
        API.TMDBClient tmdbc = new API.TMDBClient();
        Folder.FolderDestination fd = new Folder.FolderDestination();

        public object DataGridView1 { get; private set; }

        public Form1()
        {
            InitializeComponent();
            this.dataGridView1.DefaultCellStyle.WrapMode =
            DataGridViewTriState.True;
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            while (Properties.Settings.Default.BaseFolder == "")
            fd.ChooseBaseFolder();
            pictureBox1.Image = Image.FromFile(Properties.Settings.Default.profilepic);
            panel2.BackgroundImage = Image.FromFile(Properties.Settings.Default.Backgroundpic);
            this.dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.AllowUserToAddRows = false;


        }


        //Voert de methode uit "ChooseBaseFolder()".
        private void kiesMapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            fd.ChooseBaseFolder();
        }


        //Een methode om een venster te openen waarin een path geselecteerd kan worden voor de films.
   

        //Voert de methode uit "ChooseProfilePath()".
        private void veranderProfielfotoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChooseProfilePath();
        }


        //Een methode om een venster te openen waarin een plaatje geselecteerd kan worden voor de profielfoto.
        private void ChooseProfilePath()
        {
            OpenFileDialog Dialog = new OpenFileDialog();
            DialogResult Result = Dialog.ShowDialog();
            if (Result == DialogResult.OK)
            {
                Properties.Settings.Default.profilepic = Dialog.FileName;
                Properties.Settings.Default.Save();
                pictureBox1.Image = Image.FromFile(Properties.Settings.Default.profilepic);
            }

        }

        private void veranderPanelKleurToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loadMoviesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            foreach (var folder in fd.GetFolderNames())
                {
                     Console.WriteLine(folder);
                    var movie = tmdbc.GetMovieByTitle(folder);
                if (movie.Count > 0)
                {
                    
                    dataGridView1.Rows.Add(movie[0].Title, movie[0].Overview, movie[0].Popularity, new Foto.ImageLoader().LoadImageFromURL("https://image.tmdb.org/t/p/w185" + movie[0].PosterPath));

                }
                }

        }

        private void veranderAchtergrondToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChooseAchtergrondPath();
        }

        private void sluitenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }


        //Een methode om een venster te openen waarin een plaatje geselecteerd kan worden voor de profielfoto.
        private void ChooseAchtergrondPath()
        {
            OpenFileDialog Dialog = new OpenFileDialog();
            DialogResult Result = Dialog.ShowDialog();
            if (Result == DialogResult.OK)
            {
                Properties.Settings.Default.Backgroundpic = Dialog.FileName;
                Properties.Settings.Default.Save();
                panel2.BackgroundImage = Image.FromFile(Properties.Settings.Default.Backgroundpic);
            }

        }
        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(200, Color.Black);
        }

        private void dataGridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.BackColor = Color.FromArgb(2, Color.White);
        }

    }
}
