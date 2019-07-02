namespace SinatraGianpaolo18_06_2019
{
    partial class FormGeometria
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label lblLato;
            System.Windows.Forms.Label lblBase;
            System.Windows.Forms.Label lblAltezza;
            this.lblTitle = new System.Windows.Forms.Label();
            this.rbtnCerchio = new System.Windows.Forms.RadioButton();
            this.lblRaggio = new System.Windows.Forms.Label();
            this.txtRaggio = new System.Windows.Forms.TextBox();
            this.txtLato = new System.Windows.Forms.TextBox();
            this.rbtnQuadrato = new System.Windows.Forms.RadioButton();
            this.rbtnRettangolo = new System.Windows.Forms.RadioButton();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.rbtnTriangolo = new System.Windows.Forms.RadioButton();
            this.txtAltezza = new System.Windows.Forms.TextBox();
            this.btnCalcola = new System.Windows.Forms.Button();
            this.rbtnEsagono = new System.Windows.Forms.RadioButton();
            this.rbtnPentagono = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            lblLato = new System.Windows.Forms.Label();
            lblBase = new System.Windows.Forms.Label();
            lblAltezza = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLato
            // 
            lblLato.AutoSize = true;
            lblLato.Location = new System.Drawing.Point(100, 165);
            lblLato.Name = "lblLato";
            lblLato.Size = new System.Drawing.Size(79, 13);
            lblLato.TabIndex = 5;
            lblLato.Text = "Inserisci il Lato:";
            // 
            // lblBase
            // 
            lblBase.AutoSize = true;
            lblBase.Location = new System.Drawing.Point(93, 261);
            lblBase.Name = "lblBase";
            lblBase.Size = new System.Drawing.Size(86, 13);
            lblBase.TabIndex = 9;
            lblBase.Text = "Inserisci la Base:";
            lblBase.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            lblBase.Click += new System.EventHandler(this.LblBase_Click);
            // 
            // lblAltezza
            // 
            lblAltezza.AutoSize = true;
            lblAltezza.Location = new System.Drawing.Point(90, 287);
            lblAltezza.Name = "lblAltezza";
            lblAltezza.Size = new System.Drawing.Size(89, 13);
            lblAltezza.TabIndex = 12;
            lblAltezza.Text = "Inserisci l\'Altezza:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(75, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(269, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Scegli la figura da calcolare e inserisci le caratteristiche:";
            // 
            // rbtnCerchio
            // 
            this.rbtnCerchio.AutoSize = true;
            this.rbtnCerchio.Location = new System.Drawing.Point(141, 38);
            this.rbtnCerchio.Name = "rbtnCerchio";
            this.rbtnCerchio.Size = new System.Drawing.Size(61, 17);
            this.rbtnCerchio.TabIndex = 1;
            this.rbtnCerchio.Text = "Cerchio";
            this.rbtnCerchio.UseVisualStyleBackColor = true;
            this.rbtnCerchio.CheckedChanged += new System.EventHandler(this.RbtnCerchio_CheckedChanged);
            // 
            // lblRaggio
            // 
            this.lblRaggio.AutoSize = true;
            this.lblRaggio.Location = new System.Drawing.Point(87, 64);
            this.lblRaggio.Name = "lblRaggio";
            this.lblRaggio.Size = new System.Drawing.Size(92, 13);
            this.lblRaggio.TabIndex = 2;
            this.lblRaggio.Text = "Inserisci il Raggio:";
            // 
            // txtRaggio
            // 
            this.txtRaggio.Enabled = false;
            this.txtRaggio.Location = new System.Drawing.Point(181, 61);
            this.txtRaggio.Name = "txtRaggio";
            this.txtRaggio.Size = new System.Drawing.Size(100, 20);
            this.txtRaggio.TabIndex = 3;
            this.txtRaggio.TextChanged += new System.EventHandler(this.txtRaggio_TextChanged);
            // 
            // txtLato
            // 
            this.txtLato.Enabled = false;
            this.txtLato.Location = new System.Drawing.Point(181, 162);
            this.txtLato.Name = "txtLato";
            this.txtLato.Size = new System.Drawing.Size(100, 20);
            this.txtLato.TabIndex = 6;
            // 
            // rbtnQuadrato
            // 
            this.rbtnQuadrato.AutoSize = true;
            this.rbtnQuadrato.Location = new System.Drawing.Point(111, 135);
            this.rbtnQuadrato.Name = "rbtnQuadrato";
            this.rbtnQuadrato.Size = new System.Drawing.Size(69, 17);
            this.rbtnQuadrato.TabIndex = 4;
            this.rbtnQuadrato.TabStop = true;
            this.rbtnQuadrato.Text = "Quadrato";
            this.rbtnQuadrato.UseVisualStyleBackColor = true;
            this.rbtnQuadrato.CheckedChanged += new System.EventHandler(this.RbtnQuadrato_CheckedChanged);
            // 
            // rbtnRettangolo
            // 
            this.rbtnRettangolo.AutoSize = true;
            this.rbtnRettangolo.Location = new System.Drawing.Point(111, 235);
            this.rbtnRettangolo.Name = "rbtnRettangolo";
            this.rbtnRettangolo.Size = new System.Drawing.Size(77, 17);
            this.rbtnRettangolo.TabIndex = 11;
            this.rbtnRettangolo.TabStop = true;
            this.rbtnRettangolo.Text = "Rettangolo";
            this.rbtnRettangolo.UseVisualStyleBackColor = true;
            this.rbtnRettangolo.CheckedChanged += new System.EventHandler(this.RbtnRettangolo_CheckedChanged);
            // 
            // txtBase
            // 
            this.txtBase.Enabled = false;
            this.txtBase.Location = new System.Drawing.Point(181, 258);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(100, 20);
            this.txtBase.TabIndex = 10;
            // 
            // rbtnTriangolo
            // 
            this.rbtnTriangolo.AutoSize = true;
            this.rbtnTriangolo.Location = new System.Drawing.Point(194, 235);
            this.rbtnTriangolo.Name = "rbtnTriangolo";
            this.rbtnTriangolo.Size = new System.Drawing.Size(111, 17);
            this.rbtnTriangolo.TabIndex = 8;
            this.rbtnTriangolo.TabStop = true;
            this.rbtnTriangolo.Text = "Triangolo Isoscele";
            this.rbtnTriangolo.UseVisualStyleBackColor = true;
            this.rbtnTriangolo.CheckedChanged += new System.EventHandler(this.RbtnTriangolo_CheckedChanged);
            // 
            // txtAltezza
            // 
            this.txtAltezza.Enabled = false;
            this.txtAltezza.Location = new System.Drawing.Point(181, 284);
            this.txtAltezza.Name = "txtAltezza";
            this.txtAltezza.Size = new System.Drawing.Size(100, 20);
            this.txtAltezza.TabIndex = 13;
            // 
            // btnCalcola
            // 
            this.btnCalcola.Location = new System.Drawing.Point(166, 338);
            this.btnCalcola.Name = "btnCalcola";
            this.btnCalcola.Size = new System.Drawing.Size(115, 23);
            this.btnCalcola.TabIndex = 14;
            this.btnCalcola.Text = "Calcola Tutto";
            this.btnCalcola.UseVisualStyleBackColor = true;
            this.btnCalcola.Click += new System.EventHandler(this.BtnCalcola_Click);
            // 
            // rbtnEsagono
            // 
            this.rbtnEsagono.AutoSize = true;
            this.rbtnEsagono.Location = new System.Drawing.Point(277, 135);
            this.rbtnEsagono.Name = "rbtnEsagono";
            this.rbtnEsagono.Size = new System.Drawing.Size(67, 17);
            this.rbtnEsagono.TabIndex = 15;
            this.rbtnEsagono.TabStop = true;
            this.rbtnEsagono.Text = "Esagono";
            this.rbtnEsagono.UseVisualStyleBackColor = true;
            this.rbtnEsagono.CheckedChanged += new System.EventHandler(this.RbtnEsagono_CheckedChanged);
            // 
            // rbtnPentagono
            // 
            this.rbtnPentagono.AutoSize = true;
            this.rbtnPentagono.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rbtnPentagono.Location = new System.Drawing.Point(194, 135);
            this.rbtnPentagono.Name = "rbtnPentagono";
            this.rbtnPentagono.Size = new System.Drawing.Size(77, 17);
            this.rbtnPentagono.TabIndex = 16;
            this.rbtnPentagono.TabStop = true;
            this.rbtnPentagono.Text = "Pentagono";
            this.rbtnPentagono.UseVisualStyleBackColor = true;
            this.rbtnPentagono.CheckedChanged += new System.EventHandler(this.RbtnPentagono_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbtnCerchio);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.rbtnPentagono);
            this.panel1.Controls.Add(this.lblRaggio);
            this.panel1.Controls.Add(this.rbtnEsagono);
            this.panel1.Controls.Add(this.txtRaggio);
            this.panel1.Controls.Add(this.btnCalcola);
            this.panel1.Controls.Add(this.rbtnQuadrato);
            this.panel1.Controls.Add(this.txtAltezza);
            this.panel1.Controls.Add(lblLato);
            this.panel1.Controls.Add(lblAltezza);
            this.panel1.Controls.Add(this.txtLato);
            this.panel1.Controls.Add(this.rbtnRettangolo);
            this.panel1.Controls.Add(this.rbtnTriangolo);
            this.panel1.Controls.Add(this.txtBase);
            this.panel1.Controls.Add(lblBase);
            this.panel1.Location = new System.Drawing.Point(3, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(434, 386);
            this.panel1.TabIndex = 17;
            // 
            // FormGeometria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 407);
            this.Controls.Add(this.panel1);
            this.Name = "FormGeometria";
            this.Text = "Forme Geometriche";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.RadioButton rbtnCerchio;
        private System.Windows.Forms.Label lblRaggio;
        private System.Windows.Forms.TextBox txtRaggio;
        private System.Windows.Forms.TextBox txtLato;
        private System.Windows.Forms.RadioButton rbtnQuadrato;
        private System.Windows.Forms.RadioButton rbtnRettangolo;
        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.RadioButton rbtnTriangolo;
        private System.Windows.Forms.TextBox txtAltezza;
        private System.Windows.Forms.Button btnCalcola;
        private System.Windows.Forms.RadioButton rbtnEsagono;
        private System.Windows.Forms.RadioButton rbtnPentagono;
        private System.Windows.Forms.Panel panel1;
    }
}

