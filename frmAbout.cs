using System;
using System.Reflection;
using System.Windows.Forms;

namespace Julian_Date_Selector
    {
    internal partial class frmAbout : Form
        {
        /// <summary>
        /// Initializes a new instance of the about form.
        /// I will replace it later with something more stylized.
        /// </summary>
        public frmAbout()
            {
            InitializeComponent();
            this.Text = "About - " + AssemblyProduct;
            this.lblProduct.Text = this.lblProduct.Text + AssemblyProduct;
            this.lblVersion.Text = lblVersion.Text + String.Format("Version {0}", AssemblyVersion);
            this.lblCopyright.Text = lblCopyright.Text + AssemblyCopyright;
            this.lnkGitHubProfile.Text = "https://github.com/JamesFlippin";
            this.lnkGitHubRepo.Text = "https://github.com/JamesFlippin/Julian_Date_Selector";
            this.tbxDescription.AppendText("A Calendar date to Julian date selection tool. It allows the user to select a Calendar date then it displays the Julian date for that selected date." + Environment.NewLine + Environment.NewLine);
            this.tbxDescription.AppendText("Image: Gastown Steam Clock, Vancouver B.C., Canada" + Environment.NewLine);
            this.tbxDescription.AppendText("Image Copyright: James Flippin 2023" + Environment.NewLine + Environment.NewLine);
            this.tbxDescription.AppendText("Icons courtesy of: https://www.iconfinder.com©");
            }

        #region Assembly Attribute Accessors

        public string AssemblyTitle
            {
            get
                {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                    {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                        {
                        return titleAttribute.Title;
                        }
                    }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
                }
            }

        public string AssemblyVersion
            {
            get
                {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
                }
            }

        public string AssemblyDescription
            {
            get
                {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                    {
                    return "";
                    }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
                }
            }

        public string AssemblyProduct
            {
            get
                {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                    {
                    return "";
                    }
                return ((AssemblyProductAttribute)attributes[0]).Product;
                }
            }

        public string AssemblyCopyright
            {
            get
                {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                    {
                    return "";
                    }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
                }
            }

        public string AssemblyCompany
            {
            get
                {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                    {
                    return "";
                    }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
                }
            }

        #endregion Assembly Attribute Accessors

        private void okButton_Click(object sender, EventArgs e)
            {
            this.Close();
            }

        private void lnkLicenseSite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            {
            // Show we visited the license site
            this.lnkLicenseSite.LinkVisited = true;

            // Navigate to a URL

            try
                {
                System.Diagnostics.Process.Start("https://www.gnu.org/licenses/gpl-3.0.en.html#license-text");
                }
            catch
                {
                MessageBox.Show("Error opening license file link.", "Error: License Link", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        private void btnOk_Click(object sender, EventArgs e)
            {
            this.Close();
            }

        private void lnkGitHubProfile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            {
            try
                {
                System.Diagnostics.Process.Start("https://github.com/JamesFlippin");
                }
            catch
                {
                MessageBox.Show("Error opening GitHub Profile link.", "Error: GitHub Link", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        private void lnkGitHubRepo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            {
            try
                {
                System.Diagnostics.Process.Start("https://github.com/JamesFlippin/Julian_Date_Selector");
                }
            catch
                {
                MessageBox.Show("Error opening GitHub Repository link.", "Error: GitHub Link", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        /// <summary>
        /// Handles the Click event of the btnDisclaimer control.
        /// Loads the text for the Disclaimer to the tbxDescription textbox.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnDisclaimer_Click(object sender, EventArgs e)
            {
            tbxDescription.Clear(); // Clear out the previous text
            tbxDescription.AppendText("Disclaimer: As Is, No Warranties or Guarantees for Julian Date Selector Program" + Environment.NewLine + Environment.NewLine);
            tbxDescription.AppendText("The following disclaimer outlines the terms and conditions for the use of the 'Julian Date Selector' program, including any associated code, documentation, or materials. By accessing, downloading, or utilizing the program, you agree to the following:" + Environment.NewLine + Environment.NewLine);
            tbxDescription.AppendText("1. No Warranties: The 'Julian Date Selector' program is provided \"as is\" without any warranties or guarantees of any kind, whether expressed or implied. This includes, but is not limited to, warranties of merchantability, fitness for a particular purpose, non-infringement, or any other warranty that may arise in the course of usage." + Environment.NewLine + Environment.NewLine);
            tbxDescription.AppendText("2. Use at Your Own Risk: Any reliance you place on the 'Julian Date Selector' program is strictly at your own risk. We shall not be held responsible for any errors, bugs, defects, or inaccuracies in the program. It is your responsibility to evaluate the suitability, reliability, accuracy, and completeness of the program before using it or making any decisions based upon it." + Environment.NewLine + Environment.NewLine);
            tbxDescription.AppendText("3. No Guarantees: We make no guarantees regarding the functionality, performance, or accuracy of the 'Julian Date Selector' program. We do not warrant that the program will meet your specific requirements or expectations, or that it will operate without interruptions or errors." + Environment.NewLine + Environment.NewLine);
            tbxDescription.AppendText("4. Exclusion of Liability: In no event shall we or our affiliates, partners, directors, employees, or agents be liable for any direct, indirect, incidental, special, or consequential damages arising out of or in any way connected with the use of the 'Julian Date Selector' program, including but not limited to damages for loss of profits, data, or other intangible losses, even if we have been advised of the possibility of such damages." + Environment.NewLine + Environment.NewLine);
            tbxDescription.AppendText("5. No Technical Support: We do not provide any technical support or assistance for the 'Julian Date Selector' program. You are solely responsible for the maintenance, support, and troubleshooting of the program." + Environment.NewLine + Environment.NewLine);
            tbxDescription.AppendText("6. Compliance with Laws: You agree to comply with all applicable laws, regulations, and guidelines while using the 'Julian Date Selector' program. Any illegal or unauthorized use of the program may be subject to legal action." + Environment.NewLine + Environment.NewLine);
            tbxDescription.AppendText("By accessing, downloading, or using the 'Julian Date Selector' program, you acknowledge that you have read, understood, and agreed to this disclaimer. If you do not agree with any part of this disclaimer, you should refrain from accessing, downloading, or using the program and its associated code, documentation, or materials." + Environment.NewLine + Environment.NewLine);
            tbxDescription.Focus(); // Set the focus to the textbox with the disclaimer text
            SendKeys.Send("^{HOME}"); //Quick and dirty (old school) method to set the focus back to the top
            }

        private void frmAbout_Load(object sender, EventArgs e)
            {
            }
        }
    }