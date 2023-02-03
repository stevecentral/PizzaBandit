Module PizzaBanditGlobal
    Public Quit As Boolean
    Public Const defaultD As Integer = 0
    Public Const EasyD As Integer = 1
    Public Const MediumD As Integer = 2
    Public Const HardD As Integer = 3
    Public Const ReggieSelect As Integer = -1
    Public Const PeteSelect As Integer = -2
    Public Const SuzieSelect As Integer = -3
    Public CharacterSelect As Integer = -1
    Public CharacterDirectory As String
    Public AcronymString As String
    Public difficulty As Integer = defaultD
    Public cageSpeed As Integer = 0
    Public reggieSpeed As Integer = 0
    Public username As String
    Public Score As Integer
End Module
