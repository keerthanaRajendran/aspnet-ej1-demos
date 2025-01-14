<%@ Page Title="XlsIO-AutoShapes-ASP.NET-SYNCFUSION"   MasterPageFile="~/samplebrowser.master" Language="C#" AutoEventWireup="true"
    CodeFile="AutoShapes.aspx.cs" Inherits="WebSampleBrowser.XlsIO.AutoShapes" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ControlsSection" runat="server">
    <p>
        Essential XlsIO can used to create auto shapes.
    </p>
    <br />
    <p>
       Click the button to view an Excel spreadsheet generated by Essential XlsIO.
       Please note that Microsoft Excel Viewer or Microsoft Excel is required to view the resultant document.
    </p>   
    <div>
        <table id="PanelTable" width="100%" cellpadding="0" cellspacing="0" border="0">
            <tr>
            <td align="center">                              
                <div>
                    <asp:button id="Button1" runat="server" onclick="Button1_Click" text="Create Document" width="200px" />                    
                </div>
            </td>
            </tr>
        </table>
    </div>
</asp:Content>

