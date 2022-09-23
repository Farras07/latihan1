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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.length = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CB_hari = New System.Windows.Forms.ComboBox()
        Me.Hari = New System.Windows.Forms.Label()
        Me.isiData = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GUB_Negatif = New System.Windows.Forms.Button()
        Me.length_negatif = New System.Windows.Forms.Button()
        Me.sisipkan = New System.Windows.Forms.Button()
        Me.Switch = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.length)
        Me.GroupBox1.Location = New System.Drawing.Point(30, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(379, 163)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(22, 101)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(272, 43)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "GetUpperBound"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'length
        '
        Me.length.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.length.Location = New System.Drawing.Point(22, 34)
        Me.length.Name = "length"
        Me.length.Size = New System.Drawing.Size(182, 43)
        Me.length.TabIndex = 0
        Me.length.Text = "Length"
        Me.length.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CB_hari)
        Me.GroupBox2.Controls.Add(Me.Hari)
        Me.GroupBox2.Controls.Add(Me.isiData)
        Me.GroupBox2.Location = New System.Drawing.Point(30, 220)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(379, 181)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'CB_hari
        '
        Me.CB_hari.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_hari.FormattingEnabled = True
        Me.CB_hari.Items.AddRange(New Object() {"Minggu", "Senin", "Selasa", "Rabu", "Kamis", "Jumat", "Sabtu"})
        Me.CB_hari.Location = New System.Drawing.Point(92, 66)
        Me.CB_hari.Name = "CB_hari"
        Me.CB_hari.Size = New System.Drawing.Size(272, 37)
        Me.CB_hari.TabIndex = 4
        '
        'Hari
        '
        Me.Hari.AutoSize = True
        Me.Hari.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hari.Location = New System.Drawing.Point(6, 66)
        Me.Hari.Name = "Hari"
        Me.Hari.Size = New System.Drawing.Size(57, 29)
        Me.Hari.TabIndex = 3
        Me.Hari.Text = "Hari"
        '
        'isiData
        '
        Me.isiData.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.isiData.Location = New System.Drawing.Point(44, 132)
        Me.isiData.Name = "isiData"
        Me.isiData.Size = New System.Drawing.Size(272, 43)
        Me.isiData.TabIndex = 2
        Me.isiData.Text = "Isi Data Hari"
        Me.isiData.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GUB_Negatif)
        Me.GroupBox3.Controls.Add(Me.length_negatif)
        Me.GroupBox3.Location = New System.Drawing.Point(424, 35)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(467, 366)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "GroupBox3"
        '
        'GUB_Negatif
        '
        Me.GUB_Negatif.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GUB_Negatif.Location = New System.Drawing.Point(40, 214)
        Me.GUB_Negatif.Name = "GUB_Negatif"
        Me.GUB_Negatif.Size = New System.Drawing.Size(405, 66)
        Me.GUB_Negatif.TabIndex = 2
        Me.GUB_Negatif.Text = "GetUpperBoundArray NEGATIF"
        Me.GUB_Negatif.UseVisualStyleBackColor = True
        '
        'length_negatif
        '
        Me.length_negatif.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.length_negatif.Location = New System.Drawing.Point(40, 97)
        Me.length_negatif.Name = "length_negatif"
        Me.length_negatif.Size = New System.Drawing.Size(405, 66)
        Me.length_negatif.TabIndex = 1
        Me.length_negatif.Text = "Length Array NEGATIF"
        Me.length_negatif.UseVisualStyleBackColor = True
        '
        'sisipkan
        '
        Me.sisipkan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sisipkan.Location = New System.Drawing.Point(317, 424)
        Me.sisipkan.Name = "sisipkan"
        Me.sisipkan.Size = New System.Drawing.Size(272, 43)
        Me.sisipkan.TabIndex = 3
        Me.sisipkan.Text = "Sisipkan Array"
        Me.sisipkan.UseVisualStyleBackColor = True
        '
        'Switch
        '
        Me.Switch.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Switch.Location = New System.Drawing.Point(303, 485)
        Me.Switch.Name = "Switch"
        Me.Switch.Size = New System.Drawing.Size(306, 64)
        Me.Switch.TabIndex = 4
        Me.Switch.Text = "Array Multidimensi"
        Me.Switch.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(903, 571)
        Me.Controls.Add(Me.Switch)
        Me.Controls.Add(Me.sisipkan)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents length As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Hari As Label
    Friend WithEvents isiData As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents CB_hari As ComboBox
    Friend WithEvents GUB_Negatif As Button
    Friend WithEvents length_negatif As Button
    Friend WithEvents sisipkan As Button
    Friend WithEvents Switch As Button
