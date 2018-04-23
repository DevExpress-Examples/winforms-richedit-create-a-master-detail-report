Namespace RichEditMasterDetailMailMerge
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.xtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
            Me.xtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
            Me.mainRichEdit = New DevExpress.XtraRichEdit.RichEditControl()
            Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
            Me.insertMergeFieldItem1 = New DevExpress.XtraRichEdit.UI.InsertMergeFieldItem()
            Me.showAllFieldCodesItem1 = New DevExpress.XtraRichEdit.UI.ShowAllFieldCodesItem()
            Me.showAllFieldResultsItem1 = New DevExpress.XtraRichEdit.UI.ShowAllFieldResultsItem()
            Me.toggleViewMergedDataItem1 = New DevExpress.XtraRichEdit.UI.ToggleViewMergedDataItem()
            Me.insertTableItem1 = New DevExpress.XtraRichEdit.UI.InsertTableItem()
            Me.insertPictureItem1 = New DevExpress.XtraRichEdit.UI.InsertPictureItem()
            Me.insertFloatingPictureItem1 = New DevExpress.XtraRichEdit.UI.InsertFloatingPictureItem()
            Me.insertBookmarkItem1 = New DevExpress.XtraRichEdit.UI.InsertBookmarkItem()
            Me.insertHyperlinkItem1 = New DevExpress.XtraRichEdit.UI.InsertHyperlinkItem()
            Me.editPageHeaderItem1 = New DevExpress.XtraRichEdit.UI.EditPageHeaderItem()
            Me.editPageFooterItem1 = New DevExpress.XtraRichEdit.UI.EditPageFooterItem()
            Me.insertPageNumberItem1 = New DevExpress.XtraRichEdit.UI.InsertPageNumberItem()
            Me.insertPageCountItem1 = New DevExpress.XtraRichEdit.UI.InsertPageCountItem()
            Me.insertTextBoxItem1 = New DevExpress.XtraRichEdit.UI.InsertTextBoxItem()
            Me.barButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
            Me.mailingsRibbonPage1 = New DevExpress.XtraRichEdit.UI.MailingsRibbonPage()
            Me.mailMergeRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.MailMergeRibbonPageGroup()
            Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.InsertRibbonPage1 = New DevExpress.XtraRichEdit.UI.InsertRibbonPage()
            Me.TablesRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.TablesRibbonPageGroup()
            Me.IllustrationsRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.IllustrationsRibbonPageGroup()
            Me.LinksRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.LinksRibbonPageGroup()
            Me.HeaderFooterRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.HeaderFooterRibbonPageGroup()
            Me.TextRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.TextRibbonPageGroup()
            Me.xtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
            Me.masterRichEdit = New DevExpress.XtraRichEdit.RichEditControl()
            Me.xtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
            Me.detailRichEdit = New DevExpress.XtraRichEdit.RichEditControl()
            Me.xtraTabPage4 = New DevExpress.XtraTab.XtraTabPage()
            Me.resultRichEdit = New DevExpress.XtraRichEdit.RichEditControl()
            Me.richEditBarController1 = New DevExpress.XtraRichEdit.UI.RichEditBarController()
            Me.defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
            CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.xtraTabControl1.SuspendLayout()
            Me.xtraTabPage1.SuspendLayout()
            CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.xtraTabPage2.SuspendLayout()
            Me.xtraTabPage3.SuspendLayout()
            Me.xtraTabPage4.SuspendLayout()
            CType(Me.richEditBarController1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'xtraTabControl1
            '
            Me.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xtraTabControl1.Location = New System.Drawing.Point(0, 146)
            Me.xtraTabControl1.Name = "xtraTabControl1"
            Me.xtraTabControl1.SelectedTabPage = Me.xtraTabPage1
            Me.xtraTabControl1.Size = New System.Drawing.Size(1032, 362)
            Me.xtraTabControl1.TabIndex = 0
            Me.xtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtraTabPage1, Me.xtraTabPage2, Me.xtraTabPage3, Me.xtraTabPage4})
            '
            'xtraTabPage1
            '
            Me.xtraTabPage1.Controls.Add(Me.mainRichEdit)
            Me.xtraTabPage1.Name = "xtraTabPage1"
            Me.xtraTabPage1.Size = New System.Drawing.Size(1030, 337)
            Me.xtraTabPage1.Tag = ""
            Me.xtraTabPage1.Text = "Main Template"
            '
            'mainRichEdit
            '
            Me.mainRichEdit.Dock = System.Windows.Forms.DockStyle.Fill
            Me.mainRichEdit.Location = New System.Drawing.Point(0, 0)
            Me.mainRichEdit.MenuManager = Me.ribbonControl1
            Me.mainRichEdit.Name = "mainRichEdit"
            Me.mainRichEdit.Size = New System.Drawing.Size(1030, 337)
            Me.mainRichEdit.TabIndex = 4
            Me.mainRichEdit.Text = "richEditControl1"
            '
            'ribbonControl1
            '
            Me.ribbonControl1.ExpandCollapseItem.Id = 0
            Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl1.ExpandCollapseItem, Me.insertMergeFieldItem1, Me.showAllFieldCodesItem1, Me.showAllFieldResultsItem1, Me.toggleViewMergedDataItem1, Me.insertTableItem1, Me.insertPictureItem1, Me.insertFloatingPictureItem1, Me.insertBookmarkItem1, Me.insertHyperlinkItem1, Me.editPageHeaderItem1, Me.editPageFooterItem1, Me.insertPageNumberItem1, Me.insertPageCountItem1, Me.insertTextBoxItem1, Me.barButtonItem1})
            Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
            Me.ribbonControl1.MaxItemId = 73
            Me.ribbonControl1.Name = "ribbonControl1"
            Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.mailingsRibbonPage1, Me.InsertRibbonPage1})
            Me.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013
            Me.ribbonControl1.Size = New System.Drawing.Size(1032, 146)
            '
            'insertMergeFieldItem1
            '
            Me.insertMergeFieldItem1.Id = 1
            Me.insertMergeFieldItem1.Name = "insertMergeFieldItem1"
            '
            'showAllFieldCodesItem1
            '
            Me.showAllFieldCodesItem1.Id = 2
            Me.showAllFieldCodesItem1.Name = "showAllFieldCodesItem1"
            '
            'showAllFieldResultsItem1
            '
            Me.showAllFieldResultsItem1.Id = 3
            Me.showAllFieldResultsItem1.Name = "showAllFieldResultsItem1"
            '
            'toggleViewMergedDataItem1
            '
            Me.toggleViewMergedDataItem1.Id = 4
            Me.toggleViewMergedDataItem1.Name = "toggleViewMergedDataItem1"
            '
            'insertTableItem1
            '
            Me.insertTableItem1.Id = 6
            Me.insertTableItem1.Name = "insertTableItem1"
            '
            'insertPictureItem1
            '
            Me.insertPictureItem1.Id = 7
            Me.insertPictureItem1.Name = "insertPictureItem1"
            '
            'insertFloatingPictureItem1
            '
            Me.insertFloatingPictureItem1.Id = 8
            Me.insertFloatingPictureItem1.Name = "insertFloatingPictureItem1"
            '
            'insertBookmarkItem1
            '
            Me.insertBookmarkItem1.Id = 9
            Me.insertBookmarkItem1.Name = "insertBookmarkItem1"
            '
            'insertHyperlinkItem1
            '
            Me.insertHyperlinkItem1.Id = 10
            Me.insertHyperlinkItem1.Name = "insertHyperlinkItem1"
            '
            'editPageHeaderItem1
            '
            Me.editPageHeaderItem1.Id = 11
            Me.editPageHeaderItem1.Name = "editPageHeaderItem1"
            '
            'editPageFooterItem1
            '
            Me.editPageFooterItem1.Id = 12
            Me.editPageFooterItem1.Name = "editPageFooterItem1"
            '
            'insertPageNumberItem1
            '
            Me.insertPageNumberItem1.Id = 13
            Me.insertPageNumberItem1.Name = "insertPageNumberItem1"
            '
            'insertPageCountItem1
            '
            Me.insertPageCountItem1.Id = 14
            Me.insertPageCountItem1.Name = "insertPageCountItem1"
            '
            'insertTextBoxItem1
            '
            Me.insertTextBoxItem1.Id = 15
            Me.insertTextBoxItem1.Name = "insertTextBoxItem1"
            '
            'barButtonItem1
            '
            Me.barButtonItem1.Caption = "Generate Report"
            Me.barButtonItem1.Glyph = CType(resources.GetObject("barButtonItem1.Glyph"), System.Drawing.Image)
            Me.barButtonItem1.Id = 72
            Me.barButtonItem1.LargeGlyph = CType(resources.GetObject("barButtonItem1.LargeGlyph"), System.Drawing.Image)
            Me.barButtonItem1.Name = "barButtonItem1"
            '
            'mailingsRibbonPage1
            '
            Me.mailingsRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.mailMergeRibbonPageGroup1, Me.ribbonPageGroup1})
            Me.mailingsRibbonPage1.Name = "mailingsRibbonPage1"
            '
            'mailMergeRibbonPageGroup1
            '
            Me.mailMergeRibbonPageGroup1.ItemLinks.Add(Me.insertMergeFieldItem1)
            Me.mailMergeRibbonPageGroup1.ItemLinks.Add(Me.showAllFieldCodesItem1)
            Me.mailMergeRibbonPageGroup1.ItemLinks.Add(Me.showAllFieldResultsItem1)
            Me.mailMergeRibbonPageGroup1.ItemLinks.Add(Me.toggleViewMergedDataItem1, "P")
            Me.mailMergeRibbonPageGroup1.Name = "mailMergeRibbonPageGroup1"
            '
            'ribbonPageGroup1
            '
            Me.ribbonPageGroup1.ItemLinks.Add(Me.barButtonItem1)
            Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
            Me.ribbonPageGroup1.Text = "Actions"
            '
            'InsertRibbonPage1
            '
            Me.InsertRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.TablesRibbonPageGroup1, Me.IllustrationsRibbonPageGroup1, Me.LinksRibbonPageGroup1, Me.HeaderFooterRibbonPageGroup1, Me.TextRibbonPageGroup1})
            Me.InsertRibbonPage1.Name = "InsertRibbonPage1"
            '
            'TablesRibbonPageGroup1
            '
            Me.TablesRibbonPageGroup1.AllowTextClipping = False
            Me.TablesRibbonPageGroup1.ItemLinks.Add(Me.insertTableItem1)
            Me.TablesRibbonPageGroup1.Name = "TablesRibbonPageGroup1"
            '
            'IllustrationsRibbonPageGroup1
            '
            Me.IllustrationsRibbonPageGroup1.ItemLinks.Add(Me.insertPictureItem1)
            Me.IllustrationsRibbonPageGroup1.ItemLinks.Add(Me.insertFloatingPictureItem1)
            Me.IllustrationsRibbonPageGroup1.Name = "IllustrationsRibbonPageGroup1"
            '
            'LinksRibbonPageGroup1
            '
            Me.LinksRibbonPageGroup1.ItemLinks.Add(Me.insertBookmarkItem1)
            Me.LinksRibbonPageGroup1.ItemLinks.Add(Me.insertHyperlinkItem1)
            Me.LinksRibbonPageGroup1.Name = "LinksRibbonPageGroup1"
            '
            'HeaderFooterRibbonPageGroup1
            '
            Me.HeaderFooterRibbonPageGroup1.ItemLinks.Add(Me.editPageHeaderItem1)
            Me.HeaderFooterRibbonPageGroup1.ItemLinks.Add(Me.editPageFooterItem1)
            Me.HeaderFooterRibbonPageGroup1.ItemLinks.Add(Me.insertPageNumberItem1)
            Me.HeaderFooterRibbonPageGroup1.ItemLinks.Add(Me.insertPageCountItem1)
            Me.HeaderFooterRibbonPageGroup1.Name = "HeaderFooterRibbonPageGroup1"
            '
            'TextRibbonPageGroup1
            '
            Me.TextRibbonPageGroup1.Glyph = CType(resources.GetObject("TextRibbonPageGroup1.Glyph"), System.Drawing.Image)
            Me.TextRibbonPageGroup1.ItemLinks.Add(Me.insertTextBoxItem1)
            Me.TextRibbonPageGroup1.Name = "TextRibbonPageGroup1"
            '
            'xtraTabPage2
            '
            Me.xtraTabPage2.Controls.Add(Me.masterRichEdit)
            Me.xtraTabPage2.Name = "xtraTabPage2"
            Me.xtraTabPage2.Size = New System.Drawing.Size(1030, 337)
            Me.xtraTabPage2.Tag = ""
            Me.xtraTabPage2.Text = "Master (Categories)"
            '
            'masterRichEdit
            '
            Me.masterRichEdit.Dock = System.Windows.Forms.DockStyle.Fill
            Me.masterRichEdit.Location = New System.Drawing.Point(0, 0)
            Me.masterRichEdit.MenuManager = Me.ribbonControl1
            Me.masterRichEdit.Name = "masterRichEdit"
            Me.masterRichEdit.Size = New System.Drawing.Size(1030, 337)
            Me.masterRichEdit.TabIndex = 5
            Me.masterRichEdit.Text = "richEditControl2"
            '
            'xtraTabPage3
            '
            Me.xtraTabPage3.Controls.Add(Me.detailRichEdit)
            Me.xtraTabPage3.Name = "xtraTabPage3"
            Me.xtraTabPage3.Size = New System.Drawing.Size(1030, 337)
            Me.xtraTabPage3.Tag = ""
            Me.xtraTabPage3.Text = "Detail (Products)"
            '
            'detailRichEdit
            '
            Me.detailRichEdit.Dock = System.Windows.Forms.DockStyle.Fill
            Me.detailRichEdit.Location = New System.Drawing.Point(0, 0)
            Me.detailRichEdit.MenuManager = Me.ribbonControl1
            Me.detailRichEdit.Name = "detailRichEdit"
            Me.detailRichEdit.Size = New System.Drawing.Size(1030, 337)
            Me.detailRichEdit.TabIndex = 5
            Me.detailRichEdit.Text = "richEditControl3"
            '
            'xtraTabPage4
            '
            Me.xtraTabPage4.Controls.Add(Me.resultRichEdit)
            Me.xtraTabPage4.Name = "xtraTabPage4"
            Me.xtraTabPage4.Size = New System.Drawing.Size(1030, 337)
            Me.xtraTabPage4.Tag = ""
            Me.xtraTabPage4.Text = "Result"
            '
            'resultRichEdit
            '
            Me.resultRichEdit.Dock = System.Windows.Forms.DockStyle.Fill
            Me.resultRichEdit.Location = New System.Drawing.Point(0, 0)
            Me.resultRichEdit.MenuManager = Me.ribbonControl1
            Me.resultRichEdit.Name = "resultRichEdit"
            Me.resultRichEdit.Size = New System.Drawing.Size(1030, 337)
            Me.resultRichEdit.TabIndex = 5
            Me.resultRichEdit.Text = "richEditControl4"
            '
            'richEditBarController1
            '
            Me.richEditBarController1.BarItems.Add(Me.insertMergeFieldItem1)
            Me.richEditBarController1.BarItems.Add(Me.showAllFieldCodesItem1)
            Me.richEditBarController1.BarItems.Add(Me.showAllFieldResultsItem1)
            Me.richEditBarController1.BarItems.Add(Me.toggleViewMergedDataItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertTableItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertPictureItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertFloatingPictureItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertBookmarkItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertHyperlinkItem1)
            Me.richEditBarController1.BarItems.Add(Me.editPageHeaderItem1)
            Me.richEditBarController1.BarItems.Add(Me.editPageFooterItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertPageNumberItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertPageCountItem1)
            Me.richEditBarController1.BarItems.Add(Me.insertTextBoxItem1)
            Me.richEditBarController1.Control = Me.mainRichEdit
            '
            'defaultLookAndFeel1
            '
            Me.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful"
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1032, 508)
            Me.Controls.Add(Me.xtraTabControl1)
            Me.Controls.Add(Me.ribbonControl1)
            Me.Name = "Form1"
            Me.Ribbon = Me.ribbonControl1
            Me.Text = "Master-Detail Mail Merge Application"
            CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.xtraTabControl1.ResumeLayout(False)
            Me.xtraTabPage1.ResumeLayout(False)
            CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.xtraTabPage2.ResumeLayout(False)
            Me.xtraTabPage3.ResumeLayout(False)
            Me.xtraTabPage4.ResumeLayout(False)
            CType(Me.richEditBarController1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Private WithEvents xtraTabControl1 As DevExpress.XtraTab.XtraTabControl
        Private xtraTabPage1 As DevExpress.XtraTab.XtraTabPage
        Private xtraTabPage2 As DevExpress.XtraTab.XtraTabPage
        Private xtraTabPage3 As DevExpress.XtraTab.XtraTabPage
        Private xtraTabPage4 As DevExpress.XtraTab.XtraTabPage
        Private mainRichEdit As DevExpress.XtraRichEdit.RichEditControl
        Private ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
        Private insertMergeFieldItem1 As DevExpress.XtraRichEdit.UI.InsertMergeFieldItem
        Private showAllFieldCodesItem1 As DevExpress.XtraRichEdit.UI.ShowAllFieldCodesItem
        Private showAllFieldResultsItem1 As DevExpress.XtraRichEdit.UI.ShowAllFieldResultsItem
        Private toggleViewMergedDataItem1 As DevExpress.XtraRichEdit.UI.ToggleViewMergedDataItem
        Private insertTableItem1 As DevExpress.XtraRichEdit.UI.InsertTableItem
        Private insertPictureItem1 As DevExpress.XtraRichEdit.UI.InsertPictureItem
        Private insertFloatingPictureItem1 As DevExpress.XtraRichEdit.UI.InsertFloatingPictureItem
        Private insertBookmarkItem1 As DevExpress.XtraRichEdit.UI.InsertBookmarkItem
        Private insertHyperlinkItem1 As DevExpress.XtraRichEdit.UI.InsertHyperlinkItem
        Private editPageHeaderItem1 As DevExpress.XtraRichEdit.UI.EditPageHeaderItem
        Private editPageFooterItem1 As DevExpress.XtraRichEdit.UI.EditPageFooterItem
        Private insertPageNumberItem1 As DevExpress.XtraRichEdit.UI.InsertPageNumberItem
        Private insertPageCountItem1 As DevExpress.XtraRichEdit.UI.InsertPageCountItem
        Private insertTextBoxItem1 As DevExpress.XtraRichEdit.UI.InsertTextBoxItem
        Private mailingsRibbonPage1 As DevExpress.XtraRichEdit.UI.MailingsRibbonPage
        Private mailMergeRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.MailMergeRibbonPageGroup
        Private masterRichEdit As DevExpress.XtraRichEdit.RichEditControl
        Private detailRichEdit As DevExpress.XtraRichEdit.RichEditControl
        Private resultRichEdit As DevExpress.XtraRichEdit.RichEditControl
        Private richEditBarController1 As DevExpress.XtraRichEdit.UI.RichEditBarController
        Private WithEvents barButtonItem1 As DevExpress.XtraBars.BarButtonItem
        Private ribbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
        Friend WithEvents InsertRibbonPage1 As DevExpress.XtraRichEdit.UI.InsertRibbonPage
        Friend WithEvents TablesRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.TablesRibbonPageGroup
        Friend WithEvents IllustrationsRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.IllustrationsRibbonPageGroup
        Friend WithEvents LinksRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.LinksRibbonPageGroup
        Friend WithEvents HeaderFooterRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.HeaderFooterRibbonPageGroup
        Friend WithEvents TextRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.TextRibbonPageGroup
    End Class
End Namespace

