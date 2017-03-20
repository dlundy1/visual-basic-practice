Public Class sandwich
    'name, bread, meat, cheese, condiments
    Private Name, Bread, Meat, Cheese, Condiments As String

    Public Sub New(ByVal NameI As String, BreadI As String, MeatI As String, CheeseI As String, CondimentsI As String)
        Name = NameI
        Bread = BreadI
        Meat = MeatI
        Cheese = CheeseI
        Condiments = CondimentsI
    End Sub

    Property getName()
        Get
            Return Name
        End Get
        Set(value)
            Name = value
        End Set
    End Property
    Property getBread
        Get
            Return Bread
        End Get
        Set(value)
            Bread = value
        End Set
    End Property
    Property getMeat()
        Get
            Return Meat
        End Get
        Set(value)
            Meat = value
        End Set
    End Property
    Property getCheese()
        Get
            Return Cheese
        End Get
        Set(value)
            Cheese = value
        End Set
    End Property
    Property getCondiments()
        Get
            Return Condiments
        End Get
        Set(value)
            Condiments = value
        End Set
    End Property
End Class
