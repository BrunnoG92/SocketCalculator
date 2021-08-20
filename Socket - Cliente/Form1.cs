using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Socket___Cliente
{
    public partial class Form1 : Form
    {
        public IPAddress IP;
        public int Porta;
        public string MensagemEnviada;
        public int clicado;

        public Form1()
        {
            InitializeComponent();
            // Inicializo com as opções Adição e protocolo CALC selecioandos por padrão
            CmbB_Protocolo.SelectedIndex = 0;
            CmbB_Operacao.SelectedIndex = 0;

        }
        public void EnviaMensagem()
        {
            try
            {   // Crio e instancio um novo cliente TCP chamado client. O client recebe por paramentro IP e Porta do Servidor
                TcpClient client = new TcpClient();
                client.Connect(IP, Porta);
                NetworkStream networkStream = client.GetStream();

                // Crio um  BinaryWriter para escrever para o  stream
                BinaryWriter binaryWriter = new BinaryWriter(networkStream);

                // Crio um  BinaryReader para  leitura do stream
                BinaryReader binaryReader = new BinaryReader(networkStream);

                // envio a mensagem para o servidor em bytes
                byte[] writeData = UTF8Encoding.UTF8.GetBytes(MensagemEnviada);
                Array.Resize(ref writeData, 21); //  A mensagem é composto por 4 "pedaços" contendo 4 bytes, totalizando 20
                                                 //  foi adicionado 1 byte a mais para caso onde o resultado é um número negativo, poder ser enviado o simbolo -
                binaryWriter.Write(writeData, 0, 21);

                // Leio a resposta do servidor em byte. A resposta é composta por 3 blocos de 3 bytes. Novamente 1 a mais para o simbolo -
                byte[] RespostaServidorBytes = new byte[13];
                binaryReader.Read(RespostaServidorBytes, 0, 13);
                string RespostaServidorString = UTF8Encoding.UTF8.GetString(RespostaServidorBytes); // Converto os byte recebidos para uma string
                Txtb_Resposta_Servidor.Text = RespostaServidorString;

                // Validações do protocolo recebido
                if (RespostaServidorString.Contains("-") == true) // se a reposta conter o simbolo negativo (-). Exibo a label -
                {   
                    TxtB_Resultado_Final.Text = RespostaServidorString.Substring(8, 4);
                    Lbl_Negativo.Visible = true;
                    client.Close(); 
                }
                if (RespostaServidorString.Contains("-1") == true)  // Se a resposta for -1 , indica que o protocolo é invalido e encerro a conexão.
                {
                    Lbl_Negativo.Visible = false;
                    MessageBox.Show("Erro na mensagem enviada !", "Protocolo inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    client.Close();

                }
                else if (RespostaServidorString.Contains("-") == false)
                {
                    TxtB_Resultado_Final.Text = RespostaServidorString.Substring(8, 4); //se a resposta não contem (-), oculto a label (-)
                    Lbl_Negativo.Visible = false;
                    client.Close();
                }
                if (RespostaServidorString.Contains("X") == true)  // Se a resposta contem X , indica operação invalida, divisão por zero
                {
                    MessageBox.Show("Divisão por zero não permitida!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    client.Close();
                }
                if (int.Parse(TxtB_Numero1.Text) < 0 && CmbB_Operacao.SelectedIndex == 4) // Caso o primeiro numer o seja negativo e a operação selecionada
                                                                                          // for raiz quadrada, informo ao usuário que sera feita a conversão
                {
                    MessageBox.Show($"Não existe raiz quadrada de número negativo. O número {TxtB_Numero1.Text} será convertido para positivo ", "Operação não permetida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            catch // Tratamento de exeção, para o servidor não estiver ligado, informo ao usuário
            {
                MessageBox.Show("Erro ao enviar mensagem. Verifique se o Servidor está ligado", "Não foi possível conectar ao Servidor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }
        private void Btn_Calculo_Click(object sender, EventArgs e)
        {
            // Validação para o clique no envio. Somente pode enviar após ter salvo a configuração
            if (clicado < 1)
            {
                MessageBox.Show("Você deve salvar as configurações do servidor antes de enviar uma mensagem", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string Operacao = null; 
                // Salvo o comando da operação na variavel de acordo com o selecionado
                // na ComboBox
                if (CmbB_Operacao.SelectedIndex == 0)
                {
                    Operacao = "SUM";
                }
                else if (CmbB_Operacao.SelectedIndex == 1)
                {
                    Operacao = "SUB";
                }
                else if (CmbB_Operacao.SelectedIndex == 2)
                {
                    Operacao = "MUL";
                }
                else if (CmbB_Operacao.SelectedIndex == 3)
                {
                    Operacao = "DIV";
                }
                else if (CmbB_Operacao.SelectedIndex == 4)
                {
                    Operacao = "RAIZ";
                }
              
                // se os numeros 1 e 2 tiverem menos que 4 digitos, complemento com zero a esquerda

                string NumerosMensagem = TxtB_Numero1.Text.PadLeft(4, '0') + TxtB_Numero2.Text.PadLeft(4, '0') + Operacao;
                int TamanhoNumeros = NumerosMensagem.Length + 1;

                // Fomato a mensagem enviada ao servidor no formato : CALC 0012 0025 0025 SUM

                MensagemEnviada = CmbB_Protocolo.Text + TamanhoNumeros.ToString().PadLeft(4, '0') +
                TxtB_Numero1.Text.PadLeft(4, '0') + TxtB_Numero2.Text.PadLeft(4, '0') + Operacao;
                Txtb_Comando_Enviado.Text = MensagemEnviada;
                EnviaMensagem();
            }
        }

        private void Btn_Salvar_Click(object sender, EventArgs e)
        {   

            clicado = 1; // validação se o botão salvar foi clicado
            IP = IPAddress.Parse(TxtB_IP.Text);
            Porta = int.Parse(TxtB_Porta.Text);
            MessageBox.Show("Configurações salvas com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void Btn_Limpar_Click(object sender, EventArgs e)
        {
            Txtb_Resposta_Servidor.Text = null;
            Txtb_Comando_Enviado.Text = null;
            TxtB_Numero1.Text = null;
            TxtB_Numero2.Text = null;
            TxtB_Resultado_Final.Text = null;
        }


        private void TxtB_IP_KeyPress(object sender, KeyPressEventArgs e)
        {   // validação para textbox IP, receber apenas números
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Somente números são permitidos no campo IP", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void CmbB_Operacao_SelectedIndexChanged(object sender, EventArgs e)
        {   
            // Funçao onde desabilito o campo de texto para o número caso a operação raiz quadrada for selecionada
            if (CmbB_Operacao.SelectedIndex == 4)
            {
                TxtB_Numero2.Enabled = false;
                TxtB_Numero2.Text = null;
            }
            else
            {
                TxtB_Numero2.Enabled = true;
            }
        }
    }
}
