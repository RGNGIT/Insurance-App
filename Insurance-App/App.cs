using Insurance_App.Models;

namespace Insurance_App
{
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
        }

        void RefreshGrid()
        {
            dataGridViewInsurance.Rows.Clear();

            void addAction(string period, string validTo, string maxSum, string coverage, string additionalInfo) 
            {
                dataGridViewInsurance.Rows.Add(period, validTo, maxSum, coverage, additionalInfo);
            }

            Dictionary<EInsuranceBillingPeriod, string> periodNames = new()
            {
                { EInsuranceBillingPeriod.Monthly, "Ежемесячно" },
                { EInsuranceBillingPeriod.Quarterly, "Квартально" },
                { EInsuranceBillingPeriod.Annualy, "Ежегодно" }
            };

            Storage.InsuranceDocuments
                .Where(d => d is CarInsurance)
                .Select(d => d as CarInsurance)
                .ToList()
                .ForEach(d => addAction(
                    periodNames[d!.BillingPeriod], 
                    d.ValidUntil.ToString()!, 
                    d.MaxSum.ToString()!, 
                    d.Franchise.ToString()!,
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
                    $"СНИЛС: {d.SNILS}"
                    ));
        }

        private void buttonAddInsurance_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBoxBillingPeriod.Text))
            {
                MessageBox.Show("Не выбран период взноса.");
                return;
            }

            try
            {
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

                Storage.InsuranceDocuments.Add(document);
                RefreshGrid();
            }
            catch
            {
                MessageBox.Show("Вероятно, неверный формат денежного числа.");
            }
        }
    }
}