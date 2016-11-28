using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#region
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
#endregion

namespace WindowsFormsApplication1
{
    /// <summary>
    ///   A custom windows control to display text vertically
    /// </summary>
    [ToolboxBitmap(typeof(VerticalLabel), "VerticalLabel.ico")]
    public class VerticalLabel : Control
    {
        private string _labelText;
        private readonly Container _components = new Container();
        /// <summary>
        ///   VerticalLabel constructor
        /// </summary>
        public VerticalLabel()
        {
            CreateControl();
            InitializeComponent();
            SetStyle(ControlStyles.Opaque, true);
        }
        /// <summary>
        ///   Dispose override method
        /// </summary>
        /// <param name = "disposing">boolean parameter</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_components != null)
                {
                    _components.Dispose();
                }
            }
            base.Dispose(disposing);
        }
        [DebuggerStepThrough]
        private void InitializeComponent()
        {
            Size = new Size(24, 100);
        }
        /// <summary>
        ///   OnPaint override. This is where the text is rendered vertically.
        /// </summary>
        /// <param name = "e">PaintEventArgs</param>
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.DrawString(_labelText, Font, new SolidBrush(ForeColor), 0, 0);
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x20; // Turn on WS_EX_TRANSPARENT
                return cp;
            }
        }
        /// <summary>
        ///   The text to be displayed in the control
        /// </summary>
        [Category("VerticalLabel"), Description("Text is displayed vertically in container.")]
        public override string Text
        {
            get { return _labelText; }
            set
            {
                _labelText = value;
                Invalidate();
            }
        }
    }
}