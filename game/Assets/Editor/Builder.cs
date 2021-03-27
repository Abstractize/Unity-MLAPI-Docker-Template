using UnityEditor;
using UnityEngine;

namespace Builder
{
    public abstract class Builder
    {
        protected static BuildTargetGroup TargetGroup {get; set;}
        protected static BuildTarget Target {get; set;}
        protected static string[]  Scenes {get; set;}
        protected static string PathToDeploy {get; set;} = "Build/";
        protected static string FolderToDeploy {get; set;}
        protected static BuildOptions Options {get; set;}
        protected static void build()
        {
            configure();



            BuildPlayerOptions player = new BuildPlayerOptions();

            player.assetBundleManifestPath = "Packages/manifest.json";
            player.locationPathName = FolderToDeploy;
            player.scenes = Scenes;
            player.target = Target;
            player.targetGroup = TargetGroup;
            player.options = Options;
            
            if(BuildPipeline.IsBuildTargetSupported(TargetGroup, Target))
            {
                Debug.LogAssertion(Target.ToString() + " is Supported.");
                BuildPipeline.BuildPlayer(player);
            }
            else
                Debug.LogError(Target.ToString() + " is NOT Supported.");


        }
        protected static void configure()
        {
            
        }
    }
}
