using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CP77.CR2W;
using CP77.CR2W.Archive;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WolvenKit.Common;
using StreamExtensions = Catel.IO.StreamExtensions;

namespace CP77.MSTests
{
    [TestClass]
    public class Cr2wWriteTest : GameUnitTest
    {
        [ClassInitialize]
        public static void SetupClass(TestContext context)
        {
            Setup(context);
        }


        #region test methods

        //[TestMethod]
        //public void Test_All_Extensions()
        //{
        //    Test_Extension();
        //}

        [TestMethod]
        public void Write_acousticdata()
        {
            Test_Extension(".acousticdata");
        }

        [TestMethod]
        public void Write_actionanimdb()
        {
            Test_Extension(".actionanimdb");
        }

        [TestMethod]
        public void Write_aiarch()
        {
            Test_Extension(".aiarch");
        }

        [TestMethod]
        public void Write_animgraph()
        {
            Test_Extension(".animgraph");
        }

        [TestMethod]
        public void Write_anims()
        {
            Test_Extension(".anims");
        }

        [TestMethod]
        public void Write_app()
        {
            Test_Extension(".app");
        }

        [TestMethod]
        public void Write_archetypes()
        {
            Test_Extension(".archetypes");
        }

        [TestMethod]
        public void Write_areas()
        {
            Test_Extension(".areas");
        }

        [TestMethod]
        public void Write_audio_metadata()
        {
            Test_Extension(".audio_metadata");
        }

        [TestMethod]
        public void Write_audiovehcurveset()
        {
            Test_Extension(".audiovehcurveset");
        }

        [TestMethod]
        public void Write_behavior()
        {
            Test_Extension(".behavior");
        }

        [TestMethod]
        public void Write_bikecurveset()
        {
            Test_Extension(".bikecurveset");
        }

        [TestMethod]
        public void Write_bin()
        {
            Test_Extension(".bin");
        }

        [TestMethod]
        public void Write_bk2()
        {
            Test_Extension(".bk2");
        }

        [TestMethod]
        public void Write_bnk()
        {
            Test_Extension(".bnk");
        }

        [TestMethod]
        public void Write_camcurveset()
        {
            Test_Extension(".camcurveset");
        }

        [TestMethod]
        public void Write_cfoliage()
        {
            Test_Extension(".cfoliage");
        }

        [TestMethod]
        public void Write_charcustpreset()
        {
            Test_Extension(".charcustpreset");
        }

        [TestMethod]
        public void Write_cminimap()
        {
            Test_Extension(".cminimap");
        }

        [TestMethod]
        public void Write_community()
        {
            Test_Extension(".community");
        }

        [TestMethod]
        public void Write_conversations()
        {
            Test_Extension(".conversations");
        }

        [TestMethod]
        public void Write_cooked_mlsetup()
        {
            Test_Extension(".cooked_mlsetup");
        }

        [TestMethod]
        public void Write_cookedanims()
        {
            Test_Extension(".cookedanims");
        }

        [TestMethod]
        public void Write_cookedapp()
        {
            Test_Extension(".cookedapp");
        }

        [TestMethod]
        public void Write_credits()
        {
            Test_Extension(".credits");
        }

        [TestMethod]
        public void Write_csv()
        {
            Test_Extension(".csv");
        }

        [TestMethod]
        public void Write_cubemap()
        {
            Test_Extension(".cubemap");
        }

        [TestMethod]
        public void Write_curveset()
        {
            Test_Extension(".curveset");
        }

        [TestMethod]
        public void Write_dat()
        {
            Test_Extension(".dat");
        }

        [TestMethod]
        public void Write_devices()
        {
            Test_Extension(".devices");
        }

        [TestMethod]
        public void Write_dtex()
        {
            Test_Extension(".dtex");
        }

        [TestMethod]
        public void Write_effect()
        {
            Test_Extension(".effect");
        }

        [TestMethod]
        public void Write_ent()
        {
            Test_Extension(".ent");
        }

