using Agility.BaseLib;
using Agility.DomainModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Agility.PresentationLayer
{
    public partial class frmAddRequirement : Form, IAddNewRequirementView
    { 
        private readonly List<string> _requirementType = null;
        private readonly List<string> _requirementPriority = null;
        private readonly Requirement _req = null;
        public frmAddRequirement(List<string> inReqTypes, List<string> inReqPriority, string inTitle, Requirement inRequirement)
        {
            _requirementType = inReqTypes;
            _requirementPriority = inReqPriority;
            _req = inRequirement;

            InitializeComponent();
            lblNewRequirement.Text = inTitle;
            
            
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void PopulateFields()
        {
            textBoxTitle.Text = _req.Title;
            textBoxDescription.Text = _req.Description;
            comboBoxType.SelectedItem = comboBoxType.Items[(int)_req.Type - 1];
            comboBoxPriority.SelectedIndex = comboBoxPriority.FindString(RequirementPriority.PriorityToDesc[_req.Priority]);
            foreach(Task t in _req.RequirementTasks)
            {
                AddTaskToForm(t.Description);
            }
        }

        private void frmAddRequirement_Load(object sender, EventArgs e)
        {
            foreach (string t in _requirementType)
                comboBoxType.Items.Add(t);

            foreach (string p in _requirementPriority)
                comboBoxPriority.Items.Add(p);
            if (_req != null)
            {
                PopulateFields();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddTaskToForm("");
        }

        private void AddTaskToForm(string input)
        {
            //Create the dynamic TextBox.
            TextBox textbox = new TextBox();
            int count = pnlTasks.Controls.OfType<TextBox>().ToList().Count;
            textbox.Location = new System.Drawing.Point(10, 25 * count);
            textbox.Size = new System.Drawing.Size(180, 20);
            textbox.Name = "txt_" + (count + 1);
            textbox.Text = input;
            pnlTasks.Controls.Add(textbox);

            //Create the dynamic Button to remove the TextBox.
            Button button = new Button();
            button.Location = new System.Drawing.Point(210, 25 * count);
            button.Size = new System.Drawing.Size(20, 20);
            button.Name = "btnDelete_" + (count + 1);
            button.Text = "X";
            button.BackColor = Color.FromArgb(147, 128, 166);
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.Click += new System.EventHandler(this.btnDelete_Click);
            pnlTasks.Controls.Add(button);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Reference the Button which was clicked.
            Button button = (sender as Button);

            //Determine the Index of the Button.
            int index = int.Parse(button.Name.Split('_')[1]);

            //Find the TextBox using Index and remove it.
            pnlTasks.Controls.Remove(pnlTasks.Controls.Find("txt_" + index, true)[0]);

            //Remove the Button.
            pnlTasks.Controls.Remove(button);

            //Rearranging the Location controls.
            foreach (Button btn in pnlTasks.Controls.OfType<Button>())
            {
                int controlIndex = int.Parse(btn.Name.Split('_')[1]);
                if (controlIndex > index)
                {
                    TextBox txt = (TextBox)pnlTasks.Controls.Find("txt_" + controlIndex, true)[0];
                    btn.Top = btn.Top - 25;
                    txt.Top = txt.Top - 25;
                }
            }
        }

        public bool ShowViewModal()
        {
            if (this.ShowDialog() == DialogResult.OK)
                return true;
            else
                return false;
        }

        public string ReqTitle => textBoxTitle.Text;

        public string ReqDescription => textBoxDescription.Text;

        public string ReqType => comboBoxType.SelectedItem.ToString();

        public string ReqPriority => comboBoxPriority.SelectedItem.ToString();

        public List<string> ReqTasks => getTasks();

        private List<string> getTasks()
        {
            List<string> _tasks = new List<string>();
            if(pnlTasks.Controls.OfType<TextBox>().Count() == 0)
            {
                MessageBox.Show("Requirement must have at least one task");
            }
            else
            {
                foreach (TextBox tb in pnlTasks.Controls.OfType<TextBox>())
                {
                    if (string.IsNullOrEmpty(tb.Text.Trim()))
                    {
                        MessageBox.Show("Text box can't be empty");
                    }
                    _tasks.Add(tb.Text);
                }
                return _tasks;
            }

            return null;
        }
    }
}
