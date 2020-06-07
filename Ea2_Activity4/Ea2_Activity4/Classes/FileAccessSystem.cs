using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ea2_Activity4.Classes
{
    class FileAccessSystem
    {
        //this is from my inventory project from C#1
        //calling it FAM, it accesses the save file wherever in the system.


        public String getLibrary(String filename)
        {
            //purpose, to find the Directory of just the project.
            //so essentially, it just goes to the project itself, so going to the SaveFile.txt in this project
            //it has to be typed as "\\SaveData\\SaveFile.txt"
            var parent = System.IO.Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
            return (parent + filename);
        }

        public HeroesAssemble HeroesAssemble()
        {
            //return it as a Json
            string[] read = getSaveFile().Split('\n');
            HeroesAssemble heroesAssemble = new HeroesAssemble();
            for (int i = 0; i < read.Length; i++)
            {
                if (read[i].Length > 0)
                {
                    heroesAssemble.Add(JsonConvert.DeserializeObject<Superhero>(read[i]));
                }
            }
            return heroesAssemble;
        }

        public string getSaveFile()
        {
            //return as a string
            return (File.ReadAllText(getLibrary("\\SaveData\\SaveFile.txt")));
        }

        public void saveJsonSaveFile(string SaveData)
        {
            //saves the Json
            //we assume we as the programmer has already created the json and we're just saving
            File.AppendAllText(getLibrary("\\SaveData\\SaveFile.txt"),SaveData+Environment.NewLine);
        }

        public Bitmap getImage(String city)
        {
            Bitmap r = new Bitmap(getLibrary("\\SaveData\\HeroCities\\" + city + ".png"));
            //Bitmap r = new Bitmap(getLibrary("\\SaveData\\HeroCities\\Chicago.jpg"));

            return r;
        }


    }
}
