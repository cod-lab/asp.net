<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="user.aspx.cs" Inherits="biodata.user" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <style>
        .btn.btn-lg.cancel {
            background-color: transparent;
            border:1px solid #f0ad4e;
        }
        .btn.btn-lg.cancel:hover { background-color: #F8F8F8; }

    </style>

    <section id="main-content">
        <section id="wrapper">
            <div class="row">
                <div class="col-lg-12">
                    <section class="panel">
                        <header class="panel-heading">
                            <center>
                                <h1>User Details</h1>
                                <hr />
                            </center>
                            <h3><asp:Label ID="headtxt" Text="Please enter all details:-" runat="server" /></h3>
                        </header>
                        <div class="panel-body">

                            <div class="row">
                                <div class="col-md-4">
                                    <div class="form-group">
                                        <asp:Label Text="Name*" runat="server" />
                                        <asp:TextBox runat="server" ID="nmtxt" Enabled="true" CssClass="form-control input-sm" placeholder="Full Name" />
                                    </div>
                                </div>
                                <div class="col-md-4">
                                    <div class="form-group">
                                        <asp:Label Text="Contact No.*" runat="server" />
                                        <asp:TextBox runat="server" ID="notxt" Enabled="true" CssClass="form-control input-sm" placeholder="Number" TextMode="Phone" />
                                    </div>
                                </div>
                                <div class="col-md-4">
                                        
                                        <br />                                        
                                        <asp:Button Text="Edit" ID="btnEdit" CssClass="btn btn-warning btn-lg" width="130px" runat="server" OnClick="btnEdit_Click" />
                                    
                                </div>
                            </div>

                            <div class="row">
                                <div class="col-md-4">
                                    <div class="form-group">
                                        <asp:Label Text="Email*" runat="server" />
                                        <asp:TextBox runat="server" ID="etxt" Enabled="true" CssClass="form-control input-sm" placeholder="@" TextMode="Email" />
                                    </div>
                                </div>
                                <div class="col-md-4">
                                    <div class="form-group">                           
                                        <br /><br />
                                        <placeholder>&nbsp;&nbsp;&nbsp;&nbsp;</placeholder><asp:Label ID="msgtxt" Text="&nbsp;&nbsp;Please enter name & email&nbsp;&nbsp;&nbsp;" runat="server" Visible ="false" Font-Bold="True" Font-Italic="True" ForeColor="White" BackColor="Black" />
                                    </div>
                                </div>
                                <div class="col-md-4">
                                        
                                        <br />
                                        <asp:Button Text="Cancel" ID="btnCancel" CssClass="btn btn-lg cancel" width="130px" runat="server" Visible ="false" OnClick="btnCancel_Click" />
                                    
                                </div>
                            </div>

                            <hr />
                            
                            <div class="row"><h4>&nbsp;&nbsp;&nbsp;Academic Qualifications</h4>
                                <div class="col-md-3">
                                    <div class="form-group">
                                        <asp:Label Text="Post Graduation" runat="server" />
                                        <asp:DropDownList runat="server" ID="pgddl" CssClass="form-control input-sm">
                                            <asp:ListItem Text="MCA" />
                                            <asp:ListItem Text="MBA" />
                                            <asp:ListItem Text="MSc." />
                                            <asp:ListItem Text="M.COM" />
                                            <asp:ListItem Text="MA" />
                                        </asp:DropDownList>
                                    </div>
                                </div>
                                <div class="col-md-3">
                                    <div class="form-group">
                                        <asp:Label Text="College" runat="server" />
                                        <asp:TextBox runat="server" ID="pgclgtxt" Enabled="true" CssClass="form-control input-sm" placeholder="" />
                                    </div>
                                </div>
                                <div class="col-md-3">
                                    <div class="form-group">
                                        <asp:Label Text="Year of Paasing" runat="server" />
                                        <asp:TextBox runat="server" ID="pgyrtxt" Enabled="true" CssClass="form-control input-sm" placeholder="-" />
                                    </div>
                                </div>
                                <div class="col-md-3">
                                    <div class="form-group">
                                        <asp:Label Text="Percentage" runat="server" />
                                        <asp:TextBox runat="server" ID="pgpertxt" Enabled="true" CssClass="form-control input-sm" placeholder="%" TextMode="Number" />
                                    </div>
                                </div>

                                <div class="col-md-3">
                                    <div class="form-group">
                                        <asp:Label Text="Graduation*" runat="server" />
                                        <asp:DropDownList runat="server" ID="gddl" CssClass="form-control input-sm">
                                            <asp:ListItem Text="BCA" />
                                            <asp:ListItem Text="BSc." />
                                            <asp:ListItem Text="B.COM" />
                                            <asp:ListItem Text="BA" />
                                        </asp:DropDownList>
                                    </div>
                                </div>
                                <div class="col-md-3">
                                    <div class="form-group">
                                        <asp:Label Text="College*" runat="server" />
                                        <asp:TextBox runat="server" ID="gclgtxt" Enabled="true" CssClass="form-control input-sm" placeholder="" />
                                    </div>
                                </div>
                                <div class="col-md-3">
                                    <div class="form-group">
                                        <asp:Label Text="Year of Paasing*" runat="server" />
                                        <asp:TextBox runat="server" ID="gyrtxt" Enabled="true" CssClass="form-control input-sm" placeholder="-" />
                                    </div>
                                </div>
                                <div class="col-md-3">
                                    <div class="form-group">
                                        <asp:Label Text="Percentage*" runat="server" />
                                        <asp:TextBox runat="server" ID="gpertxt" Enabled="true" CssClass="form-control input-sm" placeholder="%" TextMode="Number" />
                                    </div>
                                </div>

                                <div class="col-md-3">
                                    <div class="form-group">
                                        <br />
                                        <asp:Label Text="&nbsp;&nbsp;&nbsp;12th" runat="server" />
                                    </div>
                                </div>  
                                <div class="col-md-3">
                                    <div class="form-group">
                                        <asp:Label Text="School*" runat="server" />
                                        <asp:TextBox runat="server" ID="stxt" Enabled="true" CssClass="form-control input-sm" placeholder="" />
                                    </div>
                                </div>
                                <div class="col-md-3">
                                    <div class="form-group">
                                        <asp:Label Text="Year of Paasing*" runat="server" />
                                        <asp:TextBox runat="server" ID="syrtxt" Enabled="true" CssClass="form-control input-sm" placeholder="-" />
                                    </div>
                                </div>
                                <div class="col-md-3">
                                    <div class="form-group">
                                        <asp:Label Text="Percentage*" runat="server" />
                                        <asp:TextBox runat="server" ID="spertxt" Enabled="true" CssClass="form-control input-sm" placeholder="%" TextMode="Number" />
                                    </div>
                                </div>
                            </div>

                            <hr>
                            
                            <div class="row">
                                <div class="col-md-4">
                                    <div class="form-group">
                                        <asp:Label Text="Career Objective" runat="server" />
                                        <asp:TextBox runat="server" ID="cotxt" Enabled="true" CssClass="form-control input-sm" placeholder="Write in brief" Height="135px" TextMode="MultiLine" />
                                    </div>
                                </div>
                                <div class="col-md-4">
                                    <div class="form-group">
                                        <asp:Label Text="Software Skills*" runat="server" />
                                        <asp:TextBox runat="server" ID="sstxt" Enabled="true" CssClass="form-control input-sm" placeholder="Write in points" Height="135px" TextMode="MultiLine" />
                                    </div>
                                </div>
                                <div class="col-md-4">
                                    <div class="form-group">
                                        <asp:Label Text="Personal Skills" runat="server" />
                                        <asp:TextBox runat="server" ID="pstxt" Enabled="true" CssClass="form-control input-sm" placeholder="Write in points" Height="135px" TextMode="MultiLine" />
                                    </div>
                                </div>
                            </div>

                            <div class="row">
                                <div class="col-md-4">
                                    <div class="form-group">
                                        <asp:Label Text="Project Description" runat="server" />
                                        <asp:TextBox runat="server" ID="pdtxt" Enabled="true" CssClass="form-control input-sm" placeholder="Project(If any)" Height="135px" TextMode="MultiLine" />
                                    </div>
                                </div>
                                <div class="col-md-4">
                                    <div class="form-group">                                        
                                        <br /><br /><br />
                                        <asp:Button Text="Save" ID="btnSave" CssClass="btn btn-success btn-lg" width="280px" runat="server" OnClick="btnSave_Click" />
                                        <br /><br />
                                        <placeholder>&nbsp;&nbsp;&nbsp;</placeholder><asp:Label ID="msg" Text="&nbsp;&nbsp;Details Saved&nbsp;&nbsp;&nbsp;" runat="server" Visible ="false" Font-Bold="True" Font-Italic="True" ForeColor="White" BackColor="Black" />
                                    </div>
                                </div>
                                <div class="col-md-4">
                                    <div class="form-group">
                                        <br /><br /><br />
                                        <asp:Button Text="View" ID="btnView" CssClass="btn btn-primary btn-lg" width="280px" runat="server" OnClick="btnView_Click" />
                                    </div>
                                </div>
                            </div>
                        </div>
                    </section><center><asp:GridView ID="GridView1" runat="server" width="1150px"/></center>
                    <hr />
                </div>
            </div>
        </section>
    </section>

</asp:Content>