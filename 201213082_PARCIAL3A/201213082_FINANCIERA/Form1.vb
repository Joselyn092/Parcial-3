Public Class Form1
    Private Sub AceptarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AceptarToolStripMenuItem.Click

        If index < 6 Then
            cliente(index) = Txtidentificación.Text
            viaje(index) = Cbxviaje.SelectedItem
            dias(index) = Txtdías.Text
            personas(index) = Txtpersonas.Text

            If Cbxviaje.SelectedItem = "Laguna Brava" Then
                precio(index) = laguna
            ElseIf Cbxviaje.SelectedItem = "Mirador" Then
                precio(index) = mirador
            ElseIf Cbxviaje.SelectedItem = "Biotopo del Quetzal" Then
                precio(index) = biotopo
            End If

            total(index) = precio(index) * dias(index) * personas(index)
        End If

        DataGridView1.Rows.Add(cliente(index), viaje(index), dias(index), personas(index), precio(index), total(index))
        index = 0 + 1
    End Sub

    Private Sub MostrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MostrarToolStripMenuItem.Click

        DataGridView1.Rows.Add(cliente(index), viaje(index), dias(index), personas(index), precio(index), total(index))
        index = 0 + 1

    End Sub

    Private Sub BuscarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarToolStripMenuItem.Click

        Dim existe As Boolean = False
        index = 0
        While (index <= 6) And Not (existe)
            If (cliente(index) = Val(Txtconsulta.Text)) Then
                existe = True
            Else
                index = index + 1

            End If
        End While
        If (existe) Then
            MsgBox("Número de identidad encontrado exitosamente")
            Txtidentificación.Text = cliente(index)
            Txtdías.Text = dias(index)
            Txtpersonas.Text = personas(index)
            Cbxviaje.SelectedItem = viaje(index)

            DataGridView1.Rows.Clear()
            DataGridView1.Rows.Add(cliente(index), viaje(index), dias(index), personas(index), precio(index), total(index))

        Else
            MsgBox("Número de identificación no encontrado")
            Txtconsulta.Focus()
        End If

    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click

        cliente(index) = Nothing
        viaje(index) = Nothing
        dias(index) = Nothing
        personas(index) = Nothing
        precio(index) = Nothing
        total(index) = Nothing

        For index = index To 3
            cliente(index) = cliente(index + 1)
            viaje(index) = viaje(index + 1)
            dias(index) = dias(index + 1)
            personas(index) = personas(index + 1)
            precio(index) = precio(index + 1)
            total(index) = total(index + 1)
        Next

        MsgBox("Registro eliminado exitosamente")

        cliente(index) = Nothing
        viaje(index) = Nothing
        dias(index) = Nothing
        personas(index) = Nothing
        precio(index) = Nothing
        total(index) = Nothing

        DataGridView1.Rows.Clear()
    End Sub

    Private Sub LimpiarVectoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarVectoresToolStripMenuItem.Click

        limpiar_vectores()
        limpiar_Entrada()

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click

        If MsgBox("¿Desea Salir?", vbYesNo) = vbYes Then
            End
        End If

    End Sub


End Class
