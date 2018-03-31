using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BloodBankWithUnitTesting
{
    public partial class SignIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            bool flag = true;

            if (TextBox1.Text.Length < 4 || TextBox1.Text.Length > 36)
            {
                flag = false;
                Label1.Text = "!!! Mail length 4-35 charecter ";
            }
            else
            {

                Label1.Text = " ";
            }

            if (TextBox2.Text.Length < 8 || TextBox2.Text.Length > 35)
            {
                flag = false;
                Label2.Text = "!!! Password length 8-35 charecter ";
            }

            else
            {

                Label2.Text = " ";
            }

            if (flag)
            {
                try
                {
                    DataClassesDataContext dbConn = new DataClassesDataContext();

                    var user = from usr in dbConn.user_logins
                               where usr.user_mail == TextBox1.Text
                               select usr;

                    if (user.Count() == 1)
                    {
                        foreach (user_login usr in user)
                        {
                            if (usr.user_pass != TextBox2.Text)
                            {
                                Label2.Text = "password not matched";
                            }
                            else if (usr.user_pass == TextBox2.Text)
                            {
                                var usrInfo = (from usrI in dbConn.user_profile_infos
                                               where usrI.userMail == TextBox1.Text
                                               select usrI).Single();

                                Session["user_pid"] = usrInfo.user_PID;
                                Session["user_mail"] = TextBox1.Text;
                                Session["user_bloodGroup"] = usrInfo.bloodGroup;
                                dbConn.Connection.Dispose();
                                Response.Redirect("Donor/profile.aspx");

                            }
                            else
                            {
                                dbConn.Connection.Dispose();
                                Label2.Text = "!!! Password not Matched. ";
                            }

                        }
                    }
                    else
                    {
                        dbConn.Connection.Dispose();
                        Label1.Text = "!!! Usermail does not match";
                    }

                }
                catch (Exception)
                {

                    throw;
                }
            }
            else
            {
                //Label1.Text = "!!! Usermail does not match";
            }
        }
    }
}
