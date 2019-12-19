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
        StationPresetSystemContainer presetSystemsModule = new StationPresetSystemContainer();
        txMsgContainer txMsgs = new txMsgContainer();

        public bool connectedUsb = false;
        public bool connectedHandset = false;
        public bool connectedCoupler = false;

        public RadioStation()
        {
            for (int i = 1; i <= 20; i++)
            {
                string numStr = i < 10 ? "0" + i : i.ToString();
                StationPresetModemModule m = new StationPresetModemModule();
                m.originalName = "MDM" + numStr;
                m.name = "MDM" + numStr;
                presetModemsModule.Add(m);
            }
        }
        public bool KeyBoardLock { get => keyBoardLock; set => keyBoardLock = value; }
        public SwitchOnSteps OnSteps { get => onSteps; set => onSteps = value; }
        public RadioStationMode Mode { get => mode; set => mode = value; }
        public KeyModule Keys { get => keys; set => keys = value; }
        public List<StationPresetModemModule> PresetModems { get => presetModemsModule; set => presetModemsModule = value; }
        public txMsgContainer TxMsgs { get => txMsgs; set => txMsgs = value; }
        public StationPresetSystemContainer PresetSystemsModule { get => presetSystemsModule; set => presetSystemsModule = value; }

        public void addPresetModem(StationPresetModemModule modem)
        {
            var isContains = presetModemsModule.Find(m => m.originalName == modem.originalName);
            if (isContains != null)
            {
                presetModemsModule.Remove(isContains);
            }
            presetModemsModule.Add(modem);
        }

        public void addPresetSystem(List<WidgetTextParams> textParams, string oldName)
        {
            Func<string, WidgetTextParams> findParam = (string name) =>
            {
                return textParams.Find(tp => tp.Name == name);
            };

            Func<string, string> getValueTextParam = (string name) =>
            {
                return findParam(name).currParam();
            };

            StationPresetSystem stationPresetSystemModule = new StationPresetSystem();

            stationPresetSystemModule.name = getValueTextParam("PRESET NAME");
            stationPresetSystemModule.radioMode = stringToMode(getValueTextParam("RADIO MODE"));
            stationPresetSystemModule.channelNumber = getValueTextParam("CHANNEL NUMBER");
            string modemPreset = getValueTextParam("MODEM PRESET");
            string keyTypeName = getValueTextParam("ENCRYPTION TYPE");
            string keyName = getValueTextParam("ENCRYPTION KEY");
            stationPresetSystemModule.ptVoiceMode = getValueTextParam("PT VOICE MODE");
            stationPresetSystemModule.ctVoiceMode = getValueTextParam("CT VOICE MODE");
            stationPresetSystemModule.enable = getValueTextParam("ENABLE");


            if (modemPreset != "OFF")
            {
                stationPresetSystemModule.modemPreset = PresetModems.Find(pm => pm.name == modemPreset);
            }

            if (keyName == "--------------------")
            {
                KeyModule.KeyType kType = KeyModule.stringToType(keyTypeName);
                KeyModule.KeyValue value = Keys.Keys[kType].Find(k => k.KeyName == keyName);
                stationPresetSystemModule.key = new KeyValuePair<KeyModule.KeyType, KeyModule.KeyValue>(kType, value);
            } 
            else
            {
                KeyModule.KeyType kType = KeyModule.stringToType(keyTypeName);
                stationPresetSystemModule.key = new KeyValuePair<KeyModule.KeyType, KeyModule.KeyValue>(kType, null);
            }

            var isContains = presetSystemsModule.SystemPresets.Find(psm => psm.name == oldName);
            if (isContains != null)
            {
                presetSystemsModule.SystemPresets.Remove(isContains);
            }

            presetSystemsModule.addPresetSystem(stationPresetSystemModule);
        }
        public void updatePresetModem(StationPresetModemModule modem, string oldName)
        {
            var isContains = presetModemsModule.Find(m => m.name == oldName);
            if (isContains != null)
            {
                presetModemsModule.Remove(isContains);
            }
            presetModemsModule.Add(modem);
        }

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

        public static RadioStationMode stringToMode(string str)
        {

            switch(str)
            {
                case "3G ":
                case "3G":
                    {
                        return RadioStationMode.ThreeG;
                    }
                case "FIX":
                    {
                        return RadioStationMode.FIX;
                    }
                case "ALE":
                    {
                        return RadioStationMode.ALE;
                    }
                case "HOP":
                    {
                        return RadioStationMode.HOP;
                    }
            }
            return RadioStationMode.FIX;
        }

        public RadioStation(Switcher sw)
        {
            switcher = sw; 
            for (int i = 1; i <= 20; i++)
            {
                string numStr = i < 10 ? "0" + i : i.ToString();
                StationPresetModemModule m = new StationPresetModemModule();
                m.originalName = "MDM" + numStr;
                m.name = "MDM" + numStr;
                presetModemsModule.Add(m);
            }
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
