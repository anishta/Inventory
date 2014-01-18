<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.InputToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ProductDetailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CustomerDetailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ProductReceivedDetailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ProductIssueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OutputToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ProductIssuedReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CustomerWiseToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ProductWiseToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.AllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SupplierWiseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DateWiseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CustomerDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CalculatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NotepadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ProductDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuStrip1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InputToolStripMenuItem, Me.OutputToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.AboutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(117, 678)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'InputToolStripMenuItem
        '
        Me.InputToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductDetailToolStripMenuItem, Me.CustomerDetailToolStripMenuItem, Me.ProductReceivedDetailToolStripMenuItem, Me.ProductIssueToolStripMenuItem})
        Me.InputToolStripMenuItem.Font = New System.Drawing.Font("Imprint MT Shadow", 20.25!)
        Me.InputToolStripMenuItem.Name = "InputToolStripMenuItem"
        Me.InputToolStripMenuItem.Size = New System.Drawing.Size(110, 36)
        Me.InputToolStripMenuItem.Text = "Input"
        '
        'ProductDetailToolStripMenuItem
        '
        Me.ProductDetailToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ProductDetailToolStripMenuItem.Name = "ProductDetailToolStripMenuItem"
        Me.ProductDetailToolStripMenuItem.Size = New System.Drawing.Size(387, 36)
        Me.ProductDetailToolStripMenuItem.Text = "Product Detail"
        '
        'CustomerDetailToolStripMenuItem
        '
        Me.CustomerDetailToolStripMenuItem.Name = "CustomerDetailToolStripMenuItem"
        Me.CustomerDetailToolStripMenuItem.Size = New System.Drawing.Size(387, 36)
        Me.CustomerDetailToolStripMenuItem.Text = "Customer Detail"
        '
        'ProductReceivedDetailToolStripMenuItem
        '
        Me.ProductReceivedDetailToolStripMenuItem.Name = "ProductReceivedDetailToolStripMenuItem"
        Me.ProductReceivedDetailToolStripMenuItem.Size = New System.Drawing.Size(387, 36)
        Me.ProductReceivedDetailToolStripMenuItem.Text = "Product Received Detail"
        '
        'ProductIssueToolStripMenuItem
        '
        Me.ProductIssueToolStripMenuItem.Name = "ProductIssueToolStripMenuItem"
        Me.ProductIssueToolStripMenuItem.Size = New System.Drawing.Size(387, 36)
        Me.ProductIssueToolStripMenuItem.Text = "Product Issued Detail"
        '
        'OutputToolStripMenuItem
        '
        Me.OutputToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductIssuedReportsToolStripMenuItem, Me.SupplierWiseToolStripMenuItem, Me.CustomerDetailsToolStripMenuItem, Me.ProductDetailsToolStripMenuItem})
        Me.OutputToolStripMenuItem.Font = New System.Drawing.Font("Imprint MT Shadow", 20.25!)
        Me.OutputToolStripMenuItem.Margin = New System.Windows.Forms.Padding(0, 100, 0, 0)
        Me.OutputToolStripMenuItem.Name = "OutputToolStripMenuItem"
        Me.OutputToolStripMenuItem.Size = New System.Drawing.Size(110, 36)
        Me.OutputToolStripMenuItem.Text = "Output"
        '
        'ProductIssuedReportsToolStripMenuItem
        '
        Me.ProductIssuedReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomerWiseToolStripMenuItem1, Me.ProductWiseToolStripMenuItem1, Me.AllToolStripMenuItem})
        Me.ProductIssuedReportsToolStripMenuItem.Name = "ProductIssuedReportsToolStripMenuItem"
        Me.ProductIssuedReportsToolStripMenuItem.Size = New System.Drawing.Size(408, 36)
        Me.ProductIssuedReportsToolStripMenuItem.Text = "Product Issued Reports"
        '
        'CustomerWiseToolStripMenuItem1
        '
        Me.CustomerWiseToolStripMenuItem1.Name = "CustomerWiseToolStripMenuItem1"
        Me.CustomerWiseToolStripMenuItem1.Size = New System.Drawing.Size(282, 36)
        Me.CustomerWiseToolStripMenuItem1.Text = "Customer Wise"
        '
        'ProductWiseToolStripMenuItem1
        '
        Me.ProductWiseToolStripMenuItem1.Name = "ProductWiseToolStripMenuItem1"
        Me.ProductWiseToolStripMenuItem1.Size = New System.Drawing.Size(282, 36)
        Me.ProductWiseToolStripMenuItem1.Text = "Product Wise"
        '
        'AllToolStripMenuItem
        '
        Me.AllToolStripMenuItem.Name = "AllToolStripMenuItem"
        Me.AllToolStripMenuItem.Size = New System.Drawing.Size(282, 36)
        Me.AllToolStripMenuItem.Text = "Date Wise"
        '
        'SupplierWiseToolStripMenuItem
        '
        Me.SupplierWiseToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DateWiseToolStripMenuItem})
        Me.SupplierWiseToolStripMenuItem.Name = "SupplierWiseToolStripMenuItem"
        Me.SupplierWiseToolStripMenuItem.Size = New System.Drawing.Size(408, 36)
        Me.SupplierWiseToolStripMenuItem.Text = "Product Received Reports"
        '
        'DateWiseToolStripMenuItem
        '
        Me.DateWiseToolStripMenuItem.Name = "DateWiseToolStripMenuItem"
        Me.DateWiseToolStripMenuItem.Size = New System.Drawing.Size(224, 36)
        Me.DateWiseToolStripMenuItem.Text = "Date Wise"
        '
        'CustomerDetailsToolStripMenuItem
        '
        Me.CustomerDetailsToolStripMenuItem.Name = "CustomerDetailsToolStripMenuItem"
        Me.CustomerDetailsToolStripMenuItem.Size = New System.Drawing.Size(408, 36)
        Me.CustomerDetailsToolStripMenuItem.Text = "Customer Details"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculatorToolStripMenuItem, Me.NotepadToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Font = New System.Drawing.Font("Imprint MT Shadow", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolsToolStripMenuItem.Margin = New System.Windows.Forms.Padding(0, 100, 0, 0)
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(110, 36)
        Me.ToolsToolStripMenuItem.Text = "Tools"
        '
        'CalculatorToolStripMenuItem
        '
        Me.CalculatorToolStripMenuItem.Name = "CalculatorToolStripMenuItem"
        Me.CalculatorToolStripMenuItem.Size = New System.Drawing.Size(222, 36)
        Me.CalculatorToolStripMenuItem.Text = "Calculator"
        '
        'NotepadToolStripMenuItem
        '
        Me.NotepadToolStripMenuItem.Name = "NotepadToolStripMenuItem"
        Me.NotepadToolStripMenuItem.Size = New System.Drawing.Size(222, 36)
        Me.NotepadToolStripMenuItem.Text = "Notepad"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Font = New System.Drawing.Font("Imprint MT Shadow", 20.25!)
        Me.AboutToolStripMenuItem.Margin = New System.Windows.Forms.Padding(0, 100, 0, 0)
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(110, 36)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Font = New System.Drawing.Font("Imprint MT Shadow", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitToolStripMenuItem.Margin = New System.Windows.Forms.Padding(0, 100, 0, 0)
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(110, 36)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ProductDetailsToolStripMenuItem
        '
        Me.ProductDetailsToolStripMenuItem.Name = "ProductDetailsToolStripMenuItem"
        Me.ProductDetailsToolStripMenuItem.Size = New System.Drawing.Size(408, 36)
        Me.ProductDetailsToolStripMenuItem.Text = "Product Details"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(933, 678)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "Stock Management System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents InputToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductDetailToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomerDetailToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductReceivedDetailToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductIssueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OutputToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SupplierWiseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductIssuedReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomerWiseToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductWiseToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DateWiseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CalculatorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NotepadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomerDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
