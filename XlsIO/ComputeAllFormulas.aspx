<%@ Page Title="XlsIO-Compute All formulas-ASP.NET-SYNCFUSION"   MasterPageFile="~/samplebrowser.master" Language="C#" AutoEventWireup="true"
    CodeFile="ComputeAllFormulas.aspx.cs" Inherits="WebSampleBrowser.XlsIO.ComputeAllFormulas" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ControlsSection" runat="server">
    <p>
        Essential XlsIO can compute the values of a formula entered during run time using
        the calculate engine that is integrated in XlsIO. This makes it possible to retrieve
        the values of a formula that were entered using XlsIO during run time. Currently,
        over 150 functions are supported, which covers all common usage scenarios.
    </p>
    <br />
    <p>
        Click the button to view an Excel spreadsheet generated by Essential XlsIO. 
        Please note that Microsoft Excel Viewer or Microsoft Excel is required to view the resultant document.
    </p>
    <div>
        <table id="PanelTable" width="750px" cellpadding="0" cellspacing="0" border="0">
            <tr>
              <td>                
                <div>
                    <table width="80%" cellpadding="0" cellspacing="0" border="0">
                        <tr>
                            <td>
                                <asp:label runat="server" id="label1" text="Save As :"></asp:label>
                                <asp:radiobutton style="margin-left: 10px" id="rBtnXls" runat="server" groupname="formatgrp" text="XLS" />
                                <asp:radiobutton style="margin-left: 10px" id="rBtnXlsx" runat="server" groupname="formatgrp" text="XLSX" checked="true" />
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:button id="Button1" runat="server" onclick="Button1_Click" text="Create Document"
                                    width="200px" />
                            </td>
                        </tr>
                    </table>
                </div>
            </td>
            </tr>
        </table>
    </div>
</asp:Content>

