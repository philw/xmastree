Imports System.Threading

Module Module1

    Sub Main()

        Dim MidX As Integer = 40
        Dim TopY As Integer = 1
        Dim B As Integer
        Dim X As Integer
        Dim Y As Integer
        Dim Rnd As Random = New Random
        ' Get an array with the values of ConsoleColor enumeration members.
        Dim colors() As ConsoleColor = ConsoleColor.GetValues(GetType(ConsoleColor))

        SetConsole()

        B = 0
        For Y = TopY To TopY + 15
            For X = MidX - B To MidX + B
                DrawChar(X, Y, 35)
            Next
            B += 1
        Next

        Do
            Console.ForegroundColor = colors(Rnd.Next(0, 14))
            Y = Rnd.Next(1, 16)
            X = Rnd.Next((Y * -1), Y + 1)
            DrawChar(MidX + X, TopY + Y, &H2736)
            Thread.Sleep(30)
        Loop


        Console.ReadLine()

    End Sub

    Sub SetConsole()
        Console.WindowWidth = 80
        Console.BufferWidth = 80
        Console.WindowHeight = 25
        Console.BufferHeight = 25
        Console.BackgroundColor = ConsoleColor.White
        Console.ForegroundColor = ConsoleColor.DarkGreen
        Console.CursorVisible = False
    End Sub

    Sub DrawChar(X As Integer, Y As Integer, C As Integer)
        Console.SetCursorPosition(X, Y)
        Console.Write(ChrW(C))
    End Sub

End Module
