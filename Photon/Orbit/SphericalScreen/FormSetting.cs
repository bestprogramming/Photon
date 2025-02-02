using Photon.OpenGl;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Serialization;

namespace Photon.SphericalScreen
{
    public class FormSetting : PatternSetting
    {
        public double ParticleRadius;
        public double PatternRatio;
        public double ScreenX;
        public double ScreenY;
        public double ScreenZ;
        public double ScreenRadius = 0.1;
        public double RenderMinX = -1.0;
        public double RenderMaxX = 1.0;
        public double RenderMinY = -1.0;
        public double RenderMaxY = 1.0;
        public double RenderMinZ = -1.0;
        public double RenderMaxZ = 1.0;
        public double RenderPointSize;
        public double RenderClusterSize;

        public string DrawTag = "";
        public BaseSetting[] ContentSettings = Array.Empty<BaseSetting>();

        private Sphere? screen;
        [IgnoreDataMember]
        public Sphere Screen
        {
            get
            {
                screen ??= new Sphere(ScreenX, ScreenY, ScreenZ, ScreenRadius);
                return screen.Value;
            }
        }

        public static FormSetting Get(FrmSphericalScreen frm)
        {
            var ret = new FormSetting
            {
                ParticleRadius = frm.NudParticleRadius.ToDouble(),
                PatternRatio = frm.NudPatternRatio.ToDouble(),
                ScreenX = frm.NudScreenX.ToDouble(),
                ScreenY = frm.NudScreenY.ToDouble(),
                ScreenZ = frm.NudScreenZ.ToDouble(),
                ScreenRadius = frm.NudScreenRadius.ToDouble(),
                RenderMinX = frm.NudRenderMinX.ToDouble(),
                RenderMaxX = frm.NudRenderMaxX.ToDouble(),
                RenderMinY = frm.NudRenderMinY.ToDouble(),
                RenderMaxY = frm.NudRenderMaxY.ToDouble(),
                RenderMinZ = frm.NudRenderMinZ.ToDouble(),
                RenderMaxZ = frm.NudRenderMaxZ.ToDouble(),
                RenderPointSize = frm.NudRenderPointSize.ToDouble(),
                RenderClusterSize = frm.NudRenderClusterSize.ToDouble(),

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

        public static void Set(FrmSphericalScreen frm, FormSetting fs)
        {
            frm.NudParticleRadius.FromDouble(fs.ParticleRadius);
            frm.NudPatternRatio.FromDouble(fs.PatternRatio);
            frm.NudScreenX.FromDouble(fs.ScreenX);
            frm.NudScreenY.FromDouble(fs.ScreenY);
            frm.NudScreenZ.FromDouble(fs.ScreenZ);
            frm.NudScreenRadius.FromDouble(fs.ScreenRadius);
            frm.NudRenderMinX.FromDouble(fs.RenderMinX);
            frm.NudRenderMaxX.FromDouble(fs.RenderMaxX);
            frm.NudRenderMinY.FromDouble(fs.RenderMinY);
            frm.NudRenderMaxY.FromDouble(fs.RenderMaxY);
            frm.NudRenderMinZ.FromDouble(fs.RenderMinZ);
            frm.NudRenderMaxZ.FromDouble(fs.RenderMaxZ);
            frm.NudRenderPointSize.FromDouble(fs.RenderPointSize);
            frm.NudRenderClusterSize.FromDouble(fs.RenderClusterSize);

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
