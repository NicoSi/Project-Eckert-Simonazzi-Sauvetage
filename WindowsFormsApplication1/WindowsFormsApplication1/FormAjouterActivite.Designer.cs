namespace WindowsFormsApplication1
{
    partial class FormAjouterActivite
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
            this.labelTitre = new System.Windows.Forms.Label();
            this.labelAstronautesActivite = new System.Windows.Forms.Label();
            this.labelDescriptifActivite = new System.Windows.Forms.Label();
            this.labelLieuActivite = new System.Windows.Forms.Label();
            this.labelPlageHoraireActivité = new System.Windows.Forms.Label();
            this.labelJourActivité = new System.Windows.Forms.Label();
            this.labelTypeActivité = new System.Windows.Forms.Label();
            this.labelNomActivite = new System.Windows.Forms.Label();
            this.checkedListBoxAstronautes = new System.Windows.Forms.CheckedListBox();
            this.textBoxNomActivite = new System.Windows.Forms.TextBox();
            this.textBoxNomLieu = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.boutonEnregistrerActivite = new System.Windows.Forms.Button();
            this.treeViewTypeActivite = new System.Windows.Forms.TreeView();
            this.comboBoxHeureDebut = new System.Windows.Forms.ComboBox();
            this.comboBoxMinuteDebut = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxNouveauLieu = new System.Windows.Forms.CheckBox();
            this.labelNomLieu = new System.Windows.Forms.Label();
            this.comboBoxListeLieu = new System.Windows.Forms.ComboBox();
            this.labelLieuCoordonneeX = new System.Windows.Forms.Label();
            this.labelLieuCoordonneeY = new System.Windows.Forms.Label();
            this.textBoxCoordonnéesX = new System.Windows.Forms.TextBox();
            this.textBoxCoordonnéesY = new System.Windows.Forms.TextBox();
            this.labelDuree = new System.Windows.Forms.Label();
            this.comboBoxHeureFin = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxMinuteFin = new System.Windows.Forms.ComboBox();
            this.buttonAjouterParCarte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitre
            // 
            this.labelTitre.AutoSize = true;
            this.labelTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitre.Location = new System.Drawing.Point(293, 7);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(216, 31);
            this.labelTitre.TabIndex = 9;
            this.labelTitre.Text = "Nouvelle Activité";
            // 
            // labelAstronautesActivite
            // 
            this.labelAstronautesActivite.AutoSize = true;
            this.labelAstronautesActivite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAstronautesActivite.Location = new System.Drawing.Point(369, 250);
            this.labelAstronautesActivite.Name = "labelAstronautesActivite";
            this.labelAstronautesActivite.Size = new System.Drawing.Size(181, 20);
            this.labelAstronautesActivite.TabIndex = 17;
            this.labelAstronautesActivite.Text = "Liste des astronautes :";
            this.labelAstronautesActivite.Click += new System.EventHandler(this.labelAstronautesActivite_Click);
            // 
            // labelDescriptifActivite
            // 
            this.labelDescriptifActivite.AutoSize = true;
            this.labelDescriptifActivite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescriptifActivite.Location = new System.Drawing.Point(355, 84);
            this.labelDescriptifActivite.Name = "labelDescriptifActivite";
            this.labelDescriptifActivite.Size = new System.Drawing.Size(181, 20);
            this.labelDescriptifActivite.TabIndex = 16;
            this.labelDescriptifActivite.Text = "Descriptif de l\'activité :";
            this.labelDescriptifActivite.Click += new System.EventHandler(this.labelDescriptifActivite_Click);
            // 
            // labelLieuActivite
            // 
            this.labelLieuActivite.AutoSize = true;
            this.labelLieuActivite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLieuActivite.Location = new System.Drawing.Point(23, 379);
            this.labelLieuActivite.Name = "labelLieuActivite";
            this.labelLieuActivite.Size = new System.Drawing.Size(51, 20);
            this.labelLieuActivite.TabIndex = 15;
            this.labelLieuActivite.Text = "Lieu :";
            this.labelLieuActivite.Click += new System.EventHandler(this.labelLieuActivite_Click);
            // 
            // labelPlageHoraireActivité
            // 
            this.labelPlageHoraireActivité.AutoSize = true;
            this.labelPlageHoraireActivité.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlageHoraireActivité.Location = new System.Drawing.Point(23, 291);
            this.labelPlageHoraireActivité.Name = "labelPlageHoraireActivité";
            this.labelPlageHoraireActivité.Size = new System.Drawing.Size(130, 20);
            this.labelPlageHoraireActivité.TabIndex = 14;
            this.labelPlageHoraireActivité.Text = "Horaires debut :";
            this.labelPlageHoraireActivité.Click += new System.EventHandler(this.labelPlageHoraireActivité_Click);
            // 
            // labelJourActivité
            // 
            this.labelJourActivité.AutoSize = true;
            this.labelJourActivité.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJourActivité.Location = new System.Drawing.Point(515, 7);
            this.labelJourActivité.Name = "labelJourActivité";
            this.labelJourActivité.Size = new System.Drawing.Size(82, 31);
            this.labelJourActivité.TabIndex = 13;
            this.labelJourActivité.Text = "Jour :";
            this.labelJourActivité.Click += new System.EventHandler(this.labelJourActivité_Click);
            // 
            // labelTypeActivité
            // 
            this.labelTypeActivité.AutoSize = true;
            this.labelTypeActivité.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTypeActivité.Location = new System.Drawing.Point(12, 129);
            this.labelTypeActivité.Name = "labelTypeActivité";
            this.labelTypeActivité.Size = new System.Drawing.Size(55, 20);
            this.labelTypeActivité.TabIndex = 12;
            this.labelTypeActivité.Text = "Type :";
            // 
            // labelNomActivite
            // 
            this.labelNomActivite.AutoSize = true;
            this.labelNomActivite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomActivite.Location = new System.Drawing.Point(12, 84);
            this.labelNomActivite.Name = "labelNomActivite";
            this.labelNomActivite.Size = new System.Drawing.Size(54, 20);
            this.labelNomActivite.TabIndex = 18;
            this.labelNomActivite.Text = "Nom :";
            // 
            // checkedListBoxAstronautes
            // 
            this.checkedListBoxAstronautes.FormattingEnabled = true;
            this.checkedListBoxAstronautes.Location = new System.Drawing.Point(542, 291);
            this.checkedListBoxAstronautes.Name = "checkedListBoxAstronautes";
            this.checkedListBoxAstronautes.Size = new System.Drawing.Size(327, 154);
            this.checkedListBoxAstronautes.TabIndex = 19;
            this.checkedListBoxAstronautes.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // textBoxNomActivite
            // 
            this.textBoxNomActivite.Location = new System.Drawing.Point(83, 84);
            this.textBoxNomActivite.Name = "textBoxNomActivite";
            this.textBoxNomActivite.Size = new System.Drawing.Size(256, 20);
            this.textBoxNomActivite.TabIndex = 20;
            // 
            // textBoxNomLieu
            // 
            this.textBoxNomLieu.Location = new System.Drawing.Point(114, 445);
            this.textBoxNomLieu.Name = "textBoxNomLieu";
            this.textBoxNomLieu.Size = new System.Drawing.Size(97, 20);
            this.textBoxNomLieu.TabIndex = 24;
            this.textBoxNomLieu.Visible = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(542, 87);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(327, 160);
            this.richTextBox1.TabIndex = 25;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // boutonEnregistrerActivite
            // 
            this.boutonEnregistrerActivite.Location = new System.Drawing.Point(758, 469);
            this.boutonEnregistrerActivite.Name = "boutonEnregistrerActivite";
            this.boutonEnregistrerActivite.Size = new System.Drawing.Size(111, 38);
            this.boutonEnregistrerActivite.TabIndex = 26;
            this.boutonEnregistrerActivite.Text = "Enregistrer la nouvelle Activité";
            this.boutonEnregistrerActivite.UseVisualStyleBackColor = true;
            this.boutonEnregistrerActivite.Click += new System.EventHandler(this.boutonEnregistrerActivite_Click);
            // 
            // treeViewTypeActivite
            // 
            this.treeViewTypeActivite.Location = new System.Drawing.Point(83, 129);
            this.treeViewTypeActivite.Name = "treeViewTypeActivite";
            this.treeViewTypeActivite.Size = new System.Drawing.Size(256, 141);
            this.treeViewTypeActivite.TabIndex = 28;
            this.treeViewTypeActivite.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewTypeActivite_AfterSelect);
            // 
            // comboBoxHeureDebut
            // 
            this.comboBoxHeureDebut.FormattingEnabled = true;
            this.comboBoxHeureDebut.Location = new System.Drawing.Point(159, 293);
            this.comboBoxHeureDebut.Name = "comboBoxHeureDebut";
            this.comboBoxHeureDebut.Size = new System.Drawing.Size(71, 21);
            this.comboBoxHeureDebut.TabIndex = 29;
            this.comboBoxHeureDebut.SelectedIndexChanged += new System.EventHandler(this.comboBoxHeureDebut_SelectedIndexChanged);
            // 
            // comboBoxMinuteDebut
            // 
            this.comboBoxMinuteDebut.FormattingEnabled = true;
            this.comboBoxMinuteDebut.Location = new System.Drawing.Point(257, 293);
            this.comboBoxMinuteDebut.Name = "comboBoxMinuteDebut";
            this.comboBoxMinuteDebut.Size = new System.Drawing.Size(72, 21);
            this.comboBoxMinuteDebut.TabIndex = 30;
            this.comboBoxMinuteDebut.SelectedIndexChanged += new System.EventHandler(this.comboBoxMinuteDebut_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "H";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // checkBoxNouveauLieu
            // 
            this.checkBoxNouveauLieu.AutoSize = true;
            this.checkBoxNouveauLieu.Location = new System.Drawing.Point(27, 411);
            this.checkBoxNouveauLieu.Name = "checkBoxNouveauLieu";
            this.checkBoxNouveauLieu.Size = new System.Drawing.Size(144, 17);
            this.checkBoxNouveauLieu.TabIndex = 33;
            this.checkBoxNouveauLieu.Text = "Ajouter un nouveau lieu :";
            this.checkBoxNouveauLieu.UseVisualStyleBackColor = true;
            this.checkBoxNouveauLieu.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // labelNomLieu
            // 
            this.labelNomLieu.AutoSize = true;
            this.labelNomLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomLieu.Location = new System.Drawing.Point(23, 445);
            this.labelNomLieu.Name = "labelNomLieu";
            this.labelNomLieu.Size = new System.Drawing.Size(85, 20);
            this.labelNomLieu.TabIndex = 34;
            this.labelNomLieu.Text = "Nom lieu :";
            this.labelNomLieu.Visible = false;
            // 
            // comboBoxListeLieu
            // 
            this.comboBoxListeLieu.FormattingEnabled = true;
            this.comboBoxListeLieu.Location = new System.Drawing.Point(94, 378);
            this.comboBoxListeLieu.Name = "comboBoxListeLieu";
            this.comboBoxListeLieu.Size = new System.Drawing.Size(198, 21);
            this.comboBoxListeLieu.TabIndex = 35;
            this.comboBoxListeLieu.SelectedIndexChanged += new System.EventHandler(this.comboBoxListeLieu_SelectedIndexChanged);
            // 
            // labelLieuCoordonneeX
            // 
            this.labelLieuCoordonneeX.AutoSize = true;
            this.labelLieuCoordonneeX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLieuCoordonneeX.Location = new System.Drawing.Point(23, 478);
            this.labelLieuCoordonneeX.Name = "labelLieuCoordonneeX";
            this.labelLieuCoordonneeX.Size = new System.Drawing.Size(134, 20);
            this.labelLieuCoordonneeX.TabIndex = 36;
            this.labelLieuCoordonneeX.Text = "Coordonnées X :";
            this.labelLieuCoordonneeX.Visible = false;
            // 
            // labelLieuCoordonneeY
            // 
            this.labelLieuCoordonneeY.AutoSize = true;
            this.labelLieuCoordonneeY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLieuCoordonneeY.Location = new System.Drawing.Point(23, 505);
            this.labelLieuCoordonneeY.Name = "labelLieuCoordonneeY";
            this.labelLieuCoordonneeY.Size = new System.Drawing.Size(133, 20);
            this.labelLieuCoordonneeY.TabIndex = 37;
            this.labelLieuCoordonneeY.Text = "Coordonnées Y :";
            this.labelLieuCoordonneeY.Visible = false;
            // 
            // textBoxCoordonnéesX
            // 
            this.textBoxCoordonnéesX.Location = new System.Drawing.Point(164, 480);
            this.textBoxCoordonnéesX.Name = "textBoxCoordonnéesX";
            this.textBoxCoordonnéesX.Size = new System.Drawing.Size(100, 20);
            this.textBoxCoordonnéesX.TabIndex = 38;
            this.textBoxCoordonnéesX.Visible = false;
            // 
            // textBoxCoordonnéesY
            // 
            this.textBoxCoordonnéesY.Location = new System.Drawing.Point(164, 507);
            this.textBoxCoordonnéesY.Name = "textBoxCoordonnéesY";
            this.textBoxCoordonnéesY.Size = new System.Drawing.Size(100, 20);
            this.textBoxCoordonnéesY.TabIndex = 39;
            this.textBoxCoordonnéesY.Visible = false;
            // 
            // labelDuree
            // 
            this.labelDuree.AutoSize = true;
            this.labelDuree.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDuree.Location = new System.Drawing.Point(23, 332);
            this.labelDuree.Name = "labelDuree";
            this.labelDuree.Size = new System.Drawing.Size(98, 20);
            this.labelDuree.TabIndex = 40;
            this.labelDuree.Text = "Horaire fin :";
            // 
            // comboBoxHeureFin
            // 
            this.comboBoxHeureFin.FormattingEnabled = true;
            this.comboBoxHeureFin.Location = new System.Drawing.Point(127, 332);
            this.comboBoxHeureFin.Name = "comboBoxHeureFin";
            this.comboBoxHeureFin.Size = new System.Drawing.Size(71, 21);
            this.comboBoxHeureFin.TabIndex = 41;
            this.comboBoxHeureFin.SelectedIndexChanged += new System.EventHandler(this.comboBoxHeureFin_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "H";
            // 
            // comboBoxMinuteFin
            // 
            this.comboBoxMinuteFin.FormattingEnabled = true;
            this.comboBoxMinuteFin.Location = new System.Drawing.Point(220, 331);
            this.comboBoxMinuteFin.Name = "comboBoxMinuteFin";
            this.comboBoxMinuteFin.Size = new System.Drawing.Size(72, 21);
            this.comboBoxMinuteFin.TabIndex = 42;
            // 
            // buttonAjouterParCarte
            // 
            this.buttonAjouterParCarte.Location = new System.Drawing.Point(275, 442);
            this.buttonAjouterParCarte.Name = "buttonAjouterParCarte";
            this.buttonAjouterParCarte.Size = new System.Drawing.Size(144, 23);
            this.buttonAjouterParCarte.TabIndex = 44;
            this.buttonAjouterParCarte.Text = "Ajouter par carte";
            this.buttonAjouterParCarte.UseVisualStyleBackColor = true;
            this.buttonAjouterParCarte.Visible = false;
            this.buttonAjouterParCarte.Click += new System.EventHandler(this.buttonAjouterParCarte_Click);
            // 
            // FormAjouterActivite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 536);
            this.Controls.Add(this.buttonAjouterParCarte);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxMinuteFin);
            this.Controls.Add(this.comboBoxHeureFin);
            this.Controls.Add(this.labelDuree);
            this.Controls.Add(this.textBoxCoordonnéesY);
            this.Controls.Add(this.textBoxCoordonnéesX);
            this.Controls.Add(this.labelLieuCoordonneeY);
            this.Controls.Add(this.labelLieuCoordonneeX);
            this.Controls.Add(this.comboBoxListeLieu);
            this.Controls.Add(this.labelNomLieu);
            this.Controls.Add(this.checkBoxNouveauLieu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxMinuteDebut);
            this.Controls.Add(this.comboBoxHeureDebut);
            this.Controls.Add(this.treeViewTypeActivite);
            this.Controls.Add(this.boutonEnregistrerActivite);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBoxNomLieu);
            this.Controls.Add(this.textBoxNomActivite);
            this.Controls.Add(this.checkedListBoxAstronautes);
            this.Controls.Add(this.labelNomActivite);
            this.Controls.Add(this.labelAstronautesActivite);
            this.Controls.Add(this.labelDescriptifActivite);
            this.Controls.Add(this.labelLieuActivite);
            this.Controls.Add(this.labelPlageHoraireActivité);
            this.Controls.Add(this.labelJourActivité);
            this.Controls.Add(this.labelTypeActivité);
            this.Controls.Add(this.labelTitre);
            this.Name = "FormAjouterActivite";
            this.Text = "FormAjouterActivite";
            this.Load += new System.EventHandler(this.FormAjouterActivite_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitre;
        private System.Windows.Forms.Label labelAstronautesActivite;
        private System.Windows.Forms.Label labelDescriptifActivite;
        private System.Windows.Forms.Label labelLieuActivite;
        private System.Windows.Forms.Label labelPlageHoraireActivité;
        private System.Windows.Forms.Label labelJourActivité;
        private System.Windows.Forms.Label labelTypeActivité;
        private System.Windows.Forms.Label labelNomActivite;
        private System.Windows.Forms.CheckedListBox checkedListBoxAstronautes;
        private System.Windows.Forms.TextBox textBoxNomActivite;
        private System.Windows.Forms.TextBox textBoxNomLieu;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button boutonEnregistrerActivite;
        private System.Windows.Forms.TreeView treeViewTypeActivite;
        private System.Windows.Forms.ComboBox comboBoxHeureDebut;
        private System.Windows.Forms.ComboBox comboBoxMinuteDebut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxNouveauLieu;
        private System.Windows.Forms.Label labelNomLieu;
        private System.Windows.Forms.ComboBox comboBoxListeLieu;
        private System.Windows.Forms.Label labelLieuCoordonneeX;
        private System.Windows.Forms.Label labelLieuCoordonneeY;
        private System.Windows.Forms.TextBox textBoxCoordonnéesX;
        private System.Windows.Forms.TextBox textBoxCoordonnéesY;
        private System.Windows.Forms.Label labelDuree;
        private System.Windows.Forms.ComboBox comboBoxHeureFin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxMinuteFin;
        private System.Windows.Forms.Button buttonAjouterParCarte;
    }
}