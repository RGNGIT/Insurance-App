namespace Insurance_App
{
    partial class App
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label8 = new Label();
            textBoxIncome = new TextBox();
            dataGridViewInsurance = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            tabControlInsType = new TabControl();
            tabPage4 = new TabPage();
            label5 = new Label();
            textBoxAutoMark = new TextBox();
            tabPage5 = new TabPage();
            label6 = new Label();
            textBoxAssetAddress = new TextBox();
            tabPage6 = new TabPage();
            label7 = new Label();
            textBoxSnils = new TextBox();
            buttonAddInsurance = new Button();
            label4 = new Label();
            textBoxFranchise = new TextBox();
            label3 = new Label();
            textBoxMaxSum = new TextBox();
            label2 = new Label();
            dateTimePickerValidUntil = new DateTimePicker();
            label1 = new Label();
            comboBoxBillingPeriod = new ComboBox();
            tabPage3 = new TabPage();
            buttonSettle = new Button();
            dataGridViewExpired = new DataGridView();
            Column6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewComboBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewComboBoxColumn();
            tabPage7 = new TabPage();
            labelStats = new Label();
            tabPage2 = new TabPage();
            buttonAddMonth = new Button();
            dateTimePickerCurrentDate = new DateTimePicker();
            listBoxEvents = new ListBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInsurance).BeginInit();
            tabControlInsType.SuspendLayout();
            tabPage4.SuspendLayout();
            tabPage5.SuspendLayout();
            tabPage6.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewExpired).BeginInit();
            tabPage7.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage7);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(1, 1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(799, 451);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(textBoxIncome);
            tabPage1.Controls.Add(dataGridViewInsurance);
            tabPage1.Controls.Add(tabControlInsType);
            tabPage1.Controls.Add(buttonAddInsurance);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(textBoxFranchise);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(textBoxMaxSum);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(dateTimePickerValidUntil);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(comboBoxBillingPeriod);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(791, 423);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Страховки";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(7, 178);
            label8.Name = "label8";
            label8.Size = new Size(39, 15);
            label8.TabIndex = 12;
            label8.Text = "Взнос";
            // 
            // textBoxIncome
            // 
            textBoxIncome.Location = new Point(7, 196);
            textBoxIncome.Name = "textBoxIncome";
            textBoxIncome.Size = new Size(211, 23);
            textBoxIncome.TabIndex = 11;
            // 
            // dataGridViewInsurance
            // 
            dataGridViewInsurance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInsurance.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column8, Column5 });
            dataGridViewInsurance.Location = new Point(224, 3);
            dataGridViewInsurance.Name = "dataGridViewInsurance";
            dataGridViewInsurance.ReadOnly = true;
            dataGridViewInsurance.RowTemplate.Height = 25;
            dataGridViewInsurance.Size = new Size(564, 417);
            dataGridViewInsurance.TabIndex = 10;
            // 
            // Column1
            // 
            Column1.HeaderText = "Период оплаты";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Действительна до";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Макс. сумма возмещения";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Покрываемый ущерб";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column8
            // 
            Column8.HeaderText = "Взнос";
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "Доп. инфо";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // tabControlInsType
            // 
            tabControlInsType.Controls.Add(tabPage4);
            tabControlInsType.Controls.Add(tabPage5);
            tabControlInsType.Controls.Add(tabPage6);
            tabControlInsType.Location = new Point(7, 225);
            tabControlInsType.Name = "tabControlInsType";
            tabControlInsType.SelectedIndex = 0;
            tabControlInsType.Size = new Size(215, 163);
            tabControlInsType.TabIndex = 9;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(label5);
            tabPage4.Controls.Add(textBoxAutoMark);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(207, 135);
            tabPage4.TabIndex = 0;
            tabPage4.Text = "Автомобильная";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 3);
            label5.Name = "label5";
            label5.Size = new Size(116, 15);
            label5.TabIndex = 11;
            label5.Text = "Марка авто/модель";
            // 
            // textBoxAutoMark
            // 
            textBoxAutoMark.Location = new Point(6, 21);
            textBoxAutoMark.Name = "textBoxAutoMark";
            textBoxAutoMark.Size = new Size(195, 23);
            textBoxAutoMark.TabIndex = 11;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(label6);
            tabPage5.Controls.Add(textBoxAssetAddress);
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(207, 135);
            tabPage5.TabIndex = 1;
            tabPage5.Text = "Недвижимость";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 3);
            label6.Name = "label6";
            label6.Size = new Size(40, 15);
            label6.TabIndex = 12;
            label6.Text = "Адрес";
            // 
            // textBoxAssetAddress
            // 
            textBoxAssetAddress.Location = new Point(6, 21);
            textBoxAssetAddress.Name = "textBoxAssetAddress";
            textBoxAssetAddress.Size = new Size(195, 23);
            textBoxAssetAddress.TabIndex = 13;
            // 
            // tabPage6
            // 
            tabPage6.Controls.Add(label7);
            tabPage6.Controls.Add(textBoxSnils);
            tabPage6.Location = new Point(4, 24);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3);
            tabPage6.Size = new Size(207, 135);
            tabPage6.TabIndex = 2;
            tabPage6.Text = "Здоровье";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 2);
            label7.Name = "label7";
            label7.Size = new Size(49, 15);
            label7.TabIndex = 14;
            label7.Text = "СНИЛС";
            // 
            // textBoxSnils
            // 
            textBoxSnils.Location = new Point(6, 20);
            textBoxSnils.Name = "textBoxSnils";
            textBoxSnils.Size = new Size(195, 23);
            textBoxSnils.TabIndex = 15;
            // 
            // buttonAddInsurance
            // 
            buttonAddInsurance.Location = new Point(7, 394);
            buttonAddInsurance.Name = "buttonAddInsurance";
            buttonAddInsurance.Size = new Size(215, 23);
            buttonAddInsurance.TabIndex = 8;
            buttonAddInsurance.Text = "Добавить";
            buttonAddInsurance.UseVisualStyleBackColor = true;
            buttonAddInsurance.Click += buttonAddInsurance_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 134);
            label4.Name = "label4";
            label4.Size = new Size(128, 15);
            label4.TabIndex = 7;
            label4.Text = "Покрываемый ущерб";
            // 
            // textBoxFranchise
            // 
            textBoxFranchise.Location = new Point(7, 152);
            textBoxFranchise.Name = "textBoxFranchise";
            textBoxFranchise.Size = new Size(211, 23);
            textBoxFranchise.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 91);
            label3.Name = "label3";
            label3.Size = new Size(151, 15);
            label3.TabIndex = 5;
            label3.Text = "Макс. сумма возмещения";
            // 
            // textBoxMaxSum
            // 
            textBoxMaxSum.Location = new Point(7, 109);
            textBoxMaxSum.Name = "textBoxMaxSum";
            textBoxMaxSum.Size = new Size(211, 23);
            textBoxMaxSum.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 47);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 3;
            label2.Text = "Действует до";
            // 
            // dateTimePickerValidUntil
            // 
            dateTimePickerValidUntil.Location = new Point(7, 65);
            dateTimePickerValidUntil.Name = "dateTimePickerValidUntil";
            dateTimePickerValidUntil.Size = new Size(211, 23);
            dateTimePickerValidUntil.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 3);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 1;
            label1.Text = "Период оплаты";
            // 
            // comboBoxBillingPeriod
            // 
            comboBoxBillingPeriod.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxBillingPeriod.FormattingEnabled = true;
            comboBoxBillingPeriod.Items.AddRange(new object[] { "Ежемесячно", "Квартально", "Ежегодно" });
            comboBoxBillingPeriod.Location = new Point(7, 21);
            comboBoxBillingPeriod.Name = "comboBoxBillingPeriod";
            comboBoxBillingPeriod.Size = new Size(211, 23);
            comboBoxBillingPeriod.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(buttonSettle);
            tabPage3.Controls.Add(dataGridViewExpired);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(791, 423);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Действия по истекшим страховкам";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // buttonSettle
            // 
            buttonSettle.Location = new Point(573, 394);
            buttonSettle.Name = "buttonSettle";
            buttonSettle.Size = new Size(215, 23);
            buttonSettle.TabIndex = 12;
            buttonSettle.Text = "Применить действия";
            buttonSettle.UseVisualStyleBackColor = true;
            buttonSettle.Click += buttonSettle_Click;
            // 
            // dataGridViewExpired
            // 
            dataGridViewExpired.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewExpired.Columns.AddRange(new DataGridViewColumn[] { Column6, dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, Column9, dataGridViewTextBoxColumn5, Column7 });
            dataGridViewExpired.Location = new Point(3, 3);
            dataGridViewExpired.Name = "dataGridViewExpired";
            dataGridViewExpired.RowTemplate.Height = 25;
            dataGridViewExpired.Size = new Size(785, 385);
            dataGridViewExpired.TabIndex = 11;
            // 
            // Column6
            // 
            Column6.HeaderText = "Id";
            Column6.Name = "Column6";
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Период оплаты";
            dataGridViewTextBoxColumn1.Items.AddRange(new object[] { "Ежемесячно", "Квартально", "Ежегодно" });
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Resizable = DataGridViewTriState.True;
            dataGridViewTextBoxColumn1.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Действительна до";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Макс. сумма возмещения";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Покрываемый ущерб";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // Column9
            // 
            Column9.HeaderText = "Взнос";
            Column9.Name = "Column9";
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Доп. инфо";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // Column7
            // 
            Column7.HeaderText = "Обнулить";
            Column7.Items.AddRange(new object[] { "Нет", "Да" });
            Column7.Name = "Column7";
            Column7.Resizable = DataGridViewTriState.True;
            Column7.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // tabPage7
            // 
            tabPage7.Controls.Add(listBoxEvents);
            tabPage7.Controls.Add(labelStats);
            tabPage7.Location = new Point(4, 24);
            tabPage7.Name = "tabPage7";
            tabPage7.Padding = new Padding(3);
            tabPage7.Size = new Size(791, 423);
            tabPage7.TabIndex = 3;
            tabPage7.Text = "Статистика";
            tabPage7.UseVisualStyleBackColor = true;
            // 
            // labelStats
            // 
            labelStats.AutoSize = true;
            labelStats.Location = new Point(7, 3);
            labelStats.Name = "labelStats";
            labelStats.Size = new Size(38, 15);
            labelStats.TabIndex = 0;
            labelStats.Text = "label9";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(buttonAddMonth);
            tabPage2.Controls.Add(dateTimePickerCurrentDate);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(791, 423);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Управление временем";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonAddMonth
            // 
            buttonAddMonth.Location = new Point(7, 35);
            buttonAddMonth.Name = "buttonAddMonth";
            buttonAddMonth.Size = new Size(200, 23);
            buttonAddMonth.TabIndex = 1;
            buttonAddMonth.Text = "+ Месяц";
            buttonAddMonth.UseVisualStyleBackColor = true;
            buttonAddMonth.Click += buttonAddMonth_Click;
            // 
            // dateTimePickerCurrentDate
            // 
            dateTimePickerCurrentDate.Location = new Point(7, 6);
            dateTimePickerCurrentDate.Name = "dateTimePickerCurrentDate";
            dateTimePickerCurrentDate.Size = new Size(200, 23);
            dateTimePickerCurrentDate.TabIndex = 0;
            // 
            // listBoxEvents
            // 
            listBoxEvents.FormattingEnabled = true;
            listBoxEvents.ItemHeight = 15;
            listBoxEvents.Location = new Point(7, 21);
            listBoxEvents.Name = "listBoxEvents";
            listBoxEvents.Size = new Size(776, 394);
            listBoxEvents.TabIndex = 1;
            // 
            // App
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "App";
            Text = "App";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInsurance).EndInit();
            tabControlInsType.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            tabPage6.ResumeLayout(false);
            tabPage6.PerformLayout();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewExpired).EndInit();
            tabPage7.ResumeLayout(false);
            tabPage7.PerformLayout();
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label1;
        private ComboBox comboBoxBillingPeriod;
        private Label label4;
        private TextBox textBoxFranchise;
        private Label label3;
        private TextBox textBoxMaxSum;
        private Label label2;
        private DateTimePicker dateTimePickerValidUntil;
        private TabPage tabPage3;
        private TabControl tabControlInsType;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private Button buttonAddInsurance;
        private DataGridView dataGridViewInsurance;
        private Label label5;
        private TextBox textBoxAutoMark;
        private Label label6;
        private TextBox textBoxAssetAddress;
        private Label label7;
        private TextBox textBoxSnils;
        private DateTimePicker dateTimePickerCurrentDate;
        private Button buttonAddMonth;
        private DataGridView dataGridViewExpired;
        private Button buttonSettle;
        private TabPage tabPage7;
        private Label label8;
        private TextBox textBoxIncome;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewComboBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewComboBoxColumn Column7;
        private Label labelStats;
        private ListBox listBoxEvents;
    }
}