namespace tip_calculator
{
    partial class tip_calculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.bill_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tip5_btn = new System.Windows.Forms.Button();
            this.tip10_btn = new System.Windows.Forms.Button();
            this.tip15_btn = new System.Windows.Forms.Button();
            this.tip25_btn = new System.Windows.Forms.Button();
            this.tip50_btn = new System.Windows.Forms.Button();
            this.customTip_box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tipAmount_box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.totalAmount_box = new System.Windows.Forms.TextBox();
            this.calculate_btn = new System.Windows.Forms.Button();
            this.nPeople_box = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "bill";
            // 
            // bill_box
            // 
            this.bill_box.Location = new System.Drawing.Point(30, 34);
            this.bill_box.Name = "bill_box";
            this.bill_box.Size = new System.Drawing.Size(246, 20);
            this.bill_box.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "select tip";
            // 
            // tip5_btn
            // 
            this.tip5_btn.BackColor = System.Drawing.Color.DarkCyan;
            this.tip5_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tip5_btn.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tip5_btn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.tip5_btn.Location = new System.Drawing.Point(30, 128);
            this.tip5_btn.Name = "tip5_btn";
            this.tip5_btn.Size = new System.Drawing.Size(119, 23);
            this.tip5_btn.TabIndex = 3;
            this.tip5_btn.Text = "5%";
            this.tip5_btn.UseVisualStyleBackColor = false;
            this.tip5_btn.Click += new System.EventHandler(this.tip5_btn_Click);
            // 
            // tip10_btn
            // 
            this.tip10_btn.BackColor = System.Drawing.Color.DarkCyan;
            this.tip10_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tip10_btn.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tip10_btn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.tip10_btn.Location = new System.Drawing.Point(157, 128);
            this.tip10_btn.Name = "tip10_btn";
            this.tip10_btn.Size = new System.Drawing.Size(119, 23);
            this.tip10_btn.TabIndex = 4;
            this.tip10_btn.Text = "10%";
            this.tip10_btn.UseVisualStyleBackColor = false;
            this.tip10_btn.Click += new System.EventHandler(this.tip10_btn_Click);
            // 
            // tip15_btn
            // 
            this.tip15_btn.BackColor = System.Drawing.Color.DarkCyan;
            this.tip15_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tip15_btn.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tip15_btn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.tip15_btn.Location = new System.Drawing.Point(30, 157);
            this.tip15_btn.Name = "tip15_btn";
            this.tip15_btn.Size = new System.Drawing.Size(119, 23);
            this.tip15_btn.TabIndex = 5;
            this.tip15_btn.Text = "15%";
            this.tip15_btn.UseVisualStyleBackColor = false;
            this.tip15_btn.Click += new System.EventHandler(this.tip15_btn_Click);
            // 
            // tip25_btn
            // 
            this.tip25_btn.BackColor = System.Drawing.Color.DarkCyan;
            this.tip25_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tip25_btn.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tip25_btn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.tip25_btn.Location = new System.Drawing.Point(157, 157);
            this.tip25_btn.Name = "tip25_btn";
            this.tip25_btn.Size = new System.Drawing.Size(119, 23);
            this.tip25_btn.TabIndex = 6;
            this.tip25_btn.Text = "25%";
            this.tip25_btn.UseVisualStyleBackColor = false;
            this.tip25_btn.Click += new System.EventHandler(this.tip25_btn_Click);
            // 
            // tip50_btn
            // 
            this.tip50_btn.BackColor = System.Drawing.Color.DarkCyan;
            this.tip50_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tip50_btn.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tip50_btn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.tip50_btn.Location = new System.Drawing.Point(30, 186);
            this.tip50_btn.Name = "tip50_btn";
            this.tip50_btn.Size = new System.Drawing.Size(119, 23);
            this.tip50_btn.TabIndex = 7;
            this.tip50_btn.Text = "50%";
            this.tip50_btn.UseVisualStyleBackColor = false;
            this.tip50_btn.Click += new System.EventHandler(this.tip50_btn_Click);
            // 
            // customTip_box
            // 
            this.customTip_box.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customTip_box.Location = new System.Drawing.Point(157, 187);
            this.customTip_box.Name = "customTip_box";
            this.customTip_box.Size = new System.Drawing.Size(119, 21);
            this.customTip_box.TabIndex = 8;
            this.customTip_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(81, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 14);
            this.label3.TabIndex = 9;
            this.label3.Text = "tip amount";
            // 
            // tipAmount_box
            // 
            this.tipAmount_box.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipAmount_box.Location = new System.Drawing.Point(157, 295);
            this.tipAmount_box.Name = "tipAmount_box";
            this.tipAmount_box.Size = new System.Drawing.Size(119, 21);
            this.tipAmount_box.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(81, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 14);
            this.label4.TabIndex = 11;
            this.label4.Text = "total";
            // 
            // totalAmount_box
            // 
            this.totalAmount_box.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalAmount_box.Location = new System.Drawing.Point(157, 325);
            this.totalAmount_box.Name = "totalAmount_box";
            this.totalAmount_box.Size = new System.Drawing.Size(119, 21);
            this.totalAmount_box.TabIndex = 12;
            // 
            // calculate_btn
            // 
            this.calculate_btn.BackColor = System.Drawing.Color.DarkCyan;
            this.calculate_btn.Cursor = System.Windows.Forms.Cursors.Default;
            this.calculate_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculate_btn.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculate_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.calculate_btn.Location = new System.Drawing.Point(193, 231);
            this.calculate_btn.Name = "calculate_btn";
            this.calculate_btn.Size = new System.Drawing.Size(83, 23);
            this.calculate_btn.TabIndex = 13;
            this.calculate_btn.Text = "calculate";
            this.calculate_btn.UseVisualStyleBackColor = false;
            this.calculate_btn.Click += new System.EventHandler(this.calculate_btn_Click);
            // 
            // nPeople_box
            // 
            this.nPeople_box.Location = new System.Drawing.Point(30, 80);
            this.nPeople_box.Name = "nPeople_box";
            this.nPeople_box.Size = new System.Drawing.Size(246, 20);
            this.nPeople_box.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 14);
            this.label5.TabIndex = 14;
            this.label5.Text = "n. of people";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(82, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 10);
            this.label6.TabIndex = 16;
            this.label6.Text = "/pp";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(82, 336);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 10);
            this.label7.TabIndex = 17;
            this.label7.Text = "/pp";
            // 
            // tip_calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(309, 358);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nPeople_box);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.calculate_btn);
            this.Controls.Add(this.totalAmount_box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tipAmount_box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.customTip_box);
            this.Controls.Add(this.tip50_btn);
            this.Controls.Add(this.tip25_btn);
            this.Controls.Add(this.tip15_btn);
            this.Controls.Add(this.tip10_btn);
            this.Controls.Add(this.tip5_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bill_box);
            this.Controls.Add(this.label1);
            this.Name = "tip_calculator";
            this.Text = "tip_calculator";
            this.Load += new System.EventHandler(this.tip_calculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bill_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button tip5_btn;
        private System.Windows.Forms.Button tip10_btn;
        private System.Windows.Forms.Button tip15_btn;
        private System.Windows.Forms.Button tip25_btn;
        private System.Windows.Forms.Button tip50_btn;
        private System.Windows.Forms.TextBox customTip_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tipAmount_box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox totalAmount_box;
        private System.Windows.Forms.Button calculate_btn;
        private System.Windows.Forms.TextBox nPeople_box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

