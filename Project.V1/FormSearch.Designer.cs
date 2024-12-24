namespace Project.V1
{
    partial class FormSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSearch));
            groupBoxSearchForm_GSA = new GroupBox();
            buttonGoSearch_GSA = new Button();
            textBoxSearch_GSA = new TextBox();
            groupBoxSearchForm_GSA.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxSearchForm_GSA
            // 
            groupBoxSearchForm_GSA.Controls.Add(buttonGoSearch_GSA);
            groupBoxSearchForm_GSA.Controls.Add(textBoxSearch_GSA);
            groupBoxSearchForm_GSA.Location = new Point(12, 12);
            groupBoxSearchForm_GSA.Name = "groupBoxSearchForm_GSA";
            groupBoxSearchForm_GSA.Size = new Size(309, 113);
            groupBoxSearchForm_GSA.TabIndex = 0;
            groupBoxSearchForm_GSA.TabStop = false;
            groupBoxSearchForm_GSA.Text = "Введите номер:";
            // 
            // buttonGoSearch_GSA
            // 
            buttonGoSearch_GSA.Image = (Image)resources.GetObject("buttonGoSearch_GSA.Image");
            buttonGoSearch_GSA.Location = new Point(238, 58);
            buttonGoSearch_GSA.Name = "buttonGoSearch_GSA";
            buttonGoSearch_GSA.Size = new Size(46, 34);
            buttonGoSearch_GSA.TabIndex = 1;
            buttonGoSearch_GSA.UseVisualStyleBackColor = true;
            buttonGoSearch_GSA.Click += buttonGoSearch_GSA_Click;
            buttonGoSearch_GSA.MouseEnter += buttonGoSearch_GSA_MouseEnter;
            // 
            // textBoxSearch_GSA
            // 
            textBoxSearch_GSA.Location = new Point(6, 60);
            textBoxSearch_GSA.Name = "textBoxSearch_GSA";
            textBoxSearch_GSA.Size = new Size(210, 31);
            textBoxSearch_GSA.TabIndex = 0;
            // 
            // FormSearch
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 137);
            Controls.Add(groupBoxSearchForm_GSA);
            Name = "FormSearch";
            Text = "Поиск";
            groupBoxSearchForm_GSA.ResumeLayout(false);
            groupBoxSearchForm_GSA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxSearchForm_GSA;
        private TextBox textBoxSearch_GSA;
        private Button buttonGoSearch_GSA;
    }
}