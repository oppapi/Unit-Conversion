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

        private void comboBox()
        {
            switch (cboxUnit.SelectedItem)
            {
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
                    if (!cboxInput.Items.Contains("milligram"))
                    {
                        cboxInput.Items.AddRange(new string[] { "milligram", "gram", "kilogram", "pound", "ounce" });
                        cboxOutput.Items.AddRange(new string[] { "milligram", "gram", "kilogram", "pound", "ounce" });
                    }
                    break;

                case "Volume / Capacity":
                    if (!cboxInput.Items.Contains("milliliter"))
                    {
                        cboxInput.Items.AddRange(new string[] { "milliliter", "liter", "gallon", "cup", "pint" });
                        cboxOutput.Items.AddRange(new string[] { "milliliter", "liter", "gallon", "cup", "pint" });
                    }
                    break;

                case "Time":
                    if (!cboxInput.Items.Contains("second"))
                    {
                        cboxInput.Items.AddRange(new string[] { "second", "minute", "hour", "day", "week" });
                        cboxOutput.Items.AddRange(new string[] { "second", "minute", "hour", "day", "week" });
                    }
                    break;

                case "Speed":
                    if (!cboxInput.Items.Contains("meters per second"))
                    {
                        cboxInput.Items.AddRange(new string[] { "meters per second", "kilometers per hour", "miles per hour", "knots" });
                        cboxOutput.Items.AddRange(new string[] { "meters per second", "kilometers per hour", "miles per hour", "knots" });
                    }
                    break;

                case "Area":
                    if (!cboxInput.Items.Contains("square meter"))
                    {
                        cboxInput.Items.AddRange(new string[] { "square meter", "square kilometer", "square foot", "acre", "hectare" });
                        cboxOutput.Items.AddRange(new string[] { "square meter", "square kilometer", "square foot", "acre", "hectare" });
                    }
                    break;

                case "Data Storage":
                    if (!cboxInput.Items.Contains("bit"))
                    {
                        cboxInput.Items.AddRange(new string[] { "bit", "byte", "kilobyte", "megabyte", "gigabyte" });
                        cboxOutput.Items.AddRange(new string[] { "bit", "byte", "kilobyte", "megabyte", "gigabyte" });
                    }
                    break;

                case "Currency":
                    if (!cboxInput.Items.Contains("USD"))
                    {
                        cboxInput.Items.AddRange(new string[] { "USD", "EUR", "PHP", "JPY", "GBP" });
                        cboxOutput.Items.AddRange(new string[] { "USD", "EUR", "PHP", "JPY", "GBP" });
                    }
                    break;
                default:
                    MessageBox.Show("Error in input!");
                    break;
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtOutput.Text != "")
            {
                Clipboard.SetText(txtOutput.Text);
            }
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtInput.Text))
            {
                Conversion conversion = new Conversion(); double baseUnit;
                double input = double.Parse(txtInput.Text);
                switch (cboxUnit.SelectedItem.ToString())
                {
                    case "Temperature":
                        baseUnit = conversion.convertTemperature(double.Parse(txtInput.Text), cboxInput.SelectedItem.ToString());
                        txtOutput.Text = conversion.convertTemperature(baseUnit, cboxOutput.SelectedItem.ToString()).ToString();
                    break;

                    case "Length":
                        baseUnit = conversion.convertLength(double.Parse(txtInput.Text), cboxInput.SelectedItem.ToString());
                        txtOutput.Text = (baseUnit / conversion.convertLength(1, cboxOutput.SelectedItem.ToString())).ToString();
                    break;

                    case "Weight / Mass":
                        baseUnit = conversion.convertWeight(double.Parse(txtInput.Text), cboxInput.SelectedItem.ToString());
                        txtOutput.Text = (baseUnit / conversion.convertWeight(1, cboxOutput.SelectedItem.ToString())).ToString();
                    break;

                    case "Volume / Capacity":
                        baseUnit = conversion.convertVolume(double.Parse(txtInput.Text), cboxInput.SelectedItem.ToString());
                        txtOutput.Text = (baseUnit / conversion.convertVolume(1, cboxOutput.SelectedItem.ToString())).ToString();
                        break;

                    case "Time":
                        baseUnit = conversion.convertTime(double.Parse(txtInput.Text), cboxInput.SelectedItem.ToString());
                        txtOutput.Text = (baseUnit / conversion.convertTime(1, cboxOutput.SelectedItem.ToString())).ToString();
                    break;

                    case "Speed":
                        baseUnit = conversion.convertSpeed(double.Parse(txtInput.Text), cboxInput.SelectedItem.ToString());
                        txtOutput.Text = (baseUnit / conversion.convertSpeed(1, cboxOutput.SelectedItem.ToString())).ToString();
                    break;

                    case "Area":
                        baseUnit = conversion.convertArea(double.Parse(txtInput.Text), cboxInput.SelectedItem.ToString());
                        txtOutput.Text = (baseUnit / conversion.convertArea(1, cboxOutput.SelectedItem.ToString())).ToString();
                    break;

                    case "Data Storage":
                        baseUnit = conversion.convertDataStorage(double.Parse(txtInput.Text), cboxInput.SelectedItem.ToString());
                        txtOutput.Text = (baseUnit / conversion.convertDataStorage(1, cboxOutput.SelectedItem.ToString())).ToString();
                    break;

                    case "Currency":
                        baseUnit = conversion.convertCurrency(double.Parse(txtInput.Text), cboxInput.SelectedItem.ToString());
                        txtOutput.Text = (baseUnit / conversion.convertCurrency(1, cboxOutput.SelectedItem.ToString())).ToString();
                    break;
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

        private void SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox();
            cboxInput.SelectedIndex = 0;
            cboxOutput.SelectedIndex = 1;
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(86)))), ((int)(((byte)(196)))));
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(86)))), ((int)(((byte)(250)))));
        }
    }
}
