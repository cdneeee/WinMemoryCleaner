using System;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

namespace WinMemoryCleaner
{
    /// <summary>
    /// Constants
    /// </summary>
    public static class Constants
    {
        public static class App
        {
            public const int AutoOptimizationMemoryUsageInterval = 5; // Minute
            public const string EmbeddedResourcePath = "WinMemoryCleaner.Resources.";
            public const string EmbeddedResourcePathExtension = ".json";
            public const string Id = "C7F29A45-8B3E-4D2F-9A1C-5E7B2D4F8C6A";
            public const string KeyFile = "WinMemoryCleaner.snk";
            public const string License = "GPL-3.0";
            public const string LocalizationResourcePath = EmbeddedResourcePath + "Localization.";
            public const string Name = "WinMemoryCleaner";
            public const string Shortcut = "Windows Memory Cleaner.lnk";
            public const string ThemesResourcePath = EmbeddedResourcePath + "Themes.";
            public const string Title = "Windows Memory Cleaner";
            public const string VersionFormat = "{0}.{1}.{2}";

            public static class Author
            {
                public const string Name = "Igor Mundstein";
            }

            public static class Certificate
            {
                public static class Release
                {
                    public const string Thumbprint = "9D201FB199626ABE7DA32FBE47013FC023670F9B";
                }

                public static class Test
                {
                    public const string Thumbprint = "2187092935C12F90727B29AD6913A7F89817B942";
                }
            }

            public static class CommandLineArgument
            {
                public const string Install = "Install";
                public const string Reset = "Reset";
                public const string Service = "Service";
                public const string Startup = "Startup";
                public const string Uninstall = "Uninstall";
            }

            public static class Defaults
            {
                public static readonly string Path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            }

            public static class Registry
            {
                public static class Key
                {
                    public const string ProcessExclusionList = @"SOFTWARE\WinMemoryCleaner\ProcessExclusionList";
                    public const string Settings = @"SOFTWARE\WinMemoryCleaner";
                }
            }

        }

        public static class Windows
        {
            public static class Console
            {
                public const int AttachParentProcess = -1; // ATTACH_PARENT_PROCESS
                public const int StdOutputHandle = -11; // STD_OUTPUT_HANDLE
            }

            public static class DesktopWindowManager
            {
                public static class Attribute
                {
                    public const int BorderColor = 34;
                    public const int WindowCornerPreference = 33;
                }

                public static class Value
                {
                    public const int WindowCornerPreferenceRound = 2;
                }
            }

            public static class Drive
            {
                public const int FsctlDiscardVolumeCache = 589828; // 0x00090054 - FSCTL_DISCARD_VOLUME_CACHE
                public const int IoControlResetWriteOrder = 589832; // 0x000900F8 - FSCTL_RESET_WRITE_ORDER
            }

            public static class File
            {
                public const int FlagsNoBuffering = 536870912; // 0x20000000 - FILE_FLAG_NO_BUFFERING
            }

            public static class Keyboard
            {
                public const int WmHotkey = 786; // 0x312
            }

            public static class Locale
            {
                public static class Name
                {
                    public const string English = "en";
                    public const string PortugueseBrazil = "pt-BR";
                    public const string PortuguesePortugal = "pt-PT";
                    public const string SimplifiedChinese = "zh-Hans";
                    public const string TraditionalChinese = "zh-Hant";
                }
            }

            public static class Privilege
            {
                public const string SeDebugName = "SeDebugPrivilege"; // Required to debug and adjust the memory of a process owned by another account. User Right: Debug programs.
                public const string SeIncreaseQuotaName = "SeIncreaseQuotaPrivilege"; // Required to increase the quota assigned to a process. User Right: Adjust memory quotas for a process.
                public const string SeProfSingleProcessName = "SeProfileSingleProcessPrivilege"; // Required to gather profiling information for a single process. User Right: Profile single process.
            }

            public static class PrivilegeAttribute
            {
                public const int Enabled = 2;
            }

            public static class ShowWindow
            {
                public const int Restore = 9; // SW_RESTORE
            }

            public static class SystemErrorCode
            {
                public const int ErrorAccessDenied = 5; // (ERROR_ACCESS_DENIED) Access is denied
                public const int ErrorSuccess = 0; // (ERROR_SUCCESS) The operation completed successfully
            }

            public static class SystemInformationClass
            {
                public const int SystemCombinePhysicalMemoryInformation = 130; // 0x82
                public const int SystemFileCacheInformation = 21; // 0x15
                public const int SystemMemoryListInformation = 80; // 0x50
                public const int SystemRegistryReconciliationInformation = 155; // 0x9B
            }

            public static class SystemMemoryListCommand
            {
                public const int MemoryEmptyWorkingSets = 2;
                public const int MemoryFlushModifiedList = 3;
                public const int MemoryPurgeLowPriorityStandbyList = 5;
                public const int MemoryPurgeStandbyList = 4;
            }
        }
    }
}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
