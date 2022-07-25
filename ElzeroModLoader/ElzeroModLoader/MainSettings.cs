using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ElzeroModLoader
{
    public class MainSettings
    {
        public string? LastChangedDate;
        public string? GameLocation;
        public string? ModFolderLocation;
        public string? CustomModsRepository;

        [JsonIgnore]
        public string? JsonFileName;
        public string? ModsRepository;

        public MainSettings()
        {
            JsonFileName = Path.GetDirectoryName(Application.ExecutablePath) + "\\ProgramSettings.json";
            ModsRepository = Path.GetDirectoryName(Application.ExecutablePath) + "\\Mods";

            if (!Directory.Exists(ModsRepository))
            {
                Directory.CreateDirectory(ModsRepository);
            }

            LastChangedDate = DateTime.UtcNow.ToString();
        }
    }
}
