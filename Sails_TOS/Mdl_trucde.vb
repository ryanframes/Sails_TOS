Module Mdl_trucde
    Function fc_trucde_getdata(ByVal apiAddress As String, Optional apiCondition As String = Nothing) As DataTable
        Dim sCol As New Dictionary(Of String, String)
        '{"TRUCK_ID", "TID", "Truck Number", "Status", "RFID Code", "Last In Date",
        '   "Last Out Date", "ITV Flag", "Trucking Company", "Remarks"}
        'SETTING COL
        sCol.Add("TRUCK_ID", "")
        sCol.Add("TID", "")
        sCol.Add("TRUCK_NUMBER", "Truck Number")
        sCol.Add("STATUS", "Status")
        sCol.Add("RFID_CODE", "RFID Code")
        sCol.Add("LAST_IN_DATE", "Last In Date")
        sCol.Add("LAST_OUT_DATE", "Last Out Date")
        sCol.Add("ITV_FLAG", "ITV Flag")
        sCol.Add("TRUCKING_COMPANY", "Trucking Company")
        sCol.Add("REMARKS", "Remarks")
        Dim dt As DataTable = getDataFromAPI(apiAddress, "rts_trucde_getdata", sCol, apiCondition)
    End Function

    Function fc_trucde_savedata(tid As String, truck_number As String, rfid As String,
                                itv_flag As String, truck_company As String, remarks As String, status As String) As Boolean
        Dim ret As Boolean = postDataToAPI(pubApiAddress, "rts_trucde_savedata",
                        "tid=" & tid & "&truck_number=" & truck_number & "&rfid_code=" & rfid &
                        "&itv_flag=" & itv_flag & "&trucking_company=" & truck_company & "&remarks=" & remarks &
                        "&status=" & status)
        Return ret
    End Function

    Function fc_trucde_upddata(id As Integer, tid As String, truck_number As String, rfid As String,
                                itv_flag As String, truck_company As String, remarks As String) As Boolean
        Dim ret As Boolean = postDataToAPI(pubApiAddress, "rts_trucde_upddata",
                        "id=" & id & "&tid=" & tid & "&truck_number=" & truck_number & "&rfid_code=" & rfid &
                        "&itv_flag=" & itv_flag & "&trucking_company=" & truck_company & "&remarks=" & remarks)
        Return ret
    End Function

    Function fc_trucde_deldata(ByVal id As String) As Boolean
        Dim ret As Boolean = postDataToAPI(pubApiAddress, "rts_trucde_deldata", "id=" & id)
        Return ret
    End Function
End Module
