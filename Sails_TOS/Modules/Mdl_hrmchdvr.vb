Module Mdl_hrmchdvr
    Function fc_hrmchdvr_getdata(ByVal grid As DataGridView, ByVal apiAddress As String,
                                 Optional apiCondition As String = Nothing) As Boolean
        Dim sCol As New Dictionary(Of String, String)
        sCol.Add("MACHINE_DRIVER", "")
        sCol.Add("USERNAME", "Username")
        sCol.Add("FULLNAME", "Name")
        Try
            showDataGrid(grid, apiAddress, "rts_hrmchdvr_getdata", apiCondition, sCol)
            'Dim dt_user As DataTable = getDataFromAPI(apiAddress, "rts_hrmchdvr_getdata", sCol, apiCondition)
            ''set datasource grid
            'grid.DataSource = dt_user
            grid.Columns("MACHINE_DRIVER").Visible = False

            'add PDA, ITV to grid
            Dim chk As DataGridViewImageColumn
            sCol.Clear()
            sCol.Add("PDA", "")
            sCol.Add("ITV", "")
            For Each k As KeyValuePair(Of String, String) In sCol
                chk = New DataGridViewImageColumn
                chk.HeaderText = k.Key
                chk.Name = k.Key
                chk.DefaultCellStyle.NullValue = Nothing
                chk.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                grid.Columns.Add(chk)
            Next

            'add data machine to grid 
            sCol.Clear()
            sCol.Add("MCH_TYPE_CODE", "")
            Dim dt_mch As DataTable = getDataFromAPI(apiAddress, "rts_hrmchdvr_getmch", sCol, apiCondition)
            For i As Integer = 0 To dt_mch.Rows.Count - 1
                chk = New DataGridViewImageColumn
                chk.HeaderText = dt_mch.Rows(i)("MCH_TYPE_CODE")
                chk.Name = dt_mch.Rows(i)("MCH_TYPE_CODE")
                chk.DefaultCellStyle.NullValue = Nothing
                chk.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                grid.Columns.Add(chk)
            Next

            'set driver value here
            Dim arr_lane As String()
            For i = 0 To grid.Rows.Count - 1
                'Separated by comma
                arr_lane = Split(grid.Rows(i).Cells("MACHINE_DRIVER").Value.ToString, ",")
                'looping grid col
                For j As Integer = 0 To grid.Columns.Count - 1
                    'check if this machine have selected lane
                    If arr_lane.Contains(grid.Columns(j).HeaderText) Then
                        grid.Rows(i).Cells(j).Value = My.Resources.icons8_checkmark_16
                        grid.Rows(i).Cells(j).Tag = True
                    End If
                Next
            Next

            'add col check
            Dim colChk As New DataGridViewCheckBoxColumn
            colChk.HeaderText = "Select"
            colChk.Name = "Pilih"
            grid.Columns.Insert(0, colChk)

            'add col no
            Dim colNo As New DataGridViewTextBoxColumn
            colNo.HeaderText = "No."
            colNo.Name = "No"
            grid.Columns.Insert(0, colNo)
            'fill col no.
            For i As Integer = 0 To grid.Rows.Count - 1
                grid.Rows(i).Cells("No").Value = i + 1
            Next
            autoColWidth(grid.Columns("Name").Index, grid)
            Return True
        Catch ex As Exception
            DevComponents.DotNetBar.MessageBoxEx.Show("Error : " & ex.Message.ToString, "Warning", MessageBoxButtons.OK)
            Return False
        End Try
    End Function

    Function fc_hrmchdvr_savedata(ByVal params As Dictionary(Of String, String)) As Boolean
        Dim v_param As String = ""
        For Each k As KeyValuePair(Of String, String) In params
            v_param = v_param & IIf(v_param = "", "", "&") & String.Concat(k.Key, "=", Uri.EscapeDataString(k.Value))
        Next
        Dim ret As Boolean = postDataToAPI(pubApiAddress, "rts_hrmchdvr_savedata", v_param)
        Return ret
    End Function
End Module
