using DAL;
using Entities;
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
    public class MainVM : INotifyPropertyChanged
    {
        #region Attributes
        private ObservableCollection<clsPersonaConListadoDepartamentosYDepartamentoSeleccionado> listadoPersonas;
        private clsPersonaConListadoDepartamentosYDepartamentoSeleccionado personaSeleccionada;
        private DelegateCommand comprobar;
        private DelegateCommand salir;
        #endregion

        #region Properties
        public ObservableCollection<clsPersonaConListadoDepartamentosYDepartamentoSeleccionado> ListadoPersonas { get { return listadoPersonas; } }
        public clsPersonaConListadoDepartamentosYDepartamentoSeleccionado PersonaSeleccionada
        {
            get
            {
                return personaSeleccionada;
            }
            set
            {
                if (value != null)
                {
                    personaSeleccionada = value;
                    comprobar.RaiseCanExecuteChanged();
                }
            }
        }
        public DelegateCommand Comprobar { get { return comprobar; } }
        public DelegateCommand Salir { get { return salir; } }
        #endregion

        #region CommandExecuters
        private async void comprobar_execute()
        {
            bool encontradoFallo = false;
            int count = 0;
            string res = "Enhorabuena!\nHas adivinado todos los departamentos!";
            while (!encontradoFallo && count < listadoPersonas.Count)
            {
                if (listadoPersonas[count].DepartamentoSeleccionado.Id != listadoPersonas[count].IdDept)
                {
                    encontradoFallo = true;
                    res = "Has fallado uno o mas departamentos.\nIntentalo de nuevo!";
                }
                count++;
            }
            Dictionary<string, object> pack = new Dictionary<string, object>
            {
                {"Resultado", res}
            };
            await Shell.Current.GoToAsync("///Resultado", false, pack);
        }
        private bool comprobar_canExecute()
        {
            bool encontradoSinDept = false;
            int count = 0;
            while (!encontradoSinDept && count < listadoPersonas.Count)
            {
                if (listadoPersonas[count].DepartamentoSeleccionado == null)
                {
                    encontradoSinDept = true;
                }
                count++;
            }
            return !encontradoSinDept;
        }
        private void salir_execute() => System.Environment.Exit(0);
        #endregion

        #region Constructors
        public MainVM()
        {
            listadoPersonas = getListadoPersonasConDepartamento();
            comprobar = new DelegateCommand(comprobar_execute, comprobar_canExecute);
            salir = new DelegateCommand(salir_execute);
        }
        #endregion

        #region Methods
        private ObservableCollection<clsPersonaConListadoDepartamentosYDepartamentoSeleccionado> getListadoPersonasConDepartamento()
        {
            ObservableCollection<clsPersonaConListadoDepartamentosYDepartamentoSeleccionado> listadoPersonasConDepartamento = new();
            List<clsPersona> listadoPersonasGenericas = clsListadosDAL.getListadoCompletoPersonas();
            foreach (clsPersona persona in listadoPersonasGenericas)
            {
                clsPersonaConListadoDepartamentosYDepartamentoSeleccionado personaConDepartamento = new clsPersonaConListadoDepartamentosYDepartamentoSeleccionado(persona);
                listadoPersonasConDepartamento.Add(personaConDepartamento);
            }
            return listadoPersonasConDepartamento;
        }

        public void raiseCanExecuteOutsideVM()
        {
            comprobar.RaiseCanExecuteChanged();
        }
        #endregion

        #region ViewModel
        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = "")
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        #endregion
    }
}
