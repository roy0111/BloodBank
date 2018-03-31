<%@ Page Title="" Language="C#" MasterPageFile="~/signinMasterPage.Master" AutoEventWireup="true" CodeBehind="SignIn.aspx.cs" Inherits="BloodBankWithUnitTesting.SignIn" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

     <br /><br /><br /><br /><br /> 
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
			    	<form id="form2" runat="server">
                    <fieldset>
			    	  	<div class="form-group">
                            <asp:TextBox ID="TextBox1" required="require" class="form-control" placeholder="E-mail" runat="server" TextMode="Email" Height="59px" Width="500px" Font-Size="Large"></asp:TextBox>
			    					    		<asp:Label ID="Label1" runat="server" Font-Size="Medium" ForeColor="Black"></asp:Label>

                          </div>
                        <br />
			    		<div class="form-group">
                                <asp:TextBox ID="TextBox2"  required="require" class="form-control" placeholder="Password" runat="server" TextMode="Password" Height="61px" Width="500px" Font-Size="Large"></asp:TextBox>
			    					    		<asp:Label ID="Label2" runat="server" Font-Size="Medium" ForeColor="Black"></asp:Label>

                        </div><br /> 

                         <asp:Button ID="Button1" class="btn btn-lg btn-success btn-block"  runat="server" Text="Sign In" Width="500px" OnClick="Button1_Click" />
			    	</fieldset>
			      	</form>
			    </div>
			</div>
		</div>
	</div>

   </div>

        </div>
        <div class="col-3">

            
<div class="card text-white bg-success mb-3" style="max-width: 20rem;">
  <div class="card-header">Sign Up</div>
  <div class="card-body">
    <h4 class="card-title">Create A New Account</h4>
    <p class="card-text">Buid Your own Account and become a family member.</p>
      <input  type="button" class="btn btn-lg btn-warning btn-block" onclick="window.location.href ='SignUp.aspx'" value="Sign Up"/>
  </div>
</div>

        </div>
        </div>
</asp:Content>



