Imports DevExpress.XtraPrinting
Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim r As New XtraReport1
        r.ShowPreviewDialog()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim rep As XtraReport1 = New XtraReport1()
        rep.CreateDocument()

        Dim bookmarklist As ArrayList = New ArrayList()
        Dim index As Integer = 0
        Do While index < rep.PrintingSystem.Document.BookmarkNodes.Count
            Dim j As Integer = IsNodeIncluded(bookmarklist, rep.PrintingSystem.Document.BookmarkNodes(index))
            If j = -1 Then
                bookmarklist.Add(New BookMarkList(rep.PrintingSystem.Document.BookmarkNodes(index), rep.PrintingSystem.Document.BookmarkNodes(index).Page.Index, rep.PrintingSystem.Document.BookmarkNodes(index).Text))
            Else
                If (CType(bookmarklist(j), BookMarkList)).Page > rep.PrintingSystem.Document.BookmarkNodes(index).Page.Index Then
                    CType(bookmarklist(j), BookMarkList).Node = rep.PrintingSystem.Document.BookmarkNodes(index)
                    CType(bookmarklist(j), BookMarkList).Page = rep.PrintingSystem.Document.BookmarkNodes(index).Page.Index
                    CType(bookmarklist(j), BookMarkList).Name = rep.PrintingSystem.Document.BookmarkNodes(index).Text
                End If
            End If
            index += 1
        Loop
        index = 0
        Do While index < rep.PrintingSystem.Document.BookmarkNodes.Count

            Dim index2 As Integer = IsNodeIncluded(bookmarklist, rep.PrintingSystem.Document.BookmarkNodes(index))
            If (CType(bookmarklist(index2), BookMarkList)).Node Is rep.PrintingSystem.Document.BookmarkNodes(index) Then
            Else
                Dim j As Integer = 0
                Do While j < rep.PrintingSystem.Document.BookmarkNodes(index).Nodes.Count
                    CType(bookmarklist(index2), BookMarkList).Node.Nodes.Add(rep.PrintingSystem.Document.BookmarkNodes(index).Nodes(j))
                    j += 1
                Loop

                rep.PrintingSystem.Document.BookmarkNodes(index).Nodes.Clear()
                rep.PrintingSystem.Document.BookmarkNodes.RemoveAt(index)
                index = index - 1
            End If

            index += 1
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



End Class
