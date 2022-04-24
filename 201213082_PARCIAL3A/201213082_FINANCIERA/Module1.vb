Module Module1

    Public index = 0

    Public cliente(7) As String
    Public viaje(7) As String
    Public dias(7) As Double
    Public personas(7) As Double
    Public precio(7) As Double
    Public total(7) As Double

    Public Const laguna = 440
    Public Const mirador = 1190
    Public Const biotopo = 255


    Sub limpiar_vectores()
        Form1.DataGridView1.Rows.Clear()

        Index = 0
    End Sub

    Sub limpiar_Entrada()
        Form1.Txtidentificación.Text = ""
        Form1.Txtdías.Text = ""
        Form1.Txtpersonas.Text = ""
        Form1.Cbxviaje.SelectedItem = False
        Form1.Txtconsulta.Text = ""
    End Sub

End Module
