
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.Fixed fixed1;
	private global::Gtk.Button btnsumar;
	private global::Gtk.Button btnrestar;
	private global::Gtk.Button btnMult;
	private global::Gtk.Button btnDiv;
	private global::Gtk.Label label1;
	private global::Gtk.Label numero27;
	private global::Gtk.Label resultado;
	private global::Gtk.Entry numero1;
	private global::Gtk.Entry numero2;
	private global::Gtk.Entry resultado1;
	
	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.fixed1 = new global::Gtk.Fixed ();
		this.fixed1.Name = "fixed1";
		this.fixed1.HasWindow = false;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.btnsumar = new global::Gtk.Button ();
		this.btnsumar.CanFocus = true;
		this.btnsumar.Name = "btnsumar";
		this.btnsumar.UseUnderline = true;
		this.btnsumar.Label = global::Mono.Unix.Catalog.GetString ("sumar");
		this.fixed1.Add (this.btnsumar);
		global::Gtk.Fixed.FixedChild w1 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.btnsumar]));
		w1.X = 1;
		w1.Y = 193;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.btnrestar = new global::Gtk.Button ();
		this.btnrestar.CanFocus = true;
		this.btnrestar.Name = "btnrestar";
		this.btnrestar.UseUnderline = true;
		this.btnrestar.Label = global::Mono.Unix.Catalog.GetString ("restar");
		this.fixed1.Add (this.btnrestar);
		global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.btnrestar]));
		w2.X = 89;
		w2.Y = 192;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.btnMult = new global::Gtk.Button ();
		this.btnMult.CanFocus = true;
		this.btnMult.Name = "btnMult";
		this.btnMult.UseUnderline = true;
		this.btnMult.Label = global::Mono.Unix.Catalog.GetString ("multiplicar");
		this.fixed1.Add (this.btnMult);
		global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.btnMult]));
		w3.X = 172;
		w3.Y = 187;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.btnDiv = new global::Gtk.Button ();
		this.btnDiv.CanFocus = true;
		this.btnDiv.Name = "btnDiv";
		this.btnDiv.UseUnderline = true;
		this.btnDiv.Label = global::Mono.Unix.Catalog.GetString ("dividir");
		this.fixed1.Add (this.btnDiv);
		global::Gtk.Fixed.FixedChild w4 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.btnDiv]));
		w4.X = 272;
		w4.Y = 180;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label1 = new global::Gtk.Label ();
		this.label1.Name = "label1";
		this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("numero1");
		this.fixed1.Add (this.label1);
		global::Gtk.Fixed.FixedChild w5 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.label1]));
		w5.X = 10;
		w5.Y = 9;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.numero27 = new global::Gtk.Label ();
		this.numero27.Name = "numero27";
		this.numero27.LabelProp = global::Mono.Unix.Catalog.GetString ("numero2");
		this.fixed1.Add (this.numero27);
		global::Gtk.Fixed.FixedChild w6 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.numero27]));
		w6.Y = 44;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.resultado = new global::Gtk.Label ();
		this.resultado.Name = "resultado";
		this.resultado.LabelProp = global::Mono.Unix.Catalog.GetString ("resultado");
		this.fixed1.Add (this.resultado);
		global::Gtk.Fixed.FixedChild w7 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.resultado]));
		w7.X = 6;
		w7.Y = 100;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.numero1 = new global::Gtk.Entry ();
		this.numero1.CanFocus = true;
		this.numero1.Name = "numero1";
		this.numero1.IsEditable = true;
		this.numero1.InvisibleChar = '●';
		this.fixed1.Add (this.numero1);
		global::Gtk.Fixed.FixedChild w8 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.numero1]));
		w8.X = 60;
		w8.Y = 5;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.numero2 = new global::Gtk.Entry ();
		this.numero2.CanFocus = true;
		this.numero2.Name = "numero2";
		this.numero2.IsEditable = true;
		this.numero2.InvisibleChar = '●';
		this.fixed1.Add (this.numero2);
		global::Gtk.Fixed.FixedChild w9 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.numero2]));
		w9.X = 55;
		w9.Y = 38;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.resultado1 = new global::Gtk.Entry ();
		this.resultado1.CanFocus = true;
		this.resultado1.Name = "resultado1";
		this.resultado1.IsEditable = true;
		this.resultado1.InvisibleChar = '●';
		this.fixed1.Add (this.resultado1);
		global::Gtk.Fixed.FixedChild w10 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.resultado1]));
		w10.X = 75;
		w10.Y = 85;
		this.Add (this.fixed1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 476;
		this.DefaultHeight = 300;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.btnsumar.Clicked += new global::System.EventHandler (this.OnBtnsumarClicked);
		this.btnrestar.Clicked += new global::System.EventHandler (this.OnBtnrestarClicked);
		this.btnMult.Clicked += new global::System.EventHandler (this.OnBtnMultClicked);
		this.btnDiv.Clicked += new global::System.EventHandler (this.OnBtnDivClicked);
	}
}