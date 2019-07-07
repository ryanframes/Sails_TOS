Public Class FormVMTSlot
    Private _pForm As FormVMT
    Private _keyCol As String
    Private _ctrlParent As Control
    Private _idBlock As String

    Public Property PForm As FormVMT
        Get
            Return _pForm
        End Get
        Set(value As FormVMT)
            _pForm = value
        End Set
    End Property

    Public Property KeyCol As String
        Get
            Return _keyCol
        End Get
        Set(value As String)
            _keyCol = value
        End Set
    End Property

    Public Property CtrlParent As Control
        Get
            Return _ctrlParent
        End Get
        Set(value As Control)
            _ctrlParent = value
        End Set
    End Property

    Public Property IdBlock As String
        Get
            Return _idBlock
        End Get
        Set(value As String)
            _idBlock = value
        End Set
    End Property

    Private Sub FormVMTPopUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getAPIConf()
        fill_grid()

        'set pos bellow control parent
        Me.StartPosition = FormStartPosition.Manual
        Me.Location = New Point(_ctrlParent.PointToScreen(Point.Empty).X, _ctrlParent.PointToScreen(Point.Empty).Y + _ctrlParent.Height)

    End Sub

    Private Sub grid_data_DoubleClick(sender As Object, e As EventArgs) Handles grid_data.DoubleClick
        '_pForm.popReturn(grid_data.CurrentRow.Cells(0).Value) 'parent form must have popReturn public sub
        _pForm.set_slot(grid_data.CurrentRow.Cells(0).Value, grid_data.CurrentRow.Cells(1).Value)
        Me.Close()
    End Sub

    Sub fill_grid()
        Dim sCol As New Dictionary(Of String, String)
        showDataGrid(grid_data, pubApiAddress, "rts_vmtyrd_getslotlist", "id_block=" & _idBlock, sCol)
        grid_data.RowHeadersVisible = False
        grid_data.ColumnHeadersVisible = False
        grid_data.Columns("ID_STACK").Visible = False
        autoColWidth(0, grid_data)
    End Sub

    Private Sub grid_data_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid_data.CellContentClick

    End Sub
End Class