using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programka
{
    public partial class Form1 : Form
    {
        BackgroundWorker bw;
        BackgroundWorker bw1;
        Random rand = new Random();
        int arg, rand1, rand2;
        bool provrand = false;
        int param;
        Point mousedownpoint = Point.Empty;
        [DllImport("User32.dll")]
        static extern void mouse_event(MouseFlags dwFlags, int dx, int dy, int dwData, UIntPtr dwExtraInfo);//3 inta
        [Flags]
        enum MouseFlags
        {
            Move = 0x0001, LeftDown = 0x0002, LeftUp = 0x0004,
            RightDown = 0x0008,
            RightUp = 0x0010, Absolute = 0x8000
        };

        public Form1()
        {
            InitializeComponent();
            bw = new BackgroundWorker();
            bw.DoWork += (obj, ea) => Sobitie();
            bw1 = new BackgroundWorker();
            bw1.DoWork += (obj, ea) => SobitieRig();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            param = Convert.ToInt32(KolichCB.Text);
            if (MinTimeCB.SelectedIndex == 0)
            {
                provrand = true;
                rand1 = Convert.ToInt32(Rabd1CB.Text);
                rand2 = Convert.ToInt32(Rabd2CB.Text);
            }
            else
            {
                arg = Convert.ToInt32(MinTimeCB.Text);
            }
            bw.RunWorkerAsync();
            bw.WorkerSupportsCancellation = true;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mousedownpoint = new Point(e.X, e.Y);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousedownpoint.IsEmpty)
                return;
            Form f = sender as Form;
            f.Location = new Point(f.Location.X + (e.X - mousedownpoint.X), f.Location.Y + (e.Y - mousedownpoint.Y));
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mousedownpoint = Point.Empty;
        }

        private async void Sobitie()
        {
            await Task.Delay(5000);
            for (int i = 0; i < param; i++)
            {
                try
                {
                    if (provrand == true)
                    {
                        arg = rand.Next(rand1, rand2);
                        //mouse_event(MouseFlags.Absolute | MouseFlags.Move, arg1, arg2, 0, UIntPtr.Zero);
                        mouse_event(MouseFlags.Absolute | MouseFlags.LeftDown, 32000, 32000, 0, UIntPtr.Zero);
                        mouse_event(MouseFlags.Absolute | MouseFlags.LeftUp, 32000, 32000, 0, UIntPtr.Zero);
                    }
                    else if (provrand == false)
                    {
                        mouse_event(MouseFlags.Absolute | MouseFlags.LeftDown, 32000, 32000, 0, UIntPtr.Zero);
                        mouse_event(MouseFlags.Absolute | MouseFlags.LeftUp, 32000, 32000, 0, UIntPtr.Zero);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                await Task.Delay(arg);
            }
        }

        private void StartButton2_Click(object sender, EventArgs e)
        {
            param = Convert.ToInt32(KolichCB.Text);
            if (MinTimeCB.SelectedIndex == 0)
            {
                provrand = true;
                rand1 = Convert.ToInt32(Rabd1CB.Text);
                rand2 = Convert.ToInt32(Rabd2CB.Text);
            }
            else
            {
                arg = Convert.ToInt32(MinTimeCB.Text);
            }
            bw1.RunWorkerAsync();
            bw1.WorkerSupportsCancellation = true;
        }

        private async void SobitieRig()
        {
            await Task.Delay(5000);
            for (int i = 0; i < param; i++)
            {
                try
                {
                    if (provrand == true)
                    {
                        arg = rand.Next(rand1, rand2);
                        //mouse_event(MouseFlags.Absolute | MouseFlags.Move, arg1, arg2, 0, UIntPtr.Zero);
                        mouse_event(MouseFlags.Absolute | MouseFlags.RightDown, 32000, 32000, 0, UIntPtr.Zero);
                        mouse_event(MouseFlags.Absolute | MouseFlags.RightUp, 32000, 32000, 0, UIntPtr.Zero);
                    }
                    else if (provrand == false)
                    {
                        mouse_event(MouseFlags.Absolute | MouseFlags.RightDown, 32000, 32000, 0, UIntPtr.Zero);
                        mouse_event(MouseFlags.Absolute | MouseFlags.RightUp, 32000, 32000, 0, UIntPtr.Zero);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                await Task.Delay(arg);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
