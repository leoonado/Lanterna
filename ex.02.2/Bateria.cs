using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex._02._2
{
    internal class Bateria
    {
        private int carga;
        public Bateria(int carga)
        {

            this.carga = carga;

        }

        public void setCarga(int carga)
        {
            this.carga = carga;
        }

        public int getCarga (){
            return carga; 
        }


    }
  
}
