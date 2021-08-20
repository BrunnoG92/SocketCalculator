
namespace Socket___Cliente
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
            this.components = new System.ComponentModel.Container();
            this.TxtB_Numero1 = new System.Windows.Forms.TextBox();
            this.Lbl_Mensagem = new System.Windows.Forms.Label();
            this.Btn_Calculo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtB_Porta = new System.Windows.Forms.TextBox();
            this.TxtB_IP = new System.Windows.Forms.TextBox();
            this.Btn_Salvar = new System.Windows.Forms.Button();
            this.Txtb_Resposta_Servidor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Limpar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtB_Numero2 = new System.Windows.Forms.TextBox();
            this.CmbB_Operacao = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CmbB_Protocolo = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Txtb_Comando_Enviado = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtB_Resultado_Final = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Lbl_Negativo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtB_Numero1
            // 
            this.TxtB_Numero1.Location = new System.Drawing.Point(161, 63);
            this.TxtB_Numero1.MaxLength = 4;
            this.TxtB_Numero1.Name = "TxtB_Numero1";
            this.TxtB_Numero1.Size = new System.Drawing.Size(129, 20);
            this.TxtB_Numero1.TabIndex = 0;
            // 
            // Lbl_Mensagem
            // 
            this.Lbl_Mensagem.AutoSize = true;
            this.Lbl_Mensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Mensagem.Location = new System.Drawing.Point(71, 63);
            this.Lbl_Mensagem.Name = "Lbl_Mensagem";
            this.Lbl_Mensagem.Size = new System.Drawing.Size(84, 18);
            this.Lbl_Mensagem.TabIndex = 1;
            this.Lbl_Mensagem.Text = "1° Número:";
            // 
            // Btn_Calculo
            // 
            this.Btn_Calculo.Location = new System.Drawing.Point(146, 209);
            this.Btn_Calculo.Name = "Btn_Calculo";
            this.Btn_Calculo.Size = new System.Drawing.Size(112, 23);
            this.Btn_Calculo.TabIndex = 2;
            this.Btn_Calculo.Text = "CALCULAR";
            this.Btn_Calculo.UseVisualStyleBackColor = true;
            this.Btn_Calculo.Click += new System.EventHandler(this.Btn_Calculo_Click);
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(398, 27);
            this.label4.TabIndex = 16;
            this.label4.Text = "Configurações  de rede";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Porta do Servidor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "IP do Servidor:";
            // 
            // TxtB_Porta
            // 
            this.TxtB_Porta.Location = new System.Drawing.Point(175, 113);
            this.TxtB_Porta.Name = "TxtB_Porta";
            this.TxtB_Porta.Size = new System.Drawing.Size(100, 20);
            this.TxtB_Porta.TabIndex = 13;
            this.TxtB_Porta.Text = "11000";
            // 
            // TxtB_IP
            // 
            this.TxtB_IP.Location = new System.Drawing.Point(175, 75);
            this.TxtB_IP.Name = "TxtB_IP";
            this.TxtB_IP.Size = new System.Drawing.Size(100, 20);
            this.TxtB_IP.TabIndex = 12;
            this.TxtB_IP.Text = "127.0.0.1";
            this.TxtB_IP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtB_IP_KeyPress);
            // 
            // Btn_Salvar
            // 
            this.Btn_Salvar.Location = new System.Drawing.Point(136, 209);
            this.Btn_Salvar.Name = "Btn_Salvar";
            this.Btn_Salvar.Size = new System.Drawing.Size(139, 23);
            this.Btn_Salvar.TabIndex = 11;
            this.Btn_Salvar.Text = "SALVAR";
            this.Btn_Salvar.UseVisualStyleBackColor = true;
            this.Btn_Salvar.Click += new System.EventHandler(this.Btn_Salvar_Click);
            // 
            // Txtb_Resposta_Servidor
            // 
            this.Txtb_Resposta_Servidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtb_Resposta_Servidor.Location = new System.Drawing.Point(525, 344);
            this.Txtb_Resposta_Servidor.Multiline = true;
            this.Txtb_Resposta_Servidor.Name = "Txtb_Resposta_Servidor";
            this.Txtb_Resposta_Servidor.ReadOnly = true;
            this.Txtb_Resposta_Servidor.Size = new System.Drawing.Size(215, 35);
            this.Txtb_Resposta_Servidor.TabIndex = 17;
            this.toolTip1.SetToolTip(this.Txtb_Resposta_Servidor, "Resposta recebida do Servidor");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "Comando Enviado ao Servidor";
            // 
            // Btn_Limpar
            // 
            this.Btn_Limpar.Location = new System.Drawing.Point(349, 485);
            this.Btn_Limpar.Name = "Btn_Limpar";
            this.Btn_Limpar.Size = new System.Drawing.Size(130, 23);
            this.Btn_Limpar.TabIndex = 19;
            this.Btn_Limpar.Text = "LIMPAR ";
            this.toolTip1.SetToolTip(this.Btn_Limpar, "Limpa os campos editavéis da janela, exceto as configurações padão do servidor: I" +
        "P, Porta,Digitos de Precisão");
            this.Btn_Limpar.UseVisualStyleBackColor = true;
            this.Btn_Limpar.Click += new System.EventHandler(this.Btn_Limpar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(71, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 18);
            this.label5.TabIndex = 21;
            this.label5.Text = "2° Número:";
            // 
            // TxtB_Numero2
            // 
            this.TxtB_Numero2.Location = new System.Drawing.Point(161, 111);
            this.TxtB_Numero2.MaxLength = 4;
            this.TxtB_Numero2.Name = "TxtB_Numero2";
            this.TxtB_Numero2.Size = new System.Drawing.Size(129, 20);
            this.TxtB_Numero2.TabIndex = 20;
            // 
            // CmbB_Operacao
            // 
            this.CmbB_Operacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbB_Operacao.FormattingEnabled = true;
            this.CmbB_Operacao.Items.AddRange(new object[] {
            "Adição",
            "Subtração",
            "Multiplicação",
            "Divisão",
            "Raiz Quadrada"});
            this.CmbB_Operacao.Location = new System.Drawing.Point(161, 154);
            this.CmbB_Operacao.Name = "CmbB_Operacao";
            this.CmbB_Operacao.Size = new System.Drawing.Size(129, 21);
            this.CmbB_Operacao.TabIndex = 22;
            this.CmbB_Operacao.SelectedIndexChanged += new System.EventHandler(this.CmbB_Operacao_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(81, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 18);
            this.label6.TabIndex = 23;
            this.label6.Text = "Operação";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.CmbB_Operacao);
            this.panel1.Controls.Add(this.Lbl_Mensagem);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.TxtB_Numero1);
            this.panel1.Controls.Add(this.TxtB_Numero2);
            this.panel1.Controls.Add(this.Btn_Calculo);
            this.panel1.Location = new System.Drawing.Point(27, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 248);
            this.panel1.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(398, 30);
            this.label7.TabIndex = 0;
            this.label7.Text = "Cálculo a ser realizado";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.CmbB_Protocolo);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.Btn_Salvar);
            this.panel2.Controls.Add(this.TxtB_IP);
            this.panel2.Controls.Add(this.TxtB_Porta);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(464, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 248);
            this.panel2.TabIndex = 25;
            // 
            // CmbB_Protocolo
            // 
            this.CmbB_Protocolo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbB_Protocolo.FormattingEnabled = true;
            this.CmbB_Protocolo.Items.AddRange(new object[] {
            "CALC",
            "OTHER",
            "DEV",
            "CON",
            "BIN"});
            this.CmbB_Protocolo.Location = new System.Drawing.Point(175, 149);
            this.CmbB_Protocolo.Name = "CmbB_Protocolo";
            this.CmbB_Protocolo.Size = new System.Drawing.Size(100, 21);
            this.CmbB_Protocolo.TabIndex = 24;
            this.toolTip1.SetToolTip(this.CmbB_Protocolo, "Protocolo a ser enviado ao Servidor");
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(99, 150);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 16);
            this.label10.TabIndex = 17;
            this.label10.Text = "Protocolo:";
            this.toolTip1.SetToolTip(this.label10, "Protocolo de trabalho encaminhado ao servidor");
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(522, 288);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(218, 18);
            this.label8.TabIndex = 26;
            this.label8.Text = "Resposta Recebida do Servidor";
            // 
            // Txtb_Comando_Enviado
            // 
            this.Txtb_Comando_Enviado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtb_Comando_Enviado.Location = new System.Drawing.Point(103, 344);
            this.Txtb_Comando_Enviado.Multiline = true;
            this.Txtb_Comando_Enviado.Name = "Txtb_Comando_Enviado";
            this.Txtb_Comando_Enviado.ReadOnly = true;
            this.Txtb_Comando_Enviado.Size = new System.Drawing.Size(215, 35);
            this.Txtb_Comando_Enviado.TabIndex = 27;
            this.toolTip1.SetToolTip(this.Txtb_Comando_Enviado, "Comando que foi enviado ao Servidor");
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(346, 382);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 18);
            this.label9.TabIndex = 28;
            this.label9.Text = "Resultado Cálculo:";
            // 
            // TxtB_Resultado_Final
            // 
            this.TxtB_Resultado_Final.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtB_Resultado_Final.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtB_Resultado_Final.Location = new System.Drawing.Point(340, 418);
            this.TxtB_Resultado_Final.Name = "TxtB_Resultado_Final";
            this.TxtB_Resultado_Final.ReadOnly = true;
            this.TxtB_Resultado_Final.Size = new System.Drawing.Size(143, 31);
            this.TxtB_Resultado_Final.TabIndex = 29;
            this.TxtB_Resultado_Final.Text = "0";
            this.TxtB_Resultado_Final.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.TxtB_Resultado_Final, "Mostra a resposta do servidor de forma já tratada, mostrando o resultado do Calcu" +
        "lo solicitado");
            // 
            // Lbl_Negativo
            // 
            this.Lbl_Negativo.AutoSize = true;
            this.Lbl_Negativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.Lbl_Negativo.Location = new System.Drawing.Point(314, 420);
            this.Lbl_Negativo.Name = "Lbl_Negativo";
            this.Lbl_Negativo.Size = new System.Drawing.Size(20, 25);
            this.Lbl_Negativo.TabIndex = 30;
            this.Lbl_Negativo.Text = "-";
            this.Lbl_Negativo.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 545);
            this.Controls.Add(this.Lbl_Negativo);
            this.Controls.Add(this.TxtB_Resultado_Final);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Txtb_Comando_Enviado);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Btn_Limpar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txtb_Resposta_Servidor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "CLIENTE";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtB_Numero1;
        private System.Windows.Forms.Label Lbl_Mensagem;
        private System.Windows.Forms.Button Btn_Calculo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtB_Porta;
        private System.Windows.Forms.TextBox TxtB_IP;
        private System.Windows.Forms.Button Btn_Salvar;
        private System.Windows.Forms.TextBox Txtb_Resposta_Servidor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Limpar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtB_Numero2;
        private System.Windows.Forms.ComboBox CmbB_Operacao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Txtb_Comando_Enviado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtB_Resultado_Final;
        private System.Windows.Forms.ComboBox CmbB_Protocolo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label Lbl_Negativo;
    }
}

