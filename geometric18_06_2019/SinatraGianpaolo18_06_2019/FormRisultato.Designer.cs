namespace SinatraGianpaolo18_06_2019
{
    partial class FormRisultato
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
            this.lblRisultato = new System.Windows.Forms.Label();
            this.btn3dMod = new System.Windows.Forms.Button();
            this.lblAltezzaV = new System.Windows.Forms.Label();
            this.txtAltezzaV = new System.Windows.Forms.TextBox();
            this.btnAltezzaV = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRisultato
            // 
            this.lblRisultato.AutoSize = true;
            this.lblRisultato.Location = new System.Drawing.Point(53, 22);
            this.lblRisultato.Name = "lblRisultato";
            this.lblRisultato.Size = new System.Drawing.Size(48, 13);
            this.lblRisultato.TabIndex = 0;
            this.lblRisultato.Text = "Risultato";
            // 
            // btn3dMod
            // 
            this.btn3dMod.Location = new System.Drawing.Point(56, 193);
            this.btn3dMod.Name = "btn3dMod";
            this.btn3dMod.Size = new System.Drawing.Size(75, 23);
            this.btn3dMod.TabIndex = 1;
            this.btn3dMod.Text = "Modalità 3D";
            this.btn3dMod.UseVisualStyleBackColor = true;
            this.btn3dMod.Click += new System.EventHandler(this.btn3dMod_Click);
            // 
            // lblAltezzaV
            // 
            this.lblAltezzaV.AutoSize = true;
            this.lblAltezzaV.Location = new System.Drawing.Point(95, 149);
            this.lblAltezzaV.Name = "lblAltezzaV";
            this.lblAltezzaV.Size = new System.Drawing.Size(136, 13);
            this.lblAltezzaV.TabIndex = 3;
            this.lblAltezzaV.Text = "Inserisci l\'Altezza del solido:";
            this.lblAltezzaV.Visible = false;
            // 
            // txtAltezzaV
            // 
            this.txtAltezzaV.Location = new System.Drawing.Point(56, 167);
            this.txtAltezzaV.Name = "txtAltezzaV";
            this.txtAltezzaV.Size = new System.Drawing.Size(100, 20);
            this.txtAltezzaV.TabIndex = 4;
            this.txtAltezzaV.Visible = false;
            // 
            // btnAltezzaV
            // 
            this.btnAltezzaV.Location = new System.Drawing.Point(162, 165);
            this.btnAltezzaV.Name = "btnAltezzaV";
            this.btnAltezzaV.Size = new System.Drawing.Size(98, 23);
            this.btnAltezzaV.TabIndex = 5;
            this.btnAltezzaV.Text = "Calcola Volume";
            this.btnAltezzaV.UseVisualStyleBackColor = true;
            this.btnAltezzaV.Visible = false;
            this.btnAltezzaV.Click += new System.EventHandler(this.btnVolume_Click);
            // 
            // FormRisultato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 284);
            this.Controls.Add(this.btnAltezzaV);
            this.Controls.Add(this.txtAltezzaV);
            this.Controls.Add(this.lblAltezzaV);
            this.Controls.Add(this.btn3dMod);
            this.Controls.Add(this.lblRisultato);
            this.Name = "FormRisultato";
            this.Text = "Risultato";
            this.Load += new System.EventHandler(this.FormRisultato_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRisultato;
        private System.Windows.Forms.Button btn3dMod;
        private System.Windows.Forms.Label lblAltezzaV;
        private System.Windows.Forms.TextBox txtAltezzaV;
        private System.Windows.Forms.Button btnAltezzaV;
    }
}