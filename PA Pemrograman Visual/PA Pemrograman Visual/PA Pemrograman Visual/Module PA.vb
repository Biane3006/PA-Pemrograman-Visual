Imports MySql.Data.MySqlClient

Module Module_PA
    Public Koneksi As MySqlConnection
    Public Perintah As MySqlCommand
    Public BacaData As MySqlDataReader
    Public DataAdapter As MySqlDataAdapter
    Public DataSet As DataSet
    Public Akun_Database As String

    Sub Connection()
        Try
            Akun_Database = "server=localhost;userid=root;password=;database=dbApotekSamarinda"
            Koneksi = New MySqlConnection(Akun_Database)
            If Koneksi.State = ConnectionState.Closed Then
                Koneksi.Open()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'Error handling inputan selain angka
    Sub CheckAngka(e As KeyPressEventArgs)
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) Then
                'Kalau Benar Numerik atau angka maka tidak perlu melakukan apapun
            Else
                'e.handled diberi nilai True agar menghentikan karakter untuk masuk ke textbox setelah ditekan
                e.Handled = True
            End If
        End If
    End Sub

End Module
