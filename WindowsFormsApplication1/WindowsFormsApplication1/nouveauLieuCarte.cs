using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class nouveauLieuCarte : Form
    {

        private int positionX, positionY;
        private string nomLieu;
        public nouveauLieuCarte()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        public string getNomLieu
        {
            get { return nomLieu;  }

        }


        public int getPositionX
        {
            get { return positionX; }
        }

        public int getPositionY
        {
            get { return positionY; }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {


        }

        private void nouveauLieuCarte_Load(object sender, EventArgs e)
        {

        }

        private void nouveauLieuCarte_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            positionX = e.X - 700;
            positionY = pictureBox1.Height - e.Y -(pictureBox1.Height- 1000);
            textBoxCoordonneeX.Text = positionX.ToString();
            textBoxCoordonneeY.Text = positionY.ToString();
            

        }

        private void buttonEnregistrer_Click(object sender, EventArgs e)
        {
            bool erreur = false;
            string messageErreur = "Veuillez notez les informations suivantes";

            nomLieu = textBoxNomLieu.Text;
            
            if (textBoxNomLieu.Text == "")
            {
                erreur = true;
                messageErreur = messageErreur + "\r\n - Nom de lieu ";
            }

            if (textBoxCoordonneeX.Text == "")
            {
                erreur = true;
                messageErreur = messageErreur + "\r\n - Coordonnée X";
            }

            if (textBoxCoordonneeY.Text == "")
            {
                erreur = true;
                messageErreur = messageErreur + "\r\n - Coordonnée Y";
            }

            if(erreur == true)
            {
                MessageBox.Show(messageErreur, "Message Erreur", MessageBoxButtons.OK);
            }


        }
    }
}
