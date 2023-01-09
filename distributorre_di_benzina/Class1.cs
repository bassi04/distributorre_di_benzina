using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace distributorre_di_benzina
{
    internal class distributore_benzina
    {
        private string _numero_seriale;
        private string _indirizzo;
        private int _capacita_massima; // la quantita massima di benzina che può contenere il distributore 
        private int _livello_benzina; // la quantita di benzina presente in questo momento 
        private int _denaro_caricato;

        public string Numero_seriale { get { return _numero_seriale; } private set { _numero_seriale = value; } }
        public string Indirizzo { get { return _indirizzo; } set { _indirizzo = value; } }
        public int Capacita_massima { get { return _capacita_massima; } private set { _capacita_massima = value; } }
        public int Livello_benzina { get { return _livello_benzina; } set { _livello_benzina = value; } }
        public int Denaro_caricato { get { return _denaro_caricato; } set { _denaro_caricato = value; } }
        public distributore_benzina (string numero_seriale, string indirizzo, int capacita_massima) // costruttore dove vanno dichiarate le variabili che non possono essere cambiate dal utente
        {
            Numero_seriale = numero_seriale;
            Indirizzo = indirizzo;
            Capacita_massima = capacita_massima;
        } 
            
        public void AggiungiDenaro(int soldi)
        {
            _denaro_caricato = _denaro_caricato + soldi;

        }
        
        public void ControlloDenaro() 
        { 
            if (_denaro_caricato>=5 && _denaro_caricato<=100)
            {

            }
            else
            {
                throw new Exception("inserire credito maggiore di 5 ma minore di 100"); //non fa proseguire l'utente 
            }
            

           
        }


                
     

        
      
        
    }
    
}
