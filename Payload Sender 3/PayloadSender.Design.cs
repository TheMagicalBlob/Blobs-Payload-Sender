using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayloadSender
{
    internal partial class Payload_Sender : Form
    {
        //==========================================================\\
        //--|   Global Look/Feel-Related Variable Declarations   |--\\
        //==========================================================\\
        #region [Global Look/Feel-Related Variable Declarations]


        public static Color AppColour = Color.FromArgb(20, 20, 20);
        public static Color AppColourLight = Color.FromArgb(42, 42, 42);
        public static Color AppColourSpecial = Color.FromArgb(125, 183, 245);
        public static Color AppAccentColour = Color.FromArgb(210, 240, 250); // Why did I choose this colour specifically? I forget.

        public static Pen FormDecorationPen = new Pen(AppAccentColour); // Colouring for Border Drawing

        public static Font MainFont = new Font("Gadugi", 8.25f, FontStyle.Bold); // For the vast majority of controls; anything the user doesn't edit, really.
        public static Font TextFont = new Font("Segoe UI Semibold", 7.5f); // For option controls with customized contents


        /// <summary> An array of Point() arrays with the start and end points of a line to draw. </summary>
        private Point[][] HSeparatorLines;

        /// <summary> An array of Point() arrays with the start and end points of a line to draw. </summary>
        private Point[][] VSeparatorLines;
        #endregion



        //===============================================\\
        //--|   UI Decoration Function Declarations   |--\\
        //===============================================\\
        #region [UI Decoration Function Declarations]

        /// <summary>
        /// Draw a thin border over the for edges on repaint.
        /// <br/>Draw a thin line from one end of the painted control to the other.
        ///</summary>
        public static void DrawFormDecorations(Form venat, PaintEventArgs yoshiP)
        {
            if (Venat == null || yoshiP == null)
            {
                return;
            }

            // Clear line bounds with the current form's background colour
            yoshiP.Graphics?.Clear(venat.BackColor);

            //##-> Draw Vertical Lines
            foreach (var line in (venat as dynamic).VSeparatorLines ?? Array.Empty<Point[]>())
            {
                yoshiP?.Graphics?.DrawLine(FormDecorationPen, line[0], line[1]);
            }

            //##-> Draw Horizontal Lines
            foreach (var line in (venat as dynamic).HSeparatorLines ?? Array.Empty<Point[]>())
            {
                yoshiP?.Graphics?.DrawLine(FormDecorationPen, line[0], line[1]);
            }

            // Draw a thin (1 pixel) border around the form with the current Pen
            yoshiP?.Graphics?.DrawLines(FormDecorationPen, new[]
            {
                Point.Empty,
                new Point(venat.Width-1, 0),
                new Point(venat.Width-1, venat.Height-1),
                new Point(0, venat.Height-1),
                Point.Empty
            });
        }






        /// <summary>
        /// //!
        /// </summary>
        /// <param name="Venat"></param>
        /// <param name="controls"></param>
        private void InitializeFormDecorations(Form Venat, Control[] controls = null)
        {
            if (controls == null)
            {
                controls = Venat.Controls.Cast<Control>().ToArray();
            }

            var hSeparatorLineScanner = new List<Point[]>();
            var vSeparatorLineScanner = new List<Point[]>();

            // Apply the separator drawing function to any separator lines
            foreach (var line in controls.OfType<Label>())
            {
                if (line.IsSeparatorLine)
                {
                    // Horizontal Lines
                    hSeparatorLineScanner.Add(new Point[2]
                    {
                        new Point(line.StretchToFitForm ? 1 : line.Location.X, line.Location.Y + 7),
                        new Point(line.StretchToFitForm ? line.Parent.Width - 2 : line.Location.X + line.Width, line.Location.Y + 7)
                    });

                    Venat.Controls.Remove(line);
                }
            }

            if (hSeparatorLineScanner.Count > 0)
            {
                HSeparatorLines = hSeparatorLineScanner.ToArray();
            }


            Paint += (venat, yoshiP) => DrawFormDecorations((Form)venat, yoshiP);
        }

        #endregion
    }
}
