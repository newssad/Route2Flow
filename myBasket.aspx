<%@ Page Language="VB" AutoEventWireup="false" MasterPageFile="~/default.master" CodeFile="myBasket.aspx.vb" Inherits="myBasket" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<section class="vbox">
            <section class="scrollable padder">  
            <ul class="breadcrumb no-border no-radius b-b b-light pull-in">
                <li><a href="index.html"><i class="fa fa-home"></i> Home</a></li>
                <li class="active">My Basket</li>
              </ul>
              <div class="m-b-md">
                <h3 class="m-b-none">My Basket</h3>
                <small>Welcome back, Yuttana</small>
              </div>            
              <div class="row">
                <div class="col-lg-8">
                  <div class="row">
                    <div class="col-sm-6">
                      <section class="panel panel-default">
                        <header class="panel-heading bg-danger lt no-border">
                          <div class="clearfix">
                            <a href="#" class="pull-left thumb avatar b-3x m-r">
                              <img src="images/avatar.jpg" class="img-circle">
                            </a>
                            <div class="clear">
                              <div class="h3 m-t-xs m-b-xs text-white">
                                Route ที่ 1
                                <i class="fa fa-circle text-white pull-right text-xs m-t-sm"></i>
                              </div>
                              <small class="text-muted">โครงการที่ 1</small>
                            </div>                
                          </div>
                        </header>
                        <div class="list-group no-radius alt">
                          <a class="list-group-item" href="#">
                            <span class="badge bg-info">20</span>
                            <i class="fa fa-comment icon-muted"></i> 
                            Process ที่ 2
                          </a>
                          <a class="list-group-item" href="#">
                            <span class="badge bg-warning">1</span>
                            <i class="fa fa-envelope icon-muted"></i> 
                            Audit ที่ 2
                          </a>
                          <a class="list-group-item" href="#">
                            <span class="badge bg-danger">3</span>
                            <i class="fa fa-eye icon-muted"></i> 
                            Check Out
                          </a>
                        </div>
                      </section>
                      
                       <section class="panel panel-default">
                        <header class="panel-heading bg-info lt no-border">
                          <div class="clearfix">
                            <a href="#" class="pull-left thumb avatar b-3x m-r">
                              <img src="images/avatar.jpg" class="img-circle">
                            </a>
                            <div class="clear">
                              <div class="h3 m-t-xs m-b-xs text-white">
                                Route ที่ 3
                                <i class="fa fa-circle text-white pull-right text-xs m-t-sm"></i>
                              </div>
                              <small class="text-muted">โครงการที่ 1</small>
                            </div>                
                          </div>
                        </header>
                        <div class="list-group no-radius alt">
                          <a class="list-group-item" href="#">
                            <span class="badge bg-success">25</span>
                            <i class="fa fa-comment icon-muted"></i> 
                            Process ที่ 4
                          </a>
                          <a class="list-group-item" href="#">
                            <span class="badge bg-warning">16</span>
                            <i class="fa fa-envelope icon-muted"></i> 
                            Audit ที่ 4
                          </a>
                          <a class="list-group-item" href="#">
                            <span class="badge bg-light">0</span>
                            <i class="fa fa-eye icon-muted"></i> 
                            Check Out
                          </a>
                        </div>
                      </section>
                    </div>
                    <div class="col-sm-6">         
                     
                       <section class="panel panel-default">
                        <header class="panel-heading bg-danger lt no-border">
                          <div class="clearfix">
                            <a href="#" class="pull-left thumb avatar b-3x m-r">
                              <img src="images/avatar.jpg" class="img-circle">
                            </a>
                            <div class="clear">
                              <div class="h3 m-t-xs m-b-xs text-white">
                                Route ที่ 2
                                <i class="fa fa-circle text-white pull-right text-xs m-t-sm"></i>
                              </div>
                              <small class="text-muted">โครงการที่ 1</small>
                            </div>                
                          </div>
                        </header>
                        <div class="list-group no-radius alt">
                          <a class="list-group-item" href="#">
                            <span class="badge bg-info">20</span>
                            <i class="fa fa-comment icon-muted"></i> 
                            Process ที่ 4
                          </a>
                          <a class="list-group-item" href="#">
                            <span class="badge bg-warning">5</span>
                            <i class="fa fa-envelope icon-muted"></i> 
                            Audit ที่ 4
                          </a>
                          <a class="list-group-item" href="#">
                            <span class="badge bg-danger">2</span>
                            <i class="fa fa-eye icon-muted"></i> 
                            Check Out
                          </a>
                        </div>
                      </section>
                    </div>
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