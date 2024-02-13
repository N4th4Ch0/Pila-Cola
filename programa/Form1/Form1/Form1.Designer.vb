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
        btnEjecutar = New Button()
        btnBorrar = New Button()
        txtResultadosGenerales = New TextBox()
        txtPila = New TextBox()
        txtCola = New TextBox()
        SuspendLayout()
        ' 
        ' btnEjecutar
        ' 
        btnEjecutar.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnEjecutar.Location = New Point(128, 70)
        btnEjecutar.Name = "btnEjecutar"
        btnEjecutar.Size = New Size(95, 32)
        btnEjecutar.TabIndex = 0
        btnEjecutar.Text = "EJECUTAR"
        btnEjecutar.UseVisualStyleBackColor = True
        ' 
        ' btnBorrar
        ' 
        btnBorrar.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnBorrar.Location = New Point(255, 71)
        btnBorrar.Name = "btnBorrar"
        btnBorrar.Size = New Size(95, 31)
        btnBorrar.TabIndex = 1
        btnBorrar.Text = "REINICIAR"
        btnBorrar.UseVisualStyleBackColor = True
        ' 
        ' txtResultadosGenerales
        ' 
        txtResultadosGenerales.Location = New Point(12, 128)
        txtResultadosGenerales.Multiline = True
        txtResultadosGenerales.Name = "txtResultadosGenerales"
        txtResultadosGenerales.Size = New Size(147, 208)
        txtResultadosGenerales.TabIndex = 2
        ' 
        ' txtPila
        ' 
        txtPila.Location = New Point(165, 128)
        txtPila.Multiline = True
        txtPila.Name = "txtPila"
        txtPila.Size = New Size(147, 208)
        txtPila.TabIndex = 3
        ' 
        ' txtCola
        ' 
        txtCola.Location = New Point(318, 128)
        txtCola.Multiline = True
        txtCola.Name = "txtCola"
        txtCola.Size = New Size(147, 208)
        txtCola.TabIndex = 4
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.IndianRed
        ClientSize = New Size(488, 366)
        Controls.Add(txtCola)
        Controls.Add(txtPila)
        Controls.Add(txtResultadosGenerales)
        Controls.Add(btnBorrar)
        Controls.Add(btnEjecutar)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnEjecutar As Button
    Friend WithEvents btnBorrar As Button
    Friend WithEvents txtResultadosGenerales As TextBox
    Friend WithEvents txtPila As TextBox
    Friend WithEvents txtCola As TextBox
End Class
