using System.Drawing;
using System.Windows.Forms;

namespace Julian_Date_Selector
    {
    public static class DarkModeHelper
        {
        /// <summary>
        /// Applies dark mode colors to the given form and all its controls.
        /// </summary>
        public static void ApplyDarkMode(Form form)
            {
            form.BackColor = Color.FromArgb(32, 32, 32);
            form.ForeColor = Color.White;
            ApplyDarkModeToControls(form.Controls);
            }

        private static void ApplyDarkModeToControls(Control.ControlCollection controls)
            {
            foreach (Control ctrl in controls)
                {
                if (ctrl is GroupBox)
                    {
                    ctrl.BackColor = Color.FromArgb(40, 40, 40);
                    ctrl.ForeColor = Color.White;
                    }
                else if (ctrl is TextBox || ctrl is MaskedTextBox)
                    {
                    ctrl.BackColor = Color.FromArgb(48, 48, 48);
                    ctrl.ForeColor = Color.White;
                    }
                else if (ctrl is Button)
                    {
                    ctrl.BackColor = Color.FromArgb(64, 64, 64);
                    ctrl.ForeColor = Color.White;
                    ((Button)ctrl).FlatStyle = FlatStyle.Flat;
                    ((Button)ctrl).FlatAppearance.BorderColor = Color.DimGray;
                    }
                else if (ctrl is Label)
                    {
                    ctrl.ForeColor = Color.White;
                    ctrl.BackColor = Color.Transparent;
                    }
                else if (ctrl is MonthCalendar)
                    {
                    var cal = (MonthCalendar)ctrl;
                    cal.BackColor = Color.FromArgb(48, 48, 48);
                    cal.ForeColor = Color.White;
                    cal.TitleBackColor = Color.FromArgb(32, 32, 32);
                    cal.TitleForeColor = Color.White;
                    cal.TrailingForeColor = Color.Gray;
                    }
                else if (ctrl is DateTimePicker)
                    {
                    ctrl.BackColor = Color.FromArgb(48, 48, 48);
                    ctrl.ForeColor = Color.White;
                    }
                else if (ctrl is MenuStrip || ctrl is ContextMenuStrip)
                    {
                    ctrl.BackColor = Color.FromArgb(32, 32, 32);
                    ctrl.ForeColor = Color.White;
                    }
                else
                    {
                    ctrl.BackColor = Color.FromArgb(32, 32, 32);
                    ctrl.ForeColor = Color.White;
                    }

                if (ctrl.HasChildren)
                    ApplyDarkModeToControls(ctrl.Controls);
                }
            }
        }
    }