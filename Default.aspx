<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <%--<link rel="stylesheet" href="themes/default/default.css" type="text/css" media="screen">--%>
    <link href="themes/default/default.css" rel="stylesheet" type="text/css" media="screen" />
    <link type="text/css" rel="stylesheet" href="nivo-slider.css" />
     <link type="text/css" rel="stylesheet" href="style.css" />
</head>
<body>
    <form id="form1" runat="server">
               
                <asp:Repeater ID="rep_slider" runat="server">
                    <HeaderTemplate>
                        <div class="slider-wrapper theme-default">
                                <div style="text-align:center;margin-top:30px;">Edited by samere</div>
			                    <div id="slider" class="nivoSlider">

                    </HeaderTemplate>
                    <ItemTemplate>
                     <a href="http://www.7learn.com">

                         <img src="<%#DataBinder.Eval(Container.DataItem,"img")%>" data-thumb="<%#DataBinder.Eval(Container.DataItem,"img")%>" alt="<%#DataBinder.Eval(Container.DataItem,"title")%>"  title="<%#DataBinder.Eval(Container.DataItem,"sm")%>">

                     </a>
                    </ItemTemplate>
                    <FooterTemplate>
                          </div>
                        </div>
                    </FooterTemplate>
                </asp:Repeater>
                    
               
    </form>
    <script type="text/javascript" src="js/jquery-1.9.1.min.js"></script>
    <script type="text/javascript" src="js/jquery.nivo.slider.js"></script>
     <script type="text/javascript" src="js/slidersetting.js"></script>
</body>
</html>
