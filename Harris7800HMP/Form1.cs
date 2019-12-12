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

        public WidgetQueue QueueWidget
        {
            get => this.queueWidget;
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

        public Form1()
        {
            InitializeComponent();
            Form1.currObject = this;
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            switcher.initToOff();
            displayFonts.AddFontFile(@"fonts\pixelmix.ttf");

            radioStation = new RadioStation(switcher);
            display = new Display(radioStation);
            currentWidget = WidgetInit.initDefaultWidgets(radioStation);

            this.lbDisplay.Text = currentWidget.ToString();
            widgetTextToRichText(currentWidget);
            this.timer1.Interval = 500;
            this.timerAnimation.Interval = 1000;
            ////Form1.currObject.QueueWidget.add(getTestInProgressMenu());
            ////Form1.currObject.QueueWidget.add(getTestContrastMenu());
            ////Form1.currObject.QueueWidget.add(getTestLightMenu());
            ////Form1.currObject.QueueWidget.add(getTestInProgressMenu());
            //currentWidget = WidgetInit.getTestLightMenu();
            //widgetTextToRichText(currentWidget);
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
                    this.richDispley.SelectionColor = Color.White;
                }
            }
        }

        private void btVolPlus_Click(object sender, EventArgs e)
        {
            currentWidget.btnClick("VOLUME_PLUS", radioStation);
            this.lbDisplay.Text = currentWidget.ToString();
            widgetTextToRichText(currentWidget);
        }

        private void btVolMinus_Click(object sender, EventArgs e)
        {
            currentWidget.btnClick("VOLUME_MINUS", radioStation);
            this.lbDisplay.Text = currentWidget.ToString();
            widgetTextToRichText(currentWidget);
        }

        private void btClr_Click(object sender, EventArgs e)
        {
            currentWidget.btnClick("CLR", radioStation);
            this.lbDisplay.Text = currentWidget.ToString();
            widgetTextToRichText(currentWidget);
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            currentWidget.btnClick("UPDATE", radioStation);
            this.lbDisplay.Text = currentWidget.ToString();
            widgetTextToRichText(currentWidget);
        }

        private void btOpt_Click(object sender, EventArgs e)
        {
            currentWidget.btnClick("OPT", radioStation);
            this.lbDisplay.Text = currentWidget.ToString();
            widgetTextToRichText(currentWidget);
        }

        private void btSql_Click(object sender, EventArgs e)
        {
            currentWidget.btnClick("SQL", radioStation);
            this.lbDisplay.Text = currentWidget.ToString();
            widgetTextToRichText(currentWidget);
        }

        private void btCall_Click(object sender, EventArgs e)
        {
            currentWidget.btnClick("CALL", radioStation);
            this.lbDisplay.Text = currentWidget.ToString();
            widgetTextToRichText(currentWidget);
        }

        private void btLt_Click(object sender, EventArgs e)
        {

            currentWidget.btnClick("LT", radioStation);
            this.lbDisplay.Text = currentWidget.ToString();
            widgetTextToRichText(currentWidget);
        }

        private void btZero_Click(object sender, EventArgs e)
        {

            currentWidget.btnClick("ZERO", radioStation);
            this.lbDisplay.Text = currentWidget.ToString();
            widgetTextToRichText(currentWidget);
        }

        private void btPgm_Click(object sender, EventArgs e)
        {
            currentWidget.btnClick("PGM", radioStation);
            this.lbDisplay.Text = currentWidget.ToString();
            widgetTextToRichText(currentWidget);
        }

        private void btLeft_Click(object sender, EventArgs e)
        {
            currentWidget.btnClick("LEFT", radioStation);
            this.lbDisplay.Text = currentWidget.ToString();
            widgetTextToRichText(currentWidget);
        }

        private void btRigth_Click(object sender, EventArgs e)
        {
            currentWidget.btnClick("RIGTH", radioStation);
            this.lbDisplay.Text = currentWidget.ToString();
            widgetTextToRichText(currentWidget);
        }

        private void btDown_Click(object sender, EventArgs e)
        {
            currentWidget.btnClick("DOWN", radioStation);
            this.lbDisplay.Text = currentWidget.ToString();
            widgetTextToRichText(currentWidget);
        }

        private void btUp_Click(object sender, EventArgs e)
        {
            currentWidget.btnClick("UP", radioStation);
            this.lbDisplay.Text = currentWidget.ToString();
            widgetTextToRichText(currentWidget);
        }

        private void btMode_Click(object sender, EventArgs e)
        {
        //    keyboard.btnClick("MODE", radioStation, display);
        //    //MessageBox.Show(System.Reflection.MethodBase.GetCurrentMethod().Name);
        //    radioStation.nextMode();
        //    this.lbDisplay.Text = display.ToString();
            currentWidget.btnClick("MODE", radioStation);
            this.lbDisplay.Text = currentWidget.ToString();
            widgetTextToRichText(currentWidget);
        }

        private void btPrePlus_Click(object sender, EventArgs e)
        {
            currentWidget.btnClick("PRE_PLUS", radioStation);
            this.lbDisplay.Text = currentWidget.ToString();
            widgetTextToRichText(currentWidget);
        }

        private void btPreMinus_Click(object sender, EventArgs e)
        {
            currentWidget.btnClick("PRE_MINUS", radioStation);
            this.lbDisplay.Text = currentWidget.ToString();
            widgetTextToRichText(currentWidget);
        }

        private void btEnter_Click(object sender, EventArgs e)
        {
            currentWidget.btnClick("ENT", radioStation);
            this.lbDisplay.Text = currentWidget.ToString();
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
            this.lbDisplay.Text = display.ToString();
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
    }
}
