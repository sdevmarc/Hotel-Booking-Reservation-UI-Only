Module SubModule
    Private active As Form
    Sub open(inp As Form)
        If active IsNot Nothing Then
            active.Close()
        End If
        active = inp
        active.Show()
    End Sub
End Module
