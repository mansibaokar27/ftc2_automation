using System;
using System.Xml;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Reflection;
using System.IO;
using System.Diagnostics;
using FTC.Framework.Utils;


namespace FTC.Framework.Configuration
{
    public class Config
    {
        public static String ReadConfigFile(String projectName, String ModuleName, String key, String fileName)
        {
            XmlTextReader reader = null;
            String requiredData = null;

            try
            {
                string configDir = AppDomain.CurrentDomain.BaseDirectory + "\\Configuration\\" + fileName;

                // This is to load the config.xml file

                reader = new XmlTextReader(configDir);
                XmlDocument doc = new XmlDocument();
                doc.Load(reader);

                // Move the control to 'Configuration' node.
                XmlNode node = doc.SelectSingleNode("configuration");

                // get the list of 'Project' node.
                XmlNodeList projectNodeList = node.SelectNodes("Project");

                //Iterating through Project node
                foreach (XmlNode tempNode in projectNodeList)
                {
                    //get the value of 'name' attribute of current project node
                    String attribute = tempNode.Attributes["name"].Value;

                    //checking whether the current Project node is the required node
                    if (attribute.Equals(projectName))
                    {

                        // get all the child node of Project
                        XmlNodeList moduleNodeList = tempNode.ChildNodes;

                        //Iterating through Child node of project node
                        foreach (XmlNode tempModuleNode in moduleNodeList)
                        {
                            String attributeOfModuleNode = tempModuleNode.Attributes["name"].Value;

                            if (attributeOfModuleNode.Equals(ModuleName))
                            {
                                XmlNodeList elemnetNodeList = tempModuleNode.ChildNodes;

                                foreach (XmlNode tempElementNode in elemnetNodeList)
                                {
                                    String eleAttribute = tempElementNode.Attributes["key"].Value;
                                    if (eleAttribute.Equals(key))
                                    {
                                        requiredData = tempElementNode.InnerText;
                                        break;
                                    }
                                }

                            }

                        }


                    }

                }

            }
            catch (Exception e)
            {
                Logger.log.Error("Config.xml is not properly organized.");
                Logger.log.Error(e);
                return null;
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                    reader.Dispose();
                }
            }

             return requiredData;
        }

    }
}
