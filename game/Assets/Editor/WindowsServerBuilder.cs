using UnityEditor;

namespace Builder
{
    public sealed class WindowsServerBuilder : Builder 
    { 
        new static void configure()
        {
            TargetGroup = BuildTargetGroup.Standalone;
            Target = BuildTarget.StandaloneWindows64;
            Scenes = new string[]{
                "Assets/Scenes/SampleScene.unity"
            };
            FolderToDeploy = "WindowsServer/GameServer.exe";
            Options = BuildOptions.EnableHeadlessMode;
        }
        [MenuItem("Build/Windows Server")]
        new static void build()
        {
            configure();

            BuildPlayerOptions player = new BuildPlayerOptions();

            player.assetBundleManifestPath = "Packages/manifest.json";
            player.locationPathName = PathToDeploy + "/" + FolderToDeploy;
            player.scenes = Scenes;
            player.target = Target;
            player.targetGroup = TargetGroup;
            player.options = Options;

            BuildPipeline.BuildPlayer(player);
        }
    }
}
