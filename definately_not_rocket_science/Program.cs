using System;
using Gtk;

namespace definately_not_rocket_science
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Application.Init ();
			MainWindow win = new MainWindow ();
			win.Show ();
			Application.Run ();
		}

		protected virtual void OnButtonClearClicked(object sender, System.EventArgs e){

		}
	}
}
