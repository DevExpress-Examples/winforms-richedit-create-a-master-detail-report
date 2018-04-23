Imports Microsoft.VisualBasic
Imports System
Namespace MasterDetailExample
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Dim borderInfo1 As New DevExpress.XtraRichEdit.Model.BorderInfo()
			Me.xtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
			Me.xtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
			Me.mainRichEdit = New DevExpress.XtraRichEdit.RichEditControl()
			Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
			Me.insertMergeFieldItem1 = New DevExpress.XtraRichEdit.UI.InsertMergeFieldItem()
			Me.showAllFieldCodesItem1 = New DevExpress.XtraRichEdit.UI.ShowAllFieldCodesItem()
			Me.showAllFieldResultsItem1 = New DevExpress.XtraRichEdit.UI.ShowAllFieldResultsItem()
			Me.toggleViewMergedDataItem1 = New DevExpress.XtraRichEdit.UI.ToggleViewMergedDataItem()
			Me.performMailMergeItem1 = New DevExpress.XtraBars.BarButtonItem()
			Me.changeTableCellsShadingItem1 = New DevExpress.XtraRichEdit.UI.ChangeTableCellsShadingItem()
			Me.changeTableBordersItem1 = New DevExpress.XtraRichEdit.UI.ChangeTableBordersItem()
			Me.toggleTableCellsBottomBorderItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomBorderItem()
			Me.toggleTableCellsTopBorderItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsTopBorderItem()
			Me.toggleTableCellsLeftBorderItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsLeftBorderItem()
			Me.toggleTableCellsRightBorderItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsRightBorderItem()
			Me.resetTableCellsAllBordersItem1 = New DevExpress.XtraRichEdit.UI.ResetTableCellsAllBordersItem()
			Me.toggleTableCellsAllBordersItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsAllBordersItem()
			Me.toggleTableCellsOutsideBorderItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsOutsideBorderItem()
			Me.toggleTableCellsInsideBorderItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsInsideBorderItem()
			Me.toggleTableCellsInsideHorizontalBorderItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsInsideHorizontalBorderItem()
			Me.toggleTableCellsInsideVerticalBorderItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsInsideVerticalBorderItem()
			Me.toggleShowTableGridLinesItem1 = New DevExpress.XtraRichEdit.UI.ToggleShowTableGridLinesItem()
			Me.changeTableBorderLineStyleItem1 = New DevExpress.XtraRichEdit.UI.ChangeTableBorderLineStyleItem()
			Me.repositoryItemBorderLineStyle1 = New DevExpress.XtraRichEdit.Forms.Design.RepositoryItemBorderLineStyle()
			Me.changeTableBorderLineWeightItem1 = New DevExpress.XtraRichEdit.UI.ChangeTableBorderLineWeightItem()
			Me.repositoryItemBorderLineWeight1 = New DevExpress.XtraRichEdit.Forms.Design.RepositoryItemBorderLineWeight()
			Me.changeTableBorderColorItem1 = New DevExpress.XtraRichEdit.UI.ChangeTableBorderColorItem()
			Me.selectTableElementsItem1 = New DevExpress.XtraRichEdit.UI.SelectTableElementsItem()
			Me.selectTableCellItem1 = New DevExpress.XtraRichEdit.UI.SelectTableCellItem()
			Me.selectTableColumnItem1 = New DevExpress.XtraRichEdit.UI.SelectTableColumnItem()
			Me.selectTableRowItem1 = New DevExpress.XtraRichEdit.UI.SelectTableRowItem()
			Me.selectTableItem1 = New DevExpress.XtraRichEdit.UI.SelectTableItem()
			Me.showTablePropertiesFormItem1 = New DevExpress.XtraRichEdit.UI.ShowTablePropertiesFormItem()
			Me.deleteTableElementsItem1 = New DevExpress.XtraRichEdit.UI.DeleteTableElementsItem()
			Me.showDeleteTableCellsFormItem1 = New DevExpress.XtraRichEdit.UI.ShowDeleteTableCellsFormItem()
			Me.deleteTableColumnsItem1 = New DevExpress.XtraRichEdit.UI.DeleteTableColumnsItem()
			Me.deleteTableRowsItem1 = New DevExpress.XtraRichEdit.UI.DeleteTableRowsItem()
			Me.deleteTableItem1 = New DevExpress.XtraRichEdit.UI.DeleteTableItem()
			Me.insertTableRowAboveItem1 = New DevExpress.XtraRichEdit.UI.InsertTableRowAboveItem()
			Me.insertTableRowBelowItem1 = New DevExpress.XtraRichEdit.UI.InsertTableRowBelowItem()
			Me.insertTableColumnToLeftItem1 = New DevExpress.XtraRichEdit.UI.InsertTableColumnToLeftItem()
			Me.insertTableColumnToRightItem1 = New DevExpress.XtraRichEdit.UI.InsertTableColumnToRightItem()
			Me.showInsertTableCellsFormItem1 = New DevExpress.XtraRichEdit.UI.ShowInsertTableCellsFormItem()
			Me.mergeTableCellsItem1 = New DevExpress.XtraRichEdit.UI.MergeTableCellsItem()
			Me.showSplitTableCellsForm1 = New DevExpress.XtraRichEdit.UI.ShowSplitTableCellsForm()
			Me.splitTableItem1 = New DevExpress.XtraRichEdit.UI.SplitTableItem()
			Me.toggleTableAutoFitItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableAutoFitItem()
			Me.toggleTableAutoFitContentsItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableAutoFitContentsItem()
			Me.toggleTableAutoFitWindowItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableAutoFitWindowItem()
			Me.toggleTableFixedColumnWidthItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableFixedColumnWidthItem()
			Me.toggleTableCellsTopLeftAlignmentItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsTopLeftAlignmentItem()
			Me.toggleTableCellsTopCenterAlignmentItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsTopCenterAlignmentItem()
			Me.toggleTableCellsTopRightAlignmentItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsTopRightAlignmentItem()
			Me.toggleTableCellsMiddleLeftAlignmentItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsMiddleLeftAlignmentItem()
			Me.toggleTableCellsMiddleCenterAlignmentItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsMiddleCenterAlignmentItem()
			Me.toggleTableCellsMiddleRightAlignmentItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsMiddleRightAlignmentItem()
			Me.toggleTableCellsBottomLeftAlignmentItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomLeftAlignmentItem()
			Me.toggleTableCellsBottomCenterAlignmentItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomCenterAlignmentItem()
			Me.toggleTableCellsBottomRightAlignmentItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomRightAlignmentItem()
			Me.insertPageBreakItem1 = New DevExpress.XtraRichEdit.UI.InsertPageBreakItem()
			Me.insertTableItem1 = New DevExpress.XtraRichEdit.UI.InsertTableItem()
			Me.insertPictureItem1 = New DevExpress.XtraRichEdit.UI.InsertPictureItem()
			Me.insertBookmarkItem1 = New DevExpress.XtraRichEdit.UI.InsertBookmarkItem()
			Me.insertHyperlinkItem1 = New DevExpress.XtraRichEdit.UI.InsertHyperlinkItem()
			Me.editPageHeaderItem1 = New DevExpress.XtraRichEdit.UI.EditPageHeaderItem()
			Me.editPageFooterItem1 = New DevExpress.XtraRichEdit.UI.EditPageFooterItem()
			Me.insertPageNumberItem1 = New DevExpress.XtraRichEdit.UI.InsertPageNumberItem()
			Me.insertPageCountItem1 = New DevExpress.XtraRichEdit.UI.InsertPageCountItem()
			Me.insertSymbolItem1 = New DevExpress.XtraRichEdit.UI.InsertSymbolItem()
			Me.tableToolsRibbonPageCategory1 = New DevExpress.XtraRichEdit.UI.TableToolsRibbonPageCategory()
			Me.tableDesignRibbonPage1 = New DevExpress.XtraRichEdit.UI.TableDesignRibbonPage()
			Me.tableStylesRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.TableStylesRibbonPageGroup()
			Me.tableDrawBordersRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.TableDrawBordersRibbonPageGroup()
			Me.tableLayoutRibbonPage1 = New DevExpress.XtraRichEdit.UI.TableLayoutRibbonPage()
			Me.tableTableRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.TableTableRibbonPageGroup()
			Me.tableRowsAndColumnsRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.TableRowsAndColumnsRibbonPageGroup()
			Me.tableMergeRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.TableMergeRibbonPageGroup()
			Me.tableCellSizeRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.TableCellSizeRibbonPageGroup()
			Me.tableAlignmentRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.TableAlignmentRibbonPageGroup()
			Me.mailingsRibbonPage1 = New DevExpress.XtraRichEdit.UI.MailingsRibbonPage()
			Me.mailMergeRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.MailMergeRibbonPageGroup()
			Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.insertRibbonPage1 = New DevExpress.XtraRichEdit.UI.InsertRibbonPage()
			Me.pagesRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.PagesRibbonPageGroup()
			Me.tablesRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.TablesRibbonPageGroup()
			Me.illustrationsRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.IllustrationsRibbonPageGroup()
			Me.linksRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.LinksRibbonPageGroup()
			Me.headerFooterRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.HeaderFooterRibbonPageGroup()
			Me.symbolsRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.SymbolsRibbonPageGroup()
			Me.xtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
			Me.suppllierRichEdit = New DevExpress.XtraRichEdit.RichEditControl()
			Me.xtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
			Me.productRichEdit = New DevExpress.XtraRichEdit.RichEditControl()
			Me.xtraTabPage4 = New DevExpress.XtraTab.XtraTabPage()
			Me.ordersRichEdit = New DevExpress.XtraRichEdit.RichEditControl()
			Me.xtraTabPage5 = New DevExpress.XtraTab.XtraTabPage()
			Me.resultRichEdit = New DevExpress.XtraRichEdit.RichEditControl()
			Me.xtraTabPage6 = New DevExpress.XtraTab.XtraTabPage()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.richEditBarController1 = New DevExpress.XtraRichEdit.UI.RichEditBarController()
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xtraTabControl1.SuspendLayout()
			Me.xtraTabPage1.SuspendLayout()
			CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemBorderLineStyle1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemBorderLineWeight1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xtraTabPage2.SuspendLayout()
			Me.xtraTabPage3.SuspendLayout()
			Me.xtraTabPage4.SuspendLayout()
			Me.xtraTabPage5.SuspendLayout()
			Me.xtraTabPage6.SuspendLayout()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.richEditBarController1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' xtraTabControl1
			' 
			Me.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.xtraTabControl1.Location = New System.Drawing.Point(0, 145)
			Me.xtraTabControl1.Name = "xtraTabControl1"
			Me.xtraTabControl1.SelectedTabPage = Me.xtraTabPage1
			Me.xtraTabControl1.Size = New System.Drawing.Size(1031, 465)
			Me.xtraTabControl1.TabIndex = 0
			Me.xtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() { Me.xtraTabPage1, Me.xtraTabPage2, Me.xtraTabPage3, Me.xtraTabPage4, Me.xtraTabPage5, Me.xtraTabPage6})
			Me.xtraTabControl1.Tag = ""
			' 
			' xtraTabPage1
			' 
			Me.xtraTabPage1.Controls.Add(Me.mainRichEdit)
			Me.xtraTabPage1.Name = "xtraTabPage1"
			Me.xtraTabPage1.Size = New System.Drawing.Size(1025, 439)
			Me.xtraTabPage1.Tag = ""
			Me.xtraTabPage1.Text = "MainTemplate"
			' 
			' mainRichEdit
			' 
			Me.mainRichEdit.Dock = System.Windows.Forms.DockStyle.Fill
			Me.mainRichEdit.Location = New System.Drawing.Point(0, 0)
			Me.mainRichEdit.MenuManager = Me.ribbonControl1
			Me.mainRichEdit.Name = "mainRichEdit"
			Me.mainRichEdit.Options.Fields.HighlightMode = DevExpress.XtraRichEdit.FieldsHighlightMode.Always
			Me.mainRichEdit.Size = New System.Drawing.Size(1025, 439)
			Me.mainRichEdit.TabIndex = 0
			Me.mainRichEdit.Text = "Main Template"
			' 
			' ribbonControl1
			' 
			Me.ribbonControl1.ApplicationButtonText = Nothing
			' 
			' 
			' 
			Me.ribbonControl1.ExpandCollapseItem.Id = 0
			Me.ribbonControl1.ExpandCollapseItem.Name = ""
			Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.ribbonControl1.ExpandCollapseItem, Me.insertMergeFieldItem1, Me.showAllFieldCodesItem1, Me.showAllFieldResultsItem1, Me.toggleViewMergedDataItem1, Me.performMailMergeItem1, Me.changeTableCellsShadingItem1, Me.changeTableBordersItem1, Me.toggleTableCellsBottomBorderItem1, Me.toggleTableCellsTopBorderItem1, Me.toggleTableCellsLeftBorderItem1, Me.toggleTableCellsRightBorderItem1, Me.resetTableCellsAllBordersItem1, Me.toggleTableCellsAllBordersItem1, Me.toggleTableCellsOutsideBorderItem1, Me.toggleTableCellsInsideBorderItem1, Me.toggleTableCellsInsideHorizontalBorderItem1, Me.toggleTableCellsInsideVerticalBorderItem1, Me.toggleShowTableGridLinesItem1, Me.changeTableBorderLineStyleItem1, Me.changeTableBorderLineWeightItem1, Me.changeTableBorderColorItem1, Me.selectTableElementsItem1, Me.selectTableCellItem1, Me.selectTableColumnItem1, Me.selectTableRowItem1, Me.selectTableItem1, Me.showTablePropertiesFormItem1, Me.deleteTableElementsItem1, Me.showDeleteTableCellsFormItem1, Me.deleteTableColumnsItem1, Me.deleteTableRowsItem1, Me.deleteTableItem1, Me.insertTableRowAboveItem1, Me.insertTableRowBelowItem1, Me.insertTableColumnToLeftItem1, Me.insertTableColumnToRightItem1, Me.showInsertTableCellsFormItem1, Me.mergeTableCellsItem1, Me.showSplitTableCellsForm1, Me.splitTableItem1, Me.toggleTableAutoFitItem1, Me.toggleTableAutoFitContentsItem1, Me.toggleTableAutoFitWindowItem1, Me.toggleTableFixedColumnWidthItem1, Me.toggleTableCellsTopLeftAlignmentItem1, Me.toggleTableCellsTopCenterAlignmentItem1, Me.toggleTableCellsTopRightAlignmentItem1, Me.toggleTableCellsMiddleLeftAlignmentItem1, Me.toggleTableCellsMiddleCenterAlignmentItem1, Me.toggleTableCellsMiddleRightAlignmentItem1, Me.toggleTableCellsBottomLeftAlignmentItem1, Me.toggleTableCellsBottomCenterAlignmentItem1, Me.toggleTableCellsBottomRightAlignmentItem1, Me.insertPageBreakItem1, Me.insertTableItem1, Me.insertPictureItem1, Me.insertBookmarkItem1, Me.insertHyperlinkItem1, Me.editPageHeaderItem1, Me.editPageFooterItem1, Me.insertPageNumberItem1, Me.insertPageCountItem1, Me.insertSymbolItem1})
			Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
			Me.ribbonControl1.MaxItemId = 64
			Me.ribbonControl1.Name = "ribbonControl1"
			Me.ribbonControl1.PageCategories.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageCategory() { Me.tableToolsRibbonPageCategory1})
			Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.mailingsRibbonPage1, Me.insertRibbonPage1})
			Me.ribbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemBorderLineStyle1, Me.repositoryItemBorderLineWeight1})
			Me.ribbonControl1.SelectedPage = Me.mailingsRibbonPage1
			Me.ribbonControl1.Size = New System.Drawing.Size(1031, 145)
			' 
			' insertMergeFieldItem1
			' 
			Me.insertMergeFieldItem1.Glyph = (CType(resources.GetObject("insertMergeFieldItem1.Glyph"), System.Drawing.Image))
			Me.insertMergeFieldItem1.Id = 1
			Me.insertMergeFieldItem1.LargeGlyph = (CType(resources.GetObject("insertMergeFieldItem1.LargeGlyph"), System.Drawing.Image))
			Me.insertMergeFieldItem1.Name = "insertMergeFieldItem1"
			' 
			' showAllFieldCodesItem1
			' 
			Me.showAllFieldCodesItem1.Glyph = (CType(resources.GetObject("showAllFieldCodesItem1.Glyph"), System.Drawing.Image))
			Me.showAllFieldCodesItem1.Id = 2
			Me.showAllFieldCodesItem1.LargeGlyph = (CType(resources.GetObject("showAllFieldCodesItem1.LargeGlyph"), System.Drawing.Image))
			Me.showAllFieldCodesItem1.Name = "showAllFieldCodesItem1"
			' 
			' showAllFieldResultsItem1
			' 
			Me.showAllFieldResultsItem1.Glyph = (CType(resources.GetObject("showAllFieldResultsItem1.Glyph"), System.Drawing.Image))
			Me.showAllFieldResultsItem1.Id = 3
			Me.showAllFieldResultsItem1.LargeGlyph = (CType(resources.GetObject("showAllFieldResultsItem1.LargeGlyph"), System.Drawing.Image))
			Me.showAllFieldResultsItem1.Name = "showAllFieldResultsItem1"
			' 
			' toggleViewMergedDataItem1
			' 
			Me.toggleViewMergedDataItem1.Glyph = (CType(resources.GetObject("toggleViewMergedDataItem1.Glyph"), System.Drawing.Image))
			Me.toggleViewMergedDataItem1.Id = 4
			Me.toggleViewMergedDataItem1.LargeGlyph = (CType(resources.GetObject("toggleViewMergedDataItem1.LargeGlyph"), System.Drawing.Image))
			Me.toggleViewMergedDataItem1.Name = "toggleViewMergedDataItem1"
			' 
			' performMailMergeItem1
			' 
			Me.performMailMergeItem1.Caption = "Create Report"
			Me.performMailMergeItem1.Glyph = (CType(resources.GetObject("performMailMergeItem1.Glyph"), System.Drawing.Image))
			Me.performMailMergeItem1.Id = 5
			Me.performMailMergeItem1.LargeGlyph = (CType(resources.GetObject("performMailMergeItem1.LargeGlyph"), System.Drawing.Image))
			Me.performMailMergeItem1.Name = "performMailMergeItem1"
			Me.performMailMergeItem1.RibbonStyle = (CType(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles))
