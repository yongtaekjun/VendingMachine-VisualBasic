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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lbBalance = New System.Windows.Forms.Label()
        Me.pbQuater = New System.Windows.Forms.PictureBox()
        Me.pbLoonie = New System.Windows.Forms.PictureBox()
        Me.pbToonie = New System.Windows.Forms.PictureBox()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.lbDollarSign = New System.Windows.Forms.Label()
        Me.lblBalance = New System.Windows.Forms.Label()
        Me.pbDime = New System.Windows.Forms.PictureBox()
        Me.pbNickle = New System.Windows.Forms.PictureBox()
        Me.pbPenny = New System.Windows.Forms.PictureBox()
        Me.btnA = New System.Windows.Forms.Button()
        Me.btnB = New System.Windows.Forms.Button()
        Me.btnC = New System.Windows.Forms.Button()
        Me.btnD = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.tbMessage = New System.Windows.Forms.TextBox()
        Me.lbOrder = New System.Windows.Forms.Label()
        CType(Me.pbQuater, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbLoonie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbToonie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbDime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbNickle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbPenny, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbBalance
        '
        Me.lbBalance.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbBalance.BackColor = System.Drawing.Color.Black
        Me.lbBalance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbBalance.Font = New System.Drawing.Font("Franklin Gothic Medium", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbBalance.ForeColor = System.Drawing.Color.Yellow
        Me.lbBalance.Location = New System.Drawing.Point(479, 105)
        Me.lbBalance.Name = "lbBalance"
        Me.lbBalance.Size = New System.Drawing.Size(109, 32)
        Me.lbBalance.TabIndex = 5
        Me.lbBalance.Text = "0.00"
        Me.lbBalance.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'pbQuater
        '
        Me.pbQuater.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.pbQuater.Image = CType(resources.GetObject("pbQuater.Image"), System.Drawing.Image)
        Me.pbQuater.Location = New System.Drawing.Point(530, 159)
        Me.pbQuater.Name = "pbQuater"
        Me.pbQuater.Size = New System.Drawing.Size(45, 46)
        Me.pbQuater.TabIndex = 6
        Me.pbQuater.TabStop = False
        '
        'pbLoonie
        '
        Me.pbLoonie.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.pbLoonie.Image = CType(resources.GetObject("pbLoonie.Image"), System.Drawing.Image)
        Me.pbLoonie.Location = New System.Drawing.Point(479, 159)
        Me.pbLoonie.Name = "pbLoonie"
        Me.pbLoonie.Size = New System.Drawing.Size(45, 46)
        Me.pbLoonie.TabIndex = 7
        Me.pbLoonie.TabStop = False
        '
        'pbToonie
        '
        Me.pbToonie.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.pbToonie.Image = CType(resources.GetObject("pbToonie.Image"), System.Drawing.Image)
        Me.pbToonie.Location = New System.Drawing.Point(428, 159)
        Me.pbToonie.Name = "pbToonie"
        Me.pbToonie.Size = New System.Drawing.Size(45, 46)
        Me.pbToonie.TabIndex = 8
        Me.pbToonie.TabStop = False
        '
        'btnStop
        '
        Me.btnStop.BackColor = System.Drawing.Color.Lime
        Me.btnStop.Location = New System.Drawing.Point(454, 273)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(96, 46)
        Me.btnStop.TabIndex = 9
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = False
        '
        'lbDollarSign
        '
        Me.lbDollarSign.AutoSize = True
        Me.lbDollarSign.BackColor = System.Drawing.Color.Black
        Me.lbDollarSign.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbDollarSign.Font = New System.Drawing.Font("Franklin Gothic Medium", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDollarSign.ForeColor = System.Drawing.Color.Yellow
        Me.lbDollarSign.Location = New System.Drawing.Point(428, 105)
        Me.lbDollarSign.Name = "lbDollarSign"
        Me.lbDollarSign.Size = New System.Drawing.Size(37, 32)
        Me.lbDollarSign.TabIndex = 11
        Me.lbDollarSign.Text = "$ "
        '
        'lblBalance
        '
        Me.lblBalance.AutoSize = True
        Me.lblBalance.BackColor = System.Drawing.Color.Black
        Me.lblBalance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBalance.Font = New System.Drawing.Font("Franklin Gothic Medium", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBalance.ForeColor = System.Drawing.Color.Yellow
        Me.lblBalance.Location = New System.Drawing.Point(441, 64)
        Me.lblBalance.Name = "lblBalance"
        Me.lblBalance.Size = New System.Drawing.Size(120, 32)
        Me.lblBalance.TabIndex = 14
        Me.lblBalance.Text = " Balance "
        '
        'pbDime
        '
        Me.pbDime.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.pbDime.Image = CType(resources.GetObject("pbDime.Image"), System.Drawing.Image)
        Me.pbDime.Location = New System.Drawing.Point(428, 212)
        Me.pbDime.Name = "pbDime"
        Me.pbDime.Size = New System.Drawing.Size(45, 46)
        Me.pbDime.TabIndex = 15
        Me.pbDime.TabStop = False
        '
        'pbNickle
        '
        Me.pbNickle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.pbNickle.Image = CType(resources.GetObject("pbNickle.Image"), System.Drawing.Image)
        Me.pbNickle.Location = New System.Drawing.Point(479, 212)
        Me.pbNickle.Name = "pbNickle"
        Me.pbNickle.Size = New System.Drawing.Size(45, 46)
        Me.pbNickle.TabIndex = 16
        Me.pbNickle.TabStop = False
        '
        'pbPenny
        '
        Me.pbPenny.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.pbPenny.Image = CType(resources.GetObject("pbPenny.Image"), System.Drawing.Image)
        Me.pbPenny.Location = New System.Drawing.Point(530, 212)
        Me.pbPenny.Name = "pbPenny"
        Me.pbPenny.Size = New System.Drawing.Size(45, 46)
        Me.pbPenny.TabIndex = 17
        Me.pbPenny.TabStop = False
        '
        'btnA
        '
        Me.btnA.Location = New System.Drawing.Point(441, 380)
        Me.btnA.Name = "btnA"
        Me.btnA.Size = New System.Drawing.Size(24, 23)
        Me.btnA.TabIndex = 18
        Me.btnA.Text = "A"
        Me.btnA.UseVisualStyleBackColor = True
        '
        'btnB
        '
        Me.btnB.Location = New System.Drawing.Point(471, 380)
        Me.btnB.Name = "btnB"
        Me.btnB.Size = New System.Drawing.Size(31, 23)
        Me.btnB.TabIndex = 19
        Me.btnB.Text = "B"
        Me.btnB.UseVisualStyleBackColor = True
        '
        'btnC
        '
        Me.btnC.Location = New System.Drawing.Point(508, 380)
        Me.btnC.Name = "btnC"
        Me.btnC.Size = New System.Drawing.Size(31, 23)
        Me.btnC.TabIndex = 20
        Me.btnC.Text = "C"
        Me.btnC.UseVisualStyleBackColor = True
        '
        'btnD
        '
        Me.btnD.Location = New System.Drawing.Point(545, 380)
        Me.btnD.Name = "btnD"
        Me.btnD.Size = New System.Drawing.Size(31, 23)
        Me.btnD.TabIndex = 21
        Me.btnD.Text = "D"
        Me.btnD.UseVisualStyleBackColor = True
        '
        'btn4
        '
        Me.btn4.Location = New System.Drawing.Point(545, 416)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(31, 23)
        Me.btn4.TabIndex = 25
        Me.btn4.Text = "4"
        Me.btn4.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.Location = New System.Drawing.Point(508, 416)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(31, 23)
        Me.btn3.TabIndex = 24
        Me.btn3.Text = "3"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.Location = New System.Drawing.Point(471, 416)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(31, 23)
        Me.btn2.TabIndex = 23
        Me.btn2.Text = "2"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(441, 416)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(24, 23)
        Me.btn1.TabIndex = 22
        Me.btn1.Text = "1"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'tbMessage
        '
        Me.tbMessage.BackColor = System.Drawing.Color.Lime
        Me.tbMessage.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbMessage.Location = New System.Drawing.Point(94, 595)
        Me.tbMessage.Multiline = True
        Me.tbMessage.Name = "tbMessage"
        Me.tbMessage.ReadOnly = True
        Me.tbMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.tbMessage.Size = New System.Drawing.Size(512, 158)
        Me.tbMessage.TabIndex = 27
        Me.tbMessage.TabStop = False
        '
        'lbOrder
        '
        Me.lbOrder.AutoSize = True
        Me.lbOrder.BackColor = System.Drawing.Color.Black
        Me.lbOrder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbOrder.Font = New System.Drawing.Font("Franklin Gothic Medium", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbOrder.ForeColor = System.Drawing.Color.Yellow
        Me.lbOrder.Location = New System.Drawing.Point(464, 345)
        Me.lbOrder.Name = "lbOrder"
        Me.lbOrder.Size = New System.Drawing.Size(77, 32)
        Me.lbOrder.TabIndex = 28
        Me.lbOrder.Text = "Order"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Navy
        Me.ClientSize = New System.Drawing.Size(668, 774)
        Me.Controls.Add(Me.lbOrder)
        Me.Controls.Add(Me.tbMessage)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.btnD)
        Me.Controls.Add(Me.btnC)
        Me.Controls.Add(Me.btnB)
        Me.Controls.Add(Me.btnA)
        Me.Controls.Add(Me.pbPenny)
        Me.Controls.Add(Me.pbNickle)
        Me.Controls.Add(Me.pbDime)
        Me.Controls.Add(Me.lblBalance)
        Me.Controls.Add(Me.lbDollarSign)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.pbToonie)
        Me.Controls.Add(Me.pbLoonie)
        Me.Controls.Add(Me.pbQuater)
        Me.Controls.Add(Me.lbBalance)
        Me.Name = "Form1"
        Me.Text = "Vending Machine"
        CType(Me.pbQuater, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbLoonie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbToonie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbDime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbNickle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbPenny, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbBalance As Label
    Friend WithEvents pbQuater As PictureBox
    Friend WithEvents pbLoonie As PictureBox
    Friend WithEvents pbToonie As PictureBox
    Friend WithEvents btnStop As Button
    Protected WithEvents lblBalance As Label
    Friend WithEvents pbDime As PictureBox
    Friend WithEvents pbNickle As PictureBox
    Friend WithEvents pbPenny As PictureBox
    Friend WithEvents btnA As Button
    Friend WithEvents btnB As Button
    Friend WithEvents btnC As Button
    Friend WithEvents btnD As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn1 As Button
    Protected WithEvents lbDollarSign As Label
    Friend WithEvents tbMessage As TextBox
    Protected WithEvents lbOrder As Label
End Class
