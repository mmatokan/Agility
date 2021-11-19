namespace Agility.PresentationLayer
{
    partial class FrmHomeView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHomeView));
            this.pnlSideMenu = new System.Windows.Forms.Panel();
            this.btnAddProject = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.flowLayoutPanelProjects = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlSideMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSideMenu
            // 
            this.pnlSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.pnlSideMenu.Controls.Add(this.btnAddProject);
            this.pnlSideMenu.Controls.Add(this.btnLogOut);
            this.pnlSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlSideMenu.Name = "pnlSideMenu";
            this.pnlSideMenu.Size = new System.Drawing.Size(220, 853);
            this.pnlSideMenu.TabIndex = 1;
            // 
            // btnAddProject
            // 
            this.btnAddProject.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddProject.FlatAppearance.BorderSize = 0;
            this.btnAddProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProject.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProject.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddProject.Location = new System.Drawing.Point(0, 0);
            this.btnAddProject.Name = "btnAddProject";
            this.btnAddProject.Size = new System.Drawing.Size(220, 60);
            this.btnAddProject.TabIndex = 5;
            this.btnAddProject.Text = "Add Project";
            this.btnAddProject.UseVisualStyleBackColor = true;
            this.btnAddProject.Click += new System.EventHandler(this.btnAddProject_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogOut.Location = new System.Drawing.Point(0, 793);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(220, 60);
            this.btnLogOut.TabIndex = 3;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // flowLayoutPanelProjects
            // 
            this.flowLayoutPanelProjects.AutoScroll = true;
            this.flowLayoutPanelProjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelProjects.Location = new System.Drawing.Point(220, 0);
            this.flowLayoutPanelProjects.Name = "flowLayoutPanelProjects";
            this.flowLayoutPanelProjects.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanelProjects.Size = new System.Drawing.Size(1704, 853);
            this.flowLayoutPanelProjects.TabIndex = 6;
            // 
            // FrmHomeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(57)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(1924, 853);
            this.Controls.Add(this.flowLayoutPanelProjects);
            this.Controls.Add(this.pnlSideMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmHomeView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMyProjectscs";
            this.Load += new System.EventHandler(this.frmProjectSelection_Load);
            this.pnlSideMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlSideMenu;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnAddProject;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelProjects;
    }
}