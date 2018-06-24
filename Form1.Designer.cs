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
            this.richTextBoxVacancies = new System.Windows.Forms.RichTextBox();
            this.labelCountVacancies = new System.Windows.Forms.Label();
            this.checkBoxUlyanovsk = new System.Windows.Forms.CheckBox();
            this.checkBoxIT = new System.Windows.Forms.CheckBox();
            this.checkBoxSimbirSoft = new System.Windows.Forms.CheckBox();
            this.buttonNextPage = new System.Windows.Forms.Button();
            this.buttonPrevPage = new System.Windows.Forms.Button();
            this.labelSelectVacancies = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.labelCountVacancies.Size = new System.Drawing.Size(97, 13);
            this.labelCountVacancies.TabIndex = 3;
            this.labelCountVacancies.Text = "Всего вакансий : ";
            // 
            // checkBoxUlyanovsk
            // 
            this.checkBoxUlyanovsk.AutoSize = true;
            this.checkBoxUlyanovsk.Location = new System.Drawing.Point(514, 69);
            this.checkBoxUlyanovsk.Name = "checkBoxUlyanovsk";
            this.checkBoxUlyanovsk.Size = new System.Drawing.Size(82, 17);
            this.checkBoxUlyanovsk.TabIndex = 6;
            this.checkBoxUlyanovsk.Text = "Ульяновск";
            this.checkBoxUlyanovsk.UseVisualStyleBackColor = true;
            this.checkBoxUlyanovsk.CheckedChanged += new System.EventHandler(this.checkBoxUlyanovsk_CheckedChanged);
            // 
            // checkBoxIT
            // 
            this.checkBoxIT.AutoSize = true;
            this.checkBoxIT.Location = new System.Drawing.Point(514, 105);
            this.checkBoxIT.Name = "checkBoxIT";
            this.checkBoxIT.Size = new System.Drawing.Size(36, 17);
            this.checkBoxIT.TabIndex = 7;
            this.checkBoxIT.Text = "IT";
            this.checkBoxIT.UseVisualStyleBackColor = true;
            this.checkBoxIT.CheckedChanged += new System.EventHandler(this.checkBoxIT_CheckedChanged);
            // 
            // checkBoxSimbirSoft
            // 
            this.checkBoxSimbirSoft.AutoSize = true;
            this.checkBoxSimbirSoft.Location = new System.Drawing.Point(514, 139);
            this.checkBoxSimbirSoft.Name = "checkBoxSimbirSoft";
            this.checkBoxSimbirSoft.Size = new System.Drawing.Size(91, 17);
            this.checkBoxSimbirSoft.TabIndex = 8;
            this.checkBoxSimbirSoft.Text = "СимбирСофт";
            this.checkBoxSimbirSoft.UseVisualStyleBackColor = true;
            this.checkBoxSimbirSoft.CheckedChanged += new System.EventHandler(this.checkBoxSimbirSoft_CheckedChanged);
            // 
            // buttonNextPage
            // 
            this.buttonNextPage.Location = new System.Drawing.Point(291, 387);
            this.buttonNextPage.Name = "buttonNextPage";
            this.buttonNextPage.Size = new System.Drawing.Size(180, 23);
            this.buttonNextPage.TabIndex = 9;
            this.buttonNextPage.Text = "Следующая страница";
            this.buttonNextPage.UseVisualStyleBackColor = true;
            this.buttonNextPage.Click += new System.EventHandler(this.buttonNextPage_Click);
            // 
            // buttonPrevPage
            // 
            this.buttonPrevPage.Enabled = false;
            this.buttonPrevPage.Location = new System.Drawing.Point(69, 387);
            this.buttonPrevPage.Name = "buttonPrevPage";
            this.buttonPrevPage.Size = new System.Drawing.Size(180, 23);
            this.buttonPrevPage.TabIndex = 10;
            this.buttonPrevPage.Text = "Предыдущая страница";
            this.buttonPrevPage.UseVisualStyleBackColor = true;
            this.buttonPrevPage.Click += new System.EventHandler(this.buttonPrevPage_Click);
            // 
            // labelSelectVacancies
            // 
            this.labelSelectVacancies.AutoSize = true;
            this.labelSelectVacancies.Enabled = false;
            this.labelSelectVacancies.Location = new System.Drawing.Point(511, 179);
            this.labelSelectVacancies.Name = "labelSelectVacancies";
            this.labelSelectVacancies.Size = new System.Drawing.Size(189, 13);
            this.labelSelectVacancies.TabIndex = 11;
            this.labelSelectVacancies.Text = "Критериям поиска соответствуют : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelSelectVacancies);
            this.Controls.Add(this.buttonPrevPage);
            this.Controls.Add(this.buttonNextPage);
            this.Controls.Add(this.checkBoxSimbirSoft);
            this.Controls.Add(this.checkBoxIT);
            this.Controls.Add(this.checkBoxUlyanovsk);
            this.Controls.Add(this.labelCountVacancies);
            this.Controls.Add(this.richTextBoxVacancies);
            this.Name = "Form1";
            this.Text = "Вакансии сайта hh.ru";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBoxVacancies;
        private System.Windows.Forms.Label labelCountVacancies;
        private System.Windows.Forms.CheckBox checkBoxUlyanovsk;
        private System.Windows.Forms.CheckBox checkBoxIT;
        private System.Windows.Forms.CheckBox checkBoxSimbirSoft;
        private System.Windows.Forms.Button buttonNextPage;
        private System.Windows.Forms.Button buttonPrevPage;
        private System.Windows.Forms.Label labelSelectVacancies;
    }
}

