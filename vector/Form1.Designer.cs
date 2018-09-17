namespace vector
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
            this.groupBoxVectorA = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxVectorAX = new System.Windows.Forms.TextBox();
            this.textBoxVectorAY = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxVectorAZ = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButtonAdd = new System.Windows.Forms.RadioButton();
            this.radioButtonDiff = new System.Windows.Forms.RadioButton();
            this.radioButtonMulti = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBoxVectorA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxVectorA
            // 
            this.groupBoxVectorA.Controls.Add(this.textBoxVectorAZ);
            this.groupBoxVectorA.Controls.Add(this.label3);
            this.groupBoxVectorA.Controls.Add(this.textBoxVectorAY);
            this.groupBoxVectorA.Controls.Add(this.label2);
            this.groupBoxVectorA.Controls.Add(this.textBoxVectorAX);
            this.groupBoxVectorA.Controls.Add(this.label1);
            this.groupBoxVectorA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxVectorA.Name = "groupBoxVectorA";
            this.groupBoxVectorA.Size = new System.Drawing.Size(96, 100);
            this.groupBoxVectorA.TabIndex = 0;
            this.groupBoxVectorA.TabStop = false;
            this.groupBoxVectorA.Text = "Вектор a";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "X:";
            // 
            // textBoxVectorAX
            // 
            this.textBoxVectorAX.Location = new System.Drawing.Point(32, 19);
            this.textBoxVectorAX.Name = "textBoxVectorAX";
            this.textBoxVectorAX.Size = new System.Drawing.Size(48, 20);
            this.textBoxVectorAX.TabIndex = 1;
            // 
            // textBoxVectorAY
            // 
            this.textBoxVectorAY.Location = new System.Drawing.Point(32, 45);
            this.textBoxVectorAY.Name = "textBoxVectorAY";
            this.textBoxVectorAY.Size = new System.Drawing.Size(48, 20);
            this.textBoxVectorAY.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Y:";
            // 
            // textBoxVectorAZ
            // 
            this.textBoxVectorAZ.Location = new System.Drawing.Point(32, 71);
            this.textBoxVectorAZ.Name = "textBoxVectorAZ";
            this.textBoxVectorAZ.Size = new System.Drawing.Size(48, 20);
            this.textBoxVectorAZ.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Z:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(137, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Тип операции";
            // 
            // radioButtonAdd
            // 
            this.radioButtonAdd.AutoSize = true;
            this.radioButtonAdd.Location = new System.Drawing.Point(140, 34);
            this.radioButtonAdd.Name = "radioButtonAdd";
            this.radioButtonAdd.Size = new System.Drawing.Size(76, 17);
            this.radioButtonAdd.TabIndex = 3;
            this.radioButtonAdd.TabStop = true;
            this.radioButtonAdd.Text = "Сложение";
            this.radioButtonAdd.UseVisualStyleBackColor = true;
            // 
            // radioButtonDiff
            // 
            this.radioButtonDiff.AutoSize = true;
            this.radioButtonDiff.Location = new System.Drawing.Point(140, 57);
            this.radioButtonDiff.Name = "radioButtonDiff";
            this.radioButtonDiff.Size = new System.Drawing.Size(73, 17);
            this.radioButtonDiff.TabIndex = 4;
            this.radioButtonDiff.TabStop = true;
            this.radioButtonDiff.Text = "Разность";
            this.radioButtonDiff.UseVisualStyleBackColor = true;
            // 
            // radioButtonMulti
            // 
            this.radioButtonMulti.AutoSize = true;
            this.radioButtonMulti.Location = new System.Drawing.Point(140, 80);
            this.radioButtonMulti.Name = "radioButtonMulti";
            this.radioButtonMulti.Size = new System.Drawing.Size(85, 17);
            this.radioButtonMulti.TabIndex = 5;
            this.radioButtonMulti.TabStop = true;
            this.radioButtonMulti.Text = "Умножение";
            this.radioButtonMulti.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(140, 103);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Умножение";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 410);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.radioButtonMulti);
            this.Controls.Add(this.radioButtonDiff);
            this.Controls.Add(this.radioButtonAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBoxVectorA);
            this.Name = "Form1";
            this.Text = "Vector";
            this.groupBoxVectorA.ResumeLayout(false);
            this.groupBoxVectorA.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxVectorA;
        private System.Windows.Forms.TextBox textBoxVectorAZ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxVectorAY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxVectorAX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButtonAdd;
        private System.Windows.Forms.RadioButton radioButtonDiff;
        private System.Windows.Forms.RadioButton radioButtonMulti;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

