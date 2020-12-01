using SprzetKomputerowy.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprzetKomputerowy.ViewModels
{
    public class NowyDzialViewModel: JedenViewModel<Dzialy>
    {
        #region Constructor
        public NowyDzialViewModel()
            : base("Nowy Dzial")
        {
            //Ustawiamy co wyświetla się w tytule zakładki
            item = new Dzialy();
        }
        #endregion Constructor
        #region Properties
        public int idDzialu
        {
            get
            {
                return item.idDzialu;
            }
            set
            {
                if (value != item.idDzialu)
                {
                    item.idDzialu = value;
                    OnPropertyChanged(() => idDzialu);
                }
            }
        }
        public string NazwaDzialu
        {
            get
            {
                return item.NazwaDzialu;
            }
            set
            {
                if (value != item.NazwaDzialu)
                {
                    item.NazwaDzialu = value;
                    OnPropertyChanged(() => NazwaDzialu);
                }
            }
        }
        #endregion Properties
        #region Helpers
        public override void save()
        {
            sprzetKomputerowyEntities.Dzialy.Add(item);
            sprzetKomputerowyEntities.SaveChanges();
        }
        #endregion Helpers
    }
}
