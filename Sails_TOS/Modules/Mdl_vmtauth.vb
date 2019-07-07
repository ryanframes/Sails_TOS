Module Mdl_vmtauth
    Function fc_vmtauth_getuser(ByVal apiAddress As String, Optional apiCondition As String = Nothing) As DataTable
        Dim sCol As New Dictionary(Of String, String)
        Dim dt As DataTable = getDataFromAPI(apiAddress, "rts_vmtauth_getuser", sCol, apiCondition)
        Return dt
    End Function

    Function fc_vmtauth_getmchtype(ByVal apiAddress As String, Optional apiCondition As String = Nothing) As DataTable
        Dim sCol As New Dictionary(Of String, String)
        Dim dt As DataTable = getDataFromAPI(apiAddress, "rts_vmtauth_getmchtype", sCol, apiCondition)
        Return dt
    End Function

    Function fc_vmtauth_getmch(ByVal apiAddress As String, Optional apiCondition As String = Nothing) As DataTable
        Dim sCol As New Dictionary(Of String, String)
        Dim dt As DataTable = getDataFromAPI(apiAddress, "rts_vmtauth_getmch", sCol, apiCondition)
        Return dt
    End Function

    Function fc_vmtauth_getteam(ByVal apiAddress As String, Optional apiCondition As String = Nothing) As DataTable
        Dim sCol As New Dictionary(Of String, String)
        Dim dt As DataTable = getDataFromAPI(apiAddress, "rts_vmtauth_getteam", sCol, apiCondition)
        Return dt
    End Function

    Function fc_vmtauth_login(ByVal mch_type As String, ByVal user As String, ByVal mch_name As String) As Boolean
        If mch_type = "ITV" Then
            Dim frm As New FormITV
            frm.lbl_user.Text = user
            frm.Show()
        Else
            Dim frm As New FormVMT
            frm.PubUser = user
            frm.PubMch = mch_name
            frm.Show()
        End If
        Return True
    End Function

    Function fc_vmtauth_logout(ByVal frm As DevComponents.DotNetBar.Metro.MetroForm) As Boolean
        frm.Close()
        Return True
    End Function
End Module
