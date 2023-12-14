using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

using R5T.T0132;


namespace R5T.S0080
{
    [FunctionalityMarker]
    public partial interface IProjectXElementOperator : IFunctionalityMarker,
        L0032.IProjectXElementOperator
    {
        public XElement In_NewProjectXElementContext(
            IEnumerable<Action<XElement>> projectXElementActions)
        {
            var projectXElement = this.New_ProjectXElement();

            Instances.ActionOperator.Run_Actions(
                projectXElement,
                projectXElementActions);

            return projectXElement;
        }

        public XElement In_NewProjectXElementContext(
            params Action<XElement>[] projectXElementActions)
        {
            var output = this.In_NewProjectXElementContext(
                projectXElementActions.AsEnumerable());

            return output;
        }
    }
}
