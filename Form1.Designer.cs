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
            this.richTextBoxVacancies = new System.Windows.Forms.RichTextBox();
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
            // richTextBoxVacancies
            // 
            this.richTextBoxVacancies.Location = new System.Drawing.Point(46, 30);
            this.richTextBoxVacancies.Name = "richTextBoxVacancies";
            this.richTextBoxVacancies.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBoxVacancies.Size = new System.Drawing.Size(702, 320);
            this.richTextBoxVacancies.TabIndex = 2;
            this.richTextBoxVacancies.Text = "";
            this.richTextBoxVacancies.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.richTextBoxVacancies_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBoxVacancies);
            this.Controls.Add(this.buttonGetVacanties);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonGetVacanties;
        private System.Windows.Forms.RichTextBox richTextBoxVacancies;
    }
}

