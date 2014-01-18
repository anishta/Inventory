<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIssue
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim NoteLabel As System.Windows.Forms.Label
        Dim BalLabel As System.Windows.Forms.Label
        Dim BillNoLabel As System.Windows.Forms.Label
        Dim QtyLabel As System.Windows.Forms.Label
        Dim PNameLabel As System.Windows.Forms.Label
        Dim Supplier_NameLabel As System.Windows.Forms.Label
        Dim DateLabel As System.Windows.Forms.Label
        Dim IDLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIssue))
        Me.Issue1BindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.Issue1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New WindowsApplication1.DataSet1
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.Issue1BindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.Issue1TableAdapter = New WindowsApplication1.DataSet1TableAdapters.Issue1TableAdapter
        Me.TableAdapterManager = New WindowsApplication1.DataSet1TableAdapters.TableAdapterManager
        Me.CustomerTableAdapter = New WindowsApplication1.DataSet1TableAdapters.CustomerTableAdapter
        Me.ProductTableAdapter = New WindowsApplication1.DataSet1TableAdapters.ProductTableAdapter
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PNameComboBox = New System.Windows.Forms.ComboBox
        Me.Supplier_NameComboBox = New System.Windows.Forms.ComboBox
        Me.NoteTextBox = New System.Windows.Forms.TextBox
        Me.BalTextBox = New System.Windows.Forms.TextBox
        Me.BillNoTextBox = New System.Windows.Forms.TextBox
        Me.QtyTextBox = New System.Windows.Forms.TextBox
        Me.DateDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.IDTextBox = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        NoteLabel = New System.Windows.Forms.Label
        BalLabel = New System.Windows.Forms.Label
        BillNoLabel = New System.Windows.Forms.Label
        QtyLabel = New System.Windows.Forms.Label
        PNameLabel = New System.Windows.Forms.Label
        Supplier_NameLabel = New System.Windows.Forms.Label
        DateLabel = New System.Windows.Forms.Label
        IDLabel = New System.Windows.Forms.Label
        CType(Me.Issue1BindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Issue1BindingNavigator.SuspendLayout()
        CType(Me.Issue1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'NoteLabel
        '
        NoteLabel.AutoSize = True
        NoteLabel.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NoteLabel.Location = New System.Drawing.Point(99, 353)
        NoteLabel.Name = "NoteLabel"
        NoteLabel.Size = New System.Drawing.Size(58, 18)
        NoteLabel.TabIndex = 31
        NoteLabel.Text = "Note:"
        '
        'BalLabel
        '
        BalLabel.AutoSize = True
        BalLabel.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BalLabel.Location = New System.Drawing.Point(19, 310)
        BalLabel.Name = "BalLabel"
        BalLabel.Size = New System.Drawing.Size(138, 18)
        BalLabel.TabIndex = 29
        BalLabel.Text = "Balance Qty.:"
        '
        'BillNoLabel
        '
        BillNoLabel.AutoSize = True
        BillNoLabel.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BillNoLabel.Location = New System.Drawing.Point(69, 261)
        BillNoLabel.Name = "BillNoLabel"
        BillNoLabel.Size = New System.Drawing.Size(88, 18)
        BillNoLabel.TabIndex = 27
        BillNoLabel.Text = "Bill No:"
        '
        'QtyLabel
        '
        QtyLabel.AutoSize = True
        QtyLabel.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        QtyLabel.Location = New System.Drawing.Point(109, 217)
        QtyLabel.Name = "QtyLabel"
        QtyLabel.Size = New System.Drawing.Size(48, 18)
        QtyLabel.TabIndex = 25
        QtyLabel.Text = "Qty:"
        '
        'PNameLabel
        '
        PNameLabel.AutoSize = True
        PNameLabel.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PNameLabel.Location = New System.Drawing.Point(19, 172)
        PNameLabel.Name = "PNameLabel"
        PNameLabel.Size = New System.Drawing.Size(138, 18)
        PNameLabel.TabIndex = 24
        PNameLabel.Text = "Product Name:"
        '
        'Supplier_NameLabel
        '
        Supplier_NameLabel.AutoSize = True
        Supplier_NameLabel.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Supplier_NameLabel.Location = New System.Drawing.Point(9, 130)
        Supplier_NameLabel.Name = "Supplier_NameLabel"
        Supplier_NameLabel.Size = New System.Drawing.Size(148, 18)
        Supplier_NameLabel.TabIndex = 23
        Supplier_NameLabel.Text = "Customer Name:"
        AddHandler Supplier_NameLabel.Click, AddressOf Me.Supplier_NameLabel_Click
        '
        'DateLabel
        '
        DateLabel.AutoSize = True
        DateLabel.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DateLabel.Location = New System.Drawing.Point(99, 87)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New System.Drawing.Size(58, 18)
        DateLabel.TabIndex = 21
        DateLabel.Text = "Date:"
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDLabel.Location = New System.Drawing.Point(119, 35)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(38, 18)
        IDLabel.TabIndex = 19
        IDLabel.Text = "ID:"
        '
        'Issue1BindingNavigator
        '
        Me.Issue1BindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Issue1BindingNavigator.BackColor = System.Drawing.Color.White
        Me.Issue1BindingNavigator.BindingSource = Me.Issue1BindingSource
        Me.Issue1BindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Issue1BindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Issue1BindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Issue1BindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Issue1BindingNavigatorSaveItem, Me.ToolStripButton1, Me.ToolStripButton2})
        Me.Issue1BindingNavigator.Location = New System.Drawing.Point(0, 524)
        Me.Issue1BindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Issue1BindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Issue1BindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Issue1BindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Issue1BindingNavigator.Name = "Issue1BindingNavigator"
        Me.Issue1BindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Issue1BindingNavigator.Size = New System.Drawing.Size(544, 25)
        Me.Issue1BindingNavigator.TabIndex = 0
        Me.Issue1BindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(46, 22)
        Me.BindingNavigatorAddNewItem.Text = "&Add"
        '
        'Issue1BindingSource
        '
        Me.Issue1BindingSource.DataMember = "Issue1"
        Me.Issue1BindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(36, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(58, 22)
        Me.BindingNavigatorDeleteItem.Text = "&Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 21)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Issue1BindingNavigatorSaveItem
        '
        Me.Issue1BindingNavigatorSaveItem.Image = CType(resources.GetObject("Issue1BindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Issue1BindingNavigatorSaveItem.Name = "Issue1BindingNavigatorSaveItem"
        Me.Issue1BindingNavigatorSaveItem.Size = New System.Drawing.Size(51, 22)
        Me.Issue1BindingNavigatorSaveItem.Text = "&Save"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(62, 22)
        Me.ToolStripButton1.Text = "&Update"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(60, 22)
        Me.ToolStripButton2.Text = "S&earch"
        '
        'Issue1TableAdapter
        '
        Me.Issue1TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CustomerTableAdapter = Me.CustomerTableAdapter
        Me.TableAdapterManager.Issue1TableAdapter = Me.Issue1TableAdapter
        Me.TableAdapterManager.IssueTableAdapter = Nothing
        Me.TableAdapterManager.LoginTableAdapter = Nothing
        Me.TableAdapterManager.ProductTableAdapter = Me.ProductTableAdapter
        Me.TableAdapterManager.ReceiptTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'ProductTableAdapter
        '
        Me.ProductTableAdapter.ClearBeforeFill = True
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataMember = "Customer"
        Me.CustomerBindingSource.DataSource = Me.DataSet1
        '
        'ProductBindingSource
        '
        Me.ProductBindingSource.DataMember = "Product"
        Me.ProductBindingSource.DataSource = Me.DataSet1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PNameComboBox)
        Me.Panel1.Controls.Add(Me.Supplier_NameComboBox)
        Me.Panel1.Controls.Add(NoteLabel)
        Me.Panel1.Controls.Add(Me.NoteTextBox)
        Me.Panel1.Controls.Add(BalLabel)
        Me.Panel1.Controls.Add(Me.BalTextBox)
        Me.Panel1.Controls.Add(BillNoLabel)
        Me.Panel1.Controls.Add(Me.BillNoTextBox)
        Me.Panel1.Controls.Add(QtyLabel)
        Me.Panel1.Controls.Add(Me.QtyTextBox)
        Me.Panel1.Controls.Add(PNameLabel)
        Me.Panel1.Controls.Add(Supplier_NameLabel)
        Me.Panel1.Controls.Add(DateLabel)
        Me.Panel1.Controls.Add(Me.DateDateTimePicker)
        Me.Panel1.Controls.Add(IDLabel)
        Me.Panel1.Controls.Add(Me.IDTextBox)
        Me.Panel1.Location = New System.Drawing.Point(26, 89)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(495, 397)
        Me.Panel1.TabIndex = 19
        '
        'PNameComboBox
        '
        Me.PNameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Issue1BindingSource, "PName", True))
        Me.PNameComboBox.DataSource = Me.ProductBindingSource
        Me.PNameComboBox.DisplayMember = "PName"
        Me.PNameComboBox.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PNameComboBox.FormattingEnabled = True
        Me.PNameComboBox.Location = New System.Drawing.Point(181, 172)
        Me.PNameComboBox.Name = "PNameComboBox"
        Me.PNameComboBox.Size = New System.Drawing.Size(247, 26)
        Me.PNameComboBox.TabIndex = 4
        '
        'Supplier_NameComboBox
        '
        Me.Supplier_NameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Issue1BindingSource, "Supplier Name", True))
        Me.Supplier_NameComboBox.DataSource = Me.CustomerBindingSource
        Me.Supplier_NameComboBox.DisplayMember = "Name"
        Me.Supplier_NameComboBox.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Supplier_NameComboBox.FormattingEnabled = True
        Me.Supplier_NameComboBox.Location = New System.Drawing.Point(181, 130)
        Me.Supplier_NameComboBox.Name = "Supplier_NameComboBox"
        Me.Supplier_NameComboBox.Size = New System.Drawing.Size(247, 26)
        Me.Supplier_NameComboBox.TabIndex = 3
        '
        'NoteTextBox
        '
        Me.NoteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Issue1BindingSource, "Note", True))
        Me.NoteTextBox.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NoteTextBox.Location = New System.Drawing.Point(181, 348)
        Me.NoteTextBox.Name = "NoteTextBox"
        Me.NoteTextBox.Size = New System.Drawing.Size(305, 26)
        Me.NoteTextBox.TabIndex = 8
        '
        'BalTextBox
        '
        Me.BalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Issue1BindingSource, "Bal", True))
        Me.BalTextBox.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BalTextBox.Location = New System.Drawing.Point(181, 302)
        Me.BalTextBox.Name = "BalTextBox"
        Me.BalTextBox.ReadOnly = True
        Me.BalTextBox.Size = New System.Drawing.Size(100, 26)
        Me.BalTextBox.TabIndex = 7
        '
        'BillNoTextBox
        '
        Me.BillNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Issue1BindingSource, "BillNo", True))
        Me.BillNoTextBox.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BillNoTextBox.Location = New System.Drawing.Point(181, 261)
        Me.BillNoTextBox.Name = "BillNoTextBox"
        Me.BillNoTextBox.Size = New System.Drawing.Size(100, 26)
        Me.BillNoTextBox.TabIndex = 6
        '
        'QtyTextBox
        '
        Me.QtyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Issue1BindingSource, "Qty", True))
        Me.QtyTextBox.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QtyTextBox.Location = New System.Drawing.Point(181, 217)
        Me.QtyTextBox.Name = "QtyTextBox"
        Me.QtyTextBox.Size = New System.Drawing.Size(100, 26)
        Me.QtyTextBox.TabIndex = 5
        '
        'DateDateTimePicker
        '
        Me.DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Issue1BindingSource, "Date", True))
        Me.DateDateTimePicker.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateDateTimePicker.Location = New System.Drawing.Point(181, 86)
        Me.DateDateTimePicker.Name = "DateDateTimePicker"
        Me.DateDateTimePicker.Size = New System.Drawing.Size(133, 26)
        Me.DateDateTimePicker.TabIndex = 2
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Issue1BindingSource, "ID", True))
        Me.IDTextBox.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDTextBox.Location = New System.Drawing.Point(181, 35)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(100, 26)
        Me.IDTextBox.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 20.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(142, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(275, 31)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Product Issued Detail"
        '
        'frmIssue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(544, 549)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Issue1BindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmIssue"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Product Issue Details"
        CType(Me.Issue1BindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Issue1BindingNavigator.ResumeLayout(False)
        Me.Issue1BindingNavigator.PerformLayout()
        CType(Me.Issue1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataSet1 As WindowsApplication1.DataSet1
    Friend WithEvents Issue1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Issue1TableAdapter As WindowsApplication1.DataSet1TableAdapters.Issue1TableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents Issue1BindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Issue1BindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents CustomerTableAdapter As WindowsApplication1.DataSet1TableAdapters.CustomerTableAdapter
    Friend WithEvents CustomerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductTableAdapter As WindowsApplication1.DataSet1TableAdapters.ProductTableAdapter
    Friend WithEvents ProductBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PNameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Supplier_NameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents NoteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BillNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents QtyTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
End Class
