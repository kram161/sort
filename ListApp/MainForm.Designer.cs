namespace ListApp
{
    partial class MainForm
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
            this.ListInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.InputA = new System.Windows.Forms.NumericUpDown();
            this.GetCount = new System.Windows.Forms.Button();
            this.CountOutput = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.InputA)).BeginInit();
            this.SuspendLayout();
            // 
            // ListInput
            // 
            this.ListInput.Location = new System.Drawing.Point(12, 25);
            this.ListInput.Name = "ListInput";
            this.ListInput.Size = new System.Drawing.Size(373, 20);
            this.ListInput.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "введите список";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "A = ";
            // 
            // InputA
            // 
            this.InputA.Location = new System.Drawing.Point(44, 57);
            this.InputA.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.InputA.Minimum = new decimal(new int[] {
            100000000,
            0,
            0,
            -2147483648});
            this.InputA.Name = "InputA";
            this.InputA.Size = new System.Drawing.Size(64, 20);
            this.InputA.TabIndex = 3;
            // 
            // GetCount
            // 
            this.GetCount.Location = new System.Drawing.Point(114, 54);
            this.GetCount.Name = "GetCount";
            this.GetCount.Size = new System.Drawing.Size(165, 23);
            this.GetCount.TabIndex = 4;
            this.GetCount.Text = "найти кол-во элементов A";
            this.GetCount.UseVisualStyleBackColor = true;
            this.GetCount.Click += new System.EventHandler(this.GetCount_Click);
            // 
            // CountOutput
            // 
            this.CountOutput.AutoSize = true;
            this.CountOutput.Location = new System.Drawing.Point(285, 59);
            this.CountOutput.Name = "CountOutput";
            this.CountOutput.Size = new System.Drawing.Size(0, 13);
            this.CountOutput.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 100);
            this.Controls.Add(this.CountOutput);
            this.Controls.Add(this.GetCount);
            this.Controls.Add(this.InputA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListInput);
            this.Name = "MainForm";
            this.Text = "List";
            ((System.ComponentModel.ISupportInitialize)(this.InputA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ListInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown InputA;
        private System.Windows.Forms.Button GetCount;
        private System.Windows.Forms.Label CountOutput;
    }
}

