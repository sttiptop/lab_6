namespace lab_6
{
    partial class Client
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
            this.ok = new System.Windows.Forms.Button();
            this.showAll = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.search = new System.Windows.Forms.RadioButton();
            this.add = new System.Windows.Forms.RadioButton();
            this.delete = new System.Windows.Forms.RadioButton();
            this.textPosition = new System.Windows.Forms.TextBox();
            this.textFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textInfo = new System.Windows.Forms.RichTextBox();
            this.textSecondName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(275, 197);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(75, 23);
            this.ok.TabIndex = 0;
            this.ok.Text = "Отправить";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // showAll
            // 
            this.showAll.AutoSize = true;
            this.showAll.Location = new System.Drawing.Point(20, 19);
            this.showAll.Name = "showAll";
            this.showAll.Size = new System.Drawing.Size(100, 17);
            this.showAll.TabIndex = 1;
            this.showAll.TabStop = true;
            this.showAll.Text = "Показать всех";
            this.showAll.UseVisualStyleBackColor = true;
            this.showAll.Click += new System.EventHandler(this.groupBoxActive);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.search);
            this.groupBox1.Controls.Add(this.add);
            this.groupBox1.Controls.Add(this.delete);
            this.groupBox1.Controls.Add(this.showAll);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(130, 151);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Действие";
            // 
            // search
            // 
            this.search.AutoSize = true;
            this.search.Location = new System.Drawing.Point(20, 120);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(56, 17);
            this.search.TabIndex = 1;
            this.search.TabStop = true;
            this.search.Text = "Найти";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.groupBoxActive);
            // 
            // add
            // 
            this.add.AutoSize = true;
            this.add.Location = new System.Drawing.Point(20, 87);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 17);
            this.add.TabIndex = 1;
            this.add.TabStop = true;
            this.add.Text = "Добавить";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.groupBoxActive);
            // 
            // delete
            // 
            this.delete.AutoSize = true;
            this.delete.Location = new System.Drawing.Point(20, 47);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(68, 17);
            this.delete.TabIndex = 1;
            this.delete.TabStop = true;
            this.delete.Text = "Удалить";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.groupBoxActive);
            // 
            // textPosition
            // 
            this.textPosition.Location = new System.Drawing.Point(148, 22);
            this.textPosition.Name = "textPosition";
            this.textPosition.Size = new System.Drawing.Size(130, 20);
            this.textPosition.TabIndex = 3;
            // 
            // textFirstName
            // 
            this.textFirstName.Location = new System.Drawing.Point(148, 56);
            this.textFirstName.Name = "textFirstName";
            this.textFirstName.Size = new System.Drawing.Size(130, 20);
            this.textFirstName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(285, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Должность";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Фамилия";
            // 
            // textInfo
            // 
            this.textInfo.Location = new System.Drawing.Point(12, 226);
            this.textInfo.Name = "textInfo";
            this.textInfo.Size = new System.Drawing.Size(338, 99);
            this.textInfo.TabIndex = 5;
            this.textInfo.Text = "";
            // 
            // textSecondName
            // 
            this.textSecondName.Location = new System.Drawing.Point(148, 129);
            this.textSecondName.Name = "textSecondName";
            this.textSecondName.Size = new System.Drawing.Size(130, 20);
            this.textSecondName.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(285, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Отчество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(285, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Имя";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(148, 96);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(130, 20);
            this.textName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Вывод :";
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 337);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textInfo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textSecondName);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.textFirstName);
            this.Controls.Add(this.textPosition);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ok);
            this.Name = "Client";
            this.Text = "ClentApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Ok_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.RadioButton showAll;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton search;
        private System.Windows.Forms.RadioButton add;
        private System.Windows.Forms.RadioButton delete;
        private System.Windows.Forms.TextBox textPosition;
        private System.Windows.Forms.TextBox textFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox textInfo;
        private System.Windows.Forms.TextBox textSecondName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label label3;
    }
}

