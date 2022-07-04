using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex._02._2
{
    internal class Lanterna
    {
        private String ligar;

        public void setLigar(String ligar)
        {
          
          this.ligar = ligar;


        }

        public String getLigar()
        {
            return this.ligar;
        }


        public Lanterna(String ligar)
        {

            this.ligar = ligar;

        }

    }
}
