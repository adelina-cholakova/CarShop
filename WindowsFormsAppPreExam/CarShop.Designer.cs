namespace WindowsFormsAppPreExam
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chooseModelCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.basePriceTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.firstExtraChB = new System.Windows.Forms.CheckBox();
            this.secondExtraChB = new System.Windows.Forms.CheckBox();
            this.thirdExtraChB = new System.Windows.Forms.CheckBox();
            this.carsPictureBox = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.priceExtrasTb = new System.Windows.Forms.TextBox();
            this.discountTb = new System.Windows.Forms.TextBox();
            this.finalPriceTb = new System.Windows.Forms.TextBox();
            this.calcBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.carsPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // chooseModelCB
            // 
            this.chooseModelCB.FormattingEnabled = true;
            this.chooseModelCB.Items.AddRange(new object[] {
            "Audi",
            "BMW",
            "KIA"});
            this.chooseModelCB.Location = new System.Drawing.Point(59, 38);
            this.chooseModelCB.Name = "chooseModelCB";
            this.chooseModelCB.Size = new System.Drawing.Size(220, 24);
            this.chooseModelCB.TabIndex = 0;
            this.chooseModelCB.SelectedIndexChanged += new System.EventHandler(this.chooseModelCB_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Базова цена:";
            // 
            // basePriceTb
            // 
            this.basePriceTb.Enabled = false;
            this.basePriceTb.Location = new System.Drawing.Point(179, 100);
            this.basePriceTb.Name = "basePriceTb";
            this.basePriceTb.Size = new System.Drawing.Size(100, 22);
            this.basePriceTb.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Добави екстри:";
            // 
            // firstExtraChB
            // 
            this.firstExtraChB.AutoSize = true;
            this.firstExtraChB.Location = new System.Drawing.Point(69, 206);
            this.firstExtraChB.Name = "firstExtraChB";
            this.firstExtraChB.Size = new System.Drawing.Size(57, 21);
            this.firstExtraChB.TabIndex = 4;
            this.firstExtraChB.Text = "ABS";
            this.firstExtraChB.UseVisualStyleBackColor = true;
            this.firstExtraChB.CheckedChanged += new System.EventHandler(this.firstExtraChB_CheckedChanged);
            // 
            // secondExtraChB
            // 
            this.secondExtraChB.AutoSize = true;
            this.secondExtraChB.Location = new System.Drawing.Point(69, 248);
            this.secondExtraChB.Name = "secondExtraChB";
            this.secondExtraChB.Size = new System.Drawing.Size(144, 21);
            this.secondExtraChB.TabIndex = 5;
            this.secondExtraChB.Text = "Фарове за мъгла";
            this.secondExtraChB.UseVisualStyleBackColor = true;
            this.secondExtraChB.CheckedChanged += new System.EventHandler(this.secondExtraChB_CheckedChanged);
            // 
            // thirdExtraChB
            // 
            this.thirdExtraChB.AutoSize = true;
            this.thirdExtraChB.Location = new System.Drawing.Point(69, 289);
            this.thirdExtraChB.Name = "thirdExtraChB";
            this.thirdExtraChB.Size = new System.Drawing.Size(109, 21);
            this.thirdExtraChB.TabIndex = 6;
            this.thirdExtraChB.Text = "Парктроник";
            this.thirdExtraChB.UseVisualStyleBackColor = true;
            this.thirdExtraChB.CheckedChanged += new System.EventHandler(this.thirdExtraChB_CheckedChanged);
            // 
            // carsPictureBox
            // 
            this.carsPictureBox.Image = global::WindowsFormsAppPreExam.Properties.Resources.kia;
            this.carsPictureBox.Location = new System.Drawing.Point(464, 38);
            this.carsPictureBox.Name = "carsPictureBox";
            this.carsPictureBox.Size = new System.Drawing.Size(308, 242);
            this.carsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.carsPictureBox.TabIndex = 7;
            this.carsPictureBox.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(365, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Цена с избраните екстри:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(365, 365);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Отстъпка(1%):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(365, 408);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Общо:";
            // 
            // priceExtrasTb
            // 
            this.priceExtrasTb.Location = new System.Drawing.Point(569, 318);
            this.priceExtrasTb.Name = "priceExtrasTb";
            this.priceExtrasTb.Size = new System.Drawing.Size(137, 22);
            this.priceExtrasTb.TabIndex = 11;
            this.priceExtrasTb.Visible = false;
            this.priceExtrasTb.TextChanged += new System.EventHandler(this.priceExtrasTb_TextChanged);
            // 
            // discountTb
            // 
            this.discountTb.Location = new System.Drawing.Point(569, 362);
            this.discountTb.Name = "discountTb";
            this.discountTb.Size = new System.Drawing.Size(137, 22);
            this.discountTb.TabIndex = 12;
            this.discountTb.Visible = false;
            this.discountTb.TextChanged += new System.EventHandler(this.discountTb_TextChanged);
            // 
            // finalPriceTb
            // 
            this.finalPriceTb.Location = new System.Drawing.Point(569, 408);
            this.finalPriceTb.Name = "finalPriceTb";
            this.finalPriceTb.Size = new System.Drawing.Size(137, 22);
            this.finalPriceTb.TabIndex = 13;
            this.finalPriceTb.Visible = false;
            // 
            // calcBtn
            // 
            this.calcBtn.Location = new System.Drawing.Point(66, 342);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(112, 42);
            this.calcBtn.TabIndex = 14;
            this.calcBtn.Text = "Пресметни";
            this.calcBtn.UseVisualStyleBackColor = true;
            this.calcBtn.Click += new System.EventHandler(this.calcBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(65, 408);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(113, 48);
            this.exitBtn.TabIndex = 15;
            this.exitBtn.Text = "Изход";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(111, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Избери модел";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 539);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.finalPriceTb);
            this.Controls.Add(this.discountTb);
            this.Controls.Add(this.priceExtrasTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.carsPictureBox);
            this.Controls.Add(this.thirdExtraChB);
            this.Controls.Add(this.secondExtraChB);
            this.Controls.Add(this.firstExtraChB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.basePriceTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chooseModelCB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carsPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox chooseModelCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox basePriceTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox firstExtraChB;
        private System.Windows.Forms.CheckBox secondExtraChB;
        private System.Windows.Forms.CheckBox thirdExtraChB;
        private System.Windows.Forms.PictureBox carsPictureBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox priceExtrasTb;
        private System.Windows.Forms.TextBox discountTb;
        private System.Windows.Forms.TextBox finalPriceTb;
        private System.Windows.Forms.Button calcBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label label6;
    }
}