        [TestMethod]
        public void Write_env()
        {
            Test_Extension(".env");
        }

        [TestMethod]
        public void Write_envparam()
        {
            Test_Extension(".envparam");
        }

        [TestMethod]
        public void Write_envprobe()
        {
            Test_Extension(".envprobe");
        }

        [TestMethod]
        public void Write_es()
        {
            Test_Extension(".es");
        }

        [TestMethod]
        public void Write_facialcustom()
        {
            Test_Extension(".facialcustom");
        }

        [TestMethod]
        public void Write_facialsetup()
        {
            Test_Extension(".facialsetup");
        }

        [TestMethod]
        public void Write_fb2tl()
        {
            Test_Extension(".fb2tl");
        }

        [TestMethod]
        public void Write_fnt()
        {
            Test_Extension(".fnt");
        }

        [TestMethod]
        public void Write_folbrush()
        {
            Test_Extension(".folbrush");
        }

        [TestMethod]
        public void Write_foldest()
        {
            Test_Extension(".foldest");
        }

        [TestMethod]
        public void Write_fp()
        {
            Test_Extension(".fp");
        }

        [TestMethod]
        public void Write_gamedef()
        {
            Test_Extension(".gamedef");
        }

        [TestMethod]
        public void Write_garmentlayerparams()
        {
            Test_Extension(".garmentlayerparams");
        }

        [TestMethod]
        public void Write_genericanimdb()
        {
            Test_Extension(".genericanimdb");
        }

        [TestMethod]
        public void Write_geometry_cache()
        {
            Test_Extension(".geometry_cache");
        }

        [TestMethod]
        public void Write_gidata()
        {
            Test_Extension(".gidata");
        }

        [TestMethod]
        public void Write_gradient()
        {
            Test_Extension(".gradient");
        }

        [TestMethod]
        public void Write_hitrepresentation()
        {
            Test_Extension(".hitrepresentation");
        }

        [TestMethod]
        public void Write_hp()
        {
            Test_Extension(".hp");
        }

        [TestMethod]
        public void Write_ies()
        {
            Test_Extension(".ies");
        }

        [TestMethod]
        public void Write_inkanim()
        {
            Test_Extension(".inkanim");
        }

        [TestMethod]
        public void Write_inkatlas()
        {
            Test_Extension(".inkatlas");
        }

        [TestMethod]
        public void Write_inkcharcustomization()
        {
            Test_Extension(".inkcharcustomization");
        }

        [TestMethod]
        public void Write_inkfontfamily()
        {
            Test_Extension(".inkfontfamily");
        }

        [TestMethod]
        public void Write_inkfullscreencomposition()
        {
            Test_Extension(".inkfullscreencomposition");
        }

        [TestMethod]
        public void Write_inkgamesettings()
        {
            Test_Extension(".inkgamesettings");
        }

        [TestMethod]
        public void Write_inkhud()
        {
            Test_Extension(".inkhud");
        }

        [TestMethod]
        public void Write_inklayers()
        {
            Test_Extension(".inklayers");
        }

        [TestMethod]
        public void Write_inkmenu()
        {
            Test_Extension(".inkmenu");
        }

        [TestMethod]
        public void Write_inkshapecollection()
        {
            Test_Extension(".inkshapecollection");
        }

        [TestMethod]
        public void Write_inkstyle()
        {
            Test_Extension(".inkstyle");
        }

        [TestMethod]
        public void Write_inktypography()
        {
            Test_Extension(".inktypography");
        }

        [TestMethod]
        public void Write_inkwidget()
        {
            Test_Extension(".inkwidget");
        }

        [TestMethod]
        public void Write_interaction()
        {
            Test_Extension(".interaction");
        }

        [TestMethod]
        public void Write_journal()
        {
            Test_Extension(".journal");
        }

        [TestMethod]
        public void Write_journaldesc()
        {
            Test_Extension(".journaldesc");
        }

        [TestMethod]
        public void Write_json()
        {
            Test_Extension(".json");
        }

