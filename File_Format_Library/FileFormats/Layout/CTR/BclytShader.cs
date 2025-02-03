using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using OpenTK.Graphics.OpenGL;
using OpenTK;
using Toolbox.Library;

namespace LayoutBXLYT
{
    public class BclytShader : BxlytShader
    {
        public BclytShader() : base()
        {
            LoadShaders();
        }
        
        public override void OnCompiled()
        {
            SetColor("whiteColor", Color.FromArgb(255, 255, 255, 255));
            SetColor("blackColor", Color.FromArgb(0, 0, 0, 0));
            SetInt("debugShading", 0);
            SetInt("hasTexture0", 0);
            SetInt("numTextureMaps", 0);
            SetInt("flipTexture", 0);
            SetInt("textures0", 0);
            SetInt("textures1", 0);
            SetInt("textures2", 0);
            SetBool("AlphaInterpolation", false);

            SetVec2("uvScale0", new Vector2(1, 1));
            SetFloat("uvRotate0", 0);
            SetVec2("uvTranslate0", new Vector2(0, 0));

            var rotationMatrix = Matrix4.Identity;
            SetMatrix("rotationMatrix", ref rotationMatrix);
            SetInt($"texCoords0GenType", 0);
            SetInt($"texCoords0Source", 0);
        }

        public static void SetMaterials(BxlytShader shader, CTR.Material material, BasePane pane, Dictionary<string, STGenericTexture> textures)
        {
            Matrix4 rotationX = Matrix4.CreateRotationX(MathHelper.DegreesToRadians(pane.Rotate.X));
            Matrix4 rotationY = Matrix4.CreateRotationY(MathHelper.DegreesToRadians(pane.Rotate.Y));
            Matrix4 rotationZ = Matrix4.CreateRotationZ(MathHelper.DegreesToRadians(pane.Rotate.Z));
            var rotationMatrix = rotationX * rotationY * rotationZ;

            shader.SetMatrix("rotationMatrix", ref rotationMatrix);

            shader.SetColor("whiteColor", material.WhiteColor.Color);
            shader.SetColor("blackColor", material.BlackColor.Color);
            shader.SetInt("debugShading", (int)Runtime.LayoutEditor.Shading);
            shader.SetInt("numTextureMaps", material.TextureMaps.Length);
            shader.SetVec2("uvScale0", new Vector2(1, 1));
            shader.SetFloat("uvRotate0", 0);
            shader.SetVec2("uvTranslate0", new Vector2(0, 0));
            shader.SetInt("flipTexture", 0);
            shader.SetBool("AlphaInterpolation", material.AlphaInterpolation);
            shader.SetInt($"texCoords0GenType", 0);
            shader.SetInt($"texCoords0Source", 0);

            LoadTextureUniforms(shader, material, textures);
            LoadDefaultBlending();
        }

        public override string VertexShader
        {
            get
            {
                string path = System.IO.Path.Combine(Runtime.ExecutableDir, "Shader", "Layout", "Bflyt.vert");
                string legacyPath = System.IO.Path.Combine(Runtime.ExecutableDir, "Shader", "Layout", "Legacy", "Bflyt.vert");

                if (LayoutEditor.UseLegacyGL)
                    return System.IO.File.ReadAllText(legacyPath);
                else
                    return System.IO.File.ReadAllText(path);
            }
        }

        public override string FragmentShader
        {
            get
            {
                string path = System.IO.Path.Combine(Runtime.ExecutableDir, "Shader", "Layout", "Bflyt.frag");
                string legacyPath = System.IO.Path.Combine(Runtime.ExecutableDir, "Shader", "Layout", "Legacy", "Bflyt.frag");

                if (LayoutEditor.UseLegacyGL)
                    return System.IO.File.ReadAllText(legacyPath);
                else
                    return System.IO.File.ReadAllText(path);
            }
        }
    }
}
