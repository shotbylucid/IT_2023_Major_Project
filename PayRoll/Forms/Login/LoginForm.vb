Imports System.IO

Public Class LoginForm
    Private usersFilePath As String = "C:\YourUserDirectory\users.txt"

    ' Function to check if a password meets the defined strength criteria
    Private Function IsStrongPassword(password As String) As Boolean
        ' Define your password strength criteria here
        Dim minLength As Integer = 8
        Dim hasUppercase As Boolean = password.Any(Function(c) Char.IsUpper(c))
        Dim hasLowercase As Boolean = password.Any(Function(c) Char.IsLower(c))
        Dim hasDigit As Boolean = password.Any(Function(c) Char.IsDigit(c))
        Dim hasSpecialChar As Boolean = password.Any(Function(c) Not Char.IsLetterOrDigit(c))

        Return password.Length >= minLength AndAlso
            hasUppercase AndAlso
            hasLowercase AndAlso
            hasDigit AndAlso
            hasSpecialChar
    End Function

    ' Event handler for the "Login" button click
    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs)
        Dim enteredUsername As String = TextBoxUsername.Text
        Dim enteredPassword As String = TextBoxPassword.Text

        ' Check if the entered username and password are valid
        If AuthenticateUser(enteredUsername, enteredPassword) Then
            LogActivity("Login successful for user: " & enteredUsername)
            MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            LogActivity("Login failed for user: " & enteredUsername)
            LabelError.Text = "Invalid username or password. Please try again."
        End If
    End Sub

    ' Event handler for the "Create Account" button click
    Private Sub ButtonCreateAccount_Click(sender As Object, e As EventArgs)
        Dim enteredUsername As String = TextBoxUsername.Text
        Dim enteredPassword As String = TextBoxPassword.Text

        ' Check if the entered password is strong enough
        If Not IsStrongPassword(enteredPassword) Then
            MessageBox.Show("Please choose a stronger password that meets the criteria.", "Weak Password", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Check if the entered username and password are valid
        If Not String.IsNullOrWhiteSpace(enteredUsername) AndAlso Not String.IsNullOrWhiteSpace(enteredPassword) Then
            If Not UserExists(enteredUsername) Then
                Dim hashedPassword As String = HashPassword(enteredPassword)
                If SaveUserCredentials(enteredUsername, hashedPassword) Then
                    MessageBox.Show("Account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    TextBoxUsername.Clear()
                    TextBoxPassword.Clear()
                Else
                    MessageBox.Show("An error occurred while creating the account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Username already exists. Please choose a different username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Please enter both a username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' Event handler for clearing new user fields
    Private Sub ButtonClearNewUser_Click(sender As Object, e As EventArgs)
        TextBoxUsername.Clear()
        TextBoxPassword.Clear()
        LabelPasswordStrength.Text = ""
    End Sub

    ' Function to check if a user with the given username already exists
    Private Function UserExists(username As String) As Boolean
        Dim userCredentials As List(Of String) = LoadUserCredentials()

        For Each cred In userCredentials
            Dim parts As String() = cred.Split(","c)
            If parts.Length = 2 AndAlso parts(0) = username Then
                Return True
            End If
        Next

        Return False
    End Function

    ' Function to save user credentials to a file
    Private Function SaveUserCredentials(username As String, passwordHash As String) As Boolean
        Try
            Using writer As New StreamWriter(usersFilePath, True)
                writer.WriteLine(username & "," & passwordHash)
            End Using
            Return True
        Catch ex As Exception
            ' Handle file write error
            Return False
        End Try
    End Function

    ' Function to authenticate a user's credentials
    Private Function AuthenticateUser(username As String, password As String) As Boolean
        Dim userCredentials As List(Of String) = LoadUserCredentials()

        For Each cred In userCredentials
            Dim parts As String() = cred.Split(","c)
            If parts.Length = 2 AndAlso parts(0) = username Then
                Dim hashedPassword As String = HashPassword(password)
                Return parts(1) = hashedPassword
            End If
        Next

        Return False
    End Function

    ' Event handler for the "Clear" button click
    'Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
    '    TextBoxUsername.Clear()
    '    TextBoxPassword.Clear()
    '    LabelError.Text = ""
    'End Sub

    ' Function to authenticate a user's credentials
    Private Function AuthenticateUser(username As String, password As String) As Boolean
        Dim userCredentials As List(Of String) = LoadUserCredentials()

        For Each cred In userCredentials
            Dim parts As String() = cred.Split(","c)
            If parts.Length = 2 AndAlso parts(0) = username Then
                Dim hashedPassword As String = HashPassword(password)
                Return parts(1) = hashedPassword
            End If
        Next

        Return False
    End Function

    ' Function to load user credentials from a file
    Private Function LoadUserCredentials() As List(Of String)
        Dim userCredentials As New List(Of String)

        Try
            If File.Exists(usersFilePath) Then
                Using reader As New StreamReader(usersFilePath)
                    While Not reader.EndOfStream
                        userCredentials.Add(reader.ReadLine())
                    End While
                End Using
            End If
        Catch ex As Exception
            ' Handle file read error
            MessageBox.Show("An error occurred while loading user credentials.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return userCredentials
    End Function

    ' Function to log activity
    Private Sub LogActivity(message As String)
        Dim logFilePath As String = "C:\YourLogDirectory\login_activity.log"

        Try
            Using writer As New StreamWriter(logFilePath, True)
                writer.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") & " - " & message)
            End Using
        Catch ex As Exception
            ' Handle log write error
            MessageBox.Show("An error occurred while writing to the log file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Function to hash a password
    Private Function HashPassword(password As String) As String
        ' Implement a secure password hashing function (e.g., bcrypt, PBKDF2)
        ' For demonstration purposes, you can use a simple hash here (not recommended for production)
        Dim sha256 As New System.Security.Cryptography.SHA256CryptoServiceProvider()
        Dim bytes As Byte() = System.Text.Encoding.UTF8.GetBytes(password)
        Dim hash As Byte() = sha256.ComputeHash(bytes)
        Return BitConverter.ToString(hash).Replace("-", "").ToLower()
    End Function

    Private Sub ButtonLogin_Click_1(sender As Object, e As EventArgs) Handles ButtonLogin.Click

    End Sub
End Class