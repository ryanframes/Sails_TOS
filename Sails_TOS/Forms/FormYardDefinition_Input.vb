Imports DevComponents.DotNetBar
Imports Sails_TOS

Public Class FormYardDefinition_Input

    Private _v_id_yard As Integer = 1
    Enum inputTypes
        insert = 1
        edit = 2
    End Enum
    Private _inputType As inputTypes = inputTypes.insert
    Private _pForm As FormYardDefinition
    Private _blockID As Integer

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        fill_combo()
    End Sub

    Public Property v_id_yard As Integer
        Get
            Return _v_id_yard
        End Get
        Set(value As Integer)
            _v_id_yard = value
        End Set
    End Property

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

    Public Property BlockID As Integer
        Get
            Return _blockID
        End Get
        Set(value As Integer)
            _blockID = value
        End Set
    End Property

    Private Sub fill_combo()
        Dim item As ComboBoxItem
        item = New ComboBoxItem
        item.Tag = "Area"
        item.Text = "Area"
        cmb_block_type.Items.Add(item)
        item = New ComboBoxItem
        item.Tag = "Block"
        item.Text = "Block"
        cmb_block_type.Items.Add(item)
        cmb_block_type.SelectedIndex = 0

        item = New ComboBoxItem
        item.Tag = "Y"
        item.Text = "Active"
        cmb_status.Items.Add(item)
        item = New ComboBoxItem
        item.Tag = "N"
        item.Text = "Inactive"
        cmb_status.Items.Add(item)
        cmb_status.SelectedIndex = 0

        item = New ComboBoxItem
        item.Tag = "LR"
        item.Text = "Left to Right"
        cmb_stack_direction.Items.Add(item)
        item = New ComboBoxItem
        item.Tag = "RL"
        item.Text = "Right to Left"
        cmb_stack_direction.Items.Add(item)
        cmb_stack_direction.SelectedIndex = 0

        item = New ComboBoxItem
        item.Tag = "BT"
        item.Text = "Bottom to Top"
        cmb_row_direction.Items.Add(item)
        item = New ComboBoxItem
        item.Tag = "TB"
        item.Text = "Top to Bottom"
        cmb_row_direction.Items.Add(item)
        cmb_row_direction.SelectedIndex = 0
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub

    Private Sub getDesignCapacity()
        Dim v_avail As Integer, v_maxrow As Integer, v_jmlslot As Integer
        Dim sCol As New Dictionary(Of String, String)
        sCol.Add("jml", "")
        Dim dt As DataTable = getDataFromAPI(pubApiAddress, "rts_yrddef_get_jmlslot", sCol, "id=" & BlockID)
        v_avail = IIf(IsNumeric(txt_available_tier.Text), txt_available_tier.Text, 0)
        v_maxrow = IIf(IsNumeric(txt_max_row.Text), txt_max_row.Text, 0)
        v_jmlslot = dt.Rows(0)(0)
        txt_design_capacity.Text = v_avail * v_maxrow * v_jmlslot
    End Sub

    Private Sub txt_max_row_TextChanged(sender As Object, e As EventArgs) Handles txt_max_row.TextChanged
        getDesignCapacity()
    End Sub

    Private Sub txt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_max_row.KeyPress,
        txt_max_tier.KeyPress, txt_available_tier.KeyPress, txt_avail_capacity.KeyPress, txt_position_x.KeyPress, txt_position_y.KeyPress
        'set text to numeric input only
        e.KeyChar = keyNum(e.KeyChar)
    End Sub

    Private Sub txt_LostFocus(sender As Object, e As EventArgs) Handles txt_max_row.LostFocus,
        txt_max_tier.LostFocus, txt_available_tier.LostFocus, txt_avail_capacity.LostFocus, txt_position_x.LostFocus, txt_position_y.LostFocus
        'make textbox to default numeric style with comma separator
        txtLostNotNumeric(CType(sender, TextBox), 0)
    End Sub

    Private Sub txt_available_tier_TextChanged(sender As Object, e As EventArgs) Handles txt_available_tier.TextChanged
        getDesignCapacity()
    End Sub

    Private Sub txt_avail_capacity_TextChanged(sender As Object, e As EventArgs) Handles txt_avail_capacity.TextChanged
        getDesignCapacity()
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If textValidation(txt_block_name, "Block Name") = False Then Return
        If CInt(txt_available_tier.Text) > CInt(txt_max_tier.Text) Then
            MessageBoxEx.Show("Available Tier must be fewer or equal than Max Tier", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_available_tier.Focus()
            Return
        End If
        'init colomns and value
        Dim params As New Dictionary(Of String, String)
        params.Add("ID_YD", _v_id_yard)
        params.Add("BLOCK_NAME", txt_block_name.Text)
        params.Add("POS_X", CInt(txt_position_x.Text))
        params.Add("POS_Y", CInt(txt_position_y.Text))
        params.Add("MAX_ROW", CInt(txt_max_row.Text))
        params.Add("MAX_TIER", CInt(txt_max_tier.Text))
        params.Add("AVB_TIER", CInt(txt_available_tier.Text))
        params.Add("STACK_DIRECTION", cmb_stack_direction.SelectedItem.tag)
        params.Add("ROW_DIRECTION", cmb_row_direction.SelectedItem.tag)
        params.Add("DESIGN_CAPACITY", CInt(txt_design_capacity.Text))
        params.Add("AVB_CAPACITY", CInt(txt_avail_capacity.Text))
        params.Add("USE_FLAG", cmb_status.SelectedItem.tag)
        params.Add("BLOCK_TYPE", cmb_block_type.SelectedItem.tag)
        Dim isOK As Boolean = False
        If _inputType = inputTypes.insert Then
            isOK = fc_yrddef_saveblock(params)
        Else
            params.Add("ID_BLOCK", _blockID)
            isOK = fc_yrddef_updblock(params)
        End If
        msgSave(isOK) 'show msg
        If isOK Then
            _pForm.fill_combo()
            _pForm.fill_grid_block()
            Me.Close()
        End If
    End Sub
End Class