Imports DevComponents.DotNetBar

Public Class FormTruckCode_Input
    Enum inputTypes
        insert = 1
        edit = 2
    End Enum
    Private _inputType As inputTypes = inputTypes.insert
    Private _pForm As FormTruckCode
    Private _truckID As Integer

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        fill_combo()
    End Sub

    Private Sub fill_combo()
        cmb_itv.Items.Clear()
        Dim item As ComboBoxItem
        item = New ComboBoxItem
        item.Text = "Yes"
        item.Tag = "Y"
        cmb_itv.Items.Add(item)

        item = New ComboBoxItem
        item.Text = "No"
        item.Tag = "N"
        cmb_itv.Items.Add(item)
    End Sub

    Public Property inputType As inputTypes
        Get
            Return _inputType
        End Get
        Set(value As inputTypes)
            _inputType = value
        End Set
    End Property

    Public Property pForm As FormTruckCode
        Get
            Return _pForm
        End Get
        Set(value As FormTruckCode)
            _pForm = value
        End Set
    End Property

    Public Property truckID As Integer
        Get
            Return _truckID
        End Get
        Set(value As Integer)
            _truckID = value
        End Set
    End Property

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt_rfid.TextChanged

    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If textValidation(txt_tid, "TID") = False Then Return

        Dim isOk As Boolean
        If _inputType = inputTypes.insert Then
            'save new
            isOk = fc_trucde_savedata(txt_tid.Text, txt_truck_number.Text, txt_rfid.Text, cmb_itv.SelectedItem.Tag,
                                      txt_truck_company.Text, txt_remarks.Text, "IN")
        ElseIf _inputType = inputTypes.edit Then
            'update
            isOk = fc_trucde_upddata(_truckID, txt_tid.Text, txt_truck_number.Text, txt_rfid.Text, cmb_itv.SelectedItem.Tag,
                                      txt_truck_company.Text, txt_remarks.Text)
        End If
        msgSave(isOk) 'show msg
        If isOk Then
            _pForm.fill_grid()
            Me.Close()
        End If
    End Sub

    Private Sub cmb_itv_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_itv.SelectedIndexChanged

    End Sub
End Class