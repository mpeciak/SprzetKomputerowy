using SprzetKomputerowy.Helpers;
using SprzetKomputerowy.Models.Entities;
using SprzetKomputerowy.ViewModels.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SprzetKomputerowy.ViewModels
{
    public abstract class JedenViewModel<T> : WorkspaceViewModels
    {
        #region Fields
        //obiekt odpowiedzisalny za  polaczenie z baza dasnych
        //        protected BHPEntities2 bhpEntities;
        protected SprzetKomputerowyEntities1 sprzetKomputerowyEntities;
        //obiekt ktory symbolizuje dodawany rekord
        protected T item;
        //komenda do zapisu obiektu
        private BaseCommand _SaveCommand;
        #endregion Fields

        #region Constructor
        public JedenViewModel(String displayName)
        {
            base.DisplayName = displayName;
            //          bhpEntities = new BHPEntities2();
            sprzetKomputerowyEntities = new SprzetKomputerowyEntities1();
        }
        #endregion Constructor

        #region Command
        public ICommand SaveCommand
        {
            get
            {
                if (_SaveCommand == null)
                {
                    _SaveCommand = new BaseCommand(() => saveAndClose());
                }
                return _SaveCommand;

            }

        }
        #endregion Command
        #region Helpers
        public abstract void save();
        private void saveAndClose()
        {
            if (isValid())
            {
                save();
                onRequestClose();
            }
            else ShowMessageBox("Wprowadzono niepoprawne dane");
            //onRequestClose();
        }

        #endregion Helpers

        #region Validation
        public virtual bool isValid()
        {
            return true;
        }
        #endregion Validation
    }
}