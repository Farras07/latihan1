<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.output = New System.Windows.Forms.GroupBox()
        Me.LV = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.wanita = New System.Windows.Forms.RadioButton()
        Me.laki = New System.Windows.Forms.RadioButton()
        Me.Telp = New System.Windows.Forms.TextBox()
        Me.nama = New System.Windows.Forms.TextBox()
        Me.npm = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tampil = New System.Windows.Forms.Button()
        Me.Tambah = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.output.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'output
        '
        Me.output.Controls.Add(Me.LV)
        Me.output.Location = New System.Drawing.Point(470, 12)
        Me.output.Name = "output"
        Me.output.Size = New System.Drawing.Size(638, 276)
        Me.output.TabIndex = 3
        Me.output.TabStop = False
        Me.output.Text = "Output"
        '
        'LV
        '
        Me.LV.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.LV.GridLines = True
        Me.LV.HideSelection = False
        Me.LV.Location = New System.Drawing.Point(20, 34)
        Me.LV.Name = "LV"
        Me.LV.Size = New System.Drawing.Size(603, 219)
        Me.LV.TabIndex = 0
        Me.LV.UseCompatibleStateImageBehavior = False
        Me.LV.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "NPM"
        Me.ColumnHeader1.Width = 150
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nama"
        Me.ColumnHeader2.Width = 180
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Jenis Kelamin"
        Me.ColumnHeader3.Width = 120
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "No Telp"
        Me.ColumnHeader4.Width = 150
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.wanita)
        Me.GroupBox1.Controls.Add(Me.laki)
        Me.GroupBox1.Controls.Add(Me.Telp)
        Me.GroupBox1.Controls.Add(Me.nama)
        Me.GroupBox1.Controls.Add(Me.npm)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(437, 276)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Input"
        '
        'wanita
        '
        Me.wanita.AutoSize = True
        Me.wanita.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wanita.Location = New System.Drawing.Point(223, 191)
        Me.wanita.Name = "wanita"
        Me.wanita.Size = New System.Drawing.Size(99, 29)
        Me.wanita.TabIndex = 8
        Me.wanita.TabStop = True
        Me.wanita.Text = "Wanita"
        Me.wanita.UseVisualStyleBackColor = True
        '
        'laki
        '
        Me.laki.AutoSize = True
        Me.laki.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.laki.Location = New System.Drawing.Point(223, 146)
        Me.laki.Name = "laki"
        Me.laki.Size = New System.Drawing.Size(109, 29)
        Me.laki.TabIndex = 7
        Me.laki.TabStop = True
        Me.laki.Text = "Laki-laki"
        Me.laki.UseVisualStyleBackColor = True
        '
        'Telp
        '
        Me.Telp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Telp.Location = New System.Drawing.Point(223, 241)
        Me.Telp.Multiline = True
        Me.Telp.Name = "Telp"
        Me.Telp.Size = New System.Drawing.Size(208, 29)
        Me.Telp.TabIndex = 6
        '
        'nama
        '
        Me.nama.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nama.Location = New System.Drawing.Point(223, 90)
        Me.nama.Multiline = True
        Me.nama.Name = "nama"
        Me.nama.Size = New System.Drawing.Size(208, 29)
        Me.nama.TabIndex = 5
        '
        'npm
        '
        Me.npm.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.npm.Location = New System.Drawing.Point(223, 34)
        Me.npm.Multiline = True
        Me.npm.Name = "npm"
        Me.npm.Size = New System.Drawing.Size(208, 29)
        Me.npm.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(17, 224)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 29)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Telp"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(17, 145)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(164, 29)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Jenis Kelamin"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(17, 90)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 29)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Nama"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(17, 34)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 29)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "NPM"
        '
        'tampil
        '
        Me.tampil.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tampil.Location = New System.Drawing.Point(34, 339)
        Me.tampil.Name = "tampil"
        Me.tampil.Size = New System.Drawing.Size(253, 103)
        Me.tampil.TabIndex = 5
        Me.tampil.Text = "Tampilkan Array (ReDim Preserve)"
        Me.tampil.UseVisualStyleBackColor = True
        '
        'Tambah
        '
        Me.Tambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tambah.Location = New System.Drawing.Point(370, 308)
        Me.Tambah.Name = "Tambah"
        Me.Tambah.Size = New System.Drawing.Size(235, 66)
        Me.Tambah.TabIndex = 6
        Me.Tambah.Text = "Tambah Array"
        Me.Tambah.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(370, 389)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(235, 97)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Tampilkan Array ReDim"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1120, 498)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Tambah)
        Me.Controls.Add(Me.tampil)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.output)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.output.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents output As GroupBox
    Friend WithEvents LV As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents wanita As RadioButton
    Friend WithEvents laki As RadioButton
    Friend WithEvents Telp As TextBox
    Friend WithEvents nama As TextBox
    Friend WithEvents npm As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents tampil As Button
    Friend WithEvents Tambah As Button
    Friend WithEvents Button1 As Button
End Class
