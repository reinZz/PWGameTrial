<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmScenario
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
        Me.btnFinish = New System.Windows.Forms.Button()
        Me.lblQuestion = New System.Windows.Forms.Label()
        Me.btnO1 = New System.Windows.Forms.Button()
        Me.btnO2 = New System.Windows.Forms.Button()
        Me.btnO3 = New System.Windows.Forms.Button()
        Me.btnO4 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnFinish
        '
        Me.btnFinish.Enabled = False
        Me.btnFinish.Location = New System.Drawing.Point(722, 484)
        Me.btnFinish.Name = "btnFinish"
        Me.btnFinish.Size = New System.Drawing.Size(150, 65)
        Me.btnFinish.TabIndex = 0
        Me.btnFinish.Text = "Finish"
        Me.btnFinish.UseVisualStyleBackColor = True
        '
        'lblQuestion
        '
        Me.lblQuestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblQuestion.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestion.Location = New System.Drawing.Point(12, 9)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(860, 160)
        Me.lblQuestion.TabIndex = 1
        Me.lblQuestion.Text = "lblQuestion"
        '
        'btnO1
        '
        Me.btnO1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnO1.Location = New System.Drawing.Point(12, 172)
        Me.btnO1.Name = "btnO1"
        Me.btnO1.Size = New System.Drawing.Size(425, 150)
        Me.btnO1.TabIndex = 2
        Me.btnO1.TabStop = False
        Me.btnO1.Text = "btnO1"
        Me.btnO1.UseVisualStyleBackColor = True
        '
        'btnO2
        '
        Me.btnO2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnO2.Location = New System.Drawing.Point(447, 172)
        Me.btnO2.Name = "btnO2"
        Me.btnO2.Size = New System.Drawing.Size(425, 150)
        Me.btnO2.TabIndex = 3
        Me.btnO2.TabStop = False
        Me.btnO2.Text = "btnO2"
        Me.btnO2.UseVisualStyleBackColor = True
        '
        'btnO3
        '
        Me.btnO3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnO3.Location = New System.Drawing.Point(12, 328)
        Me.btnO3.Name = "btnO3"
        Me.btnO3.Size = New System.Drawing.Size(425, 150)
        Me.btnO3.TabIndex = 4
        Me.btnO3.TabStop = False
        Me.btnO3.Text = "btnO3"
        Me.btnO3.UseVisualStyleBackColor = True
        '
        'btnO4
        '
        Me.btnO4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnO4.Location = New System.Drawing.Point(447, 328)
        Me.btnO4.Name = "btnO4"
        Me.btnO4.Size = New System.Drawing.Size(425, 150)
        Me.btnO4.TabIndex = 5
        Me.btnO4.TabStop = False
        Me.btnO4.Text = "btnO4"
        Me.btnO4.UseVisualStyleBackColor = True
        '
        'frmScenario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 561)
        Me.Controls.Add(Me.btnO4)
        Me.Controls.Add(Me.btnO3)
        Me.Controls.Add(Me.btnO2)
        Me.Controls.Add(Me.btnO1)
        Me.Controls.Add(Me.lblQuestion)
        Me.Controls.Add(Me.btnFinish)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmScenario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Scenario"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnFinish As Button
    Friend WithEvents lblQuestion As Label
    Friend WithEvents btnO1 As Button
    Friend WithEvents btnO2 As Button
    Friend WithEvents btnO3 As Button
    Friend WithEvents btnO4 As Button
End Class