        [TestMethod]
        public void Write_lane_connections()
        {
            Test_Extension(".lane_connections");
        }

        [TestMethod]
        public void Write_lane_polygons()
        {
            Test_Extension(".lane_polygons");
        }

        [TestMethod]
        public void Write_lane_spots()
        {
            Test_Extension(".lane_spots");
        }

        [TestMethod]
        public void Write_lights()
        {
            Test_Extension(".lights");
        }

        [TestMethod]
        public void Write_lipmap()
        {
            Test_Extension(".lipmap");
        }

        [TestMethod]
        public void Write_location()
        {
            Test_Extension(".location");
        }

        [TestMethod]
        public void Write_locopaths()
        {
            Test_Extension(".locopaths");
        }

        [TestMethod]
        public void Write_loot()
        {
            Test_Extension(".loot");
        }

        [TestMethod]
        public void Write_mappins()
        {
            Test_Extension(".mappins");
        }

        [TestMethod]
        public void Write_mesh()
        {
            Test_Extension(".mesh");
        }

        [TestMethod]
        public void Write_mi()
        {
            Test_Extension(".mi");
        }

        [TestMethod]
        public void Write_mlmask()
        {
            Test_Extension(".mlmask");
        }

        [TestMethod]
        public void Write_mlsetup()
        {
            Test_Extension(".mlsetup");
        }

        [TestMethod]
        public void Write_mltemplate()
        {
            Test_Extension(".mltemplate");
        }

        [TestMethod]
        public void Write_morphtarget()
        {
            Test_Extension(".morphtarget");
        }

        [TestMethod]
        public void Write_mt()
        {
            Test_Extension(".mt");
        }

        [TestMethod]
        public void Write_navmesh()
        {
            Test_Extension(".navmesh");
        }

        [TestMethod]
        public void Write_null_areas()
        {
            Test_Extension(".null_areas");
        }

        [TestMethod]
        public void Write_opusinfo()
        {
            Test_Extension(".opusinfo");
        }

        [TestMethod]
        public void Write_opuspak()
        {
            Test_Extension(".opuspak");
        }

        [TestMethod]
        public void Write_particle()
        {
            Test_Extension(".particle");
        }

        [TestMethod]
        public void Write_phys()
        {
            Test_Extension(".phys");
        }

        [TestMethod]
        public void Write_physicalscene()
        {
            Test_Extension(".physicalscene");
        }

        [TestMethod]
        public void Write_physmatlib()
        {
            Test_Extension(".physmatlib");
        }

        [TestMethod]
        public void Write_poimappins()
        {
            Test_Extension(".poimappins");
        }

        [TestMethod]
        public void Write_psrep()
        {
            Test_Extension(".psrep");
        }

        [TestMethod]
        public void Write_quest()
        {
            Test_Extension(".quest");
        }

        [TestMethod]
        public void Write_questphase()
        {
            Test_Extension(".questphase");
        }

        [TestMethod]
        public void Write_regionset()
        {
            Test_Extension(".regionset");
        }

        [TestMethod]
        public void Write_remt()
        {
            Test_Extension(".remt");
        }

        [TestMethod]
        public void Write_reslist()
        {
            Test_Extension(".reslist");
        }

        [TestMethod]
        public void Write_rig()
        {
            Test_Extension(".rig");
        }

        [TestMethod]
        public void Write_scene()
        {
            Test_Extension(".scene");
        }

        [TestMethod]
        public void Write_scenerid()
        {
            Test_Extension(".scenerid");
        }

        [TestMethod]
        public void Write_scenesversions()
        {
            Test_Extension(".scenesversions");
        }

        [TestMethod]
        public void Write_smartobject()
        {
            Test_Extension(".smartobject");
        }

        [TestMethod]
        public void Write_smartobjects()
        {
            Test_Extension(".smartobjects");
        }

        [TestMethod]
        public void Write_sp()
        {
            Test_Extension(".sp");
        }

        [TestMethod]
        public void Write_spatial_representation()
        {
            Test_Extension(".spatial_representation");
        }

