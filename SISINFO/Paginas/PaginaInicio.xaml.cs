using System;
using System.Collections.Generic;
using Xamarin.Forms;
using SISINFO.Estilos;

namespace SISINFO.Paginas
{
	/// <summary>
	/// Página de inicio de la app
	/// </summary> 
	public partial class PaginaInicio : ContentPage
	{
		/// <summary>
		/// Muestra la interfaz
		/// </summary> 
		public PaginaInicio ()
		{
			Resources = new EstilosGlobales().Resources;
			InitializeComponent ();
		}

		/// <summary>
		/// Navega a la página de Profesores
		/// </summary> 
		void btnProfesores_Clicked(object sender, EventArgs e)
		{
			Navigation.PushAsync (new PaginaProfesores ());
		}

		/// <summary>
		/// Navega a la página de Acerca de
		/// </summary> 
		void btnAcercaDe_Clicked(object sender, EventArgs e)
		{
			Navigation.PushAsync (new PaginaAcercaDe ());
		}
	}
}

