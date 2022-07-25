using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElzeroModLoader {
    public class ModFile {
        public int? type;
        public string? fileName;
        public string? modFilePath;

        public ModFile(int _type, string _name, string _path) {
            type = _type;
            fileName = _name;
            modFilePath = _path;
        }
    }
    public class ModPack {
        public string? modName;
        public string[]? modFolders;
        public string[]? detachedFiles;
        public string? lastMod;
        public ModFile[]? files;

        public ModPack(string _name, string[] _folders, string[] _files) {
            modName = _name;
            modFolders = _folders;
            detachedFiles = _files;
            lastMod = DateTime.Now.ToString();
        }

    }


}
