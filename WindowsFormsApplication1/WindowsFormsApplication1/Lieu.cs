﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Lieu
{
    private string nomLieu;
    private double coordonneX, coordonneY;
    private int idLieu;
    private static int nbLieu;
    private List<Activités> listeActivites = new List<Activités>();
    //Constructeur par défaut
    public Lieu(string tempNomLieu, double tempCoordonneX, double tempCoordonneY)
    {
        nomLieu = tempNomLieu;
        coordonneX = tempCoordonneX;
        coordonneY = tempCoordonneY;
        nbLieu++;
        idLieu = nbLieu;
    }
	public string GetnomLieu
	{
        get { return nomLieu; }
        set { nomLieu = value; }
	}
    public int GetidLieu
    {
        get { return idLieu; }
        set { idLieu = value; }
    }
   public double GetCoordonneeX
    {
        get { return coordonneX; }
        set { coordonneX = value; }
    }

   public double GetCoordonneeY
   {
       get { return coordonneY; }
       set { coordonneY = value; }
   }
	public List<Activités> GetlisteActivites
	{
        get { return listeActivites; }
        set { listeActivites = value; }
	}
    public override string ToString()
    {
        string ch = "";
        return ch;
    }

    public override bool Equals(object obj)
    {
        Lieu l = obj as Lieu;

        if (l != null)
        {
            if (this.nomLieu.Equals(l.nomLieu))
                if (this.coordonneX == l.coordonneX)
                    if (this.coordonneY == l.coordonneY)
                        return true;
        }

        return false;
    }
}

