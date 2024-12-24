namespace Project.V1
{
    partial class FormAbout
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
            textBoxHelp_GSA = new TextBox();
            buttonHelpOK_GSA = new Button();
            SuspendLayout();
            // 
            // textBoxHelp_GSA
            // 
            textBoxHelp_GSA.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBoxHelp_GSA.Location = new Point(12, 12);
            textBoxHelp_GSA.Multiline = true;
            textBoxHelp_GSA.Name = "textBoxHelp_GSA";
            textBoxHelp_GSA.Size = new Size(776, 369);
            textBoxHelp_GSA.TabIndex = 0;
            textBoxHelp_GSA.Text = "Работу выполнил:\r\n\r\nГрабина Сергей Александрович\r\n\r\nИСТНб-24-1\r\n\r\nПредметная область: Авторемонтные мастерские\r\n";
            // 
            // buttonHelpOK_GSA
            // 
            buttonHelpOK_GSA.Location = new Point(672, 404);
            buttonHelpOK_GSA.Name = "buttonHelpOK_GSA";
            buttonHelpOK_GSA.Size = new Size(116, 34);
            buttonHelpOK_GSA.TabIndex = 1;
            buttonHelpOK_GSA.Text = "OK";
            buttonHelpOK_GSA.UseVisualStyleBackColor = true;
            buttonHelpOK_GSA.Click += buttonHelpOK_GSA_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonHelpOK_GSA);
            Controls.Add(textBoxHelp_GSA);
            Name = "FormAbout";
            Text = "Справка";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxHelp_GSA;
        private Button buttonHelpOK_GSA;
    }
}