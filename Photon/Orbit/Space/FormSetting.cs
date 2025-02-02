using Photon.OpenGl;
using System.Xml;
using System.Xml.Serialization;

namespace Photon.Space
{
    public class FormSetting : PatternSetting
    {
        public double ParticleRadius;
        public double PatternRatio;
        public int OrbitsFrom;
        public int OrbitsTo;
        public double RenderPointSize;
        public double RenderClusterSize;
        public double RenderMinX = -1.0;
        public double RenderMaxX = 1.0;
        public double RenderMinY = -1.0;
        public double RenderMaxY = 1.0;
        public double RenderMinZ = -1.0;
        public double RenderMaxZ = 1.0;

        public string DrawTag = "";
        public BaseSetting[] ContentSettings = Array.Empty<BaseSetting>();

        public static FormSetting Get(FrmSpace frm)
        {
            var ret = new FormSetting
            {
                ParticleRadius = frm.NudParticleRadius.ToDouble(),
                PatternRatio = frm.NudPatternRatio.ToDouble(),
                OrbitsFrom = frm.NudOrbitsFrom.ToInt(),
                OrbitsTo = frm.NudOrbitsTo.ToInt(),
                RenderPointSize = frm.NudRenderPointSize.ToDouble(),
                RenderClusterSize = frm.NudRenderClusterSize.ToDouble(),
                RenderMinX = frm.NudRenderMinX.ToDouble(),
                RenderMaxX = frm.NudRenderMaxX.ToDouble(),
                RenderMinY = frm.NudRenderMinY.ToDouble(),
                RenderMaxY = frm.NudRenderMaxY.ToDouble(),
                RenderMinZ = frm.NudRenderMinZ.ToDouble(),
                RenderMaxZ = frm.NudRenderMaxZ.ToDouble(),

                DrawTag = (string)frm.SmiDrawMenu.Tag,
            };

            var contentSettings = new List<BaseSetting>();
            foreach (IUctShape uct in frm.FlpContent.Controls)
            {
                contentSettings.Add(uct.GetSetting());
            }
            ret.ContentSettings = contentSettings.ToArray();

            var baseSettings = new List<BaseSetting>();
            foreach (IUctShape uct in frm.Lsb.Items)
            {
                baseSettings.Add(uct.GetSetting());
            }
            ret.BaseSettings = baseSettings.ToArray();

            return ret;
        }

        public static void Set(FrmSpace frm, FormSetting fs)
        {
            frm.NudParticleRadius.FromDouble(fs.ParticleRadius);
            frm.NudPatternRatio.FromDouble(fs.PatternRatio);
            frm.NudOrbitsFrom.FromInt(fs.OrbitsFrom);
            frm.NudOrbitsTo.FromInt(fs.OrbitsTo);
            frm.NudRenderPointSize.FromDouble(fs.RenderPointSize);
            frm.NudRenderClusterSize.FromDouble(fs.RenderClusterSize);
            frm.NudRenderMinX.FromDouble(fs.RenderMinX);
            frm.NudRenderMaxX.FromDouble(fs.RenderMaxX);
            frm.NudRenderMinY.FromDouble(fs.RenderMinY);
            frm.NudRenderMaxY.FromDouble(fs.RenderMaxY);
            frm.NudRenderMinZ.FromDouble(fs.RenderMinZ);
            frm.NudRenderMaxZ.FromDouble(fs.RenderMaxZ);

            frm.FlpContent.Controls.Clear();
            frm.FlpContent.SuspendLayout();
            foreach (var contentSetting in fs.ContentSettings)
            {
                var typeName = contentSetting?.ToString()?.Replace("Setting", "")?.Replace("OpenGl.", "OpenGl.Uct");
                if (typeName != null)
                {
                    var type = Type.GetType(typeName);
                    if (type != null && contentSetting != null)
                    {
                        var uct = (UserControl?)Activator.CreateInstance(type);
                        if (uct != null)
                        {
                            contentSetting.Set((IUctShape)uct);
                            frm.FlpContent.Controls.Add(uct);
                        }
                    }
                }
            }
            frm.FlpContent.ResumeLayout();

            frm.SmiDrawMenu.Tag = fs.DrawTag;
            foreach (ToolStripMenuItem smi in frm.SmiDrawMenu.DropDownItems)
            {
                smi.Checked = (string)frm.SmiDrawMenu.Tag == (string)smi.Tag;
            }

            frm.Lsb.Items.Clear();
            foreach (var baseSetting in fs.BaseSettings)
            {
                var typeName = baseSetting?.ToString()?.Replace("Setting", "")?.Replace("OpenGl.", "OpenGl.Uct");
                if (typeName != null)
                {
                    var type = Type.GetType(typeName);
                    if (type != null && baseSetting != null)
                    {
                        var uct = (UserControl?)Activator.CreateInstance(type);
                        if (uct != null)
                        {
                            baseSetting.Set((IUctShape)uct);
                            frm.Lsb.Items.Add(uct);
                        }
                    }
                }
            }

            frm.RefreshButtons();
        }

        public static void Write(FormSetting fs, string path)
        {
            var serializer = new XmlSerializer(fs.GetType());
            var directory = Path.GetDirectoryName(path);
            if (!string.IsNullOrWhiteSpace(directory))
            {
                Directory.CreateDirectory(directory);
            }
            using var writer = XmlWriter.Create(path);
            serializer.Serialize(writer, fs);
        }

        public static new FormSetting Read(string path)
        {
            var serializer = new XmlSerializer(typeof(FormSetting));
            using var reader = XmlReader.Create(path);
            var fs = (FormSetting?)serializer.Deserialize(reader);
            return fs ?? new FormSetting();
        }
    }
}
