<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
* [Program.cs](./CS/Program.cs) (VB: [Program.vb](./VB/Program.vb))
* [XtraReport1.cs](./CS/XtraReport1.cs) (VB: [XtraReport1.vb](./VB/XtraReport1.vb))
<!-- default file list end -->
# How to customize a Document Map at runtime


<p>This example demonstrates how to customize a report's document map at runtime. For demonstration purposes, I created a hierarchical tree of bookmarks and make some bookmarks of the first level repeated multiple times (since the control is repeatedly printed on different pages). This solution illustrates how to keep only one bookmark for this control. To do so, adjust the bookmark collection (accessed via the XtraReport.PrintingSystem.Document.BookmarkNodes property) after a report has been generated. </p>
<p> </p>
<p><strong>Note<br></strong>With version 15.1, we have added a <strong>BookmarkDuplicateSuppress</strong> property to the XtraReport, ScriptingReportBase, and PrintingDocument classes. This property defines whether to suppress duplicated bookmarks in a final document.</p>
<p>Moreover, the default value of this property is true, which means that duplicated bookmarks are always suppressed by default. To return to the old behavior, set BookmarkDuplicateSuppress to false. See <a href="https://www.devexpress.com/Support/Center/p/S18994">Bookmarks - Add the XRControl.SuppressDuplicateBookmarks property to avoid adding multiple bookmarks with the same name when a control is printed several times on different pages</a> for further information.<br><br></p>
<p>See also: <a href="https://www.devexpress.com/Support/Center/p/AK16962">How to customize a Document Map at runtime</a>.</p>

<br/>


