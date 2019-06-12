Imports DevComponents.DotNetBar

Public Class FormJobController
    Sub fill_combo()
        Dim dt As DataTable = fc_jobctr_getpool(pubApiAddress)
        fill_combo_dt(dt, cmb_pool, "POOL_ID", "POOL_NAME")

        Dim item As ComboBoxItem
        item = New ComboBoxItem
        item.Tag = ""
        item.Text = ""
        cmb_status.Items.Add(item)
        item = New ComboBoxItem
        item.Tag = "1"
        item.Text = "Active"
        cmb_status.Items.Add(item)
        item = New ComboBoxItem
        item.Tag = "0"
        item.Text = "Inactive"
        cmb_status.Items.Add(item)
        cmb_status.SelectedIndex = 0
    End Sub

    Sub fill_grid()
        Dim sCol As New Dictionary(Of String, String)
        sCol.Add("POOL_NAME", "Pool")
        sCol.Add("MCH_CODE", "QC")
        sCol.Add("ID_VVD", "Vessel")
        sCol.Add("STATUS", "Status")

        Dim whereCondition As String
        whereCondition = "area=QUAY"
        whereCondition = whereCondition & "&pool=" & cmb_pool.Text
        whereCondition = whereCondition & "&status=" & cmb_status.SelectedItem.tag

        showDataGrid(grid_job, pubApiAddress, "rts_jobctr_getdata", whereCondition, sCol)
        autoColWidth(1, grid_job)

        'add col no
        Dim colNo As New DataGridViewTextBoxColumn
        colNo.HeaderText = "No."
        colNo.Name = "No"
        grid_job.Columns.Insert(0, colNo)
        'add check
        Dim chk As New DataGridViewCheckBoxColumn
        chk.HeaderText = "Select"
        chk.Name = "Pilih"
        grid_job.Columns.Insert(1, chk)
        'fill col no.
        For i As Integer = 0 To grid_job.Rows.Count - 1
            grid_job.Rows(i).Cells("No").Value = i + 1
        Next
        grid_job.ReadOnly = False
    End Sub

    Private Sub FormMachineSpec_Load(sender As Object, e As EventArgs) Handles Me.Load
        getAPIConf()
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        If Not allowEditDel() Then Return

        Dim iRow As New List(Of Integer)
        'cek apakah ada row yang di pilih
        For i As Integer = 0 To grid_job.Rows.Count - 1
            If grid_job.Rows(i).Cells("Pilih").Value = True Or grid_job.Rows(i).Cells("Pilih").Value = 1 Then
                'mchCode.Add(grid_job.Rows(i).Cells("MCH_CODE").Value)
                iRow.Add(i)
            End If
        Next

        If iRow.Count = 0 Then Return
        Dim frm As New FormJobControl_Input
        With frm
            .PForm = Me
            .txt_code.Text = grid_job.Rows(iRow.Last).Cells("QC").Value
            .cmb_pool.Text = grid_job.Rows(iRow.Last).Cells("Pool").Value.ToString
            .opt_active.Checked = grid_job.Rows(iRow.Last).Cells("Status").Value = "Active"
            .opt_non.Checked = grid_job.Rows(iRow.Last).Cells("Status").Value = "Inactive"
            .ShowDialog()
        End With
    End Sub

    Private Function allowEditDel() As Boolean
        If grid_job.Rows.Count = 0 Then Return False
        If grid_job.SelectedRows Is Nothing Then Return False
        Return True
    End Function

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        fill_grid()
    End Sub

    Private Sub FormJobController_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        fill_combo()
        fill_grid()
    End Sub

    Private Sub grid_job_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles grid_job.CellBeginEdit
        e.Cancel = e.ColumnIndex <> grid_job.Columns("Pilih").Index
    End Sub
End Class