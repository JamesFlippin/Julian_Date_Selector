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
        // Use enum for format internally
        private JulianDateFormat selectedFormat = JulianDateFormat.DDD;

        private string strYear = string.Empty;
        private string strDay = string.Empty;
        private const int MinDateTextLength = 10; // Magic number replaced with constant

        // Enum for Julian date formats
        private enum JulianDateFormat
            {
            DDD,
            YYDDD,
            YY_DDD,
            YYYYDDD,
            YYYY_DDD
            }

        /// <summary>
        /// Initializes the main form and sets up event handlers.
        /// </summary>
        public frmMain()
            {
            InitializeComponent();
            this.btnJulianToCalendar.Click += new System.EventHandler(this.btnJulianToCalendar_Click);
            }

        /// <summary>
        /// Handles the form load event. Initializes settings, loads the Julian format from the registry,
        /// and sets up the calendar and date picker controls.
        /// </summary>
        private void frmMain_Load(object sender, EventArgs e)
            {
            MenuUncheckItems();
            try
                {
                RegistryGetJulianFormat();

                // Calendar Month Centering
                DateTime dtToday = DateTime.Today;
                DateTime dtPreviousMonth = new DateTime(dtToday.Year, dtToday.Month - 1, 1);
                calMonth.SetDate(dtPreviousMonth);

                this.calMonth.MinDate = new DateTime(1901, 1, 1, 0, 0, 0, 0);
                this.calMonth.MaxSelectionCount = 1;

                dtpDate.Value = DateTime.Now;
                calMonth.SetDate(DateTime.Now);
                }
            catch (Exception)
                {
                // Optionally: ShowGenericErrorMessage();
                }
            }

        /// <summary>
        /// Handles the ValueChanged event for the date picker. Updates the calendar and Julian date output.
        /// </summary>
        private void dtpDate_ValueChanged(object sender, EventArgs e)
            {
            try
                {
                calMonth.SetDate(dtpDate.Value);
                SetJulianDate();
                }
            catch (Exception ex)
                {
                MessageBox.Show("Incorrect date entered. Please try again.\n\n\n" + ex.Message, "Date Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblJulianDateOutput.Text = string.Empty;
                }
            }

        /// <summary>
        /// Handles the DateChanged event for the calendar. Updates the date picker and Julian date output.
        /// </summary>
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

        /// <summary>
        /// Handles the DateSelected event for the calendar. Updates the Julian date output.
        /// </summary>
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

        /// <summary>
        /// Sets the Julian date format, updates the registry, UI, and recalculates the Julian date.
        /// </summary>
        private void SetJulianFormat(JulianDateFormat format)
            {
            selectedFormat = format;
            RegistrySetJulianFormat(format);
            lblSelectedFormatOutput.Text = selectedFormat.ToString().Replace("_", " ");
            SetJulianDate();
            }

        /// <summary>
        /// Handles the DDD format menu click event.
        /// </summary>
        private void mnuDDD_Click(object sender, EventArgs e) => SetJulianFormat(JulianDateFormat.DDD);

        /// <summary>
        /// Handles the YYDDD format menu click event.
        /// </summary>
        private void mnuYYDDD_Click(object sender, EventArgs e) => SetJulianFormat(JulianDateFormat.YYDDD);

        /// <summary>
        /// Handles the YY DDD format menu click event.
        /// </summary>
        ///
        private void YY_DDD_Click(object sender, EventArgs e) => SetJulianFormat(JulianDateFormat.YY_DDD);

        /// <summary>
        /// Handles the YYYYDDD format menu click event.
        /// </summary>
        private void mnuYYYYDDD_Click(object sender, EventArgs e) => SetJulianFormat(JulianDateFormat.YYYYDDD);

        /// <summary>
        /// Handles the YYYY DDD format menu click event.
        /// </summary>
        private void mnuYYYY_DDD_Click(object sender, EventArgs e) => SetJulianFormat(JulianDateFormat.YYYY_DDD);

        /// <summary>
        /// Saves the selected Julian date format to the Windows registry.
        /// </summary>
        private void RegistrySetJulianFormat(JulianDateFormat jDate)
            {
            try
                {
                using (var keySettings = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\CalendarToJulianDateConverter"))
                    {
                    keySettings.SetValue("JulianDateFormat", jDate);
                    }
                }
            catch (Exception)
                {
                // Optionally: ShowGenericErrorMessage();
                }
            }

        /// <summary>
        /// Loads the Julian date format from the Windows registry and updates the UI.
        /// </summary>
        private void RegistryGetJulianFormat()
            {
            try
                {
                using (var keySettings = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\CalendarToJulianDateConverter"))
                    {
                    var value = keySettings.GetValue("JulianDateFormat", "NotSet").ToString();
                    if (Enum.TryParse(value, out JulianDateFormat format))
                        {
                        selectedFormat = format;
                        }
                    else
                        {
                        selectedFormat = JulianDateFormat.DDD;
                        RegistrySetJulianFormat(selectedFormat);
                        }
                    lblSelectedFormatOutput.Text = selectedFormat.ToString().Replace("_", " ");
                    }
                }
            catch (Exception)
                {
                // Optionally: ShowGenericErrorMessage();
                }
            }

        /// <summary>
        /// Sets the Julian date output label based on the selected format and current date.
        /// </summary>
        private void SetJulianDate()
            {
            MenuUncheckItems();
            try
                {
                strYear = dtpDate.Value.Year.ToString();
                strDay = dtpDate.Value.DayOfYear.ToString().PadLeft(3, '0');

                switch (selectedFormat)
                    {
                    case JulianDateFormat.DDD:
                        lblJulianDateOutput.Text = strDay;
                        mnuDDD.Checked = true;
                        break;

                    case JulianDateFormat.YYDDD:
                        lblJulianDateOutput.Text = strYear.Substring(2, 2) + strDay;
                        mnuYYDDD.Checked = true;
                        break;

                    case JulianDateFormat.YY_DDD:
                        lblJulianDateOutput.Text = strYear.Substring(2, 2) + " " + strDay;
                        mnuYY_DDD.Checked = true;
                        break;

                    case JulianDateFormat.YYYYDDD:
                        lblJulianDateOutput.Text = strYear + strDay;
                        mnuYYYYDDD.Checked = true;
                        break;

                    case JulianDateFormat.YYYY_DDD:
                        lblJulianDateOutput.Text = strYear + " " + strDay;
                        mnuYYYY_DDD.Checked = true;
                        break;
                    }
                }
            catch (Exception)
                {
                // Optionally: ShowGenericErrorMessage();
                }
            }

        /// <summary>
        /// Copies the specified text to the clipboard and optionally notifies the user.
        /// </summary>
        private void CopyToClipboard(string text)
            {
            try
                {
                Clipboard.Clear();
                Clipboard.SetText(text);
                if (cbxNotifyOnCopy.Checked)
                    {
                    MessageBox.Show("Copied to the Clipboard:\n" + text, "Copied", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            catch (Exception)
                {
                // Optionally: ShowGenericErrorMessage();
                }
            }

        /// <summary>
        /// Handles the Copy button click event. Copies the Julian date output to the clipboard.
        /// </summary>
        private void btnCopy_Click(object sender, EventArgs e)
            {
            CopyToClipboard(lblJulianDateOutput.Text.Trim());
            }

        /// <summary>
        /// Handles the Convert Julian to Calendar button click event.
        /// Pads input if needed, parses the Julian date, and displays the calendar date or error.
        /// </summary>
        private void btnJulianToCalendar_Click(object sender, EventArgs e)
            {
            string input = txtJulianInput.Text.Trim();
            if (input.Length < 3) // Minimum length for DDD format
                {
                input = input.PadLeft(3, '0');
                txtJulianInput.Text = input;
                }
            DateTime calendarDate;

            if (TryParseAnyJulianDate(input, out calendarDate))
                lblCalendarOutput.Text = calendarDate.ToShortDateString();
            else
                lblCalendarOutput.Text = "Invalid Julian date";
            }

        /// <summary>
        /// Attempts to parse a Julian date string in any supported format to a DateTime.
        /// </summary>
        /// <param name="input">The Julian date string.</param>
        /// <param name="date">The parsed DateTime if successful.</param>
        /// <returns>True if parsing succeeded, otherwise false.</returns>
        private bool TryParseAnyJulianDate(string input, out DateTime date)
            {
            date = DateTime.MinValue;
            string cleaned = input.Replace("-", "").Replace("/", "").Replace(" ", "");
            // Try YYYYDDD
            if (cleaned.Length == 7 && int.TryParse(cleaned.Substring(0, 4), out int yyyy) && int.TryParse(cleaned.Substring(4, 3), out int ddd))
                return TryBuildDate(yyyy, ddd, out date);
            // Try YYDDD
            if (cleaned.Length == 5 && int.TryParse(cleaned.Substring(0, 2), out int yy) && int.TryParse(cleaned.Substring(2, 3), out ddd))
                return TryBuildDate(2000 + yy, ddd, out date);
            // Try DDD (current year)
            if (cleaned.Length == 3 && int.TryParse(cleaned, out ddd))
                return TryBuildDate(DateTime.Now.Year, ddd, out date);

            // Try with spaces (YY DDD or YYYY DDD)
            var parts = input.Split(new[] { ' ', '-', '/' }, StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length == 2) // <-- FIXED: assignment (=) changed to comparison (==)
                {
                if (parts[0].Length == 4 && int.TryParse(parts[0], out yyyy) && int.TryParse(parts[1], out ddd))
                    return TryBuildDate(yyyy, ddd, out date);
                if (parts[0].Length == 2 && int.TryParse(parts[0], out yy) && int.TryParse(parts[1], out ddd))
                    return TryBuildDate(2000 + yy, ddd, out date);
                }
            return false;
            }

        /// <summary>
        /// Attempts to build a DateTime from a year and day-of-year.
        /// </summary>
        /// <param name="year">The year.</param>
        /// <param name="dayOfYear">The day of the year.</param>
        /// <param name="date">The resulting DateTime if successful.</param>
        /// <returns>True if the date is valid, otherwise false.</returns>
        private bool TryBuildDate(int year, int dayOfYear, out DateTime date)
            {
            date = DateTime.MinValue;
            try
                {
                if (dayOfYear < 1 || dayOfYear > (DateTime.IsLeapYear(year) ? 366 : 365))
                    return false;
                date = new DateTime(year, 1, 1).AddDays(dayOfYear - 1);
                return true;
                }
            catch
                {
                return false;
                }
            }

        public void EnableDarkMode()
            {
            DarkModeHelper.ApplyDarkMode(this);
            }

        private void mnuDarkMode_Click(object sender, EventArgs e)
            {
            DarkModeHelper.ApplyDarkMode(this);
            }

        private void mnuAbout_Click(object sender, EventArgs e)
            {
            using (var frmAboutForm = new frmAbout())
                {
                frmAboutForm.ShowDialog();
                }
            }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
            {
            Application.Exit();
            }

        private void btnFind_Click(object sender, EventArgs e)
            {
            DateTime dvSearchDate;
            if (mtbDate.TextLength < 10)
                toolStripStatusLabel1.Text = "Date not found. Please check the format and try again.";
            try
                {
                if (DateTime.TryParse(mtbDate.Text, out dvSearchDate))
                    {
                    calMonth.SetDate(dvSearchDate);
                    calMonth.Refresh();
                    calMonth.Select();
                    //calMonth.Focus();
                    toolStripStatusLabel1.Text = "Date found and set in the calendar.";
                    }
                else
                    {
                    toolStripStatusLabel1.Text = "Date not found. Please check the format and try again.";
                    }
                }
            catch
                {
                toolStripStatusLabel1.Text = "Date not found. Please check the format and try again.";
                }
            }

        private void mnuHelpWebsite_Click(object sender, EventArgs e)
            {
            try
                {
                Process.Start("https://www.flippintechnologies.com/calendardatetojuliandateselector");
                }
            catch (Exception)
                {
                MessageBox.Show("An unanticipated error has occurred.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        private void dtpDate_ValueChanged_1(object sender, EventArgs e)
            {
            try
                {
                dtpDate.Value = DateTime.Parse(dtpDate.Text);
                calMonth.SetDate(dtpDate.Value);
                SetJulianDate();
                }
            catch (Exception ex)
                {
                // Provide some user generic feedback if there is a date error
                MessageBox.Show("Incorrect date entered. Please try again.\n\n\n" + ex.Message, "Date Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblJulianDateOutput.Text = string.Empty;
                }
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
        }
    }