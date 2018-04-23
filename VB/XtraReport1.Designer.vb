Imports Microsoft.VisualBasic
Imports System
Namespace AK16962
	Partial Public Class XtraReport1
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

		#Region "Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
			Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
			Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
			Me.Detail2 = New DevExpress.XtraReports.UI.DetailBand()
			Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
			Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
			Me.Detail1 = New DevExpress.XtraReports.UI.DetailBand()
			Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
			Me.DetailReport1 = New DevExpress.XtraReports.UI.DetailReportBand()
			Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
			Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
			Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
			Me.order_DetailsTableAdapter1 = New AK16962.nwindDataSetTableAdapters.Order_DetailsTableAdapter()
			Me.nwindDataSet1 = New AK16962.nwindDataSet()
			Me.DetailReport = New DevExpress.XtraReports.UI.DetailReportBand()
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.customersTableAdapter1 = New AK16962.nwindDataSetTableAdapters.CustomersTableAdapter()
			Me.ordersTableAdapter1 = New AK16962.nwindDataSetTableAdapters.OrdersTableAdapter()
			CType(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' XrLabel9
			' 
			Me.XrLabel9.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Customers.CustomersOrders.OrderID", "")})
			Me.XrLabel9.Location = New System.Drawing.Point(67, 17)
			Me.XrLabel9.Name = "XrLabel9"
			Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.XrLabel9.Size = New System.Drawing.Size(50, 17)
			Me.XrLabel9.Text = "XrLabel9"
			' 
			' XrLabel5
			' 
			Me.XrLabel5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Customers.CompanyName", ""), New DevExpress.XtraReports.UI.XRBinding("Bookmark", Nothing, "Customers.CompanyName", "")})
			Me.XrLabel5.Location = New System.Drawing.Point(67, 0)
			Me.XrLabel5.Name = "XrLabel5"
			Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.XrLabel5.Size = New System.Drawing.Size(150, 17)
			Me.XrLabel5.Text = "XrLabel5"
			' 
			' xrLabel2
			' 
			Me.xrLabel2.BookmarkParent = Me.XrLabel5
			Me.xrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Customers.CustomersOrders.OrdersOrder Details.ProductID", ""), New DevExpress.XtraReports.UI.XRBinding("Bookmark", Nothing, "Customers.CustomersOrders.OrdersOrder Details.ProductID", "")})
			Me.xrLabel2.Location = New System.Drawing.Point(183, 0)
			Me.xrLabel2.Name = "xrLabel2"
			Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel2.Size = New System.Drawing.Size(225, 17)
			Me.xrLabel2.Text = "xrLabel2"
			' 
			' XrLabel6
			' 
			Me.XrLabel6.Location = New System.Drawing.Point(0, 0)
			Me.XrLabel6.Name = "XrLabel6"
			Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.XrLabel6.Size = New System.Drawing.Size(66, 17)
			Me.XrLabel6.Text = "Customer:"
			' 
			' Detail2
			' 
			Me.Detail2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel2, Me.XrLabel1, Me.XrLabel10})
			Me.Detail2.Height = 17
			Me.Detail2.Name = "Detail2"
			' 
			' XrLabel1
			' 
			Me.XrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Customers.CustomersOrders.OrdersOrder Details.Quantity", "")})
			Me.XrLabel1.Location = New System.Drawing.Point(408, 0)
			Me.XrLabel1.Name = "XrLabel1"
			Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.XrLabel1.Size = New System.Drawing.Size(167, 17)
			Me.XrLabel1.Text = "xrLabel4"
			' 
			' XrLabel10
			' 
			Me.XrLabel10.Location = New System.Drawing.Point(75, 0)
			Me.XrLabel10.Name = "XrLabel10"
			Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.XrLabel10.Size = New System.Drawing.Size(100, 17)
			Me.XrLabel10.Text = "Order Details:"
			' 
			' Detail1
			' 
			Me.Detail1.Height = 0
			Me.Detail1.Name = "Detail1"
			' 
			' PageFooter
			' 
			Me.PageFooter.Height = 30
			Me.PageFooter.Name = "PageFooter"
			' 
			' DetailReport1
			' 
			Me.DetailReport1.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail2, Me.GroupHeader1})
			Me.DetailReport1.DataAdapter = Me.order_DetailsTableAdapter1
			Me.DetailReport1.DataMember = "Customers.CustomersOrders.OrdersOrder Details"
			Me.DetailReport1.DataSource = Me.nwindDataSet1
			Me.DetailReport1.Name = "DetailReport1"
			' 
			' GroupHeader1
			' 
			Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.XrLabel7, Me.XrLabel9, Me.XrLine1, Me.XrLabel5, Me.XrLabel6})
			Me.GroupHeader1.Height = 60
			Me.GroupHeader1.Name = "GroupHeader1"
			Me.GroupHeader1.PageBreak = DevExpress.XtraReports.UI.PageBreak.BeforeBand
			Me.GroupHeader1.RepeatEveryPage = True
			' 
			' XrLabel7
			' 
			Me.XrLabel7.Location = New System.Drawing.Point(0, 17)
			Me.XrLabel7.Name = "XrLabel7"
			Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.XrLabel7.Size = New System.Drawing.Size(66, 17)
			Me.XrLabel7.Text = "Order:"
			' 
			' XrLine1
			' 
			Me.XrLine1.BackColor = System.Drawing.Color.LightSkyBlue
			Me.XrLine1.Location = New System.Drawing.Point(0, 35)
			Me.XrLine1.Name = "XrLine1"
			Me.XrLine1.ParentStyleUsing.UseBackColor = False
			Me.XrLine1.Size = New System.Drawing.Size(650, 25)
			' 
			' order_DetailsTableAdapter1
			' 
			Me.order_DetailsTableAdapter1.ClearBeforeFill = True
			' 
			' nwindDataSet1
			' 
			Me.nwindDataSet1.DataSetName = "nwindDataSet"
			Me.nwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' DetailReport
			' 
			Me.DetailReport.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail1, Me.DetailReport1})
			Me.DetailReport.DataAdapter = Me.ordersTableAdapter1
			Me.DetailReport.DataMember = "Customers.CustomersOrders"
			Me.DetailReport.DataSource = Me.nwindDataSet1
			Me.DetailReport.Name = "DetailReport"
			' 
			' Detail
			' 
			Me.Detail.Height = 0
			Me.Detail.Name = "Detail"
			' 
			' customersTableAdapter1
			' 
			Me.customersTableAdapter1.ClearBeforeFill = True
			' 
			' ordersTableAdapter1
			' 
			Me.ordersTableAdapter1.ClearBeforeFill = True
			' 
			' XtraReport1
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.PageFooter, Me.DetailReport})
			Me.DataAdapter = Me.customersTableAdapter1
			Me.DataMember = "Customers"
			Me.DataSource = Me.nwindDataSet1
			Me.PaperKind = System.Drawing.Printing.PaperKind.Custom
			CType(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private XrLabel9 As DevExpress.XtraReports.UI.XRLabel
		Private XrLabel5 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel2 As DevExpress.XtraReports.UI.XRLabel
		Private XrLabel6 As DevExpress.XtraReports.UI.XRLabel
		Private Detail2 As DevExpress.XtraReports.UI.DetailBand
		Private XrLabel1 As DevExpress.XtraReports.UI.XRLabel
		Private XrLabel10 As DevExpress.XtraReports.UI.XRLabel
		Private Detail1 As DevExpress.XtraReports.UI.DetailBand
		Private PageFooter As DevExpress.XtraReports.UI.PageFooterBand
		Private DetailReport1 As DevExpress.XtraReports.UI.DetailReportBand
		Private GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
		Private XrLabel7 As DevExpress.XtraReports.UI.XRLabel
		Private XrLine1 As DevExpress.XtraReports.UI.XRLine
		Private DetailReport As DevExpress.XtraReports.UI.DetailReportBand
		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private nwindDataSet1 As nwindDataSet
		Private order_DetailsTableAdapter1 As AK16962.nwindDataSetTableAdapters.Order_DetailsTableAdapter
		Private customersTableAdapter1 As AK16962.nwindDataSetTableAdapters.CustomersTableAdapter
		Private ordersTableAdapter1 As AK16962.nwindDataSetTableAdapters.OrdersTableAdapter

	End Class
End Namespace
