<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class XtraReport1
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DetailReport1 = New DevExpress.XtraReports.UI.DetailReportBand
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel
        Me.Detail2 = New DevExpress.XtraReports.UI.DetailBand
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand
        Me.DetailReport = New DevExpress.XtraReports.UI.DetailReportBand
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel
        Me.Detail1 = New DevExpress.XtraReports.UI.DetailBand
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel
        Me.NwindDataSet1 = New AK16962.nwindDataSet
        Me.CustomersTableAdapter = New AK16962.nwindDataSetTableAdapters.CustomersTableAdapter
        Me.Order_DetailsTableAdapter1 = New AK16962.nwindDataSetTableAdapters.Order_DetailsTableAdapter
        Me.OrdersTableAdapter1 = New AK16962.nwindDataSetTableAdapters.OrdersTableAdapter
        CType(Me.NwindDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'DetailReport1
        '
        Me.DetailReport1.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail2, Me.GroupHeader1})
        Me.DetailReport1.DataAdapter = Me.Order_DetailsTableAdapter1
        Me.DetailReport1.DataMember = "Customers.CustomersOrders.OrdersOrder Details"
        Me.DetailReport1.DataSource = Me.NwindDataSet1
        Me.DetailReport1.Name = "DetailReport1"
        '
        'XrLine1
        '
        Me.XrLine1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.XrLine1.Location = New System.Drawing.Point(0, 35)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.ParentStyleUsing.UseBackColor = False
        Me.XrLine1.Size = New System.Drawing.Size(650, 25)
        '
        'XrLabel6
        '
        Me.XrLabel6.Location = New System.Drawing.Point(0, 0)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.Size = New System.Drawing.Size(66, 17)
        Me.XrLabel6.Text = "Customer:"
        '
        'XrLabel10
        '
        Me.XrLabel10.Location = New System.Drawing.Point(75, 0)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel10.Size = New System.Drawing.Size(100, 17)
        Me.XrLabel10.Text = "Order Details:"
        '
        'Detail
        '
        Me.Detail.Height = 0
        Me.Detail.Name = "Detail"
        '
        'XrLabel9
        '
        Me.XrLabel9.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Customers.CustomersOrders.OrderID", "")})
        Me.XrLabel9.Location = New System.Drawing.Point(67, 17)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.Size = New System.Drawing.Size(50, 17)
        Me.XrLabel9.Text = "XrLabel9"
        '
        'Detail2
        '
        Me.Detail2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel2, Me.XrLabel1, Me.XrLabel10})
        Me.Detail2.Height = 17
        Me.Detail2.Name = "Detail2"
        '
        'XrLabel5
        '
        Me.XrLabel5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Customers.CompanyName", ""), New DevExpress.XtraReports.UI.XRBinding("Bookmark", Nothing, "Customers.CompanyName", "")})
        Me.XrLabel5.Location = New System.Drawing.Point(67, 0)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.Size = New System.Drawing.Size(150, 17)
        Me.XrLabel5.Text = "XrLabel5"
        '
        'PageFooter
        '
        Me.PageFooter.Height = 30
        Me.PageFooter.Name = "PageFooter"
        '
        'DetailReport
        '
        Me.DetailReport.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail1, Me.DetailReport1})
        Me.DetailReport.DataAdapter = Me.OrdersTableAdapter1
        Me.DetailReport.DataMember = "Customers.CustomersOrders"
        Me.DetailReport.DataSource = Me.NwindDataSet1
        Me.DetailReport.Name = "DetailReport"
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel7, Me.XrLabel9, Me.XrLine1, Me.XrLabel5, Me.XrLabel6})
        Me.GroupHeader1.Height = 60
        Me.GroupHeader1.Name = "GroupHeader1"
        Me.GroupHeader1.PageBreak = DevExpress.XtraReports.UI.PageBreak.BeforeBand
        Me.GroupHeader1.RepeatEveryPage = True
        '
        'XrLabel7
        '
        Me.XrLabel7.Location = New System.Drawing.Point(0, 17)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.Size = New System.Drawing.Size(66, 17)
        Me.XrLabel7.Text = "Order:"
        '
        'xrLabel2
        '
        Me.xrLabel2.BookmarkParent = Me.XrLabel5
        Me.xrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Customers.CustomersOrders.OrdersOrder Details.ProductID", ""), New DevExpress.XtraReports.UI.XRBinding("Bookmark", Nothing, "Customers.CustomersOrders.OrdersOrder Details.ProductID", "")})
        Me.xrLabel2.Location = New System.Drawing.Point(183, 0)
        Me.xrLabel2.Name = "xrLabel2"
        Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel2.Size = New System.Drawing.Size(225, 17)
        Me.xrLabel2.Text = "xrLabel2"
        '
        'Detail1
        '
        Me.Detail1.Height = 0
        Me.Detail1.Name = "Detail1"
        '
        'XrLabel1
        '
        Me.XrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Customers.CustomersOrders.OrdersOrder Details.Quantity", "")})
        Me.XrLabel1.Location = New System.Drawing.Point(408, 0)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.Size = New System.Drawing.Size(167, 17)
        Me.XrLabel1.Text = "xrLabel4"
        '
        'NwindDataSet1
        '
        Me.NwindDataSet1.DataSetName = "nwindDataSet"
        Me.NwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomersTableAdapter
        '
        Me.CustomersTableAdapter.ClearBeforeFill = True
        '
        'Order_DetailsTableAdapter1
        '
        Me.Order_DetailsTableAdapter1.ClearBeforeFill = True
        '
        'OrdersTableAdapter1
        '
        Me.OrdersTableAdapter1.ClearBeforeFill = True
        '
        'XtraReport1
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageFooter, Me.DetailReport})
        Me.DataAdapter = Me.CustomersTableAdapter
        Me.DataMember = "Customers"
        Me.DataSource = Me.NwindDataSet1
        Me.PaperKind = System.Drawing.Printing.PaperKind.Custom
        CType(Me.NwindDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents DetailReport1 As DevExpress.XtraReports.UI.DetailReportBand
    Friend WithEvents Detail2 As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents xrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents DetailReport As DevExpress.XtraReports.UI.DetailReportBand
    Friend WithEvents Detail1 As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents NwindDataSet1 As AK16962.nwindDataSet
    Friend WithEvents CustomersTableAdapter As AK16962.nwindDataSetTableAdapters.CustomersTableAdapter
    Friend WithEvents Order_DetailsTableAdapter1 As AK16962.nwindDataSetTableAdapters.Order_DetailsTableAdapter
    Friend WithEvents OrdersTableAdapter1 As AK16962.nwindDataSetTableAdapters.OrdersTableAdapter
End Class
