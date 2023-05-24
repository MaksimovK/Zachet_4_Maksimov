namespace Zachet_4_Maksimov
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
            this.cmbSign = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenericA = new System.Windows.Forms.Button();
            this.btnGenericB = new System.Windows.Forms.Button();
            this.txtLetter = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtColors = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbSign
            // 
            this.cmbSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbSign.FormattingEnabled = true;
            this.cmbSign.Items.AddRange(new object[] { "Буква", "Число", "Цвет" });
            this.cmbSign.Location = new System.Drawing.Point(31, 43);
            this.cmbSign.Name = "cmbSign";
            this.cmbSign.Size = new System.Drawing.Size(178, 32);
            this.cmbSign.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(31, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите признак";
            // 
            // btnGenericA
            // 
            this.btnGenericA.Location = new System.Drawing.Point(58, 97);
            this.btnGenericA.Name = "btnGenericA";
            this.btnGenericA.Size = new System.Drawing.Size(115, 42);
            this.btnGenericA.TabIndex = 2;
            this.btnGenericA.Text = "Задание А";
            this.btnGenericA.UseVisualStyleBackColor = true;
            this.btnGenericA.Click += new System.EventHandler(this.btnGenericA_Click);
            // 
            // btnGenericB
            // 
            this.btnGenericB.Location = new System.Drawing.Point(478, 97);
            this.btnGenericB.Name = "btnGenericB";
            this.btnGenericB.Size = new System.Drawing.Size(115, 42);
            this.btnGenericB.TabIndex = 3;
            this.btnGenericB.Text = "Задание Б";
            this.btnGenericB.UseVisualStyleBackColor = true;
            this.btnGenericB.Click += new System.EventHandler(this.btnGenericB_Click);
            // 
            // txtLetter
            // 
            this.txtLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtLetter.Location = new System.Drawing.Point(285, 46);
            this.txtLetter.Name = "txtLetter";
            this.txtLetter.Size = new System.Drawing.Size(142, 29);
            this.txtLetter.TabIndex = 4;
            // 
            // txtNumber
            // 
            this.txtNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtNumber.Location = new System.Drawing.Point(464, 46);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(142, 29);
            this.txtNumber.TabIndex = 5;
            // 
            // txtColors
            // 
            this.txtColors.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtColors.Location = new System.Drawing.Point(626, 46);
            this.txtColors.Name = "txtColors";
            this.txtColors.Size = new System.Drawing.Size(142, 29);
            this.txtColors.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(283, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Введите Букву";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(456, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Введите Цифру";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(626, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Введите Цвет";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(257, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 42);
            this.button1.TabIndex = 10;
            this.button1.Text = "Прочитать из файла";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 158);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtColors);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.txtLetter);
            this.Controls.Add(this.btnGenericB);
            this.Controls.Add(this.btnGenericA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSign);
            this.Name = "Form1";
            this.Text = "Декартонные произведения";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtColors;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.TextBox txtLetter;

        private System.Windows.Forms.Button btnGenericB;

        private System.Windows.Forms.Button btnGenericA;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.ComboBox cmbSign;

        #endregion
    }
}