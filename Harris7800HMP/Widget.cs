using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harris7800HMP
{
    public class Param
    {
        bool isActive = false;
        public string text;
        int activeFrom;
        int activeTo;
        string name;
        Action<string, Param> changeFunction;
        Action updateFunction;
        int x;
        int y;
        int fontSize = 6;
        bool isVisible = true;

        public Param(string name, Action<string, Param> act, string text, int xX, int yY, Action update = null)
        {
            this.Name = name;
            changeFunction = act;
            this.text = text;
            this.X = xX;
            this.Y = yY;
            updateFunction = update;
        }
        public void action(string text)
        {
            changeFunction?.Invoke(text, this);
        }
        public bool IsActive { get => isActive; 
            set
            {
                isActive = value;
                activeFrom = 0;
                activeTo = text.Length;
            }
        }

        public string getActiveText()
        {
            return text.Substring(activeFrom, activeTo);
        }
        public bool isInParam()
        {
            return activeFrom != 0 || activeTo != text.Length;
        }
        public string Text { get => text; 
            set {
                text = value;
                ActiveTo = value.Length;        
            } 
        }
        public string Name { get => name; set => name = value; }
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public int ActiveFrom { get => activeFrom; set => activeFrom = value; }
        public int ActiveTo { get => activeTo; set => activeTo = value; }
        public Action UpdateFunction { get => updateFunction; set => updateFunction = value; }
        public bool IsVisible { get => isVisible; set => isVisible = value; }

        public void update()
        {
            UpdateFunction?.Invoke();
        }
    }
    public class Widget
    {
        string name;
        Dictionary<string, Widget> availableWidgets = new Dictionary<string, Widget>();
        public Widget comeFrom;
        public Widget moveTo;
        List<Param> parameters = new List<Param>();
        Dictionary<Param, List<Button>> paramsAction = new Dictionary<Param, List<Button>>();
        int lineLenght = 50;
        Dictionary<int, int> lineSize = new Dictionary<int, int> {
            {0, 6}, {1, 6}, {3, 6}, {2, 6}, {4, 6},
        };
        Dictionary<int, int> lineCharOffset = new Dictionary<int, int> {
            {0, 2}, {1, 2}, {2, 2}, {3, 2}, {4, 2}
        };
        Dictionary<Param, List<RadioStationMode>> awailableParamForMode = new Dictionary<Param, List<RadioStationMode>>();
        Dictionary<string, Object> objectContainer = new Dictionary<string, Object>();
        public Widget(string name)
        {
            this.name = name;
        }
        public Widget ComeFrom { get => comeFrom; set => comeFrom = value; }
        public string Name { get => name; set => name = value; }
        public Widget MoveTo { get => moveTo; set
            {
                moveTo = value;

                if (moveTo != null)
                {
                    moveTo.ComeFrom = this;
                }
            }
        }

        public Dictionary<int, int> LineSize { get => lineSize; set => lineSize = value; }
        public Dictionary<int, int> LineCharOffset { get => lineCharOffset; set => lineCharOffset = value; }
        public Dictionary<string, object> ObjectContainer { get => objectContainer; set => objectContainer = value; }

        public Param activeParam()
        {
            return parameters.Find(param => param.IsActive);
        }

        public List<Param> getActiveParamsBy(Func<Param, bool> selectFunc = null)
        {
            List<Param> @params = new List<Param>();

            foreach (var pr in parameters)
            {
                if (pr.IsActive)
                {
                    if (selectFunc != null && selectFunc(pr))
                    {
                        @params.Add(pr);
                    }
                    else if(selectFunc == null)
                    {
                        @params.Add(pr);
                    }
                }
            }

            return @params;
        }

        public void deactiveParam()
        {
            parameters.ForEach(param => param.IsActive = false);
        }

        public void addAvailableWidget(string name, Widget widget)
        {
            availableWidgets.Add(name, widget);
        }
        public Widget getAvailableWidget(string name)
        {
            return availableWidgets[name];
        }

        public void prepareToShowWidget(string name)
        {
            this.MoveTo = availableWidgets[name];
        }
        public Widget showPreviousWidget()
        {
            this.moveTo = this.comeFrom;
            this.moveTo.moveTo = null;
            this.comeFrom = null;
            return this.moveTo;
        }
        public Widget addParam(Param param, bool addDefaultMode = true)
        {
            parameters.Add(param);
            if(addDefaultMode)
            {
                awailableParamForMode.Add(param, new List<RadioStationMode> { RadioStationMode.FIX });
            } 
            else
            {
                awailableParamForMode.Add(param, new List<RadioStationMode>());
            }
            return this;
        }

        public Widget addModeForParam(string paramName, RadioStationMode mode)
        {
            awailableParamForMode[getParam(paramName)].Add(mode);
            return this;
        }

        public Widget addModesForParam(string paramName, List<RadioStationMode> mode)
        {
            var modesByParam = awailableParamForMode[getParam(paramName)];

            modesByParam.AddRange(mode);
            awailableParamForMode[getParam(paramName)] = modesByParam.Distinct().ToList();

            return this;
        }

        public void addActionToParam(Param param, Button btn)
        {
            if(paramsAction.ContainsKey(param))
            {
                paramsAction[param].Add(btn);
            } 
            else
            {
                paramsAction.Add(param, new List<Button>(){btn});
            }
        }

        public List<Param> getParamByMode(RadioStationMode mode)
        {
            List<Param> modeParams = new List<Param>();
            foreach (Param pr in parameters)
            {
                if (awailableParamForMode[pr].Contains(mode))
                {
                    modeParams.Add(pr);
                }
            }
            return modeParams;
        }

        public void invisibleParamsByNode(RadioStationMode mode)
        {
            List<Param> paramsByNode = getParamByMode(mode);

            foreach (Param pr in parameters)
            {
                if (!paramsByNode.Contains(pr))
                {
                    pr.IsVisible = false;
                }
            }
        }
        public void visibleParamsByNode(RadioStationMode mode)
        {
            List<Param> paramsByNode = getParamByMode(mode);

            foreach (Param pr in parameters)
            {
                if (paramsByNode.Contains(pr))
                {
                    pr.IsVisible = true;
                }
            }
        }

        public void invisibleAllParams()
        {
            foreach (var item in parameters)
            {
                item.IsVisible = false;
            }
        }

        private string insertParamToLine(Param param, string line)
        {
            line = line.Remove(param.Y, param.Text.Length);
            return line.Insert(param.Y, param.Text);
        }

        public string[] toLines()
        {
            Dictionary<int, string> lineString = new Dictionary<int, string>();

            foreach (Param param in parameters)
            {
                if (param.IsVisible == false)
                {
                    continue;
                }

                if (!lineString.ContainsKey(param.X))
                {
                    lineString.Add(param.X, new string(' ', lineLenght));
                }
                lineString[param.X] = this.insertParamToLine(param, lineString[param.X]);
            }

            List<string> result = new List<string>();

            foreach (int line in lineString.Keys)
            {
                result.Add(lineString[line]);
            }
            return result.ToArray();
        }

        public override string ToString()
        {
            string result = "";

            Dictionary<int, string> lineString = new Dictionary<int, string>();

            foreach(Param param in parameters)
            {
                if (!lineString.ContainsKey(param.X))
                {
                    lineString.Add(param.X, new string(' ', lineLenght));
                }
                lineString[param.X] = this.insertParamToLine(param, lineString[param.X]);
            }

            foreach(int line in lineString.Keys)
            {
                result += lineString[line] + "\n";
            }

            return result;
        }

        public Param getParam(string name)
        {
            return parameters.Find(param => param.Name == name);
        }

        public void btnClick(string name, RadioStation station)
        {
            if (Name == WidgetInit.getNameMenu(WidgetInit.MenuNames.MainMenu)
                && station.KeyBoardLock)
            {
                switch(name)
                {
                    case "CALL":
                        {
                            Form1.keyEntered += "1";
                            break;
                        }
                    case "MODE":
                        {
                            Form1.keyEntered += "3";
                            break;
                        }
                    case "OPT":
                        {
                            Form1.keyEntered += "7";
                            break;
                        }
                    case "DOWN":
                        {
                            Form1.keyEntered += "9";
                            station.KeyBoardLock = !Form1.keyEntered.Contains(Form1.keyNeed);
                            break;
                        }
                }
                if(station.KeyBoardLock)
                {
                    prepareToShowWidget(WidgetInit.getNameMenu(WidgetInit.MenuNames.KeyboardLock));
                    Form1.timerAction = () =>
                    {
                        Widget trans = getAvailableWidget(WidgetInit.getNameMenu(WidgetInit.MenuNames.KeyboardLock));
                        trans.prepareToShowWidget(WidgetInit.getNameMenu(WidgetInit.MenuNames.MainMenu));
                    };
                    Form1.startTimer();
                }
                return;
            }

            List<Button> btn = new List<Button>();
            foreach(var list in paramsAction.Values)
            {
                var bt = list.Find(button => button.Name == name);
                if (bt != null)
                {
                    btn.Add(bt);
                }
            }

            btn.ForEach(button => button.click(station, this));
        }
        public void update()
        {
            parameters.ForEach(p => p.update());
        }
    
        public bool isContainParam(string name)
        {
            foreach(var pr in parameters)
            {
                if(pr.Name == name)
                {
                    return true;
                }
            }

            return false;
        }
    }


}
