namespace C__project
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.stdName = new Guna.UI.WinForms.GunaLabel();
            this.stdPhone = new Guna.UI.WinForms.GunaLabel();
            this.stdAge = new Guna.UI.WinForms.GunaLabel();
            this.txtName = new Guna.UI.WinForms.GunaTextBox();
            this.txtAge = new Guna.UI.WinForms.GunaTextBox();
            this.txtPhone = new Guna.UI.WinForms.GunaTextBox();
            this.registerbtn = new Guna.UI.WinForms.GunaButton();
            this.SuspendLayout();
            // 
            // stdName
            // 
            this.stdName.AutoSize = true;
            this.stdName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stdName.Location = new System.Drawing.Point(44, 46);
            this.stdName.Name = "stdName";
            this.stdName.Size = new System.Drawing.Size(240, 45);
            this.stdName.TabIndex = 0;
            this.stdName.Text = "Student Name: ";
            this.stdName.Click += new System.EventHandler(this.stdName_Click);
            // 
            // stdPhone
            // 
            this.stdPhone.AutoSize = true;
            this.stdPhone.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stdPhone.Location = new System.Drawing.Point(44, 134);
            this.stdPhone.Name = "stdPhone";
            this.stdPhone.Size = new System.Drawing.Size(245, 45);
            this.stdPhone.TabIndex = 1;
            this.stdPhone.Text = "Student Phone: ";
            // 
            // stdAge
            // 
            this.stdAge.AutoSize = true;
            this.stdAge.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stdAge.Location = new System.Drawing.Point(44, 208);
            this.stdAge.Name = "stdAge";
            this.stdAge.Size = new System.Drawing.Size(212, 45);
            this.stdAge.TabIndex = 2;
            this.stdAge.Text = "Student Age: ";
            // 
            // txtName
            // 
            this.txtName.BaseColor = System.Drawing.Color.White;
            this.txtName.BorderColor = System.Drawing.Color.Silver;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.FocusedBaseColor = System.Drawing.Color.White;
            this.txtName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(324, 43);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(572, 48);
            this.txtName.TabIndex = 3;
            // 
            // txtAge
            // 
            this.txtAge.BaseColor = System.Drawing.Color.White;
            this.txtAge.BorderColor = System.Drawing.Color.Silver;
            this.txtAge.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAge.FocusedBaseColor = System.Drawing.Color.White;
            this.txtAge.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtAge.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtAge.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.Location = new System.Drawing.Point(324, 218);
            this.txtAge.Name = "txtAge";
            this.txtAge.PasswordChar = '\0';
            this.txtAge.SelectedText = "";
            this.txtAge.Size = new System.Drawing.Size(572, 48);
            this.txtAge.TabIndex = 4;
            // 
            // txtPhone
            // 
            this.txtPhone.BaseColor = System.Drawing.Color.White;
            this.txtPhone.BorderColor = System.Drawing.Color.Silver;
            this.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhone.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPhone.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtPhone.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(324, 131);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.SelectedText = "";
            this.txtPhone.Size = new System.Drawing.Size(572, 48);
            this.txtPhone.TabIndex = 5;
            // 
            // registerbtn
            // 
            this.registerbtn.AnimationHoverSpeed = 0.07F;
            this.registerbtn.AnimationSpeed = 0.03F;
            this.registerbtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.registerbtn.BorderColor = System.Drawing.Color.Black;
            this.registerbtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.registerbtn.FocusedColor = System.Drawing.Color.Empty;
            this.registerbtn.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerbtn.ForeColor = System.Drawing.Color.White;
            this.registerbtn.Image = ((System.Drawing.Image)(resources.GetObject("registerbtn.Image")));
            this.registerbtn.ImageSize = new System.Drawing.Size(20, 20);
            this.registerbtn.Location = new System.Drawing.Point(448, 298);
            this.registerbtn.Name = "registerbtn";
            this.registerbtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.registerbtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.registerbtn.OnHoverForeColor = System.Drawing.Color.White;
            this.registerbtn.OnHoverImage = null;
            this.registerbtn.OnPressedColor = System.Drawing.Color.Black;
            this.registerbtn.Size = new System.Drawing.Size(187, 71);
            this.registerbtn.TabIndex = 6;
            this.registerbtn.Text = "Register";
            this.registerbtn.Click += new System.EventHandler(this.registerbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 633);
            this.Controls.Add(this.registerbtn);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.stdAge);
            this.Controls.Add(this.stdPhone);
            this.Controls.Add(this.stdName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel stdName;
        private Guna.UI.WinForms.GunaLabel stdPhone;
        private Guna.UI.WinForms.GunaLabel stdAge;
        private Guna.UI.WinForms.GunaTextBox txtName;
        private Guna.UI.WinForms.GunaTextBox txtAge;
        private Guna.UI.WinForms.GunaTextBox txtPhone;
        private Guna.UI.WinForms.GunaButton registerbtn;
    }
}

