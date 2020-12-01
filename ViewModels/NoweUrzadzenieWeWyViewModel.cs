using SprzetKomputerowy.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprzetKomputerowy.ViewModels
{
    public class NoweUrzadzenieWeWyViewModel:JedenViewModel<UrzadzeniaWeWy>
    {
        #region Constructor
        public NoweUrzadzenieWeWyViewModel()
            : base("Nowe Urzadzenie WeWy")
        {
            //Ustawiamy co wyświetla się w tytule zakładki
            item = new UrzadzeniaWeWy();
        }
        #endregion Constructor
        #region Properties
        public int IdUrzadzeniaWeWy
        {
            get
            {
                return item.IdUrzadzeniaWeWy;
            }
            set
            {
                if (value != item.IdUrzadzeniaWeWy)
                {
                    item.IdUrzadzeniaWeWy = value;
                    OnPropertyChanged(() => IdUrzadzeniaWeWy);
                }
            }
        }

        public string NazwaUrzadzenia
        {
            get
            {
                return item.NazwaUrzadzenia;
            }
            set
            {
                if (value != item.NazwaUrzadzenia)
                {
                    item.NazwaUrzadzenia = value;
                    OnPropertyChanged(() => NazwaUrzadzenia);
                }
            }
        }
        public string Producent
        {
            get
            {
                return item.Producent;
            }
            set
            {
                if (value != item.Producent)
                {
                    item.Producent = value;
                    OnPropertyChanged(() => Producent);
                }
            }
        }
        public string NrSeryjny
        {
            get
            {
                return item.NrSeryjny;
            }
            set
            {
                if (value != item.NrSeryjny)
                {
                    item.NrSeryjny = value;
                    OnPropertyChanged(() => NrSeryjny);
                }
            }
        }
        public string Status
        {
            get
            {
                return item.Status;
            }
            set
            {
                if (value != item.Status)
                {
                    item.Status = value;
                    OnPropertyChanged(() => Status);
                }
            }
        }
        #endregion Properties
        #region Helpers
        public override void save()
        {
            sprzetKomputerowyEntities.UrzadzeniaWeWy.Add(item);
            sprzetKomputerowyEntities.SaveChanges();
        }
        #endregion Helpers
    }
}
