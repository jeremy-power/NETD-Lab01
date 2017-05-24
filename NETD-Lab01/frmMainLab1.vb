' ---------------------------------------------'
' Name: Jeremy Power 100523300                 '
' Name: Connlaoi Smith 100483385               '
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

    ''' <summary>
    ''' Loads combo box items from array of drinks
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub frmMainLab1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbxDrinks.DataSource = drinkNames
    End Sub
#End Region

    ''' <summary>
    ''' Handles input validation when the user clicks out of text validation
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub txtDrinks_LostFocus(sender As Object, e As EventArgs) Handles txtDrinks.LostFocus
        'upon user clicking outside of textbox, checks whether input is valid unless
        'clicking on clear or exit
        If Not IsValid() And Not btnExit.Focused And Not btnClear.Focused Then
            'displays error if not valid
            MessageBox.Show("# of drinks must a be a whole number between 1 and 5", "Number of Drinks Error")
        End If
    End Sub
    ''' <summary>
    ''' Event Handler for Exit Button
    ''' </summary>  
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'closes the form
        Me.Close()
    End Sub

    ''' <summary>
    ''' Handles clicking the clear button
    ''' Clears all input and output fields
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'calls set default when clear button is clicked
        SetDefaults()
    End Sub

    ''' <summary>
    ''' Handles the Calculate button click, 
    ''' checks for input validation, if input
    ''' passes it calls calcOrder
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'ensures the text box is not empty to avoid errors
        If txtDrinks.Text IsNot "" Then
            'calculates the total
            Call CalcOrder(txtDrinks.Text)
        End If
    End Sub

    ''' <summary>
    ''' Sets default options for each input value
    ''' </summary>
    Private Sub SetDefaults()
        'clears drink input fields
        txtDrinks.Clear()

        'sets all output labels to "$0.00"
#Region "Default Label Values"
        lblDrinkVal.Text = "$0.00"
        lblMealVal.Text = "$0.00"
        lblSnackVal.Text = "$0.00"
        lblSubVal.Text = "$0.00"
        lblESTVal.Text = "$0.00"
        lblTotalVal.Text = "$0.00"
#End Region

        'clears all meal radio buttons
        For Each radBut As RadioButton In grpMeals.Controls
            radBut.Checked = False
        Next
        'sets meal to default
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
    Private Sub CalcOrder(drinksInt As Integer)
        'defines total for each section to be displayed
#Region "Total Variables"
        Dim drinkTotal As Decimal = 0.00
        Dim mealTotal As Decimal = 0.00
        Dim snackTotal As Decimal = 0.00

        Dim taxTotal As Decimal = 0.00
        Dim subTotal As Decimal = 0.00
        Dim finalTotal As Decimal = 0.00

#End Region

#Region "Drink Calculations"
        Dim i As Integer = 0
        For Each item As String In drinkNames
            If cbxDrinks.SelectedItem = item Then
                drinkTotal += drinkPrices(i) * drinksInt
            End If
            i += 1
        Next
#End Region

        'sets output to drink value
        lblDrinkVal.Text = FormatCurrency(drinkTotal)
        'adds drinks to final total
        subTotal += drinkTotal
#Region "Meal Calculations"
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
#End Region

        'sets output to meal value
        lblMealVal.Text = FormatCurrency(mealTotal)
        'adds meals to final total
        subTotal += mealTotal
#Region "Snack Calculations"
        'calculates snack price based on selected checkboxes
        If cbxTusken.Checked Then
            snackTotal += tuskenPrice
        End If
        If cbxEopie.Checked Then
            snackTotal += eopiePrice
        End If
        If cbxDung.Checked Then
            snackTotal += dungPrice
        End If
#End Region

        'sets output to snack value
        lblSnackVal.Text = FormatCurrency(snackTotal)
        'adds snacks to final total
        subTotal += snackTotal

        'sets output value to final total
        lblSubVal.Text = FormatCurrency(subTotal)

        'if water is selected, calculate without tax on water
        If cbxDrinks.SelectedItem = "Water" Then
            taxTotal = calculateTax(subTotal, TAX_RATE, drinksInt, True)
        Else
            'otherwise calculate tax
            taxTotal = calculateTax(subTotal, TAX_RATE, drinksInt, False)
        End If
        'prints out amount of tax
        lblESTVal.Text = FormatCurrency(taxTotal)

        'calculates subtotal + tax
        finalTotal = subTotal + taxTotal

        'prints final total
        lblTotalVal.Text = FormatCurrency(finalTotal)

    End Sub

    ''' <summary>
    ''' Calculates the tax on the subtotal based
    ''' on the constant tax rate and whether or not
    ''' there is water in the order
    ''' </summary>
    ''' <param name="SubTotal"></param>
    ''' <param name="TaxRate"></param>
    ''' <param name="drinkNum"></param>
    ''' <param name="containsWater"></param>
    ''' <returns></returns>
    Private Function CalculateTax(SubTotal As Double,
                                  TaxRate As Double,
                                  drinkNum As Integer,
                                  containsWater As Boolean) As Double
        'If there is water in the order, subtract that from the subtotal
        'and calculate tax on that
        If containsWater Then
            Return (SubTotal - (drinkPrices(7) * drinkNum)) * TaxRate
            'Otherwise calculates 20% of subtotal
        Else
            Return SubTotal * TaxRate
        End If
    End Function

    ''' <summary>
    ''' Returns true if txtDrinks input is valid
    ''' false if not
    ''' </summary>
    ''' <returns></returns>
    Private Function IsValid() As Boolean
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