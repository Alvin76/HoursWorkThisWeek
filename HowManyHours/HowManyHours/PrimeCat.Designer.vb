<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrimeCat
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PrimeCat))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblTotalHours = New System.Windows.Forms.Label()
        Me.btnEnterTime = New System.Windows.Forms.Button()
        Me.btnEditTime = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.btnClearAll = New System.Windows.Forms.Button()
        Me.btnKill = New System.Windows.Forms.Button()
        Me.btnEntery = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MonToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FriToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SunToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.SelectAnEnteryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblHelp = New System.Windows.Forms.Label()
        Me.txtTime = New System.Windows.Forms.TextBox()
        Me.radAM = New System.Windows.Forms.RadioButton()
        Me.radPM = New System.Windows.Forms.RadioButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MnuDays = New System.Windows.Forms.MenuStrip()
        Me.DaysToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MonToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TeuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WedToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThuToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FriToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SatToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SunToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LstEntreys = New System.Windows.Forms.ListBox()
        Me.btnPunchOut = New System.Windows.Forms.Button()
        Me.btnPunchIn = New System.Windows.Forms.Button()
        Me.lstDays = New System.Windows.Forms.ListBox()
        Me.lblHelpBox2 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MnuDays.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(158, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(429, 31)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Welcome to Hari hour calculator"
        '
        'lblTotalHours
        '
        Me.lblTotalHours.AutoSize = True
        Me.lblTotalHours.Location = New System.Drawing.Point(185, 40)
        Me.lblTotalHours.Name = "lblTotalHours"
        Me.lblTotalHours.Size = New System.Drawing.Size(285, 13)
        Me.lblTotalHours.TabIndex = 1
        Me.lblTotalHours.Text = "The Total Hours you have work so far this week is XXX:XX"
        Me.lblTotalHours.Visible = False
        '
        'btnEnterTime
        '
        Me.btnEnterTime.Location = New System.Drawing.Point(34, 156)
        Me.btnEnterTime.Name = "btnEnterTime"
        Me.btnEnterTime.Size = New System.Drawing.Size(102, 23)
        Me.btnEnterTime.TabIndex = 2
        Me.btnEnterTime.Text = "Enter Time"
        Me.btnEnterTime.UseVisualStyleBackColor = True
        '
        'btnEditTime
        '
        Me.btnEditTime.Enabled = False
        Me.btnEditTime.Location = New System.Drawing.Point(34, 185)
        Me.btnEditTime.Name = "btnEditTime"
        Me.btnEditTime.Size = New System.Drawing.Size(102, 23)
        Me.btnEditTime.TabIndex = 3
        Me.btnEditTime.Text = "Edit Time"
        Me.btnEditTime.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(34, 214)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(102, 23)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(34, 243)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(102, 23)
        Me.btnLoad.TabIndex = 5
        Me.btnLoad.Text = "Load"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'btnClearAll
        '
        Me.btnClearAll.Location = New System.Drawing.Point(34, 272)
        Me.btnClearAll.Name = "btnClearAll"
        Me.btnClearAll.Size = New System.Drawing.Size(102, 23)
        Me.btnClearAll.TabIndex = 6
        Me.btnClearAll.Text = "Clear All Data"
        Me.btnClearAll.UseVisualStyleBackColor = True
        '
        'btnKill
        '
        Me.btnKill.Location = New System.Drawing.Point(34, 301)
        Me.btnKill.Name = "btnKill"
        Me.btnKill.Size = New System.Drawing.Size(102, 23)
        Me.btnKill.TabIndex = 7
        Me.btnKill.Text = "Quit"
        Me.btnKill.UseVisualStyleBackColor = True
        '
        'btnEntery
        '
        Me.btnEntery.Location = New System.Drawing.Point(603, 266)
        Me.btnEntery.Name = "btnEntery"
        Me.btnEntery.Size = New System.Drawing.Size(75, 23)
        Me.btnEntery.TabIndex = 8
        Me.btnEntery.Text = "Enter"
        Me.btnEntery.UseVisualStyleBackColor = True
        Me.btnEntery.Visible = False
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(603, 295)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseMnemonic = False
        Me.btnClear.UseVisualStyleBackColor = True
        Me.btnClear.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MonToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(226, 197)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(93, 24)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        Me.MenuStrip1.Visible = False
        '
        'MonToolStripMenuItem
        '
        Me.MonToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TuToolStripMenuItem, Me.TueToolStripMenuItem, Me.WedToolStripMenuItem, Me.ThuToolStripMenuItem, Me.FriToolStripMenuItem, Me.SatToolStripMenuItem, Me.SunToolStripMenuItem})
        Me.MonToolStripMenuItem.Name = "MonToolStripMenuItem"
        Me.MonToolStripMenuItem.Size = New System.Drawing.Size(85, 20)
        Me.MonToolStripMenuItem.Text = "Day of Week"
        '
        'TuToolStripMenuItem
        '
        Me.TuToolStripMenuItem.Name = "TuToolStripMenuItem"
        Me.TuToolStripMenuItem.Size = New System.Drawing.Size(99, 22)
        Me.TuToolStripMenuItem.Text = "Mon"
        '
        'TueToolStripMenuItem
        '
        Me.TueToolStripMenuItem.Name = "TueToolStripMenuItem"
        Me.TueToolStripMenuItem.Size = New System.Drawing.Size(99, 22)
        Me.TueToolStripMenuItem.Text = "Tue"
        '
        'WedToolStripMenuItem
        '
        Me.WedToolStripMenuItem.Name = "WedToolStripMenuItem"
        Me.WedToolStripMenuItem.Size = New System.Drawing.Size(99, 22)
        Me.WedToolStripMenuItem.Text = "Wed"
        '
        'ThuToolStripMenuItem
        '
        Me.ThuToolStripMenuItem.Name = "ThuToolStripMenuItem"
        Me.ThuToolStripMenuItem.Size = New System.Drawing.Size(99, 22)
        Me.ThuToolStripMenuItem.Text = "Thu"
        '
        'FriToolStripMenuItem
        '
        Me.FriToolStripMenuItem.Name = "FriToolStripMenuItem"
        Me.FriToolStripMenuItem.Size = New System.Drawing.Size(99, 22)
        Me.FriToolStripMenuItem.Text = "Fri"
        '
        'SatToolStripMenuItem
        '
        Me.SatToolStripMenuItem.Name = "SatToolStripMenuItem"
        Me.SatToolStripMenuItem.Size = New System.Drawing.Size(99, 22)
        Me.SatToolStripMenuItem.Text = "Sat"
        '
        'SunToolStripMenuItem
        '
        Me.SunToolStripMenuItem.Name = "SunToolStripMenuItem"
        Me.SunToolStripMenuItem.Size = New System.Drawing.Size(99, 22)
        Me.SunToolStripMenuItem.Text = "Sun"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectAnEnteryToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(226, 128)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(110, 24)
        Me.MenuStrip2.TabIndex = 11
        Me.MenuStrip2.Text = "MenuStrip2"
        Me.MenuStrip2.Visible = False
        '
        'SelectAnEnteryToolStripMenuItem
        '
        Me.SelectAnEnteryToolStripMenuItem.Name = "SelectAnEnteryToolStripMenuItem"
        Me.SelectAnEnteryToolStripMenuItem.Size = New System.Drawing.Size(102, 20)
        Me.SelectAnEnteryToolStripMenuItem.Text = "Select an Entery"
        '
        'lblHelp
        '
        Me.lblHelp.AutoSize = True
        Me.lblHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHelp.Location = New System.Drawing.Point(185, 63)
        Me.lblHelp.Name = "lblHelp"
        Me.lblHelp.Size = New System.Drawing.Size(147, 18)
        Me.lblHelp.TabIndex = 12
        Me.lblHelp.Text = "Help Text Goes Here"
        Me.lblHelp.Visible = False
        '
        'txtTime
        '
        Me.txtTime.Location = New System.Drawing.Point(603, 194)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Size = New System.Drawing.Size(100, 20)
        Me.txtTime.TabIndex = 13
        Me.txtTime.Text = "XX:XX"
        Me.txtTime.Visible = False
        '
        'radAM
        '
        Me.radAM.AutoSize = True
        Me.radAM.Checked = True
        Me.radAM.Location = New System.Drawing.Point(603, 214)
        Me.radAM.Name = "radAM"
        Me.radAM.Size = New System.Drawing.Size(41, 17)
        Me.radAM.TabIndex = 15
        Me.radAM.TabStop = True
        Me.radAM.Text = "AM"
        Me.radAM.UseVisualStyleBackColor = True
        Me.radAM.Visible = False
        '
        'radPM
        '
        Me.radPM.AutoSize = True
        Me.radPM.Location = New System.Drawing.Point(659, 214)
        Me.radPM.Name = "radPM"
        Me.radPM.Size = New System.Drawing.Size(41, 17)
        Me.radPM.TabIndex = 16
        Me.radPM.Text = "PM"
        Me.radPM.UseVisualStyleBackColor = True
        Me.radPM.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(183, 63)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(549, 305)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'MnuDays
        '
        Me.MnuDays.Dock = System.Windows.Forms.DockStyle.None
        Me.MnuDays.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DaysToolStripMenuItem})
        Me.MnuDays.Location = New System.Drawing.Point(254, 201)
        Me.MnuDays.Name = "MnuDays"
        Me.MnuDays.Size = New System.Drawing.Size(202, 24)
        Me.MnuDays.TabIndex = 18
        Me.MnuDays.Text = "MenuStrip3"
        Me.MnuDays.Visible = False
        '
        'DaysToolStripMenuItem
        '
        Me.DaysToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MonToolStripMenuItem1, Me.TeuToolStripMenuItem, Me.WedToolStripMenuItem1, Me.ThuToolStripMenuItem1, Me.FriToolStripMenuItem1, Me.SatToolStripMenuItem1, Me.SunToolStripMenuItem1})
        Me.DaysToolStripMenuItem.Name = "DaysToolStripMenuItem"
        Me.DaysToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.DaysToolStripMenuItem.Text = "Days"
        Me.DaysToolStripMenuItem.Visible = False
        '
        'MonToolStripMenuItem1
        '
        Me.MonToolStripMenuItem1.Name = "MonToolStripMenuItem1"
        Me.MonToolStripMenuItem1.Size = New System.Drawing.Size(99, 22)
        Me.MonToolStripMenuItem1.Text = "Mon"
        '
        'TeuToolStripMenuItem
        '
        Me.TeuToolStripMenuItem.Name = "TeuToolStripMenuItem"
        Me.TeuToolStripMenuItem.Size = New System.Drawing.Size(99, 22)
        Me.TeuToolStripMenuItem.Text = "Tue"
        '
        'WedToolStripMenuItem1
        '
        Me.WedToolStripMenuItem1.Name = "WedToolStripMenuItem1"
        Me.WedToolStripMenuItem1.Size = New System.Drawing.Size(99, 22)
        Me.WedToolStripMenuItem1.Text = "Wed"
        '
        'ThuToolStripMenuItem1
        '
        Me.ThuToolStripMenuItem1.Name = "ThuToolStripMenuItem1"
        Me.ThuToolStripMenuItem1.Size = New System.Drawing.Size(99, 22)
        Me.ThuToolStripMenuItem1.Text = "Thu"
        '
        'FriToolStripMenuItem1
        '
        Me.FriToolStripMenuItem1.Name = "FriToolStripMenuItem1"
        Me.FriToolStripMenuItem1.Size = New System.Drawing.Size(99, 22)
        Me.FriToolStripMenuItem1.Text = "Fri"
        '
        'SatToolStripMenuItem1
        '
        Me.SatToolStripMenuItem1.Name = "SatToolStripMenuItem1"
        Me.SatToolStripMenuItem1.Size = New System.Drawing.Size(99, 22)
        Me.SatToolStripMenuItem1.Text = "Sat"
        '
        'SunToolStripMenuItem1
        '
        Me.SunToolStripMenuItem1.Name = "SunToolStripMenuItem1"
        Me.SunToolStripMenuItem1.Size = New System.Drawing.Size(99, 22)
        Me.SunToolStripMenuItem1.Text = "Sun"
        '
        'LstEntreys
        '
        Me.LstEntreys.FormattingEnabled = True
        Me.LstEntreys.Location = New System.Drawing.Point(287, 89)
        Me.LstEntreys.Name = "LstEntreys"
        Me.LstEntreys.Size = New System.Drawing.Size(126, 264)
        Me.LstEntreys.TabIndex = 19
        Me.LstEntreys.Visible = False
        '
        'btnPunchOut
        '
        Me.btnPunchOut.Location = New System.Drawing.Point(34, 127)
        Me.btnPunchOut.Name = "btnPunchOut"
        Me.btnPunchOut.Size = New System.Drawing.Size(102, 23)
        Me.btnPunchOut.TabIndex = 20
        Me.btnPunchOut.Text = "Punch Out"
        Me.btnPunchOut.UseVisualStyleBackColor = True
        '
        'btnPunchIn
        '
        Me.btnPunchIn.Location = New System.Drawing.Point(34, 98)
        Me.btnPunchIn.Name = "btnPunchIn"
        Me.btnPunchIn.Size = New System.Drawing.Size(102, 23)
        Me.btnPunchIn.TabIndex = 21
        Me.btnPunchIn.Text = "Punch In"
        Me.btnPunchIn.UseVisualStyleBackColor = True
        '
        'lstDays
        '
        Me.lstDays.FormattingEnabled = True
        Me.lstDays.Items.AddRange(New Object() {"Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun"})
        Me.lstDays.Location = New System.Drawing.Point(550, 194)
        Me.lstDays.Name = "lstDays"
        Me.lstDays.Size = New System.Drawing.Size(47, 95)
        Me.lstDays.TabIndex = 22
        Me.lstDays.Visible = False
        '
        'lblHelpBox2
        '
        Me.lblHelpBox2.AutoSize = True
        Me.lblHelpBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHelpBox2.Location = New System.Drawing.Point(547, 173)
        Me.lblHelpBox2.Name = "lblHelpBox2"
        Me.lblHelpBox2.Size = New System.Drawing.Size(147, 18)
        Me.lblHelpBox2.TabIndex = 23
        Me.lblHelpBox2.Text = "Help Text Goes Here"
        Me.lblHelpBox2.Visible = False
        '
        'PrimeCat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(744, 380)
        Me.Controls.Add(Me.lblHelpBox2)
        Me.Controls.Add(Me.lstDays)
        Me.Controls.Add(Me.btnPunchIn)
        Me.Controls.Add(Me.btnPunchOut)
        Me.Controls.Add(Me.radPM)
        Me.Controls.Add(Me.radAM)
        Me.Controls.Add(Me.txtTime)
        Me.Controls.Add(Me.lblHelp)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnEntery)
        Me.Controls.Add(Me.btnKill)
        Me.Controls.Add(Me.btnClearAll)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnEditTime)
        Me.Controls.Add(Me.btnEnterTime)
        Me.Controls.Add(Me.lblTotalHours)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.MnuDays)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Controls.Add(Me.LstEntreys)
        Me.Controls.Add(Me.PictureBox1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "PrimeCat"
        Me.Text = "Hari Hour Calculator"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MnuDays.ResumeLayout(False)
        Me.MnuDays.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblTotalHours As Label
    Friend WithEvents btnEnterTime As Button
    Friend WithEvents btnEditTime As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnLoad As Button
    Friend WithEvents btnClearAll As Button
    Friend WithEvents btnKill As Button
    Friend WithEvents btnEntery As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MonToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TueToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ThuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FriToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SatToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SunToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents SelectAnEnteryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblHelp As Label
    Friend WithEvents txtTime As TextBox
    Friend WithEvents radAM As RadioButton
    Friend WithEvents radPM As RadioButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MnuDays As MenuStrip
    Friend WithEvents DaysToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MonToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TeuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WedToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ThuToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents FriToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SatToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SunToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents LstEntreys As ListBox
    Friend WithEvents btnPunchOut As Button
    Friend WithEvents btnPunchIn As Button
    Friend WithEvents lstDays As ListBox
    Friend WithEvents lblHelpBox2 As Label
End Class
