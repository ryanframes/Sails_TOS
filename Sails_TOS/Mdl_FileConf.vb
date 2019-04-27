Imports System.Text
Module Mdl_FileConf
    Private Declare Auto Function GetPrivateProfileString Lib "kernel32.dll" (ByVal lpAppName As String,
                                                                              ByVal lpKeyName As String,
                                                                              ByVal lpDefault As String,
                                                                              ByVal lpReturnedString As StringBuilder,
                                                                              ByVal nSize As Integer,
                                                                              ByVal lpFileName As String) As Integer
    Private Declare Auto Function WritePrivateProfileString Lib "kernel32.dll" (ByVal lpApplicationName As String,
                                              ByVal lpKeyName As String,
                                              ByVal lpString As String,
                                              ByVal lpFileName As String) As Long
    Public Function Read_INI(ByVal root As String, ByVal key As String) As String
        Dim res As Integer
        Dim sb As StringBuilder
        sb = New StringBuilder(500)
        res = GetPrivateProfileString(root, key, "", sb, sb.Capacity, Application.StartupPath & "\SetServer.ini")
        Return sb.ToString
    End Function

    Public Sub Write_INI(sINIFile As String, sSection As String,
            sKey As String, sValue As String)
        Call WritePrivateProfileString(sSection, sKey, sValue, sINIFile)
    End Sub

    'write file ini
    Public Sub INITulisRemeber(nilainya As String)
        Call Write_INI(Application.StartupPath & "\SetServer.ini", "Account", "SimpanLogin", nilainya)
    End Sub

    Public Sub INITulisUsernameLogin(nilainya As String)
        Call Write_INI(Application.StartupPath & "\SetServer.ini", "Account", "UserNameLogin", nilainya)
    End Sub

    Public Sub INITulisPasswordLogin(nilainya As String)
        Call Write_INI(Application.StartupPath & "\SetServer.ini", "Account", "PasswordLogin", nilainya)
    End Sub

    Public Sub INITulisShowPassword(nilainya As String)
        Call Write_INI(Application.StartupPath & "\SetServer.ini", "Account", "ShowPassword", nilainya)
    End Sub
    'read file ini
    Public Function INIBacaShowPassword() As String
        INIBacaShowPassword = Read_INI("Account", "ShowPassword")
    End Function

    Public Function INIBacaRemember() As String
        INIBacaRemember = Read_INI("Account", "SimpanLogin")
    End Function

    Public Function INIBacaUsername() As String
        INIBacaUsername = Read_INI("Account", "UserNameLogin")
    End Function

    Public Function INIBacaPassword() As String
        INIBacaPassword = Read_INI("Account", "PasswordLogin")
    End Function
End Module
