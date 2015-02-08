using System;
using Gtk;

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
	}

	protected void OnButtonUpperClicked (object sender, EventArgs e)
	{
		textview1.Buffer.Text = textview1.Buffer.Text.ToUpper ();
	}

	protected void OnButtonLowerClicked (object sender, EventArgs e)
	{
		textview1.Buffer.Text = textview1.Buffer.Text.ToLower ();
	}
}
