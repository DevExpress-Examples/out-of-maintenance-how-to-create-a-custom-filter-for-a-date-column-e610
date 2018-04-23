using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.Data.Filtering;
using DevExpress.XtraGrid.Columns;

namespace WindowsApplication1 {
    public partial class Form1 : Form {
        private DataTable CreateTable(int RowCount) {
            DataTable tbl = new DataTable();
            tbl.Columns.Add("Name", typeof(string));
            tbl.Columns.Add("ID", typeof(int));
            tbl.Columns.Add("Number", typeof(int));
            tbl.Columns.Add("Date", typeof(DateTime));
            for(int i = 0; i < RowCount; i++)
                tbl.Rows.Add(new object[] { String.Format("Name{0}", i), i, 3 - i, DateTime.Now.AddDays(i).AddMonths(i) });
            return tbl;
        }


        public Form1() {
            InitializeComponent();
            gridControl1.DataSource = CreateTable(20);
        }

        DateTime FromDate {
            get { return dateEdit1.DateTime; }
        }

        DateTime ToDate {
            get { return dateEdit2.DateTime; }
        }

        private void ApplyFilter() {
            if(gridView1.Columns["Date"] == null) return;

            CriteriaOperator binaryFilter = new GroupOperator(GroupOperatorType.And,
                            new BinaryOperator("Date", FromDate, BinaryOperatorType.GreaterOrEqual),
                            new BinaryOperator("Date", ToDate, BinaryOperatorType.Less));
            
            
            CriteriaOperator simplifiedFilter = (new OperandProperty("Date") >= new OperandValue(FromDate)) & (new OperandProperty("Date") < new OperandValue(ToDate));

            string filterDisplayText = String.Format("Date is between {0:d} and {1:d}", FromDate, ToDate);
            ColumnFilterInfo dateFilter = new ColumnFilterInfo(binaryFilter.ToString(), filterDisplayText);
            gridView1.Columns["Date"].FilterInfo = dateFilter;
        }

        private void dateEdit_EditValueChanged(object sender, EventArgs e) {
            ApplyFilter();
        }
    }
}