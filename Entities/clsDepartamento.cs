using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class clsDepartamento
    {
        #region Attributes
        private int id;
        private string nombreDept = "";
        #endregion

        #region Properties
        public int Id { get { return id; } }
        public string NombreDept { get { return nombreDept; } }
        #endregion

        #region Constructors
        public clsDepartamento() { }
        public clsDepartamento(int id, string nombreDept)
        {
            this.id = id;
            this.nombreDept = nombreDept;
        }
        #endregion
    }
}
