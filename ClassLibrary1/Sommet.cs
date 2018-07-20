using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDjisktra
{
    public class Sommet
    {
        private int Id;
        private int Cout;
        private int Pos ;
        //private Sommet Predecesseur { get; set; }
        private List<Lien> Liens;

        public List<Lien> get_Liens()
        {
            return Liens;
        }

        public void set_Liens(List<Lien> Liens)
        {
            this.Liens = Liens;
        }

        public int get_Id()
        {
            return Id;
        }

        public void set_Id(int id)
        {
            this.Id = id;
        }

        public int get_Cout()
        {
            return Cout;
        }

        public void set_Cout(int Cout)
        {
            this.Cout = Cout;
        }

        public int get_Pos()
        {
            return Pos;
        }

        public void set_Pos(int Pos)
        {
            this.Id = Pos;
        }

        public Sommet(int Cout, int Pos)
        {
            this.Cout = Cout;
            this.Pos = Pos;

        }

    }
}
