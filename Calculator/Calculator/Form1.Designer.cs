namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
             
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtInputResault = new System.Windows.Forms.TextBox();
            this.LabelShowOp = new System.Windows.Forms.Label();
            this.LabelPreorder = new System.Windows.Forms.Label();
            this.LabelInorder = new System.Windows.Forms.Label();
            this.LabelPostorder = new System.Windows.Forms.Label();
            this.BtnRightBracket = new System.Windows.Forms.Button();
            this.BtnLeftBracket = new System.Windows.Forms.Button();
            this.BntSquareRoot = new System.Windows.Forms.Button();
            this.BntCE = new System.Windows.Forms.Button();
            this.BntC = new System.Windows.Forms.Button();
            this.BntBack = new System.Windows.Forms.Button();
            this.BntDivid = new System.Windows.Forms.Button();
            this.BntMulti = new System.Windows.Forms.Button();
            this.BntMinus = new System.Windows.Forms.Button();
            this.BntPluse = new System.Windows.Forms.Button();
            this.BntEqual = new System.Windows.Forms.Button();
            this.BntSigned = new System.Windows.Forms.Button();
            this.BntDot = new System.Windows.Forms.Button();
            this.Bnt0 = new System.Windows.Forms.Button();
            this.Bnt9 = new System.Windows.Forms.Button();
            this.Bnt8 = new System.Windows.Forms.Button();
            this.Bnt7 = new System.Windows.Forms.Button();
            this.Bnt6 = new System.Windows.Forms.Button();
            this.Bnt5 = new System.Windows.Forms.Button();
            this.Bnt4 = new System.Windows.Forms.Button();
            this.Bnt3 = new System.Windows.Forms.Button();
            this.Bnt2 = new System.Windows.Forms.Button();
            this.Bnt1 = new System.Windows.Forms.Button();
            this.LabelCalculatorId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtInputResault
            // 
            this.TxtInputResault.Font = new System.Drawing.Font("新細明體", 20F);
            this.TxtInputResault.Location = new System.Drawing.Point(50, 171);
            this.TxtInputResault.Name = "TxtInputResault";
            this.TxtInputResault.Size = new System.Drawing.Size(456, 39);
            this.TxtInputResault.TabIndex = 25;
            this.TxtInputResault.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LabelShowOp
            // 
            this.LabelShowOp.AutoSize = true;
            this.LabelShowOp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LabelShowOp.Font = new System.Drawing.Font("新細明體", 15F);
            this.LabelShowOp.Location = new System.Drawing.Point(46, 126);
            this.LabelShowOp.Name = "LabelShowOp";
            this.LabelShowOp.Size = new System.Drawing.Size(119, 20);
            this.LabelShowOp.TabIndex = 26;
            this.LabelShowOp.Text = "progressIsHere";
            this.LabelShowOp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabelPreorder
            // 
            this.LabelPreorder.AutoSize = true;
            this.LabelPreorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.LabelPreorder.Font = new System.Drawing.Font("新細明體", 12F);
            this.LabelPreorder.Location = new System.Drawing.Point(48, 28);
            this.LabelPreorder.Name = "LabelPreorder";
            this.LabelPreorder.Size = new System.Drawing.Size(61, 16);
            this.LabelPreorder.TabIndex = 30;
            this.LabelPreorder.Text = "Preorder";
            // 
            // LabelInorder
            // 
            this.LabelInorder.AutoSize = true;
            this.LabelInorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.LabelInorder.Font = new System.Drawing.Font("新細明體", 12F);
            this.LabelInorder.Location = new System.Drawing.Point(48, 61);
            this.LabelInorder.Name = "LabelInorder";
            this.LabelInorder.Size = new System.Drawing.Size(54, 16);
            this.LabelInorder.TabIndex = 31;
            this.LabelInorder.Text = "Inorder";
            // 
            // LabelPostorder
            // 
            this.LabelPostorder.AutoSize = true;
            this.LabelPostorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.LabelPostorder.Font = new System.Drawing.Font("新細明體", 12F);
            this.LabelPostorder.Location = new System.Drawing.Point(48, 89);
            this.LabelPostorder.Name = "LabelPostorder";
            this.LabelPostorder.Size = new System.Drawing.Size(67, 16);
            this.LabelPostorder.TabIndex = 32;
            this.LabelPostorder.Text = "Postorder";
            // 
            // BtnRightBracket
            // 
            this.BtnRightBracket.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnRightBracket.Location = new System.Drawing.Point(288, 238);
            this.BtnRightBracket.Name = "BtnRightBracket";
            this.BtnRightBracket.Size = new System.Drawing.Size(99, 29);
            this.BtnRightBracket.TabIndex = 29;
            this.BtnRightBracket.Tag = "https://localhost:44396/api/Calculators/Brucket/RightBrucket";
            this.BtnRightBracket.Text = ")";
            this.BtnRightBracket.UseVisualStyleBackColor = true;
            this.BtnRightBracket.Click += new System.EventHandler(this.Bnt0_ClickAsync);
            // 
            // BtnLeftBracket
            // 
            this.BtnLeftBracket.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnLeftBracket.Location = new System.Drawing.Point(172, 238);
            this.BtnLeftBracket.Name = "BtnLeftBracket";
            this.BtnLeftBracket.Size = new System.Drawing.Size(100, 29);
            this.BtnLeftBracket.TabIndex = 28;
            this.BtnLeftBracket.Tag = "https://localhost:44396/api/Calculators/Brucket/LeftBrucket";
            this.BtnLeftBracket.Text = "(";
            this.BtnLeftBracket.UseVisualStyleBackColor = true;
            this.BtnLeftBracket.Click += new System.EventHandler(this.Bnt0_ClickAsync);
            // 
            // BntSquareRoot
            // 
            this.BntSquareRoot.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BntSquareRoot.Location = new System.Drawing.Point(406, 228);
            this.BntSquareRoot.Name = "BntSquareRoot";
            this.BntSquareRoot.Size = new System.Drawing.Size(100, 48);
            this.BntSquareRoot.TabIndex = 27;
            this.BntSquareRoot.Tag = "https://localhost:44396/api/Calculators/Operator/Squrt";
            this.BntSquareRoot.Text = "√";
            this.BntSquareRoot.UseVisualStyleBackColor = true;
            this.BntSquareRoot.Click += new System.EventHandler(this.Bnt0_ClickAsync);
            // 
            // BntCE
            // 
            this.BntCE.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BntCE.Location = new System.Drawing.Point(51, 290);
            this.BntCE.Name = "BntCE";
            this.BntCE.Size = new System.Drawing.Size(100, 60);
            this.BntCE.TabIndex = 20;
            this.BntCE.Tag = "https://localhost:44396/api/Calculators/Normal/ClearError";
            this.BntCE.Text = "CE";
            this.BntCE.UseVisualStyleBackColor = true;
            this.BntCE.Click += new System.EventHandler(this.Bnt0_ClickAsync);
            // 
            // BntC
            // 
            this.BntC.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BntC.Location = new System.Drawing.Point(172, 290);
            this.BntC.Name = "BntC";
            this.BntC.Size = new System.Drawing.Size(100, 60);
            this.BntC.TabIndex = 19;
            this.BntC.Tag = "https://localhost:44396/api/Calculators/Normal/Clear";
            this.BntC.Text = "C";
            this.BntC.UseVisualStyleBackColor = true;
            this.BntC.Click += new System.EventHandler(this.Bnt0_ClickAsync);
            // 
            // BntBack
            // 
            this.BntBack.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BntBack.Location = new System.Drawing.Point(288, 290);
            this.BntBack.Name = "BntBack";
            this.BntBack.Size = new System.Drawing.Size(100, 60);
            this.BntBack.TabIndex = 18;
            this.BntBack.Tag = "https://localhost:44396/api/Calculators/Normal/Back";
            this.BntBack.Text = "Back";
            this.BntBack.UseVisualStyleBackColor = true;
            this.BntBack.Click += new System.EventHandler(this.Bnt0_ClickAsync);
            // 
            // BntDivid
            // 
            this.BntDivid.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BntDivid.Location = new System.Drawing.Point(406, 290);
            this.BntDivid.Name = "BntDivid";
            this.BntDivid.Size = new System.Drawing.Size(100, 60);
            this.BntDivid.TabIndex = 17;
            this.BntDivid.Tag = "https://localhost:44396/api/Calculators/Operator/Divid";
            this.BntDivid.Text = "/";
            this.BntDivid.UseVisualStyleBackColor = true;
            this.BntDivid.Click += new System.EventHandler(this.Bnt0_ClickAsync);
            // 
            // BntMulti
            // 
            this.BntMulti.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BntMulti.Location = new System.Drawing.Point(406, 368);
            this.BntMulti.Name = "BntMulti";
            this.BntMulti.Size = new System.Drawing.Size(100, 60);
            this.BntMulti.TabIndex = 16;
            this.BntMulti.Tag = "https://localhost:44396/api/Calculators/Operator/multi";
            this.BntMulti.Text = "*";
            this.BntMulti.UseVisualStyleBackColor = true;
            this.BntMulti.Click += new System.EventHandler(this.Bnt0_ClickAsync);
            // 
            // BntMinus
            // 
            this.BntMinus.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BntMinus.Location = new System.Drawing.Point(406, 447);
            this.BntMinus.Name = "BntMinus";
            this.BntMinus.Size = new System.Drawing.Size(100, 60);
            this.BntMinus.TabIndex = 15;
            this.BntMinus.Tag = "https://localhost:44396/api/Calculators/Operator/minus";
            this.BntMinus.Text = "-";
            this.BntMinus.UseVisualStyleBackColor = true;
            this.BntMinus.Click += new System.EventHandler(this.Bnt0_ClickAsync);
            // 
            // BntPluse
            // 
            this.BntPluse.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BntPluse.Location = new System.Drawing.Point(406, 524);
            this.BntPluse.Name = "BntPluse";
            this.BntPluse.Size = new System.Drawing.Size(100, 60);
            this.BntPluse.TabIndex = 14;
            this.BntPluse.Tag = "https://localhost:44396/api/Calculators/Operator/Plus";
            this.BntPluse.Text = "+";
            this.BntPluse.UseVisualStyleBackColor = true;
            this.BntPluse.Click += new System.EventHandler(this.Bnt0_ClickAsync);
            // 
            // BntEqual
            // 
            this.BntEqual.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BntEqual.Location = new System.Drawing.Point(406, 594);
            this.BntEqual.Name = "BntEqual";
            this.BntEqual.Size = new System.Drawing.Size(100, 60);
            this.BntEqual.TabIndex = 13;
            this.BntEqual.Tag = "https://localhost:44396/api/Calculators/ExeResult/Equal";
            this.BntEqual.Text = "=";
            this.BntEqual.UseVisualStyleBackColor = true;
            this.BntEqual.Click += new System.EventHandler(this.Bnt0_ClickAsync);
            // 
            // BntSigned
            // 
            this.BntSigned.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BntSigned.Location = new System.Drawing.Point(51, 594);
            this.BntSigned.Name = "BntSigned";
            this.BntSigned.Size = new System.Drawing.Size(100, 60);
            this.BntSigned.TabIndex = 12;
            this.BntSigned.Tag = "https://localhost:44396/api/Calculators/Normal/Sign";
            this.BntSigned.Text = "+/-";
            this.BntSigned.UseVisualStyleBackColor = true;
            this.BntSigned.Click += new System.EventHandler(this.Bnt0_ClickAsync);
            // 
            // BntDot
            // 
            this.BntDot.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BntDot.Location = new System.Drawing.Point(288, 594);
            this.BntDot.Name = "BntDot";
            this.BntDot.Size = new System.Drawing.Size(100, 60);
            this.BntDot.TabIndex = 11;
            this.BntDot.Tag = "https://localhost:44396/api/Calculators/Normal/Dot";
            this.BntDot.Text = ".";
            this.BntDot.UseVisualStyleBackColor = true;
            this.BntDot.Click += new System.EventHandler(this.Bnt0_ClickAsync);
            // 
            // Bnt0
            // 
            this.Bnt0.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Bnt0.Location = new System.Drawing.Point(172, 594);
            this.Bnt0.Name = "Bnt0";
            this.Bnt0.Size = new System.Drawing.Size(100, 60);
            this.Bnt0.TabIndex = 10;
            this.Bnt0.Tag = "https://localhost:44396/api/Calculators/Number/0";
            this.Bnt0.Text = "0";
            this.Bnt0.UseVisualStyleBackColor = true;
            this.Bnt0.Click += new System.EventHandler(this.Bnt0_ClickAsync);
            // 
            // Bnt9
            // 
            this.Bnt9.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Bnt9.Location = new System.Drawing.Point(287, 368);
            this.Bnt9.Name = "Bnt9";
            this.Bnt9.Size = new System.Drawing.Size(100, 60);
            this.Bnt9.TabIndex = 9;
            this.Bnt9.Tag = "https://localhost:44396/api/Calculators/Number/9";
            this.Bnt9.Text = "9";
            this.Bnt9.UseVisualStyleBackColor = true;
            this.Bnt9.Click += new System.EventHandler(this.Bnt0_ClickAsync);
            // 
            // Bnt8
            // 
            this.Bnt8.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Bnt8.Location = new System.Drawing.Point(172, 368);
            this.Bnt8.Name = "Bnt8";
            this.Bnt8.Size = new System.Drawing.Size(100, 60);
            this.Bnt8.TabIndex = 8;
            this.Bnt8.Tag = "https://localhost:44396/api/Calculators/Number/8";
            this.Bnt8.Text = "8";
            this.Bnt8.UseVisualStyleBackColor = true;
            this.Bnt8.Click += new System.EventHandler(this.Bnt0_ClickAsync);
            // 
            // Bnt7
            // 
            this.Bnt7.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Bnt7.Location = new System.Drawing.Point(50, 368);
            this.Bnt7.Name = "Bnt7";
            this.Bnt7.Size = new System.Drawing.Size(100, 60);
            this.Bnt7.TabIndex = 7;
            this.Bnt7.Tag = "https://localhost:44396/api/Calculators/Number/7";
            this.Bnt7.Text = "7";
            this.Bnt7.UseVisualStyleBackColor = true;
            this.Bnt7.Click += new System.EventHandler(this.Bnt0_ClickAsync);
            // 
            // Bnt6
            // 
            this.Bnt6.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Bnt6.Location = new System.Drawing.Point(287, 447);
            this.Bnt6.Name = "Bnt6";
            this.Bnt6.Size = new System.Drawing.Size(100, 60);
            this.Bnt6.TabIndex = 6;
            this.Bnt6.Tag = "https://localhost:44396/api/Calculators/Number/6";
            this.Bnt6.Text = "6";
            this.Bnt6.UseVisualStyleBackColor = true;
            this.Bnt6.Click += new System.EventHandler(this.Bnt0_ClickAsync);
            // 
            // Bnt5
            // 
            this.Bnt5.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Bnt5.Location = new System.Drawing.Point(172, 447);
            this.Bnt5.Name = "Bnt5";
            this.Bnt5.Size = new System.Drawing.Size(100, 60);
            this.Bnt5.TabIndex = 5;
            this.Bnt5.Tag = "https://localhost:44396/api/Calculators/Number/5";
            this.Bnt5.Text = "5";
            this.Bnt5.UseVisualStyleBackColor = true;
            this.Bnt5.Click += new System.EventHandler(this.Bnt0_ClickAsync);
            // 
            // Bnt4
            // 
            this.Bnt4.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Bnt4.Location = new System.Drawing.Point(51, 447);
            this.Bnt4.Name = "Bnt4";
            this.Bnt4.Size = new System.Drawing.Size(100, 60);
            this.Bnt4.TabIndex = 4;
            this.Bnt4.Tag = "https://localhost:44396/api/Calculators/Number/4";
            this.Bnt4.Text = "4";
            this.Bnt4.UseVisualStyleBackColor = true;
            this.Bnt4.Click += new System.EventHandler(this.Bnt0_ClickAsync);
            // 
            // Bnt3
            // 
            this.Bnt3.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Bnt3.Location = new System.Drawing.Point(288, 524);
            this.Bnt3.Name = "Bnt3";
            this.Bnt3.Size = new System.Drawing.Size(100, 60);
            this.Bnt3.TabIndex = 3;
            this.Bnt3.Tag = "https://localhost:44396/api/Calculators/Number/3";
            this.Bnt3.Text = "3";
            this.Bnt3.UseVisualStyleBackColor = true;
            this.Bnt3.Click += new System.EventHandler(this.Bnt0_ClickAsync);
            // 
            // Bnt2
            // 
            this.Bnt2.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Bnt2.Location = new System.Drawing.Point(172, 524);
            this.Bnt2.Name = "Bnt2";
            this.Bnt2.Size = new System.Drawing.Size(100, 60);
            this.Bnt2.TabIndex = 2;
            this.Bnt2.Tag = "https://localhost:44396/api/Calculators/Number/2";
            this.Bnt2.Text = "2";
            this.Bnt2.UseVisualStyleBackColor = true;
            this.Bnt2.Click += new System.EventHandler(this.Bnt0_ClickAsync);
            // 
            // Bnt1
            // 
            this.Bnt1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Bnt1.Location = new System.Drawing.Point(51, 524);
            this.Bnt1.Name = "Bnt1";
            this.Bnt1.Size = new System.Drawing.Size(100, 60);
            this.Bnt1.TabIndex = 1;
            this.Bnt1.Tag = "https://localhost:44396/api/Calculators/Number/1";
            this.Bnt1.Text = "1";
            this.Bnt1.UseVisualStyleBackColor = true;
            this.Bnt1.Click += new System.EventHandler(this.Bnt0_ClickAsync);
            // 
            // LabelCalculatorId
            // 
            this.LabelCalculatorId.AutoSize = true;
            this.LabelCalculatorId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.LabelCalculatorId.Font = new System.Drawing.Font("新細明體", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LabelCalculatorId.Location = new System.Drawing.Point(535, 630);
            this.LabelCalculatorId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelCalculatorId.Name = "LabelCalculatorId";
            this.LabelCalculatorId.Size = new System.Drawing.Size(134, 24);
            this.LabelCalculatorId.TabIndex = 33;
            this.LabelCalculatorId.Text = "CalculatorId";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 683);
            this.Controls.Add(this.LabelCalculatorId);
            this.Controls.Add(this.LabelPostorder);
            this.Controls.Add(this.LabelInorder);
            this.Controls.Add(this.LabelPreorder);
            this.Controls.Add(this.BtnRightBracket);
            this.Controls.Add(this.BtnLeftBracket);
            this.Controls.Add(this.BntSquareRoot);
            this.Controls.Add(this.LabelShowOp);
            this.Controls.Add(this.TxtInputResault);
            this.Controls.Add(this.BntCE);
            this.Controls.Add(this.BntC);
            this.Controls.Add(this.BntBack);
            this.Controls.Add(this.BntDivid);
            this.Controls.Add(this.BntMulti);
            this.Controls.Add(this.BntMinus);
            this.Controls.Add(this.BntPluse);
            this.Controls.Add(this.BntEqual);
            this.Controls.Add(this.BntSigned);
            this.Controls.Add(this.BntDot);
            this.Controls.Add(this.Bnt0);
            this.Controls.Add(this.Bnt9);
            this.Controls.Add(this.Bnt8);
            this.Controls.Add(this.Bnt7);
            this.Controls.Add(this.Bnt6);
            this.Controls.Add(this.Bnt5);
            this.Controls.Add(this.Bnt4);
            this.Controls.Add(this.Bnt3);
            this.Controls.Add(this.Bnt2);
            this.Controls.Add(this.Bnt1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Bnt1;
        private System.Windows.Forms.Button Bnt2;
        private System.Windows.Forms.Button Bnt3;
        private System.Windows.Forms.Button Bnt4;
        private System.Windows.Forms.Button Bnt5;
        private System.Windows.Forms.Button Bnt6;
        private System.Windows.Forms.Button Bnt7;
        private System.Windows.Forms.Button Bnt8;
        private System.Windows.Forms.Button Bnt9;
        private System.Windows.Forms.Button Bnt0;
        private System.Windows.Forms.Button BntDot;
        private System.Windows.Forms.Button BntSigned;
        private System.Windows.Forms.Button BntEqual;
        private System.Windows.Forms.Button BntPluse;
        private System.Windows.Forms.Button BntMinus;
        private System.Windows.Forms.Button BntMulti;
        private System.Windows.Forms.Button BntDivid;
        private System.Windows.Forms.Button BntBack;
        private System.Windows.Forms.Button BntC;
        private System.Windows.Forms.Button BntCE;
        private System.Windows.Forms.TextBox TxtInputResault;
        private System.Windows.Forms.Label LabelShowOp;
        private System.Windows.Forms.Button BntSquareRoot;
        private System.Windows.Forms.Button BtnLeftBracket;
        private System.Windows.Forms.Button BtnRightBracket;
        private System.Windows.Forms.Label LabelPreorder;
        private System.Windows.Forms.Label LabelInorder;
        private System.Windows.Forms.Label LabelPostorder;
        private System.Windows.Forms.Label LabelCalculatorId;
    }
}