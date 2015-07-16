using UnityEditor;
using UnityEditor.Callbacks;
using UnityEditor.iOS.Xcode;
using UnityEngine;

[PostProcessBuild]
public class UniTwitterPostProsessBuild{

    // Add Social.framework
    [PostProcessBuild]
    public static void OnPostProcessBuild(BuildTarget buildTarget, string path){
        if (buildTarget == BuildTarget.iOS) {
            string projPath = path + "/Unity-iPhone.xcodeproj/project.pbxproj";
            PBXProject pbxProj = new PBXProject ();
            pbxProj.ReadFromString (System.IO.File.ReadAllText (projPath));
            string target = pbxProj.TargetGuidByName ("Unity-iPhone");
            pbxProj.AddFrameworkToProject (target, "Social.framework", false);

            System.IO.File.WriteAllText (projPath, pbxProj.WriteToString ());
        }
    }

}
