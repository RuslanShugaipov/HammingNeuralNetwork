namespace HammingNeuralNetwork
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
            this.pictureBox_Pattern1 = new System.Windows.Forms.PictureBox();
            this.pictureBox_Pattern2 = new System.Windows.Forms.PictureBox();
            this.pictureBox_Pattern4 = new System.Windows.Forms.PictureBox();
            this.pictureBox_Pattern3 = new System.Windows.Forms.PictureBox();
            this.pictureBox_Pattern5 = new System.Windows.Forms.PictureBox();
            this.pictureBox_Input = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_Result = new System.Windows.Forms.Label();
            this.button_Predict = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox_Pattern6 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Pattern1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Pattern2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Pattern4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Pattern3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Pattern5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Pattern6)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_Pattern1
            // 
            this.pictureBox_Pattern1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox_Pattern1.Location = new System.Drawing.Point(19, 62);
            this.pictureBox_Pattern1.Margin = new System.Windows.Forms.Padding(10);
            this.pictureBox_Pattern1.Name = "pictureBox_Pattern1";
            this.pictureBox_Pattern1.Size = new System.Drawing.Size(149, 149);
            this.pictureBox_Pattern1.TabIndex = 0;
            this.pictureBox_Pattern1.TabStop = false;
            this.pictureBox_Pattern1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Pattern1_Paint);
            // 
            // pictureBox_Pattern2
            // 
            this.pictureBox_Pattern2.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox_Pattern2.Location = new System.Drawing.Point(261, 62);
            this.pictureBox_Pattern2.Margin = new System.Windows.Forms.Padding(10);
            this.pictureBox_Pattern2.Name = "pictureBox_Pattern2";
            this.pictureBox_Pattern2.Size = new System.Drawing.Size(149, 149);
            this.pictureBox_Pattern2.TabIndex = 1;
            this.pictureBox_Pattern2.TabStop = false;
            this.pictureBox_Pattern2.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Pattern2_Paint);
            // 
            // pictureBox_Pattern4
            // 
            this.pictureBox_Pattern4.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox_Pattern4.Location = new System.Drawing.Point(745, 62);
            this.pictureBox_Pattern4.Margin = new System.Windows.Forms.Padding(10);
            this.pictureBox_Pattern4.Name = "pictureBox_Pattern4";
            this.pictureBox_Pattern4.Size = new System.Drawing.Size(149, 149);
            this.pictureBox_Pattern4.TabIndex = 3;
            this.pictureBox_Pattern4.TabStop = false;
            this.pictureBox_Pattern4.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Pattern4_Paint);
            // 
            // pictureBox_Pattern3
            // 
            this.pictureBox_Pattern3.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox_Pattern3.Location = new System.Drawing.Point(503, 62);
            this.pictureBox_Pattern3.Margin = new System.Windows.Forms.Padding(10);
            this.pictureBox_Pattern3.Name = "pictureBox_Pattern3";
            this.pictureBox_Pattern3.Size = new System.Drawing.Size(149, 149);
            this.pictureBox_Pattern3.TabIndex = 2;
            this.pictureBox_Pattern3.TabStop = false;
            this.pictureBox_Pattern3.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Pattern3_Paint);
            // 
            // pictureBox_Pattern5
            // 
            this.pictureBox_Pattern5.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox_Pattern5.Location = new System.Drawing.Point(987, 62);
            this.pictureBox_Pattern5.Margin = new System.Windows.Forms.Padding(10);
            this.pictureBox_Pattern5.Name = "pictureBox_Pattern5";
            this.pictureBox_Pattern5.Size = new System.Drawing.Size(149, 149);
            this.pictureBox_Pattern5.TabIndex = 4;
            this.pictureBox_Pattern5.TabStop = false;
            this.pictureBox_Pattern5.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Pattern5_Paint);
            // 
            // pictureBox_Input
            // 
            this.pictureBox_Input.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox_Input.Location = new System.Drawing.Point(19, 282);
            this.pictureBox_Input.Margin = new System.Windows.Forms.Padding(10);
            this.pictureBox_Input.Name = "pictureBox_Input";
            this.pictureBox_Input.Size = new System.Drawing.Size(149, 149);
            this.pictureBox_Input.TabIndex = 5;
            this.pictureBox_Input.TabStop = false;
            this.pictureBox_Input.Click += new System.EventHandler(this.pictureBox_Input_Click);
            this.pictureBox_Input.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Input_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(95, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 46);
            this.label1.TabIndex = 6;
            this.label1.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(334, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 46);
            this.label2.TabIndex = 7;
            this.label2.Text = "2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(572, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 46);
            this.label3.TabIndex = 8;
            this.label3.Text = "3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(812, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 46);
            this.label4.TabIndex = 9;
            this.label4.Text = "4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(1052, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 46);
            this.label5.TabIndex = 10;
            this.label5.Text = "5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(251, 385);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 46);
            this.label6.TabIndex = 11;
            this.label6.Text = "Result: ";
            // 
            // label_Result
            // 
            this.label_Result.AutoSize = true;
            this.label_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Result.Location = new System.Drawing.Point(420, 385);
            this.label_Result.Name = "label_Result";
            this.label_Result.Size = new System.Drawing.Size(34, 46);
            this.label_Result.TabIndex = 12;
            this.label_Result.Text = "-";
            // 
            // button_Predict
            // 
            this.button_Predict.Location = new System.Drawing.Point(259, 282);
            this.button_Predict.Name = "button_Predict";
            this.button_Predict.Size = new System.Drawing.Size(97, 34);
            this.button_Predict.TabIndex = 13;
            this.button_Predict.Text = "Predict";
            this.button_Predict.UseVisualStyleBackColor = true;
            this.button_Predict.Click += new System.EventHandler(this.button_Predict_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(1303, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 46);
            this.label7.TabIndex = 15;
            this.label7.Text = "6";
            // 
            // pictureBox_Pattern6
            // 
            this.pictureBox_Pattern6.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox_Pattern6.Location = new System.Drawing.Point(1229, 62);
            this.pictureBox_Pattern6.Margin = new System.Windows.Forms.Padding(10);
            this.pictureBox_Pattern6.Name = "pictureBox_Pattern6";
            this.pictureBox_Pattern6.Size = new System.Drawing.Size(149, 149);
            this.pictureBox_Pattern6.TabIndex = 14;
            this.pictureBox_Pattern6.TabStop = false;
            this.pictureBox_Pattern6.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Pattern6_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1451, 673);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox_Pattern6);
            this.Controls.Add(this.button_Predict);
            this.Controls.Add(this.label_Result);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox_Input);
            this.Controls.Add(this.pictureBox_Pattern5);
            this.Controls.Add(this.pictureBox_Pattern4);
            this.Controls.Add(this.pictureBox_Pattern3);
            this.Controls.Add(this.pictureBox_Pattern2);
            this.Controls.Add(this.pictureBox_Pattern1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Pattern1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Pattern2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Pattern4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Pattern3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Pattern5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Pattern6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Pattern1;
        private System.Windows.Forms.PictureBox pictureBox_Pattern2;
        private System.Windows.Forms.PictureBox pictureBox_Pattern4;
        private System.Windows.Forms.PictureBox pictureBox_Pattern3;
        private System.Windows.Forms.PictureBox pictureBox_Pattern5;
        private System.Windows.Forms.PictureBox pictureBox_Input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_Result;
        private System.Windows.Forms.Button button_Predict;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox_Pattern6;
    }
}

