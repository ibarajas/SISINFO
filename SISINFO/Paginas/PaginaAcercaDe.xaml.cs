using System;
using System.Collections.Generic;

using Xamarin.Forms;
using SISINFO.Clases;
using SISINFO.Estilos;

namespace SISINFO.Paginas
{
	/// <summary>
	/// Página que muestra el historial de versiones de la aplicación, así como datos del equipo de desarrollo
	/// </summary> 
	public partial class PaginaAcercaDe : ContentPage
	{
		/// <summary>
		/// Muestra la interfaz
		/// </summary> 
		public PaginaAcercaDe ()
		{
			InitializeComponent ();
			Resources = new EstilosGlobales().Resources;
		}

		/// <summary>
		/// Envío de correo electrónico a soporte
		/// </summary> 
		void btnCorreo_Clicked(object sender, EventArgs e)
		{
			Utilerias.EnviarCorreo ("luis.beltran@itcelaya.edu.mx", "Sobre SISINFO app", "");
		}
	}
}

