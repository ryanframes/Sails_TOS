Imports DevComponents.DotNetBar

Public Class FormContainerInquiry
    Private Sub FormContainerInquiry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getAPIConf()
    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        If txt_search_cont_no.Text.Trim = "" Then
            MessageBoxEx.Show("Container Number can not be empty", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        find_inquiry()
    End Sub

    Private Sub find_inquiry()
        Dim whereCondition As String = ""
        'CLEAR POINT
        cmb_search_point.Items.Clear()
        'If cmb_search_point.SelectedValue Is Nothing Then
        '    'fill point
        '    Dim dtPoint As DataTable = fc_inqctr_getpoint(pubApiAddress, "NO_CONT=" & txt_search_cont_no.Text)
        '    fill_combo_dt(dtPoint, cmb_search_point, "POINT", "POINT")
        '    cmb_search_point.SelectedIndex = 0
        'End If

        If txt_search_cont_no.Text <> "" Then whereCondition = whereCondition.Concat(whereCondition, "&", "NO_CONT=" & txt_search_cont_no.Text)
        'If Not IsNothing(cmb_search_point.SelectedValue) Then whereCondition = whereCondition.Concat(whereCondition, "&", "POINT=" & cmb_search_point.SelectedValue)
        Dim dt As DataTable = fc_inqctr_getdata(pubApiAddress, whereCondition)
        If dt.Rows.Count = 0 Then
            clear_form()
        Else
            cmb_search_point.Items.Add(dt.Rows(0)("POINT"))
            cmb_search_point.SelectedIndex = 0
            'Container info
            txt_class.Text = dt.Rows(0)("CLASS")
            txt_iso.Text = dt.Rows(0)("ISO")
            txt_size.Text = dt.Rows(0)("SIZE")
            txt_height.Text = dt.Rows(0)("HEIGHT")
            txt_operator.Text = dt.Rows(0)("OPERATOR")
            txt_cont_typ.Text = dt.Rows(0)("CONT_TYPE").ToString
            txt_commodity.Text = dt.Rows(0)("COMMODITY").ToString
            txt_fm.Text = dt.Rows(0)("FM").ToString
            txt_weight.Text = dt.Rows(0)("WEIGHT")
            txt_vgm.Text = dt.Rows(0)("VGM").ToString
            txt_seal.Text = dt.Rows(0)("SEAL").ToString
            txt_dmg.Text = dt.Rows(0)("DMG_DESC").ToString
            txt_dmg_loc.Text = dt.Rows(0)("LOC_DESC").ToString
            txt_imdg.Text = dt.Rows(0)("IMDG").ToString
            txt_unno.Text = dt.Rows(0)("UNNO").ToString
            txt_temp.Text = dt.Rows(0)("TEMP").ToString

            'Vessel info
            txt_vessel.Text = dt.Rows(0)("VES_NAME")
            txt_stowage.Text = dt.Rows(0)("STW_PLAN")
            txt_voyin_out.Text = dt.Rows(0)("VOY_IN").ToString & "/" & dt.Rows(0)("VOY_OUT").ToString

            valueToDate(txt_atb, dt.Rows(0)("ATB").ToString)
            valueToDate(txt_atd, dt.Rows(0)("ATD").ToString)

            txt_pod.Text = dt.Rows(0)("POD").ToString
            txt_pol.Text = dt.Rows(0)("POL").ToString

            'MORE INFO
            txt_status.Text = dt.Rows(0)("ACTIVITY_TRX").ToString
            txt_location.Text = dt.Rows(0)("ACTIVITY_LOCATION").ToString

            valueToDate(txt_stack, dt.Rows(0)("ACTIVITY_TIME").ToString)

            If dt.Rows(0)("PAYMENT_STATUS").ToString = 1 Then
                txt_payment.Text = "Paid"
                valueToDate(txt_paid_thru, dt.Rows(0)("PAYTHROUGH_DATE").ToString)
                txt_billing.Text = dt.Rows(0)("TRX_NUMBER").ToString()
            End If
        End If
    End Sub

    Private Sub txt_search_cont_no_TextChanged(sender As Object, e As EventArgs) Handles txt_search_cont_no.TextChanged
        clear_form
    End Sub

    Private Sub clear_form()
        cmb_search_point.Items.Clear()
        'clear all form
        For Each obj As Control In pnl_container_info.Controls
            If TypeOf obj Is TextBox Then obj.Text = ""
        Next
        For Each obj As Control In pnl_more_info.Controls
            If TypeOf obj Is TextBox Then obj.Text = ""
        Next
        For Each obj As Control In pnl_vessel_info.Controls
            If TypeOf obj Is TextBox Then obj.Text = ""
        Next
    End Sub

    Private Sub txt_search_cont_no_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_search_cont_no.KeyUp
        If e.KeyCode = Keys.Return Then find_inquiry()
    End Sub

    Private Function allowShowDetail() As Boolean
        If txt_vessel.Text.Trim = "" Then
            MessageBoxEx.Show("Vessel Name must be fill in", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        Return True
    End Function

    Private Sub btn_datetime_Click(sender As Object, e As EventArgs) Handles btn_datetime.Click
        If Not allowShowDetail() Then Return
        Dim frm As New FormContainerInquiryDateTime
        With frm
            .ContNo = txt_search_cont_no.Text
            .PointNo = cmb_search_point.Text
            .ShowDialog()
        End With
    End Sub

    Private Sub btn_job_history_Click(sender As Object, e As EventArgs) Handles btn_job_history.Click
        If Not allowShowDetail() Then Return
        Dim frm As New FormContainerInquiryJobHistory
        With frm
            .ContNo = txt_search_cont_no.Text
            .PointNo = cmb_search_point.Text
            .fill_grid()
            .ShowDialog()
        End With
    End Sub

    Private Sub btn_hold_Click(sender As Object, e As EventArgs) Handles btn_hold.Click
        If Not allowShowDetail() Then Return
        Dim frm As New FormContainerInquiryHold
        With frm
            .ContNo = txt_search_cont_no.Text
            .PointNo = cmb_search_point.Text
            .fill_grid()
            .ShowDialog()
        End With
    End Sub
End Class