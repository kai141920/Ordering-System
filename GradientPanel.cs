using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Ordering_System
{
    public class GradientPanel : Panel
    {
        // =========================================
        // TOP COLOR
        // =========================================

        private Color topColor =
        Color.FromArgb(0, 102, 204);

        [Category("Gradient Settings")]
        public Color TopColor
        {
            get { return topColor; }

            set
            {
                topColor = value;
                Invalidate();
            }
        }

        // =========================================
        // BOTTOM COLOR
        // =========================================

        private Color bottomColor =
        Color.FromArgb(0, 51, 102);

        [Category("Gradient Settings")]
        public Color BottomColor
        {
            get { return bottomColor; }

            set
            {
                bottomColor = value;
                Invalidate();
            }
        }

        // =========================================
        // PAINT
        // =========================================

        protected override void OnPaint(
            PaintEventArgs e)
        {
            base.OnPaint(e);

            using (LinearGradientBrush brush =
                new LinearGradientBrush(
                    this.ClientRectangle,
                    topColor,
                    bottomColor,
                    90F))
            {
                e.Graphics.FillRectangle(
                    brush,
                    this.ClientRectangle
                );
            }
        }
    }
}