namespace AK16962 {
    partial class XtraReport1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.XrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.XrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.XrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.Detail2 = new DevExpress.XtraReports.UI.DetailBand();
            this.XrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.XrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
            this.Detail1 = new DevExpress.XtraReports.UI.DetailBand();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.DetailReport1 = new DevExpress.XtraReports.UI.DetailReportBand();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.XrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.XrLine1 = new DevExpress.XtraReports.UI.XRLine();
            this.order_DetailsTableAdapter1 = new AK16962.nwindDataSetTableAdapters.Order_DetailsTableAdapter();
            this.nwindDataSet1 = new AK16962.nwindDataSet();
            this.DetailReport = new DevExpress.XtraReports.UI.DetailReportBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.customersTableAdapter1 = new AK16962.nwindDataSetTableAdapters.CustomersTableAdapter();
            this.ordersTableAdapter1 = new AK16962.nwindDataSetTableAdapters.OrdersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // XrLabel9
            // 
            this.XrLabel9.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Customers.CustomersOrders.OrderID", "")});
            this.XrLabel9.Location = new System.Drawing.Point(67, 17);
            this.XrLabel9.Name = "XrLabel9";
            this.XrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.XrLabel9.Size = new System.Drawing.Size(50, 17);
            this.XrLabel9.Text = "XrLabel9";
            // 
            // XrLabel5
            // 
            this.XrLabel5.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Customers.CompanyName", ""),
            new DevExpress.XtraReports.UI.XRBinding("Bookmark", null, "Customers.CompanyName", "")});
            this.XrLabel5.Location = new System.Drawing.Point(67, 0);
            this.XrLabel5.Name = "XrLabel5";
            this.XrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.XrLabel5.Size = new System.Drawing.Size(150, 17);
            this.XrLabel5.Text = "XrLabel5";
            // 
            // xrLabel2
            // 
            this.xrLabel2.BookmarkParent = this.XrLabel5;
            this.xrLabel2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Customers.CustomersOrders.OrdersOrder Details.ProductID", ""),
            new DevExpress.XtraReports.UI.XRBinding("Bookmark", null, "Customers.CustomersOrders.OrdersOrder Details.ProductID", "")});
            this.xrLabel2.Location = new System.Drawing.Point(183, 0);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.Size = new System.Drawing.Size(225, 17);
            this.xrLabel2.Text = "xrLabel2";
            // 
            // XrLabel6
            // 
            this.XrLabel6.Location = new System.Drawing.Point(0, 0);
            this.XrLabel6.Name = "XrLabel6";
            this.XrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.XrLabel6.Size = new System.Drawing.Size(66, 17);
            this.XrLabel6.Text = "Customer:";
            // 
            // Detail2
            // 
            this.Detail2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel2,
            this.XrLabel1,
            this.XrLabel10});
            this.Detail2.Height = 17;
            this.Detail2.Name = "Detail2";
            // 
            // XrLabel1
            // 
            this.XrLabel1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Customers.CustomersOrders.OrdersOrder Details.Quantity", "")});
            this.XrLabel1.Location = new System.Drawing.Point(408, 0);
            this.XrLabel1.Name = "XrLabel1";
            this.XrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.XrLabel1.Size = new System.Drawing.Size(167, 17);
            this.XrLabel1.Text = "xrLabel4";
            // 
            // XrLabel10
            // 
            this.XrLabel10.Location = new System.Drawing.Point(75, 0);
            this.XrLabel10.Name = "XrLabel10";
            this.XrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.XrLabel10.Size = new System.Drawing.Size(100, 17);
            this.XrLabel10.Text = "Order Details:";
            // 
            // Detail1
            // 
            this.Detail1.Height = 0;
            this.Detail1.Name = "Detail1";
            // 
            // PageFooter
            // 
            this.PageFooter.Height = 30;
            this.PageFooter.Name = "PageFooter";
            // 
            // DetailReport1
            // 
            this.DetailReport1.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail2,
            this.GroupHeader1});
            this.DetailReport1.DataAdapter = this.order_DetailsTableAdapter1;
            this.DetailReport1.DataMember = "Customers.CustomersOrders.OrdersOrder Details";
            this.DetailReport1.DataSource = this.nwindDataSet1;
            this.DetailReport1.Name = "DetailReport1";
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.XrLabel7,
            this.XrLabel9,
            this.XrLine1,
            this.XrLabel5,
            this.XrLabel6});
            this.GroupHeader1.Height = 60;
            this.GroupHeader1.Name = "GroupHeader1";
            this.GroupHeader1.PageBreak = DevExpress.XtraReports.UI.PageBreak.BeforeBand;
            this.GroupHeader1.RepeatEveryPage = true;
            // 
            // XrLabel7
            // 
            this.XrLabel7.Location = new System.Drawing.Point(0, 17);
            this.XrLabel7.Name = "XrLabel7";
            this.XrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.XrLabel7.Size = new System.Drawing.Size(66, 17);
            this.XrLabel7.Text = "Order:";
            // 
            // XrLine1
            // 
            this.XrLine1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.XrLine1.Location = new System.Drawing.Point(0, 35);
            this.XrLine1.Name = "XrLine1";
            this.XrLine1.ParentStyleUsing.UseBackColor = false;
            this.XrLine1.Size = new System.Drawing.Size(650, 25);
            // 
            // order_DetailsTableAdapter1
            // 
            this.order_DetailsTableAdapter1.ClearBeforeFill = true;
            // 
            // nwindDataSet1
            // 
            this.nwindDataSet1.DataSetName = "nwindDataSet";
            this.nwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DetailReport
            // 
            this.DetailReport.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail1,
            this.DetailReport1});
            this.DetailReport.DataAdapter = this.ordersTableAdapter1;
            this.DetailReport.DataMember = "Customers.CustomersOrders";
            this.DetailReport.DataSource = this.nwindDataSet1;
            this.DetailReport.Name = "DetailReport";
            // 
            // Detail
            // 
            this.Detail.Height = 0;
            this.Detail.Name = "Detail";
            // 
            // customersTableAdapter1
            // 
            this.customersTableAdapter1.ClearBeforeFill = true;
            // 
            // ordersTableAdapter1
            // 
            this.ordersTableAdapter1.ClearBeforeFill = true;
            // 
            // XtraReport1
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.PageFooter,
            this.DetailReport});
            this.DataAdapter = this.customersTableAdapter1;
            this.DataMember = "Customers";
            this.DataSource = this.nwindDataSet1;
            this.PaperKind = System.Drawing.Printing.PaperKind.Custom;
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.XRLabel XrLabel9;
        private DevExpress.XtraReports.UI.XRLabel XrLabel5;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel XrLabel6;
        private DevExpress.XtraReports.UI.DetailBand Detail2;
        private DevExpress.XtraReports.UI.XRLabel XrLabel1;
        private DevExpress.XtraReports.UI.XRLabel XrLabel10;
        private DevExpress.XtraReports.UI.DetailBand Detail1;
        private DevExpress.XtraReports.UI.PageFooterBand PageFooter;
        private DevExpress.XtraReports.UI.DetailReportBand DetailReport1;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
        private DevExpress.XtraReports.UI.XRLabel XrLabel7;
        private DevExpress.XtraReports.UI.XRLine XrLine1;
        private DevExpress.XtraReports.UI.DetailReportBand DetailReport;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private nwindDataSet nwindDataSet1;
        private AK16962.nwindDataSetTableAdapters.Order_DetailsTableAdapter order_DetailsTableAdapter1;
        private AK16962.nwindDataSetTableAdapters.CustomersTableAdapter customersTableAdapter1;
        private AK16962.nwindDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter1;

    }
}
