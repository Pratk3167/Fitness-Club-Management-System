Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Data.OleDb
Imports System.Data
Imports Fitness_Club_Management_System

Public Class Database
    Public conn As New OleDbConnection
    Public str As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Fitness Club Management System\Fitness Club Management System\Database\Database.mdb"
    Public ds As New DataSet
    Public dt As New DataTable
    Public dr As OleDbDataReader
    public cmd As New OleDbCommand

    Public Sub New()
        conn = New OleDbConnection()
        conn.ConnectionString = str
        ds = New DataSet()
        dt = New DataTable()
    End Sub

    Public Sub open()
        conn.Open()
    End Sub

    Public Sub executeCommand(ByVal com As String)
        cmd.Connection = conn
        cmd.CommandText = com
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub

    Public Sub executeGrid(ByVal com As String, Optional ByVal tablename As String = "")
        cmd.Connection = conn
        'cmd.CommandText = com
        Dim da As New OleDbDataAdapter(com, conn)
        da.Fill(ds, tablename)
    End Sub

    Public Sub executeReader(ByVal com As String)
        cmd.Connection = conn
        cmd.CommandText = com
        'cmd.ExecuteNonQuery()
        dr = cmd.ExecuteReader
        cmd.Dispose()
    End Sub


    Public Sub close()
        conn.Close()
    End Sub

End Class


