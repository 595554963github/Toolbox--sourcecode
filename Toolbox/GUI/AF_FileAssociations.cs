﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;
using System.Security.AccessControl;
using System.IO;

//CREATED BY AIDAN MICHAEL FOLLESTAD
//COPYWRITE 2010, AF PRODUCTIONS.

namespace Associations
{
    class RegistryUtilities
    {
        public bool RenameSubKey(RegistryKey parentKey, string subKeyName, string newSubKeyName)
        {
            CopyKey(parentKey, subKeyName, newSubKeyName);
            parentKey.DeleteSubKeyTree(subKeyName);
            return true;
        }

        public bool CopyKey(RegistryKey parentKey, string keyNameToCopy, string newKeyName)
        {
            //Create new key
            RegistryKey destinationKey = parentKey.CreateSubKey(newKeyName, RegistryKeyPermissionCheck.ReadWriteSubTree);

            //Open the sourceKey we are copying from
            RegistryKey sourceKey = parentKey.OpenSubKey(keyNameToCopy, RegistryKeyPermissionCheck.ReadWriteSubTree,
                RegistryRights.FullControl);

            RecurseCopyKey(sourceKey, destinationKey);

            return true;
        }

        private void RecurseCopyKey(RegistryKey sourceKey, RegistryKey destinationKey)
        {
            //copy all the values
            foreach (string valueName in sourceKey.GetValueNames())
            {
                object objValue = sourceKey.GetValue(valueName);
                RegistryValueKind valKind = sourceKey.GetValueKind(valueName);
                destinationKey.SetValue(valueName, objValue, valKind);
            }

            //For Each subKey 
            //Create a new subKey in destinationKey 
            //Call myself 
            foreach (string sourceSubKeyName in sourceKey.GetSubKeyNames())
            {
                RegistryKey sourceSubKey = sourceKey.OpenSubKey(sourceSubKeyName,
                    RegistryKeyPermissionCheck.ReadWriteSubTree, RegistryRights.FullControl);
                RegistryKey destSubKey = destinationKey.CreateSubKey(sourceSubKeyName,
                    RegistryKeyPermissionCheck.ReadWriteSubTree);
                RecurseCopyKey(sourceSubKey, destSubKey);
            }
        }
    }

    /// <summary>
    /// Reference to an .ico file used by AF_FileAssociator.
    /// </summary>
    public class ProgramIcon
    {
        public ProgramIcon(string iconPath)
        {
            IconPath = iconPath.Trim();
        }

        public readonly string IconPath;

        public bool IsValid
        {
            get
            {
                FileInfo getInfo = new FileInfo(IconPath);

                if (getInfo.Exists && getInfo.Extension == ".ico")
                    return true;
                else
                    return false;
            }
        }
    }

    /// <summary>
    /// Reference to an list of executable files used by AF_FileAssociator.
    /// </summary>
    public class OpenWithList
    {
        public OpenWithList(string[] openWithPaths)
        {
            List<string> toReturn = new List<string>();
            FileInfo getInfo;

            foreach (string file in openWithPaths)
            {
                getInfo = new FileInfo(file);
                toReturn.Add(getInfo.Name);
            }

            List = toReturn.ToArray();
        }

        public readonly string[] List;
    }

    /// <summary>
    /// Reference to a executable file used by AF_FileAssociator.
    /// </summary>
    public class ExecApplication
    {
        public ExecApplication(string appPath)
        {
            Path = appPath.Trim();
        }

        public readonly string Path;

        /// <summary>
        /// Gets a value indicating whether this Executable Application is an .exe, and that it exists.
        /// </summary>
        public bool IsValid
        {
            get
            {
                FileInfo getInfo = new FileInfo(Path);
                if (getInfo.Exists)
                    return true;
                else
                    return false;
            }
        }
    }

    /// <summary>
    /// AF_Lib's class for associating files with programs and icons.
    /// </summary>
    public class AF_FileAssociator
    {
        /// <summary>
        /// Initializes a new AF_FileAssociator class object for the specified file extension.
        /// </summary>
        /// <param name="extension">the file extension to control (such as .txt).</param>
        public AF_FileAssociator(string extension)
        {
            Extension = extension;
        }

        /// <summary>
        /// Gets the extension set for this file associator to control when you initialized it.
        /// </summary>
        public readonly string Extension;

