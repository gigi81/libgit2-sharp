using System;
using System.Runtime.InteropServices;

namespace LibGit2Sharp.Core
{
    [StructLayout(LayoutKind.Sequential)]
    internal class GitRebaseOptions
    {
        public uint version = 1;

        public int quiet;

        public int inmemory;

        public IntPtr rewrite_notes_ref;

        public GitMergeOptions merge_options = new GitMergeOptions { Version = 1 };

        public GitCheckoutOptions checkout_options = new GitCheckoutOptions { version = 1 };

        private IntPtr padding; // TODO: add git_commit_create_cb

        public NativeMethods.commit_signing_callback signing_callback;
    }
}
