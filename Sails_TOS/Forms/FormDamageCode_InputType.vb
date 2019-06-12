Imports Sails_TOS

Public Class FormDamageCode_InputType
    Private _idType As Integer
    Private _InputType As inputTypes
    Private _pForm As FormDamageCode

    Public Property IdType As Integer
        Get
            Return _idType
        End Get
        Set(value As Integer)
            _idType = value
        End Set
    End Property

    Public Property PForm As FormDamageCode
        Get
            Return _pForm
        End Get
        Set(value As FormDamageCode)
            _pForm = value
        End Set
    End Property

    Friend Property InputType As inputTypes
        Get
            Return _InputType
        End Get
        Set(value As inputTypes)
            _InputType = value
        End Set
    End Property

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If Not textValidation(txt_code, "Code") Then Return
        If Not textValidation(txt_desc, "Description") Then Return
        Dim isOk As Boolean
        If _InputType = inputTypes.insert Then
            isOk = fc_dmgcde_savetype(txt_code.Text, txt_desc.Text)
        ElseIf _InputType = inputTypes.edit Then
            isOk = fc_dmgcde_updtype(_idType, txt_code.Text, txt_desc.Text)
        End If
        msgSave(isOk)
        If isOk Then
            _pForm.fill_grid_type()
            Me.Close()
        End If
    End Sub
End Class