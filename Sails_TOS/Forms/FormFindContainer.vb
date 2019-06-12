Public Class FormFindContainer
    Sub fill_combo()
        Dim dt As DataTable = fc_fndctr_getclass(pubApiAddress)
        fill_combo_dt(dt, cmb_class, 0, 1)
        dt = fc_fndctr_getcom(pubApiAddress)
        fill_combo_dt(dt, cmb_commodity, 0, 1)
        dt = fc_fndctr_getopr(pubApiAddress)
        fill_combo_dt(dt, cmb_operator, 0, 1)

        Dim sCol As Dictionary(Of String, String)
        sCol = New Dictionary(Of String, String)
        sCol.Add("NO_CONT", "")
        dt = fc_fndctr_getdata(pubApiAddress)
        For i As Integer = 0 To dt.Rows.Count - 1
            token_container.Tokens.Add(New DevComponents.DotNetBar.Controls.EditToken(dt.Rows(i)(0), dt.Rows(i)(0)))
        Next
    End Sub

    Sub fill_grid(Optional v_id_vvd As String = "")
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

        Dim whereCondition As String = ""
        If Not IsNothing(cmb_class.SelectedValue) Then whereCondition = whereCondition.Concat(whereCondition, "&", "class=" & cmb_class.SelectedValue)
        If Not IsNothing(cmb_commodity.SelectedValue) Then whereCondition = whereCondition.Concat(whereCondition, "&", "commodity=" & cmb_commodity.SelectedValue)
        If Not IsNothing(cmb_operator.SelectedValue) Then whereCondition = whereCondition.Concat(whereCondition, "&", "operator=" & cmb_operator.SelectedValue)
        whereCondition = whereCondition.Concat(whereCondition, "&containers=" & token_container.Text)
        showDataGrid(grid_container, pubApiAddress, "rts_fndctr_getdata", whereCondition, sCol)

        'add col no
        Dim colNo As New DataGridViewTextBoxColumn
        colNo.HeaderText = "No."
        colNo.Name = "No"
        grid_container.Columns.Insert(0, colNo)
        'fill col no.
        For i As Integer = 0 To grid_container.Rows.Count - 1
            grid_container.Rows(i).Cells("No").Value = i + 1
        Next
        grid_container.ReadOnly = False
        autoColWidth(grid_container.Columns.Count - 1, grid_container)
    End Sub
    Private Sub FormFindContainer_Load(sender As Object, e As EventArgs) Handles Me.Load
        getAPIConf()
    End Sub

    Private Sub FormFindContainer_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        fill_combo()
        fill_grid()
    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        fill_grid()
    End Sub

    Private Sub btn_export_csv_Click(sender As Object, e As EventArgs) Handles btn_export_csv.Click
        Dim res As DialogResult = dlgExport.ShowDialog
        If res = DialogResult.Cancel Then Return
        Dim fName As String = dlgExport.FileName
        Dim dt As New DataTable
        dt = CType(grid_container.DataSource, DataTable).Copy
        dt.Columns.Add("No.").SetOrdinal(0)
        For i As Integer = 0 To dt.Rows.Count - 1
            dt.Rows(i)("No.") = i + 1
        Next
        If dataTableToExcel(dt, fName, "") Then
            Process.Start(fName)
        End If
    End Sub
End Class