'Project:       Sprint4
'Programmers:   Glenn Cummings
'
'
'
'
'Date:          April 2011
'Decription:    This program allows the pc user to select two airport hub IDs from an array,
'               display the location, latitude and longitude of those airports,
'               and calculate the shortest distance between those airports in miles.
'
Option Strict On
Option Explicit On
Imports System.Math
Public Class Airports

    Public Enum FieldNames
        ID = 0
        City = 1
        Lat = 2
        Lon = 3
    End Enum

    Structure Coordinates   'latitude/longitude pair in radians
        Dim lat As Double
        Dim lon As Double
    End Structure

    Structure Airport           'Record
        Dim ID As String
        Dim City As String
        Dim Lat As String
        Dim Lon As String
    End Structure

    'Internal variables for current Airport records
    Dim Index1Integer As Integer
    Dim Lat1Double As Double
    Dim Lon1Double As Double
    Dim Index2Integer As Integer
    Dim Lat2Double As Double
    Dim Lon2Double As Double

    'Array of all Airport records
    Dim Hubs(3) As Airport

    Private Sub Form1_Load(ByVal sender As Object, _
               ByVal e As System.EventArgs) Handles Me.Load
        LoadData()
    End Sub

    Public Sub LoadData()
        '   The following code was moved from the Me.Load Event Handler
        '   for use in unit testing
        '
        'Load small sample of airport hubs into Hubs array
        Hubs(0).ID = "ATL"
        Hubs(0).City = "Atlanta"
        Hubs(0).Lat = "33° 38' 22"" N"
        Hubs(0).Lon = "84° 25' 41"" W"
        Hubs(1).ID = "BOS"
        Hubs(1).City = "Boston"
        Hubs(1).Lat = "42° 21' 42"" N"
        Hubs(1).Lon = "71° 0' 42"" W"
        Hubs(2).ID = "CLE"
        Hubs(2).City = "Cleveland"
        Hubs(2).Lat = "41° 24' 27"" N"
        Hubs(2).Lon = "81° 51' 4"" W"
        Hubs(3).ID = "SEA"
        Hubs(3).City = "Seattle"
        Hubs(3).Lat = "47° 26' 56"" N"
        Hubs(3).Lon = "122° 18' 33"" W"

        'Load ID1ComboBox List
        For Each Airport In Hubs
            ID1ComboBox.Items.Add(Airport.ID)
        Next
        'Load ID2ComboBox List
        For Each Airport In Hubs
            ID2ComboBox.Items.Add(Airport.ID)
        Next
        'Set default values for Combo boxes
        ID1ComboBox.SelectedIndex = 0
        ID2ComboBox.SelectedIndex = 1
    End Sub


    Public Function CoordinateToDegrees(ByVal DegreeString As String) As Double
        '   Converts a coordinate string in degree/minute/second notation to decimal degrees
        '
        Dim degrees As Double
        Dim minutes As Double
        Dim seconds As Double
        Dim StartPtr, StopPtr As Integer
        StartPtr = 0
        StopPtr = DegreeString.IndexOf("°", StartPtr)
        degrees = Convert.ToDouble(DegreeString.Substring(StartPtr, StopPtr - StartPtr))
        StartPtr = StopPtr + 1
        StopPtr = DegreeString.IndexOf("'", StartPtr)
        minutes = Convert.ToDouble(DegreeString.Substring(StartPtr, StopPtr - StartPtr))
        StartPtr = StopPtr + 1
        StopPtr = DegreeString.IndexOf("""", StartPtr)
        seconds = Convert.ToDouble(DegreeString.Substring(StartPtr, StopPtr - StartPtr))
        '1 degree = 60 minutes = 3600 seconds
        '1 minute = 60 seconds
        Return degrees + minutes / 60.0 + seconds / 3600.0
    End Function

    Public Function indexToCoordinatePair(ByVal index As Integer) As Coordinates
        Dim cord As Coordinates

        cord.lat = CoordinateToDegrees(Hubs(index).Lat)
        cord.lon = CoordinateToDegrees(Hubs(index).Lon)

        Return cord

    End Function


    Function DegreesToRadians(ByVal DegreesDouble As Double) As Double
        '   converts decimal degrees to radians
        '   180 degrees = Pi radians
        '
        Return DegreesDouble * PI / 180
    End Function

    Function RadiansToDegrees(ByVal RadiansDouble As Double) As Double ' Mary Napier added task 2
        ' convert radians to degrees
        'degrees = (radians*180)/pi

        Return (RadiansDouble * 180) / PI
    End Function


    Public Function ValueOf(ByVal Index As Integer, ByVal FieldName As FieldNames) As String
        '   Extract airport information from the Hubs array
        '
        If FieldName = FieldNames.City Then
            Return Hubs(Index).City
        ElseIf FieldName = FieldNames.Lat Then
            Return Hubs(Index).Lat
        ElseIf FieldName = FieldNames.Lon Then
            Return Hubs(Index).Lon
        Else
            Return ""
        End If
    End Function


    Public Function Distance(ByVal Index1 As Integer, ByVal Index2 As Integer) As Double
        '   Calculate the distance in miles between the two cities selected in the combo boxes after their 
        '   latitudes and longitudes have been converted to decimal fractions
        '   Spherical law of cosines: 	
        '   d = acos(sin(lat1) • sin(lat2) + cos(lat1) • cos(lat2) • cos(long2 − long1)) • R
        '   Anton von Braunmühl, Vorlesungen über Geschichte der Trigonometrie, Vol. 1, 1900
        '
        Const R As Double = 3958.761 'mean Earth radius in miles
        Dim Lat1, Lat2, Lon1, Lon2 As Double
        Dim tlat, tlon, a, c, d As Double
        Lat1 = DegreesToRadians(CoordinateToDegrees(Hubs(Index1).Lat))
        Lat2 = DegreesToRadians(CoordinateToDegrees(Hubs(Index2).Lat))
        Lon1 = DegreesToRadians(CoordinateToDegrees(Hubs(Index1).Lon))
        Lon2 = DegreesToRadians(CoordinateToDegrees(Hubs(Index2).Lon))
        '------------
        tlat = Lat2 - Lat1
        tlon = Lon2 - Lon1

        a = Sin(tlat / 2) ^ 2 + Cos(Lat2) * Sin(tlon / 2) ^ 2
        c = 2 * Atan2(Sqrt(a), Sqrt((1 - a)))
        d = R * c

        'd = Acos(Sin(Lat1) * Sin(Lat2) + Cos(Lat1) * Cos(Lat2) * Cos(Lon2 - Lon1)) * R
        Return d

    End Function

    Private Sub ID1ComboBox_SelectedIndexChanged(ByVal sender As System.Object,
                ByVal e As System.EventArgs) Handles ID1ComboBox.SelectedIndexChanged
        '   Load Cit1TextBox, Lat1TextBox, Lon1TextBox with values from the array Airports(ID1Integer)
        '
        Index1Integer = ID1ComboBox.SelectedIndex
        City1TextBox.Text = Hubs(Index1Integer).City
        Lat1TextBox.Text = Hubs(Index1Integer).Lat
        Lon1TextBox.Text = Hubs(Index1Integer).Lon
    End Sub

    Private Sub ID2ComboBox_SelectedIndexChanged(ByVal sender As System.Object,
                ByVal e As System.EventArgs) Handles ID2ComboBox.SelectedIndexChanged
        '   Load Cit2TextBox, Lat2TextBox, Lon2TextBox with values from the array Airports(ID2Integer)
        '
        Index2Integer = ID2ComboBox.SelectedIndex
        City2TextBox.Text = Hubs(Index2Integer).City
        Lat2TextBox.Text = Hubs(Index2Integer).Lat
        Lon2TextBox.Text = Hubs(Index2Integer).Lon
    End Sub

    Function CoordinatePairtToCartesianPair(ByVal CoordPair As Coordinates) As Point
        ' Formula for transforming coordinates into screen positions
        ' Transform equations determined using SPSS Stepwise Regression
        ' x = int( -18.886 × lon - 17.777 × lat + 0.178 × lat × lon + 2173.268 )
        ' y = int( -15.183 × lat + 14.772 × lon - 0.073 × lon² + 48.703 )
        '
        Dim x As Integer
        Dim y As Integer

        x = CInt(-18.886 * CoordPair.lon - 17.777 * CoordPair.lat + 0.178 * CoordPair.lat * CoordPair.lon + 2173.268)
        y = CInt(-15.183 * CoordPair.lat + 14.772 * CoordPair.lon - 0.073 * CoordPair.lon ^ 2 + 48.703)

        Dim result As New Point(x, y)
        Return result
    End Function



    Private Sub CalcDistanceButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalcDistanceButton.Click
        DistanceTextBox.Text = Distance(Index1Integer, Index2Integer).ToString("F0")
        'Enable 'ViewMap' Button
        plot_btn.Enabled = True
        plot_btn.BackColor = Color.FromArgb(192, 255, 192)
    End Sub

    Private Sub plot()
        'Plot a Curved Line on the US Map. Use DrawCurve() method of CreateGraphics() Library.
        Dim bPen As New Pen(Color.Black, 3)

        ' CreateGraphics.DrawCurve()

        'Use DrawRectangle() method to draw rectangles around both START and END points.
    End Sub

    Private Sub plot_btn_Click(sender As Object, e As EventArgs) Handles plot_btn.Click
        Dim map As New Map
        map.ShowDialog()
    End Sub
End Class


