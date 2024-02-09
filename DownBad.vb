Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar

Public Class ALLHAIL
    Private bgs() As Image = {
    My.Resources.IMG_0091,
    My.Resources.IMG_0096,
    My.Resources.IMG_0102,
    My.Resources.IMG_0103,
    My.Resources.IMG_0117_1_,
    My.Resources.IMG_0208,
    My.Resources.IMG_0209,
    My.Resources.IMG_0236_1_,
    My.Resources.IMG_0241,
    My.Resources.IMG_0241_1_,
    My.Resources.IMG_0257,
    My.Resources.IMG_0257,
    My.Resources.IMG_0267,
    My.Resources.IMG_0281,
    My.Resources.IMG_0345,
    My.Resources.IMG_0505,
    My.Resources.IMG_0509,
    My.Resources.IMG_0635,
    My.Resources.IMG_0648,
    My.Resources.IMG_0983,
    My.Resources.IMG_0991,
    My.Resources.IMG_1156,
    My.Resources.IMG_1514,
    My.Resources.IMG_1515,
    My.Resources.IMG_1543_1_,
    My.Resources.IMG_1549_1_,
    My.Resources.IMG_1562,
    My.Resources.IMG_1564,
    My.Resources.IMG_1565,
    My.Resources.IMG_1586_1_,
    My.Resources.IMG_1618_1_,
    My.Resources.IMG_1689_1_,
    My.Resources.IMG_1724_1_,
    My.Resources.IMG_1754_1_,
    My.Resources.IMG_1762_1_,
    My.Resources.IMG_1768_1_,
    My.Resources.IMG_1771_1_,
    My.Resources.IMG_1778_1_,
    My.Resources.IMG_1786_1_,
    My.Resources.IMG_1791_1_,
    My.Resources.IMG_1792_1_,
    My.Resources.IMG_1477_1_,
    My.Resources.IMG_1520_1_,
    My.Resources.IMG_1523_1_,
    My.Resources.IMG_1527_1_,
    My.Resources.IMG_1562,
    My.Resources.IMG_1586_1_,
    My.Resources.IMG_1715_1_,
    My.Resources.IMG_1496_1_,
    My.Resources.IJPP6901_1_,
    My.Resources.IMG_0588_1_,
    My.Resources.IMG_0863_1_,
    My.Resources.IMG_0885_1_
    }
    Private Sub btnPraise_Click(sender As Object, e As EventArgs) Handles btnPraise.Click
        For i As Integer = 0 To 500
            Dim rand As New Random
            Dim bad = New Form
            bad.Name = "hiiiiii"
            Dim x = rand.Next(My.Computer.Screen.Bounds.Width)
            Dim y = rand.Next(My.Computer.Screen.Bounds.Height)
            bad.BackgroundImage = bgs(rand.Next(bgs.Length))

            bad.BackgroundImageLayout = ImageLayout.Zoom
            bad.Location = New Point(x, y)
            bad.StartPosition = FormStartPosition.Manual
            bad.Show()
        Next

    End Sub

    Sub test()
        For Each res As String In GetMyResourcesDictionary().Keys
            Console.WriteLine(res)
        Next
    End Sub

    Public Function GetMyResourcesDictionary() As Dictionary(Of String, Object)
        Dim ItemDictionary As New Dictionary(Of String, Object)
        Dim ItemEnumerator As System.Collections.IDictionaryEnumerator
        Dim ItemResourceSet As Resources.ResourceSet
        Dim ResourceNameList As New List(Of String)

        ItemResourceSet = My.Resources.ResourceManager.GetResourceSet(New System.Globalization.CultureInfo("en"), True, True)

        'Get the enumerator for My.Resources
        ItemEnumerator = ItemResourceSet.GetEnumerator

        Do While ItemEnumerator.MoveNext
            ResourceNameList.Add(ItemEnumerator.Key.ToString)
        Loop

        For Each resourceName As String In ResourceNameList
            ItemDictionary.Add(resourceName, GetItem(resourceName))
        Next

        ResourceNameList = Nothing

        Return ItemDictionary
    End Function

    Public Function GetItem(ByVal resourceName As String) As Object
        Return My.Resources.ResourceManager.GetObject(resourceName)
    End Function

    Private Sub ALLHAIL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        test()
    End Sub
End Class
