namespace Semáforo
{
    partial class Form1
    {

       
        private System.ComponentModel.IContainer components = null;

       
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        private void InitializeComponent()
        {
            this.btn_Rua1Verd = new System.Windows.Forms.Button();
            this.btn_Rua1Verm = new System.Windows.Forms.Button();
            this.btn_Rua1Amar = new System.Windows.Forms.Button();
            this.btn_Rua2Amar = new System.Windows.Forms.Button();
            this.btn_Rua2Verm = new System.Windows.Forms.Button();
            this.btn_Rua2Verd = new System.Windows.Forms.Button();
            this.pic_rua2 = new System.Windows.Forms.PictureBox();
            this.pic_rua1 = new System.Windows.Forms.PictureBox();
            this.Lbl_Rua1 = new System.Windows.Forms.Label();
            this.Lbl_rua2 = new System.Windows.Forms.Label();
            this.txb_Dado_2 = new System.Windows.Forms.TextBox();
            this.txb_Dados = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_rua2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_rua1)).BeginInit();
            this.SuspendLayout();
           
            this.btn_Rua1Verd.Location = new System.Drawing.Point(653, 211);
            this.btn_Rua1Verd.Name = "btn_Rua1Verd";
            this.btn_Rua1Verd.Size = new System.Drawing.Size(75, 23);
            this.btn_Rua1Verd.TabIndex = 0;
            this.btn_Rua1Verd.Text = "Verde";
            this.btn_Rua1Verd.UseVisualStyleBackColor = true;
            this.btn_Rua1Verd.Click += new System.EventHandler(this.btn_Rua1Verd_Click);
            
            this.btn_Rua1Verm.Location = new System.Drawing.Point(653, 132);
            this.btn_Rua1Verm.Name = "btn_Rua1Verm";
            this.btn_Rua1Verm.Size = new System.Drawing.Size(75, 23);
            this.btn_Rua1Verm.TabIndex = 1;
            this.btn_Rua1Verm.Text = "Vermelho";
            this.btn_Rua1Verm.UseVisualStyleBackColor = true;
            this.btn_Rua1Verm.Click += new System.EventHandler(this.btn_Rua1Verm_Click);
            
            this.btn_Rua1Amar.Location = new System.Drawing.Point(653, 170);
            this.btn_Rua1Amar.Name = "btn_Rua1Amar";
            this.btn_Rua1Amar.Size = new System.Drawing.Size(75, 23);
            this.btn_Rua1Amar.TabIndex = 2;
            this.btn_Rua1Amar.Text = "Amarelo";
            this.btn_Rua1Amar.UseVisualStyleBackColor = true;
            this.btn_Rua1Amar.Click += new System.EventHandler(this.btn_Rua1Amar_Click);
            
            this.btn_Rua2Amar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_Rua2Amar.Location = new System.Drawing.Point(283, 170);
            this.btn_Rua2Amar.Name = "btn_Rua2Amar";
            this.btn_Rua2Amar.Size = new System.Drawing.Size(75, 23);
            this.btn_Rua2Amar.TabIndex = 5;
            this.btn_Rua2Amar.Text = "Amarelo";
            this.btn_Rua2Amar.UseVisualStyleBackColor = true;
            this.btn_Rua2Amar.Click += new System.EventHandler(this.btn_Rua2Amar_Click);
            
            this.btn_Rua2Verm.Location = new System.Drawing.Point(283, 132);
            this.btn_Rua2Verm.Name = "btn_Rua2Verm";
            this.btn_Rua2Verm.Size = new System.Drawing.Size(75, 23);
            this.btn_Rua2Verm.TabIndex = 4;
            this.btn_Rua2Verm.Text = "Vermelho";
            this.btn_Rua2Verm.UseVisualStyleBackColor = true;
            this.btn_Rua2Verm.Click += new System.EventHandler(this.btn_Rua2Verm_Click);
             
