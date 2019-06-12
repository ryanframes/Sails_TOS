Module Mdl_fndctr
    Function fc_fndctr_getdata(ByVal apiAddress As String, Optional apiCondition As String = Nothing) As DataTable
        Dim sCol As New Dictionary(Of String, String)
        sCol.Add("NO_CONT", "Container Number")
        sCol.Add("ACTIVITY_TRX", "Status")
        sCol.Add("ACTIVITY_LOCATION", "Location")
        sCol.Add("STW_PLAN", "Stowage")
        sCol.Add("ID_VVD", "Vessel")
        sCol.Add("CLASS", "Class")
        sCol.Add("ISO", "ISO")
        sCol.Add("SIZE", "Size")
        sCol.Add("CONT_TYPE", "Type")
        sCol.Add("HEIGHT", "Height")
        sCol.Add("COMMODITY", "Commodity")
        sCol.Add("POL", "POL")
        sCol.Add("POD", "POD")
        sCol.Add("POR", "POR")
        sCol.Add("OPERATOR", "Operator")
        sCol.Add("FM", "F/M")
        sCol.Add("WEIGHT", "Weight")
        sCol.Add("VGM", "VGM")
        sCol.Add("TEMP", "Temp")
        sCol.Add("IMDG", "IMDG")
        sCol.Add("UNNO", "UNNO")
        Dim dt As DataTable = getDataFromAPI(apiAddress, "rts_fndctr_getdata", sCol, apiCondition)
        Return dt
    End Function
    Function fc_fndctr_getclass(ByVal apiAddress As String, Optional apiCondition As String = Nothing) As DataTable
        Dim sCol As New Dictionary(Of String, String)
        sCol.Add("CLASS_CODE", "")
        sCol.Add("DESCRIPTION", "")
        Dim dt As DataTable = getDataFromAPI(apiAddress, "rts_fndctr_getclass", sCol, apiCondition)
        Return dt
    End Function

    Function fc_fndctr_getcom(ByVal apiAddress As String, Optional apiCondition As String = Nothing) As DataTable
        Dim sCol As New Dictionary(Of String, String)
        sCol.Add("CARGO_TYPE", "")
        sCol.Add("DESC", "")
        Dim dt As DataTable = getDataFromAPI(apiAddress, "rts_fndctr_getcom", sCol, apiCondition)
        Return dt
    End Function

    Function fc_fndctr_getopr(ByVal apiAddress As String, Optional apiCondition As String = Nothing) As DataTable
        Dim sCol As New Dictionary(Of String, String)
        sCol.Add("OPERATOR_CODE", "")
        sCol.Add("OPERATOR_NAME", "")
        Dim dt As DataTable = getDataFromAPI(apiAddress, "rts_fndctr_getopr", sCol, apiCondition)
        Return dt
    End Function
End Module
