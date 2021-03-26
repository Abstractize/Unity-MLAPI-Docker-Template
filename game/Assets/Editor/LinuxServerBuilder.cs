using UnityEditor;
using UnityEngine;

namespace Builder
{
    public sealed class LinuxServerBuilder : Builder 
    { 
        new static void configure()
        {
            TargetGroup = BuildTargetGroup.Standalone;
            Target = BuildTarget.StandaloneLinux64;
            Scenes = new string[]{
                "Assets/Scenes/SampleScene.unity"
            };
            FolderToDeploy = "Server/GameServer";
            Options = BuildOptions.EnableHeadlessMode;
        }
        [MenuItem("Build/Linux Server")]
        new static void build()
        {
            configure();

            BuildPlayerOptions player = new BuildPlayerOptions();

            player.assetBundleManifestPath = "Packages/manifest.json";
            player.locationPathName = PathToDeploy + FolderToDeploy;
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
    }
}