        [TestMethod]
        public void Write_streamingquerydata()
        {
            Test_Extension(".streamingquerydata");
        }

        [TestMethod]
        public void Write_streamingsector()
        {
            Test_Extension(".streamingsector");
        }

        [TestMethod]
        public void Write_streamingsector_inplace()
        {
            Test_Extension(".streamingsector_inplace");
        }

        [TestMethod]
        public void Write_streamingworld()
        {
            Test_Extension(".streamingworld");
        }

        [TestMethod]
        public void Write_terrainsetup()
        {
            Test_Extension(".terrainsetup");
        }

        [TestMethod]
        public void Write_texarray()
        {
            Test_Extension(".texarray");
        }

        [TestMethod]
        public void Write_traffic_collisions()
        {
            Test_Extension(".traffic_collisions");
        }

        [TestMethod]
        public void Write_traffic_persistent()
        {
            Test_Extension(".traffic_persistent");
        }

        [TestMethod]
        public void Write_voicetags()
        {
            Test_Extension(".voicetags");
        }

        [TestMethod]
        public void Write_w2mesh()
        {
            Test_Extension(".w2mesh");
        }

        [TestMethod]
        public void Write_w2mi()
        {
            Test_Extension(".w2mi");
        }

        [TestMethod]
        public void Write_wem()
        {
            Test_Extension(".wem");
        }

        [TestMethod]
        public void Write_workspot()
        {
            Test_Extension(".workspot");
        }

        [TestMethod]
        public void Write_xbm()
        {
            Test_Extension(".xbm");
        }

        [TestMethod]
        public void Write_xcube()
        {
            Test_Extension(".xcube");
        }

        #endregion

        private void Test_Extension(string extension)
        {
            var resultDir = Path.Combine(Environment.CurrentDirectory, TestResultsDirectory);
            Directory.CreateDirectory(resultDir);

            // Run Test
            var results = Write_Archive_Items(GroupedFiles[extension]).ToList();

            // Evaluate
            var successCount = results.Count(r => r.Success);

            // Write
            if (WriteToFile)
            {
                if (results.Any(r => !r.Success))
                {
                    var resultPath = Path.Combine(resultDir, $"{extension[1..]}.csv");
                    var csv = TestResultAsCsv(results.Where(r => !r.Success));
                    File.WriteAllText(resultPath, csv);
                }
            }

            // Logging
            int totalCount = GroupedFiles[extension].Count;
            var sb = new StringBuilder();
            sb.AppendLine(
                $"{extension} -> Successful Reads: {successCount} / {totalCount} ({(int)(((double)successCount / (double)totalCount) * 100)}%)");

            bool success = results.All(r => r.Success);


            var logPath = Path.Combine(resultDir, $"logfile_{(string.IsNullOrEmpty(extension) ? string.Empty : $"{extension[1..]}_")}{DateTime.Now:yyyyMMddHHmmss}.log");
            File.WriteAllText(logPath, sb.ToString());
            Console.WriteLine(sb.ToString());

            if (!success)
            {
                var msg = $"Successful Reads: {successCount} / {totalCount}. ";

                Assert.Fail(msg);
            }
        }

