Imports iTextSharp.text.pdf
Imports iTextSharp.text.pdf.parser
Imports System.Text

Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If (IsPostBack) Then
            Dim ruta As String
            Dim txtNumeroRuta, txtDensidad As String
            Dim posicionDens, posicionRuta As Integer
            Dim arrNumRuta() As String
            Dim arrDensidad() As String
            Dim limpiaDensidad As String
            ruta = "C:\Users\dessap.sav\source\repos\LeerPDF\PDFs\PTI151101TE5-FL-799509.pdf"
            Dim lector As New PdfReader(ruta)
            Dim paginas As Integer = lector.NumberOfPages
            Dim extrae As ITextExtractionStrategy = New iTextSharp.text.pdf.parser.SimpleTextExtractionStrategy()
            Dim text As String = PdfTextExtractor.GetTextFromPage(lector, 1, extrae)
            posicionDens = text.IndexOf("litros.")
            posicionDens = posicionDens + 7
            ' obtengo la posicion numerica del texto que se encuentra antes de los litros...
            posicionRuta = text.IndexOf("litros.")
            ' nos ubicamos en la posicion 
            posicionRuta = posicionRuta + 8
            arrNumRuta = text.Substring(posicionRuta).Split(" ")
            lblRuta.Text = arrNumRuta(0).ToString

            posicionDens = text.IndexOf("DENSIDAD")
            posicionDens = posicionDens + 9
            arrDensidad = text.Substring(posicionDens).Split(vbLf)
            lblDensidad.Text = arrDensidad(0)
            TXTPDF.Text = text
        End If
    End Sub

End Class