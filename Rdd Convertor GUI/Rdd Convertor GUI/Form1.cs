using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Rdd_Convertor_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Calc_Worth_Click(object sender, EventArgs e)
        {
            double num_held = System.Convert.ToDouble(tb_Coins_Held.Text);
            double sats = System.Convert.ToDouble(tb_Sat_Per_Rdd.Text);
            double btc_price = System.Convert.ToDouble(tb_BTC_Value.Text);
            double total_worth;
            total_worth = num_held * (sats * 0.00000001) * btc_price;
            tb_Calc_Worth.Text = total_worth.ToString();
        }

        private void btn_Calc_Need_Click(object sender, EventArgs e)
        {
            double num_held = System.Convert.ToDouble(tb_Coins_Held.Text);
            double btc_price = System.Convert.ToDouble(tb_BTC_Value.Text);            
            double price_wanted = System.Convert.ToDouble(tb_Calc_Need_In.Text);
            double sats_needed;
            sats_needed = price_wanted/(num_held *(btc_price* 0.00000001));
            tb_Calc_Need_Out.Text = sats_needed.ToString();
        }

        private void btn_Save_Config_Click(object sender, EventArgs e)
        {
            using (StreamWriter Save = new StreamWriter("rdd-conv.config"))
            {
                Save.WriteLine(System.Convert.ToDouble(tb_Coins_Held.Text));
                Save.WriteLine(System.Convert.ToDouble(tb_Sat_Per_Rdd.Text));
                Save.WriteLine(System.Convert.ToDouble(tb_BTC_Value.Text));
            }
        }

        private void btn_Load_Config_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader Load = new StreamReader("rdd-conv.config"))
                {
                    tb_Coins_Held.Text = System.Convert.ToString(Load.ReadLine());
                    tb_Sat_Per_Rdd.Text = System.Convert.ToString(Load.ReadLine());
                    tb_BTC_Value.Text = System.Convert.ToString(Load.ReadLine());

                }
            }
            catch (FileNotFoundException f)
            {
                tb_Coins_Held.Text = ("Error");
                tb_Sat_Per_Rdd.Text = ("Could Not Load .config");
                tb_BTC_Value.Text = ("Enter Values Manually");
            }
        }
    }
}
