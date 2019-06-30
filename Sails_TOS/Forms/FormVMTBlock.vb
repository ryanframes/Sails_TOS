Public Class FormVMTBlock
    Private _pForm As FormVMT
    Private _keyCol As String
    Private _ctrlParent As Control

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

    Private Sub FormVMTPopUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getAPIConf()
        fill_grid()


        'set pos bellow control parent
        Me.StartPosition = FormStartPosition.Manual
        Me.Location = New Point(_ctrlParent.PointToScreen(Point.Empty).X, _ctrlParent.PointToScreen(Point.Empty).Y + _ctrlParent.Height)

    End Sub

    Private Sub grid_data_DoubleClick(sender As Object, e As EventArgs) Handles grid_data.DoubleClick
        _pForm.set_block(grid_data.CurrentRow.Cells(0).Value, grid_data.CurrentRow.Cells(1).Value)
        Me.Close()
    End Sub

    Sub fill_grid()
        Dim sCol As New Dictionary(Of String, String)
        sCol.Add("BLOCK_NAME", "")
        sCol.Add("ID_BLOCK", "")
        showDataGrid(grid_data, pubApiAddress, "rts_vmtyrd_getblocklist", "", sCol)
        grid_data.RowHeadersVisible = False
        grid_data.ColumnHeadersVisible = False
        grid_data.Columns("ID_BLOCK").Visible = False
        autoColWidth(0, grid_data)
    End Sub

    Sub showPopUp(ByVal keyCol As String, ByVal ctrl As Control, ByVal apiAddress As String,
                  ByVal apiRoute As String, Optional autoCol As Integer = Nothing, Optional apiParams As String = Nothing,
                  Optional cols As Dictionary(Of String, String) = Nothing, Optional showHeader As Boolean = True)
        _keyCol = keyCol
        _ctrlParent = ctrl

        'set pos bellow control parent
        Me.StartPosition = FormStartPosition.Manual
        Me.Location = New Point(_ctrlParent.PointToScreen(Point.Empty).X, _ctrlParent.PointToScreen(Point.Empty).Y + _ctrlParent.Height)

        showDataGrid(grid_data, apiAddress, apiRoute, apiParams, cols)
        grid_data.RowHeadersVisible = showHeader
        grid_data.ColumnHeadersVisible = showHeader
        If Not IsNothing(autoCol) Then autoColWidth(autoCol, grid_data)
        Me.ShowDialog()
    End Sub

    Private Sub FormVMTPopUp_Resize(sender As Object, e As EventArgs) Handles Me.Resize

    End Sub

    Private Sub grid_data_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid_data.CellContentClick

    End Sub
End Class