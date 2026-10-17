Public Class Form1
    Public hrgmakanan, hrgminuman As Integer
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        ComboBox2.Visible = False
        Label3.Visible = True


        ' Add any initialization after the InitializeComponent() call.

    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case ComboBox1.Text
            Case "Mie Yamin"
                Label3.Text = "Rp. 10000"
                hrgmakanan = 10000
            Case "Bakso"
                Label3.Text = "Rp. 12000"
                hrgmakanan = 12000
            Case "Mie Ayam"
                Label3.Text = "Rp. 15000"
                hrgmakanan = 15000
        End Select
    End Sub




    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Enabled = False Then
            ComboBox2.Visible = False
            Label3.Visible = True
        End If
        If CheckBox1.Enabled = True Then
            ComboBox2.Visible = True
            Label3.Visible = True

        End If
    End Sub


    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        Select Case ComboBox2.Text
            Case "Es Jeruk"
                Label4.Text = "Rp. 3000"
                hrgminuman = 3000
            Case "Jus Alpukat"
                Label4.Text = "Rp. 7000"
                hrgminuman = 7000
            Case "Teh Es"
                Label4.Text = "Rp. 2000"
                hrgminuman = 2000
        End Select
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim porsmkn, porsmnm, total As Integer
        porsmkn = TextBox1.Text
        porsmnm = TextBox2.Text
        total = (hrgmakanan * porsmkn) + (hrgminuman * porsmnm)
        Label8.Text = "Rp" & total.ToString
    End Sub
End Class
