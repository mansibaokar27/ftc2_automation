﻿using FTC.Framework.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace FTC.Framework.Broswer
{
  public  class Browsers
    {

        public String SelectBrowser(String browserToSelect, String fileName)
        {
           try
            {
                string configDir = AppDomain.CurrentDomain.BaseDirectory + "\\Browser\\" + fileName;

                // This is to load the config.xml file
                XmlTextReader reader = new XmlTextReader(configDir);
                XmlDocument doc = new XmlDocument();
                doc.Load(reader);

                // Move the control to 'Configuration' node.
                XmlNode parentNode = doc.SelectSingleNode("browsers");

                // get the list of 'Project' node.
                XmlNode browser = parentNode.SelectSingleNode(browserToSelect);

                String selectedBrowser = browser.InnerText.Trim();

                reader.Close();
                reader.Dispose();

                return selectedBrowser;
                
            }
            catch (Exception e)
            {
                Logger.log.Error(e);
                return null;
            }
        }


     

    }
}
