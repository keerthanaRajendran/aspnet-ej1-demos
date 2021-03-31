<%@ Page Title="XlsIO-Replace Options-ASP.NET-SYNCFUSION"   MasterPageFile="~/samplebrowser.master" Language="C#" AutoEventWireup="true"
    CodeFile="ReplaceOptions.aspx.cs" Inherits="WebSampleBrowser.XlsIO.ReplaceOptions" %>

<asp:content id="Content2" contentplaceholderid="ControlsSection" runat="server">
    <p>
        Click the button to view an Excel spreadsheet generated by Essential XlsIO. 
        Please note that Microsoft Excel Viewer or Microsoft Excel is required to view the resultant document.
    </p>
    <br />
    <table id="PanelTable" width="650px" cellpadding="0" cellspacing="0" border="0">
    <tr>
            <td>                
				 <div>
                    <table cellpadding="0" cellspacing="0" border="0" style="width: 461px">
                        <tr> 
						<td align="left" >
						<asp:Label runat="server" ID="label11" Text="Find what:"></asp:Label>
						</td>
						<td align="left">
                        <asp:dropdownlist id="FindList" runat="server" Width="115px">
                        </asp:dropdownlist>
                        </td>
                        <td align="left">
                        <asp:checkbox id="Check1" runat="server" Text="Match case"/>
                        </td>
						</tr>
                        <tr> 
						<td align="left" >
						<asp:Label runat="server" ID="label1" Text="Replace with:"></asp:Label>
						</td>
						<td align="left">
                        <asp:textbox id="textbox1" runat="server" Width="115px"/>
                        </td>
                        <td align="left">
                        <asp:checkbox id="Check2" runat="server" Text="Match entire cell contents"/>
                        </td>
						</tr>
                    </table>
                </div>
				<br />
                <br />
                <div>
                    <table width="60%" cellpadding="0" cellspacing="0" border="0">
                        <tr>
                            <td>
                                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Input Template"
                                    Width="150px" />
                            </td>
                             <td>
                                <asp:button id="Button2" runat="server" text="Replace" onclick="Button2_Click" Width="150px"/>
                            </td>
                        </tr>
                    </table>
                </div>
            </td>
            </tr>
           </table>
</asp:content>

