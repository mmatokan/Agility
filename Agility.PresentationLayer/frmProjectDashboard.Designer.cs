namespace Agility.PresentationLayer
{
    partial class frmProjectDashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProjectDashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pnlSprintTasks = new System.Windows.Forms.Panel();
            this.chartBacklogPriorities = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pnlDaysLeftSprint = new System.Windows.Forms.Panel();
            this.lblSprintDaysLeft = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlDaysLeftProject = new System.Windows.Forms.Panel();
            this.lblProjectDaysLeft = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlReqs = new System.Windows.Forms.Panel();
            this.lblNumOfReqsLeft = new System.Windows.Forms.Label();
            this.lblNumOfReqsDone = new System.Windows.Forms.Label();
            this.pnlPieChart = new System.Windows.Forms.Panel();
            this.circularProgressBar = new CircularProgressBar.CircularProgressBar();
            this.panel5.SuspendLayout();
            this.pnlSprintTasks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartBacklogPriorities)).BeginInit();
            this.panel6.SuspendLayout();
            this.pnlDaysLeftSprint.SuspendLayout();
            this.pnlDaysLeftProject.SuspendLayout();
            this.pnlReqs.SuspendLayout();
            this.pnlPieChart.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 806);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(902, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 806);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 702);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(902, 104);
            this.panel3.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(902, 87);
            this.panel4.TabIndex = 9;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.pnlSprintTasks);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.pnlReqs);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 87);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(902, 615);
            this.panel5.TabIndex = 10;
            // 
            // pnlSprintTasks
            // 
            this.pnlSprintTasks.Controls.Add(this.chartBacklogPriorities);
            this.pnlSprintTasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSprintTasks.Location = new System.Drawing.Point(402, 139);
            this.pnlSprintTasks.Name = "pnlSprintTasks";
            this.pnlSprintTasks.Size = new System.Drawing.Size(500, 476);
            this.pnlSprintTasks.TabIndex = 14;
            // 
            // chartBacklogPriorities
            // 
            this.chartBacklogPriorities.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(57)))), ((int)(((byte)(77)))));
            this.chartBacklogPriorities.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chartBacklogPriorities.BorderSkin.BackColor = System.Drawing.Color.White;
            this.chartBacklogPriorities.BorderSkin.BorderColor = System.Drawing.Color.White;
            this.chartBacklogPriorities.BorderSkin.BorderWidth = 0;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisX.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(57)))), ((int)(((byte)(77)))));
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.White;
            chartArea1.BorderWidth = 0;
            chartArea1.Name = "ChartArea1";
            this.chartBacklogPriorities.ChartAreas.Add(chartArea1);
            this.chartBacklogPriorities.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartBacklogPriorities.Location = new System.Drawing.Point(0, 0);
            this.chartBacklogPriorities.Name = "chartBacklogPriorities";
            this.chartBacklogPriorities.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartBacklogPriorities.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.IsVisibleInLegend = false;
            series1.LabelBackColor = System.Drawing.Color.White;
            series1.LabelBorderColor = System.Drawing.Color.White;
            series1.LabelForeColor = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.Name = "RequirementsByPriority";
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series1.YValuesPerPoint = 2;
            this.chartBacklogPriorities.Series.Add(series1);
            this.chartBacklogPriorities.Size = new System.Drawing.Size(500, 476);
            this.chartBacklogPriorities.TabIndex = 0;
            title1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            title1.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.ForeColor = System.Drawing.Color.White;
            title1.Name = "ChartTitle";
            title1.Text = "Requirements remaining";
            this.chartBacklogPriorities.Titles.Add(title1);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.pnlDaysLeftSprint);
            this.panel6.Controls.Add(this.pnlDaysLeftProject);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(402, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(500, 139);
            this.panel6.TabIndex = 12;
            // 
            // pnlDaysLeftSprint
            // 
            this.pnlDaysLeftSprint.Controls.Add(this.lblSprintDaysLeft);
            this.pnlDaysLeftSprint.Controls.Add(this.label3);
            this.pnlDaysLeftSprint.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlDaysLeftSprint.Location = new System.Drawing.Point(252, 0);
            this.pnlDaysLeftSprint.Name = "pnlDaysLeftSprint";
            this.pnlDaysLeftSprint.Padding = new System.Windows.Forms.Padding(10);
            this.pnlDaysLeftSprint.Size = new System.Drawing.Size(248, 139);
            this.pnlDaysLeftSprint.TabIndex = 12;
            // 
            // lblSprintDaysLeft
            // 
            this.lblSprintDaysLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSprintDaysLeft.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSprintDaysLeft.Location = new System.Drawing.Point(10, 30);
            this.lblSprintDaysLeft.Name = "lblSprintDaysLeft";
            this.lblSprintDaysLeft.Size = new System.Drawing.Size(228, 99);
            this.lblSprintDaysLeft.TabIndex = 3;
            this.lblSprintDaysLeft.Text = "15 days left";
            this.lblSprintDaysLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(10, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "SPRINT";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlDaysLeftProject
            // 
            this.pnlDaysLeftProject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDaysLeftProject.Controls.Add(this.lblProjectDaysLeft);
            this.pnlDaysLeftProject.Controls.Add(this.label1);
            this.pnlDaysLeftProject.Location = new System.Drawing.Point(0, 0);
            this.pnlDaysLeftProject.Name = "pnlDaysLeftProject";
            this.pnlDaysLeftProject.Padding = new System.Windows.Forms.Padding(10);
            this.pnlDaysLeftProject.Size = new System.Drawing.Size(250, 139);
            this.pnlDaysLeftProject.TabIndex = 11;
            // 
            // lblProjectDaysLeft
            // 
            this.lblProjectDaysLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProjectDaysLeft.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectDaysLeft.Location = new System.Drawing.Point(10, 30);
            this.lblProjectDaysLeft.Name = "lblProjectDaysLeft";
            this.lblProjectDaysLeft.Size = new System.Drawing.Size(230, 99);
            this.lblProjectDaysLeft.TabIndex = 1;
            this.lblProjectDaysLeft.Text = "15 days left";
            this.lblProjectDaysLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "PROJECT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlReqs
            // 
            this.pnlReqs.Controls.Add(this.lblNumOfReqsLeft);
            this.pnlReqs.Controls.Add(this.lblNumOfReqsDone);
            this.pnlReqs.Controls.Add(this.pnlPieChart);
            this.pnlReqs.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlReqs.Location = new System.Drawing.Point(0, 0);
            this.pnlReqs.Name = "pnlReqs";
            this.pnlReqs.Size = new System.Drawing.Size(402, 615);
            this.pnlReqs.TabIndex = 8;
            // 
            // lblNumOfReqsLeft
            // 
            this.lblNumOfReqsLeft.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblNumOfReqsLeft.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumOfReqsLeft.Location = new System.Drawing.Point(0, 517);
            this.lblNumOfReqsLeft.Name = "lblNumOfReqsLeft";
            this.lblNumOfReqsLeft.Size = new System.Drawing.Size(402, 49);
            this.lblNumOfReqsLeft.TabIndex = 3;
            this.lblNumOfReqsLeft.Text = "10 requirements left";
            this.lblNumOfReqsLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumOfReqsDone
            // 
            this.lblNumOfReqsDone.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblNumOfReqsDone.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumOfReqsDone.Location = new System.Drawing.Point(0, 566);
            this.lblNumOfReqsDone.Name = "lblNumOfReqsDone";
            this.lblNumOfReqsDone.Size = new System.Drawing.Size(402, 49);
            this.lblNumOfReqsDone.TabIndex = 2;
            this.lblNumOfReqsDone.Text = "20 requirements done";
            this.lblNumOfReqsDone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlPieChart
            // 
            this.pnlPieChart.Controls.Add(this.circularProgressBar);
            this.pnlPieChart.Location = new System.Drawing.Point(80, 90);
            this.pnlPieChart.Name = "pnlPieChart";
            this.pnlPieChart.Size = new System.Drawing.Size(228, 239);
            this.pnlPieChart.TabIndex = 1;
            // 
            // circularProgressBar
            // 
            this.circularProgressBar.AnimationFunction = ((WinFormAnimation.AnimationFunctions.Function)(resources.GetObject("circularProgressBar.AnimationFunction")));
            this.circularProgressBar.AnimationSpeed = 500;
            this.circularProgressBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(57)))), ((int)(((byte)(77)))));
            this.circularProgressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.circularProgressBar.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar.ForeColor = System.Drawing.Color.White;
            this.circularProgressBar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(57)))), ((int)(((byte)(77)))));
            this.circularProgressBar.InnerMargin = 2;
            this.circularProgressBar.InnerWidth = -1;
            this.circularProgressBar.Location = new System.Drawing.Point(0, 0);
            this.circularProgressBar.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar.Name = "circularProgressBar";
            this.circularProgressBar.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.circularProgressBar.OuterMargin = -25;
            this.circularProgressBar.OuterWidth = 26;
            this.circularProgressBar.ProgressColor = System.Drawing.Color.ForestGreen;
            this.circularProgressBar.ProgressWidth = 20;
            this.circularProgressBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBar.Size = new System.Drawing.Size(228, 239);
            this.circularProgressBar.StartAngle = 270;
            this.circularProgressBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar.SubscriptText = "";
            this.circularProgressBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar.SuperscriptText = "";
            this.circularProgressBar.TabIndex = 1;
            this.circularProgressBar.Text = "100%";
            this.circularProgressBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBar.Value = 3;
            // 
            // frmProjectDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(57)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(902, 806);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmProjectDashboard";
            this.Text = "frmProjectDashboard";
            this.Load += new System.EventHandler(this.frmProjectDashboard_Load);
            this.panel5.ResumeLayout(false);
            this.pnlSprintTasks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartBacklogPriorities)).EndInit();
            this.panel6.ResumeLayout(false);
            this.pnlDaysLeftSprint.ResumeLayout(false);
            this.pnlDaysLeftProject.ResumeLayout(false);
            this.pnlReqs.ResumeLayout(false);
            this.pnlPieChart.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel pnlDaysLeftSprint;
        private System.Windows.Forms.Label lblSprintDaysLeft;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlDaysLeftProject;
        private System.Windows.Forms.Label lblProjectDaysLeft;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlReqs;
        private System.Windows.Forms.Label lblNumOfReqsLeft;
        private System.Windows.Forms.Label lblNumOfReqsDone;
        private System.Windows.Forms.Panel pnlPieChart;
        private CircularProgressBar.CircularProgressBar circularProgressBar;
        private System.Windows.Forms.Panel pnlSprintTasks;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBacklogPriorities;
    }
}