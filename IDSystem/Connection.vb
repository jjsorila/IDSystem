﻿Imports System.Data.OleDb
Public Class Connection
    Public login_conn As New OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Application.StartupPath}\Login_DB.accdb")

    'STUDENT DBS
    Public student_id_details_conn As New OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Application.StartupPath}\Student_ID_Details.accdb")
    Public student_data_conn As New OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Application.StartupPath}\Student_Data.accdb")
    Public student_to_print_conn As New OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Application.StartupPath}\Student_To_Print.accdb")

    'PROF DBS
    Public prof_conn As New OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Application.StartupPath}\Prof_DB.accdb")
    Public prof_to_print_conn As New OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Application.StartupPath}\Prof_To_Print.accdb")

End Class
