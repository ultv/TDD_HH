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
            this.labelCountVacancies = new System.Windows.Forms.Label();
            this.labelCountPrint = new System.Windows.Forms.Label();
            this.textBoxCountPrint = new System.Windows.Forms.TextBox();
            this.checkBoxUlyanovsk = new System.Windows.Forms.CheckBox();
            this.checkBoxIT = new System.Windows.Forms.CheckBox();
            this.checkBoxSimbirSoft = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // buttonGetVacanties
            // 
            this.buttonGetVacanties.Location = new System.Drawing.Point(173, 387);
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
            this.richTextBoxVacancies.Size = new System.Drawing.Size(438, 320);
            this.richTextBoxVacancies.TabIndex = 2;
            this.richTextBoxVacancies.Text = "";
            this.richTextBoxVacancies.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.richTextBoxVacancies_LinkClicked);
            // 
            // labelCountVacancies
            // 
            this.labelCountVacancies.AutoSize = true;
            this.labelCountVacancies.Location = new System.Drawing.Point(511, 33);
            this.labelCountVacancies.Name = "labelCountVacancies";
            this.labelCountVacancies.Size = new System.Drawing.Size(91, 13);
            this.labelCountVacancies.TabIndex = 3;
            this.labelCountVacancies.Text = "Всего вакансий:";
            // 
            // labelCountPrint
            // 
            this.labelCountPrint.AutoSize = true;
            this.labelCountPrint.Location = new System.Drawing.Point(511, 73);
            this.labelCountPrint.Name = "labelCountPrint";
            this.labelCountPrint.Size = new System.Drawing.Size(75, 13);
            this.labelCountPrint.TabIndex = 4;
            this.labelCountPrint.Text = "Выводить по:";
            // 
            // textBoxCountPrint
            // 
            this.textBoxCountPrint.Location = new System.Drawing.Point(514, 109);
            this.textBoxCountPrint.Name = "textBoxCountPrint";
            this.textBoxCountPrint.Size = new System.Drawing.Size(100, 20);
            this.textBoxCountPrint.TabIndex = 5;
            this.textBoxCountPrint.Text = "100";
            // 
            // checkBoxUlyanovsk
            // 
            this.checkBoxUlyanovsk.AutoSize = true;
            this.checkBoxUlyanovsk.Location = new System.Drawing.Point(514, 163);
            this.checkBoxUlyanovsk.Name = "checkBoxUlyanovsk";
            this.checkBoxUlyanovsk.Size = new System.Drawing.Size(82, 17);
            this.checkBoxUlyanovsk.TabIndex = 6;
            this.checkBoxUlyanovsk.Text = "Ульяновск";
            this.checkBoxUlyanovsk.UseVisualStyleBackColor = true;
            // 
            // checkBoxIT
            // 
            this.checkBoxIT.AutoSize = true;
            this.checkBoxIT.Location = new System.Drawing.Point(514, 202);
            this.checkBoxIT.Name = "checkBoxIT";
            this.checkBoxIT.Size = new System.Drawing.Size(36, 17);
            this.checkBoxIT.TabIndex = 7;
            this.checkBoxIT.Text = "IT";
            this.checkBoxIT.UseVisualStyleBackColor = true;
            // 
            // checkBoxSimbirSoft
            // 
            this.checkBoxSimbirSoft.AutoSize = true;
            this.checkBoxSimbirSoft.Location = new System.Drawing.Point(514, 240);
            this.checkBoxSimbirSoft.Name = "checkBoxSimbirSoft";
            this.checkBoxSimbirSoft.Size = new System.Drawing.Size(91, 17);
            this.checkBoxSimbirSoft.TabIndex = 8;
            this.checkBoxSimbirSoft.Text = "СимбирСофт";
            this.checkBoxSimbirSoft.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBoxSimbirSoft);
            this.Controls.Add(this.checkBoxIT);
            this.Controls.Add(this.checkBoxUlyanovsk);
            this.Controls.Add(this.textBoxCountPrint);
            this.Controls.Add(this.labelCountPrint);
            this.Controls.Add(this.labelCountVacancies);
            this.Controls.Add(this.richTextBoxVacancies);
            this.Controls.Add(this.buttonGetVacanties);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGetVacanties;
        private System.Windows.Forms.RichTextBox richTextBoxVacancies;
        private System.Windows.Forms.Label labelCountVacancies;
        private System.Windows.Forms.Label labelCountPrint;
        private System.Windows.Forms.TextBox textBoxCountPrint;
        private System.Windows.Forms.CheckBox checkBoxUlyanovsk;
        private System.Windows.Forms.CheckBox checkBoxIT;
        private System.Windows.Forms.CheckBox checkBoxSimbirSoft;
    }
}

