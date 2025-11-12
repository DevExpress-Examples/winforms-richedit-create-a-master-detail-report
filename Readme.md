<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3331)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# Rich Text Editor for WinForms - Create a Master-Detail Report

This example demonstrates the use of the Rich Text Editor's Mail Merge functionality to generate invoices from master-detail templates.

This project uses a two-level **Categories-Products** hierarchical data source, retrieved from the **nwind.xml** file. 

![result](./media/96c27986-26f4-4775-b794-285e373adea7.png)

## Implementation Details

Rich Text Editor allows you to perform a mail merge with master-detail templates. The ``TableStart:Name`` and ``TableEnd:Name`` merge fields define master and detail regions. The region name should match the group or table name in your data source. 

This example loads the template to the `RichEditControl` instance located in the **Main Template** tab.

![winforms richedit template tab](./media/richedit-template-tab.png)

Call the [RichEditControl.CreateMailMergeOptions()](https://docs.devexpress.com/OfficeFileAPI/DevExpress.XtraRichEdit.RichEditControl.CreateMailMergeOptions) method to create a new [MailMergeOptions](https://docs.devexpress.com/OfficeFileAPI/DevExpress.XtraRichEdit.API.Native.MailMergeOptions) object. This object contains mail merge options. Specify the object's [DataSource](https://docs.devexpress.com/OfficeFileAPI/DevExpress.XtraRichEdit.RichEditMailMergeOptions.DataSource) property to set the mail merge database.
 
Pass the `MailMergeOptions` object as the [RichEditControl.MailMerge](https://docs.devexpress.com/OfficeFileAPI/DevExpress.XtraRichEdit.RichEditControl.MailMerge.overloads) method parameter to apply specified options. 

In this project, the [RichEditControl.MailMerge](https://docs.devexpress.com/OfficeFileAPI/DevExpress.XtraRichEdit.RichEditControl.MailMerge.overloads) exports the result to the `RichEditControl` instance located in the **Result** tab.

![winforms richedit template tab](./media/richedit-result-tab.png)

## Files to Review

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))

## Documentation

* [Mail Merge in Rich Text Documents](https://docs.devexpress.com/WindowsForms/9330/controls-and-libraries/rich-text-editor/mail-merge)


<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-richedit-create-a-master-detail-report&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-richedit-create-a-master-detail-report&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
