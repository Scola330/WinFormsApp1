namespace WinFormsApp1
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
            topLeft = new Button();
            topMiddle = new Button();
            topRight = new Button();
            middleLeft = new Button();
            midleCenter = new Button();
            middleRight = new Button();
            bottomLeft = new Button();
            bottomMiddle = new Button();
            bottomRight = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            label2 = new Label();
            label1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // topLeft
            // 
            topLeft.Location = new Point(3, 37);
            topLeft.Name = "topLeft";
            topLeft.Size = new Size(143, 104);
            topLeft.TabIndex = 0;
            topLeft.UseVisualStyleBackColor = true;
            topLeft.Click += button1_Click;
            // 
            // topMiddle
            // 
            topMiddle.Location = new Point(152, 37);
            topMiddle.Name = "topMiddle";
            topMiddle.Size = new Size(179, 104);
            topMiddle.TabIndex = 1;
            topMiddle.UseVisualStyleBackColor = true;
            topMiddle.Click += button1_Click;
            // 
            // topRight
            // 
            topRight.Location = new Point(338, 37);
            topRight.Name = "topRight";
            topRight.Size = new Size(143, 104);
            topRight.TabIndex = 2;
            topRight.UseVisualStyleBackColor = true;
            topRight.Click += button1_Click;
            // 
            // middleLeft
            // 
            middleLeft.Location = new Point(3, 147);
            middleLeft.Name = "middleLeft";
            middleLeft.Size = new Size(143, 143);
            middleLeft.TabIndex = 3;
            middleLeft.UseVisualStyleBackColor = true;
            middleLeft.Click += button1_Click;
            // 
            // midleCenter
            // 
            midleCenter.Location = new Point(152, 147);
            midleCenter.Name = "midleCenter";
            midleCenter.Size = new Size(180, 143);
            midleCenter.TabIndex = 4;
            midleCenter.UseVisualStyleBackColor = true;
            midleCenter.Click += button1_Click;
            // 
            // middleRight
            // 
            middleRight.Location = new Point(338, 147);
            middleRight.Name = "middleRight";
            middleRight.Size = new Size(143, 143);
            middleRight.TabIndex = 5;
            middleRight.UseVisualStyleBackColor = true;
            middleRight.Click += button1_Click;
            // 
            // bottomLeft
            // 
            bottomLeft.Location = new Point(3, 296);
            bottomLeft.Name = "bottomLeft";
            bottomLeft.Size = new Size(143, 142);
            bottomLeft.TabIndex = 6;
            bottomLeft.UseVisualStyleBackColor = true;
            bottomLeft.Click += button1_Click;
            // 
            // bottomMiddle
            // 
            bottomMiddle.Location = new Point(152, 296);
            bottomMiddle.Name = "bottomMiddle";
            bottomMiddle.Size = new Size(180, 142);
            bottomMiddle.TabIndex = 7;
            bottomMiddle.UseVisualStyleBackColor = true;
            bottomMiddle.Click += button1_Click;
            // 
            // bottomRight
            // 
            bottomRight.Location = new Point(338, 296);
            bottomRight.Name = "bottomRight";
            bottomRight.Size = new Size(143, 142);
            bottomRight.TabIndex = 8;
            bottomRight.UseVisualStyleBackColor = true;
            bottomRight.Click += button1_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 44.35484F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55.64516F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 148F));
            tableLayoutPanel1.Controls.Add(topLeft, 0, 1);
            tableLayoutPanel1.Controls.Add(topRight, 2, 1);
            tableLayoutPanel1.Controls.Add(middleRight, 2, 2);
            tableLayoutPanel1.Controls.Add(bottomRight, 2, 3);
            tableLayoutPanel1.Controls.Add(topMiddle, 1, 1);
            tableLayoutPanel1.Controls.Add(bottomMiddle, 1, 3);
            tableLayoutPanel1.Controls.Add(middleLeft, 0, 2);
            tableLayoutPanel1.Controls.Add(bottomLeft, 0, 3);
            tableLayoutPanel1.Controls.Add(midleCenter, 1, 2);
            tableLayoutPanel1.Controls.Add(label2, 1, 0);
            tableLayoutPanel1.Controls.Add(label1, 2, 0);
            tableLayoutPanel1.Location = new Point(0, -3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 23.61111F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 76.3888855F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 149F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 147F));
            tableLayoutPanel1.Size = new Size(484, 441);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(152, 0);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 9;
            label2.Text = "aktywny gracz";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(338, 0);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 10;
            label1.Text = "ilość rozgrywek";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(486, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Windows xp Tic Tac Toe";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button topLeft;
        private Button topMiddle;
        private Button topRight;
        private Button middleLeft;
        private Button midleCenter;
        private Button middleRight;
        private Button bottomLeft;
        private Button bottomMiddle;
        private Button bottomRight;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private Label label1;
    }
}
