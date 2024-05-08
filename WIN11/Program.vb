Imports System

Module Program
    Sub Main(args As String())
        Dim character As Integer
        Dim ExitCalled As Boolean
        ExitCalled = True
        While ExitCalled = True

            Console.WriteLine("Welcome to CD's COBOL IDE!")
            Console.WriteLine("--------------------------")
            Console.WriteLine("Please select an option below to get started")
            Console.WriteLine("1.New Project")
            Console.WriteLine("2.Open Project")
            Console.WriteLine("3.Configure")
            Console.WriteLine("4.Exit")
            character = Console.Read()
            If character = 49 Then

            ElseIf character = 50 Then

            ElseIf character = 51 Then

            ElseIf character = 52 Then
                End
            End If

        End While
    End Sub

    Sub New_Project()

    End Sub

    Sub Open_Project()

    End Sub

    Sub Configure()

    End Sub
End Module
