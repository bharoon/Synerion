<%@ Page Title="Timestamp" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Timestamp.aspx.cs" Inherits="Synerion.Timestamp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <h3><%: Title %></h3>
            <asp:UpdatePanel ID="UpdatePanelRounding" UpdateMode="Conditional" runat="server">
                <ContentTemplate>
                    <fieldset>
                        <asp:Button ID="btnLogTimestamp" runat="server" Text="Log Timestamp" OnClick="btnLogTimestamp_Click" />
                        <br/>
                        <asp:Table ID="tblTimestamp" runat="server"></asp:Table>
                    </fieldset>
                </ContentTemplate>
            </asp:UpdatePanel> 
        </div>
    </div>
</asp:Content>