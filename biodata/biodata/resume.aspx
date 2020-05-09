<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="resume.aspx.cs" Inherits="biodata.resume" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <style>
        .b { font-weight: bold; }
        iv { border: 1px solid;}
        .panel-body {
            order: 2px solid; 
            ox-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2), 0 6px 20px 0 rgba(0, 0, 0, 0.19); 
            adding: 50px;
        }
        .panel.resume { 
            order: 2px solid; 
            ackground-color: Gainsboro;
            box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2), 0 6px 20px 0 rgba(0, 0, 0, 0.19); 
            padding: 40px;
        }
        /* div { border: 1px solid; } */
        .panel-body.resume {
            ackground-color: Gainsboro;
            order-bottom: 2px solid white;
            ackground-color: white;
            -index:5;
            border: 2px solid;
            padding: 50px;
        }
        .row.b {
            ackground-color: grey;
            border-top: 1px solid; 
            border-bottom: 1px solid;
            font-weight: bold;
            font-weight: 900;
        }
        table { text-align: center; }
    </style>

    <section id="main-content">
        <section id="wrapper">
            <div class="row">
                <div class="col-lg-12">
                    <section class="panel">
                        <header class="panel-heading">
                            <center>
                                <h1>RESUME</h1>
                                <hr>
                            </center>
                            <h3>Please enter user name and email to get the resume:-</h3>
                        </header>
                        <div class="panel-body">

                            <div class="row">
                                <div class="col-md-4">
                                    <div class="form-group">
                                        <asp:Label Text="Name*" runat="server" />
                                        <asp:TextBox runat="server" ID="nmtxt" Enabled="true" CssClass="form-control input-sm" placeholder="Full Name" />
                                    </div>
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
                                        <asp:Button ID="btnSearch" Text="Search" CssClass="btn btn-success btn-lg" width="280px" runat="server" OnClick="btnSearch_Click" />
                                    </div>
                                </div>
                                <div class="col-md-4">
                                    <div class="form-group">
                                        <asp:Button ID="btnAdd" Text="Add New" CssClass="btn btn-primary btn-lg" width="280px" runat="server" OnClick="btnAdd_Click" />
                                    </div>
                                </div>
                            </div>

                            <hr />
                            <br />
                            
                            <section class="panel resume">
                                

                                        <div class="panel-body resume">
                                            <div class="row">
                                                <div class="col-md-8">
                                                    <h4><asp:Label ID="nmlbl" Text="-" runat="server" /></h4>
                                                </div>
                                                <div class="col-md-4 rsd1">
                                                    <h4><placeholder class="b">Phone No: </placeholder><asp:Label ID="nolbl" Text="&nbsp;-" runat="server" /></h4>
                                                    <h4><placeholder class="b">Email: </placeholder><asp:Label ID="elbl" Text="&nbsp;-" runat="server" /></h4>
                                                </div>
                                            </div>

                                            <div class="row b">
                                                <div class="col-md-12 text-center">
                                                    <h4 class="b">CAREER OBJECTIVE</h4>
                                                </div>
                                            </div>
                                                <br />
                                            <div class="row">
                                                <div class="col-md-12">
                                                    <h4><asp:Label ID="colbl" Text="-" runat="server" /></h4>
                                                </div>
                                            </div>
                                                <br /><br />
                                            <div class="row b">
                                                <div class="col-md-12 text-center">
                                                    <h4 class="b">ACADEMIC QUALIFICATION</h4>
                                                </div>
                                            </div>
                                                <br />
                                            <div class="row">
                                                <div class="col-md-12"><br />
                                                    <table class="table table-striped table-hover" border="1">
                                                        <thead>
                                                            <tr>
                                                                <th class="text-center" scope="col">Examination<br>Passed</th>
                                                                <th class="text-center" scope="col">College</th>
                                                                <th class="text-center" scope="col">Year of Passing</th>
                                                                <th class="text-center" scope="col">Marks</th>
                                                            </tr>
                                                        </thead>
                                                        <tbody>
                                                            <tr>
                                                                <td><asp:Label ID="pglbl" Text="-" runat="server" /></td>
                                                                <td><asp:Label ID="pgclglbl" Text="-" runat="server" /></td>
                                                                <td><asp:Label ID="pgyrlbl" Text="-" runat="server" /></td>
                                                                <td><asp:Label ID="pgperlbl" Text="-" runat="server" /></td>
                                                            </tr>
                                                            <tr>
                                                                <td><asp:Label ID="glbl" Text="-" runat="server" /></td>
                                                                <td><asp:Label ID="gclglbl" Text="-" runat="server" /></td>
                                                                <td><asp:Label ID="gyrlbl" Text="-" runat="server" /></td>
                                                                <td><asp:Label ID="gperlbl" Text="-" runat="server" /></td>
                                                            </tr>
                                                            <tr>
                                                                <td><asp:Label ID="clslbl" Text="-" runat="server" /></td>
                                                                <td><asp:Label ID="slbl" Text="-" runat="server" /></td>
                                                                <td><asp:Label ID="syrlbl" Text="-" runat="server" /></td>
                                                                <td><asp:Label ID="sperlbl" Text="-" runat="server" /></td>
                                                            </tr>
                                            
                                                        </tbody>
                                                    </table>
                                                </div>
                                            </div>
                                                <br />
                                            <div class="row b">
                                                <div class="col-md-12 text-center">
                                                    <h4 class="b">Knowledge in Software</h4>
                                                </div>
                                            </div>
                                                <br />
                                            <div class="row">
                                                <div class="col-md-12">
                                                    <h4><asp:Label ID="sslbl" Text="-" runat="server" /></h4>
                                                </div>
                                            </div>
                                                <br /><br />
                                            <div class="row b">
                                                <div class="col-md-12 text-center">
                                                    <h4 class="b">Project Description</h4>
                                                </div>
                                            </div>
                                                <br />
                                            <div class="row">
                                                <div class="col-md-12">
                                                    <h4><asp:Label ID="pdlbl" Text="-" runat="server" /></h4>
                                                </div>
                                            </div>
                                                <br /><br />
                                            <div class="row b">
                                                <div class="col-md-12 text-center">
                                                    <h4 class="b">Personal Skills</h4>
                                                </div>
                                            </div>
                                                <br />
                                            <div class="row">
                                                <div class="col-md-12">
                                                    <h4><asp:Label ID="pslbl" Text="-" runat="server" /></h4>
                                                </div>
                                            </div>

                                        </div>
                                    

                            </section>
                        </div>
                    </section><center><asp:GridView ID="GridView1" runat="server" width="1150px"/></center>
                </div>
            </div>
        </section>
    </section>

</asp:Content>