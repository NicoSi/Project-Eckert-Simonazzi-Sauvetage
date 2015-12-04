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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxMinuteDebut = new System.Windows.Forms.ComboBox();
            this.comboBoxHeureDebut = new System.Windows.Forms.ComboBox();
            this.treeViewTypeActivite = new System.Windows.Forms.TreeView();
            this.boutonEnregistrerActivite = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBoxNomLieu = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkedListBoxAstronautes = new System.Windows.Forms.CheckedListBox();
            this.labelNomActivite = new System.Windows.Forms.Label();
            this.labelAstronautesActivite = new System.Windows.Forms.Label();
            this.labelDescriptifActivite = new System.Windows.Forms.Label();
            this.labelLieuActivite = new System.Windows.Forms.Label();
            this.labelPlageHoraireActivité = new System.Windows.Forms.Label();
            this.labelJourActivité = new System.Windows.Forms.Label();
            this.labelTypeActivité = new System.Windows.Forms.Label();
            this.labelTitre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxCoordonnéesY
            // 
            this.textBoxCoordonnéesY.Location = new System.Drawing.Point(182, 487);
            this.textBoxCoordonnéesY.Name = "textBoxCoordonnéesY";
            this.textBoxCoordonnéesY.Size = new System.Drawing.Size(100, 20);
            this.textBoxCoordonnéesY.TabIndex = 64;
            this.textBoxCoordonnéesY.Visible = false;
            // 
            // textBoxCoordonnéesX
            // 
            this.textBoxCoordonnéesX.Location = new System.Drawing.Point(182, 460);
            this.textBoxCoordonnéesX.Name = "textBoxCoordonnéesX";
            this.textBoxCoordonnéesX.Size = new System.Drawing.Size(100, 20);
            this.textBoxCoordonnéesX.TabIndex = 63;
            this.textBoxCoordonnéesX.Visible = false;
            // 
            // labelLieuCoordonneeY
            // 
            this.labelLieuCoordonneeY.AutoSize = true;
            this.labelLieuCoordonneeY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLieuCoordonneeY.Location = new System.Drawing.Point(24, 487);
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
            this.labelLieuCoordonneeX.Location = new System.Drawing.Point(23, 460);
            this.labelLieuCoordonneeX.Name = "labelLieuCoordonneeX";
            this.labelLieuCoordonneeX.Size = new System.Drawing.Size(134, 20);
            this.labelLieuCoordonneeX.TabIndex = 61;
            this.labelLieuCoordonneeX.Text = "Coordonnées X :";
            this.labelLieuCoordonneeX.Visible = false;
            // 
            // comboBoxListeLieu
            // 
            this.comboBoxListeLieu.FormattingEnabled = true;
            this.comboBoxListeLieu.Location = new System.Drawing.Point(101, 351);
            this.comboBoxListeLieu.Name = "comboBoxListeLieu";
            this.comboBoxListeLieu.Size = new System.Drawing.Size(121, 21);
            this.comboBoxListeLieu.TabIndex = 60;
            this.comboBoxListeLieu.SelectedIndexChanged += new System.EventHandler(this.comboBoxListeLieu_SelectedIndexChanged);
            // 
            // labelNomLieu
            // 
            this.labelNomLieu.AutoSize = true;
            this.labelNomLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomLieu.Location = new System.Drawing.Point(27, 425);
            this.labelNomLieu.Name = "labelNomLieu";
            this.labelNomLieu.Size = new System.Drawing.Size(85, 20);
            this.labelNomLieu.TabIndex = 59;
            this.labelNomLieu.Text = "Nom lieu :";
            this.labelNomLieu.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(31, 390);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(144, 17);
            this.checkBox1.TabIndex = 58;
            this.checkBox1.Text = "Ajouter un nouveau lieu :";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 57;
            this.label1.Text = "H";
            // 
            // comboBoxMinuteDebut
            // 
            this.comboBoxMinuteDebut.FormattingEnabled = true;
            this.comboBoxMinuteDebut.Location = new System.Drawing.Point(237, 313);
            this.comboBoxMinuteDebut.Name = "comboBoxMinuteDebut";
            this.comboBoxMinuteDebut.Size = new System.Drawing.Size(72, 21);
            this.comboBoxMinuteDebut.TabIndex = 56;
            // 
            // comboBoxHeureDebut
            // 
            this.comboBoxHeureDebut.FormattingEnabled = true;
            this.comboBoxHeureDebut.Location = new System.Drawing.Point(113, 313);
            this.comboBoxHeureDebut.Name = "comboBoxHeureDebut";
            this.comboBoxHeureDebut.Size = new System.Drawing.Size(71, 21);
            this.comboBoxHeureDebut.TabIndex = 55;
            this.comboBoxHeureDebut.SelectedIndexChanged += new System.EventHandler(this.comboBoxHeureDebut_SelectedIndexChanged);
            // 
            // treeViewTypeActivite
            // 
            this.treeViewTypeActivite.Location = new System.Drawing.Point(101, 129);
            this.treeViewTypeActivite.Name = "treeViewTypeActivite";
            this.treeViewTypeActivite.Size = new System.Drawing.Size(181, 130);
            this.treeViewTypeActivite.TabIndex = 54;
            // 
            // boutonEnregistrerActivite
            // 
            this.boutonEnregistrerActivite.Location = new System.Drawing.Point(726, 425);
            this.boutonEnregistrerActivite.Name = "boutonEnregistrerActivite";
            this.boutonEnregistrerActivite.Size = new System.Drawing.Size(150, 55);
            this.boutonEnregistrerActivite.TabIndex = 53;
            this.boutonEnregistrerActivite.Text = "Enregistrer la modification";
            this.boutonEnregistrerActivite.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(632, 116);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(327, 81);
            this.richTextBox1.TabIndex = 52;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // textBoxNomLieu
            // 
            this.textBoxNomLieu.Location = new System.Drawing.Point(125, 425);
            this.textBoxNomLieu.Name = "textBoxNomLieu";
            this.textBoxNomLieu.Size = new System.Drawing.Size(97, 20);
            this.textBoxNomLieu.TabIndex = 51;
            this.textBoxNomLieu.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(101, 276);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 50;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(101, 82);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 49;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // checkedListBoxAstronautes
            // 
            this.checkedListBoxAstronautes.FormattingEnabled = true;
            this.checkedListBoxAstronautes.Location = new System.Drawing.Point(632, 237);
            this.checkedListBoxAstronautes.Name = "checkedListBoxAstronautes";
            this.checkedListBoxAstronautes.Size = new System.Drawing.Size(327, 154);
            this.checkedListBoxAstronautes.TabIndex = 48;
            this.checkedListBoxAstronautes.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxAstronautes_SelectedIndexChanged);
            // 
            // labelNomActivite
            // 
            this.labelNomActivite.AutoSize = true;
            this.labelNomActivite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomActivite.Location = new System.Drawing.Point(24, 82);
            this.labelNomActivite.Name = "labelNomActivite";
            this.labelNomActivite.Size = new System.Drawing.Size(54, 20);
            this.labelNomActivite.TabIndex = 47;
            this.labelNomActivite.Text = "Nom :";
            // 
            // labelAstronautesActivite
            // 
            this.labelAstronautesActivite.AutoSize = true;
            this.labelAstronautesActivite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAstronautesActivite.Location = new System.Drawing.Point(410, 237);
            this.labelAstronautesActivite.Name = "labelAstronautesActivite";
            this.labelAstronautesActivite.Size = new System.Drawing.Size(181, 20);
            this.labelAstronautesActivite.TabIndex = 46;
            this.labelAstronautesActivite.Text = "Liste des astronautes :";
            // 
            // labelDescriptifActivite
            // 
            this.labelDescriptifActivite.AutoSize = true;
            this.labelDescriptifActivite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescriptifActivite.Location = new System.Drawing.Point(410, 116);
            this.labelDescriptifActivite.Name = "labelDescriptifActivite";
            this.labelDescriptifActivite.Size = new System.Drawing.Size(181, 20);
            this.labelDescriptifActivite.TabIndex = 45;
            this.labelDescriptifActivite.Text = "Descriptif de l\'activité :";
            // 
            // labelLieuActivite
            // 
            this.labelLieuActivite.AutoSize = true;
            this.labelLieuActivite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLieuActivite.Location = new System.Drawing.Point(27, 349);
            this.labelLieuActivite.Name = "labelLieuActivite";
            this.labelLieuActivite.Size = new System.Drawing.Size(51, 20);
            this.labelLieuActivite.TabIndex = 44;
            this.labelLieuActivite.Text = "Lieu :";
            // 
            // labelPlageHoraireActivité
            // 
            this.labelPlageHoraireActivité.AutoSize = true;
            this.labelPlageHoraireActivité.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlageHoraireActivité.Location = new System.Drawing.Point(23, 314);
            this.labelPlageHoraireActivité.Name = "labelPlageHoraireActivité";
            this.labelPlageHoraireActivité.Size = new System.Drawing.Size(84, 20);
            this.labelPlageHoraireActivité.TabIndex = 43;
            this.labelPlageHoraireActivité.Text = "Horaires :";
            // 
            // labelJourActivité
            // 
            this.labelJourActivité.AutoSize = true;
            this.labelJourActivité.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJourActivité.Location = new System.Drawing.Point(24, 274);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 65;
            this.label2.Text = "label2";
            // 
            // formModifierActivite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 513);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCoordonnéesY);
            this.Controls.Add(this.textBoxCoordonnéesX);
            this.Controls.Add(this.labelLieuCoordonneeY);
            this.Controls.Add(this.labelLieuCoordonneeX);
            this.Controls.Add(this.comboBoxListeLieu);
            this.Controls.Add(this.labelNomLieu);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxMinuteDebut);
            this.Controls.Add(this.comboBoxHeureDebut);
            this.Controls.Add(this.treeViewTypeActivite);
            this.Controls.Add(this.boutonEnregistrerActivite);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBoxNomLieu);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxMinuteDebut;
        private System.Windows.Forms.ComboBox comboBoxHeureDebut;
        private System.Windows.Forms.TreeView treeViewTypeActivite;
        private System.Windows.Forms.Button boutonEnregistrerActivite;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBoxNomLieu;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckedListBox checkedListBoxAstronautes;
        private System.Windows.Forms.Label labelNomActivite;
        private System.Windows.Forms.Label labelAstronautesActivite;
        private System.Windows.Forms.Label labelDescriptifActivite;
        private System.Windows.Forms.Label labelLieuActivite;
        private System.Windows.Forms.Label labelPlageHoraireActivité;
        private System.Windows.Forms.Label labelJourActivité;
        private System.Windows.Forms.Label labelTypeActivité;
        private System.Windows.Forms.Label labelTitre;
        private System.Windows.Forms.Label label2;
    }
}