using UnityEditor;
using UnityEngine;

namespace ShellIntegration.Editor
{
    public static class ShellIntegration
    {
        [MenuItem("Assets/Open Shell")]
        public static void OpenGitBash()
        {
            var settings = Resources.Load("ShellIntegrationSettings") as ShellIntegrationSettings;
            if (settings == null)
            {
                Debug.LogError("Shell Integration Settings is not exist.");
                return;
            }

            Application.OpenURL(settings.ShellPath);
        }
    }
}