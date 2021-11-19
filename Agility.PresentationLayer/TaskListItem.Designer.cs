namespace Agility.PresentationLayer
{
    partial class TaskListItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlPriorityColor = new System.Windows.Forms.Panel();
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblMemberWorking = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblType = new System.Windows.Forms.Label();
            this.pnlCenter.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(268, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(15, 110);
            this.flowLayoutPanel1.TabIndex = 19;
            this.flowLayoutPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TaskListItem_MouseDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(15, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 110);
            this.panel1.TabIndex = 18;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TaskListItem_MouseDown);
            // 
            // pnlPriorityColor
            // 
            this.pnlPriorityColor.BackColor = System.Drawing.Color.White;
            this.pnlPriorityColor.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlPriorityColor.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.pnlPriorityColor.Location = new System.Drawing.Point(0, 0);
            this.pnlPriorityColor.Name = "pnlPriorityColor";
            this.pnlPriorityColor.Size = new System.Drawing.Size(15, 110);
            this.pnlPriorityColor.TabIndex = 17;
            this.pnlPriorityColor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TaskListItem_MouseDown);
            // 
            // pnlCenter
            // 
            this.pnlCenter.BackColor = System.Drawing.Color.White;
            this.pnlCenter.Controls.Add(this.panel3);
            this.pnlCenter.Controls.Add(this.lblDesc);
            this.pnlCenter.Controls.Add(this.panel2);
            this.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenter.Location = new System.Drawing.Point(25, 0);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(243, 110);
            this.pnlCenter.TabIndex = 20;
            this.pnlCenter.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TaskListItem_MouseDown);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.lblMemberWorking);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 80);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(243, 30);
            this.panel3.TabIndex = 24;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TaskListItem_MouseDown);
            // 
            // lblMemberWorking
            // 
            this.lblMemberWorking.BackColor = System.Drawing.Color.White;
            this.lblMemberWorking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMemberWorking.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberWorking.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(57)))), ((int)(((byte)(77)))));
            this.lblMemberWorking.Location = new System.Drawing.Point(0, 0);
            this.lblMemberWorking.Name = "lblMemberWorking";
            this.lblMemberWorking.Size = new System.Drawing.Size(243, 30);
            this.lblMemberWorking.TabIndex = 0;
            this.lblMemberWorking.Text = "Pero Perić";
            this.lblMemberWorking.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblMemberWorking.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TaskListItem_MouseDown);
            // 
            // lblDesc
            // 
            this.lblDesc.AllowDrop = true;
            this.lblDesc.AutoEllipsis = true;
            this.lblDesc.AutoSize = true;
            this.lblDesc.BackColor = System.Drawing.Color.White;
            this.lblDesc.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDesc.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(0, 31);
            this.lblDesc.Margin = new System.Windows.Forms.Padding(0);
            this.lblDesc.MaximumSize = new System.Drawing.Size(240, 50);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(226, 48);
            this.lblDesc.TabIndex = 23;
            this.lblDesc.Text = "Something that needs to be done";
            this.lblDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDesc.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TaskListItem_MouseDown);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lblType);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(243, 31);
            this.panel2.TabIndex = 22;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TaskListItem_MouseDown);
            // 
            // lblType
            // 
            this.lblType.BackColor = System.Drawing.Color.White;
            this.lblType.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblType.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(0, 0);
            this.lblType.Margin = new System.Windows.Forms.Padding(0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(243, 31);
            this.lblType.TabIndex = 15;
            this.lblType.Text = "bug fix";
            this.lblType.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblType.Click += new System.EventHandler(this.lblType_Click);
            this.lblType.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TaskListItem_MouseDown);
            // 
            // TaskListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlCenter);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlPriorityColor);
            this.Name = "TaskListItem";
            this.Size = new System.Drawing.Size(283, 110);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TaskListItem_MouseDown);
            this.pnlCenter.ResumeLayout(false);
            this.pnlCenter.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlPriorityColor;
        private System.Windows.Forms.Panel pnlCenter;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblMemberWorking;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblType;
    }
}
