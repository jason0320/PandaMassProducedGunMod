using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BepInEx;
using HarmonyLib;

namespace PandaMassProducedGunMod
{
    [BepInPlugin("panda.massproducedgun.mod", "Panda's Mass Produced Gun Mod", "1.0.0.0")]
    public class Mod_PandaMassProducedGunMod : BaseUnityPlugin
    {
        public void OnStartCore()
        {
            string pathToExcelFile = Path.GetDirectoryName(((BaseUnityPlugin)this).Info.Location) + "/MassProducedGun.xlsx";
            SourceManager sources = Core.Instance.sources;
            ModUtil.ImportExcel(pathToExcelFile, "Thing", sources.things);
        }
    }
}
