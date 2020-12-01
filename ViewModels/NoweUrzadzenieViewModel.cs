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
    public class NoweUrzadzenieViewModel:JedenViewModel<Urzadzenia>
    {

        #region Fields
        //To jest pole do komendy, ktora zostanie podpieta pod przycisk z trzema kropkami, ktory wywola okno do wybierania Kontrahenta
        private BaseCommand _ShowKlasyfikacjaCommand;
        private BaseCommand _ShowStanTechnicznyCommand;
        private BaseCommand _ShowPracownikCommand;
        private BaseCommand _ShowLokalizacjaCommand;
        #endregion Fields
        #region Constructor
        public NoweUrzadzenieViewModel()
            : base("Nowe Urzadzenie")
        {
            //Ustawiamy co wyświetla się w tytule zakładki
            item = new Urzadzenia();
            //To jest nasluchiwanie na wybranego Kontrahenta w oknie modalny, po zlapaniu Kontrahenta wywola sie metoda getWybranyKontrahent
           // Messenger.Default.Register<StanTechnicznyForAllView>(this, getWybranyStan);
        }
        #endregion Constructor
        #region Command
        public ICommand ShowKlasyfikacjaCommand
        {
            get
            {
                if (_ShowKlasyfikacjaCommand == null)
                {
                    //Po kliknieciu na button z trzema kropkami do MainWindowViewModel Messengerem zostanie wsylany komunikat wywolujacy okno ze wszystkimi Kontrahentami
                    _ShowKlasyfikacjaCommand = new BaseCommand(() => Messenger.Default.Send("KlasyfikacjaShow"));
                }
                return _ShowKlasyfikacjaCommand;
            }
        }
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
        public int IdUrzadzenia
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
        public int? IdKlasyfikacji
        {
            get
            {
                return item.IdKlasyfikacji;
            }
            set
            {
                if (value != item.IdKlasyfikacji)
                {
                    item.IdKlasyfikacji = value;
                    OnPropertyChanged(() => IdKlasyfikacji);
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

        public int? IdStanuTechnicznego
        {
            get
            {
                return item.IdStanuTechnicznego;
            }
            set
            {
                if (value != item.IdStanuTechnicznego)
                {
                    item.IdStanuTechnicznego = value;
                    OnPropertyChanged(() => IdStanuTechnicznego);
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
        public int? IDKomputera
        {
            get
            {
                return item.IDKomputera;
            }
            set
            {
                if (value != item.IDKomputera)
                {
                    item.IDKomputera = value;
                    OnPropertyChanged(() => IDKomputera);
                }
            }
        }
        public int? idOsoby
        {
            get
            {
                return item.idOsoby;
            }
            set
            {
                if (value != item.idOsoby)
                {
                    item.idOsoby = value;
                    OnPropertyChanged(() => idOsoby);
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
        public IQueryable<ComboboxKeyAndValue> KlasyfikacjaComboboxItems
        {
            get
            {
                return
                    (
                    from stanowisko in sprzetKomputerowyEntities.KlasyfikacjaUrzadzenia
                    select new ComboboxKeyAndValue
                    {
                        Key = stanowisko.IdKlasyfikacjiUrzadzenia,
                        Value = stanowisko.NazwaKlasyfikacji,
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
                        Value = stanowisko.Imie+" "+stanowisko.Nazwisko,
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
        private void getWybranyStan(StanTechnicznyForAllView stan)
        {
            
        }
        private void getWybranaklasyfikacja(KlasyfikacjaForAllView stan)
        {

        }
        private void getWybranyPracownik(PracownikForAllView stan)
        {

        }
        private void getLokalizacja(LokalizacjaForAllView stan)
        {

        }
        public override void save()
        {
            sprzetKomputerowyEntities.Urzadzenia.Add(item);
            sprzetKomputerowyEntities.SaveChanges();
        }
        #endregion Helpers
    }
}