using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;

namespace Harris7800HMP
{
    public partial class Form1 : Form
    {
        public static Switcher switcher = new Switcher();
        public static Action timerAction;
        private RadioStation radioStation;
        private Widget currentWidget;
        private PrivateFontCollection displayFonts = new PrivateFontCollection();
        private WidgetQueue queueWidget = new WidgetQueue();

        public static Timer transitionTimer = new Timer();
        public static String keyNeed = "1379";
        public static String keyEntered = "";
        public static Form1 currObject;
        private FileInfo fileLesson;
        public RichTextBox lessonsInfo = new RichTextBox();
        private RadioModules externalModules = new RadioModules();
        private Color displayColor = Color.FromArgb(138, 164, 0);
        private Color displayTextColor = Color.FromArgb(138, 164, 0);

        public WidgetQueue QueueWidget
        {
            get => queueWidget;
        }

        public void SetBrigth(int value)
        {
            displayColor = Color.FromArgb(value * 20, value * 25, displayColor.B);
            displayTextColor = Color.FromArgb(value * 20, value * 25, displayColor.B);
            richDispley.BackColor = displayColor;
            richDispley.SelectionColor = displayTextColor;
        }

        public void SetContrast(int value)
        {
            richDispley.BackColor = Color.FromArgb(displayColor.R * value / 100, displayColor.G * value / 100, displayColor.B); ;
        }

        public void StartShowWidgetQueue(int interval = 1000)
        {
            timerAnimation.Interval = interval;
            timer1.Stop();
            timerAnimation.Start();
        }

        public static void StartTimer()
        {
            transitionTimer.Interval = 2000;
            transitionTimer.Tick += trans_timer_Tick;
            transitionTimer.Start();
        }

        public Form1(FileInfo fLesson)
        {
            InitializeComponent();
            Form1.currObject = this;
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            switcher.InitToOff();
            displayFonts.AddFontFile(@"fonts\pixelmix.ttf");

            radioStation = new RadioStation(switcher);
            currentWidget = WidgetInit.InitDefaultWidgets(radioStation);

            WidgetTextToRichText(currentWidget);
            timer1.Interval = 500;
            timerAnimation.Interval = 1000;
            fileLesson = fLesson;
            richDispley.BackColor = displayColor;
        }

        private void WidgetTextToRichText(Widget currWidget)
        {
            if (radioStation.IsOff())
            {
                richDispley.Clear();
                timer1.Stop();
                return;
            }

            if (currWidget.MoveTo != null)
            {
                currentWidget = currWidget.MoveTo;
                if (currentWidget.MoveTo != null)
                {
                    currentWidget.MoveTo = null;
                }
            }

            currentWidget.Update();
            var lines = currentWidget.ToLines();
            richDispley.Lines = lines;

            if (lines.Length > 0)
            {
                richDispley.Select(0, lines[0].Length);
                richDispley.SelectionFont = new Font(displayFonts.Families[0], currentWidget.LineSize[0], FontStyle.Regular);
                richDispley.SelectionCharOffset = currentWidget.LineCharOffset[0];

            }
            if (lines.Length > 1)
            {
                richDispley.Select(lines[0].Length + 1, lines[1].Length);
                richDispley.SelectionFont = new Font(displayFonts.Families[0], currentWidget.LineSize[1], FontStyle.Regular);
                richDispley.SelectionCharOffset = currentWidget.LineCharOffset[1];
            }
            if (lines.Length > 2)
            {
                richDispley.Select(lines[0].Length + lines[1].Length + 2, lines[2].Length);
                richDispley.SelectionFont = new Font(displayFonts.Families[0], currentWidget.LineSize[2], FontStyle.Regular);
                richDispley.SelectionCharOffset = currentWidget.LineCharOffset[2];
            }
            if (lines.Length > 3)
            {
                richDispley.Select(lines[0].Length + lines[1].Length + lines[2].Length + 3, lines[3].Length);
                richDispley.SelectionFont = new Font(displayFonts.Families[0], currentWidget.LineSize[3], FontStyle.Regular);
            }
            if (currentWidget.ActiveParam() != null)
            {
                var activeParams = currentWidget.GetActiveParamsBy();
                foreach (var param in activeParams)
                {
                    var activeParam = param;
                    var pText = activeParam.Text;
                    var index = richDispley.Lines[activeParam.X - 1].IndexOf(pText);
                    for (var i = 0; i < richDispley.Lines.Length && i < activeParam.X - 1; i++)
                    {
                        index += richDispley.Lines[i].Length + 1;
                    }
                    index += activeParam.ActiveFrom;
                    richDispley.Select(index, activeParam.ActiveTo);
                    richDispley.SelectionBackColor = Color.Black;
                    richDispley.SelectionColor = displayTextColor;
                }
            }

            richDispley.SelectionStart = 0;
            richDispley.SelectionLength = 1;
            Clipboard.SetImage(Properties.Resources.test_image);
            if (richDispley.CanPaste(DataFormats.GetFormat(DataFormats.Bitmap)))
            {
                richDispley.Paste(DataFormats.GetFormat(DataFormats.Bitmap));
            }
            
        }

