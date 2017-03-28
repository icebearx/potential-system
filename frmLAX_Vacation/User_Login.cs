//Designed and developed by Noah Schrayter
//Vacation scheduling system for Los Angeles Union Station
//Ver 1.0

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; //file in/out
using System.Security.Cryptography.X509Certificates; // Password security
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace frmLAX_Vacation
{
    public partial class User_Login : Form
    {
         
    /// <summary>
    /// Key for the crypto provider
    /// </summary>
  //  private static readonly byte[] _key = { 0xA1, 0xF1, 0xA6, 0xBB, 0xA2, 0x5A, 0x37, 0x6F, 0x81, 0x2E, 0x17, 0x41, 0x72, 0x2C, 0x43, 0x27 };
        /// <summary>
        /// Initialization vector for the crypto provider
        /// </summary>
       // private static readonly byte[] _initVector = { 0xE1, 0xF1, 0xA6, 0xBB, 0xA9, 0x5B, 0x31, 0x2F, 0x81, 0x2E, 0x17, 0x4C, 0xA2, 0x81, 0x53, 0x61 };

        private static class Globals
        {
            public static string dataFile = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Warrior\Documents\users.mdf;Integrated Security = True; Connect Timeout = 30";//change database location here when ready
            public static bool letsContinueBoolean = false;
            public static string soundLocation = @"c:\Windows\Media\chimes.wav";
        }
        public User_Login()
        {
            InitializeComponent();
        }


//#if (DEBUG) //Only compile this method for local debugging.
//        /// <summary>
//        /// Decrypt a string
//        /// </summary>
//        /// <param name="Value"></param>
//        /// <returns></returns>
//        private static string Decrypt(string Value)
//        {
//            SymmetricAlgorithm mCSP;
//            ICryptoTransform ct = null;
//            MemoryStream ms = null;
//            CryptoStream cs = null;
//            byte[] byt;
//            byte[] _result;

//            mCSP = new RijndaelManaged();

//            try
//            {
//                mCSP.Key = _key;
//                mCSP.IV = _initVector;
//                ct = mCSP.CreateDecryptor(mCSP.Key, mCSP.IV);


//                byt = Convert.FromBase64String(Value);

//                ms = new MemoryStream();
//                cs = new CryptoStream(ms, ct, CryptoStreamMode.Write);
//                cs.Write(byt, 0, byt.Length);
//                cs.FlushFinalBlock();

//                cs.Close();
//                _result = ms.ToArray();
//            }
//            catch
//            {
//                _result = null;
//            }
//            finally
//            {
//                if (ct != null)
//                    ct.Dispose();
//                if (ms != null)
//                    ms.Dispose();
//                if (cs != null)
//                    cs.Dispose();
//            }

//            return ASCIIEncoding.UTF8.GetString(_result);
//        } //NOT USED - DELETE WHEN READY - GOOD IDEA?
//#endif

        /// <summary>
        /// Encrypt a string
        /// </summary>
        /// <param name="Password"></param>
        /// <returns></returns>//NOT USED - DELETE WHEN READY - GOOD IDEA?
        //private static string Encrypt(string Password)
        //{
        //    if (string.IsNullOrEmpty(Password))
        //        return string.Empty;

        //    byte[] Value = Encoding.UTF8.GetBytes(Password);
        //    SymmetricAlgorithm mCSP = new RijndaelManaged();
        //    mCSP.Key = _key;
        //    mCSP.IV = _initVector;
        //    using (ICryptoTransform ct = mCSP.CreateEncryptor(mCSP.Key, mCSP.IV))
        //    {
        //        using (MemoryStream ms = new MemoryStream())
        //        {
        //            using (CryptoStream cs = new CryptoStream(ms, ct, CryptoStreamMode.Write))
        //            {
        //                cs.Write(Value, 0, Value.Length);
        //                cs.FlushFinalBlock();
        //                cs.Close();
        //                return Convert.ToBase64String(ms.ToArray());
        //            }
        //        }
        //    }
        //} //NOT USED -- DELETE//NOT USED - DELETE WHEN READY - GOOD IDEA?

        /// <summary>
        /// Looks up the users password crypto string in the database
        /// </summary>
        /// <param name="Username"></param>
        /// <returns></returns>



        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
            SqlConnection con = new SqlConnection(Globals.dataFile);
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From Login where UserName ='" + txtUserName.Text + "' and Password ='" + txtPassword.Text + "'", con);
            con.Open();
            DataTable dt = new DataTable();
            con.Close();
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                //Focus box before showing a message
                txtUserName.Focus();
                MessageBox.Show("Enter your username", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Focus again afterwards, sometimes people double click message boxes and select another control accidentally
                txtUserName.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(txtPassword.Text))
            {
                txtPassword.Focus();
                MessageBox.Show("Enter your password", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPassword.Focus();
                return;
            }
            else //input was valid
            {
                    string password = EncodePasswordToBase64(txtUserName.Text);
            
                    MessageBox.Show(password.ToString());
                    string decodedPassword = Base64Decode(password);
                    password = Base64Decode(password);
                    MessageBox.Show(decodedPassword.ToString());
                    int user = int.Parse(txtUserName.Text);
                loadUserInfo(user,txtPassword.Text);
                //encode password here??
            }

        }
            catch
            {

                isValidNumber(txtUserName.Text);
            }
    }   //end of btnLogin


        public static string EncodePasswordToBase64(string password) //encode password //not used
        {

            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] inArray = HashAlgorithm.Create("SHA1").ComputeHash(bytes);
            return Convert.ToBase64String(inArray);
        }

        public static string Base64Decode(string base64EncodedData) //decode password  // not used
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        } //ok

        private void txtPassword_TextChanged(object sender, EventArgs e) //password text changed
        {
            if (!isValidNumber(txtUserName.Text)) //if userName is valid
            {
                txtUserName.BackColor = Color.Red;
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Globals.soundLocation);
                player.Play();
                txtUserName.SelectAll(); //selects text and forces user to reinput
                lblUserName.Text = "* Username:";
                errorProvider.SetError(txtUserName, "Please enter your 8 digit employee number. ");
                Globals.letsContinueBoolean = false;
            }

            else
            {
                txtUserName.BackColor = Color.Black;
                lblUserName.Text = "Username:";
                errorProvider.Clear();
                Globals.letsContinueBoolean = true;

                if (txtPassword.Text == "") //validate Password
                {
                    errorProvider.SetError(txtPassword, "Please dont forget your password.");
                    txtPassword.Focus();
                }
            }
        } //ok
        private bool isValidNumber(string userInput) //Check to see if a number is valid
        {
            double number = 0;
            if (double.TryParse(userInput, out number))
                return true;
            else if (userInput == "")
                return false;
            else
                return false;
        }

        private void User_Login_Load(object sender, EventArgs e)
        {
            txtUserName.Focus();

        } //load ok

        public void txtUserName_TextChanged(object sender, EventArgs e) //username text changed
        {
            if (!isValidNumber(txtUserName.Text)) //if userName is valid
            {
                txtUserName.BackColor = Color.Red;
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Globals.soundLocation);
                player.Play();
                txtUserName.SelectAll(); //selects text and forces user to reinput
                lblUserName.Text = "* Username:";
                errorProvider.SetError(txtUserName, "Please enter your 8 digit employee number. ");
                Globals.letsContinueBoolean = false;
            }

            else
            {
                txtUserName.BackColor = Color.Black;
                lblUserName.Text = "Username:";
                errorProvider.Clear();
                Globals.letsContinueBoolean = true;
                
            }

            if (Globals.letsContinueBoolean == false || txtUserName.Text == "") //validate UserName
            {
                errorProvider.SetError(txtUserName, "Start by entering your SAP number.");
                txtUserName.Focus();
            }
            
        } //ok
        //public string firstName;
        //public string lastName;
        //public int userName;
        //public string role;

        //public string fullName
        //{
        //    get { return firstName + lastName; }
        //    set { firstName = value; lastName = value; }
        //}

        public void loadUserInfo(int user, string pass)
        {
            //LookupUser(user.ToString());
            //DbManager db = new DbManager();
            //db.GetUsersData
           //SELECT column_name, column_name, FROM table_name;
            SqlConnection con = new SqlConnection(Globals.dataFile); //step 1 connection file
            string query = "Select * from Login where USERNAME = '" + user.ToString().Trim()+ "' and PASSWORD ='" + pass.ToString().Trim() + "'";
            
            SqlDataAdapter sda = new SqlDataAdapter(query, con); //add query and connection object    
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                sda.Fill(dt);
                con.Close();
            }
       catch
            {
                con.Close();
                MessageBox.Show("Error opening dbConnection.");
            }


            if (dt.Rows.Count == 1)
            {
         
                con.Open();
                try
                {
                    SqlDataReader myReader = null;
                    SqlCommand myCommand = new SqlCommand(query, con);
                    myReader = myCommand.ExecuteReader();
                    emp emp = new emp();
                    char[] c = new char[15];
                     string s = new string(c);
                    while (myReader.Read()) //setting employee information 
                    {
                       emp.setFirstName(myReader["FIRSTNAME"].ToString().Trim());
                       emp.setLastName(myReader["LASTNAME"].ToString().Trim());
                       emp.setHoursAvailable(Convert.ToInt32(myReader["HOURS_AVAILABLE"]));
                       emp.setHoursTaken(Convert.ToInt32(myReader["HOURS_TAKEN"]));
                       emp.setUnit1(Convert.ToInt32(myReader["ASSIGNED_UNIT1"]));
                       emp.setUnit2(Convert.ToInt32(myReader["ASSIGNED_UNIT2"]));
                        emp.setUnit3(Convert.ToInt32(myReader["ASSIGNED_UNIT3"]));
                        emp.setUnit4(Convert.ToInt32(myReader["ASSIGNED_UNIT4"]));
                        emp.setUnit5(Convert.ToInt32(myReader["ASSIGNED_UNIT5"]));
                        emp.setRestDay1(Convert.ToString(myReader["REST_DAY1"]));
                        emp.setRestDay2(Convert.ToString(myReader["REST_DAY2"]));
                        emp.setEmpNumber(Convert.ToInt32(myReader["USERNAME"]));
                        //ROLE
                    }
                    this.Hide();
                    UserChangeForm success = new UserChangeForm();
                    success.ShowDialog();//SHOW NEW FORM 
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
                con.Close();
               

            }//end of if dt.rows
            else
                MessageBox.Show("Login not successful. Try again.");
 

        }

    }//end of public partial class User_Login
}


//private void txtUserName_TextChanged(object sender, EventArgs e) //runs at each key entry for user name

//{


//}
//{
//    if (!isValidNumber(txtUserName.Text)) //if userName is valid
//    {
//        txtUserName.BackColor = Color.Red;
//        System.Media.SoundPlayer player = new System.Media.SoundPlayer(Globals.soundLocation);
//player.Play();
//        txtUserName.SelectAll(); //selects text and forces user to reinput
//        lblUserName.Text = "* Username:";
//        errorProvider.SetError(txtUserName, "Please enter your 8 digit employee number. ");
//        Globals.letsContinueBoolean = false;
//    }
//    else
//    {
//        txtUserName.BackColor = Color.Black;
//        lblUserName.Text = "Username:";
//        errorProvider.Clear();
//        Globals.letsContinueBoolean = true;
//   xzcfzcza 


//private bool CompareStrings(string string1, string string2)
//{
//    return String.Compare(string1, string2, true, System.Globalization.CultureInfo.InvariantCulture) == 0 ? true : false;
//}



