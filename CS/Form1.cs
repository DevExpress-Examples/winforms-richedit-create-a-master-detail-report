using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.API.Native;
using DevExpress.XtraTab;
using System;
using System.Data;
using System.Globalization;
using System.IO;

namespace RichEditMasterDetailMailMerge
{
    public partial class Form1 : RibbonForm
    {
        DataSet xmlDataSet;
        CultureInfo cultureInfo;
        private bool introductionHandled; // flag to ensure Introduction is processed only once
        private RichEditDocumentServer? introductionContent; // cached content

        public Form1()
        {
            InitializeComponent();
            cultureInfo = CultureInfo.CreateSpecificCulture("en-US");

            xtraTabPage1.Tag = mainRichEdit;
            xtraTabPage2.Tag = resultRichEdit;

            mainRichEdit.LoadDocument("Data//template.docx");

            xmlDataSet = new DataSet();
            xmlDataSet.ReadXml("nwind.xml");
            xmlDataSet.Tables["Categories"].PrimaryKey = new DataColumn[] { xmlDataSet.Tables["Categories"].Columns["CategoryID"] };
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MailMergeOptions mailMergeOptions = mainRichEdit.CreateMailMergeOptions();
            mailMergeOptions.DataSource = xmlDataSet;
            mailMergeOptions.DataMember = "Categories";
            mailMergeOptions.MergeMode = MergeMode.NewSection;
            mailMergeOptions.LastRecordIndex = 10;
            resultRichEdit.CalculateDocumentVariable += detail_CalculateDocumentVariable;
            mainRichEdit.MailMerge(mailMergeOptions, resultRichEdit.Document);


            xtraTabControl1.SelectedTabPage = xtraTabPage2;
        }

        void detail_CalculateDocumentVariable(object sender, CalculateDocumentVariableEventArgs e)
        {
            switch (e.VariableName)
            {
                case "ItemsNumber":
                    int itemCount = xmlDataSet.Tables["Products"].Select("CategoryID=" + GetID(e.Arguments[0].Value)).Length;
                    e.Value = itemCount;
                    e.Handled = true;
                    break;
                case "Picture":
                    DataRow? row = xmlDataSet.Tables["Categories"].Rows.Find(GetID(e.Arguments[0].Value));
                    byte[] imageBytes = row?["Picture"] as byte[];

                    if (imageBytes != null)
                    {
                        var imageProcessor = new RichEditDocumentServer();

                        Shape image = imageProcessor.Document.Shapes.InsertPicture(
                            imageProcessor.Document.Range.Start,
                            DocumentImageSource.FromStream(new MemoryStream(imageBytes))
                        );
                        image.TextWrapping = TextWrappingType.InLineWithText;

                        // Set the RichEditDocumentServer with prepared content as the field value.
                        e.Value = imageProcessor;
                        e.Handled = true;
                    }
                    else
                    {
                        // No image found.
                        e.Value = null;
                    }
                    break;
                case "Introduction":
                    // Only handle once. Subsequent occurrences will produce empty content.
                    if (!introductionHandled)
                    {
                        introductionContent = new RichEditDocumentServer();
                        introductionContent.Document.AppendDocumentContent("Data//template-intro.rtf");
                        e.Value = introductionContent;
                        e.Handled = true;
                        introductionHandled = true;
                    }
                    else
                    {
                        // Return empty string (or could skip handling). We handle to suppress further processing.
                        e.Value = DocVariableValue.Current;
                        e.Handled = true;
                    }
                    break;
            }

        }

        protected internal virtual int GetID(string value)
        {
            int result;
            if (Int32.TryParse(value, out result))
                return result;
            return -1;
        }

        void tabControl_SelectedPageChanged(object sender, TabPageChangedEventArgs e)
        {
            RichEditControl richEditControl = (RichEditControl)xtraTabControl1.SelectedTabPage.Tag;
            richEditBarController1.RichEditControl = richEditControl;

        }

    }
}
