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


namespace ValheimServerSettings
{
    // COPYRIGHT 2021 KEVIN "nx#8830" J. // http://n-x.xyz
    // SOURCECODE DERIVATE OF VALHEIM PLUS
    // https://github.com/nxPublic/ValheimPlus

    [BepInPlugin("org.bepinex.plugins.valheim_plus", "Valheim Server Settings", "0.1")]
    class ValheimServerSettingsPlugin : BaseUnityPlugin
    {
        
        public static string version = "0.7";
        public static string newestVersion = "";
        public static Boolean isUpToDate = false;

        string ConfigPath = Path.GetDirectoryName(Paths.BepInExConfigPath) + "\\valheim_server_settings.cfg";

        // DO NOT REMOVE MY CREDITS
        public static string Author = "Kevin 'nx' J.";
        public static string Website = "http://n-x.xyz";
        public static string Discord = "nx#8830";
        public static string Repository = "https://github.com/nxPublic/ValheimServerSettings";

        // Add your credits here in case you modify the code or make additions, feel free to add as many as you like
        String ModifiedBy = "YourName";

        public static Boolean isDebug = false;

        // Awake is called once when both the game and the plug-in are loaded
        void Awake()
        {



            Logger.LogInfo("Trying to load the configuration file");
            if (File.Exists(ConfigPath))
            {
                Logger.LogInfo("Configuration file found, loading configuration.");
                if (ValheimServerSettings.Settings.LoadSettings() != true)
                {
                    Logger.LogError("Error while loading configuration file.");
                }
                else
                {

                    Logger.LogInfo("Configuration file loaded succesfully.");

                    var harmony = new Harmony("mod.valheim_server_settings");
                    harmony.PatchAll();
                }
            }
            else
            {
                Logger.LogError("Error: File not found. Plugin not loaded.");
            }
        }


        
    }
}
