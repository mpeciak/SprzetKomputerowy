using SprzetKomputerowy.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprzetKomputerowy.ViewModels
{
    public class NowaKategoriaUrzadzeniaViewModel:JedenViewModel<KlasyfikacjaUrzadzenia>
    {
        #region Constructor
        public NowaKategoriaUrzadzeniaViewModel()
            : base("Nowa Kat Urzadz")
        {
            //Ustawiamy co wyświetla się w tytule zakładki
            item = new KlasyfikacjaUrzadzenia();
        }
        #endregion Constructor
        #region Properties
        public int IdKlasyfikacjiUrzadzenia
        {
            get
            {
                return item.IdKlasyfikacjiUrzadzenia;
            }
            set
            {
                if (value != item.IdKlasyfikacjiUrzadzenia)
                {
                    item.IdKlasyfikacjiUrzadzenia = value;
                    OnPropertyChanged(() => IdKlasyfikacjiUrzadzenia);
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
            sprzetKomputerowyEntities.KlasyfikacjaUrzadzenia.Add(item);
            sprzetKomputerowyEntities.SaveChanges();
        }
        #endregion Helpers
    }
}
