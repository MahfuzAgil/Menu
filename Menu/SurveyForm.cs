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

    public partial class SurveyForm : Form {

        private Form _MenuForm;

        public SurveyForm() {
            InitializeComponent();
        }

        //public SurveyForm(Form form) : this() {
        //    _MenuForm = form;
        //}

        public SurveyForm(Form form1) : this() {
           // _ReservationForm = form2;
            _MenuForm = form1;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e) {
            _MenuForm.Show();
            this.Hide();
        }

        private void makeReservationToolStripMenuItem_Click(object sender, EventArgs e) {
            //if (_ReservationForm != null) {
            //    _ReservationForm.Show();
            //    this.Hide();
            //} else {
                reservationForm reservationForm = new reservationForm(_MenuForm); // create new reservation form object and pass menu state
                reservationForm.Show(); // show reservation form
                this.Hide(); // hide menu form
            //}
        }

        private void submitSurveyButton_Click(object sender, EventArgs e) {
            MessageBox.Show("Thank you for taking our survey!");
        }
    }
}
