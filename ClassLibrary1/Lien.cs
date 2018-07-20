using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDjisktra
{
    public class Lien
    {
        private int Id;
        private Sommet x;
        private int Cout;
        private Sommet y;

        public int get_Id()
        {
            return Id;
        }

        public void set_Id(int Id)
        {
            this.Id=Id;
        }
       
        public Sommet get_x()
        {
            return x;
        }

        public void set_x(Sommet x)
        {
            this.x = x;
        }
     
        public int get_Cout()
        {
            return Cout;
        }

        public void set_Cout(int Cout)
        {
            this.Cout = Cout;
        }
        
        public Sommet get_y()
        {
            return x;
        }

        public void set_y(Sommet y)
        {
            this.y = y;
        }

        public Lien(Sommet x, Sommet y,int Cout)
        {
            this.x = x;
            this.y = y;
            this.Cout = Cout;
        }

    }
}
