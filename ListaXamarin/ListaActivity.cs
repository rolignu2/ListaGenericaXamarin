
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

namespace ListaXamarin
{
	[Activity (Label = "ListaActivity")]			
	public class ListaActivity : Activity
	{

		private ListView Lista;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.Lista);

			Lista = (ListView)FindViewById (Resource.Id.vista_listado);

			this.GetListData ();
		}

		private void GetListData()
		{

			List<string> data = new List<string>() {
				"Rolando" ,
				"Antonio" ,
				"Arriaza" , 
				"Marroquin",
			};
			try
			{
				Lista.Adapter = new LisContent(this, data);
			}
			catch(Exception ex){
				Toast.MakeText (this , ex.Message ,ToastLength.Long ).Show ();
			}


		}


	}



}

