using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDjisktra
{
    class Helper
    {
       public void Djikstra(Sommet Debut, Sommet Fin, List<Sommet> Noeds)
        {

        }

        public List<Sommet> CreationListGraph(int[][]Value)
        {
            List<Sommet> Sommets = new List<Sommet>();

            List<Sommet> prev = new List<Sommet>(); 
            for(int i=0; i <= Value.Length; i++)
            {
                for (int j = 0; j <= Value[i].Length; j++)
                {
                    if (Value[i][j] != 0)
                    {
                        Sommet Temp = new Sommet(0,Value[i][j]);
                        List<Lien> TempLiens = new List<Lien>(); 
                        if (prev.Count != 0)
                        {
                            foreach(Sommet s in prev)
                            {
                                Lien l = new Lien(s, Temp, Math.Abs(s.get_Pos() - Temp.get_Pos()));
                                TempLiens.Add(l);
                                
                            }
                            Temp.set_Liens(TempLiens);
                        }
                        
                        
                    }
                }
                prev.Clear();
            }
            return Sommets;
        }
    }
}
