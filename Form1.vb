Imports System.IO.Ports
Imports System.IO

Public Class frmAngryBirdsVB



    Dim agarre, cerdo1, cerdo2, cerdo3 As Boolean
    Dim posicionX, posicionY, xi, yi, xf, yf, fuerza, score, resorteraX, resorteraY, cerdoX1, cerdoY1, cerdoX2, cerdoY2, cerdoX3, cerdoY3, pruebaX, pruebaY As Integer

    Private Sub frmAngryBirdsVB_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dim guardar As String = "C:\Users\CarlosLap\Documents\Visual Studio 2019\Projects\19- AngryBirds\guardar\variables.txt"
        Dim escritor As New StreamWriter(guardar)
        escritor.WriteLine(pcbCerdo1.Left & "," & pcbCerdo2.Left & "," & pcbCerdo3.Left & "," & pcbCerdo1.Top & "," & pcbCerdo2.Top & "," & pcbCerdo3.Top & "," & cerdo1 & "," & cerdo2 & "," & cerdo3 & "," & score & "," & tmrTiempo.Enabled & "," & pcbPajaro.Left & "," & pcbPajaro.Top & "," & vidas & "," & angulo & "," & tiempo & "," & pruebaX & "," & pruebaY & "," & fuerza)
        escritor.Close()
    End Sub

    Private Sub frmAngryBirdsVB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress

    End Sub

    Dim angulo, tiempo As Double
    Dim vidas As Integer = 5

    'Cargar form
    Private Sub frmAngryBirdsVB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.bird, AudioPlayMode.BackgroundLoop)

        Dim abrir As String = "C:\Users\CarlosLap\Documents\Visual Studio 2019\Projects\19- AngryBirds\guardar\variables.txt"

        If System.IO.File.Exists(abrir) = True Then
            Dim lector As New StreamReader(abrir)

            pcbCerdo1.Left = lector.ReadLine()
            lector.Close()

        Else
            MsgBox("No existe el archivo")
            cerdos()
        End If


    End Sub




    'Agarre
    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles pcbPajaro.MouseDown

        If tmrTiempo.Enabled = False Then
            agarre = True
            posicionX = MousePosition.X - sender.left
            posicionY = MousePosition.Y - sender.top

            xi = MousePosition.X
            yi = MousePosition.Y
        End If


    End Sub


    'Arrastre
    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles pcbPajaro.MouseMove

        If agarre = True And tmrTiempo.Enabled = False And MousePosition.X < 500 And MousePosition.Y > 300 Then
            pcbPajaro.Left = MousePosition.X - posicionX
            pcbPajaro.Top = MousePosition.Y - posicionY
        End If


    End Sub



    'Soltar
    Private Sub PictureBox1_MouseUp(sender As Object, e As MouseEventArgs) Handles pcbPajaro.MouseUp

        If tmrTiempo.Enabled = False Then

            agarre = False
            tiempo = 0
            tmrTiempo.Enabled = True

            If MousePosition.X < 500 Then
                xf = MousePosition.X
                pruebaX = MousePosition.X - posicionX
            Else
                xf = pcbPajaro.Left
                pruebaX = pcbPajaro.Left - posicionX
            End If



            If MousePosition.Y > 300 Then
                yf = MousePosition.Y
                pruebaY = MousePosition.Y - posicionY
            Else
                yf = pcbPajaro.Top
                pruebaY = pcbPajaro.Top - posicionY
            End If



            'Fuerza
            fuerza = Math.Sqrt((xf - xi) ^ 2 + (yf - yi) ^ 2)


            'Angulo
            angulo = Math.Asin((yf - yi) / (fuerza)) * (180 / 3.141592)

        End If



    End Sub



    Private Sub tmrTiempo_Tick(sender As Object, e As EventArgs) Handles tmrTiempo.Tick

        tiempo += 0.1

        Dim X, Y As Integer

        If pruebaX < 139 Then
            X = (fuerza * (Math.Cos(angulo * 3.141592 / 180)) * tiempo) + pruebaX
        Else
            X = (-1) * (fuerza * (Math.Cos(angulo * 3.141592 / 180)) * tiempo) + pruebaX
        End If

        If pruebaY < 375 Then
            Y = pruebaY + ((fuerza * (Math.Sin(angulo * 3.141592 / 180)) * tiempo - ((9.81 * (tiempo ^ 2)) / 2)) * -1)
        Else
            Y = pruebaY - (fuerza * (Math.Sin(angulo * 3.141592 / 180)) * tiempo - ((9.81 * (tiempo ^ 2)) / 2))
        End If


        Me.Text = "X: " & X & "     Y: " & Y & "       Angulo: " & angulo


        pcbPajaro.Left = X
        pcbPajaro.Top = Y




        'Te sales de la pantalla
        If X > 1366 Or X < -250 Or Y > 768 Then
            vidas -= 1
            lblVidas.Text = "Vidas: " & vidas
            pcbPajaro.Left = 139
            pcbPajaro.Top = 375
            tmrTiempo.Enabled = False
        End If







        'Si golpeas a los CERDOS
        If pcbPajaro.Bounds.IntersectsWith(pcbCerdo1.Bounds) Then
            pcbCerdo1.Location = New Point(4000, 4000)
            score += 100
            lblScore.Text = score
            cerdo1 = True
        End If

        If pcbPajaro.Bounds.IntersectsWith(pcbCerdo2.Bounds) Then
            pcbCerdo2.Location = New Point(4000, 4000)
            score += 100
            lblScore.Text = score
            cerdo2 = True
        End If

        If pcbPajaro.Bounds.IntersectsWith(pcbCerdo3.Bounds) Then
            pcbCerdo3.Location = New Point(4000, 4000)
            score += 100
            lblScore.Text = score
            cerdo3 = True
        End If

        If cerdo1 = True And cerdo2 = True And cerdo3 = True Then
            tmrTiempo.Enabled = False
            If MsgBox("Ganaste!, jugar de nuevo?", MsgBoxStyle.YesNo) = 6 Then
                tmrTiempo.Enabled = False
                lblScore.Text = score
                vidas = 5
                lblVidas.Text = "Vidas: " & vidas
                pcbPajaro.Left = 139
                pcbPajaro.Top = 375

                cerdos()
            Else
                Application.Exit()
                Me.Close()
            End If

        End If

        If vidas <= 0 Then
            tmrTiempo.Enabled = False
            If MsgBox("Perdiste!, jugar de nuevo?", MsgBoxStyle.YesNo) = 6 Then
                lblScore.Text = score
                vidas = 5
                lblVidas.Text = "Vidas: " & vidas
                pcbPajaro.Left = 139
                pcbPajaro.Top = 375
                tmrTiempo.Enabled = False
                cerdos()
            Else
                Application.Exit()
                Me.Close()

            End If

        End If

    End Sub



    Sub cerdos()


        'CERDO1
        Randomize()
        cerdoX1 = Convert.ToInt32((Rnd() * 1200))
        If cerdoX1 < 540 Then
            cerdoX1 += 540
        End If
        cerdo1 = False

        Randomize()

        cerdoY1 = Convert.ToInt32(Rnd() * 560)
        If cerdoY1 < 10 Then
            cerdoY1 += 10
        End If

        pcbCerdo1.Left = cerdoX1
        pcbCerdo1.Top = cerdoY1




        'CERDO2
        Randomize()
        cerdoX2 = Convert.ToInt32((Rnd() * 1200))
        If cerdoX2 < 540 Then
            cerdoX2 += 540
        End If
        cerdo2 = False

        Randomize()

        cerdoY2 = Convert.ToInt32(Rnd() * 560)
        If cerdoY2 < 10 Then
            cerdoY2 += 10
        End If

        pcbCerdo2.Left = cerdoX2
        pcbCerdo2.Top = cerdoY2




        'CERDO3
        Randomize()
        cerdoX3 = Convert.ToInt32((Rnd() * 1200))
        If cerdoX3 < 540 Then
            cerdoX3 += 540
        End If
        cerdo3 = False

        Randomize()

        cerdoY3 = Convert.ToInt32(Rnd() * 560)
        If cerdoY3 < 10 Then
            cerdoY3 += 10
        End If

        pcbCerdo3.Left = cerdoX3
        pcbCerdo3.Top = cerdoY3

    End Sub

End Class
