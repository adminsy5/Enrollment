<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckBoxUnpaid = New System.Windows.Forms.CheckBox()
        Me.ButtonFind = New System.Windows.Forms.Button()
        Me.TextBoxFind = New System.Windows.Forms.TextBox()
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.ButtonUpdate = New System.Windows.Forms.Button()
        Me.ButtonRefresh = New System.Windows.Forms.Button()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.DateTimePickerText = New System.Windows.Forms.DateTimePicker()
        Me.TextBoxCourse = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBoxBalance = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxAmtPaid = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxDuration = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxEno = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridViewReader = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridViewReader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBoxUnpaid)
        Me.GroupBox1.Controls.Add(Me.ButtonFind)
        Me.GroupBox1.Controls.Add(Me.TextBoxFind)
        Me.GroupBox1.Controls.Add(Me.ButtonClear)
        Me.GroupBox1.Controls.Add(Me.ButtonDelete)
        Me.GroupBox1.Controls.Add(Me.ButtonUpdate)
        Me.GroupBox1.Controls.Add(Me.ButtonRefresh)
        Me.GroupBox1.Controls.Add(Me.ButtonSave)
        Me.GroupBox1.Controls.Add(Me.DateTimePickerText)
        Me.GroupBox1.Controls.Add(Me.TextBoxCourse)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.TextBoxBalance)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TextBoxAmtPaid)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TextBoxDuration)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBoxName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBoxEno)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(41, 44)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1466, 614)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Enrollment"
        '
        'CheckBoxUnpaid
        '
        Me.CheckBoxUnpaid.AutoSize = True
        Me.CheckBoxUnpaid.Location = New System.Drawing.Point(890, 333)
        Me.CheckBoxUnpaid.Name = "CheckBoxUnpaid"
        Me.CheckBoxUnpaid.Size = New System.Drawing.Size(267, 36)
        Me.CheckBoxUnpaid.TabIndex = 22
        Me.CheckBoxUnpaid.Text = "Unpaid Fees Student"
        Me.CheckBoxUnpaid.UseVisualStyleBackColor = True
        '
        'ButtonFind
        '
        Me.ButtonFind.Location = New System.Drawing.Point(772, 408)
        Me.ButtonFind.Name = "ButtonFind"
        Me.ButtonFind.Size = New System.Drawing.Size(150, 46)
        Me.ButtonFind.TabIndex = 21
        Me.ButtonFind.Text = "Find"
        Me.ButtonFind.UseVisualStyleBackColor = True
        '
        'TextBoxFind
        '
        Me.TextBoxFind.Location = New System.Drawing.Point(432, 412)
        Me.TextBoxFind.Name = "TextBoxFind"
        Me.TextBoxFind.Size = New System.Drawing.Size(325, 39)
        Me.TextBoxFind.TabIndex = 20
        '
        'ButtonClear
        '
        Me.ButtonClear.Location = New System.Drawing.Point(607, 507)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(150, 46)
        Me.ButtonClear.TabIndex = 19
        Me.ButtonClear.Text = "Clear"
        Me.ButtonClear.UseVisualStyleBackColor = True
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Location = New System.Drawing.Point(1149, 476)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(150, 46)
        Me.ButtonDelete.TabIndex = 18
        Me.ButtonDelete.Text = "Delete"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'ButtonUpdate
        '
        Me.ButtonUpdate.Location = New System.Drawing.Point(1149, 378)
        Me.ButtonUpdate.Name = "ButtonUpdate"
        Me.ButtonUpdate.Size = New System.Drawing.Size(150, 46)
        Me.ButtonUpdate.TabIndex = 17
        Me.ButtonUpdate.Text = "Update"
        Me.ButtonUpdate.UseVisualStyleBackColor = True
        '
        'ButtonRefresh
        '
        Me.ButtonRefresh.Location = New System.Drawing.Point(113, 476)
        Me.ButtonRefresh.Name = "ButtonRefresh"
        Me.ButtonRefresh.Size = New System.Drawing.Size(150, 46)
        Me.ButtonRefresh.TabIndex = 16
        Me.ButtonRefresh.Text = "Refresh"
        Me.ButtonRefresh.UseVisualStyleBackColor = True
        '
        'ButtonSave
        '
        Me.ButtonSave.Location = New System.Drawing.Point(113, 378)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(150, 46)
        Me.ButtonSave.TabIndex = 15
        Me.ButtonSave.Text = "Save"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'DateTimePickerText
        '
        Me.DateTimePickerText.Location = New System.Drawing.Point(246, 240)
        Me.DateTimePickerText.Name = "DateTimePickerText"
        Me.DateTimePickerText.Size = New System.Drawing.Size(400, 39)
        Me.DateTimePickerText.TabIndex = 14
        '
        'TextBoxCourse
        '
        Me.TextBoxCourse.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBoxCourse.Location = New System.Drawing.Point(1052, 95)
        Me.TextBoxCourse.Name = "TextBoxCourse"
        Me.TextBoxCourse.Size = New System.Drawing.Size(263, 39)
        Me.TextBoxCourse.TabIndex = 13
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(890, 98)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(88, 32)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Course"
        '
        'TextBoxBalance
        '
        Me.TextBoxBalance.Location = New System.Drawing.Point(607, 333)
        Me.TextBoxBalance.Name = "TextBoxBalance"
        Me.TextBoxBalance.Size = New System.Drawing.Size(200, 39)
        Me.TextBoxBalance.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(457, 340)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 32)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Balance (₹)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(106, 245)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 32)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Date"
        '
        'TextBoxAmtPaid
        '
        Me.TextBoxAmtPaid.Location = New System.Drawing.Point(1052, 228)
        Me.TextBoxAmtPaid.Name = "TextBoxAmtPaid"
        Me.TextBoxAmtPaid.Size = New System.Drawing.Size(263, 39)
        Me.TextBoxAmtPaid.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(829, 231)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(185, 32)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Amount Paid (₹)"
        '
        'TextBoxDuration
        '
        Me.TextBoxDuration.Location = New System.Drawing.Point(1052, 160)
        Me.TextBoxDuration.Name = "TextBoxDuration"
        Me.TextBoxDuration.Size = New System.Drawing.Size(263, 39)
        Me.TextBoxDuration.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(829, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(200, 32)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Duration (Month)"
        '
        'TextBoxName
        '
        Me.TextBoxName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBoxName.Location = New System.Drawing.Point(246, 163)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.Size = New System.Drawing.Size(511, 39)
        Me.TextBoxName.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(106, 170)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 32)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Name"
        '
        'TextBoxEno
        '
        Me.TextBoxEno.Location = New System.Drawing.Point(246, 98)
        Me.TextBoxEno.Name = "TextBoxEno"
        Me.TextBoxEno.Size = New System.Drawing.Size(257, 39)
        Me.TextBoxEno.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(106, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Eno"
        '
        'DataGridViewReader
        '
        Me.DataGridViewReader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewReader.ContextMenuStrip = Me.ContextMenuStrip1
        Me.DataGridViewReader.Location = New System.Drawing.Point(41, 680)
        Me.DataGridViewReader.Name = "DataGridViewReader"
        Me.DataGridViewReader.RowHeadersWidth = 82
        Me.DataGridViewReader.RowTemplate.Height = 41
        Me.DataGridViewReader.Size = New System.Drawing.Size(1466, 618)
        Me.DataGridViewReader.TabIndex = 1
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteToolStripMenuItem, Me.EditToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(159, 80)
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(158, 38)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(158, 38)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1555, 1358)
        Me.Controls.Add(Me.DataGridViewReader)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Admin"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridViewReader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBoxEno As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxCourse As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBoxBalance As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxAmtPaid As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxDuration As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTimePickerText As DateTimePicker
    Friend WithEvents DataGridViewReader As DataGridView
    Friend WithEvents ButtonClear As Button
    Friend WithEvents ButtonDelete As Button
    Friend WithEvents ButtonUpdate As Button
    Friend WithEvents ButtonRefresh As Button
    Friend WithEvents ButtonSave As Button
    Friend WithEvents ButtonFind As Button
    Friend WithEvents TextBoxFind As TextBox
    Friend WithEvents CheckBoxUnpaid As CheckBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
End Class
