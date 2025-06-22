using ICSharpCode.SharpZipLib.Zip;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COM3D2_CustomEventEditor
{
    public class EditorFileManager
    {
        internal const string WORKSPACE_DIR_PATH = "workspace";
        public const string DEFINITION_FILE_NAME = "def.json";
        public const string STEPS_FILE_NAME = "steps.json";


        public static void Save(string outputPath)
        {
            //create workspace directory if needed
            CreateDirectory(WORKSPACE_DIR_PATH);

            //scan through all the steps to identify the custom files needed and remove those not necessary.
            CleanseWorkspaceDirectory();

            //write a def.json to the workspace
            string scnDef = JsonConvert.SerializeObject(Global.ScenarioDefinition, Formatting.Indented, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            });
            WriteFile(WORKSPACE_DIR_PATH + "/" + DEFINITION_FILE_NAME, scnDef);

            //write steps.json 
            Dictionary<string, ADVStep> dictSteps = new Dictionary<string, ADVStep>();
            foreach(var stepItem in Global.AllSteps)
            {
                if (stepItem.StepData != null)
                    if (!dictSteps.ContainsKey(stepItem.StepData.ID))
                        dictSteps.Add(stepItem.StepData.ID, stepItem.StepData);
            }
            string stepsInJson = JsonConvert.SerializeObject(dictSteps, Formatting.Indented, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            });
            WriteFile(WORKSPACE_DIR_PATH + "/" + STEPS_FILE_NAME, stepsInJson);

            //zip the file and output to the path selected
            WriteZipFile(outputPath, WORKSPACE_DIR_PATH);
        }

        //True: Load successful; False: Otherwise
        internal static bool Load(string filePath, out Dictionary<string, ADVStep> loadedSteps)
        {
            loadedSteps = null;
            //open the zip file
            using (var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                try
                {
                    Dictionary<string, ADVStep> steps;
                    ScenarioDefinition scnDef;

                    using (var zipFile = new ZipFile(fileStream))
                    {
                        //load the steps.json
                        var zipEntrySteps = zipFile.GetEntry(STEPS_FILE_NAME);
                        if (zipEntrySteps == null)
                        {
                            //Incorrect format
                            throw new Exception();
                        }

                        using (var s = zipFile.GetInputStream(zipEntrySteps))
                        {
                            StreamReader reader = new StreamReader(s, System.Text.Encoding.UTF8);
                            string fileContent = reader.ReadToEnd();

                            loadedSteps = JsonConvert.DeserializeObject<Dictionary<string, ADVStep>>(fileContent);
                        }

                        //load the def.json
                        var zipEntryDef = zipFile.GetEntry(DEFINITION_FILE_NAME);
                        if (zipEntryDef == null)
                        {
                            //Incorrect format
                            throw new Exception();
                        }

                        using (var s = zipFile.GetInputStream(zipEntryDef))
                        {
                            StreamReader reader = new StreamReader(s, System.Text.Encoding.UTF8);
                            string fileContent = reader.ReadToEnd();

                            scnDef = JsonConvert.DeserializeObject<ScenarioDefinition>(fileContent);
                        }

                        /* At this stage all items are ok, proceed to replace the current memory by the content loaded */

                        ClearFilesFromDirectory(WORKSPACE_DIR_PATH);

                        //convert the data into memory                      
                        Global.ScenarioDefinition = scnDef;

                        fileStream.Position = 0;
                        Decompress(fileStream, WORKSPACE_DIR_PATH);

                        return true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Util.GetResourcesString("OpenFileErrorIncorrectFormat"));
                    return false;
                }
            }
        }

        // Method to decompress files from a ZIP file
        static void Decompress(Stream stream, string extractPath)
        {
            using (var zipInputStream = new ZipInputStream(stream))
            {
                ZipEntry entry;
                // Read entries from the ZIP archive
                while ((entry = zipInputStream.GetNextEntry()) != null)
                {
                    string entryPath = Path.Combine(extractPath, entry.Name);
                    // Process files
                    if (entry.IsFile)
                    {
                        string directoryName = Path.GetDirectoryName(entryPath);
                        if (!Directory.Exists(directoryName))
                            Directory.CreateDirectory(directoryName);
                        using (var fileStream = File.Create(entryPath))
                        {
                            // Buffer for reading entries
                            byte[] buffer = new byte[4096];
                            int bytesRead;
                            // Read from ZIP stream and write to file
                            while ((bytesRead = zipInputStream.Read(buffer, 0, buffer.Length)) > 0)
                            {
                                fileStream.Write(buffer, 0, bytesRead);
                            }
                        }
                    }
                    else if (entry.IsDirectory) // Process directories
                    {
                        Directory.CreateDirectory(entryPath);
                    }
                }
            }
        }

        private static void WriteFile(string filePath, string content)
        {
            if (File.Exists(filePath))
                File.Delete(filePath);

            File.Create(filePath).Close(); 
            using (StreamWriter sw = File.AppendText(filePath))
            {
                sw.WriteLine(content); 
            }
        }

        private static void WriteZipFile(string outputFilePath, string directoryToZip)
        {
            string[] filenames = Directory.GetFiles(directoryToZip);

            using (ZipOutputStream s = new ZipOutputStream(File.Create(outputFilePath)))
            {

                s.SetLevel(9); 

                byte[] buffer = new byte[4096];

                foreach (string file in filenames)
                {
                    var entry = new ZipEntry(Path.GetFileName(file));

                    entry.DateTime = DateTime.Now;
                    s.PutNextEntry(entry);
                    var bytes = File.ReadAllBytes(file);
                    s.Write(bytes, 0, bytes.Length);
                }

                s.Finish();
                s.Close();
            }
        }

        public static void CreateDirectory(string path)
        {
            try
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
            }
            catch (Exception)
            {

            }
        }

        public static void ClearFilesFromDirectory(string path)
        {
            try
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                var files = Directory.GetFiles(path);
                foreach(var file in files)
                    File.Delete(file);
            }
            catch (Exception)
            {

            }
        }

        public static void CopyFileToWorkSpace(string filePath, string fileName)
        {
            if (!File.Exists(filePath))
                return;

            //create workspace directory if needed
            CreateDirectory(WORKSPACE_DIR_PATH);

            File.Copy(filePath, WORKSPACE_DIR_PATH + "/" + fileName , true);
        }

        public static void CleanseWorkspaceDirectory()
        {
            List<string> fileInUsed = new List<string>();

            foreach (var step in Global.AllSteps)
            {
                if (step.StepData.Type == Constant.ADVType.CharaInit)
                {
                    var customList = step.StepData.CharaInitData?.NPCFemale?.Where(x => x.Type == ADVStep.CharaInit.NPCFemaleData.NPCType.Custom).ToList();
                    if (customList != null)
                    {
                        foreach (var npc in customList)
                        {
                            if (!string.IsNullOrEmpty(npc.CustomData?.PresetFile?.V2))
                                fileInUsed.Add(npc.CustomData?.PresetFile?.V2);
                            if (!string.IsNullOrEmpty(npc.CustomData?.PresetFile?.V2_5))
                                fileInUsed.Add(npc.CustomData?.PresetFile?.V2_5);
                        }
                    }

                }
            }



            try
            {
                var files = Directory.GetFiles(WORKSPACE_DIR_PATH);
                foreach (var file in files)
                {
                    if (!fileInUsed.Contains( Path.GetFileName(file)))
                        File.Delete(file);
                }
                    
            }
            catch (Exception)
            {

            }

        }
    }
}
