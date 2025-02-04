<%@ Page Title="ComboBox-Server-Side Events-ASP.NET-SYNCFUSION"   Language="C#" AutoEventWireup="true" MasterPageFile="~/Samplebrowser.Master" CodeBehind="Events.aspx.cs" MetaDescription="This sample demonstrates the server side OnSelect event in ASP.NET Web Forms ComboBox control." Inherits="WebSampleBrowser.ComboBox.Events" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ControlsSection" runat="server">
    <div class="frame">
        <ej:ComboBox ID="selectColor" runat="server" Width="100%" DataTextField="text" OnValueSelect="selectColor_ValueSelect" Placeholder="Choose a color"></ej:ComboBox>
    </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="EventSection" runat="server">
    <asp:UpdatePanel ID="UpdatePanelProp" UpdateMode="Conditional" runat="server">
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="Clear" EventName="click" />
        </Triggers>
        <ContentTemplate>
            <div class="cols-prop-area event-tracer">
                <div>
                    <div class="heading">
                        <span>Event Trace</span>
                    </div>
                    <div class="prop-grid content">
                        <div class="eventarea">
                            <div class="EventLog" id="EventLog" runat="server">
                            </div>
                        </div>
                        <div class="evtbtn">
                            <ej:Button ID="Clear" Type="Button" OnClick="Clear_Click" Text="Clear" ClientSideOnClick="onClear" CssClass="eventclear e-btn" runat="server"></ej:Button>
                        </div>
                    </div>
                </div>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="StyleSection" runat="server">
    <style type="text/css">
        .frame {
            width: 30%;
            padding: 50px;
        }
    </style>
</asp:Content>


