Imports DevComponents.DotNetBar
Imports Sails_TOS

Public Class FormYardDefinition_InputSlot
    Private _v_id_yard As Integer = 1
    Enum inputTypes
        insert = 1
        edit = 2
    End Enum
    Private _inputType As inputTypes = inputTypes.insert
    Private _pForm As FormYardDefinition
    Private _cellID As Integer
    Private _blockID As Integer

    Public Property InputType As inputTypes
        Get
            Return _inputType
        End Get
        Set(value As inputTypes)
            _inputType = value
        End Set
    End Property

    Public Property PForm As FormYardDefinition
        Get
            Return _pForm
        End Get
        Set(value As FormYardDefinition)
            _pForm = value
        End Set
    End Property

    Public Property CellID As Integer
        Get
            Return _cellID
        End Get
        Set(value As Integer)
            _cellID = value
        End Set
    End Property

    Public Property BlockID As Integer
        Get
            Return _blockID
        End Get
        Set(value As Integer)
            _blockID = value
        End Set
    End Property

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        fill_combo()
    End Sub

    Sub fill_combo()
        Dim item As ComboBoxItem
        item = New ComboBoxItem
        item.Tag = "Y"
        item.Text = "Active"
        cmb_status.Items.Add(item)
        item = New ComboBoxItem
        item.Tag = "N"
        item.Text = "Inactive"
        cmb_status.Items.Add(item)
        cmb_status.SelectedIndex = 0

        Dim sCol As Dictionary(Of String, String)
        sCol = New Dictionary(Of String, String)
        sCol.Add("ID_SIZE_TYPE", "")
        sCol.Add("SIZE_TYPE", "")
        Dim dt As DataTable = getDataFromAPI(pubApiAddress, "rts_siztyp_getdata", sCol)
        For i As Integer = 0 To dt.Rows.Count - 1
            cmb_size_type.Tokens.Add(New DevComponents.DotNetBar.Controls.EditToken(dt.Rows(i)("ID_SIZE_TYPE"), dt.Rows(i)("SIZE_TYPE")))
        Next

        sCol = New Dictionary(Of String, String)
        sCol.Add("ID_CARGO_TYPE", "")
        sCol.Add("CARGO_TYPE", "")
        dt = getDataFromAPI(pubApiAddress, "rts_cartyp_getdata", sCol)
        For i As Integer = 0 To dt.Rows.Count - 1
            cmb_cargo_type.Tokens.Add(New DevComponents.DotNetBar.Controls.EditToken(dt.Rows(i)("ID_CARGO_TYPE"), dt.Rows(i)("CARGO_TYPE")))
        Next
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Dim isOk As Boolean
        'init colomns and value
        Dim params As New Dictionary(Of String, String)
        params.Add("ID_BLOCK", _blockID)
        params.Add("20_STACKNAME", txt_20stack.Text)
        params.Add("40_STACKNAME", txt_40stack.Text)
        params.Add("CARGO_TYPE", cmb_cargo_type.Text)
        params.Add("SIZE_TYPE", cmb_size_type.Text)
        params.Add("USE_FLAG", cmb_status.SelectedItem.tag)

        If _inputType = inputTypes.insert Then
            isOk = fc_yrddef_saveslot(params)
        Else
            params.Add("ID_CELL", _cellID)
            isOk = fc_yrddef_updslot(params)
        End If
        msgSave(isOk)
        If isOk Then
            PForm.fill_grid_slot()
            Me.Close()
        End If
    End Sub
End Class