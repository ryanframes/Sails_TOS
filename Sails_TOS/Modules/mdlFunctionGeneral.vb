Imports System.Net
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Controls
Imports System.IO
Imports System.Data.OleDb
Imports System.Globalization
Imports ClosedXML.Excel

Module mdlFunctionGeneral
    Public Enum inputTypes
        insert = 0
        edit = 1
    End Enum
    Private _pubApiAddress As String
    Public Property pubApiAddress As String
        Get
            Return _pubApiAddress
        End Get
        Set(value As String)
            _pubApiAddress = value
        End Set
    End Property

    Sub getAPIConf()
        pubApiAddress = Read_INI("SettingAPI", "API")
    End Sub

    ''' <summary>
    ''' Set Col Grid auto fill 
    ''' </summary>
    ''' <param name="colNum"></param>
    ''' <param name="dg"></param>
    Public Sub autoColWidth(ByVal colNum As Integer, ByVal dg As DataGridView)
        Dim allWidth As Double, colWidth As Double, nColWidth As Double
        If dg.Columns.Count < colNum Then Exit Sub
        With dg
            colWidth = .Columns(colNum).Width
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            For i As Integer = 0 To .ColumnCount - 1
                If .Columns(i).Visible = True Then
                    allWidth = allWidth + .Columns(i).Width
                End If
            Next
            If allWidth > dg.Width Then
                .Columns(colNum).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                .AutoResizeColumns()
            Else
                nColWidth = .Width - allWidth - 70
                nColWidth = IIf(nColWidth < colWidth, colWidth, nColWidth)
                .Columns(colNum).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill ' IIf(nColWidth > 25, DataGridViewAutoSizeColumnMode.None, DataGridViewAutoSizeColumnMode.DisplayedCells)
                If nColWidth >= colWidth Then
                    .Columns(colNum).Width = nColWidth
                End If
            End If
        End With
    End Sub

    ''' <summary>
    ''' Fungsi untuk mengisi datagridview dari API. 
    ''' Contoh mendapatkan hasil Json dari : http://localhost:8080/rts_mchtyp_getdata.
    ''' Hasil JSON di convert ke datatable untuk dijadikan datasource datagridview.
    ''' </summary>
    ''' <param name="objGrid">DataGridView yang akan di isi dengan record</param>
    ''' <param name="apiAddress">Alamat IPAddress API</param>
    ''' <param name="apiRoute">Nama Route Lumen / Nama Fungsi API</param>
    ''' <param name="cols">List of Dictionary Kolom(ColName di Database,Caption ColName yang ingin ditampilkan0 </param>
    ''' <param name="apiParams">Parameter API</param>
    ''' <returns></returns>
    Function showDataGrid(ByVal objGrid As DataGridView, ByVal apiAddress As String,
                       ByVal apiRoute As String, Optional apiParams As String = Nothing,
                        Optional cols As Dictionary(Of String, String) = Nothing) As Boolean
        Dim V_API_REQUEST As String = apiAddress & "/" & apiRoute & IIf(IsNothing(apiParams), "", "?" & apiParams)
        Try
            'get data from api
            Dim table2 As DataTable = getDataFromAPI(apiAddress, apiRoute, cols, apiParams)

            With objGrid
                '--------dont remove this code, this codes will makes your grid load data faster---------
                .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing 'Or even better .DisableResizing. Most time consumption Enum Is DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
                .RowHeadersVisible = False
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
                .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
                '-------- end ---------
                .DataSource = Nothing 'reset datasource grid 
                .Columns.Clear()
                .Rows.Clear()
                .DataSource = table2 'set grid datasource with new datatable

                .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing
                .RowHeadersVisible = True

                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .ReadOnly = True
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
                .ColumnHeadersHeight = 35
            End With
        Catch ex As Exception
            DevComponents.DotNetBar.MessageBoxEx.Show("Error : " & ex.Message.ToString, "Warning", MessageBoxButtons.OK)
            Return False
        End Try
        Return True
    End Function

    ''' <summary>
    ''' Fungsi untuk mendapatkan data dari API.
    ''' Contoh mendapatkan hasil Json dari : http://localhost:8080/rts_mchtyp_getdata.
    ''' Hasil JSON di convert ke datatable.
    ''' </summary>
    ''' <param name="apiAddress">Alamat IPAddress API</param>
    ''' <param name="apiRoute">Nama Route Lumen / Nama Fungsi API</param>
    ''' <param name="arrCols">Nama Kolom Grid</param>
    ''' <param name="apiParams">Parameter API</param>
    ''' <returns></returns>
    Function getDataFromAPI(ByVal apiAddress As String, ByVal apiRoute As String,
                            ByVal arrCols As Dictionary(Of String, String), Optional apiParams As String = Nothing) As DataTable
        Dim V_API_REQUEST As String = apiAddress & "/" & apiRoute & IIf(IsNothing(apiParams), "", "?" & apiParams)
        Try
            'Create initial request
            Dim Request As HttpWebRequest = HttpWebRequest.Create(V_API_REQUEST)
            Request.Proxy = Nothing
            Request.Method = "GET"
            'create the respon and reader
            Dim Response As HttpWebResponse = Request.GetResponse
            Dim ResponseStream As System.IO.Stream = Response.GetResponseStream
            'create a new stream reader
            Dim StreamReader As New System.IO.StreamReader(ResponseStream)
            Dim data As String = StreamReader.ReadToEnd
            StreamReader.Close()
            'convert json string to table
            Dim table2 = JsonConvert.DeserializeObject(Of Dictionary(Of String, DataTable))(data).Values.SingleOrDefault()
            'fill table with cols
            Dim selectedCols() As String = {}
            If table2.Columns.Count = 0 Then
                'if no data then fill with default cols
                For Each c As KeyValuePair(Of String, String) In arrCols
                    'jika c.value (costum caption) = kosong maka tampilkan dengan default colname dari database
                    table2.Columns.Add(IIf(c.Value = "", c.Key, c.Value))
                    'append selected cols
                    Array.Resize(selectedCols, selectedCols.Length + 1)
                    selectedCols(selectedCols.Length - 1) = IIf(c.Value = "", c.Key, c.Value)
                Next
            Else
                For Each c As KeyValuePair(Of String, String) In arrCols
                    'jika c.value (costum caption) = kosong maka tampilkan dengan default colname dari database
                    If c.Value <> "" Then
                        table2.Columns(c.Key).Caption = c.Value
                        table2.Columns(c.Key).ColumnName = c.Value
                    End If
                    'append selected cols
                    Array.Resize(selectedCols, selectedCols.Length + 1)
                    selectedCols(selectedCols.Length - 1) = IIf(c.Value = "", c.Key, c.Value)
                Next
            End If
            'get specific columns from datatable from database 
            Dim view As DataView = New DataView(table2)
            Dim tblret As DataTable = view.ToTable(False, selectedCols)

            Return tblret
        Catch ex As Exception
            DevComponents.DotNetBar.MessageBoxEx.Show("Error : " & ex.Message.ToString, "Warning", MessageBoxButtons.OK)
            WriteErrorLog(Now(), "Services " & apiRoute & ":", ex.Message)
            Return Nothing
        End Try
    End Function

    Function postDataToAPI(ByVal apiAddress As String, ByVal apiRoute As String,
                            Optional apiParams As String = Nothing) As Boolean
        Dim V_API_REQUEST As String = apiAddress & "/" & apiRoute & IIf(IsNothing(apiParams), "", "?" & apiParams)
        Try

            'Create initial request
            Dim Request As HttpWebRequest = HttpWebRequest.Create(V_API_REQUEST)
            Request.Proxy = Nothing
            Request.Method = "POST"
            'create the respon and reader
            Dim Response As HttpWebResponse = Request.GetResponse
            Dim ResponseStream As System.IO.Stream = Response.GetResponseStream
            'create a new stream reader
            Dim StreamReader As New System.IO.StreamReader(ResponseStream)
            Dim data As String = StreamReader.ReadToEnd
            StreamReader.Close()

            Dim json As JObject = JObject.Parse(data)
            Dim status As Boolean = json("data").ToString()
            Return status
        Catch ex As Exception
            DevComponents.DotNetBar.MessageBoxEx.Show("Error : " & ex.Message.ToString, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            WriteErrorLog(Now(), "Services " & apiRoute & ":", ex.Message)
            Return False
        End Try
    End Function

    Function textValidation(ByVal obj As Control, ByVal fieldName As String, Optional setFocus As Boolean = True) As Boolean
        If obj.Text.Trim = "" Then
            MessageBoxEx.Show(fieldName & " must be fill in !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            If setFocus Then obj.Focus()
            Return False
        End If
        Return True
    End Function

    Sub msgDel(isOk As Boolean)
        If isOk Then
            MessageBoxEx.Show("Delete Success !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            MessageBoxEx.Show("Delete Failed !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Sub msgSave(isOk As Boolean)
        If isOk Then
            MessageBoxEx.Show("Save Success !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBoxEx.Show("Save Failed !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Function confirmDel() As DialogResult
        Dim res As DialogResult = MessageBoxEx.Show("Are you sure want to delete selected record(s) ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        Return res
    End Function

    Public Sub WriteErrorLog(ByVal v_time As String, v_service As String, v_error As String)
        Dim strFileName As String = "errorlog.ini"
        Dim strPath As String = Application.StartupPath

        System.IO.File.AppendAllText((strPath & Convert.ToString("\")) &
                                     strFileName, (DateTime.Now.ToString() + " - " + v_service + " - " + v_error + vbCr & vbLf))
    End Sub

    Function keyNum(ByVal keyA As Char) As Char
        'keypress set numeric only
        Dim varKey As Keys
        varKey = AscW(keyA)
        If (varKey >= Keys.D0 And varKey <= Keys.D9) Or varKey = Keys.Back Or varKey = Keys.Return Or varKey = 46 Or varKey = 44 Or varKey = 45 Then
            keyNum = Chr(varKey)
        Else
            keyNum = ""
        End If
    End Function

    Public Sub txtLostNotNumeric(ByVal txt As Control, Optional decimalLen As Integer = 0)
        'make textbox to default numeric style with comma separator
        If Not IsNumeric(txt.Text) Then txt.Text = 0
        txt.Text = FormatNumber(txt.Text, decimalLen)
    End Sub

    Sub fill_combo_dt(ByVal dt As DataTable, cmb As ComboBoxEx, colKey As String, colVal As String, Optional defaultSelectEmpty As Boolean = True)
        Dim r As DataRow
        'r = dt.NewRow()
        'r.Item(dt.Columns(colKey).Caption) = "0"
        'r.Item(dt.Columns(colVal).Caption) = ""
        'dt.Rows.InsertAt(r, 0)
        If IsNumeric(colKey) Then
            cmb.ValueMember = dt.Columns(CInt(colKey)).Caption
            cmb.DisplayMember = dt.Columns(CInt(colVal)).Caption
        Else
            cmb.ValueMember = dt.Columns(colKey).Caption
            cmb.DisplayMember = dt.Columns(colVal).Caption
        End If
        cmb.DataSource = dt
        If defaultSelectEmpty Then cmb.SelectedItem = Nothing
    End Sub

    Sub autocomplete_text(ByRef txt As TextBox, ByVal dt As DataTable, ByVal colName As String)
        txt.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        txt.AutoCompleteSource = AutoCompleteSource.CustomSource
        txt.AutoCompleteCustomSource.AddRange((From row In dt.Rows.Cast(Of DataRow)()
                                               Select CStr(row(colName))).ToArray())
    End Sub

    Private Function QuoteValue(ByVal value As String) As String
        Return String.Concat("""", value.Replace("""", """"""), """")
    End Function

    Sub dataTableToCSV(ByVal sourceTable As DataTable,
        ByVal strPath As String, ByVal includeHeaders As Boolean)
        'https://www.codeproject.com/Tips/665519/Writing-a-DataTable-to-a-CSV-file

        'Dim sPath As String = IIf(strPath = Nothing, Application.UserAppDataPath & "\tmp.csv", strPath)
        'convert datatable to csv
        Dim writer As TextWriter = New StreamWriter(strPath)

        If (includeHeaders) Then
            Dim headerValues As IEnumerable(Of String) = sourceTable.Columns.
                OfType(Of DataColumn).
                Select(Function(column) QuoteValue(IIf(column.Namespace = Nothing, column.ColumnName, column.Namespace)))

            writer.WriteLine(String.Join(",", headerValues))
        End If

        Dim items As IEnumerable(Of String) = Nothing
        Dim s As String
        For Each row As DataRow In sourceTable.Rows
            items = row.ItemArray.Select(Function(obj)
                                             If IsDate(obj) Then
                                                 If InStr(obj.ToString(), "-") <> 0 Or InStr(obj.ToString(), "/") Then
                                                     s = CDate(obj).ToString("yyyy-MM-dd HH:mm")
                                                 Else
                                                     s = obj?.ToString
                                                 End If
                                             Else
                                                 s = obj?.ToString
                                             End If
                                             If (IsNothing(s) Or s = "") Then
                                                 Return "NULL"
                                             Else
                                                 Return QuoteValue(If(s, String.Empty))
                                             End If
                                         End Function)
            writer.WriteLine(String.Join(",", items))
        Next

        writer.Flush()
    End Sub

    Function getDataTableFromCsv(ByVal path As String, ByVal isFirstRowHeader As Boolean) As DataTable
        Dim header As String = If(isFirstRowHeader, "Yes", "No")
        Dim info As New FileInfo(path)
        Dim pathOnly As String = info.DirectoryName
        Dim fileName As String = info.Name
        Dim sql As String = "SELECT * FROM [" & fileName & "]"
        Try
            Using connection As OleDbConnection = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & pathOnly & ";Extended Properties=""Text;HDR=" & header & """")
                Using command As OleDbCommand = New OleDbCommand(sql, connection)
                    Using adapter As OleDbDataAdapter = New OleDbDataAdapter(command)
                        Dim dataTable As DataTable = New DataTable()
                        dataTable.Locale = CultureInfo.CurrentCulture
                        adapter.Fill(dataTable)
                        Return dataTable
                    End Using
                End Using
            End Using
        Catch ex As Exception
            WriteErrorLog(Now, "getDataTableFromCSV :", ex.Message)
        End Try
    End Function

    Function dataTableToExcel(ByVal dt As DataTable, ByVal strFileName As String, ByVal strHeader As String) As Boolean
        Dim crs As Cursor = Cursor.Current
        Cursor.Current = Cursors.WaitCursor
        Try
            Dim wb As New XLWorkbook
            dt.TableName = "Sheet1"
            wb.Worksheets.Add(dt)
            wb.Worksheet("Sheet1").Row(1).InsertRowsAbove(1)
            wb.Worksheet("Sheet1").Cell(1, 1).Value = strHeader
            wb.SaveAs(strFileName)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "dataTableToExcel")
            Return False
        End Try
        Cursor.Current = crs
    End Function

    Sub valueToDate(obj As Control, txt As String, Optional formatDate As String = "dd/MM/yyyy HH:mm")
        If IsDate(txt.ToString) Then
            obj.Text = CDate(txt).ToString(formatDate)
        Else
            obj.Text = txt.ToString
        End If
    End Sub
End Module
