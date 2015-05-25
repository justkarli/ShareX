using System;

namespace ShareX.IndexerLib
{
    public class IndexerOutputStrategy
    {
        public IndexerOutputStrategy(Indexer indexer, PrintIndexerOutput output_strategy)
        {
            Indexer = indexer;
            _indexer_output_formatter = output_strategy;
        }

        public string ExecuteIndexerOutputStrategy(string folder_path)
        {
            if (_indexer_output_formatter == null)
                throw new Exception("No output strategy set");

            Indexer.Index(folder_path);
            return _indexer_output_formatter.PrintFolderInfo(Indexer);
        }

        public Indexer Indexer { get; private set; }
        private PrintIndexerOutput _indexer_output_formatter;
    }
}
