using SprzetKomputerowy.Models.ForAllView;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprzetKomputerowy.ViewModels
{
    public class WszystkieZestawyViewModel:WszystkieViewModel<ZestawyForAllView>
    {
        #region Constructor
        public WszystkieZestawyViewModel()
            : base("Pokaż Zestawy")
        {
        }
        #endregion Constructor
        #region SortAndFind
        public override List<String> GetComboboxSortList()
        {
            return null;
        }
        public override void Sort()
        {}
        public override List<String> GetComboboxFindList()
        {
            return null;
        }
        public override void Find(){}
        
        #endregion SortAndFind
        #region Properties
        public ZestawyForAllView WybranyElement
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
        public override void select() { }
        public override void load()
        {
            List = new ObservableCollection<ZestawyForAllView>
              (
                   from kontrahenci in sprzetKomputerowyEntities.Zestawy //Dla kazdego pracownika  z bazy danych Pracownicy
                   select new ZestawyForAllView              //tworzymy nowy obiekt typu PracownocyForAllView
                   {
                      NazwaKomputera=kontrahenci.Komputery.Nazwakomputera,
                      NazwaUrzadzenia=kontrahenci.Urzadzenia.NazwaUrzadzenia,
                      NazwaKategori=kontrahenci.NazwaKategori,
                      Imie=kontrahenci.Osoby1.Imie+""+kontrahenci.Osoby1.Nazwisko,
                      NrEwidencji=kontrahenci.NrEwidencji,
                      Lokalizacja=kontrahenci.Lokalizacja.NazwaLokalizacji,
                   }
                );
        }
        public override void delete(){}
        public override void modyfikuj(){}
        #endregion Helpers
    }
}
