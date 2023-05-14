<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.pbHome = New System.Windows.Forms.PictureBox()
        Me.pbPro = New System.Windows.Forms.PictureBox()
        Me.pbExit = New System.Windows.Forms.PictureBox()
        Me.btnUsers = New System.Windows.Forms.Button()
        Me.btnRoomtypes = New System.Windows.Forms.Button()
        Me.btnRooms = New System.Windows.Forms.Button()
        Me.btnCustomers = New System.Windows.Forms.Button()
        Me.btnBook = New System.Windows.Forms.Button()
        Me.pbHot = New System.Windows.Forms.PictureBox()
        Me.pbBg = New System.Windows.Forms.PictureBox()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.pbHome, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbPro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbHot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel2)
        Me.Panel3.Location = New System.Drawing.Point(-2, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(241, 667)
        Me.Panel3.TabIndex = 7
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Panel2.Controls.Add(Me.pbHome)
        Me.Panel2.Controls.Add(Me.pbPro)
        Me.Panel2.Controls.Add(Me.pbExit)
        Me.Panel2.Controls.Add(Me.btnUsers)
        Me.Panel2.Controls.Add(Me.btnRoomtypes)
        Me.Panel2.Controls.Add(Me.btnRooms)
        Me.Panel2.Controls.Add(Me.btnCustomers)
        Me.Panel2.Controls.Add(Me.btnBook)
        Me.Panel2.Controls.Add(Me.pbHot)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(240, 660)
        Me.Panel2.TabIndex = 7
        '
        'pbHome
        '
        Me.pbHome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbHome.Image = CType(resources.GetObject("pbHome.Image"), System.Drawing.Image)
        Me.pbHome.Location = New System.Drawing.Point(14, 22)
        Me.pbHome.Name = "pbHome"
        Me.pbHome.Size = New System.Drawing.Size(19, 19)
        Me.pbHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbHome.TabIndex = 8
        Me.pbHome.TabStop = False
        '
        'pbPro
        '
        Me.pbPro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbPro.Image = CType(resources.GetObject("pbPro.Image"), System.Drawing.Image)
        Me.pbPro.Location = New System.Drawing.Point(14, 73)
        Me.pbPro.Name = "pbPro"
        Me.pbPro.Size = New System.Drawing.Size(19, 19)
        Me.pbPro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbPro.TabIndex = 7
        Me.pbPro.TabStop = False
        '
        'pbExit
        '
        Me.pbExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbExit.Image = CType(resources.GetObject("pbExit.Image"), System.Drawing.Image)
        Me.pbExit.Location = New System.Drawing.Point(14, 123)
        Me.pbExit.Name = "pbExit"
        Me.pbExit.Size = New System.Drawing.Size(19, 19)
        Me.pbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbExit.TabIndex = 1
        Me.pbExit.TabStop = False
        '
        'btnUsers
        '
        Me.btnUsers.BackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUsers.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsers.ForeColor = System.Drawing.Color.White
        Me.btnUsers.Location = New System.Drawing.Point(53, 487)
        Me.btnUsers.Name = "btnUsers"
        Me.btnUsers.Size = New System.Drawing.Size(188, 45)
        Me.btnUsers.TabIndex = 5
        Me.btnUsers.Text = "USERS"
        Me.btnUsers.UseVisualStyleBackColor = False
        '
        'btnRoomtypes
        '
        Me.btnRoomtypes.BackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btnRoomtypes.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRoomtypes.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRoomtypes.ForeColor = System.Drawing.Color.White
        Me.btnRoomtypes.Location = New System.Drawing.Point(53, 418)
        Me.btnRoomtypes.Name = "btnRoomtypes"
        Me.btnRoomtypes.Size = New System.Drawing.Size(188, 45)
        Me.btnRoomtypes.TabIndex = 3
        Me.btnRoomtypes.Text = "ROOM TYPES"
        Me.btnRoomtypes.UseVisualStyleBackColor = False
        '
        'btnRooms
        '
        Me.btnRooms.BackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btnRooms.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRooms.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRooms.ForeColor = System.Drawing.Color.White
        Me.btnRooms.Location = New System.Drawing.Point(53, 350)
        Me.btnRooms.Name = "btnRooms"
        Me.btnRooms.Size = New System.Drawing.Size(188, 45)
        Me.btnRooms.TabIndex = 4
        Me.btnRooms.Text = "ROOMS"
        Me.btnRooms.UseVisualStyleBackColor = False
        '
        'btnCustomers
        '
        Me.btnCustomers.BackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCustomers.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCustomers.ForeColor = System.Drawing.Color.White
        Me.btnCustomers.Location = New System.Drawing.Point(53, 281)
        Me.btnCustomers.Name = "btnCustomers"
        Me.btnCustomers.Size = New System.Drawing.Size(188, 45)
        Me.btnCustomers.TabIndex = 3
        Me.btnCustomers.Text = "CUSTOMERS"
        Me.btnCustomers.UseVisualStyleBackColor = False
        '
        'btnBook
        '
        Me.btnBook.BackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btnBook.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBook.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBook.ForeColor = System.Drawing.Color.White
        Me.btnBook.Location = New System.Drawing.Point(53, 212)
        Me.btnBook.Name = "btnBook"
        Me.btnBook.Size = New System.Drawing.Size(188, 45)
        Me.btnBook.TabIndex = 2
        Me.btnBook.Text = "BOOKINGS"
        Me.btnBook.UseVisualStyleBackColor = False
        '
        'pbHot
        '
        Me.pbHot.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbHot.Image = CType(resources.GetObject("pbHot.Image"), System.Drawing.Image)
        Me.pbHot.Location = New System.Drawing.Point(59, 22)
        Me.pbHot.Name = "pbHot"
        Me.pbHot.Size = New System.Drawing.Size(167, 155)
        Me.pbHot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbHot.TabIndex = 0
        Me.pbHot.TabStop = False
        '
        'pbBg
        '
        Me.pbBg.Image = CType(resources.GetObject("pbBg.Image"), System.Drawing.Image)
        Me.pbBg.Location = New System.Drawing.Point(246, 13)
        Me.pbBg.Name = "pbBg"
        Me.pbBg.Size = New System.Drawing.Size(1445, 636)
        Me.pbBg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbBg.TabIndex = 9
        Me.pbBg.TabStop = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1703, 661)
        Me.Controls.Add(Me.pbBg)
        Me.Controls.Add(Me.Panel3)
        Me.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.IsMdiContainer = True
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MAIN"
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.pbHome, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbPro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbHot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents pbExit As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnUsers As Button
    Friend WithEvents btnRoomtypes As Button
    Friend WithEvents btnRooms As Button
    Friend WithEvents btnCustomers As Button
    Friend WithEvents btnBook As Button
    Friend WithEvents pbHot As PictureBox
    Friend WithEvents pbHome As PictureBox
    Friend WithEvents pbPro As PictureBox
    Friend WithEvents pbBg As PictureBox
End Class
