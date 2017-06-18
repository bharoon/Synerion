<%@ Page Title="Rounding" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Rounding.aspx.cs" Inherits="Synerion.Rounding" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <h3><%: Title %></h3>
            <asp:UpdatePanel ID="UpdatePanelRounding" UpdateMode="Conditional" runat="server">
                <ContentTemplate>
                    <fieldset>
                        <asp:TextBox ID="txtInputDateTime" runat="server" ClientIDMode="Static"></asp:TextBox>
                        <asp:Button ID="btnTest" runat="server" OnClientClick="return isValideDateTimeFormat();"  Text="Test" CssClass="btn btn-default" OnClick="btnTest_OnClick" />
                        <asp:Label ID="lblResult" runat="server" Text="Result"></asp:Label>
                    </fieldset>
                </ContentTemplate>
            </asp:UpdatePanel> 
        </div>
    </div>
    <script type="text/javascript" >
        function isValideDateTimeFormat() {
            var dateInput = $('#txtInputDateTime').val();
            var myRegExp = /^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1]) ([0-9]|1[0-1]):[0-5][0-9]/;
            if (dateInput.match(myRegExp)) {
                return true;
            }
            else {
                alert("Please input text in correct format. Please try again");
                $('#txtInputDateTime').focus();
                return false;
            }
        };
    </script>
</asp:Content>