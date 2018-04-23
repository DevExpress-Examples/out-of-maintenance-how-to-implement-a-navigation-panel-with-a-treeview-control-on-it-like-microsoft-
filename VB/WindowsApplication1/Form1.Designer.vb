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
			Me.components = New System.ComponentModel.Container()
			Me.navBarControl1 = New DevExpress.XtraNavBar.NavBarControl()
			Me.navBarGroup1 = New DevExpress.XtraNavBar.NavBarGroup()
			Me.navBarGroupControlContainer1 = New DevExpress.XtraNavBar.NavBarGroupControlContainer()
			Me.treeList1 = New DevExpress.XtraTreeList.TreeList()
			Me.treeListColumn1 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.checkedComboBoxEdit1 = New DevExpress.XtraEditors.CheckedComboBoxEdit()
			Me.navBarGroup2 = New DevExpress.XtraNavBar.NavBarGroup()
			Me.navBarGroup3 = New DevExpress.XtraNavBar.NavBarGroup()
			Me.defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			CType(Me.navBarControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.navBarControl1.SuspendLayout()
			Me.navBarGroupControlContainer1.SuspendLayout()
			CType(Me.treeList1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkedComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' navBarControl1
			' 
			Me.navBarControl1.ActiveGroup = Me.navBarGroup1
			Me.navBarControl1.ContentButtonHint = Nothing
			Me.navBarControl1.Controls.Add(Me.navBarGroupControlContainer1)
			Me.navBarControl1.Dock = System.Windows.Forms.DockStyle.Left
			Me.navBarControl1.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() { Me.navBarGroup1, Me.navBarGroup2, Me.navBarGroup3})
			Me.navBarControl1.Location = New System.Drawing.Point(0, 0)
			Me.navBarControl1.Name = "navBarControl1"
			Me.navBarControl1.OptionsNavPane.ExpandedWidth = 212
			Me.navBarControl1.Size = New System.Drawing.Size(212, 531)
			Me.navBarControl1.TabIndex = 0
			Me.navBarControl1.Text = "navBarControl1"
			Me.navBarControl1.View = New DevExpress.XtraNavBar.ViewInfo.SkinNavigationPaneViewInfoRegistrator()
			' 
			' navBarGroup1
			' 
			Me.navBarGroup1.Caption = "Mail"
			Me.navBarGroup1.ControlContainer = Me.navBarGroupControlContainer1
			Me.navBarGroup1.Expanded = True
			Me.navBarGroup1.GroupClientHeight = 80
			Me.navBarGroup1.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer
			Me.navBarGroup1.Name = "navBarGroup1"
			' 
			' navBarGroupControlContainer1
			' 
			Me.navBarGroupControlContainer1.Controls.Add(Me.treeList1)
			Me.navBarGroupControlContainer1.Controls.Add(Me.checkedComboBoxEdit1)
			Me.navBarGroupControlContainer1.Name = "navBarGroupControlContainer1"
			Me.navBarGroupControlContainer1.Size = New System.Drawing.Size(210, 379)
			Me.navBarGroupControlContainer1.TabIndex = 0
			' 
			' treeList1
			' 
			Me.treeList1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() { Me.treeListColumn1})
			Me.treeList1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.treeList1.Location = New System.Drawing.Point(0, 20)
			Me.treeList1.Name = "treeList1"
			Me.treeList1.BeginUnboundLoad()
			Me.treeList1.AppendNode(New Object() { "Personal folders"}, -1)
			Me.treeList1.AppendNode(New Object() { "Drafts"}, 0)
			Me.treeList1.AppendNode(New Object() { "Inbox"}, 0)
			Me.treeList1.AppendNode(New Object() { "Outbox"}, 0)
			Me.treeList1.AppendNode(New Object() { "Infected items"}, 0)
			Me.treeList1.AppendNode(New Object() { "Archive folders"}, -1)
			Me.treeList1.AppendNode(New Object() { "Deleted items"}, 5)
			Me.treeList1.AppendNode(New Object() { "Search items"}, 5)
			Me.treeList1.EndUnboundLoad()
			Me.treeList1.OptionsBehavior.Editable = False
			Me.treeList1.OptionsView.ShowColumns = False
			Me.treeList1.Size = New System.Drawing.Size(210, 359)
			Me.treeList1.TabIndex = 1
