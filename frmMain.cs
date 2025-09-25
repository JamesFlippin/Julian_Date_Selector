#pragma warning restore IDE1006 // Naming Styles
// Programmer: James G. Flippin, Jr.
// GitHub Profile: https://github.com/JamesFlippin
// GitHub Repository: https://github.com/JamesFlippin/Julian_Date_Selector
// License: GNU GENERAL PUBLIC LICENSE Version 3
//
// Program Purpose: A Calendar Date to Julian Date lookup tool
// Installation/Deployment method: Available in the Microsoft App Store

using System;
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Julian_Date_Selector
    {
    public partial class frmMain : Form
        {
        /// <summary>
        /// The main class for the Julian Date Selector program
        /// </summary>

        // Initialize variables we will use
        private string strJulianDateFormat;

        private string strYear = string.Empty;
        private string strDay = string.Empty;

        // Initialize Enumerators we will use
        private enum JulianDateFormat
            {
            DDD,
            YYDDD,
            YY_DDD,
            YYYYDDD,
            YYYY_DDD
            }

        public frmMain()
            {
            InitializeComponent();
            }

        /// <summary>
        /// Handles the Load event and initializations of the frmMain control
        /// which is the main form for this program.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void frmMain_Load(object sender, EventArgs e)
            {
            try
                {
                MenuUncheckItems();
                //SetJulianFormat(JulianDateFormat.DDD);
                RegistryGetJulianFormat();
                MenuCheckItems();

                // Beginning of Calendar Month Centering
                // Set the calendar control to the current date in the middle
                DateTime dtToday = DateTime.Today;
                DateTime dtPreviousMonth = new DateTime(dtToday.Year, dtToday.Month - 1, 1);
                calMonth.SetDate(dtPreviousMonth);
                // End of Calendar Month Centering

                // Set the minimum visible date on calendar to 12/31/2010.
                this.calMonth.MinDate = new System.DateTime(1901, 1, 1, 0, 0, 0, 0);

                // Only allow 21 days to be selected at the same time.
                this.calMonth.MaxSelectionCount = 1;

                // Show the week numbers to the left of each week.
                // this.calMonth.ShowWeekNumbers = true;

                dtpDate.Value = DateTime.Now;
                calMonth.SetDate(DateTime.Now);
                }
            catch (Exception)
                {
                // Provide some user generic feedback if there is a load error
                MessageBox.Show("An unanticipated error has occured during the loading of the program.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        /// <summary>
        /// Handles the ValueChanged event of the dtpDate control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void dtpDate_ValueChanged(object sender, EventArgs e)
            {
            try
                {
                //
                calMonth.SetDate(dtpDate.Value);
                SetJulianDate();
                }
            catch (Exception ex)
                {
                // Provide some user generic feedback if there is a date error
                MessageBox.Show("Incorrect date entered. Please try again.\n\n\n" + ex.Message, "Date Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblJulianDateOutput.Text = string.Empty;
                }
            }

        private void calMonth_DateChanged(object sender, DateRangeEventArgs e)
            {
            try
                {
                dtpDate.Value = e.Start;
                SetJulianDate();
                }
            catch (Exception ex)
                {
                // Provide some user generic feedback if there is a date error
                MessageBox.Show("Incorrect date entered. Please try again.\n\n\n" + ex.Message, "Date Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblJulianDateOutput.Text = string.Empty;
                }
            }

        private void calMonth_DateSelected(object sender, DateRangeEventArgs e)
            {
            try
                {
                SetJulianDate();
                }
            catch (Exception ex)
                {
                // Provide some user generic feedback if there is a date error
                MessageBox.Show("Incorrect date entered. Please try again.\n\n\n" + ex.Message, "Date Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblJulianDateOutput.Text = string.Empty;
                }
            }

        private void lblJulianDate_Click(object sender, EventArgs e)
            {
            }

        private void lblJulianDate_DoubleClick(object sender, EventArgs e)
            {
            }

        private void lblJulianDate_MouseClick(object sender, MouseEventArgs e)
            {
            }

        private void btnFind_Click(object sender, EventArgs e)
            {
            DateTime dtDateEntered;
            try
                {
                if (DateTime.TryParse(mtbDate.Text, out dtDateEntered))
                    {
                    dtpDate.Value = dtDateEntered;
                    }
                else
                    {
                    MessageBox.Show("Incorrect date entered. Please try again.", "Date Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                mtbDate.Focus();
                mtbDate.SelectAll();
                }
            catch (Exception ex)
                {
                MessageBox.Show("Incorrect date entered. Please try again.\n\n\n" + ex.Message, "Date Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblJulianDateOutput.Text = string.Empty;
                }
            }

        private void SetJulianDate()
            {
            try
                {
                strYear = dtpDate.Value.Year.ToString();
                strDay = dtpDate.Value.DayOfYear.ToString().PadLeft(3, '0');

                switch (strJulianDateFormat)
                    {
                    case "DDD":
                        //MessageBox.Show("DDD");
                        lblJulianDateOutput.Text = strDay;
                        break;

                    case "YYDDD":
                        //Todo
                        //MessageBox.Show("YYDDD");
                        lblJulianDateOutput.Text = strYear.Substring(2, 2) + strDay;
                        break;

                    case "YY_DDD":
                        //toDo
                        lblJulianDateOutput.Text = strYear.Substring(2, 2) + " " + strDay;
                        //MessageBox.Show("YY_DDD");
                        break;

                    case "YYYYDDD":
                        //MessageBox.Show("YYYYDDD");
                        lblJulianDateOutput.Text = strYear + strDay;
                        break;

                    case "YYYY_DDD":
                        //MessageBox.Show("YYYY_DDD");
                        lblJulianDateOutput.Text = strYear + " " + strDay;
                        break;
                        //default:
                        //    MessageBox.Show("Format Not recognized", "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //    break;
                    }
                }
            catch (Exception)
                {
                MessageBox.Show("An unanticipated error has occured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        private string GetJulianDate(int intFormat)
            {
            try
                {
                string strJulianDate = string.Empty;
                switch (intFormat)
                    {
                    case 1:
                        strJulianDate = strDay.PadLeft(3, '0');
                        break;

                    case 2:
                        strJulianDate = strYear.PadLeft(2, '0') + " " + strDay.PadLeft(3, '0');
                        break;

                    case 3:
                        strJulianDate = strJulianDate = strYear.PadLeft(2, '0') + strDay.PadLeft(3, '0');
                        break;

                    default:
                        MessageBox.Show("Format Not recognized", "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                Clipboard.Clear();
                Clipboard.SetText(strJulianDate);
                MessageBox.Show("Copied: " + strJulianDate, "Clipboard", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return "";
                }
            catch (Exception)
                {
                MessageBox.Show("An unanticipated error has occured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
                }
            }

        private void btnCopyNoYear_Click(object sender, EventArgs e)
            {
            GetJulianDate(1);
            }

        private void btnCopyWithYear_Click(object sender, EventArgs e)
            {
            GetJulianDate(2);
            }

        private void btnCopyWithYearNoSpace_Click(object sender, EventArgs e)
            {
            GetJulianDate(3);
            }

        private void frmMain_Activated(object sender, EventArgs e)
            {
            }

        /// <summary>
        /// Saves the selected Julian date format to the PC's registry.
        /// </summary>
        /// <param name="jDate">The j date.</param>
        private void RegistrySetJulianFormat(JulianDateFormat jDate)
            {
            try
                {
                RegistryKey keySettings = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\CalendarToJulianDateConverter");

                //storing the values
                keySettings.SetValue("JulianDateFormat", jDate);
                //key.SetValue("Setting2", "This is our setting 2");
                keySettings.Close();
                }
            catch (Exception)
                {
                MessageBox.Show("An unanticipated error has occured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        /// <summary>
        /// Gets the previously saved Julian date format from the PC's registry.
        /// </summary>
        private void RegistryGetJulianFormat()
            {
            try
                {
                RegistryKey keySettings = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\CalendarToJulianDateConverter");

                //storing the values

                strJulianDateFormat = keySettings.GetValue("JulianDateFormat", "NotSet").ToString();
                if (strJulianDateFormat == "NotSet")
                    {
                    RegistrySetJulianFormat(JulianDateFormat.DDD);
                    strJulianDateFormat = "DDD";
                    }
                keySettings.Close();
                lblSelectedFormatOutput.Text = strJulianDateFormat.Replace("_", " ");
                }
            catch (Exception)
                {
                MessageBox.Show("An unanticipated error has occured reading the saved settings.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        /// <summary>
        /// Unchecks the menu items.
        /// </summary>
        private void MenuUncheckItems()
            {
            try
                {
                mnuDDD.Checked = false;
                mnuYYDDD.Checked = false;
                mnuYY_DDD.Checked = false;
                mnuYYYYDDD.Checked = false;
                mnuYYYY_DDD.Checked = false;
                }
            catch (Exception)
                {
                MessageBox.Show("An unanticipated error has occured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        /// <summary>
        /// Clears/unchecks the current selections and then checks
        /// to see the new selection and update the menu
        /// </summary>
        private void MenuCheckItems()
            {
            try
                {
                MenuUncheckItems(); // Unchecks the menu items
                switch (strJulianDateFormat)
                    {
                    case "DDD":
                        mnuDDD.Checked = true;
                        break;

                    case "YYDDD":
                        mnuYYDDD.Checked = true;
                        break;

                    case "YY_DDD":
                        mnuYY_DDD.Checked = true;
                        break;

                    case "YYYYDDD":
                        mnuYYYYDDD.Checked = true;
                        break;

                    case "YYYY_DDD":
                        mnuYYYY_DDD.Checked = true;
                        break;
                    }
                }
            catch (Exception)
                {
                MessageBox.Show("An unanticipated error has occured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        /// <summary>
        /// Handles the Click event of the mnuDDD control.
        /// Uses the the appropriateenumerators for the selected format.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void mnuDDD_Click(object sender, EventArgs e)
            {
            RegistrySetJulianFormat(JulianDateFormat.DDD);
            strJulianDateFormat = JulianDateFormat.DDD.ToString();
            lblSelectedFormatOutput.Text = strJulianDateFormat.Replace("_", "");
            MenuCheckItems();
            //mnuDDD.Checked = true;
            SetJulianDate();
            }

        /// <summary>
        /// Handles the Click event of the mnuYYDDD control.
        /// Uses the the appropriateenumerators for the selected format.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void mnuYYDDD_Click(object sender, EventArgs e)
            {
            RegistrySetJulianFormat(JulianDateFormat.YYDDD);
            strJulianDateFormat = JulianDateFormat.YYDDD.ToString();
            lblSelectedFormatOutput.Text = strJulianDateFormat.Replace("_", "");
            MenuCheckItems();
            //mnuYYDDD.Checked = true;
            SetJulianDate();
            }

        /// <summary>
        /// Handles the Click event of the YY_DDD control.
        /// Uses the the appropriateenumerators for the selected format.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void YY_DDD_Click(object sender, EventArgs e)
            {
            RegistrySetJulianFormat(JulianDateFormat.YY_DDD);
            strJulianDateFormat = JulianDateFormat.YY_DDD.ToString();
            lblSelectedFormatOutput.Text = strJulianDateFormat.Replace("_", " ");
            MenuCheckItems();
            //mnuYY_DDD.Checked = true;
            SetJulianDate();
            }

        /// <summary>
        /// Handles the Click event of the mnuYYYYDDD control.
        /// Uses the the appropriateenumerators for the selected format.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void mnuYYYYDDD_Click(object sender, EventArgs e)
            {
            RegistrySetJulianFormat(JulianDateFormat.YYYYDDD);
            strJulianDateFormat = JulianDateFormat.YYYYDDD.ToString();
            lblSelectedFormatOutput.Text = strJulianDateFormat.Replace("_", "");
            MenuCheckItems();
            //mnuYYDDD.Checked = true;
            SetJulianDate();
            }

        /// <summary>
        /// Handles the Click event of the mnuYYYY_DDD control.
        /// Uses the the appropriateenumerators for the selected format.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void mnuYYYY_DDD_Click(object sender, EventArgs e)
            {
            RegistrySetJulianFormat(JulianDateFormat.YYYY_DDD);
            strJulianDateFormat = JulianDateFormat.YYYY_DDD.ToString();
            lblSelectedFormatOutput.Text = strJulianDateFormat.Replace("_", " ");
            MenuCheckItems();
            //mnuYYDDD.Checked = true;
            SetJulianDate();
            }

        private void mnuHelp_Click(object sender, EventArgs e)
            {
            }

        /// <summary>
        /// Handles the Click event of the mnuHelpWebsite control to open the website for this program.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void mnuHelpWebsite_Click(object sender, EventArgs e)
            {
            try
                {
                Process.Start("https://www.flippintechnologies.com/calendardatetojuliandateselector");
                }
            catch (Exception)
                {
                MessageBox.Show("An unanticipated error has occured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        private void cbxNotifyOnCopy_CheckedChanged(object sender, EventArgs e)
            {
            }

        /// <summary>
        /// Handles the Click event of the btnCopy control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnCopy_Click(object sender, EventArgs e)
            {
            try
                {
                if (cbxNotifyOnCopy.Checked)
                    {
                    MessageBox.Show(lblJulianDateOutput.Text.Trim(), "Copied to the Clipboard", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                Clipboard.Clear();
                Clipboard.SetText(lblJulianDateOutput.Text.Trim());
                }
            catch (Exception)
                {
                ShowGenericErrorMessage();
                }
            }

        /// <summary>
        /// Handles the event of the btnFind_Click control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnFind_Click_1(object sender, EventArgs e)
            {
            DateTime dvSearchDate;

            if (mtbDate.TextLength < 10)
                ShowFindDateError();

            try
                {
                if (DateTime.TryParse(mtbDate.Text, out dvSearchDate))
                    {
                    calMonth.SetDate(dvSearchDate);
                    }
                else
                    {
                    ShowFindDateError();
                    }
                }
            catch
                {
                ShowFindDateError();
                }
            }

        /// <summary>
        /// Handles the MaskInputRejected event of the mtbDate control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="MaskInputRejectedEventArgs"/> instance containing the event data.</param>
        private void mtbDate_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
            {
            ShowFindDateError();
            }

        /// <summary>
        /// Shows a generic error message.
        /// </summary>
        private void ShowGenericErrorMessage()
            {
            MessageBox.Show("An unanticipated error has occured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        /// <summary>
        /// Shows the Find Date generic error message
        /// </summary>
        private void ShowFindDateError()
            {
            MessageBox.Show("Sorry, you didn't enter a valid date to find.", "Bad Date Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
            mtbDate.Focus();
            mtbDate.SelectionStart = 0;
            return;
            }

        private void ttTips_Popup(object sender, PopupEventArgs e)
            {
            }

        /// <summary>
        /// Handles the Click event of the mnuAbout control, to show the "About" screen.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void mnuAbout_Click(object sender, EventArgs e)
            {
            frmAbout about = new frmAbout();
            about.ShowDialog();
            }

        private void grpLookup_Enter(object sender, EventArgs e)
            {
            }

        /// <summary>
        /// Switches the entire form and its controls to Dark Mode colors.
        /// Call this method to apply a dark color scheme to the form and all child controls.
        /// </summary>
        private void EnableDarkMode()
            {
            // Set the background color of the main form to a dark shade.
            this.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
            // Set the default text color of the main form to white.
            this.ForeColor = System.Drawing.Color.White;

            // Recursively apply dark mode colors to all controls on the form.
            SetDarkModeForControls(this.Controls);
            }

        /// <summary>
        /// Recursively sets dark mode colors for all controls in the provided control collection.
        /// This method handles common WinForms controls and applies appropriate background and foreground colors.
        /// </summary>
        /// <param name="controls">The collection of controls to update.</param>
        private void SetDarkModeForControls(Control.ControlCollection controls)
            {
            foreach (Control ctrl in controls)
                {
                // Set colors for GroupBox controls.
                if (ctrl is GroupBox)
                    {
                    ctrl.BackColor = System.Drawing.Color.FromArgb(40, 40, 40);
                    ctrl.ForeColor = System.Drawing.Color.White;
                    }
                // Set colors for TextBox and MaskedTextBox controls.
                else if (ctrl is TextBox || ctrl is MaskedTextBox)
                    {
                    ctrl.BackColor = System.Drawing.Color.FromArgb(48, 48, 48);
                    ctrl.ForeColor = System.Drawing.Color.White;
                    }
                // Set colors and flat style for Button controls.
                else if (ctrl is Button)
                    {
                    ctrl.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
                    ctrl.ForeColor = System.Drawing.Color.White;
                    ((Button)ctrl).FlatStyle = FlatStyle.Flat;
                    ((Button)ctrl).FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
                    }
                // Set colors for Label controls.
                else if (ctrl is Label)
                    {
                    ctrl.ForeColor = System.Drawing.Color.White;
                    ctrl.BackColor = System.Drawing.Color.Transparent;
                    }
                // Set colors for MonthCalendar controls.
                else if (ctrl is MonthCalendar)
                    {
                    var cal = (MonthCalendar)ctrl;
                    cal.BackColor = System.Drawing.Color.FromArgb(48, 48, 48);
                    cal.ForeColor = System.Drawing.Color.White;
                    cal.TitleBackColor = System.Drawing.Color.FromArgb(32, 32, 32);
                    cal.TitleForeColor = System.Drawing.Color.White;
                    cal.TrailingForeColor = System.Drawing.Color.Gray;
                    }
                // Set colors for DateTimePicker controls.
                else if (ctrl is DateTimePicker)
                    {
                    // Note: CalendarMonthBackground is not available in .NET Framework 4.7.2 for DateTimePicker.
                    ctrl.BackColor = System.Drawing.Color.FromArgb(48, 48, 48);
                    ctrl.ForeColor = System.Drawing.Color.White;
                    }
                // Set colors for MenuStrip and ContextMenuStrip controls.
                else if (ctrl is MenuStrip || ctrl is ContextMenuStrip)
                    {
                    ctrl.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
                    ctrl.ForeColor = System.Drawing.Color.White;
                    }
                // Set default dark mode colors for all other controls.
                else
                    {
                    ctrl.BackColor = System.Drawing.Color.FromArgb(32, 32, 32);
                    ctrl.ForeColor = System.Drawing.Color.White;
                    }

                // If the control contains child controls, apply dark mode recursively.
                if (ctrl.HasChildren)
                    SetDarkModeForControls(ctrl.Controls);
                }
            }

        /// <summary>
        /// Handles the Click event of the dark mode menu item.
        /// When triggered, switches the form and all controls to dark mode.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void darkModeToolStripMenuItem_Click(object sender, EventArgs e)
            {
            EnableDarkMode();
            }
        }
    }