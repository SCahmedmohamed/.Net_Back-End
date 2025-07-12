namespace Main
{

internal class Program
    {
        static void Main(string[] args)
        {
            #region Access Modifiers

            #region Access
            /// 1. Private :
            /// if the class is private you can use it in the same Class only 
            /// 2. Internal :
            /// if the class is internal you can use it in the same Class or Same Project Only
            /// 3. Public :
            /// if the class is Public you can use it every where
            #endregion

            #region What You Can Write Inside Namespace ?
            /// 1. Class
            /// 2. Struck [stands for Structure]
            /// 3. Interface
            /// 4. Enum 
            #endregion

            #region What You Can Write Inside Class Or Struck
            /// 1. Attributes (Fields) --> Member Variables
            /// 2. Properties (Full Property , AutoMatic Property , Indexer)
            /// 3. Functions (Constructor , Getter Setter , Methods)
            /// 4. Events 
            #endregion

            #region What You Can Inside InterFace

            /// 1. Signature For Property
            /// 2. Signature For Method

            #endregion

            #region Allowed Access Modifiers Inside The Namespace 
            /// 1. Public
            /// 2. Internal [Defualt Access Modifier] 
            #endregion

            #region Allowed Access Modifiers Inside Strucks
            /// 1. Private --> default
            /// 2. Internal
            /// 3. Public
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
