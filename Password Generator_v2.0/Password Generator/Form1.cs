using System;
using Microsoft.Win32;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Password_Generator
{
    public partial class Form1 : Form
    {
        private Int32[] checkBoxValues;
        private RNDS_Generator RND_String;
        private String password;

        public Form1()
        {
            InitializeComponent();
            checkBoxValues = Enumerable.Repeat(0, 9).ToArray();
            ProccessRegistry();
            SetCheckBoxes();
        }    

        private void generate_Click(object sender, EventArgs e)
        {
            password = String.Empty;
            ConstructPassword();
            GeneratedPassword.Text = password;
        }

        private void ConstructPassword()
        {
            // Get Password Length
            int passwordLen;
            String enteredValue = passwordLength.Text.Trim();
            if (enteredValue.Length == 0) passwordLen = 1; // No value entered (set default to 1)
            else if (int.TryParse(enteredValue, out passwordLen)) { } // Parsing valid value
            else passwordLen = 1; // Entered value isn't numeric only
            // Define Password Charset
            List<string> L = new List<string>();
            if (Numbers.Checked) L.Add("ch_09");
            if (SmallCapLetters.Checked) L.Add("ch_az");
            if (trimmedSmallCaps.Checked) L.Add("ch_az_trm");
            if (BigCapLetters.Checked) L.Add("ch_AZ");
            if (trimmedBigCaps.Checked) L.Add("ch_AZ_trm");
            if (AllSpecialChars.Checked) L.Add("ch_symb_full");
            if (BasicSpecialChars.Checked) L.Add("ch_symb_bsc");
            if (specialChar17.Checked) L.Add("ch_symb_17");
            if (specialChar8.Checked) L.Add("ch_symb_8");
            // Construct Random String (using RNDS_Generator.cs)
            RND_String = new RNDS_Generator(L, passwordLen);
            password = RND_String.GenerateString();
        }

        private void Copy_Click(object sender, EventArgs e)
        { Clipboard.SetText(GeneratedPassword.Text); }

        private void ProccessRegistry()
        {
            // Selected Charset will be Stored to HKEY_CURRENT_USER/Password Generator Registry
            RegistryKey regKey = Registry.CurrentUser.OpenSubKey("Password Generator");
            if (regKey == null)
            {
                regKey = Registry.CurrentUser.CreateSubKey("Password Generator");
                regKey.SetValue("Value", "000000000");
                regKey.Close();
            }
            else
            {
                // Read Stored Charset Choice
                string value = regKey.GetValue("Value").ToString();
                char[] temp = value.ToCharArray();
                checkBoxValues = Array.ConvertAll(temp, c => (int)Char.GetNumericValue(c));
                regKey.Close();
            }
        }

        private void SetCheckBoxes()
        {
            // Set Initial Checkbox Charset Selection
            Numbers.Checked           = Convert.ToBoolean(checkBoxValues[0]);
            SmallCapLetters.Checked   = Convert.ToBoolean(checkBoxValues[1]);
            trimmedSmallCaps.Checked  = Convert.ToBoolean(checkBoxValues[2]);
            BigCapLetters.Checked     = Convert.ToBoolean(checkBoxValues[3]);
            trimmedBigCaps.Checked    = Convert.ToBoolean(checkBoxValues[4]);
            AllSpecialChars.Checked   = Convert.ToBoolean(checkBoxValues[5]);
            BasicSpecialChars.Checked = Convert.ToBoolean(checkBoxValues[6]);
            specialChar17.Checked     = Convert.ToBoolean(checkBoxValues[7]);
            specialChar8.Checked      = Convert.ToBoolean(checkBoxValues[8]);
        }

        private void passwordLength_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                generate.PerformClick();
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void passwordLength_KeyPress(object sender, KeyPressEventArgs e)
        { e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar); }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Get Selected Charsets
            checkBoxValues[0] = Convert.ToInt32(Numbers.Checked);
            checkBoxValues[1] = Convert.ToInt32(SmallCapLetters.Checked);
            checkBoxValues[2] = Convert.ToInt32(trimmedSmallCaps.Checked);
            checkBoxValues[3] = Convert.ToInt32(BigCapLetters.Checked);
            checkBoxValues[4] = Convert.ToInt32(trimmedBigCaps.Checked);
            checkBoxValues[5] = Convert.ToInt32(AllSpecialChars.Checked);
            checkBoxValues[6] = Convert.ToInt32(BasicSpecialChars.Checked);
            checkBoxValues[7] = Convert.ToInt32(specialChar17.Checked);
            checkBoxValues[8] = Convert.ToInt32(specialChar8.Checked);
            // Store Selection into Registry
            RegistryKey regKey = Registry.CurrentUser.OpenSubKey("Password Generator", true);
            string temp = string.Join("", checkBoxValues);
            regKey.SetValue("Value", temp);
            regKey.Close();
        }
    }
}
