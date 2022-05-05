/*
 * Created by SharpDevelop.
 * User: ASUS
 * Date: 05/05/2022
 * Time: 11:40
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Cafe
{
	/// <summary>
	/// Description of Pembelian.
	/// </summary>
	public partial class Pembelian : Form
	{
		public Pembelian()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnProsesClick(object sender, EventArgs e)
		{
			double menuTeh, menuMAB, menuTotalBayar, menuUang, menuPajak, menuKembalian, menuBayar;
			double hargaTeh, hargaMAB;
			
			menuTeh = double.Parse(tbTeh.Text);
			menuMAB = double.Parse(tbMAB.Text);
			menuUang = double.Parse(tbUang.Text);
			
			hargaTeh = menuTeh * 6000;
			hargaMAB = menuMAB * 10000;
			
			menuTotalBayar = hargaTeh + hargaMAB;
			menuPajak = menuTotalBayar * 0.05;
			
			menuBayar = menuTotalBayar + menuPajak;
			menuKembalian = menuUang - menuBayar;
			
			tbTotal.Text = menuTotalBayar.ToString();
			tbPajak.Text = menuPajak.ToString();
			tbBayar.Text = menuBayar.ToString();
			tbKembalian.Text = menuKembalian.ToString();
		}
	}
}