        private static IEnumerable<WriteTestResult> Write_Archive_Items(IEnumerable<FileEntry> files)
        {
            var results = new ConcurrentBag<WriteTestResult>();

            //foreach (var file in files)
            Parallel.ForEach(files, file =>
            {
                try
                {
                    if (file.Archive is not Archive ar)
                        return;
                    var (fileBytes, _) = ar.GetFileData(file.NameHash64, false);

                    using var ms = new MemoryStream(fileBytes);
                    using var br = new BinaryReader(ms);

                    var c = new CR2WFile {FileName = file.NameOrHash};
                    var readResult = c.Read(br);

                    switch (readResult)
                    {
                        case EFileReadErrorCodes.NoCr2w:
                            results.Add(new WriteTestResult
                            {
                                FileEntry = file,
                                Success = true,
                                WriteResult = WriteTestResult.WriteResultType.NoCr2W
                            });
                            break;
                        case EFileReadErrorCodes.UnsupportedVersion:
                            results.Add(new WriteTestResult
                            {
                                FileEntry = file,
                                Success = false,
                                WriteResult = WriteTestResult.WriteResultType.UnsupportedVersion,
                                Message = $"Unsupported Version ({c.GetFileHeader().version})"
                            });
                            break;
                        default:
                            
                            var oldst = c.StringDictionary.Values.ToList();
                            var newst = c.GenerateStringtable().Item1.Values.ToList();
                            var compstr = "OLD,NEW";
                            var correctStringTable = oldst.Count == newst.Count;

                            // Stringtable test
                            for (int i = 0; i < Math.Max(oldst.Count, newst.Count); i++)
                            {
                                string str1 = "";
                                string str2 = "";
                                if (i < oldst.Count)
                                    compstr += oldst[i];
                                compstr += ",";
                                if (i < newst.Count)
                                    compstr += newst[i];
                                compstr += "\n";

                                if (str1 != str2)
                                    correctStringTable = false;
                            }

                            // Binary Equal Test
                            var isBinaryEqual = true;

                            using (var wms = new MemoryStream())
                            using (var bw = new BinaryWriter(wms))
                            {
                                c.Write(bw);

                                isBinaryEqual = StreamExtensions.ToByteArray(ms).SequenceEqual(StreamExtensions.ToByteArray(wms));
                            }


                            var res = WriteTestResult.WriteResultType.NoError;
                            var msg = "";
                            if (!correctStringTable)
                            {
                                res |= WriteTestResult.WriteResultType.HasIncorrectStringTable;
                                msg += $"CorrectStringTable: {correctStringTable}";
                            }

                            if (!isBinaryEqual)
                            {
                                res |= WriteTestResult.WriteResultType.IsNotBinaryEqual;
                                msg += $"IsBinaryEqual: {isBinaryEqual}";
                            }

                            

                            results.Add(new WriteTestResult
                            {
                                FileEntry = file,
                                Success = isBinaryEqual && correctStringTable,
                                WriteResult = res,
                                Message = msg,
                                IsNotBinaryEqual = !isBinaryEqual,
                                HasIncorrectStringTable = !correctStringTable
                            });

                            break;
                    }
                }
                catch (Exception e)
                {
                    results.Add(new WriteTestResult
                    {
                        FileEntry = file,
                        Success = false,
                        WriteResult = WriteTestResult.WriteResultType.RuntimeException,
                        ExceptionType = e.GetType(),
                        Message = $"{file.NameOrHash} - {e.Message}"
                    });
                }
            });

            return results;
        }

        private string TestResultAsCsv(IEnumerable<WriteTestResult> results)
        {
            var sb = new StringBuilder();

            sb.AppendLine(
                $"{nameof(FileEntry.NameHash64)}," +
                $"{nameof(FileEntry.FileName)}," +
                $"{nameof(FileEntry.Archive)}," +
                $"{nameof(WriteTestResult)}," +
                $"{nameof(WriteTestResult.Success)}," +
                $"{nameof(WriteTestResult.HasIncorrectStringTable)}," +
                $"{nameof(WriteTestResult.IsNotBinaryEqual)}," +
                $"{nameof(WriteTestResult.ExceptionType)}," +
                $"{nameof(WriteTestResult.Message)}");

            foreach (var r in results)
            {
                sb.AppendLine(
                    $"{r.FileEntry.NameHash64}," +
                    $"{r.FileEntry.FileName}," +
                    $"{Path.GetFileName(r.FileEntry.Archive.ArchiveAbsolutePath)}," +
                    $"{r.WriteResult}," +
                    $"{r.Success}," +
                    $"{r.HasIncorrectStringTable}," +
                    $"{r.IsNotBinaryEqual}," +
                    $"{r.ExceptionType?.FullName}," +
                    $"{r.Message}");
            }

            return sb.ToString();
        }
    }
}