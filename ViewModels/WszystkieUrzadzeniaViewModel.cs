using SprzetKomputerowy.Models.ForAllView;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprzetKomputerowy.ViewModels
{
    public class WszystkieUrzadzeniaViewModel:WszystkieViewModel<UrzadzeniaForAllView>
    {
        #region Constructor
        public WszystkieUrzadzeniaViewModel()
            : base("Pokaż Urzadzenia")
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
        public UrzadzeniaForAllView WybranyElement
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
            List = new ObservableCollection<UrzadzeniaForAllView>
              (
                   from kontrahenci in sprzetKomputerowyEntities.Urzadzenia //Dla kazdego pracownika  z bazy danych Pracownicy
                   select new UrzadzeniaForAllView              //tworzymy nowy obiekt typu PracownocyForAllView
                   {
                       NazwaUrzadzenia=kontrahenci.NazwaUrzadzenia,
                       NrEwidencyjny=kontrahenci.NrEwidencyjny,
                       NrSeryjny=kontrahenci.NrSeryjny,
                       Producent=kontrahenci.Producent,
                       DataProdukcji=kontrahenci.DataProdukcji,
                       Klasyfikacja=kontrahenci.KlasyfikacjaUrzadzenia.NazwaKlasyfikacji,
                       Imie=kontrahenci.Osoby.Imie+" "+kontrahenci.Osoby.Nazwisko,
                       StanTechniczny=kontrahenci.StanTechniczny.NazwaStanuTechnicznego,
                       Lokalizacja = kontrahenci.Lokalizacja.NazwaLokalizacji,
                       //Opis=kontrahenci.Opis,
                   }
                );
        }
        public override void select() { }
        public override void delete() { }
        public override void modyfikuj() { }
        #endregion Helpers
    }
}
