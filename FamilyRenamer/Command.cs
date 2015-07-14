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
#endregion

namespace SOM.RevitTools.FamilyRenamer
{
    [Transaction(TransactionMode.Manual)]
    public class Command : IExternalCommand
    {
        public Result Execute(
          ExternalCommandData commandData,
          ref string message,
          ElementSet elements)
        {
            UIApplication uiapp = commandData.Application;
            UIDocument uidoc = uiapp.ActiveUIDocument;
            Application app = uiapp.Application;
            Document doc = uidoc.Document;

            ProcessNewTypes(doc);

            return Result.Succeeded;
        }

        public virtual string Name { get; set; }

        public void ProcessNewTypes(Document doc)
        {
            Family familyNames = null;
            FilteredElementCollector collector = new FilteredElementCollector(doc);
            ICollection<Element> collection = collector.OfClass(typeof(Family)).ToElements();
            using (Transaction t = new Transaction(doc))
            {
                t.Start("new name");

                foreach (Element e in collection)
                {
                    familyNames = e as Family;
                    string familyName = familyNames.Name;
                    string origninalFamilyName = "051200 - AISC Wide Flange Shapes - Section";

                    if (familyName == origninalFamilyName)
                    {
                        Name = "NEWname";
                        familyNames.Name = Name;
                    }
                }

                t.Commit();
            }
        }
    }
}
