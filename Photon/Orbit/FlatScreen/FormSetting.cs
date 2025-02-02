using Photon.OpenGl;
using System;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Serialization;

namespace Photon.FlatScreen
{
    public class FormSetting : PatternSetting
    {
        public double ParticleRadius;
        public double PatternRatio;
        public double ScreenX;
        public double ScreenY;
        public double ScreenZ;
        public double ScreenWidth;
        public double ScreenHeight;
        public ScreenPlane ScreenPlane;
        public double ScreenDistance;
        public double RenderPointSize;
        public double RenderClusterSize;

        public string DrawTag = "";
        public BaseSetting[] ContentSettings = Array.Empty<BaseSetting>();

        private Rectangle? screen;
        [IgnoreDataMember]
        public Rectangle Screen
        {
            get
            {
                screen ??= ScreenPlane == ScreenPlane.Xy ? new Rectangle(ScreenX, ScreenY, ScreenWidth, ScreenHeight) :
                    ScreenPlane == ScreenPlane.Xz ? new Rectangle(ScreenX, ScreenZ, ScreenWidth, ScreenHeight) :
                    new Rectangle(ScreenY, ScreenZ, ScreenWidth, ScreenHeight);
                return screen.Value;
            }
        }
        public static FormSetting Get(FrmFlatScreen frm)
        {
            var ret = new FormSetting
            {
                ParticleRadius = frm.NudParticleRadius.ToDouble(),
                PatternRatio = frm.NudPatternRatio.ToDouble(),
                ScreenX = frm.NudScreenX.ToDouble(),
                ScreenY = frm.NudScreenY.ToDouble(),
                ScreenZ = frm.NudScreenZ.ToDouble(),
                ScreenWidth = frm.NudScreenWidth.ToDouble(),
                ScreenHeight = frm.NudScreenHeight.ToDouble(),
                ScreenPlane = (ScreenPlane)Enum.Parse(typeof(ScreenPlane), (string)frm.FlpScreenPlane.Tag),
                ScreenDistance = frm.NudScreenDistance.ToDouble(),
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

        public static void Set(FrmFlatScreen frm, FormSetting fs)
        {
            frm.NudParticleRadius.FromDouble(fs.ParticleRadius);
            frm.NudPatternRatio.FromDouble(fs.PatternRatio);
            frm.NudScreenX.FromDouble(fs.ScreenX);
            frm.NudScreenY.FromDouble(fs.ScreenY);
            frm.NudScreenZ.FromDouble(fs.ScreenZ);
            frm.NudScreenWidth.FromDouble(fs.ScreenWidth);
            frm.NudScreenHeight.FromDouble(fs.ScreenHeight);

            frm.FlpScreenPlane.Tag = fs.ScreenPlane.ToString();
            foreach (RadioButton rdb in frm.FlpScreenPlane.Controls)
            {
                if ((string)frm.FlpScreenPlane.Tag == (string)rdb.Tag)
                {
                    rdb.Checked = false;
                    rdb.Checked = true;
                    break;
                }
            }

            frm.NudScreenDistance.FromDouble(fs.ScreenDistance);
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
