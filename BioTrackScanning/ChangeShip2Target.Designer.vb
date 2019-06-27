<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangeShip2Target
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
        Me.lblworkorder = New System.Windows.Forms.Label
        Me.lblSerialNo = New System.Windows.Forms.Label
        Me.lblcurrentshipTo = New System.Windows.Forms.Label
        Me.grpboxCurrent = New System.Windows.Forms.GroupBox
        Me.txtCurrWorkOrder = New System.Windows.Forms.TextBox
        Me.txtSerialNo = New System.Windows.Forms.TextBox
        Me.txtCurrShipToTarget = New System.Windows.Forms.TextBox
        Me.grpboxNew = New System.Windows.Forms.GroupBox
        Me.lblnewShipTo = New System.Windows.Forms.Label
        Me.cmbShipTo = New System.Windows.Forms.ComboBox
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.txtOprn = New System.Windows.Forms.TextBox
        Me.lbloprn = New System.Windows.Forms.Label
        Me.lblLogonUser = New System.Windows.Forms.Label
        Me.grpboxCurrent.SuspendLayout()
        Me.grpboxNew.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblworkorder
        '
        Me.lblworkorder.AutoSize = True
        Me.lblworkorder.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblworkorder.Location = New System.Drawing.Point(21, 58)
        Me.lblworkorder.Name = "lblworkorder"
        Me.lblworkorder.Size = New System.Drawing.Size(102, 20)
        Me.lblworkorder.TabIndex = 0
        Me.lblworkorder.Text = "Workorder "
        '
        'lblSerialNo
        '
        Me.lblSerialNo.AutoSize = True
        Me.lblSerialNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSerialNo.Location = New System.Drawing.Point(21, 95)
        Me.lblSerialNo.Name = "lblSerialNo"
        Me.lblSerialNo.Size = New System.Drawing.Size(87, 20)
        Me.lblSerialNo.TabIndex = 1
        Me.lblSerialNo.Text = "Serial No"
        '
        'lblcurrentshipTo
        '
        Me.lblcurrentshipTo.AutoSize = True
        Me.lblcurrentshipTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcurrentshipTo.Location = New System.Drawing.Point(21, 131)
        Me.lblcurrentshipTo.Name = "lblcurrentshipTo"
        Me.lblcurrentshipTo.Size = New System.Drawing.Size(73, 20)
        Me.lblcurrentshipTo.TabIndex = 2
        Me.lblcurrentshipTo.Text = "Ship To"
        '
        'grpboxCurrent
        '
        Me.grpboxCurrent.Controls.Add(Me.txtOprn)
        Me.grpboxCurrent.Controls.Add(Me.lbloprn)
        Me.grpboxCurrent.Controls.Add(Me.txtCurrShipToTarget)
        Me.grpboxCurrent.Controls.Add(Me.txtSerialNo)
        Me.grpboxCurrent.Controls.Add(Me.txtCurrWorkOrder)
        Me.grpboxCurrent.Controls.Add(Me.lblSerialNo)
        Me.grpboxCurrent.Controls.Add(Me.lblcurrentshipTo)
        Me.grpboxCurrent.Controls.Add(Me.lblworkorder)
        Me.grpboxCurrent.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpboxCurrent.Location = New System.Drawing.Point(24, 13)
        Me.grpboxCurrent.Name = "grpboxCurrent"
        Me.grpboxCurrent.Size = New System.Drawing.Size(471, 178)
        Me.grpboxCurrent.TabIndex = 3
        Me.grpboxCurrent.TabStop = False
        Me.grpboxCurrent.Text = "Current Values"
        '
        'txtCurrWorkOrder
        '
        Me.txtCurrWorkOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurrWorkOrder.Location = New System.Drawing.Point(150, 58)
        Me.txtCurrWorkOrder.Name = "txtCurrWorkOrder"
        Me.txtCurrWorkOrder.Size = New System.Drawing.Size(216, 27)
        Me.txtCurrWorkOrder.TabIndex = 3
        '
        'txtSerialNo
        '
        Me.txtSerialNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSerialNo.Location = New System.Drawing.Point(150, 95)
        Me.txtSerialNo.Name = "txtSerialNo"
        Me.txtSerialNo.Size = New System.Drawing.Size(216, 27)
        Me.txtSerialNo.TabIndex = 4
        '
        'txtCurrShipToTarget
        '
        Me.txtCurrShipToTarget.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurrShipToTarget.Location = New System.Drawing.Point(150, 131)
        Me.txtCurrShipToTarget.Name = "txtCurrShipToTarget"
        Me.txtCurrShipToTarget.Size = New System.Drawing.Size(216, 27)
        Me.txtCurrShipToTarget.TabIndex = 5
        '
        'grpboxNew
        '
        Me.grpboxNew.Controls.Add(Me.cmbShipTo)
        Me.grpboxNew.Controls.Add(Me.lblnewShipTo)
        Me.grpboxNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpboxNew.Location = New System.Drawing.Point(24, 197)
        Me.grpboxNew.Name = "grpboxNew"
        Me.grpboxNew.Size = New System.Drawing.Size(471, 91)
        Me.grpboxNew.TabIndex = 4
        Me.grpboxNew.TabStop = False
        Me.grpboxNew.Text = "New Values"
        '
        'lblnewShipTo
        '
        Me.lblnewShipTo.AutoSize = True
        Me.lblnewShipTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnewShipTo.Location = New System.Drawing.Point(21, 40)
        Me.lblnewShipTo.Name = "lblnewShipTo"
        Me.lblnewShipTo.Size = New System.Drawing.Size(73, 20)
        Me.lblnewShipTo.TabIndex = 6
        Me.lblnewShipTo.Text = "Ship To"
        '
        'cmbShipTo
        '
        Me.cmbShipTo.FormattingEnabled = True
        Me.cmbShipTo.Location = New System.Drawing.Point(150, 34)
        Me.cmbShipTo.Name = "cmbShipTo"
        Me.cmbShipTo.Size = New System.Drawing.Size(216, 28)
        Me.cmbShipTo.TabIndex = 7
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(174, 306)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(85, 40)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(305, 306)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(85, 40)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'txtOprn
        '
        Me.txtOprn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOprn.Location = New System.Drawing.Point(150, 26)
        Me.txtOprn.Name = "txtOprn"
        Me.txtOprn.Size = New System.Drawing.Size(216, 27)
        Me.txtOprn.TabIndex = 7
        '
        'lbloprn
        '
        Me.lbloprn.AutoSize = True
        Me.lbloprn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbloprn.Location = New System.Drawing.Point(21, 26)
        Me.lbloprn.Name = "lbloprn"
        Me.lbloprn.Size = New System.Drawing.Size(91, 20)
        Me.lbloprn.TabIndex = 6
        Me.lbloprn.Text = "Operation"
        '
        'lblLogonUser
        '
        Me.lblLogonUser.AutoSize = True
        Me.lblLogonUser.Location = New System.Drawing.Point(24, 346)
        Me.lblLogonUser.Name = "lblLogonUser"
        Me.lblLogonUser.Size = New System.Drawing.Size(78, 17)
        Me.lblLogonUser.TabIndex = 7
        Me.lblLogonUser.Text = "LogonUser"
        Me.lblLogonUser.Visible = False
        '
        'ChangeShip2Target
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(521, 375)
        Me.Controls.Add(Me.lblLogonUser)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.grpboxNew)
        Me.Controls.Add(Me.grpboxCurrent)
        Me.Name = "ChangeShip2Target"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ChangeShip2Target"
        Me.grpboxCurrent.ResumeLayout(False)
        Me.grpboxCurrent.PerformLayout()
        Me.grpboxNew.ResumeLayout(False)
        Me.grpboxNew.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblworkorder As System.Windows.Forms.Label
    Friend WithEvents lblSerialNo As System.Windows.Forms.Label
    Friend WithEvents lblcurrentshipTo As System.Windows.Forms.Label
    Friend WithEvents grpboxCurrent As System.Windows.Forms.GroupBox
    Friend WithEvents txtCurrShipToTarget As System.Windows.Forms.TextBox
    Friend WithEvents txtSerialNo As System.Windows.Forms.TextBox
    Friend WithEvents txtCurrWorkOrder As System.Windows.Forms.TextBox
    Friend WithEvents grpboxNew As System.Windows.Forms.GroupBox
    Friend WithEvents lblnewShipTo As System.Windows.Forms.Label
    Friend WithEvents cmbShipTo As System.Windows.Forms.ComboBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents txtOprn As System.Windows.Forms.TextBox
    Friend WithEvents lbloprn As System.Windows.Forms.Label
    Friend WithEvents lblLogonUser As System.Windows.Forms.Label
End Class
