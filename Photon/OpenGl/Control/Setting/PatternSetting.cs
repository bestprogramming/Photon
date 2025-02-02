using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;

namespace Photon.OpenGl
{
    public class PatternSetting
    {
        public BaseSetting[] BaseSettings = Array.Empty<BaseSetting>();


        public static void Write(PatternSetting ps, string path)
        {
            var serializer = new XmlSerializer(ps.GetType());
            var directory = Path.GetDirectoryName(path);
            if (!string.IsNullOrWhiteSpace(directory))
            {
                Directory.CreateDirectory(directory);
            }
            using var writer = XmlWriter.Create(path);
            serializer.Serialize(writer, ps);
        }

        public static PatternSetting Read(string path)
        {
            var serializer = new XmlSerializer(typeof(PatternSetting));
            using var reader = XmlReader.Create(path);
            var ps = (PatternSetting?)serializer.Deserialize(reader);
            return ps ?? new PatternSetting();
        }
    }
}
