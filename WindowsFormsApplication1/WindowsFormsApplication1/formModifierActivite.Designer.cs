namespace WindowsFormsApplication1
{
    partial class formModifierActivite
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
            this.textBoxCoordonnéesY = new System.Windows.Forms.TextBox();
            this.textBoxCoordonnéesX = new System.Windows.Forms.TextBox();
            this.labelLieuCoordonneeY = new System.Windows.Forms.Label();
            this.labelLieuCoordonneeX = new System.Windows.Forms.Label();
            this.comboBoxListeLieu = new System.Windows.Forms.ComboBox();
            this.labelNomLieu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxMinuteDebut = new System.Windows.Forms.ComboBox();
            this.comboBoxHeureDebut = new System.Windows.Forms.ComboBox();
            this.treeViewTypeActivite = new System.Windows.Forms.TreeView();
            this.boutonEnregistrerActivite = new System.Windows.Forms.Button();
            this.richTextBoxDescriptif = new System.Windows.Forms.RichTextBox();
            this.textBoxNomLieu = new System.Windows.Forms.TextBox();
            this.textBoxNomAct = new System.Windows.Forms.TextBox();
            this.checkedListBoxAstronautes = new System.Windows.Forms.CheckedListBox();
            this.labelNomActivite = new System.Windows.Forms.Label();
            this.labelAstronautesActivite = new System.Windows.Forms.Label();
            this.labelDescriptifActivite = new System.Windows.Forms.Label();
            this.labelLieuActivite = new System.Windows.Forms.Label();
            this.labelPlageHoraireActivité = new System.Windows.Forms.Label();
            this.labelJourActivité = new System.Windows.Forms.Label();
            this.labelTypeActivité = new System.Windows.Forms.Label();
            this.labelTitre = new System.Windows.Forms.Label();
            this.label2Jour = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxMinutesFin = new System.Windows.Forms.ComboBox();
            this.comboBoxHeureFin = new System.Windows.Forms.ComboBox();
            this.checkBoxLieu = new System.Windows.Forms.CheckBox();
            this.boutonAnnuler = new System.Windows.Forms.Button();
            this.buttonAjouterParCarte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxCoordonnéesY
            // 
            this.textBoxCoordonnéesY.Location = new System.Drawing.Point(182, 478);
            this.textBoxCoordonnéesY.Name = "textBoxCoordonnéesY";
            this.textBoxCoordonnéesY.Size = new System.Drawing.Size(100, 20);
            this.textBoxCoordonnéesY.TabIndex = 64;
            this.textBoxCoordonnéesY.Visible = false;
            // 
            // textBoxCoordonnéesX
            // 
            this.textBoxCoordonnéesX.Location = new System.Drawing.Point(182, 452);
            this.textBoxCoordonnéesX.Name = "textBoxCoordonnéesX";
            this.textBoxCoordonnéesX.Size = new System.Drawing.Size(100, 20);
            this.textBoxCoordonnéesX.TabIndex = 63;
            this.textBoxCoordonnéesX.Visible = false;
            // 
            // labelLieuCoordonneeY
            // 
            this.labelLieuCoordonneeY.AutoSize = true;
            this.labelLieuCoordonneeY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLieuCoordonneeY.Location = new System.Drawing.Point(42, 478);
            this.labelLieuCoordonneeY.Name = "labelLieuCoordonneeY";
            this.labelLieuCoordonneeY.Size = new System.Drawing.Size(133, 20);
            this.labelLieuCoordonneeY.TabIndex = 62;
            this.labelLieuCoordonneeY.Text = "Coordonnées Y :";
            this.labelLieuCoordonneeY.Visible = false;
            // 
            // labelLieuCoordonneeX
            // 
            this.labelLieuCoordonneeX.AutoSize = true;
            this.labelLieuCoordonneeX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLieuCoordonneeX.Location = new System.Drawing.Point(42, 450);
            this.labelLieuCoordonneeX.Name = "labelLieuCoordonneeX";
            this.labelLieuCoordonneeX.Size = new System.Drawing.Size(134, 20);
            this.labelLieuCoordonneeX.TabIndex = 61;
            this.labelLieuCoordonneeX.Text = "Coordonnées X :";
            this.labelLieuCoordonneeX.Visible = false;
            // 
            // comboBoxListeLieu
            // 
            this.comboBoxListeLieu.FormattingEnabled = true;
            this.comboBoxListeLieu.Location = new System.Drawing.Point(773, 385);
            this.comboBoxListeLieu.Name = "comboBoxListeLieu";
            this.comboBoxListeLieu.Size = new System.Drawing.Size(121, 21);
            this.comboBoxListeLieu.TabIndex = 60;
            this.comboBoxListeLieu.SelectedIndexChanged += new System.EventHandler(this.comboBoxListeLieu_SelectedIndexChanged);
            // 
            // labelNomLieu
            // 
            this.labelNomLieu.AutoSize = true;
            this.labelNomLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomLieu.Location = new System.Drawing.Point(42, 426);
            this.labelNomLieu.Name = "labelNomLieu";
            this.labelNomLieu.Size = new System.Drawing.Size(85, 20);
            this.labelNomLieu.TabIndex = 59;
            this.labelNomLieu.Text = "Nom lieu :";
            this.labelNomLieu.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 57;
            this.label1.Text = "H";
            // 
            // comboBoxMinuteDebut
            // 
            this.comboBoxMinuteDebut.FormattingEnabled = true;
            this.comboBoxMinuteDebut.Location = new System.Drawing.Point(209, 276);
            this.comboBoxMinuteDebut.Name = "comboBoxMinuteDebut";
            this.comboBoxMinuteDebut.Size = new System.Drawing.Size(72, 21);
            this.comboBoxMinuteDebut.TabIndex = 56;
            // 
            // comboBoxHeureDebut
            // 
            this.comboBoxHeureDebut.FormattingEnabled = true;
            this.comboBoxHeureDebut.Location = new System.Drawing.Point(98, 276);
            this.comboBoxHeureDebut.Name = "comboBoxHeureDebut";
            this.comboBoxHeureDebut.Size = new System.Drawing.Size(71, 21);
            this.comboBoxHeureDebut.TabIndex = 55;
            this.comboBoxHeureDebut.SelectedIndexChanged += new System.EventHandler(this.comboBoxHeureDebut_SelectedIndexChanged);
            // 
            // treeViewTypeActivite
            // 
            this.treeViewTypeActivite.Location = new System.Drawing.Point(101, 129);
            this.treeViewTypeActivite.Name = "treeViewTypeActivite";
            this.treeViewTypeActivite.Size = new System.Drawing.Size(140, 102);
            this.treeViewTypeActivite.TabIndex = 54;
            // 
            // boutonEnregistrerActivite
            // 
            this.boutonEnregistrerActivite.Location = new System.Drawing.Point(685, 442);
            this.boutonEnregistrerActivite.Name = "boutonEnregistrerActivite";
            this.boutonEnregistrerActivite.Size = new System.Drawing.Size(126, 38);
            this.boutonEnregistrerActivite.TabIndex = 53;
            this.boutonEnregistrerActivite.Text = "Enregistrer la modification";
            this.boutonEnregistrerActivite.UseVisualStyleBackColor = true;
            this.boutonEnregistrerActivite.Click += new System.EventHandler(this.boutonEnregistrerActivite_Click_1);
            // 
            // richTextBoxDescriptif
            // 
            this.richTextBoxDescriptif.Location = new System.Drawing.Point(716, 131);
            this.richTextBoxDescriptif.Name = "richTextBoxDescriptif";
            this.richTextBoxDescriptif.Size = new System.Drawing.Size(233, 81);
            this.richTextBoxDescriptif.TabIndex = 52;
            this.richTextBoxDescriptif.Text = "";
            this.richTextBoxDescriptif.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // textBoxNomLieu
            // 
            this.textBoxNomLieu.Location = new System.Drawing.Point(182, 426);
            this.textBoxNomLieu.Name = "textBoxNomLieu";
            this.textBoxNomLieu.Size = new System.Drawing.Size(100, 20);
            this.textBoxNomLieu.TabIndex = 51;
            this.textBoxNomLieu.Visible = false;
            // 
            // textBoxNomAct
            // 
            this.textBoxNomAct.Location = new System.Drawing.Point(101, 80);
            this.textBoxNomAct.Name = "textBoxNomAct";
            this.textBoxNomAct.Size = new System.Drawing.Size(100, 20);
            this.textBoxNomAct.TabIndex = 49;
            this.textBoxNomAct.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // checkedListBoxAstronautes
            // 
            this.checkedListBoxAstronautes.FormattingEnabled = true;
            this.checkedListBoxAstronautes.Location = new System.Drawing.Point(716, 238);
            this.checkedListBoxAstronautes.Name = "checkedListBoxAstronautes";
            this.checkedListBoxAstronautes.Size = new System.Drawing.Size(233, 124);
            this.checkedListBoxAstronautes.TabIndex = 48;
            this.checkedListBoxAstronautes.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxAstronautes_SelectedIndexChanged);
            // 
            // labelNomActivite
            // 
            this.labelNomActivite.AutoSize = true;
            this.labelNomActivite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomActivite.Location = new System.Drawing.Point(23, 80);
            this.labelNomActivite.Name = "labelNomActivite";
            this.labelNomActivite.Size = new System.Drawing.Size(54, 20);
            this.labelNomActivite.TabIndex = 47;
            this.labelNomActivite.Text = "Nom :";
            // 
            // labelAstronautesActivite
            // 
            this.labelAstronautesActivite.AutoSize = true;
            this.labelAstronautesActivite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAstronautesActivite.Location = new System.Drawing.Point(509, 238);
            this.labelAstronautesActivite.Name = "labelAstronautesActivite";
            this.labelAstronautesActivite.Size = new System.Drawing.Size(181, 20);
            this.labelAstronautesActivite.TabIndex = 46;
            this.labelAstronautesActivite.Text = "Liste des astronautes :";
            // 
            // labelDescriptifActivite
            // 
            this.labelDescriptifActivite.AutoSize = true;
            this.labelDescriptifActivite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescriptifActivite.Location = new System.Drawing.Point(509, 131);
            this.labelDescriptifActivite.Name = "labelDescriptifActivite";
            this.labelDescriptifActivite.Size = new System.Drawing.Size(181, 20);
            this.labelDescriptifActivite.TabIndex = 45;
            this.labelDescriptifActivite.Text = "Descriptif de l\'activité :";
            // 
            // labelLieuActivite
            // 
            this.labelLieuActivite.AutoSize = true;
            this.labelLieuActivite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLieuActivite.Location = new System.Drawing.Point(639, 386);
            this.labelLieuActivite.Name = "labelLieuActivite";
            this.labelLieuActivite.Size = new System.Drawing.Size(51, 20);
            this.labelLieuActivite.TabIndex = 44;
            this.labelLieuActivite.Text = "Lieu :";
            this.labelLieuActivite.Click += new System.EventHandler(this.labelLieuActivite_Click);
            // 
            // labelPlageHoraireActivité
            // 
            this.labelPlageHoraireActivité.AutoSize = true;
            this.labelPlageHoraireActivité.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlageHoraireActivité.Location = new System.Drawing.Point(14, 274);
            this.labelPlageHoraireActivité.Name = "labelPlageHoraireActivité";
            this.labelPlageHoraireActivité.Size = new System.Drawing.Size(64, 20);
            this.labelPlageHoraireActivité.TabIndex = 43;
            this.labelPlageHoraireActivité.Text = "Début :";
            this.labelPlageHoraireActivité.Click += new System.EventHandler(this.labelPlageHoraireActivité_Click);
            // 
            // labelJourActivité
            // 
            this.labelJourActivité.AutoSize = true;
            this.labelJourActivité.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJourActivité.Location = new System.Drawing.Point(26, 32);
            this.labelJourActivité.Name = "labelJourActivité";
            this.labelJourActivité.Size = new System.Drawing.Size(52, 20);
            this.labelJourActivité.TabIndex = 42;
            this.labelJourActivité.Text = "Jour :";
            // 
            // labelTypeActivité
            // 
            this.labelTypeActivité.AutoSize = true;
            this.labelTypeActivité.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTypeActivité.Location = new System.Drawing.Point(23, 129);
            this.labelTypeActivité.Name = "labelTypeActivité";
            this.labelTypeActivité.Size = new System.Drawing.Size(55, 20);
            this.labelTypeActivité.TabIndex = 41;
            this.labelTypeActivité.Text = "Type :";
            // 
            // labelTitre
            // 
            this.labelTitre.AutoSize = true;
            this.labelTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitre.Location = new System.Drawing.Point(323, 21);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(324, 31);
            this.labelTitre.TabIndex = 40;
            this.labelTitre.Text = "Modification d\'une activité";
            // 
            // label2Jour
            // 
            this.label2Jour.AutoSize = true;
            this.label2Jour.Location = new System.Drawing.Point(144, 39);
            this.label2Jour.Name = "label2Jour";
            this.label2Jour.Size = new System.Drawing.Size(35, 13);
            this.label2Jour.TabIndex = 65;
            this.label2Jour.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 66;
            this.label3.Text = "Fin :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(179, 344);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 69;
            this.label4.Text = "H";
            // 
            // comboBoxMinutesFin
            // 
            this.comboBoxMinutesFin.FormattingEnabled = true;
            this.comboBoxMinutesFin.Location = new System.Drawing.Point(209, 341);
            this.comboBoxMinutesFin.Name = "comboBoxMinutesFin";
            this.comboBoxMinutesFin.Size = new System.Drawing.Size(72, 21);
            this.comboBoxMinutesFin.TabIndex = 68;
            // 
            // comboBoxHeureFin
            // 
            this.comboBoxHeureFin.FormattingEnabled = true;
            this.comboBoxHeureFin.Location = new System.Drawing.Point(98, 341);
            this.comboBoxHeureFin.Name = "comboBoxHeureFin";
            this.comboBoxHeureFin.Size = new System.Drawing.Size(71, 21);
            this.comboBoxHeureFin.TabIndex = 67;
            // 
            // checkBoxLieu
            // 
            this.checkBoxLieu.AutoSize = true;
            this.checkBoxLieu.Location = new System.Drawing.Point(46, 385);
            this.checkBoxLieu.Name = "checkBoxLieu";
            this.checkBoxLieu.Size = new System.Drawing.Size(97, 17);
            this.checkBoxLieu.TabIndex = 70;
            this.checkBoxLieu.Text = "Ajouter un Lieu";
            this.checkBoxLieu.UseVisualStyleBackColor = true;
            this.checkBoxLieu.CheckedChanged += new System.EventHandler(this.checkBoxLieu_CheckedChanged);
            // 
            // boutonAnnuler
            // 
            this.boutonAnnuler.Location = new System.Drawing.Point(870, 443);
            this.boutonAnnuler.Name = "boutonAnnuler";
            this.boutonAnnuler.Size = new System.Drawing.Size(123, 36);
            this.boutonAnnuler.TabIndex = 71;
            this.boutonAnnuler.Text = "Annuler";
            this.boutonAnnuler.UseVisualStyleBackColor = true;
            this.boutonAnnuler.Click += new System.EventHandler(this.boutonAnnuler_Click);
            // 
            // buttonAjouterParCarte
            // 
            this.buttonAjouterParCarte.Location = new System.Drawing.Point(182, 379);
            this.buttonAjouterParCarte.Name = "buttonAjouterParCarte";
            this.buttonAjouterParCarte.Size = new System.Drawing.Size(144, 23);
            this.buttonAjouterParCarte.TabIndex = 72;
            this.buttonAjouterParCarte.Text = "Ajouter par carte";
            this.buttonAjouterParCarte.UseVisualStyleBackColor = true;
            this.buttonAjouterParCarte.Visible = false;
            this.buttonAjouterParCarte.Click += new System.EventHandler(this.buttonAjouterParCarte_Click);
            // 
            // formModifierActivite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 513);
            this.Controls.Add(this.buttonAjouterParCarte);
            this.Controls.Add(this.boutonAnnuler);
            this.Controls.Add(this.checkBoxLieu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxMinutesFin);
            this.Controls.Add(this.comboBoxHeureFin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2Jour);
            this.Controls.Add(this.textBoxCoordonnéesY);
            this.Controls.Add(this.textBoxCoordonnéesX);
            this.Controls.Add(this.labelLieuCoordonneeY);
            this.Controls.Add(this.labelLieuCoordonneeX);
            this.Controls.Add(this.comboBoxListeLieu);
            this.Controls.Add(this.labelNomLieu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxMinuteDebut);
            this.Controls.Add(this.comboBoxHeureDebut);
            this.Controls.Add(this.treeViewTypeActivite);
            this.Controls.Add(this.boutonEnregistrerActivite);
            this.Controls.Add(this.richTextBoxDescriptif);
            this.Controls.Add(this.textBoxNomLieu);
            this.Controls.Add(this.textBoxNomAct);
            this.Controls.Add(this.checkedListBoxAstronautes);
            this.Controls.Add(this.labelNomActivite);
            this.Controls.Add(this.labelAstronautesActivite);
            this.Controls.Add(this.labelDescriptifActivite);
            this.Controls.Add(this.labelLieuActivite);
            this.Controls.Add(this.labelPlageHoraireActivité);
            this.Controls.Add(this.labelJourActivité);
            this.Controls.Add(this.labelTypeActivité);
            this.Controls.Add(this.labelTitre);
            this.Name = "formModifierActivite";
            this.Text = "formModifierActivite";
            this.Load += new System.EventHandler(this.formModifierActivite_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCoordonnéesY;
        private System.Windows.Forms.TextBox textBoxCoordonnéesX;
        private System.Windows.Forms.Label labelLieuCoordonneeY;
        private System.Windows.Forms.Label labelLieuCoordonneeX;
        private System.Windows.Forms.ComboBox comboBoxListeLieu;
        private System.Windows.Forms.Label labelNomLieu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxMinuteDebut;
        private System.Windows.Forms.ComboBox comboBoxHeureDebut;
        private System.Windows.Forms.TreeView treeViewTypeActivite;
        private System.Windows.Forms.Button boutonEnregistrerActivite;
        private System.Windows.Forms.RichTextBox richTextBoxDescriptif;
        private System.Windows.Forms.TextBox textBoxNomLieu;
        private System.Windows.Forms.TextBox textBoxNomAct;
        private System.Windows.Forms.CheckedListBox checkedListBoxAstronautes;
        private System.Windows.Forms.Label labelNomActivite;
        private System.Windows.Forms.Label labelAstronautesActivite;
        private System.Windows.Forms.Label labelDescriptifActivite;
        private System.Windows.Forms.Label labelLieuActivite;
        private System.Windows.Forms.Label labelPlageHoraireActivité;
        private System.Windows.Forms.Label labelJourActivité;
        private System.Windows.Forms.Label labelTypeActivité;
        private System.Windows.Forms.Label labelTitre;
        private System.Windows.Forms.Label label2Jour;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxMinutesFin;
        private System.Windows.Forms.ComboBox comboBoxHeureFin;
        private System.Windows.Forms.CheckBox checkBoxLieu;
        private System.Windows.Forms.Button boutonAnnuler;
        private System.Windows.Forms.Button buttonAjouterParCarte;
    }
}