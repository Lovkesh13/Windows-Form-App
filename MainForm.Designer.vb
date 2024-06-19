<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnCreateNewSubmission = New System.Windows.Forms.Button()
        Me.btnViewSubmissions = New System.Windows.Forms.Button()
        Me.intro = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnCreateNewSubmission
        '
        Me.btnCreateNewSubmission.Location = New System.Drawing.Point(105, 187)
        Me.btnCreateNewSubmission.Name = "btnCreateNewSubmission"
        Me.btnCreateNewSubmission.Size = New System.Drawing.Size(247, 23)
        Me.btnCreateNewSubmission.TabIndex = 0
        Me.btnCreateNewSubmission.Text = "&Create New Submission (Press C)"
        Me.btnCreateNewSubmission.UseVisualStyleBackColor = True
        '
        'btnViewSubmissions
        '
        Me.btnViewSubmissions.Location = New System.Drawing.Point(470, 187)
        Me.btnViewSubmissions.Name = "btnViewSubmissions"
        Me.btnViewSubmissions.Size = New System.Drawing.Size(244, 23)
        Me.btnViewSubmissions.TabIndex = 1
        Me.btnViewSubmissions.Text = "&View Submissions (Press V)"
        Me.btnViewSubmissions.UseVisualStyleBackColor = True
        '
        'intro
        '
        Me.intro.Location = New System.Drawing.Point(91, 2)
        Me.intro.Name = "intro"
        Me.intro.Size = New System.Drawing.Size(267, 22)
        Me.intro.TabIndex = 2
        Me.intro.Text = "Lovkesh Barowalia, Slidely Task2"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.intro)
        Me.Controls.Add(Me.btnViewSubmissions)
        Me.Controls.Add(Me.btnCreateNewSubmission)
        Me.Name = "MainForm"
        Me.Text = "MainForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCreateNewSubmission As Button
    Friend WithEvents btnViewSubmissions As Button
    Friend WithEvents intro As TextBox
End Class
