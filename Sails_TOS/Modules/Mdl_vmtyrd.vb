﻿Module Mdl_vmtyrd
    Function fc_vmtyrd_getblocklist(ByVal apiAddress As String, Optional apiCondition As String = Nothing) As DataTable
        Dim sCol As New Dictionary(Of String, String)
        'sCol.Add("BLOCK_NAME", "")
        Dim dt As DataTable = getDataFromAPI(apiAddress, "rts_vmtyrd_getblocklist", sCol, apiCondition)
        Return dt
    End Function

    Function fc_vmtyrd_getslotlist(ByVal apiAddress As String, Optional apiCondition As String = Nothing) As DataTable
        Dim sCol As New Dictionary(Of String, String)
        sCol.Add("20_STACKNAME", "")
        Dim dt As DataTable = getDataFromAPI(apiAddress, "rts_vmtyrd_getslotlist", sCol, apiCondition)
        Return dt
    End Function

    Function fc_vmtyrd_getjob(ByVal apiAddress As String, Optional apiCondition As String = Nothing) As DataTable
        Dim sCol As New Dictionary(Of String, String)
        Dim dt As DataTable = getDataFromAPI(apiAddress, "rts_vmtyrd_getjob", sCol, apiCondition)
        Return dt
    End Function
End Module
