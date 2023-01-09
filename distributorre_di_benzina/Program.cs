using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace distributorre_di_benzina
{
    internal class Program
    {
        static void Main(string[] args)
        {
            distributore_benzina distributore = new distributore_benzina("dkjfh2", "via caio", 100);//INFORMAZIONI inserite nel custrottore 

            int soldi;
            
            distributore.AggiungiDenaro(soldi);//passo i dati nella funzione nella classe
            
        }
    }
}
