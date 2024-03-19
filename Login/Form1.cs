using Microsoft.Win32;

namespace Login
{
    public partial class Form1 : Form
    {
        private UserName_Password user;

        public Form1()
        {
            user = new UserName_Password("spiryu", "IJyU7ZvR");
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AutoStart();
            textBox2.UseSystemPasswordChar = true;
        }
        private void AutoStart()
        {
            string? App_Name = Application.ProductName;
            string? App_Path = Application.ExecutablePath;
            
            RegistryKey? rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            if (rk.GetValue(App_Name) == null)
            {
                rk.SetValue(App_Name, App_Path);
            }
            rk.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Username = textBox1.Text;
            string Password = textBox2.Text;

            if (Username == user.Username && Password == user.Password)
            {
                Form2 form = new Form2();
                form.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Girdiðiniz Bilgiler Hatalý.");
        }
    }

    class UserName_Password
    {
        private string _username = "spiryu";
        private string _password = "IJyU7ZvR";

        public string Username { get { return _username; } set { _username = value; } }
        public string Password { get { return _password; } set { _password = value; } }

        public UserName_Password(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }
    }
}
