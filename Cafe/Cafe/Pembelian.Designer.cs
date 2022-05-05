/*
 * Created by SharpDevelop.
 * User: ASUS
 * Date: 05/05/2022
 * Time: 11:40
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Cafe
{
	partial class Pembelian
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pembelian));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.tbTeh = new System.Windows.Forms.TextBox();
			this.tbMAB = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.btnProses = new System.Windows.Forms.Button();
			this.tbUang = new System.Windows.Forms.TextBox();
			this.tbTotal = new System.Windows.Forms.TextBox();
			this.tbPajak = new System.Windows.Forms.TextBox();
			this.tbBayar = new System.Windows.Forms.TextBox();
			this.tbKembalian = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(584, 99);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(179, 29);
			this.label1.TabIndex = 3;
			this.label1.Text = "PEMBAYARAN";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(264, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(250, 36);
			this.label2.TabIndex = 4;
			this.label2.Text = "CAFE SUKA JADI";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(50, 99);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(179, 29);
			this.label3.TabIndex = 5;
			this.label3.Text = "LIST MENU";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(23, 174);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(156, 23);
			this.label4.TabIndex = 11;
			this.label4.Text = "Teh (Panas/Dingin)";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(23, 233);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(156, 23);
			this.label5.TabIndex = 12;
			this.label5.Text = "Mie Ayam Biasa";
			// 
			// tbTeh
			// 
			this.tbTeh.Location = new System.Drawing.Point(223, 174);
			this.tbTeh.Name = "tbTeh";
			this.tbTeh.Size = new System.Drawing.Size(72, 22);
			this.tbTeh.TabIndex = 14;
			// 
			// tbMAB
			// 
			this.tbMAB.Location = new System.Drawing.Point(223, 233);
			this.tbMAB.Name = "tbMAB";
			this.tbMAB.Size = new System.Drawing.Size(77, 22);
			this.tbMAB.TabIndex = 15;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(431, 173);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(157, 23);
			this.label7.TabIndex = 16;
			this.label7.Text = "Uang yang di Kasih";
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(431, 281);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(157, 23);
			this.label8.TabIndex = 17;
			this.label8.Text = "Pajak 5%";
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(431, 232);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(157, 23);
			this.label9.TabIndex = 18;
			this.label9.Text = "Total Bayar";
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(431, 328);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(157, 23);
			this.label10.TabIndex = 19;
			this.label10.Text = "Pembayaran";
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(431, 427);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(157, 23);
			this.label11.TabIndex = 20;
			this.label11.Text = "Kembalian";
			// 
			// btnProses
			// 
			this.btnProses.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.btnProses.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnProses.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnProses.Location = new System.Drawing.Point(431, 378);
			this.btnProses.Name = "btnProses";
			this.btnProses.Size = new System.Drawing.Size(332, 28);
			this.btnProses.TabIndex = 21;
			this.btnProses.Text = "PROSES";
			this.btnProses.UseVisualStyleBackColor = false;
			this.btnProses.Click += new System.EventHandler(this.BtnProsesClick);
			// 
			// tbUang
			// 
			this.tbUang.Location = new System.Drawing.Point(595, 173);
			this.tbUang.Name = "tbUang";
			this.tbUang.Size = new System.Drawing.Size(168, 22);
			this.tbUang.TabIndex = 22;
			// 
			// tbTotal
			// 
			this.tbTotal.Location = new System.Drawing.Point(595, 232);
			this.tbTotal.Name = "tbTotal";
			this.tbTotal.Size = new System.Drawing.Size(168, 22);
			this.tbTotal.TabIndex = 23;
			// 
			// tbPajak
			// 
			this.tbPajak.Location = new System.Drawing.Point(595, 281);
			this.tbPajak.Name = "tbPajak";
			this.tbPajak.Size = new System.Drawing.Size(168, 22);
			this.tbPajak.TabIndex = 24;
			// 
			// tbBayar
			// 
			this.tbBayar.Location = new System.Drawing.Point(595, 328);
			this.tbBayar.Name = "tbBayar";
			this.tbBayar.Size = new System.Drawing.Size(168, 22);
			this.tbBayar.TabIndex = 25;
			// 
			// tbKembalian
			// 
			this.tbKembalian.Location = new System.Drawing.Point(595, 427);
			this.tbKembalian.Name = "tbKembalian";
			this.tbKembalian.Size = new System.Drawing.Size(168, 22);
			this.tbKembalian.TabIndex = 26;
			// 
			// Pembelian
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(831, 521);
			this.Controls.Add(this.tbKembalian);
			this.Controls.Add(this.tbBayar);
			this.Controls.Add(this.tbPajak);
			this.Controls.Add(this.tbTotal);
			this.Controls.Add(this.tbUang);
			this.Controls.Add(this.btnProses);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.tbMAB);
			this.Controls.Add(this.tbTeh);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Name = "Pembelian";
			this.Text = "Pembelian";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox tbKembalian;
		private System.Windows.Forms.TextBox tbBayar;
		private System.Windows.Forms.TextBox tbPajak;
		private System.Windows.Forms.TextBox tbTotal;
		private System.Windows.Forms.TextBox tbUang;
		private System.Windows.Forms.Button btnProses;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox tbMAB;
		private System.Windows.Forms.TextBox tbTeh;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
