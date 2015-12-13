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
        private List<Jour> listeJour;
        private Planning planning;


        public formModifierActivite(Jour objetJourSelection, List<Astronautes> tempListeAstronautes, Activités tempActiviteAModifier, List<Lieu> tempListeDeLieux,List<Jour> tempListeJours ,Planning P)
        {
            
            InitializeComponent();
            objetJour = objetJourSelection;
            activiteAModifier = tempActiviteAModifier;
            listeAstronautes = tempListeAstronautes;
            listeLieux = tempListeDeLieux;
            listeJour = tempListeJours;
            planning = P;
        }

       
        private void formModifierActivite_Load(object sender, EventArgs e)
        {
            textBoxNomAct.Text = this.activiteAModifier.GetnomActivite;
            label2Jour.Text = this.objetJour.GetidJour.ToString();
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
            // remplire heure de fin
            for (int i = 0; i < 25; i++)
            {
                comboBoxHeureFin.Items.Add(i);
            }
            // remplire minutes de fin
            for (int i = 0; i < 60; i = i + 10)
            {
                comboBoxMinutesFin.Items.Add(i);
            }
            // On remet l'heure initiale qu'avait l'activité qu'on doit modifier
            comboBoxHeureDebut.SelectedItem = activiteAModifier.getHeureDebutMars();
            comboBoxMinuteDebut.SelectedItem = activiteAModifier.getMinuteDebutMars();
            comboBoxHeureFin.SelectedItem = activiteAModifier.getHeureFinMars();
            comboBoxMinutesFin.SelectedItem = activiteAModifier.getMinuteFinMars();

            

            //Remplissage de tree view type activite

            TreeNode treeNodeLiving = new TreeNode("Living");

            treeNodeLiving.Nodes.Add("Eating");
            treeNodeLiving.Nodes.Add("Sleeping");
            treeNodeLiving.Nodes.Add("Entertainment");
            treeNodeLiving.Nodes.Add("Private");
            treeNodeLiving.Nodes.Add("Health Control");
            treeNodeLiving.Nodes.Add("Medical Act");

            TreeNode treeNodeScience = new TreeNode("Science");

            TreeNode treeNodeExploration = new TreeNode("Exploration");

            treeNodeExploration.Nodes.Add("Space Suit");
            treeNodeExploration.Nodes.Add("Vehicle");

            treeNodeScience.Nodes.Add(treeNodeExploration);

            treeNodeScience.Nodes.Add("Briefing");
            treeNodeScience.Nodes.Add("Debriefing");
            treeNodeScience.Nodes.Add("Inside experiment");
            treeNodeScience.Nodes.Add("Outside experiment");

            TreeNode treeNodeMaintenance = new TreeNode("Maintenance");

            treeNodeMaintenance.Nodes.Add("Cleaning");
            treeNodeMaintenance.Nodes.Add("LSS air system");
            treeNodeMaintenance.Nodes.Add("LSS water system");
            treeNodeMaintenance.Nodes.Add("LSS food system");
            treeNodeMaintenance.Nodes.Add("Power systems");
            treeNodeMaintenance.Nodes.Add("Space suit");
            treeNodeMaintenance.Nodes.Add("Other");

            TreeNode treeNodeCommunication = new TreeNode("Communication");

            treeNodeCommunication.Nodes.Add("Sending message");
            treeNodeCommunication.Nodes.Add("Receiving message");

            TreeNode treeNodeRepair = new TreeNode("Repair");

            treeNodeRepair.Nodes.Add("LSS");
            treeNodeRepair.Nodes.Add("Power systems");
            treeNodeRepair.Nodes.Add("Communication systems");
            treeNodeRepair.Nodes.Add("Propulsion systems");
            treeNodeRepair.Nodes.Add("Habitat");
            treeNodeRepair.Nodes.Add("Space suit");
            treeNodeRepair.Nodes.Add("Vehicle");

            TreeNode treeNodeEmergency = new TreeNode("Emergency");


            treeViewTypeActivite.Nodes.Add(treeNodeLiving);
            treeViewTypeActivite.Nodes.Add(treeNodeScience);
            treeViewTypeActivite.Nodes.Add(treeNodeMaintenance);
            treeViewTypeActivite.Nodes.Add(treeNodeCommunication);
            treeViewTypeActivite.Nodes.Add(treeNodeRepair);
            treeViewTypeActivite.Nodes.Add(treeNodeEmergency);

        

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
                    comboBoxListeLieu.SelectedIndex = indexLieu;
                }

                indexLieu++;
            }
            // on récupère le descriptif initial de l'activité à modifier

            richTextBoxDescriptif.Text = activiteAModifier.GettexteDescriptif;

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

        private void labelPlageHoraireActivité_Click(object sender, EventArgs e)
        {

        }

        private void boutonEnregistrerActivite_Click_1(object sender, EventArgs e)
        {
            string messageErreur = "Veuillez remplir les champs suivants :";
            string messageErreurSupplementaire = "Erreurs : ";
            bool erreur = false;
            bool erreurSupplementaire = false;
            string nomActivite = "";
            string typeActivite = "";
            int horaireDebutActivite = 0;
            int horaireFinActivite = 0;
            Lieu lieuActivite = new Lieu("lieu non defini", 0, 0);

            if (textBoxNomAct.Text != "")
            {
                //recuperation nom activite
                nomActivite = textBoxNomAct.Text;
            }
            else
            {
                erreur = true;
                messageErreur = messageErreur + "\r\n - Nom activité";
            }

            if (treeViewTypeActivite.SelectedNode != null)
            {
                //recuperation type activite
                typeActivite = treeViewTypeActivite.SelectedNode.Parent.Text + " - " + treeViewTypeActivite.SelectedNode.Text;
            }
            else
            {
                erreur = true;
                messageErreur = messageErreur + "\r\n - Type d'activité";
            }


            //recuperation horaire debut et horaire fin
            if (comboBoxHeureDebut.Text == "" || comboBoxMinuteDebut.Text == "" || comboBoxHeureFin.Text == "" || comboBoxMinutesFin.Text == "")
            {
                erreur = true;
                messageErreur = messageErreur + "\r\n - Horaire de début et de fin";

            }
            else
            {
                horaireDebutActivite = int.Parse(comboBoxHeureDebut.Text) * 60 + int.Parse(comboBoxMinuteDebut.Text);
                horaireFinActivite = int.Parse(comboBoxHeureFin.Text) * 60 + int.Parse(comboBoxMinutesFin.Text);

                if (horaireDebutActivite >= horaireFinActivite)
                {
                    erreurSupplementaire = true;
                    messageErreurSupplementaire = "\r\n - Les horaires de fin doivent être supérieures aux horaires de début";
                }

            }
            

            //Creation d'un lieu
            string nomLieu = "";
            int coordonneX = 0;
            int coordonneY = 0;

            //recuperation lieu
            if (comboBoxListeLieu.Text != "" && checkBoxLieu.Checked == false)
            {
                lieuActivite = listeLieux[comboBoxListeLieu.SelectedIndex];
            }
            else if (comboBoxListeLieu.Text == "" && checkBoxLieu.Checked == false)
            {
                erreur = true;
                messageErreur = messageErreur + "\r\n - Lieu";
            }
            else if (checkBoxLieu.Checked == true)
            {
                if (textBoxNomLieu.Text != "")
                {
                    nomLieu = textBoxNomLieu.Text;
                }
                else
                {
                    erreur = true;
                    messageErreur = messageErreur + "\r\n - Nom du lieu";
                }

                if (textBoxCoordonnéesX.Text != "")
                {
                    coordonneX = int.Parse(textBoxCoordonnéesX.Text);
                }
                else
                {
                    erreur = true;
                    messageErreur = messageErreur + "\r\n - Coordonnée X";
                }

                if (textBoxCoordonnéesY.Text != "")
                {
                    coordonneY = int.Parse(textBoxCoordonnéesY.Text);
                }
                else
                {
                    erreur = true;
                    messageErreur = messageErreur + "\r\n - Coordonnée Y";
                }

                if (nomLieu != "" && textBoxCoordonnéesX.Text != "" && textBoxCoordonnéesY.Text != "")
                {
                    lieuActivite = new Lieu(nomLieu, coordonneX, coordonneY);
                    listeLieux.Add(lieuActivite);
                }


            }

            List<Astronautes> listeAstronautesSelection = new List<Astronautes>();

            //recuperation de la liste d'astronautes selectionnee
            for (int i = 0; i <= (checkedListBoxAstronautes.Items.Count - 1); i++)
            {
                if (checkedListBoxAstronautes.GetItemChecked(i))
                {
                    listeAstronautesSelection.Add(listeAstronautes[i]);
                }
            }


            string texteDescriptif = richTextBoxDescriptif.Text;

            
            if (erreur == true)
            {
                MessageBox.Show(messageErreur, "Message Erreur", MessageBoxButtons.OK);
            }
            else if (erreurSupplementaire == true)
            {
                MessageBox.Show(messageErreurSupplementaire, "Message Erreur", MessageBoxButtons.OK);
            }
            else if (erreur == false && erreurSupplementaire == false)
            {
                objetJour.getlisteActivite.Remove(activiteAModifier);
                Activités nouvelleActivite = new Activités(nomActivite, typeActivite, horaireDebutActivite, horaireFinActivite, lieuActivite, listeAstronautesSelection, texteDescriptif);
                objetJour.ajouterActivite(nouvelleActivite);
                this.Dispose();
                
                Form2 f = new Form2(listeJour, objetJour.GetidJour, planning, listeAstronautesSelection, listeLieux);
                f.ShowDialog();
            }
            

            
        }

        private void boutonAnnuler_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void checkBoxLieu_CheckedChanged(object sender, EventArgs e)
        {
            textBoxCoordonnéesX.Visible = ((CheckBox)sender).Checked;
            textBoxCoordonnéesY.Visible = ((CheckBox)sender).Checked;
            textBoxNomLieu.Visible = ((CheckBox)sender).Checked;
            labelNomLieu.Visible = ((CheckBox)sender).Checked;
            labelLieuCoordonneeX.Visible = ((CheckBox)sender).Checked;
            labelLieuCoordonneeY.Visible = ((CheckBox)sender).Checked;
            comboBoxListeLieu.Visible = !((CheckBox)sender).Checked;
            labelLieuActivite.Visible = !((CheckBox)sender).Checked;
            buttonAjouterParCarte.Visible = ((CheckBox)sender).Checked;

        }

        private void labelLieuActivite_Click(object sender, EventArgs e)
        {

        }

        private void buttonAjouterParCarte_Click(object sender, EventArgs e)
        {
            nouveauLieuCarte form = new nouveauLieuCarte();

            if (form.ShowDialog(this) == DialogResult.OK && form.getNomLieu != "" && form.getPositionX.ToString() != "" && form.getPositionY.ToString() != "")
            {

                textBoxNomLieu.Text = form.getNomLieu;
                textBoxCoordonnéesX.Text = form.getPositionX.ToString();
                textBoxCoordonnéesY.Text = form.getPositionY.ToString();

            }
            else if (form.ShowDialog(this) == DialogResult.OK || form.getNomLieu == "" || form.getPositionX.ToString() == "" || form.getPositionY.ToString() == "")
            {
                buttonAjouterParCarte_Click(sender, e);
            }

        }

      

      
    }
}
