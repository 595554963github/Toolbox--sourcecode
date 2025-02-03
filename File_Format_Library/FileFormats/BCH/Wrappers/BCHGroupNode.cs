using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toolbox.Library.NodeWrappers;

namespace FirstPlugin.CtrLibrary
{
    public enum BCHGroupType
    {
        Models,
        Textures,
        Lookups,
        Materials,
        Shaders,
        Cameras,
        Lights,
        Fogs,
        Scenes,
        SkeletalAnim,
        MaterialAnim,
        VisibiltyAnim,
        CameraAnim,
        LightAnim,
        EmitterAnim,
        Particles,
    }


    public class BCHGroupNode : STGenericWrapper
    {
        public Dictionary<string, STGenericWrapper> ResourceNodes = new Dictionary<string, STGenericWrapper>();

        public BCHGroupType Type;

        public BCHGroupNode() : base()
        {
            ImageKey = "folder";
        }

        public BCHGroupNode(string name) : base() { Text = name; }
        public BCHGroupNode(BCHGroupType type) : base() { Type = type; SetNameByType(); }

        public void SetNameByType()
        {
            Text = SetName();
        }

        private string SetName()
        {
            switch (Type)
            {
                case BCHGroupType.Models: return "模型";
                case BCHGroupType.Textures: return "纹理";
                case BCHGroupType.Lookups: return "查找表";
                case BCHGroupType.Materials: return "材质";
                case BCHGroupType.Shaders: return "着色器";
                case BCHGroupType.Cameras: return "相机";
                case BCHGroupType.Lights: return "灯光";
                case BCHGroupType.Fogs: return "雾效";
                case BCHGroupType.Scenes: return "场景";
                case BCHGroupType.SkeletalAnim: return "骨架动画";
                case BCHGroupType.MaterialAnim: return "材质动画";
                case BCHGroupType.VisibiltyAnim: return "可见性动画";
                case BCHGroupType.CameraAnim: return "相机动画";
                case BCHGroupType.LightAnim: return "灯光动画";
                case BCHGroupType.EmitterAnim: return "发射源动画";
                case BCHGroupType.Particles: return "粒子";
                default:
                    throw new System.Exception("未知类型? " + Type);
            }
        }

        public void AddNode(STGenericWrapper node)
        {
            if (node.Text == string.Empty)
                throw new System.Exception("文本无效.必须不能是空的!");

            Nodes.Add(node);
            ResourceNodes.Add(node.Text, node);
        }
    }
}
