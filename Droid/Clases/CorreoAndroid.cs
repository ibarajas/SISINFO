using System;
using SISINFO.Clases;
using SISINFO.Droid;
using Android.Content;
using Xamarin.Forms;

[assembly: Dependency(typeof(CorreoAndroid))]
namespace SISINFO.Droid
{
	/// <summary>
	/// Clase de Android que envía correos electrónicos
	/// </summary> 
	public class CorreoAndroid : ICorreo
	{
		/// <summary>
		/// Requerido por el servicio de dependencia. No remover.
		/// </summary> 
		public CorreoAndroid (){ }

		/// <summary>
		/// Envío de correo electŕonico desde Android
		/// <param name="destinatario">A quien se le envía el correo</param>
		/// <param name="asunto">El asunto del correo</param>
		/// <param name="mensaje">El cuerpo del correo</param>
		/// </summary> 
		#region Implementacion de ICorreo
		public void EnviarCorreo (string destinatario, string asunto, string mensaje)
		{

			Intent email = new Intent(Intent.ActionSend);
			email.PutExtra(Intent.ExtraEmail, destinatario);
			email.PutExtra(Intent.ExtraSubject, asunto);
			email.PutExtra(Intent.ExtraText, "Enviado desde SISINFO app para Android");
			email.PutExtra(Intent.ExtraHtmlText, true);
			email.SetType("message/rfc822");
			Forms.Context.StartActivity (email);
		}
		#endregion
	}
}

