Public Class MainForm

    'MARK: Properties
    Dim firstFootForward As Boolean
    Dim direction As Integer
    Dim vroads(3) As PictureBox
    Dim hroads(1) As PictureBox
    Dim Cages(3) As PictureBox
    Dim Lives(2) As PictureBox
    Dim numTimesCaught As Integer
    Dim Cagesdirection(3) As Integer
    Dim CagesState(3) As Integer
    Dim CagesDelay(3) As Integer
    Dim CageNum As Integer
    Dim Pizza(NUMPIZZAS) As PictureBox
    Dim NumPizzaEaten As Integer
    Const INHOME As Integer = 0
    Const LEAVINGHOME As Integer = 1
    Const REGULAR As Integer = 2
    Const Scared As Integer = 3
    Const NUMPIZZAS As Integer = 97
    Dim firstLoad As Boolean = True
    Dim levers(3) As PictureBox
    Dim ScaredTimer As Integer
    Dim FileLocation As String = IO.Path.GetDirectoryName(Application.ExecutablePath) & "\HighScore.txt"
    Dim LabelTimer As Integer

    Private Sub MoveUp(ByVal guy As PictureBox, ByVal speed As Integer)
        If guy.Top < 0 - guy.Height Then
            guy.Top = 900
        Else
            guy.Top = guy.Top - speed
        End If
    End Sub
    Private Sub MoveDown(ByVal guy As PictureBox, ByVal speed As Integer)
        If guy.Top > 900 Then
            guy.Top = 0 - guy.Height
        Else
            guy.Top = guy.Top + speed
        End If
    End Sub
    Private Sub MoveRight(ByVal guy As PictureBox, ByVal speed As Integer)
        If guy.Left > 1200 Then
            guy.Left = 0 - guy.Width
        Else
            guy.Left = guy.Left + speed
        End If
    End Sub
    Private Sub MoveLeft(ByVal guy As PictureBox, ByVal speed As Integer)
        If guy.Left < 0 - guy.Width Then
            guy.Left = 1200
        Else
            guy.Left = guy.Left - speed
        End If
    End Sub
    Private Sub AnimateUp()
        If firstFootForward = True Then
            Reggie.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\Pics\" & CharacterDirectory & "\" & AcronymString & "Up1.png")
            firstFootForward = False
        Else
            Reggie.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\Pics\" & CharacterDirectory & "\" & AcronymString & "Up2.png")
            firstFootForward = True
        End If
    End Sub
    Private Sub AnimateDown()
        If firstFootForward = True Then
            Reggie.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\Pics\" & CharacterDirectory & "\" & AcronymString & "Dn1.png")
            firstFootForward = False
        Else
            Reggie.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\Pics\" & CharacterDirectory & "\" & AcronymString & "Dn2.png")
            firstFootForward = True
        End If
    End Sub
    Private Sub AnimateRight()
        If firstFootForward = True Then
            Reggie.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\Pics\" & CharacterDirectory & "\" & AcronymString & "Rt1.png")
            firstFootForward = False
        Else
            Reggie.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\Pics\" & CharacterDirectory & "\" & AcronymString & "Rt2.png")
            firstFootForward = True
        End If
    End Sub
    Private Sub AnimateLeft()
        If firstFootForward = True Then
            Reggie.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\Pics\" & CharacterDirectory & "\" & AcronymString & "Lt1.png")
            firstFootForward = False
        Else
            Reggie.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\Pics\" & CharacterDirectory & "\" & AcronymString & "Lt2.png")
            firstFootForward = True
        End If
    End Sub
    Private Function Touching(ByVal object1 As PictureBox, ByVal object2 As PictureBox)
        If object1.Right > object2.Left And object1.Left < object2.Right Then
            If object1.Top < object2.Bottom And object1.Bottom > object2.Top Then
                Return True
            End If
        End If
        Return False
    End Function

    Private Sub MainForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Up Or e.KeyCode = Keys.Down Or e.KeyCode = Keys.Left Or e.KeyCode = Keys.Right Then
            direction = e.KeyCode
        End If
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Quit = False
        If System.IO.File.Exists(FileLocation) = True Then

        End If
        If (difficulty = defaultD) Then
            cageSpeed = 5
            reggieSpeed = 10S
        End If
        vroads(0) = VRoad0
        vroads(1) = VRoad1
        vroads(2) = VRoad2
        vroads(3) = VRoad3
        hroads(0) = HRoad0
        hroads(1) = HRoad1
        NumPizzaEaten = 0
        numTimesCaught = 0
        Lives(0) = Live0
        Lives(1) = Live1
        Lives(2) = Live2
        levers(0) = Switch1
        levers(1) = Switch2
        levers(2) = Switch3
        levers(3) = Switch4
        levers(0).Visible = True
        levers(1).Visible = True
        levers(2).Visible = True
        levers(3).Visible = True
        Score = 0
        scoreboard.Text = "Score: " + Score.ToString
        'ScorePopup.Visible = False 
        Call SetCharacter()
        Call ResetLevel()
        My.Computer.Audio.Play(IO.Path.GetDirectoryName(Application.ExecutablePath) &
        "\Sounds\ReggieSong.wav", AudioPlayMode.BackgroundLoop)

        Timer1.Start()

    End Sub

    Private Sub SetCharacter()
        'set directory of character
        'set placeholder for character
        If CharacterSelect = ReggieSelect Then
            CharacterDirectory = "Reggie"
            AcronymString = "RR"
        ElseIf CharacterSelect = PeteSelect Then
            CharacterDirectory = "Cheeky Pete"
            AcronymString = "CP"
        ElseIf CharacterSelect = SuzieSelect Then
            CharacterDirectory = "Suzie Coo"
            AcronymString = "SC"
        Else
            Console.WriteLine("How did we get here?")
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Dim Index As Integer

        Call MoveReggie()
        Call AnimateReggie()

        For Index = 0 To 3
            If CagesState(Index) = REGULAR Or CagesState(Index) = Scared Then
                Call MoveCages(Index)
                If (Atintersection(Index)) = True Then
                    Call ChaseReggie(Index)
                End If
            Else
                Call Moveintogame()
            End If
            If Touching(Reggie, Cages(Index)) = True Then
                Call CaptureReggie()
            End If
        Next Index

        Call CheckBeatLevel()

        scoreboard.Text = username + " Score: " + Score.ToString

        If Quit = True Then
            Me.Close()
        End If
    End Sub
    Private Sub MoveReggie()

        Dim index As Integer
        For index = 0 To 3

            If Touching(Reggie, vroads(index)) Then
                If direction = Keys.Up Then
                    Call MoveUp(Reggie, reggieSpeed)
                    Reggie.Left = vroads(index).Left
                End If

                If direction = Keys.Down Then
                    Call MoveDown(Reggie, reggieSpeed)
                    Reggie.Left = vroads(index).Left

                End If
            End If
        Next index

        For index = 0 To 1
            If Touching(Reggie, hroads(index)) Then
                If direction = Keys.Left Then
                    Call MoveLeft(Reggie, reggieSpeed)
                    Reggie.Top = hroads(index).Top
                End If

                If direction = Keys.Right Then
                    Call MoveRight(Reggie, reggieSpeed)
                    Reggie.Top = hroads(index).Top
                End If
            End If

        Next index
    End Sub
    Private Sub AnimateReggie()
        If direction = Keys.Up Then
            Call AnimateUp()
        End If
        If direction = Keys.Down Then
            Call AnimateDown()
        End If
        If direction = Keys.Right Then
            Call AnimateRight()
        End If
        If direction = Keys.Left Then
            Call AnimateLeft()
        End If
    End Sub

    Private Sub MoveCages(ByVal cindex As Integer)

        Dim index As Integer
        For condex = 0 To 3
            Console.WriteLine("CageState: " + CagesState(condex).ToString())
        Next
        If CagesState(cindex) <> Scared Then
            For index = 0 To 3

                If Touching(Cages(cindex), vroads(index)) Then
                    If Cagesdirection(cindex) = Keys.Up Then
                        MoveUp(Cages(cindex), cageSpeed)
                        Cages(cindex).Left = vroads(index).Left
                    End If

                    If Cagesdirection(cindex) = Keys.Down Then
                        MoveDown(Cages(cindex), cageSpeed)
                        Cages(cindex).Left = vroads(index).Left

                    End If
                End If
            Next index

            For index = 0 To 1
                If Touching(Cages(cindex), hroads(index)) Then
                    If Cagesdirection(cindex) = Keys.Left Then
                        MoveLeft(Cages(cindex), cageSpeed)
                        Cages(cindex).Top = hroads(index).Top
                    End If

                    If Cagesdirection(cindex) = Keys.Right Then
                        MoveRight(Cages(cindex), cageSpeed)
                        Cages(cindex).Top = hroads(index).Top
                    End If
                End If

            Next index
        Else
            ScaredTimer = ScaredTimer + 1
            Console.WriteLine("ScaredTimer" + ScaredTimer.ToString())
            If ScaredTimer > 200 Then
                ScaredTimer = 0
                For index2 = 0 To 3
                    If CagesState(index2) = Scared Then
                        CagesState(index2) = REGULAR

                    End If
                Next
            End If
        End If
    End Sub
    Private Function Atintersection(ByVal cindex As Integer)
        Dim index As Integer
        For index = 0 To 3
            If Touching(Cages(cindex), HRoad0) And Touching(Cages(cindex), vroads(index)) Then
                Return True
            ElseIf Touching(Cages(cindex), HRoad1) And Touching(Cages(cindex), vroads(index)) Then
                Return True
            End If

        Next index
        Return False
    End Function
    Private Sub ChaseReggie(ByVal cindex As Integer)
        Dim xdistance As Integer
        Dim ydistance As Integer
        xdistance = Math.Abs(Cages(cindex).Left - Reggie.Left)
        ydistance = Math.Abs(Cages(cindex).Top - Reggie.Top)

        If xdistance >= ydistance Then
            If Reggie.Left <= Cages(cindex).Left Then
                Cagesdirection(cindex) = Keys.Left
            ElseIf Reggie.Left > Cages(cindex).Left Then
                Cagesdirection(cindex) = Keys.Right
            End If

        Else

            If Reggie.Top <= Cages(cindex).Top Then
                Cagesdirection(cindex) = Keys.Up
            ElseIf Reggie.Top > Cages(cindex).Top Then
                Cagesdirection(cindex) = Keys.Down
            End If

        End If
    End Sub

    Private Sub CutReggieOff(ByVal cindex As Integer)
        Dim xdistance As Integer
        Dim ydistance As Integer
        xdistance = Math.Abs(Cages(cindex).Left - Reggie.Left)
        ydistance = Math.Abs(Cages(cindex).Top - Reggie.Top)

        If xdistance < ydistance Then
            If Reggie.Left < Cages(cindex).Left Then
                Cagesdirection(cindex) = Keys.Left
            ElseIf Reggie.Left >= Cages(cindex).Left Then
                Cagesdirection(cindex) = Keys.Right
            End If

        ElseIf ydistance <= xdistance Then

            If Reggie.Top < Cages(cindex).Top Then
                Cagesdirection(cindex) = Keys.Up
            ElseIf Reggie.Top >= Cages(cindex).Top Then
                Cagesdirection(cindex) = Keys.Down
            End If

        End If
    End Sub

    Private Sub ResetLevel()
        Call ReggieSet()
        Call CagesSet()
        Call PizzaSet()
        Call LiveSet()
        ScaredTimer = 0
        LabelTimer = 0
    End Sub

    Private Sub ReggieSet()
        Reggie.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\Pics\" & CharacterDirectory & "\" & AcronymString & "RT2.PNG")
        firstFootForward = True
        Reggie.Left = 521
        Reggie.Top = 621
    End Sub

    Private Sub CagesSet()
        Cages(0) = Cage0
        Cages(1) = Cage1
        Cages(2) = Cage2
        Cages(3) = Cage3
        Cagesdirection(0) = Keys.Left
        Cagesdirection(1) = Keys.Right
        Cagesdirection(2) = Keys.Left
        Cagesdirection(3) = Keys.Right
        Cages(0).Left = 484
        Cages(0).Top = 388
        Cages(1).Left = 564
        Cages(1).Top = 388
        Cages(2).Left = 484
        Cages(2).Top = 456
        Cages(3).Left = 564
        Cages(3).Top = 456
        CagesState(0) = INHOME
        CagesState(1) = INHOME
        CagesState(2) = INHOME
        CagesState(3) = INHOME
        CageNum = 0
        CagesDelay(0) = 0
        CagesDelay(1) = 0
        CagesDelay(2) = 0
        CagesDelay(3) = 0
    End Sub

    Private Sub Moveintogame()
        If CagesState(CageNum) = INHOME Then
            CagesState(CageNum) = LEAVINGHOME
            Cages(CageNum).Left = 529
            Cages(CageNum).Top = 415
        ElseIf CagesState(CageNum) = LEAVINGHOME Then
            Cages(CageNum).Top = Cages(CageNum).Top - 2
            If Cages(CageNum).Top < 230 Then
                CagesState(CageNum) = REGULAR
                CageNum = CageNum + 1
            End If
        End If
    End Sub

    Private Sub CheckBeatLevel()
        Dim Index As Integer
        For Index = 0 To 97
            If Touching(Reggie, Pizza(Index)) = True And Pizza(Index).Visible = True Then
                PopUpTimer.Start()
                If (Touching(Reggie, Pizza(6)) = True Or Touching(Reggie, Pizza(31)) = True Or Touching(Reggie, Pizza(39)) = True Or Touching(Reggie, Pizza(97)) = True) And Pizza(Index).Visible = True Then
                    Score = Score + 5
                    ScorePopup.Text = "+5"
                Else
                    ScorePopup.Text = "+1"
                    Score = Score + 1
                End If
                ScorePopup.Left = Pizza(Index).Left
                ScorePopup.Top = Pizza(Index).Top
                NumPizzaEaten = NumPizzaEaten + 1
                Console.WriteLine("numpizzaseaten " + NumPizzaEaten.ToString)
                Pizza(Index).Visible = False
                If NumPizzaEaten = 94 Then
                    Timer1.Stop()
                    BeatLevelForm.ShowDialog()
                    levers(0).Visible = True
                    levers(1).Visible = True
                    levers(2).Visible = True
                    levers(3).Visible = True
                    NumPizzaEaten = 0
                    Call ResetLevel()
                    Timer1.Start()
                End If
            End If
        Next Index
        Index = 0
        For Index = 0 To 3
            If Touching(Reggie, levers(Index)) And levers(Index).Visible = True Then
                levers(Index).Visible = False
                ScaredTimer = 0
                For Cindex = 0 To 3
                    If CagesState(Cindex) = REGULAR Then
                        CagesState(Cindex) = Scared
                    End If
                Next
            End If
        Next
    End Sub

    Public Sub ResetPizza()
        Dim Index As Integer
        For Index = 0 To 97
            Pizza(Index).Visible = True

        Next Index
    End Sub

    Private Sub PizzaSet()
        Pizza(0) = PictureBox1
        Pizza(1) = PictureBox2
        Pizza(2) = PictureBox3
        Pizza(3) = PictureBox4
        Pizza(4) = PictureBox5
        Pizza(5) = PictureBox6
        Pizza(6) = BigPizza2
        Pizza(7) = PictureBox8
        Pizza(8) = PictureBox9
        Pizza(9) = PictureBox10
        Pizza(10) = PictureBox11
        Pizza(11) = PictureBox12
        Pizza(12) = PictureBox13
        Pizza(13) = PictureBox14
        Pizza(14) = PictureBox15
        Pizza(15) = PictureBox16
        Pizza(16) = PictureBox16
        ' Pizza(16) = Switch4
        Pizza(17) = PictureBox18
        Pizza(18) = PictureBox19
        Pizza(19) = PictureBox20
        Pizza(20) = PictureBox21
        Pizza(21) = PictureBox22
        Pizza(22) = PictureBox23
        Pizza(23) = PictureBox23
        'Pizza(23) = Switch3
        Pizza(24) = PictureBox25
        Pizza(25) = PictureBox26
        Pizza(26) = PictureBox27
        Pizza(27) = PictureBox28
        Pizza(28) = PictureBox29
        Pizza(29) = PictureBox30
        Pizza(30) = PictureBox31
        Pizza(31) = BigPizza4
        Pizza(32) = PictureBox33
        Pizza(33) = PictureBox34
        Pizza(34) = PictureBox35
        Pizza(35) = PictureBox36
        Pizza(36) = PictureBox37
        Pizza(37) = PictureBox38
        Pizza(38) = PictureBox39
        Pizza(39) = BigPizza1
        Pizza(40) = PictureBox41
        Pizza(41) = PictureBox42
        Pizza(42) = PictureBox43
        Pizza(43) = PictureBox44
        Pizza(44) = PictureBox45
        Pizza(45) = PictureBox46
        Pizza(46) = PictureBox47
        Pizza(47) = PictureBox48
        Pizza(48) = PictureBox49
        Pizza(49) = PictureBox50
        Pizza(50) = PictureBox51
        Pizza(51) = PictureBox52
        Pizza(52) = PictureBox53
        Pizza(53) = PictureBox54
        Pizza(54) = PictureBox55
        Pizza(55) = PictureBox56
        Pizza(56) = PictureBox57
        Pizza(57) = PictureBox58
        Pizza(58) = PictureBox59
        Pizza(59) = PictureBox60
        Pizza(60) = PictureBox61
        Pizza(61) = PictureBox62
        Pizza(62) = PictureBox63
        Pizza(63) = PictureBox64
        Pizza(64) = PictureBox65
        Pizza(65) = PictureBox66
        Pizza(66) = PictureBox67
        Pizza(67) = PictureBox68
        Pizza(68) = PictureBox69
        Pizza(69) = PictureBox69
        'Pizza(69) = Switch2
        Pizza(70) = PictureBox71
        Pizza(71) = PictureBox72
        Pizza(72) = PictureBox73
        Pizza(73) = PictureBox74
        Pizza(74) = PictureBox75
        Pizza(75) = PictureBox76
        Pizza(76) = PictureBox77
        Pizza(77) = PictureBox78
        Pizza(78) = PictureBox79
        Pizza(79) = PictureBox79
        'Pizza(79) = Switch1
        Pizza(80) = PictureBox81
        Pizza(81) = PictureBox82
        Pizza(82) = PictureBox83
        Pizza(83) = PictureBox84
        Pizza(84) = PictureBox85
        Pizza(85) = PictureBox86
        Pizza(86) = PictureBox87
        Pizza(87) = PictureBox88
        Pizza(88) = PictureBox89
        Pizza(89) = PictureBox90
        Pizza(90) = PictureBox91
        Pizza(91) = PictureBox92
        Pizza(92) = PictureBox93
        Pizza(93) = PictureBox94
        Pizza(94) = PictureBox95
        Pizza(95) = PictureBox96
        Pizza(96) = PictureBox97
        Pizza(97) = BigPizza3

    End Sub
    Private Sub LiveSet()
        Lives(0) = Live0
        Lives(1) = Live1
        Lives(2) = Live2
    End Sub
    Private Sub CaptureReggie()
        Dim pizzaIndex As Integer
        If numTimesCaught < 3 Then
            Timer1.Stop()
            'lose life
            Lives(numTimesCaught).Visible = False
            numTimesCaught = numTimesCaught + 1
            Capturedform.ShowDialog()
            Call ResetLevel()
            Timer1.Start()
        Else
            Timer1.Stop()
            numTimesCaught = 0
            GameOver.ShowDialog()
            Lives(0).Visible = True
            Lives(1).Visible = True
            Lives(2).Visible = True
            NumPizzaEaten = 0
            For pizzaIndex = 0 To NUMPIZZAS
                Pizza(pizzaIndex).Visible = True
            Next pizzaIndex
            levers(0).Visible = True
            levers(1).Visible = True
            levers(2).Visible = True
            levers(3).Visible = True
            Timer1.Start()
        End If
    End Sub

    Private Sub PopUpTimer_Tick(sender As Object, e As EventArgs) Handles PopUpTimer.Tick
        LabelTimer = LabelTimer + 1
        If LabelTimer > 10 Then
            LabelTimer = 0
            ScorePopup.Visible = False
            PopUpTimer.Stop()
        Else
            ScorePopup.Visible = True
        End If
    End Sub
End Class