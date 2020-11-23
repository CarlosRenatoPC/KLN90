using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using SERIAL_HEXAPOD_MONITOR;

namespace SERIAL_MONITOR
{
    public partial class Form1 : Form
    {
        //Valor INT lido
        public int[] buffeRX = new int[10000];
        public int contabuffeRX;
        public string dadoRX;

        public bool echoLocalOn = true;
        public bool echoRemoteOn = true;
        public bool oscilarOn = false;

        public Boolean testeM2000PE = false;

        public string arduinoTXdata;
        public string arduinoTXdataOld;

        public int passoatual;
        public int contapasso1;
        public int[] noBadge = new int[6];


        public int[] val1 = new int[6];//, val2, val3, val4, val5, val6;

        //Valor INT incrementado/decrementado ao longo do tempo
        public int[] valCalc1 = new int[6];//, valCalc2, valCalc3, valCalc4, valCalc5, valCalc6;

        //Valor FLOAT incrementado/decrementado ao longo do tempo
        public float[] valCalcFloat1 = new float[6];//, valCalcFloat2, valCalcFloat3, valCalcFloat4, valCalcFloat5, valCalcFloat6; 
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (testeM2000PE)
            {
                //vScrollBar1.Visible = false;
                timExtrapolacao.Enabled = false;
            }

            string[] ports = SerialPort.GetPortNames();
            for (int i = 0; i < ports.Length; i++)
            {
                cbComPorts.Items.Add(ports[i]);
            }

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            val1[0] = vScrollBar1.Value;
        }
        
        private void calcula_novo_valor( )
        {
            arduinoTXdata = "A" +   vScrollBar1.Value.ToString("000") +vScrollBar2.Value.ToString("000") +vScrollBar3.Value.ToString("000") +
                                    vScrollBar4.Value.ToString("000") + vScrollBar5.Value.ToString("000") + vScrollBar6.Value.ToString("000") + Environment.NewLine;

            enviardata(arduinoTXdata);
        }

        private void connect_desconnect(string comportstr)
        {
            try
            {
                if (spControle.IsOpen == false)
                {
                    if (testeM2000PE)           
                        spControle.BaudRate = 9600;
                    else
                        spControle.BaudRate = 115200;

                    spControle.StopBits = StopBits.One;
                    spControle.Parity = Parity.None;
                    spControle.PortName = comportstr;
                    spControle.Open();
                    btConnect.Text = "CLOSE";
                }
                else
                {
                    spControle.Close();
                    btConnect.Text = "OPEN";
                }
            }
            catch 
            { 
            
            }
        
        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            string comportsel = "COM39";
            comportsel = cbComPorts.Text;
            connect_desconnect(comportsel);
        }

