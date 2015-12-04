using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public class ActiviteComparer : IComparer<Activités>
    {
        public int Compare(Activités x, Activités y)
        {

            return x.getHoraireDebut.CompareTo(y.getHoraireDebut);

        }
    }
}