        string GetProgID
        {
            get
            {
                string toReturn = string.Empty;

                if (Registry.ClassesRoot.OpenSubKey(Extension,
                    RegistryKeyPermissionCheck.ReadWriteSubTree,
                    RegistryRights.FullControl) != null)
                {
                    if (Registry.ClassesRoot.OpenSubKey(Extension,
                        RegistryKeyPermissionCheck.ReadWriteSubTree,
                        RegistryRights.FullControl).GetValue("") != null)
                    {
                        toReturn = Registry.ClassesRoot.OpenSubKey(Extension,
                            RegistryKeyPermissionCheck.ReadWriteSubTree,
                            RegistryRights.FullControl).GetValue("").ToString();
                    }
                }

                return toReturn;
            }
        }

        /// <summary>
        /// Gets a value indicating whether the association keys exist. If the extension key doesn't, the program cannot get the name of the program association key making it appear to not exist.
        /// </summary>
        public bool Exists
        {
            get
            {
                bool extKeyExists = false;
                bool progIDkeyExists = false;

                if (Registry.ClassesRoot.OpenSubKey(Extension) != null)
                {
                    extKeyExists = true;

                    if (GetProgID != null)
                    {
                        if (Registry.ClassesRoot.OpenSubKey(GetProgID) != null)
                        {
                            progIDkeyExists = true;
                        }
                    }
                }

                if (extKeyExists && progIDkeyExists)
                    return true;
                else
                    return false;
            }
        }

        /// <summary>
        /// Create or overwrite a current file association for this FileAssociator's set extension.
        /// </summary>
        /// <param name="progID">The basic application name that uses this file extension.</param>
        /// <param name="description">The desription of this file extension and/or program that uses it.</param>
        /// <param name="defaultIcon">The icon to show on the program and it's files.</param>
        /// <param name="execApp">The application that will be run when the file extension is clicked.</param>
        /// <param name="openWith">The programs that appear in the OpenWith list.</param>
        /// <exception cref="Exception">Thrown when an error occurs that will prevent it from working correctly.</exception>
        public void Create(string progID, string description, ProgramIcon defaultIcon, ExecApplication execApp, OpenWithList openWith)
        {
            if (progID != null)
            {
                if (defaultIcon.IsValid && execApp.IsValid)
                {
                    Registry.ClassesRoot.CreateSubKey(Extension).SetValue("", progID);
                    RegistryKey key = Registry.ClassesRoot.CreateSubKey(progID,
                        RegistryKeyPermissionCheck.ReadWriteSubTree);

                    if (description != null)
                        key.SetValue("", description, RegistryValueKind.String);

                    if (defaultIcon != null && defaultIcon.IsValid)
                        key.CreateSubKey("DefaultIcon").SetValue("", defaultIcon.IconPath, RegistryValueKind.String);
                    else
                        throw new Exception("你输入的默认图标要么为空，要么不存在...");

                    if (execApp != null && execApp.IsValid)
                        key.CreateSubKey(@"Shell\Open\Command").SetValue("", execApp.Path + " %1", RegistryValueKind.String);
                    else
                        throw new Exception("您输入的可执行应用程序为空值或不是.exe格式...");

                    if (openWith != null)
                    {
                        key = key.CreateSubKey("OpenWithList", RegistryKeyPermissionCheck.ReadWriteSubTree);
                        foreach (string file in openWith.List)
                        {
                            key.CreateSubKey(file);
                        }
                    }

                    key.Flush();
                    key.Close();
                }
                else
                {
                    throw new Exception("E图标或可执行应用程序对象无效...");
                }
            }
            else
            {
                throw new Exception("您输入的程序ID为空...");
            }
        }

        /// <summary>
        /// Gets or sets the program ID for this extension.
        /// </summary>
        public string ID
        {
            get
            {
                string toReturn = string.Empty;

                if (this.Exists)
                {
                    if (Registry.ClassesRoot.OpenSubKey(Extension,
                        RegistryKeyPermissionCheck.ReadWriteSubTree,
                        RegistryRights.FullControl) != null)
                    {
                        toReturn = GetProgID;
                    }
                    else
                    {
                        throw new Exception("扩展的关联密钥(" + GetProgID + "不存在,请使用 Create（）函数设置所有内容...");
                    }
                }
                else
                {
                    throw new Exception("您的关联键之一不存在，请使用创建方法开始...");
                }

                return toReturn;
            }
            set
            {
                if (this.Exists)
                {
                    if (Registry.ClassesRoot.OpenSubKey(Extension,
                        RegistryKeyPermissionCheck.ReadWriteSubTree,
                        RegistryRights.FullControl) != null)
                    {
                        string beforeID = GetProgID;
                        RegistryUtilities reg = new RegistryUtilities();
                        reg.RenameSubKey(Registry.ClassesRoot, beforeID, value);

                        Registry.ClassesRoot.OpenSubKey(Extension,
                            RegistryKeyPermissionCheck.ReadWriteSubTree,
                            RegistryRights.FullControl).SetValue("", value,
                            RegistryValueKind.String);
                    }
                    else
                    {
                        throw new Exception("扩展的关联密钥(" + GetProgID + ")不存在,请使用 Create（）函数设置所有内容...");
                    }
                }
                else
                {
                    throw new Exception("您的关联键之一不存在，请使用创建方法开始...");
                }
            }
        }

