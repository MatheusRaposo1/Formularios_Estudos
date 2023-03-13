namespace Formulario
{
    partial class FormSegunda
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
            this.se = new System.Windows.Forms.Label();
            this.btnPrincipal = new System.Windows.Forms.Button();
            this.txtMensagem = new System.Windows.Forms.TextBox();
            this.btnRetorno = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // se
            // 
            this.se.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.se.Location = new System.Drawing.Point(12, 9);
            this.se.Name = "se";
            this.se.Size = new System.Drawing.Size(764, 88);
            this.se.TabIndex = 0;
            this.se.Text = "Segunda Form";
            this.se.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPrincipal
            // 
            this.btnPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrincipal.Location = new System.Drawing.Point(30, 359);
            this.btnPrincipal.Name = "btnPrincipal";
            this.btnPrincipal.Size = new System.Drawing.Size(234, 60);
            this.btnPrincipal.TabIndex = 1;
            this.btnPrincipal.Text = "Principal";
            this.btnPrincipal.UseVisualStyleBackColor = true;
            this.btnPrincipal.Click += new System.EventHandler(this.btnPrincipal_Click);
            // 
            // txtMensagem
            // 
            this.txtMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMensagem.Location = new System.Drawing.Point(30, 189);
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.Size = new System.Drawing.Size(746, 44);
            this.txtMensagem.TabIndex = 2;
            // 
            // btnRetorno
            // 
            this.btnRetorno.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetorno.Location = new System.Drawing.Point(310, 359);
            this.btnRetorno.Name = "btnRetorno";
            this.btnRetorno.Size = new System.Drawing.Size(234, 60);
            this.btnRetorno.TabIndex = 3;
            this.btnRetorno.Text = "Retorno";
            this.btnRetorno.UseVisualStyleBackColor = true;
            this.btnRetorno.Click += new System.EventHandler(this.btnRetorno_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(554, 359);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(234, 60);
            this.btnFechar.TabIndex = 4;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // FormSegunda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 467);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnRetorno);
            this.Controls.Add(this.txtMensagem);
            this.Controls.Add(this.btnPrincipal);
            this.Controls.Add(this.se);
            this.Name = "FormSegunda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSegunda";
            this.Load += new System.EventHandler(this.FormSegunda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label se;
        private System.Windows.Forms.Button btnPrincipal;
        private System.Windows.Forms.TextBox txtMensagem;
        private System.Windows.Forms.Button btnRetorno;
        private System.Windows.Forms.Button btnFechar;
    }
}