            this.btn_Rua2Verd.Location = new System.Drawing.Point(283, 211);
            this.btn_Rua2Verd.Name = "btn_Rua2Verd";
            this.btn_Rua2Verd.Size = new System.Drawing.Size(75, 23);
            this.btn_Rua2Verd.TabIndex = 3;
            this.btn_Rua2Verd.Text = "Verde";
            this.btn_Rua2Verd.UseVisualStyleBackColor = true;
            this.btn_Rua2Verd.Click += new System.EventHandler(this.btn_Rua2Verd_Click);
            
            this.pic_rua2.Image = global::Semáforo.Properties.Resources.desligado;
            this.pic_rua2.Location = new System.Drawing.Point(100, 132);
            this.pic_rua2.Name = "pic_rua2";
            this.pic_rua2.Size = new System.Drawing.Size(177, 131);
            this.pic_rua2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_rua2.TabIndex = 7;
            this.pic_rua2.TabStop = false;
            
            this.pic_rua1.Image = global::Semáforo.Properties.Resources.desligado;
            this.pic_rua1.Location = new System.Drawing.Point(470, 132);
            this.pic_rua1.Name = "pic_rua1";
            this.pic_rua1.Size = new System.Drawing.Size(177, 131);
            this.pic_rua1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_rua1.TabIndex = 8;
            this.pic_rua1.TabStop = false;
            
            this.Lbl_Rua1.AutoSize = true;
            this.Lbl_Rua1.Location = new System.Drawing.Point(537, 99);
            this.Lbl_Rua1.Name = "Lbl_Rua1";
            this.Lbl_Rua1.Size = new System.Drawing.Size(36, 13);
            this.Lbl_Rua1.TabIndex = 9;
            this.Lbl_Rua1.Text = "Rua 1";
             
            this.Lbl_rua2.AutoSize = true;
            this.Lbl_rua2.Location = new System.Drawing.Point(150, 99);
            this.Lbl_rua2.Name = "Lbl_rua2";
            this.Lbl_rua2.Size = new System.Drawing.Size(36, 13);
            this.Lbl_rua2.TabIndex = 10;
            this.Lbl_rua2.Text = "Rua 2";
            this.Lbl_rua2.Click += new System.EventHandler(this.Lbl_rua2_Click);
            
            this.txb_Dado_2.Location = new System.Drawing.Point(540, 341);
            this.txb_Dado_2.Name = "txb_Dado_2";
            this.txb_Dado_2.Size = new System.Drawing.Size(100, 20);
            this.txb_Dado_2.TabIndex = 11;
            
            this.txb_Dados.Location = new System.Drawing.Point(153, 341);
            this.txb_Dados.Name = "txb_Dados";
            this.txb_Dados.Size = new System.Drawing.Size(100, 20);
            this.txb_Dados.TabIndex = 12;
             
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txb_Dados);
            this.Controls.Add(this.txb_Dado_2);
            this.Controls.Add(this.Lbl_rua2);
            this.Controls.Add(this.Lbl_Rua1);
            this.Controls.Add(this.pic_rua1);
            this.Controls.Add(this.pic_rua2);
            this.Controls.Add(this.btn_Rua2Amar);
            this.Controls.Add(this.btn_Rua2Verm);
            this.Controls.Add(this.btn_Rua2Verd);
            this.Controls.Add(this.btn_Rua1Amar);
            this.Controls.Add(this.btn_Rua1Verm);
            this.Controls.Add(this.btn_Rua1Verd);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pic_rua2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_rua1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Rua1Verd;
        private System.Windows.Forms.Button btn_Rua1Verm;
        private System.Windows.Forms.Button btn_Rua1Amar;
        private System.Windows.Forms.Button btn_Rua2Amar;
        private System.Windows.Forms.Button btn_Rua2Verm;
        private System.Windows.Forms.Button btn_Rua2Verd;
        private System.Windows.Forms.PictureBox pic_rua2;
        private System.Windows.Forms.PictureBox pic_rua1;
        private System.Windows.Forms.Label Lbl_Rua1;
        private System.Windows.Forms.Label Lbl_rua2;
        private System.Windows.Forms.TextBox txb_Dado_2;
        private System.Windows.Forms.TextBox txb_Dados;
    }
}


