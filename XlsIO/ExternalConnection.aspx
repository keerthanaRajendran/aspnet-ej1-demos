﻿<%@ Page MasterPageFile="~/samplebrowser.master" Language="C#" AutoEventWireup="true"
    CodeFile="ExternalConnection.aspx.cs" Inherits="WebSampleBrowser.XlsIO.ExternalConnection" %>

<asp:Content ID="content2" ContentPlaceHolderID="ControlsSection" runat="server">
    <p>
        This sample demonstrates how Essential XlsIO implement the 
        connection between MsExcel and DB(MsAccess,SQL..etc).
    </p>
    <br />
    <p>
        An Excel template is read by XlsIO and an externalconnection is generated for the given country
        ; this is done by fetching data corresponding to the particular country from the Northwind
        database. That, Data base Connection has been included to excel using
        Essential XlsIO.
    </p>
    <br />
    <p>
        Click the button to view an Excel spreadsheet generated by Essential XlsIO. 
        Please note that Microsoft Excel Viewer or Microsoft Excel is required to view the resultant document.
    </p>
    <br />
    <div>
        <table width="650px" id="PanelTable" cellspacing="0" cellpadding="0" border="0">
            <tr>
                <td>                    
                    <div>
                        <table width="110%">
                            <tr>
                                <td align="left">
                                    <asp:label height="25px" style="vertical-align: middle;" id="Label1" runat="server"
                                        text="Select the Country :" />
                                    <asp:dropdownlist id="DropDownList1" width="150px" runat="server" />
                                </td>                            
                                <td align="right">
                                    <asp:checkbox id="refresh" runat="server" text="Refresh" />
                                </td>
                                <td align="right">
                                    <asp:button width="200px" id="Button1" runat="server" text="Create Document" onclick="Button1_Click">                                    
                                    </asp:button>

                                </td>
                            </tr>
                        </table>
                    </div>
                </td>
            </tr>
        </table>
    </div>
</asp:Content>