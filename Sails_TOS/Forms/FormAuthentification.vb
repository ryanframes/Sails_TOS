Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Controls
Public Class FormAuthentification

    Private _userId As Integer

    Private Sub get_user_info()
        'get user name
        Dim dt As DataTable = fc_vmtauth_getuser(pubApiAddress, "USER=" & txt_user.Text & "&PASSWORD=" & txt_pwd.Text)

        If dt.Rows.Count = 0 Then
            _userId = 0
            MessageBoxEx.Show("Invalid username or password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        Else
            _userId = dt.Rows(0)("USER_ID")
            txt_name.Text = dt.Rows(0)("FIRSTNAME") & " " & dt.Rows(0)("LASTNAME")
            'disable password
            txt_pwd.Enabled = False
            txt_pwd.BackColor = txt_name.BackColor
            'fill shift
            cmb_shift.Items.Add("Shift 1")
            cmb_shift.Items.Add("Shift 2")
            cmb_shift.Items.Add("Shift 3")
            cmb_shift.SelectedIndex = 0
        End If
        'get machine type
        dt = fc_vmtauth_getmchtype(pubApiAddress, "USER=" & txt_user.Text & "&PASSWORD=" & txt_pwd.Text)
        If dt.Rows.Count = 0 Then
            'MessageBoxEx.Show("Machine Type with criteria ITV and Area is Yard not found", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        Else
            fill_combo_dt(dt, cmb_mch_type, "MCH_TYPE_CODE", "MCH_TYPE_NAME")
        End If
    End Sub

    Private Sub get_user_mch_name()
        Dim dt As DataTable = fc_vmtauth_getmch(pubApiAddress, "MCH_TYPE_CODE=" & cmb_mch_type.SelectedValue)

        If dt.Rows.Count = 0 Then
            'MessageBoxEx.Show("Invalid username or password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            'fill machine
            fill_combo_dt(dt, cmb_mch_name, "MCH_CODE", "MCH_CODE")
        End If
    End Sub

    Private Sub get_user_mch_team()
        Dim dt As DataTable = fc_vmtauth_getteam(pubApiAddress, "USER_ID=" & _userId & "&MCH_TYPE_CODE=" & cmb_mch_type.SelectedValue)

        If dt.Rows.Count = 0 Then
            'MessageBoxEx.Show("Invalid username or password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            'fill team
            fill_combo_dt(dt, cmb_team, "ID_MCH_TEAM", "TEAM_NAME")
        End If
    End Sub
    Private Sub txt_user_TextChanged(sender As Object, e As EventArgs) Handles txt_user.TextChanged
        'enable password
        txt_pwd.Enabled = True
        txt_pwd.BackColor = txt_user.BackColor
        'clear all text 
        For Each obj As Control In pnl_vmt.Controls
            If TypeOf obj IsNot Label Then
                If obj.Name <> txt_user.Name Then obj.Text = ""
                If TypeOf obj Is ComboBoxEx Then
                    If CType(obj, ComboBoxEx).DataSource IsNot Nothing Then
                        CType(obj, ComboBoxEx).DataSource = Nothing
                    Else
                        CType(obj, ComboBoxEx).Items.Clear()
                    End If
                End If
            End If
        Next
    End Sub

    Private Sub FormAuthentification_Load(sender As Object, e As EventArgs) Handles Me.Load
        getAPIConf()
    End Sub

    Private Sub cmb_mch_type_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmb_mch_type.SelectedValueChanged
        get_user_mch_name()
        get_user_mch_team()
    End Sub

    Private Sub txt_pwd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_pwd.KeyPress
        If e.KeyChar = Chr(Keys.Return) Then
            get_user_info()
        End If
    End Sub

    Private Sub txt_user_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_user.KeyPress
        If e.KeyChar = Chr(Keys.Return) Then
            get_user_info()
        End If
    End Sub

    Private Sub cmb_mch_name_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_mch_name.SelectedIndexChanged

    End Sub

    Private Sub cmb_mch_type_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_mch_type.SelectedIndexChanged

    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        If _userId = 0 Then
            MessageBoxEx.Show("Invalid username or password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        Else
            If Not textValidation(cmb_mch_type, "Machine Type") Then Return
            If Not textValidation(cmb_mch_name, "Machine Name") Then Return
            If Not textValidation(cmb_team, "Team") Then Return
            'LOGIN HERE
            If fc_vmtauth_login(cmb_mch_type.Text, txt_user.Text, cmb_mch_name.Text) Then Me.Close()
        End If
    End Sub
End Class