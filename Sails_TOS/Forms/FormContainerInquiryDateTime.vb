Public Class FormContainerInquiryDateTime
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

    Private Sub get_date_time()
        Dim dt As DataTable = fc_inqctr_getactv(pubApiAddress, "NO_CONT=" & _ContNo & "&POINT=" & _PointNo)
        If dt.Rows.Count > 0 Then
            valueToDate(txt_terminal_in, dt.Rows(0)("TERMINAL_IN").ToString)
            valueToDate(txt_stacking, dt.Rows(0)("STACKING").ToString)
            valueToDate(txt_truck_out, dt.Rows(0)("TRUCK_OUT").ToString)
            valueToDate(txt_truck_in, dt.Rows(0)("TRUCK_IN").ToString)
            valueToDate(txt_on_chassis, dt.Rows(0)("ON_CHASSIS").ToString)
            valueToDate(txt_terminal_out, dt.Rows(0)("TERMINAL_OUT").ToString)
            valueToDate(txt_loading, dt.Rows(0)("LOADING").ToString)
            valueToDate(txt_discharging, dt.Rows(0)("DISCHARGE").ToString)
        End If
    End Sub

    Private Sub FormContainerInquiryDateTime_Load(sender As Object, e As EventArgs) Handles Me.Load
        get_date_time()
    End Sub
End Class