        private void btVolPlus_Click(object sender, EventArgs e)
        {
            currentWidget.BtnClick("VOLUME_PLUS", radioStation);
            WidgetTextToRichText(currentWidget);
        }

        private void btVolMinus_Click(object sender, EventArgs e)
        {
            currentWidget.BtnClick("VOLUME_MINUS", radioStation);
            WidgetTextToRichText(currentWidget);
        }

        private void btClr_Click(object sender, EventArgs e)
        {
            currentWidget.BtnClick("CLR", radioStation);
            WidgetTextToRichText(currentWidget);
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            currentWidget.BtnClick("UPDATE", radioStation);
            WidgetTextToRichText(currentWidget);
        }

        private void btOpt_Click(object sender, EventArgs e)
        {
            currentWidget.BtnClick("OPT", radioStation);
            WidgetTextToRichText(currentWidget);
        }

        private void btSql_Click(object sender, EventArgs e)
        {
            currentWidget.BtnClick("SQL", radioStation);
            WidgetTextToRichText(currentWidget);
        }

        private void btCall_Click(object sender, EventArgs e)
        {
            currentWidget.BtnClick("CALL", radioStation);
            WidgetTextToRichText(currentWidget);
        }

        private void btLt_Click(object sender, EventArgs e)
        {

            currentWidget.BtnClick("LT", radioStation);
            WidgetTextToRichText(currentWidget);
        }

        private void btZero_Click(object sender, EventArgs e)
        {

            currentWidget.BtnClick("ZERO", radioStation);
            WidgetTextToRichText(currentWidget);
        }

        private void btPgm_Click(object sender, EventArgs e)
        {
            currentWidget.BtnClick("PGM", radioStation);
            WidgetTextToRichText(currentWidget);
        }

        private void btLeft_Click(object sender, EventArgs e)
        {
            currentWidget.BtnClick("LEFT", radioStation);
            WidgetTextToRichText(currentWidget);
        }

        private void btRigth_Click(object sender, EventArgs e)
        {
            currentWidget.BtnClick("RIGTH", radioStation);
            WidgetTextToRichText(currentWidget);
        }

        private void btDown_Click(object sender, EventArgs e)
        {
            currentWidget.BtnClick("DOWN", radioStation);
            WidgetTextToRichText(currentWidget);
        }

        private void btUp_Click(object sender, EventArgs e)
        {
            currentWidget.BtnClick("UP", radioStation);
            WidgetTextToRichText(currentWidget);
        }

        private void btMode_Click(object sender, EventArgs e)
        {
            //    keyboard.btnClick("MODE", radioStation, display);
            //    //MessageBox.Show(System.Reflection.MethodBase.GetCurrentMethod().Name);
            //    radioStation.nextMode();
            //    this.lbDisplay.Text = display.ToString();
            currentWidget.BtnClick("MODE", radioStation);
            WidgetTextToRichText(currentWidget);
        }

        private void btPrePlus_Click(object sender, EventArgs e)
        {
            currentWidget.BtnClick("PRE_PLUS", radioStation);
            WidgetTextToRichText(currentWidget);
        }

        private void btPreMinus_Click(object sender, EventArgs e)
        {
            currentWidget.BtnClick("PRE_MINUS", radioStation);
            WidgetTextToRichText(currentWidget);
        }

        private void btEnter_Click(object sender, EventArgs e)
        {
            currentWidget.BtnClick("ENT", radioStation);
            WidgetTextToRichText(currentWidget);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (radioStation.IsOff())
            {
                timerOn.Interval = 1500;
                timerOn.Start();
            }
            radioStation.NextState();
            var pBox = (PictureBox)sender;
            pBox.Image = switcher.GetImage();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            WidgetTextToRichText(currentWidget);
        }

