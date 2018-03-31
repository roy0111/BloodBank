<%@ Page Title="" Language="C#" MasterPageFile="~/signinMasterPage.Master" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="BloodBankWithUnitTesting.SignUp" %>



<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

     <br /><br />
    <div class="row">
         
    <div class="col-4"></div>
       
        <div class=" col-5" style="align-self:center; text-align: center;" >
             
            <div class="container"  runat="server">
          
    <div class="row vertical-offset-100">
    	<div class="col-md-4 col-md-offset-4">
    		<div class="panel panel-default">
			  	<div class="panel-heading">
			 	</div>
			  	<div class="panel-body">
			    	<form id="form1" runat="server">
                    <fieldset>
			    	  	<div class="form-group">
                            <asp:TextBox ID="TextBox1"  required="require" class="form-control" placeholder="Full Name" runat="server" TextMode="SingleLine" Height="40px" Width="500px" MaxLength="36"></asp:TextBox>
			    		<asp:Label ID="Label1" runat="server" Font-Size="Medium" ForeColor="Black"></asp:Label>

                          </div><br/>
                        
			    		<div class="form-group">
                                <asp:TextBox ID="TextBox2"  required="require" class="form-control" placeholder="Enter your E-mail" runat="server" TextMode="Email" Height="40px" Width="500px" MaxLength="32"></asp:TextBox>
			    					    		<asp:Label ID="Label2" runat="server" Font-Size="Medium" ForeColor="Black"></asp:Label>
                        </div><br/>
                        <div class="form-group">
                                <asp:TextBox ID="TextBox3"  required="require" class="form-control" placeholder="Date Of Birth" runat="server" TextMode="Date" Height="40px" Width="500px" MaxLength="32" CssClass="btn-outline-dark focus" Font-Size="20px"></asp:TextBox>
			    					    		<asp:Label ID="Label3" runat="server" Font-Size="Medium" ForeColor="Black"></asp:Label>
                        </div><br /> 
                        <div class="form-group">
                               <asp:DropDownList ID="DropDownList3" CssClass="form-control"  Height="50px" Width="500px" runat="server" Font-Size="Larger" ToolTip="Select Your Current Area">
                                 <asp:ListItem>Asad Gate</asp:ListItem>
                                 <asp:ListItem>Badda</asp:ListItem>
                                 <asp:ListItem>Dhanmondi</asp:ListItem>
                                   <asp:ListItem>Farmget</asp:ListItem>
                                   <asp:ListItem>Gabtoli</asp:ListItem>
                                   <asp:ListItem>Gazipur</asp:ListItem>
                                   <asp:ListItem>Gulshan</asp:ListItem>
                                   <asp:ListItem>Gulisthan</asp:ListItem>
                                   <asp:ListItem>Rampura</asp:ListItem>
                                   <asp:ListItem>Malibagh</asp:ListItem>
                                   <asp:ListItem>Mirpur</asp:ListItem>
                                   <asp:ListItem>Motijheel</asp:ListItem>
                                   <asp:ListItem>Mohammadpur</asp:ListItem>
                                   <asp:ListItem>Mouchak</asp:ListItem>
                                   <asp:ListItem>Nadda</asp:ListItem>
                                   <asp:ListItem>Puran Dhaka</asp:ListItem>
                                   <asp:ListItem>Poltan</asp:ListItem>
                                   <asp:ListItem>Karwan Bazar</asp:ListItem>
                                   <asp:ListItem>Sahbagh</asp:ListItem>
                                   <asp:ListItem>Savar</asp:ListItem>
                                   <asp:ListItem>Shamoli</asp:ListItem>
                                   <asp:ListItem>Uttara</asp:ListItem>
                                   <asp:ListItem>Wari</asp:ListItem>
                             </asp:DropDownList>
			    		</div>
                         <div class="form-group">
                             <asp:DropDownList ID="DropDownList1" CssClass="form-control"  Height="50px" Width="500px" runat="server" Font-Size="Larger" ToolTip="Select your gender">
                                 <asp:ListItem>Male</asp:ListItem>
                                 <asp:ListItem>Female</asp:ListItem>
                                 <asp:ListItem>Others</asp:ListItem>
                             </asp:DropDownList>
			    		</div>
                             <div class="form-group">
                             <asp:DropDownList ID="DropDownList2" CssClass="form-control" Height="50px" Width="500px" runat="server" Font-Size="Larger" ToolTip="Select your blood group">
                                 <asp:ListItem>a+</asp:ListItem>
                                 <asp:ListItem>a-</asp:ListItem>
                                 <asp:ListItem>b+</asp:ListItem>
                                 <asp:ListItem>b-</asp:ListItem>
                                 <asp:ListItem>ab+</asp:ListItem>
                                 <asp:ListItem>ab-</asp:ListItem>
                                 <asp:ListItem>o+</asp:ListItem>
                                 <asp:ListItem>o-</asp:ListItem>
                                 </asp:DropDownList>
			    		</div>

                     	<div class="form-group">
                                <asp:TextBox ID="TextBox4"  required="require" class="form-control" placeholder="Phone No.(+880-)" runat="server" TextMode="SingleLine" Height="40px" Width="500px" MaxLength="10"></asp:TextBox>
			    					    		<asp:Label ID="Label4" runat="server" Font-Size="Medium" ForeColor="Black"></asp:Label>
                         </div><br/>

			    		<div class="form-group">
                                <asp:TextBox ID="TextBox5"  required="require" class="form-control" placeholder="Password" runat="server" TextMode="Password" Height="40px" Width="500px" MaxLength="32"></asp:TextBox>
			    					<asp:Label ID="Label5" runat="server" Font-Size="Medium" ForeColor="Black"></asp:Label>
                        </div><br/>

                       <div class="form-group">
                                <asp:TextBox ID="TextBox6"  required="require" class="form-control" placeholder="Confirm Password" runat="server" TextMode="Password" Height="40px" Width="500px" MaxLength="32"></asp:TextBox>
			    					    		<asp:Label ID="Label6" runat="server" Font-Size="Medium" ForeColor="Black"></asp:Label>
                       </div><br/>
                        <div class="form-group">
                            <asp:CheckBox ID="CheckBox1" required="require" CssClass="form-check" runat="server" Width="500px" Text="* Agree with terms and conditions." Font-Size="Large" Font-Bold="True" ForeColor="White" />
			    		<br /><asp:Label ID="Label7" runat="server" Font-Size="Medium" ForeColor="Black"></asp:Label>
                       </div>
                         <asp:Button ID="Button1" class="btn btn-lg btn-success btn-block"  runat="server" Text="Sign Up" Width="500px" OnClick="Button1_Click" />
			    	</fieldset>
			      	</form>
                      <br /> <br /> <br /> 
			    </div>
			</div>
		</div>
	</div>


   </div>

        </div>
        <div class="col-3">

            
<div class="card text-white bg-success mb-3" style="max-width: 20rem;">
  <div class="card-header">Sign In</div>
  <div class="card-body">
    <h4 class="card-title">Already have an account ?</h4>
    <p class="card-text">Log In your account</p>
      <input  type="button" class="btn btn-lg btn-warning btn-block" onclick="window.location.href ='SignIn.aspx'" value="Sign In"/>
  </div>
</div>

        </div>
        </div>
</asp:Content>


