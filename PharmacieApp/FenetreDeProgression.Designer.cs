
namespace PharmacieApp
{
    partial class FenetreDeProgression
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.BarDeProgression = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.labelPourcentage = new System.Windows.Forms.Label();
            this.labelPharmacie = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.BarDeProgression.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarDeProgression
            // 
            this.BarDeProgression.BackColor = System.Drawing.Color.Crimson;
            this.BarDeProgression.Controls.Add(this.labelPourcentage);
            this.BarDeProgression.FillColor = System.Drawing.Color.White;
            this.BarDeProgression.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BarDeProgression.ForeColor = System.Drawing.Color.White;
            this.BarDeProgression.Location = new System.Drawing.Point(292, 149);
            this.BarDeProgression.Minimum = 0;
            this.BarDeProgression.Name = "BarDeProgression";
            this.BarDeProgression.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.BarDeProgression.Size = new System.Drawing.Size(192, 192);
            this.BarDeProgression.TabIndex = 0;
            // 
            // labelPourcentage
            // 
            this.labelPourcentage.AutoSize = true;
            this.labelPourcentage.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPourcentage.ForeColor = System.Drawing.Color.White;
            this.labelPourcentage.Location = new System.Drawing.Point(69, 75);
            this.labelPourcentage.Name = "labelPourcentage";
            this.labelPourcentage.Size = new System.Drawing.Size(59, 43);
            this.labelPourcentage.TabIndex = 3;
            this.labelPourcentage.Text = "%";
            // 
            // labelPharmacie
            // 
            this.labelPharmacie.AutoSize = true;
            this.labelPharmacie.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPharmacie.ForeColor = System.Drawing.Color.White;
            this.labelPharmacie.Location = new System.Drawing.Point(245, 54);
            this.labelPharmacie.Name = "labelPharmacie";
            this.labelPharmacie.Size = new System.Drawing.Size(314, 43);
            this.labelPharmacie.TabIndex = 1;
            this.labelPharmacie.Text = "Pharmacie CISSE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS PGothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(288, 393);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Developper par Aly";
            // 
            // Timer1
            // 
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick_1);
            // 
            // FenetreDeProgression
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPharmacie);
            this.Controls.Add(this.BarDeProgression);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FenetreDeProgression";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FenetreDeProgression_Load);
            this.BarDeProgression.ResumeLayout(false);
            this.BarDeProgression.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Guna.UI2.WinForms.Guna2CircleProgressBar BarDeProgression;
        private System.Windows.Forms.Label labelPharmacie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.Label labelPourcentage;
    }
}

