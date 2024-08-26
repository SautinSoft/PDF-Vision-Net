Imports System
Imports System.IO
Imports SautinSoft.PdfVision
Imports System.Drawing

Namespace Sample
	Friend Class Program
		Shared Sub Main(ByVal args() As String)
			ConvertJpegToPdf()
		End Sub
		Public Shared Sub ConvertJpegToPdf()
			Dim inpFile As String = Path.GetFullPath("..\..\..\image-jpeg.jpg")
			Dim outFile As String = (New FileInfo("Result.pdf")).FullName
			' Before starting, we recommend to get a free 100-day key:
            ' https://sautinsoft.com/start-for-free/
            
            ' Apply the key here:
			' SautinSoft.PdfVision.SetLicense("...");

			Dim v As New PdfVision()
			Dim options As New ImageToPdfOptions()
			options.JpegQuality = 95

			Try
				v.ConvertImageToPdf(New String() {inpFile}, outFile, options)
				System.Diagnostics.Process.Start(New System.Diagnostics.ProcessStartInfo(outFile) With {.UseShellExecute = True})
			Catch ex As Exception
				Console.WriteLine($"Error: {ex.Message}")
				Console.ReadLine()
			End Try
		End Sub
	End Class
End Namespace
