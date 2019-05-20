using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST_117_Exercise_8
{
    public partial class CaloriesCalcForm : Form
    {
        public CaloriesCalcForm()
        {
            InitializeComponent();
        }
        private int CarbCalories()
        {
            int carbs;
            bool result = Int32.TryParse(carbGramTextBox.Text, out carbs);
            if (result)
            {
                return carbs * 4;
            }
            else
            {
                MessageBox.Show("Carbs must be an integer", "Invalid Input");
                return 0;
            }
        }
            private int FatCalories()
        {
            int fat;
            bool result = Int32.TryParse(fatGramTextBox.Text, out fat);
            if (result)
            {
                return fat * 9;
            }
            else
            {
                MessageBox.Show("Fat must be an integer", "Invalid Input");
                return 0;
            }
        }

        private void CalcButton_Click(object sender, EventArgs e)
        {
            int carbCalories = CarbCalories();
            int fatCalories = FatCalories();
            carbCaloriesOutputLabel.Text = "Calories from Carbs: " + carbCalories;
            fatCaloriesOutputLabel.Text = "Calories from Fat: " + fatCalories;
            ToolBarTextAlignCaloriesLabel.Text = "Total Calories: " + (fatCalories + carbCalories);
        }
    }
}
