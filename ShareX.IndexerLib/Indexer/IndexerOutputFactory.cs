using System;
using System.Collections.Generic;

namespace ShareX.IndexerLib
{
    public class IndexerOutputFactory
    {
        private static IndexerOutputFactory _singleton_factory;

        public static IndexerOutputFactory Instance
        {
            get
            {
                if (_singleton_factory == null)
                    _singleton_factory = new IndexerOutputFactory();

                return _singleton_factory;
            }
        }

        private IndexerOutputFactory()
        {
            // default initialization of the factory
            RegisterIndexerOutput(IndexerOutputEnum.Txt, typeof(PrintIndexerText));
            RegisterIndexerOutput(IndexerOutputEnum.Xml, typeof(PrintIndexerXml));
            RegisterIndexerOutput(IndexerOutputEnum.Html, typeof(PrintIndexerHtml));
        }

        public bool RegisterIndexerOutput(IndexerOutputEnum output_id, Type output_type)
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

        private Dictionary<IndexerOutputEnum, Type> _indexer_output_container = new Dictionary<IndexerOutputEnum, Type>();
    }
}
