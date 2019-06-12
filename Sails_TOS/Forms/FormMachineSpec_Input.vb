Imports DevComponents.DotNetBar
Imports Sails_TOS

Public Class FormMachineSpec_Input
    Private _pForm As FormMachineSpec
    Private _inputType As inputTypes

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        getAPIConf()
        fill_combo()
        'set default color
        cp_backcolor.SelectedColor = Color.White
        cp_forecolor.SelectedColor = Color.White
        sw_stat.Value = True
    End Sub

    Public Property PForm As FormMachineSpec
        Get
            Return _pForm
        End Get
        Set(value As FormMachineSpec)
            _pForm = value
        End Set
    End Property

    Friend Property InputType As inputTypes
        Get
            Return _inputType
        End Get
        Set(value As inputTypes)
            _inputType = value
        End Set
    End Property

    Private Sub fill_combo()
        Dim dt As DataTable = fc_mchtyp_getdata(pubApiAddress)
        cmb_type.Items.Clear()
        Dim item As ComboBoxItem
        item = New ComboBoxItem
        item.Tag = ""
        item.Text = ""
        cmb_type.Items.Add(item)
        For i As Integer = 0 To dt.Rows.Count - 1
            item = New ComboBoxItem
            item.Tag = dt.Rows(i)("MCH_TYPE_CODE")
            item.Text = dt.Rows(i)("MCH_TYPE_CODE") & " : " & dt.Rows(i)("MCH_TYPE_NAME")
            cmb_type.Items.Add(item)
        Next
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If Not textValidation(txt_code, "Code") Then Return
        Dim sCol As New Dictionary(Of String, String)
        sCol.Add("MCH_CODE", txt_code.Text)
        sCol.Add("MCH_TYPE_CODE", cmb_type.SelectedItem.tag)
        sCol.Add("HEIGHT", CInt(txt_height.Text))
        sCol.Add("CAPACITY", CInt(txt_capacity.Text))
        sCol.Add("COLOR_B", ColorTranslator.ToHtml(cp_backcolor.SelectedColor))
        sCol.Add("COLOR_F", ColorTranslator.ToHtml(cp_forecolor.SelectedColor))
        sCol.Add("ON_OFF", IIf(sw_stat.Value = True, 1, 0))
        sCol.Add("FROM_COVERAGE", CInt(txt_fromcvrg.Text))
        sCol.Add("TO_COVERAGE", CInt(txt_tocvrg.Text))
        sCol.Add("FROM_COV2", CInt(txt_fromcov.Text))
        sCol.Add("TO_COV2", CInt(txt_tocov.Text))
        sCol.Add("POOL_ID", 0)

        Dim isOK As Boolean
        If _inputType = inputTypes.insert Then
            isOK = fc_mchspc_savedata(sCol)
        Else
            isOK = fc_mchspc_upddata(sCol)
        End If
        msgSave(isOK)
        If isOK Then
            _pForm.fill_combo()
            _pForm.fill_grid()
            Me.Close()
        End If
    End Sub

    Private Sub txt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_height.KeyPress, txt_capacity.KeyPress,
            txt_fromcov.KeyPress, txt_tocov.KeyPress, txt_fromcvrg.KeyPress, txt_tocvrg.KeyPress
        e.KeyChar = keyNum(e.KeyChar)
    End Sub

    Private Sub txt_LostFocus(sender As Object, e As EventArgs) Handles txt_height.LostFocus, txt_capacity.LostFocus,
            txt_fromcov.LostFocus, txt_tocov.LostFocus, txt_fromcvrg.LostFocus, txt_tocvrg.LostFocus
        txtLostNotNumeric(CType(sender, TextBox), 0)
    End Sub

    Private Sub cp_backcolor_SelectedColorChanged(sender As Object, e As EventArgs) Handles cp_backcolor.SelectedColorChanged
        chgColor(txt_backcolor, cp_backcolor.SelectedColor)
    End Sub

    Private Sub cp_forecolor_SelectedColorChanged(sender As Object, e As EventArgs) Handles cp_forecolor.SelectedColorChanged
        chgColor(txt_forecolor, cp_forecolor.SelectedColor)
    End Sub

    Sub chgColor(ByVal obj As Control, clr As Color)
        obj.BackColor = clr
    End Sub

    Private Sub FormMachineSpec_Input_Load(sender As Object, e As EventArgs) Handles Me.Load
        chgColor(txt_forecolor, cp_forecolor.SelectedColor)
        chgColor(txt_backcolor, cp_backcolor.SelectedColor)
    End Sub
End Class