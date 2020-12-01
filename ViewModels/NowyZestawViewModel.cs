using SprzetKomputerowy.Models.Entities;
using SprzetKomputerowy.Models.ForAllView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprzetKomputerowy.ViewModels
{
    public class NowyZestawViewModel:JedenViewModel<Zestawy>
    {

        #region Constructor
        public NowyZestawViewModel()
            : base("Nowy Zestaw")
        {
            //Ustawiamy co wyświetla się w tytule zakładki
            item = new Zestawy();
        }
        #endregion Constructor
        #region Properties
        public int? IdKomputera
        {
            get
            {
                return item.IdKomputera;
            }
            set
            {
                if (value != item.IdKomputera)
                {
                    item.IdKomputera = value;
                    OnPropertyChanged(() => IdKomputera);
                }
            }
        }
        public string NrEwidencji
        {
            get
            {
                return item.NrEwidencji;
            }
            set
            {
                if (value != item.NrEwidencji)
                {
                    item.NrEwidencji = value;
                    OnPropertyChanged(() => NrEwidencji);
                }
            }
        }
        public string NazwaKategori
        {
            get
            {
                return item.NazwaKategori;
            }
            set
            {
                if (value != item.NazwaKategori)
                {
                    item.NazwaKategori = value;
                    OnPropertyChanged(() => NazwaKategori);
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
        public int? IdOsoby
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
        public int? IdLokalizacji
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
        public int? IdUrzadzenia
        {
            get
            {
                return item.IdUrzadzenia;

            }
            set
            {
                if (value != item.IdUrzadzenia)
                {
                    item.IdUrzadzenia = value;
                    OnPropertyChanged(() => IdUrzadzenia);
                }
            }
        }
        public IQueryable<ComboboxKeyAndValue> DzialyComboboxItems
        {
            get
            {
                return
                    (
                    from dzialy in sprzetKomputerowyEntities.Dzialy
                    select new ComboboxKeyAndValue
                    {
                        Key = dzialy.idDzialu,
                        Value = dzialy.NazwaDzialu,
                    }
                    ).ToList().AsQueryable();
            }
        }
        public IQueryable<ComboboxKeyAndValue> LokalizacjaComboboxItems
        {
            get
            {
                return
                    (
                    from lokalizacja in sprzetKomputerowyEntities.Lokalizacja
                    select new ComboboxKeyAndValue
                    {
                        Key = lokalizacja.IdLokalizacji,
                        Value = lokalizacja.NazwaLokalizacji,
                    }
                    ).ToList().AsQueryable();
            }
        }
        public IQueryable<ComboboxKeyAndValue> OsobaComboboxItems
        {
            get
            {
                return
                    (
                    from osoba in sprzetKomputerowyEntities.Osoby
                    select new ComboboxKeyAndValue
                    {
                        Key = osoba.IdOsoby,
                        Value = osoba.Imie+" "+ osoba.Nazwisko,
                    }
                    ).ToList().AsQueryable();
            }
        }

        #endregion Properties

        #region Helpers
        public override void save()
        {
            sprzetKomputerowyEntities.Zestawy.Add(item);
            sprzetKomputerowyEntities.SaveChanges();
        }
        #endregion Helpers
    }
}

