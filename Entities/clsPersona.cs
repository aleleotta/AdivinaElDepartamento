using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class clsPersona
    {
        #region Attributes
        private int id;
        private string nombre = "";
        private string apellidos = "";
        private int idDept;
        #endregion

        #region Properties
        public int Id { get { return id; } }
        public string Nombre { get { return nombre; } }
        public string Apellidos { get { return apellidos; } }
        public int IdDept { get { return idDept; } }
        #endregion

        #region Constructors
        public clsPersona() { }
        public clsPersona(int id, string nombre, string apellidos, int idDept)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.idDept = idDept;
        }
        public clsPersona(clsPersona persona)
        {
            id = persona.id;
            nombre = persona.nombre;
            apellidos = persona.apellidos;
            idDept = persona.idDept;
        }
        #endregion
    }
}
