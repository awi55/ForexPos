using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace myPos
{
    public partial class Form1 : Form
    {
        string password = "awi55";
        int BuyYPos;
        int SellYPos;

        public Form1()
        {
            InitializeComponent();
            CompanyTextBox.Text = MySettings.Default.CompanyName;
            StoreAddressTextBox.Text = MySettings.Default.StoreAddress;
            ACNTextBox.Text = MySettings.Default.ACN;

            dateTimePicker1.Value = DateTime.Today;

            
        }

        private void TextBox7_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string errMsg;
            if (!Empty(TextBox7.Text, out errMsg))
            {
                e.Cancel = true;
                TextBox7.Select(0, TextBox7.Text.Length);
                this.errorProvider1.SetError(TextBox7, errMsg);
            }
        }

        private void TextBox7_Validated(object sender, System.EventArgs e)
        {
            errorProvider1.SetError(TextBox7, "");
        }

        public bool Empty(string fieldValue, out string errMsg)
        {
            if (fieldValue.Length == 0)
            {
                errMsg = "Amount field is required";
            }
            errMsg = "Field must not be empty";
            return false;
        }

        private string getBuyingConvertedTotal()
        {
            string totalValue;
            totalValue = Converted.Text;
            return totalValue;
        }

        private string getSellingConvertedTotal()
        {
            string totalValue;
            totalValue = SellConverted.Text;
            return totalValue;
        }

        private string getBuyingAmount()
        {
            string AmountValue;
            AmountValue = TextBox7.Text;
            return AmountValue;
        }

        private string getSellingAmount()
        {
            string AmountValue;
            AmountValue = TextBox19.Text;
            return AmountValue;
        }

        private string getBuyingRate()
        {
            string rateValue;
            rateValue = TextBox8.Text;
            return rateValue;
        }

        private string getSellingRate()
        {
            string rateValue;
            rateValue = TextBox18.Text;
            return rateValue;
        }

        private string getBuyingTotal()
        {
            string buyingValue;
            buyingValue = TextBox10.Text;
            return buyingValue;
        }

        private string getSellingTotal()
        {
            string buyingValue;
            buyingValue = TextBox16.Text;
            return buyingValue;
        }

        private string getBuyingCommPer()
        {
            string commValue;
            commValue = TextBox9.Text;
            return commValue;
        }

        private string getSellingCommPer()
        {
            string commValue;
            commValue = TextBox17.Text;
            return commValue;
        }

        private string getBuyingCommVal()
        {
            string commValue;
            commValue = CommissionValue.Text.ToString();
            return commValue;
        }

        private string getBuyingFlatFee()
        {
            string flatValue;
            flatValue = FlatFeeTextBox.Text;
            return flatValue;
        }

        private string getSellingCommVal()
        {
            string commValue;
            commValue = SellCommValue.Text.ToString();
            return commValue;
        }

        private string getSellingFlatFee()
        {
            string flatValue;
            flatValue = FlatFeeSellingTextBox.Text;
            return flatValue;
        }


        private string getBuyingCurrency()
        {
            string currencyText;
            currencyText = comboBox1.Text;
            return currencyText;
        }

        private string getSellingCurrency()
        {
            string currencyText;
            currencyText = comboBox2.Text;
            return currencyText;
        }

        private string getCompanyName()
        {
            string companyName;
            companyName = CompanyTextBox.Text;
            return companyName;
        }

        private string getCompanyACN()
        {
            string companyACN;
            companyACN = ACNTextBox.Text;
            return companyACN;
        }

        private string getCompanyAddress()
        {
            string companyAddress;
            companyAddress = StoreAddressTextBox.Text;
            return companyAddress;
        }

        private void TextBox7_TextChanged(object sender, EventArgs e)
        {

            double num1, num2, num3, num4, percent;
            num4 = 0;

            if ((Double.TryParse(TextBox7.Text, out num1)) && (Double.TryParse(TextBox8.Text, out num2)))
            {

                if ((Double.TryParse(TextBox9.Text, out num3)) && (Double.TryParse(FlatFeeTextBox.Text, out num4)))
                {
                    num3 = num3 / 100;
                    percent = (num1 / num2) * num3;
                    CommissionValue.Text = percent.ToString("#,###.00");
                    Converted.Text = (num1 / num2).ToString("#,###.00");
                    TextBox10.Text = ((num1 / num2) - percent - num4).ToString("#,###.00");
                    FlatFeeConverted.Text = num4.ToString("#,###.00");
                }
                else if (Double.TryParse(TextBox9.Text, out num3))
                {
                    num3 = num3 / 100;
                    percent = (num1 / num2) * num3;
                    CommissionValue.Text = percent.ToString("#,###.00");
                    Converted.Text = (num1 / num2).ToString("#,###.00");
                    TextBox10.Text = ((num1 / num2) - percent - num4).ToString("#,###.00");
                    FlatFeeConverted.Text = "0";

                }
                else if (Double.TryParse(FlatFeeTextBox.Text, out num4))
                {
                    TextBox10.Text = ((num1 / num2) - num4).ToString("#,###.00");
                    FlatFeeConverted.Text = num4.ToString("#,###.00");
                    CommissionValue.Text = "0";
                }
                else
                {
                    CommissionValue.Text = "0";
                    FlatFeeConverted.Text = "0";
                    Converted.Text = (num1 / num2).ToString("#,###.00");
                    TextBox10.Text = (num1 / num2).ToString("#,###.00");
                }
            }
            else
            {
                CommissionValue.Text = "0";
                FlatFeeConverted.Text = "0";
                Converted.Text = "0";
                TextBox10.Text = "NaN";
            }
        }

        private void TextBox8_TextChanged(object sender, EventArgs e)
        {
            double num1, num2, num3, num4, percent;
            if ((Double.TryParse(TextBox7.Text, out num1)) && (Double.TryParse(TextBox8.Text, out num2)))
            {
                if ((Double.TryParse(TextBox9.Text, out num3)) && (Double.TryParse(FlatFeeTextBox.Text, out num4)))
                {
                    num3 = num3 / 100;
                    percent = (num1 / num2) * num3;
                    CommissionValue.Text = percent.ToString("#,###.00");
                    Converted.Text = (num1 / num2).ToString("#,###.00");
                    TextBox10.Text = ((num1 / num2) - percent - num4).ToString("#,###.00");
                    FlatFeeConverted.Text = num4.ToString("#,###.00");
                }
                else if (Double.TryParse(TextBox9.Text, out num3))
                {
                    num3 = num3 / 100;
                    percent = (num1 / num2) * num3;
                    CommissionValue.Text = percent.ToString("#,###.00");
                    Converted.Text = (num1 / num2).ToString("#,###.00");
                    TextBox10.Text = ((num1 / num2) - percent).ToString("#,###.00");
                    FlatFeeConverted.Text = "0";
                }
                else if (Double.TryParse(FlatFeeTextBox.Text, out num4))
                {
                    TextBox10.Text = ((num1 / num2) - num4).ToString("#,###.00");
                    FlatFeeConverted.Text = num4.ToString("#,###.00");
                    CommissionValue.Text = "0";
                }
                else
                {
                    FlatFeeConverted.Text = "0";
                    CommissionValue.Text = "0";
                    Converted.Text = (num1 / num2).ToString("#,###.00");
                    TextBox10.Text = (num1 / num2).ToString("#,###.00");
                }
            }
            else
            {
                CommissionValue.Text = "0";
                FlatFeeConverted.Text = "0";
                Converted.Text = "0";
                TextBox10.Text = "NaN";
            }
            //C:\Users\Awais\Desktop\Book.csv
        }

        private void TextBox9_TextChanged(object sender, EventArgs e)
        {
            double num1, num2, num3, num4, percent;
            if ((Double.TryParse(TextBox7.Text, out num1)) && (Double.TryParse(TextBox8.Text, out num2)))
            {
                if ((Double.TryParse(TextBox9.Text, out num3)) && (Double.TryParse(FlatFeeTextBox.Text, out num4)))
                {
                    num3 = num3 / 100;
                    percent = (num1 / num2) * num3;
                    CommissionValue.Text = percent.ToString("#,###.00");
                    Converted.Text = (num1 / num2).ToString("#,###.00");
                    TextBox10.Text = ((num1 / num2) - percent - num4).ToString("#,###.00");
                    FlatFeeConverted.Text = num4.ToString("#,###.00");
                }
                else if (Double.TryParse(TextBox9.Text, out num3))
                {
                    num3 = num3 / 100;
                    percent = (num1 / num2) * num3;
                    CommissionValue.Text = percent.ToString("#,###.00");
                    Converted.Text = (num1 / num2).ToString("#,###.00");
                    TextBox10.Text = ((num1 / num2) - percent).ToString("#,###.00");
                    FlatFeeConverted.Text = "0";
                }
                else if (Double.TryParse(FlatFeeTextBox.Text, out num4))
                {
                    TextBox10.Text = ((num1 / num2) - num4).ToString("#,###.00");
                    FlatFeeConverted.Text = num4.ToString("#,###.00");
                    CommissionValue.Text = "0";
                }
                else
                {
                    FlatFeeConverted.Text = "0";
                    CommissionValue.Text = "0";
                    Converted.Text = (num1 / num2).ToString("#,###.00");
                    TextBox10.Text = (num1 / num2).ToString("#,###.00");
                }
            }
            else
            {
                CommissionValue.Text = "0";
                FlatFeeConverted.Text = "0";
                Converted.Text = "0";
                TextBox10.Text = "NaN";
            }
            //C:\Users\Awais\Desktop\Book.csv
            /*
            string convertedVal = getBuyingConvertedTotal();

            double percent, num1, num2;

            if (Double.TryParse(TextBox9.Text, out num1))
            {
                num1 = (double.Parse(TextBox9.Text) / 100);
                num2 = (double.Parse(convertedVal));
                percent = num2 * num1;
                CommissionValue.Text = percent.ToString("#,###.00");
                TextBox10.Text = (num2 - percent).ToString("#,###.00");
            }
            else
            {
                CommissionValue.Text = "0";
                TextBox10.Text = convertedVal;
            }
            */
        }

        private void FlatFeeTextBox_TextChanged(object sender, EventArgs e)
        {
            double num1, num2, num3, num4, percent;
            if ((Double.TryParse(TextBox7.Text, out num1)) && (Double.TryParse(TextBox8.Text, out num2)))
            {
                if ((Double.TryParse(TextBox9.Text, out num3)) && (Double.TryParse(FlatFeeTextBox.Text, out num4)))
                {
                    num3 = num3 / 100;
                    percent = (num1 / num2) * num3;
                    CommissionValue.Text = percent.ToString("#,###.00");
                    Converted.Text = (num1 / num2).ToString("#,###.00");
                    TextBox10.Text = ((num1 / num2) - percent - num4).ToString("#,###.00");
                    FlatFeeConverted.Text = num4.ToString("#,###.00");
                }
                else if (Double.TryParse(TextBox9.Text, out num3))
                {
                    num3 = num3 / 100;
                    percent = (num1 / num2) * num3;
                    CommissionValue.Text = percent.ToString("#,###.00");
                    Converted.Text = (num1 / num2).ToString("#,###.00");
                    TextBox10.Text = ((num1 / num2) - percent).ToString("#,###.00");
                    FlatFeeConverted.Text = "0";
                }
                else if (Double.TryParse(FlatFeeTextBox.Text, out num4))
                {
                    TextBox10.Text = ((num1 / num2) - num4).ToString("#,###.00");
                    FlatFeeConverted.Text = num4.ToString("#,###.00");
                    CommissionValue.Text = "0";
                }
                else
                {
                    FlatFeeConverted.Text = "0";
                    CommissionValue.Text = "0";
                    Converted.Text = (num1 / num2).ToString("#,###.00");
                    TextBox10.Text = (num1 / num2).ToString("#,###.00");
                }
            }
            else
            {
                CommissionValue.Text = "0";
                FlatFeeConverted.Text = "0";
                Converted.Text = "0";
                TextBox10.Text = "NaN";
            }
        }

        private void BuyingGo_Click(object sender, EventArgs e)
        {
            
            // a = 7, r = 8, c = 9, total = 10
            
            double percent, num1, num2, num3, num4 , dummy;
            string num5;
            if ((Double.TryParse(TextBox10.Text, out num1)) && (Double.TryParse(TextBox8.Text, out num2)))
            {
                if ((Double.TryParse(TextBox9.Text, out num3)) && (Double.TryParse(FlatFeeTextBox.Text, out num4)))
                {
                    num3 = num3 / 100;
                    percent = num1 * num3;
                    dummy = num1 + percent + num4;
                    num5 = (dummy * num2).ToString("#,###.00");
                    TextBox7.Text = num5;
                    CommissionValue.Text = percent.ToString("#,###.00");
                    TextBox10.Text = num1.ToString("#,###.00");
                    FlatFeeConverted.Text = num4.ToString("#,###.00");

                    //CommissionValue.Text = percent.ToString("#,###.00");
                    //Converted.Text = (num1 / num2).ToString("#,###.00");
                    //TextBox10.Text = ((num1 / num2) - percent - num4).ToString("#,###.00");
                    //FlatFeeConverted.Text = num4.ToString("#,###.00");
                }
                else if (Double.TryParse(TextBox9.Text, out num3))
                {
                    num3 = num3 / 100;
                    percent = num1 * num3;
                    dummy = num1 + percent;
                    num5 = (dummy * num2).ToString("#,###.00");
                    TextBox7.Text = num5;
                    CommissionValue.Text = percent.ToString("#,###.00");
                    FlatFeeConverted.Text = "0";
                    TextBox10.Text = num1.ToString("#,###.00");
                }
                else if (Double.TryParse(FlatFeeTextBox.Text, out num4))
                {
                    dummy = num1 + num4;
                    num5 = (dummy * num2).ToString("#,###.00");
                    TextBox7.Text = num5;
                    CommissionValue.Text = "0";
                    FlatFeeConverted.Text = num4.ToString("#,###.00");
                    TextBox10.Text = num1.ToString("#,###.00");

                    //TextBox10.Text = ((num1 / num2) - num4).ToString("#,###.00");
                    //FlatFeeConverted.Text = num4.ToString("#,###.00");
                    //CommissionValue.Text = "0";
                }
                else
                {
                    num4 = num1 * num2;
                    CommissionValue.Text = "0";
                    FlatFeeConverted.Text = "0";
                    TextBox7.Text = num4.ToString("#,###.00"); ;
                    TextBox10.Text = num1.ToString("#,###.00");
                }
            }

            /*
            else if (Double.TryParse(TextBox9.Text, out num3))
                {
                    num3 = num3 / 100;
                    percent = num1 * num3;
                    num4 = num1 + percent;
                    num5 = (num4 * num2).ToString("#,###.00");
                    TextBox7.Text = num5;
                    CommissionValue.Text = percent.ToString("#,###.00");
                    TextBox10.Text = num1.ToString("#,###.00");
                }
            */
            //C:\Users\Awais\Desktop\Book.csv

        }

        private void TextBox19_TextChanged(object sender, EventArgs e)
        {
            string convertedVal = getSellingConvertedTotal();
            double num1, num2, num3, num4, percent;
            if ((Double.TryParse(TextBox19.Text, out num1)) && (Double.TryParse(TextBox18.Text, out num2)))
            {
                if ((Double.TryParse(TextBox17.Text, out num3)) && (Double.TryParse(FlatFeeSellingTextBox.Text, out num4)))
                {
                    num3 = num3 / 100;
                    //num4 = (num1 / num2);//(double.Parse(convertedVal));
                    percent = (num1 / num2) * num3;
                    //num5 = num4 - percent;
             
                    FlatFeeSellingConv.Text = num4.ToString("#,###.00");
                    SellCommValue.Text = percent.ToString("#,###.00");
                    SellConverted.Text = (num1 / num2).ToString("#,###.00");
                    TextBox16.Text = ((num1 / num2) + percent + num4).ToString("#,###.00");
                }
                else if (Double.TryParse(TextBox17.Text, out num3))
                {
                    num3 = num3 / 100;
                    percent = (num1 / num2) * num3;
                    FlatFeeSellingConv.Text = "0";
                    SellCommValue.Text = percent.ToString("#,###.00");
                    SellConverted.Text = (num1 / num2).ToString("#,###.00");
                    TextBox16.Text = ((num1 / num2) + percent).ToString("#,###.00");
                    /* Old version before Flat fee

                    num3 = (double.Parse(TextBox17.Text) / 100);
                    num4 = (num1 / num2);//(double.Parse(convertedVal));
                    percent = num4 * num3;
                    num5 = num4 - percent;
                    SellCommValue.Text = percent.ToString("#,###.00");
                    SellConverted.Text = (num1 / num2).ToString("#,###.00");
                    TextBox16.Text = ((num1 / num2) + percent).ToString("#,###.00");
                    */
                }
                else if (Double.TryParse(FlatFeeSellingTextBox.Text, out num4))
                {
                    FlatFeeSellingConv.Text = num4.ToString("#,###.00");
                    SellCommValue.Text = "0";
                    SellConverted.Text = (num1 / num2).ToString("#,###.00");
                    TextBox16.Text = ((num1 / num2) + num4).ToString("#,###.00");
                }
                else
                {
                    FlatFeeSellingConv.Text = "0";
                    SellCommValue.Text = "0";
                    SellConverted.Text = (num1 / num2).ToString("#,###.00");
                    TextBox16.Text = (num1 / num2).ToString("#,###.00");
                }
            }
            else
            {
                FlatFeeSellingConv.Text = "0";
                SellCommValue.Text = "0";
                SellConverted.Text = "0";
                TextBox16.Text = "NaN";
            }
        }

        private void TextBox18_TextChanged(object sender, EventArgs e)
        {
            double num1, num2, num3, num4, percent;
            if ((Double.TryParse(TextBox19.Text, out num1)) && (Double.TryParse(TextBox18.Text, out num2)))
            {
                if ((Double.TryParse(TextBox17.Text, out num3)) && (Double.TryParse(FlatFeeSellingTextBox.Text, out num4)))
                {
                    num3 = num3 / 100;
                    percent = (num1 / num2) * num3;
                    FlatFeeSellingConv.Text = num4.ToString("#,###.00");
                    SellCommValue.Text = percent.ToString("#,###.00");
                    SellConverted.Text = (num1 / num2).ToString("#,###.00");
                    TextBox16.Text = ((num1 / num2) + percent + num4).ToString("#,###.00");
                }
                else if (Double.TryParse(TextBox17.Text, out num3))
                {
                    num3 = num3 / 100;
                    percent = (num1 / num2) * num3;
                    FlatFeeSellingConv.Text = "0";
                    SellCommValue.Text = percent.ToString("#,###.00");
                    SellConverted.Text = (num1 / num2).ToString("#,###.00");
                    TextBox16.Text = ((num1 / num2) + percent).ToString("#,###.00");
                }
                else if (Double.TryParse(FlatFeeSellingTextBox.Text, out num4))
                {
                    FlatFeeSellingConv.Text = num4.ToString("#,###.00");
                    SellCommValue.Text = "0";
                    SellConverted.Text = (num1 / num2).ToString("#,###.00");
                    TextBox16.Text = ((num1 / num2) + num4).ToString("#,###.00");
                }
                else
                {
                    FlatFeeSellingConv.Text = "0";
                    SellCommValue.Text = "0";
                    SellConverted.Text = (num1 / num2).ToString("#,###.00");
                    TextBox16.Text = (num1 / num2).ToString("#,###.00");
                }
                /*
                if (Double.TryParse(TextBox17.Text, out num3))
                {
                    num3 = num3 / 100;
                    percent = (num1 / num2) * num3;
                    SellCommValue.Text = percent.ToString("#,###.00");
                    SellConverted.Text = (num1 / num2).ToString("#,###.00");
                    TextBox16.Text = ((num1 / num2) + percent).ToString("#,###.00");
                }
                else
                {
                    SellCommValue.Text = "0";
                    SellConverted.Text = (num1 / num2).ToString("#,###.00");
                    TextBox16.Text = (num1 / num2).ToString("#,###.00");
                }
                */
            }
            else
            {
                FlatFeeSellingConv.Text = "0";
                SellCommValue.Text = "0";
                SellConverted.Text = "0";
                TextBox16.Text = "NaN";
            }
        }

        

        private void TextBox17_TextChanged(object sender, EventArgs e)
        {
            double num1, num2, num3, num4, percent;
            if ((Double.TryParse(TextBox19.Text, out num1)) && (Double.TryParse(TextBox18.Text, out num2)))
            {
                if ((Double.TryParse(TextBox17.Text, out num3)) && (Double.TryParse(FlatFeeSellingTextBox.Text, out num4)))
                {
                    num3 = num3 / 100;
                    percent = (num1 / num2) * num3;
                    FlatFeeSellingConv.Text = num4.ToString("#,###.00");
                    SellCommValue.Text = percent.ToString("#,###.00");
                    SellConverted.Text = (num1 / num2).ToString("#,###.00");
                    TextBox16.Text = ((num1 / num2) + percent + num4).ToString("#,###.00");
                }
                else if (Double.TryParse(TextBox17.Text, out num3))
                {
                    num3 = num3 / 100;
                    percent = (num1 / num2) * num3;
                    FlatFeeSellingConv.Text = "0";
                    SellCommValue.Text = percent.ToString("#,###.00");
                    SellConverted.Text = (num1 / num2).ToString("#,###.00");
                    TextBox16.Text = ((num1 / num2) + percent).ToString("#,###.00");
                }
                else if (Double.TryParse(FlatFeeSellingTextBox.Text, out num4))
                {
                    FlatFeeSellingConv.Text = num4.ToString("#,###.00");
                    SellCommValue.Text = "0";
                    SellConverted.Text = (num1 / num2).ToString("#,###.00");
                    TextBox16.Text = ((num1 / num2) + num4).ToString("#,###.00");
                }
                else
                {
                    FlatFeeSellingConv.Text = "0";
                    SellCommValue.Text = "0";
                    SellConverted.Text = (num1 / num2).ToString("#,###.00");
                    TextBox16.Text = (num1 / num2).ToString("#,###.00");
                }
            }
            else
            {
                FlatFeeSellingConv.Text = "0";
                SellCommValue.Text = "0";
                SellConverted.Text = "0";
                TextBox16.Text = "NaN";
            }
        }

        private void FlatFeeSellingTextBox_TextChanged(object sender, EventArgs e)
        {
            double num1, num2, num3, num4, percent;
            if ((Double.TryParse(TextBox19.Text, out num1)) && (Double.TryParse(TextBox18.Text, out num2)))
            {
                if ((Double.TryParse(TextBox17.Text, out num3)) && (Double.TryParse(FlatFeeSellingTextBox.Text, out num4)))
                {
                    num3 = num3 / 100;
                    percent = (num1 / num2) * num3;
                    FlatFeeSellingConv.Text = num4.ToString("#,###.00");
                    SellCommValue.Text = percent.ToString("#,###.00");
                    SellConverted.Text = (num1 / num2).ToString("#,###.00");
                    TextBox16.Text = ((num1 / num2) + percent + num4).ToString("#,###.00");
                }
                else if (Double.TryParse(TextBox17.Text, out num3))
                {
                    num3 = num3 / 100;
                    percent = (num1 / num2) * num3;
                    FlatFeeSellingConv.Text = "0";
                    SellCommValue.Text = percent.ToString("#,###.00");
                    SellConverted.Text = (num1 / num2).ToString("#,###.00");
                    TextBox16.Text = ((num1 / num2) + percent).ToString("#,###.00");
                }
                else if (Double.TryParse(FlatFeeSellingTextBox.Text, out num4))
                {
                    FlatFeeSellingConv.Text = num4.ToString("#,###.00");
                    SellCommValue.Text = "0";
                    SellConverted.Text = (num1 / num2).ToString("#,###.00");
                    TextBox16.Text = ((num1 / num2) + num4).ToString("#,###.00");
                }
                else
                {
                    FlatFeeSellingConv.Text = "0";
                    SellCommValue.Text = "0";
                    SellConverted.Text = (num1 / num2).ToString("#,###.00");
                    TextBox16.Text = (num1 / num2).ToString("#,###.00");
                }
            }
            else
            {
                FlatFeeSellingConv.Text = "0";
                SellCommValue.Text = "0";
                SellConverted.Text = "0";
                TextBox16.Text = "NaN";
            }
        }



        private void SellingGo_Click(object sender, EventArgs e)
        {
            double percent, num1, num2, num3, num4;
            string num5;
            //double dummy;
            if ((Double.TryParse(TextBox16.Text, out num1)) && (Double.TryParse(TextBox18.Text, out num2)))
            {
                //dummy = num1;
                //num3 = num1 * num2;
                //TextBox19.Text = num3.ToString("#,###.00");

                if ((Double.TryParse(TextBox17.Text, out num3)) && (Double.TryParse(FlatFeeSellingTextBox.Text, out num4)))
                {
                    num3 = num3 / 100;
                    percent = num1 * num3;
                    num1 = num1 - percent - num4;
                    num5 = (num1 * num2).ToString("#,###.00");
                    FlatFeeSellingConv.Text = num4.ToString("#,###.00");
                    SellCommValue.Text = percent.ToString("#,###.00");
                    SellConverted.Text = num1.ToString("#,###.00");
                    TextBox19.Text = num5;
                }
                else if (Double.TryParse(TextBox17.Text, out num3))
                {
                    num3 = num3 / 100;
                    percent = num1 * num3;
                    num1 = num1 - percent;
                    num5 = (num1 * num2).ToString("#,###.00");
                    FlatFeeSellingConv.Text = "0";
                    SellCommValue.Text = percent.ToString("#,###.00");
                    SellConverted.Text = num1.ToString("#,###.00");
                    TextBox19.Text = num5;
                }
                else if (Double.TryParse(FlatFeeSellingTextBox.Text, out num4))
                {
                    num1 = num1 - num4;
                    num5 = (num1 * num2).ToString("#,###.00");
                    FlatFeeSellingConv.Text = num4.ToString("#,###.00");
                    SellCommValue.Text = "0";
                    SellConverted.Text = num1.ToString("#,###.00");
                    TextBox19.Text = num5;
                }
                else
                {
                    FlatFeeSellingConv.Text = "0";
                    SellCommValue.Text = "0";
                    SellConverted.Text = (num1 * num2).ToString("#,###.00");
                    TextBox19.Text = (num1 * num2).ToString("#,###.00");
                }

                //TextBox16.Text = dummy.ToString("#,###.00");
            }
            else
            {
                FlatFeeSellingConv.Text = "0";
                SellCommValue.Text = "0";
                SellConverted.Text = "0";
                TextBox16.Text = "NaN";
            }
        }
        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex >= 0)
            {
                TextBox8.Text = comboBox1.SelectedValue.ToString();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex >= 0)
            {
                TextBox18.Text = comboBox2.SelectedValue.ToString();
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.DefaultExt = ".csv";
            dialog.Filter = "CSV Files (*.csv)|*.csv";
            DialogResult result = dialog.ShowDialog();
            string fileName = dialog.FileName;
            textBoxPath.Text = fileName;
        }

        private void uploadButton_Click(object sender, EventArgs e)
        {
            DataSet myDataSet = new DataSet();

            DataTable dataTable = new DataTable("Currencies");
            dataTable.Columns.Add("Country");
            dataTable.Columns.Add("Code");
            dataTable.Columns.Add("Buying");
            dataTable.Columns.Add("Selling");


            string filePath = textBoxPath.Text;
            System.IO.StreamReader streamReader = new System.IO.StreamReader(filePath);
            String[] totalData = new String[File.ReadAllLines(filePath).Length];
            totalData = streamReader.ReadLine().Split(',');
            while (!streamReader.EndOfStream)
            {
                totalData = streamReader.ReadLine().Split(',');
                dataTable.Rows.Add(totalData[0], totalData[1], totalData[2], totalData[3]);
            }
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.DataSource = dataTable;
            myDataSet.Tables.Add(dataTable);

            comboBox1.DataSource = myDataSet.Tables["Currencies"].DefaultView;
            comboBox1.DisplayMember = "Code";
            comboBox1.ValueMember = "Buying";
            comboBox1.SelectedIndex = 0;
            TextBox8.Text = comboBox1.SelectedValue.ToString();

            comboBox2.DataSource = myDataSet.Tables["Currencies"].DefaultView;
            comboBox2.DisplayMember = "Code";
            comboBox2.ValueMember = "Selling";
            comboBox2.SelectedIndex = 0;
            TextBox18.Text = comboBox2.SelectedValue.ToString();

            //C:\Users\Awais\Desktop\Book.csv
        }


        public static String GetDatestamp(DateTime value)
        {
            return value.ToString("dd/MM/yyyy");
        }

        public static String GetTimestamp(DateTime value)
        {
            return value.ToString("hh:mm:ss tt");
        }

        private void BuyingPrintButton_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            PrintDocument printDoc = new PrintDocument();
            printDialog.Document = printDoc;
            printDoc.PrintPage += new PrintPageEventHandler(this.CreateBuyingReceipt);
            printDoc.Print();

            /*
            //DialogResult result = printDialog.ShowDialog();
            if (printDialog.ShowDialog() == DialogResult.Yes)
            {
                printDoc.PrintPage += new PrintPageEventHandler(this.CreateBuyingReceipt);
                printDoc.Print();
            }
            else
            {
                PrintPreviewDialog my1 = new PrintPreviewDialog();
                my1.Document = printDoc;
                my1.ShowDialog();
                
                //printDoc.Print();
                //MessageBox.Show(dateTimePicker1.Text);
                //labelTesting.Text = dateTimePicker1.Value.ToString("dd/MM/yyyy");
                MessageBox.Show("Printer not connected");
            }
            */
        }

        private int getNewBuyYPos()
        {
            BuyYPos += 20;
            return BuyYPos; 
        }

        
        public void CreateBuyingReceipt(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string ACN = getCompanyACN();
            string Address = getCompanyAddress();
            string companyName = getCompanyName();

            string currency = getBuyingCurrency();
            string commPer = getBuyingCommPer();
            string commVal = getBuyingCommVal();
            string buyingTotalVal = getBuyingTotal();
            string rateVal = getBuyingRate();
            string amountVal = getBuyingAmount();
            string flatFeeVal = getBuyingFlatFee();
            //int flatFeeVal = 8;
            string type = "BUY";
            string dateStamp = GetDatestamp(DateTime.Now);
            string timeStamp = GetTimestamp(DateTime.Now);

            Graphics graphic = e.Graphics;
            Font font = new Font("Arial", 10);

            float fontHeight = font.GetHeight();
            int startX = 10;
            BuyYPos = 180;

            graphic.DrawString(companyName, new Font("Arena Black", 18), new SolidBrush
                (Color.Black), 60, 10);

            graphic.DrawString("Receipt", new Font("Arial", 10), new SolidBrush(Color.Black), startX, 50);
            graphic.DrawString("A.C.N: " + ACN, new Font("Arial", 10), new SolidBrush(Color.Black), startX, 70);
            graphic.DrawString("Address: " + Address, new Font("Arial", 10), new SolidBrush(Color.Black), startX, 90);

            graphic.DrawString("Date: " + dateStamp + " " + timeStamp, new Font("Arial", 10), new SolidBrush(Color.Black), startX, BuyYPos);
            graphic.DrawString("Type: BUY", new Font("Arial", 10), new SolidBrush(Color.Black), startX, getNewBuyYPos());
            graphic.DrawString("Currency: " + currency, new Font("Arial", 10), new SolidBrush(Color.Black), startX, getNewBuyYPos());
            graphic.DrawString("Amount: " + amountVal, new Font("Arial", 10), new SolidBrush(Color.Black), startX, getNewBuyYPos());
            graphic.DrawString("Rate: " + rateVal, new Font("Arial", 10), new SolidBrush(Color.Black), startX, getNewBuyYPos());
            if (TextBox9.Text != "")
            {
                graphic.DrawString("Commission: " + commPer + " \u00A2 a dollar", new Font("Arial", 10), new SolidBrush(Color.Black), startX, getNewBuyYPos());
            }
            if (FlatFeeTextBox.Text != "")
            {
                graphic.DrawString("Flat Fee: " + flatFeeVal + " AUD", new Font("Arial", 10), new SolidBrush(Color.Black), startX, getNewBuyYPos());
            }
            graphic.DrawString("Total: " + buyingTotalVal, new Font("Arial", 10), new SolidBrush(Color.Black), startX, getNewBuyYPos());


            // Save Transaction
            string conn_string = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\POS\\myPos\\myPos\\myDatabase.mdf;Integrated Security=True";
            //string conn_string = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Program Files\\POS_Setup\\myDatabase.mdf;Integrated Security=True";
            //string conn_string = "Data Source=(LocalDB)\\MSSQLLocalDB;Integrated Security=True";


            string q1 = "Insert Into [TransactionTable] Values ('" + currency + "','" + type + "','" + amountVal + "','" + rateVal + "','" + buyingTotalVal + "','" + commVal + "', '" + flatFeeVal + "', '" + dateStamp + "', '" + timeStamp + "' )";
            string q2 = "Select * from [TransactionTable] where Date = '" + dateStamp + "'";
            //SqlConnection conn = null;
            try
            {
                SqlConnection conn = new SqlConnection(conn_string);
                conn.Open();

                SqlCommand cmd1 = new SqlCommand(q1, conn);
                SqlCommand cmd2 = new SqlCommand(q2, conn);

                cmd1.ExecuteNonQuery();

                SqlDataAdapter sda = new SqlDataAdapter();
                //sda.SelectCommand = cmd1;
                sda.SelectCommand = cmd2;


                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                tableDataGrid1.DataSource = bSource;
                sda.Update(dbdataset);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string conn_string = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\POS\\myPos\\myPos\\myDatabase.mdf;Integrated Security=True";
            //string conn_string = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Program Files\\POS_Setup\\myDatabase.mdf;Integrated Security=True";
            //string conn_string = "Data Source=(LocalDB)\\MSSQLLocalDB;Integrated Security=True";

            string q1 = "Select * from [TransactionTable] Where Date = '" + dateTimePicker1.Value.ToString("dd/MM/yyyy") + "'";

            try
            {
                SqlConnection conn = new SqlConnection(conn_string);
                conn.Open();

                SqlCommand cmd1 = new SqlCommand(q1, conn);

                SqlDataAdapter sda = new SqlDataAdapter();
                //sda.SelectCommand = cmd1;
                sda.SelectCommand = cmd1;

                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                tableDataGrid1.DataSource = bSource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //C:\Users\Awais\Desktop\Book.csv
        }

        private void SellingPrintButton_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            PrintDocument printDoc = new PrintDocument();
            printDialog.Document = printDoc;
            printDoc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(CreateSellingReceipt);
            printDoc.Print();
            /*
            DialogResult result = printDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                printDoc.Print();
            }
            else
            {
                PrintPreviewDialog my1 = new PrintPreviewDialog();
                my1.Document = printDoc;
                my1.ShowDialog();
                //MessageBox.Show(dateTimePicker1.Text);
                //labelTesting.Text = dateTimePicker1.Value.ToString("dd/MM/yyyy");
                MessageBox.Show("Printer not connected");
            }
            */
        }

        private int getNewSellYPos()
        {
            SellYPos += 20;
            return SellYPos;
        }

        public void CreateSellingReceipt(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string ACN = getCompanyACN();
            string Address = getCompanyAddress();
            string companyName = getCompanyName();

            string currency = getSellingCurrency();
            string commPer = getSellingCommPer();
            string commVal = getSellingCommVal();
            string buyingTotalVal = getSellingTotal();
            string rateVal = getSellingRate();
            string amountVal = getSellingAmount();
            string flatFeeVal = getSellingFlatFee();
            //int flatFeeVal = 8;
            string type = "SELL";
            string dateStamp = GetDatestamp(DateTime.Now);
            string timeStamp = GetTimestamp(DateTime.Now);

            Graphics graphic = e.Graphics;
            Font font = new Font("Arial", 10);

            float fontHeight = font.GetHeight();
            int startX = 10;
            SellYPos = 180;

            graphic.DrawString(companyName, new Font("Arena Black", 18), new SolidBrush
                (Color.Black), 60, 10);
            graphic.DrawString("Receipt", new Font("Arial", 10), new SolidBrush(Color.Black), startX, 50);
            graphic.DrawString("A.C.N: " +ACN, new Font("Arial", 10), new SolidBrush(Color.Black), startX, 70);
            graphic.DrawString("Address: " + Address, new Font("Arial", 10), new SolidBrush(Color.Black), startX, 90);

            graphic.DrawString("Date: " + dateStamp + " " + timeStamp, new Font("Arial", 10), new SolidBrush(Color.Black), startX, SellYPos);
            graphic.DrawString("Type: SELL", new Font("Arial", 10), new SolidBrush(Color.Black), startX, getNewSellYPos());
            graphic.DrawString("Currency: " + currency, new Font("Arial", 10), new SolidBrush(Color.Black), startX, getNewSellYPos());
            graphic.DrawString("Amount: " + amountVal, new Font("Arial", 10), new SolidBrush(Color.Black), startX, getNewSellYPos());
            graphic.DrawString("Rate: " + rateVal, new Font("Arial", 10), new SolidBrush(Color.Black), startX, getNewSellYPos());
            if (TextBox17.Text != "")
            {
                graphic.DrawString("Commission: " + commPer + " \u00A2 a dollar", new Font("Arial", 10), new SolidBrush(Color.Black), startX, getNewSellYPos());
            }
            if (FlatFeeSellingTextBox.Text != "")
            {
                graphic.DrawString("Flat Fee: " + flatFeeVal + " AUD", new Font("Arial", 10), new SolidBrush(Color.Black), startX, getNewSellYPos());
            }
            graphic.DrawString("Total: " + buyingTotalVal, new Font("Arial", 10), new SolidBrush(Color.Black), startX, getNewSellYPos());


            // Save Transaction
            string conn_string = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\POS\\myPos\\myPos\\myDatabase.mdf;Integrated Security=True";
            //string conn_string = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Program Files\\POS_Setup\\myDatabase.mdf;Integrated Security=True";
            //string conn_string = "Data Source=(LocalDB)\\MSSQLLocalDB;Integrated Security=True";


            string q1 = "Insert Into [TransactionTable] Values ('" + currency + "','" + type + "','" + amountVal + "','" + rateVal + "','" + buyingTotalVal + "','" + commVal + "', '" + flatFeeVal + "', '" + dateStamp + "', '" + timeStamp + "' )";
            string q2 = "Select * from [TransactionTable] where Date = '" + dateStamp + "'";
            //SqlConnection conn = null;
            try
            {
                SqlConnection conn = new SqlConnection(conn_string);
                conn.Open();

                SqlCommand cmd1 = new SqlCommand(q1, conn);
                SqlCommand cmd2 = new SqlCommand(q2, conn);

                cmd1.ExecuteNonQuery();

                SqlDataAdapter sda = new SqlDataAdapter();
                //sda.SelectCommand = cmd1;
                sda.SelectCommand = cmd2;


                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                tableDataGrid1.DataSource = bSource;
                sda.Update(dbdataset);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void StoreAddressTextBox_TextChanged(object sender, EventArgs e)
        {
            if (PasswordTextBox.Text == password)
            {
                MySettings.Default.StoreAddress = StoreAddressTextBox.Text;
                MySettings.Default.Save();
            }
        }
        private void CompanyTextBox_TextChanged(object sender, EventArgs e)
        {
            if (PasswordTextBox.Text == password)
            {
                MySettings.Default.CompanyName = CompanyTextBox.Text;
                MySettings.Default.Save();
            }
        }

        private void ACNTextBox_TextChanged(object sender, EventArgs e)
        {
            if (PasswordTextBox.Text == password)
            {
                MySettings.Default.ACN = ACNTextBox.Text;
                MySettings.Default.Save();
            }
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            if (PasswordTextBox.Text == password)
            {
                CompanyTextBox.Enabled = true;
                StoreAddressTextBox.Enabled = true;
                ACNTextBox.Enabled = true;
            }
            else
            {
                CompanyTextBox.Enabled = false;
                StoreAddressTextBox.Enabled = false;
                ACNTextBox.Enabled = false;
            }
        }

        private void TransactionPwdTextBox_TextChanged(object sender, EventArgs e)
        {
            if (TransactionPwdTextBox.Text == password)
            {
                ClearTransactionsButton.Enabled = true;
            }
            else
            {
                ClearTransactionsButton.Enabled = false;
            }
        }

        private void ClearTransactionsButton_Click(object sender, EventArgs e)
        {
            if (TransactionPwdTextBox.Text == password)
            {
                string conn_string = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\POS\\myPos\\myPos\\myDatabase.mdf;Integrated Security=True";
                //string conn_string = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Program Files\\POS_Setup\\myDatabase.mdf;Integrated Security=True";
                //string conn_string = "Data Source=(LocalDB)\\MSSQLLocalDB;Integrated Security=True";

                string q1 = "Delete from [TransactionTable]";

                var confirmResult = MessageBox.Show("Are you sure you want to delete all the transactions?", "Confirmation", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        SqlConnection conn = new SqlConnection(conn_string);
                        conn.Open();

                        SqlCommand cmd1 = new SqlCommand(q1, conn);
                        cmd1.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                
            }
        }

        private void tabPage3_Leave(object sender, EventArgs e)
        {
            PasswordTextBox.Text = "";
        }

        private void tabPage4_Leave(object sender, EventArgs e)
        {
            TransactionPwdTextBox.Text = "";
        }

        private void tabPage4_Enter(object sender, EventArgs e)
        {
            string dateStamp = GetDatestamp(DateTime.Now);
            
            //string conn_string = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Program Files\\POS_Setup\\myDatabase.mdf;Integrated Security=True";
            //string conn_string = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\POS\\myPos\\myPos\\myDatabase.mdf;Integrated Security=True";
            string conn_string = "Data Source=(LocalDB)\\MSSQLLocalDB;Integrated Security=True";




            string q1 = "Create Database [myDaatabase] On (NAME='myDaatabase', FILENAME = 'C:\\Usama\\myPos\\myDaatabase.mdf')";
            string q5 = "Use [myDaatabase]";
            string q2 = "CREATE TABLE [TransacctionTable] ([CurrencyCode] VARCHAR(50) NOT NULL, [Type] VARCHAR(50) NOT NULL, [Amount] VARCHAR(50) NOT NULL, [Rate] VARCHAR(50) NOT NULL, [Total] VARCHAR(50) NOT NULL, [Commission] VARCHAR(50) NULL, [FlatFee] VARCHAR(50) NULL, [Date] VARCHAR(50) NOT NULL, [Time] VARCHAR(50) NULL";
            try
            {
                SqlConnection conn = new SqlConnection(conn_string);
                conn.Open();
                SqlCommand cmd1 = new SqlCommand(q1, conn);
                SqlCommand cmd2 = new SqlCommand(q2, conn);
                SqlCommand cmd3 = new SqlCommand(q5, conn);

                cmd1.ExecuteNonQuery();
                cmd3.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //string q3 = "Select * from [TransactionTable] where Date = '" + dateStamp + "'";
            //DataTable dt = new DataTable("TransactionTable");






            string q3 = "Select * from [TransacctionTable] where Date = '" + dateStamp + "'";
            
            
            //string q1 = "Select * from [TransactionTable] where Date = '" + dateStamp + "'";
            //SqlConnection conn = null;
            try
            {
                SqlConnection conn = new SqlConnection(conn_string);
                conn.Open();
                SqlCommand cmd1 = new SqlCommand(q3, conn);

                SqlDataAdapter sda = new SqlDataAdapter();
                //sda.SelectCommand = cmd1;
                sda.SelectCommand = cmd1;


                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                tableDataGrid1.DataSource = bSource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}