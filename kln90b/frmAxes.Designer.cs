namespace SERIAL_MONITOR
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tmTXdata = new System.Windows.Forms.Timer(this.components);
            this.spControle = new System.IO.Ports.SerialPort(this.components);
            this.cbComPorts = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btConnect = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timExtrapolacao = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMinMeio1 = new System.Windows.Forms.TextBox();
            this.txtMin1 = new System.Windows.Forms.TextBox();
            this.txtMax1 = new System.Windows.Forms.TextBox();
            this.txtMaxMeio1 = new System.Windows.Forms.TextBox();
            this.txtZero1 = new System.Windows.Forms.TextBox();
            this.lblVal1 = new System.Windows.Forms.Label();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtMin2 = new System.Windows.Forms.TextBox();
            this.txtMax2 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.txtZero2 = new System.Windows.Forms.TextBox();
            this.lblVal2 = new System.Windows.Forms.Label();
            this.vScrollBar2 = new System.Windows.Forms.VScrollBar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.txtMin3 = new System.Windows.Forms.TextBox();
            this.txtMax3 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.txtZero3 = new System.Windows.Forms.TextBox();
            this.lblVal3 = new System.Windows.Forms.Label();
            this.vScrollBar3 = new System.Windows.Forms.VScrollBar();
            this.panel4 = new System.Windows.Forms.Panel();
            this.vScrollBar6 = new System.Windows.Forms.VScrollBar();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.txtMin6 = new System.Windows.Forms.TextBox();
            this.txtMax6 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.txtZero6 = new System.Windows.Forms.TextBox();
            this.lblVal6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.txtMin5 = new System.Windows.Forms.TextBox();
            this.txtMax5 = new System.Windows.Forms.TextBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.txtZero5 = new System.Windows.Forms.TextBox();
            this.lblVal5 = new System.Windows.Forms.Label();
            this.vScrollBar5 = new System.Windows.Forms.VScrollBar();
            this.panel6 = new System.Windows.Forms.Panel();
            this.vScrollBar4 = new System.Windows.Forms.VScrollBar();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.txtMin4 = new System.Windows.Forms.TextBox();
            this.txtMax4 = new System.Windows.Forms.TextBox();
            this.textBox25 = new System.Windows.Forms.TextBox();
            this.txtZero4 = new System.Windows.Forms.TextBox();
            this.lblVal4 = new System.Windows.Forms.Label();
            this.btMin = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.vScrollBar7 = new System.Windows.Forms.VScrollBar();
            this.timDisplayRefresh = new System.Windows.Forms.Timer(this.components);
            this.button4 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.timControleAngulo = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmTXdata
            // 
            this.tmTXdata.Enabled = true;
            this.tmTXdata.Tick += new System.EventHandler(this.tmTXdata_Tick);
            // 
            // spControle
            // 
            this.spControle.BaudRate = 115200;
            // 
            // cbComPorts
            // 
            this.cbComPorts.FormattingEnabled = true;
            this.cbComPorts.Location = new System.Drawing.Point(777, 54);
            this.cbComPorts.Name = "cbComPorts";
            this.cbComPorts.Size = new System.Drawing.Size(133, 21);
            this.cbComPorts.TabIndex = 2;
            this.cbComPorts.SelectedIndexChanged += new System.EventHandler(this.cbComPorts_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(774, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "COM PORT";
            // 
            // btConnect
            // 
            this.btConnect.Enabled = false;
            this.btConnect.Location = new System.Drawing.Point(777, 87);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(118, 26);
            this.btConnect.TabIndex = 4;
            this.btConnect.Text = "CONNECT";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(637, 183);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(375, 210);
            this.textBox1.TabIndex = 5;
            // 
            // timExtrapolacao
            // 
            this.timExtrapolacao.Enabled = true;
            this.timExtrapolacao.Interval = 20;
            this.timExtrapolacao.Tick += new System.EventHandler(this.timExtrapolacao_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtMinMeio1);
            this.panel1.Controls.Add(this.txtMin1);
            this.panel1.Controls.Add(this.txtMax1);
            this.panel1.Controls.Add(this.txtMaxMeio1);
            this.panel1.Controls.Add(this.txtZero1);
            this.panel1.Controls.Add(this.lblVal1);
            this.panel1.Controls.Add(this.vScrollBar1);
            this.panel1.Location = new System.Drawing.Point(32, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(71, 407);
            this.panel1.TabIndex = 12;
            // 
            // txtMinMeio1
            // 
            this.txtMinMeio1.Location = new System.Drawing.Point(9, 293);
            this.txtMinMeio1.Name = "txtMinMeio1";
            this.txtMinMeio1.Size = new System.Drawing.Size(52, 20);
            this.txtMinMeio1.TabIndex = 18;
            this.txtMinMeio1.Text = "045045";
            this.txtMinMeio1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMinMeio1.Visible = false;
            // 
            // txtMin1
            // 
            this.txtMin1.Location = new System.Drawing.Point(9, 267);
            this.txtMin1.Name = "txtMin1";
            this.txtMin1.Size = new System.Drawing.Size(52, 20);
            this.txtMin1.TabIndex = 17;
            this.txtMin1.Text = "000";
            this.txtMin1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMin1.Leave += new System.EventHandler(this.txtMin1_Leave);
            // 
            // txtMax1
            // 
            this.txtMax1.Location = new System.Drawing.Point(9, 371);
            this.txtMax1.Name = "txtMax1";
            this.txtMax1.Size = new System.Drawing.Size(52, 20);
            this.txtMax1.TabIndex = 16;
            this.txtMax1.Text = "180";
            this.txtMax1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMaxMeio1
            // 
            this.txtMaxMeio1.Location = new System.Drawing.Point(9, 345);
            this.txtMaxMeio1.Name = "txtMaxMeio1";
            this.txtMaxMeio1.Size = new System.Drawing.Size(52, 20);
            this.txtMaxMeio1.TabIndex = 15;
            this.txtMaxMeio1.Text = "135";
            this.txtMaxMeio1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMaxMeio1.Visible = false;
            // 
            // txtZero1
            // 
            this.txtZero1.Location = new System.Drawing.Point(9, 319);
            this.txtZero1.Name = "txtZero1";
            this.txtZero1.Size = new System.Drawing.Size(52, 20);
            this.txtZero1.TabIndex = 14;
            this.txtZero1.Text = "090";
            this.txtZero1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblVal1
            // 
            this.lblVal1.AutoSize = true;
            this.lblVal1.Location = new System.Drawing.Point(28, 16);
            this.lblVal1.Name = "lblVal1";
            this.lblVal1.Size = new System.Drawing.Size(13, 13);
            this.lblVal1.TabIndex = 13;
            this.lblVal1.Text = "1";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.LargeChange = 1;
            this.vScrollBar1.Location = new System.Drawing.Point(9, 49);
            this.vScrollBar1.Maximum = 180;
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(52, 203);
            this.vScrollBar1.TabIndex = 12;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll_1);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.txtMin2);
            this.panel2.Controls.Add(this.txtMax2);
            this.panel2.Controls.Add(this.textBox5);
            this.panel2.Controls.Add(this.txtZero2);
            this.panel2.Controls.Add(this.lblVal2);
            this.panel2.Controls.Add(this.vScrollBar2);
            this.panel2.Location = new System.Drawing.Point(109, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(71, 407);
            this.panel2.TabIndex = 19;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(9, 293);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(52, 20);
            this.textBox2.TabIndex = 18;
            this.textBox2.Text = "045045";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.Visible = false;
            // 
            // txtMin2
            // 
            this.txtMin2.Location = new System.Drawing.Point(9, 267);
            this.txtMin2.Name = "txtMin2";
            this.txtMin2.Size = new System.Drawing.Size(52, 20);
            this.txtMin2.TabIndex = 17;
            this.txtMin2.Text = "000";
            this.txtMin2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMax2
            // 
            this.txtMax2.Location = new System.Drawing.Point(9, 371);
            this.txtMax2.Name = "txtMax2";
            this.txtMax2.Size = new System.Drawing.Size(52, 20);
            this.txtMax2.TabIndex = 16;
            this.txtMax2.Text = "180";
            this.txtMax2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(9, 345);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(52, 20);
            this.textBox5.TabIndex = 15;
            this.textBox5.Text = "135";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox5.Visible = false;
            // 
            // txtZero2
            // 
            this.txtZero2.Location = new System.Drawing.Point(9, 319);
            this.txtZero2.Name = "txtZero2";
            this.txtZero2.Size = new System.Drawing.Size(52, 20);
            this.txtZero2.TabIndex = 14;
            this.txtZero2.Text = "090";
            this.txtZero2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblVal2
            // 
            this.lblVal2.AutoSize = true;
            this.lblVal2.Location = new System.Drawing.Point(28, 16);
            this.lblVal2.Name = "lblVal2";
            this.lblVal2.Size = new System.Drawing.Size(13, 13);
            this.lblVal2.TabIndex = 13;
            this.lblVal2.Text = "2";
            // 
            // vScrollBar2
            // 
            this.vScrollBar2.LargeChange = 1;
            this.vScrollBar2.Location = new System.Drawing.Point(9, 49);
            this.vScrollBar2.Maximum = 180;
            this.vScrollBar2.Name = "vScrollBar2";
            this.vScrollBar2.Size = new System.Drawing.Size(52, 203);
            this.vScrollBar2.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBox7);
            this.panel3.Controls.Add(this.txtMin3);
            this.panel3.Controls.Add(this.txtMax3);
            this.panel3.Controls.Add(this.textBox10);
            this.panel3.Controls.Add(this.txtZero3);
            this.panel3.Controls.Add(this.lblVal3);
            this.panel3.Controls.Add(this.vScrollBar3);
            this.panel3.Location = new System.Drawing.Point(186, 48);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(71, 407);
            this.panel3.TabIndex = 20;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(9, 293);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(52, 20);
            this.textBox7.TabIndex = 18;
            this.textBox7.Text = "045045";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox7.Visible = false;
            // 
            // txtMin3
            // 
            this.txtMin3.Location = new System.Drawing.Point(9, 267);
            this.txtMin3.Name = "txtMin3";
            this.txtMin3.Size = new System.Drawing.Size(52, 20);
            this.txtMin3.TabIndex = 17;
            this.txtMin3.Text = "000";
            this.txtMin3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMax3
            // 
            this.txtMax3.Location = new System.Drawing.Point(9, 371);
            this.txtMax3.Name = "txtMax3";
            this.txtMax3.Size = new System.Drawing.Size(52, 20);
            this.txtMax3.TabIndex = 16;
            this.txtMax3.Text = "180";
            this.txtMax3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(9, 345);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(52, 20);
            this.textBox10.TabIndex = 15;
            this.textBox10.Text = "135";
            this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox10.Visible = false;
            // 
            // txtZero3
            // 
            this.txtZero3.Location = new System.Drawing.Point(9, 319);
            this.txtZero3.Name = "txtZero3";
            this.txtZero3.Size = new System.Drawing.Size(52, 20);
            this.txtZero3.TabIndex = 14;
            this.txtZero3.Text = "090";
            this.txtZero3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblVal3
            // 
            this.lblVal3.AutoSize = true;
            this.lblVal3.Location = new System.Drawing.Point(28, 16);
            this.lblVal3.Name = "lblVal3";
            this.lblVal3.Size = new System.Drawing.Size(13, 13);
            this.lblVal3.TabIndex = 13;
            this.lblVal3.Text = "3";
            // 
            // vScrollBar3
            // 
            this.vScrollBar3.LargeChange = 1;
            this.vScrollBar3.Location = new System.Drawing.Point(9, 49);
            this.vScrollBar3.Maximum = 180;
            this.vScrollBar3.Name = "vScrollBar3";
            this.vScrollBar3.Size = new System.Drawing.Size(52, 203);
            this.vScrollBar3.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.vScrollBar6);
            this.panel4.Controls.Add(this.textBox12);
            this.panel4.Controls.Add(this.txtMin6);
            this.panel4.Controls.Add(this.txtMax6);
            this.panel4.Controls.Add(this.textBox15);
            this.panel4.Controls.Add(this.txtZero6);
            this.panel4.Controls.Add(this.lblVal6);
            this.panel4.Location = new System.Drawing.Point(417, 48);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(71, 407);
            this.panel4.TabIndex = 23;
            // 
            // vScrollBar6
            // 
            this.vScrollBar6.LargeChange = 1;
            this.vScrollBar6.Location = new System.Drawing.Point(9, 49);
            this.vScrollBar6.Maximum = 180;
            this.vScrollBar6.Name = "vScrollBar6";
            this.vScrollBar6.Size = new System.Drawing.Size(52, 203);
            this.vScrollBar6.TabIndex = 19;
            this.vScrollBar6.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar6_Scroll);
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(9, 293);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(52, 20);
            this.textBox12.TabIndex = 18;
            this.textBox12.Text = "045045";
            this.textBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox12.Visible = false;
            // 
            // txtMin6
            // 
            this.txtMin6.Location = new System.Drawing.Point(9, 267);
            this.txtMin6.Name = "txtMin6";
            this.txtMin6.Size = new System.Drawing.Size(52, 20);
            this.txtMin6.TabIndex = 17;
            this.txtMin6.Text = "000";
            this.txtMin6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMax6
            // 
            this.txtMax6.Location = new System.Drawing.Point(9, 371);
            this.txtMax6.Name = "txtMax6";
            this.txtMax6.Size = new System.Drawing.Size(52, 20);
            this.txtMax6.TabIndex = 16;
            this.txtMax6.Text = "180";
            this.txtMax6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(9, 345);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(52, 20);
            this.textBox15.TabIndex = 15;
            this.textBox15.Text = "135";
            this.textBox15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox15.Visible = false;
            // 
            // txtZero6
            // 
            this.txtZero6.Location = new System.Drawing.Point(9, 319);
            this.txtZero6.Name = "txtZero6";
            this.txtZero6.Size = new System.Drawing.Size(52, 20);
            this.txtZero6.TabIndex = 14;
            this.txtZero6.Text = "090";
            this.txtZero6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblVal6
            // 
            this.lblVal6.AutoSize = true;
            this.lblVal6.Location = new System.Drawing.Point(28, 16);
            this.lblVal6.Name = "lblVal6";
            this.lblVal6.Size = new System.Drawing.Size(13, 13);
            this.lblVal6.TabIndex = 13;
            this.lblVal6.Text = "6";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.textBox17);
            this.panel5.Controls.Add(this.txtMin5);
            this.panel5.Controls.Add(this.txtMax5);
            this.panel5.Controls.Add(this.textBox20);
            this.panel5.Controls.Add(this.txtZero5);
            this.panel5.Controls.Add(this.lblVal5);
            this.panel5.Controls.Add(this.vScrollBar5);
            this.panel5.Location = new System.Drawing.Point(340, 48);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(71, 407);
            this.panel5.TabIndex = 22;
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(9, 293);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(52, 20);
            this.textBox17.TabIndex = 18;
            this.textBox17.Text = "045045";
            this.textBox17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox17.Visible = false;
            // 
            // txtMin5
            // 
            this.txtMin5.Location = new System.Drawing.Point(9, 267);
            this.txtMin5.Name = "txtMin5";
            this.txtMin5.Size = new System.Drawing.Size(52, 20);
            this.txtMin5.TabIndex = 17;
            this.txtMin5.Text = "000";
            this.txtMin5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMax5
            // 
            this.txtMax5.Location = new System.Drawing.Point(9, 371);
            this.txtMax5.Name = "txtMax5";
            this.txtMax5.Size = new System.Drawing.Size(52, 20);
            this.txtMax5.TabIndex = 16;
            this.txtMax5.Text = "180";
            this.txtMax5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox20
            // 
            this.textBox20.Location = new System.Drawing.Point(9, 345);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(52, 20);
            this.textBox20.TabIndex = 15;
            this.textBox20.Text = "135";
            this.textBox20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox20.Visible = false;
            // 
            // txtZero5
            // 
            this.txtZero5.Location = new System.Drawing.Point(9, 319);
            this.txtZero5.Name = "txtZero5";
            this.txtZero5.Size = new System.Drawing.Size(52, 20);
            this.txtZero5.TabIndex = 14;
            this.txtZero5.Text = "090";
            this.txtZero5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblVal5
            // 
            this.lblVal5.AutoSize = true;
            this.lblVal5.Location = new System.Drawing.Point(28, 16);
            this.lblVal5.Name = "lblVal5";
            this.lblVal5.Size = new System.Drawing.Size(13, 13);
            this.lblVal5.TabIndex = 13;
            this.lblVal5.Text = "5";
            // 
            // vScrollBar5
            // 
            this.vScrollBar5.LargeChange = 1;
            this.vScrollBar5.Location = new System.Drawing.Point(9, 49);
            this.vScrollBar5.Maximum = 180;
            this.vScrollBar5.Name = "vScrollBar5";
            this.vScrollBar5.Size = new System.Drawing.Size(52, 203);
            this.vScrollBar5.TabIndex = 12;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.vScrollBar4);
            this.panel6.Controls.Add(this.textBox22);
            this.panel6.Controls.Add(this.txtMin4);
            this.panel6.Controls.Add(this.txtMax4);
            this.panel6.Controls.Add(this.textBox25);
            this.panel6.Controls.Add(this.txtZero4);
            this.panel6.Controls.Add(this.lblVal4);
            this.panel6.Location = new System.Drawing.Point(263, 48);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(71, 407);
            this.panel6.TabIndex = 21;
            // 
            // vScrollBar4
            // 
            this.vScrollBar4.LargeChange = 1;
            this.vScrollBar4.Location = new System.Drawing.Point(9, 49);
            this.vScrollBar4.Maximum = 180;
            this.vScrollBar4.Name = "vScrollBar4";
            this.vScrollBar4.Size = new System.Drawing.Size(52, 203);
            this.vScrollBar4.TabIndex = 19;
            // 
            // textBox22
            // 
            this.textBox22.Location = new System.Drawing.Point(9, 293);
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(52, 20);
            this.textBox22.TabIndex = 18;
            this.textBox22.Text = "045045";
            this.textBox22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox22.Visible = false;
            // 
            // txtMin4
            // 
            this.txtMin4.Location = new System.Drawing.Point(9, 267);
            this.txtMin4.Name = "txtMin4";
            this.txtMin4.Size = new System.Drawing.Size(52, 20);
            this.txtMin4.TabIndex = 17;
            this.txtMin4.Text = "000";
            this.txtMin4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMax4
            // 
            this.txtMax4.Location = new System.Drawing.Point(9, 371);
            this.txtMax4.Name = "txtMax4";
            this.txtMax4.Size = new System.Drawing.Size(52, 20);
            this.txtMax4.TabIndex = 16;
            this.txtMax4.Text = "180";
            this.txtMax4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox25
            // 
            this.textBox25.Location = new System.Drawing.Point(9, 345);
            this.textBox25.Name = "textBox25";
            this.textBox25.Size = new System.Drawing.Size(52, 20);
            this.textBox25.TabIndex = 15;
            this.textBox25.Text = "135";
            this.textBox25.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox25.Visible = false;
            // 
            // txtZero4
            // 
            this.txtZero4.Location = new System.Drawing.Point(9, 319);
            this.txtZero4.Name = "txtZero4";
            this.txtZero4.Size = new System.Drawing.Size(52, 20);
            this.txtZero4.TabIndex = 14;
            this.txtZero4.Text = "090";
            this.txtZero4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblVal4
            // 
            this.lblVal4.AutoSize = true;
            this.lblVal4.Location = new System.Drawing.Point(28, 16);
            this.lblVal4.Name = "lblVal4";
            this.lblVal4.Size = new System.Drawing.Size(13, 13);
            this.lblVal4.TabIndex = 13;
            this.lblVal4.Text = "4";
            // 
            // btMin
            // 
            this.btMin.Location = new System.Drawing.Point(494, 315);
            this.btMin.Name = "btMin";
            this.btMin.Size = new System.Drawing.Size(44, 26);
            this.btMin.TabIndex = 24;
            this.btMin.Text = "Min";
            this.btMin.UseVisualStyleBackColor = true;
            this.btMin.Click += new System.EventHandler(this.btMin_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(494, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 26);
            this.button1.TabIndex = 25;
            this.button1.Text = "Zero";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(494, 419);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(44, 26);
            this.button2.TabIndex = 26;
            this.button2.Text = "Max";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(549, 195);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(44, 26);
            this.button3.TabIndex = 27;
            this.button3.Text = "Set";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // vScrollBar7
            // 
            this.vScrollBar7.LargeChange = 1;
            this.vScrollBar7.Location = new System.Drawing.Point(494, 97);
            this.vScrollBar7.Maximum = 180;
            this.vScrollBar7.Name = "vScrollBar7";
            this.vScrollBar7.Size = new System.Drawing.Size(52, 203);
            this.vScrollBar7.TabIndex = 28;
            this.vScrollBar7.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar7_Scroll);
            // 
            // timDisplayRefresh
            // 
            this.timDisplayRefresh.Enabled = true;
            this.timDisplayRefresh.Interval = 500;
            this.timDisplayRefresh.Tick += new System.EventHandler(this.timDisplayRefresh_Tick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(637, 151);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(118, 26);
            this.button4.TabIndex = 29;
            this.button4.Text = "Read";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(765, 157);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(119, 17);
            this.checkBox1.TabIndex = 30;
            this.checkBox1.Text = "Atualiza Parametros";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(777, 119);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(118, 26);
            this.button5.TabIndex = 31;
            this.button5.Text = "Clear";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(637, 119);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(118, 26);
            this.button6.TabIndex = 32;
            this.button6.Text = "Oscilar";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(637, 87);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(118, 26);
            this.button7.TabIndex = 33;
            this.button7.Text = "Resposta RS232";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(637, 55);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(118, 26);
            this.button8.TabIndex = 34;
            this.button8.Text = "Echo Local";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(910, 81);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(71, 26);
            this.button9.TabIndex = 35;
            this.button9.Text = "V0";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(910, 145);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(71, 26);
            this.button10.TabIndex = 36;
            this.button10.Text = "V2";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(910, 113);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(71, 26);
            this.button11.TabIndex = 37;
            this.button11.Text = "V1";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(637, 415);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(118, 26);
            this.button12.TabIndex = 38;
            this.button12.Text = "Angles";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // timControleAngulo
            // 
            this.timControleAngulo.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 523);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.vScrollBar7);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btMin);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btConnect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbComPorts);
            this.Name = "Form1";
            this.Text = "SERIAL PORT";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.Enter += new System.EventHandler(this.Form1_Enter);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmTXdata;
        private System.IO.Ports.SerialPort spControle;
        private System.Windows.Forms.ComboBox cbComPorts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timExtrapolacao;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtMinMeio1;
        private System.Windows.Forms.TextBox txtMin1;
        private System.Windows.Forms.TextBox txtMax1;
        private System.Windows.Forms.TextBox txtMaxMeio1;
        private System.Windows.Forms.TextBox txtZero1;
        private System.Windows.Forms.Label lblVal1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtMin2;
        private System.Windows.Forms.TextBox txtMax2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox txtZero2;
        private System.Windows.Forms.Label lblVal2;
        private System.Windows.Forms.VScrollBar vScrollBar2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox txtMin3;
        private System.Windows.Forms.TextBox txtMax3;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox txtZero3;
        private System.Windows.Forms.Label lblVal3;
        private System.Windows.Forms.VScrollBar vScrollBar3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox txtMin6;
        private System.Windows.Forms.TextBox txtMax6;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox txtZero6;
        private System.Windows.Forms.Label lblVal6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox txtMin5;
        private System.Windows.Forms.TextBox txtMax5;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.TextBox txtZero5;
        private System.Windows.Forms.Label lblVal5;
        private System.Windows.Forms.VScrollBar vScrollBar5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox textBox22;
        private System.Windows.Forms.TextBox txtMin4;
        private System.Windows.Forms.TextBox txtMax4;
        private System.Windows.Forms.TextBox textBox25;
        private System.Windows.Forms.TextBox txtZero4;
        private System.Windows.Forms.Label lblVal4;
        private System.Windows.Forms.Button btMin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.VScrollBar vScrollBar6;
        private System.Windows.Forms.VScrollBar vScrollBar4;
        private System.Windows.Forms.VScrollBar vScrollBar7;
        private System.Windows.Forms.Timer timDisplayRefresh;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Timer timControleAngulo;
    }
}

