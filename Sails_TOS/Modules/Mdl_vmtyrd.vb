Module Mdl_vmtyrd
    Function fc_vmtyrd_getblocklist(ByVal apiAddress As String, Optional apiCondition As String = Nothing) As DataTable
        Dim sCol As New Dictionary(Of String, String)
        'sCol.Add("BLOCK_NAME", "")
        Dim dt As DataTable = getDataFromAPI(apiAddress, "rts_vmtyrd_getblocklist", sCol, apiCondition)
        Return dt
    End Function

    Function fc_vmtyrd_getslotlist(ByVal apiAddress As String, Optional apiCondition As String = Nothing) As DataTable
        Dim sCol As New Dictionary(Of String, String)
        Dim dt As DataTable = getDataFromAPI(apiAddress, "rts_vmtyrd_getslotlist", sCol, apiCondition)
        Return dt
    End Function

    Function fc_vmtyrd_getjob(ByVal apiAddress As String, Optional apiCondition As String = Nothing) As DataTable
        Dim sCol As New Dictionary(Of String, String)
        Dim dt As DataTable = getDataFromAPI(apiAddress, "rts_vmtyrd_getjob", sCol, apiCondition)
        Return dt
    End Function

    Function fc_vmtyrd_getrowlist(ByVal apiAddress As String, Optional apiCondition As String = Nothing) As DataTable
        Dim sCol As New Dictionary(Of String, String)
        Dim dt As DataTable = getDataFromAPI(apiAddress, "rts_vmtyrd_getrowlist", sCol, apiCondition)
        Return dt
    End Function

    Function fc_vmtyrd_gettierlist(ByVal apiAddress As String, Optional apiCondition As String = Nothing) As DataTable
        Dim sCol As New Dictionary(Of String, String)
        Dim dt As DataTable = getDataFromAPI(apiAddress, "rts_vmtyrd_gettierlist", sCol, apiCondition)
        Return dt
    End Function

    Function fc_vmtyrd_getcell(ByVal apiAddress As String, Optional apiCondition As String = Nothing) As DataTable
        Dim sCol As New Dictionary(Of String, String)
        Dim dt As DataTable = getDataFromAPI(apiAddress, "rts_vmtyrd_getcell", sCol, apiCondition)
        Return dt
    End Function

    Function fc_vmtyrd_check_prev_slot(ByVal apiAddress As String, Optional apiCondition As String = Nothing) As DataTable
        Dim sCol As New Dictionary(Of String, String)
        Dim dt As DataTable = getDataFromAPI(apiAddress, "rts_vmtyrd_check_prev_slot", sCol, apiCondition)
        Return dt
    End Function

    Function fc_vmtyrd_getjob_contsize(ByVal apiAddress As String, Optional apiCondition As String = Nothing) As DataTable
        Dim sCol As New Dictionary(Of String, String)
        Dim dt As DataTable = getDataFromAPI(apiAddress, "rts_vmtyrd_getjob_contsize", sCol, apiCondition)
        Return dt
    End Function

    Function fc_vmtyrd_plcmnt_check_next_slot(ByVal apiAddress As String, Optional apiCondition As String = Nothing) As DataTable
        Dim sCol As New Dictionary(Of String, String)
        Dim dt As DataTable = getDataFromAPI(apiAddress, "rts_vmtyrd_plcmnt_check_next_slot", sCol, apiCondition)
        Return dt
    End Function

    Function fc_vmtyrd_plcmnt(ByVal job As String, ByVal truckId As Integer,
                              noCont As String, point As Integer, idVVD As String,
                              idCont As Integer, user As String, mchCode As String,
                              idBlock As Integer, blockName As String, row As Integer, tier As Integer,
                              idStack As Integer, size As Integer) As Boolean
        Dim ret As Boolean = postDataToAPI(pubApiAddress, "rts_vmtyrd_plcmnt", "job=" & job & "&truck_id=" & truckId &
                        "&no_cont=" & noCont & "&point=" & point & "&id_vvd=" & idVVD & "&id_cont=" & idCont &
                        "&user=" & user & "&mch_code=" & mchCode & "&id_block=" & idBlock & "&block_name=" & blockName &
                        "&row=" & row & "&tier=" & tier & "&id_stack=" & idStack & "&size=" & size)
        Return ret
    End Function

    Function fc_vmtyrd_chgloc(ByVal code As String, ByVal desc As String) As Boolean
        Dim ret As Boolean = postDataToAPI(pubApiAddress, "rts_vmtyrd_chgloc", "kode=" & code & "&nama=" & desc)
        Return ret
    End Function
End Module
