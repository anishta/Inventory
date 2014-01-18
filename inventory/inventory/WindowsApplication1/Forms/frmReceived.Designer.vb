<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReceived
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
        Dim BalanceLabel As System.Windows.Forms.Label
        Dim QtyLabel As System.Windows.Forms.Label
        Dim BillNoLabel As System.Windows.Forms.Label
        Dim PNameLabel As System.Windows.Forms.Label
        Dim SNameLabel As System.Windows.Forms.Label
        Dim DateLabel As System.Windows.Forms.Label
        Dim IDLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReceived))
        Me.DataSet1 = New WindowsApplication1.DataSet1
        Me.ReceiptBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReceiptTableAdapter = New WindowsApplication1.DataSet1TableAdapters.ReceiptTableAdapter
        Me.TableAdapterManager = New WindowsApplication1.DataSet1TableAdapters.TableAdapterManager
        Me.CustomerTableAdapter = New WindowsApplication1.DataSet1TableAdapters.CustomerTableAdapter
        Me.ProductTableAdapter = New WindowsApplication1.DataSet1TableAdapters.ProductTableAdapter
        Me.ReceiptBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
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
        Me.ReceiptBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.ProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.SNameComboBox = New System.Windows.Forms.ComboBox
        Me.NoteTextBox = New System.Windows.Forms.TextBox
        Me.BalanceTextBox = New System.Windows.Forms.TextBox
        Me.QtyTextBox = New System.Windows.Forms.TextBox
        Me.BillNoTextBox = New System.Windows.Forms.TextBox
        Me.PNameComboBox = New System.Windows.Forms.ComboBox
        Me.DateDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.IDTextBox = New System.Windows.Forms.TextBox
        NoteLabel = New System.Windows.Forms.Label
        BalanceLabel = New System.Windows.Forms.Label
        QtyLabel = New System.Windows.Forms.Label
        BillNoLabel = New System.Windows.Forms.Label
        PNameLabel = New System.Windows.Forms.Label
        SNameLabel = New System.Windows.Forms.Label
        DateLabel = New System.Windows.Forms.Label
        IDLabel = New System.Windows.Forms.Label
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReceiptBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReceiptBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ReceiptBindingNavigator.SuspendLayout()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'NoteLabel
        '
        NoteLabel.AutoSize = True
        NoteLabel.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NoteLabel.Location = New System.Drawing.Point(110, 341)
        NoteLabel.Name = "NoteLabel"
        NoteLabel.Size = New System.Drawing.Size(58, 18)
        NoteLabel.TabIndex = 38
        NoteLabel.Text = "Note:"
        '
        'BalanceLabel
        '
        BalanceLabel.AutoSize = True
        BalanceLabel.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BalanceLabel.Location = New System.Drawing.Point(30, 294)
        BalanceLabel.Name = "BalanceLabel"
        BalanceLabel.Size = New System.Drawing.Size(138, 18)
        BalanceLabel.TabIndex = 36
        BalanceLabel.Text = "Balanced Qty:"
        '
        'QtyLabel
        '
        QtyLabel.AutoSize = True
        QtyLabel.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        QtyLabel.Location = New System.Drawing.Point(120, 249)
        QtyLabel.Name = "QtyLabel"
        QtyLabel.Size = New System.Drawing.Size(48, 18)
        QtyLabel.TabIndex = 34
        QtyLabel.Text = "Qty:"
        '
        'BillNoLabel
        '
        BillNoLabel.AutoSize = True
        BillNoLabel.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BillNoLabel.Location = New System.Drawing.Point(80, 203)
        BillNoLabel.Name = "BillNoLabel"
        BillNoLabel.Size = New System.Drawing.Size(88, 18)
        BillNoLabel.TabIndex = 32
        BillNoLabel.Text = "Bill No:"
        '
        'PNameLabel
        '
        PNameLabel.AutoSize = True
        PNameLabel.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PNameLabel.Location = New System.Drawing.Point(30, 157)
        PNameLabel.Name = "PNameLabel"
        PNameLabel.Size = New System.Drawing.Size(138, 18)
        PNameLabel.TabIndex = 30
        PNameLabel.Text = "Product Name:"
        '
        'SNameLabel
        '
        SNameLabel.AutoSize = True
        SNameLabel.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SNameLabel.Location = New System.Drawing.Point(20, 111)
        SNameLabel.Name = "SNameLabel"
        SNameLabel.Size = New System.Drawing.Size(148, 18)
        SNameLabel.TabIndex = 29
        SNameLabel.Text = "Supplier Name:"
        '
        'DateLabel
        '
        DateLabel.AutoSize = True
        DateLabel.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DateLabel.Location = New System.Drawing.Point(110, 65)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New System.Drawing.Size(58, 18)
        DateLabel.TabIndex = 27
        DateLabel.Text = "Date:"
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDLabel.Location = New System.Drawing.Point(130, 12)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(38, 18)
        IDLabel.TabIndex = 25
        IDLabel.Text = "ID:"
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReceiptBindingSource
        '
        Me.ReceiptBindingSource.DataMember = "Receipt"
        Me.ReceiptBindingSource.DataSource = Me.DataSet1
        '
        'ReceiptTableAdapter
        '
        Me.ReceiptTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CustomerTableAdapter = Me.CustomerTableAdapter
        Me.TableAdapterManager.Issue1TableAdapter = Nothing
        Me.TableAdapterManager.IssueTableAdapter = Nothing
        Me.TableAdapterManager.LoginTableAdapter = Nothing
        Me.TableAdapterManager.ProductTableAdapter = Me.ProductTableAdapter
        Me.TableAdapterManager.ReceiptTableAdapter = Me.ReceiptTableAdapter
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
        'ReceiptBindingNavigator
        '
        Me.ReceiptBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ReceiptBindingNavigator.BackColor = System.Drawing.Color.White
        Me.ReceiptBindingNavigator.BindingSource = Me.ReceiptBindingSource
        Me.ReceiptBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ReceiptBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ReceiptBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ReceiptBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ReceiptBindingNavigatorSaveItem, Me.ToolStripButton1, Me.ToolStripButton2})
        Me.ReceiptBindingNavigator.Location = New System.Drawing.Point(0, 478)
        Me.ReceiptBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ReceiptBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ReceiptBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ReceiptBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ReceiptBindingNavigator.Name = "ReceiptBindingNavigator"
        Me.ReceiptBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ReceiptBindingNavigator.Size = New System.Drawing.Size(512, 25)
        Me.ReceiptBindingNavigator.TabIndex = 0
        Me.ReceiptBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(46, 22)
        Me.BindingNavigatorAddNewItem.Text = "&Add"
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
        'ReceiptBindingNavigatorSaveItem
        '
        Me.ReceiptBindingNavigatorSaveItem.Image = CType(resources.GetObject("ReceiptBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ReceiptBindingNavigatorSaveItem.Name = "ReceiptBindingNavigatorSaveItem"
        Me.ReceiptBindingNavigatorSaveItem.Size = New System.Drawing.Size(51, 22)
        Me.ReceiptBindingNavigatorSaveItem.Text = "&Save"
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
        'ProductBindingSource
        '
        Me.ProductBindingSource.DataMember = "Product"
        Me.ProductBindingSource.DataSource = Me.DataSet1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 20.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(122, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(311, 31)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Product Received Detail"
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataMember = "Customer"
        Me.CustomerBindingSource.DataSource = Me.DataSet1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.SNameComboBox)
        Me.Panel1.Controls.Add(NoteLabel)
        Me.Panel1.Controls.Add(Me.NoteTextBox)
        Me.Panel1.Controls.Add(BalanceLabel)
        Me.Panel1.Controls.Add(Me.BalanceTextBox)
        Me.Panel1.Controls.Add(QtyLabel)
        Me.Panel1.Controls.Add(Me.QtyTextBox)
        Me.Panel1.Controls.Add(BillNoLabel)
        Me.Panel1.Controls.Add(Me.BillNoTextBox)
        Me.Panel1.Controls.Add(PNameLabel)
        Me.Panel1.Controls.Add(Me.PNameComboBox)
        Me.Panel1.Controls.Add(SNameLabel)
        Me.Panel1.Controls.Add(DateLabel)
        Me.Panel1.Controls.Add(Me.DateDateTimePicker)
        Me.Panel1.Controls.Add(IDLabel)
        Me.Panel1.Controls.Add(Me.IDTextBox)
        Me.Panel1.Location = New System.Drawing.Point(22, 69)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(463, 376)
        Me.Panel1.TabIndex = 23
        '
        'SNameComboBox
        '
        Me.SNameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReceiptBindingSource, "SName", True))
        Me.SNameComboBox.DataSource = Me.CustomerBindingSource
        Me.SNameComboBox.DisplayMember = "Name"
        Me.SNameComboBox.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SNameComboBox.FormattingEnabled = True
        Me.SNameComboBox.Location = New System.Drawing.Point(200, 111)
        Me.SNameComboBox.Name = "SNameComboBox"
        Me.SNameComboBox.Size = New System.Drawing.Size(196, 26)
        Me.SNameComboBox.TabIndex = 3
        '
        'NoteTextBox
        '
        Me.NoteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReceiptBindingSource, "Note", True))
        Me.NoteTextBox.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NoteTextBox.Location = New System.Drawing.Point(200, 341)
        Me.NoteTextBox.Name = "NoteTextBox"
        Me.NoteTextBox.Size = New System.Drawing.Size(100, 26)
        Me.NoteTextBox.TabIndex = 8
        '
        'BalanceTextBox
        '
        Me.BalanceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReceiptBindingSource, "Balance", True))
        Me.BalanceTextBox.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BalanceTextBox.Location = New System.Drawing.Point(200, 294)
        Me.BalanceTextBox.Name = "BalanceTextBox"
        Me.BalanceTextBox.ReadOnly = True
        Me.BalanceTextBox.Size = New System.Drawing.Size(100, 26)
        Me.BalanceTextBox.TabIndex = 7
        '
        'QtyTextBox
        '
        Me.QtyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReceiptBindingSource, "Qty", True))
        Me.QtyTextBox.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QtyTextBox.Location = New System.Drawing.Point(200, 247)
        Me.QtyTextBox.Name = "QtyTextBox"
        Me.QtyTextBox.Size = New System.Drawing.Size(100, 26)
        Me.QtyTextBox.TabIndex = 6
        '
        'BillNoTextBox
        '
        Me.BillNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReceiptBindingSource, "BillNo", True))
        Me.BillNoTextBox.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BillNoTextBox.Location = New System.Drawing.Point(200, 200)
        Me.BillNoTextBox.Name = "BillNoTextBox"
        Me.BillNoTextBox.Size = New System.Drawing.Size(100, 26)
        Me.BillNoTextBox.TabIndex = 5
        '
        'PNameComboBox
        '
        Me.PNameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReceiptBindingSource, "PName", True))
        Me.PNameComboBox.DataSource = Me.ProductBindingSource
        Me.PNameComboBox.DisplayMember = "PName"
        Me.PNameComboBox.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PNameComboBox.FormattingEnabled = True
        Me.PNameComboBox.Location = New System.Drawing.Point(200, 153)
        Me.PNameComboBox.Name = "PNameComboBox"
        Me.PNameComboBox.Size = New System.Drawing.Size(196, 26)
        Me.PNameComboBox.TabIndex = 4
        '
        'DateDateTimePicker
        '
        Me.DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ReceiptBindingSource, "Date", True))
        Me.DateDateTimePicker.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateDateTimePicker.Location = New System.Drawing.Point(200, 59)
        Me.DateDateTimePicker.Name = "DateDateTimePicker"
        Me.DateDateTimePicker.Size = New System.Drawing.Size(121, 26)
        Me.DateDateTimePicker.TabIndex = 2
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReceiptBindingSource, "ID", True))
        Me.IDTextBox.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDTextBox.Location = New System.Drawing.Point(200, 12)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(100, 26)
        Me.IDTextBox.TabIndex = 1
        '
        'frmReceived
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(512, 503)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ReceiptBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmReceived"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Product Received Details"
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReceiptBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReceiptBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ReceiptBindingNavigator.ResumeLayout(False)
        Me.ReceiptBindingNavigator.PerformLayout()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataSet1 As WindowsApplication1.DataSet1
    Friend WithEvents ReceiptBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReceiptTableAdapter As WindowsApplication1.DataSet1TableAdapters.ReceiptTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents ReceiptBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents ReceiptBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ProductTableAdapter As WindowsApplication1.DataSet1TableAdapters.ProductTableAdapter
    Friend WithEvents ProductBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CustomerTableAdapter As WindowsApplication1.DataSet1TableAdapters.CustomerTableAdapter
    Friend WithEvents CustomerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents SNameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents NoteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BalanceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents QtyTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BillNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PNameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
End Class
