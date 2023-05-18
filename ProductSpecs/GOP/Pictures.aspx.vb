Imports System.Data.SqlClient
Imports System.Configuration.ConfigurationManager
Imports System.IO

Public Class Pictures
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        lblProductCode.Text = Session.Item("ProductCode").ToString
        lblProductName.Text = Session("ProductDesc").ToString

        If Not Me.IsPostBack Then

            Dim tb As Table = New Table()
            tb.BorderWidth = 3
            tb.BorderStyle = BorderStyle.Solid
            tb.ID = "tableImages"


            Dim oConn As New SqlConnection
            oConn = ConnectSQL(AppSettings("ConnectionString"))

            Dim cmd As New SqlCommand
            'SELECT  Import_pk, Add_dts, Import_dts, FullPath, ProductCode, Type, Photo, version From dbo.Import_images
            cmd = New SqlClient.SqlCommand("SELECT * FROM Import_images where ProductCode = '" & Right(Session.Item("ProductCode").ToString, 4) & "'", oConn)
            Dim rdr As SqlClient.SqlDataReader
            rdr = cmd.ExecuteReader
            If rdr.HasRows Then
                While rdr.Read()

                    Dim tr As TableRow = New TableRow()

                    Dim tc1 As TableCell = New TableCell()
                    Dim tc2 As TableCell = New TableCell()
                    Dim tc3 As TableCell = New TableCell()


                    Dim tcCheckBoxes As TableCell = New TableCell()

                    Dim labelText As New Label
                    labelText.Text = "<b>&nbsp;&nbsp;" & Path.GetFileNameWithoutExtension(rdr("FullPath").ToString) & "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br /><br /><br /></b>"
                    tcCheckBoxes.Controls.Add(labelText)

                    Dim cb As CheckBox = New CheckBox()
                    cb.Text = "Primary Photo<br /><br />"
                    cb.ID = "Primary_" & rdr("Import_pk")
                    tcCheckBoxes.Controls.Add(cb)

                    Dim cb2 As CheckBox = New CheckBox()
                    cb2.Text = "Secondary Photo<br /><br />"
                    cb2.ID = "Secondary_" & rdr("Import_pk")
                    tcCheckBoxes.Controls.Add(cb2)

                    Dim cb3 As CheckBox = New CheckBox()
                    cb3.Text = "Box Weight Label<br /><br />"
                    cb3.ID = "BoxWeight_" & rdr("Import_pk")
                    tcCheckBoxes.Controls.Add(cb3)

                    Dim cb4 As CheckBox = New CheckBox()
                    cb4.Text = "Box Label<br /><br />"
                    cb4.ID = "BoxLabel_" & rdr("Import_pk")
                    tcCheckBoxes.Controls.Add(cb4)

                    Dim cb5 As CheckBox = New CheckBox()
                    cb5.Text = "Archive Photo"
                    cb5.ID = "ArchivePhoto_" & rdr("Import_pk")
                    tcCheckBoxes.Controls.Add(cb5)

                    tcCheckBoxes.BorderWidth = 2
                    tr.Cells.Add(tcCheckBoxes)



                    Dim currentImage As System.Web.UI.WebControls.Image = New System.Web.UI.WebControls.Image()
                    Dim bytes As Byte() = CType(rdr("Photo"), Byte())
                    Dim sBase64 As String = Convert.ToBase64String(bytes)
                    currentImage.ImageUrl = "data:Image/png;base64," & sBase64
                    currentImage.Height = 400
                    currentImage.Width = 600
                    tc1.Controls.Add(currentImage)
                    tc1.BorderWidth = 2
                    tr.Cells.Add(tc1)


                    tc2.Text = rdr("Import_pk")
                    tc2.BorderWidth = 2
                    tc2.Visible = False
                    tr.Cells.Add(tc2)
                    tr.VerticalAlign = VerticalAlign.Top

                    tb.Rows.Add(tr)
                End While
            End If

            Form.Controls.Add(tb)


            cmd.Dispose()
            oConn.Dispose()
        End If



    End Sub

    Protected Sub btnUpdateSelection_Click(sender As Object, e As EventArgs) Handles btnUpdateSelection.click


    End Sub




    'Protected Sub btnAddPrimaryImage_Click(sender As Object, e As EventArgs) Handles btnAddPrimaryImage.Click


    '    'Dim oConn As New SqlConnection
    '    'oConn = ConnectSQL(AppSettings("ConnectionString"))

    '    'Dim cmd As New SqlCommand
    '    'cmd = New SqlClient.SqlCommand("SELECT * FROM Import_images where ProductCode = '" & Session.Item("ProductCode").ToString & "'", oConn)
    '    'Dim rdr As SqlClient.SqlDataReader
    '    'rdr = cmd.ExecuteReader
    '    'If rdr.HasRows Then
    '    '    While rdr.Read()
    '    '        ' lstSearchResults.Items.Add(rdr("ProductCode") & " - " & rdr("Product Description"))
    '    '    End While
    '    'End If

    '    'cmd.Dispose()
    '    'oConn.Dispose()

    'End Sub





    Public Shared Function ConnectSQL(db As String) As SqlConnection

        Dim myConn As SqlConnection
        myConn = New SqlConnection(db)
        myConn.Open()
        Return myConn

    End Function
End Class