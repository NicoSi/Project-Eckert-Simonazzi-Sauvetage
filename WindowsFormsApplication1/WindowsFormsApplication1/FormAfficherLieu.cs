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
    public partial class FormAfficherLieu : Form
    {

        private List<Lieu> listeLieux;
        private List<Jour> listeJours;
        private Planning planning;
        int positionX, positionY;
        public FormAfficherLieu(List<Lieu> tempListeLieux, List<Jour> templisteJours, Planning tempPlanning)
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            listeLieux = tempListeLieux;
            listeJours = templisteJours;
            planning = tempPlanning;
        }

        private void FormAfficherLieu_Load(object sender, EventArgs e)
        {

            int coordonneeX, coordonneeY;
            foreach (Jour j in listeJours)
            {
                //Exploration passé
                if (j.GetidJour < planning.getJourActuel())
                {
                    foreach (Activités A in j.getlisteActivite)
                    {
                        if(A.GettypeActivite == "Exploration - Space Suit" )
                        {
                            Image imageExploSpaceSuitPast = Image.FromFile(System.Windows.Forms.Application.StartupPath + @"\astronautPast.png");
                            Lieu lieuExploSpaceSuitPast = A.GetLieuActivite;
                            PictureBox pBExploSpaceSuitPast = new PictureBox();
                            pBExploSpaceSuitPast.Image = imageExploSpaceSuitPast;

                            coordonneeX = Convert.ToInt32(lieuExploSpaceSuitPast.GetCoordonneeX) + 700;
                            coordonneeY = 1000 - Convert.ToInt32(lieuExploSpaceSuitPast.GetCoordonneeY);

                            Point p = new Point(coordonneeX, coordonneeY);
                            pBExploSpaceSuitPast.Location = p;
                            pBExploSpaceSuitPast.Size = new System.Drawing.Size(50, 50);
                            pictureBox1.Controls.Add(pBExploSpaceSuitPast);
                            pBExploSpaceSuitPast.SizeMode = PictureBoxSizeMode.StretchImage;
                            pBExploSpaceSuitPast.BackColor = Color.Transparent;

                        }
                        else if (A.GettypeActivite == "Exploration - Vehicle")
                        {
                            Image imageExploVehiclePast = Image.FromFile(System.Windows.Forms.Application.StartupPath + @"\vehiclePast.png");
                            Lieu lieuExploVehiclePast = A.GetLieuActivite;
                            PictureBox pBExploVehiclePast = new PictureBox();
                            pBExploVehiclePast.Image = imageExploVehiclePast;

                            coordonneeX = Convert.ToInt32(lieuExploVehiclePast.GetCoordonneeX) + 700;
                            coordonneeY = 1000 - Convert.ToInt32(lieuExploVehiclePast.GetCoordonneeY);

                            Point p = new Point(coordonneeX, coordonneeY);
                            pBExploVehiclePast.Location = p;
                            pBExploVehiclePast.Size = new System.Drawing.Size(50, 50);
                            pictureBox1.Controls.Add(pBExploVehiclePast);
                            pBExploVehiclePast.SizeMode = PictureBoxSizeMode.StretchImage;
                            pBExploVehiclePast.BackColor = Color.Transparent;

                        }
                        else if (A.GettypeActivite == "Science - Outside experiment")
                        {
                            Image imageExperiencePast = Image.FromFile(System.Windows.Forms.Application.StartupPath + @"\experiencePast.png");
                            Lieu lieuExploExperiencePast = A.GetLieuActivite;
                            PictureBox pBExploExperiencePast = new PictureBox();
                            pBExploExperiencePast.Image = imageExperiencePast;

                            coordonneeX = Convert.ToInt32(lieuExploExperiencePast.GetCoordonneeX) + 700;
                            coordonneeY = 1000 - Convert.ToInt32(lieuExploExperiencePast.GetCoordonneeY);

                            Point p = new Point(coordonneeX, coordonneeY);
                            pBExploExperiencePast.Location = p;
                            pBExploExperiencePast.Size = new System.Drawing.Size(50, 50);
                            pictureBox1.Controls.Add(pBExploExperiencePast);
                            pBExploExperiencePast.SizeMode = PictureBoxSizeMode.StretchImage;
                            pBExploExperiencePast.BackColor = Color.Transparent;
                        }
                    }

                }
                else
                {

                    foreach (Activités A in j.getlisteActivite)
                    {
                        if (A.GettypeActivite == "Exploration - Space Suit")
                        {
                            Image imageExploSpaceSuitFuture = Image.FromFile(System.Windows.Forms.Application.StartupPath + @"\astronautFuture.png");
                            Lieu lieuExploSpaceSuitFuture = A.GetLieuActivite;
                            PictureBox pBExploSpaceSuitFuture = new PictureBox();
                            pBExploSpaceSuitFuture.Image = imageExploSpaceSuitFuture;

                            coordonneeX = Convert.ToInt32(lieuExploSpaceSuitFuture.GetCoordonneeX) + 700;
                            coordonneeY = 1000 - Convert.ToInt32(lieuExploSpaceSuitFuture.GetCoordonneeY);

                            Point p = new Point(coordonneeX, coordonneeY);
                            pBExploSpaceSuitFuture.Location = p;
                            pBExploSpaceSuitFuture.Size = new System.Drawing.Size(50, 50);
                            pictureBox1.Controls.Add(pBExploSpaceSuitFuture);
                            pBExploSpaceSuitFuture.SizeMode = PictureBoxSizeMode.StretchImage;
                            pBExploSpaceSuitFuture.BackColor = Color.Transparent;

                        }
                        else if (A.GettypeActivite == "Exploration - Vehicle")
                        {
                            Image imageExploVehicleFuture = Image.FromFile(System.Windows.Forms.Application.StartupPath + @"\vehicleFuture.png");
                            Lieu lieuExploVehicleFuture = A.GetLieuActivite;
                            PictureBox pBExploVehicleFuture = new PictureBox();
                            pBExploVehicleFuture.Image = imageExploVehicleFuture;

                            coordonneeX = Convert.ToInt32(lieuExploVehicleFuture.GetCoordonneeX) + 700;
                            coordonneeY = 1000 - Convert.ToInt32(lieuExploVehicleFuture.GetCoordonneeY);

                            Point p = new Point(coordonneeX, coordonneeY);
                            pBExploVehicleFuture.Location = p;
                            pBExploVehicleFuture.Size = new System.Drawing.Size(50, 50);
                            pictureBox1.Controls.Add(pBExploVehicleFuture);
                            pBExploVehicleFuture.SizeMode = PictureBoxSizeMode.StretchImage;
                            pBExploVehicleFuture.BackColor = Color.Transparent;

                        }
                        else if (A.GettypeActivite == "Science - Outside experiment")
                        {
                            Image imageExperienceFuture = Image.FromFile(System.Windows.Forms.Application.StartupPath + @"\experienceFuture.png");
                            Lieu lieuExploExperienceFuture = A.GetLieuActivite;
                            PictureBox pBExploExperienceFuture = new PictureBox();
                            pBExploExperienceFuture.Image = imageExperienceFuture;

                            coordonneeX = Convert.ToInt32(lieuExploExperienceFuture.GetCoordonneeX) + 700;
                            coordonneeY = 1000 - Convert.ToInt32(lieuExploExperienceFuture.GetCoordonneeY);

                            Point p = new Point(coordonneeX, coordonneeY);
                            pBExploExperienceFuture.Location = p;
                            pBExploExperienceFuture.Size = new System.Drawing.Size(50, 50);
                            pictureBox1.Controls.Add(pBExploExperienceFuture);
                            pBExploExperienceFuture.SizeMode = PictureBoxSizeMode.StretchImage;
                            pBExploExperienceFuture.BackColor = Color.Transparent;
                        }
                    }




                }

            }


            foreach (Lieu L in listeLieux)
            {


            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {

            positionX = e.X - 700;
            positionY = pictureBox1.Height - e.Y - (pictureBox1.Height - 1000);
            labelCoordonneeX.Text = "Coordonnée X :  " + positionX.ToString();
            labelCoordonneeY.Text = "Coordonnée Y :  " + positionY.ToString();
        }
    }
}
