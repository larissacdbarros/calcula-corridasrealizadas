namespace Aula80_WF_
{
    partial class TelaMotorista
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMotorista = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotalViagensRelIndivi = new System.Windows.Forms.Label();
            this.lblValorTotalRelIndivi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Motorista:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(151, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Relatório Viagens";
            // 
            // txtMotorista
            // 
            this.txtMotorista.AutoSize = true;
            this.txtMotorista.Location = new System.Drawing.Point(127, 76);
            this.txtMotorista.Name = "txtMotorista";
            this.txtMotorista.Size = new System.Drawing.Size(51, 20);
            this.txtMotorista.TabIndex = 5;
            this.txtMotorista.Text = "Nome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Total de Viagens  Realizadas:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Total:";
            // 
            // lblTotalViagensRelIndivi
            // 
            this.lblTotalViagensRelIndivi.AutoSize = true;
            this.lblTotalViagensRelIndivi.Location = new System.Drawing.Point(267, 106);
            this.lblTotalViagensRelIndivi.Name = "lblTotalViagensRelIndivi";
            this.lblTotalViagensRelIndivi.Size = new System.Drawing.Size(102, 20);
            this.lblTotalViagensRelIndivi.TabIndex = 5;
            this.lblTotalViagensRelIndivi.Text = "total Viagens";
            // 
            // lblValorTotalRelIndivi
            // 
            this.lblValorTotalRelIndivi.AutoSize = true;
            this.lblValorTotalRelIndivi.Location = new System.Drawing.Point(114, 139);
            this.lblValorTotalRelIndivi.Name = "lblValorTotalRelIndivi";
            this.lblValorTotalRelIndivi.Size = new System.Drawing.Size(81, 20);
            this.lblValorTotalRelIndivi.TabIndex = 5;
            this.lblValorTotalRelIndivi.Text = "Total valor";
            // 
            // TelaMotorista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 241);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblValorTotalRelIndivi);
            this.Controls.Add(this.lblTotalViagensRelIndivi);
            this.Controls.Add(this.txtMotorista);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TelaMotorista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaMotorista";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label txtMotorista;
        public System.Windows.Forms.Label lblTotalViagensRelIndivi;
        public System.Windows.Forms.Label lblValorTotalRelIndivi;
    }
}