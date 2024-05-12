Public Class GradingSheet
    Private Sub Panel3_Scroll(sender As Object, e As ScrollEventArgs)
        If e.ScrollOrientation = ScrollOrientation.VerticalScroll Then
            Panel3.VerticalScroll.Value = e.NewValue
        End If
    End Sub


End Class