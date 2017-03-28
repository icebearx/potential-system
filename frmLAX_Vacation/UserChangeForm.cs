using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using System.IO;
using System.Data;
using System.Text.RegularExpressions;

namespace frmLAX_Vacation
{
    public partial class UserChangeForm : Form
    {
       // SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Warrior\Documents\users.mdf;Integrated Security=True;Connect Timeout=30");
     //   SqlCommand cmd = new SqlCommand();
       // SqlDataReader dr;


       /// String _connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Warrior\Documents\users.mdf;Integrated Security=True;Connect Timeout=30";//change database location here when ready
     //   private SqlCommand _cmd;
        private string user = emp.getFirstName() + emp.getLastName();
      //  private String _sql = "SELECT * FROM users WHERE users == emp.get_empNumber()";
       // usersDataSet ds = new usersDataSet();

        public UserChangeForm()
        {
            InitializeComponent();
        }
        // ListBox l = new ListBox();

        private static class Globals
        {
            public static int currentYear = 2017; //current year to run program
            public static int minHoursChange = 48;
            public static int minDaysChange = 2;
            public static string fileLocation = @"c:\temp\MyTest.txt"; //showdialog replace
        }
        //enum WeekDays
        //{
        //    Sunday,
        //    Monday,
        //    Tuesday,
        //    Wednesday,
        //    Thursday,
        //    Friday,
        //    Saturday
        //}
        private void UserChangeForm_Load(object sender, EventArgs e)    //setting form labels and loading employee stats
        {
            // TODO: This line of code loads data into the 'usersDataSet.Login' table. You can move, or remove it, as needed.
            this.loginTableAdapter.Fill(this.usersDataSet.Login);
            this.lblWelcomeMessage.Text = "Welcome " + emp.getFirstName() + " " + emp.getLastName() + "." + " Please make a selection.";
            this.lblHoursAvailable.Text = emp.getHoursAvailable().ToString();
            this.lblHoursUsed.Text = (emp.getHoursTaken() - emp.getHoursTaken()).ToString(); //available hours minus hours taken
            this.lblUserRestDays.Text = (emp.getRestDay1().Trim() + " / " + emp.getRestDay2().Trim());

            //Rest Days: Saturday / Sunday

 
            loadEmployeeStats();
        }
       
        private void btnSubmitChange_Click(object sender, EventArgs e) //TODO submit change to database and save. write to logfile
        {
            int fromUnit = 0;
            int toUnit = 0;  
         //   SqlDataAdapter da;
            try
            {
                //   //using (SqlConnection _connString)
                // //  da.Open();
                //   da = new SqlDataAdapter(_sql, _connString);
                //   da.UpdateCommand = new SqlCommand("UPDATE users SET FIRSTNAME = @FIRSTNAME, LASTNAME = @LASTNAME WHERE USERNAME = @USERNAME");

                //   da.Fill(ds);
                ////   _con.Close();
                fromUnit = int.Parse(cbxFromUnit.SelectedItem.ToString()); //FROM
                //string temp = "1";
                //while (cbxFromUnit.SelectedItem.ToString() != temp.ToString())
                //{

                //}wq
                toUnit = int.Parse(cbxToUnit.SelectedItem.ToString()); //TO UNIT

                Console.WriteLine("You want to change " + fromUnit + " to " + toUnit + ".");
                fileWrite(emp.getFirstName() +" " + emp.getLastName(), fromUnit, toUnit);
                updateDB();//DOES NOTHING YET
                // (string userName, int unitChangedFrom, int unitChangedTo)

            }
            catch (Exception ex)
            {
                cbxFromUnit.BackColor = Color.Red;
                errorProvider1.SetError(cbxToUnit, "Please give up a vacation unit. ");
                Console.WriteLine(ex.Message);
            };
        }
        private void updateDB()
        {
            
        }
        private void saveDB()
        {
            int[] units = setValueArray();
            //String connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Warrior\Documents\users.mdf;Integrated Security=True;Connect Timeout=30";//change database location here when ready
           // string Query = "insert into database.login (ASSIGNED_UNIT1, ASSIGNED_UNIT2, ASSIGNED_UNIT3, ASSIGNED_UNIT4, ASSIGNED_UNIT5) values
        }
        //updateDB code below that works!!!!
        //sort of
        //    emp oldEmpData = new emp();
        //    SqlConnection cn = new SqlConnection();
        //    DataSet CustomersDataSet = new DataSet();
        //    SqlDataAdapter da;
        //    SqlCommandBuilder cmdBuilder;

