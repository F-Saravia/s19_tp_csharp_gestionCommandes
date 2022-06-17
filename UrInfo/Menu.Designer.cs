namespace UrInfo
{
    partial class Menu
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
            this.label_loggedEmploye_Type = new System.Windows.Forms.Label();
            this.label_loggedEmploye_Name = new System.Windows.Forms.Label();
            this.btn_seDeconnecter = new System.Windows.Forms.Button();
            this.btn_listeCommandes = new System.Windows.Forms.Button();
            this.btn_rechercherCommande = new System.Windows.Forms.Button();
            this.flowLayoutPanel_Recherche = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox_inputRecherche = new System.Windows.Forms.TextBox();
            this.comboBox_ChercherPar = new System.Windows.Forms.ComboBox();
            this.btn_lancerRecherche = new System.Windows.Forms.Button();
            this.dataGridView_listeCommandes = new System.Windows.Forms.DataGridView();
            this.btn_RetourAuMenu = new System.Windows.Forms.Button();
            this.flowLayoutPanel_Recherche.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_listeCommandes)).BeginInit();
            this.SuspendLayout();
            // 
            // label_loggedEmploye_Type
            // 
            this.label_loggedEmploye_Type.AutoSize = true;
            this.label_loggedEmploye_Type.Location = new System.Drawing.Point(25, 25);
            this.label_loggedEmploye_Type.Name = "label_loggedEmploye_Type";
            this.label_loggedEmploye_Type.Size = new System.Drawing.Size(149, 15);
            this.label_loggedEmploye_Type.TabIndex = 0;
            this.label_loggedEmploye_Type.Text = "label_loggedEmploye_Type";
            // 
            // label_loggedEmploye_Name
            // 
            this.label_loggedEmploye_Name.AutoSize = true;
            this.label_loggedEmploye_Name.Location = new System.Drawing.Point(320, 25);
            this.label_loggedEmploye_Name.Name = "label_loggedEmploye_Name";
            this.label_loggedEmploye_Name.Size = new System.Drawing.Size(157, 15);
            this.label_loggedEmploye_Name.TabIndex = 1;
            this.label_loggedEmploye_Name.Text = "label_loggedEmploye_Name";
            // 
            // btn_seDeconnecter
            // 
            this.btn_seDeconnecter.AutoSize = true;
            this.btn_seDeconnecter.Location = new System.Drawing.Point(682, 25);
            this.btn_seDeconnecter.Name = "btn_seDeconnecter";
            this.btn_seDeconnecter.Size = new System.Drawing.Size(98, 25);
            this.btn_seDeconnecter.TabIndex = 2;
            this.btn_seDeconnecter.Text = "Se déconnecter";
            this.btn_seDeconnecter.UseVisualStyleBackColor = true;
            this.btn_seDeconnecter.Click += new System.EventHandler(this.btn_seDeconnecter_Click);
            // 
            // btn_listeCommandes
            // 
            this.btn_listeCommandes.AutoSize = true;
            this.btn_listeCommandes.Location = new System.Drawing.Point(336, 85);
            this.btn_listeCommandes.Name = "btn_listeCommandes";
            this.btn_listeCommandes.Size = new System.Drawing.Size(126, 25);
            this.btn_listeCommandes.TabIndex = 3;
            this.btn_listeCommandes.Text = "Liste de commandes";
            this.btn_listeCommandes.UseVisualStyleBackColor = true;
            this.btn_listeCommandes.Click += new System.EventHandler(this.btn_listeCommandes_Click);
            // 
            // btn_rechercherCommande
            // 
            this.btn_rechercherCommande.AutoSize = true;
            this.btn_rechercherCommande.Location = new System.Drawing.Point(314, 116);
            this.btn_rechercherCommande.Name = "btn_rechercherCommande";
            this.btn_rechercherCommande.Size = new System.Drawing.Size(163, 25);
            this.btn_rechercherCommande.TabIndex = 4;
            this.btn_rechercherCommande.Text = "Rechercher une commande";
            this.btn_rechercherCommande.UseVisualStyleBackColor = true;
            this.btn_rechercherCommande.Click += new System.EventHandler(this.btn_rechercherCommande_Click);
            // 
            // flowLayoutPanel_Recherche
            // 
            this.flowLayoutPanel_Recherche.Controls.Add(this.textBox_inputRecherche);
            this.flowLayoutPanel_Recherche.Controls.Add(this.comboBox_ChercherPar);
            this.flowLayoutPanel_Recherche.Controls.Add(this.btn_lancerRecherche);
            this.flowLayoutPanel_Recherche.Location = new System.Drawing.Point(22, 192);
            this.flowLayoutPanel_Recherche.Name = "flowLayoutPanel_Recherche";
            this.flowLayoutPanel_Recherche.Size = new System.Drawing.Size(766, 34);
            this.flowLayoutPanel_Recherche.TabIndex = 5;
            // 
            // textBox_inputRecherche
            // 
            this.textBox_inputRecherche.Location = new System.Drawing.Point(3, 3);
            this.textBox_inputRecherche.Name = "textBox_inputRecherche";
            this.textBox_inputRecherche.Size = new System.Drawing.Size(509, 23);
            this.textBox_inputRecherche.TabIndex = 0;
            // 
            // comboBox_ChercherPar
            // 
            this.comboBox_ChercherPar.FormattingEnabled = true;
            this.comboBox_ChercherPar.Location = new System.Drawing.Point(518, 3);
            this.comboBox_ChercherPar.Name = "comboBox_ChercherPar";
            this.comboBox_ChercherPar.Size = new System.Drawing.Size(164, 23);
            this.comboBox_ChercherPar.TabIndex = 1;
            this.comboBox_ChercherPar.Text = "Choisir un champ";
            // 
            // btn_lancerRecherche
            // 
            this.btn_lancerRecherche.Location = new System.Drawing.Point(688, 3);
            this.btn_lancerRecherche.Name = "btn_lancerRecherche";
            this.btn_lancerRecherche.Size = new System.Drawing.Size(75, 23);
            this.btn_lancerRecherche.TabIndex = 2;
            this.btn_lancerRecherche.Text = "Rechercher";
            this.btn_lancerRecherche.UseVisualStyleBackColor = true;
            this.btn_lancerRecherche.Click += new System.EventHandler(this.btn_lancerRecherche_Click);
            // 
            // dataGridView_listeCommandes
            // 
            this.dataGridView_listeCommandes.AllowUserToOrderColumns = true;
            this.dataGridView_listeCommandes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_listeCommandes.Location = new System.Drawing.Point(22, 232);
            this.dataGridView_listeCommandes.Name = "dataGridView_listeCommandes";
            this.dataGridView_listeCommandes.RowTemplate.Height = 25;
            this.dataGridView_listeCommandes.Size = new System.Drawing.Size(766, 206);
            this.dataGridView_listeCommandes.TabIndex = 6;
            // 
            // btn_RetourAuMenu
            // 
            this.btn_RetourAuMenu.AutoSize = true;
            this.btn_RetourAuMenu.Location = new System.Drawing.Point(346, 147);
            this.btn_RetourAuMenu.Name = "btn_RetourAuMenu";
            this.btn_RetourAuMenu.Size = new System.Drawing.Size(102, 25);
            this.btn_RetourAuMenu.TabIndex = 7;
            this.btn_RetourAuMenu.Text = "Retour au menu";
            this.btn_RetourAuMenu.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_RetourAuMenu);
            this.Controls.Add(this.dataGridView_listeCommandes);
            this.Controls.Add(this.flowLayoutPanel_Recherche);
            this.Controls.Add(this.btn_rechercherCommande);
            this.Controls.Add(this.btn_listeCommandes);
            this.Controls.Add(this.btn_seDeconnecter);
            this.Controls.Add(this.label_loggedEmploye_Name);
            this.Controls.Add(this.label_loggedEmploye_Type);
            this.Name = "Menu";
            this.Text = "Menu";
            this.flowLayoutPanel_Recherche.ResumeLayout(false);
            this.flowLayoutPanel_Recherche.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_listeCommandes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_loggedEmploye_Type;
        private Label label_loggedEmploye_Name;
        private Button btn_seDeconnecter;
        private Button btn_listeCommandes;
        private Button btn_rechercherCommande;
        private FlowLayoutPanel flowLayoutPanel_Recherche;
        private TextBox textBox_inputRecherche;
        private ComboBox comboBox_ChercherPar;
        private Button btn_lancerRecherche;
        private DataGridView dataGridView_listeCommandes;
        private Button btn_RetourAuMenu;
    }
}