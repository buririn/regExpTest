<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TextBoxRegPattern = New System.Windows.Forms.TextBox()
        Me.TextBoxCheckStrigs = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LabelRegPattern = New System.Windows.Forms.Label()
        Me.LabelCheckStrings = New System.Windows.Forms.Label()
        Me.LinkLabelVBSRegExp = New System.Windows.Forms.LinkLabel()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.LabelEffectiveStringsLength = New System.Windows.Forms.Label()
        Me.LabelMatchOrNot = New System.Windows.Forms.Label()
        Me.LabelCheckResult = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.LinkLabelVBDNRegExp = New System.Windows.Forms.LinkLabel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.LabelCehckStrLength = New System.Windows.Forms.Label()
        Me.LabelRegPatLength = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBoxRegPattern
        '
        Me.TextBoxRegPattern.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxRegPattern.Location = New System.Drawing.Point(117, 8)
        Me.TextBoxRegPattern.Name = "TextBoxRegPattern"
        Me.TextBoxRegPattern.Size = New System.Drawing.Size(100, 19)
        Me.TextBoxRegPattern.TabIndex = 0
        '
        'TextBoxCheckStrigs
        '
        Me.TextBoxCheckStrigs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxCheckStrigs.Location = New System.Drawing.Point(117, 37)
        Me.TextBoxCheckStrigs.Name = "TextBoxCheckStrigs"
        Me.TextBoxCheckStrigs.Size = New System.Drawing.Size(100, 19)
        Me.TextBoxCheckStrigs.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(140, 170)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "実行"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LabelRegPattern
        '
        Me.LabelRegPattern.AutoSize = True
        Me.LabelRegPattern.Location = New System.Drawing.Point(3, 10)
        Me.LabelRegPattern.Name = "LabelRegPattern"
        Me.LabelRegPattern.Size = New System.Drawing.Size(53, 12)
        Me.LabelRegPattern.TabIndex = 3
        Me.LabelRegPattern.Text = "正規表現"
        '
        'LabelCheckStrings
        '
        Me.LabelCheckStrings.AutoSize = True
        Me.LabelCheckStrings.Location = New System.Drawing.Point(3, 37)
        Me.LabelCheckStrings.Name = "LabelCheckStrings"
        Me.LabelCheckStrings.Size = New System.Drawing.Size(72, 12)
        Me.LabelCheckStrings.TabIndex = 4
        Me.LabelCheckStrings.Text = "チェック文字列"
        '
        'LinkLabelVBSRegExp
        '
        Me.LinkLabelVBSRegExp.AutoSize = True
        Me.LinkLabelVBSRegExp.Location = New System.Drawing.Point(10, 178)
        Me.LinkLabelVBSRegExp.Name = "LinkLabelVBSRegExp"
        Me.LinkLabelVBSRegExp.Size = New System.Drawing.Size(99, 12)
        Me.LinkLabelVBSRegExp.TabIndex = 6
        Me.LinkLabelVBSRegExp.TabStop = True
        Me.LinkLabelVBSRegExp.Text = "VBScript正規表現"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(5, 15)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(49, 15)
        Me.RadioButton1.TabIndex = 7
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "しない"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(5, 33)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(40, 15)
        Me.RadioButton2.TabIndex = 8
        Me.RadioButton2.Text = "する"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Font = New System.Drawing.Font("MS UI Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(15, 108)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(87, 53)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "大小文字区別"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(168, 85)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {7000, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(45, 19)
        Me.NumericUpDown1.TabIndex = 10
        Me.NumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabelEffectiveStringsLength
        '
        Me.LabelEffectiveStringsLength.AutoSize = True
        Me.LabelEffectiveStringsLength.Location = New System.Drawing.Point(3, 88)
        Me.LabelEffectiveStringsLength.Name = "LabelEffectiveStringsLength"
        Me.LabelEffectiveStringsLength.Size = New System.Drawing.Size(108, 12)
        Me.LabelEffectiveStringsLength.TabIndex = 11
        Me.LabelEffectiveStringsLength.Text = "チェック対象文字列数"
        '
        'LabelMatchOrNot
        '
        Me.LabelMatchOrNot.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelMatchOrNot.AutoSize = True
        Me.LabelMatchOrNot.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.LabelMatchOrNot.Location = New System.Drawing.Point(117, 67)
        Me.LabelMatchOrNot.Name = "LabelMatchOrNot"
        Me.LabelMatchOrNot.Size = New System.Drawing.Size(0, 12)
        Me.LabelMatchOrNot.TabIndex = 12
        Me.LabelMatchOrNot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelCheckResult
        '
        Me.LabelCheckResult.AutoSize = True
        Me.LabelCheckResult.Location = New System.Drawing.Point(3, 66)
        Me.LabelCheckResult.Name = "LabelCheckResult"
        Me.LabelCheckResult.Size = New System.Drawing.Size(54, 12)
        Me.LabelCheckResult.TabIndex = 13
        Me.LabelCheckResult.Text = "マッチ結果"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RadioButton3)
        Me.GroupBox2.Controls.Add(Me.RadioButton4)
        Me.GroupBox2.Font = New System.Drawing.Font("MS UI Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(117, 108)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(98, 53)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "正規表現エンジン"
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Checked = True
        Me.RadioButton3.Location = New System.Drawing.Point(5, 15)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(65, 15)
        Me.RadioButton3.TabIndex = 7
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "VBScript"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(5, 33)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(44, 15)
        Me.RadioButton4.TabIndex = 8
        Me.RadioButton4.Text = ".NET"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'LinkLabelVBDNRegExp
        '
        Me.LinkLabelVBDNRegExp.AutoSize = True
        Me.LinkLabelVBDNRegExp.Location = New System.Drawing.Point(10, 201)
        Me.LinkLabelVBDNRegExp.Name = "LinkLabelVBDNRegExp"
        Me.LinkLabelVBDNRegExp.Size = New System.Drawing.Size(77, 12)
        Me.LinkLabelVBDNRegExp.TabIndex = 14
        Me.LinkLabelVBDNRegExp.TabStop = True
        Me.LinkLabelVBDNRegExp.Text = ".NET正規表現"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(140, 199)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "結果クリア"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'LabelCehckStrLength
        '
        Me.LabelCehckStrLength.Font = New System.Drawing.Font("MS UI Gothic", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.LabelCehckStrLength.Location = New System.Drawing.Point(3, 49)
        Me.LabelCehckStrLength.Name = "LabelCehckStrLength"
        Me.LabelCehckStrLength.Size = New System.Drawing.Size(38, 12)
        Me.LabelCehckStrLength.TabIndex = 17
        Me.LabelCehckStrLength.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelRegPatLength
        '
        Me.LabelRegPatLength.Font = New System.Drawing.Font("MS UI Gothic", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.LabelRegPatLength.Location = New System.Drawing.Point(3, 22)
        Me.LabelRegPatLength.Name = "LabelRegPatLength"
        Me.LabelRegPatLength.Size = New System.Drawing.Size(38, 12)
        Me.LabelRegPatLength.TabIndex = 18
        Me.LabelRegPatLength.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(227, 229)
        Me.Controls.Add(Me.LabelRegPatLength)
        Me.Controls.Add(Me.LabelCehckStrLength)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.LinkLabelVBDNRegExp)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.LabelCheckResult)
        Me.Controls.Add(Me.LabelMatchOrNot)
        Me.Controls.Add(Me.LabelEffectiveStringsLength)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LinkLabelVBSRegExp)
        Me.Controls.Add(Me.LabelCheckStrings)
        Me.Controls.Add(Me.LabelRegPattern)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBoxCheckStrigs)
        Me.Controls.Add(Me.TextBoxRegPattern)
        Me.Name = "Form1"
        Me.Text = "正規表現テスト"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBoxRegPattern As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxCheckStrigs As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents LabelRegPattern As System.Windows.Forms.Label
    Friend WithEvents LabelCheckStrings As System.Windows.Forms.Label
    Friend WithEvents LinkLabelVBSRegExp As System.Windows.Forms.LinkLabel
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents LabelEffectiveStringsLength As System.Windows.Forms.Label
    Friend WithEvents LabelMatchOrNot As System.Windows.Forms.Label
    Friend WithEvents LabelCheckResult As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents LinkLabelVBDNRegExp As System.Windows.Forms.LinkLabel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents LabelCehckStrLength As System.Windows.Forms.Label
    Friend WithEvents LabelRegPatLength As System.Windows.Forms.Label

End Class
