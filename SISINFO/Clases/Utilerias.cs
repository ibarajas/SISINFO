using System;
using System.IO;
using System.Reflection;
using SISINFO.Paginas;
using Xamarin.Forms;

namespace SISINFO.Clases
{
	/// <summary>
	/// Clase estática con métodos estáticos de uso general
	/// </summary> 
	public static class Utilerias
	{

		/// <summary>
		/// Obtiene el prefijo respectivo al dispositivo donde se esté ejecutando la aplicación
		/// NOTA: Será más útil cuando se integren los proyectos de iOS y Windows Phone
		/// </summary> 
		private static string ObtenerPrefijo()
		{
			#if __IOS__
			return "SISINFO.iOS";
			#endif

			#if __ANDROID__
			return "SISINFO.Droid";
			#endif

			#if WINDOWS_PHONE
			return "SISINFO.WinPhone";
			#endif
		}

		/// <summary>
		/// Obtiene el flujo (stream) de un archivo
		/// <param name="archivo">El nombre del archivo que se desea abrir
		/// <param name="extension">La extension del archivo
		/// </summary> 
		private static Stream ObtenerStream(string archivo, string extension)
		{
			string recurso = String.Format ("{0}.{1}.{2}", ObtenerPrefijo(), archivo, extension);
			Assembly ensamblado = typeof(PaginaInicio).GetTypeInfo().Assembly;
			return ensamblado.GetManifestResourceStream (recurso);
		}

		/// <summary>
		/// Obtiene la cadena json contenida en un archivo
		/// <param name="archivo">El nombre del archivo que se desea abrir
		/// </summary> 
		public static string LeerArchivoJson(string archivo)
		{
			string json = "";
			Stream flujo = ObtenerStream (archivo, "json");

			using (StreamReader reader = new StreamReader (flujo)) {
				json = reader.ReadToEnd ();
			}

			return json;
		}

		/// <summary>
		/// Envío de correo electŕonico independiente de plataforma mediante dependencias de servicios
		/// <param name="destinatario">A quien se le envía el correo</param>
		/// <param name="asunto">El asunto del correo</param>
		/// <param name="mensaje">El cuerpo del correo</param>
		/// </summary> 
		public static void EnviarCorreo(string destinatario, string asunto, string mensaje)
		{
			DependencyService.Get<ICorreo> ().EnviarCorreo (destinatario, asunto, mensaje);
		}
	}
}