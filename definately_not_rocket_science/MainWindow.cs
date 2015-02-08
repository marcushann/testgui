using System;
using Gtk;
using System.IO;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnButtonClearClicked (object sender, EventArgs e)
	{
		textview1.Buffer.Text = "";
		//comment
	}

	protected void OnButtonUpperClicked (object sender, EventArgs e)
	{
		textview1.Buffer.Text = textview1.Buffer.Text.ToUpper ();
	}

	protected void OnButtonLowerClicked (object sender, EventArgs e)
	{
		textview1.Buffer.Text = textview1.Buffer.Text.ToLower ();
	}

	protected void OnButtonSaveClicked (object sender, EventArgs e)
	{
		StreamWriter sw = new StreamWriter ("Test.txt");
		sw.Write (textview1.Buffer.Text);
		textview1.Buffer.Text = "Saved To File!";
		sw.Close ();
	}
}
