<%@ Page Language="VB" MasterPageFile="~/default.master" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <script src="js/jquery-1.10.2.js"></script>
   <script type="text/javascript">
       $(function () {

           $.ajax({
               type: "POST",
               url: "default.aspx/getroute",
               contentType: "application/json; charset=utf-8",
               dataType: "json",
               success: function (msg) {
                   // alert(msg.d);
                   var val = eval(msg.d);
                   for (var i = 0; i < val.length; i++) {
                       headerScript(val[i].Name, val[i].Name, "", i);
                       for (var j = 0; j < val[i].WMember.length; j++) {
                           listItem(val[i].WMember[j].WProcess.Type, val[i].WMember[j].WProcess.Name, val[i].WMember[j].Notification, i, val[i].RID, val[i].WMember[j].PID, val[i].WMember[j].Steps)
                       }
                   }
               },
               failure: function (msg) {
                   alert(msg);
               },
               error: function (xhr, err) {
                   alert(err);
               }
           });



           function headerScript(txt, name, pic, row) {
               //first div
               var d = document.createElement('div');
               $(d).addClass("col-sm-6")
               .appendTo($("#ctl00_ContentPlaceHolder1_divOverview")); //main div
               //second section
               var s = document.createElement('section');
               $(s).addClass("panel panel-default")
              .appendTo($(d)); //first div
               //tree header
               var h = document.createElement('header');
               $(h).addClass("panel-heading bg-danger lt no-border")
               .appendTo($(s)); //second div
               //four div
               var d2 = document.createElement('div');
               $(d2).addClass("clearfix")
               .appendTo($(h)); //second div
               //five a
               var d3 = document.createElement('a');
               $(d3).addClass("pull-left thumb avatar b-3x m-r")
              .appendTo($(d2)); //second div
               //six img
               var img = document.createElement('img');
               $(img).addClass("img-circle")
              .attr("src", "images/avatar.jpg")
              .appendTo($(d3)); //second div
               //seven div
               var d4 = document.createElement('div');
               $(d4).addClass("clear")
              .appendTo($(d2)); //second div
               //eight div
               var d5 = document.createElement('div');
               $(d5).addClass("h3 m-t-xs m-b-xs text-white")
               .html(txt)
               .appendTo($(d4)); //second div

               //nine small
               var d6 = document.createElement('small');
               $(d6).addClass("text-muted")
              .html("โครงการที่ 1")
              .appendTo($(d4)); //second div
               //ten i
               var d7 = document.createElement('i');
               $(d7).addClass("fa fa-circle text-white pull-right text-xs m-t-sm")
              .appendTo($(d5)); //second div
               //eleven  
               var listitems = document.createElement('div');
               $(listitems).addClass("list-group no-radius alt")
               .attr("id", row)
               .appendTo($(s)); //second div
           }
           function listItem(type, name, noti, row,rid,pid,step) {
               if (type == "N") {
                   var a = document.createElement('a');
                   $(a).addClass("list-group-item")
                   .attr("href", "process.aspx?id="+pid+"&rid="+ rid +"&step="+ step +"")
                   .appendTo($("#" + row + "")); //second div

                   //second
                   var sp = document.createElement('span');
                   $(sp).addClass("badge bg-info")
                   .html(noti)
                  .appendTo($(a)); //second div
                   //tree
                   var i2 = document.createElement('i');
                   $(i2).addClass("fa fa-angle-right")
                  .appendTo($(a)); //second div
                   $(a).append("&nbsp;" + name );
               }

               else {
                   var a = document.createElement('a');
                   $(a).addClass("list-group-item")
                   .attr("href", "process.aspx?id=" + pid + "&rid=" + rid + "")
                  .appendTo($("#" + row + "")); //second div
                   //second
                   var sp = document.createElement('span');
                   $(sp).addClass("badge bg-warning")
                   .html(noti)
                  .appendTo($(a)); //second div
                   //tree
                   var i2 = document.createElement('i');
                   $(i2).addClass("fa fa-exclamation-circle")
                  .appendTo($(a)); //second div
				   $(a).append("&nbsp;" + name );
               }
           }

       });
   </script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<section class="vbox">
            <section class="scrollable padder">  
            <ul class="breadcrumb no-border no-radius b-b b-light pull-in">
                <li><a href="default.aspx"><i class="fa fa-home"></i> โครงการ 1</a></li>
                <li class="active">My Basket</li>
              </ul>
              <div class="m-b-md">
                <h3 class="m-b-none">My Basket</h3>
                <small>Welcome back, <%=strCurFullName%></small>
              </div>            
              <div class="row">
                <div class="col-lg-8">
                  <div id="divOverview" class="row" runat="server">
                    
                  </div>
                </div>
                <div class="col-lg-4" >
                  
                   <section class="panel panel-default">
                    <header class="panel-heading">                    
                      <span class="label bg-dark">15</span> Inbox
                    </header>
                    <section class="panel-body slim-scroll" data-height="380px">
                      <article class="media">
                        <span class="pull-left thumb-sm"><img src="images/avatar_default.jpg" class="img-circle"></span>
                        <div class="media-body">
                          <div class="pull-right media-xs text-center text-muted">
                            <strong class="h4">12:18</strong><br>
                            <small class="label bg-light">pm</small>
                          </div>
                          <a href="#" class="h4">Bootstrap 3 released</a>
                          <small class="block"><a href="#" class="">John Smith</a> <span class="label label-success">Circle</span></small>
                          <small class="block m-t-sm">Sleek, intuitive, and powerful mobile-first front-end framework for faster and easier web development.</small>
                        </div>
                      </article>
                      <div class="line pull-in"></div>
                      <article class="media">
                        <span class="pull-left thumb-sm"><i class="fa fa-file-o fa-3x icon-muted"></i></span>                
                        <div class="media-body">
                          <div class="pull-right media-xs text-center text-muted">
                            <strong class="h4">17</strong><br>
                            <small class="label bg-light">feb</small>
                          </div>
                          <a href="#" class="h4">Bootstrap documents</a>
                          <small class="block"><a href="#" class="">John Smith</a> <span class="label label-info">Friends</span></small>
                          <small class="block m-t-sm">There are a few easy ways to quickly get started with Bootstrap, each one appealing to a different skill level and use case. Read through to see what suits your particular needs.</small>
                        </div>
                      </article>
                      <div class="line pull-in"></div>
                      <article class="media">
                        <div class="media-body">
                          <div class="pull-right media-xs text-center text-muted">
                            <strong class="h4">09</strong><br>
                            <small class="label bg-light">jan</small>
                          </div>
                          <a href="#" class="h4 text-success">Mobile first html/css framework</a>
                          <small class="block m-t-sm">Bootstrap, Ratchet</small>
                        </div>
                      </article>
                      <div class="line pull-in"></div>
                      <article class="media">
                        <span class="pull-left thumb-sm"><i class="fa fa-file-o fa-3x icon-muted"></i></span>                
                        <div class="media-body">
                          <div class="pull-right media-xs text-center text-muted">
                            <strong class="h4">17</strong><br>
                            <small class="label bg-light">feb</small>
                          </div>
                          <a href="#" class="h4">Bootstrap documents</a>
                          <small class="block"><a href="#" class="">John Smith</a> <span class="label label-info">Friends</span></small>
                          <small class="block m-t-sm">There are a few easy ways to quickly get started with Bootstrap, each one appealing to a different skill level and use case. Read through to see what suits your particular needs.</small>
                        </div>
                      </article>
                      <div class="line pull-in"></div>
                      <article class="media">
                        <div class="media-body">
                          <div class="pull-right media-xs text-center text-muted">
                            <strong class="h4">09</strong><br>
                            <small class="label bg-light">jan</small>
                          </div>
                          <a href="#" class="h4 text-success">Mobile first html/css framework</a>
                          <small class="block m-t-sm">Bootstrap, Ratchet</small>
                        </div>
                      </article>
                      <div class="line pull-in"></div>
                      <article class="media">
                        <span class="pull-left thumb-sm"><i class="fa fa-file-o fa-3x icon-muted"></i></span>                
                        <div class="media-body">
                          <div class="pull-right media-xs text-center text-muted">
                            <strong class="h4">17</strong><br>
                            <small class="label bg-light">feb</small>
                          </div>
                          <a href="#" class="h4">Bootstrap documents</a>
                          <small class="block"><a href="#" class="">John Smith</a> <span class="label label-info">Friends</span></small>
                          <small class="block m-t-sm">There are a few easy ways to quickly get started with Bootstrap, each one appealing to a different skill level and use case. Read through to see what suits your particular needs.</small>
                        </div>
                      </article>
                      <div class="line pull-in"></div>
                      <article class="media">
                        <div class="media-body">
                          <div class="pull-right media-xs text-center text-muted">
                            <strong class="h4">09</strong><br>
                            <small class="label bg-light">jan</small>
                          </div>
                          <a href="#" class="h4 text-success">Mobile first html/css framework</a>
                          <small class="block m-t-sm">Bootstrap, Ratchet</small>
                        </div>
                      </article>
                      <div class="line pull-in"></div>
                      <article class="media">
                        <span class="pull-left thumb-sm"><i class="fa fa-file-o fa-3x icon-muted"></i></span>                
                        <div class="media-body">
                          <div class="pull-right media-xs text-center text-muted">
                            <strong class="h4">17</strong><br>
                            <small class="label bg-light">feb</small>
                          </div>
                          <a href="#" class="h4">Bootstrap documents</a>
                          <small class="block"><a href="#" class="">John Smith</a> <span class="label label-info">Friends</span></small>
                          <small class="block m-t-sm">There are a few easy ways to quickly get started with Bootstrap, each one appealing to a different skill level and use case. Read through to see what suits your particular needs.</small>
                        </div>
                      </article>
                      <div class="line pull-in"></div>
                      <article class="media">
                        <div class="media-body">
                          <div class="pull-right media-xs text-center text-muted">
                            <strong class="h4">09</strong><br>
                            <small class="label bg-light">jan</small>
                          </div>
                          <a href="#" class="h4 text-success">Mobile first html/css framework</a>
                          <small class="block m-t-sm">Bootstrap, Ratchet</small>
                        </div>
                      </article>
                      <div class="line pull-in"></div>
                      <article class="media">
                        <span class="pull-left thumb-sm"><i class="fa fa-file-o fa-3x icon-muted"></i></span>                
                        <div class="media-body">
                          <div class="pull-right media-xs text-center text-muted">
                            <strong class="h4">17</strong><br>
                            <small class="label bg-light">feb</small>
                          </div>
                          <a href="#" class="h4">Bootstrap documents</a>
                          <small class="block"><a href="#" class="">John Smith</a> <span class="label label-info">Friends</span></small>
                          <small class="block m-t-sm">There are a few easy ways to quickly get started with Bootstrap, each one appealing to a different skill level and use case. Read through to see what suits your particular needs.</small>
                        </div>
                      </article>
                      <div class="line pull-in"></div>
                      <article class="media">
                        <div class="media-body">
                          <div class="pull-right media-xs text-center text-muted">
                            <strong class="h4">09</strong><br>
                            <small class="label bg-light">jan</small>
                          </div>
                          <a href="#" class="h4 text-success">Mobile first html/css framework</a>
                          <small class="block m-t-sm">Bootstrap, Ratchet</small>
                        </div>
                      </article>
                    </section>
                  </section>
                  
                </div>
              </div>
              
            </section>
          </section>
          <a href="#" class="hide nav-off-screen-block" data-toggle="class:nav-off-screen" data-target="#nav"></a>
</asp:Content>