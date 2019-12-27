﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harris7800HMP
{
    class WidgetInit
    {
        public enum MenuNames
        {
            MainMenu,
            MainMenuDisplayOpt,
            ProgramMenu,
            ProgramComsecMenu,
            ProgramComsecIdMenu,
            ProgramComsecMiMenu,
            ProgramComsecAksMenu,
            ProgramComsecKeysMenu,
            ProgramModeMenu,
            ProgramModePresetMenu,
            ProgramModePresetChannelMenu, 
            ProgramModePresetModemMenu,
            ProgramModePresetSystemMenu,
            ProgramModeAleMenu,
            ProgramModeAleAmdMenu,
            ProgramModeAleAmdTxMsgMenu,
            TransitionProgramMenu,
            ProgramMenu2,
            OptionMenu,
            OptionMenu2,
            OptionMenuTest,
            OptionMenuRadio,
            KeyboardLock,
            OptionGpsTodMenu,
            OptionScanMenu,
            OptionThreeGMenu,
            OptionThreeG2Menu,
            OptionExtAccMenu,
            OptionTestBitMenu,
            OptionTestBatteryMenu,
            OptionTestTempMenu,
            OptionTestSpecialMenu,
            OptionTestSpecialVersionMenu,
            OptionTestSpecialConfigMenu,
            SelectModeMenu,
            OptionMsgMenu,
            OptionMsgSmsMenu,
            OptionMsgSmsFunctionsMenu,
            OptionMsgEnterSmsMenu,
            OptionMsgSmsSendingMenu,
            OptionAleMenu,
            OptionAleLqaMenu,
            OptionAleLqaExchangeMenu,
            
        }

        static SmsMenu smsControls = new SmsMenu();
        static public string getNameMenu(MenuNames name)
        {
            return Enum.GetName(typeof(MenuNames), name);
        }

        static public Dictionary<string, Widget> widgetContainer = new Dictionary<string, Widget>();

        static public Widget initDefaultWidgets(RadioStation station)
        {
            Widget mainMenu = initMainMenu(station);
            Widget mainMenuDisplayOpt = initMainMenuDisplayOpt(station);
            Widget programMenu = initProgramMenu(station);
            Widget transitionPM = initTransitionProgramMenu(station);
            Widget programMenu2 = initProgramMenu2(station);
            Widget optionMenu = initOptionMenu(station);
            Widget optionMenu2 = initOptionMenu2(station);
            Widget optionMenuTest = initOptionMenuTest(station);
            Widget optionMenuRadio = initOptionMenuRadio(station);
            Widget keyBoardLock = initKeyboardLockMenu(station);
            Widget optionMenuGps = initOptionGpsTodMenu(station);
            Widget optionScanMenu = initOptionScanMenu(station);
            Widget optionExtAccMenu = initOptionExtAccMenu(station);
            Widget optionThreeGMenu = initOptionThreeGMenu(station);
            Widget optionThreeG2Menu = initOptionThreeG2Menu(station);
            Widget optionTestBitMenu = initOptionTestBitMenu(station);
            Widget optionTestBatteryMenu = initOptionTestBatteryMenu(station);
            Widget optionTestTempMenu = initOptionTestTempMenu(station);
            Widget optionTestSpecialMenu = initOptionTestSpecialMenu(station);
            Widget optionTestSpecialVersionMenu = initOptionTestSpecialVersionMenu(station);
            Widget optionTestSpecialConfigMenu = initOptionTestSpecialConfigMenu(station);
            Widget optionModeSelectMenu = initSelectModeMenu(station);
            Widget optionMsgMenu = initOptionMsgMenu(station);
            Widget optionMsgSmsMenu = initOptionMsgSmsMenu(station);
            Widget optionMsgSmsFunctionsMenu = initOptionMsgSmsFunctionsMenu(station);
            Widget optionMsgEnterSmsMenu = initOptionMsgNewSmsMenu(station);
            Widget optionMsgSmsSendingMenu = initOptionMsgSmsSendingMenu(station);
            Widget optionAleMenu = initOptionAleMenu(station);
            Widget optionAleLqaMenu = initOptionAleLqaMenu(station);
            Widget optionAleLqaExchangeMenu = initOptionAleLqaExchangeMenu(station);
            Widget programComsecMenu = initProgramComsecMenu(station);
            Widget programComsecIdMenu = initProgramComsecIdMenu(station);
            Widget programComsecMiMenu = initProgramComsecMiMenu(station);
            Widget programComsecAksMenu = initProgramComsecAksMenu(station);
            Widget programComsecKeysMenu = initProgramComsecKeysMenu(station);
            Widget programModeMenu = initProgramModeMenu(station);
            Widget programModePresetMenu = initProgramModePresetMenu(station);
            Widget programModePresetChannelMenu = initProgramModePresetChannelMenu(station);
            Widget programModePresetModemMenu = initProgramModePresetModemMenu(station);
            Widget programModePresetSystemMenu = initProgramModePresetSystemMenu(station);
            Widget programModeAleMenu = initProgramModeAleMenu(station);
            Widget programModeAleAmdMenu = initProgramModeAleAmdMenu(station);
            Widget programModeAleAmdTxMsgMenu = initProgramModeAleAmdTxMsgMenu(station);

            transitionPM.addAvailableWidget(getNameMenu(MenuNames.ProgramMenu), programMenu);

            mainMenu.addAvailableWidget(getNameMenu(MenuNames.TransitionProgramMenu), transitionPM);
            mainMenu.addAvailableWidget(getNameMenu(MenuNames.OptionMenu), optionMenu);
            mainMenu.addAvailableWidget(getNameMenu(MenuNames.KeyboardLock), keyBoardLock);
            mainMenu.addAvailableWidget(getNameMenu(MenuNames.SelectModeMenu), optionModeSelectMenu);
            mainMenu.addAvailableWidget(getNameMenu(MenuNames.MainMenuDisplayOpt), mainMenuDisplayOpt);

            programMenu.addAvailableWidget(getNameMenu(MenuNames.ProgramMenu2), programMenu2);
            programMenu.addAvailableWidget(getNameMenu(MenuNames.ProgramComsecMenu), programComsecMenu);
            programMenu.addAvailableWidget(getNameMenu(MenuNames.ProgramModeMenu), programModeMenu);

            programComsecMenu.addAvailableWidget(getNameMenu(MenuNames.ProgramComsecIdMenu), programComsecIdMenu);
            programComsecMenu.addAvailableWidget(getNameMenu(MenuNames.ProgramComsecMiMenu), programComsecMiMenu);
            programComsecMenu.addAvailableWidget(getNameMenu(MenuNames.ProgramComsecAksMenu), programComsecAksMenu);
            programComsecMenu.addAvailableWidget(getNameMenu(MenuNames.ProgramComsecKeysMenu), programComsecKeysMenu);

            programModeMenu.addAvailableWidget(getNameMenu(MenuNames.ProgramModePresetMenu), programModePresetMenu);
            programModeMenu.addAvailableWidget(getNameMenu(MenuNames.ProgramModeAleMenu), programModeAleMenu);

            programModePresetMenu.addAvailableWidget(getNameMenu(MenuNames.ProgramModePresetChannelMenu), programModePresetChannelMenu);
            programModePresetMenu.addAvailableWidget(getNameMenu(MenuNames.ProgramModePresetModemMenu), programModePresetModemMenu);
            programModePresetMenu.addAvailableWidget(getNameMenu(MenuNames.ProgramModePresetSystemMenu), programModePresetSystemMenu);

            programModeAleMenu.addAvailableWidget(getNameMenu(MenuNames.ProgramModeAleAmdMenu), programModeAleAmdMenu);

            programModeAleAmdMenu.addAvailableWidget(getNameMenu(MenuNames.ProgramModeAleAmdTxMsgMenu), programModeAleAmdTxMsgMenu);

            optionMenu.addAvailableWidget(getNameMenu(MenuNames.OptionMenu2), optionMenu2);
            optionMenu.addAvailableWidget(getNameMenu(MenuNames.OptionMenuRadio), optionMenuRadio);
            optionMenu.addAvailableWidget(getNameMenu(MenuNames.OptionGpsTodMenu), optionMenuGps);
            optionMenu.addAvailableWidget(getNameMenu(MenuNames.OptionScanMenu), optionScanMenu);
            optionMenu.addAvailableWidget(getNameMenu(MenuNames.OptionThreeGMenu), optionThreeGMenu);
            optionMenu.addAvailableWidget(getNameMenu(MenuNames.OptionAleMenu), optionAleMenu);

            optionMenu2.addAvailableWidget(getNameMenu(MenuNames.OptionMenuTest), optionMenuTest);
            optionMenu2.addAvailableWidget(getNameMenu(MenuNames.OptionExtAccMenu), optionExtAccMenu);
            optionMenu2.addAvailableWidget(getNameMenu(MenuNames.OptionMsgMenu), optionMsgMenu);

            optionMenuRadio.addAvailableWidget(getNameMenu(MenuNames.MainMenu), mainMenu);
            optionMenuRadio.addAvailableWidget(getNameMenu(MenuNames.KeyboardLock), keyBoardLock);

            optionThreeGMenu.addAvailableWidget(getNameMenu(MenuNames.OptionThreeG2Menu), optionThreeG2Menu);

            keyBoardLock.addAvailableWidget(getNameMenu(MenuNames.MainMenu), mainMenu);

            optionMenuTest.addAvailableWidget(getNameMenu(MenuNames.OptionTestBitMenu), optionTestBitMenu);
            optionMenuTest.addAvailableWidget(getNameMenu(MenuNames.OptionTestBatteryMenu), optionTestBatteryMenu);
            optionMenuTest.addAvailableWidget(getNameMenu(MenuNames.OptionTestTempMenu), optionTestTempMenu);
            optionMenuTest.addAvailableWidget(getNameMenu(MenuNames.OptionTestSpecialMenu), optionTestSpecialMenu);

            optionTestSpecialMenu.addAvailableWidget(getNameMenu(MenuNames.OptionTestSpecialVersionMenu), optionTestSpecialVersionMenu);
            optionTestSpecialMenu.addAvailableWidget(getNameMenu(MenuNames.OptionTestSpecialConfigMenu), optionTestSpecialConfigMenu);

            optionMsgMenu.addAvailableWidget(getNameMenu(MenuNames.OptionMsgSmsMenu), optionMsgSmsMenu);

            optionMsgSmsMenu.addAvailableWidget(getNameMenu(MenuNames.OptionMsgSmsFunctionsMenu), optionMsgSmsFunctionsMenu);

            optionMsgSmsFunctionsMenu.addAvailableWidget(getNameMenu(MenuNames.OptionMsgEnterSmsMenu), optionMsgEnterSmsMenu);

            optionMsgEnterSmsMenu.addAvailableWidget(getNameMenu(MenuNames.OptionMsgSmsSendingMenu), optionMsgSmsSendingMenu);

            optionAleMenu.addAvailableWidget(getNameMenu(MenuNames.OptionAleLqaMenu), optionAleLqaMenu);

            optionAleLqaMenu.addAvailableWidget(getNameMenu(MenuNames.OptionAleLqaExchangeMenu), optionAleLqaExchangeMenu);

            widgetContainer.Add(getNameMenu(MenuNames.MainMenu), mainMenu);
            widgetContainer.Add(getNameMenu(MenuNames.OptionMsgEnterSmsMenu), optionMsgEnterSmsMenu);

            return mainMenu;
        }

        static public Widget initMainMenu(RadioStation station)
        {
            Widget mainMenu = new Widget(Enum.GetName(typeof(MenuNames), MenuNames.MainMenu));
            mainMenu.LineSize[0] = 6;
            mainMenu.LineSize[1] = 8;
            mainMenu.LineSize[2] = 8;
            mainMenu.LineSize[3] = 6;
            mainMenu.LineCharOffset[1] = 6;
            mainMenu.LineCharOffset[2] = 4;

            mainMenu.addParam(new Param("Body", null, "", 1, 0))
                .addModesForParam("Body", new List<RadioStationMode> { RadioStationMode.ThreeG, RadioStationMode.ALE, RadioStationMode.HOP });
            mainMenu.addParam(new Param("StationRTmode", null, "R", 1, 0))
                .addModesForParam("StationRTmode", new List<RadioStationMode> { RadioStationMode.ThreeG, RadioStationMode.ALE, RadioStationMode.HOP });
            mainMenu.addParam(new Param("Battery", null, "BAT ■■■■■", 1, 2))
                .addModesForParam("Battery", new List<RadioStationMode> { RadioStationMode.ThreeG, RadioStationMode.ALE, RadioStationMode.HOP });
            mainMenu
                .addParam(new Param("StationMode", null, "FIX", 1, 10, () =>
                {
                    mainMenu.getParam("StationMode").Text = Enum.GetName(typeof(RadioStationMode), station.Mode);
                }))
                .addModesForParam("StationMode", new List<RadioStationMode> { RadioStationMode.ThreeG, RadioStationMode.ALE, RadioStationMode.HOP }); ;
            mainMenu
                .addParam(new Param("SQ", null, "SQ", 1, 14))
                .addModesForParam("SQ", new List<RadioStationMode> { RadioStationMode.ThreeG, RadioStationMode.ALE, RadioStationMode.HOP }); ;
            mainMenu
                .addParam(new Param("SwitchState", null, "PT", 1, 17, () =>
                {
                    mainMenu.getParam("SwitchState").Text = Enum.GetName(typeof(SwitcherState), station.getState());
                }))
                .addModesForParam("SwitchState", new List<RadioStationMode> { RadioStationMode.ThreeG, RadioStationMode.ALE, RadioStationMode.HOP });
            mainMenu
                .addParam(new Param("SwitchStateChan", null, "S 3 6 9 *", 1, 32))
                .addModesForParam("SwitchStateChan", new List<RadioStationMode> { RadioStationMode.ThreeG, RadioStationMode.ALE, RadioStationMode.HOP });

            mainMenu.addParam(new Param("Manual", null, "MANUAL", 2, 0))
                .addModesForParam("Manual", new List<RadioStationMode> { RadioStationMode.ALE, RadioStationMode.HOP });
            mainMenu.addParam(new Param("UpdateSignal", null, "⟲▮▮▮▯", 2, 23))
                .addModesForParam("UpdateSignal", new List<RadioStationMode> { RadioStationMode.ALE, RadioStationMode.HOP });

            mainMenu
                .addParam(new Param("DataValue", (string text, Param cParam) =>
            {

            }, "OFF", 3, 0))
                .addModesForParam("DataValue", new List<RadioStationMode> { RadioStationMode.ALE, RadioStationMode.HOP }); ;
            mainMenu
                .addParam(new Param("VoiceValue", (string text, Param cParam) =>
            {
                cParam.Text = text;
            }, "CLR", 3, 9))
                .addModesForParam("VoiceValue", new List<RadioStationMode> { RadioStationMode.ALE, RadioStationMode.HOP }); ;
            mainMenu
                .addParam(new Param("KeyValue", null, "▬▬▬▬▬", 3, 15))
                .addModesForParam("KeyValue", new List<RadioStationMode> { RadioStationMode.ALE, RadioStationMode.HOP }); ;
            mainMenu
                .addParam(new Param("ChanValue", (string text, Param cParam) =>
            {
                cParam.text = cParam.Text.Remove(cParam.ActiveFrom, cParam.ActiveTo);
                cParam.text = cParam.Text.Insert(cParam.ActiveFrom, text);

            }, "003", 3, 23))
                .addModesForParam("ChanValue", new List<RadioStationMode> { RadioStationMode.ALE, RadioStationMode.HOP }); ;

            mainMenu.addParam(new Param("Data", null, "DATA", 4, 0))
                .addModesForParam("Data", new List<RadioStationMode> { RadioStationMode.ALE, RadioStationMode.HOP }); ;
            mainMenu.addParam(new Param("Voice", null, "VOICE", 4, 12))
                .addModesForParam("Voice", new List<RadioStationMode> { RadioStationMode.ALE, RadioStationMode.HOP }); ;
            mainMenu.addParam(new Param("Key", null, "KEY", 4, 24))
                .addModesForParam("Key", new List<RadioStationMode> { RadioStationMode.ALE, RadioStationMode.HOP }); ;
            mainMenu.addParam(new Param("Chan", null, "CHAN", 4, 35))
                .addModesForParam("Chan", new List<RadioStationMode> { RadioStationMode.ALE, RadioStationMode.HOP }); ;

            mainMenu.addActionToParam(mainMenu.getParam("SQ"), new Button("SQL", (Button btn, RadioStation rs, Widget wdg) =>
            {
                if (wdg.activeParam() != null)
                {
                    return;
                }

                var param = wdg.getParam("SQ");
                if (param.Text == "SQ")
                {
                    param.Text = "  ";
                }
                else
                {
                    param.Text = "SQ";
                }
            }));
            mainMenu.addActionToParam(mainMenu.getParam("ChanValue"), new Button("LEFT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();

                if (activeParam == null)
                {
                    var param = wdg.getParam("ChanValue");
                    wdg.deactiveParam();
                    param.IsActive = true;
                    return;
                }

                if (activeParam.isInParam())
                {
                    if (activeParam.ActiveFrom == 0)
                    {
                        activeParam.ActiveFrom = 2;
                        activeParam.ActiveTo = 1;
                    }
                    else
                    {
                        activeParam.ActiveFrom -= 1;
                        activeParam.ActiveTo = 1;
                    }
                    return;
                }

                switch (activeParam.Name)
                {
                    case "ChanValue":
                        {
                            var param = wdg.getParam("KeyValue");
                            wdg.deactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "KeyValue":
                        {
                            var param = wdg.getParam("VoiceValue");
                            wdg.deactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "VoiceValue":
                        {
                            var param = wdg.getParam("DataValue");
                            wdg.deactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "DataValue":
                        {
                            var param = wdg.getParam("ChanValue");
                            wdg.deactiveParam();
                            param.IsActive = true;
                            break;
                        }
                }

            }));
            mainMenu.addActionToParam(mainMenu.getParam("ChanValue"), new Button("RIGTH", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();

                if (activeParam == null)
                {
                    var param = wdg.getParam("ChanValue");
                    wdg.deactiveParam();
                    param.IsActive = true;
                    return;
                }

                if (activeParam.isInParam())
                {
                    if (activeParam.ActiveFrom == 2)
                    {
                        activeParam.ActiveFrom = 0;
                        activeParam.ActiveTo = 1;
                    }
                    else
                    {
                        activeParam.ActiveFrom += 1;
                        activeParam.ActiveTo = 1;
                    }
                    return;
                }

                switch (activeParam.Name)
                {
                    case "ChanValue":
                        {

                            var param = wdg.getParam("DataValue");
                            wdg.deactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "KeyValue":
                        {

                            var param = wdg.getParam("ChanValue");
                            wdg.deactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "VoiceValue":
                        {

                            var param = wdg.getParam("KeyValue");
                            wdg.deactiveParam();
                            param.IsActive = true;

                            break;
                        }
                    case "DataValue":
                        {
                            var param = wdg.getParam("VoiceValue");
                            wdg.deactiveParam();
                            param.IsActive = true;

                            break;
                        }
                }

            }));
            mainMenu.addActionToParam(mainMenu.getParam("ChanValue"), new Button("CALL", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();

                if (activeParam == null
                    || activeParam.Name != "ChanValue")
                {
                    return;
                }

                if (!activeParam.isInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }

                activeParam.action("1");

            }));
            mainMenu.addActionToParam(mainMenu.getParam("ChanValue"), new Button("LT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();

                if (activeParam == null
                    || activeParam.Name != "ChanValue")
                {
                    return;
                }

                if (!activeParam.isInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }

                activeParam.action("2");

            }));
            mainMenu.addActionToParam(mainMenu.getParam("ChanValue"), new Button("MODE", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();

                if (activeParam == null
                    || activeParam.Name != "ChanValue")
                {
                    return;
                }

                if (!activeParam.isInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }

                activeParam.action("3");

            }));
            mainMenu.addActionToParam(mainMenu.getParam("ChanValue"), new Button("SQL", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();

                if (activeParam == null
                    || activeParam.Name != "ChanValue")
                {
                    return;
                }

                if (!activeParam.isInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }

                activeParam.action("4");

            }));
            mainMenu.addActionToParam(mainMenu.getParam("ChanValue"), new Button("ZERO", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();

                if (activeParam == null
                    || activeParam.Name != "ChanValue")
                {
                    return;
                }

                if (!activeParam.isInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }

                activeParam.action("5");

            }));
            mainMenu.addActionToParam(mainMenu.getParam("ChanValue"), new Button("UP", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();

                if (activeParam == null
                    || activeParam.Name != "ChanValue")
                {
                    return;
                }

                if (!activeParam.isInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }

                activeParam.action("6");

            }));
            mainMenu.addActionToParam(mainMenu.getParam("ChanValue"), new Button("OPT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();

                if (activeParam == null
                    || activeParam.Name != "ChanValue")
                {
                    return;
                }

                if (!activeParam.isInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }

                activeParam.action("7");

            }));
            mainMenu.addActionToParam(mainMenu.getParam("ChanValue"), new Button("PGM", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();

                if (activeParam == null
                    || activeParam.Name != "ChanValue")
                {
                    return;
                }

                if (!activeParam.isInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }

                activeParam.action("8");

            }));
            mainMenu.addActionToParam(mainMenu.getParam("ChanValue"), new Button("DOWN", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();

                if (activeParam == null
                    || activeParam.Name != "ChanValue")
                {
                    return;
                }

                if (!activeParam.isInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }

                activeParam.action("9");

            }));
            mainMenu.addActionToParam(mainMenu.getParam("ChanValue"), new Button("UPDATE", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();

                if (activeParam == null
                    || activeParam.Name != "ChanValue")
                {
                    return;
                }

                if (!activeParam.isInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }

                activeParam.action("0");

            }));
            mainMenu.addActionToParam(mainMenu.getParam("VoiceValue"), new Button("UP", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();

                if (activeParam == null
                    || activeParam.Name != "VoiceValue")
                {
                    return;
                }

                Dictionary<string, int> values = new Dictionary<string, int>(){
                    { "CLR", 0 },
                    { "NONE", 1 },
                    { "LDV",  2 },
                    { "ME24", 3 },
                    { "ME12", 4 },
                    { "ME6", 5 },
                    { "DV24", 6 },
                    { "DV6", 7 },
                    { "AVS", 8 },
                    { "CVSD", 9 }
                };

                Dictionary<int, string> values_num = new Dictionary<int, string>(){
                    { 0, "CLR" },
                    { 1, "NONE" },
                    { 2, "LDV" },
                    { 3 ,"ME24"},
                    { 4, "ME12"},
                    { 5, "ME6"},
                    { 6, "DV24"},
                    { 7, "DV6"},
                    { 8, "AVS"},
                    { 9, "CVSD" }
                };

                int index = values[activeParam.Text];
                string text;
                if (index >= 9)
                {
                    text = values_num[0];
                }
                else
                {
                    text = values_num[index + 1];
                }
                activeParam.action(text);
                activeParam.ActiveTo = text.Length;
            }));
            mainMenu.addActionToParam(mainMenu.getParam("VoiceValue"), new Button("DOWN", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();

                if (activeParam == null
                    || activeParam.Name != "VoiceValue")
                {
                    return;
                }

                Dictionary<string, int> values = new Dictionary<string, int>(){
                    { "CLR", 0 },
                    { "NONE", 1 },
                    { "LDV",  2 },
                    { "ME24", 3 },
                    { "ME12", 4 },
                    { "ME6", 5 },
                    { "DV24", 6 },
                    { "DV6", 7 },
                    { "AVS", 8 },
                    { "CVSD", 9 }
                };

                Dictionary<int, string> values_num = new Dictionary<int, string>(){
                    { 0, "CLR" },
                    { 1, "NONE" },
                    { 2, "LDV" },
                    { 3 ,"ME24"},
                    { 4, "ME12"},
                    { 5, "ME6"},
                    { 6, "DV24"},
                    { 7, "DV6"},
                    { 8, "AVS"},
                    { 9, "CVSD" }
                };

                int index = values[activeParam.Text];
                string text;
                if (index <= 0)
                {
                    text = values_num[9];
                }
                else
                {
                    text = values_num[index - 1];
                }
                activeParam.action(text);
                activeParam.ActiveTo = text.Length;
            }));
            mainMenu.addActionToParam(mainMenu.getParam("Chan"), new Button("CLR", (Button btn, RadioStation rs, Widget wdg) =>
            {
                wdg.deactiveParam();
            }));

            mainMenu.addActionToParam(mainMenu.getParam("Body"), new Button("PGM", (Button btn, RadioStation rs, Widget wdg) =>
            {
                if (mainMenu.activeParam() != null)
                {
                    return;
                }

                wdg.prepareToShowWidget(Enum.GetName(typeof(MenuNames), MenuNames.TransitionProgramMenu));

                Form1.timerAction = () =>
                {
                    Widget trans = wdg.getAvailableWidget(getNameMenu(MenuNames.TransitionProgramMenu));
                    trans.prepareToShowWidget(getNameMenu(MenuNames.ProgramMenu));
                    trans.getAvailableWidget(getNameMenu(MenuNames.ProgramMenu)).comeFrom = wdg;
                };
                Form1.startTimer();
            }));
            mainMenu.addActionToParam(mainMenu.getParam("Body"), new Button("OPT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                if (mainMenu.activeParam() != null)
                {
                    return;
                }

                wdg.prepareToShowWidget(Enum.GetName(typeof(MenuNames), MenuNames.OptionMenu));
            }));
            mainMenu.addActionToParam(mainMenu.getParam("StationMode"), new Button("MODE", (Button btn, RadioStation rs, Widget wdg) =>
            {
                if (mainMenu.activeParam() != null)
                {
                    return;
                }

                wdg.prepareToShowWidget(getNameMenu(MenuNames.SelectModeMenu));
            }));
            mainMenu.addActionToParam(mainMenu.getParam("Body"), new Button("PRE_PLUS", (Button btn, RadioStation rs, Widget wdg) =>
            {
                if (mainMenu.activeParam() != null)
                {
                    return;
                }

                var next = station.PresetSystemsModule.nextPreset();

                var chan = mainMenu.getParam("Chan");
                chan.Text = next.channelNumber;

                var voice = mainMenu.getParam("VoiceValue");
                voice.Text = next.ctVoiceMode;

                var mode = mainMenu.getParam("StationMode");
                mode.Text = RadioStation.modeToString(next.radioMode);

                var name = mainMenu.getParam("Manual");
                name.Text = next.name;
                
            }));
            mainMenu.addActionToParam(mainMenu.getParam("Body"), new Button("LT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                if (mainMenu.activeParam() != null)
                {
                    return;
                }

                mainMenu.prepareToShowWidget(getNameMenu(MenuNames.MainMenuDisplayOpt));

            }));

            mainMenu.addActionToParam(mainMenu.getParam("Body"), new Button("PRE_PLUS", (Button btn, RadioStation rs, Widget wdg) =>
            {
                if (mainMenu.activeParam() != null)
                {
                    return;
                }

                var next = station.PresetSystemsModule.prevPreset();

                var chan = mainMenu.getParam("Chan");
                chan.Text = next.channelNumber;

                var voice = mainMenu.getParam("VoiceValue");
                voice.Text = next.ctVoiceMode;

                var mode = mainMenu.getParam("StationMode");
                mode.Text = RadioStation.modeToString(next.radioMode);

                var name = mainMenu.getParam("Manual");
                name.Text = next.name;

            }));
            //3G mode

            mainMenu.addParam(new Param("3GTitle", null, "INCOMPLETE 3G FILL", 2, 6), false).addModeForParam("3GTitle", RadioStationMode.ThreeG);


            mainMenu.addParam(new Param("RebuildByStationMode", null, "", 1, 0, () =>
            {
                var modeParams = mainMenu.getParamByMode(station.Mode);

                mainMenu.invisibleAllParams();
                mainMenu.visibleParamsByNode(station.Mode);
            }));

            return mainMenu;
        }
        static public Widget initMainMenuDisplayOpt(RadioStation station)
        {
            Widget programMenu = new Widget(getNameMenu(MenuNames.MainMenuDisplayOpt));
            programMenu.LineSize[0] = 5;
            programMenu.LineSize[1] = 10;
            programMenu.LineSize[2] = 11;
            programMenu.LineSize[3] = 10;
            programMenu.LineCharOffset[0] = 6;
            programMenu.LineCharOffset[1] = 6;
            programMenu.LineCharOffset[2] = 6;

            programMenu.addParam(new Param("Body", null, "", 1, 0));
            programMenu.addParam(new Param("StationRTmode", null, "R", 1, 0))
                .addModesForParam("StationRTmode", new List<RadioStationMode> { RadioStationMode.ThreeG, RadioStationMode.ALE, RadioStationMode.HOP });
            programMenu.addParam(new Param("Battery", null, "BAT ■■■■■", 1, 2))
                .addModesForParam("Battery", new List<RadioStationMode> { RadioStationMode.ThreeG, RadioStationMode.ALE, RadioStationMode.HOP });
            programMenu
                .addParam(new Param("StationMode", null, "FIX", 1, 10, () =>
                {
                    programMenu.getParam("StationMode").Text = Enum.GetName(typeof(RadioStationMode), station.Mode);
                }))
                .addModesForParam("StationMode", new List<RadioStationMode> { RadioStationMode.ThreeG, RadioStationMode.ALE, RadioStationMode.HOP }); ;
            programMenu
                .addParam(new Param("SQ", null, "SQ", 1, 14))
                .addModesForParam("SQ", new List<RadioStationMode> { RadioStationMode.ThreeG, RadioStationMode.ALE, RadioStationMode.HOP }); ;
            programMenu
                .addParam(new Param("SwitchState", null, "PT", 1, 17, () =>
                {
                    programMenu.getParam("SwitchState").Text = Enum.GetName(typeof(SwitcherState), station.getState());
                }))
                .addModesForParam("SwitchState", new List<RadioStationMode> { RadioStationMode.ThreeG, RadioStationMode.ALE, RadioStationMode.HOP });
            programMenu.addParam(new Param("BrightTitle", null, "BRIGHT", 2, 1));
            programMenu.addParam(new Param("ContrastTitle", null, "CONTRAST", 2, 16));
            programMenu.addParam(new Param("BrightValue", null, "7", 3, 3));
            programMenu.addParam(new Param("ContrastValue", null, "100%", 3, 17));
            programMenu.getParam("BrightValue").IsActive = true;
            programMenu.addActionToParam(programMenu.getParam("Body"), new Button("CLR", (Button btn, RadioStation rs, Widget wdg) =>
            {
                wdg.showPreviousWidget();
            }));
            programMenu.addActionToParam(programMenu.getParam("Body"), new Button("LEFT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();

                if (activeParam == null)
                {
                    var param = wdg.getParam("ContrastValue");
                    wdg.deactiveParam();
                    param.IsActive = true;
                    return;
                }

                switch (activeParam.Name)
                {
                    case "BrightValue":
                        {
                            var param = wdg.getParam("ContrastValue");
                            wdg.deactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "ContrastValue":
                        {
                            var param = wdg.getParam("BrightValue");
                            wdg.deactiveParam();
                            param.IsActive = true;
                            break;
                        }
                }

            }));
            programMenu.addActionToParam(programMenu.getParam("Body"), new Button("RIGTH", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();

                if (activeParam == null)
                {
                    var param = wdg.getParam("BrightValue");
                    wdg.deactiveParam();
                    param.IsActive = true;
                    return;
                }

                switch (activeParam.Name)
                {
                    case "BrightValue":
                        {
                            var param = wdg.getParam("ContrastValue");
                            wdg.deactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "ContrastValue":
                        {
                            var param = wdg.getParam("BrightValue");
                            wdg.deactiveParam();
                            param.IsActive = true;
                            break;
                        }
                }


            }));

            programMenu.addActionToParam(programMenu.getParam("Body"), new Button("UP", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();

                switch (activeParam.Name)
                {
                    case "BrightValue":
                        {
                            int value = int.Parse(activeParam.Text);
                            value++;
                            if (value > 7)
                            {
                                value = 1;
                            }
                            Form1.currObject.setBrigth(value);
                            activeParam.Text = value.ToString();
                            break;
                        }
                    case "ContrastValue":
                        {
                            int value = int.Parse(activeParam.Text.Replace("%",""));
                            value += 10;
                            if (value > 100)
                            {
                                value = 20;
                            }
                            Form1.currObject.setContrast(value);
                            activeParam.Text = value.ToString() + "%";
                            break;
                        }
                }
            }));

            programMenu.addActionToParam(programMenu.getParam("Body"), new Button("DOWN", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();

                switch (activeParam.Name)
                {
                    case "BrightValue":
                        {
                            int value = int.Parse(activeParam.Text);
                            value--;
                            if (value < 1)
                            {
                                value = 7;
                            }
                            Form1.currObject.setBrigth(value);
                            activeParam.Text = value.ToString();
                            break;
                        }
                    case "ContrastValue":
                        {
                            int value = int.Parse(activeParam.Text.Replace("%", ""));
                            value -= 10;
                            if (value < 20)
                            {
                                value = 100;
                            }
                            Form1.currObject.setContrast(value);
                            activeParam.Text = value.ToString() + "%";
                            break;
                        }
                }


            }));
            return programMenu;
        }
        static public Widget initProgramMenu(RadioStation station)
        {
            Widget programMenu = new Widget(getNameMenu(MenuNames.ProgramMenu));
            programMenu.LineSize[0] = 5;
            programMenu.LineSize[1] = 5;
            programMenu.LineSize[2] = 9;
            programMenu.LineSize[3] = 9;
            programMenu.LineCharOffset[1] = 6;
            programMenu.LineCharOffset[2] = 6;

            programMenu.addParam(new Param("Body", null, "", 1, 0));
            programMenu.addParam(new Param("Title", null, "PGM", 1, 0));
            programMenu.addParam(new Param("EmptyLine", null, "             ", 2, 0));
            programMenu.addParam(new Param("Comsec", null, "COMSEC", 3, 0));
            programMenu.addParam(new Param("Config", null, "CONFIG", 3, 13));
            programMenu.addParam(new Param("Mode", null, "MODE", 3, 22));
            programMenu.addParam(new Param("Maintenance", null, "MAINTENANCE", 4, 0));
            programMenu.addParam(new Param("NextPage", null, "->", 4, 24));
            programMenu.getParam("Comsec").IsActive = true;
            programMenu.addActionToParam(programMenu.getParam("Body"), new Button("CLR", (Button btn, RadioStation rs, Widget wdg) =>
            {
                wdg.showPreviousWidget();
            }));
            programMenu.addActionToParam(programMenu.getParam("Body"), new Button("LEFT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();

                if (activeParam == null)
                {
                    var param = wdg.getParam("Maintenance");
                    wdg.deactiveParam();
                    param.IsActive = true;
                    return;
                }

                switch (activeParam.Name)
                {
                    case "Comsec":
                        {
                            wdg.deactiveParam();
                            wdg.prepareToShowWidget(Enum.GetName(typeof(MenuNames), MenuNames.ProgramMenu2));
                            wdg.getAvailableWidget(getNameMenu(MenuNames.ProgramMenu2)).getParam("Sched").IsActive = true;
                            break;
                        }
                    case "Config":
                        {
                            var param = wdg.getParam("Comsec");
                            wdg.deactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Mode":
                        {
                            var param = wdg.getParam("Config");
                            wdg.deactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Maintenance":
                        {
                            var param = wdg.getParam("Mode");
                            wdg.deactiveParam();
                            param.IsActive = true;
                            break;
                        }
                }

            }));
            programMenu.addActionToParam(programMenu.getParam("Body"), new Button("RIGTH", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();

                if (activeParam == null)
                {
                    var param = wdg.getParam("Comsec");
                    wdg.deactiveParam();
                    param.IsActive = true;
                    return;
                }

                switch (activeParam.Name)
                {
                    case "Comsec":
                        {
                            var param = wdg.getParam("Config");
                            wdg.deactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Config":
                        {
                            var param = wdg.getParam("Mode");
                            wdg.deactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Mode":
                        {
                            var param = wdg.getParam("Maintenance");
                            wdg.deactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Maintenance":
                        {
                            wdg.deactiveParam();
                            wdg.prepareToShowWidget(Enum.GetName(typeof(MenuNames), MenuNames.ProgramMenu2));
                            wdg.getAvailableWidget(getNameMenu(MenuNames.ProgramMenu2)).getParam("Install").IsActive = true;
                            break;
                        }
                }

            }));
            programMenu.addActionToParam(programMenu.getParam("Comsec"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();

                if (activeParam == null || activeParam.Name != "Comsec")
                {
                    return;
                }

                wdg.prepareToShowWidget(getNameMenu(MenuNames.ProgramComsecMenu));

            }));
            programMenu.addActionToParam(programMenu.getParam("Mode"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();

                if (activeParam == null || activeParam.Name != "Mode")
                {
                    return;
                }

                wdg.prepareToShowWidget(getNameMenu(MenuNames.ProgramModeMenu));

            }));
            return programMenu;
        }
        static public Widget initTransitionProgramMenu(RadioStation station)
        {
            Widget transition = new Widget(getNameMenu(MenuNames.TransitionProgramMenu));
            transition.LineSize[0] = 8;
            transition.LineSize[1] = 8;
            transition.LineSize[2] = 8;
            transition.LineSize[3] = 8;
            transition.addParam(new Param("Body", null, "", 1, 0));
            transition.addParam(new Param("ActionEnter", null, "** ENTERING **", 2, 10));
            transition.addParam(new Param("Title", null, "PROGRAM MENU", 3, 10));
            transition.addParam(new Param("Description", null, "...WAIT...", 4, 13));
            return transition;
        }
        static public Widget initProgramMenu2(RadioStation station)
        {
            Widget programMenu = new Widget(getNameMenu(MenuNames.ProgramMenu2));
            programMenu.LineSize[0] = 5;
            programMenu.LineSize[1] = 9;
            programMenu.LineSize[2] = 9;
            programMenu.LineSize[3] = 9;
            programMenu.addParam(new Param("Body", null, "", 1, 0));
            programMenu.addParam(new Param("Title", null, "PGM", 1, 0));
            programMenu.addParam(new Param("EmptyLine", null, "", 2, 0));
            programMenu.addParam(new Param("PreviousPage", null, "<-", 3, 0));
            programMenu.addParam(new Param("Install", null, "INSTALL", 3, 4));
            programMenu.addParam(new Param("Sched", null, "SCHED", 3, 15));
            programMenu.getParam("Install").IsActive = true;

            programMenu.addActionToParam(programMenu.getParam("Body"), new Button("LEFT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();

                if (activeParam == null)
                {
                    var param = wdg.getParam("Sched");
                    wdg.deactiveParam();
                    param.IsActive = true;
                    return;
                }

                switch (activeParam.Name)
                {
                    case "Install":
                        {
                            wdg.deactiveParam();
                            wdg.showPreviousWidget().getParam("Maintenance").IsActive = true;
                            break;
                        }
                    case "Sched":
                        {
                            var param = wdg.getParam("Install");
                            wdg.deactiveParam();
                            param.IsActive = true;
                            break;
                        }
                }

            }));
            programMenu.addActionToParam(programMenu.getParam("Body"), new Button("RIGTH", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();

                if (activeParam == null)
                {
                    var param = wdg.getParam("Install");
                    wdg.deactiveParam();
                    param.IsActive = true;
                    return;
                }

                switch (activeParam.Name)
                {
                    case "Install":
                        {
                            var param = wdg.getParam("Sched");
                            wdg.deactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Sched":
                        {
                            wdg.deactiveParam();
                            wdg.showPreviousWidget().getParam("Comsec").IsActive = true;
                            break;
                        }
                }

            }));
            return programMenu;
        }

        static public Widget initOptionMenu(RadioStation station)
        {
            Widget optionMenu = new Widget(getNameMenu(MenuNames.OptionMenu));
            optionMenu.LineSize[0] = 5;
            optionMenu.LineSize[1] = 9;
            optionMenu.LineSize[2] = 9;
            optionMenu.LineSize[3] = 9;
            optionMenu
                .addParam(new Param("Body", null, "", 1, 0))
                .addModesForParam("Body", new List<RadioStationMode> { RadioStationMode.ThreeG, RadioStationMode.ALE, RadioStationMode.HOP });
            optionMenu.addParam(new Param("Title", null, "OPTIONS", 1, 0))
                .addModesForParam("Title", new List<RadioStationMode> { RadioStationMode.ThreeG, RadioStationMode.ALE, RadioStationMode.HOP });
            optionMenu.addParam(new Param("EmptyLine", null, " ", 2, 0))
                .addModesForParam("EmptyLine", new List<RadioStationMode> { RadioStationMode.ThreeG, RadioStationMode.ALE, RadioStationMode.HOP });
            optionMenu.addParam(new Param("GPS-tod", null, "GPS-TOD", 3, 0))
                .addModesForParam("GPS-tod", new List<RadioStationMode> { RadioStationMode.ThreeG, RadioStationMode.ALE, RadioStationMode.HOP });
            optionMenu.addParam(new Param("Retune", null, "RETUNE", 3, 10))
                .addModesForParam("Retune", new List<RadioStationMode> { RadioStationMode.ThreeG, RadioStationMode.ALE, RadioStationMode.HOP });
            optionMenu.addParam(new Param("Radio", null, "RADIO", 3, 20))
                .addModesForParam("Radio", new List<RadioStationMode> { RadioStationMode.ThreeG, RadioStationMode.ALE, RadioStationMode.HOP });
            optionMenu.addParam(new Param("Scan", null, "SCAN", 4, 0));
            optionMenu.addParam(new Param("GPS-apr", null, "GPS-APR", 4, 10))
                .addModesForParam("GPS-apr", new List<RadioStationMode> { RadioStationMode.ThreeG, RadioStationMode.ALE, RadioStationMode.HOP });
            optionMenu.addParam(new Param("NextPage", null, "->", 4, 22))
                .addModesForParam("NextPage", new List<RadioStationMode> { RadioStationMode.ThreeG, RadioStationMode.ALE, RadioStationMode.HOP });
            optionMenu.addParam(new Param("3G", null, "3G", 4, 0), false)
                .addModesForParam("3G", new List<RadioStationMode> { RadioStationMode.ThreeG });
            optionMenu.addParam(new Param("Ale", null, "ALE", 4, 0), false)
                .addModesForParam("Ale", new List<RadioStationMode> { RadioStationMode.ALE });

            optionMenu.addParam(new Param("RebuildByStationMode", null, "", 1, 0, () =>
            {
                var modeParams = optionMenu.getParamByMode(station.Mode);

                optionMenu.invisibleAllParams();
                optionMenu.visibleParamsByNode(station.Mode);
            }));

            optionMenu.getParam("GPS-tod").IsActive = true;

            optionMenu.addActionToParam(optionMenu.getParam("Body"), new Button("LEFT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();

                if (activeParam == null)
                {
                    var param = wdg.getParam("GPS-apr");
                    wdg.deactiveParam();
                    param.IsActive = true;
                    return;
                }

                switch (activeParam.Name)
                {
                    case "GPS-tod":
                        {
                            wdg.deactiveParam();
                            wdg.getAvailableWidget(getNameMenu(MenuNames.OptionMenu2)).getParam("Test").IsActive = true;
                            wdg.prepareToShowWidget(getNameMenu(MenuNames.OptionMenu2));
                            break;
                        }
                    case "Retune":
                        {
                            var param = wdg.getParam("GPS-tod");
                            wdg.deactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Radio":
                        {
                            var param = wdg.getParam("Retune");
                            wdg.deactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "3G":
                    case "Ale":
                    case "Scan":
                        {
                            var param = wdg.getParam("Radio");
                            wdg.deactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "GPS-apr":
                        {
                            wdg.deactiveParam();
                            if (wdg.getParam("Scan").IsVisible)
                            {
                                wdg.getParam("Scan").IsActive = true;
                            }
                            else if (wdg.getParam("3G").IsVisible)
                            {
                                wdg.getParam("3G").IsActive = true;
                            } 
                            else if (wdg.getParam("Ale").IsVisible)
                            {
                                wdg.getParam("Ale").IsActive = true;
                            } 
                            else if (wdg.getParam("Radio").IsVisible)
                            {
                                wdg.getParam("Radio").IsActive = true;
                            }
                            break;
                        }
                }

            }));
            optionMenu.addActionToParam(optionMenu.getParam("Body"), new Button("RIGTH", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();

                if (activeParam == null)
                {
                    var param = wdg.getParam("GPS-tod");
                    wdg.deactiveParam();
                    param.IsActive = true;
                    return;
                }

                switch (activeParam.Name)
                {
                    case "GPS-tod":
                        {
                            wdg.deactiveParam();
                            var param = wdg.getParam("Retune");
                            wdg.deactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Retune":
                        {
                            var param = wdg.getParam("Radio");
                            wdg.deactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Radio":
                        {
                            wdg.deactiveParam();
                            if (wdg.getParam("Scan").IsVisible)
                            {
                                wdg.getParam("Scan").IsActive = true;
                            }
                            else if (wdg.getParam("3G").IsVisible)
                            {
                                wdg.getParam("3G").IsActive = true;
                            }
                            else if (wdg.getParam("Ale").IsVisible)
                            {
                                wdg.getParam("Ale").IsActive = true;
                            }
                            else if (wdg.getParam("GPS-apr").IsVisible)
                            {
                                wdg.getParam("GPS-apr").IsActive = true;
                            }
                            break;
                        }
                    case "3G":
                    case "Ale":
                    case "Scan":
                        {
                            var param = wdg.getParam("GPS-apr");
                            wdg.deactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "GPS-apr":
                        {
                            wdg.deactiveParam();
                            wdg.prepareToShowWidget(getNameMenu(MenuNames.OptionMenu2));
                            wdg.getAvailableWidget(getNameMenu(MenuNames.OptionMenu2)).getParam("Ext-acc").IsActive = true;
                            break;
                        }
                }

            }));

            optionMenu.addActionToParam(optionMenu.getParam("Radio"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                Param activeParam = wdg.activeParam();
                if (activeParam == null || activeParam.Name != "Radio")
                {
                    return;
                }

                wdg.prepareToShowWidget(getNameMenu(MenuNames.OptionMenuRadio));
            }));
            optionMenu.addActionToParam(optionMenu.getParam("GPS-tod"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                Param activeParam = wdg.activeParam();
                if (activeParam == null || activeParam.Name != "GPS-tod")
                {
                    return;
                }

                wdg.prepareToShowWidget(getNameMenu(MenuNames.OptionGpsTodMenu));
            }));

            optionMenu.addActionToParam(optionMenu.getParam("Scan"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                Param activeParam = wdg.activeParam();
                if (activeParam == null || activeParam.Name != "Scan")
                {
                    return;
                }

                wdg.prepareToShowWidget(getNameMenu(MenuNames.OptionScanMenu));
            }));
            optionMenu.addActionToParam(optionMenu.getParam("3G"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                Param activeParam = wdg.activeParam();
                if (activeParam == null || activeParam.Name != "3G")
                {
                    return;
                }

                wdg.prepareToShowWidget(getNameMenu(MenuNames.OptionThreeGMenu));
            }));
            optionMenu.addActionToParam(optionMenu.getParam("Ale"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                Param activeParam = wdg.activeParam();
                if (activeParam == null || activeParam.Name != "Ale")
                {
                    return;
                }

                wdg.prepareToShowWidget(getNameMenu(MenuNames.OptionAleMenu));
            }));
            optionMenu.addActionToParam(optionMenu.getParam("Body"), new Button("CLR", (Button btn, RadioStation rs, Widget wdg) =>
            {
                wdg.showPreviousWidget();
            }));

            return optionMenu;
        }
        static public Widget initOptionMenu2(RadioStation station)
        {
            Widget optionMenu = new Widget(getNameMenu(MenuNames.OptionMenu2));

            optionMenu.LineSize[0] = 5;
            optionMenu.LineSize[1] = 9;
            optionMenu.LineSize[2] = 9;
            optionMenu.LineSize[3] = 9;
            optionMenu.addParam(new Param("Body", null, "", 1, 0))
                .addModesForParam("Body", new List<RadioStationMode> { RadioStationMode.ThreeG, RadioStationMode.ALE, RadioStationMode.HOP });
            optionMenu.addParam(new Param("Title", null, "OPTIONS", 1, 0))
                .addModesForParam("Title", new List<RadioStationMode> { RadioStationMode.ThreeG, RadioStationMode.ALE, RadioStationMode.HOP });
            optionMenu.addParam(new Param("EmptyLine", null, " ", 2, 0))
                .addModesForParam("EmptyLine", new List<RadioStationMode> { RadioStationMode.ThreeG, RadioStationMode.ALE, RadioStationMode.HOP });
            optionMenu.addParam(new Param("NextPage", null, "<-", 3, 0))
                .addModesForParam("NextPage", new List<RadioStationMode> { RadioStationMode.ThreeG, RadioStationMode.ALE, RadioStationMode.HOP });
            optionMenu.addParam(new Param("Ext-acc", null, "EXT-ACC", 3, 10))
                .addModesForParam("Ext-acc", new List<RadioStationMode> { RadioStationMode.ThreeG, RadioStationMode.ALE, RadioStationMode.HOP });
            optionMenu.addParam(new Param("Test", null, "TEST", 3, 20))
                .addModesForParam("Test", new List<RadioStationMode> { RadioStationMode.ThreeG, RadioStationMode.ALE, RadioStationMode.HOP });
            optionMenu.addParam(new Param("Msg", null, "MSG", 3, 20), false)
                .addModesForParam("Msg", new List<RadioStationMode> { RadioStationMode.ThreeG });

            optionMenu.getParam("Ext-acc").IsActive = true;

            optionMenu.addActionToParam(optionMenu.getParam("Body"), new Button("LEFT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();

                if (activeParam == null)
                {
                    var param = wdg.getParam("Test");
                    wdg.deactiveParam();
                    param.IsActive = true;
                    return;
                }

                switch (activeParam.Name)
                {
                    case "Ext-acc":
                        {
                            wdg.deactiveParam();
                            wdg.showPreviousWidget().getParam("GPS-apr").IsActive = true;
                            break;
                        }
                    case "Msg":
                        {
                            var param = wdg.getParam("Ext-acc");
                            wdg.deactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Test":
                        {
                            wdg.deactiveParam();
                            if (wdg.getParam("Msg").IsVisible)
                            {
                                wdg.getParam("Msg").IsActive = true;
                            }
                            else if (wdg.getParam("Ext-acc").IsVisible)
                            {
                                wdg.getParam("Ext-acc").IsActive = true;
                            }
                            break;
                        }
                }

            }));
            optionMenu.addActionToParam(optionMenu.getParam("Body"), new Button("RIGTH", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();

                if (activeParam == null)
                {
                    var param = wdg.getParam("Ext-acc");
                    wdg.deactiveParam();
                    param.IsActive = true;
                    return;
                }

                switch (activeParam.Name)
                {
                    case "Ext-acc":
                        {
                            wdg.deactiveParam();
                            if (wdg.getParam("Msg").IsVisible)
                            {
                                wdg.getParam("Msg").IsActive = true;
                            }
                            else if (wdg.getParam("Test").IsVisible)
                            {
                                wdg.getParam("Test").IsActive = true;
                            }
                            break;
                        }
                    case "Msg":
                        {
                            var param = wdg.getParam("Test");
                            wdg.deactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Test":
                        {
                            wdg.deactiveParam();
                            wdg.showPreviousWidget().getParam("GPS-tod").IsActive = true;
                            break;
                        }
                }

            }));
            optionMenu.addActionToParam(optionMenu.getParam("Test"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();

                if (activeParam == null || activeParam.Name != "Test")
                {
                    return;
                }

                wdg.prepareToShowWidget(getNameMenu(MenuNames.OptionMenuTest));
            }));

            optionMenu.addActionToParam(optionMenu.getParam("Ext-acc"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                Param activeParam = wdg.activeParam();
                if (activeParam == null || activeParam.Name != "Ext-acc")
                {
                    return;
                }

                wdg.prepareToShowWidget(getNameMenu(MenuNames.OptionExtAccMenu));
            }));
            optionMenu.addActionToParam(optionMenu.getParam("Msg"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                Param activeParam = wdg.activeParam();
                if (activeParam == null || activeParam.Name != "Msg")
                {
                    return;
                }

                wdg.prepareToShowWidget(getNameMenu(MenuNames.OptionMsgMenu));
            }));
            optionMenu.addParam(new Param("RebuildByStationMode", null, "", 1, 0, () =>
            {
                var modeParams = optionMenu.getParamByMode(station.Mode);

                optionMenu.invisibleAllParams();
                optionMenu.visibleParamsByNode(station.Mode);

                if (station.Mode == RadioStationMode.ThreeG)
                {
                    optionMenu.getParam("Test").X = 4;
                    optionMenu.getParam("Test").Y = 0;
                }
                if (station.Mode == RadioStationMode.FIX)
                {
                    optionMenu.getParam("Test").X = 3;
                    optionMenu.getParam("Test").Y = 20;
                }
            }));
            return optionMenu;
        }

        static public Widget initOptionMenuTest(RadioStation station)
        {
            Widget optionMenu = new Widget(getNameMenu(MenuNames.OptionMenu2));

            optionMenu.LineSize[0] = 5;
            optionMenu.LineSize[1] = 9;
            optionMenu.LineSize[2] = 9;
            optionMenu.LineSize[3] = 9;
            optionMenu.addParam(new Param("Body", null, "", 1, 0));
            optionMenu.addParam(new Param("Title", null, "OPTIONS-TEST", 1, 0));
            optionMenu.addParam(new Param("EmptyLine", null, " ", 2, 0));
            optionMenu.addParam(new Param("Bit", null, "BIT", 3, 0));
            optionMenu.addParam(new Param("Ping", null, "PING", 3, 10));
            optionMenu.addParam(new Param("Battery", null, "BATTERY", 3, 20));
            optionMenu.addParam(new Param("Vswr", null, "VSWR", 4, 0));
            optionMenu.addParam(new Param("Temp", null, "TEMP", 4, 10));
            optionMenu.addParam(new Param("Special", null, "SPECIAL", 4, 20));

            optionMenu.getParam("Bit").IsActive = true;

            optionMenu.addActionToParam(optionMenu.getParam("Body"), new Button("LEFT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();

                if (activeParam == null)
                {
                    var param = wdg.getParam("Special");
                    wdg.deactiveParam();
                    param.IsActive = true;
                    return;
                }

                switch (activeParam.Name)
                {
                    case "Bit":
                        {
                            wdg.deactiveParam();
                            var param = wdg.getParam("Special");
                            param.IsActive = true;
                            break;
                        }
                    case "Ping":
                        {
                            wdg.deactiveParam();
                            var param = wdg.getParam("Bit");
                            param.IsActive = true;
                            break;
                        }
                    case "Battery":
                        {
                            wdg.deactiveParam();
                            var param = wdg.getParam("Ping");
                            param.IsActive = true;
                            break;
                        }
                    case "Vswr":
                        {
                            wdg.deactiveParam();
                            var param = wdg.getParam("Battery");
                            param.IsActive = true;
                            break;
                        }
                    case "Temp":
                        {
                            wdg.deactiveParam();
                            var param = wdg.getParam("Vswr");
                            param.IsActive = true;
                            break;
                        }
                    case "Special":
                        {
                            wdg.deactiveParam();
                            var param = wdg.getParam("Temp");
                            param.IsActive = true;
                            break;
                        }
                }

            }));
            optionMenu.addActionToParam(optionMenu.getParam("Body"), new Button("RIGTH", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();

                if (activeParam == null)
                {
                    var param = wdg.getParam("Bit");
                    wdg.deactiveParam();
                    param.IsActive = true;
                    return;
                }

                switch (activeParam.Name)
                {
                    case "Bit":
                        {
                            wdg.deactiveParam();
                            var param = wdg.getParam("Ping");
                            param.IsActive = true;
                            break;
                        }
                    case "Ping":
                        {
                            wdg.deactiveParam();
                            var param = wdg.getParam("Battery");
                            param.IsActive = true;
                            break;
                        }
                    case "Battery":
                        {
                            wdg.deactiveParam();
                            var param = wdg.getParam("Vswr");
                            param.IsActive = true;
                            break;
                        }
                    case "Vswr":
                        {
                            wdg.deactiveParam();
                            var param = wdg.getParam("Temp");
                            param.IsActive = true;
                            break;
                        }
                    case "Temp":
                        {
                            wdg.deactiveParam();
                            var param = wdg.getParam("Special");
                            param.IsActive = true;
                            break;
                        }
                    case "Special":
                        {
                            wdg.deactiveParam();
                            var param = wdg.getParam("Bit");
                            param.IsActive = true;
                            break;
                        }
                }

            }));

            optionMenu.addActionToParam(optionMenu.getParam("Bit"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                Param activeParam = wdg.activeParam();
                if (activeParam == null || activeParam.Name != "Bit")
                {
                    return;
                }

                wdg.prepareToShowWidget(getNameMenu(MenuNames.OptionTestBitMenu));
            }));
            optionMenu.addActionToParam(optionMenu.getParam("Battery"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                Param activeParam = wdg.activeParam();
                if (activeParam == null || activeParam.Name != "Battery")
                {
                    return;
                }

                wdg.prepareToShowWidget(getNameMenu(MenuNames.OptionTestBatteryMenu));
            }));
            optionMenu.addActionToParam(optionMenu.getParam("Temp"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                Param activeParam = wdg.activeParam();
                if (activeParam == null || activeParam.Name != "Temp")
                {
                    return;
                }

                wdg.prepareToShowWidget(getNameMenu(MenuNames.OptionTestTempMenu));
            }));
            optionMenu.addActionToParam(optionMenu.getParam("Special"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                Param activeParam = wdg.activeParam();
                if (activeParam == null || activeParam.Name != "Special")
                {
                    return;
                }

                wdg.prepareToShowWidget(getNameMenu(MenuNames.OptionTestSpecialMenu));
            }));
            return optionMenu;
        }

        static public Widget initOptionMenuRadio(RadioStation station)
        {
            Widget optionMenu = new Widget(getNameMenu(MenuNames.OptionMenuRadio));

            optionMenu.LineSize[0] = 5;
            optionMenu.LineSize[1] = 9;
            optionMenu.LineSize[2] = 9;
            optionMenu.LineSize[3] = 5;
            optionMenu.LineCharOffset[0] = 6;
            optionMenu.LineCharOffset[1] = 7;
            optionMenu.LineCharOffset[2] = 6;
            optionMenu.LineCharOffset[3] = 6;
            optionMenu.addParam(new Param("Body", null, "", 1, 0));
            optionMenu.addParam(new Param("Title", null, "OPTI0NS-RADIO", 1, 0));
            optionMenu.addParam(new Param("RadioOptionsTitle", null, "TX POWER LEVEL", 2, 7));
            optionMenu.addParam(new Param("RadioOptionsValue", null, "LOW", 3, 12));
            optionMenu.addParam(new Param("Info", null, "PRESS ↑↓ TO SCROLL", 4, 19));

            optionMenu.getParam("RadioOptionsValue").IsActive = true;

            WidgetTextParams paramPowerLevel = new WidgetTextParams("TX POWER LEVEL");
            paramPowerLevel.addParam("LOW").addParam("HIGH").addParam("MED");
            WidgetTextParams paramSquelch = new WidgetTextParams("SQUELCH LEVEL");
            paramSquelch.addParam("LOW").addParam("HIGH").addParam("MED");
            WidgetTextParams paramFMSquelch = new WidgetTextParams("FM SQUELCH TYPE");
            paramFMSquelch.addParam("TONE").addParam("NOICE");
            WidgetTextParams paramInternelCoupler = new WidgetTextParams("INTERNAL COUPLER");
            paramInternelCoupler.addParam("ENABLED").addParam("BYPASSED");
            WidgetTextParams paramRadioSilence = new WidgetTextParams("RADIO SILENCE");
            paramRadioSilence.addParam("OFF").addParam("ON");
            WidgetTextParams paramBFO = new WidgetTextParams("BFO");
            paramBFO.addParam("-10").addParam("0").addParam("10");
            WidgetTextParams paramRXNocie = new WidgetTextParams("RX NOICE BLANKING");
            paramRXNocie.addParam("OFF").addParam("ON");
            WidgetTextParams paramRadioLock = new WidgetTextParams("RADIO LOCK");
            paramRadioLock.addParam("OFF").addParam("ON");

            List<WidgetTextParams> radioParams = new List<WidgetTextParams>();
            radioParams.Add(paramPowerLevel);
            radioParams.Add(paramSquelch);
            radioParams.Add(paramFMSquelch);
            radioParams.Add(paramInternelCoupler);
            radioParams.Add(paramRadioSilence);
            radioParams.Add(paramBFO);
            radioParams.Add(paramRXNocie);
            radioParams.Add(paramRadioLock);


            optionMenu.addActionToParam(optionMenu.getParam("RadioOptionsValue"), new Button("DOWN", (Button btn, RadioStation rs, Widget wdg) =>
            {
                Param activeParam = wdg.activeParam();
                Param titleParam = wdg.getParam("RadioOptionsTitle");

                string paramTitle = titleParam.Text;

                activeParam.Text = radioParams.Find(p => p.Name == paramTitle).getPrevParam();
                activeParam.ActiveTo = activeParam.Text.Length;
                activeParam.Y = Helper.calcCenterIndent(activeParam.Text.Length, 28);
                titleParam.Y = Helper.calcCenterIndent(titleParam.Text.Length, 28);
            }));

            optionMenu.addActionToParam(optionMenu.getParam("RadioOptionsValue"), new Button("UP", (Button btn, RadioStation rs, Widget wdg) =>
            {
                Param activeParam = wdg.activeParam();
                Param titleParam = wdg.getParam("RadioOptionsTitle");

                string paramTitle = titleParam.Text;

                activeParam.Text = radioParams.Find(p => p.Name == paramTitle).getNextParam();
                activeParam.ActiveTo = activeParam.Text.Length;
                activeParam.Y = Helper.calcCenterIndent(activeParam.Text.Length, 28);
                titleParam.Y = Helper.calcCenterIndent(titleParam.Text.Length, 28);
            }));

            optionMenu.addActionToParam(optionMenu.getParam("Body"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                Param activeParam = wdg.activeParam();
                Param titleParam = wdg.getParam("RadioOptionsTitle");

                string paramTitle = titleParam.Text;

                int nextIndex = radioParams.IndexOf(radioParams.Find(p => p.Name == paramTitle)) + 1;
                if (nextIndex < radioParams.Count)
                {
                    titleParam.Text = radioParams[nextIndex].Name;
                    activeParam.Text = radioParams[nextIndex].currParam();
                    activeParam.ActiveTo = activeParam.Text.Length;
                    activeParam.Y = Helper.calcCenterIndent(activeParam.Text.Length, 28);
                    titleParam.Y = Helper.calcCenterIndent(titleParam.Text.Length, 28);
                }
                else
                {
                    if (paramTitle == "RADIO LOCK")
                    {
                        bool res = activeParam.Text == "ON";
                        rs.KeyBoardLock = res;
                        if(res)
                        {
                            wdg.prepareToShowWidget(getNameMenu(MenuNames.KeyboardLock));
                            wdg.getAvailableWidget(getNameMenu(MenuNames.KeyboardLock)).ComeFrom = null;

                            Form1.timerAction = () =>
                            {
                                Widget trans = wdg.getAvailableWidget(getNameMenu(MenuNames.KeyboardLock));
                                trans.prepareToShowWidget(getNameMenu(MenuNames.MainMenu));
                                trans.getAvailableWidget(getNameMenu(MenuNames.MainMenu));
                            };
                            Form1.startTimer();
                            return;
                        } 
                        else
                        {
                            wdg.showPreviousWidget();

                            activeParam.Text = radioParams[0].currParam();
                            titleParam.Text = radioParams[0].Name;
                            activeParam.Y = Helper.calcCenterIndent(activeParam.Text.Length, 28);
                            titleParam.Y = Helper.calcCenterIndent(titleParam.Text.Length, 28);
                        }
                    }
                }
            }));

            return optionMenu;
        }

        static public Widget initKeyboardLockMenu(RadioStation station)
        {
            Widget optionMenu = new Widget(getNameMenu(MenuNames.KeyboardLock));
            optionMenu.LineSize[0] = 5;
            optionMenu.LineSize[1] = 8;
            optionMenu.LineSize[2] = 8;
            optionMenu.LineSize[3] = 8;
            optionMenu.addParam(new Param("Body", null, "", 1, 0));
            optionMenu.addParam(new Param("Title", null, "OPTIONS", 1, 0));
            optionMenu.addParam(new Param("EmptyLine", null, "", 2, 0));
            optionMenu.addParam(new Param("Title", null, "RADIO LOCK ENABLED", 3, 0));
            optionMenu.addParam(new Param("Info", null, "ENTER 1379 TO UNLOCK", 4, 0));



            optionMenu.addActionToParam(optionMenu.getParam("Body"), new Button("CALL", (Button btn, RadioStation st, Widget wdg) =>
            {
                Form1.keyEntered += "1";
            }));

            optionMenu.addActionToParam(optionMenu.getParam("Body"), new Button("MODE", (Button btn, RadioStation st, Widget wdg) =>
            {
                Form1.keyEntered += "3";
            }));

            optionMenu.addActionToParam(optionMenu.getParam("Body"), new Button("OPT", (Button btn, RadioStation st, Widget wdg) =>
            {
                Form1.keyEntered += "7";
            }));

            optionMenu.addActionToParam(optionMenu.getParam("Body"), new Button("DOWN", (Button btn, RadioStation st, Widget wdg) =>
            {
                Form1.keyEntered += "9";
                st.KeyBoardLock = !Form1.keyEntered.Contains(Form1.keyNeed);
            }));

            return optionMenu;
        }
        static public Widget initOptionGpsTodMenu(RadioStation station)
        {
            Widget optionMenu = new Widget(getNameMenu(MenuNames.OptionGpsTodMenu));
            optionMenu.LineSize[0] = 5;
            optionMenu.LineSize[1] = 9;
            optionMenu.LineSize[2] = 9;
            optionMenu.LineSize[3] = 5;
            optionMenu.LineCharOffset[0] = 6;
            optionMenu.LineCharOffset[1] = 6;
            optionMenu.LineCharOffset[2] = 7;
            optionMenu.LineCharOffset[3] = 6;
            optionMenu.addParam(new Param("Body", null, "", 1, 0));
            optionMenu.addParam(new Param("Title", null, "OPTIONS", 1, 0));
            optionMenu.addParam(new Param("GpsTitle", null, "GPS STATUS", 2, 9));
            optionMenu.addParam(new Param("GpsValue", null, "TRACKING", 3, 10));
            optionMenu.addParam(new Param("Info", null, "PRESS ↑ OR ↓ TO SCROLL", 4, 17));


            optionMenu.getParam("GpsValue").IsActive = true;

            WidgetTextParams paramPowerLevel = new WidgetTextParams("GPS STATUS");
            paramPowerLevel.addParam("TRACKING");
            WidgetTextParams paramSquelch = new WidgetTextParams("LAT: N 43'09.1958");
            paramSquelch.addParam("LNG: W 77'34.0012");
            WidgetTextParams paramFMSquelch = new WidgetTextParams("HEADING: 169'");
            paramFMSquelch.addParam("VELOCITY: 0.0 kph");
            WidgetTextParams paramInternelCoupler = new WidgetTextParams("ALTITUDE: 159.66 m");
            paramInternelCoupler.addParam("");

            List<WidgetTextParams> radioParams = new List<WidgetTextParams>();
            radioParams.Add(paramPowerLevel);
            radioParams.Add(paramSquelch);
            radioParams.Add(paramFMSquelch);
            radioParams.Add(paramInternelCoupler);


            optionMenu.addActionToParam(optionMenu.getParam("GpsValue"), new Button("DOWN", (Button btn, RadioStation rs, Widget wdg) =>
            {
                Param activeParam = wdg.activeParam();
                Param titleParam = wdg.getParam("GpsTitle");

                string paramTitle = titleParam.Text;

                activeParam.Text = radioParams.Find(p => p.Name == paramTitle).getPrevParam();
                activeParam.ActiveTo = activeParam.Text.Length;
                activeParam.Y = Helper.calcCenterIndent(activeParam.Text.Length, 28);
                titleParam.Y = Helper.calcCenterIndent(titleParam.Text.Length, 28);
            }));

            optionMenu.addActionToParam(optionMenu.getParam("GpsValue"), new Button("UP", (Button btn, RadioStation rs, Widget wdg) =>
            {
                Param activeParam = wdg.activeParam();
                Param titleParam = wdg.getParam("GpsTitle");

                string paramTitle = titleParam.Text;

                activeParam.Text = radioParams.Find(p => p.Name == paramTitle).getNextParam();
                activeParam.ActiveTo = activeParam.Text.Length;
                activeParam.Y = Helper.calcCenterIndent(activeParam.Text.Length, 28);
                titleParam.Y = Helper.calcCenterIndent(titleParam.Text.Length, 28);
            }));

            optionMenu.addActionToParam(optionMenu.getParam("Body"), new Button("CLR", (Button btn, RadioStation rs, Widget wdg) =>
            {
                wdg.showPreviousWidget();
                Param activeParam = wdg.activeParam();
                Param titleParam = wdg.getParam("GpsTitle");

                activeParam.Text = radioParams[0].currParam();
                titleParam.Text = radioParams[0].Name;
                activeParam.Y = Helper.calcCenterIndent(activeParam.Text.Length, 28);
                titleParam.Y = Helper.calcCenterIndent(titleParam.Text.Length, 28);
            }));

            optionMenu.addActionToParam(optionMenu.getParam("Body"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                Param activeParam = wdg.activeParam();
                Param titleParam = wdg.getParam("GpsTitle");

                string paramTitle = titleParam.Text;

                int nextIndex = radioParams.IndexOf(radioParams.Find(p => p.Name == paramTitle)) + 1;
                if (nextIndex < radioParams.Count)
                {
                    titleParam.Text = radioParams[nextIndex].Name;
                    activeParam.Text = radioParams[nextIndex].currParam();
                    activeParam.ActiveTo = activeParam.Text.Length;
                }
                else
                {
                    wdg.showPreviousWidget();

                    activeParam.Text = radioParams[0].currParam();
                    titleParam.Text = radioParams[0].Name;
                    activeParam.Y = Helper.calcCenterIndent(activeParam.Text.Length, 28);
                    titleParam.Y = Helper.calcCenterIndent(titleParam.Text.Length, 28);
                    return;
                }


                activeParam.Y = Helper.calcCenterIndent(activeParam.Text.Length, 28);
                titleParam.Y = Helper.calcCenterIndent(titleParam.Text.Length, 28);
            }));
            return optionMenu;
        }

        static public Widget initOptionScanMenu(RadioStation station)
        {
            Widget optionMenu = new Widget(getNameMenu(MenuNames.OptionMenuRadio));

            optionMenu.LineSize[0] = 5;
            optionMenu.LineSize[1] = 9;
            optionMenu.LineSize[2] = 9;
            optionMenu.LineSize[3] = 5;
            optionMenu.LineCharOffset[0] = 6;
            optionMenu.LineCharOffset[1] = 6;
            optionMenu.LineCharOffset[2] = 7;
            optionMenu.LineCharOffset[3] = 6;
            optionMenu.addParam(new Param("Body", null, "", 1, 0));
            optionMenu.addParam(new Param("Title", null, "OPTI0NS-RADIO", 1, 0));
            optionMenu.addParam(new Param("ScanTitle", null, "ENABLE SSB SCAN", 2, 7));
            optionMenu.addParam(new Param("ScanValue", null, "ON", 3, 12));
            optionMenu.addParam(new Param("Info", null, "PRESS ↑↓ TO SCROLL", 4, 18));

            optionMenu.getParam("ScanValue").IsActive = true;

            WidgetTextParams paramPowerLevel = new WidgetTextParams("ENABLE SSB SCAN");
            paramPowerLevel.addParam("ON").addParam("OFF");

            List<WidgetTextParams> radioParams = new List<WidgetTextParams>();
            radioParams.Add(paramPowerLevel);


            optionMenu.addActionToParam(optionMenu.getParam("ScanValue"), new Button("DOWN", (Button btn, RadioStation rs, Widget wdg) =>
            {
                Param activeParam = wdg.activeParam();
                Param titleParam = wdg.getParam("ScanTitle");

                string paramTitle = titleParam.Text;

                activeParam.Text = radioParams.Find(p => p.Name == paramTitle).getPrevParam();
                activeParam.ActiveTo = activeParam.Text.Length;
                activeParam.Y = Helper.calcCenterIndent(activeParam.Text.Length, 28);
                titleParam.Y = Helper.calcCenterIndent(titleParam.Text.Length, 28);
            }));

            optionMenu.addActionToParam(optionMenu.getParam("ScanValue"), new Button("UP", (Button btn, RadioStation rs, Widget wdg) =>
            {
                Param activeParam = wdg.activeParam();
                Param titleParam = wdg.getParam("ScanTitle");

                string paramTitle = titleParam.Text;

                activeParam.Text = radioParams.Find(p => p.Name == paramTitle).getNextParam();
                activeParam.ActiveTo = activeParam.Text.Length;
                activeParam.Y = Helper.calcCenterIndent(activeParam.Text.Length, 28);
                titleParam.Y = Helper.calcCenterIndent(titleParam.Text.Length, 28);
            }));

            optionMenu.addActionToParam(optionMenu.getParam("Body"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                Param activeParam = wdg.activeParam();
                Param titleParam = wdg.getParam("ScanTitle");

                string paramTitle = titleParam.Text;

                int nextIndex = radioParams.IndexOf(radioParams.Find(p => p.Name == paramTitle)) + 1;
                if (nextIndex < radioParams.Count)
                {
                    titleParam.Text = radioParams[nextIndex].Name;
                    activeParam.Text = radioParams[nextIndex].currParam();
                    activeParam.ActiveTo = activeParam.Text.Length;
                }
                else
                {
                    wdg.showPreviousWidget();
                    return;
                }

                activeParam.Y = Helper.calcCenterIndent(activeParam.Text.Length, 28);
                titleParam.Y = Helper.calcCenterIndent(titleParam.Text.Length, 28);
            }));

            optionMenu.addActionToParam(optionMenu.getParam("Body"), new Button("CLR", (Button btn, RadioStation rs, Widget wdg) =>
            {
                wdg.showPreviousWidget();
            }));

            return optionMenu;
        }

        static public Widget initOptionExtAccMenu(RadioStation station)
        {
            Widget optionMenu = new Widget(getNameMenu(MenuNames.OptionExtAccMenu));


            optionMenu.LineSize[0] = 5;
            optionMenu.LineSize[1] = 9;
            optionMenu.LineSize[2] = 9;
            optionMenu.LineSize[3] = 5;
            optionMenu.LineCharOffset[0] = 6;
            optionMenu.LineCharOffset[1] = 6;
            optionMenu.LineCharOffset[2] = 7;
            optionMenu.LineCharOffset[3] = 6;
            optionMenu.addParam(new Param("Body", null, "", 1, 0));
            optionMenu.addParam(new Param("Title", null, "OPTI0NS-RADIO", 1, 0));
            optionMenu.addParam(new Param("ExtTitle", null, "EXTERNAL ADAPTER", 2, 6));
            optionMenu.addParam(new Param("ExtValue", null, "NOT DETECTED", 3, 8));
            optionMenu.addParam(new Param("Info", null, "PRESS ENT TO CONT", 4, 18));

            optionMenu.getParam("ExtValue").IsActive = true;

            WidgetTextParams paramExternalAdapter = new WidgetTextParams("EXTERNAL ADAPTER");
            paramExternalAdapter.addParam("NOT DETECTED");
            WidgetTextParams paramPowerAmp = new WidgetTextParams("EXTERNAL POWER AMP");
            paramPowerAmp.addParam("NOT DETECTED");
            WidgetTextParams paramExternalPrepost = new WidgetTextParams("EXTERNAL PREPOST");
            paramExternalPrepost.addParam("NOT DETECTED");
            WidgetTextParams paramExternalCoupler = new WidgetTextParams("EXTERNAL COUPLER");
            paramExternalCoupler.addParam("NOT DETECTED");

            List<WidgetTextParams> radioParams = new List<WidgetTextParams>();
            radioParams.Add(paramExternalAdapter);
            radioParams.Add(paramPowerAmp);
            radioParams.Add(paramExternalPrepost);
            radioParams.Add(paramExternalCoupler);


            optionMenu.addActionToParam(optionMenu.getParam("ExtValue"), new Button("DOWN", (Button btn, RadioStation rs, Widget wdg) =>
            {
                Param activeParam = wdg.activeParam();
                Param titleParam = wdg.getParam("ExtTitle");

                string paramTitle = titleParam.Text;

                activeParam.Text = radioParams.Find(p => p.Name == paramTitle).getPrevParam();
                activeParam.ActiveTo = activeParam.Text.Length;
                activeParam.Y = Helper.calcCenterIndent(activeParam.Text.Length, 28);
                titleParam.Y = Helper.calcCenterIndent(titleParam.Text.Length, 28);
            }));

            optionMenu.addActionToParam(optionMenu.getParam("ExtValue"), new Button("UP", (Button btn, RadioStation rs, Widget wdg) =>
            {
                Param activeParam = wdg.activeParam();
                Param titleParam = wdg.getParam("ExtTitle");

                string paramTitle = titleParam.Text;

                activeParam.Text = radioParams.Find(p => p.Name == paramTitle).getNextParam();
                activeParam.ActiveTo = activeParam.Text.Length;
                activeParam.Y = Helper.calcCenterIndent(activeParam.Text.Length, 28);
                titleParam.Y = Helper.calcCenterIndent(titleParam.Text.Length, 28);
            }));

            optionMenu.addActionToParam(optionMenu.getParam("Body"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                Param activeParam = wdg.activeParam();
                Param titleParam = wdg.getParam("ExtTitle");

                string paramTitle = titleParam.Text;

                int nextIndex = radioParams.IndexOf(radioParams.Find(p => p.Name == paramTitle)) + 1;
                if (nextIndex < radioParams.Count)
                {
                    titleParam.Text = radioParams[nextIndex].Name;
                    activeParam.Text = radioParams[nextIndex].currParam();
                    activeParam.ActiveTo = activeParam.Text.Length;
                }
                else
                {
                    wdg.showPreviousWidget();
                    return;
                }

                activeParam.Y = Helper.calcCenterIndent(activeParam.Text.Length, 28);
                titleParam.Y = Helper.calcCenterIndent(titleParam.Text.Length, 28);
            }));

            optionMenu.addActionToParam(optionMenu.getParam("Body"), new Button("CLR", (Button btn, RadioStation rs, Widget wdg) =>
            {
                wdg.showPreviousWidget();
                Param activeParam = wdg.activeParam();
                Param titleParam = wdg.getParam("ExtTitle");

                activeParam.Text = radioParams[0].currParam();
                titleParam.Text = radioParams[0].Name;
                activeParam.Y = Helper.calcCenterIndent(activeParam.Text.Length, 28);
                titleParam.Y = Helper.calcCenterIndent(titleParam.Text.Length, 28);
            }));
            return optionMenu;
        }

        static public Widget initOptionTestBitMenu(RadioStation station)
        {
            Widget optionMenu = new Widget(getNameMenu(MenuNames.OptionTestBitMenu));

            optionMenu.LineSize[0] = 5;
            optionMenu.LineSize[1] = 9;
            optionMenu.LineSize[2] = 9;
            optionMenu.LineSize[3] = 5;
            optionMenu.LineCharOffset[0] = 6;
            optionMenu.LineCharOffset[1] = 6;
            optionMenu.LineCharOffset[2] = 7;
            optionMenu.LineCharOffset[3] = 6;
            optionMenu.addParam(new Param("Body", null, "", 1, 0));
            optionMenu.addParam(new Param("Title", null, "OPTI0NS-RADIO", 1, 0));
            optionMenu.addParam(new Param("TestTitle", null, "BUILT-IN-TEST", 2, 7));
            optionMenu.addParam(new Param("TestValue", null, "SYSTEM", 3, 10));
            optionMenu.addParam(new Param("Info", null, "↑↓ TO SCROLL - ENT TO EXECUTE", 4, 10));

            optionMenu.getParam("TestValue").IsActive = true;

            WidgetTextParams paramSystem = new WidgetTextParams("BUILT-IN-TEST");
            paramSystem.addParam("SYSTEM");
            WidgetTextParams paramCoupler = new WidgetTextParams("BUILT-IN-TEST");
            paramCoupler.addParam("RF-5382 COUPLER");
            WidgetTextParams paramPrepost = new WidgetTextParams("BUILT-IN-TEST");
            paramPrepost.addParam("PREPOST");
            WidgetTextParams paramPA = new WidgetTextParams("BUILT-IN-TEST");
            paramPA.addParam("EXTERNAL PA");
            WidgetTextParams paramKDP = new WidgetTextParams("BUILT-IN-TEST");
            paramPA.addParam("KDP");
            WidgetTextParams paramKDU = new WidgetTextParams("BUILT-IN-TEST");
            paramPA.addParam("KDU");
            WidgetTextParams paramInternalCoupler = new WidgetTextParams("BUILT-IN-TEST");
            paramPA.addParam("INTERNAL COUPLER");

            List<string> radioParams = new List<string>();
            radioParams.Add("SYSTEM");
            radioParams.Add("RF-5382 COUPLER");
            radioParams.Add("PREPOST");
            radioParams.Add("EXTERNAL PA");
            radioParams.Add("KDP");
            radioParams.Add("KDU");
            radioParams.Add("INTERNAL COUPLER");


            optionMenu.addActionToParam(optionMenu.getParam("TestValue"), new Button("DOWN", (Button btn, RadioStation rs, Widget wdg) =>
            {
                Param activeParam = wdg.activeParam();

                int index = radioParams.IndexOf(activeParam.Text);
                index++;
                if (index < radioParams.Count)
                {
                    activeParam.Text = radioParams[index];
                }
                else
                {
                    activeParam.Text = radioParams[0];
                }

                activeParam.ActiveTo = activeParam.Text.Length;
                activeParam.Y = Helper.calcCenterIndent(activeParam.Text.Length, 28);
            }));

            optionMenu.addActionToParam(optionMenu.getParam("TestValue"), new Button("UP", (Button btn, RadioStation rs, Widget wdg) =>
            {
                Param activeParam = wdg.activeParam();

                int index = radioParams.IndexOf(activeParam.Text);
                index--;
                if (index >= 0)
                {
                    activeParam.Text = radioParams[index];
                }
                else
                {
                    activeParam.Text = radioParams[radioParams.Count - 1];
                }

                activeParam.ActiveTo = activeParam.Text.Length;
                activeParam.Y = Helper.calcCenterIndent(activeParam.Text.Length, 28);
            }));

            optionMenu.addActionToParam(optionMenu.getParam("Body"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                Param activeParam = wdg.activeParam();

                switch (activeParam.Text)
                {
                    case "SYSTEM":
                        {
                            Form1.currObject.QueueWidget.add(getTestInProgressMenu());
                            Form1.currObject.QueueWidget.add(getTestContrastMenu());
                            Form1.currObject.QueueWidget.add(getTestLightMenu());
                            Form1.currObject.QueueWidget.add(getTestInProgressMenu());
                            Form1.currObject.QueueWidget.add(getTestPassedMenu());
                            Form1.currObject.startShowWidgetQueue();
                            break;
                        }
                    case "RF-5382 COUPLER":
                        {
                            Form1.currObject.QueueWidget.add(getTestInProgressMenu());
                            Form1.currObject.QueueWidget.add(getCouplerRFMenu());
                            Form1.currObject.startShowWidgetQueue();
                            break;
                        }
                    case "PREPOST":
                        {
                            Form1.currObject.QueueWidget.add(getTestInProgressMenu());
                            Form1.currObject.QueueWidget.add(getPrepostMenu());
                            Form1.currObject.startShowWidgetQueue();
                            break;
                        }
                    case "EXTERNAL PA":
                        {
                            Form1.currObject.QueueWidget.add(getTestInProgressMenu());
                            Form1.currObject.QueueWidget.add(getExtraMenu());
                            Form1.currObject.startShowWidgetQueue();
                            break;
                        }
                    case "KDP":
                        {
                            Form1.currObject.QueueWidget.add(getTestContrastMenu());
                            Form1.currObject.QueueWidget.add(getTestLightMenu());
                            Form1.currObject.QueueWidget.add(getTestPassedMenu());
                            Form1.currObject.startShowWidgetQueue();
                            break;
                        }
                    case "KDU":
                        {
                            Form1.currObject.QueueWidget.add(getTestInProgressMenu());
                            Form1.currObject.QueueWidget.add(getTestPassedMenu());
                            Form1.currObject.startShowWidgetQueue();
                            break;
                        }
                    case "INTERNAL COUPLER":
                        {
                            Form1.currObject.QueueWidget.add(getTestInProgressMenu());
                            Form1.currObject.QueueWidget.add(getTestPassedMenu());
                            Form1.currObject.startShowWidgetQueue();
                            break;
                        }
                }

            }));

            optionMenu.addActionToParam(optionMenu.getParam("TestValue"), new Button("UP", (Button btn, RadioStation rs, Widget wdg) =>
            {
                optionMenu.showPreviousWidget();
            }));
            return optionMenu;
        }

        static public Widget getTestInProgressMenu()
        {
            Widget optionMenu = new Widget("TestInProgressMenu");

            optionMenu.LineSize[0] = 5;
            optionMenu.LineSize[1] = 9;
            optionMenu.LineSize[2] = 9;
            optionMenu.LineSize[3] = 5;
            optionMenu.LineCharOffset[0] = 6;
            optionMenu.LineCharOffset[1] = 6;
            optionMenu.LineCharOffset[2] = 7;
            optionMenu.LineCharOffset[3] = 6;
            optionMenu.addParam(new Param("Body", null, "", 1, 0));
            optionMenu.addParam(new Param("Title", null, "TESTING", 1, 0));
            optionMenu.addParam(new Param("TestTitle", null, "*** TEST ***", 2, 9));
            optionMenu.addParam(new Param("TestValue", null, "IN PROGRESS", 3, 8));
            optionMenu.addParam(new Param("Info", null, "...WAIT...", 4, 23));

            return optionMenu;
        }
        static public Widget getTestContrastMenu()
        {
            Widget optionMenu = new Widget("TestContrastMenu");

            optionMenu.LineSize[0] = 5;
            optionMenu.LineSize[1] = 9;
            optionMenu.LineSize[2] = 9;
            optionMenu.LineSize[3] = 5;
            optionMenu.LineCharOffset[0] = 6;
            optionMenu.LineCharOffset[1] = 6;
            optionMenu.LineCharOffset[2] = 7;
            optionMenu.LineCharOffset[3] = 6;
            optionMenu.addParam(new Param("Body", null, "", 1, 0));
            optionMenu.addParam(new Param("Title", null, "TESTING", 1, 0));
            optionMenu.addParam(new Param("TestTitle", null, "CONTRAST TEST", 2, 7));
            optionMenu.addParam(new Param("TestValue", null, "", 3, 12));
            optionMenu.addParam(new Param("Info", null, "...WAIT...", 4, 23));

            return optionMenu;
        }
        static public Widget getTestLightMenu()
        {
            Widget optionMenu = new Widget("TestLightMenu");

            optionMenu.LineSize[0] = 5;
            optionMenu.LineSize[1] = 9;
            optionMenu.LineSize[2] = 9;
            optionMenu.LineSize[3] = 5;
            optionMenu.LineCharOffset[0] = 6;
            optionMenu.LineCharOffset[1] = 6;
            optionMenu.LineCharOffset[2] = 7;
            optionMenu.LineCharOffset[3] = 6;
            optionMenu.addParam(new Param("Body", null, "", 1, 0));
            optionMenu.addParam(new Param("Title", null, "TESTING", 1, 0));
            optionMenu.addParam(new Param("TestTitle", null, "LIGHT TEST", 2, 9));
            optionMenu.addParam(new Param("TestValue", null, "", 3, 12));
            optionMenu.addParam(new Param("Info", null, "...WAIT...", 4, 23));

            return optionMenu;
        }
        static public Widget getTestPassedMenu()
        {
            Widget optionMenu = new Widget("getTestPassedMenu");

            optionMenu.LineSize[0] = 5;
            optionMenu.LineSize[1] = 9;
            optionMenu.LineSize[2] = 9;
            optionMenu.LineSize[3] = 5;
            optionMenu.LineCharOffset[0] = 6;
            optionMenu.LineCharOffset[1] = 6;
            optionMenu.LineCharOffset[2] = 7;
            optionMenu.LineCharOffset[3] = 6;
            optionMenu.addParam(new Param("Body", null, "", 1, 0));
            optionMenu.addParam(new Param("Title", null, "TESTING", 1, 0));
            optionMenu.addParam(new Param("TestTitle", null, "*** TEST ***", 2, 9));
            optionMenu.addParam(new Param("TestValue", null, "PASSED", 3, 11));
            optionMenu.addParam(new Param("Info", null, "PRESS CLR/ENT TO EXIT", 4, 17));
            optionMenu.addActionToParam(optionMenu.getParam("Body"), new Button("ENT", (Button btn, RadioStation st, Widget wdg) =>
            {
                WidgetInit.widgetContainer[getNameMenu(MenuNames.MainMenu)].MoveTo = null;
                Form1.currObject.QueueWidget.clear();
                Form1.currObject.QueueWidget.add(WidgetInit.widgetContainer[getNameMenu(MenuNames.MainMenu)]);
                Form1.currObject.startShowWidgetQueue();
            }));
            optionMenu.addActionToParam(optionMenu.getParam("Body"), new Button("CLR", (Button btn, RadioStation st, Widget wdg) =>
            {
                WidgetInit.widgetContainer[getNameMenu(MenuNames.MainMenu)].MoveTo = null;
                Form1.currObject.QueueWidget.clear();
                Form1.currObject.QueueWidget.add(WidgetInit.widgetContainer[getNameMenu(MenuNames.MainMenu)]);
                Form1.currObject.startShowWidgetQueue();
            }));

            return optionMenu;
        }
        static public Widget getCouplerRFMenu()
        {
            Widget optionMenu = new Widget("getCouplerRFMenu");

            optionMenu.LineSize[0] = 5;
            optionMenu.LineSize[1] = 8;
            optionMenu.LineSize[2] = 8;
            optionMenu.LineSize[3] = 5;
            optionMenu.LineCharOffset[1] = 6;
            optionMenu.LineCharOffset[2] = 4;
            optionMenu.addParam(new Param("Body", null, "", 1, 0));
            optionMenu.addParam(new Param("Title", null, "TESTING", 1, 0));
            optionMenu.addParam(new Param("TestTitle", null, "MODULE: 5382_COUPLER", 2, 0));
            optionMenu.addParam(new Param("TestValue", null, "FAULT:       99", 3, 0));
            optionMenu.addParam(new Param("Info", null, "PRESS CLR/ENT TO EXIT", 4, 15));
            optionMenu.addActionToParam(optionMenu.getParam("Body"), new Button("UPDATE", (Button btn, RadioStation st, Widget wdg) =>
            {
                wdg.getParam("TestValue").Text = wdg.getParam("TestValue").Text == "FAULT:       99" ? "NOT_INSTALLED" : "FAULT:       99";
            }));
            optionMenu.addActionToParam(optionMenu.getParam("Body"), new Button("ENT", (Button btn, RadioStation st, Widget wdg) =>
            {
                WidgetInit.widgetContainer[getNameMenu(MenuNames.MainMenu)].MoveTo = null;
                Form1.currObject.QueueWidget.clear();
                Form1.currObject.QueueWidget.add(WidgetInit.widgetContainer[getNameMenu(MenuNames.MainMenu)]);
                Form1.currObject.startShowWidgetQueue();
            }));

            return optionMenu;
        }
        static public Widget getPrepostMenu()
        {
            Widget optionMenu = new Widget("getPrepostMenu");

            optionMenu.LineSize[0] = 5;
            optionMenu.LineSize[1] = 8;
            optionMenu.LineSize[2] = 8;
            optionMenu.LineSize[3] = 5;
            optionMenu.LineCharOffset[1] = 6;
            optionMenu.LineCharOffset[2] = 4;
            optionMenu.addParam(new Param("Body", null, "", 1, 0));
            optionMenu.addParam(new Param("Title", null, "TESTING", 1, 0));
            optionMenu.addParam(new Param("TestTitle", null, "MODULE: PREPOST_1", 2, 0));
            optionMenu.addParam(new Param("TestValue", null, "FAULT:       99", 3, 0));
            optionMenu.addParam(new Param("Info", null, "PRESS CLR/ENT TO EXIT", 4, 15));
            optionMenu.addActionToParam(optionMenu.getParam("Body"), new Button("UPDATE", (Button btn, RadioStation st, Widget wdg) =>
            {
                wdg.getParam("TestValue").Text = wdg.getParam("TestValue").Text == "FAULT:       99" ? "NOT_INSTALLED" : "FAULT:       99";
            }));
            optionMenu.addActionToParam(optionMenu.getParam("Body"), new Button("ENT", (Button btn, RadioStation st, Widget wdg) =>
            {
                WidgetInit.widgetContainer[getNameMenu(MenuNames.MainMenu)].MoveTo = null;
                Form1.currObject.QueueWidget.clear();
                Form1.currObject.QueueWidget.add(WidgetInit.widgetContainer[getNameMenu(MenuNames.MainMenu)]);
                Form1.currObject.startShowWidgetQueue();
            }));

            return optionMenu;
        }
        static public Widget getExtraMenu()
        {
            Widget optionMenu = new Widget("getExtraMenu");

            optionMenu.LineSize[0] = 5;
            optionMenu.LineSize[1] = 8;
            optionMenu.LineSize[2] = 8;
            optionMenu.LineSize[3] = 5;
            optionMenu.LineCharOffset[1] = 6;
            optionMenu.LineCharOffset[2] = 4;
            optionMenu.addParam(new Param("Body", null, "", 1, 0));
            optionMenu.addParam(new Param("Title", null, "TESTING", 1, 0));
            optionMenu.addParam(new Param("TestTitle", null, "MODULE: EXTRA", 2, 0));
            optionMenu.addParam(new Param("TestValue", null, "FAULT:       99", 3, 0));
            optionMenu.addParam(new Param("Info", null, "PRESS CLR/ENT TO EXIT", 4, 15));
            optionMenu.addActionToParam(optionMenu.getParam("Body"), new Button("UPDATE", (Button btn, RadioStation st, Widget wdg) =>
            {
                wdg.getParam("TestValue").Text = wdg.getParam("TestValue").Text == "FAULT:       99" ? "NOT_INSTALLED" : "FAULT:       99";
            }));
            optionMenu.addActionToParam(optionMenu.getParam("Body"), new Button("ENT", (Button btn, RadioStation st, Widget wdg) =>
            {
                WidgetInit.widgetContainer[getNameMenu(MenuNames.MainMenu)].MoveTo = null;
                Form1.currObject.QueueWidget.clear();
                Form1.currObject.QueueWidget.add(WidgetInit.widgetContainer[getNameMenu(MenuNames.MainMenu)]);
                Form1.currObject.startShowWidgetQueue();
            }));

            return optionMenu;
        }

        static public Widget initOptionTestBatteryMenu(RadioStation station)
        {
            Widget optionMenu = new Widget(getNameMenu(MenuNames.OptionTestBatteryMenu));

            optionMenu.LineSize[0] = 5;
            optionMenu.LineSize[1] = 9;
            optionMenu.LineSize[2] = 9;
            optionMenu.LineSize[3] = 5;
            optionMenu.LineCharOffset[0] = 6;
            optionMenu.LineCharOffset[1] = 6;
            optionMenu.LineCharOffset[2] = 7;
            optionMenu.LineCharOffset[3] = 6;
            optionMenu.addParam(new Param("Body", null, "", 1, 0));
            optionMenu.addParam(new Param("Title", null, "OPTI0NS-RADIO", 1, 0));
            optionMenu.addParam(new Param("BatteryTitle", null, "BATT:          RECHARGEABLE", 2, 0));
            optionMenu.addParam(new Param("BatteryValue", null, "VOLTAGE:       29.7 NOMINAL", 3, 0));
            optionMenu.addParam(new Param("Info", null, "PRESS ENT TO CONT", 4, 15));

            optionMenu.getParam("BatteryValue").IsActive = true;

            WidgetTextParams paramFirst = new WidgetTextParams("BATT:          RECHARGEABLE");
            paramFirst.addParam("VOLTAGE:       29.7 NOMINAL");
            WidgetTextParams paramSecond = new WidgetTextParams("HUB VOLTAGE:      3.62 V");
            paramSecond.addParam("HUB STATUS:       NOMINAL");
            WidgetTextParams paramFMSquelch = new WidgetTextParams("      HUB CAPACITY EST");
            paramFMSquelch.addParam("     DAYS REMAINING:    349");

            List<WidgetTextParams> radioParams = new List<WidgetTextParams>();
            radioParams.Add(paramFirst);
            radioParams.Add(paramSecond);
            radioParams.Add(paramFMSquelch);


            optionMenu.addActionToParam(optionMenu.getParam("BatteryValue"), new Button("DOWN", (Button btn, RadioStation rs, Widget wdg) =>
            {
                Param activeParam = wdg.activeParam();
                Param titleParam = wdg.getParam("BatteryTitle");

                string paramTitle = titleParam.Text;

                activeParam.Text = radioParams.Find(p => p.Name == paramTitle).getPrevParam();
                activeParam.ActiveTo = activeParam.Text.Length;
            }));

            optionMenu.addActionToParam(optionMenu.getParam("BatteryValue"), new Button("UP", (Button btn, RadioStation rs, Widget wdg) =>
            {
                Param activeParam = wdg.activeParam();
                Param titleParam = wdg.getParam("BatteryTitle");

                string paramTitle = titleParam.Text;

                activeParam.Text = radioParams.Find(p => p.Name == paramTitle).getNextParam();
                activeParam.ActiveTo = activeParam.Text.Length;
            }));

            optionMenu.addActionToParam(optionMenu.getParam("Body"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                Param activeParam = wdg.activeParam();
                Param titleParam = wdg.getParam("BatteryTitle");

                string paramTitle = titleParam.Text;

                int nextIndex = radioParams.IndexOf(radioParams.Find(p => p.Name == paramTitle)) + 1;
                if (nextIndex < radioParams.Count)
                {
                    titleParam.Text = radioParams[nextIndex].Name;
                    activeParam.Text = radioParams[nextIndex].currParam();
                    activeParam.ActiveTo = activeParam.Text.Length;
                }
                else
                {
                    wdg.showPreviousWidget();

                    activeParam.Text = radioParams[0].currParam();
                    titleParam.Text = radioParams[0].Name;
                    activeParam.Y = Helper.calcCenterIndent(activeParam.Text.Length, 28);
                    titleParam.Y = Helper.calcCenterIndent(titleParam.Text.Length, 28);
                }


            }));
            optionMenu.addActionToParam(optionMenu.getParam("Body"), new Button("CLR", (Button btn, RadioStation st, Widget wdg) =>
            {
                wdg.showPreviousWidget();

                Param activeParam = wdg.activeParam();
                Param titleParam = wdg.getParam("BatteryTitle");

                activeParam.Text = radioParams[0].currParam();
                titleParam.Text = radioParams[0].Name;
                activeParam.Y = Helper.calcCenterIndent(activeParam.Text.Length, 28);
                titleParam.Y = Helper.calcCenterIndent(titleParam.Text.Length, 28);
            }));
            return optionMenu;
        }

        static public Widget initOptionTestTempMenu(RadioStation station)
        {
            Widget optionMenu = new Widget(getNameMenu(MenuNames.OptionTestTempMenu));

            optionMenu.LineSize[0] = 5;
            optionMenu.LineSize[1] = 9;
            optionMenu.LineSize[2] = 9;
            optionMenu.LineSize[3] = 5;
            optionMenu.LineCharOffset[0] = 6;
            optionMenu.LineCharOffset[1] = 6;
            optionMenu.LineCharOffset[2] = 7;
            optionMenu.LineCharOffset[3] = 6;
            optionMenu.addParam(new Param("Body", null, "", 1, 0));
            optionMenu.addParam(new Param("Title", null, "TESTING-TEMP", 1, 0));
            optionMenu.addParam(new Param("TestTitle", null, "DIG BD TEMP: 42.0 C", 2, 5));
            optionMenu.addParam(new Param("TestValue", null, "PA TEMP: 35.6 C", 3, 7));
            optionMenu.addParam(new Param("Info", null, "ENT TO REFRESH/CLR TO EXIT", 4, 13));

            optionMenu.addActionToParam(optionMenu.getParam("Body"), new Button("CLR", (Button btn, RadioStation st, Widget wdg) =>
            {
                wdg.showPreviousWidget();
            }));
            optionMenu.addActionToParam(optionMenu.getParam("Body"), new Button("UPDATE", (Button btn, RadioStation st, Widget wdg) =>
            {
                wdg.showPreviousWidget();
            }));

            return optionMenu;
        }
        static public Widget initOptionTestSpecialMenu(RadioStation station)
        {
            Widget optionMenu = new Widget(getNameMenu(MenuNames.OptionTestSpecialMenu));

            optionMenu.LineSize[0] = 5;
            optionMenu.LineSize[1] = 9;
            optionMenu.LineSize[2] = 9;
            optionMenu.LineSize[3] = 5;
            optionMenu.LineCharOffset[0] = 6;
            optionMenu.LineCharOffset[1] = 6;
            optionMenu.LineCharOffset[2] = 7;
            optionMenu.LineCharOffset[3] = 6;
            optionMenu.addParam(new Param("Body", null, "", 1, 0));
            optionMenu.addParam(new Param("Title", null, "OPTION-TEST-SPECIAL", 1, 0));
            optionMenu.addParam(new Param("Version", null, "VERSION", 2, 0));
            optionMenu.addParam(new Param("Stats", null, "RADIO STATS", 2, 10));
            optionMenu.addParam(new Param("Config", null, "CONFIG", 3, 10));

            optionMenu.getParam("Version").IsActive = true;

            optionMenu.addActionToParam(optionMenu.getParam("Body"), new Button("CLR", (Button btn, RadioStation st, Widget wdg) =>
            {
                wdg.showPreviousWidget();
            }));
            optionMenu.addActionToParam(optionMenu.getParam("Body"), new Button("UPDATE", (Button btn, RadioStation st, Widget wdg) =>
            {
                wdg.showPreviousWidget();
            }));

            optionMenu.addActionToParam(optionMenu.getParam("Body"), new Button("LEFT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();

                if (activeParam == null)
                {
                    var param = wdg.getParam("Config");
                    wdg.deactiveParam();
                    param.IsActive = true;
                    return;
                }

                switch (activeParam.Name)
                {
                    case "Version":
                        {
                            wdg.deactiveParam();
                            var param = wdg.getParam("Config");
                            param.IsActive = true;
                            break;
                        }
                    case "Stats":
                        {
                            wdg.deactiveParam();
                            var param = wdg.getParam("Version");
                            param.IsActive = true;
                            break;
                        }
                    case "Config":
                        {
                            wdg.deactiveParam();
                            var param = wdg.getParam("Stats");
                            param.IsActive = true;
                            break;
                        }
                }

            }));
            optionMenu.addActionToParam(optionMenu.getParam("Body"), new Button("RIGTH", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();

                if (activeParam == null)
                {
                    var param = wdg.getParam("Version");
                    wdg.deactiveParam();
                    param.IsActive = true;
                    return;
                }

                switch (activeParam.Name)
                {
                    case "Version":
                        {
                            wdg.deactiveParam();
                            var param = wdg.getParam("Stats");
                            param.IsActive = true;
                            break;
                        }
                    case "Stats":
                        {
                            wdg.deactiveParam();
                            var param = wdg.getParam("Config");
                            param.IsActive = true;
                            break;
                        }
                    case "Config":
                        {
                            wdg.deactiveParam();
                            var param = wdg.getParam("Version");
                            param.IsActive = true;
                            break;
                        }
                }
            }));

            optionMenu.addActionToParam(optionMenu.getParam("Version"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();

                if (activeParam == null || activeParam.Name != "Version")
                {
                    return;
                }

                wdg.prepareToShowWidget(getNameMenu(MenuNames.OptionTestSpecialVersionMenu));
            }));

            optionMenu.addActionToParam(optionMenu.getParam("Config"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();

                if (activeParam == null || activeParam.Name != "Config")
                {
                    return;
                }

                wdg.prepareToShowWidget(getNameMenu(MenuNames.OptionTestSpecialConfigMenu));
            }));

            return optionMenu;
        }

        static public Widget initOptionTestSpecialVersionMenu(RadioStation station)
        {
            Widget optionMenu = new Widget(getNameMenu(MenuNames.OptionTestSpecialVersionMenu));

            optionMenu.LineSize[0] = 5;
            optionMenu.LineSize[1] = 9;
            optionMenu.LineSize[2] = 9;
            optionMenu.LineSize[3] = 5;
            optionMenu.LineCharOffset[0] = 6;
            optionMenu.LineCharOffset[1] = 6;
            optionMenu.LineCharOffset[2] = 7;
            optionMenu.LineCharOffset[3] = 6;
            optionMenu.addParam(new Param("Body", null, "", 1, 0));
            optionMenu.addParam(new Param("Title", null, "OPTION-TEST-SPECIAL-VERSION", 1, 0));
            optionMenu.addParam(new Param("Software", null, "SOFTWARE", 2, 0));
            optionMenu.addParam(new Param("Hardware", null, "HARDWARE", 2, 10));

            optionMenu.getParam("Software").IsActive = true;

            optionMenu.addActionToParam(optionMenu.getParam("Body"), new Button("CLR", (Button btn, RadioStation st, Widget wdg) =>
            {
                wdg.showPreviousWidget();
            }));

            optionMenu.addActionToParam(optionMenu.getParam("Body"), new Button("LEFT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();

                if (activeParam == null)
                {
                    var param = wdg.getParam("Hardware");
                    wdg.deactiveParam();
                    param.IsActive = true;
                    return;
                }

                switch (activeParam.Name)
                {
                    case "Software":
                        {
                            wdg.deactiveParam();
                            var param = wdg.getParam("Hardware");
                            param.IsActive = true;
                            break;
                        }
                    case "Hardware":
                        {
                            wdg.deactiveParam();
                            var param = wdg.getParam("Software");
                            param.IsActive = true;
                            break;
                        }
                }

            }));
            optionMenu.addActionToParam(optionMenu.getParam("Body"), new Button("RIGTH", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();

                if (activeParam == null)
                {
                    var param = wdg.getParam("Software");
                    wdg.deactiveParam();
                    param.IsActive = true;
                    return;
                }

                switch (activeParam.Name)
                {
                    case "Software":
                        {
                            wdg.deactiveParam();
                            var param = wdg.getParam("Hardware");
                            param.IsActive = true;
                            break;
                        }
                    case "Hardware":
                        {
                            wdg.deactiveParam();
                            var param = wdg.getParam("Software");
                            param.IsActive = true;
                            break;
                        }
                }
            }));


            return optionMenu;
        }

        static public Widget initOptionTestSpecialConfigMenu(RadioStation station)
        {
            Widget optionMenu = new Widget(getNameMenu(MenuNames.OptionTestSpecialConfigMenu));

            optionMenu.LineSize[0] = 5;
            optionMenu.LineSize[1] = 9;
            optionMenu.LineSize[2] = 9;
            optionMenu.LineSize[3] = 5;
            optionMenu.LineCharOffset[0] = 6;
            optionMenu.LineCharOffset[1] = 6;
            optionMenu.LineCharOffset[2] = 7;
            optionMenu.LineCharOffset[3] = 6;
            optionMenu.addParam(new Param("Body", null, "", 1, 0));
            optionMenu.addParam(new Param("Title", null, "OPTION-TEST-SPECIAL-CONFIG", 1, 0));
            optionMenu.addParam(new Param("Ids", null, "IDS", 2, 0));
            optionMenu.addParam(new Param("Options", null, "OPTIONS", 2, 10));
            optionMenu.getParam("Ids").IsActive = true;

            optionMenu.addActionToParam(optionMenu.getParam("Body"), new Button("CLR", (Button btn, RadioStation st, Widget wdg) =>
            {
                wdg.showPreviousWidget();
            }));

            optionMenu.addActionToParam(optionMenu.getParam("Body"), new Button("LEFT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();

                if (activeParam == null)
                {
                    var param = wdg.getParam("Options");
                    wdg.deactiveParam();
                    param.IsActive = true;
                    return;
                }

                switch (activeParam.Name)
                {
                    case "Ids":
                        {
                            wdg.deactiveParam();
                            var param = wdg.getParam("Options");
                            param.IsActive = true;
                            break;
                        }
                    case "Options":
                        {
                            wdg.deactiveParam();
                            var param = wdg.getParam("Ids");
                            param.IsActive = true;
                            break;
                        }
                }

            }));
            optionMenu.addActionToParam(optionMenu.getParam("Body"), new Button("RIGTH", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();

                if (activeParam == null)
                {
                    var param = wdg.getParam("Ids");
                    wdg.deactiveParam();
                    param.IsActive = true;
                    return;
                }

                switch (activeParam.Name)
                {
                    case "Ids":
                        {
                            wdg.deactiveParam();
                            var param = wdg.getParam("Options");
                            param.IsActive = true;
                            break;
                        }
                    case "Options":
                        {
                            wdg.deactiveParam();
                            var param = wdg.getParam("Ids");
                            param.IsActive = true;
                            break;
                        }
                }
            }));


            return optionMenu;
        }

        static public Widget initSelectModeMenu(RadioStation station)
        {
            Widget mainMenu = new Widget(getNameMenu(MenuNames.OptionTestSpecialConfigMenu));

            RadioStationMode oldMode = station.Mode;

            mainMenu.LineSize[0] = 5;
            mainMenu.LineSize[1] = 9;
            mainMenu.LineSize[2] = 9;
            mainMenu.LineSize[3] = 5;
            mainMenu.LineCharOffset[0] = 6;
            mainMenu.LineCharOffset[1] = 6;
            mainMenu.LineCharOffset[2] = 7;
            mainMenu.LineCharOffset[3] = 6;
            mainMenu.addParam(new Param("Body", null, "", 1, 0));
            mainMenu.addParam(new Param("StationRTmode", null, "R", 1, 0));
            mainMenu.addParam(new Param("Battery", null, "BAT ■■■■■", 1, 2));
            mainMenu.addParam(new Param("StationMode", null, station.currentModeToString(), 1, 10, () =>
            {
                mainMenu.getParam("StationMode").Text = station.currentModeToString();
            }));
            mainMenu.addParam(new Param("SQ", null, "SQ", 1, 14));
            mainMenu.addParam(new Param("SwitchState", null, Enum.GetName(typeof(SwitcherState), station.getState()), 1, 17, () =>
            {
                mainMenu.getParam("SwitchState").Text = Enum.GetName(typeof(SwitcherState), station.getState());
            }));
            mainMenu.addParam(new Param("Select", null, $">>> {station.currentModeToString()} <<<", 2, 9));
            mainMenu.addParam(new Param("EmptyLine", null, "", 3, 0));
            mainMenu.addParam(new Param("Info", null, "MODE TO SELECT", 4, 20));

            mainMenu.addActionToParam(mainMenu.getParam("Body"), new Button("CLR", (Button btn, RadioStation st, Widget wdg) =>
            {
                wdg.showPreviousWidget();
                station.Mode = oldMode;
            }));

            mainMenu.addActionToParam(mainMenu.getParam("Body"), new Button("MODE", (Button btn, RadioStation st, Widget wdg) =>
            {
                station.nextMode();
                mainMenu.getParam("Select").Text = $">>> {station.currentModeToString()} <<<";
            }));

            mainMenu.addActionToParam(mainMenu.getParam("Body"), new Button("ENT", (Button btn, RadioStation st, Widget wdg) =>
            {
                if (station.Mode == RadioStationMode.ALE)
                {
                    Form1.currObject.QueueWidget.add(initAleSelfAddressMenu(station));
                    Form1.currObject.startShowWidgetQueue();
                    return;
                }

                mainMenu.showPreviousWidget();
            }));

            return mainMenu;
        }

        static public Widget initOptionThreeGMenu(RadioStation station)
        {
            Widget optionMenu = new Widget(getNameMenu(MenuNames.OptionMenu));
            optionMenu.LineSize[0] = 5;
            optionMenu.LineSize[1] = 8;
            optionMenu.LineSize[2] = 8;
            optionMenu.LineSize[3] = 8;
            optionMenu
                .addParam(new Param("Body", null, "", 1, 0))
                .addModesForParam("Body", new List<RadioStationMode> { RadioStationMode.ThreeG });
            optionMenu.addParam(new Param("Title", null, "OPTIONS-3G", 1, 0))
                .addModesForParam("Title", new List<RadioStationMode> { RadioStationMode.ThreeG });
            optionMenu.addParam(new Param("EmptyLine", null, " ", 2, 0))
                .addModesForParam("EmptyLine", new List<RadioStationMode> { RadioStationMode.ThreeG });
            optionMenu.addParam(new Param("Lqa", null, "LQA", 3, 0))
                .addModesForParam("Lqa", new List<RadioStationMode> { RadioStationMode.ThreeG });
            optionMenu.addParam(new Param("Scores", null, "SCORES", 3, 10))
                .addModesForParam("Scores", new List<RadioStationMode> { RadioStationMode.ThreeG });
            optionMenu.addParam(new Param("Unsync", null, "UNSYNC", 3, 20))
                .addModesForParam("Unsync", new List<RadioStationMode> { RadioStationMode.ThreeG });
            optionMenu.addParam(new Param("Tod", null, "TOD", 4, 0));
            optionMenu.addParam(new Param("Todrole", null, "TODROLE", 4, 10))
                .addModesForParam("Todrole", new List<RadioStationMode> { RadioStationMode.ThreeG });
            optionMenu.addParam(new Param("NextPage", null, "->", 4, 22))
                .addModesForParam("NextPage", new List<RadioStationMode> { RadioStationMode.ThreeG });

            optionMenu.getParam("Lqa").IsActive = true;

            optionMenu.addActionToParam(optionMenu.getParam("Body"), new Button("LEFT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();

                if (activeParam == null)
                {
                    var param = wdg.getParam("Todrole");
                    wdg.deactiveParam();
                    param.IsActive = true;
                    return;
                }

                switch (activeParam.Name)
                {
                    case "Lqa":
                        {
                            wdg.deactiveParam();
                            wdg.prepareToShowWidget(getNameMenu(MenuNames.OptionThreeG2Menu));
                            wdg.getAvailableWidget(getNameMenu(MenuNames.OptionThreeG2Menu)).getParam("Linked").IsActive = true;
                            break;
                        }
                    case "Scores":
                        {
                            var param = wdg.getParam("Lqa");
                            wdg.deactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Unsync":
                        {
                            var param = wdg.getParam("Scores");
                            wdg.deactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Tod":
                        {
                            var param = wdg.getParam("Unsync");
                            wdg.deactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Todrole":
                        {
                            var param = wdg.getParam("Tod");
                            wdg.deactiveParam();
                            param.IsActive = true;
                            break;
                        }
                }

            }));
            optionMenu.addActionToParam(optionMenu.getParam("Body"), new Button("RIGTH", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();

                if (activeParam == null)
                {
                    var param = wdg.getParam("Lqa");
                    wdg.deactiveParam();
                    param.IsActive = true;
                    return;
                }

                switch (activeParam.Name)
                {
                    case "Lqa":
                        {
                            var param = wdg.getParam("Scores");
                            wdg.deactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Scores":
                        {
                            var param = wdg.getParam("Unsync");
                            wdg.deactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Unsync":
                        {
                            var param = wdg.getParam("Tod");
                            wdg.deactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Tod":
                        {
                            var param = wdg.getParam("Todrole");
                            wdg.deactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Todrole":
                        {
                            wdg.deactiveParam();
                            wdg.prepareToShowWidget(getNameMenu(MenuNames.OptionThreeG2Menu));
                            wdg.getAvailableWidget(getNameMenu(MenuNames.OptionThreeG2Menu)).getParam("Linked").IsActive = true;
                            break;
                        }
                }

            }));

            //optionMenu.addActionToParam(optionMenu.getParam("Scan"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            //{
            //    Param activeParam = wdg.activeParam();
            //    if (activeParam == null || activeParam.Name != "Scan")
            //    {
            //        return;
            //    }

            //    wdg.prepareToShowWidget(getNameMenu(MenuNames.OptionScanMenu));
            //}));

            optionMenu.addActionToParam(optionMenu.getParam("Body"), new Button("CLR", (Button btn, RadioStation rs, Widget wdg) =>
            {
                wdg.showPreviousWidget();
            }));

            return optionMenu;
        }

        static public Widget initOptionThreeG2Menu(RadioStation station)
        {
            Widget optionMenu = new Widget(getNameMenu(MenuNames.OptionThreeG2Menu));
            optionMenu.LineSize[0] = 5;
            optionMenu.LineSize[1] = 9;
            optionMenu.LineSize[2] = 9;
            optionMenu.LineSize[3] = 5;
            optionMenu.LineCharOffset[0] = 6;
            optionMenu.LineCharOffset[1] = 6;
            optionMenu.LineCharOffset[2] = 7;
            optionMenu.LineCharOffset[3] = 6;
            optionMenu
                .addParam(new Param("Body", null, "", 1, 0))
                .addModesForParam("Body", new List<RadioStationMode> { RadioStationMode.ThreeG });
            optionMenu.addParam(new Param("Title", null, "OPTIONS-3G", 1, 0))
                .addModesForParam("Title", new List<RadioStationMode> { RadioStationMode.ThreeG });
            optionMenu.addParam(new Param("EmptyLine", null, " ", 2, 0))
                .addModesForParam("EmptyLine", new List<RadioStationMode> { RadioStationMode.ThreeG });
            optionMenu.addParam(new Param("NextPage", null, "<-", 3, 0))
                .addModesForParam("NextPage", new List<RadioStationMode> { RadioStationMode.ThreeG });
            optionMenu.addParam(new Param("Linked", null, "LINKED", 3, 3))
                .addModesForParam("Linked", new List<RadioStationMode> { RadioStationMode.ThreeG });

            optionMenu.addActionToParam(optionMenu.getParam("Body"), new Button("LEFT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();

                if (activeParam == null)
                {
                    var param = wdg.getParam("Linked");
                    wdg.deactiveParam();
                    param.IsActive = true;
                    return;
                }

                wdg.ComeFrom.getParam("Todrole").IsActive = true;
                wdg.showPreviousWidget();
            }));
            optionMenu.addActionToParam(optionMenu.getParam("Body"), new Button("RIGTH", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();

                if (activeParam == null)
                {
                    var param = wdg.getParam("Linked");
                    wdg.deactiveParam();
                    param.IsActive = true;
                    return;
                }

                wdg.ComeFrom.getParam("Lqa").IsActive = true;
                wdg.showPreviousWidget();
            }));

            //optionMenu.addActionToParam(optionMenu.getParam("Scan"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            //{
            //    Param activeParam = wdg.activeParam();
            //    if (activeParam == null || activeParam.Name != "Scan")
            //    {
            //        return;
            //    }

            //    wdg.prepareToShowWidget(getNameMenu(MenuNames.OptionScanMenu));
            //}));

            optionMenu.addActionToParam(optionMenu.getParam("Body"), new Button("CLR", (Button btn, RadioStation rs, Widget wdg) =>
            {
                wdg.showPreviousWidget();
            }));


            return optionMenu;
        }

        static public Widget initOptionMsgMenu(RadioStation station)
        {

            Widget optionMenu = new Widget(getNameMenu(MenuNames.OptionMsgMenu));
            optionMenu.LineSize[0] = 5;
            optionMenu.LineSize[1] = 9;
            optionMenu.LineSize[2] = 9;
            optionMenu.LineSize[3] = 5;
            optionMenu.LineCharOffset[0] = 6;
            optionMenu.LineCharOffset[1] = 6;
            optionMenu.LineCharOffset[2] = 7;
            optionMenu.LineCharOffset[3] = 6;
            optionMenu
                .addParam(new Param("Body", null, "", 1, 0))
                .addModesForParam("Body", new List<RadioStationMode> { RadioStationMode.ThreeG });
            optionMenu.addParam(new Param("Title", null, "OPTIONS-MSG", 1, 0))
                .addModesForParam("Title", new List<RadioStationMode> { RadioStationMode.ThreeG });
            optionMenu.addParam(new Param("EmptyLine", null, " ", 2, 0))
                .addModesForParam("EmptyLine", new List<RadioStationMode> { RadioStationMode.ThreeG });
            optionMenu.addParam(new Param("Lvd", null, "LVD", 3, 0))
                .addModesForParam("Lvd", new List<RadioStationMode> { RadioStationMode.ThreeG });
            optionMenu.addParam(new Param("Sms", null, "SMS", 3, 15))
                .addModesForParam("Sms", new List<RadioStationMode> { RadioStationMode.ThreeG });

            optionMenu.getParam("Lvd").IsActive = true;

            optionMenu.addActionToParam(optionMenu.getParam("Body"), new Button("LEFT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();

                if (activeParam == null)
                {
                    var param = wdg.getParam("Lvd");
                    wdg.deactiveParam();
                    param.IsActive = true;
                    return;
                }

                switch (activeParam.Name)
                {
                    case "Lvd":
                        {
                            wdg.deactiveParam();
                            var param = wdg.getParam("Sms");
                            param.IsActive = true;
                            break;
                        }
                    case "Sms":
                        {
                            wdg.deactiveParam();
                            var param = wdg.getParam("Lvd");
                            param.IsActive = true;
                            break;
                        }
                }

            }));
            optionMenu.addActionToParam(optionMenu.getParam("Body"), new Button("RIGTH", (Button btn, RadioStation rs, Widget wdg) =>
            {

                var activeParam = wdg.activeParam();

                if (activeParam == null)
                {
                    var param = wdg.getParam("Sms");
                    wdg.deactiveParam();
                    param.IsActive = true;
                    return;
                }

                switch (activeParam.Name)
                {
                    case "Lvd":
                        {
                            wdg.deactiveParam();
                            var param = wdg.getParam("Sms");
                            param.IsActive = true;
                            break;
                        }
                    case "Sms":
                        {
                            wdg.deactiveParam();
                            var param = wdg.getParam("Lvd");
                            param.IsActive = true;
                            break;
                        }
                }

            }));

            optionMenu.addActionToParam(optionMenu.getParam("Sms"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                Param activeParam = wdg.activeParam();
                if (activeParam == null || activeParam.Name != "Sms")
                {
                    return;
                }

                wdg.prepareToShowWidget(getNameMenu(MenuNames.OptionMsgSmsMenu));
            }));

            optionMenu.addActionToParam(optionMenu.getParam("Body"), new Button("CLR", (Button btn, RadioStation rs, Widget wdg) =>
            {
                wdg.showPreviousWidget();
            }));

            return optionMenu;
        }

        static public Widget initOptionMsgSmsMenu(RadioStation station)
        {
            var smsMenu = new Widget(getNameMenu(MenuNames.OptionMsgSmsMenu));

            smsMenu.LineSize[0] = 5;
            smsMenu.LineSize[1] = 9;
            smsMenu.LineSize[2] = 9;
            smsMenu.LineSize[3] = 5;
            smsMenu.LineCharOffset[0] = 6;
            smsMenu.LineCharOffset[1] = 6;
            smsMenu.LineCharOffset[2] = 7;
            smsMenu.LineCharOffset[3] = 6;
            smsMenu
                .addParam(new Param("Body", null, "", 1, 0))
                .addModesForParam("Body", new List<RadioStationMode> { RadioStationMode.ThreeG });
            
            smsMenu.addParam(new Param("Title", null, "↑↓ TO BROWSE RECEIVED MSGS", 1, 0, () => {
                Param activeSms = smsMenu.getActiveParamsBy(pr => {
                    return pr.X == 4;
                })[0];
                Param title = smsMenu.getParam("Title");
                switch (activeSms.Name)
                {
                    case "Select":
                        {
                            title.Text = "↑↓ TO BROWSE RECEIVED MSGS";
                            break;
                        }
                    case "New":
                        {
                            title.Text = "ENTER FOR NEW MSGS";
                            break;
                        }
                    case "Delete_all":
                        {
                            title.Text = "ENTER TO DELETE MSGS";
                            break;
                        }
                }
            }))
                .addModesForParam("Title", new List<RadioStationMode> { RadioStationMode.ThreeG });
            
            smsMenu
                .addParam(new Param("MsgLine1", null, "", 2, 0, () => {
                    smsMenu.getParam("MsgLine1").Text = smsControls.getPair().Item1;
            }))
                .addModesForParam("MsgLine1", new List<RadioStationMode> { RadioStationMode.ThreeG });
            smsMenu
                .addParam(new Param("MsgLine2", null, "", 3, 0, () => {
                    smsMenu.getParam("MsgLine2").Text = smsControls.getPair().Item2;
                }))
                .addModesForParam("MsgLine2", new List<RadioStationMode> { RadioStationMode.ThreeG });
            
            smsMenu.addParam(new Param("Select", null, "SELECT", 4, 0))
                .addModesForParam("Select", new List<RadioStationMode> { RadioStationMode.ThreeG });
            smsMenu.addParam(new Param("New", null, "NEW", 4, 10))
                .addModesForParam("New", new List<RadioStationMode> { RadioStationMode.ThreeG });
            smsMenu.addParam(new Param("Delete_all", null, "DELETE_ALL", 4, 15))
                .addModesForParam("Delete_all", new List<RadioStationMode> { RadioStationMode.ThreeG });

            smsMenu.getParam("MsgLine1").IsActive = true;
            smsMenu.getParam("Select").IsActive = true;

            smsMenu.addActionToParam(smsMenu.getParam("Body"), new Button("DOWN", (Button btn, RadioStation rs, Widget wdg) => {
                Param activeSms = wdg.getActiveParamsBy(pr => {
                    return pr.X == 2 || pr.X == 3;
                })[0];

                if (activeSms.Name == "MsgLine1")
                {
                    activeSms.IsActive = false;
                    wdg.getParam("MsgLine2").IsActive = true;
                } 
                else
                {
                    activeSms.IsActive = false;
                    wdg.getParam("MsgLine1").IsActive = true;
                }

                smsControls.next();
            }));
            smsMenu.addActionToParam(smsMenu.getParam("Body"), new Button("UP", (Button btn, RadioStation rs, Widget wdg) => {
                Param activeSms = wdg.getActiveParamsBy(pr => {
                    return pr.X == 2 || pr.X == 3;
                })[0];

                if (activeSms.Name == "MsgLine1")
                {
                    activeSms.IsActive = false;
                    wdg.getParam("MsgLine2").IsActive = true;
                }
                else
                {
                    activeSms.IsActive = false;
                    wdg.getParam("MsgLine1").IsActive = true;
                }

                smsControls.previous();
            }));


            smsMenu.addActionToParam(smsMenu.getParam("Body"), new Button("LEFT", (Button btn, RadioStation rs, Widget wdg) => {
                Param activeSms = wdg.getActiveParamsBy(pr => {
                    return pr.X == 4;
                })[0];

                switch (activeSms.Name)
                {
                    case "Select":
                        {
                            activeSms.IsActive = false;
                            var param = wdg.getParam("Delete_all");
                            param.IsActive = true;
                            break;
                        }
                    case "New":
                        {
                            activeSms.IsActive = false;
                            var param = wdg.getParam("Select");
                            param.IsActive = true;
                            break;
                        }
                    case "Delete_all":
                        {
                            activeSms.IsActive = false;
                            var param = wdg.getParam("New");
                            param.IsActive = true;
                            break;
                        }
                }
            }));

            smsMenu.addActionToParam(smsMenu.getParam("Body"), new Button("RIGTH", (Button btn, RadioStation rs, Widget wdg) => {
                Param activeSms = wdg.getActiveParamsBy(pr => {
                    return pr.X == 4;
                })[0];

                switch (activeSms.Name)
                {
                    case "Select":
                        {
                            activeSms.IsActive = false;
                            var param = wdg.getParam("New");
                            param.IsActive = true;
                            break;
                        }
                    case "New":
                        {
                            activeSms.IsActive = false;
                            var param = wdg.getParam("Delete_all");
                            param.IsActive = true;
                            break;
                        }
                    case "Delete_all":
                        {
                            activeSms.IsActive = false;
                            var param = wdg.getParam("Select");
                            param.IsActive = true;
                            break;
                        }
                }
            }));

            smsMenu.addActionToParam(smsMenu.getParam("Body"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) => {
                Param activeSms = wdg.getActiveParamsBy(pr => {
                    return pr.X == 4;
                })[0];

                switch (activeSms.Name)
                {
                    case "Select":
                        {

                            break;
                        }
                    case "New":
                        {
                            wdg.prepareToShowWidget(getNameMenu(MenuNames.OptionMsgSmsFunctionsMenu));
                            break;
                        }
                    case "Delete_all":
                        {
                            break;
                        }
                }
            }));

            return smsMenu;
        }

        static public Widget initOptionMsgSmsFunctionsMenu(RadioStation station)
        {
            Widget optionMenu = new Widget(getNameMenu(MenuNames.OptionMenuRadio));

            optionMenu.LineSize[0] = 5;
            optionMenu.LineSize[1] = 9;
            optionMenu.LineSize[2] = 9;
            optionMenu.LineSize[3] = 5;
            optionMenu.LineCharOffset[0] = 6;
            optionMenu.LineCharOffset[1] = 6;
            optionMenu.LineCharOffset[2] = 7;
            optionMenu.LineCharOffset[3] = 6;
            optionMenu.addParam(new Param("Body", null, "", 1, 0));
            optionMenu.addParam(new Param("Title", null, "", 1, 0));
            optionMenu.addParam(new Param("SmsTitle", null, "MESSAGE TYPE", 2, 7));
            optionMenu.addParam(new Param("SmsValue", null, "NEW MSG", 3, 9));
            optionMenu.addParam(new Param("Info", null, "PRESS ↑↓ TO SCROLL", 4, 15));

            optionMenu.getParam("SmsValue").IsActive = true;

            WidgetTextParams smsFunctions = new WidgetTextParams("MESSAGE TYPE");
            smsFunctions.addParam("NEW MSG").addParam("CANNED MSG").addParam("LAST SEND MSG").addParam("LAST ENTERED MSG");

            List<WidgetTextParams> radioParams = new List<WidgetTextParams>();
            radioParams.Add(smsFunctions);


            optionMenu.addActionToParam(optionMenu.getParam("SmsValue"), new Button("DOWN", (Button btn, RadioStation rs, Widget wdg) =>
            {
                Param activeParam = wdg.activeParam();
                Param titleParam = wdg.getParam("SmsTitle");

                string paramTitle = titleParam.Text;

                activeParam.Text = radioParams.Find(p => p.Name == paramTitle).getPrevParam();
                activeParam.ActiveTo = activeParam.Text.Length;
                activeParam.Y = Helper.calcCenterIndent(activeParam.Text.Length, 28);
                titleParam.Y = Helper.calcCenterIndent(titleParam.Text.Length, 28);
            }));

            optionMenu.addActionToParam(optionMenu.getParam("SmsValue"), new Button("UP", (Button btn, RadioStation rs, Widget wdg) =>
            {
                Param activeParam = wdg.activeParam();
                Param titleParam = wdg.getParam("SmsTitle");

                string paramTitle = titleParam.Text;

                activeParam.Text = radioParams.Find(p => p.Name == paramTitle).getNextParam();
                activeParam.ActiveTo = activeParam.Text.Length;
                activeParam.Y = Helper.calcCenterIndent(activeParam.Text.Length, 28);
                titleParam.Y = Helper.calcCenterIndent(titleParam.Text.Length, 28);
            }));

            optionMenu.addActionToParam(optionMenu.getParam("Body"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                Param activeParam = wdg.activeParam();

                switch(activeParam.Text)
                {
                    case "NEW MSG":
                        {
                            wdg.prepareToShowWidget(getNameMenu(MenuNames.OptionMsgEnterSmsMenu));
                            break;
                        }
                }
            }));

            optionMenu.addActionToParam(optionMenu.getParam("Body"), new Button("CLR", (Button btn, RadioStation rs, Widget wdg) =>
            {
                wdg.showPreviousWidget();
            }));

            return optionMenu;
        }

        static public Widget initOptionMsgNewSmsMenu(RadioStation station)
        {
            Widget enterMsgMenu = new Widget(getNameMenu(MenuNames.OptionMsgMenu));
            enterMsgMenu.LineSize[0] = 5;
            enterMsgMenu.LineSize[1] = 9;
            enterMsgMenu.LineSize[2] = 9;
            enterMsgMenu.LineSize[3] = 5;
            enterMsgMenu.LineCharOffset[0] = 6;
            enterMsgMenu.LineCharOffset[1] = 6;
            enterMsgMenu.LineCharOffset[2] = 7;
            enterMsgMenu.LineCharOffset[3] = 6;
            enterMsgMenu
                .addParam(new Param("Body", null, "", 1, 0))
                .addModesForParam("Body", new List<RadioStationMode> { RadioStationMode.ThreeG });
            enterMsgMenu.addParam(new Param("Title", null, "USE ⟳ FOR MORE OPTIONS", 1, 0))
                .addModesForParam("Title", new List<RadioStationMode> { RadioStationMode.ThreeG });
            enterMsgMenu
                .addParam(new Param("LineOne", (string text, Param cParam) =>
            {
                cParam.text = cParam.Text.Remove(cParam.ActiveFrom, cParam.ActiveTo);
                cParam.text = cParam.Text.Insert(cParam.ActiveFrom, text);

            }, "                    ", 2, 0))
                .addModesForParam("LineOne", new List<RadioStationMode> { RadioStationMode.ThreeG });
            enterMsgMenu
                .addParam(new Param("LineTwo", (string text, Param cParam) =>
            {
                cParam.text = cParam.Text.Remove(cParam.ActiveFrom, cParam.ActiveTo);
                cParam.text = cParam.Text.Insert(cParam.ActiveFrom, text);

            }, "                    ", 3, 0))
                .addModesForParam("LineTwo", new List<RadioStationMode> { RadioStationMode.ThreeG });
            enterMsgMenu
                .addParam(new Param("Enter", null, "PRESS ENTER TO SEND MESSAGE", 4, 0))
                .addModesForParam("Enter", new List<RadioStationMode> { RadioStationMode.ThreeG });

            enterMsgMenu.addActionToParam(enterMsgMenu.getParam("Body"), new Button("LEFT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();

                if (activeParam == null)
                {
                    var param = wdg.getParam("LineOne");
                    wdg.deactiveParam();
                    param.IsActive = true;
                    param.ActiveFrom = 0;
                    param.ActiveTo = 1;
                    return;
                }

                if (activeParam.isInParam())
                {
                    if (activeParam.ActiveFrom >= 0)
                    {
                        activeParam.ActiveFrom -= 1;
                        activeParam.ActiveTo = 1;
                    }
                    else
                    {
                        activeParam.IsActive = false;
                        wdg.getParam("LineOne").IsActive = true;
                        wdg.getParam("LineOne").ActiveFrom = 0;
                        wdg.getParam("LineOne").ActiveTo = 1;
                    }
                    return;
                }

            }));

            enterMsgMenu.addActionToParam(enterMsgMenu.getParam("Body"), new Button("RIGTH", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();

                if (activeParam == null)
                {
                    var param = wdg.getParam("LineOne");
                    wdg.deactiveParam();
                    param.IsActive = true;
                    param.ActiveFrom = 0;
                    param.ActiveTo = 1;
                    return;
                }

                if (activeParam.isInParam())
                {
                    if (activeParam.ActiveFrom < 20)
                    {
                        activeParam.ActiveFrom += 1;
                        activeParam.ActiveTo = 1;
                    } 
                    else
                    {
                        activeParam.IsActive = false;
                        wdg.getParam("LineTwo").IsActive = true;
                        wdg.getParam("LineTwo").ActiveFrom = 0;
                        wdg.getParam("LineTwo").ActiveTo = 1;
                    }
                    return;
                }

            }));
            enterMsgMenu.addActionToParam(enterMsgMenu.getParam("Body"), new Button("CALL", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();
                
                if (activeParam == null)
                {
                    activeParam = wdg.getParam("LineOne");
                    wdg.deactiveParam();
                    activeParam.IsActive = true;
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }

                if (!activeParam.isInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                string symbols = "1ABC";
                string currentSymbol = activeParam.getActiveText();
                int index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                } 
                string nextSymbol = symbols.Substring(index, 1);
                activeParam.action(nextSymbol);

            }));
            enterMsgMenu.addActionToParam(enterMsgMenu.getParam("Body"), new Button("LT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();

                if (activeParam == null)
                {
                    activeParam = wdg.getParam("LineOne");
                    wdg.deactiveParam();
                    activeParam.IsActive = true;
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }

                if (!activeParam.isInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                string symbols = "2DEF";
                string currentSymbol = activeParam.getActiveText();
                int index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                }
                string nextSymbol = symbols.Substring(index, 1);
                activeParam.action(nextSymbol);

            }));
            enterMsgMenu.addActionToParam(enterMsgMenu.getParam("Body"), new Button("MODE", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();

                if (activeParam == null)
                {
                    activeParam = wdg.getParam("LineOne");
                    wdg.deactiveParam();
                    activeParam.IsActive = true;
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }

                if (!activeParam.isInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                string symbols = "3GHI";
                string currentSymbol = activeParam.getActiveText();
                int index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                }
                string nextSymbol = symbols.Substring(index, 1);
                activeParam.action(nextSymbol);

            }));
            enterMsgMenu.addActionToParam(enterMsgMenu.getParam("Body"), new Button("SQL", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();

                if (activeParam == null)
                {
                    activeParam = wdg.getParam("LineOne");
                    wdg.deactiveParam();
                    activeParam.IsActive = true;
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }

                if (!activeParam.isInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                string symbols = "4JKL";
                string currentSymbol = activeParam.getActiveText();
                int index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                }
                string nextSymbol = symbols.Substring(index, 1);
                activeParam.action(nextSymbol);

            }));
            enterMsgMenu.addActionToParam(enterMsgMenu.getParam("Body"), new Button("ZERO", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();

                if (activeParam == null)
                {
                    activeParam = wdg.getParam("LineOne");
                    wdg.deactiveParam();
                    activeParam.IsActive = true;
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }

                if (!activeParam.isInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                string symbols = "5MNO";
                string currentSymbol = activeParam.getActiveText();
                int index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                }
                string nextSymbol = symbols.Substring(index, 1);
                activeParam.action(nextSymbol);

            }));
            enterMsgMenu.addActionToParam(enterMsgMenu.getParam("Body"), new Button("UP", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();

                if (activeParam == null)
                {
                    activeParam = wdg.getParam("LineOne");
                    wdg.deactiveParam();
                    activeParam.IsActive = true;
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }

                if (!activeParam.isInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                string symbols = "6PQR";
                string currentSymbol = activeParam.getActiveText();
                int index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                }
                string nextSymbol = symbols.Substring(index, 1);
                activeParam.action(nextSymbol);
            }));
            enterMsgMenu.addActionToParam(enterMsgMenu.getParam("Body"), new Button("OPT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();

                if (activeParam == null)
                {
                    activeParam = wdg.getParam("LineOne");
                    wdg.deactiveParam();
                    activeParam.IsActive = true;
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }

                if (!activeParam.isInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                string symbols = "7STU";
                string currentSymbol = activeParam.getActiveText();
                int index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                }
                string nextSymbol = symbols.Substring(index, 1);
                activeParam.action(nextSymbol);

            }));
            enterMsgMenu.addActionToParam(enterMsgMenu.getParam("Body"), new Button("PGM", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();

                if (activeParam == null)
                {
                    activeParam = wdg.getParam("LineOne");
                    wdg.deactiveParam();
                    activeParam.IsActive = true;
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }

                if (!activeParam.isInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                string symbols = "8VWX";
                string currentSymbol = activeParam.getActiveText();
                int index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                }
                string nextSymbol = symbols.Substring(index, 1);
                activeParam.action(nextSymbol);

            }));
            enterMsgMenu.addActionToParam(enterMsgMenu.getParam("Body"), new Button("DOWN", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();

                if (activeParam == null)
                {
                    activeParam = wdg.getParam("LineOne");
                    wdg.deactiveParam();
                    activeParam.IsActive = true;
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }

                if (!activeParam.isInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                string symbols = "9YZ?";
                string currentSymbol = activeParam.getActiveText();
                int index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                }
                string nextSymbol = symbols.Substring(index, 1);
                activeParam.action(nextSymbol);

            }));
            enterMsgMenu.addActionToParam(enterMsgMenu.getParam("Body"), new Button("UPDATE", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();

                if (activeParam == null
                    || activeParam.Name != "ChanValue")
                {
                    return;
                }

                if (!activeParam.isInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }

                activeParam.action("0");

            }));

            enterMsgMenu.addActionToParam(enterMsgMenu.getParam("Body"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                string lineOne = wdg.getParam("LineOne").Text.Trim(new char[] { ' ' });
                string lineTwo = wdg.getParam("LineTwo").Text.Trim(new char[] { ' ' });
                smsControls.NumberSms[smsControls.CurrentIndex] = lineOne + lineTwo;

                wdg.prepareToShowWidget(getNameMenu(MenuNames.OptionMsgSmsSendingMenu));
            }));

            enterMsgMenu.addActionToParam(enterMsgMenu.getParam("Body"), new Button("CLR", (Button btn, RadioStation rs, Widget wdg) =>
            {
                wdg.showPreviousWidget();
            }));

            return enterMsgMenu;
        }

        static public Widget initOptionMsgSmsSendingMenu(RadioStation station)
        {
            Widget optionMenu = new Widget("optionMsgSmsSendingMenu");

            optionMenu.LineSize[0] = 5;
            optionMenu.LineSize[1] = 9;
            optionMenu.LineSize[2] = 9;
            optionMenu.LineSize[3] = 5;
            optionMenu.LineCharOffset[0] = 6;
            optionMenu.LineCharOffset[1] = 6;
            optionMenu.LineCharOffset[2] = 7;
            optionMenu.LineCharOffset[3] = 6;
            optionMenu.addParam(new Param("Body", null, "", 1, 0));
            optionMenu.addParam(new Param("Title", null, "", 1, 0));
            optionMenu.addParam(new Param("SendingTitle", null, "SEND TO", 2, 9));
            optionMenu.addParam(new Param("SendingValue", null, "STATION", 3, 9));
            optionMenu.addParam(new Param("Info", null, "PRESS ↑↓ TO SCROLL", 4, 15));

            optionMenu.getParam("SendingValue").IsActive = true;

            WidgetTextParams smsFunctions = new WidgetTextParams("SEND TO");
            smsFunctions.addParam("STATION").addParam("NET"); 
            WidgetTextParams stationAddress = new WidgetTextParams("STATION ADDRESS");
            stationAddress.addParam("7800H2");

            List<WidgetTextParams> radioParams = new List<WidgetTextParams>();
            radioParams.Add(smsFunctions); 
            radioParams.Add(stationAddress);


            optionMenu.addActionToParam(optionMenu.getParam("SendingValue"), new Button("DOWN", (Button btn, RadioStation rs, Widget wdg) =>
            {
                Param activeParam = wdg.activeParam();
                Param titleParam = wdg.getParam("SendingTitle");

                string paramTitle = titleParam.Text;

                activeParam.Text = radioParams.Find(p => p.Name == paramTitle).getPrevParam();
                activeParam.ActiveTo = activeParam.Text.Length;
                activeParam.Y = Helper.calcCenterIndent(activeParam.Text.Length, 28);
                titleParam.Y = Helper.calcCenterIndent(titleParam.Text.Length, 28);
            }));

            optionMenu.addActionToParam(optionMenu.getParam("SendingValue"), new Button("UP", (Button btn, RadioStation rs, Widget wdg) =>
            {
                Param activeParam = wdg.activeParam();
                Param titleParam = wdg.getParam("SendingTitle");

                string paramTitle = titleParam.Text;

                activeParam.Text = radioParams.Find(p => p.Name == paramTitle).getNextParam();
                activeParam.ActiveTo = activeParam.Text.Length;
                activeParam.Y = Helper.calcCenterIndent(activeParam.Text.Length, 28);
                titleParam.Y = Helper.calcCenterIndent(titleParam.Text.Length, 28);
            }));

            optionMenu.addActionToParam(optionMenu.getParam("Body"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                Param activeParam = wdg.activeParam();
                Param titleParam = wdg.getParam("SendingTitle");

                if (titleParam.Text == "STATION ADDRESS")
                {
                    widgetContainer[getNameMenu(MenuNames.MainMenu)].MoveTo = null;
                    Form1.currObject.QueueWidget.add(initSentMessageTransition());
                    Form1.currObject.QueueWidget.add(widgetContainer[getNameMenu(MenuNames.MainMenu)]);
                    Form1.currObject.startShowWidgetQueue();
                    return;
                }

                titleParam.Text = stationAddress.Name;
                activeParam.Text = stationAddress.currParam();
                
            }));

            optionMenu.addActionToParam(optionMenu.getParam("Body"), new Button("CLR", (Button btn, RadioStation rs, Widget wdg) =>
            {
                wdg.showPreviousWidget();

                Param activeParam = wdg.activeParam();
                Param titleParam = wdg.getParam("SendingTitle");

                activeParam.Text = radioParams[0].currParam();
                titleParam.Text = radioParams[0].Name;
                activeParam.Y = Helper.calcCenterIndent(activeParam.Text.Length, 28);
                titleParam.Y = Helper.calcCenterIndent(titleParam.Text.Length, 28);
            }));

            return optionMenu;
        }

        static public Widget initSentMessageTransition()
        {

            Widget optionMenu = new Widget("sentMessageTransition");

            optionMenu.LineSize[0] = 5;
            optionMenu.LineSize[1] = 9;
            optionMenu.LineSize[2] = 9;
            optionMenu.LineSize[3] = 5;
            optionMenu.LineCharOffset[0] = 6;
            optionMenu.LineCharOffset[1] = 6;
            optionMenu.LineCharOffset[2] = 7;
            optionMenu.LineCharOffset[3] = 6;
            optionMenu.addParam(new Param("Body", null, "", 1, 0));
            optionMenu.addParam(new Param("Title", null, "", 1, 0));
            optionMenu.addParam(new Param("SendingTitle", null, "", 2, 7));
            optionMenu.addParam(new Param("SendingValue", null, "MESSAGE SENT TO", 3, 7));


            return optionMenu;

        }

        static public Widget initAleSelfAddressMenu(RadioStation station)
        {

            Widget optionMenu = new Widget("initAleFillMenu");

            optionMenu.LineSize[0] = 5;
            optionMenu.LineSize[1] = 9;
            optionMenu.LineSize[2] = 9;
            optionMenu.LineSize[3] = 5;
            optionMenu.LineCharOffset[0] = 6;
            optionMenu.LineCharOffset[1] = 6;
            optionMenu.LineCharOffset[2] = 7;
            optionMenu.LineCharOffset[3] = 6;
            optionMenu.addParam(new Param("Body", null, "", 1, 0));
            optionMenu.addParam(new Param("StationRTmode", null, "R", 1, 0))
                .addModesForParam("StationRTmode", new List<RadioStationMode> { RadioStationMode.ThreeG });
            optionMenu.addParam(new Param("Battery", null, "BAT ■■■■■", 1, 2))
                .addModesForParam("Battery", new List<RadioStationMode> { RadioStationMode.ThreeG });
            optionMenu
                .addParam(new Param("StationMode", null, "ALE", 1, 10, () =>
                {
                    optionMenu.getParam("StationMode").Text = Enum.GetName(typeof(RadioStationMode), station.Mode);
                }))
                .addModesForParam("Battery", new List<RadioStationMode> { RadioStationMode.ThreeG }); ;
            optionMenu
                .addParam(new Param("SQ", null, "SQ", 1, 14))
                .addModesForParam("Battery", new List<RadioStationMode> { RadioStationMode.ThreeG }); ;
            optionMenu
                .addParam(new Param("SwitchState", null, "PT", 1, 17, () =>
                {
                    optionMenu.getParam("SwitchState").Text = Enum.GetName(typeof(SwitcherState), station.getState());
                }))
                .addModesForParam("Battery", new List<RadioStationMode> { RadioStationMode.ThreeG });
            optionMenu.addParam(new Param("InfoOne", null, "SELF ADDRESS", 2, 8));
            optionMenu.addParam(new Param("InfoTwo", null, "NO 1-3 CHAR DEFAULT", 3, 5));
            optionMenu.addParam(new Param("InfoBottom", null, "WAIT OR PRESS CLR/ENT TO CLEAR", 4, 9));

            optionMenu.addActionToParam(optionMenu.getParam("Body"), new Button("CLR", (Button btn, RadioStation rs, Widget wdg) =>
            {
                widgetContainer[getNameMenu(MenuNames.MainMenu)].MoveTo = null;
                Form1.currObject.QueueWidget.add(widgetContainer[getNameMenu(MenuNames.MainMenu)]);
                Form1.currObject.startShowWidgetQueue();
            }));
            optionMenu.addActionToParam(optionMenu.getParam("Body"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                widgetContainer[getNameMenu(MenuNames.MainMenu)].MoveTo = null;
                Form1.currObject.QueueWidget.add(widgetContainer[getNameMenu(MenuNames.MainMenu)]);
                Form1.currObject.startShowWidgetQueue();
            }));

            return optionMenu;

        }

        static public Widget initOptionAleMenu(RadioStation station)
        {

            Widget optionMenu = new Widget(getNameMenu(MenuNames.OptionAleMenu));
            
            optionMenu.LineSize[0] = 5;
            optionMenu.LineSize[1] = 9;
            optionMenu.LineSize[2] = 9;
            optionMenu.LineSize[3] = 5;
            optionMenu.LineCharOffset[0] = 6;
            optionMenu.LineCharOffset[1] = 6;
            optionMenu.LineCharOffset[2] = 7;
            optionMenu.LineCharOffset[3] = 6;

            optionMenu.addParam(new Param("Body", null, "", 1, 0));
            optionMenu.addParam(new Param("Title", null, "OPTIONS-ALE", 1, 0));
            //optionMenu.addParam(new Param("EmptyLine", null, " ", 2, 0));
            optionMenu.addParam(new Param("Lqa", null, "LQA", 2, 0));
            optionMenu.addParam(new Param("Scores", null, "SCORES", 2, 10));
            optionMenu.addParam(new Param("Tx-msg", null, "TX-MSG", 3, 0));
            optionMenu.addParam(new Param("Rx-msg", null, "RX-MSG", 3, 10));
            optionMenu.getParam("Lqa").IsActive = true;

            optionMenu.addActionToParam(optionMenu.getParam("Body"), new Button("LEFT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();

                if (activeParam == null)
                {
                    var param = wdg.getParam("Rx-msg");
                    wdg.deactiveParam();
                    param.IsActive = true;
                    return;
                }

                switch (activeParam.Name)
                {
                    case "Lqa":
                        {
                            var param = wdg.getParam("Rx-msg");
                            wdg.deactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Scores":
                        {
                            var param = wdg.getParam("Lqa");
                            wdg.deactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Tx-msg":
                        {
                            var param = wdg.getParam("Scores");
                            wdg.deactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Rx-msg":
                        {
                            var param = wdg.getParam("Tx-msg");
                            wdg.deactiveParam();
                            param.IsActive = true;
                            break;
                        }
                }

            }));
            optionMenu.addActionToParam(optionMenu.getParam("Body"), new Button("RIGTH", (Button btn, RadioStation rs, Widget wdg) =>
            {

                var activeParam = wdg.activeParam();

                if (activeParam == null)
                {
                    var param = wdg.getParam("Lqa");
                    wdg.deactiveParam();
                    param.IsActive = true;
                    return;
                }

                switch (activeParam.Name)
                {
                    case "Lqa":
                        {
                            var param = wdg.getParam("Scores");
                            wdg.deactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Scores":
                        {
                            var param = wdg.getParam("Tx-msg");
                            wdg.deactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Tx-msg":
                        {
                            var param = wdg.getParam("Rx-msg");
                            wdg.deactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Rx-msg":
                        {
                            var param = wdg.getParam("Lqa");
                            wdg.deactiveParam();
                            param.IsActive = true;
                            break;
                        }
                }

            }));

            optionMenu.addActionToParam(optionMenu.getParam("Lqa"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                if (wdg.activeParam() == null 
                || wdg.activeParam().Name != "Lqa")
                {
                    return;
                }

                wdg.prepareToShowWidget(getNameMenu(MenuNames.OptionAleLqaMenu));
            }));

            optionMenu.addActionToParam(optionMenu.getParam("Body"), new Button("CLR", (Button btn, RadioStation rs, Widget wdg) =>
            {
                wdg.showPreviousWidget();
            }));

            optionMenu.addActionToParam(optionMenu.getParam("Tx-msg"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                if (wdg.activeParam() == null
                || wdg.activeParam().Name != "Tx-msg")
                {
                    return;
                }

                var txMsg = initOptionAleTxMsgMenu(station);
                txMsg.comeFrom = optionMenu;
                Form1.currObject.QueueWidget.add(txMsg);
                if (station.TxMsgs.Msgs.Count < 0)
                {
                    Form1.currObject.QueueWidget.add(wdg);
                }
                Form1.currObject.startShowWidgetQueue();
            }));
            return optionMenu;
        }

        static public Widget initOptionAleLqaMenu(RadioStation station)
        {

            Widget optionMenu = new Widget(getNameMenu(MenuNames.OptionAleLqaMenu));

            optionMenu.LineSize[0] = 5;
            optionMenu.LineSize[1] = 9;
            optionMenu.LineSize[2] = 9;
            optionMenu.LineSize[3] = 5;
            optionMenu.LineCharOffset[0] = 6;
            optionMenu.LineCharOffset[1] = 6;
            optionMenu.LineCharOffset[2] = 7;
            optionMenu.LineCharOffset[3] = 6;

            optionMenu.addParam(new Param("Body", null, "", 1, 0));
            optionMenu.addParam(new Param("Title", null, "OPTIONS-ALE-LQA", 1, 0));
            optionMenu.addParam(new Param("EmptyLine", null, " ", 2, 0));
            optionMenu.addParam(new Param("Exchange", null, "EXCHANGE", 3, 0));
            optionMenu.addParam(new Param("Sound", null, "SOUND", 3, 15));
            optionMenu.getParam("Exchange").IsActive = true;

            optionMenu.addActionToParam(optionMenu.getParam("Body"), new Button("LEFT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();

                if (activeParam == null)
                {
                    var param = wdg.getParam("Sound");
                    wdg.deactiveParam();
                    param.IsActive = true;
                    return;
                }

                switch (activeParam.Name)
                {
                    case "Exchange":
                        {
                            var param = wdg.getParam("Sound");
                            wdg.deactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Sound":
                        {
                            var param = wdg.getParam("Exchange");
                            wdg.deactiveParam();
                            param.IsActive = true;
                            break;
                        }
                }

            }));
            optionMenu.addActionToParam(optionMenu.getParam("Body"), new Button("RIGTH", (Button btn, RadioStation rs, Widget wdg) =>
            {

                var activeParam = wdg.activeParam();

                if (activeParam == null)
                {
                    var param = wdg.getParam("Exchange");
                    wdg.deactiveParam();
                    param.IsActive = true;
                    return;
                }

                switch (activeParam.Name)
                {
                    case "Exchange":
                        {
                            var param = wdg.getParam("Sound");
                            wdg.deactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Sound":
                        {
                            var param = wdg.getParam("Exchange");
                            wdg.deactiveParam();
                            param.IsActive = true;
                            break;
                        }
                }
            }));

            optionMenu.addActionToParam(optionMenu.getParam("Exchange"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {

                var activeParam = wdg.activeParam();

                if (activeParam == null || activeParam.Name == "Exchange")
                {
                    return;
                }

                wdg.prepareToShowWidget(getNameMenu(MenuNames.OptionAleLqaExchangeMenu));

            }));

            optionMenu.addActionToParam(optionMenu.getParam("Sound"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {

                var activeParam = wdg.activeParam();

                if (activeParam == null || activeParam.Name == "Sound")
                {
                    return;
                }

                wdg.prepareToShowWidget(getNameMenu(MenuNames.OptionAleLqaExchangeMenu));

            }));
            optionMenu.addActionToParam(optionMenu.getParam("Body"), new Button("CLR", (Button btn, RadioStation rs, Widget wdg) =>
            {
                wdg.showPreviousWidget();
            }));

            return optionMenu;
        }
        static public Widget initOptionAleLqaExchangeMenu(RadioStation station)
        {

            Widget optionMenu = new Widget(getNameMenu(MenuNames.OptionAleLqaExchangeMenu));

            optionMenu.LineSize[0] = 5;
            optionMenu.LineSize[1] = 9;
            optionMenu.LineSize[2] = 9;
            optionMenu.LineSize[3] = 5;
            optionMenu.LineCharOffset[0] = 6;
            optionMenu.LineCharOffset[1] = 6;
            optionMenu.LineCharOffset[2] = 7;
            optionMenu.LineCharOffset[3] = 6;

            optionMenu.addParam(new Param("Body", null, "", 1, 0)); 
            optionMenu.addParam(new Param("StationRTmode", null, "R", 1, 0));
            optionMenu.addParam(new Param("Battery", null, "BAT ■■■■■", 1, 2));
            optionMenu.addParam(new Param("StationMode", null, "ALE", 1, 10));
            optionMenu.addParam(new Param("SQ", null, "SQ", 1, 14));
            optionMenu.addParam(new Param("SwitchState", null, "PT", 1, 17));
            optionMenu.addParam(new Param("ExchangeTitle", null, "EXCHANGE TYPE", 2, 7));
            optionMenu.addParam(new Param("ExchangeValue", null, "INDIVIDUAL", 3, 12));
            optionMenu.addParam(new Param("Info", null, "PRESS ↑↓ TO SCROLL", 4, 17));

            optionMenu.getParam("ExchangeValue").IsActive = true;

            WidgetTextParams smsFunctions = new WidgetTextParams("EXCHANGE TYPE");
            smsFunctions.addParam("INDIVIDUAL").addParam("NET");

            List<WidgetTextParams> radioParams = new List<WidgetTextParams>();
            radioParams.Add(smsFunctions);


            optionMenu.addActionToParam(optionMenu.getParam("ExchangeValue"), new Button("DOWN", (Button btn, RadioStation rs, Widget wdg) =>
            {
                Param activeParam = wdg.activeParam();
                Param titleParam = wdg.getParam("ExchangeTitle");

                string paramTitle = titleParam.Text;

                activeParam.Text = radioParams.Find(p => p.Name == paramTitle).getPrevParam();
                activeParam.ActiveTo = activeParam.Text.Length;
                activeParam.Y = Helper.calcCenterIndent(activeParam.Text.Length, 28);
                titleParam.Y = Helper.calcCenterIndent(titleParam.Text.Length, 28);
            }));

            optionMenu.addActionToParam(optionMenu.getParam("ExchangeValue"), new Button("UP", (Button btn, RadioStation rs, Widget wdg) =>
            {
                Param activeParam = wdg.activeParam();
                Param titleParam = wdg.getParam("ExchangeTitle");

                string paramTitle = titleParam.Text;

                activeParam.Text = radioParams.Find(p => p.Name == paramTitle).getNextParam();
                activeParam.ActiveTo = activeParam.Text.Length;
                activeParam.Y = Helper.calcCenterIndent(activeParam.Text.Length, 28);
                titleParam.Y = Helper.calcCenterIndent(titleParam.Text.Length, 28);
            }));

            optionMenu.addActionToParam(optionMenu.getParam("Body"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                Param activeParam = wdg.activeParam();
                Param titleParam = wdg.getParam("ExchangeTitle");

            }));

            optionMenu.addActionToParam(optionMenu.getParam("Body"), new Button("CLR", (Button btn, RadioStation rs, Widget wdg) =>
            {
                wdg.showPreviousWidget();
            }));

            return optionMenu;
        }

        static public Widget initOptionAleTxMsgMenu(RadioStation station)
        {

            Widget optionMenu = new Widget("initOptionAleTxMsgMenu");

            optionMenu.LineSize[0] = 5;
            optionMenu.LineSize[1] = 9;
            optionMenu.LineSize[2] = 9;
            optionMenu.LineSize[3] = 5;
            optionMenu.LineCharOffset[0] = 6;
            optionMenu.LineCharOffset[1] = 6;
            optionMenu.LineCharOffset[2] = 7;
            optionMenu.LineCharOffset[3] = 6;

            optionMenu.addParam(new Param("Body", null, "", 1, 0));
            optionMenu.addParam(new Param("Title", null, "OPTION-ALE-TX_MSG", 1, 0));
            optionMenu.addParam(new Param("LineOne", null, "NO TX", 2, 0));
            optionMenu.addParam(new Param("LineTwo", null, "MESSAGES", 3, 0));
            optionMenu.addParam(new Param("Info", null, "PRESS ENT/CLR TO CONTINUE", 4, 15));

            var lineOne = optionMenu.getParam("LineOne");
            var lineTwo = optionMenu.getParam("LineTwo");

            optionMenu.addActionToParam(optionMenu.getParam("Body"), new Button("CLR", (Button btn, RadioStation rs, Widget wdg) =>
            {
                wdg.showPreviousWidget();
            }));

            optionMenu.addActionToParam(optionMenu.getParam("Body"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                if (station.TxMsgs.isEmpty())
                {
                    return;
                }
                Action clr = () => {
                    Form1.currObject.QueueWidget.add(optionMenu);
                    Form1.currObject.startShowWidgetQueue();
                };
                var question = dialogMenu("OPTION-ALE-TX_MSG", "SEND TX MESSAGE"
                    , clr
                    , ifYes: () => {
                        var sendingMenu = initOptionAleTxMsgSendingMenu(station, clr);
                        Form1.currObject.QueueWidget.add(sendingMenu);
                        Form1.currObject.startShowWidgetQueue();
                    }
                    , clr);


                Form1.currObject.QueueWidget.add(question);
                Form1.currObject.startShowWidgetQueue();
            }));

            optionMenu.addActionToParam(optionMenu.getParam("Body"), new Button("DOWN", (Button btn, RadioStation rs, Widget wdg) =>
            {
                if (station.TxMsgs.isEmpty())
                {
                    return;
                }
                var next = station.TxMsgs.prevNDMsg();
                lineTwo.Text = next.msg;
            }));

            optionMenu.addActionToParam(optionMenu.getParam("Body"), new Button("UP", (Button btn, RadioStation rs, Widget wdg) =>
            {
                if (station.TxMsgs.isEmpty())
                {
                    return;
                }
                var next = station.TxMsgs.nextNDMsg();
                lineTwo.Text = next.msg;
            }));

            optionMenu.addParam(new Param("Rebuild", null, "", 1, 0, () => { 
                if (station.TxMsgs.isEmpty())
                {
                    lineOne.Text = "NO TX";
                    lineTwo.Text = "MESSAGES";
                    lineOne.setLocation(2, 12);
                    lineTwo.setLocation(3, 10);
                    return;
                }

                lineOne.Text = "TX MESSAGES TO SEND:";
                if (lineTwo.Text == "MESSAGES")
                {
                    optionMenu.getParam("LineTwo").Text = station.TxMsgs.Msgs[0].msg;
                }

                lineOne.setLocation(2, 5);
                lineTwo.setLocation(3, 0);
            }));

            

            return optionMenu;
        }
        static public Widget initProgramComsecMenu(RadioStation station)
        {

            Widget optionMenu = new Widget(getNameMenu(MenuNames.OptionAleLqaMenu));
            optionMenu.LineSize[0] = 5;
            optionMenu.LineSize[1] = 9;
            optionMenu.LineSize[2] = 9;
            optionMenu.LineSize[3] = 9;
            optionMenu.LineCharOffset[0] = 6;
            optionMenu.LineCharOffset[1] = 6;
            optionMenu.LineCharOffset[2] = 7;
            optionMenu.LineCharOffset[3] = 6;
            optionMenu.addParam(new Param("Body", null, "", 1, 0));
            optionMenu.addParam(new Param("Title", null, "PGM-COMSEC", 1, 0));
            optionMenu.addParam(new Param("EmptyLine", null, " ", 2, 0));
            optionMenu.addParam(new Param("Cam", null, "CAM", 3, 0));
            optionMenu.addParam(new Param("Id", null, "ID", 3, 10));
            optionMenu.addParam(new Param("Keys", null, "KEYS", 3, 20));
            optionMenu.addParam(new Param("Mi", null, "MI", 4, 0));
            optionMenu.addParam(new Param("Aks", null, "AKS", 4, 15));
            optionMenu.getParam("Cam").IsActive = true;

            optionMenu.addActionToParam(optionMenu.getParam("Body"), new Button("LEFT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();

                if (activeParam == null)
                {
                    var param = wdg.getParam("Aks");
                    wdg.deactiveParam();
                    param.IsActive = true;
                    return;
                }

                switch (activeParam.Name)
                {
                    case "Cam":
                        {
                            var param = wdg.getParam("Aks");
                            wdg.deactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Id":
                        {
                            var param = wdg.getParam("Cam");
                            wdg.deactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Keys":
                        {
                            var param = wdg.getParam("Id");
                            wdg.deactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Mi":
                        {
                            var param = wdg.getParam("Keys");
                            wdg.deactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Aks":
                        {
                            var param = wdg.getParam("Mi");
                            wdg.deactiveParam();
                            param.IsActive = true;
                            break;
                        }
                }

            }));
            optionMenu.addActionToParam(optionMenu.getParam("Body"), new Button("RIGTH", (Button btn, RadioStation rs, Widget wdg) =>
            {

                var activeParam = wdg.activeParam();

                if (activeParam == null)
                {
                    var param = wdg.getParam("Cam");
                    wdg.deactiveParam();
                    param.IsActive = true;
                    return;
                }

                switch (activeParam.Name)
                {
                    case "Cam":
                        {
                            var param = wdg.getParam("Id");
                            wdg.deactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Id":
                        {
                            var param = wdg.getParam("Keys");
                            wdg.deactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Keys":
                        {
                            var param = wdg.getParam("Mi");
                            wdg.deactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Mi":
                        {
                            var param = wdg.getParam("Aks");
                            wdg.deactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Aks":
                        {
                            var param = wdg.getParam("Cam");
                            wdg.deactiveParam();
                            param.IsActive = true;
                            break;
                        }
                }
            }));

            optionMenu.addActionToParam(optionMenu.getParam("Id"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {

                var activeParam = wdg.activeParam();

                if (activeParam == null || activeParam.Name != "Id")
                {
                    return;
                }

                wdg.prepareToShowWidget(getNameMenu(MenuNames.ProgramComsecIdMenu));

            }));

            optionMenu.addActionToParam(optionMenu.getParam("Mi"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {

                var activeParam = wdg.activeParam();

                if (activeParam == null || activeParam.Name != "Mi")
                {
                    return;
                }

                wdg.prepareToShowWidget(getNameMenu(MenuNames.ProgramComsecMiMenu));

            }));
            optionMenu.addActionToParam(optionMenu.getParam("Aks"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {

                var activeParam = wdg.activeParam();

                if (activeParam == null || activeParam.Name != "Aks")
                {
                    return;
                }

                wdg.prepareToShowWidget(getNameMenu(MenuNames.ProgramComsecAksMenu));

            }));
            optionMenu.addActionToParam(optionMenu.getParam("Keys"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {

                var activeParam = wdg.activeParam();

                if (activeParam == null || activeParam.Name != "Keys")
                {
                    return;
                }

                wdg.prepareToShowWidget(getNameMenu(MenuNames.ProgramComsecKeysMenu));

            }));

            optionMenu.addActionToParam(optionMenu.getParam("Body"), new Button("CLR", (Button btn, RadioStation rs, Widget wdg) =>
            {
                wdg.showPreviousWidget();
            }));
            return optionMenu;
        }

        static public Widget initProgramComsecIdMenu(RadioStation station)
        {

            Widget optionMenu = new Widget(getNameMenu(MenuNames.ProgramComsecIdMenu));

            optionMenu.LineSize[0] = 5;
            optionMenu.LineSize[1] = 9;
            optionMenu.LineSize[2] = 9;
            optionMenu.LineSize[3] = 5;
            optionMenu.LineCharOffset[0] = 6;
            optionMenu.LineCharOffset[1] = 6;
            optionMenu.LineCharOffset[2] = 7;
            optionMenu.LineCharOffset[3] = 6;
            optionMenu.addParam(new Param("Body", null, "", 1, 0));
            optionMenu.addParam(new Param("Title", null, "PGM-COMSEC-ID", 1, 0));
            optionMenu.addParam(new Param("IdTitle", null, "KERNEL_ID", 2, 7));
            optionMenu.addParam(new Param("IdValue", null, "", 3, 12));
            optionMenu.addParam(new Param("Info", null, "", 4, 15));

            optionMenu.getParam("IdValue").IsActive = true;

            WidgetTextParams smsFunctions = new WidgetTextParams("KERNEL_ID");
            smsFunctions.addParam("");

            List<WidgetTextParams> radioParams = new List<WidgetTextParams>();
            radioParams.Add(smsFunctions);


            optionMenu.addActionToParam(optionMenu.getParam("IdValue"), new Button("DOWN", (Button btn, RadioStation rs, Widget wdg) =>
            {
                Param activeParam = wdg.activeParam();
                Param titleParam = wdg.getParam("IdTitle");

                string paramTitle = titleParam.Text;

                activeParam.Text = radioParams.Find(p => p.Name == paramTitle).getPrevParam();
                activeParam.ActiveTo = activeParam.Text.Length;
            }));

            optionMenu.addActionToParam(optionMenu.getParam("IdValue"), new Button("UP", (Button btn, RadioStation rs, Widget wdg) =>
            {
                Param activeParam = wdg.activeParam();
                Param titleParam = wdg.getParam("IdTitle");

                string paramTitle = titleParam.Text;

                activeParam.Text = radioParams.Find(p => p.Name == paramTitle).getNextParam();
                activeParam.ActiveTo = activeParam.Text.Length;
            }));


            optionMenu.addActionToParam(optionMenu.getParam("Body"), new Button("CLR", (Button btn, RadioStation rs, Widget wdg) =>
            {
                wdg.showPreviousWidget();
            }));

            return optionMenu;
        }
        static public Widget initProgramComsecMiMenu(RadioStation station)
        {

            Widget programMenu = new Widget(getNameMenu(MenuNames.ProgramComsecMiMenu));

            programMenu.LineSize[0] = 5;
            programMenu.LineSize[1] = 9;
            programMenu.LineSize[2] = 9;
            programMenu.LineSize[3] = 5;
            programMenu.LineCharOffset[0] = 6;
            programMenu.LineCharOffset[1] = 6;
            programMenu.LineCharOffset[2] = 7;
            programMenu.LineCharOffset[3] = 6;
            programMenu.addParam(new Param("Body", null, "", 1, 0));
            programMenu.addParam(new Param("Title", null, "PGM-COMSEC-MI", 1, 0));
            programMenu.addParam(new Param("MiTitle", null, "CRYPTO MI", 2, 10));
            programMenu.addParam(new Param("MiValue", null, "DEFAULT", 3, 11));
            programMenu.addParam(new Param("Info", null, "PRESS ↑↓ TO SCROLL", 4, 20));

            programMenu.getParam("MiValue").IsActive = true;

            WidgetTextParams smsFunctions = new WidgetTextParams("CRYPTO MI");
            smsFunctions.addParam("DEFAULT").addParam("3X").addParam("1X");

            List<WidgetTextParams> radioParams = new List<WidgetTextParams>();
            radioParams.Add(smsFunctions);


            programMenu.addActionToParam(programMenu.getParam("MiValue"), new Button("DOWN", (Button btn, RadioStation rs, Widget wdg) =>
            {
                Param activeParam = wdg.activeParam();
                Param titleParam = wdg.getParam("MiTitle");

                string paramTitle = titleParam.Text;

                activeParam.Text = radioParams.Find(p => p.Name == paramTitle).getPrevParam();
                activeParam.ActiveTo = activeParam.Text.Length;
                activeParam.Y = Helper.calcCenterIndent(activeParam.Text.Length, 28);
                titleParam.Y = Helper.calcCenterIndent(titleParam.Text.Length, 28);
            }));

            programMenu.addActionToParam(programMenu.getParam("MiValue"), new Button("UP", (Button btn, RadioStation rs, Widget wdg) =>
            {
                Param activeParam = wdg.activeParam();
                Param titleParam = wdg.getParam("MiTitle");

                string paramTitle = titleParam.Text;

                activeParam.Text = radioParams.Find(p => p.Name == paramTitle).getNextParam();
                activeParam.ActiveTo = activeParam.Text.Length;
                activeParam.Y = Helper.calcCenterIndent(activeParam.Text.Length, 28);
                titleParam.Y = Helper.calcCenterIndent(titleParam.Text.Length, 28);
            }));


            programMenu.addActionToParam(programMenu.getParam("Body"), new Button("CLR", (Button btn, RadioStation rs, Widget wdg) =>
            {
                wdg.showPreviousWidget();
            }));

            programMenu.addActionToParam(programMenu.getParam("Body"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                wdg.showPreviousWidget();
            }));

            return programMenu;
        }

        static public Widget initProgramComsecAksMenu(RadioStation station)
        {

            Widget programMenu = new Widget(getNameMenu(MenuNames.ProgramComsecAksMenu));

            programMenu.LineSize[0] = 5;
            programMenu.LineSize[1] = 9;
            programMenu.LineSize[2] = 9;
            programMenu.LineSize[3] = 5;
            programMenu.LineCharOffset[0] = 6;
            programMenu.LineCharOffset[1] = 6;
            programMenu.LineCharOffset[2] = 7;
            programMenu.LineCharOffset[3] = 6;
            programMenu.addParam(new Param("Body", null, "", 1, 0));
            programMenu.addParam(new Param("Title", null, "PGM-COMSEC-AKS", 1, 0));
            programMenu.addParam(new Param("AksTitle", null, "AUTO KEY SELECT", 2, 7));
            programMenu.addParam(new Param("AksValue", null, "KEY & KRYPTO TYPE", 3, 10));
            programMenu.addParam(new Param("Info", null, "PRESS ↑↓ TO SCROLL", 4, 18));

            programMenu.getParam("AksValue").IsActive = true;

            WidgetTextParams @params = new WidgetTextParams("AUTO KEY SELECT");
            @params.addParam("KEY & KRYPTO TYPE").addParam("KEY ONLY").addParam("DISABLE");

            List<WidgetTextParams> radioParams = new List<WidgetTextParams>();
            radioParams.Add(@params);


            programMenu.addActionToParam(programMenu.getParam("AksValue"), new Button("DOWN", (Button btn, RadioStation rs, Widget wdg) =>
            {
                Param activeParam = wdg.activeParam();
                Param titleParam = wdg.getParam("AksTitle");

                string paramTitle = titleParam.Text;

                activeParam.Text = radioParams.Find(p => p.Name == paramTitle).getPrevParam();
                activeParam.ActiveTo = activeParam.Text.Length;
                activeParam.Y = Helper.calcCenterIndent(activeParam.Text.Length, 28);
                titleParam.Y = Helper.calcCenterIndent(titleParam.Text.Length, 28);
            }));

            programMenu.addActionToParam(programMenu.getParam("AksValue"), new Button("UP", (Button btn, RadioStation rs, Widget wdg) =>
            {
                Param activeParam = wdg.activeParam();
                Param titleParam = wdg.getParam("AksTitle");

                string paramTitle = titleParam.Text;

                activeParam.Text = radioParams.Find(p => p.Name == paramTitle).getNextParam();
                activeParam.ActiveTo = activeParam.Text.Length;
                activeParam.Y = Helper.calcCenterIndent(activeParam.Text.Length, 28);
                titleParam.Y = Helper.calcCenterIndent(titleParam.Text.Length, 28);
            }));


            programMenu.addActionToParam(programMenu.getParam("Body"), new Button("CLR", (Button btn, RadioStation rs, Widget wdg) =>
            {
                wdg.showPreviousWidget();
            }));

            programMenu.addActionToParam(programMenu.getParam("Body"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                wdg.showPreviousWidget();
            }));

            return programMenu;
        }
    
        static public Widget initProgramComsecKeysMenu (RadioStation station)
        {
            Widget optionMenu = new Widget(getNameMenu(MenuNames.OptionAleLqaMenu));
            optionMenu.LineSize[0] = 5;
            optionMenu.LineSize[1] = 9;
            optionMenu.LineSize[2] = 9;
            optionMenu.LineSize[3] = 5;
            optionMenu.LineCharOffset[0] = 6;
            optionMenu.LineCharOffset[1] = 6;
            optionMenu.LineCharOffset[2] = 7;
            optionMenu.LineCharOffset[3] = 6;
            optionMenu.addParam(new Param("Body", null, "", 1, 0));
            optionMenu.addParam(new Param("Title", null, "PGM-COMSEC", 1, 0));
            optionMenu.addParam(new Param("EmptyLine", null, " ", 2, 0));
            optionMenu.addParam(new Param("Enter", null, "ENTER", 3, 0));
            optionMenu.addParam(new Param("Update", null, "UPDATE", 3, 10));
            optionMenu.addParam(new Param("Erase", null, "ERASE", 3, 20));

            optionMenu.addActionToParam(optionMenu.getParam("Body"), new Button("LEFT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();

                if (activeParam == null)
                {
                    var param = wdg.getParam("Erase");
                    wdg.deactiveParam();
                    param.IsActive = true;
                    return;
                }

                switch (activeParam.Name)
                {
                    case "Enter":
                        {
                            var param = wdg.getParam("Erase");
                            wdg.deactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Update":
                        {
                            var param = wdg.getParam("Enter");
                            wdg.deactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Erase":
                        {
                            var param = wdg.getParam("Update");
                            wdg.deactiveParam();
                            param.IsActive = true;
                            break;
                        }
                }

            }));
            optionMenu.addActionToParam(optionMenu.getParam("Body"), new Button("RIGTH", (Button btn, RadioStation rs, Widget wdg) =>
            {

                var activeParam = wdg.activeParam();

                if (activeParam == null)
                {
                    var param = wdg.getParam("Enter");
                    wdg.deactiveParam();
                    param.IsActive = true;
                    return;
                }

                switch (activeParam.Name)
                {
                    case "Enter":
                        {
                            var param = wdg.getParam("Update");
                            wdg.deactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Update":
                        {
                            var param = wdg.getParam("Erase");
                            wdg.deactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Erase":
                        {
                            var param = wdg.getParam("Enter");
                            wdg.deactiveParam();
                            param.IsActive = true;
                            break;
                        }
                }
            }));

            optionMenu.addActionToParam(optionMenu.getParam("Enter"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {

                var activeParam = wdg.activeParam();

                if (activeParam == null || activeParam.Name != "Enter")
                {
                    return;
                }
                Widget nextStep = initProgramComsecKeysEnterMenu(station);

                nextStep.addActionToParam(nextStep.getParam("Body"), new Button("CLR", (Button btn1, RadioStation rs1, Widget wdg1) =>
                {
                    optionMenu.moveTo = null;
                    Form1.currObject.QueueWidget.add(optionMenu);
                    Form1.currObject.startShowWidgetQueue();
                }));

                Form1.currObject.QueueWidget.add(nextStep);
                Form1.currObject.startShowWidgetQueue();

            }));

            optionMenu.addActionToParam(optionMenu.getParam("Update"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {

                var activeParam = wdg.activeParam();

                if (activeParam == null || activeParam.Name != "Update")
                {
                    return;
                }

                Widget nextStep = initProgramComsecKeysUpdateMenu(station);

                nextStep.addActionToParam(nextStep.getParam("Body"), new Button("CLR", (Button btn1, RadioStation rs1, Widget wdg1) =>
                {
                    optionMenu.moveTo = null;
                    Form1.currObject.QueueWidget.add(optionMenu);
                    Form1.currObject.startShowWidgetQueue();
                }));


                Form1.currObject.QueueWidget.add(nextStep);

                Form1.currObject.startShowWidgetQueue();

            }));
            optionMenu.addActionToParam(optionMenu.getParam("Erase"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {

                var activeParam = wdg.activeParam();

                if (activeParam == null || activeParam.Name != "Erase")
                {
                    return;
                }

                wdg.prepareToShowWidget(getNameMenu(MenuNames.ProgramComsecAksMenu));

            }));

            optionMenu.addActionToParam(optionMenu.getParam("Body"), new Button("CLR", (Button btn, RadioStation rs, Widget wdg) =>
            {

                wdg.showPreviousWidget();

            }));
            return optionMenu;
        }

        static public Widget initProgramComsecKeysEnterMenu(RadioStation station)
        {

            Widget programMenu = new Widget("initProgramComsecKeysEnterMenu");

            programMenu.LineSize[0] = 5;
            programMenu.LineSize[1] = 9;
            programMenu.LineSize[2] = 9;
            programMenu.LineSize[3] = 5;
            programMenu.LineCharOffset[0] = 6;
            programMenu.LineCharOffset[1] = 6;
            programMenu.LineCharOffset[2] = 7;
            programMenu.LineCharOffset[3] = 6;
            programMenu.addParam(new Param("Body", null, "", 1, 0));
            programMenu.addParam(new Param("Title", null, "PGM-COMSEC-KEYS", 1, 0));
            programMenu.addParam(new Param("KeyTitle", null, "KEY TYPE", 2, 10));
            programMenu.addParam(new Param("KeyValue", null, "CITADEL I (MK-128)", 3, 6));
            programMenu.addParam(new Param("Info", null, "PRESS ↑↓ TO SCROLL", 4, 19));

            programMenu.getParam("KeyValue").IsActive = true;

            WidgetTextParams @params = new WidgetTextParams("KEY TYPE");
            @params
                .addParam(KeyModule.typeToString(KeyModule.KeyType.Citadel1))
                .addParam(KeyModule.typeToString(KeyModule.KeyType.Aes256))
                .addParam(KeyModule.typeToString(KeyModule.KeyType.Aes128));

            List<WidgetTextParams> radioParams = new List<WidgetTextParams>();
            radioParams.Add(@params);


            programMenu.addActionToParam(programMenu.getParam("KeyValue"), new Button("DOWN", (Button btn, RadioStation rs, Widget wdg) =>
            {
                Param activeParam = wdg.activeParam();
                Param titleParam = wdg.getParam("KeyTitle");

                string paramTitle = titleParam.Text;

                activeParam.Text = radioParams.Find(p => p.Name == paramTitle).getPrevParam();
                activeParam.ActiveTo = activeParam.Text.Length;
                activeParam.Y = Helper.calcCenterIndent(activeParam.Text.Length, 28);
                titleParam.Y = Helper.calcCenterIndent(titleParam.Text.Length, 28);
            }));

            programMenu.addActionToParam(programMenu.getParam("KeyValue"), new Button("UP", (Button btn, RadioStation rs, Widget wdg) =>
            {
                Param activeParam = wdg.activeParam();
                Param titleParam = wdg.getParam("KeyTitle");

                string paramTitle = titleParam.Text;

                activeParam.Text = radioParams.Find(p => p.Name == paramTitle).getNextParam();
                activeParam.ActiveTo = activeParam.Text.Length;
                activeParam.Y = Helper.calcCenterIndent(activeParam.Text.Length, 28);
                titleParam.Y = Helper.calcCenterIndent(titleParam.Text.Length, 28);
            }));

            programMenu.addActionToParam(programMenu.getParam("Body"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                Widget nextStep = initProgramComsecKeysEnterNameMenu(station);
                nextStep.ObjectContainer.Add("KeyType", KeyModule.stringToType(wdg.getParam("KeyValue").Text));

                nextStep.addActionToParam(nextStep.getParam("Body"), new Button("CLR", (Button btn1, RadioStation rs1, Widget wdg1) =>
                {
                    Form1.currObject.QueueWidget.add(programMenu);
                    Form1.currObject.startShowWidgetQueue();
                }));

                Form1.currObject.QueueWidget.add(nextStep);
                Form1.currObject.startShowWidgetQueue();
            }));

            return programMenu;
        }
        static public Widget initProgramComsecKeysEnterNameMenu(RadioStation station)
        {

            Widget programMenu = new Widget("initProgramComsecKeysEnterMenu");

            programMenu.LineSize[0] = 5;
            programMenu.LineSize[1] = 9;
            programMenu.LineSize[2] = 9;
            programMenu.LineSize[3] = 5;
            programMenu.LineCharOffset[0] = 6;
            programMenu.LineCharOffset[1] = 6;
            programMenu.LineCharOffset[2] = 7;
            programMenu.LineCharOffset[3] = 6;
            programMenu.addParam(new Param("Body", null, "", 1, 0));
            programMenu.addParam(new Param("Title", null, "PGM-COMSEC-KEYS-ENTER", 1, 0));
            programMenu.addParam(new Param("KeyTitle", null, "KEY TO ENTER", 2, 8));
            programMenu.addParam(new Param("KeyValue", (string text, Param cParam) =>
            {
                cParam.text = cParam.Text.Remove(cParam.ActiveFrom, cParam.ActiveTo);
                cParam.text = cParam.Text.Insert(cParam.ActiveFrom, text);
            }, "TEK01", 3, 11 ));
            programMenu.addParam(new Param("Info", null, "PRESS ↑↓ TO SCROLL", 4, 17));

            programMenu.getParam("KeyValue").IsActive = true;
            programMenu.getParam("KeyValue").ActiveTo = 1;

            programMenu.addActionToParam(programMenu.getParam("Body"), new Button("LEFT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();

                if (activeParam.isInParam())
                {
                    if (activeParam.ActiveFrom >= 0)
                    {
                        activeParam.ActiveFrom -= 1;
                        activeParam.ActiveTo = 1;
                    }
                    return;
                }

            }));
            programMenu.addActionToParam(programMenu.getParam("Body"), new Button("RIGTH", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();

                if (activeParam.isInParam())
                {
                    if (activeParam.ActiveFrom < 5)
                    {
                        activeParam.ActiveFrom += 1;
                        activeParam.ActiveTo = 1;
                    }
                    return;
                }

            }));
            programMenu.addActionToParam(programMenu.getParam("Body"), new Button("CALL", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();


                if (!activeParam.isInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                string symbols = "1ABC";
                string currentSymbol = activeParam.getActiveText();
                int index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                }
                string nextSymbol = symbols.Substring(index, 1);
                activeParam.action(nextSymbol);

            }));
            programMenu.addActionToParam(programMenu.getParam("Body"), new Button("LT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();

                if (!activeParam.isInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                string symbols = "2DEF";
                string currentSymbol = activeParam.getActiveText();
                int index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                }
                string nextSymbol = symbols.Substring(index, 1);
                activeParam.action(nextSymbol);

            }));
            programMenu.addActionToParam(programMenu.getParam("Body"), new Button("MODE", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();

                if (!activeParam.isInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                string symbols = "3GHI";
                string currentSymbol = activeParam.getActiveText();
                int index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                }
                string nextSymbol = symbols.Substring(index, 1);
                activeParam.action(nextSymbol);

            }));
            programMenu.addActionToParam(programMenu.getParam("Body"), new Button("SQL", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();


                if (!activeParam.isInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                string symbols = "4JKL";
                string currentSymbol = activeParam.getActiveText();
                int index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                }
                string nextSymbol = symbols.Substring(index, 1);
                activeParam.action(nextSymbol);

            }));
            programMenu.addActionToParam(programMenu.getParam("Body"), new Button("ZERO", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();

                if (!activeParam.isInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                string symbols = "5MNO";
                string currentSymbol = activeParam.getActiveText();
                int index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                }
                string nextSymbol = symbols.Substring(index, 1);
                activeParam.action(nextSymbol);

            }));
            programMenu.addActionToParam(programMenu.getParam("Body"), new Button("UP", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();

                if (!activeParam.isInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                string symbols = "6PQR";
                string currentSymbol = activeParam.getActiveText();
                int index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                }
                string nextSymbol = symbols.Substring(index, 1);
                activeParam.action(nextSymbol);
            }));
            programMenu.addActionToParam(programMenu.getParam("Body"), new Button("OPT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();

                if (!activeParam.isInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                string symbols = "7STU";
                string currentSymbol = activeParam.getActiveText();
                int index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                }
                string nextSymbol = symbols.Substring(index, 1);
                activeParam.action(nextSymbol);

            }));
            programMenu.addActionToParam(programMenu.getParam("Body"), new Button("PGM", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();

                if (!activeParam.isInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                string symbols = "8VWX";
                string currentSymbol = activeParam.getActiveText();
                int index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                }
                string nextSymbol = symbols.Substring(index, 1);
                activeParam.action(nextSymbol);

            }));
            programMenu.addActionToParam(programMenu.getParam("Body"), new Button("DOWN", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();

                if (!activeParam.isInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                string symbols = "9YZ?";
                string currentSymbol = activeParam.getActiveText();
                int index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                }
                string nextSymbol = symbols.Substring(index, 1);
                activeParam.action(nextSymbol);

            }));
            programMenu.addActionToParam(programMenu.getParam("Body"), new Button("UPDATE", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();

                activeParam.action("0");

            }));

            programMenu.addActionToParam(programMenu.getParam("Body"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                //wdg.showPreviousWidget();
                if (station.Keys.isContainKey(programMenu.getParam("KeyValue").Text))
                {

                    Form1.currObject.QueueWidget.add(dialogMenu(title: "PGM-COMSEC-AKS-ENTER", text: "KEY EXIST OVERWRITE?", null
                        , ifYes: () => {

                            KeyModule.KeyValue keyValue = station.Keys.findKey(programMenu.getParam("KeyValue").Text);
                            Widget nextStep = initProgramComsecKeysEnterValueMenu(rs);
                            nextStep.ObjectContainer.Add("KeyValue", keyValue);
                            nextStep.ObjectContainer.Add("KeyType", programMenu.ObjectContainer["KeyType"]);

                            nextStep.addActionToParam(nextStep.getParam("Body"), new Button("CLR", (Button btn1, RadioStation rs1, Widget wdg1) =>
                            {
                                Form1.currObject.QueueWidget.add(programMenu);
                                Form1.currObject.startShowWidgetQueue();
                            }));

                            Form1.currObject.QueueWidget.add(nextStep);
                            Form1.currObject.startShowWidgetQueue();
                        }
                        , ifNo: () => {
                            Form1.currObject.QueueWidget.add(programMenu);
                            Form1.currObject.startShowWidgetQueue();
                        }));
                    Form1.currObject.startShowWidgetQueue();
                }
                else
                {
                    KeyModule.KeyValue keyValue = new KeyModule.KeyValue();
                    keyValue.KeyName = programMenu.getParam("KeyValue").Text;

                    Widget nextStep = initProgramComsecKeysEnterValueMenu(rs);
                    nextStep.ObjectContainer.Add("KeyValue", keyValue);
                    nextStep.ObjectContainer.Add("KeyType", programMenu.ObjectContainer["KeyType"]);

                    nextStep.addActionToParam(nextStep.getParam("Body"), new Button("CLR", (Button btn1, RadioStation rs1, Widget wdg1) =>
                    {
                        Form1.currObject.QueueWidget.add(programMenu);
                        Form1.currObject.startShowWidgetQueue();
                    }));

                    Form1.currObject.QueueWidget.add(nextStep);
                    Form1.currObject.startShowWidgetQueue();
                }
            }));

            return programMenu;
        }
        static public Widget initProgramComsecKeysEnterValueMenu(RadioStation station)
        {

            Widget enterMsgMenu = new Widget("initProgramComsecKeysEnterValueMenu");
            enterMsgMenu.LineSize[0] = 5;
            enterMsgMenu.LineSize[1] = 9;
            enterMsgMenu.LineSize[2] = 9;
            enterMsgMenu.LineSize[3] = 5;
            enterMsgMenu.LineCharOffset[0] = 6;
            enterMsgMenu.LineCharOffset[1] = 6;
            enterMsgMenu.LineCharOffset[2] = 7;
            enterMsgMenu.LineCharOffset[3] = 6;
            enterMsgMenu
                .addParam(new Param("Body", null, "", 1, 0))
                .addModesForParam("Body", new List<RadioStationMode> { RadioStationMode.ThreeG });
            enterMsgMenu.addParam(new Param("Title", null, "PGM-COMSEC-KEYS-ENTER-", 1, 0))
                .addModesForParam("Title", new List<RadioStationMode> { RadioStationMode.ThreeG });
            enterMsgMenu
                .addParam(new Param("LineOne", (string text, Param cParam) =>
                {
                    cParam.text = cParam.Text.Remove(cParam.ActiveFrom, cParam.ActiveTo);
                    cParam.text = cParam.Text.Insert(cParam.ActiveFrom, text);

                }, "____________________", 2, 4))
                .addModesForParam("LineOne", new List<RadioStationMode> { RadioStationMode.ThreeG });
            enterMsgMenu
                .addParam(new Param("LineTwo", (string text, Param cParam) =>
                {
                    cParam.text = cParam.Text.Remove(cParam.ActiveFrom, cParam.ActiveTo);
                    cParam.text = cParam.Text.Insert(cParam.ActiveFrom, text);

                }, "____________________", 3, 4))
                .addModesForParam("LineTwo", new List<RadioStationMode> { RadioStationMode.ThreeG });
            enterMsgMenu
                .addParam(new Param("Enter", null, "PRESS ENTER TO SEND MESSAGE", 4, 12))
                .addModesForParam("Enter", new List<RadioStationMode> { RadioStationMode.ThreeG });

            enterMsgMenu.addActionToParam(enterMsgMenu.getParam("Body"), new Button("LEFT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();

                if (activeParam == null)
                {
                    var param = wdg.getParam("LineOne");
                    wdg.deactiveParam();
                    param.IsActive = true;
                    param.ActiveFrom = 0;
                    param.ActiveTo = 1;
                    return;
                }

                if (activeParam.isInParam())
                {
                    if (activeParam.ActiveFrom > 0)
                    {
                        activeParam.ActiveFrom -= 1;
                        activeParam.ActiveTo = 1;
                    }
                    else
                    {
                        activeParam.IsActive = false;
                        wdg.getParam("LineOne").IsActive = true;
                        wdg.getParam("LineOne").ActiveFrom = 0;
                        wdg.getParam("LineOne").ActiveTo = 1;
                    }
                    return;
                }

            }));

            enterMsgMenu.addActionToParam(enterMsgMenu.getParam("Body"), new Button("RIGTH", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();

                if (activeParam == null)
                {
                    var param = wdg.getParam("LineOne");
                    wdg.deactiveParam();
                    param.IsActive = true;
                    param.ActiveFrom = 0;
                    param.ActiveTo = 1;
                    return;
                }

                if (activeParam.isInParam())
                {
                    if (activeParam.ActiveFrom < 19)
                    {
                        activeParam.ActiveFrom += 1;
                        activeParam.ActiveTo = 1;
                    }
                    else
                    {
                        activeParam.IsActive = false;
                        wdg.getParam("LineTwo").IsActive = true;
                        wdg.getParam("LineTwo").ActiveFrom = 0;
                        wdg.getParam("LineTwo").ActiveTo = 1;
                    }
                    return;
                }

            }));
            enterMsgMenu.addActionToParam(enterMsgMenu.getParam("Body"), new Button("CALL", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();

                if (activeParam == null)
                {
                    activeParam = wdg.getParam("LineOne");
                    wdg.deactiveParam();
                    activeParam.IsActive = true;
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }

                if (!activeParam.isInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                string symbols = "1ABC";
                string currentSymbol = activeParam.getActiveText();
                int index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                }
                string nextSymbol = symbols.Substring(index, 1);
                activeParam.action(nextSymbol);

            }));
            enterMsgMenu.addActionToParam(enterMsgMenu.getParam("Body"), new Button("LT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();

                if (activeParam == null)
                {
                    activeParam = wdg.getParam("LineOne");
                    wdg.deactiveParam();
                    activeParam.IsActive = true;
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }

                if (!activeParam.isInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                string symbols = "2DEF";
                string currentSymbol = activeParam.getActiveText();
                int index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                }
                string nextSymbol = symbols.Substring(index, 1);
                activeParam.action(nextSymbol);

            }));
            enterMsgMenu.addActionToParam(enterMsgMenu.getParam("Body"), new Button("MODE", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();

                if (activeParam == null)
                {
                    activeParam = wdg.getParam("LineOne");
                    wdg.deactiveParam();
                    activeParam.IsActive = true;
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }

                if (!activeParam.isInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                string symbols = "3GHI";
                string currentSymbol = activeParam.getActiveText();
                int index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                }
                string nextSymbol = symbols.Substring(index, 1);
                activeParam.action(nextSymbol);

            }));
            enterMsgMenu.addActionToParam(enterMsgMenu.getParam("Body"), new Button("SQL", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();

                if (activeParam == null)
                {
                    activeParam = wdg.getParam("LineOne");
                    wdg.deactiveParam();
                    activeParam.IsActive = true;
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }

                if (!activeParam.isInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                string symbols = "4JKL";
                string currentSymbol = activeParam.getActiveText();
                int index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                }
                string nextSymbol = symbols.Substring(index, 1);
                activeParam.action(nextSymbol);

            }));
            enterMsgMenu.addActionToParam(enterMsgMenu.getParam("Body"), new Button("ZERO", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();

                if (activeParam == null)
                {
                    activeParam = wdg.getParam("LineOne");
                    wdg.deactiveParam();
                    activeParam.IsActive = true;
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }

                if (!activeParam.isInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                string symbols = "5MNO";
                string currentSymbol = activeParam.getActiveText();
                int index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                }
                string nextSymbol = symbols.Substring(index, 1);
                activeParam.action(nextSymbol);

            }));
            enterMsgMenu.addActionToParam(enterMsgMenu.getParam("Body"), new Button("UP", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();

                if (activeParam == null)
                {
                    activeParam = wdg.getParam("LineOne");
                    wdg.deactiveParam();
                    activeParam.IsActive = true;
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }

                if (!activeParam.isInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                string symbols = "6PQR";
                string currentSymbol = activeParam.getActiveText();
                int index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                }
                string nextSymbol = symbols.Substring(index, 1);
                activeParam.action(nextSymbol);
            }));
            enterMsgMenu.addActionToParam(enterMsgMenu.getParam("Body"), new Button("OPT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();

                if (activeParam == null)
                {
                    activeParam = wdg.getParam("LineOne");
                    wdg.deactiveParam();
                    activeParam.IsActive = true;
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }

                if (!activeParam.isInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                string symbols = "7STU";
                string currentSymbol = activeParam.getActiveText();
                int index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                }
                string nextSymbol = symbols.Substring(index, 1);
                activeParam.action(nextSymbol);

            }));
            enterMsgMenu.addActionToParam(enterMsgMenu.getParam("Body"), new Button("PGM", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();

                if (activeParam == null)
                {
                    activeParam = wdg.getParam("LineOne");
                    wdg.deactiveParam();
                    activeParam.IsActive = true;
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }

                if (!activeParam.isInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                string symbols = "8VWX";
                string currentSymbol = activeParam.getActiveText();
                int index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                }
                string nextSymbol = symbols.Substring(index, 1);
                activeParam.action(nextSymbol);

            }));
            enterMsgMenu.addActionToParam(enterMsgMenu.getParam("Body"), new Button("DOWN", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();

                if (activeParam == null)
                {
                    activeParam = wdg.getParam("LineOne");
                    wdg.deactiveParam();
                    activeParam.IsActive = true;
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }

                if (!activeParam.isInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                string symbols = "9YZ?";
                string currentSymbol = activeParam.getActiveText();
                int index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                }
                string nextSymbol = symbols.Substring(index, 1);
                activeParam.action(nextSymbol);

            }));
            enterMsgMenu.addActionToParam(enterMsgMenu.getParam("Body"), new Button("UPDATE", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();

                if (activeParam == null)
                {
                    activeParam = wdg.getParam("LineOne");
                    wdg.deactiveParam();
                    activeParam.IsActive = true;
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }

                if (!activeParam.isInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }

                activeParam.action("0");

            }));

            enterMsgMenu.addActionToParam(enterMsgMenu.getParam("Body"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                string lineOne = wdg.getParam("LineOne").Text.Trim(new char[] { '_' });
                string lineTwo = wdg.getParam("LineTwo").Text.Trim(new char[] { '_' });
                KeyModule.KeyValue value = (KeyModule.KeyValue)enterMsgMenu.ObjectContainer["KeyValue"];
                KeyModule.KeyType type = (KeyModule.KeyType)enterMsgMenu.ObjectContainer["KeyType"];
                value.KeyVal = lineOne + lineTwo;

                rs.Keys.Keys[type].Add(value);

                Action returnToThisWidget = () => {
                    Form1.currObject.QueueWidget.add(enterMsgMenu);
                    Form1.currObject.startShowWidgetQueue();
                };
                if (type == KeyModule.KeyType.Citadel1)
                {

                    Form1.currObject.QueueWidget.add(dialogMenu(title: "PGM-COMSEC-KEYS-ENTER"
                    , text: "ENTER AVS KEY"
                    , clr: returnToThisWidget
                    , ifYes: () => {
                        Form1.currObject.QueueWidget.add(enterMsg("PGM-COMSEC-KEYS-ENTER-", "ENTER AVS KEY"
                        , returnToThisWidget
                        , (string enteredMsg) => {
                            value.KeyAws = enteredMsg;
                            Form1.currObject.QueueWidget.add(messageMenu("PGM-COMSEC-KEYS-ENTER-"
                                , "MK-128 AND AWS"
                                , "KEYS LOADED"
                                , "WAIT OR PRESS CLR/ENT TO CONTINUE"
                                , returnToThisWidget
                                , returnToThisWidget));
                            Form1.currObject.QueueWidget.add(enterMsgMenu);
                            Form1.currObject.startShowWidgetQueue();
                        }));
                        Form1.currObject.startShowWidgetQueue();
                    }
                    , ifNo: returnToThisWidget));
                    Form1.currObject.startShowWidgetQueue();
                } 
                else
                {
                    Form1.currObject.QueueWidget.add(messageMenu("PGM-COMSEC-KEYS-ENTER"
                        , KeyModule.typeToString(type).ToUpper()
                        , "KEY ENTERED"
                        , "WAIT OR PRESS CLR/ENT TO CONTINUE"
                        , returnToThisWidget
                        , returnToThisWidget));
                    Form1.currObject.QueueWidget.add(enterMsgMenu);
                    Form1.currObject.startShowWidgetQueue();
                }

                //wdg.prepareToShowWidget(getNameMenu(MenuNames.OptionMsgSmsSendingMenu));
            }));


            return enterMsgMenu;
        }
    
        static public Widget dialogMenu(string title, string text, Action clr, Action ifYes, Action ifNo = null)
        {
            Widget programMenu = new Widget(title);

            programMenu.LineSize[0] = 5;
            programMenu.LineSize[1] = 9;
            programMenu.LineSize[2] = 9;
            programMenu.LineSize[3] = 5;
            programMenu.LineCharOffset[0] = 6;
            programMenu.LineCharOffset[1] = 6;
            programMenu.LineCharOffset[2] = 7;
            programMenu.LineCharOffset[3] = 6;

            programMenu.addParam(new Param("Body", null, "", 1, 0));
            programMenu.addParam(new Param("Title", null, title, 1, 0));
            programMenu.addParam(new Param("KeyTitle", null, text, 2, 7));
            programMenu.addParam(new Param("KeyValue", null, "YES", 3, 13));
            programMenu.addParam(new Param("Info", null, "PRESS ↑↓ TO SCROLL", 4, 18));

            programMenu.getParam("KeyValue").IsActive = true;

            WidgetTextParams @params = new WidgetTextParams(text);
            @params
                .addParam("YES")
                .addParam("NO");

            List<WidgetTextParams> radioParams = new List<WidgetTextParams>();
            radioParams.Add(@params);


            programMenu.addActionToParam(programMenu.getParam("KeyValue"), new Button("DOWN", (Button btn, RadioStation rs, Widget wdg) =>
            {
                Param activeParam = wdg.activeParam();
                Param titleParam = wdg.getParam("KeyTitle");

                string paramTitle = titleParam.Text;

                activeParam.Text = radioParams.Find(p => p.Name == paramTitle).getPrevParam();
                activeParam.ActiveTo = activeParam.Text.Length;
            }));

            programMenu.addActionToParam(programMenu.getParam("KeyValue"), new Button("UP", (Button btn, RadioStation rs, Widget wdg) =>
            {
                Param activeParam = wdg.activeParam();
                Param titleParam = wdg.getParam("KeyTitle");

                string paramTitle = titleParam.Text;

                activeParam.Text = radioParams.Find(p => p.Name == paramTitle).getNextParam();
                activeParam.ActiveTo = activeParam.Text.Length;
            }));


            programMenu.addActionToParam(programMenu.getParam("Body"), new Button("CLR", (Button btn, RadioStation rs, Widget wdg) =>
            {
                clr?.Invoke();
            }));

            programMenu.addActionToParam(programMenu.getParam("Body"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                string choice = programMenu.activeParam().Text;

                if (choice == "YES")
                {
                    ifYes?.Invoke();
                } 
                else
                {
                    ifNo?.Invoke();
                }
            }));

            return programMenu;
        }
        static public Widget enterMsg(string title, string info, Action clr, Action<string> ent)
        {

            Widget enterMsgMenu = new Widget(title);
            enterMsgMenu.LineSize[0] = 5;
            enterMsgMenu.LineSize[1] = 9;
            enterMsgMenu.LineSize[2] = 9;
            enterMsgMenu.LineSize[3] = 5;
            enterMsgMenu.LineCharOffset[0] = 6;
            enterMsgMenu.LineCharOffset[1] = 6;
            enterMsgMenu.LineCharOffset[2] = 7;
            enterMsgMenu.LineCharOffset[3] = 6;

            enterMsgMenu
                .addParam(new Param("Body", null, "", 1, 0))
                .addModesForParam("Body", new List<RadioStationMode> { RadioStationMode.ThreeG });
            enterMsgMenu.addParam(new Param("Title", null, title, 1, 0))
                .addModesForParam("Title", new List<RadioStationMode> { RadioStationMode.ThreeG });
            enterMsgMenu
                .addParam(new Param("LineOne", (string text, Param cParam) =>
                {
                    cParam.text = cParam.Text.Remove(cParam.ActiveFrom, cParam.ActiveTo);
                    cParam.text = cParam.Text.Insert(cParam.ActiveFrom, text);

                }, "____________________", 2, 0))
                .addModesForParam("LineOne", new List<RadioStationMode> { RadioStationMode.ThreeG });
            enterMsgMenu
                .addParam(new Param("LineTwo", (string text, Param cParam) =>
                {
                    cParam.text = cParam.Text.Remove(cParam.ActiveFrom, cParam.ActiveTo);
                    cParam.text = cParam.Text.Insert(cParam.ActiveFrom, text);

                }, "____________________", 3, 0))
                .addModesForParam("LineTwo", new List<RadioStationMode> { RadioStationMode.ThreeG });
            enterMsgMenu
                .addParam(new Param("Enter", null, info, 4, 0))
                .addModesForParam("Enter", new List<RadioStationMode> { RadioStationMode.ThreeG });

            enterMsgMenu.addActionToParam(enterMsgMenu.getParam("Body"), new Button("LEFT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();

                if (activeParam == null)
                {
                    var param = wdg.getParam("LineOne");
                    wdg.deactiveParam();
                    param.IsActive = true;
                    param.ActiveFrom = 0;
                    param.ActiveTo = 1;
                    return;
                }

                if (activeParam.isInParam())
                {
                    if (activeParam.ActiveFrom >= 0)
                    {
                        activeParam.ActiveFrom -= 1;
                        activeParam.ActiveTo = 1;
                    }
                    else
                    {
                        activeParam.IsActive = false;
                        wdg.getParam("LineOne").IsActive = true;
                        wdg.getParam("LineOne").ActiveFrom = 0;
                        wdg.getParam("LineOne").ActiveTo = 1;
                    }
                    return;
                }

            }));

            enterMsgMenu.addActionToParam(enterMsgMenu.getParam("Body"), new Button("RIGTH", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();

                if (activeParam == null)
                {
                    var param = wdg.getParam("LineOne");
                    wdg.deactiveParam();
                    param.IsActive = true;
                    param.ActiveFrom = 0;
                    param.ActiveTo = 1;
                    return;
                }

                if (activeParam.isInParam())
                {
                    if (activeParam.ActiveFrom < 19)
                    {
                        activeParam.ActiveFrom += 1;
                        activeParam.ActiveTo = 1;
                    }
                    else
                    {
                        activeParam.IsActive = false;
                        wdg.getParam("LineTwo").IsActive = true;
                        wdg.getParam("LineTwo").ActiveFrom = 0;
                        wdg.getParam("LineTwo").ActiveTo = 1;
                    }
                    return;
                }

            }));
            enterMsgMenu.addActionToParam(enterMsgMenu.getParam("Body"), new Button("CALL", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();

                if (activeParam == null)
                {
                    activeParam = wdg.getParam("LineOne");
                    wdg.deactiveParam();
                    activeParam.IsActive = true;
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }

                if (!activeParam.isInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                string symbols = "1ABC";
                string currentSymbol = activeParam.getActiveText();
                int index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                }
                string nextSymbol = symbols.Substring(index, 1);
                activeParam.action(nextSymbol);

            }));
            enterMsgMenu.addActionToParam(enterMsgMenu.getParam("Body"), new Button("LT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();

                if (activeParam == null)
                {
                    activeParam = wdg.getParam("LineOne");
                    wdg.deactiveParam();
                    activeParam.IsActive = true;
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }

                if (!activeParam.isInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                string symbols = "2DEF";
                string currentSymbol = activeParam.getActiveText();
                int index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                }
                string nextSymbol = symbols.Substring(index, 1);
                activeParam.action(nextSymbol);

            }));
            enterMsgMenu.addActionToParam(enterMsgMenu.getParam("Body"), new Button("MODE", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();

                if (activeParam == null)
                {
                    activeParam = wdg.getParam("LineOne");
                    wdg.deactiveParam();
                    activeParam.IsActive = true;
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }

                if (!activeParam.isInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                string symbols = "3GHI";
                string currentSymbol = activeParam.getActiveText();
                int index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                }
                string nextSymbol = symbols.Substring(index, 1);
                activeParam.action(nextSymbol);

            }));
            enterMsgMenu.addActionToParam(enterMsgMenu.getParam("Body"), new Button("SQL", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();

                if (activeParam == null)
                {
                    activeParam = wdg.getParam("LineOne");
                    wdg.deactiveParam();
                    activeParam.IsActive = true;
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }

                if (!activeParam.isInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                string symbols = "4JKL";
                string currentSymbol = activeParam.getActiveText();
                int index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                }
                string nextSymbol = symbols.Substring(index, 1);
                activeParam.action(nextSymbol);

            }));
            enterMsgMenu.addActionToParam(enterMsgMenu.getParam("Body"), new Button("ZERO", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();

                if (activeParam == null)
                {
                    activeParam = wdg.getParam("LineOne");
                    wdg.deactiveParam();
                    activeParam.IsActive = true;
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }

                if (!activeParam.isInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                string symbols = "5MNO";
                string currentSymbol = activeParam.getActiveText();
                int index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                }
                string nextSymbol = symbols.Substring(index, 1);
                activeParam.action(nextSymbol);

            }));
            enterMsgMenu.addActionToParam(enterMsgMenu.getParam("Body"), new Button("UP", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();

                if (activeParam == null)
                {
                    activeParam = wdg.getParam("LineOne");
                    wdg.deactiveParam();
                    activeParam.IsActive = true;
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }

                if (!activeParam.isInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                string symbols = "6PQR";
                string currentSymbol = activeParam.getActiveText();
                int index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                }
                string nextSymbol = symbols.Substring(index, 1);
                activeParam.action(nextSymbol);
            }));
            enterMsgMenu.addActionToParam(enterMsgMenu.getParam("Body"), new Button("OPT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();

                if (activeParam == null)
                {
                    activeParam = wdg.getParam("LineOne");
                    wdg.deactiveParam();
                    activeParam.IsActive = true;
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }

                if (!activeParam.isInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                string symbols = "7STU";
                string currentSymbol = activeParam.getActiveText();
                int index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                }
                string nextSymbol = symbols.Substring(index, 1);
                activeParam.action(nextSymbol);

            }));
            enterMsgMenu.addActionToParam(enterMsgMenu.getParam("Body"), new Button("PGM", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();

                if (activeParam == null)
                {
                    activeParam = wdg.getParam("LineOne");
                    wdg.deactiveParam();
                    activeParam.IsActive = true;
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }

                if (!activeParam.isInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                string symbols = "8VWX";
                string currentSymbol = activeParam.getActiveText();
                int index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                }
                string nextSymbol = symbols.Substring(index, 1);
                activeParam.action(nextSymbol);

            }));
            enterMsgMenu.addActionToParam(enterMsgMenu.getParam("Body"), new Button("DOWN", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();

                if (activeParam == null)
                {
                    activeParam = wdg.getParam("LineOne");
                    wdg.deactiveParam();
                    activeParam.IsActive = true;
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }

                if (!activeParam.isInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                string symbols = "9YZ?";
                string currentSymbol = activeParam.getActiveText();
                int index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                }
                string nextSymbol = symbols.Substring(index, 1);
                activeParam.action(nextSymbol);

            }));
            enterMsgMenu.addActionToParam(enterMsgMenu.getParam("Body"), new Button("UPDATE", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();

                if (activeParam == null)
                {
                    activeParam = wdg.getParam("LineOne");
                    wdg.deactiveParam();
                    activeParam.IsActive = true;
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }

                if (!activeParam.isInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }

                activeParam.action("0");

            }));

            enterMsgMenu.addActionToParam(enterMsgMenu.getParam("Body"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                string lineOne = wdg.getParam("LineOne").Text.Trim(new char[] { '_' });
                string lineTwo = wdg.getParam("LineTwo").Text.Trim(new char[] { '_' });

                ent?.Invoke(lineOne + lineTwo);
            }));

            enterMsgMenu.addActionToParam(enterMsgMenu.getParam("Body"), new Button("CLR", (Button btn, RadioStation rs, Widget wdg) =>
            {
                clr?.Invoke();
            }));

            return enterMsgMenu;
        }
        static public Widget messageMenu(string title, string lineOne, string lineTwo, string info, Action ent = null, Action clr = null)
        {
            Widget programMenu = new Widget(title);

            programMenu.LineSize[0] = 5;
            programMenu.LineSize[1] = 9;
            programMenu.LineSize[2] = 9;
            programMenu.LineSize[3] = 5;
            programMenu.LineCharOffset[0] = 6;
            programMenu.LineCharOffset[1] = 6;
            programMenu.LineCharOffset[2] = 7;
            programMenu.LineCharOffset[3] = 6;
            programMenu.addParam(new Param("Body", null, "", 1, 0));
            programMenu.addParam(new Param("Title", null, title, 1, 0));
            programMenu.addParam(new Param("KeyTitle", null, lineOne, 2, 7));
            programMenu.addParam(new Param("KeyValue", null, lineTwo, 3, 10));
            programMenu.addParam(new Param("Info", null, info, 4, 5));


            programMenu.addActionToParam(programMenu.getParam("Body"), new Button("CLR", (Button btn, RadioStation rs, Widget wdg) =>
            {
                clr?.Invoke();
            }));

            programMenu.addActionToParam(programMenu.getParam("Body"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                ent?.Invoke();
            }));

            return programMenu;
        }
        static public Widget initProgramComsecKeysUpdateMenu(RadioStation station)
        {

            Widget programMenu = new Widget("initProgramComsecKeysEnterMenu");

            programMenu.LineSize[0] = 5;
            programMenu.LineSize[1] = 9;
            programMenu.LineSize[2] = 9;
            programMenu.LineSize[3] = 5;
            programMenu.LineCharOffset[0] = 6;
            programMenu.LineCharOffset[1] = 6;
            programMenu.LineCharOffset[2] = 7;
            programMenu.LineCharOffset[3] = 6;
            programMenu.addParam(new Param("Body", null, "", 1, 0));
            programMenu.addParam(new Param("Title", null, "PGM-COMSEC-KEYS-UPDATE", 1, 0));
            programMenu.addParam(new Param("KeyTitle", null, "KEY TYPE", 2, 9));
            programMenu.addParam(new Param("KeyValue", null, "CITADEL I (MK-128)", 3, 10));
            programMenu.addParam(new Param("Info", null, "PRESS ↑↓ TO SCROLL", 4, 18));

            programMenu.getParam("KeyValue").IsActive = true;

            WidgetTextParams @params = new WidgetTextParams("KEY TYPE");
            @params
                .addParam(KeyModule.typeToString(KeyModule.KeyType.Citadel1))
                .addParam(KeyModule.typeToString(KeyModule.KeyType.Aes256))
                .addParam(KeyModule.typeToString(KeyModule.KeyType.Aes128));

            List<WidgetTextParams> radioParams = new List<WidgetTextParams>();
            radioParams.Add(@params);


            programMenu.addActionToParam(programMenu.getParam("KeyValue"), new Button("DOWN", (Button btn, RadioStation rs, Widget wdg) =>
            {
                Param activeParam = wdg.activeParam();
                Param titleParam = wdg.getParam("KeyTitle");

                string paramTitle = titleParam.Text;

                activeParam.Text = radioParams.Find(p => p.Name == paramTitle).getPrevParam();
                activeParam.ActiveTo = activeParam.Text.Length;

                activeParam.Y = Helper.calcCenterIndent(activeParam.Text.Length, 28);
                titleParam.Y = Helper.calcCenterIndent(titleParam.Text.Length, 28);
            }));

            programMenu.addActionToParam(programMenu.getParam("KeyValue"), new Button("UP", (Button btn, RadioStation rs, Widget wdg) =>
            {
                Param activeParam = wdg.activeParam();
                Param titleParam = wdg.getParam("KeyTitle");

                string paramTitle = titleParam.Text;

                activeParam.Text = radioParams.Find(p => p.Name == paramTitle).getNextParam();
                activeParam.ActiveTo = activeParam.Text.Length;

                activeParam.Y = Helper.calcCenterIndent(activeParam.Text.Length, 28);
                titleParam.Y = Helper.calcCenterIndent(titleParam.Text.Length, 28);
            }));


            programMenu.addActionToParam(programMenu.getParam("Body"), new Button("CLR", (Button btn, RadioStation rs, Widget wdg) =>
            {
                //wdg.showPreviousWidget();
            }));

            programMenu.addActionToParam(programMenu.getParam("Body"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                KeyModule.KeyType keyType = KeyModule.stringToType(wdg.getParam("KeyValue").Text);
                Widget nextStep = initProgramComsecKeysUpdateKeysMenu(station, keyType);
                nextStep.ObjectContainer.Add("KeyType", keyType);

                nextStep.addActionToParam(nextStep.getParam("Body"), new Button("CLR", (Button btn1, RadioStation rs1, Widget wdg1) =>
                {
                    Form1.currObject.QueueWidget.add(programMenu);
                    Form1.currObject.startShowWidgetQueue();
                }));

                Form1.currObject.QueueWidget.add(nextStep);
                Form1.currObject.startShowWidgetQueue();
            }));

            return programMenu;
        }
        static public Widget initProgramComsecKeysUpdateKeysMenu(RadioStation station, KeyModule.KeyType type)
        {

            List<KeyModule.KeyValue> keysByType = station.Keys.Keys[type];


            WidgetTextParams @params = new WidgetTextParams("KEY TYPE");

            keysByType.ForEach(v => {
                @params.addParam(v.KeyName);
            });

            Widget programMenu = new Widget("initProgramComsecKeysUpdateKeysMenu");

            programMenu.LineSize[0] = 5;
            programMenu.LineSize[1] = 9;
            programMenu.LineSize[2] = 9;
            programMenu.LineSize[3] = 5;
            programMenu.LineCharOffset[0] = 6;
            programMenu.LineCharOffset[1] = 6;
            programMenu.LineCharOffset[2] = 7;
            programMenu.LineCharOffset[3] = 6;
            programMenu.addParam(new Param("Body", null, "", 1, 0));
            programMenu.addParam(new Param("Title", null, "PGM-COMSEC-KEYS-UPDATE: ", 1, 0, () => {
                Param title = programMenu.getParam("Title");
                title.Text = "PGM-COMSEC-KEYS-UPDATE:      " + type;
            }));
            programMenu.addParam(new Param("CountTitle", null, "UPDATE COUNT:", 2, 0));
            programMenu.addParam(new Param("CountValue", null, "00", 2, 20
                , update: ()=> {
                    Param count = programMenu.getParam("CountValue");
                    var value = keysByType.Find(v => {
                        return v.KeyName == @params.currParam();
                    });
                    if (value != null)
                    {
                        count.Text = value.countToString();
                    }
                     
                }));

            string keyValue = "----------";

            if (keysByType.Count > 0)
            {
                keyValue = keysByType[0].KeyName;
            }

            programMenu.addParam(new Param("IsUpdateTitle", null, "UPDATE?", 2, 0));
            programMenu.addParam(new Param("IsUpdateValue", null, "YES", 2, 20));
            programMenu.getParam("IsUpdateTitle").IsVisible = false;
            programMenu.getParam("IsUpdateValue").IsVisible = false;

            programMenu.addParam(new Param("KeyValue", null, keyValue, 3, 9));
            programMenu.addParam(new Param("Info", null, "PRESS ↑↓ TO SCROLL", 4, 18));

            programMenu.getParam("KeyValue").IsActive = true;


            programMenu.addActionToParam(programMenu.getParam("KeyValue"), new Button("DOWN", (Button btn, RadioStation rs, Widget wdg) =>
            {
                Param activeParam = wdg.activeParam();
                if (programMenu.getParam("CountTitle").IsVisible && keysByType.Count > 0)
                {
                    activeParam.Text = @params.getPrevParam();
                    activeParam.ActiveTo = activeParam.Text.Length;
                }
                else if (programMenu.getParam("IsUpdateTitle").IsVisible)
                {
                    activeParam.Text = activeParam.Text == "YES" ? "NO" : "YES";
                }
            }));

            programMenu.addActionToParam(programMenu.getParam("KeyValue"), new Button("UP", (Button btn, RadioStation rs, Widget wdg) =>
            {
                Param activeParam = wdg.activeParam();
                if (programMenu.getParam("CountTitle").IsVisible && keysByType.Count > 0)
                {
                    
                    activeParam.Text = @params.getNextParam();
                    activeParam.ActiveTo = activeParam.Text.Length;
                } 
                else if (programMenu.getParam("IsUpdateTitle").IsVisible)
                {
                    activeParam.Text = activeParam.Text == "YES" ? "NO" : "YES";
                }
            }));

            programMenu.addActionToParam(programMenu.getParam("Body"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {

                if (keysByType.Count <= 0)
                {
                    return;
                }

                Action returnToThisWidget = () => {
                    Form1.currObject.QueueWidget.add(programMenu);
                    Form1.currObject.startShowWidgetQueue();
                };

                if (programMenu.getParam("CountTitle").IsVisible)
                {
                    programMenu.getParam("CountTitle").IsVisible = false;
                    programMenu.getParam("CountValue").IsVisible = false;
                    programMenu.getParam("IsUpdateTitle").IsVisible = true;
                    programMenu.getParam("IsUpdateValue").IsVisible = true;

                    programMenu.deactiveParam();
                    programMenu.getParam("IsUpdateValue").IsActive = true;
                    programMenu.getParam("IsUpdateValue").Text = "YES";
                    return;
                } 
                if (programMenu.getParam("IsUpdateTitle").IsVisible)
                {
                    if (programMenu.getParam("IsUpdateValue").Text == "YES")
                    {
                        var keyValueParam = programMenu.getParam("KeyValue");
                        keysByType.Find(kv => kv.KeyName == keyValueParam.Text).updateCount += 1;
                        Form1.currObject.QueueWidget.add(messageMenu("PGM-COMSEC-KEYS-ENTER-"
                                , "** UPDATE KEY **"
                                , "KEY UPDATE"
                                , "WAIT OR PRESS CLR/ENT TO CONTINUE"
                                , returnToThisWidget
                                , returnToThisWidget));
                        Form1.currObject.QueueWidget.add(programMenu);
                        Form1.currObject.startShowWidgetQueue();
                    } 
                    else
                    {
                        Form1.currObject.QueueWidget.add(programMenu);
                        Form1.currObject.startShowWidgetQueue(500);
                    }

                    programMenu.getParam("CountTitle").IsVisible = true;
                    programMenu.getParam("CountValue").IsVisible = true;
                    programMenu.getParam("IsUpdateTitle").IsVisible = false;
                    programMenu.getParam("IsUpdateValue").IsVisible = false;

                    programMenu.deactiveParam();
                    programMenu.getParam("KeyValue").IsActive = true;
                }
            }));

            return programMenu;
        }

        static public Widget initProgramModeMenu(RadioStation station)
        {

            Widget optionMenu = new Widget(getNameMenu(MenuNames.ProgramModeMenu));
            optionMenu.LineSize[0] = 5;
            optionMenu.LineSize[1] = 9;
            optionMenu.LineSize[2] = 9;
            optionMenu.LineSize[3] = 9;
            optionMenu.LineCharOffset[0] = 6;
            optionMenu.LineCharOffset[1] = 6;
            optionMenu.LineCharOffset[2] = 7;
            optionMenu.LineCharOffset[3] = 7;
            optionMenu.addParam(new Param("Body", null, "", 1, 0));
            optionMenu.addParam(new Param("Title", null, "PGM-MODE", 1, 0));
            optionMenu.addParam(new Param("EmptyLine", null, " ", 2, 0));
            optionMenu.addParam(new Param("Preset", null, "PRESET", 3, 0));
            optionMenu.addParam(new Param("Ale", null, "ALE", 3, 10));
            optionMenu.addParam(new Param("3G", null, "3G", 3, 20));
            optionMenu.addParam(new Param("Hop", null, "HOP", 4, 0));
            optionMenu.addParam(new Param("Arq", null, "ARQ", 4, 10));
            optionMenu.addParam(new Param("Xdl", null, "XDL", 4, 20));
            optionMenu.getParam("Preset").IsActive = true;

            optionMenu.addActionToParam(optionMenu.getParam("Body"), new Button("LEFT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();

                if (activeParam == null)
                {
                    var param = wdg.getParam("Xdl");
                    wdg.deactiveParam();
                    param.IsActive = true;
                    return;
                }

                switch (activeParam.Name)
                {
                    case "Preset":
                        {
                            var param = wdg.getParam("Xdl");
                            wdg.deactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Ale":
                        {
                            var param = wdg.getParam("Preset");
                            wdg.deactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "3G":
                        {
                            var param = wdg.getParam("Ale");
                            wdg.deactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Hop":
                        {
                            var param = wdg.getParam("3G");
                            wdg.deactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Arq":
                        {
                            var param = wdg.getParam("Hop");
                            wdg.deactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Xdl":
                        {
                            var param = wdg.getParam("Arq");
                            wdg.deactiveParam();
                            param.IsActive = true;
                            break;
                        }
                }

            }));
            optionMenu.addActionToParam(optionMenu.getParam("Body"), new Button("RIGTH", (Button btn, RadioStation rs, Widget wdg) =>
            {

                var activeParam = wdg.activeParam();

                if (activeParam == null)
                {
                    var param = wdg.getParam("Preset");
                    wdg.deactiveParam();
                    param.IsActive = true;
                    return;
                }

                switch (activeParam.Name)
                {
                    case "Preset":
                        {
                            var param = wdg.getParam("Ale");
                            wdg.deactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Ale":
                        {
                            var param = wdg.getParam("3G");
                            wdg.deactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "3G":
                        {
                            var param = wdg.getParam("Hop");
                            wdg.deactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Hop":
                        {
                            var param = wdg.getParam("Arq");
                            wdg.deactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Arq":
                        {
                            var param = wdg.getParam("Xdl");
                            wdg.deactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Xdl":
                        {
                            var param = wdg.getParam("Preset");
                            wdg.deactiveParam();
                            param.IsActive = true;
                            break;
                        }
                }

            }));

            optionMenu.addActionToParam(optionMenu.getParam("Preset"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {

                var activeParam = wdg.activeParam();

                if (activeParam == null || activeParam.Name != "Preset")
                {
                    return;
                }

                wdg.prepareToShowWidget(getNameMenu(MenuNames.ProgramModePresetMenu));

            })); 
            optionMenu.addActionToParam(optionMenu.getParam("Ale"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {

                var activeParam = wdg.activeParam();

                if (activeParam == null || activeParam.Name != "Ale")
                {
                    return;
                }

                wdg.prepareToShowWidget(getNameMenu(MenuNames.ProgramModeAleMenu));

            }));
            optionMenu.addActionToParam(optionMenu.getParam("Body"), new Button("CLR", (Button btn, RadioStation rs, Widget wdg) =>
            {
                wdg.showPreviousWidget();
            }));
            return optionMenu;
        }
        static public Widget initProgramModePresetMenu(RadioStation station)
        {

            Widget optionMenu = new Widget(getNameMenu(MenuNames.ProgramModePresetMenu));
            optionMenu.LineSize[0] = 5;
            optionMenu.LineSize[1] = 9;
            optionMenu.LineSize[2] = 9;
            optionMenu.LineSize[3] = 9;
            optionMenu.LineCharOffset[0] = 6;
            optionMenu.LineCharOffset[1] = 6;
            optionMenu.LineCharOffset[2] = 7;
            optionMenu.LineCharOffset[3] = 7;
            optionMenu.addParam(new Param("Body", null, "", 1, 0));
            optionMenu.addParam(new Param("Title", null, "PGM-MODE", 1, 0));
            optionMenu.addParam(new Param("EmptyLine", null, " ", 2, 0));
            optionMenu.addParam(new Param("Channel", null, "CHANNEL", 3, 0));
            optionMenu.addParam(new Param("Modem", null, "MODEM", 3, 10));
            optionMenu.addParam(new Param("System", null, "SYSTEM", 4, 0));
            optionMenu.addParam(new Param("Manual", null, "MANUAL", 4, 10));
            optionMenu.getParam("Channel").IsActive = true;

            optionMenu.addActionToParam(optionMenu.getParam("Body"), new Button("LEFT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();

                if (activeParam == null)
                {
                    var param = wdg.getParam("Manual");
                    wdg.deactiveParam();
                    param.IsActive = true;
                    return;
                }

                switch (activeParam.Name)
                {
                    case "Channel":
                        {
                            var param = wdg.getParam("Manual");
                            wdg.deactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Modem":
                        {
                            var param = wdg.getParam("Channel");
                            wdg.deactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "System":
                        {
                            var param = wdg.getParam("Modem");
                            wdg.deactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Manual":
                        {
                            var param = wdg.getParam("System");
                            wdg.deactiveParam();
                            param.IsActive = true;
                            break;
                        }
                }

            }));
            optionMenu.addActionToParam(optionMenu.getParam("Body"), new Button("RIGTH", (Button btn, RadioStation rs, Widget wdg) =>
            {

                var activeParam = wdg.activeParam();

                if (activeParam == null)
                {
                    var param = wdg.getParam("Channel");
                    wdg.deactiveParam();
                    param.IsActive = true;
                    return;
                }

                switch (activeParam.Name)
                {
                    case "Channel":
                        {
                            var param = wdg.getParam("Modem");
                            wdg.deactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Modem":
                        {
                            var param = wdg.getParam("System");
                            wdg.deactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "System":
                        {
                            var param = wdg.getParam("Manual");
                            wdg.deactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Manual":
                        {
                            var param = wdg.getParam("Channel");
                            wdg.deactiveParam();
                            param.IsActive = true;
                            break;
                        }
                }
            }));

            optionMenu.addActionToParam(optionMenu.getParam("Channel"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {

                var activeParam = wdg.activeParam();

                if (activeParam == null || activeParam.Name != "Channel")
                {
                    return;
                }

                wdg.prepareToShowWidget(getNameMenu(MenuNames.ProgramModePresetChannelMenu));

            }));
            optionMenu.addActionToParam(optionMenu.getParam("Modem"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {

                var activeParam = wdg.activeParam();

                if (activeParam == null || activeParam.Name != "Modem")
                {
                    return;
                }

                wdg.prepareToShowWidget(getNameMenu(MenuNames.ProgramModePresetModemMenu));

            }));
            optionMenu.addActionToParam(optionMenu.getParam("System"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {

                var activeParam = wdg.activeParam();

                if (activeParam == null || activeParam.Name != "System")
                {
                    return;
                }

                wdg.prepareToShowWidget(getNameMenu(MenuNames.ProgramModePresetSystemMenu));

            }));
            optionMenu.addActionToParam(optionMenu.getParam("Body"), new Button("CLR", (Button btn, RadioStation rs, Widget wdg) =>
            {
                wdg.showPreviousWidget();
            }));
            return optionMenu;
        }
        static public Widget initProgramModePresetChannelMenu(RadioStation station)
        {

            Widget programMenu = new Widget(getNameMenu(MenuNames.ProgramModePresetChannelMenu));

            programMenu.LineSize[0] = 5;
            programMenu.LineSize[1] = 9;
            programMenu.LineSize[2] = 9;
            programMenu.LineSize[3] = 5;
            programMenu.LineCharOffset[0] = 6;
            programMenu.LineCharOffset[1] = 6;
            programMenu.LineCharOffset[2] = 7;
            programMenu.LineCharOffset[3] = 6;
            programMenu.addParam(new Param("Body", null, "", 1, 0));
            programMenu.addParam(new Param("Title", null, "PGM-MODE-PRESET-CHANNEL-", 1, 0));
            programMenu.addParam(new Param("KeyTitle", null, "CHANNEL NUMBER", 2, 6));
            programMenu.addParam(new Param("KeyTitleCont", null, "TO CHANGE:", 3, 0));
            programMenu.addParam(new Param("KeyValue", (string text, Param cParam) =>
            {
                cParam.text = cParam.Text.Remove(cParam.ActiveFrom, cParam.ActiveTo);
                cParam.text = cParam.Text.Insert(cParam.ActiveFrom, text);

            }, "000", 3, 15));
            programMenu.addParam(new Param("Info", null, "ENT TO SAVE - CLR TO EXIT", 4, 15));

            programMenu.getParam("KeyValue").IsActive = true;

            WidgetTextParams channelNumberTP = new WidgetTextParams("CHANNEL NUMBER");//ENTER
            channelNumberTP.addParam("000");
            WidgetTextParams rxFrequencyPT = new WidgetTextParams("RX FREQUENCY");//ENTER
            rxFrequencyPT.addParam("07.8000 MHZ");
            WidgetTextParams txFrequencyPT = new WidgetTextParams("TX FREQUENCY");//ENTER
            txFrequencyPT.addParam("07.8000 MHZ"); ;
            WidgetTextParams modulationPT = new WidgetTextParams("MODULATION");
            modulationPT.addParam("USB").addParam("FM").addParam("CW").addParam("AME").addParam("LSB");
            WidgetTextParams rxOnlyPT = new WidgetTextParams("MODE");
            rxOnlyPT.addParam("NO").addParam("YES");
            WidgetTextParams enableHailTxPT = new WidgetTextParams("ENABLE HAIL TX");
            enableHailTxPT.addParam("NO").addParam("YES");
            WidgetTextParams hailKeyPT = new WidgetTextParams("HAIL KEY"); //ENTER, AFTER enableHailTxPT == YES
            hailKeyPT.addParam("00");
            WidgetTextParams enableSsbScan = new WidgetTextParams("ENABLE SSB SCAN");
            enableSsbScan.addParam("NO").addParam("YES");
            WidgetTextParams maximumBandwidth = new WidgetTextParams("MAXIMUM BANDWIDTH");
            maximumBandwidth.addParam("3 KHZ").addParam("24 KHZ").addParam("21 KHZ").addParam("18 KHZ").addParam("15 KHZ").addParam("12 KHZ").addParam("9 KHZ").addParam("6 KHZ");


            List<WidgetTextParams> radioParams = new List<WidgetTextParams>();
            radioParams.Add(channelNumberTP);
            radioParams.Add(rxFrequencyPT);
            radioParams.Add(txFrequencyPT);
            radioParams.Add(modulationPT);
            radioParams.Add(rxOnlyPT);
            radioParams.Add(enableHailTxPT);
            radioParams.Add(hailKeyPT);
            radioParams.Add(enableSsbScan);
            radioParams.Add(maximumBandwidth);


            programMenu.addActionToParam(programMenu.getParam("KeyValue"), new Button("DOWN", (Button btn, RadioStation rs, Widget wdg) =>
            {
                Param activeParam = wdg.activeParam();
                Param titleParam = wdg.getParam("KeyTitle");

                if (titleParam.Text != "CHANNEL NUMBER" 
                && titleParam.Text != "RX FREQUENCY"
                && titleParam.Text != "TX FREQUENCY"
                && titleParam.Text != "HAIL KEY")
                {
                    string paramTitle = titleParam.Text;

                    activeParam.Text = radioParams.Find(p => p.Name == paramTitle).getPrevParam();
                    activeParam.ActiveTo = activeParam.Text.Length;

                    activeParam.Y = Helper.calcCenterIndent(activeParam.Text.Length, 28);
                    titleParam.Y = Helper.calcCenterIndent(titleParam.Text.Length, 28);
                    return;
                }

                if (!activeParam.isInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                activeParam.action("9");
            }));

            programMenu.addActionToParam(programMenu.getParam("KeyValue"), new Button("UP", (Button btn, RadioStation rs, Widget wdg) =>
            {
                Param activeParam = wdg.activeParam();
                Param titleParam = wdg.getParam("KeyTitle");


                if (titleParam.Text != "CHANNEL NUMBER"
                && titleParam.Text != "RX FREQUENCY"
                && titleParam.Text != "TX FREQUENCY"
                && titleParam.Text != "HAIL KEY")
                {

                    string paramTitle = titleParam.Text;

                    activeParam.Text = radioParams.Find(p => p.Name == paramTitle).getNextParam();
                    activeParam.ActiveTo = activeParam.Text.Length;

                    activeParam.Y = Helper.calcCenterIndent(activeParam.Text.Length, 28);
                    titleParam.Y = Helper.calcCenterIndent(titleParam.Text.Length, 28);
                    return;
                }

                if (!activeParam.isInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                activeParam.action("6");
            }));

            programMenu.addActionToParam(programMenu.getParam("KeyValue"), new Button("LEFT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                Param activeParam = wdg.activeParam();
                Param titleParam = wdg.getParam("KeyTitle");


                if (titleParam.Text != "CHANNEL NUMBER"
                && titleParam.Text != "RX FREQUENCY"
                && titleParam.Text != "TX FREQUENCY"
                && titleParam.Text != "HAIL KEY")
                {
                    return;
                }

                if (!activeParam.isInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                    return;
                }

                if (activeParam.isInParam())
                {
                    if(activeParam.ActiveFrom <= 0)
                    {
                        return;
                    }
                    activeParam.ActiveFrom -= 1;
                    if (!Char.IsDigit(activeParam.getActiveText()[0]))
                    {
                        activeParam.ActiveFrom -= 1;
                    }
                }
            }));

            programMenu.addActionToParam(programMenu.getParam("KeyValue"), new Button("RIGTH", (Button btn, RadioStation rs, Widget wdg) =>
            {
                Param activeParam = wdg.activeParam();
                Param titleParam = wdg.getParam("KeyTitle");



                if (titleParam.Text != "CHANNEL NUMBER"
                && titleParam.Text != "RX FREQUENCY"
                && titleParam.Text != "TX FREQUENCY"
                && titleParam.Text != "HAIL KEY")
                {
                    return;
                }


                if (!activeParam.isInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                    return;
                }

                if (activeParam.isInParam())
                {
                    activeParam.ActiveFrom += 1;

                    if (titleParam.Text == "RX FREQUENCY" || titleParam.Text == "TX FREQUENCY")
                    {
                        if (!Char.IsDigit(activeParam.getActiveText()[0]))
                        {
                            activeParam.ActiveFrom += 1;
                        }
                        if (activeParam.ActiveFrom > activeParam.Text.Length - 5)
                        {
                            activeParam.ActiveFrom = activeParam.Text.Length - 5;
                        }
                    } 
                    else if (activeParam.ActiveFrom > activeParam.Text.Length - 1)
                    {
                        activeParam.ActiveFrom = activeParam.Text.Length - 1;
                    }
                }
            }));

            programMenu.addActionToParam(programMenu.getParam("Body"), new Button("CALL", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();
                var titleParam = wdg.getParam("KeyTitle");

                if (titleParam.Text != "CHANNEL NUMBER"
                && titleParam.Text != "RX FREQUENCY"
                && titleParam.Text != "TX FREQUENCY"
                && titleParam.Text != "HAIL KEY")
                {
                    return;
                }


                if (!activeParam.isInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                activeParam.action("1");

            }));
            programMenu.addActionToParam(programMenu.getParam("Body"), new Button("LT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();
                var titleParam = wdg.getParam("KeyTitle");

                if (titleParam.Text != "CHANNEL NUMBER"
                && titleParam.Text != "RX FREQUENCY"
                && titleParam.Text != "TX FREQUENCY"
                && titleParam.Text != "HAIL KEY")
                {
                    return;
                }


                if (!activeParam.isInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                activeParam.action("2");

            }));
            programMenu.addActionToParam(programMenu.getParam("Body"), new Button("MODE", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();
                var titleParam = wdg.getParam("KeyTitle");

                if (titleParam.Text != "CHANNEL NUMBER"
                && titleParam.Text != "RX FREQUENCY"
                && titleParam.Text != "TX FREQUENCY"
                && titleParam.Text != "HAIL KEY")
                {
                    return;
                }


                if (!activeParam.isInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                activeParam.action("3");

            }));
            programMenu.addActionToParam(programMenu.getParam("Body"), new Button("SQL", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();
                var titleParam = wdg.getParam("KeyTitle");

                if (titleParam.Text != "CHANNEL NUMBER"
                && titleParam.Text != "RX FREQUENCY"
                && titleParam.Text != "TX FREQUENCY"
                && titleParam.Text != "HAIL KEY")
                {
                    return;
                }


                if (!activeParam.isInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                activeParam.action("4");


            }));
            programMenu.addActionToParam(programMenu.getParam("Body"), new Button("ZERO", (Button btn, RadioStation rs, Widget wdg) =>
            {

                var activeParam = wdg.activeParam();
                var titleParam = wdg.getParam("KeyTitle");

                if (titleParam.Text != "CHANNEL NUMBER"
                && titleParam.Text != "RX FREQUENCY"
                && titleParam.Text != "TX FREQUENCY"
                && titleParam.Text != "HAIL KEY")
                {
                    return;
                }


                if (!activeParam.isInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                activeParam.action("5");


            }));

            programMenu.addActionToParam(programMenu.getParam("Body"), new Button("OPT", (Button btn, RadioStation rs, Widget wdg) =>
            {

                var activeParam = wdg.activeParam();
                var titleParam = wdg.getParam("KeyTitle");

                if (titleParam.Text != "CHANNEL NUMBER"
                && titleParam.Text != "RX FREQUENCY"
                && titleParam.Text != "TX FREQUENCY"
                && titleParam.Text != "HAIL KEY")
                {
                    return;
                }


                if (!activeParam.isInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                activeParam.action("7");


            }));
            programMenu.addActionToParam(programMenu.getParam("Body"), new Button("PGM", (Button btn, RadioStation rs, Widget wdg) =>
            {

                var activeParam = wdg.activeParam();
                var titleParam = wdg.getParam("KeyTitle");

                if (titleParam.Text != "CHANNEL NUMBER"
                && titleParam.Text != "RX FREQUENCY"
                && titleParam.Text != "TX FREQUENCY"
                && titleParam.Text != "HAIL KEY")
                {
                    return;
                }


                if (!activeParam.isInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                activeParam.action("8");


            }));
            programMenu.addActionToParam(programMenu.getParam("Body"), new Button("UPDATE", (Button btn, RadioStation rs, Widget wdg) =>
            {

                var activeParam = wdg.activeParam();
                var titleParam = wdg.getParam("KeyTitle");

                if (titleParam.Text != "CHANNEL NUMBER"
                && titleParam.Text != "RX FREQUENCY"
                && titleParam.Text != "TX FREQUENCY"
                && titleParam.Text != "HAIL KEY")
                {
                    return;
                }

                if (!activeParam.isInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                activeParam.action("0");


            }));
            
            programMenu.addActionToParam(programMenu.getParam("Body"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {

                Param activeParam = wdg.activeParam();
                Param titleParam = wdg.getParam("KeyTitle");

                string paramTitle = titleParam.Text;

                if (titleParam.Text == "CHANNEL NUMBER"
                    || titleParam.Text == "RX FREQUENCY"
                    || titleParam.Text == "TX FREQUENCY"
                    || titleParam.Text == "HAIL KEY")
                {
                    var currParam = radioParams.Find(p => p.Name == paramTitle);
                    currParam.Parameters[currParam.CurrIndex] = activeParam.Text;
                }

                int nextIndex = radioParams.IndexOf(radioParams.Find(p => p.Name == paramTitle)) + 1;
                if (nextIndex < radioParams.Count)
                {
                    titleParam.Text = radioParams[nextIndex].Name;
                    activeParam.Text = radioParams[nextIndex].currParam();
                } 
                else
                {
                    titleParam.Text = radioParams[0].Name;
                    activeParam.Text = radioParams[0].currParam();
                }

                activeParam.ActiveTo = activeParam.Text.Length;
                activeParam.ActiveFrom = 0;

                if (titleParam.Text == "CHANNEL NUMBER")
                {
                    programMenu.getParam("KeyTitleCont").IsVisible = true;
                } 
                else
                {
                    programMenu.getParam("KeyTitleCont").IsVisible = false;
                }

                activeParam.Y = Helper.calcCenterIndent(activeParam.Text.Length, 28);
                titleParam.Y = Helper.calcCenterIndent(titleParam.Text.Length, 28);
            }));

            programMenu.addActionToParam(programMenu.getParam("Body"), new Button("CLR", (Button btn, RadioStation rs, Widget wdg) =>
            {
                wdg.showPreviousWidget();

                Param activeParam = wdg.activeParam();
                Param titleParam = wdg.getParam("KeyValue");

                activeParam.Text = radioParams[0].currParam();
                titleParam.Text = radioParams[0].Name;
                activeParam.Y = Helper.calcCenterIndent(activeParam.Text.Length, 28);
                titleParam.Y = Helper.calcCenterIndent(titleParam.Text.Length, 28);
            }));

            return programMenu;
        }
        static public Widget initProgramModePresetModemMenu(RadioStation station)
        {

            Widget programMenu = new Widget(getNameMenu(MenuNames.ProgramModePresetModemMenu));

            programMenu.LineSize[0] = 5;
            programMenu.LineSize[1] = 9;
            programMenu.LineSize[2] = 9;
            programMenu.LineSize[3] = 5;
            programMenu.LineCharOffset[0] = 6;
            programMenu.LineCharOffset[1] = 6;
            programMenu.LineCharOffset[2] = 7;
            programMenu.LineCharOffset[3] = 6;
            programMenu.addParam(new Param("Body", null, "", 1, 0));
            programMenu.addParam(new Param("Title", null, "PGM-MODE-PRESET-MODEM-", 1, 0));
            programMenu.addParam(new Param("KeyTitle", null, "MODEM PRESET", 2, 10));
            programMenu.addParam(new Param("KeyTitleCont", null, "TO CHANGE:", 3, 0));
            programMenu.addParam(new Param("KeyValue", (string text, Param cParam) =>
            {
                cParam.text = cParam.Text.Remove(cParam.ActiveFrom, cParam.ActiveTo);
                cParam.text = cParam.Text.Insert(cParam.ActiveFrom, text);

            }, "MDM01", 3, 10));
            programMenu.addParam(new Param("Info", null, "ENT TO SAVE - CLR TO EXIT", 4, 15));

            programMenu.getParam("KeyValue").IsActive = true;

            WidgetTextParams modemNumTP = new WidgetTextParams("MODEM PRESET");
            for (int i = 1; i <= 20; i++)
            {
                string numStr = i < 10 ? "0" + i : i.ToString();
                modemNumTP.addParam("MDM" + numStr);
            }

            WidgetTextParams presetNameTP = new WidgetTextParams("PRESET NAME");
            presetNameTP.addParam("");
            WidgetTextParams modemTypeTP = new WidgetTextParams("MODEM TYPE");
            modemTypeTP
                .addParam("MIL110B").addParam("WBHF").addParam("ARQ").addParam("XDL")
                .addParam("WBFSK").addParam("STANAG-4285-U").addParam("STANAG-4285-C").addParam("SERIAL");
            WidgetTextParams dataRateTP = new WidgetTextParams("DATA RATE");
            dataRateTP.addParam("600").addParam("300").addParam("150").addParam("75").addParam("4800")
                      .addParam("2400").addParam("1200");
            WidgetTextParams modeTP = new WidgetTextParams("MODE");
            modeTP.addParam("SYNC").addParam("ASYNC");
            WidgetTextParams dataBitsTP = new WidgetTextParams("DATA BITS");
            dataBitsTP.addParam("7").addParam("8");
            WidgetTextParams stopBitsTP = new WidgetTextParams("STOP BITS");
            stopBitsTP.addParam("1").addParam("2");
            WidgetTextParams parityTP = new WidgetTextParams("PARITY");
            parityTP.addParam("EVEN").addParam("NONE").addParam("SPACE").addParam("MARK").addParam("ODD");
            WidgetTextParams enableTP = new WidgetTextParams("ENABLE");
            enableTP.addParam("NO").addParam("YES");


            List<WidgetTextParams> radioParams = new List<WidgetTextParams>();
            radioParams.Add(modemNumTP);
            radioParams.Add(presetNameTP);
            radioParams.Add(modemTypeTP);
            radioParams.Add(dataRateTP);
            radioParams.Add(modeTP);
            radioParams.Add(dataBitsTP);
            radioParams.Add(stopBitsTP);
            radioParams.Add(parityTP);
            radioParams.Add(enableTP);

            string oldPresetName = "MDM01";

            programMenu.addActionToParam(programMenu.getParam("KeyValue"), new Button("DOWN", (Button btn, RadioStation rs, Widget wdg) =>
            {
                Param activeParam = wdg.activeParam();
                Param titleParam = wdg.getParam("KeyTitle");

                if (titleParam.Text != "PRESET NAME")
                {
                    string paramTitle = titleParam.Text;

                    activeParam.Text = radioParams.Find(p => p.Name == paramTitle).getPrevParam();
                    activeParam.ActiveTo = activeParam.Text.Length;
                    activeParam.Y = Helper.calcCenterIndent(activeParam.Text.Length, 28);
                    titleParam.Y = Helper.calcCenterIndent(titleParam.Text.Length, 28);
                    return;
                }

                if (!activeParam.isInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                string symbols = "9YZ?";
                string currentSymbol = activeParam.getActiveText();
                int index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                }
                string nextSymbol = symbols.Substring(index, 1);
                activeParam.action(nextSymbol);
            }));

            programMenu.addActionToParam(programMenu.getParam("KeyValue"), new Button("UP", (Button btn, RadioStation rs, Widget wdg) =>
            {
                Param activeParam = wdg.activeParam();
                Param titleParam = wdg.getParam("KeyTitle");


                if (titleParam.Text != "PRESET NAME")
                {

                    string paramTitle = titleParam.Text;

                    activeParam.Text = radioParams.Find(p => p.Name == paramTitle).getNextParam();
                    activeParam.ActiveTo = activeParam.Text.Length;
                    activeParam.Y = Helper.calcCenterIndent(activeParam.Text.Length, 28);
                    titleParam.Y = Helper.calcCenterIndent(titleParam.Text.Length, 28);
                    return;
                }

                if (!activeParam.isInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                string symbols = "6PQR";
                string currentSymbol = activeParam.getActiveText();
                int index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                }
                string nextSymbol = symbols.Substring(index, 1);
                activeParam.action(nextSymbol);
            }));

            programMenu.addActionToParam(programMenu.getParam("KeyValue"), new Button("LEFT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                Param activeParam = wdg.activeParam();
                Param titleParam = wdg.getParam("KeyTitle");


                if (activeParam == null || titleParam.Text != "PRESET NAME")
                {
                    return;
                }

                if (!activeParam.isInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                    return;
                }

                if (activeParam.isInParam())
                {
                    if (activeParam.ActiveFrom <= 0)
                    {
                        return;
                    }
                    activeParam.ActiveFrom -= 1;
                }
            }));

            programMenu.addActionToParam(programMenu.getParam("KeyValue"), new Button("RIGTH", (Button btn, RadioStation rs, Widget wdg) =>
            {
                Param activeParam = wdg.activeParam();
                Param titleParam = wdg.getParam("KeyTitle");



                if (activeParam == null || titleParam.Text != "PRESET NAME")
                {
                    return;
                }


                if (!activeParam.isInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                    return;
                }

                if (activeParam.isInParam())
                {
                    activeParam.ActiveFrom += 1;

                    if (activeParam.ActiveFrom > activeParam.Text.Length - 1)
                    {
                        activeParam.ActiveFrom = activeParam.Text.Length - 1;
                    }
                }
            }));

            programMenu.addActionToParam(programMenu.getParam("Body"), new Button("CALL", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();
                var titleParam = wdg.getParam("KeyTitle");

                if (activeParam == null || titleParam.Text != "PRESET NAME")
                {
                    return;
                }


                if (!activeParam.isInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                string symbols = "1ABC";
                string currentSymbol = activeParam.getActiveText();
                int index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                }
                string nextSymbol = symbols.Substring(index, 1);
                activeParam.action(nextSymbol);

            }));
            programMenu.addActionToParam(programMenu.getParam("Body"), new Button("LT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();
                var titleParam = wdg.getParam("KeyTitle");

                if (activeParam == null || titleParam.Text != "PRESET NAME")
                {
                    return;
                }


                if (!activeParam.isInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                string symbols = "2DEF";
                string currentSymbol = activeParam.getActiveText();
                int index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                }
                string nextSymbol = symbols.Substring(index, 1);
                activeParam.action(nextSymbol);

            }));
            programMenu.addActionToParam(programMenu.getParam("Body"), new Button("MODE", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();
                var titleParam = wdg.getParam("KeyTitle");

                if (activeParam == null || titleParam.Text != "PRESET NAME")
                {
                    return;
                }


                if (!activeParam.isInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                string symbols = "3GHI";
                string currentSymbol = activeParam.getActiveText();
                int index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                }
                string nextSymbol = symbols.Substring(index, 1);
                activeParam.action(nextSymbol);

            }));
            programMenu.addActionToParam(programMenu.getParam("Body"), new Button("SQL", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();
                var titleParam = wdg.getParam("KeyTitle");

                if (activeParam == null || titleParam.Text != "PRESET NAME")
                {
                    return;
                }


                if (!activeParam.isInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                string symbols = "4JKL";
                string currentSymbol = activeParam.getActiveText();
                int index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                }
                string nextSymbol = symbols.Substring(index, 1);
                activeParam.action(nextSymbol);


            }));
            programMenu.addActionToParam(programMenu.getParam("Body"), new Button("ZERO", (Button btn, RadioStation rs, Widget wdg) =>
            {

                var activeParam = wdg.activeParam();
                var titleParam = wdg.getParam("KeyTitle");

                if (activeParam == null || titleParam.Text != "PRESET NAME")
                {
                    return;
                }


                if (!activeParam.isInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                string symbols = "5MNO";
                string currentSymbol = activeParam.getActiveText();
                int index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                }
                string nextSymbol = symbols.Substring(index, 1);
                activeParam.action(nextSymbol);


            }));

            programMenu.addActionToParam(programMenu.getParam("Body"), new Button("OPT", (Button btn, RadioStation rs, Widget wdg) =>
            {

                var activeParam = wdg.activeParam();
                var titleParam = wdg.getParam("KeyTitle");

                if (activeParam == null || titleParam.Text != "PRESET NAME")
                {
                    return;
                }


                if (!activeParam.isInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                string symbols = "7STU";
                string currentSymbol = activeParam.getActiveText();
                int index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                }
                string nextSymbol = symbols.Substring(index, 1);
                activeParam.action(nextSymbol);


            }));
            programMenu.addActionToParam(programMenu.getParam("Body"), new Button("PGM", (Button btn, RadioStation rs, Widget wdg) =>
            {

                var activeParam = wdg.activeParam();
                var titleParam = wdg.getParam("KeyTitle");

                if (activeParam == null || titleParam.Text != "PRESET NAME")
                {
                    return;
                }


                if (!activeParam.isInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                string symbols = "8VWX";
                string currentSymbol = activeParam.getActiveText();
                int index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                }
                string nextSymbol = symbols.Substring(index, 1);
                activeParam.action(nextSymbol);


            }));
            programMenu.addActionToParam(programMenu.getParam("Body"), new Button("UPDATE", (Button btn, RadioStation rs, Widget wdg) =>
            {

                var activeParam = wdg.activeParam();
                var titleParam = wdg.getParam("KeyTitle");

                if (activeParam == null || titleParam.Text != "PRESET NAME")
                {
                    return;
                }

                if (!activeParam.isInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                activeParam.action("0");


            }));

            programMenu.addActionToParam(programMenu.getParam("Body"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {

                Param activeParam = wdg.activeParam();
                Param titleParam = wdg.getParam("KeyTitle");

                string paramTitle = titleParam.Text;

                if (titleParam.Text == "PRESET NAME")
                {
                    var currParam = radioParams.Find(p => p.Name == paramTitle);
                    currParam.Parameters[currParam.CurrIndex] = activeParam.Text;
                }
                
                if (titleParam.Text == "MODEM PRESET")
                {
                    var currParam = radioParams.Find(p => p.Name == "PRESET NAME");
                    currParam.Parameters[0] = activeParam.Text;
                    oldPresetName = activeParam.Text;
                }

                if (titleParam.Text == "ENABLE")
                {
                    var presetNameParam = radioParams.Find(p => p.Name == "MODEM PRESET");
                    presetNameParam.Parameters[presetNameParam.CurrIndex] = radioParams.Find(p => p.Name == "PRESET NAME").currParam();
                    var newModem = StationPresetModemModule.parse(radioParams);
                    station.updatePresetModem(newModem, oldPresetName);
                }

                int nextIndex = radioParams.IndexOf(radioParams.Find(p => p.Name == paramTitle)) + 1;
                if (nextIndex < radioParams.Count)
                {
                    titleParam.Text = radioParams[nextIndex].Name;
                    activeParam.Text = radioParams[nextIndex].currParam();
                }
                else
                {
                    titleParam.Text = radioParams[0].Name;
                    activeParam.Text = radioParams[0].currParam();
                }

                activeParam.ActiveTo = activeParam.Text.Length;
                activeParam.ActiveFrom = 0;

                if (titleParam.Text == "MODEM PRESET")
                {
                    programMenu.getParam("KeyTitleCont").IsVisible = true;
                }
                else
                {
                    programMenu.getParam("KeyTitleCont").IsVisible = false;
                }
                activeParam.Y = Helper.calcCenterIndent(activeParam.Text.Length, 28);
                titleParam.Y = Helper.calcCenterIndent(titleParam.Text.Length, 28);
            }));

            programMenu.addActionToParam(programMenu.getParam("Body"), new Button("CLR", (Button btn, RadioStation rs, Widget wdg) =>
            {
                wdg.showPreviousWidget();

                Param activeParam = wdg.activeParam();
                Param titleParam = wdg.getParam("KeyTitle");

                activeParam.Text = presetNameTP.currParam();
                titleParam.Text = presetNameTP.Name;
                activeParam.Y = Helper.calcCenterIndent(activeParam.Text.Length, 28);
                titleParam.Y = Helper.calcCenterIndent(titleParam.Text.Length, 28);
            }));

            return programMenu;
        }

        static public Widget initProgramModePresetSystemMenu(RadioStation station)
        {

            Widget programMenu = new Widget(getNameMenu(MenuNames.ProgramModePresetSystemMenu));

            programMenu.LineSize[0] = 5;
            programMenu.LineSize[1] = 8;
            programMenu.LineSize[2] = 8;
            programMenu.LineSize[3] = 5;
            programMenu.LineCharOffset[1] = 6;
            programMenu.LineCharOffset[2] = 4;
            programMenu.addParam(new Param("Body", null, "", 1, 0));
            programMenu.addParam(new Param("Title", null, "PGM-MODE-PRESET-SYSTEM-", 1, 0));
            programMenu.addParam(new Param("KeyTitle", null, "SYSTEM PRESET", 2, 10));
            programMenu.addParam(new Param("KeyTitleCont", null, "TO CHANGE:", 3, 0));
            programMenu.addParam(new Param("KeyValue", (string text, Param cParam) =>
            {
                cParam.text = cParam.Text.Remove(cParam.ActiveFrom, cParam.ActiveTo);
                cParam.text = cParam.Text.Insert(cParam.ActiveFrom, text);

            }, "SYSPRE01", 3, 10));
            programMenu.addParam(new Param("Info", null, "ENT TO SAVE - CLR TO EXIT", 4, 15));

            programMenu.getParam("KeyValue").IsActive = true;

            WidgetTextParams modemNumTP = new WidgetTextParams("SYSTEM PRESET");
            for (int i = 1; i <= 75; i++)
            {
                string numStr = i < 10 ? "0" + i : i.ToString();
                modemNumTP.addParam("SYSPRE" + numStr);
            }

            WidgetTextParams presetNameTP = new WidgetTextParams("PRESET NAME"); //ENTER
            presetNameTP.addParam("");
            WidgetTextParams radioModeTP = new WidgetTextParams("RADIO MODE");
            radioModeTP.addParam("FIX").addParam("3G").addParam("ALE").addParam("HOP");
            WidgetTextParams channelNumberTP = new WidgetTextParams("CHANNEL NUMBER"); //ENTER
            channelNumberTP.addParam("000");
            WidgetTextParams modemPreset = new WidgetTextParams("MODEM PRESET");
            modemPreset.addParam("OFF");
            WidgetTextParams encryptionType = new WidgetTextParams("ENCRYPTION TYPE");
            encryptionType.addParam("CITADEL").addParam("AES-256").addParam("AES-128");
            WidgetTextParams encryptionKeyTP = new WidgetTextParams("ENCRYPTION KEY"); //TO DO
            encryptionKeyTP.addParam("-------------------");
            WidgetTextParams ptVoiceModeTP = new WidgetTextParams("PT VOICE MODE");
            ptVoiceModeTP.addParam("CVSD").addParam("CLR").addParam("NONE").addParam("LDV").addParam("ME24")
                .addParam("ME12").addParam("ME6").addParam("DV24").addParam("DV6").addParam("AVS");
            WidgetTextParams ctVoiceModeTP = new WidgetTextParams("CT VOICE MODE");
            ctVoiceModeTP.addParam("NONE").addParam("LDV").addParam("ME24")
                .addParam("ME12").addParam("ME6").addParam("DV24").addParam("DV6");
            WidgetTextParams enableTP = new WidgetTextParams("ENABLE");
            enableTP.addParam("YES").addParam("NO");


            List<WidgetTextParams> radioParams = new List<WidgetTextParams>();
            radioParams.Add(modemNumTP);
            radioParams.Add(presetNameTP);
            radioParams.Add(radioModeTP);
            radioParams.Add(channelNumberTP);
            radioParams.Add(modemPreset);
            radioParams.Add(encryptionType);
            radioParams.Add(encryptionKeyTP);
            radioParams.Add(ptVoiceModeTP);
            radioParams.Add(ctVoiceModeTP);
            radioParams.Add(enableTP);

            string oldPresetName = "SYSPRE01";

            programMenu.addActionToParam(programMenu.getParam("KeyValue"), new Button("DOWN", (Button btn, RadioStation rs, Widget wdg) =>
            {
                Param activeParam = wdg.activeParam();
                Param titleParam = wdg.getParam("KeyTitle");

                if (titleParam.Text != "PRESET NAME" && titleParam.Text != "CHANNEL NUMBER")
                {
                    string paramTitle = titleParam.Text;

                    activeParam.Text = radioParams.Find(p => p.Name == paramTitle).getPrevParam();
                    activeParam.ActiveTo = activeParam.Text.Length;
                    activeParam.Y = Helper.calcCenterIndent(activeParam.Text.Length, 28);
                    titleParam.Y = Helper.calcCenterIndent(titleParam.Text.Length, 28);
                    return;
                }

                if (!activeParam.isInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }

                if (titleParam.Text == "CHANNEL NUMBER")
                {
                    activeParam.action("9");
                    return;
                }

                string symbols = "9YZ?";
                string currentSymbol = activeParam.getActiveText();
                int index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                }
                string nextSymbol = symbols.Substring(index, 1);
                activeParam.action(nextSymbol);
            }));

            programMenu.addActionToParam(programMenu.getParam("KeyValue"), new Button("UP", (Button btn, RadioStation rs, Widget wdg) =>
            {
                Param activeParam = wdg.activeParam();
                Param titleParam = wdg.getParam("KeyTitle");


                if (titleParam.Text != "PRESET NAME" && titleParam.Text != "CHANNEL NUMBER")
                {

                    string paramTitle = titleParam.Text;

                    activeParam.Text = radioParams.Find(p => p.Name == paramTitle).getNextParam();
                    activeParam.ActiveTo = activeParam.Text.Length;
                    activeParam.Y = Helper.calcCenterIndent(activeParam.Text.Length, 28);
                    titleParam.Y = Helper.calcCenterIndent(titleParam.Text.Length, 28);
                    return;
                }

                if (!activeParam.isInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                if (titleParam.Text == "CHANNEL NUMBER")
                {
                    activeParam.action("6");
                    return;
                }

                string symbols = "6PQR";
                string currentSymbol = activeParam.getActiveText();
                int index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                }
                string nextSymbol = symbols.Substring(index, 1);
                activeParam.action(nextSymbol);
            }));

            programMenu.addActionToParam(programMenu.getParam("KeyValue"), new Button("LEFT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                Param activeParam = wdg.activeParam();
                Param titleParam = wdg.getParam("KeyTitle");


                if (activeParam == null || (titleParam.Text != "PRESET NAME" && titleParam.Text != "CHANNEL NUMBER"))
                {
                    return;
                }

                if (!activeParam.isInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                    return;
                }

                if (activeParam.isInParam())
                {
                    if (activeParam.ActiveFrom <= 0)
                    {
                        return;
                    }
                    activeParam.ActiveFrom -= 1;
                }
            }));

            programMenu.addActionToParam(programMenu.getParam("KeyValue"), new Button("RIGTH", (Button btn, RadioStation rs, Widget wdg) =>
            {
                Param activeParam = wdg.activeParam();
                Param titleParam = wdg.getParam("KeyTitle");



                if (activeParam == null 
                || (titleParam.Text != "PRESET NAME" && titleParam.Text != "CHANNEL NUMBER"))
                {
                    return;
                }


                if (!activeParam.isInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                    return;
                }

                if (activeParam.isInParam())
                {
                    activeParam.ActiveFrom += 1;

                    if (activeParam.ActiveFrom > activeParam.Text.Length - 1)
                    {
                        activeParam.ActiveFrom = activeParam.Text.Length - 1;
                    }
                }
            }));

            programMenu.addActionToParam(programMenu.getParam("Body"), new Button("CALL", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();
                var titleParam = wdg.getParam("KeyTitle");

                if (activeParam == null || (titleParam.Text != "PRESET NAME" && titleParam.Text != "CHANNEL NUMBER"))
                {
                    return;
                }


                if (!activeParam.isInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                if (titleParam.Text == "CHANNEL NUMBER")
                {
                    activeParam.action("1");
                    return;
                }

                string symbols = "1ABC";
                string currentSymbol = activeParam.getActiveText();
                int index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                }
                string nextSymbol = symbols.Substring(index, 1);
                activeParam.action(nextSymbol);

            }));
            programMenu.addActionToParam(programMenu.getParam("Body"), new Button("LT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();
                var titleParam = wdg.getParam("KeyTitle");

                if (activeParam == null || (titleParam.Text != "PRESET NAME" && titleParam.Text != "CHANNEL NUMBER"))
                {
                    return;
                }


                if (!activeParam.isInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                if (titleParam.Text == "CHANNEL NUMBER")
                {
                    activeParam.action("2");
                    return;
                }

                string symbols = "2DEF";
                string currentSymbol = activeParam.getActiveText();
                int index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                }
                string nextSymbol = symbols.Substring(index, 1);
                activeParam.action(nextSymbol);

            }));
            programMenu.addActionToParam(programMenu.getParam("Body"), new Button("MODE", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();
                var titleParam = wdg.getParam("KeyTitle");

                if (activeParam == null || (titleParam.Text != "PRESET NAME" && titleParam.Text != "CHANNEL NUMBER"))
                {
                    return;
                }


                if (!activeParam.isInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                if (titleParam.Text == "CHANNEL NUMBER")
                {
                    activeParam.action("3");
                    return;
                }

                string symbols = "3GHI";
                string currentSymbol = activeParam.getActiveText();
                int index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                }
                string nextSymbol = symbols.Substring(index, 1);
                activeParam.action(nextSymbol);

            }));
            programMenu.addActionToParam(programMenu.getParam("Body"), new Button("SQL", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();
                var titleParam = wdg.getParam("KeyTitle");

                if (activeParam == null || (titleParam.Text != "PRESET NAME" && titleParam.Text != "CHANNEL NUMBER"))
                {
                    return;
                }


                if (!activeParam.isInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                if (titleParam.Text == "CHANNEL NUMBER")
                {
                    activeParam.action("4");
                    return;
                }

                string symbols = "4JKL";
                string currentSymbol = activeParam.getActiveText();
                int index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                }
                string nextSymbol = symbols.Substring(index, 1);
                activeParam.action(nextSymbol);


            }));
            programMenu.addActionToParam(programMenu.getParam("Body"), new Button("ZERO", (Button btn, RadioStation rs, Widget wdg) =>
            {

                var activeParam = wdg.activeParam();
                var titleParam = wdg.getParam("KeyTitle");

                if (activeParam == null || (titleParam.Text != "PRESET NAME" && titleParam.Text != "CHANNEL NUMBER"))
                {
                    return;
                }


                if (!activeParam.isInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                if (titleParam.Text == "CHANNEL NUMBER")
                {
                    activeParam.action("5");
                    return;
                }

                string symbols = "5MNO";
                string currentSymbol = activeParam.getActiveText();
                int index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                }
                string nextSymbol = symbols.Substring(index, 1);
                activeParam.action(nextSymbol);


            }));

            programMenu.addActionToParam(programMenu.getParam("Body"), new Button("OPT", (Button btn, RadioStation rs, Widget wdg) =>
            {

                var activeParam = wdg.activeParam();
                var titleParam = wdg.getParam("KeyTitle");

                if (activeParam == null || (titleParam.Text != "PRESET NAME" && titleParam.Text != "CHANNEL NUMBER"))
                {
                    return;
                }


                if (!activeParam.isInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                if (titleParam.Text == "CHANNEL NUMBER")
                {
                    activeParam.action("7");
                    return;
                }

                string symbols = "7STU";
                string currentSymbol = activeParam.getActiveText();
                int index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                }
                string nextSymbol = symbols.Substring(index, 1);
                activeParam.action(nextSymbol);


            }));
            programMenu.addActionToParam(programMenu.getParam("Body"), new Button("PGM", (Button btn, RadioStation rs, Widget wdg) =>
            {

                var activeParam = wdg.activeParam();
                var titleParam = wdg.getParam("KeyTitle");

                if (activeParam == null || (titleParam.Text != "PRESET NAME" && titleParam.Text != "CHANNEL NUMBER"))
                {
                    return;
                }


                if (!activeParam.isInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                if (titleParam.Text == "CHANNEL NUMBER")
                {
                    activeParam.action("8");
                    return;
                }

                string symbols = "8VWX";
                string currentSymbol = activeParam.getActiveText();
                int index = symbols.IndexOf(currentSymbol) + 1;
                if (index > symbols.Length - 1 || index < 0)
                {
                    index = 0;
                }
                string nextSymbol = symbols.Substring(index, 1);
                activeParam.action(nextSymbol);


            }));
            programMenu.addActionToParam(programMenu.getParam("Body"), new Button("UPDATE", (Button btn, RadioStation rs, Widget wdg) =>
            {

                var activeParam = wdg.activeParam();
                var titleParam = wdg.getParam("KeyTitle");

                if (activeParam == null || (titleParam.Text != "PRESET NAME" && titleParam.Text != "CHANNEL NUMBER"))
                {
                    return;
                }

                if (!activeParam.isInParam())
                {
                    activeParam.ActiveFrom = 0;
                    activeParam.ActiveTo = 1;
                }
                activeParam.action("0");


            }));

            programMenu.addActionToParam(programMenu.getParam("Body"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {

                Param activeParam = wdg.activeParam();
                Param titleParam = wdg.getParam("KeyTitle");

                string paramTitle = titleParam.Text;

                if (titleParam.Text == "PRESET NAME")
                {
                    var currParam = radioParams.Find(p => p.Name == paramTitle);
                    currParam.Parameters[currParam.CurrIndex] = activeParam.Text;
                }

                if (titleParam.Text == "SYSTEM PRESET")
                {
                    var currParam = radioParams.Find(p => p.Name == "PRESET NAME");
                    currParam.Parameters[0] = activeParam.Text;
                    oldPresetName = activeParam.Text;
                }

                if (titleParam.Text == "ENABLE")
                {
                    var presetNameParam = radioParams.Find(p => p.Name == "SYSTEM PRESET");
                    presetNameParam.Parameters[presetNameParam.CurrIndex] = radioParams.Find(p => p.Name == "PRESET NAME").currParam();
                    station.addPresetSystem(radioParams, oldPresetName);
                }

                if (titleParam.Text == "ENCRYPTION TYPE")
                {
                    var nextParam = radioParams.Find(p => p.Name == "ENCRYPTION KEY");
                    nextParam.clear();
                    nextParam.addParam("-------------------");
                    KeyModule.KeyType type = KeyModule.stringToType(activeParam.Text);
                    foreach (var key in station.Keys.Keys[type])
                    {
                        nextParam.addParam(key.KeyName);
                    }
                }

                int nextIndex = radioParams.IndexOf(radioParams.Find(p => p.Name == paramTitle)) + 1;
                if (nextIndex < radioParams.Count)
                {
                    titleParam.Text = radioParams[nextIndex].Name;
                    activeParam.Text = radioParams[nextIndex].currParam();
                }
                else
                {
                    titleParam.Text = radioParams[0].Name;
                    activeParam.Text = radioParams[0].currParam();
                }

                activeParam.ActiveTo = activeParam.Text.Length;
                activeParam.ActiveFrom = 0;

                if (titleParam.Text == "MODEM PRESET")
                {
                    programMenu.getParam("KeyTitleCont").IsVisible = true;
                    modemPreset.clear();
                    modemPreset.addParam("OFF");
                    foreach (var modem in station.PresetModems)
                    {
                        modemPreset.addParam(modem.name);
                    }
                }
                else
                {
                    programMenu.getParam("KeyTitleCont").IsVisible = false;
                }

                activeParam.Y = Helper.calcCenterIndent(activeParam.Text.Length, 28);
                titleParam.Y = Helper.calcCenterIndent(titleParam.Text.Length, 28);
            }));

            programMenu.addActionToParam(programMenu.getParam("Body"), new Button("CLR", (Button btn, RadioStation rs, Widget wdg) =>
            {
                wdg.showPreviousWidget();

                Param activeParam = wdg.activeParam();
                Param titleParam = wdg.getParam("KeyTitle");

                activeParam.Text = presetNameTP.currParam();
                titleParam.Text = presetNameTP.Name;
                activeParam.Y = Helper.calcCenterIndent(activeParam.Text.Length, 28);
                titleParam.Y = Helper.calcCenterIndent(titleParam.Text.Length, 28);
            }));

            return programMenu;
        }

        static public Widget initProgramModeAleMenu(RadioStation station)
        {

            Widget optionMenu = new Widget(getNameMenu(MenuNames.ProgramModeAleMenu));
            optionMenu.LineSize[0] = 5;
            optionMenu.LineSize[1] = 8;
            optionMenu.LineSize[2] = 8;
            optionMenu.LineSize[3] = 8;
            optionMenu.addParam(new Param("Body", null, "", 1, 0));
            optionMenu.addParam(new Param("Title", null, "PGM-MODE-ALE", 1, 0));
            optionMenu.addParam(new Param("EmptyLine", null, " ", 2, 0));
            optionMenu.addParam(new Param("Chan_group", null, "CHAN_GROUP", 3, 0));
            optionMenu.addParam(new Param("Address", null, "ADDRESS", 3, 15));
            optionMenu.addParam(new Param("Config", null, "CONFIG", 4, 0));
            optionMenu.addParam(new Param("Lqa", null, "LQA", 4, 10));
            optionMenu.addParam(new Param("Amd", null, "AMD", 4, 15));
            optionMenu.getParam("Chan_group").IsActive = true;

            optionMenu.addActionToParam(optionMenu.getParam("Body"), new Button("LEFT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();

                if (activeParam == null)
                {
                    var param = wdg.getParam("Amd");
                    wdg.deactiveParam();
                    param.IsActive = true;
                    return;
                }

                switch (activeParam.Name)
                {
                    case "Chan_group":
                        {
                            var param = wdg.getParam("Amd");
                            wdg.deactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Address":
                        {
                            var param = wdg.getParam("Chan_group");
                            wdg.deactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Config":
                        {
                            var param = wdg.getParam("Address");
                            wdg.deactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Lqa":
                        {
                            var param = wdg.getParam("Config");
                            wdg.deactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Amd":
                        {
                            var param = wdg.getParam("Lqa");
                            wdg.deactiveParam();
                            param.IsActive = true;
                            break;
                        }
                }

            }));
            optionMenu.addActionToParam(optionMenu.getParam("Body"), new Button("RIGTH", (Button btn, RadioStation rs, Widget wdg) =>
            {

                var activeParam = wdg.activeParam();

                if (activeParam == null)
                {
                    var param = wdg.getParam("Chan_group");
                    wdg.deactiveParam();
                    param.IsActive = true;
                    return;
                }

                switch (activeParam.Name)
                {
                    case "Chan_group":
                        {
                            var param = wdg.getParam("Address");
                            wdg.deactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Address":
                        {
                            var param = wdg.getParam("Config");
                            wdg.deactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Config":
                        {
                            var param = wdg.getParam("Lqa");
                            wdg.deactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Lqa":
                        {
                            var param = wdg.getParam("Amd");
                            wdg.deactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Amd":
                        {
                            var param = wdg.getParam("Address");
                            wdg.deactiveParam();
                            param.IsActive = true;
                            break;
                        }
                }
            }));

            optionMenu.addActionToParam(optionMenu.getParam("Amd"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {

                var activeParam = wdg.activeParam();

                if (activeParam == null || activeParam.Name != "Amd")
                {
                    return;
                }

                wdg.prepareToShowWidget(getNameMenu(MenuNames.ProgramModeAleAmdMenu));

            }));
            optionMenu.addActionToParam(optionMenu.getParam("Body"), new Button("CLR", (Button btn, RadioStation rs, Widget wdg) =>
            {
                wdg.showPreviousWidget();
            }));
            return optionMenu;
        }
        static public Widget initProgramModeAleAmdMenu(RadioStation station)
        {

            Widget optionMenu = new Widget(getNameMenu(MenuNames.ProgramModeAleAmdMenu));
            optionMenu.LineSize[0] = 5;
            optionMenu.LineSize[1] = 8;
            optionMenu.LineSize[2] = 8;
            optionMenu.LineSize[3] = 8;
            optionMenu.addParam(new Param("Body", null, "", 1, 0));
            optionMenu.addParam(new Param("Title", null, "PGM-MODE-ALE-AMD", 1, 0));
            optionMenu.addParam(new Param("EmptyLine", null, " ", 2, 0));
            optionMenu.addParam(new Param("Tx_msg", null, "TX_MSG", 3, 0));
            optionMenu.addParam(new Param("Rx_msg", null, "RX_MSG", 3, 15));
            optionMenu.getParam("Tx_msg").IsActive = true;

            optionMenu.addActionToParam(optionMenu.getParam("Body"), new Button("LEFT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                var activeParam = wdg.activeParam();

                if (activeParam == null)
                {
                    var param = wdg.getParam("Rx_msg");
                    wdg.deactiveParam();
                    param.IsActive = true;
                    return;
                }

                switch (activeParam.Name)
                {
                    case "Tx_msg":
                        {
                            var param = wdg.getParam("Rx_msg");
                            wdg.deactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Rx_msg":
                        {
                            var param = wdg.getParam("Tx_msg");
                            wdg.deactiveParam();
                            param.IsActive = true;
                            break;
                        }
                }

            }));
            optionMenu.addActionToParam(optionMenu.getParam("Body"), new Button("RIGTH", (Button btn, RadioStation rs, Widget wdg) =>
            {

                var activeParam = wdg.activeParam();

                if (activeParam == null)
                {
                    var param = wdg.getParam("Tx_msg");
                    wdg.deactiveParam();
                    param.IsActive = true;
                    return;
                }

                switch (activeParam.Name)
                {
                    case "Tx_msg":
                        {
                            var param = wdg.getParam("Rx_msg");
                            wdg.deactiveParam();
                            param.IsActive = true;
                            break;
                        }
                    case "Rx_msg":
                        {
                            var param = wdg.getParam("Tx_msg");
                            wdg.deactiveParam();
                            param.IsActive = true;
                            break;
                        }
                }

            }));

            optionMenu.addActionToParam(optionMenu.getParam("Tx_msg"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {

                var activeParam = wdg.activeParam();

                if (activeParam == null || activeParam.Name != "Tx_msg")
                {
                    return;
                }

                wdg.prepareToShowWidget(getNameMenu(MenuNames.ProgramModeAleAmdTxMsgMenu));

            }));
            optionMenu.addActionToParam(optionMenu.getParam("Body"), new Button("CLR", (Button btn, RadioStation rs, Widget wdg) =>
            {
                wdg.showPreviousWidget();
            }));
            return optionMenu;
        }

        public static Widget initProgramModeAleAmdTxMsgMenu(RadioStation station)
        {
            Widget optionMenu = new Widget(getNameMenu(MenuNames.ProgramModeAleAmdTxMsgMenu));

            optionMenu.LineSize[0] = 5;
            optionMenu.LineSize[1] = 8;
            optionMenu.LineSize[2] = 8;
            optionMenu.LineSize[3] = 5;
            optionMenu.LineCharOffset[1] = 6;
            optionMenu.LineCharOffset[2] = 4;
            optionMenu.addParam(new Param("Body", null, "", 1, 0));
            optionMenu.addParam(new Param("Title", null, "PGM-MODE-ALE-AMD-TX_MSG", 1, 0));
            optionMenu.addParam(new Param("SmsTitle", null, "TX_MESSAGE", 2, 7));
            optionMenu.addParam(new Param("SmsValue", null, "EDIT", 3, 12));
            optionMenu.addParam(new Param("Info", null, "PRESS ↑↓ TO SCROLL", 4, 15));

            optionMenu.getParam("SmsValue").IsActive = true;

            WidgetTextParams smsFunctions = new WidgetTextParams("TX_MESSAGE");
            smsFunctions.addParam("EDIT").addParam("REVIEW").addParam("DELETE");

            List<WidgetTextParams> radioParams = new List<WidgetTextParams>();
            radioParams.Add(smsFunctions);


            optionMenu.addActionToParam(optionMenu.getParam("SmsValue"), new Button("DOWN", (Button btn, RadioStation rs, Widget wdg) =>
            {
                Param activeParam = wdg.activeParam();
                Param titleParam = wdg.getParam("SmsTitle");

                string paramTitle = titleParam.Text;

                activeParam.Text = radioParams.Find(p => p.Name == paramTitle).getPrevParam();
                activeParam.ActiveTo = activeParam.Text.Length;
                activeParam.Y = Helper.calcCenterIndent(activeParam.Text.Length, 28);
                titleParam.Y = Helper.calcCenterIndent(titleParam.Text.Length, 28);
            }));

            optionMenu.addActionToParam(optionMenu.getParam("SmsValue"), new Button("UP", (Button btn, RadioStation rs, Widget wdg) =>
            {
                Param activeParam = wdg.activeParam();
                Param titleParam = wdg.getParam("SmsTitle");

                string paramTitle = titleParam.Text;

                activeParam.Text = radioParams.Find(p => p.Name == paramTitle).getNextParam();
                activeParam.ActiveTo = activeParam.Text.Length;
                activeParam.Y = Helper.calcCenterIndent(activeParam.Text.Length, 28);
                titleParam.Y = Helper.calcCenterIndent(titleParam.Text.Length, 28);
            }));

            optionMenu.addActionToParam(optionMenu.getParam("Body"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                Param activeParam = wdg.activeParam();

                switch (activeParam.Text)
                {
                    case "EDIT":
                        {
                            Form1.currObject.QueueWidget.add(initProgramModeAleAmdTxMsgSelectMenu(station, true, false, clr: () =>
                            {
                                Form1.currObject.QueueWidget.add(optionMenu);
                                Form1.currObject.startShowWidgetQueue();
                            }));
                            Form1.currObject.startShowWidgetQueue();
                            break;
                        }
                    case "DELETE":
                        {
                            Form1.currObject.QueueWidget.add(initProgramModeAleAmdTxMsgSelectMenu(station, false, true, clr: () =>
                            {
                                Form1.currObject.QueueWidget.add(optionMenu);
                                Form1.currObject.startShowWidgetQueue();
                            }));
                            Form1.currObject.startShowWidgetQueue();
                            break;
                        }
                }
            }));

            optionMenu.addActionToParam(optionMenu.getParam("Body"), new Button("CLR", (Button btn, RadioStation rs, Widget wdg) =>
            {
                wdg.showPreviousWidget();
            }));

            return optionMenu;
        }
        public static Widget initProgramModeAleAmdTxMsgSelectMenu(RadioStation station, bool edit = false, bool remove = false, Action clr = null)
        {
            Widget optionMenu = new Widget("initProgramModeAleAmdTxMsgSelectMenu");

            optionMenu.LineSize[0] = 5;
            optionMenu.LineSize[1] = 8;
            optionMenu.LineSize[2] = 8;
            optionMenu.LineSize[3] = 5;
            optionMenu.LineCharOffset[1] = 6;
            optionMenu.LineCharOffset[2] = 4;
            optionMenu.addParam(new Param("Body", null, "", 1, 0));
            optionMenu.addParam(new Param("Title", null, "PGM-MODE-ALE-AMD-TX_MSG", 1, 0));
            optionMenu.addParam(new Param("TitleNumberMessage", null, "", 1, 25, () => {
                var tnm = optionMenu.getParam("TitleNumberMessage");
                tnm.Text = "EDIT " + station.TxMsgs.currMsg().number;
            }));
            optionMenu.addParam(new Param("SmsTitle", null, "TX MESSAGE:", 2, 7));
            optionMenu.addParam(new Param("SmsValue", null, "", 3, 0, () => {
                var smsVal = optionMenu.getParam("SmsValue");
                int defLenghtEmptyMsg = txMsg.emptyMsg.Length;
                var currMsg = station.TxMsgs.currMsg();
                if (currMsg.msg.Length < defLenghtEmptyMsg)
                {
                    smsVal.Text = currMsg.msg;
                } 
                else
                {
                    smsVal.Text = currMsg.msg.Substring(0, defLenghtEmptyMsg - 1);
                }
            }));
            optionMenu.addParam(new Param("Info", null, "PRESS ↑↓ TO SCROLL / ENT TO CONT", 4, 10));

            optionMenu.getParam("SmsValue").IsActive = true;


            optionMenu.addActionToParam(optionMenu.getParam("SmsValue"), new Button("DOWN", (Button btn, RadioStation rs, Widget wdg) =>
            {
                station.TxMsgs.nextMsg();
            }));

            optionMenu.addActionToParam(optionMenu.getParam("SmsValue"), new Button("UP", (Button btn, RadioStation rs, Widget wdg) =>
            {
                station.TxMsgs.prevMsg();
            }));

            optionMenu.addActionToParam(optionMenu.getParam("Body"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                Param activeParam = wdg.activeParam();
                Action clrAction = () =>
                {
                    Form1.currObject.QueueWidget.add(optionMenu);
                    Form1.currObject.startShowWidgetQueue();
                };


                if (edit)
                {
                    Widget editMessageView = enterMsg("PGM-MODE-ALE-AMD-TX_MSG-", "ENT TO SAVE - CLR TO EXIT", 
                    clr: clrAction, 
                    ent: (string newMsg) => {
                        station.TxMsgs.currMsg().msg = newMsg;
                        clrAction.Invoke();
                    });

                    Form1.currObject.QueueWidget.add(editMessageView);
                    Form1.currObject.startShowWidgetQueue();
                }

                if (remove)
                {
                    Form1.currObject.QueueWidget.add(dialogMenu("PGM-MODE-ALE-AMD-TX_MSG-", "TX MESSAGE:", 
                        clr: clrAction, 
                        ifYes: () => {
                            station.TxMsgs.currMsg().msg = txMsg.emptyMsg;
                            clrAction.Invoke();
                        }, 
                        ifNo: () => {
                            clrAction.Invoke();
                        }));
                    Form1.currObject.startShowWidgetQueue();
                }
            }));

            optionMenu.addActionToParam(optionMenu.getParam("Body"), new Button("CLR", (Button btn, RadioStation rs, Widget wdg) =>
            {
                clr?.Invoke();
            }));

            return optionMenu;
        }

        public static Widget initOptionAleTxMsgSendingMenu(RadioStation station, Action clr = null)
        {
            Widget optionMenu = new Widget("initOptionAleTxMsgSendingMenu");

            optionMenu.LineSize[0] = 5;
            optionMenu.LineSize[1] = 8;
            optionMenu.LineSize[2] = 8;
            optionMenu.LineSize[3] = 5;
            optionMenu.LineCharOffset[1] = 6;
            optionMenu.LineCharOffset[2] = 4;
            optionMenu.addParam(new Param("Body", null, "", 1, 0));
            optionMenu.addParam(new Param("Title", null, "PGM-MODE-ALE-AMD-TX_MSG", 1, 0));
            optionMenu.addParam(new Param("SmsTitle", null, "CALL TYPE", 2, 7));
            optionMenu.addParam(new Param("SmsValue", null, "AUTOMATIC", 3, 12));
            optionMenu.addParam(new Param("Info", null, "PRESS ↑↓ TO SCROLL", 4, 15));

            optionMenu.getParam("SmsValue").IsActive = true;

            WidgetTextParams callTypeTP = new WidgetTextParams("CALL TYPE");
            callTypeTP.addParam("AUTOMATIC").addParam("MANUAL");
            WidgetTextParams addressTypeTP = new WidgetTextParams("ADDRESS TYPE");
            addressTypeTP.addParam("INDIVIDUAL").addParam("ALL").addParam("ANY").addParam("GROUP").addParam("NET");
            WidgetTextParams individualAddressTypeTP = new WidgetTextParams("INDIV ADDR");
            individualAddressTypeTP.addParam("R2");

            List<WidgetTextParams> radioParams = new List<WidgetTextParams>();
            radioParams.Add(callTypeTP);
            radioParams.Add(addressTypeTP);
            radioParams.Add(individualAddressTypeTP);


            optionMenu.addActionToParam(optionMenu.getParam("SmsValue"), new Button("DOWN", (Button btn, RadioStation rs, Widget wdg) =>
            {
                Param activeParam = wdg.activeParam();
                Param titleParam = wdg.getParam("SmsTitle");

                string paramTitle = titleParam.Text;

                activeParam.Text = radioParams.Find(p => p.Name == paramTitle).getPrevParam();
                activeParam.ActiveTo = activeParam.Text.Length;
                activeParam.Y = Helper.calcCenterIndent(activeParam.Text.Length, 28);
                titleParam.Y = Helper.calcCenterIndent(titleParam.Text.Length, 28);
            }));

            optionMenu.addActionToParam(optionMenu.getParam("SmsValue"), new Button("UP", (Button btn, RadioStation rs, Widget wdg) =>
            {
                Param activeParam = wdg.activeParam();
                Param titleParam = wdg.getParam("SmsTitle");

                string paramTitle = titleParam.Text;

                activeParam.Text = radioParams.Find(p => p.Name == paramTitle).getNextParam();
                activeParam.ActiveTo = activeParam.Text.Length;
                activeParam.Y = Helper.calcCenterIndent(activeParam.Text.Length, 28);
                titleParam.Y = Helper.calcCenterIndent(titleParam.Text.Length, 28);
            }));

            optionMenu.addActionToParam(optionMenu.getParam("Body"), new Button("ENT", (Button btn, RadioStation rs, Widget wdg) =>
            {
                Param activeParam = wdg.activeParam();
                Param titleP = wdg.getParam("SmsTitle");

                int nextIndex = radioParams.IndexOf(radioParams.Find(p => p.Name == titleP.Text)) + 1;
                if (nextIndex < radioParams.Count)
                {
                    titleP.Text = radioParams[nextIndex].Name;
                    activeParam.Text = radioParams[nextIndex].currParam();
                }
                else
                {
                    titleP.Text = radioParams[0].Name;
                    activeParam.Text = radioParams[0].currParam();
                }

                activeParam.ActiveTo = activeParam.Text.Length;
                activeParam.ActiveFrom = 0;

                activeParam.Y = Helper.calcCenterIndent(activeParam.Text.Length, 28);
                titleP.Y = Helper.calcCenterIndent(titleP.Text.Length, 28);
            }));

            optionMenu.addActionToParam(optionMenu.getParam("Body"), new Button("CLR", (Button btn, RadioStation rs, Widget wdg) =>
            {
                Param activeParam = wdg.activeParam();
                Param titleParam = wdg.getParam("SmsTitle");

                activeParam.Text = callTypeTP.currParam();
                titleParam.Text = callTypeTP.Name;
                activeParam.Y = Helper.calcCenterIndent(activeParam.Text.Length, 28);
                titleParam.Y = Helper.calcCenterIndent(titleParam.Text.Length, 28);

                clr?.Invoke();
            }));

            return optionMenu;
        }
    }

}
