namespace Agility.PresentationLayer
{
    partial class frmSprint
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
            this.pnlAddSprint = new System.Windows.Forms.Panel();
            this.btnAddSprint = new System.Windows.Forms.Button();
            this.pnlSprint = new System.Windows.Forms.Panel();
            this.tblTasks = new System.Windows.Forms.TableLayoutPanel();
            this.flowInProgress = new System.Windows.Forms.FlowLayoutPanel();
            this.flowStuck = new System.Windows.Forms.FlowLayoutPanel();
            this.flowDone = new System.Windows.Forms.FlowLayoutPanel();
            this.flowToDo = new System.Windows.Forms.FlowLayoutPanel();
            this.tblLabels = new System.Windows.Forms.TableLayoutPanel();
            this.lblDone = new System.Windows.Forms.Label();
            this.lblStuck = new System.Windows.Forms.Label();
            this.lblToDo = new System.Windows.Forms.Label();
            this.lblDoing = new System.Windows.Forms.Label();
            this.tblTasksStats = new System.Windows.Forms.TableLayoutPanel();
            this.pnlSprintInfo = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblNumOfToDo = new System.Windows.Forms.Label();
            this.lblNumOfInProgress = new System.Windows.Forms.Label();
            this.lblNumOfStuck = new System.Windows.Forms.Label();
            this.lblNumOfDone = new System.Windows.Forms.Label();
            this.pnlAddSprint.SuspendLayout();
            this.pnlSprint.SuspendLayout();
            this.tblTasks.SuspendLayout();
            this.tblLabels.SuspendLayout();
            this.tblTasksStats.SuspendLayout();
            this.pnlSprintInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAddSprint
            // 
            this.pnlAddSprint.Controls.Add(this.btnAddSprint);
            this.pnlAddSprint.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAddSprint.Location = new System.Drawing.Point(0, 0);
            this.pnlAddSprint.Name = "pnlAddSprint";
            this.pnlAddSprint.Size = new System.Drawing.Size(902, 80);
            this.pnlAddSprint.TabIndex = 0;
            // 
            // btnAddSprint
            // 
            this.btnAddSprint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddSprint.FlatAppearance.BorderSize = 0;
            this.btnAddSprint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSprint.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSprint.ForeColor = System.Drawing.Color.White;
            this.btnAddSprint.Location = new System.Drawing.Point(0, 0);
            this.btnAddSprint.Name = "btnAddSprint";
            this.btnAddSprint.Size = new System.Drawing.Size(902, 80);
            this.btnAddSprint.TabIndex = 0;
            this.btnAddSprint.Text = "Create New Sprint";
            this.btnAddSprint.UseVisualStyleBackColor = true;
            this.btnAddSprint.Click += new System.EventHandler(this.btnAddSprint_Click);
            // 
            // pnlSprint
            // 
            this.pnlSprint.Controls.Add(this.tblTasks);
            this.pnlSprint.Controls.Add(this.tblLabels);
            this.pnlSprint.Controls.Add(this.tblTasksStats);
            this.pnlSprint.Controls.Add(this.pnlSprintInfo);
            this.pnlSprint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSprint.Location = new System.Drawing.Point(0, 80);
            this.pnlSprint.Name = "pnlSprint";
            this.pnlSprint.Size = new System.Drawing.Size(902, 726);
            this.pnlSprint.TabIndex = 1;
            // 
            // tblTasks
            // 
            this.tblTasks.AutoScroll = true;
            this.tblTasks.ColumnCount = 4;
            this.tblTasks.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblTasks.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblTasks.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblTasks.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblTasks.Controls.Add(this.flowInProgress, 1, 0);
            this.tblTasks.Controls.Add(this.flowStuck, 2, 0);
            this.tblTasks.Controls.Add(this.flowDone, 3, 0);
            this.tblTasks.Controls.Add(this.flowToDo, 0, 0);
            this.tblTasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblTasks.Location = new System.Drawing.Point(0, 75);
            this.tblTasks.Name = "tblTasks";
            this.tblTasks.RowCount = 1;
            this.tblTasks.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblTasks.Size = new System.Drawing.Size(902, 621);
            this.tblTasks.TabIndex = 8;
            this.tblTasks.DragDrop += new System.Windows.Forms.DragEventHandler(this.flowToDo_DragDrop);
            this.tblTasks.DragEnter += new System.Windows.Forms.DragEventHandler(this.flowToDo_DragEnter);
            // 
            // flowInProgress
            // 
            this.flowInProgress.AllowDrop = true;
            this.flowInProgress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowInProgress.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowInProgress.Location = new System.Drawing.Point(233, 5);
            this.flowInProgress.Margin = new System.Windows.Forms.Padding(8, 5, 8, 5);
            this.flowInProgress.Name = "flowInProgress";
            this.flowInProgress.Size = new System.Drawing.Size(209, 611);
            this.flowInProgress.TabIndex = 1;
            this.flowInProgress.DragDrop += new System.Windows.Forms.DragEventHandler(this.flowInProgress_DragDrop);
            this.flowInProgress.DragEnter += new System.Windows.Forms.DragEventHandler(this.flowInProgress_DragEnter);
            this.flowInProgress.DragLeave += new System.EventHandler(this.flowInProgress_DragLeave);
            // 
            // flowStuck
            // 
            this.flowStuck.AllowDrop = true;
            this.flowStuck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowStuck.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowStuck.Location = new System.Drawing.Point(458, 5);
            this.flowStuck.Margin = new System.Windows.Forms.Padding(8, 5, 8, 5);
            this.flowStuck.Name = "flowStuck";
            this.flowStuck.Size = new System.Drawing.Size(209, 611);
            this.flowStuck.TabIndex = 2;
            this.flowStuck.DragDrop += new System.Windows.Forms.DragEventHandler(this.flowStuck_DragDrop);
            this.flowStuck.DragEnter += new System.Windows.Forms.DragEventHandler(this.flowStuck_DragEnter);
            this.flowStuck.DragLeave += new System.EventHandler(this.flowStuck_DragLeave);
            // 
            // flowDone
            // 
            this.flowDone.AllowDrop = true;
            this.flowDone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowDone.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowDone.Location = new System.Drawing.Point(683, 5);
            this.flowDone.Margin = new System.Windows.Forms.Padding(8, 5, 8, 5);
            this.flowDone.Name = "flowDone";
            this.flowDone.Size = new System.Drawing.Size(211, 611);
            this.flowDone.TabIndex = 3;
            this.flowDone.DragDrop += new System.Windows.Forms.DragEventHandler(this.flowDone_DragDrop);
            this.flowDone.DragEnter += new System.Windows.Forms.DragEventHandler(this.flowDone_DragEnter);
            this.flowDone.DragLeave += new System.EventHandler(this.flowDone_DragLeave);
            // 
            // flowToDo
            // 
            this.flowToDo.AllowDrop = true;
            this.flowToDo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowToDo.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowToDo.Location = new System.Drawing.Point(8, 5);
            this.flowToDo.Margin = new System.Windows.Forms.Padding(8, 5, 8, 5);
            this.flowToDo.Name = "flowToDo";
            this.flowToDo.Size = new System.Drawing.Size(209, 611);
            this.flowToDo.TabIndex = 0;
            this.flowToDo.DragDrop += new System.Windows.Forms.DragEventHandler(this.flowToDo_DragDrop);
            this.flowToDo.DragEnter += new System.Windows.Forms.DragEventHandler(this.flowToDo_DragEnter);
            this.flowToDo.DragLeave += new System.EventHandler(this.flowToDo_DragLeave);
            // 
            // tblLabels
            // 
            this.tblLabels.ColumnCount = 4;
            this.tblLabels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLabels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLabels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLabels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLabels.Controls.Add(this.lblDone, 3, 0);
            this.tblLabels.Controls.Add(this.lblStuck, 0, 0);
            this.tblLabels.Controls.Add(this.lblToDo, 0, 0);
            this.tblLabels.Controls.Add(this.lblDoing, 0, 0);
            this.tblLabels.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblLabels.Location = new System.Drawing.Point(0, 30);
            this.tblLabels.Name = "tblLabels";
            this.tblLabels.RowCount = 1;
            this.tblLabels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLabels.Size = new System.Drawing.Size(902, 45);
            this.tblLabels.TabIndex = 7;
            // 
            // lblDone
            // 
            this.lblDone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDone.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDone.ForeColor = System.Drawing.Color.White;
            this.lblDone.Location = new System.Drawing.Point(678, 0);
            this.lblDone.Name = "lblDone";
            this.lblDone.Size = new System.Drawing.Size(221, 45);
            this.lblDone.TabIndex = 5;
            this.lblDone.Text = "DONE";
            this.lblDone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStuck
            // 
            this.lblStuck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStuck.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStuck.ForeColor = System.Drawing.Color.White;
            this.lblStuck.Location = new System.Drawing.Point(453, 0);
            this.lblStuck.Name = "lblStuck";
            this.lblStuck.Size = new System.Drawing.Size(219, 45);
            this.lblStuck.TabIndex = 4;
            this.lblStuck.Text = "STUCK";
            this.lblStuck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblToDo
            // 
            this.lblToDo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblToDo.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToDo.ForeColor = System.Drawing.Color.White;
            this.lblToDo.Location = new System.Drawing.Point(3, 0);
            this.lblToDo.Name = "lblToDo";
            this.lblToDo.Size = new System.Drawing.Size(219, 45);
            this.lblToDo.TabIndex = 3;
            this.lblToDo.Text = "TO DO";
            this.lblToDo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDoing
            // 
            this.lblDoing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDoing.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoing.ForeColor = System.Drawing.Color.White;
            this.lblDoing.Location = new System.Drawing.Point(228, 0);
            this.lblDoing.Name = "lblDoing";
            this.lblDoing.Size = new System.Drawing.Size(219, 45);
            this.lblDoing.TabIndex = 2;
            this.lblDoing.Text = "IN PROGRESS";
            this.lblDoing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tblTasksStats
            // 
            this.tblTasksStats.ColumnCount = 4;
            this.tblTasksStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblTasksStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblTasksStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblTasksStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblTasksStats.Controls.Add(this.lblNumOfDone, 3, 0);
            this.tblTasksStats.Controls.Add(this.lblNumOfStuck, 2, 0);
            this.tblTasksStats.Controls.Add(this.lblNumOfInProgress, 1, 0);
            this.tblTasksStats.Controls.Add(this.lblNumOfToDo, 0, 0);
            this.tblTasksStats.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tblTasksStats.Location = new System.Drawing.Point(0, 696);
            this.tblTasksStats.Name = "tblTasksStats";
            this.tblTasksStats.RowCount = 1;
            this.tblTasksStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblTasksStats.Size = new System.Drawing.Size(902, 30);
            this.tblTasksStats.TabIndex = 5;
            // 
            // pnlSprintInfo
            // 
            this.pnlSprintInfo.Controls.Add(this.lblDate);
            this.pnlSprintInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSprintInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlSprintInfo.Name = "pnlSprintInfo";
            this.pnlSprintInfo.Size = new System.Drawing.Size(902, 30);
            this.pnlSprintInfo.TabIndex = 6;
            // 
            // lblDate
            // 
            this.lblDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDate.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(0, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(902, 30);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "01/01/2020 - 02/02/2020";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumOfToDo
            // 
            this.lblNumOfToDo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNumOfToDo.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumOfToDo.ForeColor = System.Drawing.Color.White;
            this.lblNumOfToDo.Location = new System.Drawing.Point(3, 0);
            this.lblNumOfToDo.Name = "lblNumOfToDo";
            this.lblNumOfToDo.Size = new System.Drawing.Size(219, 30);
            this.lblNumOfToDo.TabIndex = 0;
            this.lblNumOfToDo.Text = "Total: 2";
            this.lblNumOfToDo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumOfInProgress
            // 
            this.lblNumOfInProgress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNumOfInProgress.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumOfInProgress.ForeColor = System.Drawing.Color.White;
            this.lblNumOfInProgress.Location = new System.Drawing.Point(228, 0);
            this.lblNumOfInProgress.Name = "lblNumOfInProgress";
            this.lblNumOfInProgress.Size = new System.Drawing.Size(219, 30);
            this.lblNumOfInProgress.TabIndex = 1;
            this.lblNumOfInProgress.Text = "Total: 2";
            this.lblNumOfInProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumOfStuck
            // 
            this.lblNumOfStuck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNumOfStuck.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumOfStuck.ForeColor = System.Drawing.Color.White;
            this.lblNumOfStuck.Location = new System.Drawing.Point(453, 0);
            this.lblNumOfStuck.Name = "lblNumOfStuck";
            this.lblNumOfStuck.Size = new System.Drawing.Size(219, 30);
            this.lblNumOfStuck.TabIndex = 2;
            this.lblNumOfStuck.Text = "Total: 2";
            this.lblNumOfStuck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumOfDone
            // 
            this.lblNumOfDone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNumOfDone.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumOfDone.ForeColor = System.Drawing.Color.White;
            this.lblNumOfDone.Location = new System.Drawing.Point(678, 0);
            this.lblNumOfDone.Name = "lblNumOfDone";
            this.lblNumOfDone.Size = new System.Drawing.Size(221, 30);
            this.lblNumOfDone.TabIndex = 3;
            this.lblNumOfDone.Text = "Total: 2";
            this.lblNumOfDone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmSprint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(57)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(902, 806);
            this.Controls.Add(this.pnlSprint);
            this.Controls.Add(this.pnlAddSprint);
            this.Name = "frmSprint";
            this.Text = "frmSprint";
            this.Load += new System.EventHandler(this.frmSprint_Load);
            this.pnlAddSprint.ResumeLayout(false);
            this.pnlSprint.ResumeLayout(false);
            this.tblTasks.ResumeLayout(false);
            this.tblLabels.ResumeLayout(false);
            this.tblTasksStats.ResumeLayout(false);
            this.pnlSprintInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAddSprint;
        private System.Windows.Forms.Panel pnlSprint;
        private System.Windows.Forms.TableLayoutPanel tblTasks;
        private System.Windows.Forms.TableLayoutPanel tblLabels;
        private System.Windows.Forms.Label lblDone;
        private System.Windows.Forms.Label lblStuck;
        private System.Windows.Forms.Label lblToDo;
        private System.Windows.Forms.Label lblDoing;
        private System.Windows.Forms.TableLayoutPanel tblTasksStats;
        private System.Windows.Forms.Panel pnlSprintInfo;
        private System.Windows.Forms.Button btnAddSprint;
        private System.Windows.Forms.FlowLayoutPanel flowToDo;
        private System.Windows.Forms.FlowLayoutPanel flowInProgress;
        private System.Windows.Forms.FlowLayoutPanel flowStuck;
        private System.Windows.Forms.FlowLayoutPanel flowDone;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblNumOfDone;
        private System.Windows.Forms.Label lblNumOfStuck;
        private System.Windows.Forms.Label lblNumOfInProgress;
        private System.Windows.Forms.Label lblNumOfToDo;
    }
}