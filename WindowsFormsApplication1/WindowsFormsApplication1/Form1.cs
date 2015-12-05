using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
// TEST DE GITHUB du 20/11/15 a 11:51
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private List<Jour> listeJourForm1 = new List<Jour>();
        private List<Jour> listeJourRecherche = new List<Jour>();
        private List<Activités> listeDesActivites = new List<Activités>();
        private List<Astronautes> listeDesAstronautes = new List<Astronautes>();
        private List<Lieu> listeDeLieux = new List<Lieu>();
        private Planning planning;
        private int jourPivot;
        private int hauteurPanel;
        private int hauteurBouton;
        private int intervalleBouton;
        private int positionLigne1, positionLigne2, positionLigne3;
        private int nbJourAffichage;
        private int jourActuel;
        private List<Button> ListeBoutons = new List<Button>();
        private bool modeRecherche;

        public List<Jour> GetlisteJourForm1
        {
            get { return listeJourForm1; }
            set { listeJourForm1 = value; }
        }

        //Constructeur par défaut
        public Form1()
        {
            InitializeComponent();
        }

        //Accesseurs//
        public Planning GetPLanning
        {
            get { return planning; }
            set { planning = value; }
        }

        public int GetjourPivot
        {
            get { return jourPivot; }
            set { jourPivot = value; }
        }

        public int GethauteurPanel
        {
            get { return hauteurPanel; }
            set { hauteurPanel = value; }
        }

        public int GethauteurBouton
        {
            get { return hauteurBouton; }
            set { hauteurBouton = value; }
        }

        public int GetintervalleBouton
        {
            get { return intervalleBouton; }
            set { intervalleBouton = value; }
        }
        public int GetpositionLigne1
        {
            get { return positionLigne1; }
            set { positionLigne1 = value; }
        }
        public int GetpositionLigne2
        {
            get { return positionLigne2; }
            set { positionLigne2 = value; }
        }
        public int GetpositionLigne3
        {
            get { return positionLigne3; }
            set { positionLigne3 = value; }
        }
        public int GetnbJourAffichage
        {
            get { return nbJourAffichage; }
            set { nbJourAffichage = value; }
        }

        public int GetjourActuel
        {
            get { return jourActuel; }
            set { jourActuel = value; }
        }

        public List<Button> GetlisteBoutons
        {
            get { return ListeBoutons; }
            set { ListeBoutons = value; }
        }
        //FinAccesseurs//



        //Au chargement de la page, on initialise le planning qui contient la liste de jour et propose un premier affichage par défaut.
        private void Form1_Load_1(object sender, EventArgs e)
        {

            Lieu stationMars = new Lieu("base principale", 0, 0);
            Lieu lieuExploration1 = new Lieu("cratere 1 ", 50, 50);


            listeDeLieux.Add(stationMars);
            listeDeLieux.Add(lieuExploration1);


            List<Astronautes> listeAstronautesParDefaut1 = new List<Astronautes>();
            List<Astronautes> listeAstronautesParDefaut2 = new List<Astronautes>();

            Astronautes a1 = new Astronautes("Johnson", "John", 30);
            Astronautes a2 = new Astronautes("Billyson", "Billy Junior", 30);
            Astronautes a3 = new Astronautes("Pokora", "Matt", 30);
            Astronautes a4 = new Astronautes("Josianeson", "Josiane", 28);
            Astronautes a5 = new Astronautes("Poliakoff", "Paula", 35);

            listeDesAstronautes.Add(a1);
            listeDesAstronautes.Add(a2);
            listeDesAstronautes.Add(a3);
            listeDesAstronautes.Add(a4);
            listeDesAstronautes.Add(a5);

            listeAstronautesParDefaut1.Add(a1);
            listeAstronautesParDefaut1.Add(a2);
            listeAstronautesParDefaut1.Add(a3);

            listeAstronautesParDefaut2.Add(a4);
            listeAstronautesParDefaut2.Add(a5);
            
          
            // Activité 1
            List<Activités> listeActiviteParDefaut = new List<Activités>();
           // DateTime horaireDebut = new DateTime(2015, 11, 19, 08, 00, 00);
            //DateTime horaireFin = new DateTime(2015, 11, 19, 09, 00, 00);
            Activités activité1 = new Activités("Dormir", "Sleeping", 0, 600, stationMars, listeAstronautesParDefaut1, "Sieste matinale pour l'équipe 1");
            listeActiviteParDefaut.Add(activité1);
            // Activité 2 
            //DateTime horaireDebut2 = new DateTime(2015, 11, 19, 09, 00, 00);
            //DateTime horaireFin2 = new DateTime(2015, 11, 19, 11, 00, 00);
            Activités activité2 = new Activités("Repas midi", "Eating", 600, 800, stationMars, listeAstronautesParDefaut2, "Repas de l'équipe 2");
            listeActiviteParDefaut.Add(activité2);
            // Activité 3
            //DateTime horaireDebut3 = new DateTime(2015, 11, 19, 11, 00, 00);
            //DateTime horaireFin3 = new DateTime(2015, 11, 19, 13, 00, 00);
            Activités activité3 = new Activités("Travail privé", "Private", 800, 1000, stationMars, listeAstronautesParDefaut2, "Temps alloué pour réaliser des tâches personnelles");
            listeActiviteParDefaut.Add(activité3);
            // Activité 4
            //DateTime horaireDebut4 = new DateTime(2015, 11, 19, 13, 00, 00);
            //DateTime horaireFin4 = new DateTime(2015, 11, 19, 14, 00, 00);
            Activités activité4 = new Activités("Récurer les chiotes", "Cleaning", 1000, 1200, stationMars, listeAstronautesParDefaut1, "Nettoyage des sanitaires");
            listeActiviteParDefaut.Add(activité4);
            // Exploration
            DateTime horaireDebut5 = new DateTime(2015, 11, 19, 14, 00, 00);
            DateTime horaireFin5 = new DateTime(2015, 11, 19, 18, 00, 00);
            Activités exploration = new Exploration("Exploration du cratere 0", "Vehicle", 1200, 1480, lieuExploration1, listeAstronautesParDefaut2, "Exploration du cratere numero 0");

            listeActiviteParDefaut.Add(exploration);

            Activités Test = new Activités("Toto", "Cleaning", 1000, 1200, lieuExploration1, listeAstronautesParDefaut2, "Pouet");
            Activités Test2 = new Activités("Tata", "Cleaning", 1000, 1200, lieuExploration1, listeAstronautesParDefaut2, "Exploration du cratere numero 0");

            List<Activités> listeActiviteRecherche = new List<Activités>();
            List<Activités> listeActiviteRecherche2 = new List<Activités>();

            listeActiviteRecherche.Add(Test);
            listeActiviteRecherche2.Add(Test2);

            //Cette boucle implémente 500 jours pour la liste de jour
            for (int i = 0; i <= 499; i++)
            {


                if (i == 50 || i == 256 || i == 147 || i == 200 || i == 60 || i == 10 || i == 320 || i == 457 || i == 159 || i == 328 || i == 12 || i ==97 || i ==358 || i == 45 || i == 123 || i ==412) 
                {
                    Jour j = new Jour(listeActiviteRecherche, "Test 1");
                    listeJourForm1.Add(j);
                }else if (i == 51 || i == 143 || i == 98 || i == 254)
                {
                    Jour j = new Jour(listeActiviteRecherche2, "Test 2");
                    listeJourForm1.Add(j);

                }
                else
                {

                    Jour j = new Jour(listeActiviteParDefaut, "Test 0");
                    listeJourForm1.Add(j);
                
                }

            }


            //Initialisation du planning
            DateTime dateDebut = new DateTime(2015, 11, 15, 0, 0, 0);

            List<Jour> listeJourPlanning = new List<Jour>();
            listeJourPlanning = listeJourForm1;
            planning = new Planning("Planning de Mars", listeJourPlanning, dateDebut);

            jourPivot = 0;

            jourActuel = planning.getJourActuel();


            //Affiche les jours colorés selon leur temporalité

            ListeBoutons.Add(boutonJour1);
            ListeBoutons.Add(boutonJour2);
            ListeBoutons.Add(boutonJour3);
            ListeBoutons.Add(boutonJour4);
            ListeBoutons.Add(boutonJour5);
            ListeBoutons.Add(boutonJour6);
            ListeBoutons.Add(boutonJour7);
            ListeBoutons.Add(boutonJour8);
            ListeBoutons.Add(boutonJour9);
            ListeBoutons.Add(boutonJour10);
            ListeBoutons.Add(boutonJour11);
            ListeBoutons.Add(boutonJour12);
            ListeBoutons.Add(boutonJour13);
            ListeBoutons.Add(boutonJour14);
            ListeBoutons.Add(boutonJour15);
            ListeBoutons.Add(boutonJour16);
            ListeBoutons.Add(boutonJour17);
            ListeBoutons.Add(boutonJour18);
            ListeBoutons.Add(boutonJour19);
            ListeBoutons.Add(boutonJour20);
            ListeBoutons.Add(boutonJour21);

            //Affichage des jours, par défaut : 7 jours.
            afficherJour(jourPivot);
            affichage7Jours.PerformClick();

        }

        public void coloriseBouton()
        {
            foreach (Button b in ListeBoutons)
            {

                int JourBouton = int.Parse(b.Text);
                if (JourBouton == jourActuel)
                {
                    b.BackColor = Color.Blue;
                }
                else if (JourBouton < jourActuel)
                {
                    b.BackColor = Color.Gray;
                }
                else
                {
                    b.BackColor = Color.Green;
                }
            }

        }

        //Redonne la lisibilite au boutons qui ne l'était plus de part une recherche
        public void boutonVisible()
        {
            if (nbJourAffichage == 7)
            {
                if (boutonJour1.Visible == false)
                {
                    boutonJour1.Visible = true;
                }
                if (boutonJour2.Visible == false)
                {
                    boutonJour2.Visible = true;
                }
                if (boutonJour3.Visible == false)
                {
                    boutonJour3.Visible = true;
                }
                if (boutonJour4.Visible == false)
                {
                    boutonJour4.Visible = true;
                }
                if (boutonJour5.Visible == false)
                {
                    boutonJour5.Visible = true;
                }
                if (boutonJour6.Visible == false)
                {
                    boutonJour6.Visible = true;
                }
                if (boutonJour7.Visible == false)
                {
                    boutonJour7.Visible = true;
                }
            }

            if (nbJourAffichage == 14)
            {
                if (boutonJour8.Visible == false)
                {
                    boutonJour8.Visible = true;
                }
                if (boutonJour9.Visible == false)
                {
                    boutonJour8.Visible = true;
                }
                if (boutonJour9.Visible == false)
                {
                    boutonJour9.Visible = true;
                }
                if (boutonJour10.Visible == false)
                {
                    boutonJour10.Visible = true;
                }
                if (boutonJour11.Visible == false)
                {
                    boutonJour11.Visible = true;
                }
                if (boutonJour12.Visible == false)
                {
                    boutonJour12.Visible = true;
                }
                if (boutonJour13.Visible == false)
                {
                    boutonJour13.Visible = true;
                }
                if (boutonJour14.Visible == false)
                {
                    boutonJour14.Visible = true;
                }

            }

            if (nbJourAffichage == 21)
            {
                if (boutonJour15.Visible == false)
                {
                    boutonJour15.Visible = true;
                }
                if (boutonJour16.Visible == false)
                {
                    boutonJour16.Visible = true;
                }
                if (boutonJour17.Visible == false)
                {
                    boutonJour17.Visible = true;
                }
                if (boutonJour18.Visible == false)
                {
                    boutonJour18.Visible = true;
                }
                if (boutonJour19.Visible == false)
                {
                    boutonJour19.Visible = true;
                }
                if (boutonJour20.Visible == false)
                {
                    boutonJour20.Visible = true;
                }
                if (boutonJour21.Visible == false)
                {
                    boutonJour21.Visible = true;
                }

            }
        }
        

        /* Récupère le numéros des jours à partir du paramètre numJour et les affiche dans les boutons. 
        Elle prend en compte le nombre de jour à afficher par page.*/
        public void afficherJour(int numJour)
        {

           if (modeRecherche == true && listeJourRecherche.Count <= 7)
           {
               Precedent.Enabled = false;
               suivant.Enabled = false;

           }else
           {
               Precedent.Enabled = true;
               suivant.Enabled = true;
           }


            if (modeRecherche == true){

                if (listeJourRecherche.Count > numJour + 0) { boutonJour1.Text = listeJourRecherche[numJour].GetidJour.ToString(); } else { boutonJour1.Visible = false; }
                if (listeJourRecherche.Count > numJour + 1) { boutonJour2.Text = listeJourRecherche[numJour + 1].GetidJour.ToString(); } else { boutonJour2.Visible = false; }
                if (listeJourRecherche.Count > numJour + 2) { boutonJour3.Text = listeJourRecherche[numJour + 2].GetidJour.ToString(); } else { boutonJour3.Visible = false; }
                if (listeJourRecherche.Count > numJour + 3) { boutonJour4.Text = listeJourRecherche[numJour + 3].GetidJour.ToString(); } else { boutonJour4.Visible = false; }
                if (listeJourRecherche.Count > numJour + 4) { boutonJour5.Text = listeJourRecherche[numJour + 4].GetidJour.ToString(); } else { boutonJour5.Visible = false; }
                if (listeJourRecherche.Count > numJour + 5) { boutonJour6.Text = listeJourRecherche[numJour + 5].GetidJour.ToString(); } else { boutonJour6.Visible = false; }
                if (listeJourRecherche.Count > numJour + 6) { boutonJour7.Text = listeJourRecherche[numJour + 6].GetidJour.ToString(); } else { boutonJour7.Visible = false; }

            }else{

                 boutonJour1.Text = listeJourForm1[numJour].GetidJour.ToString(); 
                 boutonJour2.Text = listeJourForm1[numJour + 1].GetidJour.ToString();
                 boutonJour3.Text = listeJourForm1[numJour + 2].GetidJour.ToString();
                 boutonJour4.Text = listeJourForm1[numJour + 3].GetidJour.ToString();
                 boutonJour5.Text = listeJourForm1[numJour + 4].GetidJour.ToString();
                 boutonJour6.Text = listeJourForm1[numJour + 5].GetidJour.ToString();
                 boutonJour7.Text = listeJourForm1[numJour + 6].GetidJour.ToString();

            }
            

            if (nbJourAffichage > 7)
            {
                if (modeRecherche == true)
                {
                    if (listeJourRecherche.Count > numJour + 7) { boutonJour8.Text = listeJourRecherche[numJour + 7].GetidJour.ToString(); } else { boutonJour8.Visible = false; }
                    if (listeJourRecherche.Count > numJour + 8) { boutonJour9.Text = listeJourRecherche[numJour + 8].GetidJour.ToString(); } else { boutonJour9.Visible = false; }
                    if (listeJourRecherche.Count > numJour + 9) { boutonJour10.Text = listeJourRecherche[numJour + 9].GetidJour.ToString(); } else { boutonJour10.Visible = false; }
                    if (listeJourRecherche.Count > numJour + 10) { boutonJour11.Text = listeJourRecherche[numJour + 10].GetidJour.ToString(); } else { boutonJour11.Visible = false; }
                    if (listeJourRecherche.Count > numJour + 11) { boutonJour12.Text = listeJourRecherche[numJour + 11].GetidJour.ToString(); } else { boutonJour12.Visible = false; }
                    if (listeJourRecherche.Count > numJour + 12) { boutonJour13.Text = listeJourRecherche[numJour + 12].GetidJour.ToString(); } else { boutonJour13.Visible = false; }
                    if (listeJourRecherche.Count > numJour + 13) { boutonJour14.Text = listeJourRecherche[numJour + 13].GetidJour.ToString(); } else { boutonJour14.Visible = false; }
                }
                else
                {
                    boutonJour8.Text = listeJourForm1[numJour + 7].GetidJour.ToString();
                    boutonJour9.Text = listeJourForm1[numJour + 8].GetidJour.ToString();
                    boutonJour10.Text = listeJourForm1[numJour + 9].GetidJour.ToString();
                    boutonJour11.Text = listeJourForm1[numJour + 10].GetidJour.ToString();
                    boutonJour12.Text = listeJourForm1[numJour + 11].GetidJour.ToString();
                    boutonJour13.Text = listeJourForm1[numJour + 12].GetidJour.ToString();
                    boutonJour14.Text = listeJourForm1[numJour + 13].GetidJour.ToString();
                }

            }

            if (nbJourAffichage > 14)
            {
                if (modeRecherche == true)
                {
                    if (listeJourRecherche.Count > numJour + 14) { boutonJour15.Text = listeJourRecherche[numJour + 14].GetidJour.ToString(); } else { boutonJour15.Visible = false; }
                    if (listeJourRecherche.Count > numJour + 15) { boutonJour16.Text = listeJourRecherche[numJour + 15].GetidJour.ToString(); } else { boutonJour16.Visible = false; }
                    if (listeJourRecherche.Count > numJour + 16) { boutonJour17.Text = listeJourRecherche[numJour + 16].GetidJour.ToString(); } else { boutonJour17.Visible = false; }
                    if (listeJourRecherche.Count > numJour + 17) { boutonJour18.Text = listeJourRecherche[numJour + 17].GetidJour.ToString(); } else { boutonJour18.Visible = false; }
                    if (listeJourRecherche.Count > numJour + 18) { boutonJour19.Text = listeJourRecherche[numJour + 18].GetidJour.ToString(); } else { boutonJour19.Visible = false; }
                    if (listeJourRecherche.Count > numJour + 19) { boutonJour20.Text = listeJourRecherche[numJour + 19].GetidJour.ToString(); } else { boutonJour20.Visible = false; }
                    if (listeJourRecherche.Count > numJour + 20) { boutonJour21.Text = listeJourRecherche[numJour + 20].GetidJour.ToString(); } else { boutonJour21.Visible = false; }
                }
                else
                {
                    boutonJour15.Text = listeJourForm1[numJour + 14].GetidJour.ToString();
                    boutonJour16.Text = listeJourForm1[numJour + 15].GetidJour.ToString();
                    boutonJour17.Text = listeJourForm1[numJour + 16].GetidJour.ToString();
                    boutonJour18.Text = listeJourForm1[numJour + 17].GetidJour.ToString();
                    boutonJour19.Text = listeJourForm1[numJour + 18].GetidJour.ToString();
                    boutonJour20.Text = listeJourForm1[numJour + 19].GetidJour.ToString();
                    boutonJour21.Text = listeJourForm1[numJour + 20].GetidJour.ToString();

                }
            }

            coloriseBouton();

            int tailleListe;

            if(modeRecherche == true)
            {
                tailleListe = listeJourRecherche.Count;

            }
            else
            {
                tailleListe = listeJourForm1.Count;
            }

            if (jourPivot > (tailleListe - 1 - 21))
            {

                affichage21Jours.Enabled = false;

            }
            else
            {
                affichage21Jours.Enabled = true;
            }


            if (jourPivot > (tailleListe - 1 - 14))
            {

                affichage14Jours.Enabled = false;

            }
            else
            {
                affichage14Jours.Enabled = true;


            }

        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            modeRecherche = false;
            boutonVisible();
            afficherJour(0);
            buttonAnnuler.Visible = false;
            labelResultatRecherche.Visible = false;
        }

        // Recherche d'un terme dans le nom d'activite, texte descriptif ou compte rendu
        private void buttonRecherche_Click(object sender, EventArgs e)
        {
            string termeARechercher = textBoxRecherche.Text;
            int termePresentNom, termePresentTexteDescriptif, termePresentCompteRendu;
            int nombreDeJour = 0;
            bool termePresentDansJour = false;
            modeRecherche = true;

            boutonVisible();

            listeJourRecherche.Clear();

            foreach (Jour J in listeJourForm1)
            {

                termePresentCompteRendu = J.GetcompteRendu.IndexOf(termeARechercher);

                if (termePresentCompteRendu != -1)
                {
                    termePresentDansJour = true;
                }

                foreach (Activités A in J.getlisteActivite)
                {
                    termePresentNom = A.GetnomActivite.IndexOf(termeARechercher);
                    termePresentTexteDescriptif = A.GettexteDescriptif.IndexOf(termeARechercher);
                    if (termePresentNom != -1 || termePresentTexteDescriptif != -1)
                    {
                        termePresentDansJour = true;
                    }
                }

                if (termePresentDansJour == true)
                {
                    listeJourRecherche.Add(J);
                    termePresentDansJour = false;
                    nombreDeJour++;
                }
            }
            if (nombreDeJour > 0)
            {
                modeRecherche = true;
                afficherJour(0);
                labelResultatRecherche.Text = "Nombre de jour correspondant au résultat de la recherche : " + nombreDeJour.ToString();
                labelResultatRecherche.Visible = true;
                buttonAnnuler.Visible = true;
            }
            else
            {
                MessageBox.Show("Votre recherche n'a donné aucun resultat", "Resultat recherche", MessageBoxButtons.OK);
                modeRecherche = false;
                afficherJour(0);
            }
        }

        //Bouton suivant, affiche les jours dans l'ordre chronlogique en fonction par page.
        private void suivant_Click(object sender, EventArgs e)
        {
            int tailleListe;
            if (modeRecherche == true)
            {
                tailleListe = listeJourRecherche.Count - 1;
            }
            else
            {
                tailleListe = listeJourForm1.Count - 1;
            }

            int limite7 = 7 + tailleListe % 7 -1;
            int limite14 = 14 + tailleListe % 14 -1;
            int limite21 = 21 + tailleListe % 21 -1;


            if (jourPivot != tailleListe - nbJourAffichage)
            {
                if (jourPivot < (tailleListe - limite7-1) && nbJourAffichage == 7)
                {
                    jourPivot = jourPivot + nbJourAffichage;
                    afficherJour(jourPivot);
                }
                else if (jourPivot >= (tailleListe - limite7-1) && nbJourAffichage == 7)
                {
                    jourPivot = jourPivot + (tailleListe + 1 - jourPivot - nbJourAffichage);
                    afficherJour(jourPivot);
                }
                else if (jourPivot < (tailleListe - limite14-1) && nbJourAffichage == 14)
                {
                    jourPivot = jourPivot + nbJourAffichage;
                    afficherJour(jourPivot);
                }
                else if (jourPivot >= (tailleListe - limite14-1) && nbJourAffichage == 14)
                {
                    jourPivot = jourPivot + (tailleListe + 1 - jourPivot - nbJourAffichage);
                    afficherJour(jourPivot);
                }
                else if (jourPivot < (tailleListe - limite21-1) && nbJourAffichage == 21)
                {
                    jourPivot = jourPivot + nbJourAffichage;
                    afficherJour(jourPivot);
                }
                else if (jourPivot >= (tailleListe - limite21-1) && nbJourAffichage == 21)
                {
                    jourPivot = jourPivot + (tailleListe + 1 - jourPivot - nbJourAffichage);
                    afficherJour(jourPivot);
                }
            }

        }

        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //Bouton précedent
        private void Precedent_Click(object sender, EventArgs e)
        {

            if (nbJourAffichage == 7)
            {
                if (jourPivot >= 7)
                {
                    jourPivot -= 7;
                    afficherJour(jourPivot);
                }
                else
                {
                    jourPivot = jourPivot - jourPivot;
                    afficherJour(jourPivot);
                }
            }
            else if (nbJourAffichage == 14)
            {
                if (jourPivot >= 14)
                {
                    jourPivot -= 14;
                    afficherJour(jourPivot);

                }
                else if (jourPivot < 14)
                {
                    jourPivot = jourPivot - jourPivot;
                    afficherJour(jourPivot);

                }
            }
            else if (nbJourAffichage == 21)
            {
                if (jourPivot >= 21)
                {
                    jourPivot -= 21;
                    afficherJour(jourPivot);

                }
                else if (jourPivot < 21)
                {
                    jourPivot = jourPivot - jourPivot;
                    afficherJour(jourPivot);

                }

            }


        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            hauteurPanel = panel1.Height;

            hauteurBouton = hauteurPanel / 3;
            intervalleBouton = hauteurBouton / 4;

            positionLigne1 = intervalleBouton;

            positionLigne2 = hauteurBouton + 2 * intervalleBouton;

            boutonJour1.Height = hauteurBouton;
            boutonJour8.Height = hauteurBouton;
            boutonJour1.Top = positionLigne1;
            boutonJour8.Top = positionLigne2;
            boutonJour8.Visible = true;

            boutonJour2.Height = hauteurBouton;
            boutonJour9.Height = hauteurBouton;
            boutonJour2.Top = positionLigne1;
            boutonJour9.Top = positionLigne2;
            boutonJour9.Visible = true;

            boutonJour3.Height = hauteurBouton;
            boutonJour10.Height = hauteurBouton;
            boutonJour3.Top = positionLigne1;
            boutonJour10.Top = positionLigne2;
            boutonJour10.Visible = true;

            boutonJour4.Height = hauteurBouton;
            boutonJour11.Height = hauteurBouton;
            boutonJour4.Top = positionLigne1;
            boutonJour11.Top = positionLigne2;
            boutonJour11.Visible = true;

            boutonJour5.Height = hauteurBouton;
            boutonJour12.Height = hauteurBouton;
            boutonJour5.Top = positionLigne1;
            boutonJour12.Top = positionLigne2;
            boutonJour12.Visible = true;

            boutonJour6.Height = hauteurBouton;
            boutonJour13.Height = hauteurBouton;
            boutonJour6.Top = positionLigne1;
            boutonJour13.Top = positionLigne2;
            boutonJour13.Visible = true;

            boutonJour7.Height = hauteurBouton;
            boutonJour14.Height = hauteurBouton;
            boutonJour7.Top = positionLigne1;
            boutonJour14.Top = positionLigne2;
            boutonJour14.Visible = true;

            boutonJour15.Visible = false;
            boutonJour16.Visible = false;
            boutonJour17.Visible = false;
            boutonJour18.Visible = false;
            boutonJour19.Visible = false;
            boutonJour20.Visible = false;
            boutonJour21.Visible = false;

            nbJourAffichage = 14;

            afficherJour(jourPivot);

        }



        private void button1_Click_2(object sender, EventArgs e)
        {

            hauteurPanel = panel1.Height;

            hauteurBouton = hauteurPanel / 4;
            intervalleBouton = hauteurBouton / 4;

            positionLigne1 = intervalleBouton;

            positionLigne2 = hauteurBouton + 2 * intervalleBouton;

            positionLigne3 = 2 * hauteurBouton + 3 * intervalleBouton;

            boutonJour1.Height = hauteurBouton;
            boutonJour8.Height = hauteurBouton;
            boutonJour15.Height = hauteurBouton;
            boutonJour1.Top = positionLigne1;
            boutonJour8.Top = positionLigne2;
            boutonJour15.Top = positionLigne3;
            boutonJour8.Visible = true;
            boutonJour15.Visible = true;

            boutonJour2.Height = hauteurBouton;
            boutonJour9.Height = hauteurBouton;
            boutonJour16.Height = hauteurBouton;
            boutonJour2.Top = positionLigne1;
            boutonJour9.Top = positionLigne2;
            boutonJour16.Top = positionLigne3;
            boutonJour9.Visible = true;
            boutonJour16.Visible = true;

            boutonJour3.Height = hauteurBouton;
            boutonJour10.Height = hauteurBouton;
            boutonJour17.Height = hauteurBouton;
            boutonJour3.Top = positionLigne1;
            boutonJour10.Top = positionLigne2;
            boutonJour17.Top = positionLigne3;
            boutonJour10.Visible = true;
            boutonJour17.Visible = true;

            boutonJour4.Height = hauteurBouton;
            boutonJour11.Height = hauteurBouton;
            boutonJour18.Height = hauteurBouton;
            boutonJour4.Top = positionLigne1;
            boutonJour11.Top = positionLigne2;
            boutonJour18.Top = positionLigne3;
            boutonJour11.Visible = true;
            boutonJour18.Visible = true;

            boutonJour5.Height = hauteurBouton;
            boutonJour12.Height = hauteurBouton;
            boutonJour19.Height = hauteurBouton;
            boutonJour5.Top = positionLigne1;
            boutonJour12.Top = positionLigne2;
            boutonJour19.Top = positionLigne3;
            boutonJour12.Visible = true;
            boutonJour19.Visible = true;

            boutonJour6.Height = hauteurBouton;
            boutonJour13.Height = hauteurBouton;
            boutonJour20.Height = hauteurBouton;
            boutonJour6.Top = positionLigne1;
            boutonJour13.Top = positionLigne2;
            boutonJour20.Top = positionLigne3;
            boutonJour13.Visible = true;
            boutonJour20.Visible = true;

            boutonJour7.Height = hauteurBouton;
            boutonJour14.Height = hauteurBouton;
            boutonJour21.Height = hauteurBouton;
            boutonJour7.Top = positionLigne1;
            boutonJour14.Top = positionLigne2;
            boutonJour21.Top = positionLigne3;
            boutonJour14.Visible = true;
            boutonJour21.Visible = true;

            nbJourAffichage = 21;

            afficherJour(jourPivot);

        }

        private void affichage7Jours_Click(object sender, EventArgs e)
        {

            hauteurPanel = panel1.Height;

            hauteurBouton = (2 * hauteurPanel) / 3;
            intervalleBouton = hauteurBouton / 4;

            positionLigne1 = intervalleBouton;

            boutonJour1.Height = hauteurBouton;
            boutonJour1.Top = positionLigne1;

            boutonJour2.Height = hauteurBouton;
            boutonJour2.Top = positionLigne1;

            boutonJour3.Height = hauteurBouton;
            boutonJour3.Top = positionLigne1;

            boutonJour4.Height = hauteurBouton;
            boutonJour4.Top = positionLigne1;

            boutonJour5.Height = hauteurBouton;
            boutonJour5.Top = positionLigne1;

            boutonJour6.Height = hauteurBouton;
            boutonJour6.Top = positionLigne1;

            boutonJour7.Height = hauteurBouton;
            boutonJour7.Top = positionLigne1;

            boutonJour8.Visible = false;
            boutonJour9.Visible = false;
            boutonJour10.Visible = false;
            boutonJour11.Visible = false;
            boutonJour12.Visible = false;
            boutonJour13.Visible = false;
            boutonJour14.Visible = false;
            boutonJour15.Visible = false;
            boutonJour16.Visible = false;
            boutonJour17.Visible = false;
            boutonJour18.Visible = false;
            boutonJour19.Visible = false;
            boutonJour20.Visible = false;
            boutonJour21.Visible = false;

            nbJourAffichage = 7;

            afficherJour(jourPivot);

        }

        public void affichageNiveau2(int tmpIdJour)
        {
            Form2 Niveau2 = new Form2(listeJourForm1, tmpIdJour, planning, listeDesAstronautes, listeDeLieux);
            Niveau2.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            affichageNiveau2(int.Parse(boutonJour1.Text));
        }

        private void boutonJour2_Click(object sender, EventArgs e)
        {

            affichageNiveau2(int.Parse(boutonJour2.Text));
        }

        private void boutonJour3_Click(object sender, EventArgs e)
        {

            affichageNiveau2(int.Parse(boutonJour3.Text));
        }

        private void boutonJour4_Click(object sender, EventArgs e)
        {

            affichageNiveau2(int.Parse(boutonJour4.Text));
        }

        private void boutonJour5_Click(object sender, EventArgs e)
        {

            affichageNiveau2(int.Parse(boutonJour5.Text));
        }

        private void boutonJour6_Click_1(object sender, EventArgs e)
        {

            affichageNiveau2(int.Parse(boutonJour6.Text));
        }

        private void boutonJour7_Click(object sender, EventArgs e)
        {

            affichageNiveau2(int.Parse(boutonJour7.Text));
        }

        private void boutonJour8_Click(object sender, EventArgs e)
        {

            affichageNiveau2(int.Parse(boutonJour8.Text));
        }

        private void boutonJour9_Click(object sender, EventArgs e)
        {

            affichageNiveau2(int.Parse(boutonJour9.Text));
        }

        private void boutonJour10_Click(object sender, EventArgs e)
        {

            affichageNiveau2(int.Parse(boutonJour10.Text));
        }

        private void boutonJour11_Click(object sender, EventArgs e)
        {

            affichageNiveau2(int.Parse(boutonJour11.Text));
        }

        private void boutonJour12_Click(object sender, EventArgs e)
        {

            affichageNiveau2(int.Parse(boutonJour12.Text));
        }

        private void boutonJour13_Click(object sender, EventArgs e)
        {

            affichageNiveau2(int.Parse(boutonJour13.Text));
        }

        private void boutonJour14_Click(object sender, EventArgs e)
        {

            affichageNiveau2(int.Parse(boutonJour14.Text));
        }

        //Il s'agit bien de boutonJour15, mais la référence sur le nom ne s'est pas faite
        private void button7_Click(object sender, EventArgs e)
        {

            affichageNiveau2(int.Parse(boutonJour15.Text));
        }

        private void boutonJour16_Click(object sender, EventArgs e)
        {

            affichageNiveau2(int.Parse(boutonJour16.Text));
        }

        private void boutonJour17_Click(object sender, EventArgs e)
        {

            affichageNiveau2(int.Parse(boutonJour17.Text));
        }

        private void boutonJour18_Click(object sender, EventArgs e)
        {

            affichageNiveau2(int.Parse(boutonJour18.Text));
        }

        private void boutonJour19_Click(object sender, EventArgs e)
        {

            affichageNiveau2(int.Parse(boutonJour19.Text));
        }

        private void boutonJour20_Click(object sender, EventArgs e)
        {

            affichageNiveau2(int.Parse(boutonJour20.Text));
        }

        private void boutonJour21_Click(object sender, EventArgs e)
        {

            affichageNiveau2(int.Parse(boutonJour21.Text));
        }
        public void enregistrerProjet() // Permet d'enregistrer tous les attributs de toutes les classes de tout le projet
        {
            XmlDocument xmlDoc = new XmlDocument();
            XmlNode rootNode = xmlDoc.CreateElement("Enregistrement");
            xmlDoc.AppendChild(rootNode);


            ////////////Activités//////////// Serialise les attributs de la classe Activités
            XmlNode Activites = xmlDoc.CreateElement("SerializationActivites");
            rootNode.AppendChild(Activites);
            foreach (Activités A in listeDesActivites)
            {
                XmlNode Activite = xmlDoc.CreateElement("Activite");
                Activites.AppendChild(Activite);

                XmlNode hDebut = xmlDoc.CreateElement("heureDebut");
                hDebut.InnerText = A.getHoraireDebut.ToString();
                Activites.AppendChild(hDebut);

                XmlNode hFin = xmlDoc.CreateElement("heureFin");


                hFin.InnerText = A.GetHoraireFin.ToString();
                Activites.AppendChild(hFin);

                XmlNode txtDescriptif = xmlDoc.CreateElement("texteDescriptif");
                txtDescriptif.InnerText = A.GettexteDescriptif;
                Activites.AppendChild(txtDescriptif);

                XmlNode typeActivity = xmlDoc.CreateElement("typeActivite");
                typeActivity.InnerText = A.GettypeActivite;
                Activites.AppendChild(typeActivity);

                XmlNode statutDeActivite = xmlDoc.CreateElement("statutActivite");
                statutDeActivite.InnerText = A.GetstatutActivite;
                Activites.AppendChild(statutDeActivite);

                XmlNode NomActivite = xmlDoc.CreateElement("nomActivité");
                NomActivite.InnerText = A.GetnomActivite;
                Activites.AppendChild(NomActivite);

                XmlNode Astronautes = xmlDoc.CreateElement("Astronautes");
                Activites.AppendChild(Astronautes);

                XmlNode nomDuLieu = xmlDoc.CreateElement("lieu");
                Activites.AppendChild(nomDuLieu);



                //////Liste des Atsronautes de la classe Activités////////
                foreach (Astronautes Astro in listeDesAstronautes)
                {
                    XmlNode cosmonautes = xmlDoc.CreateElement("Astronaute");
                    Activites.AppendChild(cosmonautes);

                    XmlNode idCosmonaute = xmlDoc.CreateElement("ID");
                    idCosmonaute.InnerText = Astro.GetidAstronaute.ToString();
                    cosmonautes.AppendChild(idCosmonaute);

                    XmlNode nomCosmonaute = xmlDoc.CreateElement("Nom");
                    nomCosmonaute.InnerText = Astro.GetnomAstronaute;
                    cosmonautes.AppendChild(nomCosmonaute);

                    XmlNode prenomCosmonaute = xmlDoc.CreateElement("Prenom");
                    prenomCosmonaute.InnerText = Astro.GetprenomAstronaute;
                    cosmonautes.AppendChild(prenomCosmonaute);

                    XmlNode ageCosmonaute = xmlDoc.CreateElement("Age");
                    ageCosmonaute.InnerText = Astro.GetageAstronaute.ToString();
                    cosmonautes.AppendChild(ageCosmonaute);

                }
            }

            //////\Liste des Atsronautes de la classe Activités////////
            ////////////\Activites///////////


            ////////////Planning////////////
            XmlNode ClassePlanning = xmlDoc.CreateElement("SerializationPlanning");
            rootNode.AppendChild(ClassePlanning);

            XmlNode DateDeDebut = xmlDoc.CreateElement("Date de debut");
            DateDeDebut.InnerText = planning.GetDateDebut.ToString();
            ClassePlanning.AppendChild(DateDeDebut);

            XmlNode nomDuPlanning = xmlDoc.CreateElement("nom");
            nomDuPlanning.InnerText = planning.GetnomPlanning;
            ClassePlanning.AppendChild(nomDuPlanning);

            XmlNode idDuPlanning = xmlDoc.CreateElement("ID");
            idDuPlanning.InnerText = planning.GetidPlanning.ToString();
            ClassePlanning.AppendChild(nomDuPlanning);
            ////////////\Planning///////////

            ////////////Jour////////

            XmlNode Jour = xmlDoc.CreateElement("SerializationJour");
            rootNode.AppendChild(Jour);

            foreach (Jour j in listeJourForm1)
            {
                XmlNode idDuJour = xmlDoc.CreateElement("ID");
                idDuJour.InnerText = j.GetidJour.ToString();
                Jour.AppendChild(idDuJour);

                XmlNode Etat = xmlDoc.CreateElement("Etat");
                Etat.InnerText = j.GetetatActivite; ;
                Jour.AppendChild(Etat);

                XmlNode CompteRendu = xmlDoc.CreateElement("Compte Rendu");
                CompteRendu.InnerText = j.GetcompteRendu;
                Jour.AppendChild(CompteRendu);

            }
            ////////////\Jour//////////

            ////////////Lieu//////////
            XmlNode Lieu = xmlDoc.CreateElement("Lieu");
            rootNode.AppendChild(Lieu);

            foreach (Lieu L in listeDeLieux)
            {
                XmlNode NomLieu = xmlDoc.CreateElement("Nom");
                NomLieu.InnerText = L.GetnomLieu;
                Lieu.AppendChild(NomLieu);

                XmlNode X = xmlDoc.CreateElement("Abscisse");
                X.InnerText = L.GetCoordonneeX.ToString();
                Lieu.AppendChild(X);

                XmlNode Y = xmlDoc.CreateElement("Ordonnee");
                Y.InnerText = L.GetCoordonneeY.ToString();
                Lieu.AppendChild(Y);

                XmlNode idDuLieu = xmlDoc.CreateElement("ID");
                idDuLieu.InnerText = L.GetidLieu.ToString();
                Lieu.AppendChild(idDuLieu);

            }
            ////////////\Lieu/////////

            xmlDoc.Save("FichierXMLPrincipal.xml");
        }

    

      
        /*public bool ChargerFichierXMLPrincipal() //Permet de recréer toutes les instances appartenant au form 1
        {
            XmlDocument xmldoc = new XmlDocument();
            try
            {
                xmldoc.Load("FichierXMLPrincipal.xml"); //On charge le fichier xml
            }
            catch (Exception)
            {
                Console.WriteLine("Le fichier n'existe pas.");
                return false;
            }

            if (xmldoc == null)
            {
                return false;
            }

            listeDeLieux.Clear();
            listeDesActivites.Clear();
            listeDesAstronautes.Clear();
            listeJourForm1.Clear();

            //Charge le planning
            XmlNodeList noeuPlanning = xmldoc.GetElementsByTagName("ClassePlanning");

            foreach (XmlNode node in noeuPlanning)
            {
                string nomDuPlanning = node.SelectSingleNode("nom").InnerText;
                DateTime DateDeDebut = DateTime.Parse(node.SelectSingleNode("Date de debut").InnerText);
                int idDuPlanning = int.Parse(node.SelectSingleNode("ID").InnerText);
                Planning Planning = new Planning(nomDuPlanning, listeJourForm1, DateDeDebut);
            }
            // Charge les activites

            XmlNodeList nodeListeActivites = xmldoc.GetElementsByTagName("SerializationActivites");
            foreach (XmlNode nodeAct in nodeListeActivites)
            {
                if (nodeAct != null)
                {
                    XmlNodeList nodeActivites = xmldoc.GetElementsByTagName("Activites");

                    foreach (XmlNode nodeRes in nodeActivites)
                    {
                        DateTime hDebut = DateTime.Parse(nodeRes.SelectSingleNode("heuredebut").InnerText);
                        DateTime hFin = DateTime.Parse(nodeRes.SelectSingleNode("heureFin").InnerText);
                        string txtDescriptif = nodeRes.SelectSingleNode("texteDescriptif").InnerText;
                        string typeActivity = nodeRes.SelectSingleNode("typeActivite").InnerText;
                        string statutDeActivite = nodeRes.SelectSingleNode("statutActivite").InnerText;
                        string NomActivite = nodeRes.SelectSingleNode("nomActivité").InnerText;
                        string nomDuLieu = (nodeRes.SelectSingleNode("lieuActivite").InnerText);


                        //Activités monActivite = new Activités(NomActivite,typeActivity,hDebut,hFin,lieu);

                        // charge les Astronautes de activite
                        // charge les Astronaute de activite


<<<<<<< HEAD

                        //Activités monActivite = new Activités(NomActivite, typeActivity, hDebut, hFin, lieu);
=======
                       // Activités monActivite = new Activités(NomActivite, typeActivity, hDebut, hFin, lieu);
>>>>>>> origin/master

                        // charge les Astronautes de activite
                        // charge les Astronaute de activite

                        XmlNodeList nodeAstronautes = xmldoc.GetElementsByTagName("Cosmonautes");
                        foreach (XmlNode nodeCosmonaute in nodeAstronautes)
                        {
                            int idCosmonaute = int.Parse(nodeCosmonaute.SelectSingleNode("ID").InnerText);
                            string nomCosmonaute = nodeCosmonaute.SelectSingleNode("Nom").InnerText;
                            string prenomCosmonaute = nodeCosmonaute.SelectSingleNode("Prenom").InnerText;
                            int ageCosmonaute = int.Parse(nodeCosmonaute.SelectSingleNode("Age").InnerText);

                        }
                        /* XmlNode cosmonautes = xmlDoc.CreateElement("Astronaute");
                     Activites.AppendChild(cosmonautes);

                     XmlNode idCosmonaute = xmlDoc.CreateElement("ID");
                     idCosmonaute.InnerText = Astro.GetidAstronaute.ToString();
                     cosmonautes.AppendChild(idCosmonaute);

                     XmlNode nomCosmonaute = xmlDoc.CreateElement("Nom");
                     nomCosmonaute.InnerText = Astro.GetnomAstronaute;
                     cosmonautes.AppendChild(nomCosmonaute);

                     XmlNode prenomCosmonaute = xmlDoc.CreateElement("Prenom");
                     prenomCosmonaute.InnerText = Astro.GetprenomAstronaute;
                     cosmonautes.AppendChild(prenomCosmonaute);

                     XmlNode ageCosmonaute = xmlDoc.CreateElement("Age");
                     ageCosmonaute.InnerText = Astro.GetageAstronaute.ToString();
                     cosmonautes.AppendChild(ageCosmonaute);

                    }
                }
            }

<<<<<<< HEAD
=======
=======
<<<<<<< HEAD

=======
>>>>>>> origin/master
>>>>>>> origin/master
>>>>>>> origin/master
            ////////FinJour///////

            //////////Lieu//////////
            XmlNodeList nodeListeLieu = xmldoc.GetElementsByTagName("CategorieLieu");
            foreach (XmlNode nodeL in nodeListeLieu)
            {
                if (nodeL != null)
                {
                    XmlNodeList nodeLieuL = xmldoc.GetElementsByTagName("Lieu");

                    foreach (XmlNode leLieu in nodeLieuL)
                    {
                        string NomLieu = leLieu.SelectSingleNode("Nom").InnerText;
                        int X = int.Parse(leLieu.SelectSingleNode("Abscisse").InnerText);
                        int Y = int.Parse(leLieu.SelectSingleNode("Ordonnee").InnerText);
                        int idDuLieu = int.Parse(leLieu.SelectSingleNode("ID").InnerText);
                        Lieu lieu = new Lieu(NomLieu, X, Y);
                    }

                    //////////FinLieu////////


                }



            }
            //////////////////
            //////////////////
            return true;
        }





<<<<<<< HEAD
=======
>>>>>>> origin/master

        }*/

    }
}

