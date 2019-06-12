Public Class FormContainerInquiryJobHistory
    Private _ContNo As String
    Private _PointNo As Integer

    Public Property ContNo As String
        Get
            Return _ContNo
        End Get
        Set(value As String)
            _ContNo = value
        End Set
    End Property

    Public Property PointNo As Integer
        Get
            Return _PointNo
        End Get
        Set(value As Integer)
            _PointNo = value
        End Set
    End Property

    Sub fill_grid()
        Dim sCol As New Dictionary(Of String, String)
        sCol.Add("SEQ", "Seq")
        sCol.Add("ACTIVITY_TRX", "Cont Situation")
        sCol.Add("ACTIVITY_TIME", "Date / Time")
        sCol.Add("ACTIVITY_LOCATION", "Location")
        sCol.Add("ACTIVITY_MACHINE", "Machine")
        sCol.Add("ACTIVITY_USER", "User")
        showDataGrid(grid_job_history, pubApiAddress, "rts_inqctr_getjobhstr", "NO_CONT=" & _ContNo & "&POINT=" & _PointNo, sCol)

        'sort by seq
        grid_job_history.Sort(grid_job_history.Columns("Seq"), System.ComponentModel.ListSortDirection.Descending)

        autoColWidth(1, grid_job_history)
    End Sub

    Private Sub FormContainerInquiryJobHistory_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        'add col no
        Dim colNo As New DataGridViewTextBoxColumn
        colNo.HeaderText = "No."
        colNo.Name = "No"

        grid_job_history.Columns.Insert(0, colNo)
        'fill col no.
        For i As Integer = 0 To grid_job_history.Rows.Count - 1
            grid_job_history.Rows(i).Cells("No").Value = i + 1
        Next
    End Sub
End Class