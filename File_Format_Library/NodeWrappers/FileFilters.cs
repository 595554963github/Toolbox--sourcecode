using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toolbox.Library.Animations;
using Bfres.Structs;

namespace FirstPlugin
{
    public class FileFilters
    {
        public static string BNTX_TEX = GetFilter(".bftex", ".dds",".astc", ".png", ".bmp", ".tga", ".jpg", ".tiff", ".tif", ".gif");
        public static string FTEX = GetFilter(".bftex", ".dds", ".dds2", ".png", ".bmp", ".tga", ".jpg", ".tiff", ".tif", ".gif");
        public static string GTX = GetFilter(".dds", ".dds2", ".png", ".bmp", ".tga", ".jpg", ".tiff", ".tif", ".gif");

        public static string FMDL = GetFilter(".dae", ".bfmdl", ".fbx", ".obj", ".csv");
        public static string FMDL_EXPORT = GetFilter(".dae", ".bfmdl");
        public static string FSKL = GetFilter(".bfskl");
        public static string FSHP = GetFilter(".bfobj", ".dae");
        public static string BONE = GetFilter(".bfbon");
        public static string FMAT = GetFilter(".bfmat");

        public static string FSKA_EXPORT = GetFilter(".bfska", ".anim", ".seanim", ".smd", ".chr0");
        public static string FSKA_REPLACE = GetFilter(".bfska",".anim", ".seanim", ".smd", ".chr0");

        public static string FMAA = GetFilter(".bfmaa",".yaml", ".gif");

        public static string FSHU_REPLACE_PARAM = GetFilter(".bfmaa", ".bfshu", ".yaml");
        public static string FSHU_REPLACE_SRT = GetFilter(".bfmaa", ".bftsh", ".yaml");
        public static string FSHU_REPLACE_COLOR = GetFilter(".bfmaa", ".bfcsh", ".yaml", ".clr0");
        public static string FSHU_EXPORT_PARAM = GetFilter(".bfmaa", ".bfshu", ".yaml");
        public static string FSHU_EXPORT_SRT = GetFilter(".bfmaa", ".bftsh", ".yaml");
        public static string FSHU_EXPORT_COLOR = GetFilter(".bfmaa", ".bfcsh", ".yaml");

        public static string FCLH = GetFilter(".bfcsh");
        public static string FSTH = GetFilter(".bfsth");
        public static string FTXP = GetFilter(".bftxp", ".yaml", ".gif");
        public static string FMTV = GetFilter(".bfmvi");
        public static string FBNV = GetFilter(".bfbvi");
        public static string FSCN = GetFilter(".bfscn");
        public static string FSHA = GetFilter(".bfspa");

        public static string CMDL = GetFilter(".dae");

        public static string CTR_TEX = GetFilter(".png", ".bmp", ".tga", ".jpg", ".tiff", ".tif", ".gif");
        public static string REV_TEX = GetFilter(".png", ".bmp", ".tga", ".jpg", ".tiff", ".tif", ".gif");

        public static string NUTEXB = GetFilter(".dds",".png", ".bmp", ".tga", ".jpg", ".tiff", ".tif", ".gif");
        public static string XTX = GetFilter(".dds", ".astc", ".png", ".bmp", ".tga", ".jpg", ".tiff", ".tif", ".gif");

        public static string GetFilter(Type type, object CheckAnimEffect = null, bool IsExporting = false)
        {
            if (type == typeof(TextureData)) return BNTX_TEX;
            else if (type == typeof(FMDL) && IsExporting) return FMDL_EXPORT;
            else if (type == typeof(FMDL)) return FMDL;
            else if (type == typeof(FSHP)) return FSHP;
            else if (type == typeof(FMAT)) return FMAT;
            else if (type == typeof(FSKL)) return FSKL;
            else if (type == typeof(BfresBone)) return BONE;
            else if (type == typeof(FSKA) && IsExporting) return FSKA_EXPORT;
            else if (type == typeof(FSKA)) return FSKA_REPLACE;
            else if (type == typeof(FMAA)) return FMAA;
            else if (type == typeof(FTXP)) return FTXP;
            else if (type == typeof(FSHA)) return FSHA;
            else if (type == typeof(FTEX)) return FTEX;
            else if (type == typeof(FSCN)) return FSCN;
            else if (type == typeof(FSHU))
            {
                if (IsExporting)
                {
                    if (CheckAnimEffect is FSHU.AnimationType)
                    {
                        var animType = (MaterialAnimation.AnimationType)CheckAnimEffect;
                        if (animType == MaterialAnimation.AnimationType.Color) return FSHU_EXPORT_COLOR;
                        if (animType == MaterialAnimation.AnimationType.TextureSrt) return FSHU_EXPORT_SRT;
                        else return FSHU_EXPORT_PARAM;
                    }
                }
                else
                {
                    if (CheckAnimEffect is FSHU.AnimationType)
                    {
                        var animType = (MaterialAnimation.AnimationType)CheckAnimEffect;
                        if (animType == MaterialAnimation.AnimationType.Color) return FSHU_REPLACE_COLOR;
                        if (animType == MaterialAnimation.AnimationType.TextureSrt) return FSHU_REPLACE_SRT;
                        else return FSHU_REPLACE_PARAM;
                    }
                }

                if (IsExporting)
                    return FSHU_EXPORT_PARAM;
                else
                    return FSHU_REPLACE_PARAM;
            }
            else if (type == typeof(FVIS))
            {
                return FBNV;
            }
            else return "All Files (*.*)|*.*";
        }

