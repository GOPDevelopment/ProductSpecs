Imports System.Data.SqlClient
Imports System.Configuration.ConfigurationManager
Imports System.IO

Public Class Pictures
    Inherits System.Web.UI.Page
    'Public checkBoxListPrimary As List(Of CheckBox)
    'Public checkBoxListSecondary As List(Of CheckBox)
    'Public checkBoxListBoxLabelWeight As List(Of CheckBox)
    'Public checkBoxListBoxLabel As List(Of CheckBox)

    'Private checkboxes As New List(Of CheckBox)

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        lblProductCode.Text = Session.Item("ProductCode").ToString
        lblProductName.Text = Session("ProductDesc").ToString

        If Not Me.IsPostBack Then
            'CreateImageTable()
            FillImageTable



        End If


    End Sub
    Private Sub FillImageTable()

        Dim primary_photo As Integer
        Dim secondary_photo As Integer
        Dim box_wght_Label_photo As Integer
        Dim Box_label_photo As Integer

        Dim oConn As New SqlConnection
        oConn = ConnectSQL(AppSettings("ConnectionString"))
        Dim cmd As New SqlCommand
        Dim rdr As SqlClient.SqlDataReader

        cmd = New SqlClient.SqlCommand("SELECT * FROM ProductInfo where ProductCode = '" & Session("ProductCode") & "'", oConn)
        rdr = cmd.ExecuteReader
        If rdr.HasRows Then
            While rdr.Read()
                'setting these so they can be manipulated outside the db conn
                primary_photo = FixNullInteger(rdr("primary_photo"))
                secondary_photo = FixNullInteger(rdr("secondary_photo"))
                box_wght_Label_photo = FixNullInteger(rdr("box_wght_Label_photo"))
                Box_label_photo = FixNullInteger(rdr("Box_label_photo"))
            End While
        End If
        rdr.Close()
        cmd.Dispose()

        Dim iCount As Integer = 0
        cmd = New SqlClient.SqlCommand("SELECT * FROM Import_images where ProductCode = '" & Right(Session.Item("ProductCode").ToString, 4) & "' and archive = 0", oConn)
        rdr = cmd.ExecuteReader
        If rdr.HasRows Then
            While rdr.Read()
                iCount += 1

                Dim tempLabel As Label = FindLabelWithText("l" & iCount)
                tempLabel.Text = "<b>&nbsp;&nbsp;" & Path.GetFileNameWithoutExtension(rdr("FullPath").ToString) & "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br /><br /><br /></b>"

                Dim tempCheck As CheckBox = FindCheckBoxWithText("primary" & iCount)
                tempCheck.ToolTip = "Primary_" & rdr("Import_pk")
                If primary_photo = rdr("Import_pk") Then
                    tempCheck.Checked = True
                End If

                tempCheck = FindCheckBoxWithText("secondary" & iCount)
                tempCheck.ToolTip = "Secondary_" & rdr("Import_pk")
                If secondary_photo = rdr("Import_pk") Then
                    tempCheck.Checked = True
                End If

                tempCheck = FindCheckBoxWithText("boxweightlabel" & iCount)
                tempCheck.ToolTip = "BoxWeight_" & rdr("Import_pk")
                If box_wght_Label_photo = rdr("Import_pk") Then
                    tempCheck.Checked = True
                End If

                tempCheck = FindCheckBoxWithText("boxlabel" & iCount)
                tempCheck.ToolTip = "BoxLabel_" & rdr("Import_pk")
                If Box_label_photo = rdr("Import_pk") Then
                    tempCheck.Checked = True
                End If

                tempCheck = FindCheckBoxWithText("additional" & iCount)
                tempCheck.ToolTip = "Additional_" & rdr("Import_pk")
                If Box_label_photo = rdr("Import_pk") Then
                    tempCheck.Checked = True
                End If

                tempCheck = FindCheckBoxWithText("archive" & iCount)
                tempCheck.ToolTip = "ArchivePhoto_" & rdr("Import_pk")

                Dim currentImage As System.Web.UI.WebControls.Image = New System.Web.UI.WebControls.Image()
                Dim bytes As Byte() = CType(rdr("Photo"), Byte())
                Dim sBase64 As String = Convert.ToBase64String(bytes)
                currentImage = FindImageControlWithText("image" & iCount)
                currentImage.ImageUrl = "data:Image/png;base64," & sBase64
                currentImage.Height = 400
                currentImage.Width = 600
                'image1.Controls.Add(currentImage)


            End While
        End If

        cmd.Dispose()
        oConn.Dispose()


        'set the rest to visible = false
        For i = iCount + 1 To 50
            Dim tempRow As TableRow = FindTableRowWithText("tr" & i)
            tempRow.Visible = False
        Next


    End Sub

    Private Function FindTextBoxlWithText(stringText As String) As TextBox

        Dim textboxControl As TextBox = DirectCast(FindControl(stringText), TextBox)

        If textboxControl IsNot Nothing Then
        Else
        End If

        Return textboxControl

    End Function
    Private Function FindLabelWithText(stringText As String) As Label

        Dim labelControl As Label = DirectCast(FindControl(stringText), Label)

        If labelControl IsNot Nothing Then
        Else
        End If

        Return labelControl

    End Function
    Private Function FindCheckBoxWithText(stringText As String) As CheckBox

        Dim checkboxControl As CheckBox = DirectCast(FindControl(stringText), CheckBox)

        If checkboxControl IsNot Nothing Then
        Else
        End If

        Return checkboxControl

    End Function
    Private Function FindImageControlWithText(stringText As String) As Image

        Dim imageControl As Image = DirectCast(FindControl(stringText), Image)

        If imageControl IsNot Nothing Then
        Else
        End If

        Return imageControl

    End Function
    Private Function FindTableRowWithText(stringText As String) As TableRow

        Dim tablerowControl As TableRow = DirectCast(FindControl(stringText), TableRow)

        If tablerowControl IsNot Nothing Then
        Else
        End If

        Return tablerowControl

    End Function
    Protected Sub UploadFile(sender As Object, e As EventArgs)
        Dim folderPath As String = Server.MapPath("~/Files/")
        Dim newFileName As String = ""

        'Check whether Directory (Folder) exists.
        If Not Directory.Exists(folderPath) Then
            'If Directory (Folder) does not exists. Create it.
            Directory.CreateDirectory(folderPath)
        End If

        'update filename to contain product code and date to make it unique
        newFileName = Session("ProductCode") & "_" & DateTime.Now.ToString("yyyyMMddHHmmss") & "_" & RemoveIllegalFileNameChars(Path.GetFileName(FileUpload1.FileName))

        'Save the File to the Directory (Folder).
        'FileUpload1.SaveAs(folderPath & Path.GetFileName(FileUpload1.FileName))
        FileUpload1.SaveAs(folderPath & newFileName)

        'attach filename to import_images db



        'Display the success message.
        lblMessage.Text = Path.GetFileName(FileUpload1.FileName) + " has been uploaded (as " & newFileName & ")"


    End Sub
    Private Sub FindCheckBoxes(controls As ControlCollection)
        For Each control As Control In controls
            If TypeOf control Is CheckBox Then
                Dim checkbox As CheckBox = DirectCast(control, CheckBox)
                If checkbox.Checked Then
                    ' Checkbox is checked
                    'Dim checkboxText As String = checkbox.Text
                    Dim checkboxID As String = checkbox.ID
                    Dim checkboxToolTip As String = checkbox.ToolTip

                    ' Do something with the checkbox value
                Else
                    ' Checkbox is not checked
                End If
            ElseIf control.Controls.Count > 0 Then
                ' Recursively search for checkboxes in child controls
                FindCheckBoxes(control.Controls)
            End If
        Next
    End Sub

    'Protected Sub btnUpdateSelection_Click(sender As Object, e As EventArgs) Handles btnUpdateSelection.Click
    Protected Sub btnUpdateSelection_Click()

        'FindCheckBoxes(Page.Controls)
        'FindCheckBoxes(Me.Controls)


        Dim primary_photo As Integer = 0
        Dim secondary_photo As Integer = 0
        Dim box_wght_Label_photo As Integer = 0
        Dim Box_label_photo As Integer = 0
        Dim archive_photo As New List(Of Integer)
        Dim additional_photos As New List(Of Integer)
        Dim errorText As String = ""


        For iCount = 1 To 50

            Dim tempCheck As CheckBox = FindCheckBoxWithText("primary" & iCount)
            If tempCheck.Checked Then
                If primary_photo = 0 Then
                    primary_photo = tempCheck.ToolTip.Replace("Primary_", "") '= "Primary_" & rdr("Import_pk")
                Else
                    errorText = errorText & "<br />" & "Only one Primary Photo can be selected."
                End If

            End If

            tempCheck = FindCheckBoxWithText("secondary" & iCount)
            If tempCheck.Checked Then
                If secondary_photo = 0 Then
                    secondary_photo = tempCheck.ToolTip.Replace("Secondary_", "") '= "Secondary_" & rdr("Import_pk")
                Else
                    errorText = errorText & "<br />" & "Only one Secondary Photo can be selected."
                End If
            End If

            tempCheck = FindCheckBoxWithText("boxweightlabel" & iCount)
            If tempCheck.Checked Then
                If box_wght_Label_photo = 0 Then
                    box_wght_Label_photo = tempCheck.ToolTip.Replace("BoxWeight_", "") '= "BoxWeight_" & rdr("Import_pk")
                Else
                    errorText = errorText & "<br />" & "Only one Box Weight Photo can be selected."
                End If
            End If

            tempCheck = FindCheckBoxWithText("boxlabel" & iCount)
            If tempCheck.Checked Then
                If Box_label_photo = 0 Then
                    Box_label_photo = tempCheck.ToolTip.Replace("BoxLabel_", "") '= "BoxLabel_" & rdr("Import_pk")
                Else
                    errorText = errorText & "<br />" & "Only one Box Label Photo can be selected."
                End If
            End If

            tempCheck = FindCheckBoxWithText("additional" & iCount)
            If tempCheck.Checked Then
                additional_photos.Add(tempCheck.ToolTip.Replace("Additional_", "")) '= "Additional_" & rdr("Import_pk")
            End If

            tempCheck = FindCheckBoxWithText("archive" & iCount)
            If tempCheck.Checked Then
                archive_photo.Add(tempCheck.ToolTip.Replace("ArchivePhoto_", ""))   ' = "ArchivePhoto_" & rdr("Import_pk")
            End If
        Next




        Dim oConn As New SqlConnection
        oConn = ConnectSQL(AppSettings("ConnectionString"))
        Dim cmd As New SqlCommand
        Dim sSql As String



        'update primary, secondary, box weight and box label photos
        sSql = "UPDATE dbo.ProductInfo
                SET primary_photo = @primary_photo, secondary_photo = @secondary_photo, 
                box_wght_Label_photo = @box_wght_Label_photo, Box_label_photo = @Box_label_photo
                WHERE (ProductCode = '" & Session("ProductCode") & "')"
        cmd = New SqlClient.SqlCommand(sSql, oConn)
        cmd.Parameters.AddWithValue("@primary_photo", primary_photo)
        cmd.Parameters.AddWithValue("@secondary_photo", secondary_photo)
        cmd.Parameters.AddWithValue("@box_wght_Label_photo", box_wght_Label_photo)
        cmd.Parameters.AddWithValue("@Box_label_photo", Box_label_photo)
        cmd.ExecuteNonQuery()
        cmd.Dispose()


        'update archived photos
        If archive_photo.Count > 0 Then
            Dim sArchive As String = ""
            For i = 0 To archive_photo.Count
                sArchive = sArchive & archive_photo(i).ToString & ","
            Next

            sSql = "Update dbo.Import_images SET Archive = 'True' where Import_pk in (" & sArchive & "0)"
            'trust, that end 0 needs to be there to accommodate for the last , in the created string
            cmd = New SqlClient.SqlCommand(sSql, oConn)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        End If


        'add and update additional photo store
        If additional_photos.Count > 0 Then
            Dim sAdditional As String = ""
            'delete from additional
            sSql = "DELETE FROM dbo.Images_Additional WHERE Product_Code = '" & Session("ProductCode") & "'"
            cmd = New SqlClient.SqlCommand(sSql, oConn)
            cmd.ExecuteNonQuery()
            cmd.Dispose()

            'add to additional
            sSql = "INSERT INTO dbo.Images_Additional  (product_code, image_import_pk) VALUES "
            For i = 0 To additional_photos.Count - 1
                sSql = sSql & "('" & Session("ProductCode") & "','" & additional_photos(i) & "')"
                If i < additional_photos.Count - 1 Then
                    sSql = sSql & ","
                End If
            Next
            cmd = New SqlClient.SqlCommand(sSql, oConn)
            cmd.ExecuteNonQuery()
            cmd.Dispose()

        End If


        oConn.Close()

    End Sub




    Protected Sub CreateImageTable()

        ''checkBoxListPrimary = New List(Of CheckBox)
        ''checkBoxListSecondary = New List(Of CheckBox)
        ''checkBoxListBoxLabelWeight = New List(Of CheckBox)
        ''checkBoxListBoxLabel = New List(Of CheckBox)

        'Dim primary_photo As Integer
        'Dim secondary_photo As Integer
        'Dim box_wght_Label_photo As Integer
        'Dim Box_label_photo As Integer

        'Dim oConn As New SqlConnection
        'oConn = ConnectSQL(AppSettings("ConnectionString"))
        'Dim cmd As New SqlCommand
        'Dim rdr As SqlClient.SqlDataReader

        'cmd = New SqlClient.SqlCommand("SELECT * FROM ProductInfo where ProductCode = '" & Session("ProductCode") & "'", oConn)
        'rdr = cmd.ExecuteReader
        'If rdr.HasRows Then
        '    While rdr.Read()
        '        'setting these so they can be manipulated outside the db conn
        '        primary_photo = FixNullInteger(rdr("primary_photo"))
        '        secondary_photo = FixNullInteger(rdr("secondary_photo"))
        '        box_wght_Label_photo = FixNullInteger(rdr("box_wght_Label_photo"))
        '        Box_label_photo = FixNullInteger(rdr("Box_label_photo"))
        '    End While
        'End If
        'rdr.Close()
        'cmd.Dispose()


        'Dim tb As Table = New Table()
        'tb.BorderWidth = 3
        'tb.BorderStyle = BorderStyle.Solid
        'tb.ID = "tableImages"


        ''SELECT  Import_pk, Add_dts, Import_dts, FullPath, ProductCode, Type, Photo, version From dbo.Import_images
        'cmd = New SqlClient.SqlCommand("SELECT * FROM Import_images where ProductCode = '" & Right(Session.Item("ProductCode").ToString, 4) & "' and archive = 0", oConn)
        'rdr = cmd.ExecuteReader
        'If rdr.HasRows Then
        '    While rdr.Read()

        '        Dim tr As TableRow = New TableRow()

        '        Dim tc1 As TableCell = New TableCell()
        '        Dim tc2 As TableCell = New TableCell()
        '        Dim tc3 As TableCell = New TableCell()


        '        Dim tcCheckBoxes As TableCell = New TableCell()

        '        Dim labelText As New Label
        '        labelText.Text = "<b>&nbsp;&nbsp;" & Path.GetFileNameWithoutExtension(rdr("FullPath").ToString) & "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br /><br /><br /></b>"
        '        tcCheckBoxes.Controls.Add(labelText)

        '        Dim cb As CheckBox = New CheckBox()
        '        cb.Text = "Primary Photo<br /><br />"
        '        cb.ID = "Primary_" & rdr("Import_pk")
        '        If primary_photo = rdr("Import_pk") Then
        '            cb.Checked = True
        '        End If
        '        tcCheckBoxes.Controls.Add(cb)
        '        'checkBoxListPrimary.Add(cb)

        '        Dim cb2 As CheckBox = New CheckBox()
        '        cb2.Text = "Secondary Photo<br /><br />"
        '        cb2.ID = "Secondary_" & rdr("Import_pk")
        '        If secondary_photo = rdr("Import_pk") Then
        '            cb2.Checked = True
        '        End If
        '        tcCheckBoxes.Controls.Add(cb2)
        '        'checkBoxListSecondary.Add(cb2)

        '        Dim cb3 As CheckBox = New CheckBox()
        '        cb3.Text = "Box Weight Label<br /><br />"
        '        cb3.ID = "BoxWeight_" & rdr("Import_pk")
        '        If box_wght_Label_photo = rdr("Import_pk") Then
        '            cb3.Checked = True
        '        End If
        '        tcCheckBoxes.Controls.Add(cb3)
        '        'checkBoxListBoxLabelWeight.Add(cb3)

        '        Dim cb4 As CheckBox = New CheckBox()
        '        cb4.Text = "Box Label<br /><br />"
        '        cb4.ID = "BoxLabel_" & rdr("Import_pk")
        '        If Box_label_photo = rdr("Import_pk") Then
        '            cb4.Checked = True
        '        End If
        '        tcCheckBoxes.Controls.Add(cb4)
        '        'checkBoxListBoxLabel.Add(cb4)

        '        Dim cb5 As CheckBox = New CheckBox()
        '        cb5.Text = "Archive Photo"
        '        cb5.ID = "ArchivePhoto_" & rdr("Import_pk")
        '        tcCheckBoxes.Controls.Add(cb5)

        '        tcCheckBoxes.BorderWidth = 2
        '        tr.Cells.Add(tcCheckBoxes)



        '        Dim currentImage As System.Web.UI.WebControls.Image = New System.Web.UI.WebControls.Image()
        '        Dim bytes As Byte() = CType(rdr("Photo"), Byte())
        '        Dim sBase64 As String = Convert.ToBase64String(bytes)
        '        currentImage.ImageUrl = "data:Image/png;base64," & sBase64
        '        currentImage.Height = 400
        '        currentImage.Width = 600
        '        tc1.Controls.Add(currentImage)
        '        tc1.BorderWidth = 2
        '        tr.Cells.Add(tc1)


        '        tc2.Text = rdr("Import_pk")
        '        tc2.BorderWidth = 2
        '        tc2.Visible = False
        '        tr.Cells.Add(tc2)
        '        tr.VerticalAlign = VerticalAlign.Top

        '        tb.Rows.Add(tr)
        '    End While
        'End If

        'form1.Controls.Add(tb)



        'cmd.Dispose()
        'oConn.Dispose()
    End Sub
    Public Shared Function ConnectSQL(db As String) As SqlConnection

        Dim myConn As SqlConnection
        myConn = New SqlConnection(db)
        myConn.Open()
        Return myConn

    End Function

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

    'Private Sub CreateCheckBoxes(count As Integer)
    '    For i As Integer = 1 To count
    '        Dim checkbox As New CheckBox()
    '        checkbox.Text = "Checkbox " & i.ToString()
    '        'checkbox.Top = i * 20
    '        'checkbox.Left = 20

    '        ' Add the checkbox to the form and the list
    '        Me.Controls.Add(checkbox)
    '        checkboxes.Add(checkbox)
    '    Next
    'End Sub

    'Private Sub CheckCheckbox(index As Integer)
    '    If index >= 0 AndAlso index < checkboxes.Count Then
    '        checkboxes(index).Checked = True
    '    End If
    'End Sub

    'Public Shared Function FindChildControl(start As Control, id As String) As Control
    '    If start IsNot Nothing Then
    '        Dim foundControl As Control
    '        foundControl = start.FindControl(id)

    '        If foundControl IsNot Nothing Then
    '            Return foundControl
    '        End If

    '        For Each c As Control In start.Controls
    '            foundControl = FindChildControl(c, id)
    '            If foundControl IsNot Nothing Then
    '                Return foundControl
    '            End If
    '        Next
    '    End If
    '    Return Nothing
    'End Function


End Class