Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraRichEdit.API.Native
Imports DevExpress.XtraTab
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Globalization
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace RichEditMasterDetailMailMerge
    Partial Public Class Form1
        Inherits RibbonForm

        Private xmlDataSet As DataSet
        Private products As DataTable
        Private categories As DataTable
        Private cultureInfo As CultureInfo


        Public Sub New()
            InitializeComponent()

            'Subscribe to the CalculateDocumentVariable event that triggers the master-detail report generation
            AddHandler resultRichEdit.CalculateDocumentVariable, AddressOf ResultRichEdit_CalculateDocumentVariable
            cultureInfo = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")

            'Link all RichEditControls to TabPages
            xtraTabPage1.Tag = mainRichEdit
            xtraTabPage2.Tag = masterRichEdit
            xtraTabPage3.Tag = detailRichEdit
            xtraTabPage4.Tag = resultRichEdit
        End Sub
        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            'Load main template, master and detail documents to the corresponding RichEditCotnrols:
            mainRichEdit.LoadDocument("Templates\Template.rtf")
            masterRichEdit.LoadDocument("Templates\Master.rtf")
            detailRichEdit.LoadDocument("Templates\Detail.rtf")

            'Initialize and fill the dataset:
            xmlDataSet = New DataSet()
            xmlDataSet.ReadXml("nwind.xml")

            'Fill the required data tables:
            categories = xmlDataSet.Tables("Categories")
            products = xmlDataSet.Tables("Products")
        End Sub

#Region "#start"
        Private Sub barButtonItem1_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barButtonItem1.ItemClick
            'The mail merge won't start without a data source. The main template do not require using any data, 
            'so provide it with a mock data: 
            mainRichEdit.Options.MailMerge.DataSource = CreateFakeDataSource()

            'Start the mail merging process and pass the result to the resultRichEdit.
            'When the mail merge starts, the CalculateDocumentVariable raises:
            mainRichEdit.MailMerge(resultRichEdit.Document)

            xtraTabControl1.SelectedTabPage = xtraTabPage4
        End Sub
#End Region ' #start

#Region "#master"
        Private Sub ResultRichEdit_CalculateDocumentVariable(ByVal sender As Object, ByVal e As CalculateDocumentVariableEventArgs)
            'Check whether the event is raised to the required field:
            If e.VariableName = "Categories" Then
                'Provide the data source for the next document part:
                masterRichEdit.Options.MailMerge.DataSource = categories

                'Create a new RichEditDocumentServer for further processing:
                Dim result As IRichEditDocumentServer = masterRichEdit.CreateDocumentServer()

                'Subscribe the new instance to the CalculateDocumentVariable event to handle the detail part: 
                AddHandler result.CalculateDocumentVariable, AddressOf result_CalculateDocumentVariable

                'Set additional mail merge options if necessary:
                Dim options As MailMergeOptions = masterRichEdit.CreateMailMergeOptions()
                options.LastRecordIndex = 4

                'Merge the document and pass it to the RichEditDocumentServer:
                masterRichEdit.MailMerge(options, result.Document)
                RemoveHandler result.CalculateDocumentVariable, AddressOf result_CalculateDocumentVariable

                e.Value = result
                e.Handled = True
            End If

        End Sub
#End Region ' #master

#Region "#detail"
        Private Sub result_CalculateDocumentVariable(ByVal sender As Object, ByVal e As CalculateDocumentVariableEventArgs)
            'Check whether the event is raised for the required field
            If e.VariableName = "Products" Then
                'Provide the detail part with the data source:
                detailRichEdit.Options.MailMerge.DataSource = products

                'Create an intermediate document server instance:
                Dim result As IRichEditDocumentServer = detailRichEdit.CreateDocumentServer()

                'Set the merged ranges delimitation and a number of records to be merged:
                Dim options As MailMergeOptions = detailRichEdit.CreateMailMergeOptions()
                options.MergeMode = MergeMode.JoinTables
                options.LastRecordIndex = 10

                'Provide a procedure for further processing:
                AddHandler result.CalculateDocumentVariable, AddressOf detail_CalculateDocumentVariable

                ' Create a merged document with a detail template: 
                detailRichEdit.MailMerge(options, result.Document)
                RemoveHandler result.CalculateDocumentVariable, AddressOf detail_CalculateDocumentVariable

                e.Value = result
                e.Handled = True
            End If

            'Format other merged fields:
            If e.VariableName = "LowestPrice" Then
                e.Value = String.Format(cultureInfo, "{0:C2}", products.Compute("Min(UnitPrice)", String.Empty))
                e.Handled = True
            End If
            If e.VariableName = "HighestPrice" Then
                e.Value = String.Format(cultureInfo, "{0:C2}", products.Compute("Max(UnitPrice)", String.Empty))
                e.Handled = True
            End If
            If e.VariableName = "ItemsCount" Then
                e.Value = products.Rows.Count
                e.Handled = True
            End If
        End Sub
#End Region ' #detail

#Region "#UnitPrice"
        Private Sub detail_CalculateDocumentVariable(ByVal sender As Object, ByVal e As CalculateDocumentVariableEventArgs)
            Dim productId As Integer = GetID(e.Arguments(0).Value)
            If productId = -1 Then
                Return
            End If

            'Format the UnitPrice field:
            If e.VariableName = "UnitPrice" Then
                Dim expression As String = String.Format("ProductID = {0}", productId)
                e.Value = String.Format(cultureInfo, "{0:C2}", products.Select(expression)(0)("UnitPrice"))
                e.Handled = True
            End If
        End Sub
#End Region 'UnitPrice


#Region "#Help"
        Protected Friend Overridable Function GetID(ByVal value As String) As Integer
            Dim result As Integer = Nothing
            If Int32.TryParse(value, result) Then
                Return result
            End If
            Return -1
        End Function

        Private Sub tabControl_SelectedPageChanged(ByVal sender As Object, ByVal e As TabPageChangedEventArgs) Handles xtraTabControl1.SelectedPageChanged
            Dim richEditControl As RichEditControl = CType(xtraTabControl1.SelectedTabPage.Tag, RichEditControl)
            richEditBarController1.RichEditControl = richEditControl

        End Sub
        Private Shared Function CreateFakeDataSource() As List(Of Integer)
            Dim result As New List(Of Integer)()
            result.Add(0)
            Return result
        End Function
#End Region ' #Help
    End Class
End Namespace