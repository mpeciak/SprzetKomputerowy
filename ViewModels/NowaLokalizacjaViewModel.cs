using SprzetKomputerowy.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprzetKomputerowy.ViewModels
{
    class NowaLokalizacjaViewModel:JedenViewModel<Lokalizacja>
    {
        #region Constructor
        public NowaLokalizacjaViewModel()
            : base("Nowa Lokalizacja")
        {
            //Ustawiamy co wyświetla się w tytule zakładki
            item = new Lokalizacja();
        }
        #endregion Constructor
        #region Properties
        public int IdLokalizacji
        {
            get
            {
                return item.IdLokalizacji;
            }
            set
            {
                if (value != item.IdLokalizacji)
                {
                    item.IdLokalizacji = value;
                    OnPropertyChanged(() => IdLokalizacji);
                }
            }
        }
        public string NazwaLokalizacji
        {
            get
            {
                return item.NazwaLokalizacji;
            }
            set
            {
                if (value != item.NazwaLokalizacji)
                {
                    item.NazwaLokalizacji = value;
                    OnPropertyChanged(() => NazwaLokalizacji);
                }
            }
        }

        #endregion Properties
        #region Helpers
        public override void save()
        {
            sprzetKomputerowyEntities.Lokalizacja.Add(item);
            sprzetKomputerowyEntities.SaveChanges();
        }
        #endregion Helpers
    }

}

