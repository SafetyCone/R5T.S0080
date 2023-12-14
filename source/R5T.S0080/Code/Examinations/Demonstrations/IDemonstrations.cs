using System;

using R5T.T0141;


namespace R5T.S0080
{
    [DemonstrationsMarker]
    public partial interface IDemonstrations : IDemonstrationsMarker
    {
        public void In_ProjectXElementContext()
        {
            /// Input.
            var projectFilePath = Instances.FilePaths._Platform.Sample_ProjectFilePath;


            /// Run.
            var projectElement = Instances.ProjectXElementOperator.In_NewProjectXElementContext(
                Instances.ProjectXElementOperations.Set_SDK_NET,
                Instances.ProjectXElementOperations.In_NewPropertyGroupXElementContext(
                    Instances.PropertyGroupXElementOperations.Set_OutputType(Instances.OutputTypes.Exe),
                    Instances.PropertyGroupXElementOperations.Set_TargetFramework(Instances.TargetFrameworkMonikers.NET_8),
                    Instances.PropertyGroupXElementOperations.Enable_ImplicitUsings,
                    Instances.PropertyGroupXElementOperations.Enable_Nullable
                )
            );

            //Instances.XElementOperator.To_File_Indented_Synchronous(
            //    projectFilePath,
            //    projectElement);

            Instances.ProjectXElementOperator.To_File_Separated_Synchronous(
                projectFilePath,
                projectElement);

            Instances.NotepadPlusPlusOperator.Open(
                projectFilePath);
        }

        /// <summary>
        /// The starting point for all project element operations is a new, empty, project element (XElement).
        /// </summary>
        public void Create_EmptyProjectXElement()
        {
            /// Input.
            var projectFilePath = Instances.FilePaths._Platform.Sample_ProjectFilePath;


            /// Run.
            var projectElement = Instances.ProjectXElementOperator.New_ProjectXElement();

            Instances.XElementOperator.To_File_AsIs_Synchronous(
                projectFilePath,
                projectElement);

            Instances.NotepadPlusPlusOperator.Open(
                projectFilePath);
        }
    }
}
