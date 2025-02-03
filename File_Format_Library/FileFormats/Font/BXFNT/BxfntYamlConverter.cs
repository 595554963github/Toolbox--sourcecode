using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using SharpYaml.Serialization;

namespace FirstPlugin
{
    public class BxfntYamlConverter
    {
        public static string ToYaml(FFNT header)
        {
            YamlMappingNode mapping = new YamlMappingNode();
            mapping.Add("Platform", header.Platform.ToString());
            mapping.Add("Version", header.Version.ToString("X"));
            mapping.Add("FontInfo", SaveFontInfo(header.FontSection));
            mapping.Add("KerningTable", SaveKerningTable(header.KerningTable));

            var doc = new YamlDocument(mapping);

            YamlStream stream = new YamlStream(doc);
            var buffer = new StringBuilder();
            using (var writer = new StringWriter(buffer)) {
                stream.Save(writer, true);
                return writer.ToString();
            }
        }

        private static YamlMappingNode SaveFontInfo(FINF fontInfo)
        {
            YamlMappingNode mapping = new YamlMappingNode();
            mapping.Add("类型", fontInfo.Type.ToString());
            mapping.Add("字体宽度", fontInfo.Width.ToString());
            mapping.Add("字体高度", fontInfo.Height.ToString());
            mapping.Add("行间距", fontInfo.LineFeed.ToString());
            mapping.Add("上升量", fontInfo.Ascent.ToString());
            mapping.Add("替换字符索引", fontInfo.AlterCharIndex.ToString());
            mapping.Add("默认字符宽度", fontInfo.DefaultCharWidth.ToString());
            mapping.Add("默认自行宽度", fontInfo.DefaultGlyphWidth.ToString());
            mapping.Add("默认左宽度", fontInfo.DefaultLeftWidth.ToString());
            mapping.Add("默认纹理宽度", SaveTextureGlyph(fontInfo.TextureGlyph));
            mapping.Add("字符映射", SaveCharacterMaps(fontInfo));
            mapping.Add("字符宽度值", SaveCharacterWidths(fontInfo));
            return mapping;
        }

        private static YamlMappingNode SaveTextureGlyph(TGLP texInfo)
        {
            YamlMappingNode mapping = new YamlMappingNode();
            mapping.Add("单元格高度", texInfo.CellHeight.ToString());
            mapping.Add("单元格宽度", texInfo.CellWidth.ToString());
            mapping.Add("格式", texInfo.Format.ToString());
            mapping.Add("基线位置", texInfo.BaseLinePos.ToString());
            mapping.Add("最大字符索引", texInfo.MaxCharWidth.ToString());
            mapping.Add("表格高度", texInfo.SheetHeight.ToString());
            mapping.Add("表格卷度", texInfo.SheetWidth.ToString());
            mapping.Add("行数", texInfo.RowCount.ToString());
            mapping.Add("列数", texInfo.ColumnCount.ToString());
            return mapping;
        }

        private static YamlSequenceNode SaveCharacterMaps(FINF fontInfo)
        {
            YamlSequenceNode node = new YamlSequenceNode();
           // node.Style = SharpYaml.YamlStyle.Flow;
            foreach (var character in fontInfo.CodeMapDictionary.Keys)
            {
                YamlMappingNode mapping = new YamlMappingNode();
                mapping.Add($"0x{((ushort)character).ToString("X4")}", character.ToString());
                node.Add(mapping);
            }
            
            return node;
        }

        private static YamlSequenceNode SaveCharacterWidths(FINF fontInfo)
        {
            YamlSequenceNode node = new YamlSequenceNode();
            foreach (var character in fontInfo.CodeMapDictionary)
            {
                YamlMappingNode mapping = new YamlMappingNode();
                mapping.Style = SharpYaml.YamlStyle.Flow;
                if (character.Value != -1) {
                    var width = fontInfo.GetCharacterWidth(character.Value);
                    mapping.Add($"0x{((ushort)character.Key).ToString("X4")}", SaveCharacterWidth(width));
                }
                node.Add(mapping);
            }
            return node;
        }

        private static YamlSequenceNode SaveCharacterWidth(CharacterWidthEntry table)
        {
            YamlSequenceNode node = new YamlSequenceNode();
            node.Style = SharpYaml.YamlStyle.Flow;
            node.Add(NewMappingNode("CharWidth", table.CharWidth.ToString()));
            node.Add(NewMappingNode("GlyphWidth", table.GlyphWidth.ToString()));
            node.Add(NewMappingNode("Left", table.Left.ToString()));
            return node;
        }

        private static YamlMappingNode NewMappingNode(string key, string value)
        {
            return new YamlMappingNode(new YamlScalarNode(key), new YamlScalarNode(value));
        }

        private static YamlMappingNode SaveKerningTable(FontKerningTable table)
        {
            YamlMappingNode mapping = new YamlMappingNode();
            if (table == null)
                return mapping;


            return mapping;
        }
    }
}
