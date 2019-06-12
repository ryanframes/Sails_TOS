Public Class FormContainerInquiryHold
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
        sCol.Add("HOLD_GROUP", "Hold Group")
        sCol.Add("HOLD_CODE", "Hold Code")
        sCol.Add("HOLD_DATE", "Hold Date/Time")
        sCol.Add("HOLD_USER", "Hold User")
        sCol.Add("RELEASE_DATE", "Release Date/Time")
        sCol.Add("RELEASE_USER", "Release User")
        sCol.Add("REMARKS", "Remark")
        showDataGrid(grid_hold, pubApiAddress, "rts_inqctr_gethold", "NO_CONT=" & _ContNo & "&POINT=" & _PointNo, sCol)
        autoColWidth(1, grid_hold)

    End Sub

    Private Sub FormContainerInquiryHold_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        'add col no
        Dim colNo As New DataGridViewTextBoxColumn
        colNo.HeaderText = "No."
        colNo.Name = "No"

        grid_hold.Columns.Insert(0, colNo)
        'fill col no.
        For i As Integer = 0 To grid_hold.Rows.Count - 1
            grid_hold.Rows(i).Cells("No").Value = i + 1
        Next
    End Sub
End Class