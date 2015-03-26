<%@ Page Language="VB" MasterPageFile="~/rManager.master" AutoEventWireup="false" CodeFile="rManager.aspx.vb" Inherits="rManager" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
<section class="hbox stretch">
<!-- .aside -->
    <aside class="bg-light lter " id="email-list">
        <section class="vbox">
        
            <header class="dk header bg-gradient">
                <span class="thumb-sm avatar pull-left m-r-xs m-t-xs"><img src="images/avatar.jpg"></span>
                <p class="h4">Route Name</p>
                <button class="btn btn-default pull-right btn-sm" >
                    <i class="fa fa-plus text m-r-xs"></i>
                    <span>Add Process</span>
                </button>
                <button class="btn btn-default pull-right btn-sm m-r-xs" data-toggle="ajaxModal" href="editR.html" >
                    <i class="fa fa-pencil text m-r-xs"></i>
                    <span>Edit Route</span>
                </button>
            </header>
                    
            <section class="scrollable hover padder bg-light lt w-f">
            <%--Content Here--%>
                <div class="col-md-3"></div>
                <div class="col-lg-6 padder-v">

                    <!-- .accordion -->
                    <div class="panel-group m-b sortable" id="accordion3">
                        <div class="panel panel-info">
                            <div class="panel-heading">
                                Process #1
                                <span class="pull-right" >
                                    <a class="accordion-toggle" data-toggle="collapse" data-parent="#accordion3" href="#collapse1">
                                    <i class="fa fa-pencil fa-fw m-r-xs"></i></a>
                                    <a href="#"><i class="fa fa-times fa-fw"></i></a>                  
                                </span>
                            </div>
                            <div id="collapse1" class="panel-collapse collapse lter">
                                <div class="panel-body text-sm">
                                    <div class="form-group">
                                        <label>Procress Name</label>
                                        <input type="text" class="form-control">
                                    </div>

                                    <section class="panel panel-default">  
                                        <header class="panel-heading ">
                                            <ul class="nav nav-tabs">
                                                <li class="active"><a href="#properties" data-toggle="tab">Properties</a></li>
                                                <li><a href="#advanced" data-toggle="tab">Advanced</a></li>
                                            </ul>
                                        </header>
                                        <div class="panel-body">
                                            <div class="tab-content">
                                                <div class="tab-pane active" id="properties">
                                                    Properties
                                                    <br /><br /><br /><br /><br /><br /><br /><br /><br /><br />
                                                </div>
                                                <div class="tab-pane" id="advanced">
                                                     Advanced
                                                     <br /><br /><br /><br /><br /><br /><br /><br /><br /><br />
                                                </div>
                                            </div>
                                        </div>
                                    </section>
                                    <div class="text-center padder-v">
                                        <button class="btn btn-sm btn-default" type="submit">Update</button>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="panel panel-info">
                            <div class="panel-heading">
                                Process #2
                                <span class="pull-right" >
                                    <a class="accordion-toggle" data-toggle="collapse" data-parent="#accordion3" href="#collapse2">
                                        <i class="fa fa-pencil fa-fw m-r-xs"></i>
                                    </a>
                                    <a href="#"><i class="fa fa-times fa-fw"></i></a>                  
                                </span>
                            </div>
                            <div id="collapse2" class="panel-collapse collapse">
                                <div class="panel-body text-sm">
                                    <div class="form-group">
                                        <label>Procress Name</label>
                                        <input type="text" class="form-control">
                                    </div>
                                    <section class="panel panel-default">  
                                        <header class="panel-heading bg-light">
                                            <ul class="nav nav-tabs">
                                                <li class="active"><a href="#properties-2" data-toggle="tab">Properties</a></li>
                                                <li><a href="#advanced-2" data-toggle="tab">Advanced</a></li>
                                            </ul>
                                        </header>
                                        <div class="panel-body">
                                            <div class="tab-content">
                                                <div class="tab-pane active" id="properties-2">
                                                    Properties<br /><br /><br /><br /><br /><br /><br /><br /><br /><br />
                                                </div>
                                                <div class="tab-pane" id="advanced-2">
                                                    Advanced<br /><br /><br /><br /><br /><br /><br /><br /><br /><br />
                                                </div>
                                            </div>
                                        </div>
                                    </section>
                                    <div class="text-center padder-v">
                                        <button class="btn btn-sm btn-default" type="submit">Update</button>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="panel panel-info">
                            <div class="panel-heading">
                                Process #3
                                <span class="pull-right " >
                                    <a class="accordion-toggle " data-toggle="collapse" data-parent="#accordion3" href="#collapse3">
                                        <i class="fa fa-pencil fa-fw m-r-xs"></i>
                                    </a>
                                    <a href="#"><i class="fa fa-times fa-fw"></i></a>                  
                                </span>
                            </div>
                            <div id="collapse3" class="panel-collapse collapse">
                                <div class="panel-body text-sm">
                                    <div class="form-group">
                                        <label>Procress Name</label>
                                        <input type="text" class="form-control">
                                    </div>
                                    <section class="panel panel-default">  
                                        <header class="panel-heading bg-light">
                                            <ul class="nav nav-tabs">
                                                <li class="active"><a href="#properties-3" data-toggle="tab">Properties</a></li>
                                                <li><a href="#advanced-3" data-toggle="tab">Advanced</a></li>
                                            </ul>
                                        </header>
                                        <div class="panel-body">
                                            <div class="tab-content">
                                                <div class="tab-pane active" id="properties-3">
                                                    Properties<br /><br /><br /><br /><br /><br /><br /><br /><br /><br />
                                                </div>
                                                <div class="tab-pane" id="advanced-3">
                                                    Advanced<br /><br /><br /><br /><br /><br /><br /><br /><br /><br />
                                                </div>
                                            </div>
                                        </div>
                                    </section>
                                    <div class="text-center padder-v">
                                        <button class="btn btn-sm btn-default" type="submit">Update</button>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <!-- / .accordion -->
                </div>
                <div class="col-md-3"></div>
            </section>
            <footer class="footer text-center b-t">
                <button class="btn btn-success btn-sm">Finish</button>
            </footer>
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
                        <span class="inline m-t-xs">Mika Sokeil&lt;mica_sokeil@gmail.com&gt; to me</span>
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
                        <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi id neque quam. Aliquam sollicitudin venenatis ipsum ac feugiat. Vestibulum ullamcorper sodales nisi nec condimentum. Mauris convallis mauris at pellentesque volutpat. Phasellus at ultricies neque, quis malesuada augue. Donec eleifend condimentum nisl eu consectetur. Integer eleifend, nisl venenatis consequat iaculis, lectus arcu malesuada sem, dapibus porta quam lacus eu neque.</p>
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
    </aside><!-- /.aside -->

    <aside class="aside-md">
        <section class="vbox">
            <header class="bg-light dk header">
                <p>Users (25)</p>
            </header>
            <section class="scrollable hover bg-white w-f">
                <ul class="list-group no-radius m-b-none m-t-n-xxs list-group-alt list-group-lg">
                    <li class="list-group-item">
                        <a href="#" class="thumb-xs pull-left m-r-sm">
                            <img src="images/avatar_default.jpg" class="img-circle">
                        </a>
                        <a href="#" class="clear">Drew Wllon</a>
                    </li>
                    <li class="list-group-item animated fadeInRightBig" href="#email-content, #email-list" data-toggle="class:show,hide">
                        <a href="#" class="thumb-xs pull-left m-r-sm">
                            <img src="images/avatar.jpg" class="img-circle">
                        </a>
                        <a href="#" class="clear">Jonathan George</a>
                    </li>
                    <li class="list-group-item">
                        <a href="#" class="thumb-xs pull-left m-r-sm">
                            <img src="images/avatar.jpg" class="img-circle">
                        </a>
                        <a href="#" class="clear">Josh Long</a>
                    </li>
                    <li class="list-group-item">
                        <a href="#" class="thumb-xs pull-left m-r-sm">
                            <img src="images/avatar_default.jpg" class="img-circle">
                        </a>
                        <a href="#" class="clear">Jack Dorsty</a>
                    </li>
                    <li class="list-group-item">
                        <a href="#" class="thumb-xs pull-left m-r-sm">
                            <img src="images/avatar.jpg" class="img-circle">
                        </a>
                        <a href="#" class="clear">Morgen Kntooh</a>
                    </li>
                    <li class="list-group-item">
                        <a href="#" class="thumb-xs pull-left m-r-sm">
                            <img src="images/avatar_default.jpg" class="img-circle">
                        </a>
                        <a href="#" class="clear">Yoha Omish</a>
                    </li>
                    <li class="list-group-item">
                        <a href="#" class="thumb-xs pull-left m-r-sm">
                            <img src="images/avatar.jpg" class="img-circle">
                        </a>
                        <a href="#" class="clear">Gole Lido</a>
                    </li>
                    <li class="list-group-item">
                        <a href="#" class="thumb-xs pull-left m-r-sm">
                            <img src="images/avatar_default.jpg" class="img-circle">
                        </a>
                        <a href="#" class="clear">
                            Jonthan Snow
                        </a>
                    </li>
                    <li class="list-group-item" href="#email-content" data-toggle="class:show">
                        <a href="#" class="thumb-xs pull-left m-r-sm">
                            <img src="images/avatar_default.jpg" class="img-circle">
                        </a>
                        <a href="#" class="clear">Drew Wllon</a>
                    </li>
                     <li class="list-group-item">
                        <a href="#" class="thumb-xs pull-left m-r-sm">
                            <img src="images/avatar.jpg" class="img-circle">
                        </a>
                        <a href="#" class="clear">Jonathan George</a>
                    </li>
                    <li class="list-group-item">
                        <a href="#" class="thumb-xs pull-left m-r-sm">
                            <img src="images/avatar.jpg" class="img-circle">
                        </a>
                        <a href="#" class="clear">Josh Long</a>
                    </li>
                    <li class="list-group-item">
                        <a href="#" class="thumb-xs pull-left m-r-sm">
                            <img src="images/avatar_default.jpg" class="img-circle">
                        </a>
                        <a href="#" class="clear">Jack Dorsty</a>
                    </li>
                    <li class="list-group-item">
                        <a href="#" class="thumb-xs pull-left m-r-sm">
                            <img src="images/avatar.jpg" class="img-circle">
                        </a>
                        <a href="#" class="clear">Morgen Kntooh</a>
                    </li>
                    <li class="list-group-item">
                        <a href="#" class="thumb-xs pull-left m-r-sm">
                            <img src="images/avatar_default.jpg" class="img-circle">
                        </a>
                        <a href="#" class="clear">Yoha Omish</a>
                    </li>
                    <li class="list-group-item">
                        <a href="#" class="thumb-xs pull-left m-r-sm">
                            <img src="images/avatar.jpg" class="img-circle">
                        </a>
                        <a href="#" class="clear">Gole Lido</a>
                    </li>
                    <li class="list-group-item">
                        <a href="#" class="thumb-xs pull-left m-r-sm">
                            <img src="images/avatar_default.jpg" class="img-circle">
                        </a>
                        <a href="#" class="clear">Jonthan Snow</a>
                    </li>
                    <li class="list-group-item" href="#email-content" data-toggle="class:show">
                        <a href="#" class="thumb-xs pull-left m-r-sm">
                            <img src="images/avatar_default.jpg" class="img-circle">
                        </a>
                        <a href="#" class="clear">Drew Wllon</a>
                    </li>
                    <li class="list-group-item">
                    <a href="#" class="thumb-xs pull-left m-r-sm">
                    <img src="images/avatar.jpg" class="img-circle">
                    </a>
                    <a href="#" class="clear">
                    Jonathan George
                    </a>
                    </li>
                    <li class="list-group-item">
                    <a href="#" class="thumb-xs pull-left m-r-sm">
                    <img src="images/avatar.jpg" class="img-circle">
                    </a>
                    <a href="#" class="clear">
                    Josh Long
                    </a>
                    </li>
                    <li class="list-group-item">
                    <a href="#" class="thumb-xs pull-left m-r-sm">
                    <img src="images/avatar_default.jpg" class="img-circle">
                    </a>
                    <a href="#" class="clear">
                    Jack Dorsty
                    </a>
                    </li>
                    <li class="list-group-item">
                    <a href="#" class="thumb-xs pull-left m-r-sm">
                    <img src="images/avatar.jpg" class="img-circle">
                    </a>
                    <a href="#" class="clear">
                    Morgen Kntooh
                    </a>
                    </li>
                </ul>
            </section>
            <footer class="footer text-center b-t">
                <button class="btn btn-success btn-sm"><i class="fa fa-plus m-r-xs"></i>Add User</button>
            </footer>
        </section>
    </aside>
</section>
    <a href="#" class="hide nav-off-screen-block" data-toggle="class:nav-off-screen" data-target="#nav"></a>
</asp:Content>
