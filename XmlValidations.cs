using System;
using System.Xml;
using System.Xml.Schema;

namespace XmlValidations
{
    class XmlValidations
    {
        public static void ValidateWithXSD(string xmlFile, string schemaFile)
        {
            try {
                XmlDocument xmlDoc = new XmlDocument();
                XmlTextReader schemaReader = new XmlTextReader(@schemaFile);
                XmlSchema schema = XmlSchema.Read(schemaReader, SchemaValidationHandler);

                xmlDoc.Schemas.Add(schema);            
                xmlDoc.Load(@xmlFile);
                xmlDoc.Validate(DocumentValidationHandler);
            }
            catch(System.IO.FileNotFoundException fnf) 
            {
                Console.WriteLine(fnf.GetBaseException().ToString());
            }
            catch(Exception e)
            {
                Console.WriteLine(e.GetBaseException().ToString());
            }
        }

        private static void SchemaValidationHandler(object sender, ValidationEventArgs e)
        {
            System.Console.WriteLine(e.Message);
        }

        private static void DocumentValidationHandler(object sender, ValidationEventArgs e)
        {
            System.Console.WriteLine(e.Message);
        }
    }
}