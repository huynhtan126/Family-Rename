#region Namespaces
using System;
using System.Collections.Generic;
using System.Diagnostics;
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;

using System;
using System.Reflection;
using System.IO;
using System.Windows.Forms;
#endregion

namespace SOM.RevitTools.FamilyRenamer
{
    class changeFamilyNames
    {
        public virtual string Name { get; set; }
        int count;

        public void changeFamiliesNames(Document doc)
        {
            //Gets the families
            Family familyNames = null;
            FilteredElementCollector collector = new FilteredElementCollector(doc);
            ICollection<Element> collection = collector.OfClass(typeof(Family)).ToElements();

            ValueDictionary dictionaryList = new ValueDictionary();
            var dictionary = dictionaryList.GetRenameFamilies();

            using (Transaction t = new Transaction(doc))
            {
                t.Start("new name");

                foreach (Element e in collection)
                {
                    familyNames = e as Family;
                    string familyName = familyNames.Name;

                    //Checks the dictionary and if found renames the family
                    if (dictionary.ContainsKey(familyName))
                    {
                        string value = dictionary[familyName];
                        familyNames.Name = value;
                        count++;
                    }
                }
                t.Commit();
                string message = "Number of Families Renamed: ";
                MessageBox.Show(message + count.ToString());
            }
        }
    }
}
