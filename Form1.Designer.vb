<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAngryBirdsVB
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.pcbCerdo1 = New System.Windows.Forms.PictureBox()
        Me.pcbPajaro = New System.Windows.Forms.PictureBox()
        Me.tmrTiempo = New System.Windows.Forms.Timer(Me.components)
        Me.lblVidas = New System.Windows.Forms.Label()
        Me.lblScoreTxt = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.pcbCerdo2 = New System.Windows.Forms.PictureBox()
        Me.pcbCerdo3 = New System.Windows.Forms.PictureBox()
        CType(Me.pcbCerdo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbPajaro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbCerdo2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbCerdo3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pcbCerdo1
        '
        Me.pcbCerdo1.BackColor = System.Drawing.Color.Transparent
        Me.pcbCerdo1.BackgroundImage = Global.AngryBirdsVB.My.Resources.Resources._4
        Me.pcbCerdo1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pcbCerdo1.Location = New System.Drawing.Point(645, 395)
        Me.pcbCerdo1.Name = "pcbCerdo1"
        Me.pcbCerdo1.Size = New System.Drawing.Size(100, 100)
        Me.pcbCerdo1.TabIndex = 1
        Me.pcbCerdo1.TabStop = False
        '
        'pcbPajaro
        '
        Me.pcbPajaro.BackColor = System.Drawing.Color.Transparent
        Me.pcbPajaro.BackgroundImage = Global.AngryBirdsVB.My.Resources.Resources._3
        Me.pcbPajaro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pcbPajaro.Location = New System.Drawing.Point(139, 375)
        Me.pcbPajaro.Name = "pcbPajaro"
        Me.pcbPajaro.Size = New System.Drawing.Size(100, 100)
        Me.pcbPajaro.TabIndex = 0
        Me.pcbPajaro.TabStop = False
        '
        'tmrTiempo
        '
        Me.tmrTiempo.Interval = 1
        '
        'lblVidas
        '
        Me.lblVidas.AutoSize = True
        Me.lblVidas.Font = New System.Drawing.Font("Bauhaus 93", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVidas.Location = New System.Drawing.Point(31, 24)
        Me.lblVidas.Name = "lblVidas"
        Me.lblVidas.Size = New System.Drawing.Size(109, 30)
        Me.lblVidas.TabIndex = 2
        Me.lblVidas.Text = "Vidas: 5"
        '
        'lblScoreTxt
        '
        Me.lblScoreTxt.AutoSize = True
        Me.lblScoreTxt.Font = New System.Drawing.Font("Bauhaus 93", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScoreTxt.Location = New System.Drawing.Point(33, 67)
        Me.lblScoreTxt.Name = "lblScoreTxt"
        Me.lblScoreTxt.Size = New System.Drawing.Size(95, 30)
        Me.lblScoreTxt.TabIndex = 3
        Me.lblScoreTxt.Text = "Score: "
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Font = New System.Drawing.Font("Bauhaus 93", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.Location = New System.Drawing.Point(122, 67)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(28, 30)
        Me.lblScore.TabIndex = 4
        Me.lblScore.Text = "0"
        '
        'pcbCerdo2
        '
        Me.pcbCerdo2.BackColor = System.Drawing.Color.Transparent
        Me.pcbCerdo2.BackgroundImage = Global.AngryBirdsVB.My.Resources.Resources._4
        Me.pcbCerdo2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pcbCerdo2.Location = New System.Drawing.Point(783, 395)
        Me.pcbCerdo2.Name = "pcbCerdo2"
        Me.pcbCerdo2.Size = New System.Drawing.Size(100, 100)
        Me.pcbCerdo2.TabIndex = 5
        Me.pcbCerdo2.TabStop = False
        '
        'pcbCerdo3
        '
        Me.pcbCerdo3.BackColor = System.Drawing.Color.Transparent
        Me.pcbCerdo3.BackgroundImage = Global.AngryBirdsVB.My.Resources.Resources._4
        Me.pcbCerdo3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pcbCerdo3.Location = New System.Drawing.Point(922, 395)
        Me.pcbCerdo3.Name = "pcbCerdo3"
        Me.pcbCerdo3.Size = New System.Drawing.Size(100, 100)
        Me.pcbCerdo3.TabIndex = 6
        Me.pcbCerdo3.TabStop = False
        '
        'frmAngryBirdsVB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.AngryBirdsVB.My.Resources.Resources.Sin_título
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.pcbCerdo3)
        Me.Controls.Add(Me.pcbCerdo2)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.lblScoreTxt)
        Me.Controls.Add(Me.lblVidas)
        Me.Controls.Add(Me.pcbCerdo1)
        Me.Controls.Add(Me.pcbPajaro)
        Me.Name = "frmAngryBirdsVB"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Angry Birds"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.pcbCerdo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbPajaro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbCerdo2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbCerdo3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pcbCerdo1 As PictureBox
    Friend WithEvents pcbPajaro As PictureBox
    Friend WithEvents tmrTiempo As Timer
    Friend WithEvents lblVidas As Label
    Friend WithEvents lblScoreTxt As Label
    Friend WithEvents lblScore As Label
    Friend WithEvents pcbCerdo2 As PictureBox
    Friend WithEvents pcbCerdo3 As PictureBox
End Class
