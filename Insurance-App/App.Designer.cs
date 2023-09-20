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
            dataGridViewInsurance = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
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
            tabPage2 = new TabPage();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInsurance).BeginInit();
            tabControlInsType.SuspendLayout();
            tabPage4.SuspendLayout();
            tabPage5.SuspendLayout();
            tabPage6.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(1, 1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(799, 451);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
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
            // dataGridViewInsurance
            // 
            dataGridViewInsurance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInsurance.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridViewInsurance.Location = new Point(224, 3);
            dataGridViewInsurance.Name = "dataGridViewInsurance";
            dataGridViewInsurance.RowTemplate.Height = 25;
            dataGridViewInsurance.Size = new Size(564, 417);
            dataGridViewInsurance.TabIndex = 10;
            // 
            // Column1
            // 
            Column1.HeaderText = "Период оплаты";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Действительна до";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Макс. сумма возмещения";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Покрываемый ущерб";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Доп. инфо";
            Column5.Name = "Column5";
            // 
            // tabControlInsType
            // 
            tabControlInsType.Controls.Add(tabPage4);
            tabControlInsType.Controls.Add(tabPage5);
            tabControlInsType.Controls.Add(tabPage6);
            tabControlInsType.Location = new Point(7, 181);
            tabControlInsType.Name = "tabControlInsType";
            tabControlInsType.SelectedIndex = 0;
            tabControlInsType.Size = new Size(215, 207);
            tabControlInsType.TabIndex = 9;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(label5);
            tabPage4.Controls.Add(textBoxAutoMark);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(207, 179);
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
            tabPage5.Size = new Size(207, 179);
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
            tabPage6.Size = new Size(207, 179);
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
            label2.Size = new Size(93, 15);
            label2.TabIndex = 3;
            label2.Text = "Период оплаты";
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
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(791, 423);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Действия по истекшим страховкам";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(791, 423);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Управление временем";
            tabPage2.UseVisualStyleBackColor = true;
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
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Label label5;
        private TextBox textBoxAutoMark;
        private Label label6;
        private TextBox textBoxAssetAddress;
        private Label label7;
        private TextBox textBoxSnils;
    }
}