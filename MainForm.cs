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
		    
			try {
				
				a = Convert.ToDouble(peso.Text);
		     	b = Convert.ToDouble(tasa.Text);
		    
		     	r = a/b;
		     
		    	s = Convert.ToString(r);
		     	dolar.Text = s;
		     	
			}catch(Exception){
			
				MessageBox.Show("Datos Incorrectos!! sea Introducido: ["+peso.Text+"] y ["+tasa.Text+"]");
		    	return;
			}
			
		  
		}
		
		}
	
	}

	    
	
		

	
