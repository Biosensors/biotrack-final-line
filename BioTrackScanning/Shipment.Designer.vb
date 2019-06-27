<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Shipment
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim configurationAppSettings As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader
        Me.txtsrno1 = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtBESA = New System.Windows.Forms.TextBox
        Me.txtBIT = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtWono = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.tbShipment = New System.Windows.Forms.TabControl
        Me.TabPage7 = New System.Windows.Forms.TabPage
        Me.dgBIT = New System.Windows.Forms.DataGrid
        Me.TabPage8 = New System.Windows.Forms.TabPage
        Me.dgBESA = New System.Windows.Forms.DataGrid
        Me.btnClose = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.tbShipment.SuspendLayout()
        Me.TabPage7.SuspendLayout()
        CType(Me.dgBIT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage8.SuspendLayout()
        CType(Me.dgBESA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtsrno1
        '
        Me.txtsrno1.BackColor = System.Drawing.SystemColors.Window
        Me.txtsrno1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsrno1.ForeColor = System.Drawing.SystemColors.GrayText
        Me.txtsrno1.Location = New System.Drawing.Point(254, 394)
        Me.txtsrno1.MaxLength = 20
        Me.txtsrno1.Name = "txtsrno1"
        Me.txtsrno1.Size = New System.Drawing.Size(216, 29)
        Me.txtsrno1.TabIndex = 6
        Me.txtsrno1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.Controls.Add(Me.txtBESA)
        Me.GroupBox1.Controls.Add(Me.txtBIT)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtWono)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.tbShipment)
        Me.GroupBox1.Controls.Add(Me.txtsrno1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(701, 435)
        Me.GroupBox1.TabIndex = 100
        Me.GroupBox1.TabStop = False
        '
        'txtBESA
        '
        Me.txtBESA.BackColor = System.Drawing.SystemColors.Control
        Me.txtBESA.Location = New System.Drawing.Point(457, 27)
        Me.txtBESA.MaxLength = 10
        Me.txtBESA.Name = "txtBESA"
        Me.txtBESA.ReadOnly = True
        Me.txtBESA.Size = New System.Drawing.Size(74, 22)
        Me.txtBESA.TabIndex = 3
        '
        'txtBIT
        '
        Me.txtBIT.BackColor = System.Drawing.SystemColors.Control
        Me.txtBIT.Location = New System.Drawing.Point(317, 27)
        Me.txtBIT.MaxLength = 10
        Me.txtBIT.Name = "txtBIT"
        Me.txtBIT.ReadOnly = True
        Me.txtBIT.Size = New System.Drawing.Size(74, 22)
        Me.txtBIT.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(281, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 16)
        Me.Label3.TabIndex = 81
        Me.Label3.Text = "BIT"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(404, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 82
        Me.Label2.Text = "BESA"
        '
        'txtWono
        '
        Me.txtWono.BackColor = System.Drawing.SystemColors.Control
        Me.txtWono.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtWono.Location = New System.Drawing.Point(128, 26)
        Me.txtWono.MaxLength = 12
        Me.txtWono.Name = "txtWono"
        Me.txtWono.ReadOnly = True
        Me.txtWono.Size = New System.Drawing.Size(142, 22)
        Me.txtWono.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 16)
        Me.Label1.TabIndex = 78
        Me.Label1.Text = "WorkOrder No"
        '
        'tbShipment
        '
        Me.tbShipment.Controls.Add(Me.TabPage7)
        Me.tbShipment.Controls.Add(Me.TabPage8)
        Me.tbShipment.Location = New System.Drawing.Point(12, 68)
        Me.tbShipment.Name = "tbShipment"
        Me.tbShipment.SelectedIndex = 0
        Me.tbShipment.Size = New System.Drawing.Size(678, 314)
        Me.tbShipment.TabIndex = 77
        '
        'TabPage7
        '
        Me.TabPage7.BackColor = System.Drawing.Color.PaleGreen
        Me.TabPage7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage7.Controls.Add(Me.dgBIT)
        Me.TabPage7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage7.ForeColor = System.Drawing.Color.Green
        Me.TabPage7.ImageIndex = CType(configurationAppSettings.GetValue("TabPage1.ImageIndex", GetType(Integer)), Integer)
        Me.TabPage7.Location = New System.Drawing.Point(4, 25)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Size = New System.Drawing.Size(670, 285)
        Me.TabPage7.TabIndex = 0
        Me.TabPage7.Text = "BIT"
        '
        'dgBIT
        '
        Me.dgBIT.AlternatingBackColor = System.Drawing.Color.LightCyan
        Me.dgBIT.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgBIT.CaptionBackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgBIT.CaptionForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgBIT.CaptionText = "BIT"
        Me.dgBIT.DataMember = ""
        Me.dgBIT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.dgBIT.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.dgBIT.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgBIT.Location = New System.Drawing.Point(9, 9)
        Me.dgBIT.Name = "dgBIT"
        Me.dgBIT.PreferredColumnWidth = 90
        Me.dgBIT.ReadOnly = True
        Me.dgBIT.Size = New System.Drawing.Size(649, 261)
        Me.dgBIT.TabIndex = 4
        '
        'TabPage8
        '
        Me.TabPage8.BackColor = System.Drawing.Color.Coral
        Me.TabPage8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage8.Controls.Add(Me.dgBESA)
        Me.TabPage8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage8.ForeColor = System.Drawing.Color.Snow
        Me.TabPage8.Location = New System.Drawing.Point(4, 25)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Size = New System.Drawing.Size(670, 285)
        Me.TabPage8.TabIndex = 1
        Me.TabPage8.Text = "BESA"
        '
        'dgBESA
        '
        Me.dgBESA.AlternatingBackColor = System.Drawing.Color.LightCyan
        Me.dgBESA.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgBESA.CaptionBackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgBESA.CaptionForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgBESA.CaptionText = "BESA"
        Me.dgBESA.DataMember = ""
        Me.dgBESA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.dgBESA.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.dgBESA.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgBESA.Location = New System.Drawing.Point(9, 8)
        Me.dgBESA.Name = "dgBESA"
        Me.dgBESA.PreferredColumnWidth = 90
        Me.dgBESA.ReadOnly = True
        Me.dgBESA.Size = New System.Drawing.Size(648, 263)
        Me.dgBESA.TabIndex = 5
        '
        'btnClose
        '
        Me.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnClose.Location = New System.Drawing.Point(322, 461)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(125, 25)
        Me.btnClose.TabIndex = 7
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Shipment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(741, 500)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Shipment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Shipment Details"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tbShipment.ResumeLayout(False)
        Me.TabPage7.ResumeLayout(False)
        CType(Me.dgBIT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage8.ResumeLayout(False)
        CType(Me.dgBESA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtsrno1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tbShipment As System.Windows.Forms.TabControl
    Friend WithEvents TabPage7 As System.Windows.Forms.TabPage
    Friend WithEvents dgBIT As System.Windows.Forms.DataGrid
    Friend WithEvents TabPage8 As System.Windows.Forms.TabPage
    Friend WithEvents dgBESA As System.Windows.Forms.DataGrid
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents txtBESA As System.Windows.Forms.TextBox
    Friend WithEvents txtBIT As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtWono As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
