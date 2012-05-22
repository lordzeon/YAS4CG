using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        public ObservableCollection<Quality> Qualities { get; set; }

        public Dictionary<string, Rulebook> Rulebooks { get; set; }

        public Character character { get; set; }

        public MainWindowViewModel()
        {
            LoadRulebooks();
        }

        public void LoadRulebooks()
        {
            //XmlDocument xmlFile = new XmlDocument();
            //xmlFile.Load(@"C:\Users\Skynet2\YAS4CG\YAS4CG\Rulebooks\SR4A.xml");
            Rulebooks = new Dictionary<string, Rulebook>();
            Qualities = new ObservableCollection<Quality>();

            AttributeLoader.LoadAttributes(@"Rulebooks\Attributes.xml");

            Rulebooks.Add("SR4A", RulebookLoader.LoadRulebook(@"Rulebooks\SR4A.xml"));

            foreach (string item in Rulebooks["SR4A"].Qualities.Keys)
            {
                Qualities.Add(Rulebooks["SR4A"].Qualities[item]);
            }
        }

        public void CreateNewCharacter()
        {
            character = new Character();
        }
    }
}