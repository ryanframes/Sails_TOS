Module Mdl_dmgcde
    Function fc_dmgcde_gettype(ByVal apiAddress As String, Optional apiCondition As String = Nothing) As DataTable
        Dim sCol As New Dictionary(Of String, String)
        'SETTING COL
        sCol.Add("ID_DMG", "")
        sCol.Add("DMG_CODE", "")
        sCol.Add("DMG_DESC", "")
        Dim dt As DataTable = getDataFromAPI(apiAddress, "rts_dmgcde_gettype", sCol, apiCondition)
        Return dt
    End Function

    Function fc_dmgcde_savetype(code As String, desc As String) As Boolean
        Dim ret As Boolean = postDataToAPI(pubApiAddress, "rts_dmgcde_savetype",
                        "DMG_CODE=" & code & "&DMG_DESC=" & desc)
        Return ret
    End Function

    Function fc_dmgcde_updtype(id As Integer, code As String, desc As String) As Boolean
        Dim ret As Boolean = postDataToAPI(pubApiAddress, "rts_dmgcde_updtype",
                        "id=" & id & "&DMG_CODE=" & code & "&DMG_DESC=" & desc)
        Return ret
    End Function

    Function fc_dmgcde_deltype(ByVal id As String) As Boolean
        Dim ret As Boolean = postDataToAPI(pubApiAddress, "rts_dmgcde_deltype", "id=" & id)
        Return ret
    End Function

    Function fc_dmgcde_getpart(ByVal apiAddress As String, Optional apiCondition As String = Nothing) As DataTable
        Dim sCol As New Dictionary(Of String, String)
        'SETTING COL
        sCol.Add("ID_DMG_LOC", "")
        sCol.Add("LOC_CODE", "")
        sCol.Add("LOC_DESC", "")
        Dim dt As DataTable = getDataFromAPI(apiAddress, "rts_dmgcde_getpart", sCol, apiCondition)
        Return dt
    End Function

    Function fc_dmgcde_savepart(code As String, desc As String) As Boolean
        Dim ret As Boolean = postDataToAPI(pubApiAddress, "rts_dmgcde_savepart",
                        "LOC_CODE=" & code & "&LOC_DESC=" & desc)
        Return ret
    End Function

    Function fc_dmgcde_updpart(id As Integer, code As String, desc As String) As Boolean
        Dim ret As Boolean = postDataToAPI(pubApiAddress, "rts_dmgcde_updpart",
                        "id=" & id & "&LOC_CODE=" & code & "&LOC_DESC=" & desc)
        Return ret
    End Function

    Function fc_dmgcde_delpart(ByVal id As String) As Boolean
        Dim ret As Boolean = postDataToAPI(pubApiAddress, "rts_dmgcde_delpart", "id=" & id)
        Return ret
    End Function

    Function fc_dmgcde_getgrade(ByVal apiAddress As String, Optional apiCondition As String = Nothing) As DataTable
        Dim sCol As New Dictionary(Of String, String)
        'SETTING COL
        sCol.Add("ID_DMG_GRADE", "")
        sCol.Add("GRADE_CODE", "")
        sCol.Add("GRADE_DESC", "")
        Dim dt As DataTable = getDataFromAPI(apiAddress, "rts_dmgcde_getgrade", sCol, apiCondition)
        Return dt
    End Function

    Function fc_dmgcde_savegrade(code As String, desc As String) As Boolean
        Dim ret As Boolean = postDataToAPI(pubApiAddress, "rts_dmgcde_savegrade",
                        "GRADE_CODE=" & code & "&GRADE_DESC=" & desc)
        Return ret
    End Function

    Function fc_dmgcde_updgrade(id As Integer, code As String, desc As String) As Boolean
        Dim ret As Boolean = postDataToAPI(pubApiAddress, "rts_dmgcde_updgrade",
                        "id=" & id & "&GRADE_CODE=" & code & "&GRADE_DESC=" & desc)
        Return ret
    End Function

    Function fc_dmgcde_delgrade(ByVal id As String) As Boolean
        Dim ret As Boolean = postDataToAPI(pubApiAddress, "rts_dmgcde_delgrade", "id=" & id)
        Return ret
    End Function
End Module
