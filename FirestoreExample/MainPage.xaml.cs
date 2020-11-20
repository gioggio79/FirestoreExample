using FirestoreExample.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FirestoreExample
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

		private void FirebaseInit(object sender, EventArgs e)
		{
			DependencyService.Get<IFirebase>().InitFirebase();
		}
	}
}
