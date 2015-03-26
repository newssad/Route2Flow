<%@ Page Language="VB" AutoEventWireup="false" CodeFile="signin.aspx.vb" Inherits="signin" %>


<!DOCTYPE html>
<html lang="en" class="bg-dark">
<head>
  <meta charset="utf-8" />
  <title>Notebook | Web Application</title>
  <meta name="description" content="app, web app, responsive, admin dashboard, admin, flat, flat ui, ui kit, off screen nav" />
  <meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1" /> 
  <link rel="stylesheet" href="css/bootstrap.css" type="text/css" />
  <link rel="stylesheet" href="css/animate.css" type="text/css" />
  <link rel="stylesheet" href="css/font-awesome.min.css" type="text/css" />
  <link rel="stylesheet" href="css/font.css" type="text/css" />
    <link rel="stylesheet" href="css/app.css" type="text/css" />
  <!--[if lt IE 9]>
    <script src="js/ie/html5shiv.js"></script>
    <script src="js/ie/respond.min.js"></script>
    <script src="js/ie/excanvas.js"></script>
  <![endif]-->
</head>
<body>
  <section id="content" class="m-t-lg wrapper-md animated fadeInUp signinBody">    
    <div class="container aside-xxl">
      
        <a href="#" class="text-center block"><img src="images/logo-signin.png" /></a>
     
      
      <section class="panel-default m-t-lg">

        <form runat="server" method="post" action="signin.aspx" class="panel-body wrapper-lg">
          <div class="form-group">
            <asp:TextBox ID="tbName" runat="server" placeholder="ชื่อผู้ใช้" class="form-control input-lg"></asp:TextBox>
          </div>
          <div class="form-group">
            <asp:TextBox ID="tbPassword" runat="server" placeholder="รหัสผ่าน" class="form-control input-lg"></asp:TextBox>
          </div>
          <!--<div class="checkbox">
            <label>
              <input type="checkbox"> Keep me logged in
            </label>
          </div>-->
          <div class="line line-dashed"></div>
          <a href="#" class="pull-right m-t-xs"><small>ลืมรหัสผ่าน?</small></a>
          <asp:Button ID="btSubmit" runat="server" Text="เข้าสู่ระบบ" class="btn btn-green"></asp:Button>
          
         
        </form>
      </section>
    </div>
  </section>
  <!-- footer -->
  <footer id="footer">
    <div class="text-center text-white">
      <p>
        <small>Powered by SoftVibe Co.,Ltd.<br>&copy; 2015</small>
      </p>
    </div>
  </footer>
  <!-- / footer -->
  <script src="js/jquery.min.js"></script>
  <!-- Bootstrap -->
  <script src="js/bootstrap.js"></script>
  <!-- App -->
  <script src="js/app.js"></script>
  <script src="js/app.plugin.js"></script>
  <script src="js/slimscroll/jquery.slimscroll.min.js"></script>
  
</body>
</html>
