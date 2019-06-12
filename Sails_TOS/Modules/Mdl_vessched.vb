Module Mdl_vessched
    Public Function fc_vessched_getdata(ByVal apiAddress As String, Optional apiCondition As String = Nothing) As DataTable
        Dim sCol As New Dictionary(Of String, String)
        Dim dt As DataTable = getDataFromAPI(apiAddress, "rts_vessched_getdata", sCol, apiCondition)
        Return dt
    End Function
End Module
