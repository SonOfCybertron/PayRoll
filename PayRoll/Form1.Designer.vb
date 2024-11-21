<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Panel1 = New Panel()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        txtBasicSalary = New TextBox()
        txtPosition = New TextBox()
        txtOtherDeductions = New TextBox()
        txtLastName = New TextBox()
        txtFirstName = New TextBox()
        Panel2 = New Panel()
        Button2 = New Button()
        Button1 = New Button()
        dgvEmployees = New DataGridView()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(dgvEmployees, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(txtBasicSalary)
        Panel1.Controls.Add(txtPosition)
        Panel1.Controls.Add(txtOtherDeductions)
        Panel1.Controls.Add(txtLastName)
        Panel1.Controls.Add(txtFirstName)
        Panel1.Font = New Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Panel1.ForeColor = SystemColors.ButtonFace
        Panel1.Location = New Point(71, 116)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(497, 695)
        Panel1.TabIndex = 0
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.ForeColor = SystemColors.ActiveCaptionText
        Label5.Location = New Point(174, 447)
        Label5.Name = "Label5"
        Label5.Size = New Size(166, 28)
        Label5.TabIndex = 9
        Label5.Text = "Other Deductions"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = SystemColors.ActiveCaptionText
        Label4.Location = New Point(195, 295)
        Label4.Name = "Label4"
        Label4.Size = New Size(113, 28)
        Label4.TabIndex = 8
        Label4.Text = "Basic Salary"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = SystemColors.ActiveCaptionText
        Label3.Location = New Point(212, 163)
        Label3.Name = "Label3"
        Label3.Size = New Size(83, 28)
        Label3.TabIndex = 7
        Label3.Text = "Position"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = SystemColors.ActiveCaptionText
        Label2.Location = New Point(331, 44)
        Label2.Name = "Label2"
        Label2.Size = New Size(98, 28)
        Label2.TabIndex = 6
        Label2.Text = "LastName"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = SystemColors.ActiveCaptionText
        Label1.Location = New Point(70, 44)
        Label1.Name = "Label1"
        Label1.Size = New Size(101, 28)
        Label1.TabIndex = 5
        Label1.Text = "FirstName"
        ' 
        ' txtBasicSalary
        ' 
        txtBasicSalary.BackColor = SystemColors.HotTrack
        txtBasicSalary.Font = New Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtBasicSalary.Location = New Point(160, 326)
        txtBasicSalary.Name = "txtBasicSalary"
        txtBasicSalary.Size = New Size(180, 34)
        txtBasicSalary.TabIndex = 4
        ' 
        ' txtPosition
        ' 
        txtPosition.BackColor = SystemColors.HotTrack
        txtPosition.Font = New Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPosition.Location = New Point(160, 194)
        txtPosition.Name = "txtPosition"
        txtPosition.Size = New Size(180, 34)
        txtPosition.TabIndex = 3
        ' 
        ' txtOtherDeductions
        ' 
        txtOtherDeductions.BackColor = SystemColors.HotTrack
        txtOtherDeductions.Font = New Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtOtherDeductions.Location = New Point(160, 478)
        txtOtherDeductions.Name = "txtOtherDeductions"
        txtOtherDeductions.Size = New Size(180, 34)
        txtOtherDeductions.TabIndex = 2
        ' 
        ' txtLastName
        ' 
        txtLastName.BackColor = SystemColors.HotTrack
        txtLastName.Font = New Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtLastName.Location = New Point(287, 75)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(180, 34)
        txtLastName.TabIndex = 1
        ' 
        ' txtFirstName
        ' 
        txtFirstName.BackColor = SystemColors.HotTrack
        txtFirstName.Font = New Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtFirstName.Location = New Point(30, 75)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(180, 34)
        txtFirstName.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.Control
        Panel2.BorderStyle = BorderStyle.Fixed3D
        Panel2.Controls.Add(Button2)
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(dgvEmployees)
        Panel2.Location = New Point(764, 116)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(497, 695)
        Panel2.TabIndex = 1
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Yu Gothic UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.Black
        Button2.Location = New Point(48, 582)
        Button2.Name = "Button2"
        Button2.Size = New Size(396, 80)
        Button2.TabIndex = 2
        Button2.Text = "Calculate Payroll"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Yu Gothic UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.Black
        Button1.Location = New Point(48, 478)
        Button1.Name = "Button1"
        Button1.Size = New Size(396, 75)
        Button1.TabIndex = 1
        Button1.Text = "Add Employee"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' dgvEmployees
        ' 
        dgvEmployees.AllowUserToOrderColumns = True
        dgvEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvEmployees.Location = New Point(48, 44)
        dgvEmployees.Name = "dgvEmployees"
        dgvEmployees.RowHeadersWidth = 51
        dgvEmployees.Size = New Size(396, 415)
        dgvEmployees.TabIndex = 0
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1335, 967)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "Form1"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        CType(dgvEmployees, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtBasicSalary As TextBox
    Friend WithEvents txtPosition As TextBox
    Friend WithEvents txtOtherDeductions As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents dgvEmployees As DataGridView

End Class
