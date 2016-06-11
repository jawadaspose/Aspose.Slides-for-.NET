﻿Imports System
Imports Aspose.Slides.Export
Imports Aspose.Slides

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Slides for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Slides for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace VisualBasic.Text
    Class ReplaceFontsExplicitly
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_Text()

            ' ExStart:ReplaceFontsExplicitly
            ' Load presentation
            Dim presentation As New Presentation(dataDir & Convert.ToString("Fonts.pptx"))

            ' Load source font to be replaced
            Dim sourceFont As IFontData = New FontData("Arial")

            ' Load the replacing font
            Dim destFont As IFontData = New FontData("Times New Roman")

            ' Replace the fonts
            presentation.FontsManager.ReplaceFont(sourceFont, destFont)

            ' ExEnd:ReplaceFontsExplicitly
            ' Save the presentation
            presentation.Save(dataDir & Convert.ToString("UpdatedFont.pptx"), SaveFormat.Pptx)
        End Sub
    End Class
End Namespace