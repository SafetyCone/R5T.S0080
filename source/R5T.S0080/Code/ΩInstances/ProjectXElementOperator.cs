using System;


namespace R5T.S0080
{
    public class ProjectXElementOperator : IProjectXElementOperator
    {
        #region Infrastructure

        public static IProjectXElementOperator Instance { get; } = new ProjectXElementOperator();


        private ProjectXElementOperator()
        {
        }

        #endregion
    }
}
