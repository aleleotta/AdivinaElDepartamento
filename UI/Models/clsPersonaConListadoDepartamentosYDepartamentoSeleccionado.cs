using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Models
{
    public class clsPersonaConListadoDepartamentosYDepartamentoSeleccionado : clsPersona
    {
        private ObservableCollection<clsDepartamento> listadoDepartamentos;
        private clsDepartamento departamentoSeleccionado;

        public ObservableCollection<clsDepartamento> ListadoDepartamentos { get { return listadoDepartamentos; } }
        public clsDepartamento DepartamentoSeleccionado
        {
            get
            {
                return departamentoSeleccionado;
            }
            set
            {
                if (value != null)
                {
                    departamentoSeleccionado = value;
                }
            }
        }

        public clsPersonaConListadoDepartamentosYDepartamentoSeleccionado(clsPersona persona) : base(persona)
        {
            listadoDepartamentos = new ObservableCollection<clsDepartamento>(clsListadosDAL.getListadoCompletoDepartamentos());
        }

    }
}
