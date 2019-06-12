Imports System.ComponentModel

Public Class TextBoxDatatableAutoComplete
    Inherits TextBox

    Dim lv As ListView = New ListView With {.Dock = DockStyle.Top, .Visible = False, .HotTracking = True, .HoverSelection = True, .FullRowSelect = True}
    Dim txt As TextBox = New TextBox With {.Dock = DockStyle.Top, .Multiline = False, .Visible = True}
    Dim pnlTxt As Panel = New Panel With {.Dock = DockStyle.Fill, .BackColor = Color.Transparent, .Visible = True}
    Dim _dtTableSource As DataTable = Nothing

    Public Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or
        ControlStyles.DoubleBuffer Or ControlStyles.ResizeRedraw Or ControlStyles.UserPaint Or ControlStyles.SupportsTransparentBackColor, True)

        AutoCompleteMode = AutoCompleteMode.None
        Controls.AddRange(New Control() {pnlTxt})
        Me.BackColor = Color.White
        Me.BorderStyle = BorderStyle.None
        Me.Multiline = True
        pnlTxt.Controls.AddRange(New Control() {lv, txt})
        txt.Text = "Text"
        MyBase.Height = txt.Height + 2
        AddHandler txt.LostFocus, AddressOf txtLost
        AddHandler txt.Enter, AddressOf txtFocus
        AddHandler txt.TextChanged, AddressOf txtChanged
        AddHandler txt.Click, AddressOf txtClick
        AddHandler txt.DoubleClick, AddressOf txtDoubleClick
        AddHandler txt.KeyPress, AddressOf txtKeyPress
        AddHandler txt.KeyDown, AddressOf txtKeyDown
        AddHandler txt.KeyUp, AddressOf txtKeyUp

        AddHandler lv.LostFocus, AddressOf lv_LostFocus
        AddHandler lv.Click, AddressOf lv_Click
        Me.Update()
    End Sub

    Protected Overrides Sub OnDoubleClick(e As EventArgs)
        refreshAutoComplete(_dtTableSource)
        MyBase.OnDoubleClick(e)
    End Sub

    <Browsable(False), System.ComponentModel.DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Overloads Property AutoCompleteMode() As AutoCompleteMode
        Get
            Return AutoCompleteMode.None
        End Get
        Set(ByVal Value As AutoCompleteMode)

        End Set
    End Property

    Public Property DtTableSource As DataTable
        Get
            Return _dtTableSource
        End Get
        Set(value As DataTable)
            _dtTableSource = value
        End Set
    End Property

    Protected Overrides Sub OnKeyUp(e As KeyEventArgs)
        MyBase.OnKeyUp(e)

        If _dtTableSource IsNot Nothing Then
            refreshAutoComplete(CType(_dtTableSource, DataTable))
        End If
    End Sub
    Private Sub refreshAutoComplete(defDt As DataTable)
        If IsNothing(defDt) Then Return
        Dim dt As New DataTable
        Try
            lv.Visible = False
            dt = defDt.Copy
            dt.DefaultView.RowFilter = "value like '%" & txt.Text & "%'"
            If dt.DefaultView.Count > 0 Then
                lv.Clear()
                lv.View = View.SmallIcon
                For i As Integer = 0 To dt.DefaultView.Count - 1
                    Dim item As New ListViewItem
                    item.Tag = dt.DefaultView(i)(0)
                    item.Text = dt.DefaultView(i)(1)
                    lv.Items.Add(item)
                Next
                lv.Height = lv.GetItemRect(0).Height * lv.Items.Count + 10
                lv.Top = MyBase.Top + MyBase.Height
                MyBase.Height = txt.Height + lv.Height
                pnlTxt.Height = MyBase.Height
                pnlTxt.BringToFront()
                lv.Visible = True
                MyBase.Update()
                Me.Update()
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub lv_LostFocus(sender As Object, e As EventArgs)
        lv.Visible = False
    End Sub

    Private Sub lv_Click(sender As Object, e As EventArgs)
        txt.Text = lv.SelectedItems.Item(0).Text
        lv.Visible = False
        MyBase.Focus()
    End Sub

    Private Sub txtDoubleClick(sender As Object, e As EventArgs)
        refreshAutoComplete(_dtTableSource)
        MyBase.OnDoubleClick(e)
    End Sub

    Private Sub txtKeyUp(sender As Object, e As KeyEventArgs)
        MyBase.OnKeyUp(e)

        If _dtTableSource IsNot Nothing Then
            refreshAutoComplete(CType(_dtTableSource, DataTable))
        End If
    End Sub

    Private Sub txtKeyDown(sender As Object, e As KeyEventArgs)
        MyBase.OnKeyDown(e)
    End Sub

    Private Sub txtKeyPress(sender As Object, e As KeyPressEventArgs)
        MyBase.OnKeyPress(e)
    End Sub

    Private Sub txtClick(sender As Object, e As EventArgs)
        txt.Focus()
        MyBase.OnClick(e)
    End Sub

    Private Sub txtChanged(sender As Object, e As EventArgs)
        MyBase.Text = txt.Text
        MyBase.OnTextChanged(e)
    End Sub

    Private Sub txtLost(sender As Object, e As EventArgs)
        MyBase.OnLostFocus(e)
    End Sub

    Private Sub txtFocus(sender As Object, e As EventArgs)
        MyBase.OnGotFocus(e)
    End Sub
End Class
