namespace Busca_CEP
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textCep = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ibge = new System.Windows.Forms.Label();
            this.ddd = new System.Windows.Forms.Label();
            this.uf = new System.Windows.Forms.Label();
            this.cidade = new System.Windows.Forms.Label();
            this.cep = new System.Windows.Forms.Label();
            this.rua = new System.Windows.Forms.Label();
            this.comple = new System.Windows.Forms.Label();
            this.bairro = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comple);
            this.groupBox1.Controls.Add(this.bairro);
            this.groupBox1.Controls.Add(this.rua);
            this.groupBox1.Controls.Add(this.ddd);
            this.groupBox1.Controls.Add(this.cep);
            this.groupBox1.Controls.Add(this.ibge);
            this.groupBox1.Controls.Add(this.uf);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cidade);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(13, 92);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(303, 242);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações CEP";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textCep
            // 
            this.textCep.Location = new System.Drawing.Point(83, 24);
            this.textCep.Name = "textCep";
            this.textCep.Size = new System.Drawing.Size(114, 20);
            this.textCep.TabIndex = 1;
            this.textCep.Text = "01001000";
            this.textCep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "CEP:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(203, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 20);
            this.button1.TabIndex = 3;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "CEP:";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(81, 59);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(0, 12);
            this.status.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "Rua:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "Complemento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "Bairro:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 12);
            this.label7.TabIndex = 4;
            this.label7.Text = "Cidade:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(52, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 12);
            this.label8.TabIndex = 5;
            this.label8.Text = "UF:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(52, 202);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 12);
            this.label9.TabIndex = 6;
            this.label9.Text = "IBGE:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(52, 180);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 12);
            this.label10.TabIndex = 7;
            this.label10.Text = "DDD:";
            // 
            // ibge
            // 
            this.ibge.AutoSize = true;
            this.ibge.Font = new System.Drawing.Font("Arial", 9F);
            this.ibge.Location = new System.Drawing.Point(83, 200);
            this.ibge.Name = "ibge";
            this.ibge.Size = new System.Drawing.Size(0, 15);
            this.ibge.TabIndex = 13;
            // 
            // ddd
            // 
            this.ddd.AutoSize = true;
            this.ddd.Font = new System.Drawing.Font("Arial", 9F);
            this.ddd.Location = new System.Drawing.Point(81, 178);
            this.ddd.Name = "ddd";
            this.ddd.Size = new System.Drawing.Size(0, 15);
            this.ddd.TabIndex = 14;
            // 
            // uf
            // 
            this.uf.AutoSize = true;
            this.uf.Font = new System.Drawing.Font("Arial", 9F);
            this.uf.Location = new System.Drawing.Point(72, 155);
            this.uf.Name = "uf";
            this.uf.Size = new System.Drawing.Size(0, 15);
            this.uf.TabIndex = 15;
            // 
            // cidade
            // 
            this.cidade.AutoSize = true;
            this.cidade.Font = new System.Drawing.Font("Arial", 9F);
            this.cidade.Location = new System.Drawing.Point(95, 131);
            this.cidade.Name = "cidade";
            this.cidade.Size = new System.Drawing.Size(0, 15);
            this.cidade.TabIndex = 16;
            // 
            // cep
            // 
            this.cep.AutoSize = true;
            this.cep.Font = new System.Drawing.Font("Arial", 9F);
            this.cep.Location = new System.Drawing.Point(79, 36);
            this.cep.Name = "cep";
            this.cep.Size = new System.Drawing.Size(0, 15);
            this.cep.TabIndex = 17;
            // 
            // rua
            // 
            this.rua.AutoSize = true;
            this.rua.Font = new System.Drawing.Font("Arial", 9F);
            this.rua.Location = new System.Drawing.Point(78, 60);
            this.rua.Name = "rua";
            this.rua.Size = new System.Drawing.Size(0, 15);
            this.rua.TabIndex = 18;
            this.rua.Click += new System.EventHandler(this.label15_Click);
            // 
            // comple
            // 
            this.comple.AutoSize = true;
            this.comple.Font = new System.Drawing.Font("Arial", 9F);
            this.comple.Location = new System.Drawing.Point(134, 85);
            this.comple.Name = "comple";
            this.comple.Size = new System.Drawing.Size(0, 15);
            this.comple.TabIndex = 19;
            // 
            // bairro
            // 
            this.bairro.AutoSize = true;
            this.bairro.Font = new System.Drawing.Font("Arial", 9F);
            this.bairro.Location = new System.Drawing.Point(95, 108);
            this.bairro.Name = "bairro";
            this.bairro.Size = new System.Drawing.Size(0, 15);
            this.bairro.TabIndex = 20;
            this.bairro.Click += new System.EventHandler(this.label18_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 340);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(303, 27);
            this.button2.TabIndex = 4;
            this.button2.Text = "Copiar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 379);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.status);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textCep);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(346, 418);
            this.MinimumSize = new System.Drawing.Size(346, 418);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busca CEP";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textCep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label ddd;
        private System.Windows.Forms.Label ibge;
        private System.Windows.Forms.Label uf;
        private System.Windows.Forms.Label cidade;
        private System.Windows.Forms.Label cep;
        private System.Windows.Forms.Label comple;
        private System.Windows.Forms.Label bairro;
        private System.Windows.Forms.Label rua;
        private System.Windows.Forms.Button button2;
    }
}

