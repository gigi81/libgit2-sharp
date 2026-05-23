using System;
using System.Runtime.InteropServices;

namespace LibGit2Sharp.Core
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    internal delegate int stash_apply_progress_cb(StashApplyProgress progress, IntPtr payload);

    [StructLayout(LayoutKind.Sequential)]
    internal class GitStashApplyOptions
    {
        public uint Version = 1;

        public StashApplyModifiers Flags;
        public GitCheckoutOptions CheckoutOptions;

        public stash_apply_progress_cb ApplyProgressCallback;
        public IntPtr ProgressPayload;
    }
}
