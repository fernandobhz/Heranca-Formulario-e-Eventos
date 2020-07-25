Public Class Form2

    Private s As String

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(s As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.s = s
    End Sub

    'Public Delegate Sub B1Delegate()
    Protected Event BClicou(s As String) 'As B1Delegate

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        RaiseEvent BClicou("xyz")
    End Sub

End Class