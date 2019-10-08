<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AwareGroup.Demos.AspWebForms._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>This application is running on the <strong><%= System.Configuration.ConfigurationManager.AppSettings["EnvironmentType"].ToString() %></strong> environment</h1>
    </div>
</asp:Content>
