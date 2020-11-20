using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Firebase.Firestore;
using FirestoreExample.Droid.Implementations;
using FirestoreExample.Interfaces;

[assembly: Xamarin.Forms.Dependency(typeof(FirebaseImplementation))]
namespace FirestoreExample.Droid.Implementations
{
	public class FirebaseImplementation : IFirebase
	{
		public void InitFirebase()
		{
			var FirestoreIstance = FirebaseFirestore.GetInstance(MainActivity.MyFirebaseApp);
			//var FirestoreIstance = FirebaseFirestore.Instance;
			if (FirestoreIstance != null)
			{
				//DO SOMETHING
			}

		}
	}
}