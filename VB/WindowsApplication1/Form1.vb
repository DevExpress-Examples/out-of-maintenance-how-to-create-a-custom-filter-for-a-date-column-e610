Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.Data.Filtering
Imports DevExpress.XtraGrid.Columns

Namespace WindowsApplication1
	Partial Public Class Form1
		Inherits Form
		Private Function CreateTable(ByVal RowCount As Integer) As DataTable
			Dim tbl As New DataTable()
			tbl.Columns.Add("Name", GetType(String))
			tbl.Columns.Add("ID", GetType(Integer))
			tbl.Columns.Add("Number", GetType(Integer))
			tbl.Columns.Add("Date", GetType(DateTime))
			For i As Integer = 0 To RowCount - 1
				tbl.Rows.Add(New Object() { String.Format("Name{0}", i), i, 3 - i, DateTime.Now.AddDays(i).AddMonths(i) })
			Next i
			Return tbl
		End Function


		Public Sub New()
			InitializeComponent()
			gridControl1.DataSource = CreateTable(20)
		End Sub

		Private ReadOnly Property FromDate() As DateTime
			Get
				Return dateEdit1.DateTime
			End Get
		End Property

		Private ReadOnly Property ToDate() As DateTime
			Get
				Return dateEdit2.DateTime
			End Get
		End Property

		Private Sub ApplyFilter()
			If gridView1.Columns("Date") Is Nothing Then
				Return
			End If

			Dim binaryFilter As CriteriaOperator = New GroupOperator(GroupOperatorType.And, New BinaryOperator("Date", FromDate, BinaryOperatorType.GreaterOrEqual), New BinaryOperator("Date", ToDate, BinaryOperatorType.Less))


			Dim simplifiedFilter As CriteriaOperator = (New OperandProperty("Date") >= New OperandValue(FromDate)) And (New OperandProperty("Date") < New OperandValue(ToDate))

			Dim filterDisplayText As String = String.Format("Date is between {0:d} and {1:d}", FromDate, ToDate)
			Dim dateFilter As New ColumnFilterInfo(binaryFilter.ToString(), filterDisplayText)
			gridView1.Columns("Date").FilterInfo = dateFilter
		End Sub

		Private Sub dateEdit_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles dateEdit2.EditValueChanged, dateEdit1.EditValueChanged
			ApplyFilter()
		End Sub
	End Class
End Namespace