namespace Rimskie_and_arabskie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int number;
            if (int.TryParse(textBox1.Text, out number))
            {
                if (number < 1 || number > 3999)
                {
                    label1.Text = "Invalid input";
                }
                else
                {
                    string romanNumber = ConvertToRoman(number);
                    label1.Text = romanNumber;
                }
            }
            else
            {
                label1.Text = "Invalid input";
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string romanNumber = textBox1.Text;
            int arabicNumber = ConvertToArabic(romanNumber);
            label1.Text = arabicNumber.ToString();
        }
        private string ConvertToRoman(int number)
        {
            int[] arabicValues = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            string[] romanNumerals = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
            string romanNumber = "";
            for (int i = 0; i < arabicValues.Length; i++)
            {
                while (number >= arabicValues[i])
                {
                    romanNumber += romanNumerals[i];
                    number -= arabicValues[i];
                }
            }
            return romanNumber;
        }
        private int ConvertToArabic(string romanNumber)
        {
            string[] romanNumerals = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
            int[] arabicValues = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            int arabicNumber = 0;
            int index = 0;
            foreach (string numeral in romanNumerals)
            {
                while (romanNumber.StartsWith(numeral))
                {
                    arabicNumber += arabicValues[index];
                    romanNumber = romanNumber.Substring(numeral.Length);
                }
                index++;
            }
            return arabicNumber;
        }
    }
}