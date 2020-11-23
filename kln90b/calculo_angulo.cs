using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SERIAL_HEXAPOD_MONITOR
{
    class calculo_angulo
    {
        public const string FILENAME = "SettingsTelecommande.ini";
        public const int VALP = 1, VALR = 2, VALY = 3, VALS = 4, VALH = 5, VALSu = 0;

        public const int ValMin = 1, ValMax = 180, ValStd = 90;

        public static int[] telecomm_pmax = new int[6 * 6];
        public static int[] telecomm_pmin = new int[6 * 6];
        public static int[] telecomm_max = new int[6];
        public static int[] telecomm_min = new int[6];
        public static int[] telecomm_pos_sortie = new int[6 * 6];
        public static int[] telecomm_pos_sortie_total = new int[6];
        public static int telecomm_p_calcule;
        public static int[] value_entree = new int[6];
        public static int[] value_entree_old = new int[6];

        public static int testechanel = VALP;


        public void calcule_sortie_canal_total()
        {
            var instance = new calculo_angulo();

            int canal = 0;
            int saida_calculada = 0;

            for (int pint = 0; pint < 6; pint++)
            {
                saida_calculada = 0;
                for (canal = 0; canal < 6; canal++)
                {
                    if (telecomm_pos_sortie[(6 * canal) + pint] > ValStd)
                    {
                        saida_calculada += (telecomm_pos_sortie[(6 * canal) + pint] - ValStd);
                    }
                    else
                    {
                        saida_calculada += (telecomm_pos_sortie[(6 * canal) + pint] - ValStd);
                    }

                }
                telecomm_pos_sortie_total[pint] = saida_calculada;
            }
        }
        public int ler_sortie_canal(int canal)
        {
            int valsortie = telecomm_pos_sortie_total[canal] + ValStd;

            if (valsortie > 180)
                valsortie = 180;

            if (valsortie < 1)
                valsortie = 1;

            return valsortie;
        }

            public void calcule_sortie_canal(int canal)
        {
            var instance = new calculo_angulo();


            float proporcao = 0;
            float difval = 0;
            float saida_calculada = 0;
            if (value_entree[canal] < ValStd)
            {
                difval = ValStd - value_entree[canal];
                for (int pint = 0; pint < 6; pint++)
                {
                    float ptemp = telecomm_pmin[(6 * canal) + pint];
                    if (ptemp < ValStd)
                    {
                        proporcao = (ValStd - ptemp) / ValStd;
                    }
                    else
                    {
                        proporcao = (ValStd - ptemp) / ValStd;
                    }
                    saida_calculada = ValStd - (difval * proporcao);
                    telecomm_pos_sortie[(6 * canal) + pint] = (int)saida_calculada;

                }



            }
            else if (value_entree[canal] > ValStd)
            {
                difval = value_entree[canal] - ValStd;
                for (int pint = 0; pint < 6; pint++)
                {
                    float ptemp = telecomm_pmax[(6 * canal) + pint];
                    if (ptemp < ValStd)
                    {
                        proporcao = (ptemp - ValStd) / ValStd;
                    }
                    else
                    {
                        proporcao = (ptemp - ValStd) / ValStd;
                    }
                    saida_calculada = ValStd + (difval * proporcao);
                    telecomm_pos_sortie[(6 * canal) + pint] = (int)saida_calculada;
                }
            }
            else
            {
                for (int pint = 0; pint < 6; pint++)
                {
                    telecomm_pos_sortie[(6 * canal) + pint] = ValStd;
                }

            }
        }


    }
}
