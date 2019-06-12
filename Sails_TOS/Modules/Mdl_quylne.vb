Module Mdl_quylne
    Function fc_quylne_getdata(ByVal apiAddress As String, Optional apiCondition As String = Nothing) As DataTable
        Dim sCol As New Dictionary(Of String, String)
        sCol.Add("ID_QUAY_LANE", "")
        sCol.Add("QUAY_DESC", "")
        Dim dt As DataTable = getDataFromAPI(apiAddress, "rts_quylne_getdata", sCol, apiCondition)
        Return dt
    End Function
End Module
