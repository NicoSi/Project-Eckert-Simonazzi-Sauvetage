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

public class Carte
{
    private List<Lieu> listeLieu;
    private List<Exploration> listeExploration;


    //contructeur par défaut
    public Carte()
    {

    }
    //Accesseurs//
	public List<Lieu> GetlisteLieu
	{
        get { return listeLieu; }
        set { listeLieu = value; }
	}

	public List<Exploration> GetlisteExploration
	{
		get{return listeExploration;}
		set{listeExploration=value;}
	}
    ///FinAccesseurs//

}
