<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.m_search_text = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.m_Select_Font = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.fctb = New FastColoredTextBoxNS.FastColoredTextBox()
        Me.fctb_context_strip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cm_cut = New System.Windows.Forms.ToolStripMenuItem()
        Me.cm_copy = New System.Windows.Forms.ToolStripMenuItem()
        Me.cm_paste = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.seperator = New System.Windows.Forms.ToolStripSeparator()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.cm_delete = New System.Windows.Forms.ToolStripMenuItem()
        Me.cm_undo = New System.Windows.Forms.ToolStripMenuItem()
        Me.cm_redo = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.CutToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.CopyToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.PasteToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.m_Delete = New System.Windows.Forms.ToolStripButton()
        Me.m_undo = New System.Windows.Forms.ToolStripButton()
        Me.m_redo = New System.Windows.Forms.ToolStripButton()
        Me.m_search = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.m_set_colors = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.m_help = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.m_edit_Filter = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.fctb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.fctb_context_strip.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.LightGray
        Me.ToolStrip1.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ToolStrip1.GripMargin = New System.Windows.Forms.Padding(10, 2, 2, 2)
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripButton, Me.SaveToolStripButton, Me.toolStripSeparator, Me.CutToolStripButton, Me.CopyToolStripButton, Me.PasteToolStripButton, Me.toolStripSeparator1, Me.m_Delete, Me.ToolStripSeparator3, Me.m_undo, Me.m_redo, Me.ToolStripSeparator2, Me.m_search_text, Me.m_search, Me.ToolStripSeparator5, Me.ToolStripButton1, Me.m_Select_Font, Me.m_set_colors, Me.ToolStripSeparator7, Me.ToolStripTextBox1, Me.ToolStripSeparator6, Me.ToolStripButton4, Me.m_help, Me.ToolStripButton3, Me.ToolStripButton2, Me.m_edit_Filter})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(5, 0, 1, 0)
        Me.ToolStrip1.Size = New System.Drawing.Size(1176, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'm_search_text
        '
        Me.m_search_text.AcceptsReturn = True
        Me.m_search_text.AutoSize = False
        Me.m_search_text.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.m_search_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.m_search_text.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.m_search_text.Name = "m_search_text"
        Me.m_search_text.Size = New System.Drawing.Size(199, 23)
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'm_Select_Font
        '
        Me.m_Select_Font.Name = "m_Select_Font"
        Me.m_Select_Font.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 25)
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'fctb
        '
        Me.fctb.AutoCompleteBracketsList = New Char() {Global.Microsoft.VisualBasic.ChrW(40), Global.Microsoft.VisualBasic.ChrW(41), Global.Microsoft.VisualBasic.ChrW(123), Global.Microsoft.VisualBasic.ChrW(125), Global.Microsoft.VisualBasic.ChrW(91), Global.Microsoft.VisualBasic.ChrW(93), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(39), Global.Microsoft.VisualBasic.ChrW(39)}
        Me.fctb.AutoIndent = False
        Me.fctb.AutoIndentChars = False
        Me.fctb.AutoIndentCharsPatterns = ""
        Me.fctb.AutoIndentExistingLines = False
        Me.fctb.AutoScrollMinSize = New System.Drawing.Size(27, 12)
        Me.fctb.BackBrush = Nothing
        Me.fctb.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.fctb.BookmarkColor = System.Drawing.Color.MediumTurquoise
        Me.fctb.CaretColor = System.Drawing.Color.White
        Me.fctb.CharHeight = 12
        Me.fctb.CharWidth = 8
        Me.fctb.CommentPrefix = Nothing
        Me.fctb.ContextMenuStrip = Me.fctb_context_strip
        Me.fctb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.fctb.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.fctb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fctb.Font = New System.Drawing.Font("Lucida Console", 9.75!)
        Me.fctb.ForeColor = System.Drawing.Color.DodgerBlue
        Me.fctb.HighlightFoldingIndicator = False
        Me.fctb.IndentBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.fctb.IsReplaceMode = False
        Me.fctb.LeftBracket = Global.Microsoft.VisualBasic.ChrW(60)
        Me.fctb.LeftBracket2 = Global.Microsoft.VisualBasic.ChrW(40)
        Me.fctb.LineNumberColor = System.Drawing.Color.Gray
        Me.fctb.Location = New System.Drawing.Point(0, 25)
        Me.fctb.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.fctb.Name = "fctb"
        Me.fctb.PaddingBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.fctb.Paddings = New System.Windows.Forms.Padding(0)
        Me.fctb.RightBracket = Global.Microsoft.VisualBasic.ChrW(62)
        Me.fctb.RightBracket2 = Global.Microsoft.VisualBasic.ChrW(41)
        Me.fctb.SelectionColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.fctb.ServiceColors = Nothing
        Me.fctb.ServiceLinesColor = System.Drawing.Color.Black
        Me.fctb.Size = New System.Drawing.Size(1176, 633)
        Me.fctb.TabIndex = 1
        Me.fctb.TabLength = 3
        Me.fctb.Zoom = 100
        '
        'fctb_context_strip
        '
        Me.fctb_context_strip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cm_cut, Me.cm_copy, Me.cm_paste, Me.ToolStripSeparator4, Me.cm_delete, Me.seperator, Me.cm_undo, Me.cm_redo})
        Me.fctb_context_strip.Name = "ContextMenuStrip1"
        Me.fctb_context_strip.Size = New System.Drawing.Size(108, 148)
        '
        'cm_cut
        '
        Me.cm_cut.Name = "cm_cut"
        Me.cm_cut.Size = New System.Drawing.Size(107, 22)
        Me.cm_cut.Text = "Cut"
        '
        'cm_copy
        '
        Me.cm_copy.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cm_copy.Name = "cm_copy"
        Me.cm_copy.Size = New System.Drawing.Size(107, 22)
        Me.cm_copy.Text = "Copy"
        '
        'cm_paste
        '
        Me.cm_paste.Name = "cm_paste"
        Me.cm_paste.Size = New System.Drawing.Size(107, 22)
        Me.cm_paste.Text = "Paste"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(104, 6)
        '
        'seperator
        '
        Me.seperator.Name = "seperator"
        Me.seperator.Size = New System.Drawing.Size(104, 6)
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'cm_delete
        '
        Me.cm_delete.Image = CType(resources.GetObject("cm_delete.Image"), System.Drawing.Image)
        Me.cm_delete.Name = "cm_delete"
        Me.cm_delete.Size = New System.Drawing.Size(107, 22)
        Me.cm_delete.Text = "Delete"
        '
        'cm_undo
        '
        Me.cm_undo.Image = CType(resources.GetObject("cm_undo.Image"), System.Drawing.Image)
        Me.cm_undo.ImageTransparentColor = System.Drawing.Color.Black
        Me.cm_undo.Name = "cm_undo"
        Me.cm_undo.Size = New System.Drawing.Size(107, 22)
        Me.cm_undo.Text = "Undo"
        '
        'cm_redo
        '
        Me.cm_redo.Image = CType(resources.GetObject("cm_redo.Image"), System.Drawing.Image)
        Me.cm_redo.ImageTransparentColor = System.Drawing.Color.Black
        Me.cm_redo.Name = "cm_redo"
        Me.cm_redo.Size = New System.Drawing.Size(107, 22)
        Me.cm_redo.Text = "Redo"
        '
        'OpenToolStripButton
        '
        Me.OpenToolStripButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OpenToolStripButton.Image = Global.xml_editor.My.Resources.Resources.xml_open
        Me.OpenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenToolStripButton.Name = "OpenToolStripButton"
        Me.OpenToolStripButton.Size = New System.Drawing.Size(55, 22)
        Me.OpenToolStripButton.Text = "&Open"
        '
        'SaveToolStripButton
        '
        Me.SaveToolStripButton.Image = Global.xml_editor.My.Resources.Resources.xml_save
        Me.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripButton.Name = "SaveToolStripButton"
        Me.SaveToolStripButton.Size = New System.Drawing.Size(55, 22)
        Me.SaveToolStripButton.Text = "&Save"
        '
        'CutToolStripButton
        '
        Me.CutToolStripButton.Image = Global.xml_editor.My.Resources.Resources.xml_cut
        Me.CutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CutToolStripButton.Name = "CutToolStripButton"
        Me.CutToolStripButton.Size = New System.Drawing.Size(48, 22)
        Me.CutToolStripButton.Text = "C&ut"
        '
        'CopyToolStripButton
        '
        Me.CopyToolStripButton.Image = Global.xml_editor.My.Resources.Resources.xml_copy
        Me.CopyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CopyToolStripButton.Name = "CopyToolStripButton"
        Me.CopyToolStripButton.Size = New System.Drawing.Size(55, 22)
        Me.CopyToolStripButton.Text = "&Copy"
        '
        'PasteToolStripButton
        '
        Me.PasteToolStripButton.Image = Global.xml_editor.My.Resources.Resources.xml_paste
        Me.PasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PasteToolStripButton.Name = "PasteToolStripButton"
        Me.PasteToolStripButton.Size = New System.Drawing.Size(62, 22)
        Me.PasteToolStripButton.Text = "&Paste"
        '
        'm_Delete
        '
        Me.m_Delete.Image = Global.xml_editor.My.Resources.Resources.xml_delete
        Me.m_Delete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.m_Delete.Name = "m_Delete"
        Me.m_Delete.Size = New System.Drawing.Size(69, 22)
        Me.m_Delete.Text = "Delete"
        Me.m_Delete.ToolTipText = "Delete"
        '
        'm_undo
        '
        Me.m_undo.Image = Global.xml_editor.My.Resources.Resources.xml_undo
        Me.m_undo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.m_undo.Name = "m_undo"
        Me.m_undo.Size = New System.Drawing.Size(55, 22)
        Me.m_undo.Text = "Undo"
        Me.m_undo.ToolTipText = "Undo"
        '
        'm_redo
        '
        Me.m_redo.Image = Global.xml_editor.My.Resources.Resources.xml_redo
        Me.m_redo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.m_redo.Name = "m_redo"
        Me.m_redo.Size = New System.Drawing.Size(55, 22)
        Me.m_redo.Text = "Redo"
        Me.m_redo.ToolTipText = "Redo"
        '
        'm_search
        '
        Me.m_search.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.m_search.Image = Global.xml_editor.My.Resources.Resources.xml_find
        Me.m_search.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.m_search.Name = "m_search"
        Me.m_search.Size = New System.Drawing.Size(23, 22)
        Me.m_search.Text = "Search"
        Me.m_search.ToolTipText = "Seaarch"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = Global.xml_editor.My.Resources.Resources.xml_font
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "Font"
        '
        'm_set_colors
        '
        Me.m_set_colors.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.m_set_colors.Image = Global.xml_editor.My.Resources.Resources.xml_color
        Me.m_set_colors.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.m_set_colors.Name = "m_set_colors"
        Me.m_set_colors.Size = New System.Drawing.Size(23, 22)
        Me.m_set_colors.ToolTipText = "Set Colors"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.Image = Global.xml_editor.My.Resources.Resources.xml_source
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(69, 22)
        Me.ToolStripButton4.Text = "Source"
        '
        'm_help
        '
        Me.m_help.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.m_help.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.m_help.Image = Global.xml_editor.My.Resources.Resources.xml_info
        Me.m_help.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.m_help.Name = "m_help"
        Me.m_help.Size = New System.Drawing.Size(23, 22)
        Me.m_help.Text = "ToolStripButton2"
        Me.m_help.ToolTipText = "Help"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Image = Global.xml_editor.My.Resources.Resources.xml_destination
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(104, 22)
        Me.ToolStripButton3.Text = "Destination"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = Global.xml_editor.My.Resources.Resources.xml_build
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(62, 22)
        Me.ToolStripButton2.Text = "Build"
        '
        'm_edit_Filter
        '
        Me.m_edit_Filter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.m_edit_Filter.Image = Global.xml_editor.My.Resources.Resources.xml_cut
        Me.m_edit_Filter.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.m_edit_Filter.Name = "m_edit_Filter"
        Me.m_edit_Filter.Size = New System.Drawing.Size(23, 20)
        Me.m_edit_Filter.Text = "Edit Filter Strings"
        Me.m_edit_Filter.ToolTipText = "Edit Filter List" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "These are the tags tags that usually follow the <property> tag" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "They mess up the XML format and have to be handled."
        Me.m_edit_Filter.Visible = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1176, 658)
        Me.Controls.Add(Me.fctb)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "XML Editor"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.fctb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.fctb_context_strip.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents OpenToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents SaveToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CutToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents CopyToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents PasteToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents fctb As FastColoredTextBoxNS.FastColoredTextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents m_search_text As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents m_search As System.Windows.Forms.ToolStripButton
    Friend WithEvents m_Delete As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents m_undo As System.Windows.Forms.ToolStripButton
    Friend WithEvents m_redo As System.Windows.Forms.ToolStripButton
    Friend WithEvents m_edit_Filter As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents m_Select_Font As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents fctb_context_strip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cm_cut As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cm_copy As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cm_paste As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cm_delete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents seperator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cm_undo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cm_redo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents m_set_colors As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents m_help As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents ToolStripButton4 As ToolStripButton
End Class
