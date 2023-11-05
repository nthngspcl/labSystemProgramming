namespace labSystemProgramming
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtZigZagSort = new TextBox();
            txtRadixSort = new TextBox();
            txtPancakeSort = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            inputLengthArr = new TextBox();
            label5 = new Label();
            btnSnakeSort = new Button();
            btnRadixSort = new Button();
            btnPancakeSort = new Button();
            txtZigZagSortSteps = new TextBox();
            txtRadixSortSteps = new TextBox();
            txtPancakeSortSteps = new TextBox();
            button1 = new Button();
            radixInfoBtn = new Button();
            pancakeInfoBtn = new Button();
            label1 = new Label();
            generateArrText = new TextBox();
            button2 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // txtZigZagSort
            // 
            txtZigZagSort.BackColor = SystemColors.ActiveBorder;
            txtZigZagSort.BorderStyle = BorderStyle.FixedSingle;
            txtZigZagSort.Location = new Point(21, 139);
            txtZigZagSort.Multiline = true;
            txtZigZagSort.Name = "txtZigZagSort";
            txtZigZagSort.Size = new Size(420, 96);
            txtZigZagSort.TabIndex = 3;
            // 
            // txtRadixSort
            // 
            txtRadixSort.BackColor = SystemColors.ActiveBorder;
            txtRadixSort.BorderStyle = BorderStyle.FixedSingle;
            txtRadixSort.Location = new Point(538, 139);
            txtRadixSort.Multiline = true;
            txtRadixSort.Name = "txtRadixSort";
            txtRadixSort.Size = new Size(365, 96);
            txtRadixSort.TabIndex = 4;
            // 
            // txtPancakeSort
            // 
            txtPancakeSort.BackColor = SystemColors.ActiveBorder;
            txtPancakeSort.BorderStyle = BorderStyle.FixedSingle;
            txtPancakeSort.Location = new Point(1029, 139);
            txtPancakeSort.Multiline = true;
            txtPancakeSort.Name = "txtPancakeSort";
            txtPancakeSort.Size = new Size(321, 96);
            txtPancakeSort.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(31, 119);
            label2.Name = "label2";
            label2.Size = new Size(187, 25);
            label2.TabIndex = 6;
            label2.Text = "Сортировка змейкой";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(548, 119);
            label3.Name = "label3";
            label3.Size = new Size(224, 25);
            label3.TabIndex = 7;
            label3.Text = "Поразрядная сортировка";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(1039, 119);
            label4.Name = "label4";
            label4.Size = new Size(181, 25);
            label4.TabIndex = 8;
            label4.Text = "Блинная сортировка";
            // 
            // inputLengthArr
            // 
            inputLengthArr.BackColor = Color.AntiqueWhite;
            inputLengthArr.BorderStyle = BorderStyle.FixedSingle;
            inputLengthArr.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            inputLengthArr.ForeColor = Color.Black;
            inputLengthArr.Location = new Point(471, 45);
            inputLengthArr.Name = "inputLengthArr";
            inputLengthArr.Size = new Size(110, 31);
            inputLengthArr.TabIndex = 13;
            inputLengthArr.Text = "10";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(292, 45);
            label5.Name = "label5";
            label5.Size = new Size(173, 31);
            label5.TabIndex = 14;
            label5.Text = "Длина массива";
            // 
            // btnSnakeSort
            // 
            btnSnakeSort.BackColor = Color.AntiqueWhite;
            btnSnakeSort.Font = new Font("Sitka Small Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnSnakeSort.ForeColor = Color.DarkBlue;
            btnSnakeSort.Location = new Point(21, 91);
            btnSnakeSort.Name = "btnSnakeSort";
            btnSnakeSort.Size = new Size(98, 25);
            btnSnakeSort.TabIndex = 15;
            btnSnakeSort.Text = "Snake Sort";
            btnSnakeSort.UseVisualStyleBackColor = false;
            btnSnakeSort.Click += btnSnakeSort_Click;
            // 
            // btnRadixSort
            // 
            btnRadixSort.BackColor = Color.AntiqueWhite;
            btnRadixSort.Font = new Font("Sitka Text Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnRadixSort.Location = new Point(538, 91);
            btnRadixSort.Name = "btnRadixSort";
            btnRadixSort.Size = new Size(98, 25);
            btnRadixSort.TabIndex = 16;
            btnRadixSort.Text = "Radix Sort";
            btnRadixSort.UseVisualStyleBackColor = false;
            btnRadixSort.Click += btnRadixSort_Click;
            // 
            // btnPancakeSort
            // 
            btnPancakeSort.BackColor = Color.AntiqueWhite;
            btnPancakeSort.Font = new Font("Sitka Text Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnPancakeSort.Location = new Point(1029, 91);
            btnPancakeSort.Name = "btnPancakeSort";
            btnPancakeSort.Size = new Size(98, 25);
            btnPancakeSort.TabIndex = 17;
            btnPancakeSort.Text = "Pancake Sort";
            btnPancakeSort.UseVisualStyleBackColor = false;
            btnPancakeSort.Click += btnPancakeSort_Click;
            // 
            // txtZigZagSortSteps
            // 
            txtZigZagSortSteps.Location = new Point(21, 241);
            txtZigZagSortSteps.Multiline = true;
            txtZigZagSortSteps.Name = "txtZigZagSortSteps";
            txtZigZagSortSteps.Size = new Size(420, 250);
            txtZigZagSortSteps.TabIndex = 18;
            // 
            // txtRadixSortSteps
            // 
            txtRadixSortSteps.Location = new Point(538, 241);
            txtRadixSortSteps.Multiline = true;
            txtRadixSortSteps.Name = "txtRadixSortSteps";
            txtRadixSortSteps.Size = new Size(365, 250);
            txtRadixSortSteps.TabIndex = 19;
            // 
            // txtPancakeSortSteps
            // 
            txtPancakeSortSteps.Location = new Point(1029, 241);
            txtPancakeSortSteps.Multiline = true;
            txtPancakeSortSteps.Name = "txtPancakeSortSteps";
            txtPancakeSortSteps.Size = new Size(321, 250);
            txtPancakeSortSteps.TabIndex = 20;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonFace;
            button1.Font = new Font("Segoe UI Black", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(21, 498);
            button1.Name = "button1";
            button1.Size = new Size(64, 56);
            button1.TabIndex = 21;
            button1.Text = "Info";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // radixInfoBtn
            // 
            radixInfoBtn.BackColor = SystemColors.ButtonFace;
            radixInfoBtn.Font = new Font("Segoe UI Black", 11F, FontStyle.Regular, GraphicsUnit.Point);
            radixInfoBtn.Location = new Point(538, 498);
            radixInfoBtn.Name = "radixInfoBtn";
            radixInfoBtn.Size = new Size(64, 56);
            radixInfoBtn.TabIndex = 22;
            radixInfoBtn.Text = "Info";
            radixInfoBtn.UseVisualStyleBackColor = false;
            radixInfoBtn.Click += radixInfoBtn_Click;
            // 
            // pancakeInfoBtn
            // 
            pancakeInfoBtn.BackColor = SystemColors.ButtonFace;
            pancakeInfoBtn.Font = new Font("Segoe UI Black", 11F, FontStyle.Regular, GraphicsUnit.Point);
            pancakeInfoBtn.Location = new Point(1029, 498);
            pancakeInfoBtn.Name = "pancakeInfoBtn";
            pancakeInfoBtn.Size = new Size(64, 56);
            pancakeInfoBtn.TabIndex = 23;
            pancakeInfoBtn.Text = "Info";
            pancakeInfoBtn.UseVisualStyleBackColor = false;
            pancakeInfoBtn.Click += pancakeInfoBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(630, 23);
            label1.Name = "label1";
            label1.Size = new Size(202, 31);
            label1.TabIndex = 24;
            label1.Text = "Исходный массив";
            // 
            // generateArrText
            // 
            generateArrText.BackColor = Color.AntiqueWhite;
            generateArrText.BorderStyle = BorderStyle.FixedSingle;
            generateArrText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            generateArrText.ForeColor = Color.Black;
            generateArrText.Location = new Point(838, 43);
            generateArrText.Multiline = true;
            generateArrText.Name = "generateArrText";
            generateArrText.Size = new Size(492, 25);
            generateArrText.TabIndex = 25;
            // 
            // button2
            // 
            button2.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(676, 57);
            button2.Name = "button2";
            button2.Size = new Size(156, 28);
            button2.TabIndex = 26;
            button2.Text = "Сгенерировать";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(444, 574);
            button4.Name = "button4";
            button4.Size = new Size(593, 56);
            button4.TabIndex = 27;
            button4.Text = "Анализ";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1401, 642);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(generateArrText);
            Controls.Add(label1);
            Controls.Add(pancakeInfoBtn);
            Controls.Add(radixInfoBtn);
            Controls.Add(button1);
            Controls.Add(txtPancakeSortSteps);
            Controls.Add(txtRadixSortSteps);
            Controls.Add(txtZigZagSortSteps);
            Controls.Add(btnPancakeSort);
            Controls.Add(btnRadixSort);
            Controls.Add(btnSnakeSort);
            Controls.Add(label5);
            Controls.Add(inputLengthArr);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtPancakeSort);
            Controls.Add(txtRadixSort);
            Controls.Add(txtZigZagSort);
            Name = "Form1";
            Text = "Тренажер по алгоритмам";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox inputLengthArr;
        private Label label5;
        private Button btnSnakeSort;
        private Button btnRadixSort;
        private Button btnPancakeSort;
        private TextBox txtZigZagSortSteps;
        private TextBox txtRadixSortSteps;
        private TextBox txtPancakeSortSteps;
        private Button button1;
        private Button radixInfoBtn;
        private Button pancakeInfoBtn;
        private TextBox txtPancakeSort;
        private TextBox txtRadixSort;
        private TextBox txtZigZagSort;
        private Label label1;
        private TextBox generateArrText;
        private Button button2;
        private Button button4;
    }
}