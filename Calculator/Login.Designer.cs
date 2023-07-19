namespace Calculator
{
    partial class Login
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
            REGISTER = new Button();
            label1 = new Label();
            label2 = new Label();
            txt_name = new TextBox();
            txt_pass = new TextBox();
            SuspendLayout();
            // 
            // REGISTER
            // 
            REGISTER.BackColor = SystemColors.AppWorkspace;
            REGISTER.BackgroundImageLayout = ImageLayout.None;
            REGISTER.FlatAppearance.BorderColor = SystemColors.AppWorkspace;
            REGISTER.FlatStyle = FlatStyle.Popup;
            REGISTER.Location = new Point(404, 335);
            REGISTER.Margin = new Padding(4);
            REGISTER.Name = "REGISTER";
            REGISTER.Size = new Size(141, 41);
            REGISTER.TabIndex = 0;
            REGISTER.Text = "Register";
            REGISTER.UseVisualStyleBackColor = false;
            REGISTER.Click += REGISTER_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(286, 175);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(107, 28);
            label1.TabIndex = 1;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(286, 256);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(102, 28);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // txt_name
            // 
            txt_name.AcceptsTab = true;
            txt_name.Location = new Point(404, 175);
            txt_name.Margin = new Padding(4);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(242, 34);
            txt_name.TabIndex = 3;
            // 
            // txt_pass
            // 
            txt_pass.Location = new Point(404, 252);
            txt_pass.Margin = new Padding(4);
            txt_pass.Name = "txt_pass";
            txt_pass.PasswordChar = '*';
            txt_pass.Size = new Size(242, 34);
            txt_pass.TabIndex = 4;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(1052, 592);
            Controls.Add(txt_pass);
            Controls.Add(txt_name);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(REGISTER);
            Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button REGISTER;
        private Label label1;
        private Label label2;
        private TextBox txt_name;
        private TextBox txt_pass;
    }
}