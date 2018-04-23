Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.Windows.Forms
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraReports.UI

Namespace AK16962
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			Dim r As New XtraReport1()
			Dim rpt As New ReportPrintTool(r)
			rpt.ShowPreviewDialog()
		End Sub

		Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button2.Click
			Dim rep As New XtraReport1()
			rep.CreateDocument()

			Dim bookmarklist As New ArrayList()
			Dim i As Integer = 0
			Do While i < rep.PrintingSystem.Document.BookmarkNodes.Count
				Dim index As Integer = IsNodeIncluded(bookmarklist, rep.PrintingSystem.Document.BookmarkNodes(i))
				If index = -1 Then
					bookmarklist.Add(New BookMarkList(rep.PrintingSystem.Document.BookmarkNodes(i), rep.PrintingSystem.Document.BookmarkNodes(i).Page.Index, rep.PrintingSystem.Document.BookmarkNodes(i).Text))
				Else
					If (CType(bookmarklist(index), BookMarkList)).Page > rep.PrintingSystem.Document.BookmarkNodes(i).Page.Index Then
						CType(bookmarklist(index), BookMarkList).Node = rep.PrintingSystem.Document.BookmarkNodes(i)
						CType(bookmarklist(index), BookMarkList).Page = rep.PrintingSystem.Document.BookmarkNodes(i).Page.Index
						CType(bookmarklist(index), BookMarkList).Name = rep.PrintingSystem.Document.BookmarkNodes(i).Text
					End If
				End If
				i += 1
			Loop
			i = 0
			Do While i < rep.PrintingSystem.Document.BookmarkNodes.Count

				Dim index As Integer = IsNodeIncluded(bookmarklist, rep.PrintingSystem.Document.BookmarkNodes(i))
				If (CType(bookmarklist(index), BookMarkList)).Node Is rep.PrintingSystem.Document.BookmarkNodes(i) Then
				Else
					Dim j As Integer = 0
					Do While j < rep.PrintingSystem.Document.BookmarkNodes(i).Nodes.Count
						CType(bookmarklist(index), BookMarkList).Node.Nodes.Add(rep.PrintingSystem.Document.BookmarkNodes(i).Nodes(j))
						j += 1
					Loop

					rep.PrintingSystem.Document.BookmarkNodes(i).Nodes.Clear()
					rep.PrintingSystem.Document.BookmarkNodes.RemoveAt(i)
					i = i - 1
				End If

				i += 1
			Loop
			rep.ShowPreviewDialog()

		End Sub
		Private Function IsNodeIncluded(ByVal bookmarklist As ArrayList, ByVal bookmarkNode As BookmarkNode) As Integer
			For Each item As BookMarkList In bookmarklist
				If item.Name = bookmarkNode.Text Then
					Return bookmarklist.IndexOf(item)
				End If
			Next item
			Return -1
		End Function

	End Class
	Public Class BookMarkList
		Private node_Renamed As BookmarkNode
		Public Property Node() As BookmarkNode
			Get
				Return node_Renamed
			End Get
			Set(ByVal value As BookmarkNode)
				node_Renamed = value
			End Set
		End Property
		Private page_Renamed As Integer
		Public Property Page() As Integer
			Get
				Return page_Renamed
			End Get
			Set(ByVal value As Integer)
				page_Renamed = value
			End Set
		End Property
		Private name_Renamed As String

		Public Property Name() As String
			Get
				Return name_Renamed
			End Get
			Set(ByVal value As String)
				name_Renamed = value
			End Set
		End Property

		Public Sub New(ByVal node_Renamed As BookmarkNode, ByVal page_Renamed As Integer, ByVal name_Renamed As String)
			Me.node_Renamed = node_Renamed
			Me.page_Renamed = page_Renamed
			Me.name_Renamed = name_Renamed
		End Sub
	End Class

End Namespace