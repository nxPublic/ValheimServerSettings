using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BepInEx;
using Unity;
using UnityEngine;
using System.IO;
using System.Reflection;
using System.Runtime;
using IniParser;
using IniParser.Model;
using HarmonyLib;
using System.Globalization;
using Steamworks;
using System.Net;

// Todo, better error handling

namespace ValheimServerSettings
{
    class Settings
    {

        public static IniData Config { get; set; }
        public static IniData Defaults { get; set; }

        static string ConfigPath = Path.GetDirectoryName(Paths.BepInExConfigPath) + "\\valheim_plus.cfg";
        static string ConfigDefaultsPath = Path.GetDirectoryName(Paths.BepInExConfigPath) + "\\valheim_plus_defaults.cfg";

        public static bool LoadSettings()
        {
            try
            {
                IniData userConfig;
                var parser = new FileIniDataParser();

                userConfig = parser.ReadFile(ConfigPath);
                Defaults = parser.ReadFile(ConfigDefaultsPath);

                Defaults.Merge(userConfig);

                Config = Defaults;
            }
            catch (Exception ex)
            {
                Debug.Log(ex.Message);
                return false;
            }
            return true;
        }

        public static bool isEnabled(string section)
        {
            return Boolean.Parse(Config[section]["enabled"]);
        }
        public static bool getBool(string section, string name)
        {
            return (Config[section][name].ToLower() == "true");
        }
        public static string getString(string section, string name)
        {
            return Config[section][name];
        }
        public static int getInt(string section, string name)
        {
            return int.Parse(Config[section][name]);
        }
        public static float getFloat(string section, string name)
        {
            
            return float.Parse(Config[section][name], CultureInfo.InvariantCulture.NumberFormat);
        }
        public static KeyCode getHotkey(string name)
        {
            KeyCode HotKey = KeyCode.None;
            try
            {
                HotKey = (KeyCode)System.Enum.Parse(typeof(KeyCode), Config["Hotkeys"][name]);
            }
            catch(Exception e){
                HotKey = KeyCode.None;
            }
            
            return HotKey;
        }

    }
}
