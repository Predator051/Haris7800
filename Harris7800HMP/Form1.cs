using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.IO;
using System.Diagnostics;

namespace Harris7800HMP
{
    public partial class Form1 : Form
    {
        public static Switcher switcher = new Switcher();
        public static Action timerAction;
        private RadioStation radioStation;
        private Display display;
        private Widget currentWidget;
        private PrivateFontCollection displayFonts = new PrivateFontCollection();
        private WidgetQueue queueWidget = new WidgetQueue();
        
        public static Timer transitionTimer = new Timer();
        public static String keyNeed = "1379";
        public static String keyEntered = "";
        public static Form1 currObject;
        FileInfo fileLesson;
        public RichTextBox lessonsInfo = new RichTextBox();

        RadioModules externalModules = new RadioModules();

        Color displayColor = Color.FromArgb(138, 164, 0);
        Color displayTextColor = Color.FromArgb(138, 164, 0);

        public WidgetQueue QueueWidget
        {
            get => this.queueWidget;
        }

        public void setBrigth(int value)
        {
            displayColor = Color.FromArgb(value * 20, value * 25, displayColor.B);
            displayTextColor = Color.FromArgb(value * 20, value * 25, displayColor.B);
            this.richDispley.BackColor = displayColor;
            this.richDispley.SelectionColor = displayTextColor;
        }

        public void setContrast(int value)
        {
            this.richDispley.BackColor = Color.FromArgb(displayColor.R * value / 100, displayColor.G * value / 100, displayColor.B); ;
        }

        public void startShowWidgetQueue(int interval = 1000)
        {
            this.timerAnimation.Interval = interval;
            this.timer1.Stop();
            this.timerAnimation.Start();
        }
        
        static public void startTimer()
        {
            transitionTimer.Interval = 2000;
            transitionTimer.Tick += trans_timer_Tick;
            transitionTimer.Start();
        }

        public Form1(FileInfo fLesson)
        {
            InitializeComponent();
            Form1.currObject = this;
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            switcher.initToOff();
            displayFonts.AddFontFile(@"fonts\pixelmix.ttf");

            radioStation = new RadioStation(switcher);
            currentWidget = WidgetInit.initDefaultWidgets(radioStation);

            widgetTextToRichText(currentWidget);
            this.timer1.Interval = 500;
            this.timerAnimation.Interval = 1000;
            fileLesson = fLesson;
            this.richDispley.BackColor = displayColor;
        }

        private void widgetTextToRichText(Widget currWidget)
        {
            if (radioStation.isOff())
            {
                this.richDispley.Clear();
                this.timer1.Stop();
                return;
            }

            if (currWidget.MoveTo != null)
            {
                currentWidget = currWidget.MoveTo;
                if(currentWidget.MoveTo != null)
                {
                    currentWidget.MoveTo = null;
                }
            }

            currentWidget.update();
            var lines = currentWidget.toLines();
            this.richDispley.Lines = lines;

            if (lines.Length > 0)
            {
                this.richDispley.Select(0, lines[0].Length);
                this.richDispley.SelectionFont = new Font(displayFonts.Families[0], (float)currentWidget.LineSize[0], FontStyle.Regular);
                this.richDispley.SelectionCharOffset = currentWidget.LineCharOffset[0];
                
            }
            if (lines.Length > 1)
            {
                this.richDispley.Select(lines[0].Length + 1, lines[1].Length);
                this.richDispley.SelectionFont = new Font(displayFonts.Families[0], (float)currentWidget.LineSize[1], FontStyle.Regular);
                this.richDispley.SelectionCharOffset = currentWidget.LineCharOffset[1];
            }
            if (lines.Length > 2)
            {
                this.richDispley.Select(lines[0].Length + lines[1].Length + 2, lines[2].Length);
                this.richDispley.SelectionFont = new Font(displayFonts.Families[0], (float)currentWidget.LineSize[2], FontStyle.Regular);
                this.richDispley.SelectionCharOffset = currentWidget.LineCharOffset[2];
            }
            if (lines.Length > 3)
            {
                this.richDispley.Select(lines[0].Length + lines[1].Length + lines[2].Length + 3, lines[3].Length);
                this.richDispley.SelectionFont = new Font(displayFonts.Families[0], (float)currentWidget.LineSize[3], FontStyle.Regular);
            }
            if (currentWidget.activeParam() != null)
            {
                var activeParams = currentWidget.getActiveParamsBy();
                foreach(Param param in activeParams)
                {
                    var activeParam = param;
                    string pText = activeParam.Text;
                    int index = this.richDispley.Lines[activeParam.X-1].IndexOf(pText);
                    for(int i = 0; i < this.richDispley.Lines.Length && i < activeParam.X - 1; i++)
                    {
                        index += this.richDispley.Lines[i].Length+1;
                    }
                    index += activeParam.ActiveFrom;
                    this.richDispley.Select(index, activeParam.ActiveTo);
                    this.richDispley.SelectionBackColor = Color.Black;
                    this.richDispley.SelectionColor = displayTextColor;
                }
            }
        }

