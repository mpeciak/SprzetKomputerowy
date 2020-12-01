using GalaSoft.MvvmLight.Messaging;
using SprzetKomputerowy.Helpers;
using SprzetKomputerowy.ViewModels.Abstract;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Input;

namespace SprzetKomputerowy.ViewModels
{
    public class MainWindowViewModel: BaseViewModels
    {
        #region Fields
        //okno zawiera kolekcje linkow tylko do odczytu
        private ReadOnlyCollection<CommandViewModels> _Commands;
        //ale tez zakladek
        private ObservableCollection<WorkspaceViewModels> _Workspaces;
        #endregion Fields
        #region CommandsMenu
        //te komendy sa po to zeby dzialalo menu i pasek narzedzi
        public ICommand NowaOsobaCommand
        {
            get
            {
                //komenda towarCommand wywoluje funkcje createTowar, ktora wyswietla nowa zakladke i jest zdefiniowana nizej 
                return new BaseCommand(() => ShowNowaOsoba());
            }
        }
        public ICommand NowaLokalizacjaCommand
        {
            get
            {
                //komenda towarCommand wywoluje funkcje createTowar, ktora wyswietla nowa zakladke i jest zdefiniowana nizej 
                return new BaseCommand(() => ShowNowaLokalizacja());
            }
        }
        public ICommand NowyDzialCommand
        {
            get
            {
                //komenda towarCommand wywoluje funkcje createTowar, ktora wyswietla nowa zakladke i jest zdefiniowana nizej 
                return new BaseCommand(() => ShowNowyDzial());
            }
        }
        public ICommand NowyKomputerCommand
        {
            get
            {
                //komenda towarCommand wywoluje funkcje createTowar, ktora wyswietla nowa zakladke i jest zdefiniowana nizej 
                return new BaseCommand(() => ShowNowyKomputer());
            }
        }
        public ICommand NoweUrzadzenieCommand
        {
            get
            {
                //komenda towarCommand wywoluje funkcje createTowar, ktora wyswietla nowa zakladke i jest zdefiniowana nizej 
                return new BaseCommand(() => ShowNoweUrzadzenie());
            }
        }
        public ICommand NoweUrzadzenieWeWyCommand
        {
            get
            {
                //komenda towarCommand wywoluje funkcje createTowar, ktora wyswietla nowa zakladke i jest zdefiniowana nizej 
                return new BaseCommand(() => ShowNoweUrzadzenieWeWy());
            }
        }
        public ICommand NowyZestawCommand
        {
            get
            {
                //komenda towarCommand wywoluje funkcje createTowar, ktora wyswietla nowa zakladke i jest zdefiniowana nizej 
                return new BaseCommand(() => ShowNowyZestaw());
            }
        }
        public ICommand WszystkieKomputeryCommand
        {
            get
            {
                //komenda towarCommand wywoluje funkcje createTowar, ktora wyswietla nowa zakladke i jest zdefiniowana nizej 
                return new BaseCommand(() => ShowWszystkieKomputery());
            }
        }
        public ICommand WszystkieUrzadzeniaCommand
        {
            get
            {
                //komenda towarCommand wywoluje funkcje createTowar, ktora wyswietla nowa zakladke i jest zdefiniowana nizej 
                return new BaseCommand(() => ShowWszystkieUrzadzenia());
            }
        }
        //public ICommand WszystkieUrzadzeniaWeWyCommand
        //{
        //    get
        //    {
        //        //komenda towarCommand wywoluje funkcje createTowar, ktora wyswietla nowa zakladke i jest zdefiniowana nizej 
        //        return new BaseCommand(() => ShowWszystkieUrzadzeniaWeWy());
        //    }
        //}
        //public ICommand WszystkieOsobyCommand
        //{
        //    get
        //    {
        //        //komenda towarCommand wywoluje funkcje createTowar, ktora wyswietla nowa zakladke i jest zdefiniowana nizej 
        //        return new BaseCommand(() => ShowWszystkieOsoby());
        //    }
        //}
        #endregion CommandsMenu
        #region Commands
        //tworzymy propertisa do _Commands
        public ReadOnlyCollection<CommandViewModels> Commands
        {
            get
            {
                if (_Commands == null)
                {
                    //tworzymy liste poniewaz readonlycollection nie mozna modifikowac
                    //a zatem cmds jest po to żeby było wzorcem dla readonlycollection
                    List<CommandViewModels> cmds = this.createCommands();
                    _Commands = new ReadOnlyCollection<CommandViewModels>(cmds);
                }
                return _Commands;
            }
        }
        //to jest funckja ktora tworzy komendy
        public List<CommandViewModels> createCommands()
        {

            //tworzymy nowa liste linkow
            return new List<CommandViewModels>
            {
                //kazdy element listy to nowy CommandViewModel o pierwszym parametrze
                //takim jak nazwa linku a drugim parametr mowi jaka funkcje wywolac
                //po kliknieciu
                    new CommandViewModels("Nowe Urzadzenie",
                        new BaseCommand(()=>this.ShowNoweUrzadzenie())),
                    new CommandViewModels("Nowy Komputer",
                        new BaseCommand(()=>this.ShowNowyKomputer())),
                    new CommandViewModels("Nowy Zestaw",
                        new BaseCommand(()=>this.ShowNowyZestaw())),
                    new CommandViewModels("Nowa Osoba",
                        new BaseCommand(()=>this.ShowNowaOsoba())),
                    new CommandViewModels("Nowe Podzespoly",
                        new BaseCommand(()=>this.ShowNowePodzespoly())),
                    new CommandViewModels("Nowa Kat. Komputera",
                        new BaseCommand(()=>this.ShowNowaKategoriaKomputera())),
                    new CommandViewModels("Nowa Kat. Urzadzenia ",
                        new BaseCommand(()=>this.ShowNowaKategoriaUrzadzenia())),
                    new CommandViewModels("Nowe Urzadzenie. WeWy",
                        new BaseCommand(()=>this.ShowNoweUrzadzenieWeWy())),
                    new CommandViewModels("Nowy Dzial",
                        new BaseCommand(()=>this.ShowNowyDzial())),
                    new CommandViewModels("Wszystkie Zestawy",
                        new BaseCommand(()=>this.ShowWszystkieZestawy())),
                    new CommandViewModels("Wszystkie Komputery",
                        new BaseCommand(()=>this.ShowWszystkieKomputery())),
                    new CommandViewModels("Wszystkie Urzadzenia",
                        new BaseCommand(()=>this.ShowWszystkieUrzadzenia())),
            };
        }
        #endregion Commands
        public MainWindowViewModel()
        {
            Messenger.Default.Register<string>(this, open);
        }
        #region Workspaces
        //tworzymy propertisa do pola _Workspaces
        public ObservableCollection<WorkspaceViewModels> Workspaces
        {
            get
            {
                if (_Workspaces == null)
                {
                    _Workspaces = new ObservableCollection<WorkspaceViewModels>();
                    _Workspaces.CollectionChanged += this.onWorkspacesChanged;
                }
                return _Workspaces;
            }
        }
        private void onWorkspacesChanged(object sender,
            NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null && e.NewItems.Count != 0)
                foreach (WorkspaceViewModels workspace in e.NewItems)
                    workspace.RequestClose += this.onWorkspaceRequestClose;
            if (e.OldItems != null && e.OldItems.Count != 0)
                foreach (WorkspaceViewModels workspace in e.OldItems)
                    workspace.RequestClose -= this.onWorkspaceRequestClose;
        }
        private void onWorkspaceRequestClose(object sender, EventArgs e)
        {
            WorkspaceViewModels workspace = sender as WorkspaceViewModels;
            this.Workspaces.Remove(workspace);
        }
        #endregion Workspaces

