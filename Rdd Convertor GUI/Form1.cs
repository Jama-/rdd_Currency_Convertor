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
using System.Net;

namespace Rdd_Convertor_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            load_config();
            tb_Calc_Need_In.Text = symbol();
        }

        private void get_rdd_price()
        {
            WebClient client = new WebClient();
            string downloadString = client.DownloadString("http://pubapi.cryptsy.com/api.php?method=singlemarketdata&marketid=169");
            string webRdd = downloadString.Substring(97, 8);
            tb_Sat_Per_Rdd.Text = webRdd;
        }

        private void get_btc_price()
        {
            string webBTC ="";
            WebClient client = new WebClient();
            string downloadString = client.DownloadString("http://api.bitcoincharts.com/v1/weighted_prices.json");
            if (cb_Currency.Text == "GBP")
            {
                 webBTC = downloadString.Substring(242, 6);
            }
            else if (cb_Currency.Text == "USD")
            {
                webBTC = downloadString.Substring(50, 6);
            }
            else if (cb_Currency.Text == "EUR")
            {
                webBTC = downloadString.Substring(1234, 6);
            }
            Console.WriteLine(webBTC);
            tb_BTC_Value.Text = webBTC;
        }

        private void load_config()
        {
            using (StreamReader Load = new StreamReader("rdd-conv.config"))
            {
                tb_Coins_Held.Text = Load.ReadLine();
                tb_Sat_Per_Rdd.Text = Load.ReadLine();
                tb_BTC_Value.Text = Load.ReadLine();
                cb_Currency.Text = Load.ReadLine();

            }
        }

        private void save_config()
        {
            using (StreamWriter Save = new StreamWriter("rdd-conv.config"))
            {
                Save.WriteLine(tb_Coins_Held.Text);
                Save.WriteLine(tb_Sat_Per_Rdd.Text);
                Save.WriteLine(tb_BTC_Value.Text);
                Save.WriteLine(cb_Currency.Text);
            }
        }

        private string symbol()
        {
            if (cb_Currency.Text == "GBP")
            {
                return "£";
            }
            else if (cb_Currency.Text == "USD")
            {
                return "$";
            }
            else if (cb_Currency.Text == "EUR")
            {
                return "€";
            }
            else
            {
                return "";
            }
        }

        private void btn_Calc_Worth_Click(object sender, EventArgs e)
        {
            double num_held = System.Convert.ToDouble(tb_Coins_Held.Text);
            double sats = System.Convert.ToDouble(tb_Sat_Per_Rdd.Text);
            double btc_price = System.Convert.ToDouble(tb_BTC_Value.Text);
            double total_worth;
            total_worth = num_held * (sats * 0.00000001) * btc_price;
            tb_Calc_Worth.Text = symbol()+(total_worth.ToString());
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
            save_config();
        }

        private void btn_Load_Config_Click(object sender, EventArgs e)
        {
            try
            {
                load_config();
            }
            catch (FileNotFoundException f)
            {
                tb_Coins_Held.Text = ("Error");
                tb_Sat_Per_Rdd.Text = ("No Config Found");
                tb_BTC_Value.Text = ("Enter Values Manually");
            }
        }

        private void btn_Get_Rdd_Price_Click(object sender, EventArgs e)
        {
            get_rdd_price();
        }

        private void btn_Get_BTC_Price_Click(object sender, EventArgs e)
        {
            get_btc_price();
        }
    }
}
