
namespace Socket_Servidor
{
    partial class Form1_Servidor
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
            this.Lbl_Status = new System.Windows.Forms.Label();
            this.Lbl_Status2 = new System.Windows.Forms.Label();
            this.TxtB_ComandoRecebido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Iniciar_Servidor = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Btn_Limpa_Texto = new System.Windows.Forms.Button();
            this.TxtB_IP = new System.Windows.Forms.TextBox();
            this.TxtB_Porta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Lbl_ComandoEnviado = new System.Windows.Forms.Label();
            this.TxtB_ComandoEnviado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Lbl_Status
            // 
            this.Lbl_Status.AutoSize = true;
            this.Lbl_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Status.Location = new System.Drawing.Point(64, 23);
            this.Lbl_Status.Name = "Lbl_Status";
            this.Lbl_Status.Size = new System.Drawing.Size(140, 16);
            this.Lbl_Status.TabIndex = 0;
            this.Lbl_Status.Text = "Status do Servidor:";
            // 
            // Lbl_Status2
            // 
            this.Lbl_Status2.AutoSize = true;
            this.Lbl_Status2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Status2.ForeColor = System.Drawing.Color.Red;
            this.Lbl_Status2.Location = new System.Drawing.Point(210, 25);
            this.Lbl_Status2.Name = "Lbl_Status2";
            this.Lbl_Status2.Size = new System.Drawing.Size(78, 13);
            this.Lbl_Status2.TabIndex = 1;
            this.Lbl_Status2.Text = "DESLIGADO";
            // 
            // TxtB_ComandoRecebido
            // 
            this.TxtB_ComandoRecebido.Cursor = System.Windows.Forms.Cursors.No;
            this.TxtB_ComandoRecebido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtB_ComandoRecebido.Location = new System.Drawing.Point(175, 87);
            this.TxtB_ComandoRecebido.Multiline = true;
            this.TxtB_ComandoRecebido.Name = "TxtB_ComandoRecebido";
            this.TxtB_ComandoRecebido.ReadOnly = true;
            this.TxtB_ComandoRecebido.Size = new System.Drawing.Size(263, 30);
            this.TxtB_ComandoRecebido.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Comando Recebido";
            // 
            // Btn_Iniciar_Servidor
            // 
            this.Btn_Iniciar_Servidor.Location = new System.Drawing.Point(509, 183);
            this.Btn_Iniciar_Servidor.Name = "Btn_Iniciar_Servidor";
            this.Btn_Iniciar_Servidor.Size = new System.Drawing.Size(139, 23);
            this.Btn_Iniciar_Servidor.TabIndex = 4;
            this.Btn_Iniciar_Servidor.Text = "INICIAR SERVIDOR";
            this.Btn_Iniciar_Servidor.UseVisualStyleBackColor = true;
            this.Btn_Iniciar_Servidor.Click += new System.EventHandler(this.Btn_Iniciar_Servidor_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // Btn_Limpa_Texto
            // 
            this.Btn_Limpa_Texto.Location = new System.Drawing.Point(119, 211);
            this.Btn_Limpa_Texto.Name = "Btn_Limpa_Texto";
            this.Btn_Limpa_Texto.Size = new System.Drawing.Size(139, 23);
            this.Btn_Limpa_Texto.TabIndex = 5;
            this.Btn_Limpa_Texto.Text = "LIMPAR TEXTO";
            this.Btn_Limpa_Texto.UseVisualStyleBackColor = true;
            this.Btn_Limpa_Texto.Click += new System.EventHandler(this.Btn_Limpa_Texto_Click);
            // 
            // TxtB_IP
            // 
            this.TxtB_IP.Location = new System.Drawing.Point(567, 101);
            this.TxtB_IP.Name = "TxtB_IP";
            this.TxtB_IP.Size = new System.Drawing.Size(100, 20);
            this.TxtB_IP.TabIndex = 6;
            this.TxtB_IP.Text = "127.0.0.1";
            // 
            // TxtB_Porta
            // 
            this.TxtB_Porta.Location = new System.Drawing.Point(567, 141);
            this.TxtB_Porta.Name = "TxtB_Porta";
            this.TxtB_Porta.Size = new System.Drawing.Size(100, 20);
            this.TxtB_Porta.TabIndex = 7;
            this.TxtB_Porta.Text = "11000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(487, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "IP do Servidor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(469, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Porta do Servidor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(506, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Configuração do Servidor";
            // 
            // Lbl_ComandoEnviado
            // 
            this.Lbl_ComandoEnviado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ComandoEnviado.Location = new System.Drawing.Point(12, 131);
            this.Lbl_ComandoEnviado.Name = "Lbl_ComandoEnviado";
            this.Lbl_ComandoEnviado.Size = new System.Drawing.Size(157, 30);
            this.Lbl_ComandoEnviado.TabIndex = 12;
            this.Lbl_ComandoEnviado.Text = "Comando Enviado:";
            // 
            // TxtB_ComandoEnviado
            // 
            this.TxtB_ComandoEnviado.Cursor = System.Windows.Forms.Cursors.No;
            this.TxtB_ComandoEnviado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtB_ComandoEnviado.Location = new System.Drawing.Point(175, 127);
            this.TxtB_ComandoEnviado.Multiline = true;
            this.TxtB_ComandoEnviado.Name = "TxtB_ComandoEnviado";
            this.TxtB_ComandoEnviado.ReadOnly = true;
            this.TxtB_ComandoEnviado.Size = new System.Drawing.Size(263, 30);
            this.TxtB_ComandoEnviado.TabIndex = 11;
            // 
            // Form1_Servidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 249);
            this.Controls.Add(this.Lbl_ComandoEnviado);
            this.Controls.Add(this.TxtB_ComandoEnviado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtB_Porta);
            this.Controls.Add(this.TxtB_IP);
            this.Controls.Add(this.Btn_Limpa_Texto);
            this.Controls.Add(this.Btn_Iniciar_Servidor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtB_ComandoRecebido);
            this.Controls.Add(this.Lbl_Status2);
            this.Controls.Add(this.Lbl_Status);
            this.Name = "Form1_Servidor";
            this.Text = "SERVIDOR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Status;
        private System.Windows.Forms.Label Lbl_Status2;
        private System.Windows.Forms.TextBox TxtB_ComandoRecebido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Iniciar_Servidor;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button Btn_Limpa_Texto;
        private System.Windows.Forms.TextBox TxtB_IP;
        private System.Windows.Forms.TextBox TxtB_Porta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Lbl_ComandoEnviado;
        private System.Windows.Forms.TextBox TxtB_ComandoEnviado;
    }
}

