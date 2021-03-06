﻿<%@ Page Language="VB" MasterPageFile="~/default.master" AutoEventWireup="false" CodeFile="message.aspx.vb" Inherits="message" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<section class="hbox stretch">
            <!-- .aside -->
            <aside class="aside aside-md bg-white">
              <section class="vbox">
                <header class="dk header">
                  <button class="btn btn-icon btn-default btn-sm pull-right"><i class="fa fa-plus"></i></button>
                  <button class="btn btn-icon btn-default btn-sm pull-right visible-xs m-r-xs" data-toggle="class:show" data-target="#mail-nav"><i class="fa fa-reorder"></i></button>
                  <p class="h4">Mailbox</p>
                </header>
                <section>
                  <section>
                    <section id="mail-nav" class="hidden-xs">
                      <ul class="nav nav-pills nav-stacked no-radius">
                        <li>
                          <a href="#">
                            <span class="badge pull-right">15</span> 
                            <i class="fa fa-fw fa-inbox"></i>
                            Inbox
                          </a>
                        </li>
                        <li class="active">
                          <a href="#">
                            <i class="fa fa-fw fa-envelope-o"></i>
                            Sent mail
                          </a>
                        </li>
                        <li>
                          <a href="#">
                            <span class="badge badge-hollow pull-right">4</span>
                            <i class="fa fa-fw fa-bookmark-o"></i>                            
                            Important
                          </a>
                        </li>
                        <li>
                          <a href="#">
                            <i class="fa fa-fw fa-pencil"></i>
                            Draft
                          </a>
                        </li>
                        <li>                
                          <a href="#">
                            <span class="badge badge-hollow pull-right">3</span>
                            <i class="fa fa-fw fa-star-o"></i>                            
                            Spam
                          </a>
                        </li>
                      </ul>
                      <ul class="nav nav-pills nav-stacked no-radius m-t-sm">
                        <li class="padder dk text-sm l-h-2x">
                          <p>Labels</p>
                        </li>
                        <li>
                          <a href="#">
                            <i class="fa fa-circle text-danger pull-right m-t-xs"></i>
                            Work
                          </a>
                        </li>
                        <li>
                          <a href="#">
                            <i class="fa fa-circle pull-right m-t-xs"></i>
                            Private
                          </a>
                        </li>
                        <li>
                          <a href="#">
                            <i class="fa fa-circle text-success pull-right m-t-xs"></i>
                            Clients
                          </a>
                        </li>
                      </ul>
                    </section>
                  </section>
                </section>
              </section>
            </aside>
            <!-- /.aside -->
            <!-- .aside -->
            <aside class="bg-light lter b-l" id="email-list">
              <section class="vbox">
                <header class="bg-light dk header clearfix">
                  <div class="btn-group pull-right">
                    <button type="button" class="btn btn-sm btn-default"><i class="fa fa-chevron-left"></i></button>
                    <button type="button" class="btn btn-sm btn-default"><i class="fa fa-chevron-right"></i></button>
                  </div>
                  <div class="btn-toolbar">
                    <div class="btn-group select">
                      <button class="btn btn-default btn-sm dropdown-toggle" data-toggle="dropdown">
                        <span class="dropdown-label" style="width: 65px;">Filter</span>                    
                        <span class="caret"></span>
                      </button>
                      <ul class="dropdown-menu text-left text-sm">
                        <li><a href="#">Read</a></li>
                        <li><a href="#">Unread</a></li>
                        <li><a href="#">Starred</a></li>
                        <li><a href="#">Unstarred</a></li>
                      </ul>
                    </div>
                    <div class="btn-group">
                      <button class="btn btn-sm btn-default" data-toggle="tooltip" data-placement="bottom" data-title="Refresh"><i class="fa fa-refresh"></i></button>
                    </div>
                  </div>
                </header>            
                <section class="scrollable hover">
                  <ul class="list-group no-radius m-b-none m-t-n-xxs list-group-alt list-group-lg">
                    <li class="list-group-item">
                      <a href="#" class="thumb-xs pull-left m-r-sm">
                        <img src="images/avatar_default.jpg" class="img-circle">
                      </a>
                      <a href="#" class="clear">
                        <small class="pull-right text-muted">3 minuts ago</small>
                        <strong>Drew Wllon</strong> <span class="label label-sm bg-primary text-uc">work</span>
                        <span>Wellcome and play this web application template ... </span>
                      </a>
                    </li>
                    <li class="list-group-item animated fadeInRightBig" href="#email-content, #email-list" data-toggle="class:show,hide">
                      <a href="#" class="thumb-xs pull-left m-r-sm">
                        <img src="images/avatar.jpg" class="img-circle">
                      </a>
                      <a href="#" class="clear">
                        <small class="pull-right text-muted">1 hour ago</small>
                        <strong>Jonathan George</strong>
                        <span>Morbi nec nunc condimentum...<span class="text-danger">click me</span></span>
                      </a>
                    </li>
                    <li class="list-group-item">
                      <a href="#" class="thumb-xs pull-left m-r-sm">
                        <img src="images/avatar.jpg" class="img-circle">
                      </a>
                      <a href="#" class="clear">
                        <small class="pull-right text-muted">2 hours ago</small>
                        <strong>Josh Long</strong>
                        <span>Vestibulum ullamcorper sodales nisi nec...</span>
                      </a>
                    </li>
                    <li class="list-group-item">
                      <a href="#" class="thumb-xs pull-left m-r-sm">
                        <img src="images/avatar_default.jpg" class="img-circle">
                      </a>
                      <a href="#" class="clear">
                        <small class="pull-right text-muted">1 day ago</small>
                        <strong>Jack Dorsty</strong>
                        <span>Morbi nec nunc condimentum...</span>
                      </a>
                    </li>
                    <li class="list-group-item">
                      <a href="#" class="thumb-xs pull-left m-r-sm">
                        <img src="images/avatar.jpg" class="img-circle">
                      </a>
                      <a href="#" class="clear">
                        <small class="pull-right text-muted">3 days ago</small>
                        <strong>Morgen Kntooh</strong>
                        <span>Mobile first web app for startup...</span>
                      </a>
                    </li>
                    <li class="list-group-item">
                      <a href="#" class="thumb-xs pull-left m-r-sm">
                        <img src="images/avatar_default.jpg" class="img-circle">
                      </a>
                      <a href="#" class="clear">
                        <small class="pull-right text-muted">Jun 21</small>
                        <strong>Yoha Omish</strong> <span class="label label-sm bg-danger text-uc">private</span>
                        <span>Morbi nec nunc condimentum...</span>
                      </a>
                    </li>
                    <li class="list-group-item">
                      <a href="#" class="thumb-xs pull-left m-r-sm">
                        <img src="images/avatar.jpg" class="img-circle">
                      </a>
                      <a href="#" class="clear">
                        <small class="pull-right text-muted">May 10</small>
                        <strong>Gole Lido</strong>
                        <span>Vestibulum ullamcorper sodales nisi nec...</span>
                      </a>
                    </li>
                    <li class="list-group-item">
                      <a href="#" class="thumb-xs pull-left m-r-sm">
                        <img src="images/avatar_default.jpg" class="img-circle">
                      </a>
                      <a href="#" class="clear">
                        <small class="pull-right text-muted">Jan 2</small>
                        <strong>Jonthan Snow</strong> <span class="label label-sm bg-success text-uc">clients</span>
                        <span>Morbi nec nunc condimentum...</span>
                      </a>
                    </li>
                    <li class="list-group-item" href="#email-content" data-toggle="class:show">
                      <a href="#" class="thumb-xs pull-left m-r-sm">
                        <img src="images/avatar_default.jpg" class="img-circle">
                      </a>
                      <a href="#" class="clear">
                        <small class="pull-right text-muted">3 minuts ago</small>
                        <strong>Drew Wllon</strong> <span class="label label-sm bg-primary text-uc">work</span>
                        <span>Vestibulum ullamcorper sodales nisi nec sodales nisi nec sodales nisi nec...</span>
                      </a>
                    </li>
                    <li class="list-group-item">
                      <a href="#" class="thumb-xs pull-left m-r-sm">
                        <img src="images/avatar.jpg" class="img-circle">
                      </a>
                      <a href="#" class="clear">
                        <small class="pull-right text-muted">1 hour ago</small>
                        <strong>Jonathan George</strong>
                        <span>Morbi nec nunc condimentum...</span>
                      </a>
                    </li>
                    <li class="list-group-item">
                      <a href="#" class="thumb-xs pull-left m-r-sm">
                        <img src="images/avatar.jpg" class="img-circle">
                      </a>
                      <a href="#" class="clear">
                        <small class="pull-right text-muted">2 hours ago</small>
                        <strong>Josh Long</strong>
                        <span>Vestibulum ullamcorper sodales nisi nec...</span>
                      </a>
                    </li>
                    <li class="list-group-item">
                      <a href="#" class="thumb-xs pull-left m-r-sm">
                        <img src="images/avatar_default.jpg" class="img-circle">
                      </a>
                      <a href="#" class="clear">
                        <small class="pull-right text-muted">1 day ago</small>
                        <strong>Jack Dorsty</strong>
                        <span>Morbi nec nunc condimentum...</span>
                      </a>
                    </li>
                    <li class="list-group-item">
                      <a href="#" class="thumb-xs pull-left m-r-sm">
                        <img src="images/avatar.jpg" class="img-circle">
                      </a>
                      <a href="#" class="clear">
                        <small class="pull-right text-muted">3 days ago</small>
                        <strong>Morgen Kntooh</strong>
                        <span>Mobile first web app for startup...</span>
                      </a>
                    </li>
                    <li class="list-group-item">
                      <a href="#" class="thumb-xs pull-left m-r-sm">
                        <img src="images/avatar_default.jpg" class="img-circle">
                      </a>
                      <a href="#" class="clear">
                        <small class="pull-right text-muted">Jun 21</small>
                        <strong>Yoha Omish</strong> <span class="label label-sm bg-danger text-uc">private</span>
                        <span>Morbi nec nunc condimentum...</span>
                      </a>
                    </li>
                    <li class="list-group-item">
                      <a href="#" class="thumb-xs pull-left m-r-sm">
                        <img src="images/avatar.jpg" class="img-circle">
                      </a>
                      <a href="#" class="clear">
                        <small class="pull-right text-muted">May 10</small>
                        <strong>Gole Lido</strong>
                        <span>Vestibulum ullamcorper sodales nisi nec...</span>
                      </a>
                    </li>
                    <li class="list-group-item">
                      <a href="#" class="thumb-xs pull-left m-r-sm">
                        <img src="images/avatar_default.jpg" class="img-circle">
                      </a>
                      <a href="#" class="clear">
                        <small class="pull-right text-muted">Jan 2</small>
                        <strong>Jonthan Snow</strong> <span class="label label-sm bg-success text-uc">clients</span>
                        <span>Morbi nec nunc condimentum...</span>
                      </a>
                    </li>
                    <li class="list-group-item" href="#email-content" data-toggle="class:show">
                      <a href="#" class="thumb-xs pull-left m-r-sm">
                        <img src="images/avatar_default.jpg" class="img-circle">
                      </a>
                      <a href="#" class="clear">
                        <small class="pull-right text-muted">3 minuts ago</small>
                        <strong>Drew Wllon</strong> <span class="label label-sm bg-primary text-uc">work</span>
                        <span>Vestibulum ullamcorper sodales nisi nec sodales nisi nec sodales nisi nec...</span>
                      </a>
                    </li>
                    <li class="list-group-item">
                      <a href="#" class="thumb-xs pull-left m-r-sm">
                        <img src="images/avatar.jpg" class="img-circle">
                      </a>
                      <a href="#" class="clear">
                        <small class="pull-right text-muted">1 hour ago</small>
                        <strong>Jonathan George</strong>
                        <span>Morbi nec nunc condimentum...</span>
                      </a>
                    </li>
                    <li class="list-group-item">
                      <a href="#" class="thumb-xs pull-left m-r-sm">
                        <img src="images/avatar.jpg" class="img-circle">
                      </a>
                      <a href="#" class="clear">
                        <small class="pull-right text-muted">2 hours ago</small>
                        <strong>Josh Long</strong>
                        <span>Vestibulum ullamcorper sodales nisi nec...</span>
                      </a>
                    </li>
                    <li class="list-group-item">
                      <a href="#" class="thumb-xs pull-left m-r-sm">
                        <img src="images/avatar_default.jpg" class="img-circle">
                      </a>
                      <a href="#" class="clear">
                        <small class="pull-right text-muted">1 day ago</small>
                        <strong>Jack Dorsty</strong>
                        <span>Morbi nec nunc condimentum...</span>
                      </a>
                    </li>
                    <li class="list-group-item">
                      <a href="#" class="thumb-xs pull-left m-r-sm">
                        <img src="images/avatar.jpg" class="img-circle">
                      </a>
                      <a href="#" class="clear">
                        <small class="pull-right text-muted">3 days ago</small>
                        <strong>Morgen Kntooh</strong>
                        <span>Mobile first web app for startup...</span>
                      </a>
                    </li>
                  </ul>
                </section>
                <footer class="footer b-t bg-white-only">
                  <form class="m-t-sm">
                    <div class="input-group">
                      <input type="text" class="input-sm form-control input-s-sm" placeholder="Search">
                      <div class="input-group-btn">
                        <button class="btn btn-sm btn-default"><i class="fa fa-search"></i></button>
                      </div>
                    </div>
                  </form>
                </footer>
              </section>
            </aside>
            <!-- /.aside -->
            <!-- .aside -->
            <aside class="bg-white hide b-l" id="email-content">
              <section class="vbox">
                <section class="scrollable">
                  <div class="wrapper b-b b-light">
                    <a href="#" data-toggle="class" class="pull-left m-r-sm"><i class="fa fa-star-o fa-1x text"></i><i class="fa fa-star text-warning fa-1x text-active"></i></a>
                    <a href="#email-content, #email-list" data-toggle="class:show,hide" class="pull-right text">
                      <i class="fa fa-trash-o"></i>
                    </a>
                    <h4 class="m-n"> Kickoff meeting</h4>
                  </div>
                  <div class="text-sm padder m-t">
                    <div class="block clearfix m-b">
                      <a href="#" class="thumb-xs inline"><img src="images/avatar.jpg" class="img-circle"></a> 
                      <span class="inline m-t-xs">Mika Sokeil
                      &lt;mica_sokeil@gmail.com&gt; to me</span>
                      <div class="pull-right inline">May 12 (<em>4 days ago</em>)                         
                        <div class="btn-group">
                          <button class="btn btn-default btn-xs" data-toggle="tooltip" data-title="Reply"><i class="fa fa-reply"></i></button>
                          <button class="btn btn-default btn-xs dropdown-toggle" data-toggle="dropdown"><span class="caret"></span></button>
                          <ul class="dropdown-menu pull-right">
                            <li><a href="#"><i class="fa fa-reply"></i> Reply</a></li>
                            <li><a href="#"><i class="fa fa-signout"></i> Forward</a></li>
                            <li><a href="#">Add Mika Sokeil to contact list</a></li>
                            <li><a href="#">Mark as unread</a></li>
                            <li class="divider"></li>
                            <li><a href="#">Delete this message</a></li>
                            <li><a href="#">Report spam</a></li>
                          </ul>
                        </div>
                      </div>
                    </div>
                    <div class="line pull-in"></div>
                    <p>Mr. Soe</p>
                    <p>Lorem ipsum dolor sit amet, consectetur adipiscing2222 elit. Morbi id neque quam. Aliquam sollicitudin venenatis ipsum ac feugiat. Vestibulum ullamcorper sodales nisi nec condimentum. Mauris convallis mauris at pellentesque volutpat. Phasellus at ultricies neque, quis malesuada augue. Donec eleifend condimentum nisl eu consectetur. Integer eleifend, nisl venenatis consequat iaculis, lectus arcu malesuada sem, dapibus porta quam lacus eu neque.</p>
                    <blockquote>
                      <em>Morbi nec nunc condimentum, egestas dui nec, fermentum diam. Vivamus vel tincidunt libero, vitae elementum ligula. Nunc placerat purus quam, ac adipiscing arcu rutrum eu. Vestibulum adipiscing ut augue ut auctor. Vestibulum nec lorem imperdiet nibh mollis gravida ut a justo.<br><br>Vestibulum ullamcorper sodales nisi nec condimentum. Mauris convallis mauris at pellentesque volutpat. Phasellus at ultricies neque, quis malesuada augue. Donec eleifend condimentum nisl eu consectetur. Integer eleifend, nisl venenatis consequat iaculis</em>
                    </blockquote>
                    <div class="show">
                      <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi id neque quam. Aliquam sollicitudin venenatis ipsum ac feugiat. Vestibulum ullamcorper sodales nisi nec condimentum. Mauris convallis mauris at pellentesque volutpat. Phasellus at ultricies neque, quis malesuada augue. Donec eleifend condimentum nisl eu consectetur. Integer eleifend, nisl venenatis consequat iaculis, lectus arcu malesuada sem, dapibus porta quam lacus eu neque.</p>
                      <p>Duis non malesuada est, quis congue nibh. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas.</p>
                      <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi id neque quam. Aliquam sollicitudin venenatis ipsum ac feugiat. Vestibulum ullamcorper sodales nisi nec condimentum. Mauris convallis mauris at pellentesque volutpat. Phasellus at ultricies neque, quis malesuada augue. Donec eleifend condimentum nisl eu consectetur. Integer eleifend, nisl venenatis consequat iaculis, lectus arcu malesuada sem, dapibus porta quam lacus eu neque.</p>
                      <p>Duis non malesuada est, quis congue nibh. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas.</p>
                      <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi id neque quam. Aliquam sollicitudin venenatis ipsum ac feugiat. Vestibulum ullamcorper sodales nisi nec condimentum. Mauris convallis mauris at pellentesque volutpat. Phasellus at ultricies neque, quis malesuada augue. Donec eleifend</p>
                    </div>
                    <p>Best Regards<br>Mical</p>
                  </div>
                  <div class="padder">
                    <div class="panel text-sm bg-light">
                      <div class="panel-body">
                        Click here to <a href="#">Reply</a> or <a href="#">Forward</a>
                      </div>
                    </div>
                  </div>
                </section>
              </section>
            </aside>
            <!-- /.aside -->
            <aside class="aside-sm b-l">
              <section class="vbox">
                <header class="bg-light dk header">
                  <p>Contacts (25)</p>
                </header>            
                <section class="scrollable bg-white">
                  <div class="list-group list-group-alt no-radius no-borders">
                    <a class="list-group-item" href="#">
                        <i class="fa fa-circle text-success text-xs"></i>
                        <span>Cris Labiso</span>
                    </a>
                    <a class="list-group-item" href="#">
                        <i class="fa fa-circle text-muted text-xs"></i>
                        <span>Daniel Sandvid</span>
                    </a>
                    <a class="list-group-item" href="#">
                        <i class="fa fa-circle text-danger text-xs"></i>
                        <span>Helder Oliveira</span>
                    </a>
                    <a class="list-group-item" href="#">
                        <i class="fa fa-circle text-muted text-xs"></i>
                        <span>Jeff Broderik</span>
                    </a>
                    <a class="list-group-item" href="#">
                        <i class="fa fa-circle text-muted text-xs"></i>
                        <span>Jonathan Morina</span>
                    </a>
                    <a class="list-group-item" href="#">
                        <i class="fa fa-circle text-success text-xs"></i>
                        <span>Mason Yarnell</span>
                    </a>
                    <a class="list-group-item" href="#">
                        <i class="fa fa-circle text-danger text-xs"></i>
                        <span>Mike Mcalidek</span>
                    </a>
                  </div>
                </section>
                <footer class="footer text-center b-t">
                  <button class="btn btn-success btn-sm"><i class="fa fa-plus"></i> New contact</button>
                </footer>
              </section>
            </aside>
          </section>
          <a href="#" class="hide nav-off-screen-block" data-toggle="class:nav-off-screen" data-target="#nav"></a>
</asp:Content>
