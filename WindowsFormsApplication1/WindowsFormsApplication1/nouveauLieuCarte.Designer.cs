namespace WindowsFormsApplication1
{
    partial class nouveauLieuCarte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nouveauLieuCarte));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxCoordonneeX = new System.Windows.Forms.TextBox();
            this.textBoxCoordonneeY = new System.Windows.Forms.TextBox();
            this.labelCoordonneeX = new System.Windows.Forms.Label();
            this.labelCoordonneeY = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxNomLieu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonEnregistrer = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(781, 520);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // textBoxCoordonneeX
            // 
            this.textBoxCoordonneeX.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCoordonneeX.Location = new System.Drawing.Point(933, 55);
            this.textBoxCoordonneeX.Name = "textBoxCoordonneeX";
            this.textBoxCoordonneeX.Size = new System.Drawing.Size(100, 24);
            this.textBoxCoordonneeX.TabIndex = 1;
            // 
            // textBoxCoordonneeY
            // 
            this.textBoxCoordonneeY.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCoordonneeY.Location = new System.Drawing.Point(933, 92);
            this.textBoxCoordonneeY.Name = "textBoxCoordonneeY";
            this.textBoxCoordonneeY.Size = new System.Drawing.Size(100, 24);
            this.textBoxCoordonneeY.TabIndex = 2;
            // 
            // labelCoordonneeX
            // 
            this.labelCoordonneeX.AutoSize = true;
            this.labelCoordonneeX.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCoordonneeX.Location = new System.Drawing.Point(806, 55);
            this.labelCoordonneeX.Name = "labelCoordonneeX";
            this.labelCoordonneeX.Size = new System.Drawing.Size(121, 18);
            this.labelCoordonneeX.TabIndex = 3;
            this.labelCoordonneeX.Text = "Coordonnées X :";
            // 
            // labelCoordonneeY
            // 
            this.labelCoordonneeY.AutoSize = true;
            this.labelCoordonneeY.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCoordonneeY.Location = new System.Drawing.Point(806, 93);
            this.labelCoordonneeY.Name = "labelCoordonneeY";
            this.labelCoordonneeY.Size = new System.Drawing.Size(120, 18);
            this.labelCoordonneeY.TabIndex = 4;
            this.labelCoordonneeY.Text = "Coordonnées Y :";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(787, 526);
            this.panel1.TabIndex = 5;
            // 
            // textBoxNomLieu
            // 
            this.textBoxNomLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNomLieu.Location = new System.Drawing.Point(933, 9);
            this.textBoxNomLieu.Name = "textBoxNomLieu";
            this.textBoxNomLieu.Size = new System.Drawing.Size(100, 24);
            this.textBoxNomLieu.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(806, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nom du lieu :";
            // 
            // buttonEnregistrer
            // 
            this.buttonEnregistrer.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonEnregistrer.Location = new System.Drawing.Point(978, 164);
            this.buttonEnregistrer.Name = "buttonEnregistrer";
            this.buttonEnregistrer.Size = new System.Drawing.Size(75, 23);
            this.buttonEnregistrer.TabIndex = 8;
            this.buttonEnregistrer.Text = "Enregistrer";
            this.buttonEnregistrer.UseVisualStyleBackColor = true;
            this.buttonEnregistrer.Click += new System.EventHandler(this.buttonEnregistrer_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.button2.Location = new System.Drawing.Point(834, 164);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Annuler";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // nouveauLieuCarte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 550);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonEnregistrer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNomLieu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelCoordonneeY);
            this.Controls.Add(this.labelCoordonneeX);
            this.Controls.Add(this.textBoxCoordonneeY);
            this.Controls.Add(this.textBoxCoordonneeX);
            this.Name = "nouveauLieuCarte";
            this.Text = "nouveauLieuCarte";
            this.Load += new System.EventHandler(this.nouveauLieuCarte_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.nouveauLieuCarte_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxCoordonneeX;
        private System.Windows.Forms.TextBox textBoxCoordonneeY;
        private System.Windows.Forms.Label labelCoordonneeX;
        private System.Windows.Forms.Label labelCoordonneeY;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxNomLieu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonEnregistrer;
        private System.Windows.Forms.Button button2;
    }
}