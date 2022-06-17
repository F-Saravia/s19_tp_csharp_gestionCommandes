namespace UrInfo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param login="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_type = new System.Windows.Forms.TextBox();
            this.lb_id = new System.Windows.Forms.Label();
            this.lb_type = new System.Windows.Forms.Label();
            this.bt_modifier = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(43, 69);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 29;
            this.dataGridView.Size = new System.Drawing.Size(694, 350);
            this.dataGridView.TabIndex = 0;
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(109, 25);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(125, 27);
            this.tb_id.TabIndex = 1;
            // 
            // tb_type
            // 
            this.tb_type.Location = new System.Drawing.Point(294, 25);
            this.tb_type.Name = "tb_type";
            this.tb_type.Size = new System.Drawing.Size(125, 27);
            this.tb_type.TabIndex = 2;
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Location = new System.Drawing.Point(50, 29);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(22, 20);
            this.lb_id.TabIndex = 3;
            this.lb_id.Text = "id";
            this.lb_id.Click += new System.EventHandler(this.label1_Click);
            // 
            // lb_type
            // 
            this.lb_type.AutoSize = true;
            this.lb_type.Location = new System.Drawing.Point(240, 32);
            this.lb_type.Name = "lb_type";
            this.lb_type.Size = new System.Drawing.Size(40, 20);
            this.lb_type.TabIndex = 4;
            this.lb_type.Text = "Type";
            // 
            // bt_modifier
            // 
            this.bt_modifier.Location = new System.Drawing.Point(491, 25);
            this.bt_modifier.Name = "bt_modifier";
            this.bt_modifier.Size = new System.Drawing.Size(94, 29);
            this.bt_modifier.TabIndex = 5;
            this.bt_modifier.Text = "Modifier";
            this.bt_modifier.UseVisualStyleBackColor = true;
            this.bt_modifier.Click += new System.EventHandler(this.bt_modifier_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_modifier);
            this.Controls.Add(this.lb_type);
            this.Controls.Add(this.lb_id);
            this.Controls.Add(this.tb_type);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.dataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView;
        private TextBox tb_id;
        private TextBox tb_type;
        private Label lb_id;
        private Label lb_type;
        private Button bt_modifier;
    }
}