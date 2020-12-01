using GalaSoft.MvvmLight.Messaging;
using SprzetKomputerowy.Helpers;
using SprzetKomputerowy.Models.Entities;
using SprzetKomputerowy.Models.ForAllView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SprzetKomputerowy.ViewModels
{
    public class NowyKomputerViewModel:JedenViewModel<Komputery>
    {

        #region Fields
        //To jest pole do komendy, ktora zostanie podpieta pod przycisk z trzema kropkami, ktory wywola okno do wybierania Kontrahenta
        private BaseCommand _ShowStanTechnicznyCommand;
        private BaseCommand _ShowPracownikCommand;
        private BaseCommand _ShowLokalizacjaCommand;
        #endregion Fields
        #region Constructor
        public NowyKomputerViewModel()
            : base("Nowy Komputer")
        {
            //Ustawiamy co wyświetla się w tytule zakładki
            item = new Komputery();
        }
        #endregion Constructor
        #region Command
        public ICommand ShowStanTechnicznyCommand
        {
            get
            {
                if (_ShowStanTechnicznyCommand == null)
                {
                    //Po kliknieciu na button z trzema kropkami do MainWindowViewModel Messengerem zostanie wsylany komunikat wywolujacy okno ze wszystkimi Kontrahentami
                    _ShowStanTechnicznyCommand = new BaseCommand(() => Messenger.Default.Send("StanTechnicznyShow"));
                }
                return _ShowStanTechnicznyCommand;
            }
        }
        public ICommand ShowPracownikCommand
        {
            get
            {
                if (_ShowPracownikCommand == null)
                {
                    //Po kliknieciu na button z trzema kropkami do MainWindowViewModel Messengerem zostanie wsylany komunikat wywolujacy okno ze wszystkimi Kontrahentami
                    _ShowPracownikCommand = new BaseCommand(() => Messenger.Default.Send("PracownikShow"));
                }
                return _ShowPracownikCommand;
            }
        }
        public ICommand ShowLokalizacjaCommand
        {
            get
            {
                if (_ShowLokalizacjaCommand == null)
                {
                    //Po kliknieciu na button z trzema kropkami do MainWindowViewModel Messengerem zostanie wsylany komunikat wywolujacy okno ze wszystkimi Kontrahentami
                    _ShowLokalizacjaCommand = new BaseCommand(() => Messenger.Default.Send("LokalizacjaShow"));
                }
                return _ShowLokalizacjaCommand;
            }
        }
        #endregion Command

        #region Properties
        public int IdKomputera
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
        public string Nazwakomputera
        {
            get
            {
                return item.Nazwakomputera;
            }
            set
            {
                if (value != item.Nazwakomputera)
                {
                    item.Nazwakomputera = value;
                    OnPropertyChanged(() => Nazwakomputera);
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
        public string NrEwidencyjny
        {
            get
            {
                return item.NrEwidencyjny;
            }
            set
            {
                if (value != item.NrEwidencyjny)
                {
                    item.NrEwidencyjny = value;
                    OnPropertyChanged(() => NrEwidencyjny);
                }
            }
        }
        public int? IdKlasyfikacjiKomputera
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
        public DateTime? DataProdukcji
        {
            get
            {
                return item.DataProdukcji;
            }
            set
            {
                if (value != item.DataProdukcji)
                {
                    item.DataProdukcji = value;
                    OnPropertyChanged(() => DataProdukcji);
                }
            }
        }
        public bool? CzyAktywny
        {
            get
            {
                return item.CzyAktywny;
            }
            set
            {
                if (value != item.CzyAktywny)
                {
                    item.CzyAktywny = value;
                    OnPropertyChanged(() => CzyAktywny);
                }
            }
        }
        public int? IdUrzadzeniaWeWy
        {
            get
            {
                return item.IdUrzadzeniaWeWy;

            }
            set
            {
                if (value != item.IdUrzadzeniaWeWy)
                {
                    item.IdUrzadzeniaWeWy=value;
                    OnPropertyChanged(() => IdUrzadzeniaWeWy);
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
        public IQueryable<ComboboxKeyAndValue> StanTechnicznyComboboxItems
        {
            get
            {
                return
                    (
                    from stanowisko in sprzetKomputerowyEntities.StanTechniczny
                    select new ComboboxKeyAndValue
                    {
                        Key = stanowisko.IdStanuTechnicznego,
                        Value = stanowisko.NazwaStanuTechnicznego,
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
                    from stanowisko in sprzetKomputerowyEntities.Osoby
                    select new ComboboxKeyAndValue
                    {
                        Key = stanowisko.IdOsoby,
                        Value = stanowisko.Imie+" "+ stanowisko.Nazwisko,
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
                    from stanowisko in sprzetKomputerowyEntities.Lokalizacja
                    select new ComboboxKeyAndValue
                    {
                        Key = stanowisko.IdLokalizacji,
                        Value = stanowisko.NazwaLokalizacji,
                    }
                    ).ToList().AsQueryable();
            }
        }
        #endregion Properties
        #region Helpers
        public override void save()
        {
            sprzetKomputerowyEntities.Komputery.Add(item);
            sprzetKomputerowyEntities.SaveChanges();
        }
        #endregion Helpers
    }
}
