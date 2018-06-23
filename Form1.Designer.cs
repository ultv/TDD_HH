namespace TDD_HH
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
            this.buttonGetVacanties = new System.Windows.Forms.Button();
            this.textBoxVacncies = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonGetVacanties
            // 
            this.buttonGetVacanties.Location = new System.Drawing.Point(325, 397);
            this.buttonGetVacanties.Name = "buttonGetVacanties";
            this.buttonGetVacanties.Size = new System.Drawing.Size(174, 23);
            this.buttonGetVacanties.TabIndex = 0;
            this.buttonGetVacanties.Text = "Получить вакансии";
            this.buttonGetVacanties.UseVisualStyleBackColor = true;
            this.buttonGetVacanties.Click += new System.EventHandler(this.buttonGetVacanties_Click);
            // 
            // textBoxVacncies
            // 
            this.textBoxVacncies.Location = new System.Drawing.Point(46, 40);
            this.textBoxVacncies.Multiline = true;
            this.textBoxVacncies.Name = "textBoxVacncies";
            this.textBoxVacncies.Size = new System.Drawing.Size(692, 325);
            this.textBoxVacncies.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxVacncies);
            this.Controls.Add(this.buttonGetVacanties);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGetVacanties;
        private System.Windows.Forms.TextBox textBoxVacncies;
    }
}

