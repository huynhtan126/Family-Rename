using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOM.RevitTools.FamilyRenamer
{
    class ValueDictionary
    {
        //TODO move this dictionary to a better data platform such as Excel.
        //Dictionary for renaming the families 
        public Dictionary<string, string> GetRenameFamilies()
        {
            Dictionary<String, String> lookupFamilyNames = 
                new Dictionary<string, string>(StringComparer.Ordinal);
            //Annotation 
            //lookupFamilyNames.Add("", "");
            lookupFamilyNames.Add("Symbol - Blank Leader", "SYMBOL - BLANK LEADER (I SF)");
            lookupFamilyNames.Add("SYMBOL - CALLOUT", "SYMBOL - CALLOUT (I SF)");
            lookupFamilyNames.Add("Symbol - Cell", "SYMBOL - CELL (I SF)");
            lookupFamilyNames.Add("Symbol - Centerline - With Text", "SYMBOL - CENTERLINE - WITH TEXT (I SF)");
            lookupFamilyNames.Add("Symbol - Centerline - Text", "SYMBOL - CENTERLINE (I SF)");
            lookupFamilyNames.Add("Symbol - Connection Brace - Angle", "SYMBOL - CONNECTION BRACE - ANGLE (I SF)");
            lookupFamilyNames.Add("Symbol - Connection Brace - Angle Down", "SYMBOL - CONNECTION BRACE - ANGLE DOWN (I SF)");
            lookupFamilyNames.Add("Symbol - Connection Brace - Angle Up", "SYMBOL - CONNECTION BRACE - ANGLE UP (I SF)");
            lookupFamilyNames.Add("Symbol - Connection Brace - Kicker", "SYMBOL - CONNECTION BRACE - KICKER (I SF)");
            lookupFamilyNames.Add("Symbol - Connection Brace - Parallel", "SYMBOL - CONNECTION BRACE - PARALLEL (I SF)");
            lookupFamilyNames.Add("Symbol - Connection Brace - Parallel - Above", "SYMBOL - CONNECTION BRACE - PARALLEL ABOVE (I SF)");
            lookupFamilyNames.Add("Symbol - Connection Column - Filled Triangle", "SYMBOL - CONNECTION COLUMN - FILLED TRIANGLE (I SF)");
            lookupFamilyNames.Add("Symbol - Connection Column - Plate", "SYMBOL - CONNECTION COLUMN - PLATE (I SF)");
            lookupFamilyNames.Add("Symbol - Connection Column - Shear", "SYMBOL - CONNECTION COLUMN - SHEAR (I SF)");
            lookupFamilyNames.Add("Symbol - Connection Column - Splice Bot", "SYMBOL - CONNECTION COLUMN - SPLICE BOT (I SF)");
            lookupFamilyNames.Add("Symbol - Connection Column - Splice Top", "SYMBOL - CONNECTION COLUMN - SPLICE TOP (I SF)");
            lookupFamilyNames.Add("Symbol - Connection Column - Vertical Plates", "SYMBOL - CONNECTION COLUMN - VERTICAL PLATES (I SF)");
            lookupFamilyNames.Add("Symbol - Connection Framing - Diamond", "SYMBOL - CONNECTION FRAMING - DIAMOND (I SF)");
            lookupFamilyNames.Add("Symbol - Connection Framing - Dot", "SYMBOL - CONNECTION FRAMING - DOT (I SF)");
            lookupFamilyNames.Add("Symbol - Connection Moment - Filled", "SYMBOL - CONNECTION MOMENT - FILLED (I SF)");
            lookupFamilyNames.Add("Symbol - Connection Moment - Not Filled", "SYMBOL - CONNECTION MOMENT - NOT FILLED (I SF)");
            lookupFamilyNames.Add("Symbol - Elevation Mark Body - Circle", "SYMBOL - ELEVATION MARK BODY- CIRCLE");
            lookupFamilyNames.Add("Symbol - Elevation Mark Circle - Upgrade", "SYMBOL - ELEVATION MARK CIRCLE - UPGRADE (I SF)");
            lookupFamilyNames.Add("Symbol - Elevation Mark Pointer - Circle", "SYMBOL - ELEVATION MARK POINTER - CIRCLE (I SF)");
            lookupFamilyNames.Add("Symbol - Graphic - Dot Center", "SYMBOL - GRAPHIC DOT - CENTER (I SF)");
            lookupFamilyNames.Add("Symbol - Grid Head - Circle", "SYMBOL - GRID HEAD - CIRCLE (I SF)");
            lookupFamilyNames.Add("Symbol - Grid Head_HEX", "SYMBOL - GRID HEAD - HEXAGON (I SF)");
            lookupFamilyNames.Add("Symbol - Grid Head - No Bubble", "SYMBOL - GRID HEAD - NO BUBBLE (I SF)");
            lookupFamilyNames.Add("Symbol - Level Head - Target&Elev", "SYMBOL - LEVEL HEAD - TARGET ELEV (I SF)");
            lookupFamilyNames.Add("Symbol - Level Head - Circle", "SYMBOL - LEVEL HEAD (I SF)");
            lookupFamilyNames.Add("Symbol - Line - Extents", "SYMBOL - LINE EXTENTS (I SF)");
            lookupFamilyNames.Add("Symbol - North Arrow", "SYMBOL - NORTH ARROW (I SF)");
            lookupFamilyNames.Add("Symbol - One Way Slab - Mark", "SYMBOL - ONE WAY SLAB - MARK (I SF)");
            lookupFamilyNames.Add("Symbol - Opening for Elev - Text", "SYMBOL - OPENING ELEVATOR - TEXT (I SF)");
            lookupFamilyNames.Add("Symbol - Opening for Stair - Text", "SYMBOL - OPENING STAIRS - TEXT (I SF)");
            lookupFamilyNames.Add("Symbol - Plate - Text", "SYMBOL - PLATE - TEXT (I SF)");
            lookupFamilyNames.Add("Symbol - Rebar Hook Dot - Plan", "SYMBOL - REBAR HOOK DOTS - PLAN (I SF)");
            lookupFamilyNames.Add("Symbol - Revision Tag - Dummy", "SYMBOL - REVISION TAG - DUMMY (I SF)");
            lookupFamilyNames.Add("2D Section Cut", "SYMBOL - SECTION CUT (I SF)");
            lookupFamilyNames.Add("Symbol - Slab Ramp Down", "SYMBOL - SLAB RAMP DOWN (I SF)");
            lookupFamilyNames.Add("Symbol - Slab Ramp Up", "SYMBOL - SLAB RAMP UP (I SF)");
            lookupFamilyNames.Add("Symbol - Slab Step", "SYMBOL - SLAB STEP (I SF)");
            lookupFamilyNames.Add("Symbol - Slab Steps", "SYMBOL - SLAB STEPS (I SF)");
            lookupFamilyNames.Add("Symbol - Tilda", "SYMBOL - TILDA (I SF)");
            lookupFamilyNames.Add("Symbol - Tilde - Arrowhead", "SYMBOL - TILDA -ARROWHEAD (I SF)");
            lookupFamilyNames.Add("Symbol - Tube Break Line", "SYMBOL - TUBE BREAK LINE (I SF)");
            lookupFamilyNames.Add("Symbol - Two Way Slab", "SYMBOL - TWO WAY SLAB - MARK (I SF)");
            lookupFamilyNames.Add("Symbol - View - Reference", "SYMBOL - VIEW - REFERENCE (I SF)");
            lookupFamilyNames.Add("Symbol - View Title - Fake Left", "SYMBOL - VIEW TITLE - MANUAL (I SF)");
            lookupFamilyNames.Add("Symbol - Weld", "SYMBOL - WELD (I SF)");
            lookupFamilyNames.Add("Symbol - Work Point", "SYMBOL - WORK POINT (I SF)");
            lookupFamilyNames.Add("Tag - Column - Schedule", "TAG - COLUMN - SCHEDULE (I SF)");
            lookupFamilyNames.Add("Tag - Exterior - Elevation", "TAG - EXTERIOR - ELEV (I SF)");
            lookupFamilyNames.Add("Tag - Plan - Reinf", "TAG - PLAN - REINF (I SF)");
            lookupFamilyNames.Add("Tag - Plan Reinf - Rotate", "TAG - PLAN REINF - ROTATE (I SF)");
            lookupFamilyNames.Add("Tag - Property Line", "TAG - PROPERTY LINE (I SF)");
            lookupFamilyNames.Add("Tag - P-T Drape", "TAG - P-T DRAPE (I SF)");
            lookupFamilyNames.Add("Tag - Revision", "TAG - REVISION (I SF)");
            lookupFamilyNames.Add("Tag - Span Direction", "TAG - SPAN DIRECTION (I SF)");
            lookupFamilyNames.Add("Tag - Structural Column", "TAG - STRUCTURAL COLUMN (I SF)");
            lookupFamilyNames.Add("Tag - Structural Foundation", "TAG - STRUCTURAL FOUNDATION (I SF)");
            lookupFamilyNames.Add("Tag - Structural Framing - CELL Lengths", "TAG - STRUCTURAL FRAMING - CELL LENGTHS (I SF)");
            lookupFamilyNames.Add("Tag - Structural Framing - Standard", "TAG - STRUCTURAL FRAMING - STANDARD (I SF)");
            lookupFamilyNames.Add("Tag - View Reference - Matchline", "TAG - VIEW REF - MATCHLINE (I SF)");
            lookupFamilyNames.Add("Tag - View Ref - Sheet and Number", "TAG - VIEW REF - SHEET AND NUMBER (I SF)");
            lookupFamilyNames.Add("Tag - Wall", "TAG - WALL (I SF)");
            lookupFamilyNames.Add("Target - Grid Head", "TARGET - GRID HEAD (I SF)");
            lookupFamilyNames.Add("Target - Level Head - Circle", "TARGET - LEVEL HEAD - CIRCLE (I SF)");
            lookupFamilyNames.Add("Target - Level Head - No Bubble", "TARGET - LEVEL HEAD - NO BUBBLE (I SF)");
            lookupFamilyNames.Add("Target - Section Head", "TARGET - SECTION HEAD (I SF)");
            lookupFamilyNames.Add("Target - Section Tail", "TARGET - SECTION TAIL (I SF)");
            lookupFamilyNames.Add("Target - Spot Elevation - Crosshair", "TARGET - SPOT ELEVATION - CROSSHAIR (I SF)");
            lookupFamilyNames.Add("Target - Spot Elevation - Target Filled", "TARGET - SPOT ELEVATION - FILLED (I SF)");
            lookupFamilyNames.Add("Target - Spot Elevation - T", "TARGET - SPOT ELEVATION - T (I SF)");
            lookupFamilyNames.Add("Target - Spot Elevation", "TARGET - SPOT ELEVATION (I SF)");
            lookupFamilyNames.Add("View Reference Cut No Tail", "VIEW - REF CUT - NO TAIL (I SF)");
            lookupFamilyNames.Add("View Reference Cut", "VIEW - REF CUT (I SF)");
            lookupFamilyNames.Add("View Reference ELEVATION", "VIEW - REF ELEVATION (I SF)");
            lookupFamilyNames.Add("SOM-VIEW TITLE", "VIEW - TITLE (I SF)");

            //Detail Items: 
            //lookupFamilyNames.Add("", "");
            lookupFamilyNames.Add("Symbol - Break Line - Single", "00 - BREAK LINE - SINGLE (I SF)");
            lookupFamilyNames.Add("Symbol - Break Line", "00 - BREAK LINE (I SF)");
            lookupFamilyNames.Add("Opening-X", "00 - OPENING X (I SF)");
            lookupFamilyNames.Add("033100 - Concrete Columns Circular - Side", "03 - CONCRETE CIRCULAR - SIDE (I SF)");
            lookupFamilyNames.Add("033100 - Concrete Columns Circular - Top", "03 - CONCRETE CIRCULAR - TOP (I SF)");
            lookupFamilyNames.Add("033100 - Concrete Footing Rectangular - Section", "03 - CONCRETE FOOTING RECTANGLE - SECTION (I SF)");
            lookupFamilyNames.Add("033100 - Concrete Footing Rectangular - Side", "03 - CONCRETE FOOTING RECTANGLE - SIDE (I SF)");
            lookupFamilyNames.Add("033100 - Concrete Footing Rectangular - Top", "03 - CONCRETE FOOTING RECTANGLE - TOP");
            lookupFamilyNames.Add("033100 - Concrete Beams - Side", "03 - CONCRETE RECTANGLE  - SIDE (I SF)");
            lookupFamilyNames.Add("033100 - Concrete Beams - Top", "03 - CONCRETE RECTANGLE  - TOP (I SF)");
            lookupFamilyNames.Add("033100 - Concrete Beams - Section", "03 - CONCRETE RECTANGLE - SECTION (I SF)");
            lookupFamilyNames.Add("035300 - Concrete Topping Slabs - Section", "03 - CONCRETE TOPPING SLAB - SECTION (I SF)");
            lookupFamilyNames.Add("Symbol - Construction Joint", "03 - CONSTRUCTION JOINT (I SF)");
            lookupFamilyNames.Add("Symbol - Post Tension - Dot", "03 - POST TENSION - DOT (I SF)");
            lookupFamilyNames.Add("Symbol - Post Tension", "03 - POST TENSION - GRAPHIC (I SF)");
            lookupFamilyNames.Add("Symbol - Post Tension - 2 Stressing ends", "03 - POST TENSION 2 STRESS ENDS - GRAPHIC (I SF)");
            lookupFamilyNames.Add("Symbol - Construction Joint - Masking", "03- CONSTRUCTION JOINT - MASK (I SF)");
            lookupFamilyNames.Add("042200 - Bond Beams Double - Section", "04 - BOND BEAM DOUBLE - SECTION (I SF)");
            lookupFamilyNames.Add("042200 - Bond Beams Double - Side", "04 - BOND BEAM DOUBLE - SIDE (I SF)");
            lookupFamilyNames.Add("042200 - Bond Beams Double - Top", "04 - BOND BEAM DOUBLE - TOP (I SF)");
            lookupFamilyNames.Add("042200 - Bond Beams-Single - Section", "04 - BOND BEAM SINGLE - SECTION (I SF)");
            lookupFamilyNames.Add("042200 - Bond Beams-Single - Side", "04 - BOND BEAM SINGLE - SIDE (I SF)");
            lookupFamilyNames.Add("042200 - CMU Standard", "04 - CMU STANDARD (I SF)");
            lookupFamilyNames.Add("050523 - Anchor Bolts Hook - Side", "05 - ANCHOR BOLT HOOK - SIDE (I SF)");
            lookupFamilyNames.Add("051200 - AISC Angle Shape - Section", "05 - ANGLE - SECTION (I SF)");
            lookupFamilyNames.Add("051200 - AISC Angle Shape - Side", "05 - ANGLE - SIDE (I SF)");
            lookupFamilyNames.Add("Symbol - Bolt", "05 - BOLT - TOP (I SF)");
            lookupFamilyNames.Add("050523 - Bolt A307 - Side", "05 - BOLT A307 - SIDE (I SF)");
            lookupFamilyNames.Add("050523 - Bolt A307 - Side - Transparante", "05 - BOLT A307 - TRANSPARANTE - SIDE (I SF)");
            lookupFamilyNames.Add("051200 - AISC Channel Shapes-Section", "05 - CHANNEL SECTION (I SF)");
            lookupFamilyNames.Add("053100 - Composite Decking - Section", "05 - COMPOSITE DECK - SECTION (I SF)");
            lookupFamilyNames.Add("053100 - Composite Decking - Side", "05 - COMPOSITE DECK - SIDE (I SF)");
            lookupFamilyNames.Add("050523 - Expansion Bolts - Side", "05 - EXPANSION BOLT - SIDE (I SF)");
            lookupFamilyNames.Add("Symbol - Headed Anchor Stud", "05 - HEADED ANCHOR STUD - SIDE (I SF)");
            lookupFamilyNames.Add("051200 - AISC HP Shapes - Section", "05 - HP - SECTION (I SF)");
            lookupFamilyNames.Add("051200 - AISC HP Shapes - Side", "05 - HP - SIDE (I SF)");
            lookupFamilyNames.Add("051200 - AISC HP Shapes - Top", "05 - HP - TOP (I SF)");
            lookupFamilyNames.Add("AISC Round Tube Shapes-Section", "05 - HSS ROUND - SECTION (I SF)");
            lookupFamilyNames.Add("051200 - AISC Tube Shapes - Section", "05 - HSS TUBE - SECTION (I SF)");
            lookupFamilyNames.Add("051200 - AISC Tube Shapes - Side", "05 - HSS TUBE - SIDE (I SF)");
            lookupFamilyNames.Add("051200 - AISC Tube Shapes - Top", "05 - HSS TUBE - TOP (I SF)");
            lookupFamilyNames.Add("051200 - L Angle - Bolted Connection - Elevation", "05 - L ANGLE - BOLTED CONNECTION - ELEV (I SF)");
            lookupFamilyNames.Add("052100 - LH Series Bar Joist - Section", "05 - LH SERIES BAR JOIST - SECTION (I SF)");
            lookupFamilyNames.Add("052100 - LH Series Bar Joist - Side", "05 - LH SERIES BAR JOIST - SIDE (I SF)");
            lookupFamilyNames.Add("052100 - LH Series Bar Joist - Top", "05 - LH SERIES BAR JOIST - TOP (I SF)");
            lookupFamilyNames.Add("051200 - L Angle - Bolted Connection - Section", "05 - LL ANGLE - BOLTED CONNECTION - ELEV (I SF)");
            lookupFamilyNames.Add("053100 - Non-Composite Decking - Section", "05 - NON-COMPOSITE DECK - SECTION (I SF)");
            lookupFamilyNames.Add("053100 - Non-Composite Decking-Side", "05 - NON-COMPOSITE DECK - SIDE (I SF)");
            lookupFamilyNames.Add("053100 - Roof Decking - Section", "05 - ROOF DECKING - SECTION (I SF)");
            lookupFamilyNames.Add("Symbol - Slotted Bolt", "05 - SLOTTED BOLT - TOP (I SF)");
            lookupFamilyNames.Add("050523 - Steel Base Plate - Side - Length", "05 - STEEL PLATE - SIDE (I SF)");
            lookupFamilyNames.Add("050523 - Steel Base Plate - Top", "05 - STEEL PLATE - TOP (I SF)");
            lookupFamilyNames.Add("050523 - Steel Plate - Plain Side - Length", "05 - STEEL PLATE PLAIN - SIDE (I SF)");
            lookupFamilyNames.Add("050523 - Steel Plate - Plain Side - Top", "05 - STEEL PLATE PLIAN - TOP (I SF)");
            lookupFamilyNames.Add("050523 - Steel Shear Plate - Face", "05 - STEEL SHEAR PLATE - FACE (I SF)");
            lookupFamilyNames.Add("050523 - Steel Shear Plate - Section", "05 - STEEL SHEAR PLATE - SECTION (I SF)");
            lookupFamilyNames.Add("050523 - Carriage Bolts - Head", "05 - STUD HEAD - TOP (I SF)");
            lookupFamilyNames.Add("Symbol - VERCO Metal Deck", "05 - VERCO METAL DECK - SECTION (I SF)");
            lookupFamilyNames.Add("051200 - AISC Wide Flange Shapes - Section", "05 - WIDE FLANGE - SECTION (I SF)");
            lookupFamilyNames.Add("051200 - AISC Wide Flange Shapes - Side", "05 - WIDE FLANGE - SIDE (I SF)");
            lookupFamilyNames.Add("051200 - AISC Wide Flange Shapes - Top", "05 - WIDE FLANGE - TOP (I SF)");
            lookupFamilyNames.Add("051200 - AISC WT Shapes - Section", "05 - WT - SECTION (I SF)");
            lookupFamilyNames.Add("051200 - AISC WT Shapes - Side", "05 - WT - SIDE (I SF)");
            lookupFamilyNames.Add("051200 - AISC WT Shapes - Top", "05 - WT - TOP (I SF)");

            return lookupFamilyNames;
        }

        
    }
}
