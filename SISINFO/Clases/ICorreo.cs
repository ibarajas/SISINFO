namespace SISINFO.Clases
{
	/// <summary>
	/// Interfaz para el envío de correo electrónico independiente de plataforma
	/// </summary> 
	public interface ICorreo
	{
		/// <summary>
		/// Envía un correo electrónico a un destinatario con el asunto y mensaje indicados
		/// <param name="destinatario">A quien se le envía el correo</param>
		/// <param name="asunto">El asunto del correo</param>
		/// <param name="mensaje">El cuerpo del correo</param>
		/// </summary> 
		void EnviarCorreo(string destinatario, string asunto, string mensaje);
	}
}

