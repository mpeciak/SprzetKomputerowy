using SprzetKomputerowy.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprzetKomputerowy.ViewModels
{
    public class NowyStanTechnicznyViewModel: JedenViewModel<StanTechniczny>
    {

        #region Constructor
        public NowyStanTechnicznyViewModel()
            : base("Nowy Stan Techniczny")
        {
            //Ustawiamy co wyświetla się w tytule zakładki
            item = new StanTechniczny();
        }
        #endregion Constructor
        #region Properties
        public int IdStanuTechnicznego
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
        public string NazwaStanuTechnicznego
        {
            get
            {
                return item.NazwaStanuTechnicznego;
            }
            set
            {
                if (value != item.NazwaStanuTechnicznego)
                {
                    item.NazwaStanuTechnicznego = value;
                    OnPropertyChanged(() => NazwaStanuTechnicznego);
                }
            }
        }

        #endregion Properties
        #region Helpers
        public override void save()
        {
            sprzetKomputerowyEntities.StanTechniczny.Add(item);
            sprzetKomputerowyEntities.SaveChanges();
        }
        #endregion Helpers
    }
}
