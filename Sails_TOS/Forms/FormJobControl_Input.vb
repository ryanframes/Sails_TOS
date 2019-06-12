Imports Sails_TOS

Public Class FormJobControl_Input
    Private _pForm As FormJobController

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        fill_combo()
    End Sub

    Public Property PForm As FormJobController
        Get
            Return _pForm
        End Get
        Set(value As FormJobController)
            _pForm = value
        End Set
    End Property

    Private Sub FormJobControl_Input_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub fill_combo()
        Dim dt As DataTable = fc_jobctr_getpool(pubApiAddress)
        fill_combo_dt(dt, cmb_pool, "POOL_ID", "POOL_NAME")
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Dim sCol As New Dictionary(Of String, String)
        sCol.Add("MCH_CODE", txt_code.Text)
        sCol.Add("POOL_ID", IIf(IsNothing(cmb_pool.SelectedValue), 0, cmb_pool.SelectedValue))
        sCol.Add("STATUS", IIf(opt_active.Checked, 1, 0))
        Dim isOk As Boolean = fc_jobctr_savedata(sCol)
        msgSave(isOk)
        If isOk Then
            _pForm.fill_grid()
            Me.Close()
        End If
    End Sub
End Class