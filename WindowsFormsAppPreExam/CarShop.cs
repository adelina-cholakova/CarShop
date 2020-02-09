using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppPreExam
{
    public partial class Form1 : Form
    {
        double basePrice;
        double price;
        
        public Form1()
        {
            InitializeComponent();
            this.Text = "Конфигуриране на модел";
        }

        private void chooseModelCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chooseModelCB.SelectedIndex == 0)
            {
                carsPictureBox.Image = Properties.Resources.audi;
                basePrice = 5000;
                price = 5000;
                basePriceTb.Text = basePrice.ToString();

                
            }
            else if (chooseModelCB.SelectedIndex == 1)
            {
                carsPictureBox.Image = Properties.Resources.bmw;
                basePrice = 10000;
                price = 10000;
                basePriceTb.Text = basePrice.ToString();
            }
            else if (chooseModelCB.SelectedIndex == 2)
            {
                carsPictureBox.Image = Properties.Resources.kia;
                basePrice = 7000;
                price = 7000;
                basePriceTb.Text = basePrice.ToString();
            }
            
        }
        

        private void firstExtraChB_CheckedChanged(object sender, EventArgs e)
        {
            
            
            if (firstExtraChB.Checked)
            {
                price +=100;
                
            }
            else 
            {
                price -= 100;
               
            }

            priceExtrasTb.Text = price.ToString();
            priceExtrasTb.Visible = true;

        }

        private void secondExtraChB_CheckedChanged(object sender, EventArgs e)
        {
            if (secondExtraChB.Checked == true)
            {
                price += 200;
                
            }
            else if (secondExtraChB.Checked == false)
            {
                price -= 200;
                
            }

            priceExtrasTb.Text = price.ToString();
            priceExtrasTb.Visible = true;
        }

        private void thirdExtraChB_CheckedChanged(object sender, EventArgs e)
        {
            if (thirdExtraChB.Checked == true)
            {
                price +=550;
                
            }
            else if (thirdExtraChB.Checked == false)
            {
                price -= 550;
                
            }

            priceExtrasTb.Text = price.ToString();
            priceExtrasTb.Visible = true;
        }

        private void discountTb_TextChanged(object sender, EventArgs e)
        {
            //discountTb.Text = (0.01 * price).ToString();
            //discountTb.Visible = true;
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            priceExtrasTb.Visible = true;
            if (firstExtraChB.Checked && secondExtraChB.Checked && thirdExtraChB.Checked)
            {
                discountTb.Text = (0.01 * price).ToString();
            }
            else
            {
                discountTb.Text = "0";
            }
            
            discountTb.Visible = finalPriceTb.Visible = true;
            finalPriceTb.Text = (price - double.Parse(discountTb.Text)).ToString();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            carsPictureBox.Image = null;
        }

        private void priceExtrasTb_TextChanged(object sender, EventArgs e)
        {
            if (firstExtraChB.Checked && secondExtraChB.Checked && thirdExtraChB.Checked)
            {
                discountTb.Text = (0.01 * price).ToString();
            }
            else
            {
                discountTb.Text = "0";
            }

            
            finalPriceTb.Text = (price - double.Parse(discountTb.Text)).ToString();
        }
    }
}
