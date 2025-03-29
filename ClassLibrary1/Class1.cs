using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.UI;
using Autodesk.Revit.DB;
using System.Windows.Forms;
using Autodesk.Revit.UI.Selection;

namespace A003_SelectEdge
{
    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit
    .Attributes.TransactionMode.Manual)]
    public class Class1 : IExternalCommand
    {
        public Result Execute(ExternalCommandData
        commandData, ref string message, ElementSet elements)
        {
            UIDocument uidoc = commandData.Application.ActiveUIDocument;
            IList<Reference> referenceCollection = uidoc.Selection.PickObjects(ObjectType.Edge);

            MessageBox.Show("You have selected total" + referenceCollection.Count.ToString()+ "Edges.");
            return Result.Succeeded;
        }
    }
}