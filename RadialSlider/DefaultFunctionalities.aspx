﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Samplebrowser.Master" AutoEventWireup="true" CodeBehind="DefaultFunctionalities.aspx.cs" Inherits="WebSampleBrowser.RadialSlider.DefaultFunctionalities" %>


<asp:Content ID="Content5" ContentPlaceHolderID="ControlsSection" runat="server">
    <div class="control listbox">
        <div class="frame">
            <ej:RadialSlider ID="slider" runat="server" InnerCircleImageUrl="../Content/images/radialslider/chevron-right.png"></ej:RadialSlider>
		</div>
	</div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="StyleSection" runat="server">
    <style type="text/css">
        .row [class*="cols-"] {
            overflow-x: auto;
        }
    </style>
</asp:Content>