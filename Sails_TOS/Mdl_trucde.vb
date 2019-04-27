Module Mdl_trucde
    Function fc_trucde_getdata(ByVal apiAddress As String, Optional apiCondition As String = Nothing) As DataTable

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
