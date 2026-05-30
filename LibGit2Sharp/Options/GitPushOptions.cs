using System.Runtime.InteropServices;

namespace LibGit2Sharp.Core;

[StructLayout(LayoutKind.Sequential)]
internal struct GitPushOptions
{
    public int Version;
    public int PackbuilderDegreeOfParallelism;
    public GitRemoteCallbacks RemoteCallbacks;
    public GitProxyOptions ProxyOptions;
    public RemoteRedirectMode FollowRedirects;
    public GitStrArrayManaged CustomHeaders;
    public GitStrArrayManaged remote_push_options;

    public GitPushOptions()
    {
        Version = 1;
        PackbuilderDegreeOfParallelism = 0;
        RemoteCallbacks = default;
        ProxyOptions = new GitProxyOptions();
        FollowRedirects = RemoteRedirectMode.Initial;
        CustomHeaders = default;
        remote_push_options = default;
    }
}
