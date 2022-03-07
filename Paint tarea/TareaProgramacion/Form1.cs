namespace TareaProgramacion
{
    public partial class Paint_Programacion : Form
    {
        Graphics g;
        int x = -1, y = -1;
        bool movimiento = false;
        Pen pen;
        
        public Paint_Programacion()
        {
            InitializeComponent();
            g = panel1.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pen = new Pen(Color.Black, 5);
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pen.Color = pb.BackColor;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            movimiento = true;
            x = e.X;
            y = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (movimiento && x!=-1 && y != -1)
            {
                g.DrawLine(pen, new Point(x, y), e.Location);
                x = e.X;
                y = e.Y;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            movimiento = false;   
            x = -1;
            y = -1;
        }
    }
}