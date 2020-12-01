using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprzetKomputerowy.Models.ForAllView
{
    public class UrzadzeniaForAllView
    {
        public string NrEwidencyjny { get; set; }
        public string NazwaUrzadzenia { get; set; }
        public string Producent { get; set; }
        public string Klasyfikacja { get; set; }
        public string SprzetPrzypisany { get; set; }
        public string Imie { get; set; }
        public string Lokalizacja { get; set; }
        public string NrSeryjny { get; set; }
        public DateTime? DataProdukcji { get; set; }
        public string Opis { get; set; }
        public string StanTechniczny { get; set; }

    }
}
