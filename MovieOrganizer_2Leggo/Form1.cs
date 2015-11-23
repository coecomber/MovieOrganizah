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
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            while (Properties.Settings.Default.BaseFolder == "")
                ChooseBaseFolder();
            pictureBox1.Image = Image.FromFile(Properties.Settings.Default.profilepic);
        }


        //Voert de methode uit "ChooseBaseFolder()".
        private void kiesMapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChooseBaseFolder();
        }


        //Een methode om een venster te openen waarin een path geselecteerd kan worden voor de films.
        private void ChooseBaseFolder()
        {
            FolderBrowserDialog Dialog = new FolderBrowserDialog();
            DialogResult Result = Dialog.ShowDialog(this);
            if (Result == DialogResult.OK)
            {
                Properties.Settings.Default.BaseFolder = Dialog.SelectedPath;
                Properties.Settings.Default.Save();
            }
        }


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
    }
}
