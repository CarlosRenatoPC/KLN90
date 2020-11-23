using SERIAL_HEXAPOD_MONITOR;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SERIAL_MONITOR
{
    public partial class frmIni : Form
    {
        /*
        int nomin = -90;
        int nomed = 0;
        int nomax = 90;
        */


        public frmIni()
        {
            InitializeComponent();
        }


        public int ler_delta(int index)
        {
            //var instance = new calculo_angulo();

            return calculo_angulo.telecomm_pos_sortie_total[index];
        }

        private void show_channel(int channeltype)
        {
            //var instance = new calculo_angulo();

            txtValMax0.Text = calculo_angulo.telecomm_pmax[(6 * channeltype) + 0].ToString();
            txtValMax1.Text = calculo_angulo.telecomm_pmax[(6 * channeltype) + 1].ToString();
            txtValMax2.Text = calculo_angulo.telecomm_pmax[(6 * channeltype) + 2].ToString();
            txtValMax3.Text = calculo_angulo.telecomm_pmax[(6 * channeltype) + 3].ToString();
            txtValMax4.Text = calculo_angulo.telecomm_pmax[(6 * channeltype) + 4].ToString();
            txtValMax5.Text = calculo_angulo.telecomm_pmax[(6 * channeltype) + 5].ToString();

            txtValMin0.Text = calculo_angulo.telecomm_pmin[(6 * channeltype) + 0].ToString();
            txtValMin1.Text = calculo_angulo.telecomm_pmin[(6 * channeltype) + 1].ToString();
            txtValMin2.Text = calculo_angulo.telecomm_pmin[(6 * channeltype) + 2].ToString();
            txtValMin3.Text = calculo_angulo.telecomm_pmin[(6 * channeltype) + 3].ToString();
            txtValMin4.Text = calculo_angulo.telecomm_pmin[(6 * channeltype) + 4].ToString();
            txtValMin5.Text = calculo_angulo.telecomm_pmin[(6 * channeltype) + 5].ToString();

            btSaveData.Visible = false;
        }

        private void load_channel(int channeltype)
        {
            //var instance = new calculo_angulo();

            var MyIni = new IniFile(calculo_angulo.FILENAME);
            string strValMaxName = "";
            string strValMinName= "";
            string strSection = "";
            int outputconv;

            
            alterarvScroll(calculo_angulo.value_entree[calculo_angulo.testechanel]);//vScrollBar1.Value = value_entree[testechanel];
            if (channeltype == calculo_angulo.VALP)
            {
                strValMinName = "PValMin";
                strValMaxName = "PValMax";
                strSection = "Telecommand_p";
            }
            if (channeltype == calculo_angulo.VALR)
            {
                strValMinName = "RValMin";
                strValMaxName = "RValMax";
                strSection = "Telecommand_r";
            }
            if (channeltype == calculo_angulo.VALY)
            {
                strValMinName = "YValMin";
                strValMaxName = "YValMax";
                strSection = "Telecommand_y";
            }
            if (channeltype == calculo_angulo.VALH)
            {
                strValMinName = "HValMin";
                strValMaxName = "HValMax";
                strSection = "Telecommand_h";
            }
            if (channeltype == calculo_angulo.VALS)
            {
                strValMinName = "SValMin";
                strValMaxName = "SValMax";
                strSection = "Telecommand_s";
            }
            if (channeltype == calculo_angulo.VALSu)
            {
                strValMinName = "SuValMin";
                strValMaxName = "SuValMax";
                strSection = "Telecommand_su";
            }

            //Si telecommande DATA non exist pas, on va creer
            for (int pint = 0; pint < 6; pint++)
                {
                    string tempstr = strValMinName + pint.ToString();
                    if (!MyIni.KeyExists(tempstr, strSection))
                    {
                        MyIni.Write(tempstr, "-90", strSection);
                    }

                    tempstr = strValMaxName + pint.ToString();
                    if (!MyIni.KeyExists(tempstr, strSection))
                    {
                        MyIni.Write(tempstr, "+90", strSection);
                    }
                }

                //Lecture des variables
                for (int pint = 0; pint < 6; pint++)
                {
                    string tempstr = strValMinName + pint.ToString();                   
                    string val_lecture = MyIni.Read(tempstr, strSection);
                    int.TryParse(val_lecture, out outputconv);
                    calculo_angulo.telecomm_pmin[(6* channeltype) + pint] = outputconv;
                    //telecomm_min[pint] = outputconv;

                    tempstr = strValMaxName + pint.ToString();
                    val_lecture = MyIni.Read(tempstr, strSection);
                    int.TryParse(val_lecture, out outputconv);
                    calculo_angulo.telecomm_pmax[(6 * channeltype) + pint] = outputconv;
                    //telecomm_max[pint] = outputconv;
                }           
        }


        private void save_channel(int channeltype)
        {
            //var instance = new calculo_angulo();

            var MyIni = new IniFile(calculo_angulo.FILENAME);
            string strValMaxName = "";
            string strValMinName = "";
            string strSection = "";
            //int outputconv;

            if (channeltype == calculo_angulo.VALP)
            {
                strValMinName = "PValMin";
                strValMaxName = "PValMax";
                strSection = "Telecommand_p";
            }
            if (channeltype == calculo_angulo.VALR)
            {
                strValMinName = "RValMin";
                strValMaxName = "RValMax";
                strSection = "Telecommand_r";
            }
            if (channeltype == calculo_angulo.VALY)
            {
                strValMinName = "YValMin";
                strValMaxName = "YValMax";
                strSection = "Telecommand_y";
            }
            if (channeltype == calculo_angulo.VALH)
            {
                strValMinName = "HValMin";
                strValMaxName = "HValMax";
                strSection = "Telecommand_h";
            }
            if (channeltype == calculo_angulo.VALS)
            {
                strValMinName = "SValMin";
                strValMaxName = "SValMax";
                strSection = "Telecommand_s";
            }
            if (channeltype == calculo_angulo.VALSu)
            {
                strValMinName = "SuValMin";
                strValMaxName = "SuValMax";
                strSection = "Telecommand_su";
            }


            //Si telecommande DATA non exist pas, on va creer
            for (int pint = 0; pint < 6; pint++)
            {
                string tempstr = strValMinName + pint.ToString();
                {
                    MyIni.Write(tempstr, calculo_angulo.telecomm_pmin[( 6 * channeltype) + pint].ToString(), strSection);
                }

                tempstr = strValMaxName + pint.ToString();
                {
                    MyIni.Write(tempstr, calculo_angulo.telecomm_pmax[( 6 * channeltype) + pint].ToString(), strSection);
                }
            }

        }

        private void atribuir_val_max(int p)
        {

        }




        private void testeMin(object sender, int channel)
        {
            //var instance = new calculo_angulo();

            TextBox objTextBox = (TextBox)sender;
            string valtempstr = objTextBox.Text;
            int valtemp = 0;
            bool varGood = false;
            varGood = int.TryParse(valtempstr, out valtemp);
            if (varGood)
            {
                calculo_angulo.telecomm_pmin[(calculo_angulo.testechanel * 6) + channel] = valtemp;
                btSaveData.Visible = true;
            }
            else
            {
                btSaveData.Visible = false;
            }
        }

        private void calcule_sortie()
        {
            var instance = new calculo_angulo();
            instance.calcule_sortie_canal(calculo_angulo.testechanel);

            txtOut0.Text = calculo_angulo.telecomm_pos_sortie[(6 * calculo_angulo.testechanel) + 0].ToString();
            txtOut1.Text = calculo_angulo.telecomm_pos_sortie[(6 * calculo_angulo.testechanel) + 1].ToString();
            txtOut2.Text = calculo_angulo.telecomm_pos_sortie[(6 * calculo_angulo.testechanel) + 2].ToString();
            txtOut3.Text = calculo_angulo.telecomm_pos_sortie[(6 * calculo_angulo.testechanel) + 3].ToString();
            txtOut4.Text = calculo_angulo.telecomm_pos_sortie[(6 * calculo_angulo.testechanel) + 4].ToString(); 
            txtOut5.Text = calculo_angulo.telecomm_pos_sortie[(6 * calculo_angulo.testechanel) + 5].ToString();


            instance.calcule_sortie_canal_total();

            txtOutT0.Text = calculo_angulo.telecomm_pos_sortie_total[0].ToString();
            txtOutT1.Text = calculo_angulo.telecomm_pos_sortie_total[1].ToString();
            txtOutT2.Text = calculo_angulo.telecomm_pos_sortie_total[2].ToString();
            txtOutT3.Text = calculo_angulo.telecomm_pos_sortie_total[3].ToString();
            txtOutT4.Text = calculo_angulo.telecomm_pos_sortie_total[4].ToString();
            txtOutT5.Text = calculo_angulo.telecomm_pos_sortie_total[5].ToString();


        }
        private void testeMax(object sender, int channel)
        {
            TextBox objTextBox = (TextBox)sender;
            string valtempstr = objTextBox.Text;
            int valtemp = 0;
            bool varGood = false;
            varGood = int.TryParse(valtempstr, out valtemp);
            if (varGood)
            {
                calculo_angulo.telecomm_pmax[(calculo_angulo.testechanel * 6)+channel] = valtemp;
                btSaveData.Visible= true;
            }
            else
            {
                btSaveData.Visible = false;
            }
        }


        private void frmIni_Load(object sender, EventArgs e)
        {
            // Or specify a specific name in the current dir
            var MyIni = new IniFile(calculo_angulo.FILENAME);

            /*
            // Or specify a specific name in a specific dir
            var MyIni = new IniFile(@"C:\Settings.ini");
            */

            //Si telecommande DATA non exist pas, on va creer
            for (int pint = 0; pint < 6; pint++)
            {
                 calculo_angulo.value_entree[pint] = calculo_angulo.ValStd;
                atribuivalorlabel(pint, calculo_angulo.value_entree[pint]);
                
                load_channel(pint);
            }
            calculo_angulo.testechanel = calculo_angulo.VALP;
            show_channel(calculo_angulo.testechanel);
            btSaveData.Visible = false;
        }

        private void calcule_telecomm_p(int value)
        {

            calculo_angulo.telecomm_p_calcule = 0;
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int pint = 0; pint < 6; pint++)
            {
                save_channel(pint);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            calculo_angulo.testechanel = calculo_angulo.VALP;
            load_channel(calculo_angulo.testechanel);
            show_channel(calculo_angulo.testechanel);
            label3.Text = calculo_angulo.value_entree[calculo_angulo.testechanel].ToString();
        }

        private void txtValMax0_TextChanged(object sender, EventArgs e)
        {
            testeMax(sender, 0);
        }

        private void txtValMax1_TextChanged(object sender, EventArgs e)
        {
            testeMax(sender, 1);
        }

        private void txtValMax2_TextChanged(object sender, EventArgs e)
        {
            testeMax(sender, 2);
        }

        private void txtValMax3_TextChanged(object sender, EventArgs e)
        {
            testeMax(sender, 3);
        }

        private void txtValMax4_TextChanged(object sender, EventArgs e)
        {
            testeMax(sender, 4);
        }

        private void txtValMax5_TextChanged(object sender, EventArgs e)
        {
            testeMax(sender, 5);
        }

        private void txtValMin0_TextChanged(object sender, EventArgs e)
        {
            testeMin(sender, 0);
        }

        private void txtValMin1_TextChanged(object sender, EventArgs e)
        {
            testeMin(sender, 1);
        }

        private void txtValMin2_TextChanged(object sender, EventArgs e)
        {
            testeMin(sender, 2);
        }

        private void txtValMin3_TextChanged(object sender, EventArgs e)
        {
            testeMin(sender, 3);
        }

        private void txtValMin4_TextChanged(object sender, EventArgs e)
        {
            testeMin(sender, 4);
        }

        private void txtValMin5_TextChanged(object sender, EventArgs e)
        {
            testeMin(sender, 5);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*
            for (int pint = 0; pint < 6; pint++)
            {
                telecomm_pmin[(6 * calculo_angulo.testechanel) + pint] = calculo_angulo.ValMin;
                telecomm_pmax[(6 * calculo_angulo.testechanel) + pint] = calculo_angulo.ValMax;
            }
            */
            txtValMax0.Text = calculo_angulo.ValMax.ToString();
            txtValMax1.Text = calculo_angulo.ValMax.ToString();
            txtValMax2.Text = calculo_angulo.ValMax.ToString();
            txtValMax3.Text = calculo_angulo.ValMax.ToString();
            txtValMax4.Text = calculo_angulo.ValMax.ToString();
            txtValMax5.Text = calculo_angulo.ValMax.ToString();

            txtValMin0.Text = calculo_angulo.ValMin.ToString();
            txtValMin1.Text = calculo_angulo.ValMin.ToString();
            txtValMin2.Text = calculo_angulo.ValMin.ToString();
            txtValMin3.Text = calculo_angulo.ValMin.ToString();
            txtValMin4.Text = calculo_angulo.ValMin.ToString();
            txtValMin5.Text = calculo_angulo.ValMin.ToString();

        }

        private void alterarvScroll(int valor)
        {
            if (valor > vScrollBar1.Maximum)
                vScrollBar1.Value = vScrollBar1.Maximum;
            else if (valor < vScrollBar1.Minimum)
                vScrollBar1.Value = vScrollBar1.Minimum;
            else
                vScrollBar1.Value = valor;
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            alterarvScroll(calculo_angulo.ValStd);//vScrollBar1.Value = ValStd;
        }

        private void timUpdate_Tick(object sender, EventArgs e)
        {
            var instance = new calculo_angulo();
            calculo_angulo.value_entree[calculo_angulo.testechanel] = vScrollBar1.Value;

            for (int ptemp = 0; ptemp < 6; ptemp++)
            {
                instance.calcule_sortie_canal(ptemp);
            }

            //if (value_entree_old[testechanel] != value_entree[testechanel])
            {
                calculo_angulo.value_entree_old[calculo_angulo.testechanel] = calculo_angulo.value_entree[calculo_angulo.testechanel];
                label3.Text = calculo_angulo.value_entree_old[calculo_angulo.testechanel].ToString();

                calcule_sortie();
                atribuivalorlabel(calculo_angulo.testechanel, calculo_angulo.value_entree[calculo_angulo.testechanel]);

            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int pint = 0; pint < 6; pint++)
            {
                calculo_angulo.value_entree[pint] = calculo_angulo.ValStd;
                atribuivalorlabel(pint, calculo_angulo.value_entree[pint]);
                //load_channel(pint);
            }
            alterarvScroll(calculo_angulo.ValStd);
            label3.Text = calculo_angulo.ValStd.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int Qint = 0; Qint < 6; Qint++)
            {
                for (int pint = 0; pint < 6; pint++)
                {
                    calculo_angulo.telecomm_pmin[(6 * Qint) + pint] = calculo_angulo.ValMin;
                    calculo_angulo.telecomm_pmax[(6 * Qint) + pint] = calculo_angulo.ValMax;
                }
            }
            txtValMax0.Text = calculo_angulo.ValMax.ToString();
            txtValMax1.Text = calculo_angulo.ValMax.ToString();
            txtValMax2.Text = calculo_angulo.ValMax.ToString();
            txtValMax3.Text = calculo_angulo.ValMax.ToString();
            txtValMax4.Text = calculo_angulo.ValMax.ToString();
            txtValMax5.Text = calculo_angulo.ValMax.ToString();

            txtValMin0.Text = calculo_angulo.ValMin.ToString();
            txtValMin1.Text = calculo_angulo.ValMin.ToString();
            txtValMin2.Text = calculo_angulo.ValMin.ToString();
            txtValMin3.Text = calculo_angulo.ValMin.ToString();
            txtValMin4.Text = calculo_angulo.ValMin.ToString();
            txtValMin5.Text = calculo_angulo.ValMin.ToString();


        }

        private void atribuivalorlabel(int canal, int valor) 
        
        {
            if (canal == calculo_angulo.VALP)
                lblvalP.Text = valor.ToString();
            else if (canal == calculo_angulo.VALR)
                lblvalR.Text = valor.ToString();
            else if (canal == calculo_angulo.VALY)
                lblvalY.Text = valor.ToString();
            else if (canal == calculo_angulo.VALS)
                lblvalS.Text = valor.ToString();
            else if (canal == calculo_angulo.VALH)
                lblvalH.Text = valor.ToString();
            else if (canal == calculo_angulo.VALSu)
                lblvalSu.Text = valor.ToString();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
             calculo_angulo.testechanel = calculo_angulo.VALR;
            load_channel( calculo_angulo.testechanel);
            show_channel( calculo_angulo.testechanel);
            label3.Text =  calculo_angulo.value_entree[ calculo_angulo.testechanel].ToString();
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
             calculo_angulo.testechanel = calculo_angulo.VALY;
            load_channel( calculo_angulo.testechanel);
            show_channel( calculo_angulo.testechanel);
            label3.Text =  calculo_angulo.value_entree[ calculo_angulo.testechanel].ToString();
        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
             calculo_angulo.testechanel = calculo_angulo.VALS;
            load_channel( calculo_angulo.testechanel);
            show_channel( calculo_angulo.testechanel);
            label3.Text =  calculo_angulo.value_entree[ calculo_angulo.testechanel].ToString();
        }
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
             calculo_angulo.testechanel = calculo_angulo.VALH;
            load_channel( calculo_angulo.testechanel);
            show_channel( calculo_angulo.testechanel);
            label3.Text =  calculo_angulo.value_entree[ calculo_angulo.testechanel].ToString();
        }
        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
             calculo_angulo.testechanel = calculo_angulo.VALSu;
            load_channel( calculo_angulo.testechanel);
            show_channel( calculo_angulo.testechanel);
            label3.Text =  calculo_angulo.value_entree[ calculo_angulo.testechanel].ToString();
        }
    }
}
