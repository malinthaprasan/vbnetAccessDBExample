<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.textboxStdNameGet = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.textboxStdNameUpdate = New System.Windows.Forms.TextBox()
        Me.textboxMarksUpdate = New System.Windows.Forms.TextBox()
        Me.labelMarks = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.textboxStdNameAdd = New System.Windows.Forms.TextBox()
        Me.textboxMarksAdd = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.textboxStdNameDelete = New System.Windows.Forms.TextBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(35, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(166, 30)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Load And Show Database"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(35, 337)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(148, 29)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Show/Refresh"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(35, 66)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1031, 250)
        Me.DataGridView1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 395)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Get Data"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(592, 395)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Update Data"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 439)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Student Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(592, 439)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Student Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(34, 477)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Marks"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(592, 477)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Marks"
        '
        'textboxStdNameGet
        '
        Me.textboxStdNameGet.Location = New System.Drawing.Point(132, 436)
        Me.textboxStdNameGet.Name = "textboxStdNameGet"
        Me.textboxStdNameGet.Size = New System.Drawing.Size(100, 20)
        Me.textboxStdNameGet.TabIndex = 9
        Me.textboxStdNameGet.Text = "Thilan"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(132, 521)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Get"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(693, 521)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "Update"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'textboxStdNameUpdate
        '
        Me.textboxStdNameUpdate.Location = New System.Drawing.Point(691, 436)
        Me.textboxStdNameUpdate.Name = "textboxStdNameUpdate"
        Me.textboxStdNameUpdate.Size = New System.Drawing.Size(100, 20)
        Me.textboxStdNameUpdate.TabIndex = 12
        Me.textboxStdNameUpdate.Text = "Amanda"
        '
        'textboxMarksUpdate
        '
        Me.textboxMarksUpdate.Location = New System.Drawing.Point(691, 474)
        Me.textboxMarksUpdate.Name = "textboxMarksUpdate"
        Me.textboxMarksUpdate.Size = New System.Drawing.Size(100, 20)
        Me.textboxMarksUpdate.TabIndex = 13
        Me.textboxMarksUpdate.Text = "100"
        '
        'labelMarks
        '
        Me.labelMarks.AutoSize = True
        Me.labelMarks.Location = New System.Drawing.Point(129, 477)
        Me.labelMarks.Name = "labelMarks"
        Me.labelMarks.Size = New System.Drawing.Size(10, 13)
        Me.labelMarks.TabIndex = 14
        Me.labelMarks.Text = "-"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(311, 395)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Add Data"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(311, 478)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Marks"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(311, 440)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Student Name"
        '
        'textboxStdNameAdd
        '
        Me.textboxStdNameAdd.Location = New System.Drawing.Point(417, 437)
        Me.textboxStdNameAdd.Name = "textboxStdNameAdd"
        Me.textboxStdNameAdd.Size = New System.Drawing.Size(100, 20)
        Me.textboxStdNameAdd.TabIndex = 18
        Me.textboxStdNameAdd.Text = "Nimal"
        '
        'textboxMarksAdd
        '
        Me.textboxMarksAdd.Location = New System.Drawing.Point(417, 475)
        Me.textboxMarksAdd.Name = "textboxMarksAdd"
        Me.textboxMarksAdd.Size = New System.Drawing.Size(100, 20)
        Me.textboxMarksAdd.TabIndex = 19
        Me.textboxMarksAdd.Text = "33"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(417, 522)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 20
        Me.Button5.Text = "Add"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'textboxStdNameDelete
        '
        Me.textboxStdNameDelete.Location = New System.Drawing.Point(970, 436)
        Me.textboxStdNameDelete.Name = "textboxStdNameDelete"
        Me.textboxStdNameDelete.Size = New System.Drawing.Size(100, 20)
        Me.textboxStdNameDelete.TabIndex = 25
        Me.textboxStdNameDelete.Text = "Amanda"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(970, 492)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 24
        Me.Button6.Text = "Delete"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(871, 439)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 13)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Student Name"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(871, 395)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 13)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Delete Data"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1088, 547)
        Me.Controls.Add(Me.textboxStdNameDelete)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.textboxMarksAdd)
        Me.Controls.Add(Me.textboxStdNameAdd)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.labelMarks)
        Me.Controls.Add(Me.textboxMarksUpdate)
        Me.Controls.Add(Me.textboxStdNameUpdate)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.textboxStdNameGet)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents textboxStdNameGet As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents textboxStdNameUpdate As System.Windows.Forms.TextBox
    Friend WithEvents textboxMarksUpdate As System.Windows.Forms.TextBox
    Friend WithEvents labelMarks As System.Windows.Forms.Label
    Public WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents textboxStdNameAdd As System.Windows.Forms.TextBox
    Friend WithEvents textboxMarksAdd As System.Windows.Forms.TextBox
    Public WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents textboxStdNameDelete As System.Windows.Forms.TextBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label

End Class
