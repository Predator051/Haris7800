using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harris7800HMP
{
    public enum RadioStationMode
    {
        FIX, ALE, ThreeG, HOP
    };
    public class RadioStation
    {   
        public enum SwitchOnSteps
        {
            Logo, Model, Init, AfterInit
        }

        SwitchOnSteps onSteps = SwitchOnSteps.Logo;

        Battery battery = new Battery();
        bool receptionMode = true;
        RadioStationMode mode = RadioStationMode.FIX;
        Volume volume = new Volume();
        Switcher switcher;
        bool keyBoardLock = false;
        string firstLine = "";
        string secondLine = "";
        string thirdLine = " ";
        string fourthLine = "";
        KeyModule keys = new KeyModule();
        List<StationPresetModemModule> presetModemsModule = new List<StationPresetModemModule>();
        
        public bool KeyBoardLock { get => keyBoardLock; set => keyBoardLock = value; }
        public SwitchOnSteps OnSteps { get => onSteps; set => onSteps = value; }
        public RadioStationMode Mode { get => mode; set => mode = value; }
        public KeyModule Keys { get => keys; set => keys = value; }

        public string currentModeToString()
        {
            return modeToString(mode);
        }

        public static string modeToString(RadioStationMode mode)
        {
            if (mode == RadioStationMode.ThreeG)
            {
                return "3G ";
            }

            return Enum.GetName(typeof(RadioStationMode), mode);
        }

        public RadioStation(Switcher sw)
        {
            switcher = sw;
        }

        public SwitcherState getState()
        {
            return switcher.State;
        }

        public bool isOff()
        {
            return switcher.State == SwitcherState.Off;
        }

        public void nextState()
        {
            switcher.nextState();

            //sec
        }

        public override string ToString()
        {
            if(switcher.State == SwitcherState.Off)
            {
                return "";
            }

            return getFirstLine()
                + "\n" + getSecondLine()
                + "\n" + getThirdLine()
                + "\n" + getFourthLine();
        }
        public string getFirstLine()
        {
            string result = " ";
            if(receptionMode)
            {
                result += "R";
            }

            result += " " + battery.ToString();

            switch (Mode) {
                case RadioStationMode.ALE:
                    {
                        result += " ALE";
                        break;
                    }
                case RadioStationMode.FIX:
                    {
                        result += " FIX";
                        break;
                    }
                case RadioStationMode.HOP:
                    {
                        result += " HOP";
                        break;
                    }
                case RadioStationMode.ThreeG:
                    {
                        result += " 3G ";
                        break;
                    }
            }

            switch (switcher.State)
            {
                case SwitcherState.CLR:
                    {
                        result += " CLR";
                        break;
                    }
                case SwitcherState.CT:
                    {
                        result += " CT ";
                        break;
                    }
                case SwitcherState.LD:
                    {
                        result += " LD ";
                        break;
                    }
                case SwitcherState.PT:
                    {
                        result += " PT ";
                        break;
                    }
                case SwitcherState.Z:
                    {
                        result += " Z  ";
                        break;
                    }
            }

            return result;
        }

        public string getSecondLine()
        {
            return secondLine;
        }

        public string getThirdLine()
        {
            return thirdLine;
        }

        public string getFourthLine()
        {
            return fourthLine;
        }

        public RadioStationMode nextMode()
        {
            if((int)Mode + 1 > 3)
            {
                Mode = RadioStationMode.FIX;
            } 
            else
            {
                Mode += 1;
            }

            switch (Mode)
            {
                case RadioStationMode.ALE:
                    {
                        secondLine = Helper.centerString(Helper.EmptySpaceString, ">>>  ALE  <<<");
                        break;
                    }
                case RadioStationMode.FIX:
                    {
                        secondLine = Helper.centerString(Helper.EmptySpaceString, ">>>  FIX  <<<");
                        break;
                    }
                case RadioStationMode.HOP:
                    {
                        secondLine = Helper.centerString(Helper.EmptySpaceString, ">>>  HOP  <<<");
                        break;
                    }
                case RadioStationMode.ThreeG:
                    {
                        secondLine = Helper.centerString(Helper.EmptySpaceString, ">>>  3G  <<<");
                        break;
                    }
            }

            fourthLine = Helper.centerString(Helper.EmptySpaceString, "MODE TO SELECT");

            return Mode;
        }
    }
}
