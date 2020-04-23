<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PrimeCat
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
        Me.components = New System.ComponentModel.Container()
        Dim lblEnteredDate As System.Windows.Forms.Label
        Dim lblTimeIN As System.Windows.Forms.Label
        Dim lblTimeOut As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PrimeCat))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblTotalHours = New System.Windows.Forms.Label()
        Me.btnEditTime = New System.Windows.Forms.Button()
        Me.btnKill = New System.Windows.Forms.Button()
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
        Me.MnuDays = New System.Windows.Forms.MenuStrip()
        Me.DaysToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MonToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TeuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WedToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThuToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FriToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SatToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SunToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnPunchOut = New System.Windows.Forms.Button()
        Me.btnPunchIn = New System.Windows.Forms.Button()
        Me.EnteredDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.txtTimeIN = New System.Windows.Forms.TextBox()
        Me.txtTimeOut = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.btnRmove = New System.Windows.Forms.Button()
        Me.DataViewManager1 = New System.Data.DataViewManager()
        Me.DataView1 = New System.Data.DataView()
        Me.TimeStampsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HariWorkHoursDataSet = New Hari_Hour_Calculator.HariWorkHoursDataSet()
        Me.TimeStampsTableAdapter = New Hari_Hour_Calculator.HariWorkHoursDataSetTableAdapters.TimeStampsTableAdapter()
        Me.TableAdapterManager = New Hari_Hour_Calculator.HariWorkHoursDataSetTableAdapters.TableAdapterManager()
        lblEnteredDate = New System.Windows.Forms.Label()
        lblTimeIN = New System.Windows.Forms.Label()
        lblTimeOut = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        Me.MnuDays.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TimeStampsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HariWorkHoursDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblEnteredDate
        '
        lblEnteredDate.AutoSize = True
        lblEnteredDate.Location = New System.Drawing.Point(471, 237)
        lblEnteredDate.Name = "lblEnteredDate"
        lblEnteredDate.Size = New System.Drawing.Size(61, 13)
        lblEnteredDate.TabIndex = 24
        lblEnteredDate.Text = "Enter Date:"
        lblEnteredDate.Visible = False
        '
        'lblTimeIN
        '
        lblTimeIN.AutoSize = True
        lblTimeIN.Location = New System.Drawing.Point(530, 260)
        lblTimeIN.Name = "lblTimeIN"
        lblTimeIN.Size = New System.Drawing.Size(44, 13)
        lblTimeIN.TabIndex = 25
        lblTimeIN.Text = "Time in:"
        lblTimeIN.Visible = False
        '
        'lblTimeOut
        '
        lblTimeOut.AutoSize = True
        lblTimeOut.Location = New System.Drawing.Point(524, 287)
        lblTimeOut.Name = "lblTimeOut"
        lblTimeOut.Size = New System.Drawing.Size(51, 13)
        lblTimeOut.TabIndex = 26
        lblTimeOut.Text = "Time out:"
        lblTimeOut.Visible = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(158, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(440, 31)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Welcome to Hari Hour Calculator"
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
        'btnEditTime
        '
        Me.btnEditTime.Enabled = False
        Me.btnEditTime.Location = New System.Drawing.Point(32, 203)
        Me.btnEditTime.Name = "btnEditTime"
        Me.btnEditTime.Size = New System.Drawing.Size(102, 23)
        Me.btnEditTime.TabIndex = 3
        Me.btnEditTime.Text = "Edit Time"
        Me.btnEditTime.UseVisualStyleBackColor = True
        '
        'btnKill
        '
        Me.btnKill.Location = New System.Drawing.Point(32, 232)
        Me.btnKill.Name = "btnKill"
        Me.btnKill.Size = New System.Drawing.Size(102, 23)
        Me.btnKill.TabIndex = 7
        Me.btnKill.Text = "Quit"
        Me.btnKill.UseVisualStyleBackColor = True
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
        'btnPunchOut
        '
        Me.btnPunchOut.Location = New System.Drawing.Point(32, 174)
        Me.btnPunchOut.Name = "btnPunchOut"
        Me.btnPunchOut.Size = New System.Drawing.Size(102, 23)
        Me.btnPunchOut.TabIndex = 20
        Me.btnPunchOut.Text = "Punch Out"
        Me.btnPunchOut.UseVisualStyleBackColor = True
        '
        'btnPunchIn
        '
        Me.btnPunchIn.Location = New System.Drawing.Point(32, 145)
        Me.btnPunchIn.Name = "btnPunchIn"
        Me.btnPunchIn.Size = New System.Drawing.Size(102, 23)
        Me.btnPunchIn.TabIndex = 21
        Me.btnPunchIn.Text = "Punch In"
        Me.btnPunchIn.UseVisualStyleBackColor = True
        '
        'EnteredDateDateTimePicker
        '
        Me.EnteredDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TimeStampsBindingSource, "EnteredDate", True))
        Me.EnteredDateDateTimePicker.Location = New System.Drawing.Point(533, 231)
        Me.EnteredDateDateTimePicker.Name = "EnteredDateDateTimePicker"
        Me.EnteredDateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.EnteredDateDateTimePicker.TabIndex = 25
        Me.EnteredDateDateTimePicker.Visible = False
        '
        'txtTimeIN
        '
        Me.txtTimeIN.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TimeStampsBindingSource, "TimeIN", True))
        Me.txtTimeIN.Location = New System.Drawing.Point(583, 257)
        Me.txtTimeIN.Name = "txtTimeIN"
        Me.txtTimeIN.Size = New System.Drawing.Size(100, 20)
        Me.txtTimeIN.TabIndex = 26
        Me.txtTimeIN.Visible = False
        '
        'txtTimeOut
        '
        Me.txtTimeOut.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TimeStampsBindingSource, "TimeOut", True))
        Me.txtTimeOut.Location = New System.Drawing.Point(583, 284)
        Me.txtTimeOut.Name = "txtTimeOut"
        Me.txtTimeOut.Size = New System.Drawing.Size(100, 20)
        Me.txtTimeOut.TabIndex = 27
        Me.txtTimeOut.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.TimeStampsBindingSource, "EnteredDate", True))
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(176, 56)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(569, 305)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(457, 329)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 28
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        Me.btnAdd.Visible = False
        '
        'BtnEdit
        '
        Me.BtnEdit.Location = New System.Drawing.Point(538, 329)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(75, 23)
        Me.BtnEdit.TabIndex = 29
        Me.BtnEdit.Text = "Edit"
        Me.BtnEdit.UseVisualStyleBackColor = True
        Me.BtnEdit.Visible = False
        '
        'btnRmove
        '
        Me.btnRmove.Location = New System.Drawing.Point(619, 329)
        Me.btnRmove.Name = "btnRmove"
        Me.btnRmove.Size = New System.Drawing.Size(75, 23)
        Me.btnRmove.TabIndex = 30
        Me.btnRmove.Text = "Remove"
        Me.btnRmove.UseVisualStyleBackColor = True
        Me.btnRmove.Visible = False
        '
        'DataViewManager1
        '
        Me.DataViewManager1.DataViewSettingCollectionString = ""
        '
        'TimeStampsBindingSource
        '
        Me.TimeStampsBindingSource.DataMember = "TimeStamps"
        Me.TimeStampsBindingSource.DataSource = Me.HariWorkHoursDataSet
        '
        'HariWorkHoursDataSet
        '
        Me.HariWorkHoursDataSet.DataSetName = "HariWorkHoursDataSet"
        Me.HariWorkHoursDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TimeStampsTableAdapter
        '
        Me.TimeStampsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.TimeStampsTableAdapter = Me.TimeStampsTableAdapter
        Me.TableAdapterManager.UpdateOrder = Hari_Hour_Calculator.HariWorkHoursDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PrimeCat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(757, 388)
        Me.Controls.Add(Me.btnRmove)
        Me.Controls.Add(Me.BtnEdit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(lblTimeOut)
        Me.Controls.Add(Me.txtTimeOut)
        Me.Controls.Add(lblTimeIN)
        Me.Controls.Add(Me.txtTimeIN)
        Me.Controls.Add(lblEnteredDate)
        Me.Controls.Add(Me.EnteredDateDateTimePicker)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnPunchIn)
        Me.Controls.Add(Me.btnPunchOut)
        Me.Controls.Add(Me.btnKill)
        Me.Controls.Add(Me.btnEditTime)
        Me.Controls.Add(Me.lblTotalHours)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Controls.Add(Me.MnuDays)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "PrimeCat"
        Me.Text = "Hari Hour Calculator"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.MnuDays.ResumeLayout(False)
        Me.MnuDays.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TimeStampsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HariWorkHoursDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblTotalHours As Label
    Friend WithEvents btnEditTime As Button
    Friend WithEvents btnKill As Button
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
    Friend WithEvents MnuDays As MenuStrip
    Friend WithEvents DaysToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MonToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TeuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WedToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ThuToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents FriToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SatToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SunToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents btnPunchOut As Button
    Friend WithEvents btnPunchIn As Button
    Friend WithEvents HariWorkHoursDataSet As HariWorkHoursDataSet
    Friend WithEvents TimeStampsBindingSource As BindingSource
    Friend WithEvents TimeStampsTableAdapter As HariWorkHoursDataSetTableAdapters.TimeStampsTableAdapter
    Friend WithEvents TableAdapterManager As HariWorkHoursDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EnteredDateDateTimePicker As DateTimePicker
    Friend WithEvents txtTimeIN As TextBox
    Friend WithEvents txtTimeOut As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents btnRmove As Button
    Friend WithEvents DataViewManager1 As DataViewManager
    Friend WithEvents DataView1 As DataView
End Class
