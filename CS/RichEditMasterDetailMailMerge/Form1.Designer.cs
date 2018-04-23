namespace RichEditMasterDetailMailMerge
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.mainRichEdit = new DevExpress.XtraRichEdit.RichEditControl();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.insertMergeFieldItem1 = new DevExpress.XtraRichEdit.UI.InsertMergeFieldItem();
            this.showAllFieldCodesItem1 = new DevExpress.XtraRichEdit.UI.ShowAllFieldCodesItem();
            this.showAllFieldResultsItem1 = new DevExpress.XtraRichEdit.UI.ShowAllFieldResultsItem();
            this.toggleViewMergedDataItem1 = new DevExpress.XtraRichEdit.UI.ToggleViewMergedDataItem();
            this.insertTableItem1 = new DevExpress.XtraRichEdit.UI.InsertTableItem();
            this.insertPictureItem1 = new DevExpress.XtraRichEdit.UI.InsertPictureItem();
            this.insertFloatingPictureItem1 = new DevExpress.XtraRichEdit.UI.InsertFloatingPictureItem();
            this.insertBookmarkItem1 = new DevExpress.XtraRichEdit.UI.InsertBookmarkItem();
            this.insertHyperlinkItem1 = new DevExpress.XtraRichEdit.UI.InsertHyperlinkItem();
            this.editPageHeaderItem1 = new DevExpress.XtraRichEdit.UI.EditPageHeaderItem();
            this.editPageFooterItem1 = new DevExpress.XtraRichEdit.UI.EditPageFooterItem();
            this.insertPageNumberItem1 = new DevExpress.XtraRichEdit.UI.InsertPageNumberItem();
            this.insertPageCountItem1 = new DevExpress.XtraRichEdit.UI.InsertPageCountItem();
            this.insertTextBoxItem1 = new DevExpress.XtraRichEdit.UI.InsertTextBoxItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.mailingsRibbonPage1 = new DevExpress.XtraRichEdit.UI.MailingsRibbonPage();
            this.mailMergeRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.MailMergeRibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.insertRibbonPage1 = new DevExpress.XtraRichEdit.UI.InsertRibbonPage();
            this.tablesRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.TablesRibbonPageGroup();
            this.illustrationsRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.IllustrationsRibbonPageGroup();
            this.linksRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.LinksRibbonPageGroup();
            this.headerFooterRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.HeaderFooterRibbonPageGroup();
            this.textRibbonPageGroup1 = new DevExpress.XtraRichEdit.UI.TextRibbonPageGroup();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.masterRichEdit = new DevExpress.XtraRichEdit.RichEditControl();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.detailRichEdit = new DevExpress.XtraRichEdit.RichEditControl();
            this.xtraTabPage4 = new DevExpress.XtraTab.XtraTabPage();
            this.resultRichEdit = new DevExpress.XtraRichEdit.RichEditControl();
            this.richEditBarController1 = new DevExpress.XtraRichEdit.UI.RichEditBarController();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            this.xtraTabPage3.SuspendLayout();
            this.xtraTabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.richEditBarController1)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 146);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(685, 241);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3,
            this.xtraTabPage4});
            this.xtraTabControl1.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(this.tabControl_SelectedPageChanged);
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.mainRichEdit);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(683, 216);
            this.xtraTabPage1.Tag = "";
            this.xtraTabPage1.Text = "Main Template";
            // 
            // mainRichEdit
            // 
            this.mainRichEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainRichEdit.Location = new System.Drawing.Point(0, 0);
            this.mainRichEdit.MenuManager = this.ribbonControl1;
            this.mainRichEdit.Name = "mainRichEdit";
            this.mainRichEdit.Size = new System.Drawing.Size(683, 216);
            this.mainRichEdit.TabIndex = 4;
            this.mainRichEdit.Text = "richEditControl1";
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.insertMergeFieldItem1,
            this.showAllFieldCodesItem1,
            this.showAllFieldResultsItem1,
            this.toggleViewMergedDataItem1,
            this.insertTableItem1,
            this.insertPictureItem1,
            this.insertFloatingPictureItem1,
            this.insertBookmarkItem1,
            this.insertHyperlinkItem1,
            this.editPageHeaderItem1,
            this.editPageFooterItem1,
            this.insertPageNumberItem1,
            this.insertPageCountItem1,
            this.insertTextBoxItem1,
            this.barButtonItem1});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 73;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.mailingsRibbonPage1,
            this.insertRibbonPage1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl1.Size = new System.Drawing.Size(685, 146);
            // 
            // insertMergeFieldItem1
            // 
            this.insertMergeFieldItem1.Id = 1;
            this.insertMergeFieldItem1.Name = "insertMergeFieldItem1";
            // 
            // showAllFieldCodesItem1
            // 
            this.showAllFieldCodesItem1.Id = 2;
            this.showAllFieldCodesItem1.Name = "showAllFieldCodesItem1";
            // 
            // showAllFieldResultsItem1
            // 
            this.showAllFieldResultsItem1.Id = 3;
            this.showAllFieldResultsItem1.Name = "showAllFieldResultsItem1";
            // 
            // toggleViewMergedDataItem1
            // 
            this.toggleViewMergedDataItem1.Id = 4;
            this.toggleViewMergedDataItem1.Name = "toggleViewMergedDataItem1";
            // 
            // insertTableItem1
            // 
            this.insertTableItem1.Id = 6;
            this.insertTableItem1.Name = "insertTableItem1";
            // 
            // insertPictureItem1
            // 
            this.insertPictureItem1.Id = 7;
            this.insertPictureItem1.Name = "insertPictureItem1";
            // 
            // insertFloatingPictureItem1
            // 
            this.insertFloatingPictureItem1.Id = 8;
            this.insertFloatingPictureItem1.Name = "insertFloatingPictureItem1";
            // 
            // insertBookmarkItem1
            // 
            this.insertBookmarkItem1.Id = 9;
            this.insertBookmarkItem1.Name = "insertBookmarkItem1";
            // 
            // insertHyperlinkItem1
            // 
            this.insertHyperlinkItem1.Id = 10;
            this.insertHyperlinkItem1.Name = "insertHyperlinkItem1";
            // 
            // editPageHeaderItem1
            // 
            this.editPageHeaderItem1.Id = 11;
            this.editPageHeaderItem1.Name = "editPageHeaderItem1";
            // 
            // editPageFooterItem1
            // 
            this.editPageFooterItem1.Id = 12;
            this.editPageFooterItem1.Name = "editPageFooterItem1";
            // 
            // insertPageNumberItem1
            // 
            this.insertPageNumberItem1.Id = 13;
            this.insertPageNumberItem1.Name = "insertPageNumberItem1";
            // 
            // insertPageCountItem1
            // 
            this.insertPageCountItem1.Id = 14;
            this.insertPageCountItem1.Name = "insertPageCountItem1";
            // 
            // insertTextBoxItem1
            // 
            this.insertTextBoxItem1.Id = 15;
            this.insertTextBoxItem1.Name = "insertTextBoxItem1";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Generate Report";
            this.barButtonItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.Glyph")));
            this.barButtonItem1.Id = 72;
            this.barButtonItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.LargeGlyph")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // mailingsRibbonPage1
            // 
            this.mailingsRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.mailMergeRibbonPageGroup1,
            this.ribbonPageGroup1});
            this.mailingsRibbonPage1.Name = "mailingsRibbonPage1";
            // 
            // mailMergeRibbonPageGroup1
            // 
            this.mailMergeRibbonPageGroup1.ItemLinks.Add(this.insertMergeFieldItem1);
            this.mailMergeRibbonPageGroup1.ItemLinks.Add(this.showAllFieldCodesItem1);
            this.mailMergeRibbonPageGroup1.ItemLinks.Add(this.showAllFieldResultsItem1);
            this.mailMergeRibbonPageGroup1.ItemLinks.Add(this.toggleViewMergedDataItem1, "P");
            this.mailMergeRibbonPageGroup1.Name = "mailMergeRibbonPageGroup1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Actions";
            // 
            // insertRibbonPage1
            // 
            this.insertRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.tablesRibbonPageGroup1,
            this.illustrationsRibbonPageGroup1,
            this.linksRibbonPageGroup1,
            this.headerFooterRibbonPageGroup1,
            this.textRibbonPageGroup1});
            this.insertRibbonPage1.Name = "insertRibbonPage1";
            // 
            // tablesRibbonPageGroup1
            // 
            this.tablesRibbonPageGroup1.AllowTextClipping = false;
            this.tablesRibbonPageGroup1.ItemLinks.Add(this.insertTableItem1, "T");
            this.tablesRibbonPageGroup1.Name = "tablesRibbonPageGroup1";
            // 
            // illustrationsRibbonPageGroup1
            // 
            this.illustrationsRibbonPageGroup1.ItemLinks.Add(this.insertPictureItem1, "P");
            this.illustrationsRibbonPageGroup1.ItemLinks.Add(this.insertFloatingPictureItem1);
            this.illustrationsRibbonPageGroup1.Name = "illustrationsRibbonPageGroup1";
            // 
            // linksRibbonPageGroup1
            // 
            this.linksRibbonPageGroup1.ItemLinks.Add(this.insertBookmarkItem1, "K");
            this.linksRibbonPageGroup1.ItemLinks.Add(this.insertHyperlinkItem1, "I");
            this.linksRibbonPageGroup1.Name = "linksRibbonPageGroup1";
            // 
            // headerFooterRibbonPageGroup1
            // 
            this.headerFooterRibbonPageGroup1.ItemLinks.Add(this.editPageHeaderItem1, "H");
            this.headerFooterRibbonPageGroup1.ItemLinks.Add(this.editPageFooterItem1, "O");
            this.headerFooterRibbonPageGroup1.ItemLinks.Add(this.insertPageNumberItem1, "NU");
            this.headerFooterRibbonPageGroup1.ItemLinks.Add(this.insertPageCountItem1);
            this.headerFooterRibbonPageGroup1.Name = "headerFooterRibbonPageGroup1";
            // 
            // textRibbonPageGroup1
            // 
            this.textRibbonPageGroup1.Glyph = ((System.Drawing.Image)(resources.GetObject("textRibbonPageGroup1.Glyph")));
            this.textRibbonPageGroup1.ItemLinks.Add(this.insertTextBoxItem1, "X");
            this.textRibbonPageGroup1.Name = "textRibbonPageGroup1";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.masterRichEdit);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(683, 216);
            this.xtraTabPage2.Tag = "";
            this.xtraTabPage2.Text = "Master (Categories)";
            // 
            // masterRichEdit
            // 
            this.masterRichEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.masterRichEdit.Location = new System.Drawing.Point(0, 0);
            this.masterRichEdit.MenuManager = this.ribbonControl1;
            this.masterRichEdit.Name = "masterRichEdit";
            this.masterRichEdit.Size = new System.Drawing.Size(683, 216);
            this.masterRichEdit.TabIndex = 5;
            this.masterRichEdit.Text = "richEditControl2";
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.detailRichEdit);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(683, 216);
            this.xtraTabPage3.Tag = "";
            this.xtraTabPage3.Text = "Detail (Products)";
            // 
            // detailRichEdit
            // 
            this.detailRichEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailRichEdit.Location = new System.Drawing.Point(0, 0);
            this.detailRichEdit.MenuManager = this.ribbonControl1;
            this.detailRichEdit.Name = "detailRichEdit";
            this.detailRichEdit.Size = new System.Drawing.Size(683, 216);
            this.detailRichEdit.TabIndex = 5;
            this.detailRichEdit.Text = "richEditControl3";
            // 
            // xtraTabPage4
            // 
            this.xtraTabPage4.Controls.Add(this.resultRichEdit);
            this.xtraTabPage4.Name = "xtraTabPage4";
            this.xtraTabPage4.Size = new System.Drawing.Size(683, 216);
            this.xtraTabPage4.Tag = "";
            this.xtraTabPage4.Text = "Result";
            // 
            // resultRichEdit
            // 
            this.resultRichEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultRichEdit.Location = new System.Drawing.Point(0, 0);
            this.resultRichEdit.MenuManager = this.ribbonControl1;
            this.resultRichEdit.Name = "resultRichEdit";
            this.resultRichEdit.Size = new System.Drawing.Size(683, 216);
            this.resultRichEdit.TabIndex = 5;
            this.resultRichEdit.Text = "richEditControl4";
            // 
            // richEditBarController1
            // 
            this.richEditBarController1.BarItems.Add(this.insertMergeFieldItem1);
            this.richEditBarController1.BarItems.Add(this.showAllFieldCodesItem1);
            this.richEditBarController1.BarItems.Add(this.showAllFieldResultsItem1);
            this.richEditBarController1.BarItems.Add(this.toggleViewMergedDataItem1);
            this.richEditBarController1.BarItems.Add(this.insertTableItem1);
            this.richEditBarController1.BarItems.Add(this.insertPictureItem1);
            this.richEditBarController1.BarItems.Add(this.insertFloatingPictureItem1);
            this.richEditBarController1.BarItems.Add(this.insertBookmarkItem1);
            this.richEditBarController1.BarItems.Add(this.insertHyperlinkItem1);
            this.richEditBarController1.BarItems.Add(this.editPageHeaderItem1);
            this.richEditBarController1.BarItems.Add(this.editPageFooterItem1);
            this.richEditBarController1.BarItems.Add(this.insertPageNumberItem1);
            this.richEditBarController1.BarItems.Add(this.insertPageCountItem1);
            this.richEditBarController1.BarItems.Add(this.insertTextBoxItem1);
            this.richEditBarController1.Control = this.mainRichEdit;
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 387);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "Form1";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Master-Detail Mail Merge Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage3.ResumeLayout(false);
            this.xtraTabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.richEditBarController1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage4;
        private DevExpress.XtraRichEdit.RichEditControl mainRichEdit;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraRichEdit.UI.InsertMergeFieldItem insertMergeFieldItem1;
        private DevExpress.XtraRichEdit.UI.ShowAllFieldCodesItem showAllFieldCodesItem1;
        private DevExpress.XtraRichEdit.UI.ShowAllFieldResultsItem showAllFieldResultsItem1;
        private DevExpress.XtraRichEdit.UI.ToggleViewMergedDataItem toggleViewMergedDataItem1;       
        private DevExpress.XtraRichEdit.UI.InsertTableItem insertTableItem1;
        private DevExpress.XtraRichEdit.UI.InsertPictureItem insertPictureItem1;
        private DevExpress.XtraRichEdit.UI.InsertFloatingPictureItem insertFloatingPictureItem1;
        private DevExpress.XtraRichEdit.UI.InsertBookmarkItem insertBookmarkItem1;
        private DevExpress.XtraRichEdit.UI.InsertHyperlinkItem insertHyperlinkItem1;
        private DevExpress.XtraRichEdit.UI.EditPageHeaderItem editPageHeaderItem1;
        private DevExpress.XtraRichEdit.UI.EditPageFooterItem editPageFooterItem1;
        private DevExpress.XtraRichEdit.UI.InsertPageNumberItem insertPageNumberItem1;
        private DevExpress.XtraRichEdit.UI.InsertPageCountItem insertPageCountItem1;
        private DevExpress.XtraRichEdit.UI.InsertTextBoxItem insertTextBoxItem1;
        private DevExpress.XtraRichEdit.UI.MailingsRibbonPage mailingsRibbonPage1;
        private DevExpress.XtraRichEdit.UI.MailMergeRibbonPageGroup mailMergeRibbonPageGroup1;
        private DevExpress.XtraRichEdit.UI.InsertRibbonPage insertRibbonPage1;
               private DevExpress.XtraRichEdit.UI.TablesRibbonPageGroup tablesRibbonPageGroup1;
        private DevExpress.XtraRichEdit.UI.IllustrationsRibbonPageGroup illustrationsRibbonPageGroup1;
        private DevExpress.XtraRichEdit.UI.LinksRibbonPageGroup linksRibbonPageGroup1;
        private DevExpress.XtraRichEdit.UI.HeaderFooterRibbonPageGroup headerFooterRibbonPageGroup1;
        private DevExpress.XtraRichEdit.UI.TextRibbonPageGroup textRibbonPageGroup1;
        private DevExpress.XtraRichEdit.RichEditControl masterRichEdit;
        private DevExpress.XtraRichEdit.RichEditControl detailRichEdit;
        private DevExpress.XtraRichEdit.RichEditControl resultRichEdit;
        private DevExpress.XtraRichEdit.UI.RichEditBarController richEditBarController1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
    }
}

