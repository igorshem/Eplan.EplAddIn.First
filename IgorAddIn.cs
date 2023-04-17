using Eplan.EplApi.ApplicationFramework;

namespace Eplan.EplAddin.First_v0003.API
{
    public class IgorshemAPI : IEplAddIn
    {
        public string newTab = "TestTab";
        public string newGroup = "TestGroup";
        public string newItem = "Start";
        public string newAction = "IgorshemAction";

        public bool OnExit()
        {
            return true;
        }

        public bool OnInit()
        {
            return true;
        }

        public bool OnInitGui()
        {
            return true;
        }

        public bool OnRegister(ref bool bLoadOnStart)
        {
            bLoadOnStart = true;
            var myTab = new Eplan.EplApi.Gui.RibbonBar().AddTab(newTab);
            var commandGroup = myTab.AddCommandGroup(newGroup);
            commandGroup.AddCommand(newItem, newAction, 76);
            return true;
        }

        public bool OnUnregister()
        {
            var ribbonBar = new Eplan.EplApi.Gui.RibbonBar();
            ribbonBar.RemoveCommand(newAction);
            ribbonBar.GetTab(newTab).GetCommandGroup(newGroup).Remove();
            ribbonBar.GetTab(newTab).Remove();
            return true;
        }
    }
}
