using System.Security;
using System.Windows.Forms;


namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        // Variables
        decimal P = 0m; // Initial principal amount
        const decimal alltrust = 2400m;
        const decimal attivo = 0.005m; // Annual charge from Attivo to be deducted
        const decimal brewinH = 0.006m; // Annual charge from Brewin to be deducted
        const decimal brewinL = 0.007m; // Annual charge from Brewin to be deducted
        decimal attivoTotal = 0;
        decimal alltrustTotal = 0;
        decimal brewinTotal = 0;
        decimal[] annualGrowthRates = new decimal[10];
        decimal PMT = 1m; // Monthly contribution
        //List<decimal> annualGrowthRates = new List<decimal> { 0.05m, 0.04m, 0.06m };

        public Form1()
        {
            InitializeComponent();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Initialise variables incase of values change
            attivoTotal = 0;
            alltrustTotal = 0;
            brewinTotal = 0;
            annualGrowthRates[0] = decimal.TryParse(y1.Text, out decimal y1apr) ? (y1apr / 100m) : 0m;
            annualGrowthRates[1] = decimal.TryParse(y2.Text, out decimal y2apr) ? (y2apr / 100m) : 0m;
            annualGrowthRates[2] = decimal.TryParse(y3.Text, out decimal y3apr) ? (y3apr / 100m) : 0m;
            annualGrowthRates[3] = decimal.TryParse(y4.Text, out decimal y4apr) ? (y4apr / 100m) : 0m;
            annualGrowthRates[4] = decimal.TryParse(y5.Text, out decimal y5apr) ? (y5apr / 100m) : 0m;
            annualGrowthRates[5] = decimal.TryParse(y6.Text, out decimal y6apr) ? (y6apr / 100m) : 0m;
            annualGrowthRates[6] = decimal.TryParse(y7.Text, out decimal y7apr) ? (y7apr / 100m) : 0m;
            annualGrowthRates[7] = decimal.TryParse(y8.Text, out decimal y8apr) ? (y8apr / 100m) : 0m;
            annualGrowthRates[8] = decimal.TryParse(y9.Text, out decimal y9apr) ? (y9apr / 100m) : 0m;
            annualGrowthRates[9] = decimal.TryParse(y10.Text, out decimal y10apr) ? (y10apr / 100m) : 0m;


            // Calculate 
            decimal A = CalculateFutureValue(P, annualGrowthRates, PMT, attivo, ref attivoTotal, ref alltrustTotal, ref brewinTotal);

            // Display on screen the total projected value and totals costs
            projectedValue.Text = A.ToString("N2");
            attivocosts.Text = attivoTotal.ToString("N2");
            alltrustcosts.Text = alltrustTotal.ToString("N2");
            brewincosts.Text = brewinTotal.ToString("N2");
            decimal sumTotal = attivoTotal + alltrustTotal + brewinTotal;
            totalcosts.Text = sumTotal.ToString("N2");

        }


        private void startValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow numeric digits, backspace, and decimal point
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            // Prevent more than one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void startValue_Leave(object sender, EventArgs e)
        {
            string input = startValue.Text;
            decimal? convertedDecimal = ConvertStringToDecimal(input);

            if (convertedDecimal.HasValue)
            {
                // Place the converted value into the principle variable 'P' to use in the calculation
                P = convertedDecimal.Value;
                // convert the value into a string to display e.g. entry 1000000, display as a string 1,000,000.00
                // Use "N2" format specifier to include thousands separator and two decimal places
                string formattedValue = convertedDecimal.Value.ToString("N2");
                startValue.Text = formattedValue;

            }
            else
            {
                // Conversion failed, handle accordingly
                MessageBox.Show("Please enter a valid decimal number.");
            }
        }


        private void periodicAdditions_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow numeric digits and backspace only
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Suppress the character if it's not a digit or a control character
            }
        }

        private void periodicAdditions_Leave(object sender, EventArgs e)
        {
            string input = periodicAdditions.Text;
            decimal? convertedDecimal = ConvertStringToDecimal(input);

            if (convertedDecimal.HasValue)
            {
                // Place the converted value into the principle variable 'P' to use in the calculation
                PMT = convertedDecimal.Value;
                // convert the value into a string to display e.g. entry 1000000, display as a string 1,000,000.00
                // Use "N2" format specifier to include thousands separator and two decimal places
                string formattedValue = convertedDecimal.Value.ToString("N2");
                periodicAdditions.Text = formattedValue;

            }
            else
            {
                // Conversion failed, handle accordingly
                MessageBox.Show("Please enter a valid decimal number.");
            }
        }



        private decimal? ConvertStringToDecimal(string input)

        //Method to convert a string to a decimal value i.e. from a textbox entry

        {
            if (Decimal.TryParse(input, out decimal result))
            {
                return result; // Return the converted decimal if successful
            }
            else
            {
                return null; // Return null if conversion fails
            }
        }

        private int? ConvertStringToInt(string input)

        //Method to convert a string to an int value i.e. from a textbox entry

        {
            if (int.TryParse(input, out int result))
            {
                return result; // Return the converted decimal if successful
            }
            else
            {
                return null; // Return null if conversion fails
            }
        }

        private decimal? ConvertStringToDecimalPercent(string input)

        //Method to convert a string to a decimal value i.e. from a textbox entry and /100 for apr

        {
            if (Decimal.TryParse(input, out decimal result))
            {
                return result / 100; // Return the converted decimal if successful
            }
            else
            {
                return null; // Return null if conversion fails
            }
        }


        static decimal CalculateFutureValue(decimal P, decimal[] annualGrowthRates, decimal yearlyAddtion, decimal attivo, ref decimal attivoTotal, ref decimal alltrustTotal, ref decimal brewinTotal)
        {

            decimal amount = P; // Start with the initial principal
            

            decimal futureValueOfSeries = 0; // Initialize future value of the series
            decimal attivoCost;
            decimal brewinCost;
            decimal brewinCostH;
            decimal brewinCostL;
            decimal brewinHigh;
            decimal brewinLow = 999999m;

            for (int year = 0; year < annualGrowthRates.Length; year++)
            {
                // Skip the iteration if the growth rate for the year is 0
                if (annualGrowthRates[year] == 0m)
                {
                    continue;
                }
                else
                {
                    // Apply the growth rate for the current year, compounded annually
                    amount *= (1 + annualGrowthRates[year]);

                    // Calculate Attivo's costs and deduct from year, and accumulate total cost

                    attivoCost = P * attivo;
                    attivoTotal += attivoCost;

                    // Calculate brewins costs
                    if (amount <= 1000000m)
                    {
                        brewinCost = amount * brewinL;
                        amount -= brewinCost;
                        brewinTotal += brewinCost;
                    }
                    else
                    {
                        // Calculate the upper and lower rates of Brewins charges. <£1m=0.7%, >£1m=0.6%
                        brewinHigh = amount - 1000000m;
                        brewinCostH = brewinHigh * brewinH;

                        brewinCostL = brewinLow * brewinL;
                        brewinTotal += (brewinCostL + brewinCostH);

                    }

                    // deduct the attivAmount from overall amount after Brewins amount has been deducted to ensure all % deductions are from the same 'amount' value
                    amount -= attivoCost;

                    // Calculate Alltrust costs deductions
                    amount -= alltrust;
                    // Calculate AllTrust Total
                    alltrustTotal += alltrust;

                    // Assuming PMT is an annual payment made at the end of each year,
                    // adjust future value of series calculation accordingly, if < 0 then = 1 else PMT
                    yearlyAddtion = yearlyAddtion <= 0 ? 1 : yearlyAddtion;
                    // Apply the annual payment with the growth rate to the future value of the series
                    futureValueOfSeries += yearlyAddtion * (DecimalPow(1 + annualGrowthRates[year], 1) - 1) / annualGrowthRates[year];
                }


            }

            // Note: The series payment part might need to be revised based on when payments are made
            // and how you wish to incorporate the varying rates for its calculation.

            return amount + futureValueOfSeries;
        }

        static decimal DecimalPow(decimal baseValue, int exponent)
        {
            decimal result = 1m;
            for (int i = 1; i <= exponent; i++)
            {
                result *= baseValue;
            }
            return result;
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void y1_Enter(object sender, EventArgs e)
        {
            y1.Clear();
        }

        private void y2_Enter(object sender, EventArgs e)
        {
            y2.Clear();
        }

        private void y3_Enter(object sender, EventArgs e)
        {
            y3.Clear();
        }

        private void y4_Enter(object sender, EventArgs e)
        {
            y4.Clear();
        }

        private void y5_Enter(object sender, EventArgs e)
        {
            y5.Clear();
        }

        private void y6_Enter(object sender, EventArgs e)
        {
            y6.Clear();
        }

        private void y7_Enter(object sender, EventArgs e)
        {
            y7.Clear();
        }

        private void y8_Enter(object sender, EventArgs e)
        {
            y8.Clear();
        }

        private void y9_Enter(object sender, EventArgs e)
        {
            y9.Clear();
        }

        private void y10_Enter(object sender, EventArgs e)
        {
            y10.Clear();
        }

        private void startValue_Enter(object sender, EventArgs e)
        {
            startValue.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Enter a Starting Value, Annual contributions \n and APR for each year, for less than 10 years, enter 0");
        }

        private void startValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

       
    }
}
