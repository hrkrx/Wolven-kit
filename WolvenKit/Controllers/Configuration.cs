﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using WolvenKit.Common.DDS;

namespace WolvenKit
{
    using Common.Model;

    public class Configuration
    {
        public static string ConfigurationPath
        {
            get
            {
                var path = AppDomain.CurrentDomain.BaseDirectory;
                var filename = Path.GetFileNameWithoutExtension(path);
                var dir = Path.GetDirectoryName(path);
                return Path.Combine(dir ?? "", filename + "_config.xml");
            }
        }

        


        /// <summary>
        ///     Configuration values
        /// </summary>
        public string W3ExePath { get; set; }
        public string CP77ExePath { get; set; }

        public string TextLanguage { get; set; }
        public string VoiceLanguage { get; set; }
        public string WccLite { get; set; }
        public string DepotPath { get; set; }

        public string InitialModDirectory { get; set; }
        public string InitialFileDirectory { get; set; }
        public string InitialExportDirectory { get; set; }

        public EUncookExtension UncookExtension { get; set; }
        public bool IsWelcomeFormDisabled { get; set; }
        public bool IsAutoInstallModsDisabled { get; set; }

        public string[] ManagerVersions { get; set; } = new string[(int)EManagerType.Max];


        public string GameModDir { get; set; }
        public string GameDlcDir { get; set; }

        public EUpdateChannel UpdateChannel { get; set; }


        [XmlIgnore]
        public string W3GameContentDir => Path.Combine(W3GameRootDir, "content");
        [XmlIgnore]
        public string W3GameRootDir => Path.Combine(W3ExePath, @"..\..\..\");

        [XmlIgnore]
        public string CP77GameContentDir => Path.Combine(CP77GameRootDir, "content");
        [XmlIgnore]
        public string CP77GameRootDir => Path.Combine(CP77ExePath, @"..\..\..\");


        ~Configuration()
        {
            Save();
        }

        public void Save()
        {
            var ser = new XmlSerializer(typeof (Configuration));
            var stream = new FileStream(ConfigurationPath, FileMode.Create, FileAccess.Write);
            ser.Serialize(stream, this);
            stream.Close();
        }

        public static Configuration Load()
        {
            try
            {
                if (File.Exists(ConfigurationPath) && new FileInfo(ConfigurationPath).Length != 0)
                {
                    var ser = new XmlSerializer(typeof(Configuration));
                    var stream = new FileStream(ConfigurationPath, FileMode.Open, FileAccess.Read);
                    var config = (Configuration)ser.Deserialize(stream);
                    stream.Close();
                    return config;
                }
            }
            catch (Exception)
            {

            }
            

            // Defaults
            return new Configuration
            {
                TextLanguage = "en",
                VoiceLanguage = "en",
            };
        }
    }
}