        //    //Set the connection string of the SqlConnection object to connect
        //    //to the SQL Server database in which you created the sample
        //    //table.
        //    cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Warrior\Documents\users.mdf;Integrated Security=True;Connect Timeout=30";//change database location here when ready

        //    cn.Open();

        //    //Initialize the SqlDataAdapter object by specifying a Select command 
        //    //that retrieves data from the sample table.
        //    da = new SqlDataAdapter("select * from LOGIN order by USERNAME", cn);
        //    //Initialize the SqlCommandBuilder object to automatically generate and initialize
        //    //the UpdateCommand, InsertCommand, and DeleteCommand properties of the SqlDataAdapter.
        //    cmdBuilder = new SqlCommandBuilder(da);

        //    //Populate the DataSet by running the Fill method of the SqlDataAdapter.
        //    da.Fill(CustomersDataSet, "Login");

        //    //Display the Update, Insert, and Delete commands that were automatically generated
        //    //by the SqlCommandBuilder object.
        //    Console.WriteLine("Update command Generated by the Command Builder : ");
        //    Console.WriteLine("==================================================");
        //    Console.WriteLine(cmdBuilder.GetUpdateCommand().CommandText);
        //    Console.WriteLine("         ");

        //    Console.WriteLine("Insert command Generated by the Command Builder : ");
        //    Console.WriteLine("==================================================");
        //    Console.WriteLine(cmdBuilder.GetInsertCommand().CommandText);
        //    Console.WriteLine("         ");

        //    Console.WriteLine("Delete command Generated by the Command Builder : ");
        //    Console.WriteLine("==================================================");
        //    Console.WriteLine(cmdBuilder.GetDeleteCommand().CommandText);
        //    Console.WriteLine("         ");


        //    //Write out the value in the CustName field before updating the data using the DataSet.
        //    Console.WriteLine("Users Vacation Week 1 before Update : " + CustomersDataSet.Tables["LOGIN"].Rows[0]["ASSIGNED_UNIT1"]);

        //    //Modify the value of the ASSIGNED_UNIT field.
        //    int toUnit = int.Parse(cbxToUnit.SelectedItem.ToString());
        ////    int fromUnit = int.Parse(cbxFromUnit.SelectedItem.ToString());

        //    ////Console.WriteLine(CustomersDataSet.Tables["Login"].Rows[0]["ASSIGNED_UNIT1"] + "   writeline here");
        //    //if (CustomersDataSet.Tables["Login"].Rows[0]["ASSIGNED_UNIT1"] != cbxToUnit)
        //    //{
        //    //}

        //    CustomersDataSet.Tables["LOGIN"].Rows[0]["ASSIGNED_UNIT1"] = toUnit.ToString();

        //    //Post the data modification to the database.

        //    da.Update(CustomersDataSet, "LOGIN");

        //    Console.WriteLine("ASSIGNED_UNIT1 Name updated successfully");

        //    //Close the database connection.
        //    cn.Close();

        //    //Pause
        //    Console.ReadLine();
        //    //  string cmdText = "UPDATE _con SET ASSIGNED_UNIT"
        // }

        private void tmrCurrent_Tick(object sender, EventArgs e)
        {
            lblCurrentTimer.Text = (DateTime.Now.ToLongTimeString() + " " + DateTime.Now.ToLongDateString());
        }
        private void loadEmployeeStats()
        {//FUBAR
            cldUserSelection.Focus(); //focus on the calendar
            DateTime d = DateTime.Now;
            int currentWeekNumber = getWeekNumber(d);
            int minWeek = emp.getUnit1();
            sortAndBlockOutUnit(); //sorts and applys text to radio buttons

            //TODO -- UPDATE DATABASE WITH SELECTED CHANGE. VALIDATE SPACE FOR CHANGE.

        }

