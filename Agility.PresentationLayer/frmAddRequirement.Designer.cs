namespace Agility.PresentationLayer
{
    partial class frmAddRequirement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddRequirement));
            this.controlPanel = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pnlTasks = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.btnCancelReq = new System.Windows.Forms.Button();
            this.btnSaveReq = new System.Windows.Forms.Button();
            this.comboBoxPriority = new System.Windows.Forms.ComboBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.lblReqPriority = new System.Windows.Forms.Label();
            this.lblReqType = new System.Windows.Forms.Label();
            this.lblReqDescription = new System.Windows.Forms.Label();
            this.lblReqTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNewRequirement = new System.Windows.Forms.Label();
            this.panel7.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // controlPanel
            // 
            this.controlPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.controlPanel.Location = new System.Drawing.Point(0, 0);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(875, 40);
            this.controlPanel.TabIndex = 28;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(57)))), ((int)(((byte)(77)))));
            this.panel7.Controls.Add(this.panel1);
            this.panel7.Controls.Add(this.pnlTasks);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Controls.Add(this.btnAddTask);
            this.panel7.Controls.Add(this.btnCancelReq);
            this.panel7.Controls.Add(this.btnSaveReq);
            this.panel7.Controls.Add(this.comboBoxPriority);
            this.panel7.Controls.Add(this.comboBoxType);
            this.panel7.Controls.Add(this.textBoxDescription);
            this.panel7.Controls.Add(this.textBoxTitle);
            this.panel7.Controls.Add(this.lblReqPriority);
            this.panel7.Controls.Add(this.lblReqType);
            this.panel7.Controls.Add(this.lblReqDescription);
            this.panel7.Controls.Add(this.lblReqTitle);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 40);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(875, 424);
            this.panel7.TabIndex = 29;
            // 
            // pnlTasks
            // 
            this.pnlTasks.AutoScroll = true;
            this.pnlTasks.Location = new System.Drawing.Point(510, 120);
            this.pnlTasks.Name = "pnlTasks";
            this.pnlTasks.Size = new System.Drawing.Size(262, 174);
            this.pnlTasks.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(447, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 24);
            this.label1.TabIndex = 26;
            this.label1.Text = "Tasks";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnAddTask
            // 
            this.btnAddTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(128)))), ((int)(((byte)(166)))));
            this.btnAddTask.FlatAppearance.BorderSize = 0;
            this.btnAddTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTask.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTask.Location = new System.Drawing.Point(677, 299);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(95, 30);
            this.btnAddTask.TabIndex = 27;
            this.btnAddTask.Text = "Add";
            this.btnAddTask.UseVisualStyleBackColor = false;
            this.btnAddTask.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancelReq
            // 
            this.btnCancelReq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.btnCancelReq.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelReq.FlatAppearance.BorderSize = 0;
            this.btnCancelReq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelReq.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelReq.ForeColor = System.Drawing.Color.White;
            this.btnCancelReq.Location = new System.Drawing.Point(340, 343);
            this.btnCancelReq.Name = "btnCancelReq";
            this.btnCancelReq.Size = new System.Drawing.Size(95, 41);
            this.btnCancelReq.TabIndex = 25;
            this.btnCancelReq.Text = "Cancel";
            this.btnCancelReq.UseVisualStyleBackColor = false;
            // 
            // btnSaveReq
            // 
            this.btnSaveReq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.btnSaveReq.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSaveReq.FlatAppearance.BorderSize = 0;
            this.btnSaveReq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveReq.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveReq.ForeColor = System.Drawing.Color.White;
            this.btnSaveReq.Location = new System.Drawing.Point(451, 343);
            this.btnSaveReq.Name = "btnSaveReq";
            this.btnSaveReq.Size = new System.Drawing.Size(95, 41);
            this.btnSaveReq.TabIndex = 24;
            this.btnSaveReq.Text = "Save";
            this.btnSaveReq.UseVisualStyleBackColor = false;
            // 
            // comboBoxPriority
            // 
            this.comboBoxPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPriority.FormattingEnabled = true;
            this.comboBoxPriority.Location = new System.Drawing.Point(176, 267);
            this.comboBoxPriority.Name = "comboBoxPriority";
            this.comboBoxPriority.Size = new System.Drawing.Size(206, 27);
            this.comboBoxPriority.TabIndex = 23;
            // 
            // comboBoxType
            // 
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(176, 225);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(206, 27);
            this.comboBoxType.TabIndex = 22;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(176, 159);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(206, 50);
            this.textBoxDescription.TabIndex = 21;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(176, 120);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(206, 24);
            this.textBoxTitle.TabIndex = 20;
            // 
            // lblReqPriority
            // 
            this.lblReqPriority.AutoSize = true;
            this.lblReqPriority.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReqPriority.ForeColor = System.Drawing.Color.White;
            this.lblReqPriority.Location = new System.Drawing.Point(96, 269);
            this.lblReqPriority.Name = "lblReqPriority";
            this.lblReqPriority.Size = new System.Drawing.Size(73, 24);
            this.lblReqPriority.TabIndex = 19;
            this.lblReqPriority.Text = "Priority";
            this.lblReqPriority.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblReqType
            // 
            this.lblReqType.AutoSize = true;
            this.lblReqType.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReqType.ForeColor = System.Drawing.Color.White;
            this.lblReqType.Location = new System.Drawing.Point(117, 227);
            this.lblReqType.Name = "lblReqType";
            this.lblReqType.Size = new System.Drawing.Size(52, 24);
            this.lblReqType.TabIndex = 18;
            this.lblReqType.Text = "Type";
            this.lblReqType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblReqDescription
            // 
            this.lblReqDescription.AutoSize = true;
            this.lblReqDescription.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReqDescription.ForeColor = System.Drawing.Color.White;
            this.lblReqDescription.Location = new System.Drawing.Point(62, 158);
            this.lblReqDescription.Name = "lblReqDescription";
            this.lblReqDescription.Size = new System.Drawing.Size(107, 24);
            this.lblReqDescription.TabIndex = 17;
            this.lblReqDescription.Text = "Description";
            this.lblReqDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblReqTitle
            // 
            this.lblReqTitle.AutoSize = true;
            this.lblReqTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReqTitle.ForeColor = System.Drawing.Color.White;
            this.lblReqTitle.Location = new System.Drawing.Point(121, 120);
            this.lblReqTitle.Name = "lblReqTitle";
            this.lblReqTitle.Size = new System.Drawing.Size(48, 24);
            this.lblReqTitle.TabIndex = 16;
            this.lblReqTitle.Text = "Title";
            this.lblReqTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblNewRequirement);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(875, 71);
            this.panel1.TabIndex = 29;
            // 
            // lblNewRequirement
            // 
            this.lblNewRequirement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNewRequirement.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewRequirement.ForeColor = System.Drawing.Color.White;
            this.lblNewRequirement.Location = new System.Drawing.Point(0, 0);
            this.lblNewRequirement.Name = "lblNewRequirement";
            this.lblNewRequirement.Size = new System.Drawing.Size(875, 71);
            this.lblNewRequirement.TabIndex = 16;
            this.lblNewRequirement.Text = "Add new requirement";
            this.lblNewRequirement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmAddRequirement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 464);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.controlPanel);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAddRequirement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddRequirement";
            this.Load += new System.EventHandler(this.frmAddRequirement_Load);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel pnlTasks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Button btnCancelReq;
        private System.Windows.Forms.Button btnSaveReq;
        private System.Windows.Forms.ComboBox comboBoxPriority;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label lblReqPriority;
        private System.Windows.Forms.Label lblReqType;
        private System.Windows.Forms.Label lblReqDescription;
        private System.Windows.Forms.Label lblReqTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNewRequirement;
    }
}