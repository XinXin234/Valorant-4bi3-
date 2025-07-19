/***

    播放wav文件操作类

    Austin Liu 刘恒辉
    Project Manager and Software Designer

    E-Mail: lzhdim@163.com
    Blog:   http://lzhdim.cnblogs.com
    Date:   2024-01-15 15:18:00

    使用方法：
        在窗体类里使用资源里的音频：
        SoundHelper.PlayResourceSoundInLoop(Properties.Resources.Alert);

***/

namespace Lzhdim.Helper
{
    using System;
    using System.IO;
    using System.Media;
    using System.Runtime.InteropServices;

    internal class SoundHelper
    {
        [Flags]
        private enum SoundFlag : uint
        {
            //SND_SYNC = 0x0000,
            SND_ASYNC = 0x0001,

            //SND_NODEFAULT = 0x0002,
            //SND_MEMORY = 0x0004,
            SND_LOOP = 0x0008,

            //SND_NOSTOP = 0x0010,
            //SND_NOWAIT = 0x00002000,
            //SND_ALIAS = 0x00010000,
            //SND_ALIAS_ID = 0x00110000,
            SND_FILENAME = 0x00020000,

            //SND_RESOURCE = 0x00040004,
            //SND_PURGE = 0x0040,
            //SND_APPLICATION = 0x0080
        }

        internal static void PlayResourceSound(Stream stream)
        {
            if (stream == null) return;
            var player = new SoundPlayer(stream);
            player.Play();
        }

        internal static void PlayResourceSoundInLoop(Stream stream)
        {
            if (stream == null) return;
            var player = new SoundPlayer(stream);
            player.PlayLooping();
        }

        internal static void PlaySound(string pszSound)
        {
            PlaySound(pszSound, UIntPtr.Zero, SoundFlag.SND_FILENAME | SoundFlag.SND_ASYNC);
        }

        internal static void PlaySound(byte[] pszSound)
        {
            PlaySound(pszSound, IntPtr.Zero, SoundFlag.SND_FILENAME | SoundFlag.SND_ASYNC);
        }

        internal static void PlaySoundInLoop(string pszSound)
        {
            PlaySound(pszSound, UIntPtr.Zero, SoundFlag.SND_FILENAME | SoundFlag.SND_ASYNC | SoundFlag.SND_LOOP);
        }

        internal static void PlaySoundInLoop(byte[] pszSound)
        {
            PlaySound(pszSound, IntPtr.Zero, SoundFlag.SND_FILENAME | SoundFlag.SND_ASYNC | SoundFlag.SND_LOOP);
        }

        internal static void StopSound()
        {
            PlaySound(null, UIntPtr.Zero, SoundFlag.SND_ASYNC);
        }

        [DllImport("winmm.dll", CharSet = CharSet.Auto)]
        private static extern bool PlaySound(string pszSound, UIntPtr hmod, SoundFlag fdwSound);

        [DllImport("winmm.dll", CharSet = CharSet.Auto)]
        private static extern bool PlaySound(byte[] pszSound, IntPtr hmod, SoundFlag fdwSound);
    }
}