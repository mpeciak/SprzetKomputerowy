using SprzetKomputerowy.Models.ForAllView;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprzetKomputerowy.ViewModels
{
    public class WszystkieKomputeryViewModel:WszystkieViewModel<KomputeryForAllView>
    {
        #region Constructor
        public WszystkieKomputeryViewModel()
            : base("Pokaż Komputery")
        {
        }
        #endregion Constructor
        #region SortAndFind
        public override List<String> GetComboboxSortList()
        {
            return null;
        }
        public override void Sort()
        { }
        public override List<String> GetComboboxFindList()
        {
            return null;
        }
        public override void Find() { }

        #endregion SortAndFind
        #region Properties
        public KomputeryForAllView WybranyElement
        {
            get
            {
                return _WybranyElement;
            }
            set
            {
                if (value != _WybranyElement)
                {
                    _WybranyElement = value;

                }
            }
        }
        #endregion Properties
        #region Helpers
        public override void load()
        {
            List = new ObservableCollection<KomputeryForAllView>
              (
                   from kontrahenci in sprzetKomputerowyEntities.Komputery //Dla kazdego pracownika  z bazy danych Pracownicy
                   select new KomputeryForAllView              //tworzymy nowy obiekt typu PracownocyForAllView
                   {
                       NazwaKomputera = kontrahenci.Nazwakomputera,
                       Producent = kontrahenci.Producent,
                       DataProdukcji = kontrahenci.DataProdukcji,
                       Imie = kontrahenci.Osoby.Imie+" "+kontrahenci.Osoby.Nazwisko,
                       NrEwidencji = kontrahenci.NrEwidencyjny,
                       Lokalizacja = kontrahenci.Lokalizacja.NazwaLokalizacji,
                   }
                );
        }
        public override void select() { }
        public override void delete() { }
        public override void modyfikuj() { }
        #endregion Helpers
    }
}