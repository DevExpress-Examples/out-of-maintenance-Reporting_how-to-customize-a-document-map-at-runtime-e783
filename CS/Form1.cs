using System;
using System.Collections;
using System.Windows.Forms;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;

namespace AK16962 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            XtraReport1 r = new XtraReport1();
            ReportPrintTool rpt = new ReportPrintTool(r);
            rpt.ShowPreviewDialog();
       }

        private void button2_Click(object sender, EventArgs e) {
            XtraReport1 rep = new XtraReport1();
            rep.CreateDocument();

            ArrayList bookmarklist = new ArrayList();
            int i = 0;
            while(i < rep.PrintingSystem.Document.BookmarkNodes.Count) {
                int index = IsNodeIncluded(bookmarklist, rep.PrintingSystem.Document.BookmarkNodes[i]);
                if(index == -1) {
                    bookmarklist.Add(new BookMarkList(rep.PrintingSystem.Document.BookmarkNodes[i], rep.PrintingSystem.Document.BookmarkNodes[i].PageIndex, rep.PrintingSystem.Document.BookmarkNodes[i].Text));
                }
                else {
                    if(((BookMarkList)(bookmarklist[index])).Page > rep.PrintingSystem.Document.BookmarkNodes[i].PageIndex) {
                        ((BookMarkList)(bookmarklist[index])).Node = rep.PrintingSystem.Document.BookmarkNodes[i];
                        ((BookMarkList)(bookmarklist[index])).Page = rep.PrintingSystem.Document.BookmarkNodes[i].PageIndex;
                        ((BookMarkList)(bookmarklist[index])).Name = rep.PrintingSystem.Document.BookmarkNodes[i].Text;
                    }
                }
                i += 1;
            }
            i = 0;
            while(i < rep.PrintingSystem.Document.BookmarkNodes.Count) {

                int index = IsNodeIncluded(bookmarklist, rep.PrintingSystem.Document.BookmarkNodes[i]);
                if(((BookMarkList)(bookmarklist[index])).Node == rep.PrintingSystem.Document.BookmarkNodes[i]) {
                }
                else {
                    int j = 0;
                    while(j < rep.PrintingSystem.Document.BookmarkNodes[i].Nodes.Count) {
                        ((BookMarkList)(bookmarklist[index])).Node.Nodes.Add(rep.PrintingSystem.Document.BookmarkNodes[i].Nodes[j]);
                        j += 1;
                    }

                    rep.PrintingSystem.Document.BookmarkNodes[i].Nodes.Clear();
                    rep.PrintingSystem.Document.BookmarkNodes.RemoveAt(i);
                    i = i - 1;
                }

                i += 1;
            }
            rep.ShowPreviewDialog();

        }
        private int IsNodeIncluded(ArrayList bookmarklist, BookmarkNode bookmarkNode)
		{
			foreach (BookMarkList item in bookmarklist)
			{
				if (item.Name == bookmarkNode.Text)
				{
					return bookmarklist.IndexOf(item);
				}
			}
			return -1;
		}

    }
    public class BookMarkList {
        private BookmarkNode node_Renamed;
        public BookmarkNode Node { get { return node_Renamed;} set {node_Renamed = value; }
        }
        private int page_Renamed;
        public int Page {get {return page_Renamed;} set { page_Renamed = value; }
        }
        private string name_Renamed;

        public string Name { get { return name_Renamed; } set { name_Renamed = value; }
        }

        public BookMarkList(BookmarkNode node_Renamed, int page_Renamed, string name_Renamed) {
            this.node_Renamed = node_Renamed;
            this.page_Renamed = page_Renamed;
            this.name_Renamed = name_Renamed;
        }
    }

}