using System;
using System.Collections.Generic;

namespace ShareX.IndexerLib
{
    public class IndexerOutputFactory
    {
        public IndexerOutputFactory()
        {
            // default initialization of the factory
            AddOutputType(IndexerOutputEnum.Txt, typeof(PrintIndexerText));
            AddOutputType(IndexerOutputEnum.Xml, typeof(PrintIndexerXml));
            AddOutputType(IndexerOutputEnum.Html, typeof(PrintIndexerHtml));
        }

        private Dictionary<IndexerOutputEnum, Type> _indexer_output_container = new Dictionary<IndexerOutputEnum, Type>();

        public bool AddOutputType(IndexerOutputEnum output_id, Type output_type)
        {
            if (_indexer_output_container.ContainsKey(output_id))
                return false;

            _indexer_output_container.Add(output_id, output_type);
            return true;
        }

        public PrintIndexerOutput CreateIndexerOutput(IndexerOutputEnum output_id)
        {
            if (!_indexer_output_container.ContainsKey(output_id))
                return null;

            object indexer_output = Activator.CreateInstance(_indexer_output_container[output_id]);
            return (PrintIndexerOutput)indexer_output;
        }
        
    }
}
