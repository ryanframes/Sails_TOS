Module Mdl_jobctr
    Function fc_jobctr_getdata(ByVal apiAddress As String, Optional apiCondition As String = Nothing) As DataTable
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
        sCol.Add("LANE", "")
        sCol.Add("MCH_TYPE_NAME", "")
        sCol.Add("MCH_TYPE_AREA", "")
        sCol.Add("POOL_NAME", "")
        sCol.Add("ID_VVD", "")
        sCol.Add("STATUS", "")
        Dim dt As DataTable = getDataFromAPI(apiAddress, "rts_jobctr_getdata", sCol, apiCondition)
        Return dt
    End Function

    Function fc_jobctr_getpool(ByVal apiAddress As String, Optional apiCondition As String = Nothing) As DataTable
        Dim sCol As New Dictionary(Of String, String)
        sCol.Add("POOL_ID", "")
        sCol.Add("POOL_NAME", "")
        Dim dt As DataTable = getDataFromAPI(apiAddress, "rts_jobctr_getpool", sCol, apiCondition)
        Return dt
    End Function

    Function fc_jobctr_savedata(ByVal params As Dictionary(Of String, String)) As Boolean
        Dim v_param As String = ""
        For Each k As KeyValuePair(Of String, String) In params
            v_param = v_param & IIf(v_param = "", "", "&") & String.Concat(k.Key, "=", Uri.EscapeDataString(k.Value))
        Next
        Dim ret As Boolean = postDataToAPI(pubApiAddress, "rts_jobctr_savedata", v_param)
        Return ret
    End Function

End Module
