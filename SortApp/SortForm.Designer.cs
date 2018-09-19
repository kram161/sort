namespace SortApp
{
    partial class SortForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.InputA = new System.Windows.Forms.TextBox();
            this.InputB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.OutC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SortBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "A =";
            // 
            // InputA
            // 
            this.InputA.Location = new System.Drawing.Point(41, 6);
            this.InputA.Name = "InputA";
            this.InputA.Size = new System.Drawing.Size(747, 20);
            this.InputA.TabIndex = 1;
            // 
            // InputB
            // 
            this.InputB.Location = new System.Drawing.Point(41, 32);
            this.InputB.Name = "InputB";
            this.InputB.Size = new System.Drawing.Size(747, 20);
            this.InputB.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "B =";
            // 
            // OutC
            // 
            this.OutC.Location = new System.Drawing.Point(41, 58);
            this.OutC.Name = "OutC";
            this.OutC.ReadOnly = true;
            this.OutC.Size = new System.Drawing.Size(747, 20);
            this.OutC.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "C =";
            // 
            // SortBtn
            // 
            this.SortBtn.Location = new System.Drawing.Point(713, 86);
            this.SortBtn.Name = "SortBtn";
            this.SortBtn.Size = new System.Drawing.Size(75, 23);
            this.SortBtn.TabIndex = 6;
            this.SortBtn.Text = "Sort";
            this.SortBtn.UseVisualStyleBackColor = true;
            this.SortBtn.Click += new System.EventHandler(this.SortBtn_Click);
            // 
            // SortForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 121);
            this.Controls.Add(this.SortBtn);
            this.Controls.Add(this.OutC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.InputB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InputA);
            this.Controls.Add(this.label1);
            this.Name = "SortForm";
            this.Text = "sort";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InputA;
        private System.Windows.Forms.TextBox InputB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox OutC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SortBtn;
    }
}

