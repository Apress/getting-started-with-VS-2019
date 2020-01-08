using System;
using System.Windows.Forms;
using static elysium.crypt.crypto;

namespace ShipmentLocator
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateLogin())
                {
                    this.Close();
                }
                else
                {
                    throw new Exception("Login failed");
                }                
            }
            catch (Exception ex)
            {
                _ = MessageBox.Show(ex.Message);
            }
        }

        private bool ValidateLogin()
        {
            var blnLogin = false;
            try
            {
                var password = txtPassword.Text;

                // This encrypted password would be read 
                // from a database based on the username
                var storedEncrPassw = ReadEncryptedValueFromDatabase;

                if (ValidateEncryptedData(password, storedEncrPassw))
                {
                    blnLogin = true;
                }
            }
            catch (Exception ex)
            {
                _ = MessageBox.Show(ex.Message);
            }
            return blnLogin;
        }

        /// <summary>
        /// Encrypt any value by typing: var encrPassword = EncryptData(password);
        /// </summary>
        private string ReadEncryptedValueFromDatabase => "/goZ6Fmv1HQdjLk/JOxEb5KtE9RYCX+kLBpDN2UUwUc=:yiy7bmLTg3Gm5jcy41dNQcww0gGSeu2m0FHnK4/reNA=";

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!ValidateLogin())
            {
                // Cancel the Closing event from closing the form.
                e.Cancel = true;
            }
        }
    }
}