        /// <summary>
        /// Gets or sets the description for this file extension and/or it's program association.
        /// </summary>
        public string Description
        {
            get
            {
                string toReturn = string.Empty;

                if (this.Exists)
                {
                    if (Registry.ClassesRoot.OpenSubKey(Extension,
                        RegistryKeyPermissionCheck.ReadWriteSubTree,
                        RegistryRights.FullControl) != null)
                    {
                        if (Registry.ClassesRoot.OpenSubKey(GetProgID,
                            RegistryKeyPermissionCheck.ReadWriteSubTree,
                            RegistryRights.FullControl) != null)
                        {
                            if (Registry.ClassesRoot.OpenSubKey(GetProgID,
                                RegistryKeyPermissionCheck.ReadWriteSubTree,
                                RegistryRights.FullControl).GetValue("") != null)
                            {
                                toReturn = Registry.ClassesRoot.OpenSubKey(GetProgID,
                                    RegistryKeyPermissionCheck.ReadWriteSubTree,
                                    RegistryRights.FullControl).GetValue("").ToString();
                            }
                        }
                        else
                        {
                            throw new Exception("扩展程序的预处理关联密钥(" + GetProgID + ")不存在,请使用 Create（）函数设置所有内容...");
                        }
                    }
                    else
                    {
                        throw new Exception("扩展关联键不存在,请使用 Create（）函数设置所有内容...");
                    }
                }
                else
                {
                    throw new Exception("您的关联键之一不存在，请使用创建方法开始...");
                }

                return toReturn;
            }
            set
            {
                if (this.Exists)
                {
                    if (Registry.ClassesRoot.OpenSubKey(Extension,
                        RegistryKeyPermissionCheck.ReadWriteSubTree,
                        RegistryRights.FullControl) != null)
                    {
                        if (Registry.ClassesRoot.OpenSubKey(GetProgID,
                            RegistryKeyPermissionCheck.ReadWriteSubTree,
                            RegistryRights.FullControl) != null)
                        {
                            Registry.ClassesRoot.OpenSubKey(GetProgID,
                                RegistryKeyPermissionCheck.ReadWriteSubTree,
                                RegistryRights.FullControl).SetValue("", value, RegistryValueKind.String);
                        }
                        else
                        {
                            throw new Exception("扩展程序的预处理关联密钥(" + GetProgID + ")不存在,请使用 Create（）函数设置所有内容...");
                        }
                    }
                    else
                    {
                        throw new Exception("扩展关联键不存在,请使用 Create（）函数设置所有内容...");
                    }
                }
                else
                {
                    throw new Exception("您的关联键之一不存在，请使用创建方法开始...");
                }
            }
        }

