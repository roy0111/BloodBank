using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BloodBankWithUnitTesting
{
    public partial class SignUp : System.Web.UI.Page
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
                Label1.Text = "!!! Name length 4-35 charecter ";
            }
            else
            {

                Label1.Text = " ";
            }

            if (TextBox2.Text.Length < 8 || TextBox2.Text.Length > 35)
            {
                flag = false;
                Label2.Text = "!!! Mail length 8-35 charecter ";
            }

            else
            {

                Label2.Text = " ";
            }


            if (TextBox4.Text.Length < 5 || TextBox4.Text.Length > 10)
            {
                flag = false;
                Label4.Text = "!!! Phone number length 5-10 digit ";
            }

            else
            {

                Label4.Text = " ";
            }

            if (TextBox4.Text.Length < 5 || TextBox4.Text.Length > 10)
            {
                flag = false;
                Label4.Text = "!!! Phone number length 5-10 digit ";
            }

            else
            {

                Label4.Text = " ";
            }

            if (TextBox5.Text.Length < 8 || TextBox5.Text.Length > 35)
            {
                flag = false;
                Label5.Text = "!!! Password field 8-35 digit";
            }
            else
            {
                Label5.Text = "";

            }
            if (TextBox5.Text != TextBox6.Text)
            {
                flag = false;
                Label6.Text = "!!! Password not Matched";
            }
            else
            {
                Label6.Text = "";

            }
            if (CheckBox1.Checked == false)
            {
                flag = false;
                Label7.Text = "!!! check the checkbox";
            }
            else
            {
                Label7.Text = "";
            }


            if (flag == true)
            {

                DataClassesDataContext dbCon = new DataClassesDataContext();
                var user = from usr in dbCon.user_logins
                           where usr.user_mail == TextBox2.Text
                           select usr;
                if (user.Count() != 0)
                {
                    dbCon.Connection.Dispose();
                    Response.Write("<script>alert(' !!! >" + TextBox2.Text + "< mail is already in used.');</script>");
                }
                else if (user.Count() == 0)
                {

                    try
                    {

                        string user_pid = "DI" + DateTime.Now.ToString("yyyyMMddHHmmss");
                        user_login userloginInfo = new user_login();
                        userloginInfo.activity = "y";
                        userloginInfo.reg_date = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd"));

                        userloginInfo.user_mail = TextBox2.Text;
                        userloginInfo.user_pass = TextBox5.Text;

                        user_profile_info userProfileInfo = new user_profile_info();
                        userProfileInfo.user_PID = user_pid;
                        userProfileInfo.userMail = TextBox2.Text;
                        userProfileInfo.userName = TextBox1.Text;
                        userProfileInfo.dob = Convert.ToDateTime(TextBox3.Text.ToString());
                        userProfileInfo.gender = DropDownList1.Text;
                        userProfileInfo.userAddress = DropDownList3.Text;
                        userProfileInfo.bloodGroup = DropDownList2.Text;
                        userProfileInfo.phoneNumber = TextBox4.Text;

                        dbCon.user_logins.InsertOnSubmit(userloginInfo);
                        dbCon.user_profile_infos.InsertOnSubmit(userProfileInfo);
                        dbCon.SubmitChanges();

                        dbCon.Connection.Dispose();
                        Session["user_pid"] = user_pid;
                        Session["user_mail"] = TextBox2.Text;
                        Session["user_bloodGroup"] = DropDownList2.Text;

                        //  Response.Write("<script>alert('"+ userloginInfo.reg_date + " ');</script>");
                        Response.Redirect("Donor/profile.aspx");


                    }
                    catch (Exception)
                    {

                        throw;
                    }

                }
                else
                {

                    //  Response.Write("<script>alert(' !!! Try Later.');</script>");

                }
            }
        }
    }
}