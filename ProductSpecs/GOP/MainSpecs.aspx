<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="MainSpecs.aspx.vb" Inherits="ProductSpecs.MainSpecs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>GOP New Product Specification Form</title>
    <link rel="stylesheet" href="GOPStyles.css"/>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Greater Omaha New Product Specification Form</h1> 
        </div>
        <div>


            Product Code Search Text:&nbsp;&nbsp;
            <asp:TextBox ID="txtSearchText" runat="server" Width="71px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnSearch" runat="server" Text="Search" Width="88px" />
            <br />
            <br />
            <asp:ListBox ID="lstSearchResults" runat="server" Width="50%" BackColor="#CCCCCC" EnableTheming="True" Rows="10" AutoPostBack="True"></asp:ListBox>
            <br />
            <br />


        </div>
        <div>     
            <asp:Table ID="Table1" runat="server" Width="50%" BorderStyle="Groove">
                <asp:TableRow ><asp:TableCell Width="25%"><asp:Label ID="Label1" runat="server" Text="Product Code: "></asp:Label>
                    </asp:TableCell><asp:TableCell Width="75%"><asp:Label ID="lblProductCode" runat="server"></asp:Label>
                    </asp:TableCell></asp:TableRow>
                <asp:TableRow><asp:TableCell><asp:Label ID="Label3" runat="server" Text="Product Name: "></asp:Label>
                    </asp:TableCell><asp:TableCell><asp:TextBox ID="txtProductName" runat="server"></asp:TextBox>
                    </asp:TableCell></asp:TableRow>
                <asp:TableRow><asp:TableCell><asp:Label ID="Label6" runat="server" Text="Product Grade/Brand: "></asp:Label>
                    </asp:TableCell><asp:TableCell><asp:DropDownList ID="ddlProductGrade" runat="server"></asp:DropDownList>
                    </asp:TableCell></asp:TableRow>
                <asp:TableRow><asp:TableCell><asp:Label ID="Label7" runat="server" Text="Product Description: "></asp:Label>
                    </asp:TableCell><asp:TableCell><asp:TextBox ID="txtProductDescription" runat="server"></asp:TextBox>
                    </asp:TableCell></asp:TableRow>

                <asp:TableRow><asp:TableCell><h3><br /></h3></asp:TableCell></asp:TableRow>
                <asp:TableRow><asp:TableCell><asp:Label ID="Label8" runat="server" Text="Product Picture: "></asp:Label>
                    </asp:TableCell><asp:TableCell><asp:Image id="productImage" runat="server"/>
                    </asp:TableCell></asp:TableRow>
                <asp:TableRow><asp:TableCell><asp:Button ID="btnAddProductImage" runat="server" Text="Add Product Image" />
                    </asp:TableCell></asp:TableRow>
                <asp:TableRow><asp:TableCell><h3><br /></h3></asp:TableCell></asp:TableRow>
                <asp:TableRow><asp:TableCell><asp:Label ID="Label9" runat="server" Text="Label Picture: "></asp:Label>
                    </asp:TableCell><asp:TableCell><asp:Image id="labelImage" runat="server"/>
                    </asp:TableCell></asp:TableRow>
                <asp:TableRow><asp:TableCell><asp:Button ID="btnAddLabelImage" runat="server" Text="Add Label Image" />
                    </asp:TableCell></asp:TableRow>


                <asp:TableRow><asp:TableCell><h3><br /></h3></asp:TableCell></asp:TableRow>

                <asp:TableRow><asp:TableCell><h3><asp:Label ID="Label14" runat="server" Text="Packaging Information"></asp:Label></h3>
                    </asp:TableCell></asp:TableRow>
                <asp:TableRow><asp:TableCell><asp:Label ID="Label15" runat="server" Text="Box Description: "></asp:Label>
                    </asp:TableCell><asp:TableCell><asp:DropDownList ID="ddlBoxDesc" runat="server"></asp:DropDownList>
                    </asp:TableCell></asp:TableRow>
                <asp:TableRow><asp:TableCell><asp:Label ID="Label16" runat="server" Text="Pieces Per Box: "></asp:Label>
                    </asp:TableCell><asp:TableCell><asp:TextBox ID="txtPiecesPerBox" runat="server"></asp:TextBox>
                    </asp:TableCell></asp:TableRow>


                <asp:TableRow><asp:TableCell><h3><br /></h3></asp:TableCell></asp:TableRow>

                <asp:TableRow><asp:TableCell><h3><asp:Label ID="Label13" runat="server" Text="Primary Bag"></asp:Label></h3>
                    </asp:TableCell></asp:TableRow>
                <asp:TableRow><asp:TableCell><asp:Label ID="Label2" runat="server" Text="Length: "></asp:Label>
                    </asp:TableCell><asp:TableCell><asp:TextBox ID="txtLength" runat="server"></asp:TextBox>
                    </asp:TableCell></asp:TableRow>
                <asp:TableRow><asp:TableCell><asp:Label ID="Label4" runat="server" Text="Width: "></asp:Label>
                    </asp:TableCell><asp:TableCell><asp:TextBox ID="txtWidth" runat="server"></asp:TextBox>
                    </asp:TableCell></asp:TableRow>
                <asp:TableRow><asp:TableCell><asp:Label ID="Label5" runat="server" Text="Bag Type: "></asp:Label>
                    </asp:TableCell><asp:TableCell><asp:TextBox ID="txtBagType" runat="server"></asp:TextBox>
                    </asp:TableCell></asp:TableRow>


            </asp:Table>
            <br />
            <br />
        </div>
        <div>
        </div>
    </form>
</body>
</html>
