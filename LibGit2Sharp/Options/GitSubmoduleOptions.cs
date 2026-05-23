using System.Runtime.InteropServices;

namespace LibGit2Sharp.Core
{
    [StructLayout(LayoutKind.Sequential)]
    internal struct GitSubmoduleUpdateOptions
    {
        public uint Version;

        public GitCheckoutOptions CheckoutOptions;

        public GitFetchOptions FetchOptions;

        public int AllowFetch;
    }
}
