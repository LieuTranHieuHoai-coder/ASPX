<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="FoddASP.admin.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cph_content" runat="server">
    <div class="container">

    <!-- Outer Row -->
    <div class="row justify-content-center">

      <div class="col-xl-10 col-lg-12 col-md-9">

        <div class="card o-hidden border-0 shadow-lg my-5">
          <div class="card-body p-0">
            <!-- Nested Row within Card Body -->
            <div class="row">
              <div class="col-lg-6 d-none d-lg-block bg-login-image"></div>
              <div class="col-lg-6">
                <div class="p-5">
                  <div class="text-center">
                    <h1 class="h4 text-gray-900 mb-4">Welcome Back!</h1>
                  </div>
                  
                    <div class="form-group">
                     <%-- <input type="email" class="form-control form-control-user" id="exampleInputEmail" aria-describedby="emailHelp" placeholder="Enter Email Address...">--%>
                        <asp:TextBox ID="txt_username" runat="server" type="text" class="form-control form-control-user"  aria-describedby="emailHelp" placeholder="Enter Username..."></asp:TextBox>
                    </div>
                    <div class="form-group">
                      <%--<input type="password" class="form-control form-control-user" id="exampleInputPassword" placeholder="Password">--%>
                        <asp:TextBox ID="txt_password" runat="server" type="password" class="form-control form-control-user" placeholder="Password"></asp:TextBox>
                    </div>
                    <div class="form-group">
                      <div class="custom-control custom-checkbox small">
                        <input type="checkbox" class="custom-control-input" id="customCheck">
                        <label class="custom-control-label" for="customCheck">Remember Me</label>
                      </div>
                    </div>

                      <asp:Button ID="Button1" runat="server" Text="Login" class="btn btn-primary btn-user btn-block" OnClick="Button1_Click"/>
                    
                      
                    <hr>
                    <a href="index.html" class="btn btn-google btn-user btn-block">
                      <i class="fab fa-google fa-fw"></i> Login with Google
                    </a>
                    <a href="index.html" class="btn btn-facebook btn-user btn-block">
                      <i class="fab fa-facebook-f fa-fw"></i> Login with Facebook
                    </a>
                  
                  <hr>
                  <div class="text-center">
                    <a class="small" href="forgot-password.html">Forgot Password?</a>
                  </div>
                  <div class="text-center">
                    <a class="small" href="register.html">Create an Account!</a>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>

      </div>

    </div>

  </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cph_js" runat="server">
</asp:Content>
