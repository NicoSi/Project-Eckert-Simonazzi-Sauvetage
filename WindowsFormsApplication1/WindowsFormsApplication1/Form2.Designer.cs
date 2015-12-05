namespace WindowsFormsApplication1
{
    partial class Form2
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
            this.panelInteractionActivité = new System.Windows.Forms.Panel();
            this.labelAstronautesActivite = new System.Windows.Forms.Label();
            this.listBoxAstronautes = new System.Windows.Forms.ListBox();
            this.labelDescriptifActivite = new System.Windows.Forms.Label();
            this.labelLieuActivite = new System.Windows.Forms.Label();
            this.labelNomActivite = new System.Windows.Forms.Label();
            this.buttonSupprimerActivité = new System.Windows.Forms.Button();
            this.buttonAfficherLieuActivité = new System.Windows.Forms.Button();
            this.labelPlageHoraireActivité = new System.Windows.Forms.Label();
            this.labelJourActivité = new System.Windows.Forms.Label();
            this.labelTypeActivité = new System.Windows.Forms.Label();
            this.texteDescriptifActivite = new System.Windows.Forms.RichTextBox();
            this.buttonModifierActivité = new System.Windows.Forms.Button();
            this.buttonAjouterActivité = new System.Windows.Forms.Button();
            this.panelListeActivité = new System.Windows.Forms.Panel();
            this.boutonEffacerActivite = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.labelNumeroJour = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.boutonJourSuivant = new System.Windows.Forms.Button();
            this.boutonJourPrecedent = new System.Windows.Forms.Button();
            this.panelCompteRendu = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.labelCompteRendu = new System.Windows.Forms.Label();
            this.richTextBoxCompteRendu = new System.Windows.Forms.RichTextBox();
            this.panelInteractionActivité.SuspendLayout();
            this.panelListeActivité.SuspendLayout();
            this.panelCompteRendu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelInteractionActivité
            // 
            this.panelInteractionActivité.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInteractionActivité.Controls.Add(this.labelAstronautesActivite);
            this.panelInteractionActivité.Controls.Add(this.listBoxAstronautes);
            this.panelInteractionActivité.Controls.Add(this.labelDescriptifActivite);
            this.panelInteractionActivité.Controls.Add(this.labelLieuActivite);
            this.panelInteractionActivité.Controls.Add(this.labelNomActivite);
            this.panelInteractionActivité.Controls.Add(this.buttonSupprimerActivité);
            this.panelInteractionActivité.Controls.Add(this.buttonAfficherLieuActivité);
            this.panelInteractionActivité.Controls.Add(this.labelPlageHoraireActivité);
            this.panelInteractionActivité.Controls.Add(this.labelJourActivité);
            this.panelInteractionActivité.Controls.Add(this.labelTypeActivité);
            this.panelInteractionActivité.Controls.Add(this.texteDescriptifActivite);
            this.panelInteractionActivité.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelInteractionActivité.Location = new System.Drawing.Point(693, 90);
            this.panelInteractionActivité.Name = "panelInteractionActivité";
            this.panelInteractionActivité.Size = new System.Drawing.Size(568, 416);
            this.panelInteractionActivité.TabIndex = 0;
            // 
            // labelAstronautesActivite
            // 
            this.labelAstronautesActivite.AutoSize = true;
            this.labelAstronautesActivite.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAstronautesActivite.Location = new System.Drawing.Point(306, 238);
            this.labelAstronautesActivite.Name = "labelAstronautesActivite";
            this.labelAstronautesActivite.Size = new System.Drawing.Size(157, 18);
            this.labelAstronautesActivite.TabIndex = 11;
            this.labelAstronautesActivite.Text = "Liste des astronautes :";
            // 
            // listBoxAstronautes
            // 
            this.listBoxAstronautes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxAstronautes.FormattingEnabled = true;
            this.listBoxAstronautes.ItemHeight = 18;
            this.listBoxAstronautes.Location = new System.Drawing.Point(310, 279);
            this.listBoxAstronautes.Name = "listBoxAstronautes";
            this.listBoxAstronautes.Size = new System.Drawing.Size(242, 112);
            this.listBoxAstronautes.TabIndex = 1;
            // 
            // labelDescriptifActivite
            // 
            this.labelDescriptifActivite.AutoSize = true;
            this.labelDescriptifActivite.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescriptifActivite.Location = new System.Drawing.Point(22, 238);
            this.labelDescriptifActivite.Name = "labelDescriptifActivite";
            this.labelDescriptifActivite.Size = new System.Drawing.Size(153, 18);
            this.labelDescriptifActivite.TabIndex = 10;
            this.labelDescriptifActivite.Text = "Descriptif de l\'activité :";
            // 
            // labelLieuActivite
            // 
            this.labelLieuActivite.AutoSize = true;
            this.labelLieuActivite.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLieuActivite.Location = new System.Drawing.Point(22, 198);
            this.labelLieuActivite.Name = "labelLieuActivite";
            this.labelLieuActivite.Size = new System.Drawing.Size(43, 18);
            this.labelLieuActivite.TabIndex = 9;
            this.labelLieuActivite.Text = "Lieu :";
            // 
            // labelNomActivite
            // 
            this.labelNomActivite.AutoSize = true;
            this.labelNomActivite.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomActivite.Location = new System.Drawing.Point(20, 15);
            this.labelNomActivite.Name = "labelNomActivite";
            this.labelNomActivite.Size = new System.Drawing.Size(86, 31);
            this.labelNomActivite.TabIndex = 8;
            this.labelNomActivite.Text = "label2";
            // 
            // buttonSupprimerActivité
            // 
            this.buttonSupprimerActivité.Location = new System.Drawing.Point(428, 21);
            this.buttonSupprimerActivité.Name = "buttonSupprimerActivité";
            this.buttonSupprimerActivité.Size = new System.Drawing.Size(107, 30);
            this.buttonSupprimerActivité.TabIndex = 6;
            this.buttonSupprimerActivité.Text = "Supprimer activité";
            this.buttonSupprimerActivité.UseVisualStyleBackColor = true;
            this.buttonSupprimerActivité.Click += new System.EventHandler(this.buttonSupprimerActivité_Click);
            // 
            // buttonAfficherLieuActivité
            // 
            this.buttonAfficherLieuActivité.Location = new System.Drawing.Point(428, 65);
            this.buttonAfficherLieuActivité.Name = "buttonAfficherLieuActivité";
            this.buttonAfficherLieuActivité.Size = new System.Drawing.Size(107, 30);
            this.buttonAfficherLieuActivité.TabIndex = 4;
            this.buttonAfficherLieuActivité.Text = "Afficher le lieu";
            this.buttonAfficherLieuActivité.UseVisualStyleBackColor = true;
            // 
            // labelPlageHoraireActivité
            // 
            this.labelPlageHoraireActivité.AutoSize = true;
            this.labelPlageHoraireActivité.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlageHoraireActivité.Location = new System.Drawing.Point(22, 161);
            this.labelPlageHoraireActivité.Name = "labelPlageHoraireActivité";
            this.labelPlageHoraireActivité.Size = new System.Drawing.Size(73, 18);
            this.labelPlageHoraireActivité.TabIndex = 3;
            this.labelPlageHoraireActivité.Text = "Horaires :";
            // 
            // labelJourActivité
            // 
            this.labelJourActivité.AutoSize = true;
            this.labelJourActivité.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJourActivité.Location = new System.Drawing.Point(22, 123);
            this.labelJourActivité.Name = "labelJourActivité";
            this.labelJourActivité.Size = new System.Drawing.Size(46, 18);
            this.labelJourActivité.TabIndex = 2;
            this.labelJourActivité.Text = "Jour :";
            // 
            // labelTypeActivité
            // 
            this.labelTypeActivité.AutoSize = true;
            this.labelTypeActivité.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTypeActivité.Location = new System.Drawing.Point(22, 78);
            this.labelTypeActivité.Name = "labelTypeActivité";
            this.labelTypeActivité.Size = new System.Drawing.Size(48, 18);
            this.labelTypeActivité.TabIndex = 1;
            this.labelTypeActivité.Text = "Type :";
            // 
            // texteDescriptifActivite
            // 
            this.texteDescriptifActivite.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texteDescriptifActivite.Location = new System.Drawing.Point(26, 275);
            this.texteDescriptifActivite.Name = "texteDescriptifActivite";
            this.texteDescriptifActivite.Size = new System.Drawing.Size(278, 124);
            this.texteDescriptifActivite.TabIndex = 0;
            this.texteDescriptifActivite.Text = "";
            this.texteDescriptifActivite.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // buttonModifierActivité
            // 
            this.buttonModifierActivité.Location = new System.Drawing.Point(149, 369);
            this.buttonModifierActivité.Name = "buttonModifierActivité";
            this.buttonModifierActivité.Size = new System.Drawing.Size(107, 30);
            this.buttonModifierActivité.TabIndex = 5;
            this.buttonModifierActivité.Text = "Modifier Activité";
            this.buttonModifierActivité.UseVisualStyleBackColor = true;
            this.buttonModifierActivité.Click += new System.EventHandler(this.buttonModifierActivité_Click);
            // 
            // buttonAjouterActivité
            // 
            this.buttonAjouterActivité.Location = new System.Drawing.Point(262, 369);
            this.buttonAjouterActivité.Name = "buttonAjouterActivité";
            this.buttonAjouterActivité.Size = new System.Drawing.Size(107, 30);
            this.buttonAjouterActivité.TabIndex = 7;
            this.buttonAjouterActivité.Text = "Ajouter une activité";
            this.buttonAjouterActivité.UseVisualStyleBackColor = true;
            this.buttonAjouterActivité.Click += new System.EventHandler(this.buttonAjouterActivité_Click);
            // 
            // panelListeActivité
            // 
            this.panelListeActivité.Controls.Add(this.label2);
            this.panelListeActivité.Controls.Add(this.boutonEffacerActivite);
            this.panelListeActivité.Controls.Add(this.listBox1);
            this.panelListeActivité.Controls.Add(this.buttonAjouterActivité);
            this.panelListeActivité.Controls.Add(this.buttonModifierActivité);
            this.panelListeActivité.Location = new System.Drawing.Point(305, 90);
            this.panelListeActivité.Name = "panelListeActivité";
            this.panelListeActivité.Size = new System.Drawing.Size(382, 416);
            this.panelListeActivité.TabIndex = 1;
            // 
            // boutonEffacerActivite
            // 
            this.boutonEffacerActivite.Location = new System.Drawing.Point(29, 365);
            this.boutonEffacerActivite.Name = "boutonEffacerActivite";
            this.boutonEffacerActivite.Size = new System.Drawing.Size(114, 38);
            this.boutonEffacerActivite.TabIndex = 8;
            this.boutonEffacerActivite.Text = "Effacer toutes les activités";
            this.boutonEffacerActivite.UseVisualStyleBackColor = true;
            this.boutonEffacerActivite.Click += new System.EventHandler(this.boutonEffacerActivite_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(29, 51);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(340, 292);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // labelNumeroJour
            // 
            this.labelNumeroJour.AutoSize = true;
            this.labelNumeroJour.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumeroJour.Location = new System.Drawing.Point(474, 20);
            this.labelNumeroJour.Name = "labelNumeroJour";
            this.labelNumeroJour.Size = new System.Drawing.Size(86, 31);
            this.labelNumeroJour.TabIndex = 2;
            this.labelNumeroJour.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(372, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Jour n°";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // boutonJourSuivant
            // 
            this.boutonJourSuivant.Location = new System.Drawing.Point(1151, 43);
            this.boutonJourSuivant.Name = "boutonJourSuivant";
            this.boutonJourSuivant.Size = new System.Drawing.Size(110, 26);
            this.boutonJourSuivant.TabIndex = 4;
            this.boutonJourSuivant.Text = "Jour suivant";
            this.boutonJourSuivant.UseVisualStyleBackColor = true;
            this.boutonJourSuivant.Click += new System.EventHandler(this.boutonJourSuivant_Click);
            // 
            // boutonJourPrecedent
            // 
            this.boutonJourPrecedent.Location = new System.Drawing.Point(13, 43);
            this.boutonJourPrecedent.Name = "boutonJourPrecedent";
            this.boutonJourPrecedent.Size = new System.Drawing.Size(110, 26);
            this.boutonJourPrecedent.TabIndex = 5;
            this.boutonJourPrecedent.Text = "Jour precedent";
            this.boutonJourPrecedent.UseVisualStyleBackColor = true;
            this.boutonJourPrecedent.Click += new System.EventHandler(this.boutonJourPrecedent_Click);
            // 
            // panelCompteRendu
            // 
            this.panelCompteRendu.Controls.Add(this.richTextBoxCompteRendu);
            this.panelCompteRendu.Controls.Add(this.labelCompteRendu);
            this.panelCompteRendu.Location = new System.Drawing.Point(32, 90);
            this.panelCompteRendu.Name = "panelCompteRendu";
            this.panelCompteRendu.Size = new System.Drawing.Size(267, 416);
            this.panelCompteRendu.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Liste d\'activités :";
            // 
            // labelCompteRendu
            // 
            this.labelCompteRendu.AutoSize = true;
            this.labelCompteRendu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCompteRendu.Location = new System.Drawing.Point(23, 15);
            this.labelCompteRendu.Name = "labelCompteRendu";
            this.labelCompteRendu.Size = new System.Drawing.Size(180, 20);
            this.labelCompteRendu.TabIndex = 10;
            this.labelCompteRendu.Text = "Compte rendu  du jour:";
            // 
            // richTextBoxCompteRendu
            // 
            this.richTextBoxCompteRendu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxCompteRendu.Location = new System.Drawing.Point(27, 38);
            this.richTextBoxCompteRendu.Name = "richTextBoxCompteRendu";
            this.richTextBoxCompteRendu.Size = new System.Drawing.Size(220, 335);
            this.richTextBoxCompteRendu.TabIndex = 11;
            this.richTextBoxCompteRendu.Text = "";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 532);
            this.Controls.Add(this.panelCompteRendu);
            this.Controls.Add(this.boutonJourPrecedent);
            this.Controls.Add(this.boutonJourSuivant);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelNumeroJour);
            this.Controls.Add(this.panelListeActivité);
            this.Controls.Add(this.panelInteractionActivité);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panelInteractionActivité.ResumeLayout(false);
            this.panelInteractionActivité.PerformLayout();
            this.panelListeActivité.ResumeLayout(false);
            this.panelListeActivité.PerformLayout();
            this.panelCompteRendu.ResumeLayout(false);
            this.panelCompteRendu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelInteractionActivité;
        private System.Windows.Forms.RichTextBox texteDescriptifActivite;
        private System.Windows.Forms.Panel panelListeActivité;
        private System.Windows.Forms.Button buttonAjouterActivité;
        private System.Windows.Forms.Button buttonSupprimerActivité;
        private System.Windows.Forms.Button buttonModifierActivité;
        private System.Windows.Forms.Button buttonAfficherLieuActivité;
        private System.Windows.Forms.Label labelPlageHoraireActivité;
        private System.Windows.Forms.Label labelJourActivité;
        private System.Windows.Forms.Label labelTypeActivité;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label labelNumeroJour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNomActivite;
        private System.Windows.Forms.Label labelLieuActivite;
        private System.Windows.Forms.Label labelAstronautesActivite;
        private System.Windows.Forms.ListBox listBoxAstronautes;
        private System.Windows.Forms.Label labelDescriptifActivite;
        private System.Windows.Forms.Button boutonJourSuivant;
        private System.Windows.Forms.Button boutonJourPrecedent;
        private System.Windows.Forms.Button boutonEffacerActivite;
        private System.Windows.Forms.Panel panelCompteRendu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelCompteRendu;
        private System.Windows.Forms.RichTextBox richTextBoxCompteRendu;
    }
}