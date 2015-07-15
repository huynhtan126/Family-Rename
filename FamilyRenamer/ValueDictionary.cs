using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOM.RevitTools.FamilyRenamer
{
    class ValueDictionary
    {

        public Dictionary<string, string> GetRenameFamilies()
        {
            Dictionary<String, String> lookupFamilyNames = 
                new Dictionary<string, string>(StringComparer.Ordinal);

            //lookupFamilyNames.Add("", "");
            lookupFamilyNames.Add("051200 - AISC Wide Flange Shapes - Section", "00 - WIDE FLANGE");
            lookupFamilyNames.Add("051200 - AISC Angle Shape - Section", "00 - ANGLE");
            lookupFamilyNames.Add("051200 - AISC WT Shapes - Section", "00 - WT");

            return lookupFamilyNames;
        }

        
    }
}
