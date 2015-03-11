Imports System
Imports System.Xml
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim strProgramName As String
        Dim strArgument As String
        strProgramName = Path.Text & "\Windower.exe"
        strArgument = "-p=test --executable=xiloader.exe --args=""--server " & Server.Text & " --user " & User.Text & " --pass " & Pass.Text & """"
        Process.Start(strProgramName, strArgument)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If (System.IO.File.Exists(loadProfile.Text & ".xml")) Then

            Dim document As XmlReader = New XmlTextReader(loadProfile.Text & ".xml")

            While (document.Read())

                Dim type = document.NodeType

                If (type = XmlNodeType.Element) Then

                    If (document.Name = "Path") Then

                        Path.Visible = True
                        Path.Text = document.ReadInnerXml.ToString()

                    End If

                    If (document.Name = "Server") Then

                        Server.Visible = True
                        Server.Text = document.ReadInnerXml.ToString()

                    End If

                    If (document.Name = "User") Then

                        User.Visible = True
                        User.Text = document.ReadInnerXml.ToString()

                    End If

                    If (document.Name = "Pass") Then

                        Pass.Visible = True
                        Pass.Text = document.ReadInnerXml.ToString()

                    End If

                End If

            End While

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim settings As New XmlWriterSettings()
        settings.Indent = True

        ' Initialize the XmlWriter.
        Dim XmlWrt As XmlWriter = XmlWriter.Create(saveProfile.Text & ".xml", settings)

        With XmlWrt

            ' Write the Xml declaration.
            .WriteStartDocument()

            ' Write a comment.
            .WriteComment("XML Database.")

            ' Write the root element.
            .WriteStartElement("Settings")

            ' Start our first person.
            .WriteStartElement("Profile")

            ' The person nodes.

            .WriteStartElement("Path")
            .WriteString(Path.Text.ToString())
            .WriteEndElement()

            .WriteStartElement("Server")
            .WriteString(Server.Text.ToString())
            .WriteEndElement()

            .WriteStartElement("User")
            .WriteString(User.Text.ToString())
            .WriteEndElement()

            .WriteStartElement("Pass")
            .WriteString(Pass.Text.ToString())
            .WriteEndElement()

            ' The end of this person.
            .WriteEndElement()

            ' Close the XmlTextWriter.
            .WriteEndDocument()
            .Close()

        End With

        MessageBox.Show("XML file saved.")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (System.IO.File.Exists("default.xml")) Then

            Dim document As XmlReader = New XmlTextReader("default.xml")

            While (document.Read())

                Dim type = document.NodeType

                If (type = XmlNodeType.Element) Then

                    If (document.Name = "Path") Then

                        Path.Visible = True
                        Path.Text = document.ReadInnerXml.ToString()

                    End If

                    If (document.Name = "Server") Then

                        Server.Visible = True
                        Server.Text = document.ReadInnerXml.ToString()

                    End If

                    If (document.Name = "User") Then

                        User.Visible = True
                        User.Text = document.ReadInnerXml.ToString()

                    End If

                    If (document.Name = "Pass") Then

                        Pass.Visible = True
                        Pass.Text = document.ReadInnerXml.ToString()

                    End If

                End If

            End While

        End If
    End Sub
End Class
