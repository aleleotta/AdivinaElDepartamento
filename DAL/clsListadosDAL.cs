using Entities;

namespace DAL
{
    public class clsListadosDAL
    {
        /// <summary>
        /// Devuelve un listado completo de personas rellenado con datos inventados.
        /// </summary>
        /// <returns>El listado completo de personas.</returns>
        public static List<clsPersona> getListadoCompletoPersonas()
        {
            List<clsPersona> listadoPersonas = new List<clsPersona>
            {
                new clsPersona(),
            };
            return listadoPersonas;
        }

        /// <summary>
        /// Devuelve un listado completo de departamentos rellenado con datos inventados.
        /// </summary>
        /// <returns>El listado completo de departamentos.</returns>
        public static List<clsDepartamento> getListadoCompletoDepartamentos()
        {
            List<clsDepartamento> listadoDepartamentos = new List<clsDepartamento>
            {
                new clsDepartamento(),
            };
            return listadoDepartamentos;
        }

        /// <summary>
        /// Devuelve una sola persona usando el id en el parametro para identificarla.
        /// </summary>
        /// <param name="idPersona">El id de la persona a devolver.</param>
        /// <param name="listadoPersonas">El listado completo de personas.</param>
        /// <returns>La persona con el id correspondiente.</returns>
        public static clsPersona devolverPersona(int idPersona)
        {
            List<clsPersona> listadoPersonas = getListadoCompletoPersonas();
            bool encontrado = false;
            int count = 0;
            clsPersona persona = new clsPersona();
            while (!encontrado && count < listadoPersonas.Count)
            {
                if (listadoPersonas[count].Id == idPersona)
                {
                    encontrado = true;
                    persona = listadoPersonas[count];
                }
                else
                {
                    count++;
                }
            }
            if (!encontrado)
            {
                persona = new clsPersona();
            }
            return persona;
        }

        /// <summary>
        /// Devuelve un solo departamento usando el id en el parametro para identificarlo.
        /// </summary>
        /// <param name="idDepartamento">El id del departamento a devolver.</param>
        /// <param name="listadoDepartamentos">El listado completo de departamentos</param>
        /// <returns>El departamento con el id correspondiente.</returns>
        public static clsDepartamento devolverDepartamento(int idDepartamento)
        {
            List<clsDepartamento> listadoDepartamentos = getListadoCompletoDepartamentos();
            bool encontrado = false;
            int count = 0;
            clsDepartamento departamento = new clsDepartamento();
            while (!encontrado)
            {
                if (listadoDepartamentos[count].Id == idDepartamento)
                {
                    encontrado = true;
                    departamento = listadoDepartamentos[count];
                }
                else
                {
                    count++;
                }
            }
            if (!encontrado)
            {
                departamento = new clsDepartamento();
            }
            return departamento;
        }
    }
}
