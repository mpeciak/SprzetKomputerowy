using SprzetKomputerowy.Models.Entities;
using SprzetKomputerowy.Models.ForAllView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprzetKomputerowy.ViewModels
{
    public class NowaOsobaViewModel:JedenViewModel<Osoby>
    {

        #region Constructor
        public NowaOsobaViewModel()
            : base("Nowa Osoba")
        {
            //Ustawiamy co wyświetla się w tytule zakładki
            item = new Osoby();
        }
        #endregion Constructor
        #region Properties
        public int IdOsoby
        {
            get
            {
                return item.IdOsoby;
            }
            set
            {
                if (value != item.IdOsoby)
                {
                    item.IdOsoby = value;
                    OnPropertyChanged(() => IdOsoby);
                }
            }
        }
        public string Imie
        {
            get
            {
                return item.Imie;
            }
            set
            {
                if (value != item.Imie)
                {
                    item.Imie = value;
                    OnPropertyChanged(() => Imie);
                }
            }
        }

        public string Nazwisko
        {
            get
            {
                return item.Nazwisko;
            }
            set
            {
                if (value != item.Nazwisko)
                {
                    item.Nazwisko = value;
                    OnPropertyChanged(() => Nazwisko);
                }
            }
        }
        public int? IdDzialu
        {
            get
            {
                return item.IdDzialu;
            }
            set
            {
                if (value != item.IdDzialu)
                {
                    item.IdDzialu = value;
                    OnPropertyChanged(() => IdDzialu);
                }
            }
        }
        public int? IdZestawu
        {
            get
            {
                return item.IdZestawu;
            }
            set
            {
                if (value != item.IdZestawu)
                {
                    item.IdZestawu = value;
                    OnPropertyChanged(() => IdZestawu);
                }
            }
        }
        public string Lokalizacja
        {
            get
            {
                return item.Lokalizacja;
            }
            set
            {
                if (value != item.Lokalizacja)
                {
                    item.Lokalizacja = value;
                    OnPropertyChanged(() => Lokalizacja);
                }
            }
        }
        public IQueryable<ComboboxKeyAndValue> DzialComboboxItems
        {
            get
            {
                return
                    (
                    from stanowisko in sprzetKomputerowyEntities.Dzialy
                    select new ComboboxKeyAndValue
                    {
                        Key = stanowisko.idDzialu,
                        Value = stanowisko.NazwaDzialu,
                    }
                    ).ToList().AsQueryable();
            }
        }
        public IQueryable<ComboboxKeyAndValue> ZestawComboboxItems
        {
            get
            {
                return
                    (
                    from stanowisko in sprzetKomputerowyEntities.Zestawy
                    select new ComboboxKeyAndValue
                    {
                        Key = stanowisko.IdZestawu,
                        Value = stanowisko.NazwaKategori,
                    }
                    ).ToList().AsQueryable();
            }
        }

        #endregion Properties
        #region Helpers
        public override void save()
        {
            sprzetKomputerowyEntities.Osoby.Add(item);
            sprzetKomputerowyEntities.SaveChanges();
        }
        #endregion Helpers
    }
}
