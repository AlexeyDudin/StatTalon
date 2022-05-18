using StatTalon.src.DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatTalon.src.Forms
{
    public partial class Main : Form
    {
        private DataBaseWorker db = null;
        private IllList illListWindow = null;
        public Main()
        {
            InitializeComponent();
            db = new DataBaseWorker();
        }
        private void InitializeDataBase()
        {
            db.DataSetStatTalon = this.dataSetStatTalon;
            db.Mkb_TableTableAdapter = this.mkb_tableTableAdapter;
            db.FillAllTable();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            InitializeDataBase();
        }

        private void buttonIllWorker_Click(object sender, EventArgs e)
        {
            illListWindow = new IllList(ref db);
            this.Hide();
            illListWindow.ShowDialog();
            this.Show();
        }
    }
}
