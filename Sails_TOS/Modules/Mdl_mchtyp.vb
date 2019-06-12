Module Mdl_mchtyp
    Function fc_mchtyp_getdata(ByVal apiAddress As String, Optional apiCondition As String = Nothing) As DataTable
        Dim sCol As New Dictionary(Of String, String)
        sCol.Add("MCH_TYPE_CODE", "")
        sCol.Add("MCH_TYPE_NAME", "")
        Dim dt As DataTable = getDataFromAPI(apiAddress, "rts_mchtyp_getdata", sCol, apiCondition)
        Return dt
    End Function

    Function fc_mchtyp_savedata(ByVal code As String, ByVal desc As String) As Boolean
        Dim ret As Boolean = postDataToAPI(pubApiAddress, "rts_mchtyp_savedata", "kode=" & code & "&nama=" & desc)
        Return ret
    End Function

    Function fc_mchtyp_upddata(ByVal code As String, ByVal desc As String) As Boolean
        Dim ret As Boolean = postDataToAPI(pubApiAddress, "rts_mchtyp_upddata", "kode=" & code & "&nama=" & desc)
        Return ret
    End Function

    Function fc_mchtyp_deldata(ByVal code As String) As Boolean
        Dim ret As Boolean = postDataToAPI(pubApiAddress, "rts_mchtyp_deldata", "kode=" & code)
        Return ret
    End Function
End Module
