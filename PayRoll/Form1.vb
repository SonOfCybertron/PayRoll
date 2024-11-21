Imports System.ComponentModel

Public Class Form1

    Private Employees As New BindingList(Of Employee)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set up DataGridView to use the Employees list
        dgvEmployees.DataSource = Employees
        dgvEmployees.AutoGenerateColumns = True
    End Sub

    Private Sub btnAddEmployee_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            ' Create a new Employee object and add it to the list
            Dim employee As New Employee With {
                .FirstName = txtFirstName.Text,
                .LastName = txtLastName.Text,
                .Position = txtPosition.Text,
                .BasicSalary = Convert.ToDecimal(txtBasicSalary.Text),
                .OtherDeductions = Convert.ToDecimal(txtOtherDeductions.Text)
            }
            Employees.Add(employee)
            ClearInputFields()
        Catch ex As Exception
            MessageBox.Show("Please enter valid data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCalculatePayroll_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Calculate payroll for all employees
        For Each employee In Employees
            employee.CalculateDeductions()
            employee.CalculateNetSalary()
        Next
        dgvEmployees.Refresh()
    End Sub

    Private Sub ClearInputFields()
        ' Clear input fields after adding an employee
        txtFirstName.Clear()
        txtLastName.Clear()
        txtPosition.Clear()
        txtBasicSalary.Clear()
        txtOtherDeductions.Clear()
    End Sub
End Class

Public Class Employee
    Public Property FirstName As String
    Public Property LastName As String
    Public Property Position As String
    Public Property BasicSalary As Decimal
    Public Property PagIBIG As Decimal
    Public Property PhilHealth As Decimal
    Public Property OtherDeductions As Decimal
    Public Property NetSalary As Decimal

    Public Sub CalculateDeductions()
        ' Calculate Pag-IBIG and PhilHealth deductions
        PagIBIG = BasicSalary * 0.02D ' Pag-IBIG is 2% of the basic salary
        PhilHealth = BasicSalary * 0.035D ' PhilHealth is 3.5% of the basic salary
    End Sub

    Public Sub CalculateNetSalary()
        ' Calculate net salary after all deductions
        Dim totalDeductions As Decimal = PagIBIG + PhilHealth + OtherDeductions
        NetSalary = BasicSalary - totalDeductions
    End Sub
End Class