End Class
﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.length = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CB_hari = New System.Windows.Forms.ComboBox()
        Me.Hari = New System.Windows.Forms.Label()
        Me.isiData = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GUB_Negatif = New System.Windows.Forms.Button()
        Me.length_negatif = New System.Windows.Forms.Button()
        Me.sisipkan = New System.Windows.Forms.Button()
        Me.Switch = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.length)
        Me.GroupBox1.Location = New System.Drawing.Point(30, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(379, 163)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(22, 101)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(272, 43)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "GetUpperBound"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'length
        '
        Me.length.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.length.Location = New System.Drawing.Point(22, 34)
        Me.length.Name = "length"
        Me.length.Size = New System.Drawing.Size(182, 43)
        Me.length.TabIndex = 0
        Me.length.Text = "Length"
        Me.length.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CB_hari)
        Me.GroupBox2.Controls.Add(Me.Hari)
        Me.GroupBox2.Controls.Add(Me.isiData)
        Me.GroupBox2.Location = New System.Drawing.Point(30, 220)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(379, 181)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'CB_hari
        '
        Me.CB_hari.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_hari.FormattingEnabled = True
        Me.CB_hari.Items.AddRange(New Object() {"Minggu", "Senin", "Selasa", "Rabu", "Kamis", "Jumat", "Sabtu"})
        Me.CB_hari.Location = New System.Drawing.Point(92, 66)
        Me.CB_hari.Name = "CB_hari"
        Me.CB_hari.Size = New System.Drawing.Size(272, 37)
        Me.CB_hari.TabIndex = 4
        '
        'Hari
        '
        Me.Hari.AutoSize = True
        Me.Hari.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hari.Location = New System.Drawing.Point(6, 66)
        Me.Hari.Name = "Hari"
        Me.Hari.Size = New System.Drawing.Size(57, 29)
        Me.Hari.TabIndex = 3
        Me.Hari.Text = "Hari"
        '
        'isiData
        '
        Me.isiData.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.isiData.Location = New System.Drawing.Point(44, 132)
        Me.isiData.Name = "isiData"
        Me.isiData.Size = New System.Drawing.Size(272, 43)
        Me.isiData.TabIndex = 2
        Me.isiData.Text = "Isi Data Hari"
        Me.isiData.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GUB_Negatif)
        Me.GroupBox3.Controls.Add(Me.length_negatif)
        Me.GroupBox3.Location = New System.Drawing.Point(424, 35)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(467, 366)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "GroupBox3"
        '
        'GUB_Negatif
        '
        Me.GUB_Negatif.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GUB_Negatif.Location = New System.Drawing.Point(40, 214)
        Me.GUB_Negatif.Name = "GUB_Negatif"
        Me.GUB_Negatif.Size = New System.Drawing.Size(405, 66)
        Me.GUB_Negatif.TabIndex = 2
        Me.GUB_Negatif.Text = "GetUpperBoundArray NEGATIF"
        Me.GUB_Negatif.UseVisualStyleBackColor = True
        '
        'length_negatif
        '
        Me.length_negatif.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.length_negatif.Location = New System.Drawing.Point(40, 97)
        Me.length_negatif.Name = "length_negatif"
        Me.length_negatif.Size = New System.Drawing.Size(405, 66)
        Me.length_negatif.TabIndex = 1
        Me.length_negatif.Text = "Length Array NEGATIF"
        Me.length_negatif.UseVisualStyleBackColor = True
        '
        'sisipkan
        '
        Me.sisipkan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sisipkan.Location = New System.Drawing.Point(317, 424)
        Me.sisipkan.Name = "sisipkan"
        Me.sisipkan.Size = New System.Drawing.Size(272, 43)
        Me.sisipkan.TabIndex = 3
        Me.sisipkan.Text = "Sisipkan Array"
        Me.sisipkan.UseVisualStyleBackColor = True
        '
        'Switch
        '
        Me.Switch.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Switch.Location = New System.Drawing.Point(303, 485)
        Me.Switch.Name = "Switch"
        Me.Switch.Size = New System.Drawing.Size(306, 64)
        Me.Switch.TabIndex = 4
        Me.Switch.Text = "Array Multidimensi"
        Me.Switch.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(903, 571)
        Me.Controls.Add(Me.Switch)
        Me.Controls.Add(Me.sisipkan)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents length As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Hari As Label
    Friend WithEvents isiData As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents CB_hari As ComboBox
    Friend WithEvents GUB_Negatif As Button
    Friend WithEvents length_negatif As Button
    Friend WithEvents sisipkan As Button
    Friend WithEvents Switch As Button
End Class
