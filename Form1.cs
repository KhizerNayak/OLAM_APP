using System.Diagnostics.Eventing.Reader;

namespace Ola_App
{
    public partial class OaApp : Form
    {
        string UserName, Password;
        
        HomeOlam H = new HomeOlam();

        public OaApp()
        {
            InitializeComponent();
        }


        

        private void TxtUserName_TextChanged(object sender, EventArgs e)
        {
            TxtUserName.Focus();
            UserName = TxtUserName.Text;
            
        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {
            
            Password = TxtPassword.Text;
        }
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UserName) || string.IsNullOrWhiteSpace(Password))
            {
                MessageBox.Show("Please enter both UserName and Password");
            }
            else
            {
                // Perform authentication if both fields are non-empty

                if (TxtUserName.Text == "Admin" && TxtPassword.Text == "12345")
                {

                    MessageBox.Show("You have entered Correct Credentials");
                    this.Hide();
                    H.Show();
                }
                else
                {
                    MessageBox.Show("Your UserName or Password is Incorrect");
                    TxtUserName.Clear();
                    TxtPassword.Clear();
                }

            }  
            
            
        }
    }
}
