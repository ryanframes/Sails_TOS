Module Mdl_mchlne
    Function fc_mchlne_getdata(ByVal apiAddress As String, Optional apiCondition As String = Nothing) As DataTable
        Dim sCol As New Dictionary(Of String, String)
        sCol.Add("MCH_CODE", "")
        sCol.Add("MCH_TYPE_CODE", "")
        sCol.Add("LANE", "")
        Dim dt As DataTable = getDataFromAPI(apiAddress, "rts_mchlne_getdata", sCol, apiCondition)
        Return dt
    End Function

    Function fc_mchlne_upddata(ByVal params As Dictionary(Of String, String)) As Boolean
        Dim v_param As String = ""
        For Each k As KeyValuePair(Of String, String) In params
            v_param = v_param & IIf(v_param = "", "", "&") & String.Concat(k.Key, "=", Uri.EscapeDataString(k.Value))
        Next
        Dim ret As Boolean = postDataToAPI(pubApiAddress, "rts_mchlne_upddata", v_param)
        Return ret
    End Function

End Module
