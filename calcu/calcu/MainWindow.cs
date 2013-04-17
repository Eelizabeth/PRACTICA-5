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

	protected void OnBtnsumarClicked (object sender, EventArgs e)
	{
		int num1=int.Parse(this.numero1.Text);
	     int num2=int.Parse(this.numero2.Text);
		 int resultado =num1+num2;
		 this.resultado1.Text=resultado.ToString();
	}

	protected void OnBtnrestarClicked (object sender, EventArgs e)
	{
		int num1=int.Parse(this.numero1.Text);
		int num2=int.Parse(this.numero2.Text);
		int resultado =num1-num2;
		this.resultado1.Text=resultado.ToString();
	}

	protected void OnBtnMultClicked (object sender, EventArgs e)
	{
		int num1=int.Parse(this.numero1.Text);
		int num2=int.Parse(this.numero2.Text);
		int resultado =num1*num2;
		this.resultado1.Text=resultado.ToString();
	}

	protected void OnBtnDivClicked (object sender, EventArgs e)
	{
		int num1=int.Parse(this.numero1.Text);
		int num2=int.Parse(this.numero2.Text);
		int resultado =num1/num2;
		this.resultado1.Text=resultado.ToString();
	
	}
}
