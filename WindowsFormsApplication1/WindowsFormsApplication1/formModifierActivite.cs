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
    public partial class formModifierActivite : Form
    {
        private Jour objetJour;
        private List<Astronautes> listeAstronautes;
        private Activités activiteAModifier;
        private List<Lieu> listeLieux;


        public formModifierActivite(Jour objetJourSelection, List<Astronautes> tempListeAstronautes, Activités tempActiviteAModifier, List<Lieu> tempListeDeLieux)
        {
            InitializeComponent();
            objetJour = objetJourSelection;
            activiteAModifier = tempActiviteAModifier;
            listeAstronautes = tempListeAstronautes;
            listeLieux = tempListeDeLieux;
        }

       
        private void formModifierActivite_Load(object sender, EventArgs e)
        {
            textBox1.Text = this.activiteAModifier.GetnomActivite;
            textBox3.Text = this.objetJour.GetidJour.ToString();
            // Remplire heure debut

            for (int i = 0; i < 25; i++)
            {
                comboBoxHeureDebut.Items.Add(i);
            }
            //remplire minute debut
            for (int i = 0; i < 60; i = i + 10)
            {
                comboBoxMinuteDebut.Items.Add(i);
            }
            // On remet l'heure initiale qu'avait l'activité qu'on doit modifier
            comboBoxHeureDebut.SelectedIndex = activiteAModifier.getHeureDebutMars();
            comboBoxMinuteDebut.SelectedIndex = activiteAModifier.getMinuteDebutMars();
            // On rempli le comboBox de lieu avec la liste de lieu
            if(this  != null)
            foreach(Lieu L in listeLieux)
            {
                comboBoxListeLieu.Items.Add(L.GetnomLieu);

            }
            // On remet le lieu initial qu'avait l'activité à modifier
            
          // On remet le lieu initial qu'avait l'activité à modifier
            
            int indexLieu =0;
            foreach(Lieu l in listeLieux)
            {
                if (l.GetnomLieu == activiteAModifier.GetnomLieuDeActivite)
                {
                    comboBoxListeLieu.SelectedIndex = int.Parse(l.GetnomLieu);
                    comboBoxListeLieu.SelectedIndex = indexLieu;
                }

                indexLieu++;
            }
            // on récupère le descriptif initial de l'activité à modifier

            richTextBox1.Text = activiteAModifier.GettexteDescriptif;

            // On remplie le CheckListeBoxAstronaute avec la liste des astronautes

          
            foreach (Astronautes A in listeAstronautes)
            {
                checkedListBoxAstronautes.Items.Add(A.GetnomAstronaute);
            }

            List<Astronautes> listeAstronautesActivités = new List<Astronautes>();

            foreach (Astronautes A in activiteAModifier.GetlisteAstronautes)
            {
                listeAstronautesActivités.Add(A);
            }

            int index = 0;
            //On récupère la liste des astronoautes initiale de l'activité à modifier

            /*foreach(Astronautes astro in listeAstronautes)
            {
                if(astro.GetnomAstronaute==activiteAModifier.GetlisteAstronautes.)
                {
                    checkedListBoxAstronautes.SelectedIndex = int.Parse(astro.GetnomAstronaute);
                }
            }*/

            foreach (Astronautes astro in listeAstronautes)
            {

                    foreach (Astronautes astro2 in listeAstronautesActivités)

                        if ((astro.GetnomAstronaute == astro2.GetnomAstronaute))
                        {
                            checkedListBoxAstronautes.SetItemCheckState(index, CheckState.Checked);
                        }


                index++;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxHeureDebut_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxListeLieu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBoxAstronautes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


      
    }
}
