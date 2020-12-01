using SprzetKomputerowy.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprzetKomputerowy.ViewModels
{
    public class NowaKategoriaKomputeraViewModel: JedenViewModel<KlasyfikacjaKomputera>
    {
        #region Constructor
        public NowaKategoriaKomputeraViewModel()
            : base("Nowa Kat Komput")
        {
            //Ustawiamy co wyświetla się w tytule zakładki
            item = new KlasyfikacjaKomputera();
        }
        #endregion Constructor
        #region Properties
        public int IdKlasyfikacjiKomputera
        {
            get
            {
                return item.IdKlasyfikacjiKomputera;
            }
            set
            {
                if (value != item.IdKlasyfikacjiKomputera)
                {
                    item.IdKlasyfikacjiKomputera = value;
                    OnPropertyChanged(() => IdKlasyfikacjiKomputera);
                }
            }
        }
        public string NazwaKlasyfikacji
        {
            get
            {
                return item.NazwaKlasyfikacji;
            }
            set
            {
                if (value != item.NazwaKlasyfikacji)
                {
                    item.NazwaKlasyfikacji = value;
                    OnPropertyChanged(() => NazwaKlasyfikacji);
                }
            }
        }
        #endregion Properties
        #region Helpers
        public override void save()
        {
            sprzetKomputerowyEntities.KlasyfikacjaKomputera.Add(item);
            sprzetKomputerowyEntities.SaveChanges();
        }
        #endregion Helpers
    }
}

