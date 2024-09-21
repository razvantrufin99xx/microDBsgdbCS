/*
 * Created by SharpDevelop.
 * User: razvan
 * Date: 9/21/2024
 * Time: 6:21 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace database
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		public class db
		{
			public List<sheet>sheets = new List<sheet>();
			
		}
		public class cell
		{
			public string value = "";
			public string datatype;
			public string format;
		}
		public class row
		{
			public List<cell> rowcells = new List<cell>();
		}
		public class sheet
		{
			public List<row> date = new List<row>();
			public int rows = 20;
			public int cols = 50;
			public void addall()
			{
				for(int i = 0 ; i < rows ; i++)
				{
					
					for(int j = 0 ; j < cols ; j++)
					{
						
						date[i].rowcells[j].value = " ";
						
					}
				}
			}
		}
	}
}
