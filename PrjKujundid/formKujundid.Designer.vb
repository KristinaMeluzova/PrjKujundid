﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formKujundid
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
        Me.txtKylgB = New System.Windows.Forms.TextBox()
        Me.txtKylgA = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblTyyp = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtYmbermoot = New System.Windows.Forms.TextBox()
        Me.txtPindala = New System.Windows.Forms.TextBox()
        Me.Kujundid = New System.Windows.Forms.GroupBox()
        Me.bntRomb = New System.Windows.Forms.Button()
        Me.btnRoopkulik = New System.Windows.Forms.Button()
        Me.btnRistkylik = New System.Windows.Forms.Button()
        Me.btnRuut = New System.Windows.Forms.Button()
        Me.btnKolmnurk = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbTapsus = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtKorgus = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.Kujundid.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtKylgB
        '
        Me.txtKylgB.Location = New System.Drawing.Point(116, 138)
        Me.txtKylgB.Name = "txtKylgB"
        Me.txtKylgB.Size = New System.Drawing.Size(100, 20)
        Me.txtKylgB.TabIndex = 0
        '
        'txtKylgA
        '
        Me.txtKylgA.Location = New System.Drawing.Point(116, 112)
        Me.txtKylgA.Name = "txtKylgA"
        Me.txtKylgA.Size = New System.Drawing.Size(100, 20)
        Me.txtKylgA.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(88, 119)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(22, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "a ="
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(88, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "b ="
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtKorgus)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Location = New System.Drawing.Point(72, 91)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(180, 108)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Algandmed"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(69, 243)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Tulemused"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(88, 279)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Kujundi tüüp:"
        '
        'lblTyyp
        '
        Me.lblTyyp.AutoSize = True
        Me.lblTyyp.Location = New System.Drawing.Point(163, 279)
        Me.lblTyyp.Name = "lblTyyp"
        Me.lblTyyp.Size = New System.Drawing.Size(59, 13)
        Me.lblTyyp.TabIndex = 7
        Me.lblTyyp.Text = "määramata"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(113, 318)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Ümbermõõt"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(132, 350)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Pindala"
        '
        'txtYmbermoot
        '
        Me.txtYmbermoot.BackColor = System.Drawing.SystemColors.Window
        Me.txtYmbermoot.Enabled = False
        Me.txtYmbermoot.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtYmbermoot.Location = New System.Drawing.Point(180, 311)
        Me.txtYmbermoot.Name = "txtYmbermoot"
        Me.txtYmbermoot.Size = New System.Drawing.Size(100, 20)
        Me.txtYmbermoot.TabIndex = 10
        '
        'txtPindala
        '
        Me.txtPindala.BackColor = System.Drawing.SystemColors.Window
        Me.txtPindala.Enabled = False
        Me.txtPindala.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPindala.Location = New System.Drawing.Point(180, 343)
        Me.txtPindala.Name = "txtPindala"
        Me.txtPindala.Size = New System.Drawing.Size(100, 20)
        Me.txtPindala.TabIndex = 11
        '
        'Kujundid
        '
        Me.Kujundid.Controls.Add(Me.bntRomb)
        Me.Kujundid.Controls.Add(Me.btnRoopkulik)
        Me.Kujundid.Controls.Add(Me.btnRistkylik)
        Me.Kujundid.Controls.Add(Me.btnRuut)
        Me.Kujundid.Controls.Add(Me.btnKolmnurk)
        Me.Kujundid.Location = New System.Drawing.Point(449, 91)
        Me.Kujundid.Name = "Kujundid"
        Me.Kujundid.Size = New System.Drawing.Size(251, 201)
        Me.Kujundid.TabIndex = 12
        Me.Kujundid.TabStop = False
        Me.Kujundid.Text = "Kujundid"
        '
        'bntRomb
        '
        Me.bntRomb.Location = New System.Drawing.Point(71, 152)
        Me.bntRomb.Name = "bntRomb"
        Me.bntRomb.Size = New System.Drawing.Size(102, 23)
        Me.bntRomb.TabIndex = 16
        Me.bntRomb.Text = "Romb"
        Me.bntRomb.UseVisualStyleBackColor = True
        '
        'btnRoopkulik
        '
        Me.btnRoopkulik.Location = New System.Drawing.Point(71, 117)
        Me.btnRoopkulik.Name = "btnRoopkulik"
        Me.btnRoopkulik.Size = New System.Drawing.Size(102, 25)
        Me.btnRoopkulik.TabIndex = 15
        Me.btnRoopkulik.Text = "Rööpkülik"
        Me.btnRoopkulik.UseVisualStyleBackColor = True
        '
        'btnRistkylik
        '
        Me.btnRistkylik.Location = New System.Drawing.Point(71, 85)
        Me.btnRistkylik.Name = "btnRistkylik"
        Me.btnRistkylik.Size = New System.Drawing.Size(102, 23)
        Me.btnRistkylik.TabIndex = 13
        Me.btnRistkylik.Text = "Ristkülik"
        Me.btnRistkylik.UseVisualStyleBackColor = True
        '
        'btnRuut
        '
        Me.btnRuut.Location = New System.Drawing.Point(71, 56)
        Me.btnRuut.Name = "btnRuut"
        Me.btnRuut.Size = New System.Drawing.Size(102, 23)
        Me.btnRuut.TabIndex = 14
        Me.btnRuut.Text = "Ruut"
        Me.btnRuut.UseVisualStyleBackColor = True
        '
        'btnKolmnurk
        '
        Me.btnKolmnurk.Location = New System.Drawing.Point(71, 28)
        Me.btnKolmnurk.Name = "btnKolmnurk"
        Me.btnKolmnurk.Size = New System.Drawing.Size(102, 22)
        Me.btnKolmnurk.TabIndex = 13
        Me.btnKolmnurk.Text = "Kolmnurk"
        Me.btnKolmnurk.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 208)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Täpsus"
        '
        'cmbTapsus
        '
        Me.cmbTapsus.FormattingEnabled = True
        Me.cmbTapsus.Items.AddRange(New Object() {"0", "1", "2", "3"})
        Me.cmbTapsus.Location = New System.Drawing.Point(60, 205)
        Me.cmbTapsus.Name = "cmbTapsus"
        Me.cmbTapsus.Size = New System.Drawing.Size(121, 21)
        Me.cmbTapsus.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 76)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(22, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "h ="
        '
        'txtKorgus
        '
        Me.txtKorgus.Location = New System.Drawing.Point(44, 73)
        Me.txtKorgus.Name = "txtKorgus"
        Me.txtKorgus.Size = New System.Drawing.Size(100, 20)
        Me.txtKorgus.TabIndex = 15
        '
        'formKujundid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cmbTapsus)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtPindala)
        Me.Controls.Add(Me.txtYmbermoot)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblTyyp)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtKylgA)
        Me.Controls.Add(Me.txtKylgB)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Kujundid)
        Me.Name = "formKujundid"
        Me.RightToLeftLayout = True
        Me.Text = "Kujundid"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Kujundid.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtKylgB As TextBox
    Friend WithEvents txtKylgA As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblTyyp As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtYmbermoot As TextBox
    Friend WithEvents txtPindala As TextBox
    Friend WithEvents Kujundid As GroupBox
    Friend WithEvents btnRistkylik As Button
    Friend WithEvents btnRuut As Button
    Friend WithEvents btnKolmnurk As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents cmbTapsus As ComboBox
    Friend WithEvents btnRoopkulik As Button
    Friend WithEvents bntRomb As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents txtKorgus As TextBox
End Class
