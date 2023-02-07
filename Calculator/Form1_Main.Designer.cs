using System.Drawing;
using System.Windows.Forms;

namespace Calculator
{
    partial class Form1_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1_Main));
            this.Button1 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            this.Button5 = new System.Windows.Forms.Button();
            this.Button6 = new System.Windows.Forms.Button();
            this.Button7 = new System.Windows.Forms.Button();
            this.Button8 = new System.Windows.Forms.Button();
            this.Button9 = new System.Windows.Forms.Button();
            this.Button0 = new System.Windows.Forms.Button();
            this.ButtonClearOne = new System.Windows.Forms.Button();
            this.ButtonClearNumber = new System.Windows.Forms.Button();
            this.ButtonClearFull = new System.Windows.Forms.Button();
            this.ButtonPoint = new System.Windows.Forms.Button();
            this.ButtonDiv = new System.Windows.Forms.Button();
            this.ButtonMult = new System.Windows.Forms.Button();
            this.ButtonMinus = new System.Windows.Forms.Button();
            this.ButtonPlus = new System.Windows.Forms.Button();
            this.ButtonDeg = new System.Windows.Forms.Button();
            this.ButtonRoundBracketsRight = new System.Windows.Forms.Button();
            this.ButtonRoundBracketsLeft = new System.Windows.Forms.Button();
            this.ButtonFactorial = new System.Windows.Forms.Button();
            this.ButtonEq = new System.Windows.Forms.Button();
            this.BoxNumber = new System.Windows.Forms.GroupBox();
            this.PanelNumber = new System.Windows.Forms.Panel();
            this.LabelDecision = new System.Windows.Forms.Label();
            this.LabelNumber = new System.Windows.Forms.Label();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.ToolMenuView = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolViewConverter = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolViewHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolMenuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolEditCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolEditPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolMenuSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolMenuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolHelpHotKey = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolHelpPercent = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonUnFocus = new System.Windows.Forms.Button();
            this.BoxConverter = new System.Windows.Forms.GroupBox();
            this.TextBoxInput = new System.Windows.Forms.TextBox();
            this.ComboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ComboBox3 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ComboBox1 = new System.Windows.Forms.ComboBox();
            this.TextBoxOutput = new System.Windows.Forms.TextBox();
            this.ButtonSqrt = new System.Windows.Forms.Button();
            this.ButtonEqCopyInNumber = new System.Windows.Forms.Button();
            this.PanelCalc = new System.Windows.Forms.Panel();
            this.ButtonPercent = new System.Windows.Forms.Button();
            this.PanelHistory = new System.Windows.Forms.Panel();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BoxNumber.SuspendLayout();
            this.PanelNumber.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            this.BoxConverter.SuspendLayout();
            this.PanelCalc.SuspendLayout();
            this.PanelHistory.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.Color.White;
            this.Button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Button1.Location = new System.Drawing.Point(2, 158);
            this.Button1.Margin = new System.Windows.Forms.Padding(1);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(40, 30);
            this.Button1.TabIndex = 2;
            this.Button1.Tag = "1";
            this.Button1.Text = "1";
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.ButtonsNumber_Click);
            // 
            // Button2
            // 
            this.Button2.BackColor = System.Drawing.Color.White;
            this.Button2.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Button2.Location = new System.Drawing.Point(44, 158);
            this.Button2.Margin = new System.Windows.Forms.Padding(1);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(40, 30);
            this.Button2.TabIndex = 3;
            this.Button2.Tag = "2";
            this.Button2.Text = "2";
            this.Button2.UseVisualStyleBackColor = false;
            this.Button2.Click += new System.EventHandler(this.ButtonsNumber_Click);
            // 
            // Button3
            // 
            this.Button3.BackColor = System.Drawing.Color.White;
            this.Button3.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Button3.Location = new System.Drawing.Point(86, 158);
            this.Button3.Margin = new System.Windows.Forms.Padding(1);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(40, 30);
            this.Button3.TabIndex = 4;
            this.Button3.Tag = "3";
            this.Button3.Text = "3";
            this.Button3.UseVisualStyleBackColor = false;
            this.Button3.Click += new System.EventHandler(this.ButtonsNumber_Click);
            // 
            // Button4
            // 
            this.Button4.BackColor = System.Drawing.Color.White;
            this.Button4.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Button4.Location = new System.Drawing.Point(2, 126);
            this.Button4.Margin = new System.Windows.Forms.Padding(1);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(40, 30);
            this.Button4.TabIndex = 5;
            this.Button4.Tag = "4";
            this.Button4.Text = "4";
            this.Button4.UseVisualStyleBackColor = false;
            this.Button4.Click += new System.EventHandler(this.ButtonsNumber_Click);
            // 
            // Button5
            // 
            this.Button5.BackColor = System.Drawing.Color.White;
            this.Button5.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Button5.Location = new System.Drawing.Point(44, 126);
            this.Button5.Margin = new System.Windows.Forms.Padding(1);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(40, 30);
            this.Button5.TabIndex = 6;
            this.Button5.Tag = "5";
            this.Button5.Text = "5";
            this.Button5.UseVisualStyleBackColor = false;
            this.Button5.Click += new System.EventHandler(this.ButtonsNumber_Click);
            // 
            // Button6
            // 
            this.Button6.BackColor = System.Drawing.Color.White;
            this.Button6.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Button6.Location = new System.Drawing.Point(86, 126);
            this.Button6.Margin = new System.Windows.Forms.Padding(1);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(40, 30);
            this.Button6.TabIndex = 7;
            this.Button6.Tag = "6";
            this.Button6.Text = "6";
            this.Button6.UseVisualStyleBackColor = false;
            this.Button6.Click += new System.EventHandler(this.ButtonsNumber_Click);
            // 
            // Button7
            // 
            this.Button7.BackColor = System.Drawing.Color.White;
            this.Button7.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Button7.Location = new System.Drawing.Point(2, 94);
            this.Button7.Margin = new System.Windows.Forms.Padding(1);
            this.Button7.Name = "Button7";
            this.Button7.Size = new System.Drawing.Size(40, 30);
            this.Button7.TabIndex = 8;
            this.Button7.Tag = "7";
            this.Button7.Text = "7";
            this.Button7.UseVisualStyleBackColor = false;
            this.Button7.Click += new System.EventHandler(this.ButtonsNumber_Click);
            // 
            // Button8
            // 
            this.Button8.BackColor = System.Drawing.Color.White;
            this.Button8.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Button8.Location = new System.Drawing.Point(44, 94);
            this.Button8.Margin = new System.Windows.Forms.Padding(1);
            this.Button8.Name = "Button8";
            this.Button8.Size = new System.Drawing.Size(40, 30);
            this.Button8.TabIndex = 9;
            this.Button8.Tag = "8";
            this.Button8.Text = "8";
            this.Button8.UseVisualStyleBackColor = false;
            this.Button8.Click += new System.EventHandler(this.ButtonsNumber_Click);
            // 
            // Button9
            // 
            this.Button9.BackColor = System.Drawing.Color.White;
            this.Button9.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button9.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Button9.Location = new System.Drawing.Point(86, 94);
            this.Button9.Margin = new System.Windows.Forms.Padding(1);
            this.Button9.Name = "Button9";
            this.Button9.Size = new System.Drawing.Size(40, 30);
            this.Button9.TabIndex = 10;
            this.Button9.Tag = "9";
            this.Button9.Text = "9";
            this.Button9.UseVisualStyleBackColor = false;
            this.Button9.Click += new System.EventHandler(this.ButtonsNumber_Click);
            // 
            // Button0
            // 
            this.Button0.BackColor = System.Drawing.Color.White;
            this.Button0.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.Button0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button0.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Button0.Location = new System.Drawing.Point(2, 190);
            this.Button0.Margin = new System.Windows.Forms.Padding(1);
            this.Button0.Name = "Button0";
            this.Button0.Size = new System.Drawing.Size(82, 30);
            this.Button0.TabIndex = 1;
            this.Button0.Tag = "0";
            this.Button0.Text = "0";
            this.Button0.UseVisualStyleBackColor = false;
            this.Button0.Click += new System.EventHandler(this.ButtonsNumber_Click);
            // 
            // ButtonClearOne
            // 
            this.ButtonClearOne.BackColor = System.Drawing.Color.White;
            this.ButtonClearOne.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonClearOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonClearOne.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.ButtonClearOne.Location = new System.Drawing.Point(2, 62);
            this.ButtonClearOne.Margin = new System.Windows.Forms.Padding(1);
            this.ButtonClearOne.Name = "ButtonClearOne";
            this.ButtonClearOne.Size = new System.Drawing.Size(40, 30);
            this.ButtonClearOne.TabIndex = 12;
            this.ButtonClearOne.Tag = "<<<";
            this.ButtonClearOne.Text = "<<<";
            this.ButtonClearOne.UseVisualStyleBackColor = false;
            this.ButtonClearOne.Click += new System.EventHandler(this.ButtonsNumber_Click);
            // 
            // ButtonClearNumber
            // 
            this.ButtonClearNumber.BackColor = System.Drawing.Color.White;
            this.ButtonClearNumber.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonClearNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonClearNumber.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ButtonClearNumber.Location = new System.Drawing.Point(44, 62);
            this.ButtonClearNumber.Margin = new System.Windows.Forms.Padding(1);
            this.ButtonClearNumber.Name = "ButtonClearNumber";
            this.ButtonClearNumber.Size = new System.Drawing.Size(40, 30);
            this.ButtonClearNumber.TabIndex = 13;
            this.ButtonClearNumber.Text = "CE";
            this.ButtonClearNumber.UseVisualStyleBackColor = false;
            this.ButtonClearNumber.Click += new System.EventHandler(this.ButtonClearNumber_Click);
            // 
            // ButtonClearFull
            // 
            this.ButtonClearFull.BackColor = System.Drawing.Color.White;
            this.ButtonClearFull.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonClearFull.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonClearFull.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ButtonClearFull.Location = new System.Drawing.Point(86, 62);
            this.ButtonClearFull.Margin = new System.Windows.Forms.Padding(1);
            this.ButtonClearFull.Name = "ButtonClearFull";
            this.ButtonClearFull.Size = new System.Drawing.Size(40, 30);
            this.ButtonClearFull.TabIndex = 14;
            this.ButtonClearFull.Text = "C";
            this.ButtonClearFull.UseVisualStyleBackColor = false;
            this.ButtonClearFull.Click += new System.EventHandler(this.ButtonClearFull_Click);
            // 
            // ButtonPoint
            // 
            this.ButtonPoint.BackColor = System.Drawing.Color.White;
            this.ButtonPoint.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonPoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonPoint.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ButtonPoint.Location = new System.Drawing.Point(86, 190);
            this.ButtonPoint.Margin = new System.Windows.Forms.Padding(1);
            this.ButtonPoint.Name = "ButtonPoint";
            this.ButtonPoint.Size = new System.Drawing.Size(40, 30);
            this.ButtonPoint.TabIndex = 11;
            this.ButtonPoint.Tag = ".";
            this.ButtonPoint.Text = ".";
            this.ButtonPoint.UseVisualStyleBackColor = false;
            this.ButtonPoint.Click += new System.EventHandler(this.ButtonsNumber_Click);
            // 
            // ButtonDiv
            // 
            this.ButtonDiv.BackColor = System.Drawing.Color.White;
            this.ButtonDiv.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonDiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDiv.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ButtonDiv.Location = new System.Drawing.Point(128, 94);
            this.ButtonDiv.Margin = new System.Windows.Forms.Padding(1);
            this.ButtonDiv.Name = "ButtonDiv";
            this.ButtonDiv.Size = new System.Drawing.Size(40, 30);
            this.ButtonDiv.TabIndex = 18;
            this.ButtonDiv.Tag = "/";
            this.ButtonDiv.Text = "/";
            this.ButtonDiv.UseVisualStyleBackColor = false;
            this.ButtonDiv.Click += new System.EventHandler(this.ButtonsNumber_Click);
            // 
            // ButtonMult
            // 
            this.ButtonMult.BackColor = System.Drawing.Color.White;
            this.ButtonMult.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonMult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonMult.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ButtonMult.Location = new System.Drawing.Point(128, 126);
            this.ButtonMult.Margin = new System.Windows.Forms.Padding(1);
            this.ButtonMult.Name = "ButtonMult";
            this.ButtonMult.Size = new System.Drawing.Size(40, 30);
            this.ButtonMult.TabIndex = 17;
            this.ButtonMult.Tag = "*";
            this.ButtonMult.Text = "*";
            this.ButtonMult.UseVisualStyleBackColor = false;
            this.ButtonMult.Click += new System.EventHandler(this.ButtonsNumber_Click);
            // 
            // ButtonMinus
            // 
            this.ButtonMinus.BackColor = System.Drawing.Color.White;
            this.ButtonMinus.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonMinus.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ButtonMinus.Location = new System.Drawing.Point(128, 158);
            this.ButtonMinus.Margin = new System.Windows.Forms.Padding(1);
            this.ButtonMinus.Name = "ButtonMinus";
            this.ButtonMinus.Size = new System.Drawing.Size(40, 30);
            this.ButtonMinus.TabIndex = 16;
            this.ButtonMinus.Tag = "-";
            this.ButtonMinus.Text = "-";
            this.ButtonMinus.UseVisualStyleBackColor = false;
            this.ButtonMinus.Click += new System.EventHandler(this.ButtonsNumber_Click);
            // 
            // ButtonPlus
            // 
            this.ButtonPlus.BackColor = System.Drawing.Color.White;
            this.ButtonPlus.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonPlus.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ButtonPlus.Location = new System.Drawing.Point(128, 190);
            this.ButtonPlus.Margin = new System.Windows.Forms.Padding(1);
            this.ButtonPlus.Name = "ButtonPlus";
            this.ButtonPlus.Size = new System.Drawing.Size(40, 30);
            this.ButtonPlus.TabIndex = 15;
            this.ButtonPlus.Tag = "+";
            this.ButtonPlus.Text = "+";
            this.ButtonPlus.UseVisualStyleBackColor = false;
            this.ButtonPlus.Click += new System.EventHandler(this.ButtonsNumber_Click);
            // 
            // ButtonDeg
            // 
            this.ButtonDeg.BackColor = System.Drawing.Color.White;
            this.ButtonDeg.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonDeg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDeg.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.ButtonDeg.Location = new System.Drawing.Point(128, 62);
            this.ButtonDeg.Margin = new System.Windows.Forms.Padding(1);
            this.ButtonDeg.Name = "ButtonDeg";
            this.ButtonDeg.Size = new System.Drawing.Size(40, 30);
            this.ButtonDeg.TabIndex = 20;
            this.ButtonDeg.Tag = "^";
            this.ButtonDeg.Text = "^";
            this.ButtonDeg.UseVisualStyleBackColor = false;
            this.ButtonDeg.Click += new System.EventHandler(this.ButtonsNumber_Click);
            // 
            // ButtonRoundBracketsRight
            // 
            this.ButtonRoundBracketsRight.BackColor = System.Drawing.Color.White;
            this.ButtonRoundBracketsRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonRoundBracketsRight.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonRoundBracketsRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRoundBracketsRight.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ButtonRoundBracketsRight.Location = new System.Drawing.Point(212, 62);
            this.ButtonRoundBracketsRight.Margin = new System.Windows.Forms.Padding(1);
            this.ButtonRoundBracketsRight.Name = "ButtonRoundBracketsRight";
            this.ButtonRoundBracketsRight.Size = new System.Drawing.Size(40, 30);
            this.ButtonRoundBracketsRight.TabIndex = 23;
            this.ButtonRoundBracketsRight.Tag = ")";
            this.ButtonRoundBracketsRight.Text = ")";
            this.ButtonRoundBracketsRight.UseVisualStyleBackColor = false;
            this.ButtonRoundBracketsRight.Click += new System.EventHandler(this.ButtonsNumber_Click);
            // 
            // ButtonRoundBracketsLeft
            // 
            this.ButtonRoundBracketsLeft.BackColor = System.Drawing.Color.White;
            this.ButtonRoundBracketsLeft.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonRoundBracketsLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRoundBracketsLeft.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ButtonRoundBracketsLeft.Location = new System.Drawing.Point(170, 62);
            this.ButtonRoundBracketsLeft.Margin = new System.Windows.Forms.Padding(1);
            this.ButtonRoundBracketsLeft.Name = "ButtonRoundBracketsLeft";
            this.ButtonRoundBracketsLeft.Size = new System.Drawing.Size(40, 30);
            this.ButtonRoundBracketsLeft.TabIndex = 22;
            this.ButtonRoundBracketsLeft.Tag = "(";
            this.ButtonRoundBracketsLeft.Text = "(";
            this.ButtonRoundBracketsLeft.UseVisualStyleBackColor = false;
            this.ButtonRoundBracketsLeft.Click += new System.EventHandler(this.ButtonsNumber_Click);
            // 
            // ButtonFactorial
            // 
            this.ButtonFactorial.BackColor = System.Drawing.Color.White;
            this.ButtonFactorial.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonFactorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonFactorial.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ButtonFactorial.Location = new System.Drawing.Point(212, 94);
            this.ButtonFactorial.Margin = new System.Windows.Forms.Padding(1);
            this.ButtonFactorial.Name = "ButtonFactorial";
            this.ButtonFactorial.Size = new System.Drawing.Size(40, 30);
            this.ButtonFactorial.TabIndex = 21;
            this.ButtonFactorial.Tag = "!";
            this.ButtonFactorial.Text = "n!";
            this.ButtonFactorial.UseVisualStyleBackColor = false;
            this.ButtonFactorial.Click += new System.EventHandler(this.ButtonsNumber_Click);
            // 
            // ButtonEq
            // 
            this.ButtonEq.BackColor = System.Drawing.Color.White;
            this.ButtonEq.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonEq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonEq.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.ButtonEq.Location = new System.Drawing.Point(212, 126);
            this.ButtonEq.Margin = new System.Windows.Forms.Padding(1);
            this.ButtonEq.Name = "ButtonEq";
            this.ButtonEq.Size = new System.Drawing.Size(40, 94);
            this.ButtonEq.TabIndex = 24;
            this.ButtonEq.Text = "=";
            this.ButtonEq.UseVisualStyleBackColor = false;
            this.ButtonEq.Click += new System.EventHandler(this.ButtonEq_Click);
            // 
            // BoxNumber
            // 
            this.BoxNumber.Controls.Add(this.PanelNumber);
            this.BoxNumber.Location = new System.Drawing.Point(2, 2);
            this.BoxNumber.Margin = new System.Windows.Forms.Padding(2);
            this.BoxNumber.Name = "BoxNumber";
            this.BoxNumber.Size = new System.Drawing.Size(250, 57);
            this.BoxNumber.TabIndex = 24;
            this.BoxNumber.TabStop = false;
            // 
            // PanelNumber
            // 
            this.PanelNumber.Controls.Add(this.LabelDecision);
            this.PanelNumber.Controls.Add(this.LabelNumber);
            this.PanelNumber.Location = new System.Drawing.Point(6, 11);
            this.PanelNumber.Name = "PanelNumber";
            this.PanelNumber.Size = new System.Drawing.Size(238, 41);
            this.PanelNumber.TabIndex = 27;
            // 
            // LabelDecision
            // 
            this.LabelDecision.AutoSize = true;
            this.LabelDecision.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelDecision.Location = new System.Drawing.Point(0, 26);
            this.LabelDecision.Name = "LabelDecision";
            this.LabelDecision.Size = new System.Drawing.Size(80, 15);
            this.LabelDecision.TabIndex = 1;
            this.LabelDecision.Text = "LabelDecision";
            this.LabelDecision.MouseHover += new System.EventHandler(this.LabelDecision_MouseHover);
            // 
            // LabelNumber
            // 
            this.LabelNumber.AutoSize = true;
            this.LabelNumber.Dock = System.Windows.Forms.DockStyle.Right;
            this.LabelNumber.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.LabelNumber.Location = new System.Drawing.Point(126, 0);
            this.LabelNumber.Name = "LabelNumber";
            this.LabelNumber.Size = new System.Drawing.Size(112, 25);
            this.LabelNumber.TabIndex = 0;
            this.LabelNumber.Text = "1234567890";
            this.LabelNumber.Click += new System.EventHandler(this.LabelNumber_Click);
            this.LabelNumber.MouseHover += new System.EventHandler(this.LabelNumber_MouseHover);
            // 
            // MenuStrip
            // 
            this.MenuStrip.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolMenuView,
            this.ToolMenuEdit,
            this.ToolMenuSettings,
            this.ToolMenuHelp});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(876, 24);
            this.MenuStrip.TabIndex = 25;
            // 
            // ToolMenuView
            // 
            this.ToolMenuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolViewConverter,
            this.ToolViewHistory});
            this.ToolMenuView.Name = "ToolMenuView";
            this.ToolMenuView.Size = new System.Drawing.Size(39, 20);
            this.ToolMenuView.Text = "Вид";
            // 
            // ToolViewConverter
            // 
            this.ToolViewConverter.CheckOnClick = true;
            this.ToolViewConverter.Name = "ToolViewConverter";
            this.ToolViewConverter.Size = new System.Drawing.Size(132, 22);
            this.ToolViewConverter.Text = "Конвертер";
            this.ToolViewConverter.Click += new System.EventHandler(this.ToolViewOpenItem_Click);
            // 
            // ToolViewHistory
            // 
            this.ToolViewHistory.CheckOnClick = true;
            this.ToolViewHistory.Name = "ToolViewHistory";
            this.ToolViewHistory.Size = new System.Drawing.Size(132, 22);
            this.ToolViewHistory.Text = "Журнал";
            this.ToolViewHistory.Click += new System.EventHandler(this.ToolViewOpenItem_Click);
            // 
            // ToolMenuEdit
            // 
            this.ToolMenuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolEditCopy,
            this.ToolEditPaste});
            this.ToolMenuEdit.Name = "ToolMenuEdit";
            this.ToolMenuEdit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.ToolMenuEdit.Size = new System.Drawing.Size(59, 20);
            this.ToolMenuEdit.Text = "Правка";
            // 
            // ToolEditCopy
            // 
            this.ToolEditCopy.Name = "ToolEditCopy";
            this.ToolEditCopy.Size = new System.Drawing.Size(185, 22);
            this.ToolEditCopy.Text = "Копировать (Ctrl+C)";
            this.ToolEditCopy.Click += new System.EventHandler(this.ToolEditCopy_Click);
            // 
            // ToolEditPaste
            // 
            this.ToolEditPaste.Name = "ToolEditPaste";
            this.ToolEditPaste.Size = new System.Drawing.Size(185, 22);
            this.ToolEditPaste.Text = "Вставить (Ctrl+V)";
            this.ToolEditPaste.Click += new System.EventHandler(this.ToolEditPaste_Click);
            // 
            // ToolMenuSettings
            // 
            this.ToolMenuSettings.Name = "ToolMenuSettings";
            this.ToolMenuSettings.Size = new System.Drawing.Size(79, 20);
            this.ToolMenuSettings.Text = "Настройки";
            this.ToolMenuSettings.Click += new System.EventHandler(this.ToolMenuSettings_Click);
            // 
            // ToolMenuHelp
            // 
            this.ToolMenuHelp.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ToolMenuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolHelpHotKey,
            this.ToolHelpPercent});
            this.ToolMenuHelp.Name = "ToolMenuHelp";
            this.ToolMenuHelp.Size = new System.Drawing.Size(65, 20);
            this.ToolMenuHelp.Text = "Справка";
            // 
            // ToolHelpHotKey
            // 
            this.ToolHelpHotKey.Name = "ToolHelpHotKey";
            this.ToolHelpHotKey.Size = new System.Drawing.Size(205, 22);
            this.ToolHelpHotKey.Text = "Горячие клавиши";
            this.ToolHelpHotKey.Click += new System.EventHandler(this.ToolHelpHotKey_Click);
            // 
            // ToolHelpPercent
            // 
            this.ToolHelpPercent.Name = "ToolHelpPercent";
            this.ToolHelpPercent.Size = new System.Drawing.Size(205, 22);
            this.ToolHelpPercent.Text = "Вычисление процентов";
            this.ToolHelpPercent.Click += new System.EventHandler(this.ToolHelpPercent_Click);
            // 
            // ButtonUnFocus
            // 
            this.ButtonUnFocus.Location = new System.Drawing.Point(-3, -3);
            this.ButtonUnFocus.Name = "ButtonUnFocus";
            this.ButtonUnFocus.Size = new System.Drawing.Size(0, 0);
            this.ButtonUnFocus.TabIndex = 0;
            this.ButtonUnFocus.UseVisualStyleBackColor = true;
            // 
            // BoxConverter
            // 
            this.BoxConverter.Controls.Add(this.TextBoxInput);
            this.BoxConverter.Controls.Add(this.ComboBox2);
            this.BoxConverter.Controls.Add(this.label1);
            this.BoxConverter.Controls.Add(this.ComboBox3);
            this.BoxConverter.Controls.Add(this.label2);
            this.BoxConverter.Controls.Add(this.label3);
            this.BoxConverter.Controls.Add(this.ComboBox1);
            this.BoxConverter.Controls.Add(this.TextBoxOutput);
            this.BoxConverter.Location = new System.Drawing.Point(524, 18);
            this.BoxConverter.Name = "BoxConverter";
            this.BoxConverter.Size = new System.Drawing.Size(347, 218);
            this.BoxConverter.TabIndex = 81;
            this.BoxConverter.TabStop = false;
            this.BoxConverter.Text = "Конвертер";
            this.BoxConverter.Visible = false;
            // 
            // TextBoxInput
            // 
            this.TextBoxInput.Location = new System.Drawing.Point(6, 82);
            this.TextBoxInput.Name = "TextBoxInput";
            this.TextBoxInput.Size = new System.Drawing.Size(335, 20);
            this.TextBoxInput.TabIndex = 80;
            this.TextBoxInput.TextChanged += new System.EventHandler(this.SelectConvert);
            // 
            // ComboBox2
            // 
            this.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox2.FormattingEnabled = true;
            this.ComboBox2.Location = new System.Drawing.Point(6, 108);
            this.ComboBox2.Name = "ComboBox2";
            this.ComboBox2.Size = new System.Drawing.Size(335, 21);
            this.ComboBox2.TabIndex = 78;
            this.ComboBox2.SelectedIndexChanged += new System.EventHandler(this.SelectConvert);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 13);
            this.label1.TabIndex = 72;
            this.label1.Text = "Выберите тип преобразуемой единицы";
            // 
            // ComboBox3
            // 
            this.ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox3.FormattingEnabled = true;
            this.ComboBox3.Location = new System.Drawing.Point(6, 188);
            this.ComboBox3.Name = "ComboBox3";
            this.ComboBox3.Size = new System.Drawing.Size(335, 21);
            this.ComboBox3.TabIndex = 79;
            this.ComboBox3.SelectedIndexChanged += new System.EventHandler(this.SelectConvert);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 73;
            this.label2.Text = "Из";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 74;
            this.label3.Text = "В";
            // 
            // ComboBox1
            // 
            this.ComboBox1.BackColor = System.Drawing.Color.White;
            this.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox1.FormattingEnabled = true;
            this.ComboBox1.Items.AddRange(new object[] {
            "Информация",
            "Время",
            "Системы счисления"});
            this.ComboBox1.Location = new System.Drawing.Point(6, 32);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(335, 21);
            this.ComboBox1.TabIndex = 77;
            this.ComboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // TextBoxOutput
            // 
            this.TextBoxOutput.Location = new System.Drawing.Point(6, 162);
            this.TextBoxOutput.Name = "TextBoxOutput";
            this.TextBoxOutput.ReadOnly = true;
            this.TextBoxOutput.Size = new System.Drawing.Size(335, 20);
            this.TextBoxOutput.TabIndex = 76;
            // 
            // ButtonSqrt
            // 
            this.ButtonSqrt.BackColor = System.Drawing.Color.White;
            this.ButtonSqrt.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonSqrt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSqrt.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ButtonSqrt.Location = new System.Drawing.Point(170, 94);
            this.ButtonSqrt.Margin = new System.Windows.Forms.Padding(1);
            this.ButtonSqrt.Name = "ButtonSqrt";
            this.ButtonSqrt.Size = new System.Drawing.Size(40, 30);
            this.ButtonSqrt.TabIndex = 82;
            this.ButtonSqrt.Tag = "√";
            this.ButtonSqrt.Text = "√n";
            this.ButtonSqrt.UseVisualStyleBackColor = false;
            this.ButtonSqrt.Click += new System.EventHandler(this.ButtonsNumber_Click);
            // 
            // ButtonEqCopyInNumber
            // 
            this.ButtonEqCopyInNumber.BackColor = System.Drawing.Color.White;
            this.ButtonEqCopyInNumber.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonEqCopyInNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonEqCopyInNumber.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.ButtonEqCopyInNumber.Location = new System.Drawing.Point(170, 158);
            this.ButtonEqCopyInNumber.Margin = new System.Windows.Forms.Padding(1);
            this.ButtonEqCopyInNumber.Name = "ButtonEqCopyInNumber";
            this.ButtonEqCopyInNumber.Size = new System.Drawing.Size(40, 62);
            this.ButtonEqCopyInNumber.TabIndex = 88;
            this.ButtonEqCopyInNumber.Text = "Eq>";
            this.ButtonEqCopyInNumber.UseVisualStyleBackColor = false;
            this.ButtonEqCopyInNumber.Click += new System.EventHandler(this.ButtonEqCopyInNumber_Click);
            // 
            // PanelCalc
            // 
            this.PanelCalc.Controls.Add(this.ButtonPercent);
            this.PanelCalc.Controls.Add(this.BoxNumber);
            this.PanelCalc.Controls.Add(this.ButtonEqCopyInNumber);
            this.PanelCalc.Controls.Add(this.Button1);
            this.PanelCalc.Controls.Add(this.Button2);
            this.PanelCalc.Controls.Add(this.Button3);
            this.PanelCalc.Controls.Add(this.Button4);
            this.PanelCalc.Controls.Add(this.Button5);
            this.PanelCalc.Controls.Add(this.Button6);
            this.PanelCalc.Controls.Add(this.ButtonSqrt);
            this.PanelCalc.Controls.Add(this.Button7);
            this.PanelCalc.Controls.Add(this.Button8);
            this.PanelCalc.Controls.Add(this.Button9);
            this.PanelCalc.Controls.Add(this.ButtonEq);
            this.PanelCalc.Controls.Add(this.Button0);
            this.PanelCalc.Controls.Add(this.ButtonFactorial);
            this.PanelCalc.Controls.Add(this.ButtonClearOne);
            this.PanelCalc.Controls.Add(this.ButtonRoundBracketsLeft);
            this.PanelCalc.Controls.Add(this.ButtonClearNumber);
            this.PanelCalc.Controls.Add(this.ButtonRoundBracketsRight);
            this.PanelCalc.Controls.Add(this.ButtonClearFull);
            this.PanelCalc.Controls.Add(this.ButtonDeg);
            this.PanelCalc.Controls.Add(this.ButtonPoint);
            this.PanelCalc.Controls.Add(this.ButtonPlus);
            this.PanelCalc.Controls.Add(this.ButtonDiv);
            this.PanelCalc.Controls.Add(this.ButtonMinus);
            this.PanelCalc.Controls.Add(this.ButtonMult);
            this.PanelCalc.Location = new System.Drawing.Point(267, 16);
            this.PanelCalc.Name = "PanelCalc";
            this.PanelCalc.Size = new System.Drawing.Size(254, 222);
            this.PanelCalc.TabIndex = 89;
            // 
            // ButtonPercent
            // 
            this.ButtonPercent.BackColor = System.Drawing.Color.White;
            this.ButtonPercent.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonPercent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonPercent.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.ButtonPercent.Location = new System.Drawing.Point(170, 126);
            this.ButtonPercent.Margin = new System.Windows.Forms.Padding(1);
            this.ButtonPercent.Name = "ButtonPercent";
            this.ButtonPercent.Size = new System.Drawing.Size(40, 30);
            this.ButtonPercent.TabIndex = 89;
            this.ButtonPercent.Tag = "%";
            this.ButtonPercent.Text = "%";
            this.ButtonPercent.UseVisualStyleBackColor = false;
            this.ButtonPercent.Click += new System.EventHandler(this.ButtonsNumber_Click);
            // 
            // PanelHistory
            // 
            this.PanelHistory.Controls.Add(this.richTextBox);
            this.PanelHistory.Location = new System.Drawing.Point(0, 25);
            this.PanelHistory.Name = "PanelHistory";
            this.PanelHistory.Size = new System.Drawing.Size(269, 211);
            this.PanelHistory.TabIndex = 91;
            this.PanelHistory.Visible = false;
            // 
            // richTextBox
            // 
            this.richTextBox.BackColor = System.Drawing.Color.White;
            this.richTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.richTextBox.Location = new System.Drawing.Point(0, 0);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(269, 211);
            this.richTextBox.TabIndex = 1;
            this.richTextBox.Text = "";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.LabelNumber_Click);
            // 
            // Form1_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(876, 240);
            this.Controls.Add(this.BoxConverter);
            this.Controls.Add(this.MenuStrip);
            this.Controls.Add(this.PanelHistory);
            this.Controls.Add(this.ButtonUnFocus);
            this.Controls.Add(this.PanelCalc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.MenuStrip;
            this.MaximizeBox = false;
            this.Name = "Form1_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Калькулятор";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_Main_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_KeyDown);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Form1_Main_PreviewKeyDown);
            this.BoxNumber.ResumeLayout(false);
            this.PanelNumber.ResumeLayout(false);
            this.PanelNumber.PerformLayout();
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.BoxConverter.ResumeLayout(false);
            this.BoxConverter.PerformLayout();
            this.PanelCalc.ResumeLayout(false);
            this.PanelHistory.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button1;
        private Button Button2;
        private Button Button3;
        private Button Button4;
        private Button Button5;
        private Button Button6;
        private Button Button7;
        private Button Button8;
        private Button Button9;
        private Button Button0;
        private Button ButtonClearOne;
        private Button ButtonClearNumber;
        private Button ButtonClearFull;
        private Button ButtonPoint;
        private Button ButtonDiv;
        private Button ButtonMult;
        private Button ButtonMinus;
        private Button ButtonPlus;
        private Button ButtonDeg;
        private Button ButtonRoundBracketsRight;
        private Button ButtonRoundBracketsLeft;
        private Button ButtonFactorial;
        private Button ButtonEq;
        private GroupBox BoxNumber;
        private Label LabelDecision;
        private Label LabelNumber;
        private MenuStrip MenuStrip;
        private ToolStripMenuItem ToolMenuView;
        private ToolStripMenuItem ToolViewConverter;
        private ToolStripMenuItem ToolMenuEdit;
        private ToolStripMenuItem ToolEditCopy;
        private ToolStripMenuItem ToolEditPaste;
        private ToolStripMenuItem ToolMenuHelp;
        private Button ButtonUnFocus;
        private Panel PanelNumber;
        private GroupBox BoxConverter;
        private ComboBox ComboBox2;
        private Label label1;
        private ComboBox ComboBox3;
        private Label label2;
        private Label label3;
        private ComboBox ComboBox1;
        private TextBox TextBoxOutput;
        private ToolStripMenuItem ToolHelpHotKey;
        private TextBox TextBoxInput;
        private Button ButtonSqrt;
        private Button ButtonEqCopyInNumber;
        private Panel PanelCalc;
        private Panel PanelHistory;
        private ToolStripMenuItem ToolViewHistory;
        private ToolStripMenuItem ToolMenuSettings;
        private Button ButtonPercent;
        private ToolStripMenuItem ToolHelpPercent;
        private RichTextBox richTextBox;
        private ToolTip toolTip1;
        private Timer timer1;
    }
}