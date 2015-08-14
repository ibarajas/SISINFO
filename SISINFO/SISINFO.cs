using System;
using Xamarin.Forms;
using System.Collections.Generic;
using SISINFO.Clases;
using SISINFO.Estilos;
using SISINFO.Paginas;

namespace SISINFO
{
	public class App : Application
	{
		/// <summary>
		/// La lista de profesores que se obtienen al leer el archvo
		/// </summary> 
		public static List<Profesor> ListaProfesores;

		public App ()
		{
			Resources = new EstilosGlobales ().Resources;
			// The root page of your application
			MainPage = new NavigationPage(new PaginaInicio());
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

