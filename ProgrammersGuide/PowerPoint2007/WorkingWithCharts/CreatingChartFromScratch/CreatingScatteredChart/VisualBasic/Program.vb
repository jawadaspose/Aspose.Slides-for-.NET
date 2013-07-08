'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Slides. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////

Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Slides
Imports Aspose.Slides.Pptx
Imports Aspose.Slides.Pptx.Charts

Namespace CreatingScatteredChart
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			Dim pres As New PresentationEx()

			Dim slide As SlideEx = pres.Slides(0)

			'Creating the default chart
			Dim chart As ChartEx = slide.Shapes.AddChart(ChartTypeEx.ScatterWithSmoothLines, 0, 0, 400, 400)

			'Getting the default chart data worksheet index
			Dim defaultWorksheetIndex As Integer = 0

			'Accessing the chart data worksheet
			Dim fact As ChartDataCellFactory = chart.ChartData.ChartDataCellFactory

			'Delete demo series
			chart.ChartData.Series.Clear()

			'Add new series
			chart.ChartData.Series.Add(fact.GetCell(defaultWorksheetIndex, 1, 1, "Series 1"), chart.Type)
			chart.ChartData.Series.Add(fact.GetCell(defaultWorksheetIndex, 1, 3, "Series 2"), chart.Type)

			'Take first chart series
			Dim series As ChartSeriesEx = chart.ChartData.Series(0)

			'Add new point (1:3) there.
			series.XValues.Add(fact.GetCell(defaultWorksheetIndex, 2, 1, 1))
			series.YValues.Add(fact.GetCell(defaultWorksheetIndex, 2, 2, 3))

			'Add new point (2:10)
			series.XValues.Add(fact.GetCell(defaultWorksheetIndex, 3, 1, 2))
			series.YValues.Add(fact.GetCell(defaultWorksheetIndex, 3, 2, 10))

			'Edit the type of series
			series.Type = ChartTypeEx.ScatterWithStraightLinesAndMarkers

			'Changing the chart series marker
			series.MarkerSize = 10
			series.MarkerSymbol = MarkerStyleTypeEx.Star

			'Take second chart series
			series = chart.ChartData.Series(1)

			'Add new point (5:2) there.
			series.XValues.Add(fact.GetCell(defaultWorksheetIndex, 2, 3, 5))
			series.YValues.Add(fact.GetCell(defaultWorksheetIndex, 2, 4, 2))

			'Add new point (3:1)
			series.XValues.Add(fact.GetCell(defaultWorksheetIndex, 3, 3, 3))
			series.YValues.Add(fact.GetCell(defaultWorksheetIndex, 3, 4, 1))

			'Add new point (2:2)
			series.XValues.Add(fact.GetCell(defaultWorksheetIndex, 4, 3, 2))
			series.YValues.Add(fact.GetCell(defaultWorksheetIndex, 4, 4, 2))

			'Add new point (5:1)
			series.XValues.Add(fact.GetCell(defaultWorksheetIndex, 5, 3, 5))
			series.YValues.Add(fact.GetCell(defaultWorksheetIndex, 5, 4, 1))

			'Changing the chart series marker
			series.MarkerSize = 10
			series.MarkerSymbol = MarkerStyleTypeEx.Circle

			pres.Write(dataDir & "AsposeSeriesChart.pptx")

		End Sub
	End Class
End Namespace