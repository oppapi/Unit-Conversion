using System;
using System.Windows.Forms;

namespace Unit_Conversion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cboxUnit.SelectedIndex = 0;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboxUnit.SelectedItem){
                case "Length":
                    if (!cboxInput.Items.Contains("millimeter"))
                    {
                        cboxInput.Items.AddRange(new string[] { "millimeter", "centimeter", "meter", "kilometer", "inch", "foot", "yard" });
                        cboxOutput.Items.AddRange(new string[] { "millimeter", "centimeter", "meter", "kilometer", "inch", "foot", "yard" });
                    }
                    break;
 
                case "Temperature":
                    if (!cboxInput.Items.Contains("Celsius"))
                    {
                        cboxInput.Items.AddRange(new string[] { "Celsius", "Fahrenheit", "Kelvin" });
                        cboxOutput.Items.AddRange(new string[] { "Celsius", "Fahrenheit", "Kelvin" });
                    }
                    break;
                case "Weight / Mass":
                    cboxOutput.Items.Clear();
                    cboxInput.Items.Clear();
                    cboxInput.Items.AddRange(new string[] { "milligram", "gram", "kilogram", "pound", "ounce" });
                    cboxOutput.Items.AddRange(new string[] { "milligram", "gram", "kilogram", "pound", "ounce" });
                    break;
                case "Time":
                    cboxOutput.Items.Clear();
                    cboxInput.Items.Clear();
                    cboxInput.Items.AddRange(new string[] { "second", "minute", "hour", "day", "week" });
                    cboxOutput.Items.AddRange(new string[] { "second", "minute", "hour", "day", "week" });
                    break;
                case "Speed":
                    cboxOutput.Items.Clear();
                    cboxInput.Items.Clear();
                    cboxInput.Items.AddRange(new string[] { "meters per second", "kilometers per hour", "miles per hour", "knots" });
                    cboxOutput.Items.AddRange(new string[] { "meters per second", "kilometers per hour", "miles per hour", "knots" });
                    break;
                case "Area":
                    cboxOutput.Items.Clear();
                    cboxInput.Items.Clear();
                    cboxInput.Items.AddRange(new string[] { "square meter", "square kilometer", "square foot", "acre", "hectare" });
                    cboxOutput.Items.AddRange(new string[] { "square meter", "square kilometer", "square foot", "acre", "hectare" });
                    break;
                case "Data Storage":
                    cboxOutput.Items.Clear();
                    cboxInput.Items.Clear();
                    cboxInput.Items.AddRange(new string[] { "bit", "byte", "kilobyte", "megabyte", "gigabyte" });
                    cboxOutput.Items.AddRange(new string[] { "bit", "byte", "kilobyte", "megabyte", "gigabyte" });
                    break;
                case "Currency":
                    cboxOutput.Items.Clear();
                    cboxInput.Items.Clear();
                    cboxInput.Items.AddRange(new string[] { "USD", "EUR", "PHP", "JPY", "GBP" });
                    cboxOutput.Items.AddRange(new string[] { "USD", "EUR", "PHP", "JPY", "GBP" });
                    break;
            }   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtOutput.Text);
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtInput.Text))
            {
                if (cboxUnit.SelectedItem.ToString() == "Temperature")
                {
                    Conversion conversion = new Conversion();
                    double baseUnit = conversion.convertTemperature(double.Parse(txtInput.Text), cboxInput.SelectedItem.ToString());
                    txtOutput.Text = conversion.convertTemperature(baseUnit, cboxOutput.SelectedItem.ToString()).ToString();
                }
                else if (cboxUnit.SelectedItem.ToString() == "Length")
                {
                    Conversion conversion = new Conversion();
                    double baseUnit = conversion.convertLength(double.Parse(txtInput.Text), cboxInput.SelectedItem.ToString());
                    txtOutput.Text = (baseUnit / conversion.convertLength(1, cboxOutput.SelectedItem.ToString())).ToString();
                }
            }
            else
            {
                txtOutput.Text = "";
            }
        }

        private void cboxUnit_TextChanged(object sender, EventArgs e)
        {
            cboxOutput.Items.Clear();
            cboxInput.Items.Clear();
            txtInput.Text = "";
            txtOutput.Text = "";
        }
    }
}
