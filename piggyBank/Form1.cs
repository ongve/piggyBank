using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using piggyBank.Repositories.Enum;
using piggyBank.Repositories.Concrate;


namespace piggyBank
{
    public partial class Form1 : Form
    {
        Banknote banknote = new Banknote();
        Coin coin = new Coin();
        PBBox piggyBank = new PBBox();

        List<string> moneys = new List<string>();
        int fold = -1;
        int breakAmount = 1;
        int fixAmount = 1;
        int Shacks = 0;
        //int throwAmount = 1;
        double excessVolume = 0;
        double totalMoney = 0;
        double totalVolume;
        double Volume;

        public Form1()
        {
            InitializeComponent();
            cBoxMoneyType.Items.Add("Atacağınız para türünü seçiniz");
            cBoxMoneyType.Items.AddRange(Enum.GetNames(typeof(MoneyType)));
            piggyBank.Volume = 100000;
            cBoxMoneyType.SelectedIndex = 0;
            piggyBank.totalMoneyList = moneys;
            piggyBank.totalMoney = totalMoney;
            btnShake.Enabled = false;
            btnThrowMoney.Enabled = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnFold_Click(object sender, EventArgs e)
        {
            switch (fold)
            {
                case 1:
                    banknote.Fold(banknote);
                    fold = 0;
                    break;
                case -1:
                    System.Windows.Forms.MessageBox.Show("Öncelikle katlamak istediğin parayı seçmelisin !");
                    break;
                case -2:
                    System.Windows.Forms.MessageBox.Show("Bozuk parayı katlayamazsın !");
                    break;
                default:
                    System.Windows.Forms.MessageBox.Show("Tekrar katlayamazsın !");
                    break;
            }
        }

        private void btnShack_Click(object sender, EventArgs e)
        {
            if (Shacks == 1)
            {
                double NewVolume = piggyBank.ShakeIt(Volume);
                totalVolume = NewVolume;
            }
        }

        private void btnFix_Click(object sender, EventArgs e)
        {
            fixAmount = 0;
            breakAmount = 1;
            piggyBank.FixIt();
            System.Windows.Forms.MessageBox.Show("Kumbarayı son kez onardım.");
            btnFix.Visible = false;
            btnBreak.Enabled = true;
            btnThrowMoney.Enabled = true;
            btnThrowMoney.Visible = true;
        }

        private void btnBreak_Click(object sender, EventArgs e)
        {
            btnThrowMoney.Visible = false;

            if (breakAmount == 1 && fixAmount == 1)
            {
                foreach (var item in piggyBank.totalMoneyList.GroupBy(x => x))
                {
                    string moneys = string.Format($"Kumbaranızdan {item.Count().ToString()} tane {item.Key} var :)");
                    listBox1.Items.Add(moneys);
                }
                labelMoney.Text = Convert.ToString(piggyBank.totalMoney) + " ₺";
                btnThrowMoney.Enabled = false;
            }
            else
            {
                btnBreak.Enabled = false;
                btnFold.Enabled = false;
                btnShake.Enabled = false;
                btnThrowMoney.Enabled = false;
            }
            breakAmount = -1;
        }

        private void btnThrowMoney_Click(object sender, EventArgs e)
        {
            Shacks = 1;
            breakAmount = 1;
            excessVolume = excessVolume + banknote.CalculateVolume();
            piggyBank.totalMoneyList.Add(cBoxMoneyValue.SelectedItem.ToString());
            totalVolume = totalVolume + banknote.Volume;
            piggyBank.totalMoney = piggyBank.totalMoney + banknote.Value;
            btnFold.Enabled = true;
            btnShake.Enabled = true;
            btnThrowMoney.Enabled = false;
            int volumeProgress = Convert.ToInt32(totalVolume / piggyBank.Volume * 100);
            labelPercent.Text = (totalVolume / piggyBank.Volume * 100).ToString();
            if (volumeProgress <= 100)
            {
                progressBar.Value = volumeProgress;
            }
            else
            {
                btnThrowMoney.Enabled = false;
                System.Windows.Forms.MessageBox.Show("Kumbara doldu!");
            }
        }

        private void cBoxMoneyType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cBoxMoneyValue.Items.Clear();

            switch (cBoxMoneyType.SelectedItem.ToString())
            {
                case nameof(MoneyType.Banknote):
                    {
                        cBoxMoneyValue.Items.Add("Paranın Değerini Seç");
                        cBoxMoneyValue.Items.AddRange(Enum.GetNames(typeof(BanknoteEnum)));
                        cBoxMoneyValue.SelectedIndex = 0;
                        fold = 1;
                        break;
                    }
                case nameof(MoneyType.Coin):
                    {
                        cBoxMoneyValue.Items.Add("Paranın Değerini Seç");
                        cBoxMoneyValue.Items.AddRange(Enum.GetNames(typeof(CoinEnum)));
                        cBoxMoneyValue.SelectedIndex = 0;
                        fold = -2;
                        break;
                    }
            }
            cBoxMoneyValue.Enabled = true;
        }

