namespace UrInfo
{
    partial class Connexion
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label_loginError = new System.Windows.Forms.Label();
            this.label_login = new System.Windows.Forms.Label();
            this.label_passwordError = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.button_seConnecter = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.label_loginError, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_login, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_passwordError, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label_password, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox_login, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox_password, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.button_seConnecter, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(173, 75);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(459, 304);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label_loginError
            // 
            this.label_loginError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label_loginError.AutoSize = true;
            this.label_loginError.Location = new System.Drawing.Point(155, 22);
            this.label_loginError.Name = "label_loginError";
            this.label_loginError.Size = new System.Drawing.Size(146, 15);
            this.label_loginError.TabIndex = 0;
            this.label_loginError.Text = "loginError";
            this.label_loginError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_login
            // 
            this.label_login.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label_login.AutoSize = true;
            this.label_login.Location = new System.Drawing.Point(3, 82);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(146, 15);
            this.label_login.TabIndex = 1;
            this.label_login.Text = "Login";
            this.label_login.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_passwordError
            // 
            this.label_passwordError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label_passwordError.AutoSize = true;
            this.label_passwordError.Location = new System.Drawing.Point(155, 142);
            this.label_passwordError.Name = "label_passwordError";
            this.label_passwordError.Size = new System.Drawing.Size(146, 15);
            this.label_passwordError.TabIndex = 2;
            this.label_passwordError.Text = "passwordError";
            this.label_passwordError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_password
            // 
            this.label_password.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(3, 202);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(146, 15);
            this.label_password.TabIndex = 3;
            this.label_password.Text = "Mot de Passe";
            this.label_password.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_login
            // 
            this.textBox_login.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_login.Location = new System.Drawing.Point(155, 78);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(146, 23);
            this.textBox_login.TabIndex = 4;
            this.textBox_login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_login.TextChanged += new System.EventHandler(this.textBox_login_TextChanged);
            // 
            // textBox_password
            // 
            this.textBox_password.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_password.Location = new System.Drawing.Point(155, 198);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(146, 23);
            this.textBox_password.TabIndex = 5;
            this.textBox_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_password.TextChanged += new System.EventHandler(this.textBox_password_TextChanged);
            // 
            // button_seConnecter
            // 
            this.button_seConnecter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button_seConnecter.Location = new System.Drawing.Point(155, 260);
            this.button_seConnecter.Name = "button_seConnecter";
            this.button_seConnecter.Size = new System.Drawing.Size(146, 23);
            this.button_seConnecter.TabIndex = 6;
            this.button_seConnecter.Text = "Se Connecter";
            this.button_seConnecter.UseVisualStyleBackColor = true;
            this.button_seConnecter.Click += new System.EventHandler(this.button_seConnecter_Click);
            // 
            // Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Connexion";
            this.Text = "Connexion";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label_loginError;
        private Label label_login;
        private Label label_passwordError;
        private Label label_password;
        private TextBox textBox_login;
        private TextBox textBox_password;
        private Button button_seConnecter;
    }
}