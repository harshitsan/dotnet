﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class customer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(customer))
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtnum = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblOrderId = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(342, 135)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(236, 20)
        Me.txtname.TabIndex = 0
        '
        'txtnum
        '
        Me.txtnum.Location = New System.Drawing.Point(342, 176)
        Me.txtnum.Name = "txtnum"
        Me.txtnum.Size = New System.Drawing.Size(236, 20)
        Me.txtnum.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlText
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(294, 233)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(97, 47)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Proceed"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(138, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(184, 27)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Customer Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(138, 173)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(173, 27)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Phone number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(47, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 27)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Order Id:"
        '
        'lblOrderId
        '
        Me.lblOrderId.AutoSize = True
        Me.lblOrderId.BackColor = System.Drawing.Color.Transparent
        Me.lblOrderId.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrderId.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblOrderId.Location = New System.Drawing.Point(159, 25)
        Me.lblOrderId.Name = "lblOrderId"
        Me.lblOrderId.Size = New System.Drawing.Size(0, 27)
        Me.lblOrderId.TabIndex = 6
        '
        'customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(696, 341)
        Me.Controls.Add(Me.lblOrderId)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtnum)
        Me.Controls.Add(Me.txtname)
        Me.Name = "customer"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtname As TextBox
    Friend WithEvents txtnum As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblOrderId As Label
End Class
