using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StatTalon.src.DataBase;

namespace StatTalon.src.Forms
{
    public partial class IllList : Form
    {
        private DataBaseWorker db = null;
        private MKBTenWorker mKBTenWorker = null;
        private int editedId = 0;
        private Loader loadForm = null;

        public IllList(ref DataBaseWorker dataBase)
        {
            InitializeComponent();
            this.db = dataBase;
            mKBTenWorker = new MKBTenWorker(ref db);
            loadForm = new Loader(db.DataSetStatTalon.mkb_table.Rows.Count);
        }

        private void AddZeroLevelIll()
        {
            foreach (DataSetStatTalon.mkb_tableRow mkbRow in mKBTenWorker.GetParentRows())
            {
                treeViewIll.Nodes.Add(new TreeNode(string.Format("{0} ({1})", mkbRow.code, mkbRow.name)));
            }
        }

        private void CleanIll()
        {
            treeViewIll.Nodes.Clear();
            comboBoxParentIll.Items.Clear();
            comboBoxParentIll.Items.Add("Нет родительского класса болезни");
        }

        private void RecourceInsertLevelIll(DataSetStatTalon.mkb_tableRow[] mkbRows, TreeNode treeNode = null)
        {
            for (int i = 0; i < mkbRows.Length; i++)
            {
                DataSetStatTalon.mkb_tableRow mkbRow = mkbRows[i];
                loadForm.PerformStep();
                if (treeNode != null)
                {
                    treeNode.Nodes.Add(new TreeNode(string.Format("{0} ({1})", mkbRow.code, mkbRow.name)));
                    comboBoxParentIll.Items.Add(string.Format("{0} ({1})", mkbRow.code, mkbRow.name));
                    RecourceInsertLevelIll(mKBTenWorker.GetChildRows(mkbRow), treeNode.Nodes[i]);
                }
                else
                {
                    treeViewIll.Nodes.Add(new TreeNode(string.Format("{0} ({1})", mkbRow.code, mkbRow.name)));
                    comboBoxParentIll.Items.Add(string.Format("{0} ({1})", mkbRow.code, mkbRow.name));
                    RecourceInsertLevelIll(mKBTenWorker.GetChildRows(mkbRow), treeViewIll.Nodes[i]);
                }
            }
        }

        private void FillTreeViewIll() 
        {
            CleanIll();
            RecourceInsertLevelIll(mKBTenWorker.GetParentRows());
        }
        private void IllList_Load(object sender, EventArgs e)
        {
            this.Hide();
            loadForm.Show();
            FillTreeViewIll();
            loadForm.Hide();
            this.Show();
        }

        private void CleanTextBox()
        {
            textBoxCode.Text = "";
            textBoxName.Text = "";
            comboBoxParentIll.SelectedIndex = 0;
            comboBoxParentIll.SelectedItem = "Нет родительского класса болезни";
        }

        private void buttonAddIll_Click(object sender, EventArgs e)
        {
            int parentId = 0;
            try
            {
                parentId = mKBTenWorker.GetIdByCodeAndName(ParceCodeAndName(comboBoxParentIll.SelectedItem.ToString())[0].Trim(), ParceCodeAndName(comboBoxParentIll.SelectedItem.ToString())[1].Trim('(', ')'));
            }
            catch
            { }
            mKBTenWorker.AddRow(textBoxCode.Text, textBoxName.Text, parentId);
            FillTreeViewIll();
            CleanTextBox();
        }

        private string[] ParceCodeAndName(string name)
        {
            return name.Split('('); 
        }

        private void buttonEditIll_Click(object sender, EventArgs e)
        {
            buttonSave.Enabled = true;
            editedId = mKBTenWorker.GetIdByCodeAndName(ParceCodeAndName(treeViewIll.SelectedNode.Text)[0].Trim(), ParceCodeAndName(treeViewIll.SelectedNode.Text)[1].Trim('(', ')'));
            FillTreeViewIll();
            CleanTextBox();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            buttonSave.Enabled = false;
            mKBTenWorker.EditRow(editedId, textBoxCode.Text, textBoxName.Text);
            FillTreeViewIll();
        }

        private void RecourceDelete(TreeNode tn = null)
        {
            if (tn != null)
            {
                foreach (TreeNode tnode in tn.Nodes)
                {
                    RecourceDelete(tnode);
                    if (tnode.Checked)
                    {
                        mKBTenWorker.DeleteRow(mKBTenWorker.GetIdByCodeAndName(ParceCodeAndName(tnode.Text)[0].Trim(), ParceCodeAndName(tnode.Text)[1].Trim('(', ')')));
                    }
                }
            }
            else
            {
                foreach (TreeNode tnode in treeViewIll.Nodes)
                {
                    RecourceDelete(tnode);
                    if (tnode.Checked)
                    {
                        mKBTenWorker.DeleteRow(mKBTenWorker.GetIdByCodeAndName(ParceCodeAndName(tnode.Text)[0].Trim(), ParceCodeAndName(tnode.Text)[1].Trim('(', ')')));
                    }
                }
            }
        }

        private void buttonDeleteIll_Click(object sender, EventArgs e)
        {
            RecourceDelete();
        }

        private void RecourceCheckUncheckChildNodes(TreeNode checkedNode)
        {
            foreach (TreeNode tn in checkedNode.Nodes)
            {
                tn.Checked = checkedNode.Checked;
                RecourceCheckUncheckChildNodes(tn);
            }
        }


        private void treeViewIll_AfterCheck(object sender, TreeViewEventArgs e)
        {
            RecourceCheckUncheckChildNodes(e.Node);
        }
    }
}
