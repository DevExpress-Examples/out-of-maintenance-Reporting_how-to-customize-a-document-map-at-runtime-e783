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
			Me.components = New System.ComponentModel.Container()
			Dim selectQuery1 As New DevExpress.DataAccess.Sql.SelectQuery()
			Dim column1 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression1 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim table1 As New DevExpress.DataAccess.Sql.Table()
			Dim column2 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression2 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column3 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression3 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column4 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression4 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column5 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression5 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column6 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression6 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim table2 As New DevExpress.DataAccess.Sql.Table()
			Dim column7 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression7 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim table3 As New DevExpress.DataAccess.Sql.Table()
			Dim join1 As New DevExpress.DataAccess.Sql.Join()
			Dim relationColumnInfo1 As New DevExpress.DataAccess.Sql.RelationColumnInfo()
			Dim join2 As New DevExpress.DataAccess.Sql.Join()
			Dim relationColumnInfo2 As New DevExpress.DataAccess.Sql.RelationColumnInfo()
			Dim masterDetailInfo1 As New DevExpress.DataAccess.Sql.MasterDetailInfo()
			Dim relationColumnInfo3 As New DevExpress.DataAccess.Sql.RelationColumnInfo()
			Dim masterDetailInfo2 As New DevExpress.DataAccess.Sql.MasterDetailInfo()
			Dim relationColumnInfo4 As New DevExpress.DataAccess.Sql.RelationColumnInfo()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(XtraReport1))
			Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.xrTable2 = New DevExpress.XtraReports.UI.XRTable()
			Me.xrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
			Me.xrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.topMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
			Me.bottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
			Me.sqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
			Me.GroupHeader2 = New DevExpress.XtraReports.UI.GroupHeaderBand()
			Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
			Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
			Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
			Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
			Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
			Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
			Me.xrTable1 = New DevExpress.XtraReports.UI.XRTable()
			Me.xrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
			Me.xrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
			CType(Me.xrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.xrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' PageFooter
			' 
			Me.PageFooter.HeightF = 30F
			Me.PageFooter.Name = "PageFooter"
			Me.PageFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrTable2})
			Me.Detail.HeightF = 25F
			Me.Detail.Name = "Detail"
			Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrTable2
			' 
			Me.xrTable2.LocationFloat = New DevExpress.Utils.PointFloat(102.0833F, 0F)
			Me.xrTable2.Name = "xrTable2"
			Me.xrTable2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow2})
			Me.xrTable2.SizeF = New System.Drawing.SizeF(547.9167F, 25F)
			' 
			' xrTableRow2
			' 
			Me.xrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell4, Me.xrTableCell5, Me.xrTableCell6})
			Me.xrTableRow2.Name = "xrTableRow2"
			Me.xrTableRow2.Weight = 11.5R
			' 
			' xrTableCell4
			' 
			Me.xrTableCell4.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[OrderID]")})
			Me.xrTableCell4.Multiline = True
			Me.xrTableCell4.Name = "xrTableCell4"
			Me.xrTableCell4.Text = "xrTableCell4"
			Me.xrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
			Me.xrTableCell4.Weight = 0.2857142857142857R
			' 
			' xrTableCell5
			' 
			Me.xrTableCell5.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Quantity]")})
			Me.xrTableCell5.Multiline = True
			Me.xrTableCell5.Name = "xrTableCell5"
			Me.xrTableCell5.Text = "xrTableCell5"
			Me.xrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
			Me.xrTableCell5.Weight = 0.2857142857142857R
			' 
			' xrTableCell6
			' 
			Me.xrTableCell6.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[UnitPrice]")})
			Me.xrTableCell6.Multiline = True
			Me.xrTableCell6.Name = "xrTableCell6"
			Me.xrTableCell6.Text = "xrTableCell6"
			Me.xrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
			Me.xrTableCell6.Weight = 0.2857142857142857R
			' 
			' topMarginBand1
			' 
			Me.topMarginBand1.Name = "topMarginBand1"
			' 
			' bottomMarginBand1
			' 
			Me.bottomMarginBand1.Name = "bottomMarginBand1"
			' 
			' sqlDataSource1
			' 
			Me.sqlDataSource1.ConnectionName = "nwind.mdb"
			Me.sqlDataSource1.Name = "sqlDataSource1"
			columnExpression1.ColumnName = "OrderID"
			table1.MetaSerializable = "<Meta X=""30"" Y=""30"" Width=""125"" Height=""153"" />"
			table1.Name = "Order Details"
			columnExpression1.Table = table1
			column1.Expression = columnExpression1
			columnExpression2.ColumnName = "ProductID"
			columnExpression2.Table = table1
			column2.Expression = columnExpression2
			columnExpression3.ColumnName = "UnitPrice"
			columnExpression3.Table = table1
			column3.Expression = columnExpression3
			columnExpression4.ColumnName = "Quantity"
			columnExpression4.Table = table1
			column4.Expression = columnExpression4
			columnExpression5.ColumnName = "Discount"
			columnExpression5.Table = table1
			column5.Expression = columnExpression5
			columnExpression6.ColumnName = "ProductName"
			table2.MetaSerializable = "<Meta X=""185"" Y=""30"" Width=""125"" Height=""267"" />"
			table2.Name = "Products"
			columnExpression6.Table = table2
			column6.Expression = columnExpression6
			columnExpression7.ColumnName = "CategoryName"
			table3.MetaSerializable = "<Meta X=""340"" Y=""30"" Width=""125"" Height=""172"" />"
			table3.Name = "Categories"
			columnExpression7.Table = table3
			column7.Expression = columnExpression7
			selectQuery1.Columns.Add(column1)
			selectQuery1.Columns.Add(column2)
			selectQuery1.Columns.Add(column3)
			selectQuery1.Columns.Add(column4)
			selectQuery1.Columns.Add(column5)
			selectQuery1.Columns.Add(column6)
			selectQuery1.Columns.Add(column7)
			selectQuery1.MetaSerializable = "<Meta X=""20"" Y=""20"" Width=""100"" Height=""139"" />"
			selectQuery1.Name = "Order Details"
			relationColumnInfo1.NestedKeyColumn = "ProductID"
			relationColumnInfo1.ParentKeyColumn = "ProductID"
			join1.KeyColumns.Add(relationColumnInfo1)
			join1.Nested = table2
			join1.Parent = table1
			relationColumnInfo2.NestedKeyColumn = "CategoryID"
			relationColumnInfo2.ParentKeyColumn = "CategoryID"
			join2.KeyColumns.Add(relationColumnInfo2)
			join2.Nested = table3
			join2.Parent = table2
			selectQuery1.Relations.Add(join1)
			selectQuery1.Relations.Add(join2)
			selectQuery1.Tables.Add(table1)
			selectQuery1.Tables.Add(table2)
			selectQuery1.Tables.Add(table3)
			Me.sqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() { selectQuery1})
			masterDetailInfo1.DetailQueryName = "Products"
			relationColumnInfo3.NestedKeyColumn = "CategoryID"
			relationColumnInfo3.ParentKeyColumn = "CategoryID"
			masterDetailInfo1.KeyColumns.Add(relationColumnInfo3)
			masterDetailInfo1.MasterQueryName = "Categories"
			masterDetailInfo2.DetailQueryName = "Order Details"
			relationColumnInfo4.NestedKeyColumn = "ProductID"
			relationColumnInfo4.ParentKeyColumn = "ProductID"
			masterDetailInfo2.KeyColumns.Add(relationColumnInfo4)
			masterDetailInfo2.MasterQueryName = "Products"
			Me.sqlDataSource1.Relations.AddRange(New DevExpress.DataAccess.Sql.MasterDetailInfo() { masterDetailInfo1, masterDetailInfo2})
			Me.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable")
			' 
			' GroupHeader2
			' 
			Me.GroupHeader2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.XrLabel6, Me.XrLabel5, Me.XrLine1, Me.XrLabel9, Me.XrLabel7})
			Me.GroupHeader2.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {
				New DevExpress.XtraReports.UI.GroupField("CategoryName", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending),
				New DevExpress.XtraReports.UI.GroupField("ProductName", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)
			})
			Me.GroupHeader2.HeightF = 60F
			Me.GroupHeader2.Level = 1
			Me.GroupHeader2.Name = "GroupHeader2"
			' 
			' XrLabel6
			' 
			Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
			Me.XrLabel6.Name = "XrLabel6"
			Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.XrLabel6.SizeF = New System.Drawing.SizeF(66F, 17F)
			Me.XrLabel6.Text = "Category"
			Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' XrLabel5
			' 
			Me.XrLabel5.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {
				New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CategoryName]"),
				New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Bookmark", "[CategoryName]")
			})
			Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(67F, 0F)
			Me.XrLabel5.Name = "XrLabel5"
			Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.XrLabel5.SizeF = New System.Drawing.SizeF(150F, 17F)
			Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' XrLine1
			' 
			Me.XrLine1.BackColor = System.Drawing.Color.LightSkyBlue
			Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 35F)
			Me.XrLine1.Name = "XrLine1"
			Me.XrLine1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.XrLine1.SizeF = New System.Drawing.SizeF(650F, 25F)
			' 
			' XrLabel9
			' 
			Me.XrLabel9.BookmarkParent = Me.XrLabel5
			Me.XrLabel9.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {
				New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ProductName]"),
				New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Bookmark", "[ProductName]")
			})
			Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(67.00001F, 17.00001F)
			Me.XrLabel9.Name = "XrLabel9"
			Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.XrLabel9.SizeF = New System.Drawing.SizeF(150F, 17F)
			Me.XrLabel9.Text = "XrLabel9"
			Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' XrLabel7
			' 
			Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(0F, 17F)
			Me.XrLabel7.Name = "XrLabel7"
			Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.XrLabel7.SizeF = New System.Drawing.SizeF(66F, 17F)
			Me.XrLabel7.Text = "Product"
			Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' GroupHeader1
			' 
			Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrTable1})
			Me.GroupHeader1.HeightF = 25F
			Me.GroupHeader1.Name = "GroupHeader1"
			Me.GroupHeader1.RepeatEveryPage = True
			' 
			' xrTable1
			' 
			Me.xrTable1.LocationFloat = New DevExpress.Utils.PointFloat(102.0833F, 0F)
			Me.xrTable1.Name = "xrTable1"
			Me.xrTable1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow1})
			Me.xrTable1.SizeF = New System.Drawing.SizeF(547.9167F, 25F)
			' 
			' xrTableRow1
			' 
			Me.xrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell1, Me.xrTableCell2, Me.xrTableCell3})
			Me.xrTableRow1.Name = "xrTableRow1"
			Me.xrTableRow1.Weight = 11.5R
			' 
			' xrTableCell1
			' 
			Me.xrTableCell1.Multiline = True
			Me.xrTableCell1.Name = "xrTableCell1"
			Me.xrTableCell1.Text = "Order ID"
			Me.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
			Me.xrTableCell1.Weight = 0.2857142857142857R
			' 
			' xrTableCell2
			' 
			Me.xrTableCell2.Multiline = True
			Me.xrTableCell2.Name = "xrTableCell2"
			Me.xrTableCell2.Text = "Quantity"
			Me.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
			Me.xrTableCell2.Weight = 0.2857142857142857R
			' 
			' xrTableCell3
			' 
			Me.xrTableCell3.Multiline = True
			Me.xrTableCell3.Name = "xrTableCell3"
			Me.xrTableCell3.Text = "Unit Price"
			Me.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
			Me.xrTableCell3.Weight = 0.2857142857142857R
			' 
			' XtraReport1
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.PageFooter, Me.topMarginBand1, Me.bottomMarginBand1, Me.GroupHeader2, Me.GroupHeader1})
			Me.BookmarkDuplicateSuppress = False
			Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() { Me.sqlDataSource1})
			Me.DataMember = "Order Details"
			Me.DataSource = Me.sqlDataSource1
			Me.PaperKind = System.Drawing.Printing.PaperKind.Custom
			Me.Version = "18.1"
			CType(Me.xrTable2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.xrTable1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region
		Private PageFooter As DevExpress.XtraReports.UI.PageFooterBand
		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private sqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
		Private topMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
		Private bottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
		Private GroupHeader2 As DevExpress.XtraReports.UI.GroupHeaderBand
		Private XrLabel6 As DevExpress.XtraReports.UI.XRLabel
		Private XrLabel5 As DevExpress.XtraReports.UI.XRLabel
		Private XrLine1 As DevExpress.XtraReports.UI.XRLine
		Private XrLabel9 As DevExpress.XtraReports.UI.XRLabel
		Private XrLabel7 As DevExpress.XtraReports.UI.XRLabel
		Private xrTable2 As DevExpress.XtraReports.UI.XRTable
		Private xrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
		Private xrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
		Private GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
		Private xrTable1 As DevExpress.XtraReports.UI.XRTable
		Private xrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
		Private xrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
	End Class
End Namespace
