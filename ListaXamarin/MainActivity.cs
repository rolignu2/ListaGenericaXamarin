using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace ListaXamarin
{
	[Activity (Label = "ListaXamarin", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
		
			SetContentView (Resource.Layout.Main);

			Button button = FindViewById<Button> (Resource.Id.myButton);
			Button button2 = FindViewById<Button> (Resource.Id.button1);

			button.Click += delegate {
				ShowList();
			};


			button2.Click += (object sender, EventArgs e) => 
			{
				//Segunda lista
				Toast t = new Toast(this);
				t.SetText("Pronto crearemos la segunda lista con sqlite" );
				t.Duration = ToastLength.Long;
				t.Show();
			};

		}


		protected void ShowList()
		{
			Intent i = new Intent(this , new ListaActivity().Class);
			StartActivity (i);
		}



	
	}
}


