using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LakesTest
{
    internal class Rybník
    {
        public int pořadí {  get; set; } 
        public string rybnikName { get; set; } 
        public int rozloha {  get; set; } 
        public int objemKm { get; set; } 
        public string okres { get; set; } 
         
        internal Rybník(int pořadí,string rybnikName,int rozloha,int objemKM, string okres)  
        {
            this.pořadí = pořadí; 
            this.rybnikName = rybnikName; 
            this.rozloha = rozloha; 
            this.objemKm = objemKM; 
            this.okres = okres; 

        }
    }
}
