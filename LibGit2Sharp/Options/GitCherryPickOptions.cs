using System.Runtime.InteropServices;

namespace LibGit2Sharp.Core
{
    [StructLayout(LayoutKind.Sequential)]
    internal class GitCherryPickOptions
    {
        public uint Version = 1;

        // For merge commits, the "mainline" is treated as the parent
        public uint Mainline = 0;

        public GitMergeOptions MergeOptions = new GitMergeOptions { Version = 1 };

        public GitCheckoutOptions CheckoutOptions = new GitCheckoutOptions { version = 1 };
    }
}