        private void sortAndBlockOutUnit()
        {
            DateTime dateNow = DateTime.Now;
            int currentWeekNumber = getWeekNumber(dateNow);
            string userRestDay2 = emp.getRestDay1();
            int[] numArray = new int[5];//array of user's vacation weeks
            numArray = setValueArray();
            Array.Sort(numArray);//sorting the vacation week

            //TODO CLEANUP CODE AND USE A LISTBOX FOR THE RADIO BUTTONS??
            //for (x = 0; x < rbi.Length; x++) //disable vacation weeks that already past
            //{
            //    int temp;
            //    bool isValid;
            //    isValid = int.TryParse((numArray[x].ToString()), out temp);
            //    if (isValid == true) //is a valid number - proceed to convert 
            //    {
            //        temp = int.Parse(numArray[x].ToString());
            //        numArray[x] = temp;
            //    }
            //    if (numArray[x] > 0) // Gets and sets the radio buttons to what the current employee has scheduled. Doesnt allow changing of previous weeks.
            //    {
            //        dtmStart = GetFirstDayOfWeek(DateTime.Now.Year, numArray[x], Application.CurrentCulture); //shound be Sunday 
            //        rbi[x].Text = numArray[x].ToString() + " : " + dtmStart.AddDays(-6).ToShortDateString() + " - " + dtmStart.ToShortDateString();

            //    }
            //}

            Console.WriteLine("Today is: " + dateNow.DayOfWeek.ToString());
            addValuesToChange(currentWeekNumber);
            addValuesToListBox();

        }
        private void addValuesToListBox() 
        {
         //   DateTime dtmStart = new DateTime();
         //   dtmStart = DateTime.Now;
            bool isValid;
            int temp;
            int[] numArray = new int[10];//array of user's vacation weeks
            numArray = setValueArray();
            Array.Sort(numArray); //makes list smallest to largest
            for (int x = 0; x < numArray.Length; x++) //adds user vacation weeks to listbox
            {

                isValid = int.TryParse((numArray[x].ToString()), out temp);
                if (isValid == true)
                {
                    lstCurrentUserInfo.Items.Add("Vacation Week " + (lstCurrentUserInfo.Items.Count+1) + ":   Unit #" + temp);
                    if (numArray[x].ToString() == "0")
                    {
                        lstCurrentUserInfo.Items.RemoveAt(lstCurrentUserInfo.Items.Count - 1);
                    }
                }
            }

        }
        private void addValuesToChange(int curr) //adds the values to the cbxToUnit drop down list (Excluding past weeks)
        {
            int[] units = setValueArray();
            bool isValidChange = true;
                isValidChange = isWithinChangeRestrictions();
                int skipAunit = 0;
                if (isValidChange == false) //7 Days in a week
                {
                    skipAunit = 1;
                    isValidChange = true;
                }

                for (int i = skipAunit; i < units.Length; i++) //Add users available vacation units
                {
                    if (units[i] >= curr && isValidChange == true) //TODO dont add if rest days ... ect
                    {
                        cbxFromUnit.Items.Add(units[i].ToString()); //dynamic up/down adding vacation weeks 
                    }
                }
                
                for (int i = skipAunit; i < 53; i++) //Add future vacation units
                {
                    if (i > curr) //TODO dont add if rest days ... ect
                    {
                        cbxToUnit.Items.Add(i);
                   //
                    }
                }
            cbxFromUnit.Sorted = true;
          }
        private bool isWithinChangeRestrictions()
        {
            DateTime checkValidDate = new DateTime();
                        
            checkValidDate = DateTime.Now; //assign NOW to date 
            checkValidDate = checkValidDate.AddDays(-2);
            bool isValidBoolean = true;

            string restDay2 = emp.getRestDay2(); //contains string rest day
          // Console.WriteLine(checkValidDate.DayOfWeek.ToString() + " is DayOfWeek.");
            Console.WriteLine(restDay2.ToString() + " is their Rest Day"); 
           
            //If 2nd Rest Day equals 2 days ago,1 day ago, today, tomorrow, 2 days from now-NOT VALID
                while (checkValidDate.DayOfWeek.ToString() != "Sunday" && isValidBoolean == true)
                {
                    Console.WriteLine(checkValidDate.DayOfWeek.ToString() + "checkValidDate.DayOfWeek.ToString() loop here.");
                    if (restDay2.ToString() == checkValidDate.DayOfWeek.ToString())
                    {
                      //  if (emp.get)
                        isValidBoolean = false;
                        return isValidBoolean;
                    }
                    else if (checkValidDate.ToString() == "Sunday") //previous vacation unit
                    {
                        isValidBoolean = false;
                        return isValidBoolean;
                    }
                    else
                    {
                        checkValidDate = checkValidDate.AddDays(1);
                    }
                }//end of while loop
            return isValidBoolean;
            //Console.WriteLine(dateNow.ToString() + " 24 hour clock problem."); 
            //TODO in future - assign user start time for maximum effectiveness
        }//end of isWithinChangeRestrictions

        public int getWeekNumber(DateTime date)
        {
            return new GregorianCalendar(GregorianCalendarTypes.Localized).GetWeekOfYear
                (date, CalendarWeekRule.FirstDay, DayOfWeek.Monday);
                     
        }
        private void grpMainControls_Enter(object sender, EventArgs e)
        {

        }

