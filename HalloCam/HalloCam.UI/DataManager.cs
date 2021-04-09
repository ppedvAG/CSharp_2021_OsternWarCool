using HalloCam.Model;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace HalloCam.UI
{
    class DataManager
    {
        public string FileName { get; private set; }

        public DataManager(string fileName)
        {
            FileName = fileName;
        }

        public void SaveKameras(IEnumerable<Kamera> kameras)
        {
            StreamWriter sw = new StreamWriter(FileName);
            XmlSerializer serial = new XmlSerializer(typeof(List<Kamera>));
            serial.Serialize(sw, kameras.ToList());
            sw.Close();
        }

        public IEnumerable<Kamera> LoadKameras()
        {
            StreamReader sr = new StreamReader(FileName);
            XmlSerializer serial = new XmlSerializer(typeof(List<Kamera>));
            var result = serial.Deserialize(sr);
            sr.Close();
            return (IEnumerable<Kamera>)result;
        }
    }
}
