﻿<%@ Page MasterPageFile="~/samplebrowser.master" Language="C#" AutoEventWireup="true"
    CodeFile="Sparklines.aspx.cs" Inherits="WebSampleBrowser.XlsIO.Sparklines" %>

<asp:content id="Content2" contentplaceholderid="ControlsSection" runat="server">
     <p>
        Essential XlsIO has APIs for creating sparkline. The <strong>SparklineGroup</strong>
        class represents the sparklines in memory. This object can be used to format and
        modify sparkline settings; it is similar to modifying sparkline properties using
        Excel.
     </p>
    <br />
    <p>
        Click the button to view an Excel spreadsheet generated by Essential XlsIO. 
        Please note that Microsoft Excel Viewer or Microsoft Excel is required to view the resultant document.
    </p>
    <br />
    <div>
        <table id="PanelTable" width="100%" cellpadding="0" cellspacing="0" border="0">
            <tr>
                <td align="center">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Create Document"
                                        Width="200px" />
                </td>
            </tr>
        </table>
    </div>
</asp:content>