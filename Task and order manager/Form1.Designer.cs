namespace Task_and_order_manager
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTaskTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chkIsUrgent = new System.Windows.Forms.CheckBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnAddtask = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstTasks = new System.Windows.Forms.ListBox();
            this.btnRemoveTasks = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvTasks = new System.Windows.Forms.DataGridView();
            this.chkMarkAsCompleted = new System.Windows.Forms.CheckBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Task = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Catagory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Urgent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsComplete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkIsMark = new System.Windows.Forms.CheckBox();
            this.btnDeleteFullTask = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Font = new System.Drawing.Font("Tahoma", 45F);
            this.label1.ForeColor = System.Drawing.Color.Fuchsia;
            this.label1.Location = new System.Drawing.Point(239, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(694, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "Task Manager Applaction";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Fuchsia;
            this.panel1.Controls.Add(this.btnAddtask);
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.chkIsUrgent);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dtpDueDate);
            this.panel1.Controls.Add(this.cmbCategory);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblTaskTitle);
            this.panel1.Location = new System.Drawing.Point(29, 125);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(547, 313);
            this.panel1.TabIndex = 2;
            // 
            // lblTaskTitle
            // 
            this.lblTaskTitle.Location = new System.Drawing.Point(30, 55);
            this.lblTaskTitle.Name = "lblTaskTitle";
            this.lblTaskTitle.Size = new System.Drawing.Size(186, 20);
            this.lblTaskTitle.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label2.Location = new System.Drawing.Point(67, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter the task : ";
            // 
            // cmbCategory
            // 
            this.cmbCategory.AllowDrop = true;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "Personal",
            "For Work",
            "For Study",
            "For Shopping"});
            this.cmbCategory.Location = new System.Drawing.Point(30, 140);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(121, 21);
            this.cmbCategory.TabIndex = 2;
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.Location = new System.Drawing.Point(30, 217);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDueDate.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label3.Location = new System.Drawing.Point(36, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Catagory :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label4.Location = new System.Drawing.Point(36, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Date :";
            // 
            // chkIsUrgent
            // 
            this.chkIsUrgent.AutoSize = true;
            this.chkIsUrgent.Font = new System.Drawing.Font("Tahoma", 14F);
            this.chkIsUrgent.Location = new System.Drawing.Point(244, 52);
            this.chkIsUrgent.Name = "chkIsUrgent";
            this.chkIsUrgent.Size = new System.Drawing.Size(101, 27);
            this.chkIsUrgent.TabIndex = 6;
            this.chkIsUrgent.Text = "IsUrgent";
            this.chkIsUrgent.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Plum;
            this.btnReset.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnReset.Location = new System.Drawing.Point(343, 193);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(178, 44);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnAddtask
            // 
            this.btnAddtask.BackColor = System.Drawing.Color.MediumPurple;
            this.btnAddtask.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnAddtask.Location = new System.Drawing.Point(343, 143);
            this.btnAddtask.Name = "btnAddtask";
            this.btnAddtask.Size = new System.Drawing.Size(178, 44);
            this.btnAddtask.TabIndex = 9;
            this.btnAddtask.Text = "Add To list";
            this.btnAddtask.UseVisualStyleBackColor = false;
            this.btnAddtask.Click += new System.EventHandler(this.btnAddtask_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Fuchsia;
            this.label5.Font = new System.Drawing.Font("Tahoma", 20F);
            this.label5.Location = new System.Drawing.Point(378, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 33);
            this.label5.TabIndex = 10;
            this.label5.Text = "Main panle";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.btnRemoveTasks);
            this.groupBox1.Controls.Add(this.lstTasks);
            this.groupBox1.Location = new System.Drawing.Point(601, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(547, 325);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quick look";
            // 
            // lstTasks
            // 
            this.lstTasks.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lstTasks.FormattingEnabled = true;
            this.lstTasks.ItemHeight = 18;
            this.lstTasks.Location = new System.Drawing.Point(6, 19);
            this.lstTasks.Name = "lstTasks";
            this.lstTasks.Size = new System.Drawing.Size(470, 292);
            this.lstTasks.TabIndex = 0;
            this.lstTasks.SelectedIndexChanged += new System.EventHandler(this.lstTasks_SelectedIndexChanged);
            // 
            // btnRemoveTasks
            // 
            this.btnRemoveTasks.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnRemoveTasks.Location = new System.Drawing.Point(478, 19);
            this.btnRemoveTasks.Name = "btnRemoveTasks";
            this.btnRemoveTasks.Size = new System.Drawing.Size(65, 292);
            this.btnRemoveTasks.TabIndex = 10;
            this.btnRemoveTasks.Text = "Delete";
            this.btnRemoveTasks.UseVisualStyleBackColor = false;
            this.btnRemoveTasks.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Purple;
            this.groupBox2.Controls.Add(this.btnDeleteFullTask);
            this.groupBox2.Controls.Add(this.chkIsMark);
            this.groupBox2.Controls.Add(this.chkMarkAsCompleted);
            this.groupBox2.Controls.Add(this.dgvTasks);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(12, 467);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1136, 256);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Full details";
            // 
            // dgvTasks
            // 
            this.dgvTasks.AllowUserToAddRows = false;
            this.dgvTasks.AllowUserToDeleteRows = false;
            this.dgvTasks.AllowUserToOrderColumns = true;
            this.dgvTasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTasks.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTasks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Task,
            this.Catagory,
            this.Urgent,
            this.Date,
            this.IsComplete});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Fuchsia;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTasks.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTasks.Location = new System.Drawing.Point(17, 26);
            this.dgvTasks.Name = "dgvTasks";
            this.dgvTasks.ReadOnly = true;
            this.dgvTasks.RowHeadersWidth = 350;
            this.dgvTasks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvTasks.Size = new System.Drawing.Size(1099, 145);
            this.dgvTasks.TabIndex = 0;
            this.dgvTasks.SelectionChanged += new System.EventHandler(this.dgvTasks_SelectionChanged);
            // 
            // chkMarkAsCompleted
            // 
            this.chkMarkAsCompleted.AutoSize = true;
            this.chkMarkAsCompleted.Font = new System.Drawing.Font("Tahoma", 14F);
            this.chkMarkAsCompleted.Location = new System.Drawing.Point(48, 470);
            this.chkMarkAsCompleted.Name = "chkMarkAsCompleted";
            this.chkMarkAsCompleted.Size = new System.Drawing.Size(188, 27);
            this.chkMarkAsCompleted.TabIndex = 10;
            this.chkMarkAsCompleted.Text = "Mark As completed";
            this.chkMarkAsCompleted.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Task
            // 
            this.Task.HeaderText = "Task";
            this.Task.Name = "Task";
            this.Task.ReadOnly = true;
            // 
            // Catagory
            // 
            this.Catagory.HeaderText = "Catagory";
            this.Catagory.Name = "Catagory";
            this.Catagory.ReadOnly = true;
            // 
            // Urgent
            // 
            this.Urgent.HeaderText = "Urgent";
            this.Urgent.Name = "Urgent";
            this.Urgent.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // IsComplete
            // 
            this.IsComplete.HeaderText = "IsComplete";
            this.IsComplete.Name = "IsComplete";
            this.IsComplete.ReadOnly = true;
            // 
            // chkIsMark
            // 
            this.chkIsMark.AutoSize = true;
            this.chkIsMark.Font = new System.Drawing.Font("Tahoma", 15F);
            this.chkIsMark.Location = new System.Drawing.Point(57, 195);
            this.chkIsMark.Name = "chkIsMark";
            this.chkIsMark.Size = new System.Drawing.Size(189, 28);
            this.chkIsMark.TabIndex = 11;
            this.chkIsMark.Text = "Mark as Complete";
            this.chkIsMark.UseVisualStyleBackColor = true;
            this.chkIsMark.CheckedChanged += new System.EventHandler(this.chkIsMark_CheckedChanged);
            // 
            // btnDeleteFullTask
            // 
            this.btnDeleteFullTask.BackColor = System.Drawing.Color.MediumPurple;
            this.btnDeleteFullTask.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnDeleteFullTask.Location = new System.Drawing.Point(887, 187);
            this.btnDeleteFullTask.Name = "btnDeleteFullTask";
            this.btnDeleteFullTask.Size = new System.Drawing.Size(178, 44);
            this.btnDeleteFullTask.TabIndex = 11;
            this.btnDeleteFullTask.Text = "Delete";
            this.btnDeleteFullTask.UseVisualStyleBackColor = false;
            this.btnDeleteFullTask.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 735);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox lblTaskTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddtask;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.CheckBox chkIsUrgent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstTasks;
        private System.Windows.Forms.Button btnRemoveTasks;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvTasks;
        private System.Windows.Forms.CheckBox chkMarkAsCompleted;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Task;
        private System.Windows.Forms.DataGridViewTextBoxColumn Catagory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Urgent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsComplete;
        private System.Windows.Forms.CheckBox chkIsMark;
        private System.Windows.Forms.Button btnDeleteFullTask;
    }
}

