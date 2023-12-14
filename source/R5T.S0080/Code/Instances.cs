using System;


namespace R5T.S0080
{
    public class Instances :
        L0055.Instances
    {
        public static L0066.IActionOperator ActionOperator => L0066.ActionOperator.Instance;
        public new static Z0046.IFilePaths FilePaths => Z0046.FilePaths.Instance;
        public static L0032.Z000.IOutputTypes OutputTypes => L0032.Z000.OutputTypes.Instance;
        public static IProjectXElementOperator ProjectXElementOperator => S0080.ProjectXElementOperator.Instance;
        public static L0032.IProjectXElementOperations ProjectXElementOperations => L0032.ProjectXElementOperations.Instance;
        public static L0032.F001.IPropertyGroupXElementOperations PropertyGroupXElementOperations => L0032.F001.PropertyGroupXElementOperations.Instance;
        public static Z0057.ITargetFrameworkMonikers TargetFrameworkMonikers => Z0057.TargetFrameworkMonikers.Instance;
        public static L0053.IXElementOperator XElementOperator => L0053.XElementOperator.Instance;
    }
}