        #region Helpers
        private void ShowNoweUrzadzenie()
        {
            //tworzymy nowa zakladke do dodawania towaru
            NoweUrzadzenieViewModel workspace = new NoweUrzadzenieViewModel();
            //dodajemy ją do kolekcji zakladek
            this.Workspaces.Add(workspace);
            //i wlaczamy jej aktywnosc
            this.setActiveWorkspace(workspace);
            if (workspace == null)
            {
                workspace = new NoweUrzadzenieViewModel();
                this.Workspaces.Add(workspace);
            }
            this.setActiveWorkspace(workspace);
        }

        private void ShowWszystkieZestawy()
        {
            //tworzymy nowa zakladke do dodawania towaru
            WszystkieZestawyViewModel workspace = new WszystkieZestawyViewModel();
            //dodajemy ją do kolekcji zakladek
            this.Workspaces.Add(workspace);
            //i wlaczamy jej aktywnosc
            this.setActiveWorkspace(workspace);
            if (workspace == null)
            {
                workspace = new WszystkieZestawyViewModel();
                this.Workspaces.Add(workspace);
            }
            this.setActiveWorkspace(workspace);
        }
        private void ShowWszystkieUrzadzenia()
        {
            //tworzymy nowa zakladke do dodawania towaru
            WszystkieUrzadzeniaViewModel workspace = new WszystkieUrzadzeniaViewModel();
            //dodajemy ją do kolekcji zakladek
            this.Workspaces.Add(workspace);
            //i wlaczamy jej aktywnosc
            this.setActiveWorkspace(workspace);
            if (workspace == null)
            {
                workspace = new WszystkieUrzadzeniaViewModel();
                this.Workspaces.Add(workspace);
            }
            this.setActiveWorkspace(workspace);
        }
        private void ShowNoweUrzadzenieWeWy()
        {
            //tworzymy nowa zakladke do dodawania towaru
            NoweUrzadzenieWeWyViewModel workspace = new NoweUrzadzenieWeWyViewModel();
            //dodajemy ją do kolekcji zakladek
            this.Workspaces.Add(workspace);
            //i wlaczamy jej aktywnosc
            this.setActiveWorkspace(workspace);
            if (workspace == null)
            {
                workspace = new NoweUrzadzenieWeWyViewModel();
                this.Workspaces.Add(workspace);
            }
            this.setActiveWorkspace(workspace);
        }

