<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Synerion._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">
        <div class="row">
            <p>
                <asp:LinkButton ID="linkbtnRoudingPage" runat="server" PostBackUrl="Rounding.aspx">Rouding Page</asp:LinkButton>
            </p>
            <p>
                <asp:LinkButton ID="linkbtnTimestamp" runat="server" PostBackUrl="Timestamp.aspx">Timestamp Page</asp:LinkButton>
            </p>
        </div>

    </div>

</asp:Content>
