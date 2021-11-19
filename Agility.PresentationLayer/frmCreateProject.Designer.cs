namespace Agility.PresentationLayer
{
    partial class frmCreateProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreateProject));
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.selectMembersList = new System.Windows.Forms.ListBox();
            this.lblAddMembers = new System.Windows.Forms.Label();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.btnCancelReq = new System.Windows.Forms.Button();
            this.btnSaveReq = new System.Windows.Forms.Button();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.lbProjectEnd = new System.Windows.Forms.Label();
            this.lblProjectStart = new System.Windows.Forms.Label();
            this.lblProjectDescription = new System.Windows.Forms.Label();
            this.lblProjectTitle = new System.Windows.Forms.Label();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.panel7.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(57)))), ((int)(((byte)(77)))));
            this.panel7.Controls.Add(this.panel1);
            this.panel7.Controls.Add(this.selectMembersList);
            this.panel7.Controls.Add(this.lblAddMembers);
            this.panel7.Controls.Add(this.dateEnd);
            this.panel7.Controls.Add(this.dateStart);
            this.panel7.Controls.Add(this.btnCancelReq);
            this.panel7.Controls.Add(this.btnSaveReq);
            this.panel7.Controls.Add(this.textBoxDescription);
            this.panel7.Controls.Add(this.textBoxTitle);
            this.panel7.Controls.Add(this.lbProjectEnd);
            this.panel7.Controls.Add(this.lblProjectStart);
            this.panel7.Controls.Add(this.lblProjectDescription);
            this.panel7.Controls.Add(this.lblProjectTitle);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 40);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(712, 531);
            this.panel7.TabIndex = 28;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblFormTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(712, 62);
            this.panel1.TabIndex = 40;
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFormTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTitle.ForeColor = System.Drawing.Color.White;
            this.lblFormTitle.Location = new System.Drawing.Point(0, 0);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(712, 62);
            this.lblFormTitle.TabIndex = 28;
            this.lblFormTitle.Text = "Add new project";
            this.lblFormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // selectMembersList
            // 
            this.selectMembersList.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectMembersList.FormattingEnabled = true;
            this.selectMembersList.ItemHeight = 19;
            this.selectMembersList.Location = new System.Drawing.Point(258, 278);
            this.selectMembersList.Name = "selectMembersList";
            this.selectMembersList.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.selectMembersList.Size = new System.Drawing.Size(206, 137);
            this.selectMembersList.Sorted = true;
            this.selectMembersList.TabIndex = 39;
            // 
            // lblAddMembers
            // 
            this.lblAddMembers.AutoSize = true;
            this.lblAddMembers.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddMembers.ForeColor = System.Drawing.Color.White;
            this.lblAddMembers.Location = new System.Drawing.Point(101, 277);
            this.lblAddMembers.Name = "lblAddMembers";
            this.lblAddMembers.Size = new System.Drawing.Size(130, 24);
            this.lblAddMembers.TabIndex = 38;
            this.lblAddMembers.Text = "Add members";
            this.lblAddMembers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dateEnd
            // 
            this.dateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateEnd.Location = new System.Drawing.Point(258, 238);
            this.dateEnd.MinDate = new System.DateTime(2021, 1, 18, 0, 0, 0, 0);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(206, 22);
            this.dateEnd.TabIndex = 37;
            // 
            // dateStart
            // 
            this.dateStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateStart.Location = new System.Drawing.Point(258, 197);
            this.dateStart.MinDate = new System.DateTime(2021, 1, 18, 0, 0, 0, 0);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(206, 22);
            this.dateStart.TabIndex = 36;
            // 
            // btnCancelReq
            // 
            this.btnCancelReq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.btnCancelReq.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelReq.FlatAppearance.BorderSize = 0;
            this.btnCancelReq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelReq.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelReq.ForeColor = System.Drawing.Color.White;
            this.btnCancelReq.Location = new System.Drawing.Point(258, 449);
            this.btnCancelReq.Name = "btnCancelReq";
            this.btnCancelReq.Size = new System.Drawing.Size(95, 41);
            this.btnCancelReq.TabIndex = 35;
            this.btnCancelReq.Text = "Cancel";
            this.btnCancelReq.UseVisualStyleBackColor = false;
            // 
            // btnSaveReq
            // 
            this.btnSaveReq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.btnSaveReq.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSaveReq.FlatAppearance.BorderSize = 0;
            this.btnSaveReq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveReq.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveReq.ForeColor = System.Drawing.Color.White;
            this.btnSaveReq.Location = new System.Drawing.Point(369, 449);
            this.btnSaveReq.Name = "btnSaveReq";
            this.btnSaveReq.Size = new System.Drawing.Size(95, 41);
            this.btnSaveReq.TabIndex = 34;
            this.btnSaveReq.Text = "Save";
            this.btnSaveReq.UseVisualStyleBackColor = false;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(258, 130);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(206, 50);
            this.textBoxDescription.TabIndex = 33;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(258, 91);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(206, 22);
            this.textBoxTitle.TabIndex = 32;
            // 
            // lbProjectEnd
            // 
            this.lbProjectEnd.AutoSize = true;
            this.lbProjectEnd.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProjectEnd.ForeColor = System.Drawing.Color.White;
            this.lbProjectEnd.Location = new System.Drawing.Point(146, 237);
            this.lbProjectEnd.Name = "lbProjectEnd";
            this.lbProjectEnd.Size = new System.Drawing.Size(85, 24);
            this.lbProjectEnd.TabIndex = 31;
            this.lbProjectEnd.Text = "End date";
            this.lbProjectEnd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblProjectStart
            // 
            this.lblProjectStart.AutoSize = true;
            this.lblProjectStart.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectStart.ForeColor = System.Drawing.Color.White;
            this.lblProjectStart.Location = new System.Drawing.Point(137, 195);
            this.lblProjectStart.Name = "lblProjectStart";
            this.lblProjectStart.Size = new System.Drawing.Size(94, 24);
            this.lblProjectStart.TabIndex = 30;
            this.lblProjectStart.Text = "Start date";
            this.lblProjectStart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblProjectDescription
            // 
            this.lblProjectDescription.AutoSize = true;
            this.lblProjectDescription.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectDescription.ForeColor = System.Drawing.Color.White;
            this.lblProjectDescription.Location = new System.Drawing.Point(124, 128);
            this.lblProjectDescription.Name = "lblProjectDescription";
            this.lblProjectDescription.Size = new System.Drawing.Size(107, 24);
            this.lblProjectDescription.TabIndex = 29;
            this.lblProjectDescription.Text = "Description";
            this.lblProjectDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblProjectTitle
            // 
            this.lblProjectTitle.AutoSize = true;
            this.lblProjectTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectTitle.ForeColor = System.Drawing.Color.White;
            this.lblProjectTitle.Location = new System.Drawing.Point(183, 90);
            this.lblProjectTitle.Name = "lblProjectTitle";
            this.lblProjectTitle.Size = new System.Drawing.Size(48, 24);
            this.lblProjectTitle.TabIndex = 28;
            this.lblProjectTitle.Text = "Title";
            this.lblProjectTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // controlPanel
            // 
            this.controlPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(51)))));
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.controlPanel.Location = new System.Drawing.Point(0, 0);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(712, 40);
            this.controlPanel.TabIndex = 27;
            // 
            // frmCreateProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 571);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.controlPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCreateProject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCreateProject";
            this.Load += new System.EventHandler(this.frmCreateProject_Load);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ListBox selectMembersList;
        private System.Windows.Forms.Label lblAddMembers;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.Button btnCancelReq;
        private System.Windows.Forms.Button btnSaveReq;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label lbProjectEnd;
        private System.Windows.Forms.Label lblProjectStart;
        private System.Windows.Forms.Label lblProjectDescription;
        private System.Windows.Forms.Label lblProjectTitle;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblFormTitle;
    }
}