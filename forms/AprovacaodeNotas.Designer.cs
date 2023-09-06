namespace Projetousuarios.forms
{
    partial class AprovacaodeNotas
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
            this.checkVisto = new System.Windows.Forms.CheckBox();
            this.checkAprove = new System.Windows.Forms.CheckBox();
            this.txtvalorMin = new System.Windows.Forms.TextBox();
            this.txtvalorMax = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkVisto
            // 
            this.checkVisto.AutoSize = true;
            this.checkVisto.Location = new System.Drawing.Point(49, 76);
            this.checkVisto.Name = "checkVisto";
            this.checkVisto.Size = new System.Drawing.Size(59, 20);
            this.checkVisto.TabIndex = 0;
            this.checkVisto.Text = "Visto";
            this.checkVisto.UseVisualStyleBackColor = true;
            // 
            // checkAprove
            // 
            this.checkAprove.AutoSize = true;
            this.checkAprove.Location = new System.Drawing.Point(199, 76);
            this.checkAprove.Name = "checkAprove";
            this.checkAprove.Size = new System.Drawing.Size(96, 20);
            this.checkAprove.TabIndex = 1;
            this.checkAprove.Text = "Aprovação";
            this.checkAprove.UseVisualStyleBackColor = true;
            // 
            // txtvalorMin
            // 
            this.txtvalorMin.Location = new System.Drawing.Point(49, 135);
            this.txtvalorMin.Name = "txtvalorMin";
            this.txtvalorMin.Size = new System.Drawing.Size(100, 22);
            this.txtvalorMin.TabIndex = 2;
            // 
            // txtvalorMax
            // 
            this.txtvalorMax.Location = new System.Drawing.Point(49, 198);
            this.txtvalorMax.Name = "txtvalorMax";
            this.txtvalorMax.Size = new System.Drawing.Size(100, 22);
            this.txtvalorMax.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Valor Mínimo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Valor Máximo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Aprovação de Notas";
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(219, 198);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(100, 23);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // AprovacaodeNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 244);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtvalorMax);
            this.Controls.Add(this.txtvalorMin);
            this.Controls.Add(this.checkAprove);
            this.Controls.Add(this.checkVisto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AprovacaodeNotas";
            this.Text = "Aprovador de Notas de usuários";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkVisto;
        private System.Windows.Forms.CheckBox checkAprove;
        private System.Windows.Forms.TextBox txtvalorMin;
        private System.Windows.Forms.TextBox txtvalorMax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSair;
    }
}