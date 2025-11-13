<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3331)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# Rich Text Editor for WinForms - Use Mail Merge to Create a Master-Detail Report

This example uses the Rich Text Editor control and its Mail Merge functionality to generate a product catalog report based on a master-detail template.

This project uses a two-level **Categories-Products** data source retrieved from **nwind.xml**. 

![result](./media/96c27986-26f4-4775-b794-285e373adea7.png)

## Implementation Details

Rich Text Editor supports master-detail mail merge templates. ``TableStart:Name`` and ``TableEnd:Name`` merge fields define master and nested detail regions. Region names should match group or table names in your data source. 

This example loads the template to the `RichEditControl` instance located in the **Main Template** tab.

![winforms richedit template tab](./media/richedit-template-tab.png)

This example uses the following APIs to specify the data source: 

- [RichEditControl.CreateMailMergeOptions()](https://docs.devexpress.com/OfficeFileAPI/DevExpress.XtraRichEdit.RichEditControl.CreateMailMergeOptions) method - initializes an object with mail merge settings. 
- [RichEditMailMergeOptions.DataSource](https://docs.devexpress.com/OfficeFileAPI/DevExpress.XtraRichEdit.RichEditMailMergeOptions.DataSource) - sets the data source. 
- [RichEditControl.MailMerge](https://docs.devexpress.com/OfficeFileAPI/DevExpress.XtraRichEdit.RichEditControl.MailMerge.overloads) method - accepts the settings object as a parameter. 

In this project, the [RichEditControl.MailMerge](https://docs.devexpress.com/OfficeFileAPI/DevExpress.XtraRichEdit.RichEditControl.MailMerge.overloads) method exports the result to the `RichEditControl` instance located in the **Result** tab.


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
