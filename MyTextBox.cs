using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    public partial class MyTextBox : UserControl
    {
        private TextBox textBox;
        private Color borderColor = Color.MediumSlateBlue;
        private int borderSize = 2;
        private bool underLinedStyle = false;
        private string placeholderText = "";
        private Color placeholderColor = Color.Gray;
        private bool isPlaceholder = false;
        private bool isPasswordChar = false;
        private bool isFocused = false;

        public MyTextBox()
        {
            InitializeComponent();
            InitializeComponent();
            textBox1.Multiline = true;
            textBox1.Enter += textBox1_Enter;
            textBox1.Leave += textBox1_Leave;
            textBox1.TextChanged += textBox1_TextChanged;
            Controls.Add(textBox);
        }
        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }
        public int BorderSize
        {
            get { return borderSize; }
            set
            {
                borderSize = value;
            }
        }


        public bool UnderLinedStyle
        {
            get { return underLinedStyle; }
            set
            {
                underLinedStyle = value;
                this.Invalidate();
            }
        }

        public bool IsPlaceholder { get => isPlaceholder; set => isPlaceholder = value; }
        public bool IsPasswordChar
        {
            get => isPasswordChar;
            set
            {
                isPasswordChar = value;
                textBox1.UseSystemPasswordChar = value;
            }
        }
        public string Texts
        {
            get
            {
                if (isPlaceholder) return "";
                else return textBox1.Text;

            }
            set
            {
                textBox1.Text = value;
                SetPlaceholder();
            }
        }
        public Color PlaceholderColor
        {
            get { return placeholderColor; }
            set
            {
                placeholderColor = value;
                if (isPasswordChar)
                    textBox1.ForeColor = value;
            }
        }
        public string PlaceholderText
        {
            get { return placeholderText; }
            set
            {
                placeholderText = value;
                textBox1.Text = "";
                SetPlaceholder();
            }
        }

        private void SetPlaceholder()
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) && placeholderText != "")
            {
                isPlaceholder = true;
                textBox1.Text = placeholderText;
                textBox1.ForeColor = placeholderColor;
                if (isPasswordChar)
                    textBox1.UseSystemPasswordChar = false;

            }
        }
        private void RemovePlaceholder()
        {
            if (isPlaceholder && placeholderText != "")
            {
                isPlaceholder = false;
                textBox1.Text = "";
                textBox1.ForeColor = this.ForeColor;
                if (isPasswordChar)
                    textBox1.UseSystemPasswordChar = true;

            }
        }
        private void textBox1_Enter(object sender, EventArgs e)
        {
            isFocused = true;
            this.Invalidate();

            RemovePlaceholder();



        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            isFocused = false;
            this.Invalidate();
            SetPlaceholder();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;

            using (Pen penBorder = new Pen(borderColor, borderSize))
            {
                penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                if (underLinedStyle)
                    graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                else
                    graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
            }
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.DesignMode)
            {
                UpdateControlHeight();
            }

        }

        private void UpdateControlHeight()
        {
            if (textBox1.Multiline == false)
            {
                int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                textBox1.Multiline = true;
                textBox1.MinimumSize = new Size(0, txtHeight);
                textBox1.Multiline = true;

                this.Height = textBox1.Height + this.Padding.Top + this.Padding.Bottom;
            }
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
            SetPlaceholder();
        }
        
        }
    }
