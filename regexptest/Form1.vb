Imports System.Runtime.InteropServices

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim checkText As String
        Dim rb1, rb2 As RadioButton
        Dim ignCaseText, regExpEng As String
        Dim ignCase As Boolean
        Dim result As Boolean

        '文字列が入力されているかチェック
        If TextBoxRegPattern.Text = "" Then
            TextBoxRegPattern.Text = "入力してください"
            'Exit Sub
        End If

        If TextBoxCheckStrigs.Text = "" Then
            TextBoxCheckStrigs.Text = "入力してください"
            Exit Sub
        End If

        'チェック対象文字列の指定文字数での切りつめ処理を行う
        'チェック対象文字列が入力された有効文字数以下、または入力された
        '有効文字数が0の場合はチェック対象文字列すべてをマッチ確認対象文字列とする
        If TextBoxCheckStrigs.Text.Length <= NumericUpDown1.Value Or NumericUpDown1.Value = 0 Then
            checkText = TextBoxCheckStrigs.Text
        Else
            checkText = TextBoxCheckStrigs.Text.Substring(0, NumericUpDown1.Value)
        End If

        '入力された正規表現パターン文字列数の表示
        LabelRegPatLength.Text = TextBoxRegPattern.Text.Length & "文字"
        '有効文字列数/入力されたチェック対象文字列数の表示
        LabelCehckStrLength.Text = checkText.Length & "/" & TextBoxCheckStrigs.Text.Length & "文字"

        ignCaseText = ""
        regExpEng = ""

        'どのラジオボタンが選択されているのか取得
        For Each rb1 In GroupBox1.Controls
            If (rb1.Checked) Then
                ignCaseText = rb1.Text
            End If
        Next

        For Each rb2 In GroupBox2.Controls
            If (rb2.Checked) Then
                regExpEng = rb2.Text
            End If
        Next

        'ラジオボタンに従い、正規表現で大文字小文字を区別するかしないか設定する
        Select Case ignCaseText
            Case "しない"
                ignCase = True
            Case "する"
                ignCase = False
        End Select

        Try
            '前回の一致結果欄をクリアする
            Button2_Click(sender, e)

            'ラジオボタンに従い、使用する正規表現エンジンを設定する
            Select Case regExpEng
                Case "VBScript"
                    result = vbs(TextBoxRegPattern.Text, checkText, ignCase)
                Case ".NET"
                    result = vbdnet(TextBoxRegPattern.Text, checkText, ignCase)
                    'Visual Studioがウォーニングを出すので黙らせるためのCase Else
                Case Else
                    result = vbs(TextBoxRegPattern.Text, checkText, ignCase)
            End Select

            If result = True Then
                LabelMatchOrNot.Text = "マッチ"
                LabelMatchOrNot.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption)
            Else
                LabelMatchOrNot.Text = "アンマッチ"
                LabelMatchOrNot.BackColor = Color.FromKnownColor(KnownColor.Desktop)
            End If
        Catch ex As Exception
            MsgBox(ex.Message & "in Button1_Click")
        Finally
        End Try

    End Sub

    Function vbs(regText, checkText, ignCase)
        'RegExpクラスのMatchメソッドを用いて、正規表現によるマッチングを行う。
        '第1引数: regText      正規表現パターン	文字列
        '第2引数: checkText    一致確認対象文字列	文字列
        '第3引数: ignCase      マッチング時に大文字・小文字を区別するかしないかのフラグ
        '戻り値: マッチしたかしなかったか Bool値

        Dim objRegExp As New VBScript_RegExp_55.RegExp
        objRegExp.Pattern = regText
        objRegExp.IgnoreCase = ignCase
        objRegExp.Global = False

        Try
            vbs = objRegExp.Test(checkText)
        Catch ex As Exception
            vbs = False
            LabelMatchOrNot.Text = "例外(VBScript)"
        End Try

    End Function

    Function vbdnet(regText, checkText, ignCase)

        Try
            If ignCase = True Then
                vbdnet = System.Text.RegularExpressions.Regex.IsMatch(checkText, regText, _
                                                                      System.Text.RegularExpressions.RegexOptions.IgnoreCase)
            Else
                vbdnet = System.Text.RegularExpressions.Regex.IsMatch(checkText, regText)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            vbdnet = Nothing
            LabelMatchOrNot.Text = "例外(.NET)"
        End Try

    End Function

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelVBSRegExp.LinkClicked
        LinkLabelVBSRegExp.LinkVisited = True
        System.Diagnostics.Process.Start("http://msdn.microsoft.com/ja-jp/library/cc392020.aspx")
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelVBDNRegExp.LinkClicked
        LinkLabelVBDNRegExp.LinkVisited = True
        System.Diagnostics.Process.Start("http://msdn.microsoft.com/ja-jp/library/az24scfc(v=vs.110).aspx")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        LabelMatchOrNot.Text = ""
        LabelMatchOrNot.BackColor = Color.FromKnownColor(KnownColor.Control)
    End Sub
End Class
