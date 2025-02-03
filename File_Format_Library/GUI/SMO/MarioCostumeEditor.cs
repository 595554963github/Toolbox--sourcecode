using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;

namespace FirstPlugin
{
    public class MarioCostumeEditor
    {
        public static Matrix4 SetTransform(string fileName)
        {
            Vector3 position;
            Vector3 scale;
            Vector3 rotation;

            if (fileName.Contains("Mario") && fileName.Contains("Face"))
            {
                Console.WriteLine("定位面网格.....");
                position = new Vector3(0, 97.0f, 0);
                scale = new Vector3(1, 1, 1);
                rotation = new Vector3(0, 0, 0);
            }
            else if (fileName.Contains("Mario") && fileName.Contains("Head"))
            {
                Console.WriteLine("定位头网格.....");
                position = new Vector3(0, 97.0f, 0);
                scale = new Vector3(1, 1, 1);
                rotation = new Vector3(0, 0, 0);
            }
            else if (fileName.Contains("Mario") && fileName.Contains("HandL"))
            {
                Console.WriteLine("定位面网格.....");
                position = new Vector3(48.877f, 82.551f, -3.3f);
                scale = new Vector3(1, 1, 1);
                rotation = new Vector3(0, 90f, 0);
            }
            else if (fileName.Contains("Mario") && fileName.Contains("HandR"))
            {
                Console.WriteLine("定位右手网格.....");
                position = new Vector3(-48.877f, 82.551f, -3.3f);
                scale = new Vector3(1, 1, 1);
                rotation = new Vector3(0, -90f, 0);
            }
            else if (fileName.Contains("Mario") && fileName.Contains("Eye"))
            {
                Console.WriteLine("定位眼睛网格.....");
                position = new Vector3(0, 97.0f, 0);
                scale = new Vector3(1, 1, 1);
                rotation = new Vector3(0, 0f, 0);
            }
            else if (fileName.Contains("Mario") && fileName.Contains("Hair"))
            {
                Console.WriteLine("定位头发网格......");
                position = new Vector3(0, 97.0f, 0);
                scale = new Vector3(1, 1, 1);
                rotation = new Vector3(0, 0f, 0);
            }
            else if (fileName.Contains("Mario") && fileName.Contains("Skirt"))
            {
                Console.WriteLine("定位裙子网格.....");
                position = new Vector3(0, 56.0f, 0);
                scale = new Vector3(1, 1, 1);
                rotation = new Vector3(0, 0f, 0);
            }
            else if (fileName.Contains("Mario") && fileName.Contains("Tail"))
            {
                Console.WriteLine("定位尾巴网格.....");
                position = new Vector3(0, 56.0f, 0);
                scale = new Vector3(1, 1, 1);
                rotation = new Vector3(0, 0f, 0);
            }
            else if (fileName.Contains("Mario") && fileName.Contains("Shell"))
            {
                Console.WriteLine("定位尾巴网格.....");
                position = new Vector3(0, 75.0f, 0);
                scale = new Vector3(1, 1, 1);
                rotation = new Vector3(0, 0f, 0);
            }
            else if (fileName.Contains("Mario") && fileName.Contains("aHakama"))
            {
                Console.WriteLine("定位袴网格.....");
                position = new Vector3(0, 61.0f, -3.0f);
                scale = new Vector3(1, 1, 1);
                rotation = new Vector3(0, 0f, 0);
            }
            else if (fileName.Contains("Mario") && fileName.Contains("Under"))
            {
                Console.WriteLine("定位底部网格.....");
                position = new Vector3(0, 56.0f, 0);
                scale = new Vector3(1, 1, 1);
                rotation = new Vector3(0, 0f, 0);
            }
            else if (fileName.Contains("Mario") && fileName.Contains("PonchoPoncho"))
            {
                Console.WriteLine("定位披风网格.....");
                position = new Vector3(0, 60.5f, -4.0f);
                scale = new Vector3(1, 1, 1);
                rotation = new Vector3(0, 0f, 0);
            }
            else if (fileName.Contains("Mario") && fileName.Contains("PonchoGuitar"))
            {
                Console.WriteLine("定位其他网格.....");
                position = new Vector3(48.877f, 0, -12.3f);
                scale = new Vector3(1, 1, 1);
                rotation = new Vector3(0, 90f, 0);
            }
            else
            {
                position = new Vector3(0, 0, 0);
                scale = new Vector3(1, 1, 1);
                rotation = new Vector3(0, 0, 0);
            }

            Matrix4 positionMat = Matrix4.CreateTranslation(position);
            Matrix4 rotXMat = Matrix4.CreateRotationX(MathHelper.DegreesToRadians(rotation.X));
            Matrix4 rotYMat = Matrix4.CreateRotationY(MathHelper.DegreesToRadians(rotation.Y));
            Matrix4 rotZMat = Matrix4.CreateRotationZ(MathHelper.DegreesToRadians(rotation.Z));
            Matrix4 scaleMat = Matrix4.CreateScale(scale);
            return scaleMat * (rotXMat * rotYMat * rotZMat) * positionMat;
        }
    }
}
