Public Class Main

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnBook_Click(sender As Object, e As EventArgs) Handles btnBook.Click
        pbBg.Visible = False
        Dim book As New Book
        book.MdiParent = Me
        open(book)
    End Sub

    Private Sub btnCustomers_Click(sender As Object, e As EventArgs) Handles btnCustomers.Click
        pbBg.Visible = False
        Dim cus As New Customers
        cus.MdiParent = Me
        open(cus)
    End Sub

    Private Sub btnRooms_Click(sender As Object, e As EventArgs) Handles btnRooms.Click
        pbBg.Visible = False
        Dim room As New Rooms
        room.MdiParent = Me
        open(room)
    End Sub

    Private Sub btnRoomtypes_Click(sender As Object, e As EventArgs) Handles btnRoomtypes.Click
        pbBg.Visible = False
        Dim roomt As New Roomtype
        roomt.MdiParent = Me
        open(roomt)
    End Sub

    Private Sub btnUsers_Click(sender As Object, e As EventArgs) Handles btnUsers.Click
        pbBg.Visible = False
        Dim use As New Users
        use.MdiParent = Me
        open(use)
    End Sub

    Private Sub pbExit_Click(sender As Object, e As EventArgs) Handles pbExit.Click
        If (MessageBox.Show("Are you sure you want to logout?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
            Login.Show()
            Me.Close()
        End If
    End Sub

    Private Sub pbPro_Click(sender As Object, e As EventArgs) Handles pbPro.Click
        AddUser.Show()
    End Sub

    Private Sub pbHome_Click(sender As Object, e As EventArgs) Handles pbHome.Click
        EditHotel.Show()
    End Sub

    Private Sub pbHot_Click(sender As Object, e As EventArgs) Handles pbHot.Click
        pbBg.Visible = True
    End Sub
End Class