Public Class frmMainLab1
#Region "Variable Declaration"
    'drink prices
    Private Const banthPrice As Integer = 3000
    Private Const turboPrice As Integer = 1500
    Private Const galaxyPrice As Integer = 2500
    Private Const alderaanPrice As Integer = 2000
    Private Const spicedPrice As Integer = 3500
    Private Const deathPrice As Integer = 4000
    'meal prices
    Private Const steakPrice As Integer = 6500
    Private Const wompratPrice As Integer = 4000
    Private Const zuccaPrice As Integer = 4500
    Private Const squillPrice As Integer = 5000
    'snack prices
    Private Const tuskenPrice As Integer = 1500
    Private Const eopiePrice As Integer = 1250
    Private Const dungPrice As Integer = 1000

#End Region

    ''' <summary>
    ''' Event Handler for Exit Button
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    ''' <summary>
    ''' Handles clicking the clear button
    ''' Clears all input and output fields
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        'clears drink input fields
        txtDrinks.Clear()
        lbxDrinkType.ClearSelected()

        'sets all output labels to "$0.00"
        lblDrinkVal.Text = "$0.00"
        lblMealVal.Text = "$0.00"
        lblSnackVal.Text = "$0.00"
        lblTotalVal.Text = "$0.00"

        'clears all meal radio buttons
        For Each radBut As RadioButton In grpMeals.Controls
            radBut.Checked = False
        Next

        'clears all snack checkboxes
        For Each cbx As CheckBox In grpSnacks.Controls
            cbx.Checked = False
        Next

    End Sub

    ''' <summary>
    ''' Handles the Calculate button click, 
    ''' checks for input validation, if input
    ''' passes it calls calcOrder
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'drink text box validation

        'variable to hold valid drink number
        Dim drinksInt As Integer

        'checks if input is valid
        If Int32.TryParse(txtDrinks.Text.Trim, drinksInt) Then

            'checks if valid drink number between 1 and 5
            If drinksInt > 0 And drinksInt < 6 Then

                'checks if drink box empty
                If lbxDrinkType.SelectedIndex = -1 Then
                    MessageBox.Show("Must select a drink type")


                Else
                    'checks each meal radio button to ensure one is checked
                    Dim mealSelected As Boolean = False
                    For Each radbut As RadioButton In grpMeals.Controls
                        If radbut.Checked Then
                            mealSelected = True
                        End If
                    Next
                    'prints error if no radio button is checked
                    If Not mealSelected Then
                        MessageBox.Show("Must select a meal")

                        'if all input passes validation, proceeds with calculation
                    Else
                        Call calcOrder(drinksInt)
                    End If
                End If

                'Error handle for drink number not between 1 and 5
            Else
                MessageBox.Show("Must a be a whole number between 1 and 5")
                txtDrinks.Focus()
            End If
            'Error handle for invalid drink number (decimal or string)
        Else
            MessageBox.Show("Must a be a whole number between 1 and 5", "Error")
            txtDrinks.Focus()
            End If
    End Sub

    ''' <summary>
    ''' Takes in the integer number of drinks
    ''' checked by input validation and calculates
    ''' the $ total of each food/drink and sets
    ''' label text values to the output
    ''' </summary>
    ''' <param name="drinksInt"></param>
    Private Sub calcOrder(ByVal drinksInt As Integer)
        Dim drinkTotal As Integer = 0
        Dim mealTotal As Integer = 0
        Dim snackTotal As Integer = 0

        Dim totalAmount As Integer = 0

        Select Case lbxDrinkType.SelectedItem
            Case "Banth-Blood Fizz"
                drinkTotal = drinksInt * banthPrice
            Case "Galaxy Guzzler"
                drinkTotal = drinksInt * galaxyPrice
            Case "Alderaan Twist"
                drinkTotal = drinksInt * alderaanPrice
            Case "Spiced Jedi Mindbender"
                drinkTotal = drinksInt * spicedPrice
            Case "Turbo Fizz"
                drinkTotal = drinksInt * turboPrice
            Case "Death Starfruit Punch"
                drinkTotal = drinksInt * deathPrice
        End Select

        lblDrinkVal.Text = FormatCurrency(drinkTotal)
        totalAmount += drinkTotal

        If radBantha.Checked Then
            mealTotal = banthPrice
        ElseIf radWomprat.Checked Then
            mealTotal = wompratPrice
        ElseIf radZucca.Checked Then
            mealTotal = zuccaPrice
        ElseIf radSquill.Checked Then
            mealTotal = squillPrice
        End If
        lblMealVal.Text = FormatCurrency(mealTotal)
        totalAmount += mealTotal

        If cbxTusken.Checked Then
            snackTotal += tuskenPrice
        End If
        If cbxEopie.Checked Then
            snackTotal += eopiePrice
        End If
        If cbxDung.Checked Then
            snackTotal += dungPrice
        End If
        lblSnackVal.Text = FormatCurrency(snackTotal)
        totalAmount += snackTotal

        lblTotalVal.Text = FormatCurrency(totalAmount)

    End Sub

    ''' <summary>
    ''' Handler for music check button, 
    ''' plays music when checked on, 
    ''' stops it when checked off
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnMusic_CheckedChanged(sender As Object, e As EventArgs) Handles btnMusic.CheckedChanged

        'checks if it is checking or unchecking
        If btnMusic.Checked = True Then
            'plays music
            My.Computer.Audio.Play(My.Resources.Cantina, AudioPlayMode.BackgroundLoop)
        Else
            'stops music
            My.Computer.Audio.Stop()
        End If

    End Sub
End Class