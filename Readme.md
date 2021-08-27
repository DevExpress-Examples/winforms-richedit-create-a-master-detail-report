<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128609647/13.1.6%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3331)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/RichEditMasterDetailMailMerge/Form1.cs) (VB: [Form1.vb](./VB/RichEditMasterDetailMailMerge/Form1.vb))
* [Program.cs](./CS/RichEditMasterDetailMailMerge/Program.cs) (VB: [Program.vb](./VB/RichEditMasterDetailMailMerge/Program.vb))
<!-- default file list end -->
# How to create a master-detail report in a RichEditControl


<p>This example illustrates an older approach to create master-detail documents with the RichEditDocumentServer, by using the DOCVARIABLE field.</p>
<p>To learn about a newer and more convenient approach to <a href="https://documentation.devexpress.com/#WindowsForms/CustomDocument16044"><u>master-detail mail merge</u></a>, refer to <a href="https://www.devexpress.com/Support/Center/CodeCentral/ViewExample.aspx?exampleId=E1680"><u>How to automatically create mail-merge documents using the Snap Document Server</u></a>.</p>
<p>This project uses a two-level <strong>Categories-Products</strong> hierarchical data source, represented by the DevExpress sample <strong>nwind.xml</strong> file. The resulting document is shown below: <br><img src="https://raw.githubusercontent.com/DevExpress-Examples/how-to-create-a-master-detail-report-in-a-richeditcontrol-e3331/13.1.6+/media/96c27986-26f4-4775-b794-285e373adea7.png"><br><br></p>


<h3>Description</h3>

Starting from the build v2013 vol 1.6, the example uses the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraRichEditRichEditControl_CreateDocumentServertopic"><u>RichEditControl.CreateDocumentServer</u></a> method to create a RichEditDocumentServer.

<br/>


