Imports DevComponents.DotNetBar
Imports Sails_TOS

Public Class FormMachineType_Input
    Enum inputTypes
        insert = 1
        edit = 2
    End Enum
    Private _inputType As inputTypes = inputTypes.insert
    Private _pForm As FormMachineType

    Public Property inputType As inputTypes
        Get
            Return _inputType
        End Get
        Set(value As inputTypes)
            _inputType = value
        End Set
    End Property

    Public Property pForm As FormMachineType
        Get
            Return _pForm
        End Get
        Set(value As FormMachineType)
            _pForm = value
        End Set
    End Property

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If textValidation(txt_code, "Code") = False Then Return

        Dim isOk As Boolean
        If _inputType = inputTypes.insert Then
            'save new
            isOk = fc_mchtyp_savedata(txt_code.Text, txt_description.Text)
        ElseIf _inputType = inputTypes.edit Then
            'update
            isOk = fc_mchtyp_upddata(txt_code.Text, txt_description.Text)
        End If
        msgSave(isOk) 'show msg
        If isOk Then
            _pForm.fill_grid()
            _pForm.fill_combo()
            Me.Close()
        End If
    End Sub

    Private Sub txt_code_TextChanged(sender As Object, e As EventArgs) Handles txt_code.TextChanged

    End Sub
End Class