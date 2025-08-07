using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Unit_Conversion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cboxUnit.SelectedIndex = 0;
            selectFirstItem();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboxUnit.SelectedItem){
                case "Length":
                    cboxOutput.Items.Clear();
                    cboxInput.Items.Clear();
                    cboxInput.Items.AddRange(new string[] { "millimeter", "centimeter", "meter", "kilometer", "inch", "foot", "yard" });
                    cboxOutput.Items.AddRange(new string[] { "millimeter", "centimeter", "meter", "kilometer", "inch", "foot", "yard" });
                    selectFirstItem();
                    break;
                case "Temperature":
                    cboxOutput.Items.Clear();
                    cboxInput.Items.Clear();
                    cboxInput.Items.AddRange(new string[] { "Celsius", "Fahrenheit", "Kelvin" });
                    cboxOutput.Items.AddRange(new string[] { "Celsius", "Fahrenheit", "Kelvin" });
                    selectFirstItem();
                    break;
                case "Weight / Mass":
                    cboxOutput.Items.Clear();
                    cboxInput.Items.Clear();
                    cboxInput.Items.AddRange(new string[] { "milligram", "gram", "kilogram", "pound", "ounce" });
                    cboxOutput.Items.AddRange(new string[] { "milligram", "gram", "kilogram", "pound", "ounce" });
                    selectFirstItem();
                    break;
                case "Time":
                    cboxOutput.Items.Clear();
                    cboxInput.Items.Clear();
                    cboxInput.Items.AddRange(new string[] { "second", "minute", "hour", "day", "week" });
                    cboxOutput.Items.AddRange(new string[] { "second", "minute", "hour", "day", "week" });
                    selectFirstItem();
                    break;
                case "Speed":
                    cboxOutput.Items.Clear();
                    cboxInput.Items.Clear();
                    cboxInput.Items.AddRange(new string[] { "meters per second", "kilometers per hour", "miles per hour", "knots" });
                    cboxOutput.Items.AddRange(new string[] { "meters per second", "kilometers per hour", "miles per hour", "knots" });
                    selectFirstItem();
                    break;
                case "Area":
                    cboxOutput.Items.Clear();
                    cboxInput.Items.Clear();
                    cboxInput.Items.AddRange(new string[] { "square meter", "square kilometer", "square foot", "acre", "hectare" });
                    cboxOutput.Items.AddRange(new string[] { "square meter", "square kilometer", "square foot", "acre", "hectare" });
                    selectFirstItem();
                    break;
                case "Data Storage":
                    cboxOutput.Items.Clear();
                    cboxInput.Items.Clear();
                    cboxInput.Items.AddRange(new string[] { "bit", "byte", "kilobyte", "megabyte", "gigabyte" });
                    cboxOutput.Items.AddRange(new string[] { "bit", "byte", "kilobyte", "megabyte", "gigabyte" });
                    selectFirstItem();
                    break;
                case "Currency":
                    cboxOutput.Items.Clear();
                    cboxInput.Items.Clear();
                    cboxInput.Items.AddRange(new string[] { "USD", "EUR", "PHP", "JPY", "GBP" });
                    cboxOutput.Items.AddRange(new string[] { "USD", "EUR", "PHP", "JPY", "GBP" });
                    selectFirstItem();
                    break;
            }   
        }
        private void selectFirstItem()
        {
            cboxInput.SelectedIndex = 0;
            cboxOutput.SelectedIndex = 1;
        }
    }
}
