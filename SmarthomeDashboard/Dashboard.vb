Imports Bunifu.DataViz

Public Class Dashboard

#Region "Dashboard Events"

#Region "Methods"

    Private Sub PlotData()

        ' AREA & LINE CHARTS
        Dim canvas1 As New Canvas
        Dim datapoin1 As New DataPoint(BunifuDataViz._type.Bunifu_area)

        datapoin1.addLabely("l1", "45")
        datapoin1.addLabely("l2", "60")
        datapoin1.addLabely("l3", "50")
        datapoin1.addLabely("l4", "80")
        datapoin1.addLabely("l5", "70")
        datapoin1.addLabely("l6", "90")
        datapoin1.addLabely("l7", "100")
        datapoin1.addLabely("l8", "95")
        datapoin1.addLabely("l9", "60")
        datapoin1.addLabely("l10", "45")

        canvas1.addData(datapoin1)

        Dim datapoin2 As New DataPoint(BunifuDataViz._type.Bunifu_line)
        datapoin2.addLabely("", "55")
        datapoin2.addLabely("", "70")
        datapoin2.addLabely("", "60")
        datapoin2.addLabely("", "90")
        datapoin2.addLabely("", "80")
        datapoin2.addLabely("", "100")
        datapoin2.addLabely("", "110")
        datapoin2.addLabely("", "105")
        datapoin2.addLabely("", "70")
        datapoin2.addLabely("", "55")

        canvas1.addData(datapoin2)
        BunifuDataViz1.Render(canvas1)

        'PIE CHART
        Dim canvas2 As New Canvas
        Dim datapoin3 As New DataPoint(BunifuDataViz._type.Bunifu_doughnut)

        datapoin3.addLabely("", "45")
        datapoin3.addLabely("", "60")
        datapoin3.addLabely("", "50")
        datapoin3.addLabely("", "80")
        datapoin3.addLabely("", "70")
        datapoin3.addLabely("", "90")

        canvas2.addData(datapoin3)
        BunifuDataViz2.Render(canvas2)

    End Sub

#End Region

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        BunifuDataViz1.colorSet.Add(Color.FromArgb(76, 131, 115))
        BunifuDataViz1.colorSet.Add(Color.FromArgb(116, 231, 148))
        BunifuDataViz2.colorSet.Add(Color.FromArgb(85, 159, 127))
        BunifuDataViz2.colorSet.Add(Color.FromArgb(70, 118, 126))
        BunifuDataViz2.colorSet.Add(Color.FromArgb(123, 197, 222))
        BunifuDataViz2.colorSet.Add(Color.FromArgb(92, 175, 188))
        BunifuDataViz2.colorSet.Add(Color.FromArgb(156, 222, 202))
        BunifuDataViz2.colorSet.Add(Color.FromArgb(113, 228, 146))

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Timer1.Stop()
        PlotData()

    End Sub

#End Region

End Class