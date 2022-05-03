Public Class SiteMaster
    Inherits MasterPage
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load


        'Dim sPath As String = Request.PhysicalPath
        'LastModified.Text = "Last modified: " + System.IO.File.GetLastWriteTime(sPath).ToString()
    End Sub
End Class