        /// <summary>
        /// Gets or sets the icon shown on this file extension and/or it's program association.
        /// </summary>
        public ProgramIcon DefaultIcon
        {
            get
            {
                ProgramIcon toReturn = null;

                if (this.Exists)
                {
                    if (Registry.ClassesRoot.OpenSubKey(Extension,
                        RegistryKeyPermissionCheck.ReadWriteSubTree,
                        RegistryRights.FullControl) != null)
                    {
                        if (Registry.ClassesRoot.OpenSubKey(GetProgID,
                            RegistryKeyPermissionCheck.ReadWriteSubTree,
                            RegistryRights.FullControl) != null)
                        {
                            if (Registry.ClassesRoot.OpenSubKey(GetProgID + @"\DefaultIcon",
                                RegistryKeyPermissionCheck.ReadWriteSubTree,
                                RegistryRights.FullControl) != null)
                            {
                                if (Registry.ClassesRoot.OpenSubKey(GetProgID + @"\DefaultIcon",
                                    RegistryKeyPermissionCheck.ReadWriteSubTree,
                                    RegistryRights.FullControl).GetValue("") != null)
                                {
                                    toReturn = new ProgramIcon(Registry.ClassesRoot.OpenSubKey(GetProgID + @"\DefaultIcon",
                                        RegistryKeyPermissionCheck.ReadWriteSubTree,
                                        RegistryRights.FullControl).GetValue("").ToString());
                                }
                            }
                        }
                        else
                        {
                            throw new Exception("扩展程序的程序默认图标关联键不存在,请使用 Create（）函数设置所有内容...");
                        }
                    }
                    else
                    {
                        throw new Exception("扩展关联键不存在,请使用 Create（）函数设置所有内容...");
                    }
                }
                else
                {
                    throw new Exception("您的关联键之一不存在，请使用创建方法开始...");
                }

                return toReturn;
            }
            set
            {
                if (this.Exists)
                {
                    if (value.IsValid)
                    {
                        if (Registry.ClassesRoot.OpenSubKey(Extension,
                            RegistryKeyPermissionCheck.ReadWriteSubTree,
                            RegistryRights.FullControl) != null)
                        {
                            if (Registry.ClassesRoot.OpenSubKey(GetProgID + @"\DefaultIcon",
                                RegistryKeyPermissionCheck.ReadWriteSubTree,
                                RegistryRights.FullControl) != null)
                            {
                                Registry.ClassesRoot.OpenSubKey(GetProgID + @"\DefaultIcon",
                                    RegistryKeyPermissionCheck.ReadWriteSubTree,
                                    RegistryRights.FullControl).SetValue("", value.IconPath, RegistryValueKind.String);
                            }
                            else
                            {
                                throw new Exception("扩展程序的程序默认图标关联键不存在,请使用 Create（）函数设置所有内容...");
                            }
                        }
                        else
                        {
                            throw new Exception("扩展关联键不存在,请使用 Create（）函数设置所有内容...");
                        }
                    }
                    else
                    {
                        throw new Exception("您尝试设置为此默认图标变量的值无效...这个图标不存在或者它不是.ico文件.");
                    }
                }
                else
                {
                    throw new Exception("您的关联键之一不存在，请使用创建方法开始...");
                }
            }
        }

        /// <summary>
        /// Gets or sets the executable ran when this file extension is opened.
        /// </summary>
        public ExecApplication Executable
        {
            get
            {
                ExecApplication execApp = null;

                if (this.Exists)
                {
                    if (Registry.ClassesRoot.OpenSubKey(Extension,
                        RegistryKeyPermissionCheck.ReadWriteSubTree,
                        RegistryRights.FullControl) != null)
                    {
                        if (Registry.ClassesRoot.OpenSubKey(GetProgID + @"\Shell\Open\Command",
                            RegistryKeyPermissionCheck.ReadWriteSubTree,
                            RegistryRights.FullControl) != null)
                        {
                            if (Registry.ClassesRoot.OpenSubKey(GetProgID + @"\Shell\Open\Command",
                                RegistryKeyPermissionCheck.ReadWriteSubTree,
                                RegistryRights.FullControl).GetValue("") != null)
                            {
                                string path = Registry.ClassesRoot.OpenSubKey(GetProgID + @"\Shell\Open\Command",
                                    RegistryKeyPermissionCheck.ReadWriteSubTree,
                                    RegistryRights.FullControl).GetValue("").ToString();

                                execApp = new ExecApplication(path.Substring(0, path.LastIndexOf('%') - 1));
                            }
                        }
                        else
                        {
                            throw new Exception("扩展程序的预处理可执行关联密钥不存在,请使用 Create（）函数设置所有内容...");
                        }
                    }
                    else
                    {
                        throw new Exception("扩展关联键不存在,请使用 Create（）函数设置所有内容...");
                    }
                }
                else
                {
                    throw new Exception("您的关联键之一不存在，请使用创建方法开始...");
                }

                return execApp;
            }
            set
            {
                if (this.Exists)
                {
                    if (value.IsValid)
                    {
                        if (Registry.ClassesRoot.OpenSubKey(Extension,
                            RegistryKeyPermissionCheck.ReadWriteSubTree,
                            RegistryRights.FullControl) != null)
                        {
                            if (Registry.ClassesRoot.OpenSubKey(GetProgID + @"\Shell\Open\Command",
                                RegistryKeyPermissionCheck.ReadWriteSubTree,
                                RegistryRights.FullControl) != null)
                            {
                                Registry.ClassesRoot.OpenSubKey(GetProgID + @"\Shell\Open\Command",
                                    RegistryKeyPermissionCheck.ReadWriteSubTree,
                                    RegistryRights.FullControl).SetValue("", value.Path + " %1", RegistryValueKind.String);
                            }
                            else
                            {
                                throw new Exception("扩展程序的预处理可执行关联密钥不存在,请使用 Create（）函数设置所有内容...");
                            }
                        }
                        else
                        {
                            throw new Exception("扩展关联键不存在,请使用 Create（）函数设置所有内容...");
                        }
                    }
                    else
                    {
                        throw new Exception("用于设置此变量的值无效... 这个文件不存在或者它不是一个exe文件.");
                    }
                }
                else
                {
                    throw new Exception("您的关联键之一不存在，请使用创建方法开始...");
                }
            }
        }

