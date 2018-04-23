Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication1
	Partial Public Class Form1
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

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.gridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			Me.dateEdit2 = New DevExpress.XtraEditors.DateEdit()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
			Me.dateEdit1 = New DevExpress.XtraEditors.DateEdit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			CType(Me.dateEdit2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
			Me.gridControl1.Location = New System.Drawing.Point(0, 55)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(696, 504)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1, Me.gridView2})
			' 
			' gridView1
			' 
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			' 
			' gridView2
			' 
			Me.gridView2.GridControl = Me.gridControl1
			Me.gridView2.Name = "gridView2"
			' 
			' panelControl1
			' 
			Me.panelControl1.Controls.Add(Me.dateEdit2)
			Me.panelControl1.Controls.Add(Me.labelControl1)
			Me.panelControl1.Controls.Add(Me.labelControl2)
			Me.panelControl1.Controls.Add(Me.dateEdit1)
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelControl1.Location = New System.Drawing.Point(0, 0)
			Me.panelControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(696, 55)
			Me.panelControl1.TabIndex = 1
			' 
			' dateEdit2
			' 
			Me.dateEdit2.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles))
			Me.dateEdit2.EditValue = New System.DateTime(2010, 5, 11, 17, 54, 47, 0)
			Me.dateEdit2.Location = New System.Drawing.Point(441, 15)
			Me.dateEdit2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
			Me.dateEdit2.Name = "dateEdit2"
			Me.dateEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.dateEdit2.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.dateEdit2.Size = New System.Drawing.Size(239, 22)
			Me.dateEdit2.TabIndex = 7
'			Me.dateEdit2.EditValueChanged += New System.EventHandler(Me.dateEdit_EditValueChanged);
			' 
			' labelControl1
			' 
			Me.labelControl1.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles))
			Me.labelControl1.Location = New System.Drawing.Point(16, 18)
			Me.labelControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
			Me.labelControl1.Name = "labelControl1"
			Me.labelControl1.Size = New System.Drawing.Size(79, 16)
			Me.labelControl1.TabIndex = 6
			Me.labelControl1.Text = "Date between"
			' 
			' labelControl2
			' 
			Me.labelControl2.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles))
			Me.labelControl2.Location = New System.Drawing.Point(389, 18)
			Me.labelControl2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
			Me.labelControl2.Name = "labelControl2"
			Me.labelControl2.Size = New System.Drawing.Size(21, 16)
			Me.labelControl2.TabIndex = 4
			Me.labelControl2.Text = "and"
			' 
			' dateEdit1
			' 
			Me.dateEdit1.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles))
			Me.dateEdit1.EditValue = New System.DateTime(2010, 3, 11, 17, 54, 42, 285)
			Me.dateEdit1.Location = New System.Drawing.Point(115, 15)
			Me.dateEdit1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
			Me.dateEdit1.Name = "dateEdit1"
			Me.dateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.dateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.dateEdit1.Size = New System.Drawing.Size(239, 22)
			Me.dateEdit1.TabIndex = 3
'			Me.dateEdit1.EditValueChanged += New System.EventHandler(Me.dateEdit_EditValueChanged);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(696, 559)
			Me.Controls.Add(Me.gridControl1)
			Me.Controls.Add(Me.panelControl1)
			Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
			Me.Name = "Form1"
			Me.Text = "How to create a custom filter for a date column"
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			Me.panelControl1.PerformLayout()
			CType(Me.dateEdit2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dateEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
		#End Region

		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private gridView2 As DevExpress.XtraGrid.Views.Grid.GridView
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private labelControl2 As DevExpress.XtraEditors.LabelControl
		Private WithEvents dateEdit1 As DevExpress.XtraEditors.DateEdit
		Private labelControl1 As DevExpress.XtraEditors.LabelControl
		Private WithEvents dateEdit2 As DevExpress.XtraEditors.DateEdit
	End Class
End Namespace

