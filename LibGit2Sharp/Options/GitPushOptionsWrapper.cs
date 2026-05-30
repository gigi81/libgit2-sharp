using System;

namespace LibGit2Sharp.Core
{
    /// <summary>
    /// Git push options wrapper. Disposable wrapper for <see cref="GitPushOptions"/>.
    /// </summary>
    internal class GitPushOptionsWrapper : IDisposable
    {
        private GitPushOptions options;

        public GitPushOptionsWrapper() : this(new GitPushOptions()) { }

        public GitPushOptionsWrapper(GitPushOptions pushOptions)
        {
            options = pushOptions;
        }

        public ref GitPushOptions Options => ref options;

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
}
