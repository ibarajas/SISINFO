using System.Collections.Generic;
using Newtonsoft.Json;
using System.Linq;
using System.Collections.ObjectModel;
using System.Globalization;

namespace SISINFO.Clases
{
	/// <summary>
	/// Clase que sirve de modelo para la información de un profesor
	/// </summary> 
	public class Profesor
	{
		/// <summary>
		/// El nombre de un profesor. Comienza por sus apellidos
		/// </summary> 
		public string Nombre { get; set; }

		/// <summary>
		/// La dirección de correo electrónico de un profesor
		/// </summary> 
		public string Email { get; set; }

		/// <summary>
		/// La primera letra de su apellido
		/// </summary> 
		public string Inicial { get; set; }

		/// <summary>
		/// Método estático que obtiene la lista de profesores con sus datos desde un archivo json
		/// </summary> 
		public static List<Profesor> ObtenerProfesores()
		{
			string json = Utilerias.LeerArchivoJson ("profesores");
			List<Profesor> lista = JsonConvert.DeserializeObject<List<Profesor>> (json);

			foreach (Profesor prof in lista) {
				prof.Inicial = prof.Nombre.Substring (0, 1);
			}

			return lista.OrderBy(p => p.Nombre).ToList();
		}

		/// <summary>
		/// Método estático que realiza una búsqueda no sensible a mayúsculas y minúsculas sobre la lista de profesores
		/// <param name="lista">La lista original de profesores sobre la que se buscará</param>
		/// <param name="busqueda">La cadena de búsqueda</param>
		/// </summary> 
		public static List<Profesor> BuscarProfesores(List<Profesor> lista, string busqueda)
		{
			return lista.Where(p => CultureInfo.CurrentCulture.CompareInfo.IndexOf(p.Nombre, busqueda, CompareOptions.IgnoreCase) >= 0).ToList();
		}
	}
}