        private void btnChangeUnit_Click(object sender, EventArgs e)
        {

            flwUserChangeVacation.Visible = true;
            btnChangeUnit.Visible = false;
            btnSubmitChange.Visible = true;
            //// Create a SelectionRange object and set its Start and End properties.
            //SelectionRange sr = new SelectionRange();
            //sr.Start = DateTime.Parse(this.textBox1.Text);
            //sr.End = DateTime.Parse(this.textBox2.Text);
            ///* Assign the SelectionRange object to the 
            //   SelectionRange property of the MonthCalendar control. */
            //this.cldUserSelection.SelectionRange = sr;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        
        }

        public DateTime GetFirstDayOfWeek(int year, int weekNumber, System.Globalization.CultureInfo culture)
        {
            System.Globalization.Calendar calendar = culture.Calendar;
            DateTime firstOfYear = new DateTime(year, 1, 1, calendar);
            DateTime targetDay = calendar.AddWeeks(firstOfYear, weekNumber);
            DayOfWeek firstDayOfWeek = culture.DateTimeFormat.FirstDayOfWeek;
            while (targetDay.DayOfWeek != firstDayOfWeek)
            {
                targetDay = targetDay.AddDays(-1);
            }
            int weekOfYear = getWeekNumber(targetDay);
            return targetDay;
        }

        private void cldUserSelection_DateChanged(object sender, DateRangeEventArgs e)
        {//Calendar DateChanged 
            int weekOfYear;
            weekOfYear = getWeekNumber(cldUserSelection.SelectionRange.Start);
            lblSelectedWeekOfYear.Text = ("Week of year is: " + weekOfYear); //YES so simple..
            lblSelectedWeekOfYear.Visible = true;
        }
       
        private void lblSelectedWeekOfYear_Click(object sender, EventArgs e)
        {

        }

        private void lblHA_Click(object sender, EventArgs e)
        {

        }

        private void lblHU_Click(object sender, EventArgs e)
        {

        }

        private void lblRequiredInfo_Click(object sender, EventArgs e)
        {

        }
        private int[] setValueArray()
        {
            return new int[] { emp.getUnit1(),emp.getUnit2(),emp.getUnit3(),emp.getUnit4(),emp.getUnit5()};
        }

        private void cbxToUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxToUnit.SelectedItem == cbxFromUnit.SelectedItem)
            {
                cbxToUnit.Items[cbxToUnit.SelectedIndex] = string.Empty;
                cbxToUnit.BackColor = Color.Red;
                btnSubmitChange.Enabled = false;
            }
            else
            {
                btnSubmitChange.Enabled = true;
            }
        }

        private void cbxFromUnit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstCurrentUserInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Regex rgx = new Regex("[^a-zA-Z0-9]");
            string input = (lstCurrentUserInfo.SelectedItem.ToString());
             rgx.Replace(input, "");
            cbxFromUnit.SelectAll();
            cbxFromUnit.SelectedText = input;

        }

        private void fileWrite(string userName, int unitChangedFrom, int unitChangedTo)
        { //Store sales data in a file ( party name, number of people.
            //user name // date and time / change unit from / changed unit to //REST DAYS
            string path = Globals.fileLocation; //path of file

            if (!File.Exists(path))//no file exists at location - CREATE FILE
            {
                // Create a file to write to
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Vacation Change Event on " + DateTime.Now.ToLongDateString() + " @ " + DateTime.Now.ToLongTimeString());
                    sw.WriteLine("\n Employee " + userName + " successfully changed unit # " + unitChangedFrom + " to unit # " + unitChangedTo + ".");
                    sw.WriteLine("\n Employee stated they had " + emp.getRestDay1() + " and " + emp.getRestDay2() + " as rest days.");
                    sw.WriteLine("----------------------------------------------------------------");
                    // if (saveFile.ShowDialog() == DialogResult.OK) {}
                    sw.Close();//close the file
                }
            }
            if (File.Exists(path)) //if the file exists. Append.
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine("Vacation Change Event on " + DateTime.Now.ToLongDateString() + " @ " + DateTime.Now.ToLongTimeString());
                    sw.WriteLine("\n Employee " + userName + " successfully changed unit # " + unitChangedFrom + " to unit # " + unitChangedTo + ".");
                    sw.WriteLine("\n Employee stated they had " + emp.getRestDay1() + " and " + emp.getRestDay2() + " as rest days.");
                    sw.WriteLine("----------------------------------------------------------------");
                    // if (saveFile.ShowDialog() == DialogResult.OK) {}
                    sw.Close();//close the file
                }

            }

           
        }//end of fileWrite

        private void btnChangeRestDays_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Changing rest days is monitored and recorded. ");
         }
    }
}