        public static Dictionary<string, string> GetDescription(string[] extensions)
        {
            var filters = new Dictionary<string, string>();
            foreach (string ext in extensions)
            {
                switch (ext)
                {
                    case ".bfmdl": filters.Add(ext, "Bfres模型"); break;
                    case ".bfmat": filters.Add(ext, "Bfres材质"); break;
                    case ".bfobj": filters.Add(ext, "Bfres对象（形状/顶点）"); break;
                    case ".bfbn": filters.Add(ext, "Bfres骨骼"); break;
                    case ".bfskl": filters.Add(ext, "Bfres骨架"); break;
                    case ".bfska": filters.Add(ext, "Bfres骨架动画"); break;
                    case ".bfmaa": filters.Add(ext, "Bfres材质动画"); break;
                    case ".bfshu": filters.Add(ext, "Bfres着色器参数动画"); break;
                    case ".bfcsh": filters.Add(ext, "Bfres颜色动画"); break;
                    case ".bfsth": filters.Add(ext, "Bfres纹理变换动画"); break;
                    case ".bftxp": filters.Add(ext, "Bfres纹理图案动画"); break;
                    case ".bfbvi": filters.Add(ext, "Bfres骨骼可见性动画"); break;
                    case ".bfmvi": filters.Add(ext, "Bfres材质可见性动画"); break;
                    case ".bfspa": filters.Add(ext, "Bfres形状动画"); break;
                    case ".bfscn": filters.Add(ext, "Bfres场景动画"); break;
                    case ".dae": filters.Add(ext, "DAE"); break;
                    case ".fbx": filters.Add(ext, "FBX"); break;
                    case ".obj": filters.Add(ext, "OBJ"); break;
                    case ".csv": filters.Add(ext, "CSV"); break;
                    case ".dds": filters.Add(ext, "微软DDS"); break;
                    case ".tga": filters.Add(ext, "Truevision 图形适配器格式"); break;
                    case ".png": filters.Add(ext, "便携式网络图像"); break;
                    case ".jpg": filters.Add(ext, "联合图像专家组"); break;
                    case ".bmp": filters.Add(ext, "位图图像"); break;
                    case ".tiff": filters.Add(ext, "标记图像文件格式"); break;
                    case ".tif": filters.Add(ext, "标记图像文件格式"); break;
                    case ".seanim": filters.Add(ext, "SE动画"); break;
                    case ".smd": filters.Add(ext, "源模型动画"); break;
                    case ".bftex": filters.Add(ext, "二进制纹理"); break;
                    case ".astc": filters.Add(ext, "自适应可扩展纹理压缩"); break;
                    case ".chr0": filters.Add(ext, "CHR0动画"); break;
                    case ".anim": filters.Add(ext, "Maya动画"); break;
                    case ".yaml": filters.Add(ext, "另一种标记语言"); break;
                    case ".gif": filters.Add(ext, "通用交换格式"); break;
                    case ".cmdl": filters.Add(ext, "CTR模型"); break;
                    default:
                        filters.Add(ext, ""); break;
                }
            }
            return filters;
        }


        private static string GetFilter(params string[] extensions)
        {
            return GetCompleteFilter(GetDescription(extensions));
        }

        public static string GetCompleteFilter(Dictionary<string, string> files)
        {
            if (files.Count == 0)
                return "所有文件(*.*)|*.*";

            string Filter = "所有支持的文件|";
            List<string> FilterEach = new List<string>();
            foreach (var Extension in files)
            {
                Filter += $"*{Extension.Key};";
                FilterEach.Add($"{Extension.Value} (*{Extension.Key}) |*{Extension.Key}|");
            }

            Filter += "|";
            Filter += string.Join("", FilterEach.ToArray());
            Filter += "所有文件(*.*)|*.*";
            return Filter;
        }
    }
}
