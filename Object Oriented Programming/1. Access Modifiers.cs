using Common;
using System.Reflection.Emit;
using System.Runtime.Intrinsics.X86;
namespace Main
{

internal class Program
    {
        static void Main(string[] args)
        {
            #region Access Modifiers

            #region Common Access Modifiers 
            /// 1. Private  :Accessible only within the same class. (Default for class members)
            /// 2. Internal :Accessible only within the same assembly/project.
            /// 3. Public   :Accessible from anywhere in the project or other projects referencing it.
            /// 4. protected:Accessible within the same class and derived classes.
            /// 5. protected internal : 	Accessible within the same assembly OR any derived class.
            /// 6. private protected :Accessible only within the same class OR derived class in same assembly.
            /// ------Summary------
            /// Use public when others should access it.
            /// Use private to hide implementation details.
            /// Use protected for inheritance scenarios.
            /// Use internal for project-level access.
            /// Combine as needed for more specific control.



            #endregion

            #region What You Can Write Inside Namespace ?
            /// 1. Class
            /// 2. Struck [stands for Structure]
            /// 3. Interface
            /// 4. Enum 
            /// 5. Delegate
            /// 6. Another namespace
            #endregion

            #region What You Can Write Inside Class
            /// 1. Attributes (Fields) --> Member Variables
            /// 2. Properties (Full Property , AutoMatic Property , Indexer)
            /// 3. Functions (Constructor , Getter Setter , Methods)
            /// 4. Events 
            /// 5. Destructors
            /// 6. Delegates
            /// 7. Interfaces
            /// 8. Static members	
            /// 9. Constants
            /// 10. Finalizers
            /// 11. Nested classes/structs
            /// 12. Operator overloads
            #endregion

            #region What You Can Write Inside Struck
            /// 1. Attributes (Fields) --> Member Variables
            /// 2. Properties (Full Property , AutoMatic Property , Indexer)
            /// 3. Functions (Constructor , Getter Setter , Methods)
            /// 4. Events 
            /// 5. Delegates
            /// 6. Interfaces
            /// 7. Static members	
            /// 8. Constants
            /// 9. Nested classes/structs
            /// 10. Operator overloads
            #endregion

            #region What You Can Inside InterFace

            /// 1. Signature For Property
            /// 2. Signature For Method
            /// 3. Indexers
            /// 4. Events
            /// 5. Static methods (C# 8+)	
            /// 6. Default methods (C# 8+)	


            #endregion

            #region Allowed Access Modifiers Inside The Namespace 
            /// 1. Public
            /// 2. Internal [Defualt Access Modifier] 
            #endregion

            #region Allowed Access Modifiers Inside Strucks
            /// 1. Private --> default
            /// 2. Private Protected
            /// 3. Protected
            /// 4. Internal
            /// 5. Internal Protected
            /// 6. Public
            #endregion

            #region Allowed Access Modifiers Inside Class
            /// 1. Private --> default
            /// 2. Private Protected
            /// 3. Protected
            /// 4. Internal
            /// 5. Internal Protected
            /// 6. Public
            #endregion

            #region How to Use Library in Anoter Project 
            /// 1. Make Sure That Class is Public
            /// 2. go to Solution Explorer 
            /// 3. go to main project (Console App)
            /// 4. Right Click on Dependencies
            /// 5. Choose Add Project References
            /// 6. Select The Library and OK
            /// 7. Then Write Using (The Name Of Namespace In The Library)
            #endregion

            #region How to Use Library in The Same Project
            /// 1. Make Sure That Class IS public or Internal 
            /// That's All 
            #endregion



            #endregion









        }
    }
}