        private static void trans_timer_Tick(object sender, EventArgs e)
        {
            ((Timer)sender).Stop();
            timerAction?.Invoke();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pbOn.Visible = true;
            if (radioStation.OnSteps == RadioStation.SwitchOnSteps.AfterInit)
            {
                radioStation.OnSteps = RadioStation.SwitchOnSteps.Logo;
                pbOn.Visible = false;
                ((Timer)sender).Stop();
                timer1.Start();
                return;
            }
            switch (radioStation.OnSteps)
            {
                case RadioStation.SwitchOnSteps.Logo:
                    {
                        pbOn.Image = Properties.Resources.powerOnLogo;
                        radioStation.OnSteps++;
                        break;
                    }
                case RadioStation.SwitchOnSteps.Model:
                    {
                        pbOn.Image = Properties.Resources.powerOnModel;
                        radioStation.OnSteps++;
                        break;
                    }
                case RadioStation.SwitchOnSteps.Init:
                    {
                        pbOn.Image = Properties.Resources.powerOnInit;
                        radioStation.OnSteps++;
                        break;
                    }
            }


        }

        private void timerAnimation_Tick(object sender, EventArgs e)
        {
            var next = queueWidget.Next();
            if (next == null)
            {
                timer1.Start();
                ((Timer)sender).Stop();
                queueWidget.Clear();
                return;
            }

            currentWidget = next;
            WidgetTextToRichText(next);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Owner.Visible = false;
            var lInfo = new LessonsInfo(fileLesson);
            lInfo.Show(this);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Visible = true;

            switcher.InitToOff();

            WidgetInit.widgetContainer.Clear();
            radioStation = null;
            currentWidget = null;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (radioStation.connectedCoupler)
            {
                var usb = externalModules.modulesImage[RadioModules.ModuleType.Coupler];
                e.Graphics.DrawImage(usb.Item1, usb.Item2.x, usb.Item2.y);
            }

            if (radioStation.connectedUsb)
            {
                var usb = externalModules.modulesImage[RadioModules.ModuleType.Usb];
                e.Graphics.DrawImage(usb.Item1, usb.Item2.x, usb.Item2.y);
            }

            if (radioStation.connectedHandset)
            {
                var usb = externalModules.modulesImage[RadioModules.ModuleType.Handset];
                e.Graphics.DrawImage(usb.Item1, usb.Item2.x, usb.Item2.y);
            }
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            var ee = (MouseEventArgs)e;
            var usbArea     = new Square(new Point(730, 250), 050);
            var handSetArea = new Square(new Point(650, 350), 100);
            var couplerArea = new Square(new Point(140, 180), 100);

            if (usbArea.IsPointInto(ee.Location))
            {
                if (radioStation.connectedUsb)
                {
                    radioStation.connectedUsb = false;
                    BackgroundImage = Properties.Resources.background_keys;
                }
                else
                {
                    radioStation.connectedUsb = true;
                    var usb = externalModules.modulesImage[RadioModules.ModuleType.Usb];
                    CreateGraphics().DrawImage(usb.Item1, usb.Item2.x, usb.Item2.y);
                }
                Update();
            }
            if (handSetArea.IsPointInto(ee.Location))
            {
                if (radioStation.connectedHandset)
                {
                    radioStation.connectedHandset = false;
                    BackgroundImage = Properties.Resources.background_keys;
                }
                else
                {
                    radioStation.connectedHandset = true;
                    var handset = externalModules.modulesImage[RadioModules.ModuleType.Handset];
                    CreateGraphics().DrawImage(handset.Item1, handset.Item2.x, handset.Item2.y);
                }
                Update();
            }
            if (couplerArea.IsPointInto(ee.Location))
            {
                if (radioStation.connectedCoupler)
                {
                    radioStation.connectedCoupler = false;
                    BackgroundImage = Properties.Resources.background_keys;
                }
                else
                {
                    radioStation.connectedCoupler = true;
                    var coupler = externalModules.modulesImage[RadioModules.ModuleType.Coupler];
                    CreateGraphics().DrawImage(coupler.Item1, coupler.Item2.x, coupler.Item2.y);
                }
                Update();
            }
            Debug.WriteLine(ee.Location);
        }

        private void btCall_MouseEnter(object sender, EventArgs e)
        {
            var btn = (System.Windows.Forms.Button)sender;
            btn.BackColor = Color.FromArgb(50, Color.White);
            btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, Color.White);
        }

        private void btCall_MouseLeave(object sender, EventArgs e)
        {
            var btn = (System.Windows.Forms.Button)sender;
            btn.BackColor = Color.FromArgb(0, Color.White);
        }

        private void pbOn_Click(object sender, EventArgs e)
        {

        }
    }
}
