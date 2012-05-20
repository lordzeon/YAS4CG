using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using YAS4CG.Model;

namespace YAS4CG
{
    public class MainWindowViewModel
    {
        public Dictionary<string, Rulebook> Rulebooks { get; set; }

        public void LoadRulebooks()
        {
           
            //XmlDocument xmlFile = new XmlDocument();
            //xmlFile.Load(@"C:\Users\Skynet2\YAS4CG\YAS4CG\Rulebooks\SR4A.xml");

            AttributeLoader.LoadAttributes(@"C:\Users\Skynet2\YAS4CG\YAS4CG\Rulebooks\Attributes.xml");

            RulebookLoader.LoadRulebook(@"C:\Users\Skynet2\YAS4CG\YAS4CG\Rulebooks\SR4A.xml");
        }

    }
}
