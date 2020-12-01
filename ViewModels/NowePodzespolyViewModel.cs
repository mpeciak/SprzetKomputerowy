using SprzetKomputerowy.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprzetKomputerowy.ViewModels
{
    public class NowePodzespolyViewModel:JedenViewModel<Podzespoly>
    {

        #region Constructor
        public NowePodzespolyViewModel()
            : base("Nowe Podzespoły")
        {
            //Ustawiamy co wyświetla się w tytule zakładki
            item = new Podzespoly();
        }
        #endregion Constructor
        #region Properties
        public int idPodZespolu
        {
            get
            {
                return item.idPodZespolu;
            }
            set
            {
                if (value != item.idPodZespolu)
                {
                    item.idPodZespolu = value;
                    OnPropertyChanged(() => idPodZespolu);
                }
            }
        }
        public string NazwaPodzespolu
        {
            get
            {
                return item.NazwaPodzespolu;
            }
            set
            {
                if (value != item.NazwaPodzespolu)
                {
                    item.NazwaPodzespolu = value;
                    OnPropertyChanged(() => NazwaPodzespolu);
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
        public int? Ilosc
        {
            get
            {
                return item.Ilosc;
            }
            set
            {
                if (value != item.Ilosc)
                {
                    item.Ilosc = value;
                    OnPropertyChanged(() => Ilosc);
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
            sprzetKomputerowyEntities.Podzespoly.Add(item);
            sprzetKomputerowyEntities.SaveChanges();
        }
        #endregion Helpers
    }
}
