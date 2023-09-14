Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class PayRoll

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        ' Declarations for employee information and calculations
        Dim empName As String
        Dim hrWage As Double
        Dim hrsWorked As Double
        Dim exemptions As Integer
        Dim mStatus As String
        Dim prevPay As Double
        Dim pay As Double
        Dim totalPay As Double
        Dim ficaTax As Double
        Dim FedTax As Double
        Dim check As Double

        ' Validate and process data
        If ValidateData(empName, hrWage, hrsWorked, exemptions, mStatus, prevPay) Then
            ' Calculate payroll and display results
            pay = Gross_Pay(hrWage, hrsWorked)
            totalPay = Total_Pay(prevPay, pay)
            ficaTax = FICA_Tax(pay, prevPay, totalPay)
            FedTax = Fed_Tax(pay, exemptions, mStatus)
            check = Net_Check(pay, ficaTax, FedTax)
            ShowPayroll(empName, pay, totalPay, ficaTax, FedTax, check)
        End If
    End Sub

    Private Sub InputFields_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged, TextBox3.TextChanged, TextBox4.TextChanged, TextBox5.TextChanged, TextBox6.TextChanged
        ' Call the calculation method when any input field changes
        CalculatePayroll()
    End Sub

    ' Move the calculations to a separate method
    Private Sub CalculatePayroll()
        Dim empName As String = TextBox1.Text
        Dim hrWage As Double = CDbl(TextBox2.Text)
        Dim hrsWorked As Double = CInt(TextBox3.Text)
        Dim exemptions As Integer = CInt(TextBox4.Text)
        Dim mStatus As String = TextBox5.Text.ToUpper.Substring(0, 1)
        Dim prevPay As Double = CDbl(TextBox6.Text)

        Dim pay As Double = Gross_Pay(hrWage, hrsWorked)
        Dim totalPay As Double = Total_Pay(prevPay, pay)
        Dim ficaTax As Double = FICA_Tax(pay, prevPay, totalPay)
        Dim fedTax As Double = Fed_Tax(pay, exemptions, mStatus)
        Dim check As Double = Net_Check(pay, ficaTax, fedTax)

        ' Display payroll information
        ShowPayroll(empName, pay, totalPay, ficaTax, fedTax, check)
    End Sub

    ' Function to validate employee data
    Function ValidateData(ByRef empName As String, ByRef hrWage As Double, ByRef hrsWorked As Double, ByRef exemptions As Integer, ByRef mStatus As String, ByRef prevPay As Double) As Boolean
        Dim isValid As Boolean = True

        If String.IsNullOrEmpty(empName) Then
            MessageBox.Show("Employee name cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            isValid = False
        End If

        If Not Double.TryParse(TextBox2.Text, hrWage) Or hrWage < 0 Then
            MessageBox.Show("Hourly wage must be a non-negative number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            isValid = False
        End If

        If Not Double.TryParse(TextBox3.Text, hrsWorked) Or hrsWorked < 0 Then
            MessageBox.Show("Hours worked must be a non-negative number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            isValid = False
        End If

        If Not Double.TryParse(TextBox4.Text, exemptions) Or exemptions < 0 Then
            MessageBox.Show("Number of exemptions must be a non-negative number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            isValid = False
        End If

        If String.IsNullOrEmpty(mStatus) Then
            MessageBox.Show("Marital status cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            isValid = False
        End If

        ' ... Add similar validation for other fields

        Return isValid
    End Function

        ' Input employee data
        InputData(empName, hrWage, hrsWorked, exemptions, mStatus, prevPay)
        
        ' Calculate gross pay
        pay = Gross_Pay(hrWage, hrsWorked)
        
        ' Calculate total pay including previous earnings
        totalPay = Total_Pay(prevPay, pay)
        
        ' Calculate FICA taxes
        ficaTax = FICA_Tax(pay, prevPay, totalPay)
        
        ' Calculate Federal income tax
        FedTax = Fed_Tax(pay, exemptions, mStatus)
        
        ' Calculate net paycheck
        check = Net_Check(pay, ficaTax, FedTax)
        
        ' Display payroll information
        ShowPayroll(empName, pay, totalPay, ficaTax, FedTax, check)

    End Sub

    ' Function to input employee data
    Sub InputData(ByRef empName As String, ByRef hrWage As Double, ByRef hrsWorked As Double, ByRef exemptions As Integer, ByRef mStatus As String, ByRef PrevPay As Double)
        empName = TextBox1.Text
        hrWage = CDbl(TextBox2.Text)
        hrsWorked = CInt(TextBox3.Text)
        exemptions = CInt(TextBox4.Text)
        mStatus = TextBox5.Text.ToUpper.Substring(0, 1)
        PrevPay = CDbl(TextBox6.Text)
    End Sub

    ' Tax calculation function for single employees
    Function Taxsingle(ByVal adjpay As Double) As Double
        ' Tax brackets and calculations based on adjusted pay
        Select Case adjpay
            Case 0 To 51
                Return 0
            Case 51 To 164
                Return 0.1 * (adjpay - 51)
            Case 164 To 570
                Return 11.3 + 0.15 * (adjpay - 164)
            Case 570 To 1247
                Return 72.2 + 0.27 * (adjpay - 570)
            Case 1247 To 2749
                Return 254.99 + 0.3 * (adjpay - 1247)
            Case 2749 To 5938
                Return 705.59 + 0.35 * (adjpay - 2749)
            Case Is > 5938
                Return 1821.74 + 0.386 * (adjpay - 5938)
        End Select
    End Function

    ' Tax calculation function for married employees
    Function TaxMarried(ByVal adjPay As Double) As Double
        ' Tax brackets and calculations based on adjusted pay
        Select Case adjPay
            Case 0 To 124
                Return 0
            Case 124 To 355
                Return 0.1 * (adjPay - 124)
            Case 355 To 991
                Return 23.1 + 0.15 * (adjPay - 355)
            Case 991 To 2110
                Return 118.5 + 0.27 * (adjPay - 991)
            Case 2110 To 3400
                Return 420.63 + 0.3 * (adjPay - 2110)
            Case 3400 To 5998
                Return 807.63 + 0.35 * (adjPay - 3400)
            Case Is > 5998
                Return 1716.93 + 0.386 * (adjPay - 5998)
        End Select

    End Function

    ' Calculate Federal income tax
    Function Fed_Tax(ByVal pay As Double, ByVal exemptions As Integer, ByVal mStatus As String) As Double
        ' Calculate adjusted pay and tax based on marital status
        Dim adjPay As Double
        Dim tax As Double

        adjPay = pay - (55.77 * exemptions)

        If adjPay < 0 Then
            adjPay = 0
        End If
        If mStatus = "S" Then
            tax = Taxsingle(adjPay)
        Else
            tax = TaxMarried(adjPay)
        End If

        Return Math.Round(tax, 2)
    End Function

    ' Calculate FICA taxes
    Function FICA_Tax(ByVal pay As Double, ByVal prevPay As Double, ByVal totalPay As Double) As Double
        ' Calculate social security and medicare taxes
        Dim socialSecurity As Double
        Dim medicare As Double
        Dim sum As Double

        If totalPay <= 84900 Then
            socialSecurity = 0.062 * pay
        ElseIf prevPay < 84900 Then
            socialSecurity = 0.062 * (84900 - prevPay)
        End If

        medicare = 0.0145 * pay
        sum = socialSecurity + medicare
        FICA_Tax = Math.Round(sum, 2)
    End Function

    ' Calculate gross pay
    Function Gross_Pay(ByVal hrWage As Double, ByVal hrsWorked As Double) As Double
        ' Calculate gross pay based on hours worked and hourly wage
        If hrsWorked <= 40 Then
            Return hrsWorked * hrWage
        Else
            Return 40 * hrWage + (hrsWorked - 40) * 1.5 * hrWage
        End If

    End Function

    ' Calculate net paycheck
    Function Net_Check(ByVal pay As Double, ByVal ficaTax As Double, ByVal fedTAx As Double) As Double
        ' Calculate net pay after deductions
        Return pay - ficaTax - fedTAx
    End Function

    ' Calculate total pay including previous earnings
    Function Total_Pay(ByVal prevPay As Double, ByVal pay As Double) As Double
        Return prevPay + pay
    End Function

    ' Clear input fields
    Private Sub Button2_Click(sender As Object, e As EventArgs)
        ' Clear input fields and output list box
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        lsb_Output.Items.Clear()

    End Sub


    Sub ShowPayroll(ByVal empName As String, ByVal pay As Double, ByVal totalPay As Double, ByVal ficaTax As Double, ByVal fedTax As Double, ByVal check As Double)
        ' Format and display payroll results
        Dim fmtStr As String = "{0,24} {1,-10:C}"
        With lsb_Output.Items
            .Add("Payroll results for " & empName)
            .Add("")
            .Add(String.Format(fmtStr, "Gross pay this period:", pay))
            .Add("")
            .Add(String.Format(fmtStr, "Year-to-date earnings:", totalPay))
            .Add("")
            .Add(String.Format(fmtStr, "Fica Taxes this period:", ficaTax))
            .Add("")
            .Add(String.Format(fmtStr, "Income tax withheld:", fedTax))
            .Add("")
            .Add(String.Format(fmtStr, "Net pay (check amount):", check))
            .Add("")
        End With
    End Sub

    ' Event handler for Button3_Click
    Private Sub Button3_Click(sender As Object, e As EventArgs)
        ' Close the application
        Close()

    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        ' Get employee data from UI controls
        Dim empName As String = TextBox1.Text
        Dim hrWage As Double = CDbl(TextBox2.Text)
        ' ... (get other employee data)

        ' Create a CSV-formatted string
        Dim employeeData As String = $"{empName},{hrWage},{ ...}"

        ' Open or create the file for writing
        Dim filePath As String = "employee_data.csv"
        Using writer As New System.IO.StreamWriter(filePath, True)
            writer.WriteLine(employeeData)
        End Using
    End Sub

    Private Sub LoadButton_Click(sender As Object, e As EventArgs) Handles LoadButton.Click
        Dim filePath As String = "employee_data.csv"

        If System.IO.File.Exists(filePath) Then
            Dim lines As String() = System.IO.File.ReadAllLines(filePath)

            For Each line As String In lines
                Dim data As String() = line.Split(","c)
                ' Extract and populate employee data into UI controls
                TextBox1.Text = data(0) ' Employee name
                TextBox2.Text = data(1) ' Hourly wage
                ' ... (populate other employee data)
            Next
        Else
            MessageBox.Show("No saved employee data found.")
        End If
    End Sub

    Private Sub PayRoll_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class