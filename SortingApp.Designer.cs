namespace WindowsFormsApp1
{
    partial class SortingApp
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
            this.back = new System.Windows.Forms.Button();
            this.further = new System.Windows.Forms.Button();
            this.amountElementsSequence = new System.Windows.Forms.Panel();
            this.inputSequenceHandly = new System.Windows.Forms.Panel();
            this.inputSequenceRandomly = new System.Windows.Forms.Panel();
            this.mergeSort = new System.Windows.Forms.Panel();
            this.tests = new System.Windows.Forms.Panel();
            this.button23 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.button24 = new System.Windows.Forms.Button();
            this.lastWindow = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.button22 = new System.Windows.Forms.Button();
            this.cBubble = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pBubble = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.outputBubbleSorted = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.outputElements = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.amountInputingElements = new System.Windows.Forms.Label();
            this.deleteElements = new System.Windows.Forms.Button();
            this.tableNumbers = new System.Windows.Forms.TableLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.inputElements = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.inputSequenceChoice = new System.Windows.Forms.Panel();
            this.handlyFilling = new System.Windows.Forms.CheckBox();
            this.randomFilling = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.deleteButton = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.inputAmountElements = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.amountElementsSequence.SuspendLayout();
            this.inputSequenceHandly.SuspendLayout();
            this.inputSequenceRandomly.SuspendLayout();
            this.mergeSort.SuspendLayout();
            this.tests.SuspendLayout();
            this.lastWindow.SuspendLayout();
            this.tableNumbers.SuspendLayout();
            this.inputSequenceChoice.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(140)))), ((int)(((byte)(3)))));
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Font = new System.Drawing.Font("Microsoft JhengHei UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(236)))), ((int)(((byte)(228)))));
            this.back.Location = new System.Drawing.Point(31, 371);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(146, 70);
            this.back.TabIndex = 6;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.previousButton);
            // 
            // further
            // 
            this.further.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(140)))), ((int)(((byte)(3)))));
            this.further.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.further.Font = new System.Drawing.Font("Microsoft JhengHei UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.further.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(236)))), ((int)(((byte)(228)))));
            this.further.Location = new System.Drawing.Point(612, 371);
            this.further.Name = "further";
            this.further.Size = new System.Drawing.Size(146, 70);
            this.further.TabIndex = 7;
            this.further.Text = "Next";
            this.further.UseVisualStyleBackColor = false;
            this.further.Click += new System.EventHandler(this.nextButton);
            // 
            // amountElementsSequence
            // 
            this.amountElementsSequence.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(64)))), ((int)(((byte)(26)))));
            this.amountElementsSequence.Controls.Add(this.tests);
            this.amountElementsSequence.Controls.Add(this.tableLayoutPanel1);
            this.amountElementsSequence.Controls.Add(this.inputAmountElements);
            this.amountElementsSequence.Controls.Add(this.label1);
            this.amountElementsSequence.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amountElementsSequence.Location = new System.Drawing.Point(0, 0);
            this.amountElementsSequence.Name = "amountElementsSequence";
            this.amountElementsSequence.Size = new System.Drawing.Size(758, 365);
            this.amountElementsSequence.TabIndex = 8;
            // 
            // inputSequenceHandly
            // 
            this.inputSequenceHandly.Controls.Add(this.inputSequenceRandomly);
            this.inputSequenceHandly.Controls.Add(this.label5);
            this.inputSequenceHandly.Controls.Add(this.amountInputingElements);
            this.inputSequenceHandly.Controls.Add(this.deleteElements);
            this.inputSequenceHandly.Controls.Add(this.tableNumbers);
            this.inputSequenceHandly.Controls.Add(this.inputElements);
            this.inputSequenceHandly.Controls.Add(this.label3);
            this.inputSequenceHandly.Location = new System.Drawing.Point(3, 0);
            this.inputSequenceHandly.Name = "inputSequenceHandly";
            this.inputSequenceHandly.Size = new System.Drawing.Size(814, 359);
            this.inputSequenceHandly.TabIndex = 20;
            this.inputSequenceHandly.Visible = false;
            // 
            // inputSequenceRandomly
            // 
            this.inputSequenceRandomly.Controls.Add(this.mergeSort);
            this.inputSequenceRandomly.Controls.Add(this.outputElements);
            this.inputSequenceRandomly.Controls.Add(this.label4);
            this.inputSequenceRandomly.Location = new System.Drawing.Point(6, 3);
            this.inputSequenceRandomly.Name = "inputSequenceRandomly";
            this.inputSequenceRandomly.Size = new System.Drawing.Size(808, 356);
            this.inputSequenceRandomly.TabIndex = 21;
            // 
            // mergeSort
            // 
            this.mergeSort.Controls.Add(this.lastWindow);
            this.mergeSort.Controls.Add(this.cBubble);
            this.mergeSort.Controls.Add(this.label8);
            this.mergeSort.Controls.Add(this.pBubble);
            this.mergeSort.Controls.Add(this.label7);
            this.mergeSort.Controls.Add(this.outputBubbleSorted);
            this.mergeSort.Controls.Add(this.label6);
            this.mergeSort.Location = new System.Drawing.Point(3, 0);
            this.mergeSort.Name = "mergeSort";
            this.mergeSort.Size = new System.Drawing.Size(808, 356);
            this.mergeSort.TabIndex = 22;
            // 
            // tests
            // 
            this.tests.BackColor = System.Drawing.Color.LightGray;
            this.tests.Controls.Add(this.button23);
            this.tests.Controls.Add(this.label10);
            this.tests.Controls.Add(this.button24);
            this.tests.Location = new System.Drawing.Point(209, 67);
            this.tests.Name = "tests";
            this.tests.Size = new System.Drawing.Size(372, 286);
            this.tests.TabIndex = 26;
            // 
            // button23
            // 
            this.button23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(140)))), ((int)(((byte)(3)))));
            this.button23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button23.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F);
            this.button23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(236)))), ((int)(((byte)(228)))));
            this.button23.Location = new System.Drawing.Point(275, 216);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(84, 60);
            this.button23.TabIndex = 10;
            this.button23.Text = "NO";
            this.button23.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft JhengHei UI", 25F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(115)))), ((int)(((byte)(45)))));
            this.label10.Location = new System.Drawing.Point(100, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(230, 54);
            this.label10.TabIndex = 9;
            this.label10.Text = "Run tests?";
            // 
            // button24
            // 
            this.button24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(140)))), ((int)(((byte)(3)))));
            this.button24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button24.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16F);
            this.button24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(236)))), ((int)(((byte)(228)))));
            this.button24.Location = new System.Drawing.Point(9, 216);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(84, 60);
            this.button24.TabIndex = 9;
            this.button24.Text = "YES";
            this.button24.UseVisualStyleBackColor = false;
            // 
            // lastWindow
            // 
            this.lastWindow.BackColor = System.Drawing.Color.LightGray;
            this.lastWindow.Controls.Add(this.button1);
            this.lastWindow.Controls.Add(this.label9);
            this.lastWindow.Controls.Add(this.button22);
            this.lastWindow.Location = new System.Drawing.Point(214, 44);
            this.lastWindow.Name = "lastWindow";
            this.lastWindow.Size = new System.Drawing.Size(372, 286);
            this.lastWindow.TabIndex = 25;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(140)))), ((int)(((byte)(3)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(236)))), ((int)(((byte)(228)))));
            this.button1.Location = new System.Drawing.Point(275, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 60);
            this.button1.TabIndex = 10;
            this.button1.Text = "NO";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.buttonNOClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft JhengHei UI", 25F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(115)))), ((int)(((byte)(45)))));
            this.label9.Location = new System.Drawing.Point(28, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(376, 54);
            this.label9.TabIndex = 9;
            this.label9.Text = "Repeat program?";
            // 
            // button22
            // 
            this.button22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(140)))), ((int)(((byte)(3)))));
            this.button22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button22.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16F);
            this.button22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(236)))), ((int)(((byte)(228)))));
            this.button22.Location = new System.Drawing.Point(9, 216);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(84, 60);
            this.button22.TabIndex = 9;
            this.button22.Text = "YES";
            this.button22.UseVisualStyleBackColor = false;
            this.button22.Click += new System.EventHandler(this.buttonYesClick);
            // 
            // cBubble
            // 
            this.cBubble.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cBubble.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(236)))), ((int)(((byte)(228)))));
            this.cBubble.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cBubble.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cBubble.Font = new System.Drawing.Font("Microsoft JhengHei", 25F);
            this.cBubble.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(191)))), ((int)(((byte)(69)))));
            this.cBubble.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.cBubble.Location = new System.Drawing.Point(601, 274);
            this.cBubble.MinimumSize = new System.Drawing.Size(0, 50);
            this.cBubble.Name = "cBubble";
            this.cBubble.ReadOnly = true;
            this.cBubble.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cBubble.Size = new System.Drawing.Size(67, 56);
            this.cBubble.TabIndex = 24;
            this.cBubble.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(115)))), ((int)(((byte)(45)))));
            this.label8.Location = new System.Drawing.Point(574, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(203, 38);
            this.label8.TabIndex = 23;
            this.label8.Text = "Comparisons";
            // 
            // pBubble
            // 
            this.pBubble.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pBubble.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(236)))), ((int)(((byte)(228)))));
            this.pBubble.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pBubble.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBubble.Font = new System.Drawing.Font("Microsoft JhengHei", 25F);
            this.pBubble.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(191)))), ((int)(((byte)(69)))));
            this.pBubble.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.pBubble.Location = new System.Drawing.Point(104, 274);
            this.pBubble.MinimumSize = new System.Drawing.Size(0, 50);
            this.pBubble.Name = "pBubble";
            this.pBubble.ReadOnly = true;
            this.pBubble.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pBubble.Size = new System.Drawing.Size(67, 56);
            this.pBubble.TabIndex = 22;
            this.pBubble.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(115)))), ((int)(((byte)(45)))));
            this.label7.Location = new System.Drawing.Point(79, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(206, 38);
            this.label7.TabIndex = 21;
            this.label7.Text = "Permutations";
            // 
            // outputBubbleSorted
            // 
            this.outputBubbleSorted.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputBubbleSorted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(236)))), ((int)(((byte)(228)))));
            this.outputBubbleSorted.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outputBubbleSorted.Cursor = System.Windows.Forms.Cursors.Hand;
            this.outputBubbleSorted.Font = new System.Drawing.Font("Microsoft JhengHei", 25F);
            this.outputBubbleSorted.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(191)))), ((int)(((byte)(69)))));
            this.outputBubbleSorted.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.outputBubbleSorted.Location = new System.Drawing.Point(251, 117);
            this.outputBubbleSorted.MinimumSize = new System.Drawing.Size(0, 50);
            this.outputBubbleSorted.Name = "outputBubbleSorted";
            this.outputBubbleSorted.ReadOnly = true;
            this.outputBubbleSorted.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.outputBubbleSorted.Size = new System.Drawing.Size(317, 56);
            this.outputBubbleSorted.TabIndex = 20;
            this.outputBubbleSorted.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei UI", 25.2F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(115)))), ((int)(((byte)(45)))));
            this.label6.Location = new System.Drawing.Point(308, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(265, 55);
            this.label6.TabIndex = 0;
            this.label6.Text = "Bubble sort";
            // 
            // outputElements
            // 
            this.outputElements.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputElements.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(236)))), ((int)(((byte)(228)))));
            this.outputElements.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outputElements.Cursor = System.Windows.Forms.Cursors.Hand;
            this.outputElements.Font = new System.Drawing.Font("Microsoft JhengHei", 25F);
            this.outputElements.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(191)))), ((int)(((byte)(69)))));
            this.outputElements.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.outputElements.Location = new System.Drawing.Point(130, 150);
            this.outputElements.MinimumSize = new System.Drawing.Size(0, 50);
            this.outputElements.Name = "outputElements";
            this.outputElements.ReadOnly = true;
            this.outputElements.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.outputElements.Size = new System.Drawing.Size(548, 56);
            this.outputElements.TabIndex = 20;
            this.outputElements.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 25.2F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(115)))), ((int)(((byte)(45)))));
            this.label4.Location = new System.Drawing.Point(171, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(533, 55);
            this.label4.TabIndex = 0;
            this.label4.Text = "There are your numbers:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei UI", 25.2F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(115)))), ((int)(((byte)(45)))));
            this.label5.Location = new System.Drawing.Point(441, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(216, 55);
            this.label5.TabIndex = 22;
            this.label5.Text = "elements";
            // 
            // amountInputingElements
            // 
            this.amountInputingElements.AutoSize = true;
            this.amountInputingElements.Font = new System.Drawing.Font("Microsoft JhengHei UI", 25.2F, System.Drawing.FontStyle.Bold);
            this.amountInputingElements.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(206)))), ((int)(((byte)(22)))));
            this.amountInputingElements.Location = new System.Drawing.Point(382, 6);
            this.amountInputingElements.Name = "amountInputingElements";
            this.amountInputingElements.Size = new System.Drawing.Size(102, 55);
            this.amountInputingElements.TabIndex = 21;
            this.amountInputingElements.Text = "123";
            // 
            // deleteElements
            // 
            this.deleteElements.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deleteElements.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(206)))), ((int)(((byte)(22)))));
            this.deleteElements.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteElements.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteElements.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(236)))), ((int)(((byte)(228)))));
            this.deleteElements.Location = new System.Drawing.Point(626, 167);
            this.deleteElements.Name = "deleteElements";
            this.deleteElements.Size = new System.Drawing.Size(88, 60);
            this.deleteElements.TabIndex = 19;
            this.deleteElements.Text = "<=";
            this.deleteElements.UseVisualStyleBackColor = false;
            this.deleteElements.Click += new System.EventHandler(this.deleteNumber);
            // 
            // tableNumbers
            // 
            this.tableNumbers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableNumbers.ColumnCount = 5;
            this.tableNumbers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableNumbers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableNumbers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableNumbers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableNumbers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableNumbers.Controls.Add(this.button2, 2, 1);
            this.tableNumbers.Controls.Add(this.button13, 4, 1);
            this.tableNumbers.Controls.Add(this.button14, 1, 1);
            this.tableNumbers.Controls.Add(this.button15, 3, 1);
            this.tableNumbers.Controls.Add(this.button16, 1, 0);
            this.tableNumbers.Controls.Add(this.button17, 2, 0);
            this.tableNumbers.Controls.Add(this.button18, 4, 0);
            this.tableNumbers.Controls.Add(this.button19, 3, 0);
            this.tableNumbers.Controls.Add(this.button20, 0, 0);
            this.tableNumbers.Controls.Add(this.button21, 0, 1);
            this.tableNumbers.Location = new System.Drawing.Point(141, 142);
            this.tableNumbers.Margin = new System.Windows.Forms.Padding(10);
            this.tableNumbers.Name = "tableNumbers";
            this.tableNumbers.RowCount = 2;
            this.tableNumbers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableNumbers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableNumbers.Size = new System.Drawing.Size(472, 213);
            this.tableNumbers.TabIndex = 20;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(191)))), ((int)(((byte)(115)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(236)))), ((int)(((byte)(228)))));
            this.button2.Location = new System.Drawing.Point(200, 124);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 70);
            this.button2.TabIndex = 20;
            this.button2.Text = "7";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.numberClick);
            // 
            // button13
            // 
            this.button13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(185)))), ((int)(((byte)(126)))));
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(236)))), ((int)(((byte)(228)))));
            this.button13.Location = new System.Drawing.Point(389, 124);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(70, 70);
            this.button13.TabIndex = 11;
            this.button13.Text = "9";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.numberClick);
            // 
            // button14
            // 
            this.button14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(115)))), ((int)(((byte)(45)))));
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(236)))), ((int)(((byte)(228)))));
            this.button14.Location = new System.Drawing.Point(106, 124);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(70, 70);
            this.button14.TabIndex = 19;
            this.button14.Text = "6";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.numberClick);
            // 
            // button15
            // 
            this.button15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(191)))), ((int)(((byte)(115)))));
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(236)))), ((int)(((byte)(228)))));
            this.button15.Location = new System.Drawing.Point(294, 124);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(70, 70);
            this.button15.TabIndex = 10;
            this.button15.Text = "8";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.numberClick);
            // 
            // button16
            // 
            this.button16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(191)))), ((int)(((byte)(105)))));
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(236)))), ((int)(((byte)(228)))));
            this.button16.Location = new System.Drawing.Point(106, 18);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(70, 70);
            this.button16.TabIndex = 14;
            this.button16.Text = "1";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.numberClick);
            // 
            // button17
            // 
            this.button17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(191)))), ((int)(((byte)(105)))));
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button17.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(236)))), ((int)(((byte)(228)))));
            this.button17.Location = new System.Drawing.Point(200, 18);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(70, 70);
            this.button17.TabIndex = 15;
            this.button17.Text = "2";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.numberClick);
            // 
            // button18
            // 
            this.button18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(166)))), ((int)(((byte)(60)))));
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(236)))), ((int)(((byte)(228)))));
            this.button18.Location = new System.Drawing.Point(389, 18);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(70, 70);
            this.button18.TabIndex = 17;
            this.button18.Text = "4";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.numberClick);
            // 
            // button19
            // 
            this.button19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(166)))), ((int)(((byte)(60)))));
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button19.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(236)))), ((int)(((byte)(228)))));
            this.button19.Location = new System.Drawing.Point(294, 18);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(70, 70);
            this.button19.TabIndex = 16;
            this.button19.Tag = "";
            this.button19.Text = "3";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.numberClick);
            // 
            // button20
            // 
            this.button20.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(209)))), ((int)(((byte)(109)))));
            this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button20.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(236)))), ((int)(((byte)(228)))));
            this.button20.Location = new System.Drawing.Point(12, 18);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(70, 70);
            this.button20.TabIndex = 12;
            this.button20.Text = "0";
            this.button20.UseVisualStyleBackColor = false;
            this.button20.Click += new System.EventHandler(this.numberClick);
            // 
            // button21
            // 
            this.button21.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(115)))), ((int)(((byte)(45)))));
            this.button21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button21.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(236)))), ((int)(((byte)(228)))));
            this.button21.Location = new System.Drawing.Point(12, 124);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(70, 70);
            this.button21.TabIndex = 18;
            this.button21.Text = "5";
            this.button21.UseVisualStyleBackColor = false;
            this.button21.Click += new System.EventHandler(this.numberClick);
            // 
            // inputElements
            // 
            this.inputElements.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputElements.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(236)))), ((int)(((byte)(228)))));
            this.inputElements.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputElements.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inputElements.Font = new System.Drawing.Font("Microsoft JhengHei", 25F);
            this.inputElements.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(191)))), ((int)(((byte)(69)))));
            this.inputElements.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.inputElements.Location = new System.Drawing.Point(141, 73);
            this.inputElements.MinimumSize = new System.Drawing.Size(0, 50);
            this.inputElements.Name = "inputElements";
            this.inputElements.ReadOnly = true;
            this.inputElements.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.inputElements.Size = new System.Drawing.Size(548, 56);
            this.inputElements.TabIndex = 19;
            this.inputElements.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 25.2F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(115)))), ((int)(((byte)(45)))));
            this.label3.Location = new System.Drawing.Point(275, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 55);
            this.label3.TabIndex = 1;
            this.label3.Text = "Input";
            // 
            // inputSequenceChoice
            // 
            this.inputSequenceChoice.Controls.Add(this.inputSequenceHandly);
            this.inputSequenceChoice.Controls.Add(this.handlyFilling);
            this.inputSequenceChoice.Controls.Add(this.randomFilling);
            this.inputSequenceChoice.Controls.Add(this.label2);
            this.inputSequenceChoice.Location = new System.Drawing.Point(797, 40);
            this.inputSequenceChoice.Name = "inputSequenceChoice";
            this.inputSequenceChoice.Size = new System.Drawing.Size(780, 365);
            this.inputSequenceChoice.TabIndex = 19;
            // 
            // handlyFilling
            // 
            this.handlyFilling.AutoSize = true;
            this.handlyFilling.Font = new System.Drawing.Font("Microsoft JhengHei", 20F);
            this.handlyFilling.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(191)))), ((int)(((byte)(69)))));
            this.handlyFilling.Location = new System.Drawing.Point(31, 106);
            this.handlyFilling.Name = "handlyFilling";
            this.handlyFilling.Size = new System.Drawing.Size(257, 47);
            this.handlyFilling.TabIndex = 4;
            this.handlyFilling.Text = "Manual input";
            this.handlyFilling.UseVisualStyleBackColor = true;
            this.handlyFilling.CheckedChanged += new System.EventHandler(this.chosenTypeOfInput);
            // 
            // randomFilling
            // 
            this.randomFilling.AutoSize = true;
            this.randomFilling.Font = new System.Drawing.Font("Microsoft JhengHei", 20F);
            this.randomFilling.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(191)))), ((int)(((byte)(69)))));
            this.randomFilling.Location = new System.Drawing.Point(31, 202);
            this.randomFilling.Name = "randomFilling";
            this.randomFilling.Size = new System.Drawing.Size(272, 47);
            this.randomFilling.TabIndex = 4;
            this.randomFilling.Text = "Random input";
            this.randomFilling.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.randomFilling.UseVisualStyleBackColor = true;
            this.randomFilling.CheckedChanged += new System.EventHandler(this.chosenTypeOfInput);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 25.2F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(115)))), ((int)(((byte)(45)))));
            this.label2.Location = new System.Drawing.Point(183, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(481, 55);
            this.label2.TabIndex = 1;
            this.label2.Text = "Choose type of filling:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Controls.Add(this.deleteButton, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.button7, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.button9, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.button6, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.button8, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.button3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.button10, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.button11, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.button12, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button5, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(134, 152);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(544, 213);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(206)))), ((int)(((byte)(22)))));
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(236)))), ((int)(((byte)(228)))));
            this.deleteButton.Location = new System.Drawing.Point(453, 23);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(88, 60);
            this.deleteButton.TabIndex = 19;
            this.deleteButton.Text = "<=";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteNumber);
            // 
            // button7
            // 
            this.button7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(191)))), ((int)(((byte)(115)))));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(236)))), ((int)(((byte)(228)))));
            this.button7.Location = new System.Drawing.Point(190, 124);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(70, 70);
            this.button7.TabIndex = 20;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button_Click);
            // 
            // button9
            // 
            this.button9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(185)))), ((int)(((byte)(126)))));
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(236)))), ((int)(((byte)(228)))));
            this.button9.Location = new System.Drawing.Point(370, 124);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(70, 70);
            this.button9.TabIndex = 11;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button_Click);
            // 
            // button6
            // 
            this.button6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(115)))), ((int)(((byte)(45)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(236)))), ((int)(((byte)(228)))));
            this.button6.Location = new System.Drawing.Point(100, 124);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(70, 70);
            this.button6.TabIndex = 19;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button_Click);
            // 
            // button8
            // 
            this.button8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(191)))), ((int)(((byte)(115)))));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(236)))), ((int)(((byte)(228)))));
            this.button8.Location = new System.Drawing.Point(280, 124);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(70, 70);
            this.button8.TabIndex = 10;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(191)))), ((int)(((byte)(105)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(236)))), ((int)(((byte)(228)))));
            this.button3.Location = new System.Drawing.Point(100, 18);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(70, 70);
            this.button3.TabIndex = 14;
            this.button3.Text = "1";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button_Click);
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(191)))), ((int)(((byte)(105)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(236)))), ((int)(((byte)(228)))));
            this.button4.Location = new System.Drawing.Point(190, 18);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(70, 70);
            this.button4.TabIndex = 15;
            this.button4.Text = "2";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button_Click);
            // 
            // button10
            // 
            this.button10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(166)))), ((int)(((byte)(60)))));
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(236)))), ((int)(((byte)(228)))));
            this.button10.Location = new System.Drawing.Point(370, 18);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(70, 70);
            this.button10.TabIndex = 17;
            this.button10.Text = "4";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button_Click);
            // 
            // button11
            // 
            this.button11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(166)))), ((int)(((byte)(60)))));
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(236)))), ((int)(((byte)(228)))));
            this.button11.Location = new System.Drawing.Point(280, 18);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(70, 70);
            this.button11.TabIndex = 16;
            this.button11.Tag = "";
            this.button11.Text = "3";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button_Click);
            // 
            // button12
            // 
            this.button12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(209)))), ((int)(((byte)(109)))));
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(236)))), ((int)(((byte)(228)))));
            this.button12.Location = new System.Drawing.Point(10, 18);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(70, 70);
            this.button12.TabIndex = 12;
            this.button12.Text = "0";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button_Click);
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(115)))), ((int)(((byte)(45)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(236)))), ((int)(((byte)(228)))));
            this.button5.Location = new System.Drawing.Point(10, 124);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(70, 70);
            this.button5.TabIndex = 18;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button_Click);
            // 
            // inputAmountElements
            // 
            this.inputAmountElements.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputAmountElements.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(236)))), ((int)(((byte)(228)))));
            this.inputAmountElements.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputAmountElements.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inputAmountElements.Font = new System.Drawing.Font("Microsoft JhengHei", 25F);
            this.inputAmountElements.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(191)))), ((int)(((byte)(69)))));
            this.inputAmountElements.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.inputAmountElements.Location = new System.Drawing.Point(134, 83);
            this.inputAmountElements.MinimumSize = new System.Drawing.Size(0, 50);
            this.inputAmountElements.Name = "inputAmountElements";
            this.inputAmountElements.ReadOnly = true;
            this.inputAmountElements.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.inputAmountElements.Size = new System.Drawing.Size(548, 56);
            this.inputAmountElements.TabIndex = 17;
            this.inputAmountElements.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(115)))), ((int)(((byte)(45)))));
            this.label1.Location = new System.Drawing.Point(125, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(736, 55);
            this.label1.TabIndex = 16;
            this.label1.Text = "Input amount of sorting sequence";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SortingApp
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(64)))), ((int)(((byte)(26)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1171, 453);
            this.Controls.Add(this.inputSequenceChoice);
            this.Controls.Add(this.amountElementsSequence);
            this.Controls.Add(this.further);
            this.Controls.Add(this.back);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(220)))), ((int)(((byte)(194)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SortingApp";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sorting App";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.amountElementsSequence.ResumeLayout(false);
            this.amountElementsSequence.PerformLayout();
            this.inputSequenceHandly.ResumeLayout(false);
            this.inputSequenceHandly.PerformLayout();
            this.inputSequenceRandomly.ResumeLayout(false);
            this.inputSequenceRandomly.PerformLayout();
            this.mergeSort.ResumeLayout(false);
            this.mergeSort.PerformLayout();
            this.tests.ResumeLayout(false);
            this.tests.PerformLayout();
            this.lastWindow.ResumeLayout(false);
            this.lastWindow.PerformLayout();
            this.tableNumbers.ResumeLayout(false);
            this.inputSequenceChoice.ResumeLayout(false);
            this.inputSequenceChoice.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button further;
        private System.Windows.Forms.Panel amountElementsSequence;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.TextBox inputAmountElements;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel inputSequenceChoice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox handlyFilling;
        private System.Windows.Forms.CheckBox randomFilling;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Panel inputSequenceHandly;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableNumbers;
        private System.Windows.Forms.Button deleteElements;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.TextBox inputElements;
        private System.Windows.Forms.Panel inputSequenceRandomly;
        private System.Windows.Forms.TextBox outputElements;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label amountInputingElements;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel mergeSort;
        private System.Windows.Forms.TextBox outputBubbleSorted;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox cBubble;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox pBubble;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel lastWindow;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Panel tests;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button24;
    }
}

