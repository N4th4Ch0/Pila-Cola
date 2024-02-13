Public Class Form1
    Private originalArray As Integer() = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10}
    Private stateChanges As Integer = 0

    Private Sub btnEjecutar_Click(sender As Object, e As EventArgs) Handles btnEjecutar.Click
        ' Limpiar cuadros de texto al inicio
        txtPila.Clear()
        txtCola.Clear()
        txtResultadosGenerales.Clear()

        ' Crear instancias de pila y cola
        Dim stack As New Stack(Of Integer)
        Dim queue As New Queue(Of Integer)

        ' Realizar operaciones de pila
        For Each num As Integer In originalArray
            stack.Push(num)
            PrintState("Pila", "Push", stack, txtPila)
        Next

        For Each num As Integer In originalArray
            stack.Pop()
            PrintState("Pila", "Pop", stack, txtPila)
        Next

        ' Realizar operaciones de cola
        For Each num As Integer In originalArray
            queue.Enqueue(num)
            PrintState("Cola", "Agrega", queue, txtCola)
        Next

        For Each num As Integer In originalArray
            queue.Dequeue()
            PrintState("Cola", "Elimina", queue, txtCola)
        Next

        ' Mostrar el número de cambios de estado
        txtResultadosGenerales.AppendText("Número de cambios de estado (pila/cola): " & stateChanges.ToString() & vbCrLf)
        stateChanges = 0 ' Reiniciar el contador después de mostrar los resultados
    End Sub

    Private Sub PrintState(type As String, operation As String, container As Object, textBox As TextBox)
        textBox.AppendText(type & " - Estado: " & operation & ", Contenido: ")

        For Each item In container
            textBox.AppendText(item.ToString() & " ")
        Next

        textBox.AppendText(vbCrLf)

        stateChanges += 1
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        ' Limpiar todos los cuadros de texto y reiniciar el contador de cambios de estado
        txtPila.Clear()
        txtCola.Clear()
        txtResultadosGenerales.Clear()
        stateChanges = 0
    End Sub
End Class
