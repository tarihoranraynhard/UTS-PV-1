/*
 * Created by SharpDevelop.
 * User: ASUS
 * Date: 05/05/2022
 * Time: 12:20
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Cafe
{
	/// <summary>
	/// Description of Pegawai.
	/// </summary>
	public partial class Pegawai : Form
	{
		MySqlConnection co = new MySqlConnection("Server = localhost; Database = cafe; Uid = root");
		MySqlCommand mycommand = new MySqlCommand();
		MySqlDataAdapter myadapter = new MySqlDataAdapter();
		
		public void ReadData(){
			try{
				mycommand.Connection = co;
				myadapter.SelectCommand = mycommand;
				mycommand.CommandText = "select * from data_pegawai";
				DataSet ds = new DataSet();

				if (myadapter.Fill(ds,"data_pegawai") > 0){
					dataGridView1.DataSource = ds;
					dataGridView1.DataMember = "data_pegawai";
				}
				co.Close();
			}
			catch (Exception ex){
				MessageBox.Show(ex.ToString());
			}
		}
		
		
		public void ResetData(){
			tbNIM.Text="";
			tbNama.Text="";
			tbJabatan.Text="";
		}
		
		public Pegawai()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			ReadData();
			ResetData();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnAddClick(object sender, EventArgs e)
		{
			if(tbNIM.Text.Trim() == "" || tbNama.Text.Trim() == "" || tbJabatan.Text.Trim() == ""){
				MessageBox.Show("Isi Setiap Kolom yang Tersedia Terlebih Dahulu");
			}
			else{			
			try{
				mycommand.Connection = co;
				myadapter.SelectCommand = mycommand;
				mycommand.CommandText = "INSERT INTO  data_pegawai VALUES ('"+tbNIM.Text+"','"+tbNama.Text+"','"+tbJabatan.Text+"')";
				DataSet ds = new DataSet();
				if (myadapter.Fill(ds, "data_pegawai")>0){
					dataGridView1.DataSource = ds;
					dataGridView1.DataMember = "data_pegawai";
				}
				MessageBox.Show("Data berhasil dimasukan","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
					ReadData();
					ResetData();
				co.Close();
			}
			catch(Exception ex){
				MessageBox.Show(ex.ToString());
			}
		}				
		}
		
		void BtnUpdateClick(object sender, EventArgs e)
		{
			if(tbNIM.Text.Trim() == "" || tbNama.Text.Trim() == "" || tbJabatan.Text.Trim() == ""){
				MessageBox.Show("Isi Setiap Kolom yang Tersedia Terlebih Dahulu");
			}
			else{
			try{
				mycommand.Connection = co;
				myadapter.SelectCommand = mycommand;
				mycommand.CommandText = "UPDATE data_pegawai SET nim='"+tbNIM.Text+"',nama='"+tbNama.Text+"',jabatan='"+tbJabatan.Text+"' WHERE nim ='"+tbNIM.Text+"'";
				DataSet ds = new DataSet();
				if (myadapter.Fill(ds, "data_pegawai")>0){
					dataGridView1.DataSource = ds;
					dataGridView1.DataMember = "data_pegawai";
				}
				MessageBox.Show("Data berhasil diupdate","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
					ReadData();
					ResetData();
				co.Close();
			}
			catch(Exception ex){
				MessageBox.Show(ex.ToString());
			}
		}
		}
		
		void BtnDeleteClick(object sender, EventArgs e)
		{
			if(MessageBox.Show("Yakin ingin menghapus "+tbNIM.Text+ "?", "Hapus Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes){
			try{
				mycommand.Connection = co;
				myadapter.SelectCommand = mycommand;
				mycommand.CommandText = "DELETE FROM data_pegawai WHERE nim='"+tbNIM.Text+"'";
				DataSet ds = new DataSet();
				if (myadapter.Fill(ds, "data_pegawai")>0){
					dataGridView1.DataSource = ds;
					dataGridView1.DataMember = "data_pegawai";
				}
				MessageBox.Show("Data berhasil dihapus","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
					ReadData();
					ResetData();
				co.Close();
			}
			catch(Exception ex){
				MessageBox.Show(ex.ToString());
			}
			}			
		}
		
		void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try{
					DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
					tbNIM.Text = row.Cells["nim"].Value.ToString();
					tbNama.Text = row.Cells["nama"].Value.ToString();
					tbJabatan.Text = row.Cells["jabatan"].Value.ToString();
				}
				catch(Exception ex){
					MessageBox.Show(ex.ToString());
				}		
		}
	}
}
