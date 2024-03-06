Imports System.Resources
Imports System.Collections.ObjectModel
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar
Public Class ALLHAIL
    Private bgs() As Image ' Define bgs as an array of Images

    Private Sub ALLHAIL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Populate the bgs array with images from resources
        bgs = GetImagesFromResources()
    End Sub

    Private Function GetImagesFromResources() As Image()
        Dim imagesList As New List(Of Image)

        ' Get all resources and their objects
        Dim resourcesDictionary As Dictionary(Of String, Object) = GetMyResourcesDictionary()

        ' Iterate over the dictionary and add images to the list
        For Each kvp As KeyValuePair(Of String, Object) In resourcesDictionary
            If TypeOf kvp.Value Is Image Then
                imagesList.Add(DirectCast(kvp.Value, Image))
            End If
        Next

        ' Convert the list to an array and return it
        Return imagesList.ToArray()
    End Function

    Private Function GetMyResourcesDictionary() As Dictionary(Of String, Object)
        Dim ItemDictionary As New Dictionary(Of String, Object)
        Dim ItemEnumerator As System.Collections.IDictionaryEnumerator
        Dim ItemResourceSet As Resources.ResourceSet
        Dim ResourceNameList As New List(Of String)

        ItemResourceSet = My.Resources.ResourceManager.GetResourceSet(System.Globalization.CultureInfo.CurrentCulture, True, True)

        ' Get the enumerator for My.Resources
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

    Private Function GetItem(ByVal resourceName As String) As Object
        Return My.Resources.ResourceManager.GetObject(resourceName)
    End Function

    Private Sub btnPraise_Click(sender As Object, e As EventArgs) Handles btnPraise.Click
        Dim rand As New Random

        For i As Integer = 0 To 500
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
End Class
