using System;
using System.Collections.Generic;
using Xamarin.Forms;
using SISINFO.Clases;
using SISINFO.Estilos;

namespace SISINFO.Paginas
{
	/// <summary>
	/// Página que muestra la lista de profesores. Se puede enviar correo electrónico a un profesor seleccionado.
	/// También es posible realizar búsquedas en base al nombre
	/// </summary> 
	public partial class PaginaProfesores : ContentPage
	{
		/// <summary>
		/// Muestra la interfaz
		/// </summary> 
		public PaginaProfesores ()
		{
			Resources = new EstilosGlobales().Resources;
			InitializeComponent ();
		}

		/// <summary>
		/// Cuando se muestra la página, cargar la lista de profesores
		/// </summary> 
		protected override void OnAppearing ()
		{
			base.OnAppearing ();

			App.ListaProfesores = Profesor.ObtenerProfesores ();
			lstProfesores.ItemsSource = App.ListaProfesores;
		}

		/// <summary>
		/// Envío de correo electrónico al profesor seleccionado
		/// </summary> 
		void btnCorreo_Clicked(object sender, EventArgs e)
		{
			if (lstProfesores.SelectedItem != null){
				Profesor profesor = (Profesor)lstProfesores.SelectedItem;
				Utilerias.EnviarCorreo (profesor.Email, "", "");
			}
			else{
				DisplayAlert ("Error", "Debes seleccionar un profesor primero", "De acuerdo");
			}
		}

		/// <summary>
		/// Manejador de evento del cambio de texto en la caja de búsqueda
		/// Busca profesores por su nombre y muestra el resultado en la lista
		/// </summary> 
		void txtProfesores_TextChanged(object sender, TextChangedEventArgs e)
		{
			if (e.OldTextValue != null) {
				lstProfesores.ItemsSource = Profesor.BuscarProfesores (App.ListaProfesores, txtProfesores.Text);
			}
		}

	}
}