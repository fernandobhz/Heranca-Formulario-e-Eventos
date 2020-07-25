Public Class Form1
    Inherits Form2

    Public Sub New()
        'MyBase.New("sttt")
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Sub b1_clicou(y As String) Handles Me.BClicou
        MsgBox("b1 clicou" & y)
    End Sub
End Class
