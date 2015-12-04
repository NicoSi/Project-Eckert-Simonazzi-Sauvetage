using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Activity
    {
        private int idActivité;
        private DateTime heureDebut;

	    public Activity(string nom, DateTime hDebut, DateTime hFin)

        {

            nbActivité++;

            nomActivité = nom;

            idActivité = nbActivité;

            heureDebut = hDebut;

            heureFin = hFin;

        }



        public Activity()

        {

            nbActivité++;

        }



        private static int nbActivité = 0;

        protected string nomActivité;

        public string GetNomActivité

        {

            get { return nomActivité; }

            set { nomActivité = value; }

        }



    





	    public DateTime getHeureDebut

	    {

		    get { return heureDebut; }

		    set { heureDebut = value; }

	    }



	    private DateTime heureFin

	    {

		    get;

		    set;

	    }



	    public virtual object texteDescriptif

	    {

		    get;

		    set;

	    }



	    public virtual string typeActivite

	    {

		    get;

		    set;

	    }



	    public virtual string statutActivite

	    {

		    get;

		    set;

	    }



	    public virtual IEnumerable<Astronautes> listeAstronautes

	    {

		    get;

		    set;

	    }



	    public virtual void RenvoieActiviteParMotCle()

	    {

		    throw new System.NotImplementedException();

	    }



	    public virtual void ajouterLieu()

	    {

		    throw new System.NotImplementedException();

	    }



	    public virtual void supprimerLieu()

	    {

		    throw new System.NotImplementedException();

	    }



	    public virtual void ajouterAstronautes()

	    {

		    throw new System.NotImplementedException();

	    }



	    public virtual void supprimerAstronautes()

	    {

		    throw new System.NotImplementedException();

	    }



	    public virtual void getListeAstronautes()

	    {

		    throw new System.NotImplementedException();

	    }



	    public virtual void getLieu()

	    {

		    throw new System.NotImplementedException();

	    }
    }
}
