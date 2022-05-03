<%@ Page Title="Contact" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.vb" Inherits="ProductSpecs.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %></h2>
    <p></p>

    <address>
        3001 L Street<br />
        Omaha, NE 68107<br />
        P: 402.731.1700
    </address>

    <address>
        <strong>Support: </strong><a href="mailto:servicedesk@greateromaha.com">servicedesk@greateromaha.com</a><br />
        <strong>Sales: </strong><a href="mailto:sales@greateromaha.com">sales@greateromaha.com</a>
    </address>
</asp:Content>
