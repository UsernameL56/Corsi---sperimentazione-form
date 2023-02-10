namespace Corsi___sperimentazione
{
    partial class Form1
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.PulsanteAggiunta = new System.Windows.Forms.Button();
            this.PulsanteStampa = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.PulsanteCancellazione = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(704, 40);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(496, 572);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // PulsanteAggiunta
            // 
            this.PulsanteAggiunta.Location = new System.Drawing.Point(56, 437);
            this.PulsanteAggiunta.Name = "PulsanteAggiunta";
            this.PulsanteAggiunta.Size = new System.Drawing.Size(115, 38);
            this.PulsanteAggiunta.TabIndex = 1;
            this.PulsanteAggiunta.Text = "Aggiungi";
            this.PulsanteAggiunta.UseVisualStyleBackColor = true;
            this.PulsanteAggiunta.Click += new System.EventHandler(this.PulsanteAggiunta_Click);
            // 
            // PulsanteStampa
            // 
            this.PulsanteStampa.Location = new System.Drawing.Point(186, 437);
            this.PulsanteStampa.Name = "PulsanteStampa";
            this.PulsanteStampa.Size = new System.Drawing.Size(115, 38);
            this.PulsanteStampa.TabIndex = 2;
            this.PulsanteStampa.Text = "Stampa";
            this.PulsanteStampa.UseVisualStyleBackColor = true;
            this.PulsanteStampa.Click += new System.EventHandler(this.PulsanteStampa_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(56, 83);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(536, 62);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // PulsanteCancellazione
            // 
            this.PulsanteCancellazione.Location = new System.Drawing.Point(317, 437);
            this.PulsanteCancellazione.Name = "PulsanteCancellazione";
            this.PulsanteCancellazione.Size = new System.Drawing.Size(115, 38);
            this.PulsanteCancellazione.TabIndex = 6;
            this.PulsanteCancellazione.Text = "Cancella";
            this.PulsanteCancellazione.UseVisualStyleBackColor = true;
            this.PulsanteCancellazione.Click += new System.EventHandler(this.PulsanteCancellazione_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 637);
            this.Controls.Add(this.PulsanteCancellazione);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.PulsanteStampa);
            this.Controls.Add(this.PulsanteAggiunta);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button PulsanteAggiunta;
        private System.Windows.Forms.Button PulsanteStampa;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button PulsanteCancellazione;
    }
}