        /// <summary>
        /// Gets or sets the list of programs shown in the OpenWith list.
        /// </summary>
        public OpenWithList OpenWith
        {
            get
            {
                OpenWithList toReturn = null;

                if (this.Exists)
                {
                    if (Registry.ClassesRoot.OpenSubKey(Extension,
                        RegistryKeyPermissionCheck.ReadWriteSubTree,
                        RegistryRights.FullControl) != null)
                    {
                        if (Registry.ClassesRoot.OpenSubKey(GetProgID + @"\OpenWithList",
                            RegistryKeyPermissionCheck.ReadWriteSubTree,
                            RegistryRights.FullControl) != null)
                        {
                            List<string> list = new List<string>();
                            foreach (string file in Registry.ClassesRoot.OpenSubKey(GetProgID + @"\OpenWithList",
                                 RegistryKeyPermissionCheck.ReadWriteSubTree,
                                 RegistryRights.FullControl).GetSubKeyNames())
                            {
                                list.Add(file);
                            }

                            toReturn = new OpenWithList(list.ToArray());
                            list.Clear();
                        }
                        else
                        {
                            throw new Exception("扩展程序的程序使用可执行的关联密钥打开不存在,请使用 Create（）函数设置所有内容...");
                        }
                    }
                    else
                    {
                        throw new Exception("扩展关联键不存在,请使用 Create（）函数设置所有内容...");
                    }
                }
                else
                {
                    throw new Exception("您的关联键之一不存在，请使用创建方法开始...");
                }

                return toReturn;
            }
            set
            {
                if (this.Exists)
                {
                    if (Registry.ClassesRoot.OpenSubKey(Extension,
                        RegistryKeyPermissionCheck.ReadWriteSubTree,
                        RegistryRights.FullControl) != null)
                    {
                        if (Registry.ClassesRoot.OpenSubKey(GetProgID + @"\OpenWithList",
                            RegistryKeyPermissionCheck.ReadWriteSubTree,
                            RegistryRights.FullControl) != null)
                        {
                            Registry.ClassesRoot.DeleteSubKeyTree(GetProgID + @"\OpenWithList");
                            RegistryKey key = Registry.ClassesRoot.CreateSubKey(GetProgID + @"\OpenWithList",
                                RegistryKeyPermissionCheck.ReadWriteSubTree);

                            foreach (string file in value.List)
                            {
                                key.CreateSubKey(file);
                            }

                            key.Close();
                        }
                        else
                        {
                            throw new Exception("T扩展程序的程序使用可执行的关联密钥打开不存在,请使用 Create（）函数设置所有内容...");
                        }
                    }
                    else
                    {
                        throw new Exception("扩展关联键不存在,请使用 Create（）函数设置所有内容...");
                    }
                }
                else
                {
                    throw new Exception("您的关联键之一不存在，请使用创建方法开始...");
                }
            }
        }

        /// <summary>
        /// Deletes all registry resources used for this file associations.
        /// </summary>
        public void Delete()
        {
            if (this.Exists)
            {
                if (Registry.ClassesRoot.OpenSubKey(Extension,
                    RegistryKeyPermissionCheck.ReadWriteSubTree,
                    RegistryRights.FullControl) != null)
                {
                    try
                    {
                        Registry.ClassesRoot.DeleteSubKeyTree(GetProgID);
                        Registry.ClassesRoot.DeleteSubKeyTree(Extension);
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("无法删除文件中使用的所有密钥'" + Extension + "'文件关联出错: " + ex.Message);
                    }
                }
            }
            else
            {
                throw new Exception("您的关联键之一不存在，请使用创建方法开始...");
            }
        }
    }
}