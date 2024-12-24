using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.V1
{
    public partial class FormGuide : Form
    {
        public FormGuide()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(FormGuide));
            textBoxGuide_GSA = new TextBox();
            buttonOK_GSA = new Button();
            SuspendLayout();
            // 
            // textBoxGuide_GSA
            // 
            textBoxGuide_GSA.BackColor = SystemColors.ControlLightLight;
            textBoxGuide_GSA.Enabled = false;
            textBoxGuide_GSA.ForeColor = SystemColors.InactiveBorder;
            textBoxGuide_GSA.Location = new Point(11, 14);
            textBoxGuide_GSA.Multiline = true;
            textBoxGuide_GSA.Name = "textBoxGuide_GSA";
            textBoxGuide_GSA.ReadOnly = true;
            textBoxGuide_GSA.Size = new Size(581, 602);
            textBoxGuide_GSA.TabIndex = 0;
            textBoxGuide_GSA.Text = resources.GetString("textBoxGuide_GSA.Text");
            textBoxGuide_GSA.TextChanged += textBoxGuide_GSA_TextChanged;
            // 
            // buttonOK_GSA
            // 
            buttonOK_GSA.FlatStyle = FlatStyle.Popup;
            buttonOK_GSA.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonOK_GSA.Location = new Point(518, 622);
            buttonOK_GSA.Name = "buttonOK_GSA";
            buttonOK_GSA.Size = new Size(74, 32);
            buttonOK_GSA.TabIndex = 1;
            buttonOK_GSA.Text = "OK";
            buttonOK_GSA.UseVisualStyleBackColor = true;
            buttonOK_GSA.Click += buttonOK_GSA_Click;
            buttonOK_GSA.MouseEnter += buttonOK_GSA_MouseEnter;
            // 
            // FormGuide
            // 
            ClientSize = new Size(604, 666);
            Controls.Add(buttonOK_GSA);
            Controls.Add(textBoxGuide_GSA);
            Name = "FormGuide";
            Text = "Руководство пользователя";
            ResumeLayout(false);
            PerformLayout();
        }

        private TextBox textBoxGuide_GSA;
        private Button buttonOK_GSA;

        private void buttonOK_GSA_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxGuide_GSA_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonOK_GSA_MouseEnter(object sender, EventArgs e)
        {

        }
    }
}

