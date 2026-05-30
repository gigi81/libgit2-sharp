using System.Runtime.InteropServices;

namespace LibGit2Sharp.Core;

[StructLayout(LayoutKind.Sequential)]
internal struct GitFetchOptions
{
    public int Version;
    public GitRemoteCallbacks RemoteCallbacks;
    public FetchPruneStrategy Prune;
    public bool UpdateFetchHead;
    public TagFetchMode download_tags;
    public GitProxyOptions ProxyOptions;
    public int Depth;
    public RemoteRedirectMode FollowRedirects;
    public GitStrArrayManaged CustomHeaders;

    public GitFetchOptions()
    {
        Version = 1;
        RemoteCallbacks = default;
        Prune = default;
        UpdateFetchHead = true;
        download_tags = default;
        ProxyOptions = new GitProxyOptions();
        Depth = 0;
        FollowRedirects = RemoteRedirectMode.Initial;
        CustomHeaders = default;
    }
}