        private void cBoxMoneyValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnThrowMoney.Enabled = true;

            switch (cBoxMoneyValue.SelectedItem.ToString())
            {
                case nameof(BanknoteEnum.IkiYuzLira):
                    {
                        banknote.BanknoteName = BanknoteEnum.IkiYuzLira;
                        banknote.Value = 200;
                        banknote.Width = 72;
                        banknote.Length = 160;
                        banknote.Height = 0.25;
                        break;
                    }
                case nameof(BanknoteEnum.YuzLira):
                    {
                        banknote.BanknoteName = BanknoteEnum.YuzLira;
                        banknote.Value = 100;
                        banknote.Width = 72;
                        banknote.Length = 160;
                        banknote.Height = 0.25;
                        break;
                    }
                case nameof(BanknoteEnum.ElliLira):
                    {
                        banknote.BanknoteName = BanknoteEnum.ElliLira;
                        banknote.Value = 50;
                        banknote.Width = 72;
                        banknote.Length = 160;
                        banknote.Height = 0.25;
                        break;
                    }
                case nameof(BanknoteEnum.YirmiLira):
                    {
                        banknote.BanknoteName = BanknoteEnum.YirmiLira;
                        banknote.Value = 20;
                        banknote.Width = 72;
                        banknote.Length = 160;
                        banknote.Height = 0.25;
                        break;
                    }
                case nameof(BanknoteEnum.OnLira):
                    {
                        banknote.BanknoteName = BanknoteEnum.OnLira;
                        banknote.Value = 10;
                        banknote.Width = 72;
                        banknote.Length = 160;
                        banknote.Height = 0.25;
                        break;
                    }

                case nameof(BanknoteEnum.BesLira):
                    {
                        banknote.BanknoteName = BanknoteEnum.BesLira;
                        banknote.Value = 5;
                        banknote.Width = 72;
                        banknote.Length = 160;
                        banknote.Height = 0.25;
                        break;
                    }
                case nameof(CoinEnum.BirLira):
                    {
                        coin.CoinName = CoinEnum.BirLira;
                        coin.Value = 1;
                        coin.Radius = 13.07;
                        coin.Height = 1.9;
                        break;
                    }
                case nameof(CoinEnum.ElliKurus):
                    {
                        coin.CoinName = CoinEnum.ElliKurus;
                        coin.Value = 0.50;
                        coin.Radius = 11.92;
                        coin.Height = 1.9;
                        break;
                    }
                case nameof(CoinEnum.YirmiBesKurus):
                    {
                        coin.CoinName = CoinEnum.YirmiBesKurus;
                        coin.Value = 0.25;
                        coin.Radius = 10.25;
                        coin.Height = 1.65;
                        break;
                    }
                case nameof(CoinEnum.OnKurus):
                    {
                        coin.CoinName = CoinEnum.OnKurus;
                        coin.Value = 0.10;
                        coin.Radius = 9.25;
                        coin.Height = 1.65;
                        break;
                    }

            }

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelMoney_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelPercent_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
