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
            components = New ComponentModel.Container()
            Dim GalleryItemGroup1 As DevExpress.XtraBars.Ribbon.GalleryItemGroup = New DevExpress.XtraBars.Ribbon.GalleryItemGroup()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            xtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
            xtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
            mainRichEdit = New DevExpress.XtraRichEdit.RichEditControl()
            ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
            insertMergeFieldItem1 = New DevExpress.XtraRichEdit.UI.InsertMergeFieldItem()
            showAllFieldCodesItem1 = New DevExpress.XtraRichEdit.UI.ShowAllFieldCodesItem()
            showAllFieldResultsItem1 = New DevExpress.XtraRichEdit.UI.ShowAllFieldResultsItem()
            toggleViewMergedDataItem1 = New DevExpress.XtraRichEdit.UI.ToggleViewMergedDataItem()
            insertPageBreakItem21 = New DevExpress.XtraRichEdit.UI.InsertPageBreakItem2()
            insertTableItem1 = New DevExpress.XtraRichEdit.UI.InsertTableItem()
            insertPictureItem1 = New DevExpress.XtraRichEdit.UI.InsertPictureItem()
            insertFloatingPictureItem1 = New DevExpress.XtraRichEdit.UI.InsertFloatingPictureItem()
            insertBookmarkItem1 = New DevExpress.XtraRichEdit.UI.InsertBookmarkItem()
            insertHyperlinkItem1 = New DevExpress.XtraRichEdit.UI.InsertHyperlinkItem()
            editPageHeaderItem1 = New DevExpress.XtraRichEdit.UI.EditPageHeaderItem()
            editPageFooterItem1 = New DevExpress.XtraRichEdit.UI.EditPageFooterItem()
            insertPageNumberItem1 = New DevExpress.XtraRichEdit.UI.InsertPageNumberItem()
            insertPageCountItem1 = New DevExpress.XtraRichEdit.UI.InsertPageCountItem()
            insertTextBoxItem1 = New DevExpress.XtraRichEdit.UI.InsertTextBoxItem()
            insertSymbolItem1 = New DevExpress.XtraRichEdit.UI.InsertSymbolItem()
            toggleFirstRowItem1 = New DevExpress.XtraRichEdit.UI.ToggleFirstRowItem()
            toggleLastRowItem1 = New DevExpress.XtraRichEdit.UI.ToggleLastRowItem()
            toggleBandedRowsItem1 = New DevExpress.XtraRichEdit.UI.ToggleBandedRowsItem()
            toggleFirstColumnItem1 = New DevExpress.XtraRichEdit.UI.ToggleFirstColumnItem()
            toggleLastColumnItem1 = New DevExpress.XtraRichEdit.UI.ToggleLastColumnItem()
            toggleBandedColumnsItem1 = New DevExpress.XtraRichEdit.UI.ToggleBandedColumnsItem()
            galleryChangeTableStyleItem1 = New DevExpress.XtraRichEdit.UI.GalleryChangeTableStyleItem()
            changeTableBorderLineStyleItem1 = New DevExpress.XtraRichEdit.UI.ChangeTableBorderLineStyleItem()
            repositoryItemBorderLineStyle1 = New DevExpress.XtraRichEdit.Forms.Design.RepositoryItemBorderLineStyle()
            changeTableBorderLineWeightItem1 = New DevExpress.XtraRichEdit.UI.ChangeTableBorderLineWeightItem()
            repositoryItemBorderLineWeight1 = New DevExpress.XtraRichEdit.Forms.Design.RepositoryItemBorderLineWeight()
            changeTableBorderColorItem1 = New DevExpress.XtraRichEdit.UI.ChangeTableBorderColorItem()
            changeTableBordersItem1 = New DevExpress.XtraRichEdit.UI.ChangeTableBordersItem()
            toggleTableCellsBottomBorderItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomBorderItem()
            toggleTableCellsTopBorderItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsTopBorderItem()
            toggleTableCellsLeftBorderItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsLeftBorderItem()
            toggleTableCellsRightBorderItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsRightBorderItem()
            resetTableCellsAllBordersItem1 = New DevExpress.XtraRichEdit.UI.ResetTableCellsAllBordersItem()
            toggleTableCellsAllBordersItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsAllBordersItem()
            toggleTableCellsOutsideBorderItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsOutsideBorderItem()
            toggleTableCellsInsideBorderItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsInsideBorderItem()
            toggleTableCellsInsideHorizontalBorderItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsInsideHorizontalBorderItem()
            toggleTableCellsInsideVerticalBorderItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsInsideVerticalBorderItem()
            toggleShowTableGridLinesItem1 = New DevExpress.XtraRichEdit.UI.ToggleShowTableGridLinesItem()
            changeTableCellsShadingItem1 = New DevExpress.XtraRichEdit.UI.ChangeTableCellsShadingItem()
            selectTableElementsItem1 = New DevExpress.XtraRichEdit.UI.SelectTableElementsItem()
            selectTableCellItem1 = New DevExpress.XtraRichEdit.UI.SelectTableCellItem()
            selectTableColumnItem1 = New DevExpress.XtraRichEdit.UI.SelectTableColumnItem()
            selectTableRowItem1 = New DevExpress.XtraRichEdit.UI.SelectTableRowItem()
            selectTableItem1 = New DevExpress.XtraRichEdit.UI.SelectTableItem()
            showTablePropertiesFormItem1 = New DevExpress.XtraRichEdit.UI.ShowTablePropertiesFormItem()
            deleteTableElementsItem1 = New DevExpress.XtraRichEdit.UI.DeleteTableElementsItem()
            showDeleteTableCellsFormItem1 = New DevExpress.XtraRichEdit.UI.ShowDeleteTableCellsFormItem()
            deleteTableColumnsItem1 = New DevExpress.XtraRichEdit.UI.DeleteTableColumnsItem()
            deleteTableRowsItem1 = New DevExpress.XtraRichEdit.UI.DeleteTableRowsItem()
            deleteTableItem1 = New DevExpress.XtraRichEdit.UI.DeleteTableItem()
            insertTableRowAboveItem1 = New DevExpress.XtraRichEdit.UI.InsertTableRowAboveItem()
            insertTableRowBelowItem1 = New DevExpress.XtraRichEdit.UI.InsertTableRowBelowItem()
            insertTableColumnToLeftItem1 = New DevExpress.XtraRichEdit.UI.InsertTableColumnToLeftItem()
            insertTableColumnToRightItem1 = New DevExpress.XtraRichEdit.UI.InsertTableColumnToRightItem()
            mergeTableCellsItem1 = New DevExpress.XtraRichEdit.UI.MergeTableCellsItem()
            showSplitTableCellsForm1 = New DevExpress.XtraRichEdit.UI.ShowSplitTableCellsForm()
            splitTableItem1 = New DevExpress.XtraRichEdit.UI.SplitTableItem()
            toggleTableAutoFitItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableAutoFitItem()
            toggleTableAutoFitContentsItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableAutoFitContentsItem()
            toggleTableAutoFitWindowItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableAutoFitWindowItem()
            toggleTableFixedColumnWidthItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableFixedColumnWidthItem()
            toggleTableCellsTopLeftAlignmentItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsTopLeftAlignmentItem()
            toggleTableCellsMiddleLeftAlignmentItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsMiddleLeftAlignmentItem()
            toggleTableCellsBottomLeftAlignmentItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomLeftAlignmentItem()
            toggleTableCellsTopCenterAlignmentItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsTopCenterAlignmentItem()
            toggleTableCellsMiddleCenterAlignmentItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsMiddleCenterAlignmentItem()
            toggleTableCellsBottomCenterAlignmentItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomCenterAlignmentItem()
            toggleTableCellsTopRightAlignmentItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsTopRightAlignmentItem()
            toggleTableCellsMiddleRightAlignmentItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsMiddleRightAlignmentItem()
            toggleTableCellsBottomRightAlignmentItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomRightAlignmentItem()
            showTableOptionsFormItem1 = New DevExpress.XtraRichEdit.UI.ShowTableOptionsFormItem()
            barButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
            mailingsRibbonPage1 = New DevExpress.XtraRichEdit.UI.MailingsRibbonPage()
            mailMergeRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.MailMergeRibbonPageGroup()
            ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            insertRibbonPage1 = New DevExpress.XtraRichEdit.UI.InsertRibbonPage()
            pagesRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.PagesRibbonPageGroup()
            tablesRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.TablesRibbonPageGroup()
            illustrationsRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.IllustrationsRibbonPageGroup()
            linksRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.LinksRibbonPageGroup()
            headerFooterRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.HeaderFooterRibbonPageGroup()
            textRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.TextRibbonPageGroup()
            symbolsRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.SymbolsRibbonPageGroup()
            xtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
            resultRichEdit = New DevExpress.XtraRichEdit.RichEditControl()
            richEditBarController1 = New DevExpress.XtraRichEdit.UI.RichEditBarController(components)
            defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(components)
            CType(xtraTabControl1, ComponentModel.ISupportInitialize).BeginInit()
            xtraTabControl1.SuspendLayout()
            xtraTabPage1.SuspendLayout()
            CType(ribbonControl1, ComponentModel.ISupportInitialize).BeginInit()
            CType(repositoryItemBorderLineStyle1, ComponentModel.ISupportInitialize).BeginInit()
            CType(repositoryItemBorderLineWeight1, ComponentModel.ISupportInitialize).BeginInit()
            xtraTabPage2.SuspendLayout()
            CType(richEditBarController1, ComponentModel.ISupportInitialize).BeginInit()
            SuspendLayout()
            ' 
            ' xtraTabControl1
            ' 
            xtraTabControl1.Dock = DockStyle.Fill
            xtraTabControl1.Location = New Point(0, 308)
            xtraTabControl1.Margin = New Padding(6)
            xtraTabControl1.Name = "xtraTabControl1"
            xtraTabControl1.SelectedTabPage = xtraTabPage1
            xtraTabControl1.Size = New Size(1403, 559)
            xtraTabControl1.TabIndex = 0
            xtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {xtraTabPage1, xtraTabPage2})
            ' 
            ' xtraTabPage1
            ' 
            xtraTabPage1.Controls.Add(mainRichEdit)
            xtraTabPage1.Margin = New Padding(6)
            xtraTabPage1.Name = "xtraTabPage1"
            xtraTabPage1.Size = New Size(1399, 510)
            xtraTabPage1.Tag = ""
            xtraTabPage1.Text = "Main Template"
            ' 
            ' mainRichEdit
            ' 
            mainRichEdit.Dock = DockStyle.Fill
            mainRichEdit.Location = New Point(0, 0)
            mainRichEdit.Margin = New Padding(6)
            mainRichEdit.MenuManager = ribbonControl1
            mainRichEdit.Name = "mainRichEdit"
            mainRichEdit.Options.DocumentSaveOptions.CurrentFormat = DevExpress.XtraRichEdit.DocumentFormat.PlainText
            mainRichEdit.Size = New Size(1399, 510)
            mainRichEdit.TabIndex = 4
            mainRichEdit.Text = "richEditControl1"
            ' 
            ' ribbonControl1
            ' 
            ribbonControl1.EmptyAreaImageOptions.ImagePadding = New Padding(60, 58, 60, 58)
            ribbonControl1.ExpandCollapseItem.Id = 0
            ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {ribbonControl1.ExpandCollapseItem, insertMergeFieldItem1, showAllFieldCodesItem1, showAllFieldResultsItem1, toggleViewMergedDataItem1, insertPageBreakItem21, insertTableItem1, insertPictureItem1, insertFloatingPictureItem1, insertBookmarkItem1, insertHyperlinkItem1, editPageHeaderItem1, editPageFooterItem1, insertPageNumberItem1, insertPageCountItem1, insertTextBoxItem1, insertSymbolItem1, toggleFirstRowItem1, toggleLastRowItem1, toggleBandedRowsItem1, toggleFirstColumnItem1, toggleLastColumnItem1, toggleBandedColumnsItem1, galleryChangeTableStyleItem1, changeTableBorderLineStyleItem1, changeTableBorderLineWeightItem1, changeTableBorderColorItem1, changeTableBordersItem1, toggleTableCellsBottomBorderItem1, toggleTableCellsTopBorderItem1, toggleTableCellsLeftBorderItem1, toggleTableCellsRightBorderItem1, resetTableCellsAllBordersItem1, toggleTableCellsAllBordersItem1, toggleTableCellsOutsideBorderItem1, toggleTableCellsInsideBorderItem1, toggleTableCellsInsideHorizontalBorderItem1, toggleTableCellsInsideVerticalBorderItem1, toggleShowTableGridLinesItem1, changeTableCellsShadingItem1, selectTableElementsItem1, selectTableCellItem1, selectTableColumnItem1, selectTableRowItem1, selectTableItem1, showTablePropertiesFormItem1, deleteTableElementsItem1, showDeleteTableCellsFormItem1, deleteTableColumnsItem1, deleteTableRowsItem1, deleteTableItem1, insertTableRowAboveItem1, insertTableRowBelowItem1, insertTableColumnToLeftItem1, insertTableColumnToRightItem1, mergeTableCellsItem1, showSplitTableCellsForm1, splitTableItem1, toggleTableAutoFitItem1, toggleTableAutoFitContentsItem1, toggleTableAutoFitWindowItem1, toggleTableFixedColumnWidthItem1, toggleTableCellsTopLeftAlignmentItem1, toggleTableCellsMiddleLeftAlignmentItem1, toggleTableCellsBottomLeftAlignmentItem1, toggleTableCellsTopCenterAlignmentItem1, toggleTableCellsMiddleCenterAlignmentItem1, toggleTableCellsBottomCenterAlignmentItem1, toggleTableCellsTopRightAlignmentItem1, toggleTableCellsMiddleRightAlignmentItem1, toggleTableCellsBottomRightAlignmentItem1, showTableOptionsFormItem1, barButtonItem1})
            ribbonControl1.Location = New Point(0, 0)
            ribbonControl1.Margin = New Padding(6)
            ribbonControl1.MaxItemId = 73
            ribbonControl1.Name = "ribbonControl1"
            ribbonControl1.OptionsMenuMinWidth = 660
            ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {mailingsRibbonPage1, insertRibbonPage1})
            ribbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {repositoryItemBorderLineStyle1, repositoryItemBorderLineWeight1})
            ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013
            ribbonControl1.Size = New Size(1403, 308)
            ' 
            ' insertMergeFieldItem1
            ' 
            insertMergeFieldItem1.Id = 1
            insertMergeFieldItem1.Name = "insertMergeFieldItem1"
            ' 
            ' showAllFieldCodesItem1
            ' 
            showAllFieldCodesItem1.Id = 2
            showAllFieldCodesItem1.Name = "showAllFieldCodesItem1"
            ' 
            ' showAllFieldResultsItem1
            ' 
            showAllFieldResultsItem1.Id = 3
            showAllFieldResultsItem1.Name = "showAllFieldResultsItem1"
            ' 
            ' toggleViewMergedDataItem1
            ' 
            toggleViewMergedDataItem1.Id = 4
            toggleViewMergedDataItem1.Name = "toggleViewMergedDataItem1"
            ' 
            ' insertPageBreakItem21
            ' 
            insertPageBreakItem21.Id = 5
            insertPageBreakItem21.Name = "insertPageBreakItem21"
            ' 
            ' insertTableItem1
            ' 
            insertTableItem1.Id = 6
            insertTableItem1.Name = "insertTableItem1"
            ' 
            ' insertPictureItem1
            ' 
            insertPictureItem1.Id = 7
            insertPictureItem1.Name = "insertPictureItem1"
            ' 
            ' insertFloatingPictureItem1
            ' 
            insertFloatingPictureItem1.Id = 8
            insertFloatingPictureItem1.Name = "insertFloatingPictureItem1"
            ' 
            ' insertBookmarkItem1
            ' 
            insertBookmarkItem1.Id = 9
            insertBookmarkItem1.Name = "insertBookmarkItem1"
            ' 
            ' insertHyperlinkItem1
            ' 
            insertHyperlinkItem1.Id = 10
            insertHyperlinkItem1.Name = "insertHyperlinkItem1"
            ' 
            ' editPageHeaderItem1
            ' 
            editPageHeaderItem1.Id = 11
            editPageHeaderItem1.Name = "editPageHeaderItem1"
            ' 
            ' editPageFooterItem1
            ' 
            editPageFooterItem1.Id = 12
            editPageFooterItem1.Name = "editPageFooterItem1"
            ' 
            ' insertPageNumberItem1
            ' 
            insertPageNumberItem1.Id = 13
            insertPageNumberItem1.Name = "insertPageNumberItem1"
            ' 
            ' insertPageCountItem1
            ' 
            insertPageCountItem1.Id = 14
            insertPageCountItem1.Name = "insertPageCountItem1"
            ' 
            ' insertTextBoxItem1
            ' 
            insertTextBoxItem1.Id = 15
            insertTextBoxItem1.Name = "insertTextBoxItem1"
            ' 
            ' insertSymbolItem1
            ' 
            insertSymbolItem1.Id = 16
            insertSymbolItem1.Name = "insertSymbolItem1"
            ' 
            ' toggleFirstRowItem1
            ' 
            toggleFirstRowItem1.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
            toggleFirstRowItem1.Id = 17
            toggleFirstRowItem1.Name = "toggleFirstRowItem1"
            ' 
            ' toggleLastRowItem1
            ' 
            toggleLastRowItem1.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
            toggleLastRowItem1.Id = 18
            toggleLastRowItem1.Name = "toggleLastRowItem1"
            ' 
            ' toggleBandedRowsItem1
            ' 
            toggleBandedRowsItem1.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
            toggleBandedRowsItem1.Id = 19
            toggleBandedRowsItem1.Name = "toggleBandedRowsItem1"
            ' 
            ' toggleFirstColumnItem1
            ' 
            toggleFirstColumnItem1.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
            toggleFirstColumnItem1.Id = 20
            toggleFirstColumnItem1.Name = "toggleFirstColumnItem1"
            ' 
            ' toggleLastColumnItem1
            ' 
            toggleLastColumnItem1.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
            toggleLastColumnItem1.Id = 21
            toggleLastColumnItem1.Name = "toggleLastColumnItem1"
            ' 
            ' toggleBandedColumnsItem1
            ' 
            toggleBandedColumnsItem1.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
            toggleBandedColumnsItem1.Id = 22
            toggleBandedColumnsItem1.Name = "toggleBandedColumnsItem1"
            ' 
            ' galleryChangeTableStyleItem1
            ' 
            ' 
            ' 
            ' 
            galleryChangeTableStyleItem1.Gallery.ColumnCount = 3
            galleryChangeTableStyleItem1.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {GalleryItemGroup1})
            galleryChangeTableStyleItem1.Gallery.ImageSize = New Size(130, 88)
            galleryChangeTableStyleItem1.Id = 23
            galleryChangeTableStyleItem1.Name = "galleryChangeTableStyleItem1"
            ' 
            ' changeTableBorderLineStyleItem1
            ' 
            changeTableBorderLineStyleItem1.Edit = repositoryItemBorderLineStyle1
            changeTableBorderLineStyleItem1.EditWidth = 130
            changeTableBorderLineStyleItem1.Id = 24
            changeTableBorderLineStyleItem1.Name = "changeTableBorderLineStyleItem1"
            ' 
            ' repositoryItemBorderLineStyle1
            ' 
            repositoryItemBorderLineStyle1.AutoHeight = False
            repositoryItemBorderLineStyle1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            repositoryItemBorderLineStyle1.Control = mainRichEdit
            repositoryItemBorderLineStyle1.Name = "repositoryItemBorderLineStyle1"
            ' 
            ' changeTableBorderLineWeightItem1
            ' 
            changeTableBorderLineWeightItem1.Edit = repositoryItemBorderLineWeight1
            changeTableBorderLineWeightItem1.EditValue = 20
            changeTableBorderLineWeightItem1.EditWidth = 130
            changeTableBorderLineWeightItem1.Id = 25
            changeTableBorderLineWeightItem1.Name = "changeTableBorderLineWeightItem1"
            ' 
            ' repositoryItemBorderLineWeight1
            ' 
            repositoryItemBorderLineWeight1.AutoHeight = False
            repositoryItemBorderLineWeight1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            repositoryItemBorderLineWeight1.Control = mainRichEdit
            repositoryItemBorderLineWeight1.Name = "repositoryItemBorderLineWeight1"
            ' 
            ' changeTableBorderColorItem1
            ' 
            changeTableBorderColorItem1.Id = 26
            changeTableBorderColorItem1.Name = "changeTableBorderColorItem1"
            ' 
            ' changeTableBordersItem1
            ' 
            changeTableBordersItem1.Id = 27
            changeTableBordersItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(toggleTableCellsBottomBorderItem1), New DevExpress.XtraBars.LinkPersistInfo(toggleTableCellsTopBorderItem1), New DevExpress.XtraBars.LinkPersistInfo(toggleTableCellsLeftBorderItem1), New DevExpress.XtraBars.LinkPersistInfo(toggleTableCellsRightBorderItem1), New DevExpress.XtraBars.LinkPersistInfo(resetTableCellsAllBordersItem1, True), New DevExpress.XtraBars.LinkPersistInfo(toggleTableCellsAllBordersItem1), New DevExpress.XtraBars.LinkPersistInfo(toggleTableCellsOutsideBorderItem1), New DevExpress.XtraBars.LinkPersistInfo(toggleTableCellsInsideBorderItem1), New DevExpress.XtraBars.LinkPersistInfo(toggleTableCellsInsideHorizontalBorderItem1, True), New DevExpress.XtraBars.LinkPersistInfo(toggleTableCellsInsideVerticalBorderItem1), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.KeyTip, toggleShowTableGridLinesItem1, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.Standard, "TG", "")})
            changeTableBordersItem1.Name = "changeTableBordersItem1"
            ' 
            ' toggleTableCellsBottomBorderItem1
            ' 
            toggleTableCellsBottomBorderItem1.Id = 28
            toggleTableCellsBottomBorderItem1.Name = "toggleTableCellsBottomBorderItem1"
            ' 
            ' toggleTableCellsTopBorderItem1
            ' 
            toggleTableCellsTopBorderItem1.Id = 29
            toggleTableCellsTopBorderItem1.Name = "toggleTableCellsTopBorderItem1"
            ' 
            ' toggleTableCellsLeftBorderItem1
            ' 
            toggleTableCellsLeftBorderItem1.Id = 30
            toggleTableCellsLeftBorderItem1.Name = "toggleTableCellsLeftBorderItem1"
            ' 
            ' toggleTableCellsRightBorderItem1
            ' 
            toggleTableCellsRightBorderItem1.Id = 31
            toggleTableCellsRightBorderItem1.Name = "toggleTableCellsRightBorderItem1"
            ' 
            ' resetTableCellsAllBordersItem1
            ' 
            resetTableCellsAllBordersItem1.Id = 32
            resetTableCellsAllBordersItem1.Name = "resetTableCellsAllBordersItem1"
            ' 
            ' toggleTableCellsAllBordersItem1
            ' 
            toggleTableCellsAllBordersItem1.Id = 33
            toggleTableCellsAllBordersItem1.Name = "toggleTableCellsAllBordersItem1"
            ' 
            ' toggleTableCellsOutsideBorderItem1
            ' 
            toggleTableCellsOutsideBorderItem1.Id = 34
            toggleTableCellsOutsideBorderItem1.Name = "toggleTableCellsOutsideBorderItem1"
            ' 
            ' toggleTableCellsInsideBorderItem1
            ' 
            toggleTableCellsInsideBorderItem1.Id = 35
            toggleTableCellsInsideBorderItem1.Name = "toggleTableCellsInsideBorderItem1"
            ' 
            ' toggleTableCellsInsideHorizontalBorderItem1
            ' 
            toggleTableCellsInsideHorizontalBorderItem1.Id = 36
            toggleTableCellsInsideHorizontalBorderItem1.Name = "toggleTableCellsInsideHorizontalBorderItem1"
            ' 
            ' toggleTableCellsInsideVerticalBorderItem1
            ' 
            toggleTableCellsInsideVerticalBorderItem1.Id = 37
            toggleTableCellsInsideVerticalBorderItem1.Name = "toggleTableCellsInsideVerticalBorderItem1"
            ' 
            ' toggleShowTableGridLinesItem1
            ' 
            toggleShowTableGridLinesItem1.Id = 38
            toggleShowTableGridLinesItem1.Name = "toggleShowTableGridLinesItem1"
            ' 
            ' changeTableCellsShadingItem1
            ' 
            changeTableCellsShadingItem1.Id = 39
            changeTableCellsShadingItem1.Name = "changeTableCellsShadingItem1"
            ' 
            ' selectTableElementsItem1
            ' 
            selectTableElementsItem1.Id = 40
            selectTableElementsItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(selectTableCellItem1), New DevExpress.XtraBars.LinkPersistInfo(selectTableColumnItem1), New DevExpress.XtraBars.LinkPersistInfo(selectTableRowItem1), New DevExpress.XtraBars.LinkPersistInfo(selectTableItem1)})
            selectTableElementsItem1.Name = "selectTableElementsItem1"
            ' 
            ' selectTableCellItem1
            ' 
            selectTableCellItem1.Id = 41
            selectTableCellItem1.Name = "selectTableCellItem1"
            ' 
            ' selectTableColumnItem1
            ' 
            selectTableColumnItem1.Id = 42
            selectTableColumnItem1.Name = "selectTableColumnItem1"
            ' 
            ' selectTableRowItem1
            ' 
            selectTableRowItem1.Id = 43
            selectTableRowItem1.Name = "selectTableRowItem1"
            ' 
            ' selectTableItem1
            ' 
            selectTableItem1.Id = 44
            selectTableItem1.Name = "selectTableItem1"
            ' 
            ' showTablePropertiesFormItem1
            ' 
            showTablePropertiesFormItem1.Id = 45
            showTablePropertiesFormItem1.Name = "showTablePropertiesFormItem1"
            ' 
            ' deleteTableElementsItem1
            ' 
            deleteTableElementsItem1.Id = 46
            deleteTableElementsItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(showDeleteTableCellsFormItem1), New DevExpress.XtraBars.LinkPersistInfo(deleteTableColumnsItem1), New DevExpress.XtraBars.LinkPersistInfo(deleteTableRowsItem1), New DevExpress.XtraBars.LinkPersistInfo(deleteTableItem1)})
            deleteTableElementsItem1.Name = "deleteTableElementsItem1"
            ' 
            ' showDeleteTableCellsFormItem1
            ' 
            showDeleteTableCellsFormItem1.Id = 47
            showDeleteTableCellsFormItem1.Name = "showDeleteTableCellsFormItem1"
            ' 
            ' deleteTableColumnsItem1
            ' 
            deleteTableColumnsItem1.Id = 48
            deleteTableColumnsItem1.Name = "deleteTableColumnsItem1"
            ' 
            ' deleteTableRowsItem1
            ' 
            deleteTableRowsItem1.Id = 49
            deleteTableRowsItem1.Name = "deleteTableRowsItem1"
            ' 
            ' deleteTableItem1
            ' 
            deleteTableItem1.Id = 50
            deleteTableItem1.Name = "deleteTableItem1"
            ' 
            ' insertTableRowAboveItem1
            ' 
            insertTableRowAboveItem1.Id = 51
            insertTableRowAboveItem1.Name = "insertTableRowAboveItem1"
            ' 
            ' insertTableRowBelowItem1
            ' 
            insertTableRowBelowItem1.Id = 52
            insertTableRowBelowItem1.Name = "insertTableRowBelowItem1"
            ' 
            ' insertTableColumnToLeftItem1
            ' 
            insertTableColumnToLeftItem1.Id = 53
            insertTableColumnToLeftItem1.Name = "insertTableColumnToLeftItem1"
            ' 
            ' insertTableColumnToRightItem1
            ' 
            insertTableColumnToRightItem1.Id = 54
            insertTableColumnToRightItem1.Name = "insertTableColumnToRightItem1"
            ' 
            ' mergeTableCellsItem1
            ' 
            mergeTableCellsItem1.Id = 55
            mergeTableCellsItem1.Name = "mergeTableCellsItem1"
            ' 
            ' showSplitTableCellsForm1
            ' 
            showSplitTableCellsForm1.Id = 56
            showSplitTableCellsForm1.Name = "showSplitTableCellsForm1"
            ' 
            ' splitTableItem1
            ' 
            splitTableItem1.Id = 57
            splitTableItem1.Name = "splitTableItem1"
            ' 
            ' toggleTableAutoFitItem1
            ' 
            toggleTableAutoFitItem1.Id = 58
            toggleTableAutoFitItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(toggleTableAutoFitContentsItem1), New DevExpress.XtraBars.LinkPersistInfo(toggleTableAutoFitWindowItem1), New DevExpress.XtraBars.LinkPersistInfo(toggleTableFixedColumnWidthItem1)})
            toggleTableAutoFitItem1.Name = "toggleTableAutoFitItem1"
            ' 
            ' toggleTableAutoFitContentsItem1
            ' 
            toggleTableAutoFitContentsItem1.Id = 59
            toggleTableAutoFitContentsItem1.Name = "toggleTableAutoFitContentsItem1"
            ' 
            ' toggleTableAutoFitWindowItem1
            ' 
            toggleTableAutoFitWindowItem1.Id = 60
            toggleTableAutoFitWindowItem1.Name = "toggleTableAutoFitWindowItem1"
            ' 
            ' toggleTableFixedColumnWidthItem1
            ' 
            toggleTableFixedColumnWidthItem1.Id = 61
            toggleTableFixedColumnWidthItem1.Name = "toggleTableFixedColumnWidthItem1"
            ' 
            ' toggleTableCellsTopLeftAlignmentItem1
            ' 
            toggleTableCellsTopLeftAlignmentItem1.Id = 62
            toggleTableCellsTopLeftAlignmentItem1.Name = "toggleTableCellsTopLeftAlignmentItem1"
            ' 
            ' toggleTableCellsMiddleLeftAlignmentItem1
            ' 
            toggleTableCellsMiddleLeftAlignmentItem1.Id = 63
            toggleTableCellsMiddleLeftAlignmentItem1.Name = "toggleTableCellsMiddleLeftAlignmentItem1"
            ' 
            ' toggleTableCellsBottomLeftAlignmentItem1
            ' 
            toggleTableCellsBottomLeftAlignmentItem1.Id = 64
            toggleTableCellsBottomLeftAlignmentItem1.Name = "toggleTableCellsBottomLeftAlignmentItem1"
            ' 
            ' toggleTableCellsTopCenterAlignmentItem1
            ' 
            toggleTableCellsTopCenterAlignmentItem1.Id = 65
            toggleTableCellsTopCenterAlignmentItem1.Name = "toggleTableCellsTopCenterAlignmentItem1"
            ' 
            ' toggleTableCellsMiddleCenterAlignmentItem1
            ' 
            toggleTableCellsMiddleCenterAlignmentItem1.Id = 66
            toggleTableCellsMiddleCenterAlignmentItem1.Name = "toggleTableCellsMiddleCenterAlignmentItem1"
            ' 
            ' toggleTableCellsBottomCenterAlignmentItem1
            ' 
            toggleTableCellsBottomCenterAlignmentItem1.Id = 67
            toggleTableCellsBottomCenterAlignmentItem1.Name = "toggleTableCellsBottomCenterAlignmentItem1"
            ' 
            ' toggleTableCellsTopRightAlignmentItem1
            ' 
            toggleTableCellsTopRightAlignmentItem1.Id = 68
            toggleTableCellsTopRightAlignmentItem1.Name = "toggleTableCellsTopRightAlignmentItem1"
            ' 
            ' toggleTableCellsMiddleRightAlignmentItem1
            ' 
            toggleTableCellsMiddleRightAlignmentItem1.Id = 69
            toggleTableCellsMiddleRightAlignmentItem1.Name = "toggleTableCellsMiddleRightAlignmentItem1"
            ' 
            ' toggleTableCellsBottomRightAlignmentItem1
            ' 
            toggleTableCellsBottomRightAlignmentItem1.Id = 70
            toggleTableCellsBottomRightAlignmentItem1.Name = "toggleTableCellsBottomRightAlignmentItem1"
            ' 
            ' showTableOptionsFormItem1
            ' 
            showTableOptionsFormItem1.Id = 71
            showTableOptionsFormItem1.Name = "showTableOptionsFormItem1"
            ' 
            ' barButtonItem1
            ' 
            barButtonItem1.Caption = "Generate Report"
            barButtonItem1.Id = 72
            barButtonItem1.ImageOptions.Image = CType(resources.GetObject("barButtonItem1.ImageOptions.Image"), Image)
            barButtonItem1.ImageOptions.LargeImage = CType(resources.GetObject("barButtonItem1.ImageOptions.LargeImage"), Image)
            barButtonItem1.Name = "barButtonItem1"
            ' 
            ' mailingsRibbonPage1
            ' 
            mailingsRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {mailMergeRibbonPageGroup1, ribbonPageGroup1})
            mailingsRibbonPage1.Name = "mailingsRibbonPage1"
            ' 
            ' mailMergeRibbonPageGroup1
            ' 
            mailMergeRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False
            mailMergeRibbonPageGroup1.ItemLinks.Add(insertMergeFieldItem1)
            mailMergeRibbonPageGroup1.ItemLinks.Add(showAllFieldCodesItem1)
            mailMergeRibbonPageGroup1.ItemLinks.Add(showAllFieldResultsItem1)
            mailMergeRibbonPageGroup1.ItemLinks.Add(toggleViewMergedDataItem1, "P")
            mailMergeRibbonPageGroup1.Name = "mailMergeRibbonPageGroup1"
            ' 
            ' ribbonPageGroup1
            ' 
            ribbonPageGroup1.ItemLinks.Add(barButtonItem1)
            ribbonPageGroup1.Name = "ribbonPageGroup1"
            ribbonPageGroup1.Text = "Actions"
            ' 
            ' insertRibbonPage1
            ' 
            insertRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {pagesRibbonPageGroup1, tablesRibbonPageGroup1, illustrationsRibbonPageGroup1, linksRibbonPageGroup1, headerFooterRibbonPageGroup1, textRibbonPageGroup1, symbolsRibbonPageGroup1})
            insertRibbonPage1.Name = "insertRibbonPage1"
            ' 
            ' pagesRibbonPageGroup1
            ' 
            pagesRibbonPageGroup1.AllowTextClipping = False
            pagesRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False
            pagesRibbonPageGroup1.ItemLinks.Add(insertPageBreakItem21, "B")
            pagesRibbonPageGroup1.Name = "pagesRibbonPageGroup1"
            ' 
            ' tablesRibbonPageGroup1
            ' 
            tablesRibbonPageGroup1.AllowTextClipping = False
            tablesRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False
            tablesRibbonPageGroup1.ItemLinks.Add(insertTableItem1, "T")
            tablesRibbonPageGroup1.Name = "tablesRibbonPageGroup1"
            ' 
            ' illustrationsRibbonPageGroup1
            ' 
            illustrationsRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False
            illustrationsRibbonPageGroup1.ItemLinks.Add(insertPictureItem1, "P")
            illustrationsRibbonPageGroup1.ItemLinks.Add(insertFloatingPictureItem1)
            illustrationsRibbonPageGroup1.Name = "illustrationsRibbonPageGroup1"
            ' 
            ' linksRibbonPageGroup1
            ' 
            linksRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False
            linksRibbonPageGroup1.ItemLinks.Add(insertBookmarkItem1, "K")
            linksRibbonPageGroup1.ItemLinks.Add(insertHyperlinkItem1, "I")
            linksRibbonPageGroup1.Name = "linksRibbonPageGroup1"
            ' 
            ' headerFooterRibbonPageGroup1
            ' 
            headerFooterRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False
            headerFooterRibbonPageGroup1.ItemLinks.Add(editPageHeaderItem1, "H")
            headerFooterRibbonPageGroup1.ItemLinks.Add(editPageFooterItem1, "O")
            headerFooterRibbonPageGroup1.ItemLinks.Add(insertPageNumberItem1, "NU")
            headerFooterRibbonPageGroup1.ItemLinks.Add(insertPageCountItem1)
            headerFooterRibbonPageGroup1.Name = "headerFooterRibbonPageGroup1"
            ' 
            ' textRibbonPageGroup1
            ' 
            textRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False
            textRibbonPageGroup1.ItemLinks.Add(insertTextBoxItem1, "X")
            textRibbonPageGroup1.Name = "textRibbonPageGroup1"
            ' 
            ' symbolsRibbonPageGroup1
            ' 
            symbolsRibbonPageGroup1.AllowTextClipping = False
            symbolsRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False
            symbolsRibbonPageGroup1.ItemLinks.Add(insertSymbolItem1, "U")
            symbolsRibbonPageGroup1.Name = "symbolsRibbonPageGroup1"
            ' 
            ' xtraTabPage2
            ' 
            xtraTabPage2.Controls.Add(resultRichEdit)
            xtraTabPage2.Margin = New Padding(6)
            xtraTabPage2.Name = "xtraTabPage2"
            xtraTabPage2.Size = New Size(1399, 510)
            xtraTabPage2.Tag = ""
            xtraTabPage2.Text = "Result"
            ' 
            ' resultRichEdit
            ' 
            resultRichEdit.Dock = DockStyle.Fill
            resultRichEdit.Location = New Point(0, 0)
            resultRichEdit.Margin = New Padding(6)
            resultRichEdit.MenuManager = ribbonControl1
            resultRichEdit.Name = "resultRichEdit"
            resultRichEdit.Options.DocumentSaveOptions.CurrentFormat = DevExpress.XtraRichEdit.DocumentFormat.PlainText
            resultRichEdit.Size = New Size(1399, 510)
            resultRichEdit.TabIndex = 5
            resultRichEdit.Text = "richEditControl2"
            ' 
            ' richEditBarController1
            ' 
            richEditBarController1.BarItems.Add(insertMergeFieldItem1)
            richEditBarController1.BarItems.Add(showAllFieldCodesItem1)
            richEditBarController1.BarItems.Add(showAllFieldResultsItem1)
            richEditBarController1.BarItems.Add(toggleViewMergedDataItem1)
            richEditBarController1.BarItems.Add(insertPageBreakItem21)
            richEditBarController1.BarItems.Add(insertTableItem1)
            richEditBarController1.BarItems.Add(insertPictureItem1)
            richEditBarController1.BarItems.Add(insertFloatingPictureItem1)
            richEditBarController1.BarItems.Add(insertBookmarkItem1)
            richEditBarController1.BarItems.Add(insertHyperlinkItem1)
            richEditBarController1.BarItems.Add(editPageHeaderItem1)
            richEditBarController1.BarItems.Add(editPageFooterItem1)
            richEditBarController1.BarItems.Add(insertPageNumberItem1)
            richEditBarController1.BarItems.Add(insertPageCountItem1)
            richEditBarController1.BarItems.Add(insertTextBoxItem1)
            richEditBarController1.BarItems.Add(insertSymbolItem1)
            richEditBarController1.BarItems.Add(toggleFirstRowItem1)
            richEditBarController1.BarItems.Add(toggleLastRowItem1)
            richEditBarController1.BarItems.Add(toggleBandedRowsItem1)
            richEditBarController1.BarItems.Add(toggleFirstColumnItem1)
            richEditBarController1.BarItems.Add(toggleLastColumnItem1)
            richEditBarController1.BarItems.Add(toggleBandedColumnsItem1)
            richEditBarController1.BarItems.Add(galleryChangeTableStyleItem1)
            richEditBarController1.BarItems.Add(changeTableBorderLineStyleItem1)
            richEditBarController1.BarItems.Add(changeTableBorderLineWeightItem1)
            richEditBarController1.BarItems.Add(changeTableBorderColorItem1)
            richEditBarController1.BarItems.Add(changeTableBordersItem1)
            richEditBarController1.BarItems.Add(toggleTableCellsBottomBorderItem1)
            richEditBarController1.BarItems.Add(toggleTableCellsTopBorderItem1)
            richEditBarController1.BarItems.Add(toggleTableCellsLeftBorderItem1)
            richEditBarController1.BarItems.Add(toggleTableCellsRightBorderItem1)
            richEditBarController1.BarItems.Add(resetTableCellsAllBordersItem1)
            richEditBarController1.BarItems.Add(toggleTableCellsAllBordersItem1)
            richEditBarController1.BarItems.Add(toggleTableCellsOutsideBorderItem1)
            richEditBarController1.BarItems.Add(toggleTableCellsInsideBorderItem1)
            richEditBarController1.BarItems.Add(toggleTableCellsInsideHorizontalBorderItem1)
            richEditBarController1.BarItems.Add(toggleTableCellsInsideVerticalBorderItem1)
            richEditBarController1.BarItems.Add(toggleShowTableGridLinesItem1)
            richEditBarController1.BarItems.Add(changeTableCellsShadingItem1)
            richEditBarController1.BarItems.Add(selectTableElementsItem1)
            richEditBarController1.BarItems.Add(selectTableCellItem1)
            richEditBarController1.BarItems.Add(selectTableColumnItem1)
            richEditBarController1.BarItems.Add(selectTableRowItem1)
            richEditBarController1.BarItems.Add(selectTableItem1)
            richEditBarController1.BarItems.Add(showTablePropertiesFormItem1)
            richEditBarController1.BarItems.Add(deleteTableElementsItem1)
            richEditBarController1.BarItems.Add(showDeleteTableCellsFormItem1)
            richEditBarController1.BarItems.Add(deleteTableColumnsItem1)
            richEditBarController1.BarItems.Add(deleteTableRowsItem1)
            richEditBarController1.BarItems.Add(deleteTableItem1)
            richEditBarController1.BarItems.Add(insertTableRowAboveItem1)
            richEditBarController1.BarItems.Add(insertTableRowBelowItem1)
            richEditBarController1.BarItems.Add(insertTableColumnToLeftItem1)
            richEditBarController1.BarItems.Add(insertTableColumnToRightItem1)
            richEditBarController1.BarItems.Add(mergeTableCellsItem1)
            richEditBarController1.BarItems.Add(showSplitTableCellsForm1)
            richEditBarController1.BarItems.Add(splitTableItem1)
            richEditBarController1.BarItems.Add(toggleTableAutoFitItem1)
            richEditBarController1.BarItems.Add(toggleTableAutoFitContentsItem1)
            richEditBarController1.BarItems.Add(toggleTableAutoFitWindowItem1)
            richEditBarController1.BarItems.Add(toggleTableFixedColumnWidthItem1)
            richEditBarController1.BarItems.Add(toggleTableCellsTopLeftAlignmentItem1)
            richEditBarController1.BarItems.Add(toggleTableCellsMiddleLeftAlignmentItem1)
            richEditBarController1.BarItems.Add(toggleTableCellsBottomLeftAlignmentItem1)
            richEditBarController1.BarItems.Add(toggleTableCellsTopCenterAlignmentItem1)
            richEditBarController1.BarItems.Add(toggleTableCellsMiddleCenterAlignmentItem1)
            richEditBarController1.BarItems.Add(toggleTableCellsBottomCenterAlignmentItem1)
            richEditBarController1.BarItems.Add(toggleTableCellsTopRightAlignmentItem1)
            richEditBarController1.BarItems.Add(toggleTableCellsMiddleRightAlignmentItem1)
            richEditBarController1.BarItems.Add(toggleTableCellsBottomRightAlignmentItem1)
            richEditBarController1.BarItems.Add(showTableOptionsFormItem1)
            richEditBarController1.Control = mainRichEdit
            ' 
            ' Form1
            ' 
            AutoScaleDimensions = New SizeF(12F, 25F)
            AutoScaleMode = AutoScaleMode.Font
            ClientSize = New Size(1403, 867)
            Controls.Add(xtraTabControl1)
            Controls.Add(ribbonControl1)
            Margin = New Padding(6)
            Name = "Form1"
            Ribbon = ribbonControl1
            Text = "Master-Detail Mail Merge Application"
            CType(xtraTabControl1, ComponentModel.ISupportInitialize).EndInit()
            xtraTabControl1.ResumeLayout(False)
            xtraTabPage1.ResumeLayout(False)
            CType(ribbonControl1, ComponentModel.ISupportInitialize).EndInit()
            CType(repositoryItemBorderLineStyle1, ComponentModel.ISupportInitialize).EndInit()
            CType(repositoryItemBorderLineWeight1, ComponentModel.ISupportInitialize).EndInit()
            xtraTabPage2.ResumeLayout(False)
            CType(richEditBarController1, ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)
            PerformLayout()

        End Sub

