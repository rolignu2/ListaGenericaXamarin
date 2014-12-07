using System;
using Android.Database.Sqlite;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Views;
using Android.Widget;

namespace ListaXamarin
{
	public class SqliteServer : SQLiteOpenHelper
	{


		protected static String DbName = "BddPrueba";
		protected static  int version = 1;

		public SqliteServer (Activity context) : 
		base (context , DbName , null, version)
		{

		}
			
		#region implemented abstract members of SQLiteOpenHelper

		public override void OnCreate (SQLiteDatabase db)
		{
			if(db.IsReadOnly)
			{
				db = WritableDatabase;
			}

			String tablas = "CREATE TABLE USER IF NOT EXISTS ("
				+ "ID_USER INT PRIMARY KEY , "
				+ "USUARIO TEXT NOT NULL, "
				+ "COMMENT TEXT NOT NULL  );";

			db.ExecSQL (tablas);

			throw new NotImplementedException ();
		
		}

		public override void OnUpgrade (SQLiteDatabase db, int oldVersion, int newVersion)
		{
			throw new NotImplementedException ();
		}

		#endregion


	}
}

