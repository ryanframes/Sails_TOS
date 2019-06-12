Module Mdl_Inqctr
    Function fc_inqctr_getdata(ByVal apiAddress As String, Optional apiCondition As String = Nothing) As DataTable
        Dim sCol As New Dictionary(Of String, String)
        ''SETTING COL
        'sCol.Add("POINT", "")
        'sCol.Add("CLASS", "")
        'sCol.Add("ISO", "")
        'sCol.Add("HEIGHT", "")
        'sCol.Add("OPERATOR", "")
        'sCol.Add("CONT_TYPE", "")
        'sCol.Add("COMMODITY", "")
        'sCol.Add("FM", "")
        'sCol.Add("WEIGHT", "")
        'sCol.Add("VGM", "")
        'sCol.Add("SEAL", "")
        'sCol.Add("DMG_DESC", "")
        'sCol.Add("LOC_DESC", "")
        'sCol.Add("IMDG", "")
        'sCol.Add("UNNO", "")
        'sCol.Add("TEMP", "")
        'sCol.Add("VES_NAME", "")
        'sCol.Add("STOWAGE", "")
        'sCol.Add("VOY_IN", "")
        'sCol.Add("VOY_OUT", "")
        'sCol.Add("ATB", "")
        'sCol.Add("ATD", "")
        'sCol.Add("POD", "")
        'sCol.Add("POL", "")
        'sCol.Add("ACTIVITY_TRX", "")
        'sCol.Add("ACTIVITY_LOCATION", "")
        'sCol.Add("ACTIVITY_TIME", "")
        'sCol.Add("PAYMENT_STATUS", "")
        'sCol.Add("PAYTHROUGH_DATE", "")
        'sCol.Add("TRX_NUMBER", "")
        Dim dt As DataTable = getDataFromAPI(apiAddress, "rts_inqctr_getdata", sCol, apiCondition)
        Return dt
    End Function

    Function fc_inqctr_getpoint(ByVal apiAddress As String, Optional apiCondition As String = Nothing) As DataTable
        Dim sCol As New Dictionary(Of String, String)
        'SETTING COL
        sCol.Add("POINT", "")
        Dim dt As DataTable = getDataFromAPI(apiAddress, "rts_inqctr_getpoints", sCol, apiCondition)
        Return dt
    End Function

    Function fc_inqctr_getactv(ByVal apiAddress As String, Optional apiCondition As String = Nothing) As DataTable
        Dim sCol As New Dictionary(Of String, String)
        'SETTING COL
        Dim dt As DataTable = getDataFromAPI(apiAddress, "rts_inqctr_getactv", sCol, apiCondition)
        Return dt
    End Function

    Function fc_inqctr_getjobhstr(ByVal apiAddress As String, Optional apiCondition As String = Nothing) As DataTable
        Dim sCol As New Dictionary(Of String, String)
        'SETTING COL
        Dim dt As DataTable = getDataFromAPI(apiAddress, "rts_inqctr_getjobhstr", sCol, apiCondition)
        Return dt
    End Function
End Module