'			Me.performMailMergeItem1.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.performMailMergeItem1_ItemClick);
			' 
			' changeTableCellsShadingItem1
			' 
			Me.changeTableCellsShadingItem1.Glyph = (CType(resources.GetObject("changeTableCellsShadingItem1.Glyph"), System.Drawing.Image))
			Me.changeTableCellsShadingItem1.Id = 6
			Me.changeTableCellsShadingItem1.LargeGlyph = (CType(resources.GetObject("changeTableCellsShadingItem1.LargeGlyph"), System.Drawing.Image))
			Me.changeTableCellsShadingItem1.Name = "changeTableCellsShadingItem1"
			' 
			' changeTableBordersItem1
			' 
			Me.changeTableBordersItem1.Glyph = (CType(resources.GetObject("changeTableBordersItem1.Glyph"), System.Drawing.Image))
			Me.changeTableBordersItem1.Id = 7
			Me.changeTableBordersItem1.LargeGlyph = (CType(resources.GetObject("changeTableBordersItem1.LargeGlyph"), System.Drawing.Image))
			Me.changeTableBordersItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableCellsBottomBorderItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableCellsTopBorderItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableCellsLeftBorderItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableCellsRightBorderItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.resetTableCellsAllBordersItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableCellsAllBordersItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableCellsOutsideBorderItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableCellsInsideBorderItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableCellsInsideHorizontalBorderItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableCellsInsideVerticalBorderItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleShowTableGridLinesItem1)})
			Me.changeTableBordersItem1.Name = "changeTableBordersItem1"
			' 
			' toggleTableCellsBottomBorderItem1
			' 
			Me.toggleTableCellsBottomBorderItem1.Glyph = (CType(resources.GetObject("toggleTableCellsBottomBorderItem1.Glyph"), System.Drawing.Image))
			Me.toggleTableCellsBottomBorderItem1.Id = 8
			Me.toggleTableCellsBottomBorderItem1.LargeGlyph = (CType(resources.GetObject("toggleTableCellsBottomBorderItem1.LargeGlyph"), System.Drawing.Image))
			Me.toggleTableCellsBottomBorderItem1.Name = "toggleTableCellsBottomBorderItem1"
			' 
			' toggleTableCellsTopBorderItem1
			' 
			Me.toggleTableCellsTopBorderItem1.Glyph = (CType(resources.GetObject("toggleTableCellsTopBorderItem1.Glyph"), System.Drawing.Image))
			Me.toggleTableCellsTopBorderItem1.Id = 9
			Me.toggleTableCellsTopBorderItem1.LargeGlyph = (CType(resources.GetObject("toggleTableCellsTopBorderItem1.LargeGlyph"), System.Drawing.Image))
			Me.toggleTableCellsTopBorderItem1.Name = "toggleTableCellsTopBorderItem1"
			' 
			' toggleTableCellsLeftBorderItem1
			' 
			Me.toggleTableCellsLeftBorderItem1.Glyph = (CType(resources.GetObject("toggleTableCellsLeftBorderItem1.Glyph"), System.Drawing.Image))
			Me.toggleTableCellsLeftBorderItem1.Id = 10
			Me.toggleTableCellsLeftBorderItem1.LargeGlyph = (CType(resources.GetObject("toggleTableCellsLeftBorderItem1.LargeGlyph"), System.Drawing.Image))
			Me.toggleTableCellsLeftBorderItem1.Name = "toggleTableCellsLeftBorderItem1"
			' 
			' toggleTableCellsRightBorderItem1
			' 
			Me.toggleTableCellsRightBorderItem1.Glyph = (CType(resources.GetObject("toggleTableCellsRightBorderItem1.Glyph"), System.Drawing.Image))
			Me.toggleTableCellsRightBorderItem1.Id = 11
			Me.toggleTableCellsRightBorderItem1.LargeGlyph = (CType(resources.GetObject("toggleTableCellsRightBorderItem1.LargeGlyph"), System.Drawing.Image))
			Me.toggleTableCellsRightBorderItem1.Name = "toggleTableCellsRightBorderItem1"
			' 
			' resetTableCellsAllBordersItem1
			' 
			Me.resetTableCellsAllBordersItem1.Glyph = (CType(resources.GetObject("resetTableCellsAllBordersItem1.Glyph"), System.Drawing.Image))
			Me.resetTableCellsAllBordersItem1.Id = 12
			Me.resetTableCellsAllBordersItem1.LargeGlyph = (CType(resources.GetObject("resetTableCellsAllBordersItem1.LargeGlyph"), System.Drawing.Image))
			Me.resetTableCellsAllBordersItem1.Name = "resetTableCellsAllBordersItem1"
			' 
			' toggleTableCellsAllBordersItem1
			' 
			Me.toggleTableCellsAllBordersItem1.Glyph = (CType(resources.GetObject("toggleTableCellsAllBordersItem1.Glyph"), System.Drawing.Image))
			Me.toggleTableCellsAllBordersItem1.Id = 13
			Me.toggleTableCellsAllBordersItem1.LargeGlyph = (CType(resources.GetObject("toggleTableCellsAllBordersItem1.LargeGlyph"), System.Drawing.Image))
			Me.toggleTableCellsAllBordersItem1.Name = "toggleTableCellsAllBordersItem1"
			' 
			' toggleTableCellsOutsideBorderItem1
			' 
			Me.toggleTableCellsOutsideBorderItem1.Glyph = (CType(resources.GetObject("toggleTableCellsOutsideBorderItem1.Glyph"), System.Drawing.Image))
			Me.toggleTableCellsOutsideBorderItem1.Id = 14
			Me.toggleTableCellsOutsideBorderItem1.LargeGlyph = (CType(resources.GetObject("toggleTableCellsOutsideBorderItem1.LargeGlyph"), System.Drawing.Image))
			Me.toggleTableCellsOutsideBorderItem1.Name = "toggleTableCellsOutsideBorderItem1"
			' 
			' toggleTableCellsInsideBorderItem1
			' 
			Me.toggleTableCellsInsideBorderItem1.Glyph = (CType(resources.GetObject("toggleTableCellsInsideBorderItem1.Glyph"), System.Drawing.Image))
			Me.toggleTableCellsInsideBorderItem1.Id = 15
			Me.toggleTableCellsInsideBorderItem1.LargeGlyph = (CType(resources.GetObject("toggleTableCellsInsideBorderItem1.LargeGlyph"), System.Drawing.Image))
			Me.toggleTableCellsInsideBorderItem1.Name = "toggleTableCellsInsideBorderItem1"
			' 
			' toggleTableCellsInsideHorizontalBorderItem1
			' 
			Me.toggleTableCellsInsideHorizontalBorderItem1.Glyph = (CType(resources.GetObject("toggleTableCellsInsideHorizontalBorderItem1.Glyph"), System.Drawing.Image))
			Me.toggleTableCellsInsideHorizontalBorderItem1.Id = 16
			Me.toggleTableCellsInsideHorizontalBorderItem1.LargeGlyph = (CType(resources.GetObject("toggleTableCellsInsideHorizontalBorderItem1.LargeGlyph"), System.Drawing.Image))
			Me.toggleTableCellsInsideHorizontalBorderItem1.Name = "toggleTableCellsInsideHorizontalBorderItem1"
			' 
			' toggleTableCellsInsideVerticalBorderItem1
			' 
			Me.toggleTableCellsInsideVerticalBorderItem1.Glyph = (CType(resources.GetObject("toggleTableCellsInsideVerticalBorderItem1.Glyph"), System.Drawing.Image))
			Me.toggleTableCellsInsideVerticalBorderItem1.Id = 17
			Me.toggleTableCellsInsideVerticalBorderItem1.LargeGlyph = (CType(resources.GetObject("toggleTableCellsInsideVerticalBorderItem1.LargeGlyph"), System.Drawing.Image))
			Me.toggleTableCellsInsideVerticalBorderItem1.Name = "toggleTableCellsInsideVerticalBorderItem1"
			' 
			' toggleShowTableGridLinesItem1
			' 
			Me.toggleShowTableGridLinesItem1.Glyph = (CType(resources.GetObject("toggleShowTableGridLinesItem1.Glyph"), System.Drawing.Image))
			Me.toggleShowTableGridLinesItem1.Id = 18
			Me.toggleShowTableGridLinesItem1.LargeGlyph = (CType(resources.GetObject("toggleShowTableGridLinesItem1.LargeGlyph"), System.Drawing.Image))
			Me.toggleShowTableGridLinesItem1.Name = "toggleShowTableGridLinesItem1"
			' 
			' changeTableBorderLineStyleItem1
			' 
			Me.changeTableBorderLineStyleItem1.Edit = Me.repositoryItemBorderLineStyle1
			borderInfo1.Color = System.Drawing.Color.Black
			borderInfo1.Frame = False
			borderInfo1.Offset = 0
			borderInfo1.Shadow = False
			borderInfo1.Style = DevExpress.XtraRichEdit.Model.BorderLineStyle.Single
			borderInfo1.Width = 10
			Me.changeTableBorderLineStyleItem1.EditValue = borderInfo1
			Me.changeTableBorderLineStyleItem1.Id = 19
			Me.changeTableBorderLineStyleItem1.Name = "changeTableBorderLineStyleItem1"
			' 
			' repositoryItemBorderLineStyle1
			' 
			Me.repositoryItemBorderLineStyle1.AutoHeight = False
			Me.repositoryItemBorderLineStyle1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemBorderLineStyle1.Control = Me.mainRichEdit
			Me.repositoryItemBorderLineStyle1.Name = "repositoryItemBorderLineStyle1"
			' 
			' changeTableBorderLineWeightItem1
			' 
			Me.changeTableBorderLineWeightItem1.Edit = Me.repositoryItemBorderLineWeight1
			Me.changeTableBorderLineWeightItem1.EditValue = 20
			Me.changeTableBorderLineWeightItem1.Id = 20
			Me.changeTableBorderLineWeightItem1.Name = "changeTableBorderLineWeightItem1"
			' 
			' repositoryItemBorderLineWeight1
			' 
			Me.repositoryItemBorderLineWeight1.AutoHeight = False
			Me.repositoryItemBorderLineWeight1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemBorderLineWeight1.Control = Me.mainRichEdit
			Me.repositoryItemBorderLineWeight1.Name = "repositoryItemBorderLineWeight1"
			' 
			' changeTableBorderColorItem1
			' 
			Me.changeTableBorderColorItem1.Glyph = (CType(resources.GetObject("changeTableBorderColorItem1.Glyph"), System.Drawing.Image))
			Me.changeTableBorderColorItem1.Id = 21
			Me.changeTableBorderColorItem1.LargeGlyph = (CType(resources.GetObject("changeTableBorderColorItem1.LargeGlyph"), System.Drawing.Image))
			Me.changeTableBorderColorItem1.Name = "changeTableBorderColorItem1"
			' 
			' selectTableElementsItem1
			' 
			Me.selectTableElementsItem1.Glyph = (CType(resources.GetObject("selectTableElementsItem1.Glyph"), System.Drawing.Image))
			Me.selectTableElementsItem1.Id = 22
			Me.selectTableElementsItem1.LargeGlyph = (CType(resources.GetObject("selectTableElementsItem1.LargeGlyph"), System.Drawing.Image))
			Me.selectTableElementsItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.selectTableCellItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.selectTableColumnItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.selectTableRowItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.selectTableItem1)})
			Me.selectTableElementsItem1.Name = "selectTableElementsItem1"
			' 
			' selectTableCellItem1
			' 
			Me.selectTableCellItem1.Glyph = (CType(resources.GetObject("selectTableCellItem1.Glyph"), System.Drawing.Image))
			Me.selectTableCellItem1.Id = 23
			Me.selectTableCellItem1.LargeGlyph = (CType(resources.GetObject("selectTableCellItem1.LargeGlyph"), System.Drawing.Image))
			Me.selectTableCellItem1.Name = "selectTableCellItem1"
			' 
			' selectTableColumnItem1
			' 
			Me.selectTableColumnItem1.Glyph = (CType(resources.GetObject("selectTableColumnItem1.Glyph"), System.Drawing.Image))
			Me.selectTableColumnItem1.Id = 24
			Me.selectTableColumnItem1.LargeGlyph = (CType(resources.GetObject("selectTableColumnItem1.LargeGlyph"), System.Drawing.Image))
			Me.selectTableColumnItem1.Name = "selectTableColumnItem1"
			' 
			' selectTableRowItem1
			' 
			Me.selectTableRowItem1.Glyph = (CType(resources.GetObject("selectTableRowItem1.Glyph"), System.Drawing.Image))
			Me.selectTableRowItem1.Id = 25
			Me.selectTableRowItem1.LargeGlyph = (CType(resources.GetObject("selectTableRowItem1.LargeGlyph"), System.Drawing.Image))
			Me.selectTableRowItem1.Name = "selectTableRowItem1"
			' 
			' selectTableItem1
			' 
			Me.selectTableItem1.Glyph = (CType(resources.GetObject("selectTableItem1.Glyph"), System.Drawing.Image))
			Me.selectTableItem1.Id = 26
			Me.selectTableItem1.LargeGlyph = (CType(resources.GetObject("selectTableItem1.LargeGlyph"), System.Drawing.Image))
			Me.selectTableItem1.Name = "selectTableItem1"
			' 
			' showTablePropertiesFormItem1
			' 
			Me.showTablePropertiesFormItem1.Glyph = (CType(resources.GetObject("showTablePropertiesFormItem1.Glyph"), System.Drawing.Image))
			Me.showTablePropertiesFormItem1.Id = 27
			Me.showTablePropertiesFormItem1.LargeGlyph = (CType(resources.GetObject("showTablePropertiesFormItem1.LargeGlyph"), System.Drawing.Image))
			Me.showTablePropertiesFormItem1.Name = "showTablePropertiesFormItem1"
			' 
			' deleteTableElementsItem1
			' 
			Me.deleteTableElementsItem1.Glyph = (CType(resources.GetObject("deleteTableElementsItem1.Glyph"), System.Drawing.Image))
			Me.deleteTableElementsItem1.Id = 28
			Me.deleteTableElementsItem1.LargeGlyph = (CType(resources.GetObject("deleteTableElementsItem1.LargeGlyph"), System.Drawing.Image))
			Me.deleteTableElementsItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.showDeleteTableCellsFormItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.deleteTableColumnsItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.deleteTableRowsItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.deleteTableItem1)})
			Me.deleteTableElementsItem1.Name = "deleteTableElementsItem1"
			' 
			' showDeleteTableCellsFormItem1
			' 
			Me.showDeleteTableCellsFormItem1.Glyph = (CType(resources.GetObject("showDeleteTableCellsFormItem1.Glyph"), System.Drawing.Image))
			Me.showDeleteTableCellsFormItem1.Id = 29
			Me.showDeleteTableCellsFormItem1.LargeGlyph = (CType(resources.GetObject("showDeleteTableCellsFormItem1.LargeGlyph"), System.Drawing.Image))
			Me.showDeleteTableCellsFormItem1.Name = "showDeleteTableCellsFormItem1"
			' 
			' deleteTableColumnsItem1
			' 
			Me.deleteTableColumnsItem1.Glyph = (CType(resources.GetObject("deleteTableColumnsItem1.Glyph"), System.Drawing.Image))
			Me.deleteTableColumnsItem1.Id = 30
			Me.deleteTableColumnsItem1.LargeGlyph = (CType(resources.GetObject("deleteTableColumnsItem1.LargeGlyph"), System.Drawing.Image))
			Me.deleteTableColumnsItem1.Name = "deleteTableColumnsItem1"
			' 
			' deleteTableRowsItem1
			' 
			Me.deleteTableRowsItem1.Glyph = (CType(resources.GetObject("deleteTableRowsItem1.Glyph"), System.Drawing.Image))
			Me.deleteTableRowsItem1.Id = 31
			Me.deleteTableRowsItem1.LargeGlyph = (CType(resources.GetObject("deleteTableRowsItem1.LargeGlyph"), System.Drawing.Image))
			Me.deleteTableRowsItem1.Name = "deleteTableRowsItem1"
			' 
			' deleteTableItem1
			' 
			Me.deleteTableItem1.Glyph = (CType(resources.GetObject("deleteTableItem1.Glyph"), System.Drawing.Image))
			Me.deleteTableItem1.Id = 32
			Me.deleteTableItem1.LargeGlyph = (CType(resources.GetObject("deleteTableItem1.LargeGlyph"), System.Drawing.Image))
			Me.deleteTableItem1.Name = "deleteTableItem1"
			' 
			' insertTableRowAboveItem1
			' 
			Me.insertTableRowAboveItem1.Glyph = (CType(resources.GetObject("insertTableRowAboveItem1.Glyph"), System.Drawing.Image))
			Me.insertTableRowAboveItem1.Id = 33
			Me.insertTableRowAboveItem1.LargeGlyph = (CType(resources.GetObject("insertTableRowAboveItem1.LargeGlyph"), System.Drawing.Image))
			Me.insertTableRowAboveItem1.Name = "insertTableRowAboveItem1"
			' 
			' insertTableRowBelowItem1
			' 
			Me.insertTableRowBelowItem1.Glyph = (CType(resources.GetObject("insertTableRowBelowItem1.Glyph"), System.Drawing.Image))
			Me.insertTableRowBelowItem1.Id = 34
			Me.insertTableRowBelowItem1.LargeGlyph = (CType(resources.GetObject("insertTableRowBelowItem1.LargeGlyph"), System.Drawing.Image))
			Me.insertTableRowBelowItem1.Name = "insertTableRowBelowItem1"
			' 
			' insertTableColumnToLeftItem1
			' 
			Me.insertTableColumnToLeftItem1.Glyph = (CType(resources.GetObject("insertTableColumnToLeftItem1.Glyph"), System.Drawing.Image))
			Me.insertTableColumnToLeftItem1.Id = 35
			Me.insertTableColumnToLeftItem1.LargeGlyph = (CType(resources.GetObject("insertTableColumnToLeftItem1.LargeGlyph"), System.Drawing.Image))
			Me.insertTableColumnToLeftItem1.Name = "insertTableColumnToLeftItem1"
			' 
			' insertTableColumnToRightItem1
			' 
			Me.insertTableColumnToRightItem1.Glyph = (CType(resources.GetObject("insertTableColumnToRightItem1.Glyph"), System.Drawing.Image))
			Me.insertTableColumnToRightItem1.Id = 36
			Me.insertTableColumnToRightItem1.LargeGlyph = (CType(resources.GetObject("insertTableColumnToRightItem1.LargeGlyph"), System.Drawing.Image))
			Me.insertTableColumnToRightItem1.Name = "insertTableColumnToRightItem1"
			' 
			' showInsertTableCellsFormItem1
			' 
			Me.showInsertTableCellsFormItem1.Glyph = (CType(resources.GetObject("showInsertTableCellsFormItem1.Glyph"), System.Drawing.Image))
			Me.showInsertTableCellsFormItem1.Id = 37
			Me.showInsertTableCellsFormItem1.LargeGlyph = (CType(resources.GetObject("showInsertTableCellsFormItem1.LargeGlyph"), System.Drawing.Image))
			Me.showInsertTableCellsFormItem1.Name = "showInsertTableCellsFormItem1"
			' 
			' mergeTableCellsItem1
			' 
			Me.mergeTableCellsItem1.Glyph = (CType(resources.GetObject("mergeTableCellsItem1.Glyph"), System.Drawing.Image))
			Me.mergeTableCellsItem1.Id = 38
			Me.mergeTableCellsItem1.LargeGlyph = (CType(resources.GetObject("mergeTableCellsItem1.LargeGlyph"), System.Drawing.Image))
			Me.mergeTableCellsItem1.Name = "mergeTableCellsItem1"
			' 
			' showSplitTableCellsForm1
			' 
			Me.showSplitTableCellsForm1.Glyph = (CType(resources.GetObject("showSplitTableCellsForm1.Glyph"), System.Drawing.Image))
			Me.showSplitTableCellsForm1.Id = 39
			Me.showSplitTableCellsForm1.LargeGlyph = (CType(resources.GetObject("showSplitTableCellsForm1.LargeGlyph"), System.Drawing.Image))
			Me.showSplitTableCellsForm1.Name = "showSplitTableCellsForm1"
			' 
			' splitTableItem1
			' 
			Me.splitTableItem1.Glyph = (CType(resources.GetObject("splitTableItem1.Glyph"), System.Drawing.Image))
			Me.splitTableItem1.Id = 40
			Me.splitTableItem1.LargeGlyph = (CType(resources.GetObject("splitTableItem1.LargeGlyph"), System.Drawing.Image))
			Me.splitTableItem1.Name = "splitTableItem1"
			' 
			' toggleTableAutoFitItem1
			' 
			Me.toggleTableAutoFitItem1.Glyph = (CType(resources.GetObject("toggleTableAutoFitItem1.Glyph"), System.Drawing.Image))
			Me.toggleTableAutoFitItem1.Id = 41
			Me.toggleTableAutoFitItem1.LargeGlyph = (CType(resources.GetObject("toggleTableAutoFitItem1.LargeGlyph"), System.Drawing.Image))
			Me.toggleTableAutoFitItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableAutoFitContentsItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableAutoFitWindowItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableFixedColumnWidthItem1)})
			Me.toggleTableAutoFitItem1.Name = "toggleTableAutoFitItem1"
			' 
			' toggleTableAutoFitContentsItem1
			' 
			Me.toggleTableAutoFitContentsItem1.Glyph = (CType(resources.GetObject("toggleTableAutoFitContentsItem1.Glyph"), System.Drawing.Image))
			Me.toggleTableAutoFitContentsItem1.Id = 42
			Me.toggleTableAutoFitContentsItem1.LargeGlyph = (CType(resources.GetObject("toggleTableAutoFitContentsItem1.LargeGlyph"), System.Drawing.Image))
			Me.toggleTableAutoFitContentsItem1.Name = "toggleTableAutoFitContentsItem1"
			' 
			' toggleTableAutoFitWindowItem1
			' 
			Me.toggleTableAutoFitWindowItem1.Glyph = (CType(resources.GetObject("toggleTableAutoFitWindowItem1.Glyph"), System.Drawing.Image))
			Me.toggleTableAutoFitWindowItem1.Id = 43
			Me.toggleTableAutoFitWindowItem1.LargeGlyph = (CType(resources.GetObject("toggleTableAutoFitWindowItem1.LargeGlyph"), System.Drawing.Image))
			Me.toggleTableAutoFitWindowItem1.Name = "toggleTableAutoFitWindowItem1"
			' 
			' toggleTableFixedColumnWidthItem1
			' 
			Me.toggleTableFixedColumnWidthItem1.Glyph = (CType(resources.GetObject("toggleTableFixedColumnWidthItem1.Glyph"), System.Drawing.Image))
			Me.toggleTableFixedColumnWidthItem1.Id = 44
			Me.toggleTableFixedColumnWidthItem1.LargeGlyph = (CType(resources.GetObject("toggleTableFixedColumnWidthItem1.LargeGlyph"), System.Drawing.Image))
			Me.toggleTableFixedColumnWidthItem1.Name = "toggleTableFixedColumnWidthItem1"
			' 
			' toggleTableCellsTopLeftAlignmentItem1
			' 
			Me.toggleTableCellsTopLeftAlignmentItem1.Glyph = (CType(resources.GetObject("toggleTableCellsTopLeftAlignmentItem1.Glyph"), System.Drawing.Image))
			Me.toggleTableCellsTopLeftAlignmentItem1.Id = 45
			Me.toggleTableCellsTopLeftAlignmentItem1.LargeGlyph = (CType(resources.GetObject("toggleTableCellsTopLeftAlignmentItem1.LargeGlyph"), System.Drawing.Image))
			Me.toggleTableCellsTopLeftAlignmentItem1.Name = "toggleTableCellsTopLeftAlignmentItem1"
			' 
			' toggleTableCellsTopCenterAlignmentItem1
			' 
			Me.toggleTableCellsTopCenterAlignmentItem1.Glyph = (CType(resources.GetObject("toggleTableCellsTopCenterAlignmentItem1.Glyph"), System.Drawing.Image))
			Me.toggleTableCellsTopCenterAlignmentItem1.Id = 46
			Me.toggleTableCellsTopCenterAlignmentItem1.LargeGlyph = (CType(resources.GetObject("toggleTableCellsTopCenterAlignmentItem1.LargeGlyph"), System.Drawing.Image))
			Me.toggleTableCellsTopCenterAlignmentItem1.Name = "toggleTableCellsTopCenterAlignmentItem1"
			' 
			' toggleTableCellsTopRightAlignmentItem1
			' 
			Me.toggleTableCellsTopRightAlignmentItem1.Glyph = (CType(resources.GetObject("toggleTableCellsTopRightAlignmentItem1.Glyph"), System.Drawing.Image))
			Me.toggleTableCellsTopRightAlignmentItem1.Id = 47
			Me.toggleTableCellsTopRightAlignmentItem1.LargeGlyph = (CType(resources.GetObject("toggleTableCellsTopRightAlignmentItem1.LargeGlyph"), System.Drawing.Image))
			Me.toggleTableCellsTopRightAlignmentItem1.Name = "toggleTableCellsTopRightAlignmentItem1"
			' 
			' toggleTableCellsMiddleLeftAlignmentItem1
			' 
			Me.toggleTableCellsMiddleLeftAlignmentItem1.Glyph = (CType(resources.GetObject("toggleTableCellsMiddleLeftAlignmentItem1.Glyph"), System.Drawing.Image))
			Me.toggleTableCellsMiddleLeftAlignmentItem1.Id = 48
			Me.toggleTableCellsMiddleLeftAlignmentItem1.LargeGlyph = (CType(resources.GetObject("toggleTableCellsMiddleLeftAlignmentItem1.LargeGlyph"), System.Drawing.Image))
			Me.toggleTableCellsMiddleLeftAlignmentItem1.Name = "toggleTableCellsMiddleLeftAlignmentItem1"
			' 
			' toggleTableCellsMiddleCenterAlignmentItem1
			' 
			Me.toggleTableCellsMiddleCenterAlignmentItem1.Glyph = (CType(resources.GetObject("toggleTableCellsMiddleCenterAlignmentItem1.Glyph"), System.Drawing.Image))
			Me.toggleTableCellsMiddleCenterAlignmentItem1.Id = 49
			Me.toggleTableCellsMiddleCenterAlignmentItem1.LargeGlyph = (CType(resources.GetObject("toggleTableCellsMiddleCenterAlignmentItem1.LargeGlyph"), System.Drawing.Image))
			Me.toggleTableCellsMiddleCenterAlignmentItem1.Name = "toggleTableCellsMiddleCenterAlignmentItem1"
			' 
			' toggleTableCellsMiddleRightAlignmentItem1
			' 
			Me.toggleTableCellsMiddleRightAlignmentItem1.Glyph = (CType(resources.GetObject("toggleTableCellsMiddleRightAlignmentItem1.Glyph"), System.Drawing.Image))
			Me.toggleTableCellsMiddleRightAlignmentItem1.Id = 50
			Me.toggleTableCellsMiddleRightAlignmentItem1.LargeGlyph = (CType(resources.GetObject("toggleTableCellsMiddleRightAlignmentItem1.LargeGlyph"), System.Drawing.Image))
			Me.toggleTableCellsMiddleRightAlignmentItem1.Name = "toggleTableCellsMiddleRightAlignmentItem1"
			' 
			' toggleTableCellsBottomLeftAlignmentItem1
			' 
			Me.toggleTableCellsBottomLeftAlignmentItem1.Glyph = (CType(resources.GetObject("toggleTableCellsBottomLeftAlignmentItem1.Glyph"), System.Drawing.Image))
			Me.toggleTableCellsBottomLeftAlignmentItem1.Id = 51
			Me.toggleTableCellsBottomLeftAlignmentItem1.LargeGlyph = (CType(resources.GetObject("toggleTableCellsBottomLeftAlignmentItem1.LargeGlyph"), System.Drawing.Image))
			Me.toggleTableCellsBottomLeftAlignmentItem1.Name = "toggleTableCellsBottomLeftAlignmentItem1"
			' 
			' toggleTableCellsBottomCenterAlignmentItem1
			' 
			Me.toggleTableCellsBottomCenterAlignmentItem1.Glyph = (CType(resources.GetObject("toggleTableCellsBottomCenterAlignmentItem1.Glyph"), System.Drawing.Image))
			Me.toggleTableCellsBottomCenterAlignmentItem1.Id = 52
			Me.toggleTableCellsBottomCenterAlignmentItem1.LargeGlyph = (CType(resources.GetObject("toggleTableCellsBottomCenterAlignmentItem1.LargeGlyph"), System.Drawing.Image))
			Me.toggleTableCellsBottomCenterAlignmentItem1.Name = "toggleTableCellsBottomCenterAlignmentItem1"
			' 
			' toggleTableCellsBottomRightAlignmentItem1
			' 
			Me.toggleTableCellsBottomRightAlignmentItem1.Glyph = (CType(resources.GetObject("toggleTableCellsBottomRightAlignmentItem1.Glyph"), System.Drawing.Image))
			Me.toggleTableCellsBottomRightAlignmentItem1.Id = 53
			Me.toggleTableCellsBottomRightAlignmentItem1.LargeGlyph = (CType(resources.GetObject("toggleTableCellsBottomRightAlignmentItem1.LargeGlyph"), System.Drawing.Image))
			Me.toggleTableCellsBottomRightAlignmentItem1.Name = "toggleTableCellsBottomRightAlignmentItem1"
			' 
			' insertPageBreakItem1
			' 
			Me.insertPageBreakItem1.Glyph = (CType(resources.GetObject("insertPageBreakItem1.Glyph"), System.Drawing.Image))
			Me.insertPageBreakItem1.Id = 54
			Me.insertPageBreakItem1.LargeGlyph = (CType(resources.GetObject("insertPageBreakItem1.LargeGlyph"), System.Drawing.Image))
			Me.insertPageBreakItem1.Name = "insertPageBreakItem1"
			' 
			' insertTableItem1
			' 
			Me.insertTableItem1.Glyph = (CType(resources.GetObject("insertTableItem1.Glyph"), System.Drawing.Image))
			Me.insertTableItem1.Id = 55
			Me.insertTableItem1.LargeGlyph = (CType(resources.GetObject("insertTableItem1.LargeGlyph"), System.Drawing.Image))
			Me.insertTableItem1.Name = "insertTableItem1"
			' 
			' insertPictureItem1
			' 
			Me.insertPictureItem1.Glyph = (CType(resources.GetObject("insertPictureItem1.Glyph"), System.Drawing.Image))
			Me.insertPictureItem1.Id = 56
			Me.insertPictureItem1.LargeGlyph = (CType(resources.GetObject("insertPictureItem1.LargeGlyph"), System.Drawing.Image))
			Me.insertPictureItem1.Name = "insertPictureItem1"
			' 
			' insertBookmarkItem1
			' 
			Me.insertBookmarkItem1.Glyph = (CType(resources.GetObject("insertBookmarkItem1.Glyph"), System.Drawing.Image))
			Me.insertBookmarkItem1.Id = 57
			Me.insertBookmarkItem1.LargeGlyph = (CType(resources.GetObject("insertBookmarkItem1.LargeGlyph"), System.Drawing.Image))
			Me.insertBookmarkItem1.Name = "insertBookmarkItem1"
			' 
			' insertHyperlinkItem1
			' 
			Me.insertHyperlinkItem1.Glyph = (CType(resources.GetObject("insertHyperlinkItem1.Glyph"), System.Drawing.Image))
			Me.insertHyperlinkItem1.Id = 58
			Me.insertHyperlinkItem1.LargeGlyph = (CType(resources.GetObject("insertHyperlinkItem1.LargeGlyph"), System.Drawing.Image))
			Me.insertHyperlinkItem1.Name = "insertHyperlinkItem1"
			' 
			' editPageHeaderItem1
			' 
			Me.editPageHeaderItem1.Glyph = (CType(resources.GetObject("editPageHeaderItem1.Glyph"), System.Drawing.Image))
			Me.editPageHeaderItem1.Id = 59
			Me.editPageHeaderItem1.LargeGlyph = (CType(resources.GetObject("editPageHeaderItem1.LargeGlyph"), System.Drawing.Image))
			Me.editPageHeaderItem1.Name = "editPageHeaderItem1"
			' 
			' editPageFooterItem1
			' 
			Me.editPageFooterItem1.Glyph = (CType(resources.GetObject("editPageFooterItem1.Glyph"), System.Drawing.Image))
			Me.editPageFooterItem1.Id = 60
			Me.editPageFooterItem1.LargeGlyph = (CType(resources.GetObject("editPageFooterItem1.LargeGlyph"), System.Drawing.Image))
			Me.editPageFooterItem1.Name = "editPageFooterItem1"
			' 
			' insertPageNumberItem1
			' 
			Me.insertPageNumberItem1.Glyph = (CType(resources.GetObject("insertPageNumberItem1.Glyph"), System.Drawing.Image))
			Me.insertPageNumberItem1.Id = 61
			Me.insertPageNumberItem1.LargeGlyph = (CType(resources.GetObject("insertPageNumberItem1.LargeGlyph"), System.Drawing.Image))
			Me.insertPageNumberItem1.Name = "insertPageNumberItem1"
			' 
			' insertPageCountItem1
			' 
			Me.insertPageCountItem1.Glyph = (CType(resources.GetObject("insertPageCountItem1.Glyph"), System.Drawing.Image))
			Me.insertPageCountItem1.Id = 62
			Me.insertPageCountItem1.LargeGlyph = (CType(resources.GetObject("insertPageCountItem1.LargeGlyph"), System.Drawing.Image))
			Me.insertPageCountItem1.Name = "insertPageCountItem1"
			' 
			' insertSymbolItem1
			' 
			Me.insertSymbolItem1.Glyph = (CType(resources.GetObject("insertSymbolItem1.Glyph"), System.Drawing.Image))
			Me.insertSymbolItem1.Id = 63
			Me.insertSymbolItem1.LargeGlyph = (CType(resources.GetObject("insertSymbolItem1.LargeGlyph"), System.Drawing.Image))
			Me.insertSymbolItem1.Name = "insertSymbolItem1"
			' 
			' tableToolsRibbonPageCategory1
			' 
			Me.tableToolsRibbonPageCategory1.Name = "tableToolsRibbonPageCategory1"
			Me.tableToolsRibbonPageCategory1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.tableDesignRibbonPage1, Me.tableLayoutRibbonPage1})
			' 
			' tableDesignRibbonPage1
			' 
			Me.tableDesignRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.tableStylesRibbonPageGroup1, Me.tableDrawBordersRibbonPageGroup1})
			Me.tableDesignRibbonPage1.Name = "tableDesignRibbonPage1"
			' 
			' tableStylesRibbonPageGroup1
			' 
			Me.tableStylesRibbonPageGroup1.ItemLinks.Add(Me.changeTableCellsShadingItem1)
			Me.tableStylesRibbonPageGroup1.ItemLinks.Add(Me.changeTableBordersItem1)
			Me.tableStylesRibbonPageGroup1.Name = "tableStylesRibbonPageGroup1"
			Me.tableStylesRibbonPageGroup1.RichEditControl = Me.mainRichEdit
			' 
			' tableDrawBordersRibbonPageGroup1
			' 
			Me.tableDrawBordersRibbonPageGroup1.ItemLinks.Add(Me.changeTableBorderLineStyleItem1)
			Me.tableDrawBordersRibbonPageGroup1.ItemLinks.Add(Me.changeTableBorderLineWeightItem1)
			Me.tableDrawBordersRibbonPageGroup1.ItemLinks.Add(Me.changeTableBorderColorItem1)
			Me.tableDrawBordersRibbonPageGroup1.Name = "tableDrawBordersRibbonPageGroup1"
			Me.tableDrawBordersRibbonPageGroup1.RichEditControl = Me.mainRichEdit
			' 
			' tableLayoutRibbonPage1
			' 
			Me.tableLayoutRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.tableTableRibbonPageGroup1, Me.tableRowsAndColumnsRibbonPageGroup1, Me.tableMergeRibbonPageGroup1, Me.tableCellSizeRibbonPageGroup1, Me.tableAlignmentRibbonPageGroup1})
			Me.tableLayoutRibbonPage1.Name = "tableLayoutRibbonPage1"
			' 
			' tableTableRibbonPageGroup1
			' 
			Me.tableTableRibbonPageGroup1.ItemLinks.Add(Me.selectTableElementsItem1)
			Me.tableTableRibbonPageGroup1.ItemLinks.Add(Me.toggleShowTableGridLinesItem1)
			Me.tableTableRibbonPageGroup1.ItemLinks.Add(Me.showTablePropertiesFormItem1)
			Me.tableTableRibbonPageGroup1.Name = "tableTableRibbonPageGroup1"
			Me.tableTableRibbonPageGroup1.RichEditControl = Me.mainRichEdit
			' 
			' tableRowsAndColumnsRibbonPageGroup1
			' 
			Me.tableRowsAndColumnsRibbonPageGroup1.ItemLinks.Add(Me.deleteTableElementsItem1)
			Me.tableRowsAndColumnsRibbonPageGroup1.ItemLinks.Add(Me.insertTableRowAboveItem1)
			Me.tableRowsAndColumnsRibbonPageGroup1.ItemLinks.Add(Me.insertTableRowBelowItem1)
			Me.tableRowsAndColumnsRibbonPageGroup1.ItemLinks.Add(Me.insertTableColumnToLeftItem1)
			Me.tableRowsAndColumnsRibbonPageGroup1.ItemLinks.Add(Me.insertTableColumnToRightItem1)
			Me.tableRowsAndColumnsRibbonPageGroup1.ItemLinks.Add(Me.showInsertTableCellsFormItem1)
			Me.tableRowsAndColumnsRibbonPageGroup1.Name = "tableRowsAndColumnsRibbonPageGroup1"
			Me.tableRowsAndColumnsRibbonPageGroup1.RichEditControl = Me.mainRichEdit
			' 
			' tableMergeRibbonPageGroup1
			' 
			Me.tableMergeRibbonPageGroup1.ItemLinks.Add(Me.mergeTableCellsItem1)
			Me.tableMergeRibbonPageGroup1.ItemLinks.Add(Me.showSplitTableCellsForm1)
			Me.tableMergeRibbonPageGroup1.ItemLinks.Add(Me.splitTableItem1)
			Me.tableMergeRibbonPageGroup1.Name = "tableMergeRibbonPageGroup1"
			Me.tableMergeRibbonPageGroup1.RichEditControl = Me.mainRichEdit
			' 
			' tableCellSizeRibbonPageGroup1
			' 
			Me.tableCellSizeRibbonPageGroup1.ItemLinks.Add(Me.toggleTableAutoFitItem1)
			Me.tableCellSizeRibbonPageGroup1.Name = "tableCellSizeRibbonPageGroup1"
			Me.tableCellSizeRibbonPageGroup1.RichEditControl = Me.mainRichEdit
			' 
			' tableAlignmentRibbonPageGroup1
			' 
			Me.tableAlignmentRibbonPageGroup1.ItemLinks.Add(Me.toggleTableCellsTopLeftAlignmentItem1)
			Me.tableAlignmentRibbonPageGroup1.ItemLinks.Add(Me.toggleTableCellsTopCenterAlignmentItem1)
			Me.tableAlignmentRibbonPageGroup1.ItemLinks.Add(Me.toggleTableCellsTopRightAlignmentItem1)
			Me.tableAlignmentRibbonPageGroup1.ItemLinks.Add(Me.toggleTableCellsMiddleLeftAlignmentItem1)
			Me.tableAlignmentRibbonPageGroup1.ItemLinks.Add(Me.toggleTableCellsMiddleCenterAlignmentItem1)
			Me.tableAlignmentRibbonPageGroup1.ItemLinks.Add(Me.toggleTableCellsMiddleRightAlignmentItem1)
			Me.tableAlignmentRibbonPageGroup1.ItemLinks.Add(Me.toggleTableCellsBottomLeftAlignmentItem1)
			Me.tableAlignmentRibbonPageGroup1.ItemLinks.Add(Me.toggleTableCellsBottomCenterAlignmentItem1)
			Me.tableAlignmentRibbonPageGroup1.ItemLinks.Add(Me.toggleTableCellsBottomRightAlignmentItem1)
			Me.tableAlignmentRibbonPageGroup1.Name = "tableAlignmentRibbonPageGroup1"
			Me.tableAlignmentRibbonPageGroup1.RichEditControl = Me.mainRichEdit
			' 
			' mailingsRibbonPage1
			' 
			Me.mailingsRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.mailMergeRibbonPageGroup1, Me.ribbonPageGroup1})
			Me.mailingsRibbonPage1.Name = "mailingsRibbonPage1"
			' 
			' mailMergeRibbonPageGroup1
			' 
			Me.mailMergeRibbonPageGroup1.ItemLinks.Add(Me.insertMergeFieldItem1)
			Me.mailMergeRibbonPageGroup1.ItemLinks.Add(Me.showAllFieldCodesItem1)
			Me.mailMergeRibbonPageGroup1.ItemLinks.Add(Me.showAllFieldResultsItem1)
			Me.mailMergeRibbonPageGroup1.ItemLinks.Add(Me.toggleViewMergedDataItem1)
			Me.mailMergeRibbonPageGroup1.Name = "mailMergeRibbonPageGroup1"
			Me.mailMergeRibbonPageGroup1.RichEditControl = Me.mainRichEdit
			' 
			' ribbonPageGroup1
			' 
			Me.ribbonPageGroup1.ItemLinks.Add(Me.performMailMergeItem1)
			Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
			Me.ribbonPageGroup1.Text = "Actions"
			' 
			' insertRibbonPage1
			' 
			Me.insertRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.pagesRibbonPageGroup1, Me.tablesRibbonPageGroup1, Me.illustrationsRibbonPageGroup1, Me.linksRibbonPageGroup1, Me.headerFooterRibbonPageGroup1, Me.symbolsRibbonPageGroup1})
			Me.insertRibbonPage1.Name = "insertRibbonPage1"
			' 
			' pagesRibbonPageGroup1
			' 
			Me.pagesRibbonPageGroup1.ItemLinks.Add(Me.insertPageBreakItem1)
			Me.pagesRibbonPageGroup1.Name = "pagesRibbonPageGroup1"
			Me.pagesRibbonPageGroup1.RichEditControl = Me.mainRichEdit
			' 
			' tablesRibbonPageGroup1
			' 
			Me.tablesRibbonPageGroup1.ItemLinks.Add(Me.insertTableItem1)
			Me.tablesRibbonPageGroup1.Name = "tablesRibbonPageGroup1"
			Me.tablesRibbonPageGroup1.RichEditControl = Me.mainRichEdit
			' 
			' illustrationsRibbonPageGroup1
			' 
			Me.illustrationsRibbonPageGroup1.ItemLinks.Add(Me.insertPictureItem1)
			Me.illustrationsRibbonPageGroup1.Name = "illustrationsRibbonPageGroup1"
			Me.illustrationsRibbonPageGroup1.RichEditControl = Me.mainRichEdit
			' 
			' linksRibbonPageGroup1
			' 
			Me.linksRibbonPageGroup1.ItemLinks.Add(Me.insertBookmarkItem1)
			Me.linksRibbonPageGroup1.ItemLinks.Add(Me.insertHyperlinkItem1)
			Me.linksRibbonPageGroup1.Name = "linksRibbonPageGroup1"
			Me.linksRibbonPageGroup1.RichEditControl = Me.mainRichEdit
			' 
			' headerFooterRibbonPageGroup1
			' 
			Me.headerFooterRibbonPageGroup1.ItemLinks.Add(Me.editPageHeaderItem1)
			Me.headerFooterRibbonPageGroup1.ItemLinks.Add(Me.editPageFooterItem1)
			Me.headerFooterRibbonPageGroup1.ItemLinks.Add(Me.insertPageNumberItem1)
			Me.headerFooterRibbonPageGroup1.ItemLinks.Add(Me.insertPageCountItem1)
			Me.headerFooterRibbonPageGroup1.Name = "headerFooterRibbonPageGroup1"
			Me.headerFooterRibbonPageGroup1.RichEditControl = Me.mainRichEdit
			' 
			' symbolsRibbonPageGroup1
			' 
			Me.symbolsRibbonPageGroup1.ItemLinks.Add(Me.insertSymbolItem1)
			Me.symbolsRibbonPageGroup1.Name = "symbolsRibbonPageGroup1"
			Me.symbolsRibbonPageGroup1.RichEditControl = Me.mainRichEdit
			' 
			' xtraTabPage2
			' 
			Me.xtraTabPage2.Controls.Add(Me.suppllierRichEdit)
			Me.xtraTabPage2.Name = "xtraTabPage2"
			Me.xtraTabPage2.Size = New System.Drawing.Size(1025, 439)
			Me.xtraTabPage2.Tag = ""
			Me.xtraTabPage2.Text = "Master (Supplier)"
			' 
			' suppllierRichEdit
			' 
			Me.suppllierRichEdit.Dock = System.Windows.Forms.DockStyle.Fill
			Me.suppllierRichEdit.Location = New System.Drawing.Point(0, 0)
			Me.suppllierRichEdit.MenuManager = Me.ribbonControl1
			Me.suppllierRichEdit.Name = "suppllierRichEdit"
			Me.suppllierRichEdit.Options.Fields.HighlightMode = DevExpress.XtraRichEdit.FieldsHighlightMode.Always
			Me.suppllierRichEdit.Size = New System.Drawing.Size(1025, 439)
			Me.suppllierRichEdit.TabIndex = 1
			Me.suppllierRichEdit.Text = "Master (Supplier)"
			' 
			' xtraTabPage3
			' 
			Me.xtraTabPage3.Controls.Add(Me.productRichEdit)
			Me.xtraTabPage3.Name = "xtraTabPage3"
			Me.xtraTabPage3.Size = New System.Drawing.Size(1025, 439)
			Me.xtraTabPage3.Tag = ""
			Me.xtraTabPage3.Text = "Detail (Product)"
			' 
			' productRichEdit
			' 
			Me.productRichEdit.Dock = System.Windows.Forms.DockStyle.Fill
			Me.productRichEdit.Location = New System.Drawing.Point(0, 0)
			Me.productRichEdit.MenuManager = Me.ribbonControl1
			Me.productRichEdit.Name = "productRichEdit"
			Me.productRichEdit.Options.Fields.HighlightMode = DevExpress.XtraRichEdit.FieldsHighlightMode.Always
			Me.productRichEdit.Size = New System.Drawing.Size(1025, 439)
			Me.productRichEdit.TabIndex = 2
			Me.productRichEdit.Text = "Detail (Product)"
			' 
			' xtraTabPage4
			' 
			Me.xtraTabPage4.Controls.Add(Me.ordersRichEdit)
			Me.xtraTabPage4.Name = "xtraTabPage4"
			Me.xtraTabPage4.Size = New System.Drawing.Size(1025, 439)
			Me.xtraTabPage4.Tag = ""
			Me.xtraTabPage4.Text = "Detail (Product.Orders)"
			' 
			' ordersRichEdit
			' 
			Me.ordersRichEdit.Dock = System.Windows.Forms.DockStyle.Fill
			Me.ordersRichEdit.Location = New System.Drawing.Point(0, 0)
			Me.ordersRichEdit.MenuManager = Me.ribbonControl1
			Me.ordersRichEdit.Name = "ordersRichEdit"
			Me.ordersRichEdit.Options.Fields.HighlightMode = DevExpress.XtraRichEdit.FieldsHighlightMode.Always
			Me.ordersRichEdit.Size = New System.Drawing.Size(1025, 439)
			Me.ordersRichEdit.TabIndex = 3
			Me.ordersRichEdit.Text = "Detail (Product.Orders)"
			' 
			' xtraTabPage5
			' 
			Me.xtraTabPage5.Controls.Add(Me.resultRichEdit)
			Me.xtraTabPage5.Name = "xtraTabPage5"
			Me.xtraTabPage5.Size = New System.Drawing.Size(1025, 439)
			Me.xtraTabPage5.Text = "Result"
			' 
			' resultRichEdit
			' 
			Me.resultRichEdit.Dock = System.Windows.Forms.DockStyle.Fill
			Me.resultRichEdit.LayoutUnit = DevExpress.XtraRichEdit.DocumentLayoutUnit.Pixel
			Me.resultRichEdit.Location = New System.Drawing.Point(0, 0)
			Me.resultRichEdit.MenuManager = Me.ribbonControl1
			Me.resultRichEdit.Name = "resultRichEdit"
			Me.resultRichEdit.Options.Fields.HighlightMode = DevExpress.XtraRichEdit.FieldsHighlightMode.Always
			Me.resultRichEdit.Size = New System.Drawing.Size(1025, 439)
			Me.resultRichEdit.TabIndex = 4
			Me.resultRichEdit.Text = "Result"
			' 
			' xtraTabPage6
			' 
			Me.xtraTabPage6.Controls.Add(Me.gridControl1)
			Me.xtraTabPage6.Name = "xtraTabPage6"
			Me.xtraTabPage6.Size = New System.Drawing.Size(1025, 439)
			Me.xtraTabPage6.Text = "XtraGrid Data View"
			' 
			' gridControl1
			' 
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(1025, 439)
			Me.gridControl1.TabIndex = 1
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' gridView1
			' 
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			' 
			' richEditBarController1
			' 
			Me.richEditBarController1.BarItems.Add(Me.insertMergeFieldItem1)
			Me.richEditBarController1.BarItems.Add(Me.showAllFieldCodesItem1)
			Me.richEditBarController1.BarItems.Add(Me.showAllFieldResultsItem1)
			Me.richEditBarController1.BarItems.Add(Me.toggleViewMergedDataItem1)
			Me.richEditBarController1.BarItems.Add(Me.changeTableCellsShadingItem1)
			Me.richEditBarController1.BarItems.Add(Me.changeTableBordersItem1)
			Me.richEditBarController1.BarItems.Add(Me.toggleTableCellsBottomBorderItem1)
			Me.richEditBarController1.BarItems.Add(Me.toggleTableCellsTopBorderItem1)
			Me.richEditBarController1.BarItems.Add(Me.toggleTableCellsLeftBorderItem1)
			Me.richEditBarController1.BarItems.Add(Me.toggleTableCellsRightBorderItem1)
			Me.richEditBarController1.BarItems.Add(Me.resetTableCellsAllBordersItem1)
			Me.richEditBarController1.BarItems.Add(Me.toggleTableCellsAllBordersItem1)
			Me.richEditBarController1.BarItems.Add(Me.toggleTableCellsOutsideBorderItem1)
			Me.richEditBarController1.BarItems.Add(Me.toggleTableCellsInsideBorderItem1)
			Me.richEditBarController1.BarItems.Add(Me.toggleTableCellsInsideHorizontalBorderItem1)
			Me.richEditBarController1.BarItems.Add(Me.toggleTableCellsInsideVerticalBorderItem1)
			Me.richEditBarController1.BarItems.Add(Me.toggleShowTableGridLinesItem1)
			Me.richEditBarController1.BarItems.Add(Me.changeTableBorderLineStyleItem1)
			Me.richEditBarController1.BarItems.Add(Me.changeTableBorderLineWeightItem1)
			Me.richEditBarController1.BarItems.Add(Me.changeTableBorderColorItem1)
			Me.richEditBarController1.BarItems.Add(Me.selectTableElementsItem1)
			Me.richEditBarController1.BarItems.Add(Me.selectTableCellItem1)
			Me.richEditBarController1.BarItems.Add(Me.selectTableColumnItem1)
			Me.richEditBarController1.BarItems.Add(Me.selectTableRowItem1)
			Me.richEditBarController1.BarItems.Add(Me.selectTableItem1)
			Me.richEditBarController1.BarItems.Add(Me.showTablePropertiesFormItem1)
			Me.richEditBarController1.BarItems.Add(Me.deleteTableElementsItem1)
			Me.richEditBarController1.BarItems.Add(Me.showDeleteTableCellsFormItem1)
			Me.richEditBarController1.BarItems.Add(Me.deleteTableColumnsItem1)
			Me.richEditBarController1.BarItems.Add(Me.deleteTableRowsItem1)
			Me.richEditBarController1.BarItems.Add(Me.deleteTableItem1)
			Me.richEditBarController1.BarItems.Add(Me.insertTableRowAboveItem1)
			Me.richEditBarController1.BarItems.Add(Me.insertTableRowBelowItem1)
			Me.richEditBarController1.BarItems.Add(Me.insertTableColumnToLeftItem1)
			Me.richEditBarController1.BarItems.Add(Me.insertTableColumnToRightItem1)
			Me.richEditBarController1.BarItems.Add(Me.showInsertTableCellsFormItem1)
			Me.richEditBarController1.BarItems.Add(Me.mergeTableCellsItem1)
			Me.richEditBarController1.BarItems.Add(Me.showSplitTableCellsForm1)
			Me.richEditBarController1.BarItems.Add(Me.splitTableItem1)
			Me.richEditBarController1.BarItems.Add(Me.toggleTableAutoFitItem1)
			Me.richEditBarController1.BarItems.Add(Me.toggleTableAutoFitContentsItem1)
			Me.richEditBarController1.BarItems.Add(Me.toggleTableAutoFitWindowItem1)
			Me.richEditBarController1.BarItems.Add(Me.toggleTableFixedColumnWidthItem1)
			Me.richEditBarController1.BarItems.Add(Me.toggleTableCellsTopLeftAlignmentItem1)
			Me.richEditBarController1.BarItems.Add(Me.toggleTableCellsTopCenterAlignmentItem1)
			Me.richEditBarController1.BarItems.Add(Me.toggleTableCellsTopRightAlignmentItem1)
			Me.richEditBarController1.BarItems.Add(Me.toggleTableCellsMiddleLeftAlignmentItem1)
			Me.richEditBarController1.BarItems.Add(Me.toggleTableCellsMiddleCenterAlignmentItem1)
			Me.richEditBarController1.BarItems.Add(Me.toggleTableCellsMiddleRightAlignmentItem1)
			Me.richEditBarController1.BarItems.Add(Me.toggleTableCellsBottomLeftAlignmentItem1)
			Me.richEditBarController1.BarItems.Add(Me.toggleTableCellsBottomCenterAlignmentItem1)
			Me.richEditBarController1.BarItems.Add(Me.toggleTableCellsBottomRightAlignmentItem1)
			Me.richEditBarController1.BarItems.Add(Me.insertPageBreakItem1)
			Me.richEditBarController1.BarItems.Add(Me.insertTableItem1)
			Me.richEditBarController1.BarItems.Add(Me.insertPictureItem1)
			Me.richEditBarController1.BarItems.Add(Me.insertBookmarkItem1)
			Me.richEditBarController1.BarItems.Add(Me.insertHyperlinkItem1)
			Me.richEditBarController1.BarItems.Add(Me.editPageHeaderItem1)
			Me.richEditBarController1.BarItems.Add(Me.editPageFooterItem1)
			Me.richEditBarController1.BarItems.Add(Me.insertPageNumberItem1)
			Me.richEditBarController1.BarItems.Add(Me.insertPageCountItem1)
			Me.richEditBarController1.BarItems.Add(Me.insertSymbolItem1)
			Me.richEditBarController1.RichEditControl = Me.mainRichEdit
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(1031, 610)
			Me.Controls.Add(Me.xtraTabControl1)
			Me.Controls.Add(Me.ribbonControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xtraTabControl1.ResumeLayout(False)
			Me.xtraTabPage1.ResumeLayout(False)
			CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemBorderLineStyle1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemBorderLineWeight1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xtraTabPage2.ResumeLayout(False)
			Me.xtraTabPage3.ResumeLayout(False)
			Me.xtraTabPage4.ResumeLayout(False)
			Me.xtraTabPage5.ResumeLayout(False)
			Me.xtraTabPage6.ResumeLayout(False)
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.richEditBarController1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private xtraTabControl1 As DevExpress.XtraTab.XtraTabControl
		Private xtraTabPage1 As DevExpress.XtraTab.XtraTabPage
		Private xtraTabPage2 As DevExpress.XtraTab.XtraTabPage
		Private mainRichEdit As DevExpress.XtraRichEdit.RichEditControl
		Private ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
		Private insertMergeFieldItem1 As DevExpress.XtraRichEdit.UI.InsertMergeFieldItem
		Private showAllFieldCodesItem1 As DevExpress.XtraRichEdit.UI.ShowAllFieldCodesItem
		Private showAllFieldResultsItem1 As DevExpress.XtraRichEdit.UI.ShowAllFieldResultsItem
		Private toggleViewMergedDataItem1 As DevExpress.XtraRichEdit.UI.ToggleViewMergedDataItem
		Private mailingsRibbonPage1 As DevExpress.XtraRichEdit.UI.MailingsRibbonPage
		Private mailMergeRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.MailMergeRibbonPageGroup
		Private xtraTabPage3 As DevExpress.XtraTab.XtraTabPage
		Private xtraTabPage4 As DevExpress.XtraTab.XtraTabPage
		Private richEditBarController1 As DevExpress.XtraRichEdit.UI.RichEditBarController
		Private suppllierRichEdit As DevExpress.XtraRichEdit.RichEditControl
		Private productRichEdit As DevExpress.XtraRichEdit.RichEditControl
		Private ordersRichEdit As DevExpress.XtraRichEdit.RichEditControl
		Private WithEvents performMailMergeItem1 As DevExpress.XtraBars.BarButtonItem
		Private ribbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private xtraTabPage5 As DevExpress.XtraTab.XtraTabPage
		Private resultRichEdit As DevExpress.XtraRichEdit.RichEditControl
		Private xtraTabPage6 As DevExpress.XtraTab.XtraTabPage
		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private changeTableCellsShadingItem1 As DevExpress.XtraRichEdit.UI.ChangeTableCellsShadingItem
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
		Private changeTableBorderLineStyleItem1 As DevExpress.XtraRichEdit.UI.ChangeTableBorderLineStyleItem
		Private repositoryItemBorderLineStyle1 As DevExpress.XtraRichEdit.Forms.Design.RepositoryItemBorderLineStyle
		Private changeTableBorderLineWeightItem1 As DevExpress.XtraRichEdit.UI.ChangeTableBorderLineWeightItem
		Private repositoryItemBorderLineWeight1 As DevExpress.XtraRichEdit.Forms.Design.RepositoryItemBorderLineWeight
		Private changeTableBorderColorItem1 As DevExpress.XtraRichEdit.UI.ChangeTableBorderColorItem
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
		Private showInsertTableCellsFormItem1 As DevExpress.XtraRichEdit.UI.ShowInsertTableCellsFormItem
		Private mergeTableCellsItem1 As DevExpress.XtraRichEdit.UI.MergeTableCellsItem
		Private showSplitTableCellsForm1 As DevExpress.XtraRichEdit.UI.ShowSplitTableCellsForm
		Private splitTableItem1 As DevExpress.XtraRichEdit.UI.SplitTableItem
		Private toggleTableAutoFitItem1 As DevExpress.XtraRichEdit.UI.ToggleTableAutoFitItem
		Private toggleTableAutoFitContentsItem1 As DevExpress.XtraRichEdit.UI.ToggleTableAutoFitContentsItem
		Private toggleTableAutoFitWindowItem1 As DevExpress.XtraRichEdit.UI.ToggleTableAutoFitWindowItem
		Private toggleTableFixedColumnWidthItem1 As DevExpress.XtraRichEdit.UI.ToggleTableFixedColumnWidthItem
		Private toggleTableCellsTopLeftAlignmentItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsTopLeftAlignmentItem
		Private toggleTableCellsTopCenterAlignmentItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsTopCenterAlignmentItem
		Private toggleTableCellsTopRightAlignmentItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsTopRightAlignmentItem
		Private toggleTableCellsMiddleLeftAlignmentItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsMiddleLeftAlignmentItem
		Private toggleTableCellsMiddleCenterAlignmentItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsMiddleCenterAlignmentItem
		Private toggleTableCellsMiddleRightAlignmentItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsMiddleRightAlignmentItem
		Private toggleTableCellsBottomLeftAlignmentItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomLeftAlignmentItem
		Private toggleTableCellsBottomCenterAlignmentItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomCenterAlignmentItem
		Private toggleTableCellsBottomRightAlignmentItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomRightAlignmentItem
		Private tableToolsRibbonPageCategory1 As DevExpress.XtraRichEdit.UI.TableToolsRibbonPageCategory
		Private tableDesignRibbonPage1 As DevExpress.XtraRichEdit.UI.TableDesignRibbonPage
		Private tableStylesRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.TableStylesRibbonPageGroup
		Private tableDrawBordersRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.TableDrawBordersRibbonPageGroup
		Private tableLayoutRibbonPage1 As DevExpress.XtraRichEdit.UI.TableLayoutRibbonPage
		Private tableTableRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.TableTableRibbonPageGroup
		Private tableRowsAndColumnsRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.TableRowsAndColumnsRibbonPageGroup
		Private tableMergeRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.TableMergeRibbonPageGroup
		Private tableCellSizeRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.TableCellSizeRibbonPageGroup
		Private tableAlignmentRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.TableAlignmentRibbonPageGroup
		Private insertPageBreakItem1 As DevExpress.XtraRichEdit.UI.InsertPageBreakItem
		Private insertTableItem1 As DevExpress.XtraRichEdit.UI.InsertTableItem
		Private insertPictureItem1 As DevExpress.XtraRichEdit.UI.InsertPictureItem
		Private insertBookmarkItem1 As DevExpress.XtraRichEdit.UI.InsertBookmarkItem
		Private insertHyperlinkItem1 As DevExpress.XtraRichEdit.UI.InsertHyperlinkItem
		Private editPageHeaderItem1 As DevExpress.XtraRichEdit.UI.EditPageHeaderItem
		Private editPageFooterItem1 As DevExpress.XtraRichEdit.UI.EditPageFooterItem
		Private insertPageNumberItem1 As DevExpress.XtraRichEdit.UI.InsertPageNumberItem
		Private insertPageCountItem1 As DevExpress.XtraRichEdit.UI.InsertPageCountItem
		Private insertSymbolItem1 As DevExpress.XtraRichEdit.UI.InsertSymbolItem
		Private insertRibbonPage1 As DevExpress.XtraRichEdit.UI.InsertRibbonPage
		Private pagesRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.PagesRibbonPageGroup
		Private tablesRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.TablesRibbonPageGroup
		Private illustrationsRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.IllustrationsRibbonPageGroup
		Private linksRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.LinksRibbonPageGroup
		Private headerFooterRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.HeaderFooterRibbonPageGroup
		Private symbolsRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.SymbolsRibbonPageGroup
	End Class
End Namespace

