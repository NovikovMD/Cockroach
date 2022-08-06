using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5
{
    enum direction : byte { Up, Right, Down, Left };
    public partial class Form1 : Form
    {
        private string filePath = "cockroach.jpg";
        private int AlgStep = 0;
        Cockroach workCockroach;//рабочий Таракан - активный Таракан, который будет выполнять алгоритм
        List<Cockroach> LotsOfCockroach;//текущие выбранные тараканы
        List<PictureBox> LotsOfworkpb;//текущие выбранные поля
        PictureBox workpb;//рабочие поля PictureBox - поля на которых будут рабочие Тараканы
        List<Cockroach> LC;//Список для хранения созданных Тараканов
        List<PictureBox> PB;//Список для хранения созданных объектов PictureBox

        public Form1()
        {
            LC = new List<Cockroach>();
            PB = new List<PictureBox>(); 
            LotsOfCockroach = new List<Cockroach>();
            LotsOfworkpb = new List<PictureBox>();

            InitializeComponent();
        }

        private void NewBtn_Click(object sender, EventArgs e)
        {
            LotsOfCockroach.Clear();
            LotsOfworkpb.Clear();
            ShowButtons();
            workCockroach = new Cockroach(new Bitmap(filePath));//
            PictureBox p = new PictureBox();
            Show(p, Field);
            p.MouseMove += new MouseEventHandler(IMouseMove);
            p.MouseDown += new MouseEventHandler(IMouseDown);
            PB.Add(p);
            LC.Add(workCockroach);
            workpb = p;
        }
        private void ShowButtons()
        {
            LeftBtn.Enabled = true;
            RightBtn.Enabled = true;
            UpBtn.Enabled = true;
            DownBtn.Enabled = true;
            StepBtn.Enabled = true;
            RunBtn.Enabled = true;
            DelBtn.Enabled = true;
        }
        private void HideButtons()
        {
            LeftBtn.Enabled = false;
            RightBtn.Enabled = false;
            UpBtn.Enabled = false;
            DownBtn.Enabled = false;
            StepBtn.Enabled = false;
            RunBtn.Enabled = false;
            DelBtn.Enabled = false;
        }

        private void IMouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PictureBox picture = sender as PictureBox;
                picture.Tag = new Point(e.X, e.Y);//запоминаем координаты мыши на момент начала перетаскивания
                picture.DoDragDrop(sender, DragDropEffects.Move);//начинаем перетаскивание ЧЕГО и с КАКИМ ЭФФЕКТОМ
            }
        }

        private void IMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ShowButtons();
                if (ModifierKeys.HasFlag(Keys.Control))
                {
                    LotsOfCockroach.Add(workCockroach);
                    LotsOfworkpb.Add(workpb);
                }
                else
                {
                    LotsOfCockroach.Clear();
                    LotsOfworkpb.Clear();
                }
                int k = PB.IndexOf(sender as PictureBox);//запоминаем номер нажатого компонента PictureBox
                workpb = sender as PictureBox;//объявляет его рабочим
                workCockroach = LC[k];//по найденному номеру находим Таракана в списке
            }
        }

        private void Field_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(PictureBox)))
            {
                e.Effect = DragDropEffects.Move;
            }

        }

        private void Field_DragDrop(object sender, DragEventArgs e)
        {
            //извлекаем PictureBox
            PictureBox picture = (PictureBox)e.Data.GetData(typeof(PictureBox));
            Panel panel = sender as Panel;
            //получаем клиентские координаты в момент отпускания кнопки
            Point pointDrop = panel.PointToClient(new Point(e.X-workCockroach.image.Width/2,
                e.Y - workCockroach.image.Height / 2));
            //извлекаем клиентские координаты мыши в момент начала перетскивания
            Point pointDrag = (Point)picture.Tag;
            //вычисляем и устанавливаем Location для PictureBox в Panel

            picture.Location = pointDrop;
            //устанавливаем координаты для X и Y для рабочего таракана
            workCockroach.X = picture.Location.X;
            workCockroach.Y = picture.Location.Y;
            picture.Parent = panel;

        }

        private void UpBtn_Click(object sender, EventArgs e)
        {
            Algorithm.Items.Add((sender as Button).Text);
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            AlgStep = 0;
            Algorithm.Items.Clear();
        }

        private void RunBtn_Click(object sender, EventArgs e)
        {
            timerAlgorithm.Start();
        }

        private void timerAlgorithm_Tick(object sender, EventArgs e)
        {
            if (AlgStep == Algorithm.Items.Count) //конец алгоритма
            {
                AlgStep = 0;
                timerAlgorithm.Stop();
            }
            else//выполнение команды из списка
            {
                string s = (string)Algorithm.Items[AlgStep];
                Algorithm.SetSelected(AlgStep, true);
                if (s == "Step")
                {
                    foreach(var w in LotsOfCockroach)
                    {
                        w.Step();
                    }
                    workCockroach.Step();
                }
                else
                {
                    foreach (var w in LotsOfCockroach)
                    {
                        w.ChangeTrend(s);
                    }
                    workCockroach.ChangeTrend(s);
                }
                for(int i = 0; i < LotsOfworkpb.Count; i++)
                {
                    RePaint(LotsOfworkpb[i],LotsOfCockroach[i]);
                }
                RePaint(workpb,workCockroach);
                AlgStep++;
            }

        }


        public void RePaint(PictureBox p, Cockroach cock)
        {
            p.Bounds = new Rectangle(cock.X, cock.Y,
                cock.image.Width, cock.image.Height);
            //создание новых границ изображения для PictureBox
            p.Image = cock.image;
        }
        public void Show(PictureBox p, Panel owner)
        {
            workCockroach.X = (owner.Width - workCockroach.image.Width) / 2;
            workCockroach.Y = (owner.Height - workCockroach.image.Height) / 2;
            RePaint(p, workCockroach);
            owner.Controls.Add(p);// добавляем PictureBox к элементу Panel
        }

        private void ChngButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;..."; 
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog1.FileName;
            }
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            int k = PB.IndexOf(workpb);//запоминаем номер нажатого компонента PictureBox

            LC.RemoveAt(k);
            PB.RemoveAt(k);
            workpb.Visible = false;
            workpb.Enabled = false;
            workpb.Dispose();
            workCockroach = null;
            workpb = null;
            HideButtons();
        }
    }
}