        private void cbComPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            string comportsel = cbComPorts.Text;
            btConnect.Enabled = true;
        }

        private void tmTXdata_Tick(object sender, EventArgs e)
        {
            var instance = new frmIni();

            int p = instance.ler_delta(0);


            if (testeM2000PE)
            {
                //M2000PE
                Boolean flagtx = false;
                byte[] txdata = { 3, 0 };
                if (spControle.IsOpen)
                {
                    while (spControle.BytesToRead > 0)
                    {
                        int ntemp = spControle.ReadByte();
                        ValidaBloco(ntemp);
                        //spControle.Write(txdata, 0, 1);
                        //buffeRX[contabuffeRX++] = ntemp;
                        //dadoRX = dadoRX + " " + ntemp.ToString("X2");
                        flagtx = true;
                    }

                    if (flagtx == true)
                    {
                        spControle.Write(txdata, 0, 1);
                        //contabuffeRX = 0;
                        textBox1.Text = dadoRX;
                    }


                }
            }

            else 
            {
                if (spControle.IsOpen)
                {
                    //string s = Encoding.ASCII.GetString(new byte[] { 65 });
                    string rxdadotemp = "";
                    while (spControle.BytesToRead > 0)
                            {
                                leitura = spControle.ReadByte();
                                rxdadotemp = rxdadotemp + Encoding.ASCII.GetString(new byte[] { (byte)leitura });                       
                                ValidaBlocoEntrada(leitura);
                                if (leitura == 13) 
                                    {
                                        textBox1.Text = rxdadotemp + textBox1.Text;
                                        rxdadotemp = "";
                                    }
                            }
                }                      
            }
        }

        /*DADOS PARA LEITURA A RS232*/
        int leitura;
        public byte[] rxbufferrx = new byte[1024];
  
        public char[] posAtuadorRXchar = new char[64];       
        public int[] posAtuadorRX = new int[6];
        public int[] posAtuadorRXmin = new int[6];
        public int[] posAtuadorRXzero = new int[6];
        public int[] posAtuadorRXmax = new int[6];

        int maquina_de_estado_rs232;
        int conta_rxbloc;
        int noAtuadoresChar;
        private void ValidaBlocoEntrada(int incomingByte)
        {

            switch (maquina_de_estado_rs232)
            {

                case 0:
                    if (incomingByte == 'I')
                    {//MIN VALUE
                        //Serial.print("A" ); 
                        maquina_de_estado_rs232 = 2;
                        conta_rxbloc = 0;
                        noAtuadoresChar = 18;
                    }
                    else if (incomingByte == 'Z')
                    {//ZERO VALUE
                        //Serial.print("A" ); 
                        maquina_de_estado_rs232 = 3;
                        conta_rxbloc = 0;
                        noAtuadoresChar = 18;
                    }
                    else if (incomingByte == 'X')
                    {//MAX VALUE
                        //Serial.print("A" ); 
                        maquina_de_estado_rs232 = 4;
                        conta_rxbloc = 0;
                        noAtuadoresChar = 18;
                    }
                    else if (incomingByte == 'B')
                    {
                        maquina_de_estado_rs232 = 1;
                        conta_rxbloc = 0;
                        noAtuadoresChar = 18;
                    }
/*
                    else if (incomingByte == 'V')
                    {
                        maquina_de_estado_rs232 = 1;
                        conta_rxbloc = 0;
                        noAtuadoresChar = 2;
                    }
*/
                    else
                    {
                        maquina_de_estado_rs232 = 0;
                    }

                    break;

                case 1:
                case 2:
                case 3:
                case 4:
                    if (conta_rxbloc == noAtuadoresChar)
                    {


                        if (maquina_de_estado_rs232 == 1)
                        {
                            posAtuadorRX[0] = ((posAtuadorRXchar[0] - 48) * 100) + ((posAtuadorRXchar[1] - 48) * 10) + (posAtuadorRXchar[2] - 48);
                            posAtuadorRX[1] = ((posAtuadorRXchar[0 + 3] - 48) * 100) + ((posAtuadorRXchar[1 + 3] - 48) * 10) + (posAtuadorRXchar[2 + 3] - 48);
                            posAtuadorRX[2] = ((posAtuadorRXchar[0 + 6] - 48) * 100) + ((posAtuadorRXchar[1 + 6] - 48) * 10) + (posAtuadorRXchar[2 + 6] - 48);
                            posAtuadorRX[3] = ((posAtuadorRXchar[0 + 9] - 48) * 100) + ((posAtuadorRXchar[1 + 9] - 48) * 10) + (posAtuadorRXchar[2 + 9] - 48);
                            posAtuadorRX[4] = ((posAtuadorRXchar[0 + 12] - 48) * 100) + ((posAtuadorRXchar[1 + 12] - 48) * 10) + (posAtuadorRXchar[2 + 12] - 48);
                            posAtuadorRX[5] = ((posAtuadorRXchar[0 + 15] - 48) * 100) + ((posAtuadorRXchar[1 + 15] - 48) * 10) + (posAtuadorRXchar[2 + 15] - 48);

                        }

                        if (maquina_de_estado_rs232 == 2)
                        {
                            posAtuadorRXmin[0] = ((posAtuadorRXchar[0] - 48) * 100) + ((posAtuadorRXchar[1] - 48) * 10) + (posAtuadorRXchar[2] - 48);
                            posAtuadorRXmin[1] = ((posAtuadorRXchar[0 + 3] - 48) * 100) + ((posAtuadorRXchar[1 + 3] - 48) * 10) + (posAtuadorRXchar[2 + 3] - 48);
                            posAtuadorRXmin[2] = ((posAtuadorRXchar[0 + 6] - 48) * 100) + ((posAtuadorRXchar[1 + 6] - 48) * 10) + (posAtuadorRXchar[2 + 6] - 48);
                            posAtuadorRXmin[3] = ((posAtuadorRXchar[0 + 9] - 48) * 100) + ((posAtuadorRXchar[1 + 9] - 48) * 10) + (posAtuadorRXchar[2 + 9] - 48);
                            posAtuadorRXmin[4] = ((posAtuadorRXchar[0 + 12] - 48) * 100) + ((posAtuadorRXchar[1 + 12] - 48) * 10) + (posAtuadorRXchar[2 + 12] - 48);
                            posAtuadorRXmin[5] = ((posAtuadorRXchar[0 + 15] - 48) * 100) + ((posAtuadorRXchar[1 + 15] - 48) * 10) + (posAtuadorRXchar[2 + 15] - 48);
                            if (checkBox1.Checked)
                            {
                                txtMin1.Text = posAtuadorRXmin[0].ToString("000");
                                txtMin2.Text = posAtuadorRXmin[1].ToString("000");
                                txtMin3.Text = posAtuadorRXmin[2].ToString("000");
                                txtMin4.Text = posAtuadorRXmin[3].ToString("000");
                                txtMin5.Text = posAtuadorRXmin[4].ToString("000");
                                txtMin6.Text = posAtuadorRXmin[5].ToString("000");
                            }
                        }

                        if (maquina_de_estado_rs232 == 3)
                        {
                            posAtuadorRXzero[0] = ((posAtuadorRXchar[0] - 48) * 100) + ((posAtuadorRXchar[1] - 48) * 10) + (posAtuadorRXchar[2] - 48);
                            posAtuadorRXzero[1] = ((posAtuadorRXchar[0 + 3] - 48) * 100) + ((posAtuadorRXchar[1 + 3] - 48) * 10) + (posAtuadorRXchar[2 + 3] - 48);
                            posAtuadorRXzero[2] = ((posAtuadorRXchar[0 + 6] - 48) * 100) + ((posAtuadorRXchar[1 + 6] - 48) * 10) + (posAtuadorRXchar[2 + 6] - 48);
                            posAtuadorRXzero[3] = ((posAtuadorRXchar[0 + 9] - 48) * 100) + ((posAtuadorRXchar[1 + 9] - 48) * 10) + (posAtuadorRXchar[2 + 9] - 48);
                            posAtuadorRXzero[4] = ((posAtuadorRXchar[0 + 12] - 48) * 100) + ((posAtuadorRXchar[1 + 12] - 48) * 10) + (posAtuadorRXchar[2 + 12] - 48);
                            posAtuadorRXzero[5] = ((posAtuadorRXchar[0 + 15] - 48) * 100) + ((posAtuadorRXchar[1 + 15] - 48) * 10) + (posAtuadorRXchar[2 + 15] - 48);

                            if (checkBox1.Checked)
                            {
                                txtZero1.Text = posAtuadorRXzero[0].ToString("000");
                                txtZero2.Text = posAtuadorRXzero[1].ToString("000");
                                txtZero3.Text = posAtuadorRXzero[2].ToString("000");
                                txtZero4.Text = posAtuadorRXzero[3].ToString("000");
                                txtZero5.Text = posAtuadorRXzero[4].ToString("000");
                                txtZero6.Text = posAtuadorRXzero[5].ToString("000");
                            }
                        }

                        if (maquina_de_estado_rs232 == 4)
                        {
                            posAtuadorRXmax[0] = ((posAtuadorRXchar[0] - 48) * 100) + ((posAtuadorRXchar[1] - 48) * 10) + (posAtuadorRXchar[2] - 48);
                            posAtuadorRXmax[1] = ((posAtuadorRXchar[0 + 3] - 48) * 100) + ((posAtuadorRXchar[1 + 3] - 48) * 10) + (posAtuadorRXchar[2 + 3] - 48);
                            posAtuadorRXmax[2] = ((posAtuadorRXchar[0 + 6] - 48) * 100) + ((posAtuadorRXchar[1 + 6] - 48) * 10) + (posAtuadorRXchar[2 + 6] - 48);
                            posAtuadorRXmax[3] = ((posAtuadorRXchar[0 + 9] - 48) * 100) + ((posAtuadorRXchar[1 + 9] - 48) * 10) + (posAtuadorRXchar[2 + 9] - 48);
                            posAtuadorRXmax[4] = ((posAtuadorRXchar[0 + 12] - 48) * 100) + ((posAtuadorRXchar[1 + 12] - 48) * 10) + (posAtuadorRXchar[2 + 12] - 48);
                            posAtuadorRXmax[5] = ((posAtuadorRXchar[0 + 15] - 48) * 100) + ((posAtuadorRXchar[1 + 15] - 48) * 10) + (posAtuadorRXchar[2 + 15] - 48);

                            if (checkBox1.Checked)
                            {
                                txtMax1.Text = posAtuadorRXmax[0].ToString("000");
                                txtMax2.Text = posAtuadorRXmax[1].ToString("000");
                                txtMax3.Text = posAtuadorRXmax[2].ToString("000");
                                txtMax4.Text = posAtuadorRXmax[3].ToString("000");
                                txtMax5.Text = posAtuadorRXmax[4].ToString("000");
                                txtMax6.Text = posAtuadorRXmax[5].ToString("000");
                            }
                        }

                        if (maquina_de_estado_rs232 == 1)
                        {

                        }
                        else
                        {
                            //salva_dados_EEPROM();
                        }

                        maquina_de_estado_rs232 = 0;

                        //tx_on = 1;
                    }
                    else
                    {
                        if (incomingByte >= '0' && incomingByte <= '9')
                        {
                            posAtuadorRXchar[conta_rxbloc] = (char)(incomingByte);
                        }
                        else
                        {
                            posAtuadorRXchar[conta_rxbloc] = ' ';
                        }
                        conta_rxbloc++;

                    }

                    break;

                case 5:
                    break;

                case 6:
                    break;

                default:
                    break;

            }


        }

        private void ValidaBloco(int dadoentrada)
        {
            byte[] txdata = { 3, 0 };

            switch (passoatual) 
            { 
                    case 0:                   
                    if(dadoentrada == 0x7F)
                        passoatual = 1;
                    
                    contapasso1 = 0;
                    
                    //spControle.Write(txdata, 0, 1);                 
                    break;

                    case 1:
                    contapasso1++;

                    if (contapasso1 >= 4)
                    {
                        passoatual = 2;
                        dadoRX = "";
                    }

                    //spControle.Write(txdata, 0, 1);                   
                    break;

                    case 2:
                    if (dadoentrada == 0x09)
                    {
                            passoatual = 3;
                    }
                    else
                    {
                            passoatual = 0;
                    }
                    contapasso1 = 0;
                    //spControle.Write(txdata, 0, 1);
                    break;

                    case 3:
                    noBadge[contapasso1] = dadoentrada;
                    contapasso1++;

                    if (contapasso1 >= 5)
                    {
                        passoatual = 4;

                        /*
                        string textNum = " 0x" + noBadge[0].ToString("X2") + noBadge[1].ToString("X2") + noBadge[2].ToString("X2") +
                                                    noBadge[3].ToString("X2") + noBadge[4].ToString("X2") + Environment.NewLine;
                        dadoRX = dadoRX + textNum;
                        */
                    }

                    //spControle.Write(txdata, 0, 1);
                    break;

                    case 4:
                    /*
                    if (dadoentrada == 0x06 )
                    {
                        passoatual = 2;
                    }
                    else
                    {
                        passoatual = 0;
                    }
                     * */
                    long numero_badge_long = (noBadge[1] << 16) + (noBadge[2] << 8) + (noBadge[3]);

                    string textNum = " 0x" + noBadge[0].ToString("X2") + noBadge[1].ToString("X2") + noBadge[2].ToString("X2") +
                            noBadge[3].ToString("X2") + " index " + dadoentrada.ToString("x2") + " Numero dec " + numero_badge_long.ToString() + Environment.NewLine;
                    

                    dadoRX = dadoRX + textNum;

                    passoatual = 2;
                    //spControle.Write(txdata, 0, 1);
                    contapasso1 = 0;
                    break;

                    default:
                    break;           
            
            
            }
        
        
        }

        private void timExtrapolacao_Tick(object sender, EventArgs e)
        {
            calcula_novo_valor();
        }

        private void btMin_Click(object sender, EventArgs e)
        {
            string txdata = "I" + formata6entradas(txtMin1.Text, txtMin2.Text, txtMin3.Text, txtMin4.Text, txtMin5.Text, txtMin6.Text) + Environment.NewLine; ;
            enviardata(txdata);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string txdata = "Z" + formata6entradas(txtZero1.Text, txtZero2.Text, txtZero3.Text, txtZero4.Text, txtZero5.Text, txtZero6.Text) + Environment.NewLine;
            enviardata(txdata);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string txdata = "X" + formata6entradas(txtMax1.Text, txtMax2.Text, txtMax3.Text, txtMax4.Text, txtMax5.Text, txtMax6.Text) + Environment.NewLine;
            enviardata(txdata);
        }

        private void txtMin1_Leave(object sender, EventArgs e)
        {

        }

        private string formata6entradas(string dado1, string dado2, string dado3, string dado4, string dado5, string dado6) 
        {
            while (dado1.Length < 3) dado1 = "0" + dado1;
            while (dado2.Length < 3) dado2 = "0" + dado2;
            while (dado3.Length < 3) dado3 = "0" + dado3;
            while (dado4.Length < 3) dado4 = "0" + dado4;
            while (dado5.Length < 3) dado5 = "0" + dado5;
            while (dado6.Length < 3) dado6 = "0" + dado6;


            return dado1   +  dado2   +  dado3   +  dado4   +  dado5   +  dado6;

        }

        private void vScrollBar7_Scroll(object sender, ScrollEventArgs e)
        {
            vScrollBar1.Value = vScrollBar7.Value;
            vScrollBar2.Value = vScrollBar7.Value;
            vScrollBar3.Value = vScrollBar7.Value;
            vScrollBar4.Value = vScrollBar7.Value;
            vScrollBar5.Value = vScrollBar7.Value;
            vScrollBar6.Value = vScrollBar7.Value;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            vScrollBar1.Value = 90;
            vScrollBar2.Value = 90;
            vScrollBar3.Value = 90;
            vScrollBar4.Value = 90;
            vScrollBar5.Value = 90;
            vScrollBar6.Value = 90;
            vScrollBar7.Value = 90;
        }

        private void vScrollBar1_Scroll_1(object sender, ScrollEventArgs e)
        {

        }

        private void timDisplayRefresh_Tick(object sender, EventArgs e)
       {    /*
            lblVal1.Text = "#1 " + vScrollBar1.Value.ToString("000");
            lblVal2.Text = "#2 " + vScrollBar2.Value.ToString("000");
            lblVal3.Text = "#3 " + vScrollBar3.Value.ToString("000");
            lblVal4.Text = "#4 " + vScrollBar4.Value.ToString("000");
            lblVal5.Text = "#5 " + vScrollBar5.Value.ToString("000");
            lblVal6.Text = "#6 " + vScrollBar6.Value.ToString("000");
            */
            lblVal1.Text = posAtuadorRX[0].ToString("000");
            lblVal2.Text = posAtuadorRX[1].ToString("000");
            lblVal3.Text = posAtuadorRX[2].ToString("000");
            lblVal4.Text = posAtuadorRX[3].ToString("000");
            lblVal5.Text = posAtuadorRX[4].ToString("000");
            lblVal6.Text = posAtuadorRX[5].ToString("000");
        }
        private void enviardataDIRECT(string dado) 
        {
                if (spControle.IsOpen)
                {
                            if(echoLocalOn)
                                textBox1.Text = dado + textBox1.Text;                                              
                            spControle.Write(dado);
                }
        
        }
        private void enviardata(string dado)
        {
            if (spControle.IsOpen)
            {
                if (arduinoTXdataOld != dado)
                {
                    arduinoTXdataOld = dado;

                    if (echoLocalOn)
                        textBox1.Text = dado + textBox1.Text;


                    spControle.Write(dado);
                }
            }

        }
        private void button4_Click(object sender, EventArgs e)
        {
            enviardata("B"+ Environment.NewLine);
        }

        private void vScrollBar6_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            oscilarOn = !oscilarOn;

            if (oscilarOn) 
            {
                button6.Text = "Oscilar ON";
                enviardata("O" + Environment.NewLine); }
            else 
            { 
                button6.Text = "Oscilar OFF";
                enviardata("o" + Environment.NewLine);
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            echoRemoteOn = !echoRemoteOn;
            if (echoRemoteOn)
            {
                button7.Text = "Echo Remote ON";
                enviardata("E" + Environment.NewLine);
            }
            else
            {
                button7.Text = "Echo Remote OFF";
                enviardata("e" + Environment.NewLine);
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            echoLocalOn = !echoLocalOn;
            if (echoLocalOn)
                button8.Text = "Echo Local ON";
            else
                button8.Text = "Echo Local OFF";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            enviardataDIRECT("V00" + Environment.NewLine);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            enviardata("V11" + Environment.NewLine);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            enviardata("V22" + Environment.NewLine);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            timControleAngulo.Enabled = true;

            frmIni frmTel = new frmIni();
            frmTel.ShowDialog();



        }

        private int limita_max_min(int valsortie)
        {
            if (valsortie > 180)
                valsortie = 180;

            if (valsortie < 1)
                valsortie = 1;

            return valsortie;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            var instance = new calculo_angulo();

            vScrollBar1.Value = instance.ler_sortie_canal(0);
            vScrollBar2.Value = instance.ler_sortie_canal(1);
            vScrollBar3.Value = instance.ler_sortie_canal(2);
            vScrollBar4.Value = instance.ler_sortie_canal(3);
            vScrollBar5.Value = instance.ler_sortie_canal(4);
            vScrollBar6.Value = instance.ler_sortie_canal(5);

            /*
            vScrollBar1.Value = limita_max_min(calculo_angulo.telecomm_pos_sortie_total[0] + calculo_angulo.ValStd);
            vScrollBar2.Value = limita_max_min(calculo_angulo.telecomm_pos_sortie_total[1] + calculo_angulo.ValStd);
            vScrollBar3.Value = limita_max_min(calculo_angulo.telecomm_pos_sortie_total[2] + calculo_angulo.ValStd);
            vScrollBar4.Value = limita_max_min(calculo_angulo.telecomm_pos_sortie_total[3] + calculo_angulo.ValStd);
            vScrollBar5.Value = limita_max_min(calculo_angulo.telecomm_pos_sortie_total[4] + calculo_angulo.ValStd);
            vScrollBar6.Value = limita_max_min(calculo_angulo.telecomm_pos_sortie_total[5] + calculo_angulo.ValStd);
            */
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
           
        }

        private void Form1_Enter(object sender, EventArgs e)
        {
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            timControleAngulo.Enabled = false;
        }
    }
}
