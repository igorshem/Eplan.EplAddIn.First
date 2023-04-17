using Eplan.EplApi.ApplicationFramework;
using System.Windows.Forms;

namespace Eplan.EplAddin.First_v0003.API
{
    class IgorshemAction : IEplAction
    {
        public string newAction = "IgorshemAction";

        public bool Execute(ActionCallingContext oActionCallingContext)
        {
            IgorshemForm form = new IgorshemForm();
            form.ShowDialog();
            return true;
        }

        public void GetActionProperties(ref ActionProperties actionProperties)
        {
            //throw new System.NotImplementedException();
        }

        public bool OnRegister(ref string Name, ref int Ordinal)
        {
            Name = newAction;
            Ordinal = 20;
            return true;
        }
    }
}
