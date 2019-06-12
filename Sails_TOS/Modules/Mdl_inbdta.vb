Module Mdl_inbdta
    Public Function fc_inbdta_getdata(ByVal apiAddress As String, Optional apiCondition As String = Nothing) As DataTable
        Dim sCol As New Dictionary(Of String, String)
        sCol.Add("ID_CONT_DATA", "")
        sCol.Add("ID_VVD", "")
        sCol.Add("NO_CONT", "No. Container")
        sCol.Add("STW_PLAN", "Stowage")
        sCol.Add("LOCATION_PLAN", "Location")
        sCol.Add("ISO", "ISO")
        sCol.Add("CLASS_DESC", "Class")
        sCol.Add("OPERATOR", "Operator")
        sCol.Add("ISO_SIZE", "Size")
        sCol.Add("CONT_TYPE", "CONT_TYPE")
        sCol.Add("TYPE_DESC", "Type")
        sCol.Add("HEIGHT", "Height")
        sCol.Add("FM", "F/M")
        sCol.Add("VGM", "")
        sCol.Add("COMMODITY", "Commodity")
        sCol.Add("POL", "POL")
        sCol.Add("POD", "POD")
        sCol.Add("POR", "POR")
        sCol.Add("WEIGHT", "Weight (Ton)")
        sCol.Add("TEMP", "Temp (C)")
        sCol.Add("IMDG", "")
        sCol.Add("UNNO", "")
        sCol.Add("OVER_FRONT", "OD-F")
        sCol.Add("OVER_BACK", "OD-B")
        sCol.Add("OVER_LEFT", "OD-L")
        sCol.Add("OVER_RIGHT", "OD-R")
        sCol.Add("OVER_TOP", "OD-T")

        Dim dt As DataTable = getDataFromAPI(apiAddress, "rts_inbdta_getdata", sCol, apiCondition)
        Return dt
    End Function

    Public Function fc_inbdta_getsize(ByVal apiAddress As String, Optional apiCondition As String = Nothing) As DataTable
        Dim sCol As New Dictionary(Of String, String)
        sCol.Add("ID_SIZE_TYPE", "")
        sCol.Add("SIZE_TYPE", "")
        sCol.Add("DESCRIPTION", "")
        Dim dt As DataTable = getDataFromAPI(apiAddress, "rts_inbdta_getsize", sCol, apiCondition)
        Return dt
    End Function

    Public Function fc_inbdta_getclass(ByVal apiAddress As String, Optional apiCondition As String = Nothing) As DataTable
        Dim sCol As New Dictionary(Of String, String)
        sCol.Add("ID_CLASS", "")
        sCol.Add("CLASS_CODE", "")
        sCol.Add("DESCRIPTION", "")
        sCol.Add("STATUS_IO", "")
        Dim dt As DataTable = getDataFromAPI(apiAddress, "rts_inbdta_getclass", sCol, apiCondition)
        Return dt
    End Function

    Public Function fc_inbdta_getcontyp(ByVal apiAddress As String, Optional apiCondition As String = Nothing) As DataTable
        Dim sCol As New Dictionary(Of String, String)
        sCol.Add("ID_CONT_TYPE", "")
        sCol.Add("CONT_TYPE", "")
        sCol.Add("DESC", "")
        Dim dt As DataTable = getDataFromAPI(apiAddress, "rts_inbdta_getcontyp", sCol, apiCondition)
        Return dt
    End Function

    Public Function fc_inbdta_getiso(ByVal apiAddress As String, Optional apiCondition As String = Nothing) As DataTable
        Dim sCol As New Dictionary(Of String, String)
        sCol.Add("ID_ISO", "")
        sCol.Add("ISO_CODE", "")
        sCol.Add("SIZE", "")
        sCol.Add("HEIGHT", "")
        sCol.Add("CONT_TYPE", "")
        sCol.Add("COMMODITY", "")
        Dim dt As DataTable = getDataFromAPI(apiAddress, "rts_inbdta_getiso", sCol, apiCondition)
        Return dt
    End Function

    Public Function fc_inbdta_getport(ByVal apiAddress As String, Optional apiCondition As String = Nothing) As DataTable
        Dim sCol As New Dictionary(Of String, String)
        sCol.Add("PORT_CODE", "")
        Dim dt As DataTable = getDataFromAPI(apiAddress, "rts_inbdta_getport", sCol, apiCondition)
        Return dt
    End Function

    Public Function fc_inbdta_getopr(ByVal apiAddress As String, Optional apiCondition As String = Nothing) As DataTable
        Dim sCol As New Dictionary(Of String, String)
        sCol.Add("VES_SERVICE_CODE", "")
        sCol.Add("OP_CODE", "")
        sCol.Add("OP_NAME", "")
        Dim dt As DataTable = getDataFromAPI(apiAddress, "rts_inbdta_getopr", sCol, apiCondition)
        Return dt
    End Function

    Public Function fc_inbdta_getimdg(ByVal apiAddress As String, Optional apiCondition As String = Nothing) As DataTable
        Dim sCol As New Dictionary(Of String, String)
        sCol.Add("ID_IMDG", "")
        sCol.Add("IMDG_CODE", "")
        sCol.Add("DESC", "")
        Dim dt As DataTable = getDataFromAPI(apiAddress, "rts_inbdta_getimdg", sCol, apiCondition)
        Return dt
    End Function

    Public Function fc_inbdta_getunno(ByVal apiAddress As String, Optional apiCondition As String = Nothing) As DataTable
        Dim sCol As New Dictionary(Of String, String)
        sCol.Add("ID_UNNO", "")
        sCol.Add("IMDG_CODE", "")
        sCol.Add("UNNO_CODE", "")
        sCol.Add("DESC", "")
        Dim dt As DataTable = getDataFromAPI(apiAddress, "rts_inbdta_getunno", sCol, apiCondition)
        Return dt
    End Function

    Public Function fc_inbdta_getbay(ByVal apiAddress As String, Optional apiCondition As String = Nothing) As DataTable
        Dim sCol As New Dictionary(Of String, String)
        sCol.Add("ID_BAY_CELL", "")
        sCol.Add("ID_STW_SIZE", "")
        sCol.Add("BAY_NO", "")
        sCol.Add("ROW_NO", "")
        sCol.Add("TIER_NO", "")
        sCol.Add("CELL_STATUS", "")
        sCol.Add("CELL_REEFER_RACK", "")
        sCol.Add("CELL_45", "")
        sCol.Add("AVAIL_STATUS", "")
        sCol.Add("VES_CODE", "")
        sCol.Add("BAY_SIZE", "")
        sCol.Add("HATCH_NO", "")
        Dim dt As DataTable = getDataFromAPI(apiAddress, "rts_inbdta_getbay", sCol, apiCondition)
        Return dt
    End Function

    Function fc_inbdta_savedata(ByVal params As Dictionary(Of String, String)) As Boolean
        Dim v_param As String = ""
        For Each k As KeyValuePair(Of String, String) In params
            v_param = v_param & IIf(v_param = "", "", "&") & String.Concat(k.Key, "=", k.Value)
        Next

        Dim ret As Boolean = postDataToAPI(pubApiAddress, "rts_inbdta_savedata", v_param)
        Return ret
    End Function

    Function fc_inbdta_savedata_validation(ByVal v_id_vvd As String, v_no_cont As String, v_con_id As String, v_stowage As String) As Boolean
        Dim sCol As New Dictionary(Of String, String)
        sCol.Add("jml", "")
        Dim dt As DataTable = getDataFromAPI(pubApiAddress, "rts_inbdta_savedata_validation", sCol, "&no_cont=" & v_no_cont & "&id_vvd=" & v_id_vvd & "&con_id=" & v_con_id & "&stowage=" & v_stowage)
        Dim ret As Boolean
        If dt.Rows.Count > 0 Then
            ret = dt.Rows(0)("jml") = 0
        Else
            ret = False
        End If
        Return ret
    End Function

    Function fc_inbdta_upddata(ByVal params As Dictionary(Of String, String)) As Boolean
        Dim v_param As String = ""
        For Each k As KeyValuePair(Of String, String) In params
            v_param = v_param & IIf(v_param = "", "", "&") & String.Concat(k.Key, "=", k.Value)
        Next

        Dim ret As Boolean = postDataToAPI(pubApiAddress, "rts_inbdta_upddta", v_param)
        Return ret
    End Function

    Function fc_inbdta_deldata(ByVal conID As Integer) As Boolean
        Dim ret As Boolean = postDataToAPI(pubApiAddress, "rts_inbdta_deldata", "id=" & conID)
        Return ret
    End Function

    Function fc_inbdta_deldata_validation(ByVal v_id_vvd As String, v_no_cont As String) As Boolean
        Dim sCol As New Dictionary(Of String, String)
        sCol.Add("jml", "")
        Dim dt As DataTable = getDataFromAPI(pubApiAddress, "rts_inbdta_deldata_validation", sCol, "&no_cont=" & v_no_cont & "&id_vvd=" & v_id_vvd)
        Dim ret As Boolean
        If dt.Rows.Count > 0 Then
            ret = dt.Rows(0)("jml") > 0
        Else
            ret = False
        End If
        Return ret
    End Function
End Module