        private void btVolPlus_Click(object sender, EventArgs e)
        {
            currentWidget.btnClick("VOLUME_PLUS", radioStation);
            widgetTextToRichText(currentWidget);
        }

        private void btVolMinus_Click(object sender, EventArgs e)
        {
            currentWidget.btnClick("VOLUME_MINUS", radioStation);
            widgetTextToRichText(currentWidget);
        }

        private void btClr_Click(object sender, EventArgs e)
        {
            currentWidget.btnClick("CLR", radioStation);
            widgetTextToRichText(currentWidget);
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            currentWidget.btnClick("UPDATE", radioStation);
            widgetTextToRichText(currentWidget);
        }

        private void btOpt_Click(object sender, EventArgs e)
        {
            currentWidget.btnClick("OPT", radioStation);
            widgetTextToRichText(currentWidget);
        }

        private void btSql_Click(object sender, EventArgs e)
        {
            currentWidget.btnClick("SQL", radioStation);
            widgetTextToRichText(currentWidget);
        }

        private void btCall_Click(object sender, EventArgs e)
        {
            currentWidget.btnClick("CALL", radioStation);
            widgetTextToRichText(currentWidget);
        }

        private void btLt_Click(object sender, EventArgs e)
        {

            currentWidget.btnClick("LT", radioStation);
            widgetTextToRichText(currentWidget);
        }

        private void btZero_Click(object sender, EventArgs e)
        {

            currentWidget.btnClick("ZERO", radioStation);
            widgetTextToRichText(currentWidget);
        }

        private void btPgm_Click(object sender, EventArgs e)
        {
            currentWidget.btnClick("PGM", radioStation);
            widgetTextToRichText(currentWidget);
        }

        private void btLeft_Click(object sender, EventArgs e)
        {
            currentWidget.btnClick("LEFT", radioStation);
            widgetTextToRichText(currentWidget);
        }

        private void btRigth_Click(object sender, EventArgs e)
        {
            currentWidget.btnClick("RIGTH", radioStation);
            widgetTextToRichText(currentWidget);
        }

        private void btDown_Click(object sender, EventArgs e)
        {
            currentWidget.btnClick("DOWN", radioStation);
            widgetTextToRichText(currentWidget);
        }

        private void btUp_Click(object sender, EventArgs e)
        {
            currentWidget.btnClick("UP", radioStation);
            widgetTextToRichText(currentWidget);
        }

        private void btMode_Click(object sender, EventArgs e)
        {
        //    keyboard.btnClick("MODE", radioStation, display);
        //    //MessageBox.Show(System.Reflection.MethodBase.GetCurrentMethod().Name);
        //    radioStation.nextMode();
        //    this.lbDisplay.Text = display.ToString();
            currentWidget.btnClick("MODE", radioStation);
            widgetTextToRichText(currentWidget);
        }

        private void btPrePlus_Click(object sender, EventArgs e)
        {
            currentWidget.btnClick("PRE_PLUS", radioStation);
            widgetTextToRichText(currentWidget);
        }

        private void btPreMinus_Click(object sender, EventArgs e)
        {
            currentWidget.btnClick("PRE_MINUS", radioStation);
            widgetTextToRichText(currentWidget);
        }

        private void btEnter_Click(object sender, EventArgs e)
        {
            currentWidget.btnClick("ENT", radioStation);
            widgetTextToRichText(currentWidget);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (radioStation.isOff())
            {
                timerOn.Interval = 1500;
                timerOn.Start();
            }
            radioStation.nextState();
            PictureBox pBox = (PictureBox)sender;
            pBox.Image = switcher.getImage();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            widgetTextToRichText(currentWidget);
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
            if(radioStation.OnSteps == RadioStation.SwitchOnSteps.AfterInit)
            {
                radioStation.OnSteps = RadioStation.SwitchOnSteps.Logo;
                pbOn.Visible = false;
                ((Timer)sender).Stop();
                this.timer1.Start();
                return;
            }
            switch(radioStation.OnSteps)
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
            Widget next = queueWidget.next();
            if (next == null)
            {
                this.timer1.Start();
                ((Timer)sender).Stop();
                queueWidget.clear();
                return;
            }

            currentWidget = next;
            this.widgetTextToRichText(next);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Owner.Visible = false;
            LessonsInfo lInfo = new LessonsInfo(fileLesson);
            lInfo.Show(this);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Visible = true;

            switcher.initToOff();

            WidgetInit.widgetContainer.Clear();
            radioStation = null;
            currentWidget = null;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (this.radioStation.connectedCoupler)
            {
                var usb = externalModules.modulesImage[RadioModules.ModuleType.Coupler];
                e.Graphics.DrawImage(usb.Item1, usb.Item2.x, usb.Item2.y);
            }

            if (this.radioStation.connectedUsb)
            {
                var usb = externalModules.modulesImage[RadioModules.ModuleType.Usb];
                e.Graphics.DrawImage((Bitmap)usb.Item1, usb.Item2.x, usb.Item2.y);
            } 

            if (this.radioStation.connectedHandset)
            {
                var usb = externalModules.modulesImage[RadioModules.ModuleType.Handset];
                e.Graphics.DrawImage(usb.Item1, usb.Item2.x, usb.Item2.y);
            }
        }

