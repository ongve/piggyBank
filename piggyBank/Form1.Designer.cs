namespace piggyBank
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnFold = new System.Windows.Forms.Button();
            this.btnShake = new System.Windows.Forms.Button();
            this.btnFix = new System.Windows.Forms.Button();
            this.btnBreak = new System.Windows.Forms.Button();
            this.btnThrowMoney = new System.Windows.Forms.Button();
            this.cBoxMoneyType = new System.Windows.Forms.ComboBox();
            this.cBoxMoneyValue = new System.Windows.Forms.ComboBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelMoney = new System.Windows.Forms.Label();
            this.labelPercent = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.No;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(282, -90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(392, 312);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnFold
            // 
            this.btnFold.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnFold.Font = new System.Drawing.Font("Comic Sans MS", 10.18868F, System.Drawing.FontStyle.Bold);
            this.btnFold.Location = new System.Drawing.Point(69, 214);
            this.btnFold.Name = "btnFold";
            this.btnFold.Size = new System.Drawing.Size(126, 60);
            this.btnFold.TabIndex = 1;
            this.btnFold.Text = "BANKNOTU KATLA";
            this.btnFold.UseVisualStyleBackColor = false;
            this.btnFold.Click += new System.EventHandler(this.btnFold_Click);
            // 
            // btnShake
            // 
            this.btnShake.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnShake.Font = new System.Drawing.Font("Comic Sans MS", 10.18868F, System.Drawing.FontStyle.Bold);
            this.btnShake.Location = new System.Drawing.Point(69, 399);
            this.btnShake.Name = "btnShake";
            this.btnShake.Size = new System.Drawing.Size(126, 60);
            this.btnShake.TabIndex = 2;
            this.btnShake.Text = "SALLA";
            this.btnShake.UseVisualStyleBackColor = false;
            this.btnShake.Click += new System.EventHandler(this.btnShack_Click);
            // 
            // btnFix
            // 
            this.btnFix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnFix.Font = new System.Drawing.Font("Comic Sans MS", 10.18868F, System.Drawing.FontStyle.Bold);
            this.btnFix.Location = new System.Drawing.Point(755, 307);
            this.btnFix.Name = "btnFix";
            this.btnFix.Size = new System.Drawing.Size(126, 60);
            this.btnFix.TabIndex = 3;
            this.btnFix.Text = "ONAR";
            this.btnFix.UseVisualStyleBackColor = false;
            this.btnFix.Click += new System.EventHandler(this.btnFix_Click);
            // 
            // btnBreak
            // 
            this.btnBreak.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnBreak.Font = new System.Drawing.Font("Comic Sans MS", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBreak.Location = new System.Drawing.Point(755, 214);
            this.btnBreak.Name = "btnBreak";
            this.btnBreak.Size = new System.Drawing.Size(126, 60);
            this.btnBreak.TabIndex = 4;
            this.btnBreak.Text = "KUMBARAYI KIR";
            this.btnBreak.UseVisualStyleBackColor = false;
            this.btnBreak.Click += new System.EventHandler(this.btnBreak_Click);
            // 
            // btnThrowMoney
            // 
            this.btnThrowMoney.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnThrowMoney.Font = new System.Drawing.Font("Comic Sans MS", 10.18868F, System.Drawing.FontStyle.Bold);
            this.btnThrowMoney.Location = new System.Drawing.Point(69, 307);
            this.btnThrowMoney.Name = "btnThrowMoney";
            this.btnThrowMoney.Size = new System.Drawing.Size(126, 60);
            this.btnThrowMoney.TabIndex = 5;
            this.btnThrowMoney.Text = "PARA AT";
            this.btnThrowMoney.UseVisualStyleBackColor = false;
            this.btnThrowMoney.Click += new System.EventHandler(this.btnThrowMoney_Click);
            // 
            // cBoxMoneyType
            // 
            this.cBoxMoneyType.FormattingEnabled = true;
            this.cBoxMoneyType.Location = new System.Drawing.Point(12, 66);
            this.cBoxMoneyType.Name = "cBoxMoneyType";
            this.cBoxMoneyType.Size = new System.Drawing.Size(242, 21);
            this.cBoxMoneyType.TabIndex = 6;
            this.cBoxMoneyType.SelectedIndexChanged += new System.EventHandler(this.cBoxMoneyType_SelectedIndexChanged);
            // 
            // cBoxMoneyValue
            // 
            this.cBoxMoneyValue.FormattingEnabled = true;
            this.cBoxMoneyValue.Location = new System.Drawing.Point(12, 138);
            this.cBoxMoneyValue.Name = "cBoxMoneyValue";
            this.cBoxMoneyValue.Size = new System.Drawing.Size(242, 21);
            this.cBoxMoneyValue.TabIndex = 7;
            this.cBoxMoneyValue.SelectedIndexChanged += new System.EventHandler(this.cBoxMoneyValue_SelectedIndexChanged);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(282, 228);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(392, 30);
            this.progressBar.TabIndex = 8;
            this.progressBar.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Comic Sans MS", 8.150944F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(12, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(242, 24);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "Kağıt Para & Bozuk Para";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Comic Sans MS", 8.150944F, System.Drawing.FontStyle.Italic);
            this.textBox2.Location = new System.Drawing.Point(12, 112);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(242, 24);
            this.textBox2.TabIndex = 10;
            this.textBox2.Text = "Paranın Değeri";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // labelMoney
            // 
            this.labelMoney.AutoSize = true;
            this.labelMoney.Font = new System.Drawing.Font("Comic Sans MS", 10.18868F, System.Drawing.FontStyle.Bold);
            this.labelMoney.Location = new System.Drawing.Point(751, 89);
            this.labelMoney.Name = "labelMoney";
            this.labelMoney.Size = new System.Drawing.Size(124, 23);
            this.labelMoney.TabIndex = 11;
            this.labelMoney.Text = "Birikim Miktarı";
            this.labelMoney.Click += new System.EventHandler(this.labelMoney_Click);
            // 
            // labelPercent
            // 
            this.labelPercent.AutoSize = true;
            this.labelPercent.Location = new System.Drawing.Point(461, 240);
            this.labelPercent.Name = "labelPercent";
            this.labelPercent.Size = new System.Drawing.Size(0, 15);
            this.labelPercent.TabIndex = 13;
            this.labelPercent.Click += new System.EventHandler(this.labelPercent_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(282, 294);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(392, 238);
            this.listBox1.TabIndex = 14;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(946, 573);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.labelPercent);
            this.Controls.Add(this.labelMoney);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.cBoxMoneyValue);
            this.Controls.Add(this.cBoxMoneyType);
            this.Controls.Add(this.btnThrowMoney);
            this.Controls.Add(this.btnBreak);
            this.Controls.Add(this.btnFix);
            this.Controls.Add(this.btnShake);
            this.Controls.Add(this.btnFold);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnFold;
        private System.Windows.Forms.Button btnShake;
        private System.Windows.Forms.Button btnFix;
        private System.Windows.Forms.Button btnBreak;
        private System.Windows.Forms.Button btnThrowMoney;
        private System.Windows.Forms.ComboBox cBoxMoneyType;
        private System.Windows.Forms.ComboBox cBoxMoneyValue;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelMoney;
        private System.Windows.Forms.Label labelPercent;
        private System.Windows.Forms.ListBox listBox1;
    }
}