        private void ShowNowaKategoriaUrzadzenia()
        {
            //tworzymy nowa zakladke do dodawania towaru
            NowaKategoriaUrzadzeniaViewModel workspace = new NowaKategoriaUrzadzeniaViewModel();
            //dodajemy ją do kolekcji zakladek
            this.Workspaces.Add(workspace);
            //i wlaczamy jej aktywnosc
            this.setActiveWorkspace(workspace);
            if (workspace == null)
            {
                workspace = new NowaKategoriaUrzadzeniaViewModel();
                this.Workspaces.Add(workspace);
            }
            this.setActiveWorkspace(workspace);
        }
        private void ShowNowePodzespoly()
        {
            //tworzymy nowa zakladke do dodawania towaru
            NowePodzespolyViewModel workspace = new NowePodzespolyViewModel();
            //dodajemy ją do kolekcji zakladek
            this.Workspaces.Add(workspace);
            //i wlaczamy jej aktywnosc
            this.setActiveWorkspace(workspace);
            if (workspace == null)
            {
                workspace = new NowePodzespolyViewModel();
                this.Workspaces.Add(workspace);
            }
            this.setActiveWorkspace(workspace);
        }
        private void ShowNowaOsoba()
        {
            //tworzymy nowa zakladke do dodawania towaru
            NowaOsobaViewModel workspace = new NowaOsobaViewModel();
            //dodajemy ją do kolekcji zakladek
            this.Workspaces.Add(workspace);
            //i wlaczamy jej aktywnosc
            this.setActiveWorkspace(workspace);
            if (workspace == null)
            {
                workspace = new NowaOsobaViewModel();
                this.Workspaces.Add(workspace);
            }
            this.setActiveWorkspace(workspace);
        }
        private void ShowNowyDzial()
        {
            //tworzymy nowa zakladke do dodawania towaru
            NowyDzialViewModel workspace = new NowyDzialViewModel();
            //dodajemy ją do kolekcji zakladek
            this.Workspaces.Add(workspace);
            //i wlaczamy jej aktywnosc
            this.setActiveWorkspace(workspace);
            if (workspace == null)
            {
                workspace = new NowyDzialViewModel();
                this.Workspaces.Add(workspace);
            }
            this.setActiveWorkspace(workspace);
        }
        private void ShowNowyKomputer()
        {
            //tworzymy nowa zakladke do dodawania towaru
            NowyKomputerViewModel workspace = new NowyKomputerViewModel();
            //dodajemy ją do kolekcji zakladek
            this.Workspaces.Add(workspace);
            //i wlaczamy jej aktywnosc
            this.setActiveWorkspace(workspace);
            if (workspace == null)
            {
                workspace = new NowyKomputerViewModel();
                this.Workspaces.Add(workspace);
            }
            this.setActiveWorkspace(workspace);
        }
        private void ShowNowaKategoriaKomputera()
        {
            //tworzymy nowa zakladke do dodawania towaru
            NowaKategoriaKomputeraViewModel workspace = new NowaKategoriaKomputeraViewModel();
            //dodajemy ją do kolekcji zakladek
            this.Workspaces.Add(workspace);
            //i wlaczamy jej aktywnosc
            this.setActiveWorkspace(workspace);
            if (workspace == null)
            {
                workspace = new NowaKategoriaKomputeraViewModel();
                this.Workspaces.Add(workspace);
            }
            this.setActiveWorkspace(workspace);
        }
        private void ShowNowaLokalizacja()
        {
            //tworzymy nowa zakladke do dodawania towaru
            NowaLokalizacjaViewModel workspace = new NowaLokalizacjaViewModel();
            //dodajemy ją do kolekcji zakladek
            this.Workspaces.Add(workspace);
            //i wlaczamy jej aktywnosc
            this.setActiveWorkspace(workspace);
            if (workspace == null)
            {
                workspace = new NowaLokalizacjaViewModel();
                this.Workspaces.Add(workspace);
            }
            this.setActiveWorkspace(workspace);
        }
        private void ShowWszystkieKomputery()
        {
            //tworzymy nowa zakladke do dodawania towaru
            WszystkieKomputeryViewModel workspace = new WszystkieKomputeryViewModel();
            //dodajemy ją do kolekcji zakladek
            this.Workspaces.Add(workspace);
            //i wlaczamy jej aktywnosc
            this.setActiveWorkspace(workspace);
            if (workspace == null)
            {
                workspace = new WszystkieKomputeryViewModel();
                this.Workspaces.Add(workspace);
            }
            this.setActiveWorkspace(workspace);
        }
        private void ShowStanTechniczny()
        {
            //tworzymy nowa zakladke do dodawania towaru
            NowyStanTechnicznyViewModel workspace = new NowyStanTechnicznyViewModel();
            //dodajemy ją do kolekcji zakladek
            this.Workspaces.Add(workspace);
            //i wlaczamy jej aktywnosc
            this.setActiveWorkspace(workspace);
            if (workspace == null)
            {
                workspace = new NowyStanTechnicznyViewModel();
                this.Workspaces.Add(workspace);
            }
            this.setActiveWorkspace(workspace);
        }
        private void ShowNowyZestaw()
        {
            //tworzymy nowa zakladke do dodawania towaru
            NowyZestawViewModel workspace = new NowyZestawViewModel();
            //dodajemy ją do kolekcji zakladek
            this.Workspaces.Add(workspace);
            //i wlaczamy jej aktywnosc
            this.setActiveWorkspace(workspace);
            if (workspace == null)
            {
                workspace = new NowyZestawViewModel();
                this.Workspaces.Add(workspace);
            }
            this.setActiveWorkspace(workspace);
        }
  
        private void setActiveWorkspace(WorkspaceViewModels workspace)
        {
            Debug.Assert(this.Workspaces.Contains(workspace));

            ICollectionView collectionView =
                CollectionViewSource.GetDefaultView(this.Workspaces);
            if (collectionView != null)
                collectionView.MoveCurrentTo(workspace);
        }

        private void open(string komunikat)
        {

            if (komunikat == "KlasyfikacjaShow")
            {
                ShowNowaKategoriaUrzadzenia();
            }
            if (komunikat == "StanTechnicznyShow")
            {
               ShowStanTechniczny();
            }
            if (komunikat == "PracownikShow")
            {
                ShowNowaOsoba();
            }
            if (komunikat == "LokalizacjaShow")
            {
                ShowNowaLokalizacja();
            }
        }
        #endregion Helpers

    }
}
