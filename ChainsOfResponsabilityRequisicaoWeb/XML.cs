using System.Data;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Serialization;

namespace ChainsOfResponsabilityRequisicaoWeb
{
    internal class XML : IResposta
    {
        public IResposta Proximo { get; set; }

        public string Converte(Requisicao requisicao, Conta conta)
        {
            if(requisicao.Formato == Formato.XML)
            {
                using (StringWriter stringWriter = new StringWriter())
                {
                    XmlWriterSettings settings = new XmlWriterSettings();
                    settings.Indent = true;
                    settings.OmitXmlDeclaration = true;

                    XmlSerializer serializer = new XmlSerializer(typeof(Conta));

                    using (XmlWriter xmlWriter = XmlWriter.Create(stringWriter, settings))
                    {
                        serializer.Serialize(xmlWriter, conta);
                    }

                    return stringWriter.ToString();
                }
            }

            return Proximo.Converte(requisicao, conta);
        }
    }
}