using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cbhk_editor.ToolClasses
{
    class TextBoxTransparent:TextBox
    {
        #region private variables

        private uPictureBox myPictureBox;
        private bool myUpToDate = false;
        private bool myCaretUpToDate = false;
        private Bitmap myBitmap;
        private Bitmap myAlphaBitmap;

        private int myFontHeight = 10;

        private Timer myTimer1;

        private bool myCaretState = true;

        private bool myPaintedFirstTime = false;

        private Color myBackColor = Color.White;
        private int myBackAlpha = 10;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private Container components = null;

        #endregion // end private variables


        #region public methods and overrides

        public class win32
        {

            public const int WM_MOUSEMOVE = 0x0200;
            public const int WM_LBUTTONDOWN = 0x0201;
            public const int WM_LBUTTONUP = 0x0202;
            public const int WM_RBUTTONDOWN = 0x0204;
            public const int WM_LBUTTONDBLCLK = 0x0203;

            public const int WM_MOUSELEAVE = 0x02A3;



            public const int WM_PAINT = 0x000F;
            public const int WM_ERASEBKGND = 0x0014;

            public const int WM_PRINT = 0x0317;

            //const int EN_HSCROLL       =   0x0601;
            //const int EN_VSCROLL       =   0x0602;

            public const int WM_HSCROLL = 0x0114;
            public const int WM_VSCROLL = 0x0115;


            public const int EM_GETSEL = 0x00B0;
            public const int EM_LINEINDEX = 0x00BB;
            public const int EM_LINEFROMCHAR = 0x00C9;

            public const int EM_POSFROMCHAR = 0x00D6;



            [DllImport("USER32.DLL", EntryPoint = "PostMessage")]
            public static extern bool PostMessage(IntPtr hwnd, uint msg,
                IntPtr wParam, IntPtr lParam);

            /*
                BOOL PostMessage(          HWND hWnd,
                    UINT Msg,
                    WPARAM wParam,
                    LPARAM lParam
                    );
            */

            // Put this declaration in your class   //IntPtr
            [DllImport("USER32.DLL", EntryPoint = "SendMessage")]
            public static extern int SendMessage(IntPtr hwnd, int msg, IntPtr wParam,
                IntPtr lParam);




            [DllImport("USER32.DLL", EntryPoint = "GetCaretBlinkTime")]
            public static extern uint GetCaretBlinkTime();




            const int WM_PRINTCLIENT = 0x0318;

            const long PRF_CHECKVISIBLE = 0x00000001L;
            const long PRF_NONCLIENT = 0x00000002L;
            const long PRF_CLIENT = 0x00000004L;
            const long PRF_ERASEBKGND = 0x00000008L;
            const long PRF_CHILDREN = 0x00000010L;
            const long PRF_OWNED = 0x00000020L;

            /*  Will clean this up later doing something like this
            enum  CaptureOptions : long
            {
                PRF_CHECKVISIBLE= 0x00000001L,
                PRF_NONCLIENT    = 0x00000002L,
                PRF_CLIENT        = 0x00000004L,
                PRF_ERASEBKGND    = 0x00000008L,
                PRF_CHILDREN    = 0x00000010L,
                PRF_OWNED        = 0x00000020L
            }
            */


            public static bool CaptureWindow(Control control,
                                    ref Bitmap bitmap)
            {
                //This function captures the contents of a window or control

                Graphics g2 = Graphics.FromImage(bitmap);

                //PRF_CHILDREN // PRF_NONCLIENT
                int meint = (int)(PRF_CLIENT | PRF_ERASEBKGND); //| PRF_OWNED ); //  );
                IntPtr meptr = new IntPtr(meint);

                IntPtr hdc = g2.GetHdc();
                win32.SendMessage(control.Handle, win32.WM_PRINT, hdc, meptr);

                g2.ReleaseHdc(hdc);
                g2.Dispose();

                return true;

            }



        }

        public TextBoxTransparent()
        {
            // This call is required by the Windows.Forms Form Designer.
            InitializeComponent();
            // TODO: Add any initialization after the InitializeComponent call

            BackColor = myBackColor;

            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);


            myPictureBox = new uPictureBox();
            Controls.Add(myPictureBox);
            myPictureBox.Dock = DockStyle.Fill;
        }


        protected override void OnResize(EventArgs e)
        {

            base.OnResize(e);
            myBitmap = new Bitmap(ClientRectangle.Width, ClientRectangle.Height);//(Width,Height);
            myAlphaBitmap = new Bitmap(ClientRectangle.Width, ClientRectangle.Height);//(Width,Height);
            myUpToDate = false;
            Invalidate();
        }


        //Some of these should be moved to the WndProc later

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            myUpToDate = false;
            Invalidate();
        }

        protected override void OnKeyUp(KeyEventArgs e)
        {
            base.OnKeyUp(e);
            myUpToDate = false;
            Invalidate();

        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            myUpToDate = false;
            Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            Invalidate();
        }

        protected override void OnGiveFeedback(GiveFeedbackEventArgs gfbevent)
        {
            base.OnGiveFeedback(gfbevent);
            myUpToDate = false;
            Invalidate();
        }


        protected override void OnMouseLeave(EventArgs e)
        {
            //found this code to find the current cursor location
            //at http://www.syncfusion.com/FAQ/WinForms/FAQ_c50c.asp#q597q

            Point ptCursor = Cursor.Position;

            Form f = FindForm();
            ptCursor = f.PointToClient(ptCursor);
            if (!Bounds.Contains(ptCursor))
                base.OnMouseLeave(e);
        }


        protected override void OnChangeUICues(UICuesEventArgs e)
        {
            base.OnChangeUICues(e);
            myUpToDate = false;
            Invalidate();
        }


        //--
        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            myCaretUpToDate = false;
            myUpToDate = false;
            Invalidate();


            myTimer1 = new Timer(components);
            myTimer1.Interval = (int)win32.GetCaretBlinkTime(); //  usually around 500;

            myTimer1.Tick += new EventHandler(myTimer1_Tick);
            myTimer1.Enabled = true;

        }

        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            myCaretUpToDate = false;
            myUpToDate = false;
            Invalidate();
            myTimer1.Dispose();
        }

        //--

        protected override void OnFontChanged(EventArgs e)
        {
            if (myPaintedFirstTime)
                SetStyle(ControlStyles.UserPaint, false);

            base.OnFontChanged(e);

            if (myPaintedFirstTime)
                SetStyle(ControlStyles.UserPaint, true);


            myFontHeight = GetFontHeight();


            myUpToDate = false;
            Invalidate();
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            myUpToDate = false;
            Invalidate();
        }


        protected override void WndProc(ref Message m)
        {

            base.WndProc(ref m);

            // need to rewrite as a big switch

            if (m.Msg == win32.WM_PAINT)
            {

                myPaintedFirstTime = true;

                if (!myUpToDate || !myCaretUpToDate)
                    GetBitmaps();
                myUpToDate = true;
                myCaretUpToDate = true;

                if (myPictureBox.Image != null) myPictureBox.Image.Dispose();


                if (string.IsNullOrEmpty(Text)/* && !string.IsNullOrEmpty(PromptText)*/)
                {
                    Bitmap bit = (Bitmap)myAlphaBitmap.Clone();
                    Graphics g = Graphics.FromImage(bit);
                    SizeF sizet1 = g.MeasureString("", Font);
                    g.DrawString("", Font, new SolidBrush(Color.FromArgb(0, 0, 0)), new PointF(3, (bit.Height - sizet1.Height) / 2));
                    g.Dispose();
                    myPictureBox.Image = bit;
                }
                else
                {
                    myPictureBox.Image = (Image)myAlphaBitmap.Clone();
                }
            }

            else if (m.Msg == win32.WM_HSCROLL || m.Msg == win32.WM_VSCROLL)
            {
                myUpToDate = false;
                Invalidate();
            }

            else if (m.Msg == win32.WM_LBUTTONDOWN
                || m.Msg == win32.WM_RBUTTONDOWN
                || m.Msg == win32.WM_LBUTTONDBLCLK
                //  || m.Msg == win32.WM_MOUSELEAVE  ///****
                )
            {
                myUpToDate = false;
                Invalidate();
            }

            else if (m.Msg == win32.WM_MOUSEMOVE)
            {
                if (m.WParam.ToInt32() != 0)  //shift key or other buttons
                {
                    myUpToDate = false;
                    Invalidate();
                }
            }

            if (m.Msg == 15 || m.Msg == 7 || m.Msg == 8)
            {
                base.OnPaint(null);
            }

            //System.Diagnostics.Debug.WriteLine("Pro: " + m.Msg.ToString("X"));

        }


        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                //BackColor = Color.Pink;
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #endregion        //end public method and overrides


        #region public property overrides

        public new BorderStyle BorderStyle
        {
            get { return base.BorderStyle; }
            set
            {
                if (myPaintedFirstTime)
                    SetStyle(ControlStyles.UserPaint, false);

                base.BorderStyle = BorderStyle.None;
                if (myPaintedFirstTime)
                    SetStyle(ControlStyles.UserPaint, true);
                myBitmap = null;
                myAlphaBitmap = null;
                myUpToDate = false;
                Invalidate();
            }
        }

        public new Color BackColor
        {
            get
            {
                return Color.FromArgb(base.BackColor.R, base.BackColor.G, base.BackColor.B);
            }
            set
            {
                myBackColor = value;
                base.BackColor = value;
                myUpToDate = false;
            }
        }
        public override bool Multiline
        {
            get { return base.Multiline; }
            set
            {
                if (myPaintedFirstTime)
                    SetStyle(ControlStyles.UserPaint, false);

                base.Multiline = value;

                if (myPaintedFirstTime)
                    SetStyle(ControlStyles.UserPaint, true);

                myBitmap = null;
                myAlphaBitmap = null;
                myUpToDate = false;
                Invalidate();
            }
        }


        #endregion    //end public property overrides


        #region private functions and classes

        private int GetFontHeight()
        {
            Graphics g = CreateGraphics();
            SizeF sf_font = g.MeasureString("X", Font);
            g.Dispose();
            return (int)sf_font.Height;
        }


        private void GetBitmaps()
        {

            if (myBitmap == null
                || myAlphaBitmap == null
                || myBitmap.Width != Width
                || myBitmap.Height != Height
                || myAlphaBitmap.Width != Width
                || myAlphaBitmap.Height != Height)
            {
                myBitmap = null;
                myAlphaBitmap = null;
            }



            if (myBitmap == null)
            {
                myBitmap = new Bitmap(ClientRectangle.Width, ClientRectangle.Height);//(Width,Height);
                myUpToDate = false;
            }


            if (!myUpToDate)
            {
                //Capture the TextBox control window

                SetStyle(ControlStyles.UserPaint, false);

                win32.CaptureWindow(this, ref myBitmap);

                SetStyle(ControlStyles.UserPaint, true);
                SetStyle(ControlStyles.SupportsTransparentBackColor, true);
                BackColor = Color.FromArgb(myBackAlpha, myBackColor);

            }
            //--



            Rectangle r2 = new Rectangle(0, 0, ClientRectangle.Width, ClientRectangle.Height);
            ImageAttributes tempImageAttr = new ImageAttributes();


            //Found the color map code in the MS Help

            ColorMap[] tempColorMap = new ColorMap[1];
            tempColorMap[0] = new ColorMap();
            tempColorMap[0].OldColor = Color.FromArgb(255, myBackColor);
            tempColorMap[0].NewColor = Color.FromArgb(myBackAlpha, myBackColor);

            tempImageAttr.SetRemapTable(tempColorMap);

            if (myAlphaBitmap != null)
                myAlphaBitmap.Dispose();


            myAlphaBitmap = new Bitmap(ClientRectangle.Width, ClientRectangle.Height);//(Width,Height);

            Graphics tempGraphics1 = Graphics.FromImage(myAlphaBitmap);

            tempGraphics1.DrawImage(myBitmap, r2, 0, 0, ClientRectangle.Width, ClientRectangle.Height, GraphicsUnit.Pixel, tempImageAttr);

            tempGraphics1.Dispose();

            //----

            if (Focused && (SelectionLength == 0))
            {
                Graphics tempGraphics2 = Graphics.FromImage(myAlphaBitmap);
                if (myCaretState)
                {
                    //Draw the caret
                    Point caret = findCaret();
                    Pen p = new Pen(ForeColor, 3);
                    tempGraphics2.DrawLine(p, caret.X + 2, caret.Y + 0, caret.X + 2, caret.Y + myFontHeight);
                    tempGraphics2.Dispose();
                }

            }



        }



        private Point findCaret()
        {
            /*  Find the caret translated from code at
             * http://www.vb-helper.com/howto_track_textbox_caret.html
             *
             * and
             *
             * http://www.microbion.co.uk/developers/csharp/textpos2.htm
             *
             * Changed to EM_POSFROMCHAR
             *
             * This code still needs to be cleaned up and debugged
             * */

            Point pointCaret = new Point(0);
            int i_char_loc = SelectionStart;
            IntPtr pi_char_loc = new IntPtr(i_char_loc);

            int i_point = win32.SendMessage(Handle, win32.EM_POSFROMCHAR, pi_char_loc, IntPtr.Zero);
            pointCaret = new Point(i_point);

            if (i_char_loc == 0)
            {
                pointCaret = new Point(0);
            }
            else if (i_char_loc >= Text.Length)
            {
                pi_char_loc = new IntPtr(i_char_loc - 1);
                i_point = win32.SendMessage(Handle, win32.EM_POSFROMCHAR, pi_char_loc, IntPtr.Zero);
                pointCaret = new Point(i_point);

                Graphics g = CreateGraphics();
                String t1 = Text.Substring(Text.Length - 1, 1) + "X";
                SizeF sizet1 = g.MeasureString(t1, Font);
                SizeF sizex = g.MeasureString("X", Font);
                g.Dispose();
                int xoffset = (int)(sizet1.Width - sizex.Width);
                pointCaret.X = pointCaret.X + xoffset;

                if (i_char_loc == Text.Length)
                {
                    String slast = Text.Substring(Text.Length - 1, 1);
                    if (slast == "\n")
                    {
                        pointCaret.X = 1;
                        pointCaret.Y = pointCaret.Y + myFontHeight;
                    }
                }

            }



            return pointCaret;
        }


        private void myTimer1_Tick(object sender, EventArgs e)
        {
            //Timer used to turn caret on and off for focused control

            myCaretState = !myCaretState;
            myCaretUpToDate = false;
            Invalidate();
        }


        private class uPictureBox : PictureBox
        {
            public uPictureBox()
            {
                SetStyle(ControlStyles.Selectable, false);
                SetStyle(ControlStyles.UserPaint, true);
                SetStyle(ControlStyles.AllPaintingInWmPaint, true);
                SetStyle(ControlStyles.DoubleBuffer, true);

                Cursor = null;
                Enabled = true;
                SizeMode = PictureBoxSizeMode.Normal;

            }




            //uPictureBox
            protected override void WndProc(ref Message m)
            {
                if (m.Msg == win32.WM_LBUTTONDOWN
                    || m.Msg == win32.WM_RBUTTONDOWN
                    || m.Msg == win32.WM_LBUTTONDBLCLK
                    || m.Msg == win32.WM_MOUSELEAVE
                    || m.Msg == win32.WM_MOUSEMOVE)
                {
                    //Send the above messages back to the parent control
                    win32.PostMessage(Parent.Handle, (uint)m.Msg, m.WParam, m.LParam);
                }

                else if (m.Msg == win32.WM_LBUTTONUP)
                {
                    //??  for selects and such
                    Parent.Invalidate();
                }


                base.WndProc(ref m);
            }


        }   // End uPictureBox Class


        #endregion  // end private functions and classes


        #region Component Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
        }
        #endregion


        #region New Public Properties

        [
        Category("Appearance"),
        Description("The alpha value used to blend the control's background. Valid values are 0 through 255."),
        Browsable(true),
        DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)

        ]
        public int BackAlpha
        {
            get { return myBackAlpha; }
            set
            {
                int v = value;
                if (v > 255)
                    v = 255;
                myBackAlpha = v;
                myUpToDate = false;
                Invalidate();
            }
        }

        #endregion
    }
}
