using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harris7800HMP
{
    public enum ChargingStatus { Low, Middle, High };
    public class Battery
    {
        
        private string chargSymbol = "■";
        private ChargingStatus chargingStatus = ChargingStatus.High;

        public override string ToString()
        {
            string result = "BAT ";
            if( chargingStatus > ChargingStatus.Low )
            {
                result += chargSymbol;
            }
            if (chargingStatus > ChargingStatus.Middle)
            {
                result += chargSymbol;
            }
            if (chargingStatus >= ChargingStatus.High)
            {
                result += chargSymbol;
            }
            return result;
        }

    }

    public class Volume
    {

        private string volumeSymbol = "■";
        private int level = 1;

        public override string ToString()
        {
            if (level == 1)
            {
                return "VOL ■  ";
            }
            if (level == 2)
            {
                return "VOL ■■ ";
            }
            return "VOL ■■■";
        }

    }

    public class WidgetTextParams
    {
        string name;
        List<string> parameters = new List<string>();
        int currIndex = 0;

        public WidgetTextParams(string name)
        {
            this.Name = name;
        }

        public string Name { get => name; set => name = value; }
        public int CurrIndex { get => currIndex; set => currIndex = value; }
        public List<string> Parameters { get => parameters; set => parameters = value; }

        public WidgetTextParams addParam(string name)
        {
            parameters.Add(name);
            return this;
        }

        public string getNextParam()
        {
            currIndex++; 
            if (currIndex >= parameters.Count)
            {
                currIndex = 0;
            }
            return parameters[currIndex];
        }
        public string getPrevParam()
        {
            currIndex--;

            if (currIndex < 0)
            {
                currIndex = parameters.Count - 1;
            }
            return parameters[currIndex];
        }

        public string currParam()
        {
            return parameters[currIndex];
        }

        public static bool operator ==(WidgetTextParams a, WidgetTextParams b)
        {
            return a.Name == b.Name;
        }
        public static bool operator !=(WidgetTextParams a, WidgetTextParams b)
        {
            return a.Name != b.Name;
        }
    
        public void clear()
        {
            currIndex = 0;
            parameters.Clear();
        }
    }

    public class SmsMenu
    {
        List<string> numberSms = new List<string>() {
            "", "", "", "", "", "", "", "", "", ""
        };

        int currentIndex = 0;

        public int CurrentIndex { get => currentIndex; set => currentIndex = value; }
        public List<string> NumberSms { get => numberSms; set => numberSms = value; }

        public void next()
        {
            CurrentIndex++;
            if (CurrentIndex > NumberSms.Count - 1)
            {
                CurrentIndex = 0;
            }
        }

        public void previous()
        {
            CurrentIndex--;
            if (CurrentIndex < 0)
            {
                CurrentIndex = NumberSms.Count - 1;
            }
        }

        public Tuple<string, string> getPair()
        {
            int firstInd;
            int secondInd;
            if (CurrentIndex % 2 == 0)
            {
                firstInd = CurrentIndex;
                secondInd = CurrentIndex + 1;
            } 
            else
            {
                firstInd = CurrentIndex - 1;
                secondInd = CurrentIndex;
            }
            string firstStr = firstInd + ":" + NumberSms[firstInd];
            string secondStr = secondInd + ":" + NumberSms[secondInd];
            return new Tuple<string, string>(firstStr, secondStr);
        }
    }

    public class KeyModule
    {
        public enum KeyType
        {
            None,
            Citadel1,
            Aes256,
            Aes128
        }

        public static string typeToString(KeyType type)
        {
            switch (type)
            {
                case KeyType.Aes128:
                    {
                        return "AES-128";
                    }
                case KeyType.Aes256:
                    {
                        return "AES-256";
                    }
                case KeyType.Citadel1:
                    {
                        return "CITADEL I (MK-128)";
                    }
            }
            return "";
        }

        public static KeyType stringToType(string typeStr)
        {
            switch (typeStr)
            {
                case "AES-128":
                    {
                        return KeyType.Aes128;
                    }
                case "AES-256":
                    {
                        return KeyType.Aes256;
                    }
                case "CITADEL":
                case "CITADEL I (MK-128)":
                    {
                        return KeyType.Citadel1;
                    }
            }
            return KeyType.None;
        }

        public class KeyValue
        {
            public string KeyName = "";
            public string KeyVal = "";
            public string KeyAws = "";
            public int updateCount = 0;
            public string countToString()
            {
                if (updateCount < 10)
                {
                    return "0" + updateCount;
                }
                return updateCount.ToString();
            }
        }

        Dictionary<KeyType, List<KeyValue>> keys = new Dictionary<KeyType, List<KeyValue>> {
            {KeyType.Citadel1, new List<KeyValue>() },
            {KeyType.Aes256, new List<KeyValue>() },
            {KeyType.Aes128, new List<KeyValue>() },
        };

        public Dictionary<KeyType, List<KeyValue>> Keys { get => keys; set => keys = value; }

        public void addKey(KeyType type, KeyValue value)
        {
            keys[type].Add(value);
        }

        public bool isContainKey(string name)
        {
            var KeysName = Keys.Values.ToList();
            foreach (var klist in KeysName)
            {
                foreach (var k in klist)
                {
                    if (k.KeyName == name)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public KeyValue findKey(string name)
        {
            var KeysName = Keys.Values.ToList();
            foreach (var klist in KeysName)
            {
                foreach (var k in klist)
                {
                    if (k.KeyName == name)
                    {
                        return k;
                    }
                }
            }
            return null;
        }
    }

    public class StationPresetModemModule
    {
        public string name;
        public string modemType;
        public string dataRate;
        public string mode;
        public string dataBits;
        public string stopBits;
        public string parity;
        public string enable;
        public string originalName = "";

        public void parseFromListWidgetTextParams(List<WidgetTextParams> textParams)
        {
            Func<string, WidgetTextParams> findParam = (string name) =>
            {
                return textParams.Find(tp => tp.Name == name);
            };

            Func<string, string> getValueTextParam = (string name) =>
            {
                return findParam(name).currParam();
            };

            name = getValueTextParam("PRESET NAME");
            modemType = getValueTextParam("MODEM TYPE");
            dataRate = getValueTextParam("DATA RATE");
            mode = getValueTextParam("MODE");
            dataBits = getValueTextParam("DATA BITS");
            stopBits = getValueTextParam("STOP BITS");
            parity = getValueTextParam("PARITY");
            enable = getValueTextParam("ENABLE");
;        }

        public static StationPresetModemModule parse(List<WidgetTextParams> textParams)
        {
            StationPresetModemModule module = new StationPresetModemModule();
            module.parseFromListWidgetTextParams(textParams);
            return module;
        }
    }

    public class StationPresetSystem
    {
        public string name;
        public RadioStationMode radioMode;
        public string channelNumber;
        public StationPresetModemModule modemPreset;
        public KeyValuePair<KeyModule.KeyType, KeyModule.KeyValue> key;
        public string ptVoiceMode;
        public string ctVoiceMode;
        public string enable;
    }

    public class StationPresetSystemContainer
    {
        List<StationPresetSystem> systemPresets = new List<StationPresetSystem>();
        int currIndex = 0;

        public StationPresetSystemContainer ()
        {
            StationPresetSystem def = new StationPresetSystem();

            def.channelNumber = "001";
            def.enable = "ON";
            def.key = new KeyValuePair<KeyModule.KeyType, KeyModule.KeyValue>(KeyModule.KeyType.None, null);
            def.ctVoiceMode = "CLR";
            def.modemPreset = null;
            def.radioMode = RadioStationMode.FIX;
        }

        public List<StationPresetSystem> SystemPresets { get => systemPresets; set => systemPresets = value; }

        public void addPresetSystem(StationPresetSystem newPreset)
        {
            SystemPresets.Add(newPreset);
        } 

        public StationPresetSystem nextPreset()
        {
            currIndex++;
            if (currIndex > SystemPresets.Count - 1)
            {
                currIndex = 0;
            }

            return SystemPresets[currIndex];
        }

        public StationPresetSystem prevPreset()
        {
            currIndex--;
            if (currIndex < 0)
            {
                currIndex = SystemPresets.Count - 1;
            }

            return SystemPresets[currIndex];
        }
    }

    public class txMsg
    {
        public static string emptyMsg = "------------------------";
        public string msg;
        public int number;
        public bool isDefault()
        {
            return msg == emptyMsg;
        }
    }

    public class txMsgContainer
    {
        List<txMsg> msgs;
        int currIndex = 0;

        public bool isEmpty()
        {
            return !msgs.Any((txMsg msg)=> {
                return msg.msg != txMsg.emptyMsg;
            });
        }

        public txMsgContainer()
        {
            msgs = new List<txMsg>();

            for (int i = 0; i <= 9; i++)
            {
                txMsg tx = new txMsg();
                tx.msg = txMsg.emptyMsg;
                tx.number = i + 1;
                msgs.Add(tx);
            }
        }

        public List<txMsg> Msgs { get => msgs; set => msgs = value; }

        public txMsg currMsg()
        {
            if (msgs.Count == 0)
            {
                return null;
            }

            return msgs[currIndex];
        }

        public txMsg nextNDMsg()
        {
            currIndex++;
            bool found = false;

            for (; currIndex < msgs.Count; currIndex++)
            {
                if (msgs[currIndex].isDefault())
                {
                    continue;
                }
                found = true;
                break;
            }

            if (!found)
            {
                currIndex = 0;
                for (; currIndex < msgs.Count; currIndex++)
                {
                    if (msgs[currIndex].isDefault())
                    {
                        continue;
                    }
                    break;
                }
            }

            return msgs[currIndex];
        }

        public txMsg prevNDMsg()
        {
            currIndex--;
            bool found = false;
            for (; currIndex >= 0; currIndex--)
            {
                if (msgs[currIndex].isDefault())
                {
                    continue;
                }
                found = true;
                break;
            }

            if (!found)
            {
                currIndex = msgs.Count - 1;
                for (; currIndex >= 0; currIndex--)
                {
                    if (msgs[currIndex].isDefault())
                    {
                        continue;
                    }
                    break;
                }
            }

            return msgs[currIndex];
        }
        public txMsg nextMsg()
        {
            currIndex++;
            if (currIndex > msgs.Count - 1)
            {
                currIndex = 0;
            }

            return msgs[currIndex];
        }

        public txMsg prevMsg()
        {
            currIndex--;
            if (currIndex < 0)
            {
                currIndex = msgs.Count - 1;
            }

            return msgs[currIndex];
        }
    }
}
