<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainLab1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainLab1))
        Me.pnlTitle = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.grpDrinks = New System.Windows.Forms.GroupBox()
        Me.lbxDrinkType = New System.Windows.Forms.ListBox()
        Me.lblDrinkType = New System.Windows.Forms.Label()
        Me.txtDrinks = New System.Windows.Forms.TextBox()
        Me.lblDrinkNum = New System.Windows.Forms.Label()
        Me.grpMeals = New System.Windows.Forms.GroupBox()
        Me.radNoMeal = New System.Windows.Forms.RadioButton()
        Me.radSquill = New System.Windows.Forms.RadioButton()
        Me.radZucca = New System.Windows.Forms.RadioButton()
        Me.radWomprat = New System.Windows.Forms.RadioButton()
        Me.radBantha = New System.Windows.Forms.RadioButton()
        Me.grpSnacks = New System.Windows.Forms.GroupBox()
        Me.cbxDung = New System.Windows.Forms.CheckBox()
        Me.cbxEopie = New System.Windows.Forms.CheckBox()
        Me.cbxTusken = New System.Windows.Forms.CheckBox()
        Me.grpCalc = New System.Windows.Forms.GroupBox()
        Me.lblTotalVal = New System.Windows.Forms.Label()
        Me.lblSnackVal = New System.Windows.Forms.Label()
        Me.lblMealVal = New System.Windows.Forms.Label()
        Me.lblDrinkVal = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblSnacks = New System.Windows.Forms.Label()
        Me.lblMeals = New System.Windows.Forms.Label()
        Me.lblDrinks = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnMusic = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlTitle.SuspendLayout()
        Me.grpDrinks.SuspendLayout()
        Me.grpMeals.SuspendLayout()
        Me.grpSnacks.SuspendLayout()
        Me.grpCalc.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlTitle
        '
        Me.pnlTitle.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlTitle.Controls.Add(Me.lblTitle)
        Me.pnlTitle.Location = New System.Drawing.Point(12, 12)
        Me.pnlTitle.Name = "pnlTitle"
        Me.pnlTitle.Size = New System.Drawing.Size(762, 50)
        Me.pnlTitle.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTitle.Font = New System.Drawing.Font("STARWARS", 24.0!)
        Me.lblTitle.ForeColor = System.Drawing.Color.Yellow
        Me.lblTitle.Location = New System.Drawing.Point(144, 5)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(488, 37)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "DARTH POWER'S CANTINA"
        '
        'grpDrinks
        '
        Me.grpDrinks.BackColor = System.Drawing.Color.Transparent
        Me.grpDrinks.Controls.Add(Me.lbxDrinkType)
        Me.grpDrinks.Controls.Add(Me.lblDrinkType)
        Me.grpDrinks.Controls.Add(Me.txtDrinks)
        Me.grpDrinks.Controls.Add(Me.lblDrinkNum)
        Me.grpDrinks.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDrinks.ForeColor = System.Drawing.Color.Yellow
        Me.grpDrinks.Location = New System.Drawing.Point(20, 71)
        Me.grpDrinks.Name = "grpDrinks"
        Me.grpDrinks.Size = New System.Drawing.Size(214, 216)
        Me.grpDrinks.TabIndex = 1
        Me.grpDrinks.TabStop = False
        Me.grpDrinks.Text = "Drinks"
        '
        'lbxDrinkType
        '
        Me.lbxDrinkType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbxDrinkType.FormattingEnabled = True
        Me.lbxDrinkType.ItemHeight = 20
        Me.lbxDrinkType.Items.AddRange(New Object() {"Banth-Blood Fizz", "Galaxy Guzzler", "Alderaan Twist", "Spiced Jedi Mindbender", "Turbo Fizz", "Death Starfruit Punch"})
        Me.lbxDrinkType.Location = New System.Drawing.Point(8, 83)
        Me.lbxDrinkType.Name = "lbxDrinkType"
        Me.lbxDrinkType.Size = New System.Drawing.Size(190, 124)
        Me.lbxDrinkType.TabIndex = 3
        '
        'lblDrinkType
        '
        Me.lblDrinkType.AutoSize = True
        Me.lblDrinkType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDrinkType.Location = New System.Drawing.Point(11, 56)
        Me.lblDrinkType.Name = "lblDrinkType"
        Me.lblDrinkType.Size = New System.Drawing.Size(88, 20)
        Me.lblDrinkType.TabIndex = 2
        Me.lblDrinkType.Text = "Drink Type:"
        '
        'txtDrinks
        '
        Me.txtDrinks.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDrinks.Location = New System.Drawing.Point(117, 25)
        Me.txtDrinks.Name = "txtDrinks"
        Me.txtDrinks.Size = New System.Drawing.Size(82, 26)
        Me.txtDrinks.TabIndex = 1
        '
        'lblDrinkNum
        '
        Me.lblDrinkNum.AutoSize = True
        Me.lblDrinkNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDrinkNum.Location = New System.Drawing.Point(11, 28)
        Me.lblDrinkNum.Name = "lblDrinkNum"
        Me.lblDrinkNum.Size = New System.Drawing.Size(89, 20)
        Me.lblDrinkNum.TabIndex = 0
        Me.lblDrinkNum.Text = "# of &Drinks:"
        '
        'grpMeals
        '
        Me.grpMeals.BackColor = System.Drawing.Color.Transparent
        Me.grpMeals.Controls.Add(Me.radNoMeal)
        Me.grpMeals.Controls.Add(Me.radSquill)
        Me.grpMeals.Controls.Add(Me.radZucca)
        Me.grpMeals.Controls.Add(Me.radWomprat)
        Me.grpMeals.Controls.Add(Me.radBantha)
        Me.grpMeals.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpMeals.ForeColor = System.Drawing.Color.Yellow
        Me.grpMeals.Location = New System.Drawing.Point(244, 71)
        Me.grpMeals.Name = "grpMeals"
        Me.grpMeals.Size = New System.Drawing.Size(214, 216)
        Me.grpMeals.TabIndex = 2
        Me.grpMeals.TabStop = False
        Me.grpMeals.Text = "Meals"
        '
        'radNoMeal
        '
        Me.radNoMeal.AutoSize = True
        Me.radNoMeal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radNoMeal.Location = New System.Drawing.Point(17, 156)
        Me.radNoMeal.Name = "radNoMeal"
        Me.radNoMeal.Size = New System.Drawing.Size(88, 24)
        Me.radNoMeal.TabIndex = 7
        Me.radNoMeal.TabStop = True
        Me.radNoMeal.Text = "NO Meal"
        Me.radNoMeal.UseVisualStyleBackColor = True
        '
        'radSquill
        '
        Me.radSquill.AutoSize = True
        Me.radSquill.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radSquill.Location = New System.Drawing.Point(17, 124)
        Me.radSquill.Name = "radSquill"
        Me.radSquill.Size = New System.Drawing.Size(147, 24)
        Me.radSquill.TabIndex = 6
        Me.radSquill.TabStop = True
        Me.radSquill.Text = "Squill Liver Salad"
        Me.radSquill.UseVisualStyleBackColor = True
        '
        'radZucca
        '
        Me.radZucca.AutoSize = True
        Me.radZucca.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radZucca.Location = New System.Drawing.Point(17, 92)
        Me.radZucca.Name = "radZucca"
        Me.radZucca.Size = New System.Drawing.Size(155, 24)
        Me.radZucca.TabIndex = 5
        Me.radZucca.TabStop = True
        Me.radZucca.Text = "Zucca Fruit Pastry"
        Me.radZucca.UseVisualStyleBackColor = True
        '
        'radWomprat
        '
        Me.radWomprat.AutoSize = True
        Me.radWomprat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radWomprat.Location = New System.Drawing.Point(17, 60)
        Me.radWomprat.Name = "radWomprat"
        Me.radWomprat.Size = New System.Drawing.Size(134, 24)
        Me.radWomprat.TabIndex = 4
        Me.radWomprat.TabStop = True
        Me.radWomprat.Text = "Womprat Soup"
        Me.radWomprat.UseVisualStyleBackColor = True
        '
        'radBantha
        '
        Me.radBantha.AutoSize = True
        Me.radBantha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radBantha.Location = New System.Drawing.Point(17, 28)
        Me.radBantha.Name = "radBantha"
        Me.radBantha.Size = New System.Drawing.Size(125, 24)
        Me.radBantha.TabIndex = 3
        Me.radBantha.TabStop = True
        Me.radBantha.Text = "Bantha Steak"
        Me.radBantha.UseVisualStyleBackColor = True
        '
        'grpSnacks
        '
        Me.grpSnacks.BackColor = System.Drawing.Color.Transparent
        Me.grpSnacks.Controls.Add(Me.cbxDung)
        Me.grpSnacks.Controls.Add(Me.cbxEopie)
        Me.grpSnacks.Controls.Add(Me.cbxTusken)
        Me.grpSnacks.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSnacks.ForeColor = System.Drawing.Color.Yellow
        Me.grpSnacks.Location = New System.Drawing.Point(20, 293)
        Me.grpSnacks.Name = "grpSnacks"
        Me.grpSnacks.Size = New System.Drawing.Size(438, 53)
        Me.grpSnacks.TabIndex = 3
        Me.grpSnacks.TabStop = False
        Me.grpSnacks.Text = "Snacks"
        '
        'cbxDung
        '
        Me.cbxDung.AutoSize = True
        Me.cbxDung.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxDung.Location = New System.Drawing.Point(313, 20)
        Me.cbxDung.Name = "cbxDung"
        Me.cbxDung.Size = New System.Drawing.Size(121, 24)
        Me.cbxDung.TabIndex = 2
        Me.cbxDung.Text = "Dung Worms"
        Me.cbxDung.UseVisualStyleBackColor = True
        '
        'cbxEopie
        '
        Me.cbxEopie.AutoSize = True
        Me.cbxEopie.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxEopie.Location = New System.Drawing.Point(154, 20)
        Me.cbxEopie.Name = "cbxEopie"
        Me.cbxEopie.Size = New System.Drawing.Size(146, 24)
        Me.cbxEopie.TabIndex = 1
        Me.cbxEopie.Text = "Eopie Cream Pie"
        Me.cbxEopie.UseVisualStyleBackColor = True
        '
        'cbxTusken
        '
        Me.cbxTusken.AutoSize = True
        Me.cbxTusken.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxTusken.Location = New System.Drawing.Point(14, 20)
        Me.cbxTusken.Name = "cbxTusken"
        Me.cbxTusken.Size = New System.Drawing.Size(127, 24)
        Me.cbxTusken.TabIndex = 0
        Me.cbxTusken.Text = "Tusken Bread"
        Me.cbxTusken.UseVisualStyleBackColor = True
        '
        'grpCalc
        '
        Me.grpCalc.BackColor = System.Drawing.Color.Transparent
        Me.grpCalc.Controls.Add(Me.lblTotalVal)
        Me.grpCalc.Controls.Add(Me.lblSnackVal)
        Me.grpCalc.Controls.Add(Me.lblMealVal)
        Me.grpCalc.Controls.Add(Me.lblDrinkVal)
        Me.grpCalc.Controls.Add(Me.lblTotal)
        Me.grpCalc.Controls.Add(Me.lblSnacks)
        Me.grpCalc.Controls.Add(Me.lblMeals)
        Me.grpCalc.Controls.Add(Me.lblDrinks)
        Me.grpCalc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCalc.ForeColor = System.Drawing.Color.Yellow
        Me.grpCalc.Location = New System.Drawing.Point(20, 353)
        Me.grpCalc.Name = "grpCalc"
        Me.grpCalc.Size = New System.Drawing.Size(438, 149)
        Me.grpCalc.TabIndex = 4
        Me.grpCalc.TabStop = False
        Me.grpCalc.Text = "Calculations"
        '
        'lblTotalVal
        '
        Me.lblTotalVal.AutoSize = True
        Me.lblTotalVal.Location = New System.Drawing.Point(166, 112)
        Me.lblTotalVal.Name = "lblTotalVal"
        Me.lblTotalVal.Size = New System.Drawing.Size(54, 20)
        Me.lblTotalVal.TabIndex = 7
        Me.lblTotalVal.Text = "$0.00"
        '
        'lblSnackVal
        '
        Me.lblSnackVal.AutoSize = True
        Me.lblSnackVal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSnackVal.ForeColor = System.Drawing.Color.Tomato
        Me.lblSnackVal.Location = New System.Drawing.Point(171, 77)
        Me.lblSnackVal.Name = "lblSnackVal"
        Me.lblSnackVal.Size = New System.Drawing.Size(49, 20)
        Me.lblSnackVal.TabIndex = 6
        Me.lblSnackVal.Text = "$0.00"
        '
        'lblMealVal
        '
        Me.lblMealVal.AutoSize = True
        Me.lblMealVal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMealVal.ForeColor = System.Drawing.Color.Tomato
        Me.lblMealVal.Location = New System.Drawing.Point(171, 52)
        Me.lblMealVal.Name = "lblMealVal"
        Me.lblMealVal.Size = New System.Drawing.Size(49, 20)
        Me.lblMealVal.TabIndex = 5
        Me.lblMealVal.Text = "$0.00"
        '
        'lblDrinkVal
        '
        Me.lblDrinkVal.AutoSize = True
        Me.lblDrinkVal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDrinkVal.ForeColor = System.Drawing.Color.Tomato
        Me.lblDrinkVal.Location = New System.Drawing.Point(171, 27)
        Me.lblDrinkVal.Name = "lblDrinkVal"
        Me.lblDrinkVal.Size = New System.Drawing.Size(49, 20)
        Me.lblDrinkVal.TabIndex = 4
        Me.lblDrinkVal.Text = "$0.00"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.White
        Me.lblTotal.Location = New System.Drawing.Point(9, 112)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(108, 20)
        Me.lblTotal.TabIndex = 3
        Me.lblTotal.Text = "Total Amount:"
        '
        'lblSnacks
        '
        Me.lblSnacks.AutoSize = True
        Me.lblSnacks.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSnacks.ForeColor = System.Drawing.Color.White
        Me.lblSnacks.Location = New System.Drawing.Point(9, 77)
        Me.lblSnacks.Name = "lblSnacks"
        Me.lblSnacks.Size = New System.Drawing.Size(66, 20)
        Me.lblSnacks.TabIndex = 2
        Me.lblSnacks.Text = "Snacks:"
        '
        'lblMeals
        '
        Me.lblMeals.AutoSize = True
        Me.lblMeals.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMeals.ForeColor = System.Drawing.Color.White
        Me.lblMeals.Location = New System.Drawing.Point(9, 52)
        Me.lblMeals.Name = "lblMeals"
        Me.lblMeals.Size = New System.Drawing.Size(51, 20)
        Me.lblMeals.TabIndex = 1
        Me.lblMeals.Text = "Meals"
        '
        'lblDrinks
        '
        Me.lblDrinks.AutoSize = True
        Me.lblDrinks.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDrinks.ForeColor = System.Drawing.Color.White
        Me.lblDrinks.Location = New System.Drawing.Point(9, 27)
        Me.lblDrinks.Name = "lblDrinks"
        Me.lblDrinks.Size = New System.Drawing.Size(58, 20)
        Me.lblDrinks.TabIndex = 0
        Me.lblDrinks.Text = "Drinks:"
        '
        'btnCalc
        '
        Me.btnCalc.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCalc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalc.Location = New System.Drawing.Point(21, 516)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(101, 33)
        Me.btnCalc.TabIndex = 5
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(564, 516)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(101, 33)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(671, 516)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(101, 33)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnMusic
        '
        Me.btnMusic.AutoSize = True
        Me.btnMusic.BackColor = System.Drawing.Color.Transparent
        Me.btnMusic.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMusic.ForeColor = System.Drawing.Color.White
        Me.btnMusic.Location = New System.Drawing.Point(657, 68)
        Me.btnMusic.Name = "btnMusic"
        Me.btnMusic.Size = New System.Drawing.Size(116, 17)
        Me.btnMusic.TabIndex = 9
        Me.btnMusic.Text = "Play Cantina Music"
        Me.btnMusic.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(464, 391)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(317, 80)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'frmMainLab1
        '
        Me.AcceptButton = Me.btnCalc
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnMusic)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.grpCalc)
        Me.Controls.Add(Me.grpSnacks)
        Me.Controls.Add(Me.grpMeals)
        Me.Controls.Add(Me.grpDrinks)
        Me.Controls.Add(Me.pnlTitle)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmMainLab1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Darth Power's Cantina"
        Me.pnlTitle.ResumeLayout(False)
        Me.grpDrinks.ResumeLayout(False)
        Me.grpDrinks.PerformLayout()
        Me.grpMeals.ResumeLayout(False)
        Me.grpMeals.PerformLayout()
        Me.grpSnacks.ResumeLayout(False)
        Me.grpSnacks.PerformLayout()
        Me.grpCalc.ResumeLayout(False)
        Me.grpCalc.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlTitle As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents grpDrinks As GroupBox
    Friend WithEvents grpMeals As GroupBox
    Friend WithEvents grpSnacks As GroupBox
    Friend WithEvents grpCalc As GroupBox
    Friend WithEvents btnCalc As Button
    Friend WithEvents lblDrinkNum As Label
    Friend WithEvents lbxDrinkType As ListBox
    Friend WithEvents lblDrinkType As Label
    Friend WithEvents txtDrinks As TextBox
    Friend WithEvents radNoMeal As RadioButton
    Friend WithEvents radSquill As RadioButton
    Friend WithEvents radZucca As RadioButton
    Friend WithEvents radWomprat As RadioButton
    Friend WithEvents radBantha As RadioButton
    Friend WithEvents cbxDung As CheckBox
    Friend WithEvents cbxEopie As CheckBox
    Friend WithEvents cbxTusken As CheckBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnMusic As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblSnacks As Label
    Friend WithEvents lblMeals As Label
    Friend WithEvents lblDrinks As Label
    Friend WithEvents lblTotalVal As Label
    Friend WithEvents lblSnackVal As Label
    Friend WithEvents lblMealVal As Label
    Friend WithEvents lblDrinkVal As Label
End Class
