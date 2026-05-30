using System;

namespace LibGit2Sharp.Core;

/// <summary>
/// Git fetch options wrapper. Disposable wrapper for GitFetchOptions
/// </summary>
internal class GitFetchOptionsWrapper : IDisposable
{
    private GitFetchOptions options;

    public GitFetchOptionsWrapper() : this(new GitFetchOptions()) { }

    public GitFetchOptionsWrapper(GitFetchOptions fetchOptions)
    {
        options = fetchOptions;
    }

    public ref GitFetchOptions Options => ref options;

    #region IDisposable
    private bool disposedValue = false; // To detect redundant calls
    protected virtual void Dispose(bool disposing)
    {
        if (disposedValue)
            return;

        options.CustomHeaders.Dispose();
        EncodingMarshaler.Cleanup(options.ProxyOptions.Url);
        disposedValue = true;
    }

    public void Dispose()
    {
        Dispose(true);
    }
    #endregion
}