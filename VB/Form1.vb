Imports System.Data
Imports System.Globalization
Imports System.IO
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraRichEdit.API.Native
Imports DevExpress.XtraTab

Namespace RichEditMasterDetailMailMerge
    Partial Public Class Form1
        Inherits RibbonForm

        Private xmlDataSet As DataSet
        Private cultureInfo As CultureInfo
        Private introductionHandled As Boolean
        Private introductionContent As RichEditDocumentServer

        Public Sub New()
            InitializeComponent()

            xtraTabPage1.Tag = mainRichEdit
            xtraTabPage2.Tag = resultRichEdit

            mainRichEdit.LoadDocument(Path.Combine("Templates", "template.docx"))

            xmlDataSet = New DataSet()
            xmlDataSet.ReadXml("nwind.xml")
            xmlDataSet.Tables("Categories").PrimaryKey =
                New DataColumn() {xmlDataSet.Tables("Categories").Columns("CategoryID")}
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        End Sub

        Private Sub barButtonItem1_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barButtonItem1.ItemClick
            ' Reset per-merge state
            introductionHandled = False
            introductionContent = Nothing

            Dim mailMergeOptions As MailMergeOptions = mainRichEdit.CreateMailMergeOptions()
            mailMergeOptions.DataSource = xmlDataSet
            mailMergeOptions.DataMember = "Categories"
            mailMergeOptions.MergeMode = MergeMode.NewSection
            mailMergeOptions.LastRecordIndex = 10

            AddHandler resultRichEdit.CalculateDocumentVariable, AddressOf ResultRichEdit_CalculateDocumentVariable

            mainRichEdit.MailMerge(mailMergeOptions, resultRichEdit.Document)
            xtraTabControl1.SelectedTabPage = xtraTabPage2
        End Sub

        Private Sub ResultRichEdit_CalculateDocumentVariable(ByVal sender As Object, ByVal e As CalculateDocumentVariableEventArgs)
            Select Case e.VariableName
                Case "ItemsNumber"
                    Dim itemCount = xmlDataSet.Tables("Products").Select("CategoryID=" & GetID(e.Arguments(0).Value)).Length
                    e.Value = itemCount
                    e.Handled = True

                Case "Picture"
                    Dim categoryId = GetID(e.Arguments(0).Value)
                    Dim row = xmlDataSet.Tables("Categories").Rows.Find(categoryId)
                    Dim imageBytes As Byte() = Nothing
                    If row IsNot Nothing Then
                        imageBytes = TryCast(row("Picture"), Byte())
                    End If

                    If imageBytes IsNot Nothing AndAlso imageBytes.Length > 0 Then
                        Dim imageProcessor As New RichEditDocumentServer
                        Dim image = imageProcessor.Document.Shapes.InsertPicture(
                            imageProcessor.Document.Range.Start,
                            DocumentImageSource.FromStream(New MemoryStream(imageBytes)))
                        image.TextWrapping = TextWrappingType.InLineWithText
                        e.Value = imageProcessor
                    Else
                        e.Value = "" ' Empty replacement
                    End If
                    e.Handled = True

                Case "Introduction"
                    If Not introductionHandled Then
                        introductionContent = New RichEditDocumentServer
                        introductionContent.Document.AppendDocumentContent(Path.Combine("Templates", "template-intro.rtf"))
                        e.Value = introductionContent
                        introductionHandled = True
                    Else
                        e.Value = "" ' Suppress subsequent occurrences
                    End If
                    e.Handled = True
            End Select
        End Sub

        Protected Friend Overridable Function GetID(ByVal value As String) As Integer
            Dim result As Integer
            If Int32.TryParse(value, result) Then
                Return result
            End If
            Return -1
        End Function

        Private Sub tabControl_SelectedPageChanged(ByVal sender As Object, ByVal e As TabPageChangedEventArgs) Handles xtraTabControl1.SelectedPageChanged
            Dim richEditControl As RichEditControl = CType(xtraTabControl1.SelectedTabPage.Tag, RichEditControl)
            richEditBarController1.RichEditControl = richEditControl
        End Sub
    End Class
End Namespace