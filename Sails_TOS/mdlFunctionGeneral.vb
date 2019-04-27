Imports System.Net
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports DevComponents.DotNetBar

Module mdlFunctionGeneral
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
            MessageBoxEx.Show("Save Success !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            MessageBoxEx.Show("Save Failed !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Function confirmDel() As DialogResult
        Dim res As DialogResult = MessageBoxEx.Show("Are you sure want to delete selected data ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        Return res
    End Function
End Module
