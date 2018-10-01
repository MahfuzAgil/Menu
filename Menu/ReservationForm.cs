using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu {

    public partial class reservationForm : Form {
        private Form _MenuForm;
        private string dateMessage = string.Empty;
        private string timeMessage = string.Empty;
        private string guestName = string.Empty;
        private string guestPhone = string.Empty;
        SqlConnection con;
        SqlCommand cmd;

        public reservationForm() {
            InitializeComponent();
            phoneNumberTextBox.MaskInputRejected += new MaskInputRejectedEventHandler(phoneNumberTextBox_MaskInputRejected);
        }

        public reservationForm(Form form):this() {
            _MenuForm = form;
        }

        private void reservationForm_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'menuDataSet.Reservation' table. You can move, or remove it, as needed.
            this.reservationTableAdapter.Fill(this.menuDataSet.Reservation);
            monthCalendar1.MinDate = DateTime.Now;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e) {
            setCalendar();
            dateTimePicker2.Value = monthCalendar1.SelectionStart;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e) {
            timeMessage = this.dateTimePicker2.Value.ToString("h:mm tt");
        }

        private void makeReservationButton_Click(object sender, EventArgs e) {
            guestName = CleanInput(guestNameTextBox.Text); // removes everything except letters and single spaces
            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
            guestName = textInfo.ToTitleCase(guestName); // make sure first letters are capitalized
            // check if name and phone are valid
            if (string.IsNullOrEmpty(guestNameTextBox.Text)) {
                MessageBox.Show("Please enter a name for your reservation.");
                return;
            } else if (string.IsNullOrEmpty(guestName)) {
                MessageBox.Show("Please enter a valid name.");
                guestNameTextBox.SelectAll();
                return;
            } else {
                if (!phoneNumberTextBox.MaskCompleted) {
                    MessageBox.Show("Please enter your phone number.");
                    return;
                } else {
                    guestPhone = phoneNumberTextBox.Text;
                    DateTime date = dateTimePicker2.Value;
                    con = new SqlConnection();
                    con.ConnectionString = @"Data Source=LAPTOP-6QS87GL2;Initial Catalog=Menu;Integrated Security=True";
                    con.Open();
                    cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into reservation values('" + guestName + "','" + guestPhone + "','" + date + "')";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    guestNameTextBox.Clear();
                    phoneNumberTextBox.Clear();

                    if (dateMessage == "") // if no date is selected
                        setCalendar();
                    if (timeMessage == "") // if no time is selected
                        timeMessage = dateTimePicker2.Value.ToString("h:mm tt");
                    MessageBox.Show("Congratulations! We will see you on\n" + dateMessage +
                        " at " + timeMessage);
                    this.reservationTableAdapter.Fill(this.menuDataSet.Reservation);
                }
            }
        }

        // method sets date to whatever is selected. Called on click event and when nothing has been selected
        private string setCalendar() {
            int day = Convert.ToInt32(monthCalendar1.SelectionRange.Start.Day);
            dateMessage = monthCalendar1.SelectionRange.Start.ToString("dddd MMMM d");
            dateMessage += GetDaySuffix(day);
            dateMessage += monthCalendar1.SelectionRange.Start.ToString(", yyyy");
            return dateMessage;
        }

        // method returns day suffix based on datepicker Day
        private string GetDaySuffix(int day) {
            switch (day) {
                case 1:
                case 21:
                case 31:
                    return "st";
                case 2:
                case 22:
                    return "nd";
                case 3:
                case 23:
                    return "rd";
                default:
                    return "th";
            }
        }

        // add tooltip to guest name textbox upon entering it
        private void guestNameTextBox_Enter(object sender, EventArgs e) {
            TextBox guestNameTextBox = (TextBox)sender;
            //int VisibleTime = 1000;  //in milliseconds

            ToolTip tt = new ToolTip();
            tt.AutomaticDelay = 500;
            tt.InitialDelay = 500;
            tt.AutoPopDelay = 5000;
            tt.ReshowDelay = 100;
            tt.ShowAlways = false;
            tt.Show("Please do not enter numbers or punctuation.", guestNameTextBox);
            //tt.Show("Test ToolTip", guestNameTextBox, VisibleTime);
        }

        // tooltip for the phone number textbox input
        private void phoneNumberTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e) {
            toolTip1.Show("We're sorry, but only digits (0-9) are allowed in phone numbers.", phoneNumberTextBox, phoneNumberTextBox.Location, 5000);
        }

        // Options menu click events
        private void menuToolStripMenuItem_Click(object sender, EventArgs e) {
            _MenuForm.Show();
            this.Hide();
        }

        private void takeASurveyToolStripMenuItem_Click(object sender, EventArgs e) {
            //SurveyForm surveyForm = new SurveyForm(this, _MenuForm); // create new survey form object and pass current state
            SurveyForm surveyForm = new SurveyForm(_MenuForm); // create new survey form object and pass menu state
            surveyForm.Show(); // show survey form
            this.Hide(); // hide reservation form
        }

        private string CleanInput(string strIn) {
            // Replace invalid characters with empty strings.
            try {
                strIn = strIn.Trim(); // remove leading and trailing white space
                // Regex r = new Regex("[ ]{2,}", RegexOptions.none); // match all occurrances of two or more spaces
                strIn = Regex.Replace(strIn, @"[ ]{2,}", " "); // replace that with a single space
                // strIn = string.Join( " ", strIn.Split( new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
                return Regex.Replace(strIn, @"[^a-zA-Z ]", "", RegexOptions.None, TimeSpan.FromSeconds(6));
            } catch (RegexMatchTimeoutException) {
                // If we timeout when replacing invalid characters, we should return Empty.
                return String.Empty;
            }
        }

        //validate string 
        //private bool StringValidator(string name) {
        //    // name = name.Trim();
        //    // name = name.Replace(" ", "");
        //    string pattern = "[^a-zA-Z ]";
        //    if (Regex.IsMatch(name, pattern)) {
        //        return true;
        //    } else {
        //        return false;
        //    }
        //}

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}
