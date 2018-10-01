namespace Menu
{
    partial class MenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeReservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takeSurveyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearButton = new System.Windows.Forms.Button();
            this.beverageComboBox = new System.Windows.Forms.ComboBox();
            this.appetizerComboBox = new System.Windows.Forms.ComboBox();
            this.mainCourseComboBox = new System.Windows.Forms.ComboBox();
            this.dessertComboBox = new System.Windows.Forms.ComboBox();
            this.menuGroupBox = new System.Windows.Forms.GroupBox();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.subtotalPlaceholderLabel = new System.Windows.Forms.Label();
            this.taxPlaceholderLabel = new System.Windows.Forms.Label();
            this.totalPlaceholderLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.menuGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.makeReservationToolStripMenuItem,
            this.takeSurveyToolStripMenuItem,
            this.resetToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // makeReservationToolStripMenuItem
            // 
            this.makeReservationToolStripMenuItem.Name = "makeReservationToolStripMenuItem";
            this.makeReservationToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.makeReservationToolStripMenuItem.Text = "Make a Reservation";
            this.makeReservationToolStripMenuItem.Click += new System.EventHandler(this.makeReservationToolStripMenuItem_Click);
            // 
            // takeSurveyToolStripMenuItem
            // 
            this.takeSurveyToolStripMenuItem.Name = "takeSurveyToolStripMenuItem";
            this.takeSurveyToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.takeSurveyToolStripMenuItem.Text = "Take Survey";
            this.takeSurveyToolStripMenuItem.Click += new System.EventHandler(this.takeSurveyToolStripMenuItem_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.AccessibleDescription = "Reset Form";
            this.resetToolStripMenuItem.AccessibleName = "Reset Form";
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.R)));
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.AccessibleDescription = "Exit Form";
            this.exitToolStripMenuItem.AccessibleName = "Exit Form";
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // clearButton
            // 
            this.clearButton.AccessibleDescription = "Clears Bill";
            this.clearButton.AccessibleName = "Clear Bill";
            this.clearButton.Location = new System.Drawing.Point(463, 349);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "Clear Bill";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // beverageComboBox
            // 
            this.beverageComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.beverageComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Soda $1.95",
            "Tea $1.50",
            "Coffee $1.25",
            "Mineral Water $2.95",
            "Juice $2.50",
            "Milk $1.50"});
            this.beverageComboBox.FormattingEnabled = true;
            this.beverageComboBox.Items.AddRange(new object[] {
            "Soda $1.95",
            "Tea $1.50",
            "Coffee $1.25",
            "Mineral Water $2.95",
            "Juice $2.50",
            "Milk $1.50"});
            this.beverageComboBox.Location = new System.Drawing.Point(24, 45);
            this.beverageComboBox.Name = "beverageComboBox";
            this.beverageComboBox.Size = new System.Drawing.Size(121, 21);
            this.beverageComboBox.TabIndex = 2;
            this.beverageComboBox.Text = "Beverages";
            this.beverageComboBox.SelectedIndexChanged += new System.EventHandler(this.beverageComboBox_SelectedIndexChanged);
            // 
            // appetizerComboBox
            // 
            this.appetizerComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.appetizerComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Buffalo Wings $5.95",
            "Buffalo Fingers $6.95",
            "Potato Skins $8.95",
            "Nachos $8.95",
            "Mushroom Caps $10.95",
            "Shrimp Cocktail $12.95",
            "Chips and Salsa $6.95"});
            this.appetizerComboBox.FormattingEnabled = true;
            this.appetizerComboBox.Items.AddRange(new object[] {
            "Buffalo Wings $5.95",
            "Buffalo Fingers $6.95",
            "Potato Skins $8.95",
            "Nachos $8.95",
            "Mushroom Caps $10.95",
            "Shrimp Cocktail $12.95",
            "Chips and Salsa $6.95"});
            this.appetizerComboBox.Location = new System.Drawing.Point(151, 45);
            this.appetizerComboBox.Name = "appetizerComboBox";
            this.appetizerComboBox.Size = new System.Drawing.Size(121, 21);
            this.appetizerComboBox.TabIndex = 3;
            this.appetizerComboBox.Text = "Appetizers";
            this.appetizerComboBox.SelectedIndexChanged += new System.EventHandler(this.appetizerComboBox_SelectedIndexChanged);
            // 
            // mainCourseComboBox
            // 
            this.mainCourseComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mainCourseComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Seafood Alfredo $15.95",
            "Chicken Alfredo $13.95",
            "Chicken Piccata $13.95",
            "Turkey Club $11.95",
            "Lobster Pie $19.95",
            "Prime Rib $20.95",
            "Shrimp Scampi $18.95",
            "Turkey Dinner $13.95",
            "Stuffed Chicken $14.95"});
            this.mainCourseComboBox.FormattingEnabled = true;
            this.mainCourseComboBox.Items.AddRange(new object[] {
            "Seafood Alfredo $15.95",
            "Chicken Alfredo $13.95",
            "Chicken Piccata $13.95",
            "Turkey Club $11.95",
            "Lobster Pie $19.95",
            "Prime Rib $20.95",
            "Shrimp Scampi $18.95",
            "Turkey Dinner $13.95",
            "Stuffed Chicken $14.95"});
            this.mainCourseComboBox.Location = new System.Drawing.Point(278, 45);
            this.mainCourseComboBox.Name = "mainCourseComboBox";
            this.mainCourseComboBox.Size = new System.Drawing.Size(121, 21);
            this.mainCourseComboBox.TabIndex = 4;
            this.mainCourseComboBox.Text = "Main Courses";
            this.mainCourseComboBox.SelectedIndexChanged += new System.EventHandler(this.mainCourseComboBox_SelectedIndexChanged);
            // 
            // dessertComboBox
            // 
            this.dessertComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dessertComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Apple Pie $5.95",
            "Sundae $3.95",
            "Carrot Cake $5.95",
            "Mud Pie $4.95",
            "Apple Crisp $5.95"});
            this.dessertComboBox.FormattingEnabled = true;
            this.dessertComboBox.Items.AddRange(new object[] {
            "Apple Pie $5.95",
            "Sundae $3.95",
            "Carrot Cake $5.95",
            "Mud Pie $4.95",
            "Apple Crisp $5.95"});
            this.dessertComboBox.Location = new System.Drawing.Point(405, 45);
            this.dessertComboBox.Name = "dessertComboBox";
            this.dessertComboBox.Size = new System.Drawing.Size(121, 21);
            this.dessertComboBox.TabIndex = 5;
            this.dessertComboBox.Text = "Desserts";
            this.dessertComboBox.SelectedIndexChanged += new System.EventHandler(this.dessertComboBox_SelectedIndexChanged);
            // 
            // menuGroupBox
            // 
            this.menuGroupBox.Controls.Add(this.beverageComboBox);
            this.menuGroupBox.Controls.Add(this.dessertComboBox);
            this.menuGroupBox.Controls.Add(this.appetizerComboBox);
            this.menuGroupBox.Controls.Add(this.mainCourseComboBox);
            this.menuGroupBox.Location = new System.Drawing.Point(12, 94);
            this.menuGroupBox.Name = "menuGroupBox";
            this.menuGroupBox.Size = new System.Drawing.Size(560, 88);
            this.menuGroupBox.TabIndex = 6;
            this.menuGroupBox.TabStop = false;
            this.menuGroupBox.Text = "Menu Items";
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.AutoSize = true;
            this.subtotalLabel.Location = new System.Drawing.Point(437, 242);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(61, 13);
            this.subtotalLabel.TabIndex = 7;
            this.subtotalLabel.Text = "Subtotal:  $";
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Location = new System.Drawing.Point(458, 282);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(40, 13);
            this.taxLabel.TabIndex = 8;
            this.taxLabel.Text = "Tax:  $";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(452, 319);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(46, 13);
            this.totalLabel.TabIndex = 9;
            this.totalLabel.Text = "Total:  $";
            // 
            // subtotalPlaceholderLabel
            // 
            this.subtotalPlaceholderLabel.AutoSize = true;
            this.subtotalPlaceholderLabel.Location = new System.Drawing.Point(495, 242);
            this.subtotalPlaceholderLabel.Name = "subtotalPlaceholderLabel";
            this.subtotalPlaceholderLabel.Size = new System.Drawing.Size(43, 13);
            this.subtotalPlaceholderLabel.TabIndex = 10;
            this.subtotalPlaceholderLabel.Text = "______";
            // 
            // taxPlaceholderLabel
            // 
            this.taxPlaceholderLabel.AutoSize = true;
            this.taxPlaceholderLabel.Location = new System.Drawing.Point(495, 282);
            this.taxPlaceholderLabel.Name = "taxPlaceholderLabel";
            this.taxPlaceholderLabel.Size = new System.Drawing.Size(43, 13);
            this.taxPlaceholderLabel.TabIndex = 11;
            this.taxPlaceholderLabel.Text = "______";
            // 
            // totalPlaceholderLabel
            // 
            this.totalPlaceholderLabel.AutoSize = true;
            this.totalPlaceholderLabel.Location = new System.Drawing.Point(495, 319);
            this.totalPlaceholderLabel.Name = "totalPlaceholderLabel";
            this.totalPlaceholderLabel.Size = new System.Drawing.Size(43, 13);
            this.totalPlaceholderLabel.TabIndex = 12;
            this.totalPlaceholderLabel.Text = "______";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 384);
            this.Controls.Add(this.totalPlaceholderLabel);
            this.Controls.Add(this.taxPlaceholderLabel);
            this.Controls.Add(this.subtotalPlaceholderLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.subtotalLabel);
            this.Controls.Add(this.menuGroupBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restaurant Bill Calculator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeReservationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem takeSurveyToolStripMenuItem;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.ComboBox beverageComboBox;
        private System.Windows.Forms.ComboBox appetizerComboBox;
        private System.Windows.Forms.ComboBox mainCourseComboBox;
        private System.Windows.Forms.ComboBox dessertComboBox;
        private System.Windows.Forms.GroupBox menuGroupBox;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label subtotalPlaceholderLabel;
        private System.Windows.Forms.Label taxPlaceholderLabel;
        private System.Windows.Forms.Label totalPlaceholderLabel;
    }
}

