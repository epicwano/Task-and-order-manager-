using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_and_order_manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            cmbCategory.SelectedIndex = 0;
        }

        bool isUpdating = false;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAddtask_Click(object sender, EventArgs e)
        {

            lstTasks.Items.Add(lblTaskTitle.Text);
          
            dgvTasks.Rows.Add(lblTaskTitle.Text,cmbCategory.Text,chkIsUrgent.Checked ? "Urgent" : "Not Urgent",
                dtpDueDate.Value.ToShortDateString(),"Not Complete");

        }

        private void btnReset_Click(object sender, EventArgs e)
        {

            lblTaskTitle.Clear();

            cmbCategory.SelectedIndex = 0;
            chkIsUrgent.Checked = false;
            dtpDueDate.Value = DateTime.Now;

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int indexToRemove = -1;

            if (lstTasks.SelectedIndex != -1)
            {
                indexToRemove = lstTasks.SelectedIndex;
            }

            if (dgvTasks.CurrentRow != null && dgvTasks.CurrentRow.Index >= 0)
            {
                indexToRemove = dgvTasks.CurrentRow.Index;
            }

            if (indexToRemove != -1)
            {
                lstTasks.Items.RemoveAt(indexToRemove);
                dgvTasks.Rows.RemoveAt(indexToRemove);

               lstTasks.SelectedIndex = -1;
               dgvTasks.ClearSelection();
            }



        }

        private void chkIsMark_CheckedChanged(object sender, EventArgs e)
        {

            int indexToUpdate = -1;

            if (lstTasks.SelectedIndex != -1)
            {
                indexToUpdate = lstTasks.SelectedIndex;
            }

            if (dgvTasks.CurrentRow != null && dgvTasks.CurrentRow.Index >= 0)
            {
                indexToUpdate = dgvTasks.CurrentRow.Index;
            }


            if (indexToUpdate != -1)
            { 
                dgvTasks.Rows[indexToUpdate].Cells["IsComplete"].Value = chkIsMark.Checked ? "Complete" : "Not Complete";
            }

        }

        private void lstTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isUpdating)
                return;

            if (lstTasks.SelectedIndex != -1)
            {
                isUpdating = true;

                dgvTasks.CurrentCell = dgvTasks.Rows[lstTasks.SelectedIndex].Cells[0];

                if (dgvTasks.CurrentRow.Cells["IsComplete"].Value.ToString() == "Complete")
                {
                    chkIsMark.Checked = true;
                }
                else
                {
                    chkIsMark.Checked = false;
                }


                isUpdating = false;

            }

        }

        private void dgvTasks_SelectionChanged(object sender, EventArgs e)
        {     
            if (isUpdating)
                return;

            if (dgvTasks.CurrentRow != null && dgvTasks.CurrentRow.Index >= 0)
            {
                isUpdating = true;


                lstTasks.SelectedIndex = dgvTasks.CurrentRow.Index;

                if (dgvTasks.CurrentRow.Cells["IsComplete"].Value.ToString() == "Complete")
                {
                    chkIsMark.Checked = true;
                }
                else
                {
                    chkIsMark.Checked = false;
                }


                isUpdating = false;

            }


        }
    }
}
