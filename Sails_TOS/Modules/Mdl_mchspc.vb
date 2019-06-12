Module Mdl_mchspc
    Function fc_mchspc_getdata(ByVal apiAddress As String, Optional apiCondition As String = Nothing) As DataTable
        Dim sCol As New Dictionary(Of String, String)
        sCol.Add("MCH_CODE", "")
        sCol.Add("MCH_TYPE_CODE", "")
        sCol.Add("HEIGHT", "")
        sCol.Add("CAPACITY", "")
        sCol.Add("COLOR_B", "")
        sCol.Add("COLOR_F", "")
        sCol.Add("ON_OFF", "")
        sCol.Add("FROM_COVERAGE", "")
        sCol.Add("TO_COVERAGE", "")
        sCol.Add("FROM_COV2", "")
        sCol.Add("TO_COV2", "")
        sCol.Add("POOL_ID", "")
        Dim dt As DataTable = getDataFromAPI(apiAddress, "rts_mchspc_getdata", sCol, apiCondition)
        Return dt
    End Function

    Function fc_mchspc_savedata(ByVal params As Dictionary(Of String, String)) As Boolean
        Dim v_param As String = ""
        For Each k As KeyValuePair(Of String, String) In params
            v_param = v_param & IIf(v_param = "", "", "&") & String.Concat(k.Key, "=", Uri.EscapeDataString(k.Value))
        Next
        Dim ret As Boolean = postDataToAPI(pubApiAddress, "rts_mchspc_savedata", v_param)
        Return ret
    End Function

    Function fc_mchspc_upddata(ByVal params As Dictionary(Of String, String)) As Boolean
        Dim v_param As String = ""
        For Each k As KeyValuePair(Of String, String) In params
            v_param = v_param & IIf(v_param = "", "", "&") & String.Concat(k.Key, "=", Uri.EscapeDataString(k.Value))
        Next
        Dim ret As Boolean = postDataToAPI(pubApiAddress, "rts_mchspc_upddata", v_param)
        Return ret
    End Function

    Function fc_mchspc_deldata(ByVal code As String) As Boolean
        Dim ret As Boolean = postDataToAPI(pubApiAddress, "rts_mchspc_deldata", "kode=" & code)
        Return ret
    End Function
End Module
