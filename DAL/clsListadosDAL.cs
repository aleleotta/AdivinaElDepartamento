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
                new clsPersona(1, "Fernando", "Galiana", 1),
                new clsPersona(2, "Maria", "Lopez", 1),
                new clsPersona(3, "Juan", "Martinez", 2),
                new clsPersona(4, "Ana", "Garcia", 2),
                new clsPersona(5, "Carlos", "Rodriguez", 3),
                new clsPersona(6, "Laura", "Sanchez", 3),
                new clsPersona(7, "Pedro", "Diaz", 4),
                new clsPersona(8, "Elena", "Perez", 4),
                new clsPersona(9, "Diego", "Ruiz", 5),
                new clsPersona(10, "Sara", "Gomez", 5),
                new clsPersona(11, "Manuel", "Alvarez", 6),
                new clsPersona(12, "Carmen", "Fernandez", 6),
                new clsPersona(13, "Pablo", "Morales", 1),
                new clsPersona(14, "Rosa", "Jimenez", 1),
                new clsPersona(15, "Daniel", "Navarro", 2),
                new clsPersona(16, "Luisa", "Romero", 2),
                new clsPersona(17, "Javier", "Hernandez", 3),
                new clsPersona(18, "Marta", "Ortega", 3),
                new clsPersona(19, "Alberto", "Sanz", 4),
                new clsPersona(20, "Natalia", "Vega", 4),
                new clsPersona(21, "Roberto", "Iglesias", 5),
                new clsPersona(22, "Isabel", "Mendez", 5)
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
                new clsDepartamento(1, "Marketing"),
                new clsDepartamento(2, "Ventas"),
                new clsDepartamento(3, "Contabilidad"),
                new clsDepartamento(4, "Recursos Humanos"),
                new clsDepartamento(5, "Informatica"),
                new clsDepartamento(6, "Produccion")

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
