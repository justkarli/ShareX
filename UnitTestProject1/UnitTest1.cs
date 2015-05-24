using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShareX.IndexerLib;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        static private string _current_directory_path = Directory.GetCurrentDirectory();
        private static string _testfolder_name = "/testroot";
        private static string _test_directory_path = Path.Combine(_current_directory_path, _testfolder_name);
        static private FileInfo _testfile_1;
        static private FileInfo _testfile_2;

        [ClassInitialize]
        public static void InitializeIndexerTests(TestContext testcontext)
        {
            var di = Directory.CreateDirectory(_test_directory_path);
            var di_sub1 = di.CreateSubdirectory("sub1");
            var di_sub2 = di.CreateSubdirectory("sub2");

            _testfile_1 = new FileInfo(Path.Combine(di_sub1.FullName, "testFile1.txt"));
            _testfile_2 = new FileInfo(Path.Combine(di_sub1.FullName, "testFile2.txt"));

            if (!File.Exists(_testfile_1.FullName))
            {
                var file_stream = _testfile_1.Create();
                file_stream.Close();
            }

            if (!File.Exists(_testfile_2.FullName))
            {
                var file_stream = _testfile_2.Create();
                file_stream.Close();
            }
        }

        [TestMethod]
        public void TestTotalFolderCountOfIndexer()
        {
            var indexer_settings = new IndexerSettings();
            indexer_settings.Output = IndexerOutput.Txt;

            var indexer = new Indexer(indexer_settings);
            indexer.Index(_test_directory_path);

            Assert.IsTrue(indexer.DirectoryFileInfo.TotalFolderCount == 2);
        }

        [TestMethod]
        public void TestTotalFileCountOfIndexer()
        {
            var indexer_settings = new IndexerSettings();
            indexer_settings.Output = IndexerOutput.Txt;

            var indexer = new Indexer(indexer_settings);
            indexer.Index(_test_directory_path);

            Assert.IsTrue(indexer.DirectoryFileInfo.TotalFileCount == 2);
        }

        [ClassCleanup]
        public static void CleanupIndexerTests()
        {
            if(File.Exists(_testfile_1.FullName))
                _testfile_1.Delete();

            if(File.Exists(_testfile_2.FullName))
                _testfile_2.Delete();

            var di = new DirectoryInfo(_test_directory_path);
            
            if(Directory.Exists(di.FullName))
                di.Delete(true);
        }
    }
}
