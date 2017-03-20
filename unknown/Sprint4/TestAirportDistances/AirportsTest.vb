Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports AirportDistances



'''<summary>
'''This is a test class for AirportsTest and is intended
'''to contain all AirportsTest Unit Tests
'''</summary>
<TestClass()> _
Public Class AirportsTest


    Private testContextInstance As TestContext

    '''<summary>
    '''Gets or sets the test context which provides
    '''information about and functionality for the current test run.
    '''</summary>
    Public Property TestContext() As TestContext
        Get
            Return testContextInstance
        End Get
        Set(ByVal value As TestContext)
            testContextInstance = Value
        End Set
    End Property

#Region "Additional test attributes"
    '
    'You can use the following additional attributes as you write your tests:
    '
    'Use ClassInitialize to run code before running the first test in the class
    '<ClassInitialize()>  _
    '
    'Public Shared Sub MyClassInitialize(ByVal testContext As TestContext)
    'End Sub
    '
    'Use ClassCleanup to run code after all tests in a class have run
    '<ClassCleanup()>  _
    'Public Shared Sub MyClassCleanup()
    'End Sub
    '
    'Use TestInitialize to run code before running each test
    '<TestInitialize()>  _
    'Public Sub MyTestInitialize()
    'End Sub
    '
    'Use TestCleanup to run code after each test has run
    '<TestCleanup()>  _
    'Public Sub MyTestCleanup()
    'End Sub
    '
#End Region


    '''<summary>
    '''A test for CoordinateToDegrees
    '''</summary>
    <TestMethod()> _
    Public Sub CoordinateToDegreesTest()
        Dim target As Airports = New Airports() ' TODO: Initialize to an appropriate value
        Dim DegreeString As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim expected As Double = 0.0! ' TODO: Initialize to an appropriate value
        Dim delta As Double = 0.0! ' TODO: Initialize to an appropriate value
        Dim actual As Double
        DegreeString = "33° 38' 22"" N"
        expected = 33.63944
        delta = 0.00001
        actual = target.CoordinateToDegrees(DegreeString)
        Assert.AreEqual(expected, actual, delta)
        'Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub





    '''<summary>
    '''A test for DegreesToRadians
    '''</summary>
    <TestMethod()> _
    Public Sub DegreesToRadiansTest()
        Dim target As Airports = New Airports() ' TODO: Initialize to an appropriate value
        Dim DegreesDouble As Double = 0.0! ' TODO: Initialize to an appropriate value
        Dim expected As Double = 0.0! ' TODO: Initialize to an appropriate value
        Dim delta As Double = 0.0! ' TODO: Initialize to an appropriate value
        Dim actual As Double
        DegreesDouble = 33.63944
        expected = 0.58712
        delta = 0.00001
        actual = target.DegreesToRadians(DegreesDouble)
        Assert.AreEqual(expected, actual, delta)
        'Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for RadiansToDegrees
    '''</summary>
    <TestMethod()>
    Public Sub RadiansToDegreesTest()
        Dim target As Airports = New Airports() ' TODO: Initialize to an appropriate value
        Dim RadiansDouble As Double = 0.0! ' TODO: Initialize to an appropriate value
        Dim expected As Double = 0.0! ' TODO: Initialize to an appropriate value
        Dim delta As Double = 0.0! ' TODO: Initialize to an appropriate value
        Dim actual As Double
        RadiansDouble = 0.58712
        expected = 33.63949
        delta = 0.00001
        actual = target.RadiansToDegrees(RadiansDouble)
        Assert.AreEqual(expected, actual, delta)
        'Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub


    '''<summary>
    '''A test for Distance
    '''</summary>
    <TestMethod()> _
    Public Sub DistanceTest()
        Dim target As Airports = New Airports() ' TODO: Initialize to an appropriate value
        Dim Index1 As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim Index2 As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim expected As Double = 0.0! ' TODO: Initialize to an appropriate value
        Dim delta As Double = 0.0! ' TODO: Initialize to an appropriate value
        Dim actual As Double
        target.LoadData()
        Index1 = 0
        Index2 = 1
        expected = 945
        delta = 1
        actual = target.Distance(Index1, Index2)
        Assert.AreEqual(expected, actual, delta)
        'Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for ValueOf (City)
    '''</summary>
    <TestMethod()> _
    Public Sub ValueOfTest1()
        Dim target As Airports = New Airports() ' TODO: Initialize to an appropriate value
        Dim Index As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim FieldName As Airports.FieldNames = New Airports.FieldNames() ' TODO: Initialize to an appropriate value
        Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim actual As String
        target.LoadData()
        Index = 0
        FieldName = Airports.FieldNames.City
        expected = "Atlanta"
        actual = target.ValueOf(Index, FieldName)
        Assert.AreEqual(expected, actual)
        'Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for ValueOf (Latitude)
    '''</summary>
    <TestMethod()> _
    Public Sub ValueOfTest2()
        Dim target As Airports = New Airports() ' TODO: Initialize to an appropriate value
        Dim Index As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim FieldName As Airports.FieldNames = New Airports.FieldNames() ' TODO: Initialize to an appropriate value
        Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim actual As String
        target.LoadData()
        Index = 0
        FieldName = Airports.FieldNames.Lat
        expected = "33° 38' 22"" N"
        actual = target.ValueOf(Index, FieldName)
        Assert.AreEqual(expected, actual)
        'Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub
    '''<summary>
    '''A test for ValueOf (Longitude)
    '''</summary>
    <TestMethod()> _
    Public Sub ValueOfTest3()
        Dim target As Airports = New Airports() ' TODO: Initialize to an appropriate value
        Dim Index As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim FieldName As Airports.FieldNames = New Airports.FieldNames() ' TODO: Initialize to an appropriate value
        Dim expected As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim actual As String
        target.LoadData()
        Index = 0
        FieldName = Airports.FieldNames.Lon
        expected = "84° 25' 41"" W"
        actual = target.ValueOf(Index, FieldName)
        Assert.AreEqual(expected, actual)
        'Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub
End Class
