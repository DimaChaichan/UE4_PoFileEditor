//using MetroFramework;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace SettingsController
{
    public class SettingsControl
    {
        SettingsFileControl settingsFileControl;
        FileInfo SettingFile;
        public SettingsValues Settingsvalues;

        public SettingsControl(string FilePath)
        {
            
            settingsFileControl = new SettingsFileControl(FilePath);
            Settingsvalues = new SettingsValues();

            FileInfo SettingFile = new FileInfo(FilePath);
            if (!SettingFile.Exists)
            {
                var SettingFileVar = File.Create(SettingFile.FullName);
                SettingFileVar.Close();
                WriteAllValues();
            }

            LoadSettings();
        }

        private void LoadSettings()
        {
            try
            {
                foreach (SettingsValue Setvalue in Settingsvalues)
                {
                    string GetValue = settingsFileControl.IniReadValue(Setvalue.Group, Setvalue.Name);
                    string[] TypeClass = Setvalue.Settingsvalue.GetType().ToString().Split('`');

                    // Debug
                    //Console.WriteLine(TypeClass[0]);

                    switch (TypeClass[0])
                    {
                        //case "MetroFramework.MetroThemeStyle":
                        //     MetroThemeStyle NewTheme = (MetroThemeStyle)Setvalue.Settingsvalue;
                        //    if (GetValue == "")
                        //    {
                        //        int CodeThema = (int)NewTheme;
                        //        settingsFileControl.IniWriteValue(Setvalue.Group, Setvalue.Name, CodeThema.ToString());
                        //        GetValue = CodeThema.ToString();
                        //    }

                        //    Setvalue.Settingsvalue = (MetroThemeStyle)Convert.ToInt32(GetValue);
                        //    break;
                        //case "MetroFramework.MetroColorStyle":
                        //    MetroColorStyle NewStyle = (MetroColorStyle)Setvalue.Settingsvalue;
                        //    if (GetValue == "")
                        //    {
                        //        int CodeStyle = (int)NewStyle;
                        //        settingsFileControl.IniWriteValue(Setvalue.Group, Setvalue.Name, CodeStyle.ToString());
                        //        GetValue = CodeStyle.ToString();
                        //    }

                        //    Setvalue.Settingsvalue = (MetroColorStyle)Convert.ToInt32(GetValue);
                        //    break;
                        case "System.String":
                            Setvalue.Settingsvalue = GetValue;
                            break;
                        case "System.Int32":

                            if (GetValue == "")
                            {
                                int defaultint = (int)Setvalue.Settingsvalue;
                                settingsFileControl.IniWriteValue(Setvalue.Group, Setvalue.Name, defaultint.ToString());
                                GetValue = "0";
                            }

                            Setvalue.Settingsvalue = Convert.ToInt32(GetValue);
                            break;
                        case "System.Boolean":
                            if (GetValue == "")
                            {
                                bool defaultBool = (bool)Setvalue.Settingsvalue;
                                settingsFileControl.IniWriteValue(Setvalue.Group, Setvalue.Name, defaultBool.ToString());
                                GetValue = "True";
                            }

                            if (GetValue == "True")
                                Setvalue.Settingsvalue = true;
                            else
                                Setvalue.Settingsvalue = false;
                            break;
                        case "System.Collections.Generic.List":

                            Regex rx = new Regex(@"\[(.*?)\]");
                            var v = rx.Match(TypeClass[1]);
                            string s = v.Groups[1].ToString();

                            // Debug
                            //Console.WriteLine(s);

                            switch (s)
                            {
                                case "SettingsController.cl_ListKeyInt":
                                    List<cl_ListKeyInt> KeysIntStr = (List<cl_ListKeyInt>)Setvalue.Settingsvalue;
                                    List<string> KeysIntStrGroup = new List<string>();
                                    KeysIntStrGroup = settingsFileControl.GetKeys(Setvalue.Group);
                                    foreach (string item in KeysIntStrGroup)
                                    {
                                        string Int_ListKeyBool = settingsFileControl.IniReadValue(Setvalue.Group, item);
                                        KeysIntStr.Add(new cl_ListKeyInt(item, Int32.Parse(Int_ListKeyBool)));
                                    }
                                    Setvalue.Settingsvalue = KeysIntStr;
                                    break;
                                case "SettingsController.cl_ListKeyBool":
                                    List<cl_ListKeyBool> KeysStr = (List<cl_ListKeyBool>)Setvalue.Settingsvalue;
                                    List<string> KeysStrGroup = new List<string>();
                                    KeysStrGroup = settingsFileControl.GetKeys(Setvalue.Group);
                                    foreach (cl_ListKeyBool item in KeysStr)
                                    {
                                        foreach (string Key_ListKeyBool in KeysStrGroup)
                                        {
                                            if(item.Key == Key_ListKeyBool)
                                            {
                                                string Bool_ListKeyBool = settingsFileControl.IniReadValue(Setvalue.Group, Key_ListKeyBool);
                                                if (Bool_ListKeyBool == "True")
                                                    item.Bool = true;
                                                else
                                                    item.Bool = false;
                                            }
                                        }
                                    }
                                    Setvalue.Settingsvalue = KeysStr;
                                    break;
                                case "System.String":
                                    List<string> IDValueStr = (List<string>)Setvalue.Settingsvalue;
                                    Setvalue.Settingsvalue = IDValueStr;
                                    break;
                                case "System.Int32":
                                    List<int> IDList = (List<int>)Setvalue.Settingsvalue;
                                    List<int> NewIDList = new List<int>();
                                    List<string> ItemsIniGroup = new List<string>();
                                    ItemsIniGroup = settingsFileControl.GetKeys(Setvalue.Group);

                                    int Count = 0;
                                     foreach (int id in IDList)
                                     {
                                         
                                         bool tmp = true; 
                                         foreach (string item in ItemsIniGroup)
                                         {
                                             string idcheck = settingsFileControl.IniReadValue(Setvalue.Group, item);
                                             if (id.ToString() == idcheck)
                                             {
                                                 tmp = false;
                                             }
                                         }

                                         if (tmp)
                                         {
                                             settingsFileControl.IniWriteValue(Setvalue.Group, Count.ToString(), id.ToString());
                                             Count++;
                                         }
                                     }

                                    ItemsIniGroup = new List<string>();
                                    ItemsIniGroup = settingsFileControl.GetKeys(Setvalue.Group);
                                    foreach (string item in ItemsIniGroup)
                                    {
                                        string idcheck = settingsFileControl.IniReadValue(Setvalue.Group, item);
                                        NewIDList.Add(Convert.ToInt32(idcheck));
                                    }

                                    Setvalue.Settingsvalue = NewIDList;
                                    break;
                                case "SettingsController.StatusColor":
                                    List<StatusColor> NewList = (List<StatusColor>)Setvalue.Settingsvalue;
                                    List<string> ItemsGroup = new List<string>();
                                    ItemsGroup = settingsFileControl.GetKeys(Setvalue.Group);

                                     foreach (StatusColor color in NewList)
                                     {
                                         bool tmp = true; 
                                         foreach (string item in ItemsGroup)
                                         {
                                             if (color.status == item)
                                             {
                                                 string[] colorARGB = settingsFileControl.IniReadValue(Setvalue.Group, item).Split(',');
                                                 color.color = Color.FromArgb(255, Convert.ToInt32(colorARGB[0]), Convert.ToInt32(colorARGB[1]), Convert.ToInt32(colorARGB[2]));
                                                 tmp = false;
                                             }
                                         }

                                         if(tmp)
                                             settingsFileControl.IniWriteValue(Setvalue.Group, color.status, color.color.R + "," + color.color.G + "," + color.color.B);
                                     } 

                                     Setvalue.Settingsvalue = NewList;
                                    break;
                                case "SettingsController.ListIntValue":
                                    List<ListIntValue> NewListIntValue = (List<ListIntValue>)Setvalue.Settingsvalue;
                                    List<string> ItemsListIntValueGroup = new List<string>();
                                    ItemsGroup = settingsFileControl.GetKeys(Setvalue.Group);

                                    foreach (ListIntValue intvalue in NewListIntValue)
                                     {
                                         bool tmp = true; 
                                         foreach (string item in ItemsGroup)
                                         {
                                             if (intvalue.intName == item)
                                             {
                                                 string NewIntValue = settingsFileControl.IniReadValue(Setvalue.Group, item);
                                                 intvalue.intValue = Convert.ToInt32(NewIntValue);
                                                 tmp = false;
                                             }
                                         }

                                         if(tmp)
                                             settingsFileControl.IniWriteValue(Setvalue.Group, intvalue.intName, intvalue.intValue.ToString());
                                     }

                                    Setvalue.Settingsvalue = NewListIntValue;

                                    break;
                                default:
                                    break;
                            }


                            break;
                        case "System.IO.FileInfo":
                            FileInfo NewFileInfo = (FileInfo)Setvalue.Settingsvalue;

                            if (GetValue == "")
                            {
                                settingsFileControl.IniWriteValue(Setvalue.Group, Setvalue.Name, NewFileInfo.FullName);
                                GetValue = NewFileInfo.FullName;
                            }

                            NewFileInfo = new FileInfo(GetValue);
                            Setvalue.Settingsvalue = NewFileInfo;

                            break;
                        case "System.IO.DirectoryInfo":
                            DirectoryInfo NewDirectoryInfo = (DirectoryInfo)Setvalue.Settingsvalue;

                            if (GetValue == "")
                            {
                                settingsFileControl.IniWriteValue(Setvalue.Group, Setvalue.Name, NewDirectoryInfo.FullName);
                                GetValue = NewDirectoryInfo.FullName;
                            }

                            NewDirectoryInfo = new DirectoryInfo(GetValue);
                            Setvalue.Settingsvalue = NewDirectoryInfo;

                            break;
                        case "System.Net.IPEndPoint":
                            IPEndPoint NewEndpoint = (IPEndPoint)Setvalue.Settingsvalue;
                            if (GetValue == "")
                            {
                                string DefaultAdresse = NewEndpoint.Address.ToString() + ":" + NewEndpoint.Port.ToString();
                                settingsFileControl.IniWriteValue(Setvalue.Group, Setvalue.Name, DefaultAdresse);
                                GetValue = DefaultAdresse;
                            }

                            string[] SplitAdresse = GetValue.Split(':');
                            NewEndpoint = new IPEndPoint(IPAddress.Parse(SplitAdresse[0]), Convert.ToInt32(SplitAdresse[1]));

                            Setvalue.Settingsvalue = NewEndpoint;
                            break;
                        default:
                            break;
                    }
                }
            }
            catch(Exception e)
            {}
        }

        public object GetValue(string ValueName)
        {
            object value = Settingsvalues.Find(x => x.Name == ValueName);
            if (value != null)
                return Settingsvalues.Find(x => x.Name == ValueName).Settingsvalue;
            else
                return false;
        }   

        public void SetValue(string ValueName, object NewValue)
        {
            int Index = Settingsvalues.FindIndex(x => x.Name == ValueName);
            Settingsvalues[Index].Settingsvalue = NewValue;
        }
        public void WriteAllValues()
        {
            foreach (SettingsValue Setvalue in Settingsvalues)
            {
                string[] TypeClass = Setvalue.Settingsvalue.GetType().ToString().Split('`');

                switch (TypeClass[0])
                {
                    //case "MetroFramework.MetroThemeStyle":
                    //    MetroThemeStyle NewTheme = (MetroThemeStyle)Setvalue.Settingsvalue;
                    //    int CodeTeme = (int)NewTheme;
                    //    settingsFileControl.IniWriteValue(Setvalue.Group, Setvalue.Name, CodeTeme.ToString());
                    //    break;
                    //case "MetroFramework.MetroColorStyle":
                    //    MetroColorStyle NewStyle = (MetroColorStyle)Setvalue.Settingsvalue;
                    //    int CodeStyle = (int)NewStyle;
                    //    settingsFileControl.IniWriteValue(Setvalue.Group, Setvalue.Name, CodeStyle.ToString());
                    //    break;
                    case "System.Int32":
                        int NewInt = (int)Setvalue.Settingsvalue;
                        settingsFileControl.IniWriteValue(Setvalue.Group, Setvalue.Name, NewInt.ToString());
                        break;
                    case "System.Boolean":
                        bool NewBool = (bool)Setvalue.Settingsvalue;
                        settingsFileControl.IniWriteValue(Setvalue.Group, Setvalue.Name, NewBool.ToString());
                        break;
                    case "System.Collections.Generic.List":
                         Regex rx = new Regex(@"\[(.*?)\]");
                         var v = rx.Match(TypeClass[1]);
                         string s = v.Groups[1].ToString();
                         Console.Write(s + Environment.NewLine);
                         switch(s)
                         {
                            case "SettingsController.cl_ListKeyInt":
                                List<cl_ListKeyInt> KeysIntStr = (List<cl_ListKeyInt>)Setvalue.Settingsvalue;
                                for (int i = 0; i < KeysIntStr.Count; i++)
                                {
                                    settingsFileControl.IniWriteValue(Setvalue.Group, KeysIntStr[i].Key, KeysIntStr[i].value.ToString());
                                }
                                break;
                            case "SettingsController.cl_ListKeyBool":
                                List<cl_ListKeyBool> KeysStr = (List<cl_ListKeyBool>)Setvalue.Settingsvalue;
                                for (int i = 0; i < KeysStr.Count; i++)
                                {
                                    settingsFileControl.IniWriteValue(Setvalue.Group, KeysStr[i].Key, KeysStr[i].Bool.ToString());
                                }
                                break;
                            case "System.String":
                                List<string> NewListStr = (List<string>)Setvalue.Settingsvalue;
                                for (int i = 0; i < NewListStr.Count; i++)
                                {
                                    settingsFileControl.IniWriteValue(Setvalue.Group, NewListStr[i], i.ToString());
                                }
                                break;
                            case "System.Int32":
                                 List<int> NewListInt = (List<int>)Setvalue.Settingsvalue;
                                 int Count = 0;
                                 foreach (int ID in NewListInt)
                                 {
                                     settingsFileControl.IniWriteValue(Setvalue.Group, Count.ToString(), ID.ToString());
                                     Count++;
                                 }
                                 break;
                             case "SettingsController.StatusColor":
                                 List<StatusColor> NewList = (List<StatusColor>)Setvalue.Settingsvalue;
                                 foreach (StatusColor color in NewList)
                                 {
                                     settingsFileControl.IniWriteValue(Setvalue.Group, color.status, color.color.R + "," + color.color.G + "," + color.color.B);
                                 }
                                 break;
                             case "SettingsController.ListIntValue":
                                 List<ListIntValue> NewListIntValue = (List<ListIntValue>)Setvalue.Settingsvalue;
                                 foreach (ListIntValue intvalue in NewListIntValue)
                                 {
                                     settingsFileControl.IniWriteValue(Setvalue.Group, intvalue.intName, intvalue.intValue.ToString());
                                 }
                                 break;
                             default:
                                 break;
                         }

                        break;
                    case "System.IO.FileInfo":
                        FileInfo NewFileInfo = (FileInfo)Setvalue.Settingsvalue;
                        settingsFileControl.IniWriteValue(Setvalue.Group, Setvalue.Name, NewFileInfo.FullName);
                        break;
                    case "System.IO.DirectoryInfo":
                        DirectoryInfo NewDirectoryInfo = (DirectoryInfo)Setvalue.Settingsvalue;
                        settingsFileControl.IniWriteValue(Setvalue.Group, Setvalue.Name, NewDirectoryInfo.FullName);
                        break;
                    case "System.Net.IPEndPoint":
                        IPEndPoint NewEndpoint = (IPEndPoint)Setvalue.Settingsvalue;
                         string DefaultAdresse = NewEndpoint.Address.ToString() + ":" + NewEndpoint.Port.ToString();
                         settingsFileControl.IniWriteValue(Setvalue.Group, Setvalue.Name, DefaultAdresse);
                        break;
                    case "System.String":
                        settingsFileControl.IniWriteValue(Setvalue.Group, Setvalue.Name, (string)Setvalue.Settingsvalue);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
