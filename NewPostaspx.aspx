<%@ Page Language="C#" AutoEventWireup="true" CodeFile="NewPostaspx.aspx.cs" Inherits="NewPostaspx" %>

<!DOCTYPE html>
<script runat="server">

   
</script>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="main.css" />
    <script type="text/javascript" src="js/jquery-1.9.1.min.js"></script>
    <script type="text/javascript">

        $(document).ready(function () {
            $('#<%=chkslider.ClientID%>').on("change", function () {

                if (this.checked == true) {
                    $('#row').css({ 'display': 'table-row' });
                }
                else {
                    $('#row').css({ 'display': 'none' });
                }

            });

        });

    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div class="wrapper">
                      <table>       
                          <tbody>
                              <tr>
                                  <td>عنوان مطلب :</td>
                                  <td><asp:TextBox ID="txttitle"   runat="server"></asp:TextBox> </td>
                              </tr>
                                <tr>
                                  <td>خلاصه مطلب :</td>
                                  <td> <asp:TextBox ID="txtsm" Width="300" Height="120" TextMode="MultiLine" runat="server"></asp:TextBox></td>
                              </tr>
                                <tr>
                                  <td>متن مطلب :</td>
                                  <td> <asp:TextBox ID="txtbody" Width="600" Height="250" TextMode="MultiLine" runat="server"></asp:TextBox></td>
                              </tr>
                              <tr>
                                  <td>درج اسلایدر :</td>
                                  <td>
                                     <asp:CheckBox ID="chkslider" runat="server" /></td>
                              </tr>
                                <tr id="row" >
                                  <td>تصویر اسلایدر :</td>
                                  <td><asp:FileUpload ID="uploader" runat="server" /></td>
                              </tr>
                               <tr>
                                  <td></td>
                                  <td>   
                                    <asp:Button CssClass="btn" ID="btnSend" runat="server" Text="ارسال مطلب" OnClick="btnSend_Click" />
                                     </td>
                              </tr>
                          </tbody>
                      </table>
    
    </div>
    </form>
</body>
</html>
