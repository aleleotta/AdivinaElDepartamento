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
                }
            }
        }
        public DelegateCommand Salir { get { return salir; } }
        #endregion

        #region CommandExecuters
        private void salir_execute() => System.Environment.Exit(0);
        #endregion

        #region Constructors
        public MainVM()
        {
            listadoPersonas = getListadoPersonasConDepartamento();
            salir = new DelegateCommand(salir_execute);
        }
        #endregion

        #region Methods
        private ObservableCollection<clsPersonaConListadoDepartamentosYDepartamentoSeleccionado> getListadoPersonasConDepartamento()
        {
            ObservableCollection<clsPersonaConListadoDepartamentosYDepartamentoSeleccionado> listadoPersonasConDepartamento = new();
            List<clsPersona> listadoPersonasGenericas = clsListadosDAL.getListadoCompletoPersonas();
            return listadoPersonasConDepartamento;
        }
        #endregion

        #region ViewModel
        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = "")
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        #endregion
    }
}
