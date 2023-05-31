

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
            Calculator.ClearErrorBot clearErrorBot1 = new Calculator.ClearErrorBot();
            Calculator.ClearBot clearBot1 = new Calculator.ClearBot();
            Calculator.BackBot backBot1 = new Calculator.BackBot();
            Calculator.interface_class.DividBot dividBot1 = new Calculator.interface_class.DividBot();
            Calculator.interface_class.MultiBot multiBot1 = new Calculator.interface_class.MultiBot();
            Calculator.interface_class.MinusBot minusBot1 = new Calculator.interface_class.MinusBot();
            Calculator.interface_class.PlusBot plusBot1 = new Calculator.interface_class.PlusBot();
            Calculator.interface_class.EqualBot equalBot1 = new Calculator.interface_class.EqualBot();
            Calculator.interface_class.SignBot signBot1 = new Calculator.interface_class.SignBot();
            Calculator.interface_class.DotBot dotBot1 = new Calculator.interface_class.DotBot();
            Calculator.interface_class.ValueCube valueCube1 = new Calculator.interface_class.ValueCube();
            Calculator.interface_class.PlusBot plusBot2 = new Calculator.interface_class.PlusBot();
            Calculator.NumberBot numberBot1 = new Calculator.NumberBot();
            Calculator.NumberBot numberBot2 = new Calculator.NumberBot();
            Calculator.NumberBot numberBot3 = new Calculator.NumberBot();
            Calculator.NumberBot numberBot4 = new Calculator.NumberBot();
            Calculator.NumberBot numberBot5 = new Calculator.NumberBot();
            Calculator.NumberBot numberBot6 = new Calculator.NumberBot();
            Calculator.NumberBot numberBot7 = new Calculator.NumberBot();
            Calculator.NumberBot numberBot8 = new Calculator.NumberBot();
            Calculator.NumberBot numberBot9 = new Calculator.NumberBot();
            Calculator.NumberBot numberBot10 = new Calculator.NumberBot();
            this.TxtInputResault = new System.Windows.Forms.TextBox();
            this.LabelShowOp = new System.Windows.Forms.Label();
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
            this.SuspendLayout();
            // 
            // TxtInputResault
            // 
            this.TxtInputResault.Font = new System.Drawing.Font("PMingLiU", 20F);
            this.TxtInputResault.Location = new System.Drawing.Point(67, 228);
            this.TxtInputResault.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtInputResault.Name = "TxtInputResault";
            this.TxtInputResault.Size = new System.Drawing.Size(607, 47);
            this.TxtInputResault.TabIndex = 25;
            this.TxtInputResault.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtInputResault.TextChanged += new System.EventHandler(this.TxtInputResault_TextChanged);
            // 
            // LabelShowOp
            // 
            this.LabelShowOp.AutoSize = true;
            this.LabelShowOp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LabelShowOp.Font = new System.Drawing.Font("PMingLiU", 15F);
            this.LabelShowOp.Location = new System.Drawing.Point(326, 180);
            this.LabelShowOp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelShowOp.Name = "LabelShowOp";
            this.LabelShowOp.Size = new System.Drawing.Size(154, 25);
            this.LabelShowOp.TabIndex = 26;
            this.LabelShowOp.Text = "progressIsHere";
            this.LabelShowOp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabelShowOp.Click += new System.EventHandler(this.LabelShowOp_Click);
            // 
            // BntCE
            // 
            this.BntCE.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BntCE.Location = new System.Drawing.Point(67, 423);
            this.BntCE.Margin = new System.Windows.Forms.Padding(4);
            this.BntCE.Name = "BntCE";
            this.BntCE.Size = new System.Drawing.Size(133, 80);
            this.BntCE.TabIndex = 20;
            this.BntCE.Tag = clearErrorBot1;
            this.BntCE.Text = "CE";
            this.BntCE.UseVisualStyleBackColor = true;
            this.BntCE.Click += new System.EventHandler(this.Bnt0_Click);
            // 
            // BntC
            // 
            this.BntC.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BntC.Location = new System.Drawing.Point(229, 423);
            this.BntC.Margin = new System.Windows.Forms.Padding(4);
            this.BntC.Name = "BntC";
            this.BntC.Size = new System.Drawing.Size(133, 80);
            this.BntC.TabIndex = 19;
            this.BntC.Tag = clearBot1;
            this.BntC.Text = "C";
            this.BntC.UseVisualStyleBackColor = true;
            this.BntC.Click += new System.EventHandler(this.Bnt0_Click);
            // 
            // BntBack
            // 
            this.BntBack.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BntBack.Location = new System.Drawing.Point(383, 423);
            this.BntBack.Margin = new System.Windows.Forms.Padding(4);
            this.BntBack.Name = "BntBack";
            this.BntBack.Size = new System.Drawing.Size(133, 80);
            this.BntBack.TabIndex = 18;
            this.BntBack.Tag = backBot1;
            this.BntBack.Text = "Back";
            this.BntBack.UseVisualStyleBackColor = true;
            this.BntBack.Click += new System.EventHandler(this.Bnt0_Click);
            // 
            // BntDivid
            // 
            this.BntDivid.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BntDivid.Location = new System.Drawing.Point(541, 423);
            this.BntDivid.Margin = new System.Windows.Forms.Padding(4);
            this.BntDivid.Name = "BntDivid";
            this.BntDivid.Size = new System.Drawing.Size(133, 80);
            this.BntDivid.TabIndex = 17;
            this.BntDivid.Tag = dividBot1;
            this.BntDivid.Text = "÷";
            this.BntDivid.UseVisualStyleBackColor = true;
            this.BntDivid.Click += new System.EventHandler(this.Bnt0_Click);
            // 
            // BntMulti
            // 
            this.BntMulti.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BntMulti.Location = new System.Drawing.Point(541, 524);
            this.BntMulti.Margin = new System.Windows.Forms.Padding(4);
            this.BntMulti.Name = "BntMulti";
            this.BntMulti.Size = new System.Drawing.Size(133, 80);
            this.BntMulti.TabIndex = 16;
            this.BntMulti.Tag = multiBot1;
            this.BntMulti.Text = "×";
            this.BntMulti.UseVisualStyleBackColor = true;
            this.BntMulti.Click += new System.EventHandler(this.Bnt0_Click);
            // 
            // BntMinus
            // 
            this.BntMinus.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BntMinus.Location = new System.Drawing.Point(541, 612);
            this.BntMinus.Margin = new System.Windows.Forms.Padding(4);
            this.BntMinus.Name = "BntMinus";
            this.BntMinus.Size = new System.Drawing.Size(133, 80);
            this.BntMinus.TabIndex = 15;
            this.BntMinus.Tag = minusBot1;
            this.BntMinus.Text = "-";
            this.BntMinus.UseVisualStyleBackColor = true;
            this.BntMinus.Click += new System.EventHandler(this.Bnt0_Click);
            // 
            // BntPluse
            // 
            this.BntPluse.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BntPluse.Location = new System.Drawing.Point(541, 712);
            this.BntPluse.Margin = new System.Windows.Forms.Padding(4);
            this.BntPluse.Name = "BntPluse";
            this.BntPluse.Size = new System.Drawing.Size(133, 80);
            this.BntPluse.TabIndex = 14;
            this.BntPluse.Tag = plusBot1;
            this.BntPluse.Text = "+";
            this.BntPluse.UseVisualStyleBackColor = true;
            this.BntPluse.Click += new System.EventHandler(this.Bnt0_Click);
            // 
            // BntEqual
            // 
            this.BntEqual.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BntEqual.Location = new System.Drawing.Point(541, 815);
            this.BntEqual.Margin = new System.Windows.Forms.Padding(4);
            this.BntEqual.Name = "BntEqual";
            this.BntEqual.Size = new System.Drawing.Size(133, 80);
            this.BntEqual.TabIndex = 13;
            this.BntEqual.Tag = equalBot1;
            this.BntEqual.Text = "=";
            this.BntEqual.UseVisualStyleBackColor = true;
            this.BntEqual.Click += new System.EventHandler(this.Bnt0_Click);
            // 
            // BntSigned
            // 
            this.BntSigned.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BntSigned.Location = new System.Drawing.Point(67, 815);
            this.BntSigned.Margin = new System.Windows.Forms.Padding(4);
            this.BntSigned.Name = "BntSigned";
            this.BntSigned.Size = new System.Drawing.Size(133, 80);
            this.BntSigned.TabIndex = 12;
            this.BntSigned.Tag = signBot1;
            this.BntSigned.Text = "+/-";
            this.BntSigned.UseVisualStyleBackColor = true;
            this.BntSigned.Click += new System.EventHandler(this.Bnt0_Click);
            // 
            // BntDot
            // 
            this.BntDot.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BntDot.Location = new System.Drawing.Point(383, 815);
            this.BntDot.Margin = new System.Windows.Forms.Padding(4);
            this.BntDot.Name = "BntDot";
            this.BntDot.Size = new System.Drawing.Size(133, 80);
            this.BntDot.TabIndex = 11;
            valueCube1.labelTemp = "";
            valueCube1.operateTemp = "+";
            valueCube1.resaultTemp = 0D;
            valueCube1.selfDefTag = plusBot2;
            valueCube1.textBoxTemp = "";
            dotBot1.OriginalTag = valueCube1;
            this.BntDot.Tag = dotBot1;
            this.BntDot.Text = ".";
            this.BntDot.UseVisualStyleBackColor = true;
            this.BntDot.Click += new System.EventHandler(this.Bnt0_Click);
            // 
            // Bnt0
            // 
            this.Bnt0.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Bnt0.Location = new System.Drawing.Point(229, 815);
            this.Bnt0.Margin = new System.Windows.Forms.Padding(4);
            this.Bnt0.Name = "Bnt0";
            this.Bnt0.Size = new System.Drawing.Size(133, 80);
            this.Bnt0.TabIndex = 10;
            this.Bnt0.Tag = numberBot1;
            this.Bnt0.Text = "0";
            this.Bnt0.UseVisualStyleBackColor = true;
            this.Bnt0.Click += new System.EventHandler(this.Bnt0_Click);
            // 
            // Bnt9
            // 
            this.Bnt9.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Bnt9.Location = new System.Drawing.Point(383, 524);
            this.Bnt9.Margin = new System.Windows.Forms.Padding(4);
            this.Bnt9.Name = "Bnt9";
            this.Bnt9.Size = new System.Drawing.Size(133, 80);
            this.Bnt9.TabIndex = 9;
            this.Bnt9.Tag = numberBot2;
            this.Bnt9.Text = "9";
            this.Bnt9.UseVisualStyleBackColor = true;
            this.Bnt9.Click += new System.EventHandler(this.Bnt0_Click);
            // 
            // Bnt8
            // 
            this.Bnt8.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Bnt8.Location = new System.Drawing.Point(229, 524);
            this.Bnt8.Margin = new System.Windows.Forms.Padding(4);
            this.Bnt8.Name = "Bnt8";
            this.Bnt8.Size = new System.Drawing.Size(133, 80);
            this.Bnt8.TabIndex = 8;
            this.Bnt8.Tag = numberBot3;
            this.Bnt8.Text = "8";
            this.Bnt8.UseVisualStyleBackColor = true;
            this.Bnt8.Click += new System.EventHandler(this.Bnt0_Click);
            // 
            // Bnt7
            // 
            this.Bnt7.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Bnt7.Location = new System.Drawing.Point(67, 524);
            this.Bnt7.Margin = new System.Windows.Forms.Padding(4);
            this.Bnt7.Name = "Bnt7";
            this.Bnt7.Size = new System.Drawing.Size(133, 80);
            this.Bnt7.TabIndex = 7;
            this.Bnt7.Tag = numberBot4;
            this.Bnt7.Text = "7";
            this.Bnt7.UseVisualStyleBackColor = true;
            this.Bnt7.Click += new System.EventHandler(this.Bnt0_Click);
            // 
            // Bnt6
            // 
            this.Bnt6.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Bnt6.Location = new System.Drawing.Point(383, 612);
            this.Bnt6.Margin = new System.Windows.Forms.Padding(4);
            this.Bnt6.Name = "Bnt6";
            this.Bnt6.Size = new System.Drawing.Size(133, 80);
            this.Bnt6.TabIndex = 6;
            this.Bnt6.Tag = numberBot5;
            this.Bnt6.Text = "6";
            this.Bnt6.UseVisualStyleBackColor = true;
            this.Bnt6.Click += new System.EventHandler(this.Bnt0_Click);
            // 
            // Bnt5
            // 
            this.Bnt5.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Bnt5.Location = new System.Drawing.Point(229, 612);
            this.Bnt5.Margin = new System.Windows.Forms.Padding(4);
            this.Bnt5.Name = "Bnt5";
            this.Bnt5.Size = new System.Drawing.Size(133, 80);
            this.Bnt5.TabIndex = 5;
            this.Bnt5.Tag = numberBot6;
            this.Bnt5.Text = "5";
            this.Bnt5.UseVisualStyleBackColor = true;
            this.Bnt5.Click += new System.EventHandler(this.Bnt0_Click);
            // 
            // Bnt4
            // 
            this.Bnt4.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Bnt4.Location = new System.Drawing.Point(67, 612);
            this.Bnt4.Margin = new System.Windows.Forms.Padding(4);
            this.Bnt4.Name = "Bnt4";
            this.Bnt4.Size = new System.Drawing.Size(133, 80);
            this.Bnt4.TabIndex = 4;
            this.Bnt4.Tag = numberBot7;
            this.Bnt4.Text = "4";
            this.Bnt4.UseVisualStyleBackColor = true;
            this.Bnt4.Click += new System.EventHandler(this.Bnt0_Click);
            // 
            // Bnt3
            // 
            this.Bnt3.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Bnt3.Location = new System.Drawing.Point(383, 712);
            this.Bnt3.Margin = new System.Windows.Forms.Padding(4);
            this.Bnt3.Name = "Bnt3";
            this.Bnt3.Size = new System.Drawing.Size(133, 80);
            this.Bnt3.TabIndex = 3;
            this.Bnt3.Tag = numberBot8;
            this.Bnt3.Text = "3";
            this.Bnt3.UseVisualStyleBackColor = true;
            this.Bnt3.Click += new System.EventHandler(this.Bnt0_Click);
            // 
            // Bnt2
            // 
            this.Bnt2.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Bnt2.Location = new System.Drawing.Point(229, 712);
            this.Bnt2.Margin = new System.Windows.Forms.Padding(4);
            this.Bnt2.Name = "Bnt2";
            this.Bnt2.Size = new System.Drawing.Size(133, 80);
            this.Bnt2.TabIndex = 2;
            this.Bnt2.Tag = numberBot9;
            this.Bnt2.Text = "2";
            this.Bnt2.UseVisualStyleBackColor = true;
            this.Bnt2.Click += new System.EventHandler(this.Bnt0_Click);
            // 
            // Bnt1
            // 
            this.Bnt1.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Bnt1.Location = new System.Drawing.Point(67, 712);
            this.Bnt1.Margin = new System.Windows.Forms.Padding(4);
            this.Bnt1.Name = "Bnt1";
            this.Bnt1.Size = new System.Drawing.Size(133, 80);
            this.Bnt1.TabIndex = 1;
            this.Bnt1.Tag = numberBot10;
            this.Bnt1.Text = "1";
            this.Bnt1.UseVisualStyleBackColor = true;
            this.Bnt1.Click += new System.EventHandler(this.Bnt0_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 911);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
    }
}

