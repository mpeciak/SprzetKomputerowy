using SprzetKomputerowy.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SprzetKomputerowy.ViewModels.Abstract
{
   public abstract class WorkspaceViewModels: BaseViewModels
   {

        #region Fields
        // to jest pole do komendy ktora zamknie zakladke
        private BaseCommand _CloseCommand;
        #endregion Fields

        #region Constructor
        public WorkspaceViewModels() { }
        #endregion Constructor

        #region Command
        // utworzymy wlasciwosc do komendy zamykajacej zakladke
        public ICommand CloseCommand
        {
            get
            {
                if (_CloseCommand == null)
                    _CloseCommand = new BaseCommand(() => onRequestClose()); // ta komenda wywola funkcje onRequestClose
                //ktora bedzie nizej
                return _CloseCommand;
            }
        }
        #endregion Command

        #region RequestClose
        // to jest zdazenie i funkcja potrzebna do
        // zamkniecia zakladki
        public event EventHandler RequestClose;
        protected void onRequestClose()
        {
            EventHandler handler = this.RequestClose;
            if (handler != null)
                handler(this, EventArgs.Empty);
        }
        #endregion RequestClose
    }

}
