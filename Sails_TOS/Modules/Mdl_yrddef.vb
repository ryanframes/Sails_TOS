Module Mdl_yrddef
    Function fc_yrddef_getblock(ByVal apiAddress As String, Optional apiCondition As String = Nothing) As DataTable
        Dim sCol As New Dictionary(Of String, String)
        sCol.Add("ID_BLOCK", "")
        sCol.Add("BLOCK_NAME", "Block Name")
        sCol.Add("BLOCK_TYPE", "Type")
        sCol.Add("MAX_ROW", "Max Row")
        sCol.Add("MAX_TIER", "Max Tier")
        sCol.Add("AVB_TIER", "Available Tier")
        sCol.Add("POS_X", "Pos X")
        sCol.Add("POS_Y", "Pos Y")
        sCol.Add("DESIGN_CAPACITY", "Design Capacity")
        sCol.Add("AVB_CAPACITY", "Available Capacity")
        sCol.Add("STACK_DIRECTION", "Stack Direction")
        sCol.Add("ROW_DIRECTION", "Row Direction")
        sCol.Add("USE_FLAG", "Status")
        Dim dt As DataTable = getDataFromAPI(apiAddress, "rts_yrddef_getblock", sCol, apiCondition)
        Return dt
    End Function

    Function fc_yrddef_saveblock(ByVal params As Dictionary(Of String, String)) As Boolean
        Dim v_param As String = ""
        For Each k As KeyValuePair(Of String, String) In params
            v_param = v_param & IIf(v_param = "", "", "&") & String.Concat(k.Key, "=", k.Value)
        Next
        Dim ret As Boolean = postDataToAPI(pubApiAddress, "rts_yrddef_saveblock", v_param)
        Return ret
    End Function

    Function fc_yrddef_updblock(ByVal params As Dictionary(Of String, String)) As Boolean
        Dim v_param As String = ""
        For Each k As KeyValuePair(Of String, String) In params
            v_param = v_param & IIf(v_param = "", "", "&") & String.Concat(k.Key, "=", k.Value)
        Next
        Dim ret As Boolean = postDataToAPI(pubApiAddress, "rts_yrddef_updblock", v_param)
        Return ret
    End Function

    Function fc_yrddef_delblock(ByVal blockId As Integer) As Boolean
        Dim ret As Boolean = postDataToAPI(pubApiAddress, "rts_yrddef_delblock", "ID_BLOCK=" & blockId)
        Return ret
    End Function

    Function fc_yrddef_delblock_validation(ByVal blockID As Integer) As Integer
        Dim s As New Dictionary(Of String, String)
        s.Add("jml", "")
        'get jml cell tier yang status =1
        Dim dt As DataTable = getDataFromAPI(pubApiAddress, "rts_yrddef_delblock_validation", s, "ID_BLOCK=" & blockID)
        Dim ret As Boolean
        ret = dt.Rows(0)(0) = 0
        Return ret
    End Function

    Function fc_yrddef_getslot(ByVal apiAddress As String, Optional apiCondition As String = Nothing) As DataTable
        Dim sCol As New Dictionary(Of String, String)
        sCol.Add("ID_CELL", "")
        sCol.Add("BLOCK_NAME", "")
        sCol.Add("ID_STACK", "")
        sCol.Add("20_STACKNAME", "")
        sCol.Add("40_STACKNAME", "")
        sCol.Add("SIZE_TYPE", "")
        sCol.Add("CARGO_TYPE", "")
        sCol.Add("USE_FLAG", "")
        Dim dt As DataTable = getDataFromAPI(apiAddress, "rts_yrddef_getslot", sCol, apiCondition)
        Return dt
    End Function

    Function fc_yrddef_saveslot(ByVal params As Dictionary(Of String, String)) As Boolean
        Dim v_param As String = ""
        For Each k As KeyValuePair(Of String, String) In params
            v_param = v_param & IIf(v_param = "", "", "&") & String.Concat(k.Key, "=", k.Value)
        Next
        Dim ret As Boolean = postDataToAPI(pubApiAddress, "rts_yrddef_saveslot", v_param)
        Return ret
    End Function

    Function fc_yrddef_updslot(ByVal params As Dictionary(Of String, String)) As Boolean
        Dim v_param As String = ""
        For Each k As KeyValuePair(Of String, String) In params
            v_param = v_param & IIf(v_param = "", "", "&") & String.Concat(k.Key, "=", k.Value)
        Next
        Dim ret As Boolean = postDataToAPI(pubApiAddress, "rts_yrddef_updslot", v_param)
        Return ret
    End Function

    Function fc_yrddef_delslot(ByVal slotID As Integer) As Boolean
        Dim ret As Boolean = postDataToAPI(pubApiAddress, "rts_yrddef_delslot", "ID_CELL=" & slotID)
        Return ret
    End Function

    Function fc_yrddef_delslot_validation(ByVal slotID As Integer) As Integer
        Dim s As New Dictionary(Of String, String)
        s.Add("jml", "")
        'get jml cell tier yang status =1
        Dim dt As DataTable = getDataFromAPI(pubApiAddress, "rts_yrddef_delslot_validation", s, "ID_CELL=" & slotID)
        Dim ret As Boolean
        ret = dt.Rows(0)(0) = 0
        Return ret
    End Function
End Module
