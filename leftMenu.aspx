<%@ Page Language="VB" MasterPageFile="~/default.master" AutoEventWireup="false" CodeFile="leftMenu.aspx.vb" Inherits="leftMenu" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="leftMenu" Runat="Server">
<section class="vbox">
    <header class="header bg-primary lter text-center clearfix">
      <div class="btn-group">
        <button type="button" class="btn btn-sm btn-dark btn-icon" title="New project"><i class="fa fa-plus"></i></button>
        <div class="btn-group hidden-nav-xs">
          <button type="button" class="btn btn-sm btn-primary dropdown-toggle" data-toggle="dropdown">
            เปลี่ยนฐานข้อมูล
            <span class="caret"></span>
          </button>
          <ul class="dropdown-menu text-left">
            <li><a href="#">โครงการที่ 1</a></li>
            <li><a href="#">โครงการที่ 2</a></li>
            <li><a href="#">โครงการที่ 3</a></li>
          </ul>
        </div>
      </div>
    </header>
    <section class="w-f scrollable">
      <div class="slim-scroll" data-height="auto" data-disable-fade-out="true" data-distance="0" data-size="5px" data-color="#333333">
        
        <!-- nav -->
        <nav class="nav-primary hidden-xs">
          <ul class="nav">
            <li  class="active">
              <a href="index.html" class="active">
              	<b class="badge bg-danger pull-right">5</b>
                <i class="fa fa-dashboard icon">
                  <b class="bg-danger"></b>
                </i>
                <span>My Basket</span>
               </a>
            </li>
            <li >
              <a href="#layout" >
                <i class="fa fa-columns icon">
                  <b class="bg-warning"></b>
                </i>
                <span class="pull-right">
                  <i class="fa fa-angle-down text"></i>
                  <i class="fa fa-angle-up text-active"></i>
                </span>
                <span>Route ทึ่ 1</span>
                <b class="badge bg-info">145</b>
                <b class="badge bg-danger">3</b>
              </a>
              <ul class="nav lt">
                <li >
                  <a href="process.aspx" >
                  	<b class="badge bg-danger pull-right">3</b>
                    <i class="fa fa-angle-right"></i>
                    <span>Process ที่ 2</span>
                  </a>
                </li>
                 <li >
                  <a href="layout-c.html" >
                  	<b class="badge bg-info pull-right">1</b>
                    <i class="fa fa-angle-right"></i>
                    <span>Audit ที่ 2</span>
                  </a>
                </li>
              </ul>
            </li>
            <li >
              <a href="#uikit"  >
                <i class="fa fa-flask icon">
                  <b class="bg-success"></b>
                </i>
                <span class="pull-right">
                  <i class="fa fa-angle-down text"></i>
                  <i class="fa fa-angle-up text-active"></i>
                </span>
                <span>Route ที่ 2</span>
                <b class="badge bg-info">150</b>
                <b class="badge bg-danger">2</b>
              </a>
              <ul class="nav lt">
                <li >
                  <a href="process.aspx" >
                  	<b class="badge bg-danger pull-right">2</b>
                    <p class="pull-right">&nbsp;</p>
                  	<b class="badge bg-info pull-right">20</b>
                    <i class="fa fa-angle-right"></i>
                    <span>Process ที่ 4</span>
                  </a>
                </li>
                 <li >
                  <a href="layout-c.html" >
                  	<b class="badge bg-info pull-right">5</b>
                    <i class="fa fa-angle-right"></i>
                    <span>Audit ที่ 4</span>
                  </a>
                </li>
              </ul>
            </li>
            <li >
              <a href="mail.html"  >
                <b class="badge bg-danger pull-right">3</b>
                <i class="fa fa-envelope-o icon">
                  <b class="bg-primary dker"></b>
                </i>
                <span>Message</span>
              </a>
            </li>
             <li >
              <a href="mail.html"  >
                <i class="fa fa-search icon">
                  <b class="bg-primary dker"></b>
                </i>
                <span>Search</span>
              </a>
            </li>
          </ul>
        </nav>
        <!-- / nav -->
      </div>
    </section>
    
    <footer class="footer lt hidden-xs b-t b-light">
      <div id="chat" class="dropup">
        <section class="dropdown-menu on aside-md m-l-n">
          <section class="panel bg-white">
            <header class="panel-heading b-b b-light">Active chats</header>
            <div class="panel-body animated fadeInRight">
              <p class="text-sm">No active chats.</p>
              <p><a href="#" class="btn btn-sm btn-default">Start a chat</a></p>
            </div>
          </section>
        </section>
      </div>
      <div id="invite" class="dropup">                
        <section class="dropdown-menu on aside-md m-l-n">
          <section class="panel bg-white">
            <header class="panel-heading b-b b-light">
              John <i class="fa fa-circle text-success"></i>
            </header>
            <div class="panel-body animated fadeInRight">
              <p class="text-sm">No contacts in your lists.</p>
              <p><a href="#" class="btn btn-sm btn-facebook"><i class="fa fa-fw fa-facebook"></i> Invite from Facebook</a></p>
            </div>
          </section>
        </section>
      </div>
      <a href="#nav" data-toggle="class:nav-xs" class="pull-right btn btn-sm btn-default btn-icon">
        <i class="fa fa-angle-left text"></i>
        <i class="fa fa-angle-right text-active"></i>
      </a>
      <div class="btn-group hidden-nav-xs">
        <button type="button" title="Chats" class="btn btn-icon btn-sm btn-default" data-toggle="dropdown" data-target="#chat"><i class="fa fa-comment-o"></i></button>
        <button type="button" title="Contacts" class="btn btn-icon btn-sm btn-default" data-toggle="dropdown" data-target="#invite"><i class="fa fa-facebook"></i></button>
      </div>
    </footer>
  </section>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>

