using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using UI.Models;
using UI.Utilities;

namespace UI.ViewModels
{
    public class SubVM : INotifyPropertyChanged, IQueryAttributable
    {
        #region Attributes
        private string resultado;
        private DelegateCommand jugar;
        private DelegateCommand salir;
        #endregion

        #region Properties
        public string Resultado { get { return resultado; } }
        public DelegateCommand Jugar { get { return jugar; } }
        public DelegateCommand Salir { get { return salir; } }
        #endregion

        #region CommandExecuters
        private async void jugar_execute()
        {
            await Shell.Current.GoToAsync("///AdivinarDepartamentos");
        }
        private void salir_execute() => System.Environment.Exit(0);
        #endregion

        #region Constructors
        public SubVM()
        {
            jugar = new DelegateCommand(jugar_execute);
            salir = new DelegateCommand(salir_execute);
        }
        #endregion

        #region Methods
        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            resultado = query["Resultado"] as string;
            OnPropertyChanged("Resultado");
        }
        #endregion

        #region ViewModel
        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = "")
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        #endregion
    }
}
