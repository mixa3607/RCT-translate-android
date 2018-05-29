namespace rct_text_replace
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
            this.input_file = new System.Windows.Forms.TextBox();
            this.output_file = new System.Windows.Forms.TextBox();
            this.set_input_file = new System.Windows.Forms.Button();
            this.set_output_file = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // input_file
            // 
            this.input_file.Enabled = false;
            this.input_file.Location = new System.Drawing.Point(19, 15);
            this.input_file.Name = "input_file";
            this.input_file.Size = new System.Drawing.Size(287, 20);
            this.input_file.TabIndex = 0;
            this.input_file.Text = "не обработанный файл";
            // 
            // output_file
            // 
            this.output_file.Enabled = false;
            this.output_file.Location = new System.Drawing.Point(19, 62);
            this.output_file.Name = "output_file";
            this.output_file.Size = new System.Drawing.Size(287, 20);
            this.output_file.TabIndex = 0;
            this.output_file.Text = "выходной файл";
            // 
            // set_input_file
            // 
            this.set_input_file.Location = new System.Drawing.Point(318, 15);
            this.set_input_file.Name = "set_input_file";
            this.set_input_file.Size = new System.Drawing.Size(37, 20);
            this.set_input_file.TabIndex = 1;
            this.set_input_file.Text = "...";
            this.set_input_file.UseVisualStyleBackColor = true;
            this.set_input_file.Click += new System.EventHandler(this.Set_input_file_Click);
            // 
            // set_output_file
            // 
            this.set_output_file.Location = new System.Drawing.Point(319, 62);
            this.set_output_file.Name = "set_output_file";
            this.set_output_file.Size = new System.Drawing.Size(36, 20);
            this.set_output_file.TabIndex = 2;
            this.set_output_file.Text = "...";
            this.set_output_file.UseVisualStyleBackColor = true;
            this.set_output_file.Click += new System.EventHandler(this.Set_output_file_Click);
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.Transparent;
            this.start.Location = new System.Drawing.Point(50, 101);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(269, 52);
            this.start.TabIndex = 3;
            this.start.Text = "начать";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 168);
            this.Controls.Add(this.start);
            this.Controls.Add(this.set_output_file);
            this.Controls.Add(this.set_input_file);
            this.Controls.Add(this.output_file);
            this.Controls.Add(this.input_file);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "rct text replacer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input_file;
        private System.Windows.Forms.TextBox output_file;
        private System.Windows.Forms.Button set_input_file;
        private System.Windows.Forms.Button set_output_file;
        private System.Windows.Forms.Button start;
    }
}

