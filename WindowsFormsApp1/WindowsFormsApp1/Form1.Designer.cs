namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.enterAmount = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.inputAmountElements = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // enterAmount
            // 
            this.enterAmount.Font = new System.Drawing.Font("HP Simplified", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enterAmount.Location = new System.Drawing.Point(383, 244);
            this.enterAmount.Name = "enterAmount";
            this.enterAmount.Size = new System.Drawing.Size(138, 65);
            this.enterAmount.TabIndex = 0;
            this.enterAmount.Text = "Ввод";
            this.enterAmount.UseVisualStyleBackColor = true;
            this.enterAmount.Click += new System.EventHandler(this.enterAmountClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HP Simplified", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(53, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(468, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите количество элементов последовательности";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // inputAmountElements
            // 
            this.inputAmountElements.BackColor = System.Drawing.Color.LightSteelBlue;
            this.inputAmountElements.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputAmountElements.Font = new System.Drawing.Font("HP Simplified", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputAmountElements.Location = new System.Drawing.Point(130, 114);
            this.inputAmountElements.MinimumSize = new System.Drawing.Size(0, 50);
            this.inputAmountElements.Name = "inputAmountElements";
            this.inputAmountElements.Size = new System.Drawing.Size(286, 50);
            this.inputAmountElements.TabIndex = 2;
            this.inputAmountElements.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 321);
            this.Controls.Add(this.inputAmountElements);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.enterAmount);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button enterAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputAmountElements;
    }
}

