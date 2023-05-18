<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Pictures.aspx.vb" Inherits="ProductSpecs.Pictures" %>

<!DOCTYPE html>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>GOP Product Specification Form</title>
    <link rel="stylesheet" href="GOPStyles.css"/>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Greater Omaha Product Specification Picture Update Form</h1> 
        </div>
        
        <div>     
            <asp:Table ID="tableInfo" runat="server" Width="50%" BorderStyle="Groove" Font-Bold="True" Font-Size="Large">
                <asp:TableRow >
                    <asp:TableCell Width="35%"><asp:Label ID="Label1" runat="server" Text="Product Code: "></asp:Label></asp:TableCell>
                    <asp:TableCell Width="65%"><asp:Label ID="lblProductCode" runat="server"></asp:Label></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell><asp:Label ID="Label3" runat="server" Text="Product Name: "></asp:Label></asp:TableCell>
                    <asp:TableCell><asp:Label ID="lblProductName" runat="server"></asp:Label></asp:TableCell>
                </asp:TableRow>
            </asp:Table>

            <br />
            <br />

    <asp:Table ID="uploadTable" runat="server" BorderStyle="Groove" Font-Bold="True" Font-Size="Large">
                <asp:TableRow >
                    <asp:TableCell Width="45%">Update or select picture choices as needed.<br />  Only one picture can be associated with a selection per item.</asp:TableCell>
                    <asp:TableCell Width="55%"><asp:Button runat="server" Text="Update Selections" ID="btnUpdateSelection" /></asp:TableCell>
                </asp:TableRow>
            </asp:Table>

            <br />
            <br />


            <asp:GridView ID="gvImages" runat="server">
                <Columns>
                    <asp:ImageField>
                    </asp:ImageField>
                </Columns>
            </asp:GridView>
            <br />
        </div>
        <div>
        </div>
    </form>
</body>
</html>