#End Region

        Private WithEvents xtraTabControl1 As DevExpress.XtraTab.XtraTabControl
        Private xtraTabPage1 As DevExpress.XtraTab.XtraTabPage
        Private xtraTabPage2 As DevExpress.XtraTab.XtraTabPage
        Private WithEvents mainRichEdit As DevExpress.XtraRichEdit.RichEditControl
        Private ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
        Private insertMergeFieldItem1 As DevExpress.XtraRichEdit.UI.InsertMergeFieldItem
        Private showAllFieldCodesItem1 As DevExpress.XtraRichEdit.UI.ShowAllFieldCodesItem
        Private showAllFieldResultsItem1 As DevExpress.XtraRichEdit.UI.ShowAllFieldResultsItem
        Private toggleViewMergedDataItem1 As DevExpress.XtraRichEdit.UI.ToggleViewMergedDataItem
        Private insertPageBreakItem21 As DevExpress.XtraRichEdit.UI.InsertPageBreakItem2
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
        Private insertSymbolItem1 As DevExpress.XtraRichEdit.UI.InsertSymbolItem
        Private toggleFirstRowItem1 As DevExpress.XtraRichEdit.UI.ToggleFirstRowItem
        Private toggleLastRowItem1 As DevExpress.XtraRichEdit.UI.ToggleLastRowItem
        Private toggleBandedRowsItem1 As DevExpress.XtraRichEdit.UI.ToggleBandedRowsItem
        Private toggleFirstColumnItem1 As DevExpress.XtraRichEdit.UI.ToggleFirstColumnItem
        Private toggleLastColumnItem1 As DevExpress.XtraRichEdit.UI.ToggleLastColumnItem
        Private toggleBandedColumnsItem1 As DevExpress.XtraRichEdit.UI.ToggleBandedColumnsItem
        Private galleryChangeTableStyleItem1 As DevExpress.XtraRichEdit.UI.GalleryChangeTableStyleItem
        Private changeTableBorderLineStyleItem1 As DevExpress.XtraRichEdit.UI.ChangeTableBorderLineStyleItem
        Private repositoryItemBorderLineStyle1 As DevExpress.XtraRichEdit.Forms.Design.RepositoryItemBorderLineStyle
        Private changeTableBorderLineWeightItem1 As DevExpress.XtraRichEdit.UI.ChangeTableBorderLineWeightItem
        Private repositoryItemBorderLineWeight1 As DevExpress.XtraRichEdit.Forms.Design.RepositoryItemBorderLineWeight
        Private changeTableBorderColorItem1 As DevExpress.XtraRichEdit.UI.ChangeTableBorderColorItem
        Private changeTableBordersItem1 As DevExpress.XtraRichEdit.UI.ChangeTableBordersItem
        Private toggleTableCellsBottomBorderItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomBorderItem
        Private toggleTableCellsTopBorderItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsTopBorderItem
        Private toggleTableCellsLeftBorderItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsLeftBorderItem
        Private toggleTableCellsRightBorderItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsRightBorderItem
        Private resetTableCellsAllBordersItem1 As DevExpress.XtraRichEdit.UI.ResetTableCellsAllBordersItem
        Private toggleTableCellsAllBordersItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsAllBordersItem
        Private toggleTableCellsOutsideBorderItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsOutsideBorderItem
        Private toggleTableCellsInsideBorderItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsInsideBorderItem
        Private toggleTableCellsInsideHorizontalBorderItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsInsideHorizontalBorderItem
        Private toggleTableCellsInsideVerticalBorderItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsInsideVerticalBorderItem
        Private toggleShowTableGridLinesItem1 As DevExpress.XtraRichEdit.UI.ToggleShowTableGridLinesItem
        Private changeTableCellsShadingItem1 As DevExpress.XtraRichEdit.UI.ChangeTableCellsShadingItem
        Private selectTableElementsItem1 As DevExpress.XtraRichEdit.UI.SelectTableElementsItem
        Private selectTableCellItem1 As DevExpress.XtraRichEdit.UI.SelectTableCellItem
        Private selectTableColumnItem1 As DevExpress.XtraRichEdit.UI.SelectTableColumnItem
        Private selectTableRowItem1 As DevExpress.XtraRichEdit.UI.SelectTableRowItem
        Private selectTableItem1 As DevExpress.XtraRichEdit.UI.SelectTableItem
        Private showTablePropertiesFormItem1 As DevExpress.XtraRichEdit.UI.ShowTablePropertiesFormItem
        Private deleteTableElementsItem1 As DevExpress.XtraRichEdit.UI.DeleteTableElementsItem
        Private showDeleteTableCellsFormItem1 As DevExpress.XtraRichEdit.UI.ShowDeleteTableCellsFormItem
        Private deleteTableColumnsItem1 As DevExpress.XtraRichEdit.UI.DeleteTableColumnsItem
        Private deleteTableRowsItem1 As DevExpress.XtraRichEdit.UI.DeleteTableRowsItem
        Private deleteTableItem1 As DevExpress.XtraRichEdit.UI.DeleteTableItem
        Private insertTableRowAboveItem1 As DevExpress.XtraRichEdit.UI.InsertTableRowAboveItem
        Private insertTableRowBelowItem1 As DevExpress.XtraRichEdit.UI.InsertTableRowBelowItem
        Private insertTableColumnToLeftItem1 As DevExpress.XtraRichEdit.UI.InsertTableColumnToLeftItem
        Private insertTableColumnToRightItem1 As DevExpress.XtraRichEdit.UI.InsertTableColumnToRightItem
        Private mergeTableCellsItem1 As DevExpress.XtraRichEdit.UI.MergeTableCellsItem
        Private showSplitTableCellsForm1 As DevExpress.XtraRichEdit.UI.ShowSplitTableCellsForm
        Private splitTableItem1 As DevExpress.XtraRichEdit.UI.SplitTableItem
        Private toggleTableAutoFitItem1 As DevExpress.XtraRichEdit.UI.ToggleTableAutoFitItem
        Private toggleTableAutoFitContentsItem1 As DevExpress.XtraRichEdit.UI.ToggleTableAutoFitContentsItem
        Private toggleTableAutoFitWindowItem1 As DevExpress.XtraRichEdit.UI.ToggleTableAutoFitWindowItem
        Private toggleTableFixedColumnWidthItem1 As DevExpress.XtraRichEdit.UI.ToggleTableFixedColumnWidthItem
        Private toggleTableCellsTopLeftAlignmentItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsTopLeftAlignmentItem
        Private toggleTableCellsMiddleLeftAlignmentItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsMiddleLeftAlignmentItem
        Private toggleTableCellsBottomLeftAlignmentItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomLeftAlignmentItem
        Private toggleTableCellsTopCenterAlignmentItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsTopCenterAlignmentItem
        Private toggleTableCellsMiddleCenterAlignmentItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsMiddleCenterAlignmentItem
        Private toggleTableCellsBottomCenterAlignmentItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomCenterAlignmentItem
        Private toggleTableCellsTopRightAlignmentItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsTopRightAlignmentItem
        Private toggleTableCellsMiddleRightAlignmentItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsMiddleRightAlignmentItem
        Private toggleTableCellsBottomRightAlignmentItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomRightAlignmentItem
        Private showTableOptionsFormItem1 As DevExpress.XtraRichEdit.UI.ShowTableOptionsFormItem
        Private mailingsRibbonPage1 As DevExpress.XtraRichEdit.UI.MailingsRibbonPage
        Private mailMergeRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.MailMergeRibbonPageGroup
        Private insertRibbonPage1 As DevExpress.XtraRichEdit.UI.InsertRibbonPage
        Private pagesRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.PagesRibbonPageGroup
        Private tablesRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.TablesRibbonPageGroup
        Private illustrationsRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.IllustrationsRibbonPageGroup
        Private linksRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.LinksRibbonPageGroup
        Private headerFooterRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.HeaderFooterRibbonPageGroup
        Private textRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.TextRibbonPageGroup
        Private symbolsRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.SymbolsRibbonPageGroup
        Private resultRichEdit As DevExpress.XtraRichEdit.RichEditControl
        Private richEditBarController1 As DevExpress.XtraRichEdit.UI.RichEditBarController
        Private WithEvents barButtonItem1 As DevExpress.XtraBars.BarButtonItem
        Private ribbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    End Class
End Namespace

