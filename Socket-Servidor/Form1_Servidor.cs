using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Socket_Servidor
{

    public partial class Form1_Servidor : Form
    {

        public string MostraComando;
        public string MensagemRecebida;
        public string ComandoEnviado;
        public IPAddress IP;
        public int Porta;
        public Boolean ServidorLigado;

        public Form1_Servidor()
        {
            InitializeComponent();

        }

        // Instancio uma nova thread, para ser feito o trabalho do servidor, com isso evito da UI do programa ficar travada/congelada
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            // Instancio um novo TCP Listernert com 2 paramentros, IP e Porta
            TcpListener listener = new TcpListener(IP, Porta);
            listener.Start();
            backgroundWorker1.ReportProgress(50);  // Quando o servidor é iniciado, 50% do seu trabalho ja foi concluido
            TcpClient client = listener.AcceptTcpClient();
            NetworkStream stream = client.GetStream();
            // Criado BinaryWriter para escrita para o  stream
            BinaryWriter binaryWriter = new BinaryWriter(stream);
            // criado  BinaryReader para leitura do stream
            BinaryReader binaryReader = new BinaryReader(stream);

            while (MensagemRecebida == null) // enquanto eu não receber uma mensagem do Cliente, o servidor fica no modo ativo, aceitando conexão
            {
                // Leia as inormações que chegam
                byte[] data = new byte[21]; // O comando do cliente pode chegar com até 21 bytes no máximo (20 é o padrão, 21 para numeros negativos)
                int receivedDataLength = binaryReader.Read(data, 0, data.Length);
                string stringData = Encoding.UTF8.GetString(data, 0, receivedDataLength);

                // Salvo a string para a variavel 
                MensagemRecebida = stringData;
                MostraComando = MensagemRecebida;

                //Variaveis locais , onde é o comando recebido do cliente é quebrado em pedaços de 4  e salvo

                string Protocolo = MensagemRecebida.Substring(0, 4);
                string Numero1 = MensagemRecebida.Substring(8, 4);
                string Numero2 = MensagemRecebida.Substring(12, 4);
                string Operador = MensagemRecebida.Substring(16, 4);

                // Realiza o calculo de acordo com o operador recebido

                if (Protocolo.Contains("CALC") == false)
                {
                    byte[] Resposta1 = UTF8Encoding.UTF8.GetBytes("-1");
                    Array.Resize(ref Resposta1, 2);
                    binaryWriter.Write(Resposta1, 0, 2);
                    listener.Stop();


                }
                else
                {   // Condicioanais para ser feito o calculo
                    if (Operador.Contains("SUM") == true)
                    {

                        //faço a soma
                        int soma = int.Parse(Numero1) + int.Parse(Numero2);
                        // Formato o resultado no protocolo RESP00040050 

                        string SomaString = soma.ToString().PadLeft(4, '0');
                        string TamanhoStringSoma = SomaString.Length.ToString();
                        byte[] RespondaSoma = UTF8Encoding.UTF8.GetBytes("RESP" + TamanhoStringSoma.PadLeft(4, '0') + SomaString);
                        ComandoEnviado = ("RESP" + TamanhoStringSoma.PadLeft(4, '0') + SomaString);
                        Array.Resize(ref RespondaSoma, 21);
                        binaryWriter.Write(RespondaSoma, 0, 21);

                        listener.Stop();
                    }
                    else if (Operador.Contains("SUB") == true)
                    {
                        //faço a subtração
                        int subtracao = int.Parse(Numero1) - int.Parse(Numero2);

                        if (subtracao < 0) // Se o resultado for negativo, faço um tratamento
                        {
                            subtracao = subtracao * -1; // transformo em positivo
                            string SubtracaoStringNegativo = subtracao.ToString().PadLeft(4, '0');
                            string TamanhoSubtracaoStringNegativo = SubtracaoStringNegativo.Length.ToString();
                            byte[] RespondaSubNegativo = UTF8Encoding.UTF8.GetBytes("RESP" + TamanhoSubtracaoStringNegativo.PadLeft(4, '0') + SubtracaoStringNegativo + "-");
                            ComandoEnviado = ("RESP" + TamanhoSubtracaoStringNegativo.PadLeft(4, '0') + SubtracaoStringNegativo + "-");
                            Array.Resize(ref RespondaSubNegativo, 21);
                            binaryWriter.Write(RespondaSubNegativo, 0, 21);
                            listener.Stop();
                        }

                        // Formato o resultado no protocolo RESP00040050 
                        string SubtracaoString = subtracao.ToString().PadLeft(4, '0');
                        string TamanhoSubtracaoString = SubtracaoString.Length.ToString();
                        byte[] RespondaSub = UTF8Encoding.UTF8.GetBytes("RESP" + TamanhoSubtracaoString.PadLeft(4, '0') + SubtracaoString);
                        ComandoEnviado = ("RESP" + TamanhoSubtracaoString.PadLeft(4, '0') + SubtracaoString);

                        Array.Resize(ref RespondaSub, 21);
                        binaryWriter.Write(RespondaSub, 0, 21);
                        listener.Stop();
                    }
                    else if (Operador.Contains("DIV") == true)
                    {
                        //se o numero 2 for igual a zero, envio a mensagem XXX ao cliente, operação não permetida e encerro a conexão
                        if (int.Parse(Numero2) == 0)
                        {
                            byte[] RespondaDIVZero = UTF8Encoding.UTF8.GetBytes("XXXX");
                            Array.Resize(ref RespondaDIVZero, 21);
                            binaryWriter.Write(RespondaDIVZero, 0, 21);
                            listener.Stop();
                        }
                        //faço a Divisão caso o numero 2 for maior que zero
                        double Divisao = double.Parse(Numero1) / double.Parse(Numero2);
                        string DivisaoString = Divisao.ToString().PadLeft(4, '0');
                        string TamanhoDivisaoString = DivisaoString.Length.ToString() + 1; //calculo o tamanho da string enviada, somando-se mais 1 ao final devido ao /0 enviado pelo protocolo
                        byte[] RespondaDIV = UTF8Encoding.UTF8.GetBytes("RESP" + TamanhoDivisaoString.PadLeft(4, '0') + DivisaoString);
                        ComandoEnviado = ("RESP" + TamanhoDivisaoString.PadLeft(4, '0') + DivisaoString);
                        Array.Resize(ref RespondaDIV, 21);
                        binaryWriter.Write(RespondaDIV, 0, 21);
                        listener.Stop();
                    }
                    else if (Operador.Contains("MUL") == true)
                    {

                        //faço a Multiplicação
                        int Multiplicacao = int.Parse(Numero1) * int.Parse(Numero2);
                        string MultiplicacaoString = Multiplicacao.ToString().PadLeft(4, '0');
                        string TamanhoMultiplicacaoString = MultiplicacaoString.Length.ToString();
                        byte[] RespondaMult = UTF8Encoding.UTF8.GetBytes("RESP" + TamanhoMultiplicacaoString.PadLeft(4, '0') + MultiplicacaoString);
                        ComandoEnviado = ("RESP" + TamanhoMultiplicacaoString.PadLeft(4, '0') + MultiplicacaoString);
                        Array.Resize(ref RespondaMult, 21);
                        binaryWriter.Write(RespondaMult, 0, 21);
                        listener.Stop();
                    }
                    //faço a raiz quadrada de numero 1
                    else if (Operador.Contains("RAIZ") == true)
                    {
                        //Se numero 1 for negativo, removo o sinal de negativo da string
                        if (Numero1.Contains("-"))
                        {
                            Numero1 = Numero1.Replace("-", "");

                        }
                        // e sigo com o calculo da razi quadrada normalmente
                        double raiz = Math.Sqrt(int.Parse(Numero1));
                        string RaizString = raiz.ToString("N2").PadLeft(4, '0');
                        string TamanhoRaizString = RaizString.Length.ToString();
                        byte[] RespondaRaiz = UTF8Encoding.UTF8.GetBytes("RESP" + TamanhoRaizString.PadLeft(4, '0') + RaizString);
                        ComandoEnviado = ("RESP" + TamanhoRaizString.PadLeft(4, '0') + RaizString);
                        Array.Resize(ref RespondaRaiz, 21);
                        binaryWriter.Write(RespondaRaiz, 0, 21);
                        listener.Stop();
                    }
                }

            }
            listener.Stop();
            backgroundWorker1.ReportProgress(100); // Uma vez ja recebida a mensagem e respondida, o trabalho da thread é reportado como 100% concluido e finalizada


        }
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // Indica que a thread do Servidor entrou no modo de operação. É então feita as alterações na UI, como cor e preenchimento dos campos
            Lbl_Status2.Text = "LIGADO";
            Lbl_Status2.ForeColor = Color.ForestGreen;
            TxtB_ComandoRecebido.Text = MostraComando;
            TxtB_ComandoEnviado.Text = ComandoEnviado;

        }

        private void Btn_Iniciar_Servidor_Click(object sender, EventArgs e)
        {

            ServidorLigado = true;
            IP = IPAddress.Parse(TxtB_IP.Text);
            Porta = int.Parse(TxtB_Porta.Text);
            MostraComando = null;
            backgroundWorker1.RunWorkerAsync();

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {


            if (ServidorLigado == true)
            {
                MensagemRecebida = null;
                backgroundWorker1.RunWorkerAsync();

            }
            else
            {
                TxtB_ComandoRecebido.Text = MostraComando;
                Lbl_Status2.Text = "DESLIGADO";
                Lbl_Status2.ForeColor = Color.Red;
                MensagemRecebida = null;
            }



        }

        private void Btn_Limpa_Texto_Click(object sender, EventArgs e)
        {
            TxtB_ComandoRecebido.Text = null;
        }

    }
}
