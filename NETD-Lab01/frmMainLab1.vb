' ---------------------------------------------'
' Name: Jeremy Power 100523300                 '
' Date: May 16, 2017                           '
' Purpose: Lab 1B                              '
' Description: Cantina Order Form              '
' Allows the user to enter a number of drinks  '
' between 1 and 5, choose from a type of drink,'
' meal and any of 3 snacks, if input is valid  '
' it will provide an output of 3 calculated    '
' total pricess and an overall total.          '
' ---------------------------------------------'
Public Class frmMainLab1
#Region "Variable Declaration"
    Const TAX_RATE As Decimal = 0.2

    'meal prices
    Const steakPrice As Decimal = 6500.0
    Const wompratPrice As Decimal = 4000.0
    Const zuccaPrice As Decimal = 4500.0
    Const squillPrice As Decimal = 5000.0
    'snack prices
    Const tuskenPrice As Decimal = 1500.0
    Const eopiePrice As Decimal = 1250.0
    Const dungPrice As Decimal = 1000.0
    'set drink prices
    Dim drinkNames = New String(7) {"Banth-Blood Fizz", "Galaxy Guzzler", "Alderaan Twist", "Spiced Jedi Mindbender", "Turbo Fizz", "Death Starfruit Punch", "Bespin Vapour", "Water"}
    Dim drinkPrices = New Decimal(7) {3000.0, 1500.0, 2500.0, 2000.0, 3500.0, 4000.0, 10000.0, 1000.0}
    Private Sub frmMainLab1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbxDrinks.DataSource = drinkNames
    End Sub
#End Region

    Private Sub txtDrinks_LostFocus(sender As Object, e As EventArgs) Handles txtDrinks.LostFocus
        If Not isValid() And Not btnExit.Focused And Not btnClear.Focused Then
            MessageBox.Show("# of drinks must a be a whole number between 1 and 5", "Number of Drinks Error")
        End If
    End Sub
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
        setDefaults()
    End Sub

    ''' <summary>
    ''' Handles the Calculate button click, 
    ''' checks for input validation, if input
    ''' passes it calls calcOrder
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        If txtDrinks.Text IsNot "" Then
            Call calcOrder(txtDrinks.Text)
        End If
    End Sub

    Private Sub setDefaults()
        'clears drink input fields
        txtDrinks.Clear()

        'sets all output labels to "$0.00"
        lblDrinkVal.Text = "$0.00"
        lblMealVal.Text = "$0.00"
        lblSnackVal.Text = "$0.00"
        lblSubVal.Text = "$0.00"
        lblESTVal.Text = "$0.00"
        lblTotalVal.Text = "$0.00"

        'clears all meal radio buttons
        For Each radBut As RadioButton In grpMeals.Controls
            radBut.Checked = False
        Next
        radNoMeal.Checked = True

        'clears all snack checkboxes
        For Each cbx As CheckBox In grpSnacks.Controls
            cbx.Checked = False
        Next

        txtDrinks.Focus()

    End Sub

    ''' <summary>
    ''' Takes in the integer number of drinks
    ''' checked by input validation and calculates
    ''' the $ total of each food/drink and sets
    ''' label text values to the output
    ''' </summary>
    ''' <param name="drinksInt"></param>
    Private Sub calcOrder(drinksInt As Integer)
        'defines total for each section to be displayed
        Dim drinkTotal As Decimal = 0.00
        Dim mealTotal As Decimal = 0.00
        Dim snackTotal As Decimal = 0.00

        Dim taxTotal As Decimal
        Dim subTotal As Decimal = 0.00
        Dim finalTotal As Decimal = 0.00

        Dim i As Integer = 0
        For Each item As String In drinkNames
            If cbxDrinks.SelectedItem = item Then
                drinkTotal += drinkPrices(i) * drinksInt
            End If
            i += 1
        Next

        'sets output to drink value
        lblDrinkVal.Text = FormatCurrency(drinkTotal)
        'adds drinks to final total
        subTotal += drinkTotal

        'calculates meal price based on radio button selection
        If radSteak.Checked Then
            mealTotal = steakPrice
        ElseIf radWomprat.Checked Then
            mealTotal = wompratPrice
        ElseIf radZucca.Checked Then
            mealTotal = zuccaPrice
        ElseIf radSquill.Checked Then
            mealTotal = squillPrice
        End If

        'sets output to meal value
        lblMealVal.Text = FormatCurrency(mealTotal)
        'adds meals to final total
        subTotal += mealTotal

        'calculates snack price based on each checkbox
        If cbxTusken.Checked Then
            snackTotal += tuskenPrice
        End If
        If cbxEopie.Checked Then
            snackTotal += eopiePrice
        End If
        If cbxDung.Checked Then
            snackTotal += dungPrice
        End If

        'sets output to snack value
        lblSnackVal.Text = FormatCurrency(snackTotal)
        'adds snacks to final total
        subTotal += snackTotal

        'sets output value to final total
        lblSubVal.Text = FormatCurrency(subTotal)

        If cbxDrinks.SelectedItem = "Water" Then
            taxTotal = calculateTax(subTotal, TAX_RATE, drinksInt, True)
        Else
            taxTotal = calculateTax(subTotal, TAX_RATE, drinksInt, False)
        End If
        lblESTVal.Text = FormatCurrency(taxTotal)

        finalTotal = subTotal + taxTotal
        lblTotalVal.Text = FormatCurrency(finalTotal)

    End Sub

    Private Function calculateTax(SubTotal As Double,
                                  TaxRate As Double,
                                  drinkNum As Integer,
                                  containsWater As Boolean) As Double
        If containsWater Then
            Return (SubTotal - (drinkPrices(7) * drinkNum)) * TaxRate
        Else
            Return SubTotal * TaxRate
        End If
    End Function

    Private Function isValid() As Boolean
        Dim drinksInt As Integer
        'checks if input is valid

        If Int32.TryParse(txtDrinks.Text.Trim, drinksInt) Then
            'checks if valid drink number between 1 and 5
            If drinksInt > 0 And drinksInt < 6 Then
                Return True
                'Error handle for drink number not between 1 and 5
            Else
                Return False
            End If
            'Error handle for invalid drink number (decimal or string)
        Else
            Return False
        End If

    End Function

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