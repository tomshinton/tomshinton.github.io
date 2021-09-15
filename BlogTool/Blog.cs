using System;
using System.Collections.Generic;
using System.IO;

using System.IO.Compression;
using System.Windows.Forms;

namespace BlogTool
{
    public class Blog
    {
        public delegate void OnTempBlogCreatedDelegate(string s);
        public OnTempBlogCreatedDelegate OnTempBlogCreated;

        public static bool RemoveStylesheet = true;

        public string BlogName;
        public string StylesheetDir;
        public string ScriptDir;

        public string BlogTemplateLocation = Path.Combine(Path.Combine(Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory)), "BlogTemplate.zip");

        private string WorkingDirectory = Path.Combine(Path.GetTempPath(), "BlogTool");
        private string LivingBlogFile;
        public Blog(string InBlogName)
        {
            BlogName = InBlogName;
            WorkingDirectory = Path.Combine(WorkingDirectory, BlogName, "Assets", "Content", "Blog");
        }

        public void StartDesigning()
        {
            try
            {
                ZipFile.ExtractToDirectory(BlogTemplateLocation, WorkingDirectory);
                string[] FilesInWorkingDirectory = Directory.GetFiles(WorkingDirectory);

                //Initially we should only have 1 file in the working directory - 
                if (FilesInWorkingDirectory.Length == 1)
                {
                    Console.WriteLine("Found " + FilesInWorkingDirectory.Length + " files in working directory - processing");
                    LivingBlogFile = FilesInWorkingDirectory[0];

                    CopyAssets();

                    if(OnTempBlogCreated != null)
                    {
                        OnTempBlogCreated.Invoke(LivingBlogFile);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Could not create temporary blog from template");
            }
        }

        private void CopyAssets()
        {
            //Find all stylesheet dependancies 
            List<string> Lines = new List<string>(File.ReadAllLines(LivingBlogFile));

            bool RequiresStyling = false;
            bool RequiresScripts = false;

            foreach(string Line in Lines)
            {
                if(Line.Contains("stylesheet"))
                {
                    RequiresStyling = true;
                }

                if(Line.Contains("script"))
                {
                    RequiresScripts = true;
                }
            }

            if (RequiresStyling)
            {
                Console.WriteLine("Template has styling applied - grabbing source styles");

                if (Directory.Exists(StylesheetDir))
                {
                    string TargetDir = Path.Combine(Path.GetTempPath(), "BlogTool", BlogName, "Assets", "css");
                    Directory.CreateDirectory(TargetDir);

                    string[] Files = System.IO.Directory.GetFiles(StylesheetDir);
                    foreach (string File in Files)
                    {
                        string FileName = Path.GetFileName(File);
                        string DestFile = Path.Combine(TargetDir, FileName);

                        //Fully qualify callspace to get around foreach loop naming
                        System.IO.File.Copy(File, DestFile);
                    }
                }
            }

            if(RequiresScripts)
            {
                Console.WriteLine("Template has scripts enabled - grabbing source scripts");

                if (Directory.Exists(ScriptDir))
                {
                    string TargetDir = Path.Combine(Path.GetTempPath(), "BlogTool", BlogName, "Assets", "scripts");
                    Directory.CreateDirectory(TargetDir);

                    string[] Files = System.IO.Directory.GetFiles(ScriptDir);
                    foreach (string File in Files)
                    {
                        string FileName = Path.GetFileName(File);
                        string DestFile = Path.Combine(TargetDir, FileName);

                        //Fully qualify callspace to get around foreach loop naming
                        System.IO.File.Copy(File, DestFile);
                    }
                }
            }
        }
    }
}