        private void btnCoupler_Click(object sender, EventArgs e)
        {
            if (this.radioStation.connectedCoupler)
            {
                this.radioStation.connectedCoupler = false;
                this.BackgroundImage = Properties.Resources.background_keys;
            } else
            {
                this.radioStation.connectedCoupler = true;
                var coupler = externalModules.modulesImage[RadioModules.ModuleType.Coupler];
                this.CreateGraphics().DrawImage((Bitmap)coupler.Item1, coupler.Item2.x, coupler.Item2.y);
            }
            this.Update();
        }

        private void btnHandset_Click(object sender, EventArgs e)
        {
            if (this.radioStation.connectedHandset)
            {
                this.radioStation.connectedHandset = false;
                this.BackgroundImage = Properties.Resources.background_keys;
            }
            else
            {
                this.radioStation.connectedHandset = true;
                var handset = externalModules.modulesImage[RadioModules.ModuleType.Handset];
                this.CreateGraphics().DrawImage((Bitmap)handset.Item1, handset.Item2.x, handset.Item2.y);
            }
            this.Update();
        }

        private void btnUsb_Click(object sender, EventArgs e)
        {
            if (this.radioStation.connectedUsb)
            {
                this.radioStation.connectedUsb = false;
                this.BackgroundImage = Properties.Resources.background_keys;
            }
            else
            {
                this.radioStation.connectedUsb = true;
                var usb = externalModules.modulesImage[RadioModules.ModuleType.Usb];
                this.CreateGraphics().DrawImage((Bitmap)usb.Item1, usb.Item2.x, usb.Item2.y);
            }
            this.Update();
        }

        private void btnUsb_MouseUp(object sender, MouseEventArgs e)
        {
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            MouseEventArgs ee = (MouseEventArgs)e;
            Square usbArea = new Square(new Point(760, 288), 50);
            Square handSetArea = new Square(new Point(678, 379), 100);
            Square couplerArea = new Square(new Point(165, 210), 100);

            if (usbArea.isPointInto(ee.Location))
            {
                if (this.radioStation.connectedUsb)
                {
                    this.radioStation.connectedUsb = false;
                    this.BackgroundImage = Properties.Resources.background_keys;
                }
                else
                {
                    this.radioStation.connectedUsb = true;
                    var usb = externalModules.modulesImage[RadioModules.ModuleType.Usb];
                    this.CreateGraphics().DrawImage((Bitmap)usb.Item1, usb.Item2.x, usb.Item2.y);
                }
                this.Update();
            }
            if (handSetArea.isPointInto(ee.Location))
            {
                if (this.radioStation.connectedHandset)
                {
                    this.radioStation.connectedHandset = false;
                    this.BackgroundImage = Properties.Resources.background_keys;
                }
                else
                {
                    this.radioStation.connectedHandset = true;
                    var handset = externalModules.modulesImage[RadioModules.ModuleType.Handset];
                    this.CreateGraphics().DrawImage((Bitmap)handset.Item1, handset.Item2.x, handset.Item2.y);
                }
                this.Update();
            }
            if (couplerArea.isPointInto(ee.Location))
            {
                if (this.radioStation.connectedCoupler)
                {
                    this.radioStation.connectedCoupler = false;
                    this.BackgroundImage = Properties.Resources.background_keys;
                }
                else
                {
                    this.radioStation.connectedCoupler = true;
                    var coupler = externalModules.modulesImage[RadioModules.ModuleType.Coupler];
                    this.CreateGraphics().DrawImage((Bitmap)coupler.Item1, coupler.Item2.x, coupler.Item2.y);
                }
                this.Update();
            }
            Debug.WriteLine(ee.Location);
        }

        private void btCall_MouseEnter(object sender, EventArgs e)
        {
            System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;
            btn.BackColor = Color.FromArgb(50, Color.White);
            btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, Color.White);
        }

        private void btCall_MouseLeave(object sender, EventArgs e)
        {
            System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;
            btn.BackColor = Color.FromArgb(0, Color.White);
        }
    }
}
