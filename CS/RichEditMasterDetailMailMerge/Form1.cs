using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.API.Native;
using DevExpress.XtraTab;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RichEditMasterDetailMailMerge
{
    public partial class Form1 : RibbonForm
    {

        DataSet xmlDataSet;
        DataTable products;
        DataTable categories;
        CultureInfo cultureInfo;


        public Form1()
        {
            InitializeComponent();

            //Subscribe to the CalculateDocumentVariable event that triggers the master-detail report generation:
            resultRichEdit.CalculateDocumentVariable += ResultRichEdit_CalculateDocumentVariable;
            cultureInfo = CultureInfo.CreateSpecificCulture("en-US");

            //Link all RichEditControls to TabPages:
            xtraTabPage1.Tag = mainRichEdit;
            xtraTabPage2.Tag = masterRichEdit;
            xtraTabPage3.Tag = detailRichEdit;
            xtraTabPage4.Tag = resultRichEdit;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //Load main template, master and detail documents to the corresponding RichEditCotnrols:
            mainRichEdit.LoadDocument("Templates\\Template.rtf");
            masterRichEdit.LoadDocument("Templates\\Master.rtf");
            detailRichEdit.LoadDocument("Templates\\Detail.rtf");

            //Initialize and fill the dataset:
            xmlDataSet = new DataSet();
            xmlDataSet.ReadXml("nwind.xml");

            //Fill the required data tables:
            categories = xmlDataSet.Tables["Categories"];
            products = xmlDataSet.Tables["Products"];
        }

        #region #start
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //The mail merge won't start without a data source. The main template do not require using any data, 
            //so provide it with a mock data. 
            mainRichEdit.Options.MailMerge.DataSource = CreateFakeDataSource();

            //Start the mail merging process and pass the result to the resultRichEdit.
            //When the mail merge starts, the CalculateDocumentVariable raises:
            mainRichEdit.MailMerge(resultRichEdit.Document);

            xtraTabControl1.SelectedTabPage = xtraTabPage4;
        }
        #endregion #start

        #region #master
        private void ResultRichEdit_CalculateDocumentVariable(object sender, CalculateDocumentVariableEventArgs e)
        {
            //Check whether the event is raised to the required field:
            if (e.VariableName == "Categories")
            {
                //Provide the data source for the next document part:
                masterRichEdit.Options.MailMerge.DataSource = categories;

                //Create a new RichEditDocumentServer for further processing:
                IRichEditDocumentServer result = masterRichEdit.CreateDocumentServer();

                //Subscribe the new instance to the CalculateDocumentVariable event to handle the detail part: 
                result.CalculateDocumentVariable += result_CalculateDocumentVariable;

                //Set additional mail merge options if necessary:
                MailMergeOptions options = masterRichEdit.CreateMailMergeOptions();
                options.LastRecordIndex = 4;

                //Merge the document and pass it to the RichEditDocumentServer:
                masterRichEdit.MailMerge(options, result.Document);
                result.CalculateDocumentVariable -= result_CalculateDocumentVariable;

                e.Value = result;
                e.Handled = true;
            }

        }
        #endregion #master

        #region #detail
        private void result_CalculateDocumentVariable(object sender, CalculateDocumentVariableEventArgs e)
        {
            //Check whether the event is raised for the required field:
            if (e.VariableName == "Products")
            {
                //Provide the detail part with the data source:
                detailRichEdit.Options.MailMerge.DataSource = products;

                //Create an intermediate document server instance:
                IRichEditDocumentServer result = detailRichEdit.CreateDocumentServer();

                //Set the merged ranges delimitation and a number of records to be merged:
                MailMergeOptions options = detailRichEdit.CreateMailMergeOptions();
                options.MergeMode = MergeMode.JoinTables;
                options.LastRecordIndex = 10;

                //Provide a procedure for further processing:
                result.CalculateDocumentVariable += detail_CalculateDocumentVariable;

                // Create a merged document with a detail template:
                detailRichEdit.MailMerge(options, result.Document);
                result.CalculateDocumentVariable -= detail_CalculateDocumentVariable;

                e.Value = result;
                e.Handled = true;
            }         


            //Format other merged fields:
            if (e.VariableName == "LowestPrice")
            {
                e.Value = String.Format(cultureInfo, "{0:C2}", products.Compute("Min(UnitPrice)", String.Empty));
                e.Handled = true;
            }
            if (e.VariableName == "HighestPrice")
            {
                e.Value = String.Format(cultureInfo, "{0:C2}", products.Compute("Max(UnitPrice)", String.Empty));
                e.Handled = true;
            }
            if (e.VariableName == "ItemsCount")
            {
                e.Value = products.Rows.Count;
                e.Handled = true;
            }
        }
#endregion #detail

        #region #UnitPrice
        void detail_CalculateDocumentVariable(object sender, CalculateDocumentVariableEventArgs e)
        {
            int productId = GetID(e.Arguments[0].Value);
            if (productId == -1)
                return;

            //Format the UnitPrice field:
            if (e.VariableName == "UnitPrice")
            {
                string expression = String.Format("ProductID = {0}", productId);
                e.Value = String.Format(cultureInfo, "{0:C2}", products.Select(expression)[0]["UnitPrice"]);
                e.Handled = true;
            }
        }
        #endregion #UnitPrice

        #region #Help
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
        static List<int> CreateFakeDataSource()
        {
            List<int> result = new List<int>();
            result.Add(0);
            return result;
        }
        #endregion #Help
    }
}