'			Me.treeList1.FocusedNodeChanged += New DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(Me.treeList1_FocusedNodeChanged);
			' 
			' treeListColumn1
			' 
			Me.treeListColumn1.Caption = "treeListColumn1"
			Me.treeListColumn1.FieldName = "treeListColumn1"
			Me.treeListColumn1.MinWidth = 38
			Me.treeListColumn1.Name = "treeListColumn1"
			Me.treeListColumn1.Visible = True
			Me.treeListColumn1.VisibleIndex = 0
			' 
			' checkedComboBoxEdit1
			' 
			Me.checkedComboBoxEdit1.Dock = System.Windows.Forms.DockStyle.Top
			Me.checkedComboBoxEdit1.EditValue = "0, 1"
			Me.checkedComboBoxEdit1.Location = New System.Drawing.Point(0, 0)
			Me.checkedComboBoxEdit1.Name = "checkedComboBoxEdit1"
			Me.checkedComboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.checkedComboBoxEdit1.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.CheckedListBoxItem() { New DevExpress.XtraEditors.Controls.CheckedListBoxItem("0", "Personal folders", System.Windows.Forms.CheckState.Checked), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("1", "Archive folders", System.Windows.Forms.CheckState.Checked)})
			Me.checkedComboBoxEdit1.Properties.SelectAllItemCaption = "All mail items"
			Me.checkedComboBoxEdit1.Size = New System.Drawing.Size(210, 20)
			Me.checkedComboBoxEdit1.TabIndex = 1
			' 
			' navBarGroup2
			' 
			Me.navBarGroup2.Caption = "Calendar"
			Me.navBarGroup2.Name = "navBarGroup2"
			' 
			' navBarGroup3
			' 
			Me.navBarGroup3.Caption = "Contacts"
			Me.navBarGroup3.Name = "navBarGroup3"
			' 
			' defaultLookAndFeel1
			' 
			Me.defaultLookAndFeel1.LookAndFeel.SkinName = "Black"
			' 
			' panelControl1
			' 
			Me.panelControl1.Controls.Add(Me.labelControl1)
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.panelControl1.Location = New System.Drawing.Point(212, 0)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(515, 531)
			Me.panelControl1.TabIndex = 1
			' 
			' labelControl1
			' 
			Me.labelControl1.Appearance.Font = New System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.labelControl1.Appearance.Options.UseFont = True
			Me.labelControl1.Location = New System.Drawing.Point(171, 234)
			Me.labelControl1.Name = "labelControl1"
			Me.labelControl1.Size = New System.Drawing.Size(189, 36)
			Me.labelControl1.TabIndex = 0
			Me.labelControl1.Text = "labelControl1"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(727, 531)
			Me.Controls.Add(Me.panelControl1)
			Me.Controls.Add(Me.navBarControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.navBarControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.navBarControl1.ResumeLayout(False)
			Me.navBarGroupControlContainer1.ResumeLayout(False)
			CType(Me.treeList1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkedComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			Me.panelControl1.PerformLayout()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private navBarControl1 As DevExpress.XtraNavBar.NavBarControl
		Private navBarGroup1 As DevExpress.XtraNavBar.NavBarGroup
		Private navBarGroupControlContainer1 As DevExpress.XtraNavBar.NavBarGroupControlContainer
		Private WithEvents treeList1 As DevExpress.XtraTreeList.TreeList
		Private checkedComboBoxEdit1 As DevExpress.XtraEditors.CheckedComboBoxEdit
		Private navBarGroup2 As DevExpress.XtraNavBar.NavBarGroup
		Private navBarGroup3 As DevExpress.XtraNavBar.NavBarGroup
		Private treeListColumn1 As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private labelControl1 As DevExpress.XtraEditors.LabelControl

	End Class
End Namespace

