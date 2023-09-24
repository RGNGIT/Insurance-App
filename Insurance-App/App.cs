using Insurance_App.Models;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

namespace Insurance_App
{
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
            CollectStatisticsData();
        }

        void CollectStatisticsData()
        {
            labelStats.Text = $"Капитал: {bank}p.";

            if(bank < 0) 
            {
                isBankrupt = true;
            }
        }

        float bank = 1000000;
        int month = 0;
        bool isBankrupt = false;

        Dictionary<EInsuranceBillingPeriod, string> periodNames = new()
            {
                { EInsuranceBillingPeriod.Monthly, "Ежемесячно" },
                { EInsuranceBillingPeriod.Quarterly, "Квартально" },
                { EInsuranceBillingPeriod.Annualy, "Ежегодно" }
            };

        Dictionary<string, EInsuranceBillingPeriod> namesPeriod = new()
            {
                { "Ежемесячно", EInsuranceBillingPeriod.Monthly },
                { "Квартально", EInsuranceBillingPeriod.Quarterly },
                { "Ежегодно", EInsuranceBillingPeriod.Annualy }
            };

        void RefreshGrid()
        {
            dataGridViewInsurance.Rows.Clear();

            void addAction(string period, string validTo, string maxSum, string coverage, string income, string additionalInfo)
            {
                dataGridViewInsurance.Rows.Add(period, validTo, maxSum, coverage, income, additionalInfo);
            }

            Storage.InsuranceDocuments
                .Where(d => d is CarInsurance)
                .Select(d => d as CarInsurance)
                .ToList()
                .ForEach(d => addAction(
                    periodNames[d!.BillingPeriod],
                    d.ValidUntil.ToString()!,
                    d.MaxSum.ToString()!,
                    d.Franchise.ToString()!,
                    d.Income.ToString()!,
                    $"Марка авто: {d.CarMark}"
                    ));

            Storage.InsuranceDocuments
                .Where(d => d is AssetInsurance)
                .Select(d => d as AssetInsurance)
                .ToList()
                .ForEach(d => addAction(
                    periodNames[d!.BillingPeriod],
                    d.ValidUntil.ToString()!,
                    d.MaxSum.ToString()!,
                    d.Franchise.ToString()!,
                    d.Income.ToString()!,
                    $"Адрес: {d.Address}"
                    ));

            Storage.InsuranceDocuments
                .Where(d => d is HealthInsurance)
                .Select(d => d as HealthInsurance)
                .ToList()
                .ForEach(d => addAction(
                    periodNames[d!.BillingPeriod],
                    d.ValidUntil.ToString()!,
                    d.MaxSum.ToString()!,
                    d.Franchise.ToString()!,
                    d.Income.ToString()!,
                    $"СНИЛС: {d.SNILS}"
                    ));
        }

        EInsuranceBillingPeriod definePeriod()
        {
            switch (comboBoxBillingPeriod.SelectedIndex)
            {
                case 0:
                    return EInsuranceBillingPeriod.Monthly;
                case 1:
                    return EInsuranceBillingPeriod.Quarterly;
                case 2:
                    return EInsuranceBillingPeriod.Annualy;
            }

            return EInsuranceBillingPeriod.Undefined;
        }

        private void buttonAddInsurance_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBoxBillingPeriod.Text))
            {
                MessageBox.Show("Не выбран период взноса.");
                return;
            }

            if (dateTimePickerValidUntil.Value < dateTimePickerCurrentDate.Value)
            {
                MessageBox.Show("Дата действия страховки меньше текущей.");
                return;
            }

            try
            {
                InsuranceDocument? document = null;

                switch (tabControlInsType.SelectedIndex)
                {
                    case 0:
                        document = new CarInsurance(textBoxAutoMark.Text);
                        break;
                    case 1:
                        document = new AssetInsurance(textBoxAssetAddress.Text);
                        break;
                    case 2:
                        document = new HealthInsurance(textBoxSnils.Text);
                        break;
                }

                document!.BillingPeriod = definePeriod();
                document!.ValidUntil = dateTimePickerValidUntil.Value;
                document!.MaxSum = float.Parse(textBoxMaxSum.Text);
                document!.Franchise = float.Parse(textBoxFranchise.Text);
                document!.Income = float.Parse(textBoxIncome.Text);

                Storage.InsuranceDocuments.Add(document);
                RefreshGrid();
            }
            catch
            {
                MessageBox.Show("Вероятно, неверный формат денежного числа.");
            }
        }

        void AddExpiredInsuranceDocument()
        {
            bool findDoc(string id)
            {
                for (int i = 0; i < dataGridViewExpired.Rows.Count - 1; i++)
                {
                    if (dataGridViewExpired.Rows[i].Cells[0].Value.ToString() == id)
                        return true;
                }

                return false;
            }

            foreach (InsuranceDocument document in Storage.InsuranceDocuments)
            {
                if (!findDoc(document.Id) && dateTimePickerCurrentDate.Value > document.ValidUntil)
                {
                    Storage.ExpiredDocuments.Add(document);

                    if (document is CarInsurance)
                        dataGridViewExpired.Rows.Add(
                            document.Id,
                            periodNames[document!.BillingPeriod],
                            document.ValidUntil.ToString()!,
                            document.MaxSum.ToString()!,
                            document.Franchise.ToString()!,
                            $"{(document as CarInsurance)!.CarMark}",
                            document.Income,
                            "Нет"
                            );

                    if (document is AssetInsurance)
                        dataGridViewExpired.Rows.Add(
                            document.Id,
                            periodNames[document!.BillingPeriod],
                            document.ValidUntil.ToString()!,
                            document.MaxSum.ToString()!,
                            document.Franchise.ToString()!,
                            $"{(document as AssetInsurance)!.Address}",
                            document.Income,
                            "Нет"
                            );

                    if (document is HealthInsurance)
                        dataGridViewExpired.Rows.Add(
                            document.Id,
                            periodNames[document!.BillingPeriod],
                            document.ValidUntil.ToString()!,
                            document.MaxSum.ToString()!,
                            document.Franchise.ToString()!,
                            $"{(document as HealthInsurance)!.SNILS}",
                            document.Income,
                            "Нет"
                            );
                }
            }
        }

        void WannaSomeTroubles()
        {
            int cases = new Random().Next(1, 25);

            for(int i = 0; i < Storage.InsuranceDocuments.Count && i < cases; i++) 
            {
                if (Storage.ExpiredDocuments.Contains(Storage.InsuranceDocuments[i]))
                    continue;

                float damage = new Random().Next(
                    Convert.ToInt32(Storage.InsuranceDocuments[i].Franchise - 10000), 
                    Convert.ToInt32(Storage.InsuranceDocuments[i].Franchise + 10000)
                    );

                if (damage >= Storage.InsuranceDocuments[i].Franchise) 
                {
                    float coef = damage / Storage.InsuranceDocuments[i].MaxSum;
                    float coverage = Storage.InsuranceDocuments[i].MaxSum * coef;

                    listBoxEvents.Items.Add($"{dateTimePickerCurrentDate.Value.Date} на {month}й месяц произошел {Storage.InsuranceDocuments[i].ShortDefinition}. Ущерб: {damage}p. Выплата: {coverage}p.");

                    bank -= coverage;

                    CollectStatisticsData();
                }
            }
        }

        void TaxCheck()
        {
            if(month % 12 == 0) 
            {
                listBoxEvents.Items.Add($"Плата ежегодного налога государству от общей суммы капитала 9% ({bank * 0.09f}p.)");
                bank *= 0.91f;

                CollectStatisticsData();
            }
        }

        void ItsCollectingTime() 
        {
            foreach(InsuranceDocument document in Storage.InsuranceDocuments) 
            {
                if(!Storage.ExpiredDocuments.Contains(document)) 
                {
                    if (document.BillingPeriod == EInsuranceBillingPeriod.Monthly)
                    {
                        bank += document.Income;
                        listBoxEvents.Items.Add($"За страховку {document.Id} внесли плату {document.Income}p.");
                    }

                    if (month % 3 == 0 && document.BillingPeriod == EInsuranceBillingPeriod.Quarterly)
                    {
                        bank += document.Income;
                        listBoxEvents.Items.Add($"За страховку {document.Id} внесли плату {document.Income}p.");
                    }

                    if(month % 12 == 0 && document.BillingPeriod == EInsuranceBillingPeriod.Annualy)
                    {
                        bank += document.Income;
                        listBoxEvents.Items.Add($"За страховку {document.Id} внесли плату {document.Income}p.");
                    }
                }

            }
        }

        private void buttonAddMonth_Click(object sender, EventArgs e)
        {
            month++;

            if (Storage.ExpiredDocuments.Count > 0)
            {
                MessageBox.Show("Для продолжения моделирования необходимо произвести действия над истекшими страховками.");
                return;
            }

            dateTimePickerCurrentDate.Value = dateTimePickerCurrentDate.Value.AddMonths(1);
            AddExpiredInsuranceDocument();
            ItsCollectingTime();
            WannaSomeTroubles();
            TaxCheck();
        }

        int fetchIndex(List<InsuranceDocument> list, string id)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Id == id)
                    return i;
            }

            return -1;
        }

        private void buttonSettle_Click(object sender, EventArgs e)
        {
            foreach (InsuranceDocument document in Storage.ExpiredDocuments)
            {
                for (int i = 0; i < dataGridViewExpired.Rows.Count - 1; i++)
                {
                    if (dataGridViewExpired.Rows[i].Cells[0].Value.ToString() == document.Id)
                    {
                        if (dataGridViewExpired.Rows[i].Cells[7].Value.ToString() == "Да")
                        {
                            Storage.InsuranceDocuments.RemoveAt(fetchIndex(Storage.InsuranceDocuments, document.Id));

                            continue;
                        }

                        int index = fetchIndex(Storage.InsuranceDocuments, document.Id);

                        Storage.InsuranceDocuments.ElementAt(index).BillingPeriod = namesPeriod[dataGridViewExpired.Rows[i].Cells[1].Value.ToString()!];
                        Storage.InsuranceDocuments.ElementAt(index).ValidUntil = DateTime.Parse(dataGridViewExpired.Rows[i].Cells[2].Value.ToString()!);
                        Storage.InsuranceDocuments.ElementAt(index).MaxSum = float.Parse(dataGridViewExpired.Rows[i].Cells[3].Value.ToString()!);
                        Storage.InsuranceDocuments.ElementAt(index).Franchise = float.Parse(dataGridViewExpired.Rows[i].Cells[4].Value.ToString()!);
                        Storage.InsuranceDocuments.ElementAt(index).Income = float.Parse(dataGridViewExpired.Rows[i].Cells[5].Value.ToString()!);

                        if (Storage.InsuranceDocuments.ElementAt(index) is CarInsurance)
                        {
                            (Storage.InsuranceDocuments.ElementAt(index) as CarInsurance)!.CarMark = dataGridViewExpired.Rows[i].Cells[6].Value.ToString()!;
                        }

                        if (Storage.InsuranceDocuments.ElementAt(index) is AssetInsurance)
                        {
                            (Storage.InsuranceDocuments.ElementAt(index) as AssetInsurance)!.Address = dataGridViewExpired.Rows[i].Cells[6].Value.ToString()!;
                        }

                        if (Storage.InsuranceDocuments.ElementAt(index) is HealthInsurance)
                        {
                            (Storage.InsuranceDocuments.ElementAt(index) as HealthInsurance)!.SNILS = dataGridViewExpired.Rows[i].Cells[6].Value.ToString()!;
                        }

                    }
                }
            }

            Storage.ExpiredDocuments.Clear();

            RefreshGrid();
            dataGridViewExpired.Rows.Clear();
        }
    }
}