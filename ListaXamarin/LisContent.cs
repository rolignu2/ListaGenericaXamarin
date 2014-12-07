using System;
using System.Collections;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System.Collections.Generic;

namespace ListaXamarin
{
	public class LisContent : BaseAdapter
	{

		private List<string> ArrayList = new List<string> ();
		private Activity Context;


		public LisContent(Activity contex , List<String> array)
		{

			this.Context = contex;
			this.ArrayList = array;
		}

		#region implemented abstract members of BaseAdapter


		public override Java.Lang.Object GetItem (int position)
		{
			return this.ArrayList [position];
		}

		public override long GetItemId (int position)
		{
			return position;
		}

		public override View GetView (int position, View convertView, ViewGroup parent)
		{
			string data = this.GetItem(position).ToString();

			var view = convertView ?? this.Context.LayoutInflater.Inflate (
				Resource.Layout.BaseList,null);

			var TextSolver = view.FindViewById<TextView> (Resource.Id.txtdata);
			TextSolver.Text = data;

			return view;
		}

		public override int Count {
			get {
				return this.ArrayList.Count;
			}
		}

		#endregion




	}
}

