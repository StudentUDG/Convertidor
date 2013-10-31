using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Convertidor
{
	
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
			
		void Button1Click(object sender, EventArgs e)
		{
			double a, b, r;
			string s;
			
			if(tasa.Text == "" && peso.Text == "")
				MessageBox.Show("Ambos campos vacios");
			try {
				
				a = Convert.ToDouble(peso.Text);
		     	b = Convert.ToDouble(tasa.Text);
		    
		     	r = a/b;
		     
		    	s = Convert.ToString(r);
		    	
		    	if(peso.Text == "" || peso.Text == "0" || peso.Text == "0.0")
				MessageBox.Show("Campo Peso(MX) vacio!!");
		    	if(tasa.Text == "" || tasa.Text == "0" || tasa.Text == "0.0"){
					MessageBox.Show("Campo Tasa (flexible) vacio!!");
				return;
		    	}
		    	
		     	dolar.Text = s;
		     	
			}catch(Exception){
			
				MessageBox.Show("Datos Incorrectos!! sea Introducido: ["+peso.Text+"] y ["+tasa.Text+"]");
		    	return;
			}
			
		  
		}
		
		}
	
	}

	    
	
		

	


	
