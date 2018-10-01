using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu {

    public partial class MenuForm : Form {
        // initialize variables
        decimal subtotal = 0.00m;
        decimal taxRate = 0.05m;
        decimal tax = 0.00m;
        decimal total = 0.00m;

        public MenuForm() {
            InitializeComponent();
        }

        private void clearButton_Click(object sender, EventArgs e) {
            clearReset();
        }

        private void UpdateFields(object comboBoxItem) {
            string text = comboBoxItem.ToString(); // get text of selection
            int index = text.IndexOf('$'); // get index of dollar sign, 
            // Subtotal
            subtotal += Convert.ToDecimal(text.Substring(index + 1)); // then take substring for all chars to right
            //subtotal += Convert.ToDecimal(cost); // add value to subtotal variable
            subtotalPlaceholderLabel.Text = decimal.Round(subtotal, 2).ToString(); // round after addition, convert back to string and update form
            // Tax
            tax = subtotal * taxRate; // calculate tax for the subtotal
            taxPlaceholderLabel.Text = decimal.Round(tax, 2).ToString(); // update tax form field
            // Total
            total = subtotal + tax; // calculate bill total
            totalPlaceholderLabel.Text = decimal.Round(total, 2).ToString(); // update total form field
        }

        private void beverageComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            UpdateFields(beverageComboBox.SelectedItem);
        }

        private void appetizerComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            UpdateFields(appetizerComboBox.SelectedItem);
        }

        private void dessertComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            UpdateFields(dessertComboBox.SelectedItem);
        }

        private void mainCourseComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            UpdateFields(mainCourseComboBox.SelectedItem);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e) {
            clearReset();
        }

        private void clearReset() {
            // Reset Form Field Values
            subtotal = 0.00m;
            subtotalPlaceholderLabel.Text = "______";
            tax = 0.00m;
            taxPlaceholderLabel.Text = "______";
            total = 0.00m;
            totalPlaceholderLabel.Text = "______";

            // Reset ComboBox Text
            beverageComboBox.Text = "Beverages";
            appetizerComboBox.Text = "Appetizers";
            dessertComboBox.Text = "Desserts";
            mainCourseComboBox.Text = "Main Courses";
        }

        private void makeReservationToolStripMenuItem_Click(object sender, EventArgs e) {
            reservationForm reservationForm = new reservationForm(this); // create new reservation form object and pass current state
            reservationForm.Show(); // show reservation form
            this.Hide(); // hide menu form
        }

        private void takeSurveyToolStripMenuItem_Click(object sender, EventArgs e) {
            SurveyForm surveyForm = new SurveyForm(this); // create new survey form object and pass current state
            surveyForm.Show(); // show survey form
            this.Hide(); // hide menu form
        }
    }
}
