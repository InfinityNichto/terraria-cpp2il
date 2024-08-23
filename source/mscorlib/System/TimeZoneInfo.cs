using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x0200004D RID: 77
	[global::System.Runtime.CompilerServices.TypeForwardedFrom("System.Core, Version=2.0.5.0, Culture=Neutral, PublicKeyToken=7cec85d7bea7798e")]
	[global::Cpp2ILInjected.Token(Token = "0x200006A")]
	[global::System.Serializable]
	public sealed class TimeZoneInfo : global::System.IEquatable<global::System.TimeZoneInfo>, global::System.Runtime.Serialization.ISerializable, global::System.Runtime.Serialization.IDeserializationCallback
	{
		// Token: 0x060002A6 RID: 678 RVA: 0x00014D77 File Offset: 0x00012F77
		[global::Cpp2ILInjected.Token(Token = "0x6000302")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BA82D0", Offset = "0x1BA82D0", Length = "0x3C4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "GetTimeZoneFromTzData", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(string)
		}, ReturnType = typeof(global::System.TimeZoneInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "TZif_ParseRaw", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(ref global::System.TimeZoneInfo.TZifHead),
			typeof(ref global::System.DateTime[]),
			typeof(ref byte[]),
			typeof(ref global::System.TimeZoneInfo.TZifType[]),
			typeof(ref string),
			typeof(ref bool[]),
			typeof(ref bool[]),
			typeof(ref string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "get_UtcNow", ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "op_LessThanOrEqual", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.DateTime)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "TZif_GetZoneAbbreviation", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeSpan), Member = "get_Hours", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeSpan), Member = "get_Minutes", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeSpan), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "TZif_GenerateAdjustmentRules", MemberParameters = new object[]
		{
			typeof(ref global::System.TimeZoneInfo.AdjustmentRule[]),
			typeof(global::System.TimeSpan),
			typeof(global::System.DateTime[]),
			typeof(byte[]),
			typeof(global::System.TimeZoneInfo.TZifType[]),
			typeof(bool[]),
			typeof(bool[]),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "ValidateTimeZoneInfo", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.TimeSpan),
			typeof(global::System.TimeZoneInfo.AdjustmentRule[]),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		private TimeZoneInfo(byte[] data, string id, bool dstDisabled)
		{
			throw null;
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x00014D7A File Offset: 0x00012F7A
		[global::Cpp2ILInjected.Token(Token = "0x6000303")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BA8FB4", Offset = "0x1BA8FB4", Length = "0x3B4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.CurrentSystemTimeZone), Member = "CreateDaylightChanges", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(global::System.Globalization.DaylightTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "get_Kind", ReturnType = typeof(global::System.DateTimeKind))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "get_Ticks", ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(long),
			typeof(global::System.DateTimeKind)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "get_Hour", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "get_Minute", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "get_Second", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "get_Month", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "get_Day", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo.TransitionTime), Member = "ValidateTransitionTime", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(global::System.DayOfWeek)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "get_Date", ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo.AdjustmentRule), Member = "CreateAdjustmentRule", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.DateTime),
			typeof(global::System.TimeSpan),
			typeof(global::System.TimeZoneInfo.TransitionTime),
			typeof(global::System.TimeZoneInfo.TransitionTime)
		}, ReturnType = typeof(global::System.TimeZoneInfo.AdjustmentRule))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public global::System.TimeZoneInfo.AdjustmentRule[] GetAdjustmentRules()
		{
			throw null;
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x00014D7D File Offset: 0x00012F7D
		[global::Cpp2ILInjected.Token(Token = "0x6000304")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BA94D0", Offset = "0x1BA94D0", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo.CachedData), Member = "CreateLocal", ReturnType = typeof(global::System.TimeZoneInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static global::System.TimeZoneInfo GetLocalTimeZone(global::System.TimeZoneInfo.CachedData cachedData)
		{
			throw null;
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x00014D80 File Offset: 0x00012F80
		[global::Cpp2ILInjected.Token(Token = "0x6000305")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BA9680", Offset = "0x1BA9680", Length = "0x1B0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "GetLocalTimeZoneFromTzFile", ReturnType = typeof(global::System.TimeZoneInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "GetTzEnvironmentVariable", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "GetTimeZoneDirectory", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.Path), Member = "Combine", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "TryLoadTzFile", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref byte[]),
			typeof(ref string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		private static bool TryGetLocalTzFile(out byte[] rawData, out string id)
		{
			throw null;
		}

		// Token: 0x060002AA RID: 682 RVA: 0x00014D83 File Offset: 0x00012F83
		[global::Cpp2ILInjected.Token(Token = "0x6000306")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BA9830", Offset = "0x1BA9830", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "TryGetLocalTzFile", MemberParameters = new object[]
		{
			typeof(ref byte[]),
			typeof(ref string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetEnvironmentVariable", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private static string GetTzEnvironmentVariable()
		{
			throw null;
		}

		// Token: 0x060002AB RID: 683 RVA: 0x00014D86 File Offset: 0x00012F86
		[global::Cpp2ILInjected.Token(Token = "0x6000307")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BA98C0", Offset = "0x1BA98C0", Length = "0x190")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "TryGetLocalTzFile", MemberParameters = new object[]
		{
			typeof(ref byte[]),
			typeof(ref string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.File), Member = "Exists", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.File), Member = "ReadAllBytes", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "FindTimeZoneIdUsingReadLink", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "FindTimeZoneId", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		private static bool TryLoadTzFile(string tzFilePath, ref byte[] rawData, ref string id)
		{
			throw null;
		}

		// Token: 0x060002AC RID: 684 RVA: 0x00014D89 File Offset: 0x00012F89
		[global::Cpp2ILInjected.Token(Token = "0x6000308")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BA9B9C", Offset = "0x1BA9B9C", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "TryLoadTzFile", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref byte[]),
			typeof(ref string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Interop.Sys), Member = "ReadLink", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.Path), Member = "Combine", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "GetTimeZoneDirectory", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.StringComparison)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private static string FindTimeZoneIdUsingReadLink(string tzFilePath)
		{
			throw null;
		}

		// Token: 0x060002AD RID: 685 RVA: 0x00014D8C File Offset: 0x00012F8C
		[global::Cpp2ILInjected.Token(Token = "0x6000309")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BA9F00", Offset = "0x1BA9F00", Length = "0x18C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "EnumerateFilesRecursively", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Predicate<string>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Interop.Sys.DirectoryEntry), Member = "GetName", MemberParameters = new object[] { typeof(global::System.Span<char>) }, ReturnType = typeof(global::System.ReadOnlySpan<char>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.Path), Member = "Join", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private static string GetDirectoryEntryFullPath(ref global::Interop.Sys.DirectoryEntry dirent, string currentPath)
		{
			throw null;
		}

		// Token: 0x060002AE RID: 686 RVA: 0x00014D8F File Offset: 0x00012F8F
		[global::Cpp2ILInjected.Token(Token = "0x600030A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BAA08C", Offset = "0x1BAA08C", Length = "0x5B8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "FindTimeZoneId", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Interop.Sys), Member = "GetReadDirRBufferSize", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Interop.Sys), Member = "OpenDir", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IntPtr), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Interop.Sys), Member = "ReadDirR", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(byte*),
			typeof(int),
			typeof(ref global::Interop.Sys.DirectoryEntry)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "GetDirectoryEntryFullPath", MemberParameters = new object[]
		{
			typeof(ref global::Interop.Sys.DirectoryEntry),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Interop.Sys), Member = "Stat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref global::Interop.Sys.FileStatus)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IntPtr), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Interop.Sys), Member = "CloseDir", MemberParameters = new object[] { typeof(global::System.IntPtr) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>), Member = "RemoveAt", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Interop.Sys), Member = "GetLastErrorInfo", ReturnType = typeof(global::Interop.ErrorInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Interop), Member = "GetExceptionForIoErrno", MemberParameters = new object[]
		{
			typeof(global::Interop.ErrorInfo),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 43)]
		private unsafe static void EnumerateFilesRecursively(string path, global::System.Predicate<string> condition)
		{
			throw null;
		}

		// Token: 0x060002AF RID: 687 RVA: 0x00014D92 File Offset: 0x00012F92
		[global::Cpp2ILInjected.Token(Token = "0x600030B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BA9C9C", Offset = "0x1BA9C9C", Length = "0x264")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "TryLoadTzFile", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref byte[]),
			typeof(ref string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "GetTimeZoneDirectory", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.Path), Member = "Combine", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Predicate<object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "EnumerateFilesRecursively", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Predicate<string>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 28)]
		private static string FindTimeZoneId(byte[] rawData)
		{
			throw null;
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x00014D95 File Offset: 0x00012F95
		[global::Cpp2ILInjected.Token(Token = "0x600030C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BAA64C", Offset = "0x1BAA64C", Length = "0x34C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo.<>c__DisplayClass16_0), Member = "<FindTimeZoneId>b__0", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.FileStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IO.FileMode),
			typeof(global::System.IO.FileAccess),
			typeof(global::System.IO.FileShare),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.Error), Member = "GetEndOfFile", ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 24)]
		private static bool CompareTimeZoneFile(string filePath, byte[] buffer, byte[] rawData)
		{
			throw null;
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x00014D98 File Offset: 0x00012F98
		[global::Cpp2ILInjected.Token(Token = "0x600030D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BA951C", Offset = "0x1BA951C", Length = "0x164")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "TryGetLocalTzFile", MemberParameters = new object[]
		{
			typeof(ref byte[]),
			typeof(ref string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "GetTimeZoneFromTzData", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(string)
		}, ReturnType = typeof(global::System.TimeZoneInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "CreateLocalUnity", ReturnType = typeof(global::System.TimeZoneInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		private static global::System.TimeZoneInfo GetLocalTimeZoneFromTzFile()
		{
			throw null;
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x00014D9B File Offset: 0x00012F9B
		[global::Cpp2ILInjected.Token(Token = "0x600030E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BAA998", Offset = "0x1BAA998", Length = "0x1A8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "GetLocalTimeZoneFromTzFile", ReturnType = typeof(global::System.TimeZoneInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 23)]
		private static global::System.TimeZoneInfo GetTimeZoneFromTzData(byte[] rawData, string id)
		{
			throw null;
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x00014D9E File Offset: 0x00012F9E
		[global::Cpp2ILInjected.Token(Token = "0x600030F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BA9A50", Offset = "0x1BA9A50", Length = "0x14C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "TryGetLocalTzFile", MemberParameters = new object[]
		{
			typeof(ref byte[]),
			typeof(ref string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "FindTimeZoneIdUsingReadLink", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "FindTimeZoneId", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetEnvironmentVariable", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "EndsWith", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private static string GetTimeZoneDirectory()
		{
			throw null;
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x00014DA1 File Offset: 0x00012FA1
		[global::Cpp2ILInjected.Token(Token = "0x6000310")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BAB000", Offset = "0x1BAB000", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTime), Member = "get_Now", ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "get_Local", ReturnType = typeof(global::System.TimeZoneInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "GetUtcOffsetFromUtc", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeZoneInfo),
			typeof(ref bool),
			typeof(ref bool)
		}, ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static global::System.TimeSpan GetDateTimeNowUtcOffsetFromUtc(global::System.DateTime time, out bool isAmbiguousLocalDst)
		{
			throw null;
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x00014DA4 File Offset: 0x00012FA4
		[global::Cpp2ILInjected.Token(Token = "0x6000311")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BA8B68", Offset = "0x1BA8B68", Length = "0x140")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "TZif_GenerateAdjustmentRule", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(global::System.TimeSpan),
			typeof(global::System.Collections.Generic.List<global::System.TimeZoneInfo.AdjustmentRule>),
			typeof(global::System.DateTime[]),
			typeof(byte[]),
			typeof(global::System.TimeZoneInfo.TZifType[]),
			typeof(bool[]),
			typeof(bool[]),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>), Member = "ToArray", ReturnType = "T[]")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private static void TZif_GenerateAdjustmentRules(out global::System.TimeZoneInfo.AdjustmentRule[] rules, global::System.TimeSpan baseUtcOffset, global::System.DateTime[] dts, byte[] typeOfLocalTime, global::System.TimeZoneInfo.TZifType[] transitionType, bool[] StandardTime, bool[] GmtTime, string futureTransitionsPosixFormat)
		{
			throw null;
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x00014DA7 File Offset: 0x00012FA7
		[global::Cpp2ILInjected.Token(Token = "0x6000312")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BAB3B8", Offset = "0x1BAB3B8", Length = "0x670")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "TZif_GenerateAdjustmentRules", MemberParameters = new object[]
		{
			typeof(ref global::System.TimeZoneInfo.AdjustmentRule[]),
			typeof(global::System.TimeSpan),
			typeof(global::System.DateTime[]),
			typeof(byte[]),
			typeof(global::System.TimeZoneInfo.TZifType[]),
			typeof(bool[]),
			typeof(bool[]),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.DateTime)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "TZif_GetEarlyDateTransitionType", MemberParameters = new object[] { typeof(global::System.TimeZoneInfo.TZifType[]) }, ReturnType = typeof(global::System.TimeZoneInfo.TZifType))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "TZif_CalculateTransitionOffsetFromBase", MemberParameters = new object[]
		{
			typeof(global::System.TimeSpan),
			typeof(global::System.TimeSpan)
		}, ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "AddTicks", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo.AdjustmentRule), Member = "CreateAdjustmentRule", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.DateTime),
			typeof(global::System.TimeSpan),
			typeof(global::System.TimeZoneInfo.TransitionTime),
			typeof(global::System.TimeZoneInfo.TransitionTime),
			typeof(global::System.TimeSpan),
			typeof(bool)
		}, ReturnType = typeof(global::System.TimeZoneInfo.AdjustmentRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "IsValidAdjustmentRuleOffest", MemberParameters = new object[]
		{
			typeof(global::System.TimeSpan),
			typeof(global::System.TimeZoneInfo.AdjustmentRule)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "NormalizeAdjustmentRuleOffset", MemberParameters = new object[]
		{
			typeof(global::System.TimeSpan),
			typeof(ref global::System.TimeZoneInfo.AdjustmentRule)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "AddMilliseconds", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo.TransitionTime), Member = "ValidateTransitionTime", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(global::System.DayOfWeek)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "TZif_CreateAdjustmentRuleForPosixFormat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.DateTime),
			typeof(global::System.TimeSpan)
		}, ReturnType = typeof(global::System.TimeZoneInfo.AdjustmentRule))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 27)]
		private static void TZif_GenerateAdjustmentRule(ref int index, global::System.TimeSpan timeZoneBaseUtcOffset, global::System.Collections.Generic.List<global::System.TimeZoneInfo.AdjustmentRule> rulesList, global::System.DateTime[] dts, byte[] typeOfLocalTime, global::System.TimeZoneInfo.TZifType[] transitionTypes, bool[] StandardTime, bool[] GmtTime, string futureTransitionsPosixFormat)
		{
			throw null;
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x00014DAA File Offset: 0x00012FAA
		[global::Cpp2ILInjected.Token(Token = "0x6000313")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BABAB8", Offset = "0x1BABAB8", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "TZif_GenerateAdjustmentRule", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(global::System.TimeSpan),
			typeof(global::System.Collections.Generic.List<global::System.TimeZoneInfo.AdjustmentRule>),
			typeof(global::System.DateTime[]),
			typeof(byte[]),
			typeof(global::System.TimeZoneInfo.TZifType[]),
			typeof(bool[]),
			typeof(bool[]),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "TZif_CreateAdjustmentRuleForPosixFormat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.DateTime),
			typeof(global::System.TimeSpan)
		}, ReturnType = typeof(global::System.TimeZoneInfo.AdjustmentRule))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeSpan), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(global::System.TimeSpan),
			typeof(global::System.TimeSpan)
		}, ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeSpan), Member = "get_Hours", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeSpan), Member = "get_Minutes", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeSpan), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static global::System.TimeSpan TZif_CalculateTransitionOffsetFromBase(global::System.TimeSpan transitionOffset, global::System.TimeSpan timeZoneBaseUtcOffset)
		{
			throw null;
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x00014DAD File Offset: 0x00012FAD
		[global::Cpp2ILInjected.Token(Token = "0x6000314")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BABA28", Offset = "0x1BABA28", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "TZif_GenerateAdjustmentRule", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(global::System.TimeSpan),
			typeof(global::System.Collections.Generic.List<global::System.TimeZoneInfo.AdjustmentRule>),
			typeof(global::System.DateTime[]),
			typeof(byte[]),
			typeof(global::System.TimeZoneInfo.TZifType[]),
			typeof(bool[]),
			typeof(bool[]),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidTimeZoneException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private static global::System.TimeZoneInfo.TZifType TZif_GetEarlyDateTransitionType(global::System.TimeZoneInfo.TZifType[] transitionTypes)
		{
			throw null;
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x00014DB0 File Offset: 0x00012FB0
		[global::Cpp2ILInjected.Token(Token = "0x6000315")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BABF00", Offset = "0x1BABF00", Length = "0x324")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "TZif_GenerateAdjustmentRule", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(global::System.TimeSpan),
			typeof(global::System.Collections.Generic.List<global::System.TimeZoneInfo.AdjustmentRule>),
			typeof(global::System.DateTime[]),
			typeof(byte[]),
			typeof(global::System.TimeZoneInfo.TZifType[]),
			typeof(bool[]),
			typeof(bool[]),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "TZif_ParsePosixFormat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref string),
			typeof(ref string),
			typeof(ref string),
			typeof(ref string),
			typeof(ref string),
			typeof(ref string),
			typeof(ref string),
			typeof(ref string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "TZif_ParseOffsetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.TimeSpan?))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeSpan?), Member = "get_Value", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeSpan), Member = "Negate", ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "TZif_CalculateTransitionOffsetFromBase", MemberParameters = new object[]
		{
			typeof(global::System.TimeSpan),
			typeof(global::System.TimeSpan)
		}, ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeSpan), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "TZif_CreateTransitionTimeFromPosixRule", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(global::System.TimeZoneInfo.TransitionTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo.AdjustmentRule), Member = "CreateAdjustmentRule", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.DateTime),
			typeof(global::System.TimeSpan),
			typeof(global::System.TimeZoneInfo.TransitionTime),
			typeof(global::System.TimeZoneInfo.TransitionTime),
			typeof(global::System.TimeSpan),
			typeof(bool)
		}, ReturnType = typeof(global::System.TimeZoneInfo.AdjustmentRule))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		private static global::System.TimeZoneInfo.AdjustmentRule TZif_CreateAdjustmentRuleForPosixFormat(string posixFormat, global::System.DateTime startTransitionDate, global::System.TimeSpan timeZoneBaseUtcOffset)
		{
			throw null;
		}

		// Token: 0x060002BA RID: 698 RVA: 0x00014DB3 File Offset: 0x00012FB3
		[global::Cpp2ILInjected.Token(Token = "0x6000316")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BAC418", Offset = "0x1BAC418", Length = "0x1F0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "TZif_CreateAdjustmentRuleForPosixFormat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.DateTime),
			typeof(global::System.TimeSpan)
		}, ReturnType = typeof(global::System.TimeZoneInfo.AdjustmentRule))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "ParseTimeOfDay", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeSpan), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeSpan), Member = "TryParseExact", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(global::System.IFormatProvider),
			typeof(ref global::System.TimeSpan)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeSpan?), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.TimeSpan) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeSpan?), Member = "get_Value", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeSpan), Member = "Negate", ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private static global::System.TimeSpan? TZif_ParseOffsetString(string offset)
		{
			throw null;
		}

		// Token: 0x060002BB RID: 699 RVA: 0x00014DB6 File Offset: 0x00012FB6
		[global::Cpp2ILInjected.Token(Token = "0x6000317")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BAC850", Offset = "0x1BAC850", Length = "0x23C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "TZif_CreateTransitionTimeFromPosixRule", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(global::System.TimeZoneInfo.TransitionTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "TZif_ParseOffsetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.TimeSpan?))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeSpan?), Member = "get_Value", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeSpan), Member = "get_Hours", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeSpan), Member = "get_Minutes", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeSpan), Member = "get_Seconds", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeSpan), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeSpan?), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.TimeSpan) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeSpan), Member = "op_LessThan", MemberParameters = new object[]
		{
			typeof(global::System.TimeSpan),
			typeof(global::System.TimeSpan)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeSpan)
		}, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private static global::System.DateTime ParseTimeOfDay(string time)
		{
			throw null;
		}

		// Token: 0x060002BC RID: 700 RVA: 0x00014DB9 File Offset: 0x00012FB9
		[global::Cpp2ILInjected.Token(Token = "0x6000318")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BAC608", Offset = "0x1BAC608", Length = "0x248")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "TZif_CreateAdjustmentRuleForPosixFormat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.DateTime),
			typeof(global::System.TimeSpan)
		}, ReturnType = typeof(global::System.TimeZoneInfo.AdjustmentRule))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "TZif_ParseMDateRule", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref int),
			typeof(ref int),
			typeof(ref global::System.DayOfWeek)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "ParseTimeOfDay", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo.TransitionTime), Member = "ValidateTransitionTime", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(global::System.DayOfWeek)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "TZif_ParseJulianDay", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::SR), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidTimeZoneException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		private static global::System.TimeZoneInfo.TransitionTime TZif_CreateTransitionTimeFromPosixRule(string date, string time)
		{
			throw null;
		}

		// Token: 0x060002BD RID: 701 RVA: 0x00014DBC File Offset: 0x00012FBC
		[global::Cpp2ILInjected.Token(Token = "0x6000319")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BACD48", Offset = "0x1BACD48", Length = "0x1B4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "TZif_CreateTransitionTimeFromPosixRule", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(global::System.TimeZoneInfo.TransitionTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidTimeZoneException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private static void TZif_ParseJulianDay(string date, out int month, out int day)
		{
			throw null;
		}

		// Token: 0x060002BE RID: 702 RVA: 0x00014DBF File Offset: 0x00012FBF
		[global::Cpp2ILInjected.Token(Token = "0x600031A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BACA8C", Offset = "0x1BACA8C", Length = "0x254")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "TZif_CreateTransitionTimeFromPosixRule", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(global::System.TimeZoneInfo.TransitionTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[]
		{
			typeof(char),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", MemberParameters = new object[] { typeof(global::System.ExceptionArgument) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private static bool TZif_ParseMDateRule(string dateRule, out int month, out int week, out global::System.DayOfWeek dayOfWeek)
		{
			throw null;
		}

		// Token: 0x060002BF RID: 703 RVA: 0x00014DC2 File Offset: 0x00012FC2
		[global::Cpp2ILInjected.Token(Token = "0x600031B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BAC224", Offset = "0x1BAC224", Length = "0x1F4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "TZif_CreateAdjustmentRuleForPosixFormat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.DateTime),
			typeof(global::System.TimeSpan)
		}, ReturnType = typeof(global::System.TimeZoneInfo.AdjustmentRule))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "TZif_ParsePosixName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "TZif_ParsePosixOffset", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "TZif_ParsePosixDateTime", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref int),
			typeof(ref string),
			typeof(ref string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private static bool TZif_ParsePosixFormat(string posixFormat, out string standardName, out string standardOffset, out string daylightSavingsName, out string daylightSavingsOffset, out string start, out string startTime, out string end, out string endTime)
		{
			throw null;
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x00014DC5 File Offset: 0x00012FC5
		[global::Cpp2ILInjected.Token(Token = "0x600031C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BACEFC", Offset = "0x1BACEFC", Length = "0x224")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "TZif_ParsePosixFormat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref string),
			typeof(ref string),
			typeof(ref string),
			typeof(ref string),
			typeof(ref string),
			typeof(ref string),
			typeof(ref string),
			typeof(ref string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Func<char, bool>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "TZif_ParsePosixString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref int),
			typeof(global::System.Func<char, bool>)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		private static string TZif_ParsePosixName(string posixFormat, ref int index)
		{
			throw null;
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x00014DC8 File Offset: 0x00012FC8
		[global::Cpp2ILInjected.Token(Token = "0x600031D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BAD120", Offset = "0x1BAD120", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "TZif_ParsePosixFormat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref string),
			typeof(ref string),
			typeof(ref string),
			typeof(ref string),
			typeof(ref string),
			typeof(ref string),
			typeof(ref string),
			typeof(ref string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Func<char, bool>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "TZif_ParsePosixString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref int),
			typeof(global::System.Func<char, bool>)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private static string TZif_ParsePosixOffset(string posixFormat, ref int index)
		{
			throw null;
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x00014DCB File Offset: 0x00012FCB
		[global::Cpp2ILInjected.Token(Token = "0x600031E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BAD22C", Offset = "0x1BAD22C", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "TZif_ParsePosixFormat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref string),
			typeof(ref string),
			typeof(ref string),
			typeof(ref string),
			typeof(ref string),
			typeof(ref string),
			typeof(ref string),
			typeof(ref string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "TZif_ParsePosixDate", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "TZif_ParsePosixTime", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private static void TZif_ParsePosixDateTime(string posixFormat, ref int index, out string date, out string time)
		{
			throw null;
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x00014DCE File Offset: 0x00012FCE
		[global::Cpp2ILInjected.Token(Token = "0x600031F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BAD390", Offset = "0x1BAD390", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "TZif_ParsePosixDateTime", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref int),
			typeof(ref string),
			typeof(ref string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Func<char, bool>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "TZif_ParsePosixString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref int),
			typeof(global::System.Func<char, bool>)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private static string TZif_ParsePosixDate(string posixFormat, ref int index)
		{
			throw null;
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x00014DD1 File Offset: 0x00012FD1
		[global::Cpp2ILInjected.Token(Token = "0x6000320")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BAD49C", Offset = "0x1BAD49C", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "TZif_ParsePosixDateTime", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref int),
			typeof(ref string),
			typeof(ref string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Func<char, bool>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "TZif_ParsePosixString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref int),
			typeof(global::System.Func<char, bool>)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private static string TZif_ParsePosixTime(string posixFormat, ref int index)
		{
			throw null;
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x00014DD4 File Offset: 0x00012FD4
		[global::Cpp2ILInjected.Token(Token = "0x6000321")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BAD300", Offset = "0x1BAD300", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "TZif_ParsePosixName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "TZif_ParsePosixOffset", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "TZif_ParsePosixDate", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "TZif_ParsePosixTime", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		private static string TZif_ParsePosixString(string posixFormat, ref int index, global::System.Func<char, bool> breakCondition)
		{
			throw null;
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x00014DD7 File Offset: 0x00012FD7
		[global::Cpp2ILInjected.Token(Token = "0x6000322")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BA8B0C", Offset = "0x1BA8B0C", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[]
		{
			typeof(char),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		private static string TZif_GetZoneAbbreviation(string zoneAbbreviations, int index)
		{
			throw null;
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x00014DDA File Offset: 0x00012FDA
		[global::Cpp2ILInjected.Token(Token = "0x6000323")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BAD5A8", Offset = "0x1BAD5A8", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static int TZif_ToInt32(byte[] value, int startIndex)
		{
			throw null;
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x00014DDD File Offset: 0x00012FDD
		[global::Cpp2ILInjected.Token(Token = "0x6000324")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BAD5B8", Offset = "0x1BAD5B8", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "TZif_ToUnixTime", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(global::System.TimeZoneInfo.TZVersion)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		private static long TZif_ToInt64(byte[] value, int startIndex)
		{
			throw null;
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x00014DE0 File Offset: 0x00012FE0
		[global::Cpp2ILInjected.Token(Token = "0x6000325")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BAD5C8", Offset = "0x1BAD5C8", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "TZif_ParseRaw", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(ref global::System.TimeZoneInfo.TZifHead),
			typeof(ref global::System.DateTime[]),
			typeof(ref byte[]),
			typeof(ref global::System.TimeZoneInfo.TZifType[]),
			typeof(ref string),
			typeof(ref bool[]),
			typeof(ref bool[]),
			typeof(ref string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "TZif_ToInt64", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static long TZif_ToUnixTime(byte[] value, int startIndex, global::System.TimeZoneInfo.TZVersion version)
		{
			throw null;
		}

		// Token: 0x060002CA RID: 714 RVA: 0x00014DE3 File Offset: 0x00012FE3
		[global::Cpp2ILInjected.Token(Token = "0x6000326")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BAD670", Offset = "0x1BAD670", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "TZif_ParseRaw", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(ref global::System.TimeZoneInfo.TZifHead),
			typeof(ref global::System.DateTime[]),
			typeof(ref byte[]),
			typeof(ref global::System.TimeZoneInfo.TZifType[]),
			typeof(ref string),
			typeof(ref bool[]),
			typeof(ref bool[]),
			typeof(ref string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeOffset), Member = "FromUnixTimeSeconds", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(global::System.DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTimeOffset), Member = "get_UtcDateTime", ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private static global::System.DateTime TZif_UnixTimeToDateTime(long unixTime)
		{
			throw null;
		}

		// Token: 0x060002CB RID: 715 RVA: 0x00014DE6 File Offset: 0x00012FE6
		[global::Cpp2ILInjected.Token(Token = "0x6000327")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BA8694", Offset = "0x1BA8694", Length = "0x478")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo.TZifHead), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "TZif_ToUnixTime", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(global::System.TimeZoneInfo.TZVersion)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "TZif_UnixTimeToDateTime", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo.TZifType), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.Encoding), Member = "get_UTF8", ReturnType = typeof(global::System.Text.Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		private static void TZif_ParseRaw(byte[] data, out global::System.TimeZoneInfo.TZifHead t, out global::System.DateTime[] dts, out byte[] typeOfLocalTime, out global::System.TimeZoneInfo.TZifType[] transitionType, out string zoneAbbreviations, out bool[] StandardTime, out bool[] GmtTime, out string futureTransitionsPosixFormat)
		{
			throw null;
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060002CC RID: 716 RVA: 0x00014DE9 File Offset: 0x00012FE9
		[global::Cpp2ILInjected.Token(Token = "0x17000040")]
		public string DisplayName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000328")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BADA1C", Offset = "0x1BADA1C", Length = "0x54")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060002CD RID: 717 RVA: 0x00014DEC File Offset: 0x00012FEC
		[global::Cpp2ILInjected.Token(Token = "0x17000041")]
		public string StandardName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000329")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BADA70", Offset = "0x1BADA70", Length = "0x54")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.CurrentSystemTimeZone), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060002CE RID: 718 RVA: 0x00014DEF File Offset: 0x00012FEF
		[global::Cpp2ILInjected.Token(Token = "0x17000042")]
		public string DaylightName
		{
			[global::Cpp2ILInjected.Token(Token = "0x600032A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BADAC4", Offset = "0x1BADAC4", Length = "0x54")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.CurrentSystemTimeZone), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060002CF RID: 719 RVA: 0x00014DF2 File Offset: 0x00012FF2
		[global::Cpp2ILInjected.Token(Token = "0x17000043")]
		public global::System.TimeSpan BaseUtcOffset
		{
			[global::Cpp2ILInjected.Token(Token = "0x600032B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BADB18", Offset = "0x1BADB18", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060002D0 RID: 720 RVA: 0x00014DF5 File Offset: 0x00012FF5
		[global::Cpp2ILInjected.Token(Token = "0x17000044")]
		public bool SupportsDaylightSavingTime
		{
			[global::Cpp2ILInjected.Token(Token = "0x600032C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BADB20", Offset = "0x1BADB20", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x00014DF8 File Offset: 0x00012FF8
		[global::Cpp2ILInjected.Token(Token = "0x600032D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BADB28", Offset = "0x1BADB28", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "GetDaylightTime", MemberParameters = new object[]
		{
			typeof(int),
			typeof(global::System.TimeZoneInfo.AdjustmentRule),
			typeof(int?)
		}, ReturnType = typeof(global::System.Globalization.DaylightTimeStruct))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "GetDaylightSavingsStartOffsetFromUtc", MemberParameters = new object[]
		{
			typeof(global::System.TimeSpan),
			typeof(global::System.TimeZoneInfo.AdjustmentRule),
			typeof(int?)
		}, ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int?), Member = "get_Value", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private global::System.TimeZoneInfo.AdjustmentRule GetPreviousAdjustmentRule(global::System.TimeZoneInfo.AdjustmentRule rule, int? ruleIndex)
		{
			throw null;
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x00014DFB File Offset: 0x00012FFB
		[global::Cpp2ILInjected.Token(Token = "0x600032E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BADC1C", Offset = "0x1BADC1C", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeFormat), Member = "TryFormatO", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeSpan),
			typeof(global::System.Span<char>),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			"System.Xml.Schema.XsdDateTimeFlags"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "op_Implicit", MemberParameters = new object[] { "System.Xml.Schema.XsdDateTime" }, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "op_Implicit", MemberParameters = new object[] { "System.Xml.Schema.XsdDateTime" }, ReturnType = typeof(global::System.DateTimeOffset))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.DateTimeUtils", Member = "TryParseDateTimeOffsetIso", MemberParameters = new object[]
		{
			"Newtonsoft.Json.Utilities.StringReference",
			typeof(ref global::System.DateTimeOffset)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public global::System.TimeSpan GetUtcOffset(global::System.DateTime dateTime)
		{
			throw null;
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x00014DFE File Offset: 0x00012FFE
		[global::Cpp2ILInjected.Token(Token = "0x600032F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BADDD8", Offset = "0x1BADDD8", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTime), Member = "FromBinary", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTime), Member = "ToBinary", ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeOffset), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.DateTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeOffset), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeSpan)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeFormat), Member = "FormatCustomizedTimeZone", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeSpan),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(int),
			typeof(bool),
			typeof(global::System.Text.StringBuilder)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeFormat), Member = "FormatCustomizedRoundripTimeZone", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeSpan),
			typeof(global::System.Text.StringBuilder)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "DetermineTimeZoneAdjustments", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(ref global::System.DateTimeResult),
			typeof(global::System.Globalization.DateTimeStyles),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "DateTimeOffsetTimeZonePostProcessing", MemberParameters = new object[]
		{
			typeof(ref global::System.__DTString),
			typeof(ref global::System.DateTimeResult),
			typeof(global::System.Globalization.DateTimeStyles)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo.CachedData), Member = "CreateLocal", ReturnType = typeof(global::System.TimeZoneInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "GetUtcOffset", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeZoneInfoOptions),
			typeof(global::System.TimeZoneInfo.CachedData)
		}, ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal static global::System.TimeSpan GetLocalUtcOffset(global::System.DateTime dateTime, global::System.TimeZoneInfoOptions flags)
		{
			throw null;
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x00014E01 File Offset: 0x00013001
		[global::Cpp2ILInjected.Token(Token = "0x6000330")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BADEA0", Offset = "0x1BADEA0", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "AdjustTimeZoneToLocal", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "GetUtcOffset", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeZoneInfoOptions),
			typeof(global::System.TimeZoneInfo.CachedData)
		}, ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal global::System.TimeSpan GetUtcOffset(global::System.DateTime dateTime, global::System.TimeZoneInfoOptions flags)
		{
			throw null;
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x00014E04 File Offset: 0x00013004
		[global::Cpp2ILInjected.Token(Token = "0x6000331")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BADC90", Offset = "0x1BADC90", Length = "0x148")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "GetLocalUtcOffset", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeZoneInfoOptions)
		}, ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "GetUtcOffset", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeZoneInfoOptions)
		}, ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "get_Kind", ReturnType = typeof(global::System.DateTimeKind))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo.CachedData), Member = "GetCorrespondingKind", MemberParameters = new object[] { typeof(global::System.TimeZoneInfo) }, ReturnType = typeof(global::System.DateTimeKind))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo.CachedData), Member = "CreateLocal", ReturnType = typeof(global::System.TimeZoneInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "ConvertTime", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeZoneInfo),
			typeof(global::System.TimeZoneInfo),
			typeof(global::System.TimeZoneInfoOptions)
		}, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "GetUtcOffset", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeZoneInfo),
			typeof(global::System.TimeZoneInfoOptions)
		}, ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "GetUtcOffsetFromUtc", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeZoneInfo)
		}, ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private global::System.TimeSpan GetUtcOffset(global::System.DateTime dateTime, global::System.TimeZoneInfoOptions flags, global::System.TimeZoneInfo.CachedData cachedData)
		{
			throw null;
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x00014E07 File Offset: 0x00013007
		[global::Cpp2ILInjected.Token(Token = "0x6000332")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BAE228", Offset = "0x1BAE228", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTime), Member = "IsDaylightSavingTime", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal bool IsDaylightSavingTime(global::System.DateTime dateTime, global::System.TimeZoneInfoOptions flags)
		{
			throw null;
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x00014E0A File Offset: 0x0001300A
		[global::Cpp2ILInjected.Token(Token = "0x6000333")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BAE2A0", Offset = "0x1BAE2A0", Length = "0x1E0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "get_Kind", ReturnType = typeof(global::System.DateTimeKind))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo.CachedData), Member = "CreateLocal", ReturnType = typeof(global::System.TimeZoneInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "ConvertTime", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeZoneInfo),
			typeof(global::System.TimeZoneInfo),
			typeof(global::System.TimeZoneInfoOptions),
			typeof(global::System.TimeZoneInfo.CachedData)
		}, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo.CachedData), Member = "GetCorrespondingKind", MemberParameters = new object[] { typeof(global::System.TimeZoneInfo) }, ReturnType = typeof(global::System.DateTimeKind))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "GetUtcOffsetFromUtc", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeZoneInfo),
			typeof(ref bool)
		}, ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "GetAdjustmentRuleForTime", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(bool),
			typeof(ref int?)
		}, ReturnType = typeof(global::System.TimeZoneInfo.AdjustmentRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo.AdjustmentRule), Member = "get_HasDaylightSaving", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "get_Year", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "GetDaylightTime", MemberParameters = new object[]
		{
			typeof(int),
			typeof(global::System.TimeZoneInfo.AdjustmentRule),
			typeof(int?)
		}, ReturnType = typeof(global::System.Globalization.DaylightTimeStruct))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "GetIsDaylightSavings", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeZoneInfo.AdjustmentRule),
			typeof(global::System.Globalization.DaylightTimeStruct),
			typeof(global::System.TimeZoneInfoOptions)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private bool IsDaylightSavingTime(global::System.DateTime dateTime, global::System.TimeZoneInfoOptions flags, global::System.TimeZoneInfo.CachedData cachedData)
		{
			throw null;
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x00014E0D File Offset: 0x0001300D
		[global::Cpp2ILInjected.Token(Token = "0x6000334")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BADFA4", Offset = "0x1BADFA4", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "GetUtcOffset", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeZoneInfoOptions),
			typeof(global::System.TimeZoneInfo.CachedData)
		}, ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "ConvertTime", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeZoneInfo),
			typeof(global::System.TimeZoneInfo),
			typeof(global::System.TimeZoneInfoOptions),
			typeof(global::System.TimeZoneInfo.CachedData)
		}, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static global::System.DateTime ConvertTime(global::System.DateTime dateTime, global::System.TimeZoneInfo sourceTimeZone, global::System.TimeZoneInfo destinationTimeZone, global::System.TimeZoneInfoOptions flags)
		{
			throw null;
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x00014E10 File Offset: 0x00013010
		[global::Cpp2ILInjected.Token(Token = "0x6000335")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BAE480", Offset = "0x1BAE480", Length = "0x3D0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "IsDaylightSavingTime", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeZoneInfoOptions),
			typeof(global::System.TimeZoneInfo.CachedData)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "ConvertTime", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeZoneInfo),
			typeof(global::System.TimeZoneInfo),
			typeof(global::System.TimeZoneInfoOptions)
		}, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "ConvertTimeToUtc", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeZoneInfoOptions)
		}, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo.CachedData), Member = "GetCorrespondingKind", MemberParameters = new object[] { typeof(global::System.TimeZoneInfo) }, ReturnType = typeof(global::System.DateTimeKind))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "get_Kind", ReturnType = typeof(global::System.DateTimeKind))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "GetAdjustmentRuleForTime", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(bool),
			typeof(ref int?)
		}, ReturnType = typeof(global::System.TimeZoneInfo.AdjustmentRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeSpan), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(global::System.TimeSpan),
			typeof(global::System.TimeSpan)
		}, ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo.AdjustmentRule), Member = "get_HasDaylightSaving", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "get_Year", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "GetDaylightTime", MemberParameters = new object[]
		{
			typeof(int),
			typeof(global::System.TimeZoneInfo.AdjustmentRule),
			typeof(int?)
		}, ReturnType = typeof(global::System.Globalization.DaylightTimeStruct))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "GetIsInvalidTime", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeZoneInfo.AdjustmentRule),
			typeof(global::System.Globalization.DaylightTimeStruct)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "GetIsDaylightSavings", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeZoneInfo.AdjustmentRule),
			typeof(global::System.Globalization.DaylightTimeStruct),
			typeof(global::System.TimeZoneInfoOptions)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "get_Ticks", ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "ConvertUtcToTimeZone", MemberParameters = new object[]
		{
			typeof(long),
			typeof(global::System.TimeZoneInfo),
			typeof(ref bool)
		}, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(long),
			typeof(global::System.DateTimeKind),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(long),
			typeof(global::System.DateTimeKind)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		private static global::System.DateTime ConvertTime(global::System.DateTime dateTime, global::System.TimeZoneInfo sourceTimeZone, global::System.TimeZoneInfo destinationTimeZone, global::System.TimeZoneInfoOptions flags, global::System.TimeZoneInfo.CachedData cachedData)
		{
			throw null;
		}

		// Token: 0x060002DA RID: 730 RVA: 0x00014E13 File Offset: 0x00013013
		[global::Cpp2ILInjected.Token(Token = "0x6000336")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BAF514", Offset = "0x1BAF514", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTime), Member = "ToUniversalTime", ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "get_Kind", ReturnType = typeof(global::System.DateTimeKind))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo.CachedData), Member = "CreateLocal", ReturnType = typeof(global::System.TimeZoneInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "ConvertTime", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeZoneInfo),
			typeof(global::System.TimeZoneInfo),
			typeof(global::System.TimeZoneInfoOptions),
			typeof(global::System.TimeZoneInfo.CachedData)
		}, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal static global::System.DateTime ConvertTimeToUtc(global::System.DateTime dateTime, global::System.TimeZoneInfoOptions flags)
		{
			throw null;
		}

		// Token: 0x060002DB RID: 731 RVA: 0x00014E16 File Offset: 0x00013016
		[global::Cpp2ILInjected.Token(Token = "0x6000337")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BAF5DC", Offset = "0x1BAF5DC", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(global::System.StringComparison)
		}, ReturnType = typeof(bool))]
		public bool Equals(global::System.TimeZoneInfo other)
		{
			throw null;
		}

		// Token: 0x060002DC RID: 732 RVA: 0x00014E19 File Offset: 0x00013019
		[global::Cpp2ILInjected.Token(Token = "0x6000338")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BAF778", Offset = "0x1BAF778", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "Equals", MemberParameters = new object[] { typeof(global::System.TimeZoneInfo) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x060002DD RID: 733 RVA: 0x00014E1C File Offset: 0x0001301C
		[global::Cpp2ILInjected.Token(Token = "0x6000339")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BAF7DC", Offset = "0x1BAF7DC", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x060002DE RID: 734 RVA: 0x00014E1F File Offset: 0x0001301F
		[global::Cpp2ILInjected.Token(Token = "0x600033A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BAF62C", Offset = "0x1BAF62C", Length = "0x14C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeSpan), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::System.TimeSpan),
			typeof(global::System.TimeSpan)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo.AdjustmentRule), Member = "Equals", MemberParameters = new object[] { typeof(global::System.TimeZoneInfo.AdjustmentRule) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public bool HasSameRules(global::System.TimeZoneInfo other)
		{
			throw null;
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060002DF RID: 735 RVA: 0x00014E22 File Offset: 0x00013022
		[global::Cpp2ILInjected.Token(Token = "0x17000045")]
		public static global::System.TimeZoneInfo Local
		{
			[global::Cpp2ILInjected.Token(Token = "0x600033B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BAB078", Offset = "0x1BAB078", Length = "0x78")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "GetDateTimeNowUtcOffsetFromUtc", MemberParameters = new object[]
			{
				typeof(global::System.DateTime),
				typeof(ref bool)
			}, ReturnType = typeof(global::System.TimeSpan))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.CurrentSystemTimeZone), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.CurrentSystemTimeZone), Member = "CreateDaylightChanges", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(global::System.Globalization.DaylightTime))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTime), Member = "FromBinary", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(global::System.DateTime))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTime), Member = "IsDaylightSavingTime", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTime), Member = "ToLocalTime", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(global::System.DateTime))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeFormat), Member = "TryFormatO", MemberParameters = new object[]
			{
				typeof(global::System.DateTime),
				typeof(global::System.TimeSpan),
				typeof(global::System.Span<char>),
				typeof(ref int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "AdjustTimeZoneToLocal", MemberParameters = new object[]
			{
				typeof(ref global::System.DateTimeResult),
				typeof(bool)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = ".ctor", MemberParameters = new object[]
			{
				typeof(global::System.DateTime),
				"System.Xml.Schema.XsdDateTimeFlags"
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "op_Implicit", MemberParameters = new object[] { "System.Xml.Schema.XsdDateTime" }, ReturnType = typeof(global::System.DateTime))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.XsdDateTime", Member = "op_Implicit", MemberParameters = new object[] { "System.Xml.Schema.XsdDateTime" }, ReturnType = typeof(global::System.DateTimeOffset))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.DateTimeUtils", Member = "TryParseDateTimeOffsetIso", MemberParameters = new object[]
			{
				"Newtonsoft.Json.Utilities.StringReference",
				typeof(ref global::System.DateTimeOffset)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 15)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo.CachedData), Member = "CreateLocal", ReturnType = typeof(global::System.TimeZoneInfo))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x00014E25 File Offset: 0x00013025
		[global::Cpp2ILInjected.Token(Token = "0x600033C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BAF9D8", Offset = "0x1BAF9D8", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060002E1 RID: 737 RVA: 0x00014E28 File Offset: 0x00013028
		[global::Cpp2ILInjected.Token(Token = "0x17000046")]
		public static global::System.TimeZoneInfo Utc
		{
			[global::Cpp2ILInjected.Token(Token = "0x600033D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BAFA2C", Offset = "0x1BAFA2C", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x00014E2B File Offset: 0x0001302B
		[global::Cpp2ILInjected.Token(Token = "0x600033E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BAFA84", Offset = "0x1BAFA84", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo.CachedData), Member = "CreateLocal", ReturnType = typeof(global::System.TimeZoneInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "CreateCustomTimeZone", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.TimeSpan),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(global::System.TimeZoneInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "CreateCustomTimeZone", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.TimeSpan),
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(global::System.TimeZoneInfo.AdjustmentRule[]),
			typeof(bool)
		}, ReturnType = typeof(global::System.TimeZoneInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "ValidateTimeZoneInfo", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.TimeSpan),
			typeof(global::System.TimeZoneInfo.AdjustmentRule[]),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private TimeZoneInfo(string id, global::System.TimeSpan baseUtcOffset, string displayName, string standardDisplayName, string daylightDisplayName, global::System.TimeZoneInfo.AdjustmentRule[] adjustmentRules, bool disableDaylightSavingTime)
		{
			throw null;
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x00014E2E File Offset: 0x0001302E
		[global::Cpp2ILInjected.Token(Token = "0x600033F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BAFB64", Offset = "0x1BAFB64", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.TimeSpan),
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(global::System.TimeZoneInfo.AdjustmentRule[]),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static global::System.TimeZoneInfo CreateCustomTimeZone(string id, global::System.TimeSpan baseUtcOffset, string displayName, string standardDisplayName)
		{
			throw null;
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x00014E31 File Offset: 0x00013031
		[global::Cpp2ILInjected.Token(Token = "0x6000340")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BAFBF8", Offset = "0x1BAFBF8", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "CreateLocalUnity", ReturnType = typeof(global::System.TimeZoneInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Clone", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.TimeSpan),
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(global::System.TimeZoneInfo.AdjustmentRule[]),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static global::System.TimeZoneInfo CreateCustomTimeZone(string id, global::System.TimeSpan baseUtcOffset, string displayName, string standardDisplayName, string daylightDisplayName, global::System.TimeZoneInfo.AdjustmentRule[] adjustmentRules, bool disableDaylightSavingTime)
		{
			throw null;
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x00014E34 File Offset: 0x00013034
		[global::Cpp2ILInjected.Token(Token = "0x6000341")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BAFCFC", Offset = "0x1BAFCFC", Length = "0x1D4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "ValidateTimeZoneInfo", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.TimeSpan),
			typeof(global::System.TimeZoneInfo.AdjustmentRule[]),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::SR), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 24)]
		private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender)
		{
			throw null;
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x00014E37 File Offset: 0x00013037
		[global::Cpp2ILInjected.Token(Token = "0x6000342")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BAFED0", Offset = "0x1BAFED0", Length = "0x1D8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		private void System.Runtime.Serialization.ISerializable.GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x00014E3A File Offset: 0x0001303A
		[global::Cpp2ILInjected.Token(Token = "0x6000343")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB00A8", Offset = "0x1BB00A8", Length = "0x404")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "GetValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 28)]
		private TimeZoneInfo(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x00014E3D File Offset: 0x0001303D
		[global::Cpp2ILInjected.Token(Token = "0x6000344")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BAE8D0", Offset = "0x1BAE8D0", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "GetAdjustmentRuleForTime", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(bool),
			typeof(ref int?)
		}, ReturnType = typeof(global::System.TimeZoneInfo.AdjustmentRule))]
		private global::System.TimeZoneInfo.AdjustmentRule GetAdjustmentRuleForTime(global::System.DateTime dateTime, out int? ruleIndex)
		{
			throw null;
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x00014E40 File Offset: 0x00013040
		[global::Cpp2ILInjected.Token(Token = "0x6000345")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB04AC", Offset = "0x1BB04AC", Length = "0x180")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "IsDaylightSavingTime", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeZoneInfoOptions),
			typeof(global::System.TimeZoneInfo.CachedData)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "ConvertTime", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeZoneInfo),
			typeof(global::System.TimeZoneInfo),
			typeof(global::System.TimeZoneInfoOptions),
			typeof(global::System.TimeZoneInfo.CachedData)
		}, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "GetAdjustmentRuleForTime", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(ref int?)
		}, ReturnType = typeof(global::System.TimeZoneInfo.AdjustmentRule))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "GetIsDaylightSavingsFromUtc", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(int),
			typeof(global::System.TimeSpan),
			typeof(global::System.TimeZoneInfo.AdjustmentRule),
			typeof(int?),
			typeof(ref bool),
			typeof(global::System.TimeZoneInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "GetUtcOffset", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeZoneInfo),
			typeof(global::System.TimeZoneInfoOptions)
		}, ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "GetUtcOffsetFromUtc", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeZoneInfo),
			typeof(ref bool),
			typeof(ref bool)
		}, ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeSpan)
		}, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "get_Date", ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "CompareAdjustmentRuleToDateTime", MemberParameters = new object[]
		{
			typeof(global::System.TimeZoneInfo.AdjustmentRule),
			typeof(global::System.TimeZoneInfo.AdjustmentRule),
			typeof(global::System.DateTime),
			typeof(global::System.DateTime),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int?), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private global::System.TimeZoneInfo.AdjustmentRule GetAdjustmentRuleForTime(global::System.DateTime dateTime, bool dateTimeisUtc, out int? ruleIndex)
		{
			throw null;
		}

		// Token: 0x060002EA RID: 746 RVA: 0x00014E43 File Offset: 0x00013043
		[global::Cpp2ILInjected.Token(Token = "0x6000346")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB062C", Offset = "0x1BB062C", Length = "0x180")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "GetAdjustmentRuleForTime", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(bool),
			typeof(ref int?)
		}, ReturnType = typeof(global::System.TimeZoneInfo.AdjustmentRule))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "get_Kind", ReturnType = typeof(global::System.DateTimeKind))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "ConvertToFromUtc", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeSpan),
			typeof(global::System.TimeSpan),
			typeof(bool)
		}, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "op_GreaterThanOrEqual", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.DateTime)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "op_LessThanOrEqual", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.DateTime)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private int CompareAdjustmentRuleToDateTime(global::System.TimeZoneInfo.AdjustmentRule rule, global::System.TimeZoneInfo.AdjustmentRule previousRule, global::System.DateTime dateTime, global::System.DateTime dateOnly, bool dateTimeisUtc)
		{
			throw null;
		}

		// Token: 0x060002EB RID: 747 RVA: 0x00014E46 File Offset: 0x00013046
		[global::Cpp2ILInjected.Token(Token = "0x6000347")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB07AC", Offset = "0x1BB07AC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private global::System.DateTime ConvertToUtc(global::System.DateTime dateTime, global::System.TimeSpan daylightDelta, global::System.TimeSpan baseUtcOffsetDelta)
		{
			throw null;
		}

		// Token: 0x060002EC RID: 748 RVA: 0x00014E49 File Offset: 0x00013049
		[global::Cpp2ILInjected.Token(Token = "0x6000348")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB0938", Offset = "0x1BB0938", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "ConvertToFromUtc", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeSpan),
			typeof(global::System.TimeSpan),
			typeof(bool)
		}, ReturnType = typeof(global::System.DateTime))]
		private global::System.DateTime ConvertFromUtc(global::System.DateTime dateTime, global::System.TimeSpan daylightDelta, global::System.TimeSpan baseUtcOffsetDelta)
		{
			throw null;
		}

		// Token: 0x060002ED RID: 749 RVA: 0x00014E4C File Offset: 0x0001304C
		[global::Cpp2ILInjected.Token(Token = "0x6000349")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB07B4", Offset = "0x1BB07B4", Length = "0x184")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "CompareAdjustmentRuleToDateTime", MemberParameters = new object[]
		{
			typeof(global::System.TimeZoneInfo.AdjustmentRule),
			typeof(global::System.TimeZoneInfo.AdjustmentRule),
			typeof(global::System.DateTime),
			typeof(global::System.DateTime),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "ConvertFromUtc", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeSpan),
			typeof(global::System.TimeSpan)
		}, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "GetDaylightTime", MemberParameters = new object[]
		{
			typeof(int),
			typeof(global::System.TimeZoneInfo.AdjustmentRule),
			typeof(int?)
		}, ReturnType = typeof(global::System.Globalization.DaylightTimeStruct))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeSpan), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(global::System.TimeSpan),
			typeof(global::System.TimeSpan)
		}, ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeSpan), Member = "Negate", ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "get_Ticks", ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = ".ctor", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private global::System.DateTime ConvertToFromUtc(global::System.DateTime dateTime, global::System.TimeSpan daylightDelta, global::System.TimeSpan baseUtcOffsetDelta, bool convertToUtc)
		{
			throw null;
		}

		// Token: 0x060002EE RID: 750 RVA: 0x00014E4F File Offset: 0x0001304F
		[global::Cpp2ILInjected.Token(Token = "0x600034A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BAF330", Offset = "0x1BAF330", Length = "0x1E4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "ConvertTime", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeZoneInfo),
			typeof(global::System.TimeZoneInfo),
			typeof(global::System.TimeZoneInfoOptions),
			typeof(global::System.TimeZoneInfo.CachedData)
		}, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "get_Ticks", ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = ".ctor", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "GetUtcOffsetFromUtc", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeZoneInfo),
			typeof(ref bool)
		}, ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private static global::System.DateTime ConvertUtcToTimeZone(long ticks, global::System.TimeZoneInfo destinationTimeZone, out bool isAmbiguousLocalDst)
		{
			throw null;
		}

		// Token: 0x060002EF RID: 751 RVA: 0x00014E52 File Offset: 0x00013052
		[global::Cpp2ILInjected.Token(Token = "0x600034B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BAEA38", Offset = "0x1BAEA38", Length = "0x130")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "IsDaylightSavingTime", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeZoneInfoOptions),
			typeof(global::System.TimeZoneInfo.CachedData)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "ConvertTime", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeZoneInfo),
			typeof(global::System.TimeZoneInfo),
			typeof(global::System.TimeZoneInfoOptions),
			typeof(global::System.TimeZoneInfo.CachedData)
		}, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "GetIsDaylightSavingsFromUtc", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(int),
			typeof(global::System.TimeSpan),
			typeof(global::System.TimeZoneInfo.AdjustmentRule),
			typeof(int?),
			typeof(ref bool),
			typeof(global::System.TimeZoneInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "GetUtcOffset", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeZoneInfo),
			typeof(global::System.TimeZoneInfoOptions)
		}, ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "GetPreviousAdjustmentRule", MemberParameters = new object[]
		{
			typeof(global::System.TimeZoneInfo.AdjustmentRule),
			typeof(int?)
		}, ReturnType = typeof(global::System.TimeZoneInfo.AdjustmentRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "ConvertToFromUtc", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeSpan),
			typeof(global::System.TimeSpan),
			typeof(bool)
		}, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "TransitionTimeToDateTime", MemberParameters = new object[]
		{
			typeof(int),
			typeof(global::System.TimeZoneInfo.TransitionTime)
		}, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.DaylightTimeStruct), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.DateTime),
			typeof(global::System.TimeSpan)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private global::System.Globalization.DaylightTimeStruct GetDaylightTime(int year, global::System.TimeZoneInfo.AdjustmentRule rule, int? ruleIndex)
		{
			throw null;
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x00014E55 File Offset: 0x00013055
		[global::Cpp2ILInjected.Token(Token = "0x600034C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BAEB68", Offset = "0x1BAEB68", Length = "0x37C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "IsDaylightSavingTime", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeZoneInfoOptions),
			typeof(global::System.TimeZoneInfo.CachedData)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "ConvertTime", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeZoneInfo),
			typeof(global::System.TimeZoneInfo),
			typeof(global::System.TimeZoneInfoOptions),
			typeof(global::System.TimeZoneInfo.CachedData)
		}, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "GetUtcOffset", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeZoneInfo),
			typeof(global::System.TimeZoneInfoOptions)
		}, ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "get_Kind", ReturnType = typeof(global::System.DateTimeKind))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo.AdjustmentRule), Member = "IsStartDateMarkerForBeginningOfYear", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "get_Year", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeSpan), Member = "op_GreaterThan", MemberParameters = new object[]
		{
			typeof(global::System.TimeSpan),
			typeof(global::System.TimeSpan)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeSpan)
		}, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo.AdjustmentRule), Member = "IsEndDateMarkerForEndOfYear", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "AddTicks", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeSpan), Member = "op_UnaryNegation", MemberParameters = new object[] { typeof(global::System.TimeSpan) }, ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "CheckIsDst", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.DateTime),
			typeof(global::System.DateTime),
			typeof(bool),
			typeof(global::System.TimeZoneInfo.AdjustmentRule)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "GetIsAmbiguousTime", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeZoneInfo.AdjustmentRule),
			typeof(global::System.Globalization.DaylightTimeStruct)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "IsAmbiguousDaylightSavingTime", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		private static bool GetIsDaylightSavings(global::System.DateTime time, global::System.TimeZoneInfo.AdjustmentRule rule, global::System.Globalization.DaylightTimeStruct daylightTime, global::System.TimeZoneInfoOptions flags)
		{
			throw null;
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x00014E58 File Offset: 0x00013058
		[global::Cpp2ILInjected.Token(Token = "0x600034D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB12AC", Offset = "0x1BB12AC", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "GetIsDaylightSavingsFromUtc", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(int),
			typeof(global::System.TimeSpan),
			typeof(global::System.TimeZoneInfo.AdjustmentRule),
			typeof(int?),
			typeof(ref bool),
			typeof(global::System.TimeZoneInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "GetPreviousAdjustmentRule", MemberParameters = new object[]
		{
			typeof(global::System.TimeZoneInfo.AdjustmentRule),
			typeof(int?)
		}, ReturnType = typeof(global::System.TimeZoneInfo.AdjustmentRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeSpan), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(global::System.TimeSpan),
			typeof(global::System.TimeSpan)
		}, ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private global::System.TimeSpan GetDaylightSavingsStartOffsetFromUtc(global::System.TimeSpan baseUtcOffset, global::System.TimeZoneInfo.AdjustmentRule rule, int? ruleIndex)
		{
			throw null;
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x00014E5B File Offset: 0x0001305B
		[global::Cpp2ILInjected.Token(Token = "0x600034E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB1368", Offset = "0x1BB1368", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "GetIsDaylightSavingsFromUtc", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(int),
			typeof(global::System.TimeSpan),
			typeof(global::System.TimeZoneInfo.AdjustmentRule),
			typeof(int?),
			typeof(ref bool),
			typeof(global::System.TimeZoneInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeSpan), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(global::System.TimeSpan),
			typeof(global::System.TimeSpan)
		}, ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private global::System.TimeSpan GetDaylightSavingsEndOffsetFromUtc(global::System.TimeSpan baseUtcOffset, global::System.TimeZoneInfo.AdjustmentRule rule)
		{
			throw null;
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x00014E5E File Offset: 0x0001305E
		[global::Cpp2ILInjected.Token(Token = "0x600034F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB13E0", Offset = "0x1BB13E0", Length = "0x778")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "GetUtcOffsetFromUtc", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeZoneInfo),
			typeof(ref bool),
			typeof(ref bool)
		}, ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "GetDaylightTime", MemberParameters = new object[]
		{
			typeof(int),
			typeof(global::System.TimeZoneInfo.AdjustmentRule),
			typeof(int?)
		}, ReturnType = typeof(global::System.Globalization.DaylightTimeStruct))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "GetDaylightSavingsStartOffsetFromUtc", MemberParameters = new object[]
		{
			typeof(global::System.TimeSpan),
			typeof(global::System.TimeZoneInfo.AdjustmentRule),
			typeof(int?)
		}, ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo.AdjustmentRule), Member = "IsStartDateMarkerForBeginningOfYear", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "get_Year", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "GetAdjustmentRuleForTime", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(bool),
			typeof(ref int?)
		}, ReturnType = typeof(global::System.TimeZoneInfo.AdjustmentRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo.AdjustmentRule), Member = "IsEndDateMarkerForEndOfYear", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeSpan)
		}, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "GetDaylightSavingsEndOffsetFromUtc", MemberParameters = new object[]
		{
			typeof(global::System.TimeSpan),
			typeof(global::System.TimeZoneInfo.AdjustmentRule)
		}, ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "AddTicks", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "CheckIsDst", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.DateTime),
			typeof(global::System.DateTime),
			typeof(bool),
			typeof(global::System.TimeZoneInfo.AdjustmentRule)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "op_GreaterThanOrEqual", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.DateTime)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "op_LessThan", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.DateTime)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "AddYears", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 35)]
		private static bool GetIsDaylightSavingsFromUtc(global::System.DateTime time, int year, global::System.TimeSpan utc, global::System.TimeZoneInfo.AdjustmentRule rule, int? ruleIndex, out bool isAmbiguousLocalDst, global::System.TimeZoneInfo zone)
		{
			throw null;
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x00014E61 File Offset: 0x00013061
		[global::Cpp2ILInjected.Token(Token = "0x6000350")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB0D2C", Offset = "0x1BB0D2C", Length = "0x1D4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "GetIsDaylightSavings", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeZoneInfo.AdjustmentRule),
			typeof(global::System.Globalization.DaylightTimeStruct),
			typeof(global::System.TimeZoneInfoOptions)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "GetIsDaylightSavingsFromUtc", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(int),
			typeof(global::System.TimeSpan),
			typeof(global::System.TimeZoneInfo.AdjustmentRule),
			typeof(int?),
			typeof(ref bool),
			typeof(global::System.TimeZoneInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "get_Year", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "AddYears", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "op_GreaterThan", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.DateTime)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "op_LessThan", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.DateTime)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "op_GreaterThanOrEqual", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.DateTime)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "op_LessThanOrEqual", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.DateTime)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private static bool CheckIsDst(global::System.DateTime startTime, global::System.DateTime time, global::System.DateTime endTime, bool ignoreYearAdjustment, global::System.TimeZoneInfo.AdjustmentRule rule)
		{
			throw null;
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x00014E64 File Offset: 0x00013064
		[global::Cpp2ILInjected.Token(Token = "0x6000351")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB0F00", Offset = "0x1BB0F00", Length = "0x3AC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "GetIsDaylightSavings", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeZoneInfo.AdjustmentRule),
			typeof(global::System.Globalization.DaylightTimeStruct),
			typeof(global::System.TimeZoneInfoOptions)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeSpan), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.TimeSpan),
			typeof(global::System.TimeSpan)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeSpan), Member = "op_GreaterThan", MemberParameters = new object[]
		{
			typeof(global::System.TimeSpan),
			typeof(global::System.TimeSpan)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo.AdjustmentRule), Member = "IsEndDateMarkerForEndOfYear", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeSpan)
		}, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo.AdjustmentRule), Member = "IsStartDateMarkerForBeginningOfYear", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeSpan)
		}, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "op_GreaterThanOrEqual", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.DateTime)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "op_LessThan", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.DateTime)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "get_Year", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "AddYears", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 28)]
		private static bool GetIsAmbiguousTime(global::System.DateTime time, global::System.TimeZoneInfo.AdjustmentRule rule, global::System.Globalization.DaylightTimeStruct daylightTime)
		{
			throw null;
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x00014E67 File Offset: 0x00013067
		[global::Cpp2ILInjected.Token(Token = "0x6000352")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BAEF84", Offset = "0x1BAEF84", Length = "0x3AC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "ConvertTime", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeZoneInfo),
			typeof(global::System.TimeZoneInfo),
			typeof(global::System.TimeZoneInfoOptions),
			typeof(global::System.TimeZoneInfo.CachedData)
		}, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeSpan), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.TimeSpan),
			typeof(global::System.TimeSpan)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeSpan), Member = "op_LessThan", MemberParameters = new object[]
		{
			typeof(global::System.TimeSpan),
			typeof(global::System.TimeSpan)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo.AdjustmentRule), Member = "IsEndDateMarkerForEndOfYear", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeSpan)
		}, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo.AdjustmentRule), Member = "IsStartDateMarkerForBeginningOfYear", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeSpan)
		}, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "op_GreaterThanOrEqual", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.DateTime)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "op_LessThan", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.DateTime)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "get_Year", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "AddYears", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 28)]
		private static bool GetIsInvalidTime(global::System.DateTime time, global::System.TimeZoneInfo.AdjustmentRule rule, global::System.Globalization.DaylightTimeStruct daylightTime)
		{
			throw null;
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x00014E6A File Offset: 0x0001306A
		[global::Cpp2ILInjected.Token(Token = "0x6000353")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BAE09C", Offset = "0x1BAE09C", Length = "0x18C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "GetUtcOffset", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeZoneInfoOptions),
			typeof(global::System.TimeZoneInfo.CachedData)
		}, ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "GetAdjustmentRuleForTime", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(bool),
			typeof(ref int?)
		}, ReturnType = typeof(global::System.TimeZoneInfo.AdjustmentRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeSpan), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(global::System.TimeSpan),
			typeof(global::System.TimeSpan)
		}, ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo.AdjustmentRule), Member = "get_HasDaylightSaving", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "get_Year", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "GetDaylightTime", MemberParameters = new object[]
		{
			typeof(int),
			typeof(global::System.TimeZoneInfo.AdjustmentRule),
			typeof(int?)
		}, ReturnType = typeof(global::System.Globalization.DaylightTimeStruct))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "GetIsDaylightSavings", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeZoneInfo.AdjustmentRule),
			typeof(global::System.Globalization.DaylightTimeStruct),
			typeof(global::System.TimeZoneInfoOptions)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private static global::System.TimeSpan GetUtcOffset(global::System.DateTime time, global::System.TimeZoneInfo zone, global::System.TimeZoneInfoOptions flags)
		{
			throw null;
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x00014E6D File Offset: 0x0001306D
		[global::Cpp2ILInjected.Token(Token = "0x6000354")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BAE02C", Offset = "0x1BAE02C", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "GetUtcOffset", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeZoneInfoOptions),
			typeof(global::System.TimeZoneInfo.CachedData)
		}, ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "GetUtcOffsetFromUtc", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeZoneInfo),
			typeof(ref bool)
		}, ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static global::System.TimeSpan GetUtcOffsetFromUtc(global::System.DateTime time, global::System.TimeZoneInfo zone)
		{
			throw null;
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x00014E70 File Offset: 0x00013070
		[global::Cpp2ILInjected.Token(Token = "0x6000355")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BAE850", Offset = "0x1BAE850", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "IsDaylightSavingTime", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeZoneInfoOptions),
			typeof(global::System.TimeZoneInfo.CachedData)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "ConvertUtcToTimeZone", MemberParameters = new object[]
		{
			typeof(long),
			typeof(global::System.TimeZoneInfo),
			typeof(ref bool)
		}, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "GetUtcOffsetFromUtc", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeZoneInfo)
		}, ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "GetUtcOffsetFromUtc", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeZoneInfo),
			typeof(ref bool),
			typeof(ref bool)
		}, ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static global::System.TimeSpan GetUtcOffsetFromUtc(global::System.DateTime time, global::System.TimeZoneInfo zone, out bool isDaylightSavings)
		{
			throw null;
		}

		// Token: 0x060002FA RID: 762 RVA: 0x00014E73 File Offset: 0x00013073
		[global::Cpp2ILInjected.Token(Token = "0x6000356")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BAB0F0", Offset = "0x1BAB0F0", Length = "0x2C8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "GetDateTimeNowUtcOffsetFromUtc", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(ref bool)
		}, ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "GetUtcOffsetFromUtc", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeZoneInfo),
			typeof(ref bool)
		}, ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTime), Member = "FromBinary", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTime), Member = "ToLocalTime", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTimeParse), Member = "AdjustTimeZoneToLocal", MemberParameters = new object[]
		{
			typeof(ref global::System.DateTimeResult),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "op_GreaterThan", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.DateTime)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "GetAdjustmentRuleForTime", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(bool),
			typeof(ref int?)
		}, ReturnType = typeof(global::System.TimeZoneInfo.AdjustmentRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "op_LessThan", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.DateTime)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.TimeSpan)
		}, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "get_Year", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeSpan), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(global::System.TimeSpan),
			typeof(global::System.TimeSpan)
		}, ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo.AdjustmentRule), Member = "get_HasDaylightSaving", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "GetIsDaylightSavingsFromUtc", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(int),
			typeof(global::System.TimeSpan),
			typeof(global::System.TimeZoneInfo.AdjustmentRule),
			typeof(int?),
			typeof(ref bool),
			typeof(global::System.TimeZoneInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		internal static global::System.TimeSpan GetUtcOffsetFromUtc(global::System.DateTime time, global::System.TimeZoneInfo zone, out bool isDaylightSavings, out bool isAmbiguousLocalDst)
		{
			throw null;
		}

		// Token: 0x060002FB RID: 763 RVA: 0x00014E76 File Offset: 0x00013076
		[global::Cpp2ILInjected.Token(Token = "0x6000357")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB0940", Offset = "0x1BB0940", Length = "0x28C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "GetDaylightTime", MemberParameters = new object[]
		{
			typeof(int),
			typeof(global::System.TimeZoneInfo.AdjustmentRule),
			typeof(int?)
		}, ReturnType = typeof(global::System.Globalization.DaylightTimeStruct))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.CurrentSystemTimeZone), Member = "CreateDaylightChanges", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(global::System.Globalization.DaylightTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "DaysInMonth", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "get_Hour", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "get_Minute", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "get_Second", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "get_Millisecond", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "get_DayOfWeek", ReturnType = typeof(global::System.DayOfWeek))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "AddDays", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal static global::System.DateTime TransitionTimeToDateTime(int year, global::System.TimeZoneInfo.TransitionTime transitionTime)
		{
			throw null;
		}

		// Token: 0x060002FC RID: 764 RVA: 0x00014E79 File Offset: 0x00013079
		[global::Cpp2ILInjected.Token(Token = "0x6000358")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BA8CA8", Offset = "0x1BA8CA8", Length = "0x30C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.TimeSpan),
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(global::System.TimeZoneInfo.AdjustmentRule[]),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "System.Runtime.Serialization.IDeserializationCallback.OnDeserialization", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "UtcOffsetOutOfRange", MemberParameters = new object[] { typeof(global::System.TimeSpan) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "IsValidAdjustmentRuleOffest", MemberParameters = new object[]
		{
			typeof(global::System.TimeSpan),
			typeof(global::System.TimeZoneInfo.AdjustmentRule)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "op_LessThanOrEqual", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.DateTime)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidTimeZoneException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::SR), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 31)]
		private static void ValidateTimeZoneInfo(string id, global::System.TimeSpan baseUtcOffset, global::System.TimeZoneInfo.AdjustmentRule[] adjustmentRules, out bool adjustmentRulesSupportDst)
		{
			throw null;
		}

		// Token: 0x060002FD RID: 765 RVA: 0x00014E7C File Offset: 0x0001307C
		[global::Cpp2ILInjected.Token(Token = "0x6000359")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB1B58", Offset = "0x1BB1B58", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "ValidateTimeZoneInfo", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.TimeSpan),
			typeof(global::System.TimeZoneInfo.AdjustmentRule[]),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "IsValidAdjustmentRuleOffest", MemberParameters = new object[]
		{
			typeof(global::System.TimeSpan),
			typeof(global::System.TimeZoneInfo.AdjustmentRule)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeSpan), Member = "op_LessThan", MemberParameters = new object[]
		{
			typeof(global::System.TimeSpan),
			typeof(global::System.TimeSpan)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeSpan), Member = "op_GreaterThan", MemberParameters = new object[]
		{
			typeof(global::System.TimeSpan),
			typeof(global::System.TimeSpan)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal static bool UtcOffsetOutOfRange(global::System.TimeSpan offset)
		{
			throw null;
		}

		// Token: 0x060002FE RID: 766 RVA: 0x00014E7F File Offset: 0x0001307F
		[global::Cpp2ILInjected.Token(Token = "0x600035A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB1C80", Offset = "0x1BB1C80", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "IsValidAdjustmentRuleOffest", MemberParameters = new object[]
		{
			typeof(global::System.TimeSpan),
			typeof(global::System.TimeZoneInfo.AdjustmentRule)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "NormalizeAdjustmentRuleOffset", MemberParameters = new object[]
		{
			typeof(global::System.TimeSpan),
			typeof(ref global::System.TimeZoneInfo.AdjustmentRule)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeSpan), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(global::System.TimeSpan),
			typeof(global::System.TimeSpan)
		}, ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo.AdjustmentRule), Member = "get_HasDaylightSaving", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static global::System.TimeSpan GetUtcOffset(global::System.TimeSpan baseUtcOffset, global::System.TimeZoneInfo.AdjustmentRule adjustmentRule)
		{
			throw null;
		}

		// Token: 0x060002FF RID: 767 RVA: 0x00014E82 File Offset: 0x00013082
		[global::Cpp2ILInjected.Token(Token = "0x600035B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BABC58", Offset = "0x1BABC58", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "TZif_GenerateAdjustmentRule", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(global::System.TimeSpan),
			typeof(global::System.Collections.Generic.List<global::System.TimeZoneInfo.AdjustmentRule>),
			typeof(global::System.DateTime[]),
			typeof(byte[]),
			typeof(global::System.TimeZoneInfo.TZifType[]),
			typeof(bool[]),
			typeof(bool[]),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "ValidateTimeZoneInfo", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.TimeSpan),
			typeof(global::System.TimeZoneInfo.AdjustmentRule[]),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "GetUtcOffset", MemberParameters = new object[]
		{
			typeof(global::System.TimeSpan),
			typeof(global::System.TimeZoneInfo.AdjustmentRule)
		}, ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "UtcOffsetOutOfRange", MemberParameters = new object[] { typeof(global::System.TimeSpan) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static bool IsValidAdjustmentRuleOffest(global::System.TimeSpan baseUtcOffset, global::System.TimeZoneInfo.AdjustmentRule adjustmentRule)
		{
			throw null;
		}

		// Token: 0x06000300 RID: 768 RVA: 0x00014E85 File Offset: 0x00013085
		[global::Cpp2ILInjected.Token(Token = "0x600035C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BABCCC", Offset = "0x1BABCCC", Length = "0x234")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "TZif_GenerateAdjustmentRule", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(global::System.TimeSpan),
			typeof(global::System.Collections.Generic.List<global::System.TimeZoneInfo.AdjustmentRule>),
			typeof(global::System.DateTime[]),
			typeof(byte[]),
			typeof(global::System.TimeZoneInfo.TZifType[]),
			typeof(bool[]),
			typeof(bool[]),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "GetUtcOffset", MemberParameters = new object[]
		{
			typeof(global::System.TimeSpan),
			typeof(global::System.TimeZoneInfo.AdjustmentRule)
		}, ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeSpan), Member = "op_GreaterThan", MemberParameters = new object[]
		{
			typeof(global::System.TimeSpan),
			typeof(global::System.TimeSpan)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeSpan), Member = "op_LessThan", MemberParameters = new object[]
		{
			typeof(global::System.TimeSpan),
			typeof(global::System.TimeSpan)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeSpan), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(global::System.TimeSpan),
			typeof(global::System.TimeSpan)
		}, ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeSpan), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::System.TimeSpan),
			typeof(global::System.TimeSpan)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeSpan), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(global::System.TimeSpan),
			typeof(global::System.TimeSpan)
		}, ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo.AdjustmentRule), Member = "CreateAdjustmentRule", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.DateTime),
			typeof(global::System.TimeSpan),
			typeof(global::System.TimeZoneInfo.TransitionTime),
			typeof(global::System.TimeZoneInfo.TransitionTime),
			typeof(global::System.TimeSpan),
			typeof(bool)
		}, ReturnType = typeof(global::System.TimeZoneInfo.AdjustmentRule))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private static void NormalizeAdjustmentRuleOffset(global::System.TimeSpan baseUtcOffset, ref global::System.TimeZoneInfo.AdjustmentRule adjustmentRule)
		{
			throw null;
		}

		// Token: 0x06000301 RID: 769 RVA: 0x00014E88 File Offset: 0x00013088
		[global::Cpp2ILInjected.Token(Token = "0x600035D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB1D40", Offset = "0x1BB1D40", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private static string GetTimeZoneDirectoryUnity()
		{
			throw null;
		}

		// Token: 0x06000302 RID: 770 RVA: 0x00014E8B File Offset: 0x0001308B
		[global::Cpp2ILInjected.Token(Token = "0x600035E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB1D88", Offset = "0x1BB1D88", Length = "0x750")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "CreateLocalUnity", ReturnType = typeof(global::System.TimeZoneInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.CurrentSystemTimeZone), Member = "GetTimeZoneData", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref long[]),
			typeof(ref string[]),
			typeof(ref bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = ".ctor", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "Equals", MemberParameters = new object[] { typeof(global::System.DateTime) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "DaysInMonth", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo.TransitionTime), Member = "ValidateTransitionTime", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(global::System.DayOfWeek)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "get_TimeOfDay", ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "Add", MemberParameters = new object[] { typeof(global::System.TimeSpan) }, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "get_Month", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "get_Day", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "get_Year", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo.AdjustmentRule), Member = "CreateAdjustmentRule", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.DateTime),
			typeof(global::System.TimeSpan),
			typeof(global::System.TimeZoneInfo.TransitionTime),
			typeof(global::System.TimeZoneInfo.TransitionTime)
		}, ReturnType = typeof(global::System.TimeZoneInfo.AdjustmentRule))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "AddDays", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private static global::System.Collections.Generic.List<global::System.TimeZoneInfo.AdjustmentRule> CreateAdjustmentRule(int year, out long[] data, out string[] names, string standardNameCurrentYear, string daylightNameCurrentYear)
		{
			throw null;
		}

		// Token: 0x06000303 RID: 771 RVA: 0x00014E8E File Offset: 0x0001308E
		[global::Cpp2ILInjected.Token(Token = "0x600035F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BAAB40", Offset = "0x1BAAB40", Length = "0x464")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "GetLocalTimeZoneFromTzFile", ReturnType = typeof(global::System.TimeZoneInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "get_UtcNow", ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "get_Year", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.CurrentSystemTimeZone), Member = "GetTimeZoneData", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref long[]),
			typeof(ref string[]),
			typeof(ref bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeSpan), Member = "FromTicks", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeSpan), Member = "op_GreaterThanOrEqual", MemberParameters = new object[]
		{
			typeof(global::System.TimeSpan),
			typeof(global::System.TimeSpan)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeSpan), Member = "ToString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "CreateAdjustmentRule", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref long[]),
			typeof(ref string[]),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(global::System.Collections.Generic.List<global::System.TimeZoneInfo.AdjustmentRule>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>), Member = "AddRange", MemberParameters = new object[] { typeof(global::System.Collections.Generic.IEnumerable<object>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Comparison<object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>), Member = "Sort", MemberParameters = new object[] { typeof(global::System.Comparison<object>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>), Member = "ToArray", ReturnType = "T[]")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "CreateCustomTimeZone", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.TimeSpan),
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(global::System.TimeZoneInfo.AdjustmentRule[]),
			typeof(bool)
		}, ReturnType = typeof(global::System.TimeZoneInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 30)]
		private static global::System.TimeZoneInfo CreateLocalUnity()
		{
			throw null;
		}

		// Token: 0x06000304 RID: 772 RVA: 0x00014E91 File Offset: 0x00013091
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000360")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB24D8", Offset = "0x1BB24D8", Length = "0x16C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "CreateCustomTimeZone", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.TimeSpan),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(global::System.TimeZoneInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeSpan), Member = "FromHours", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeSpan), Member = "op_UnaryNegation", MemberParameters = new object[] { typeof(global::System.TimeSpan) }, ReturnType = typeof(global::System.TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		static TimeZoneInfo()
		{
			throw null;
		}

		// Token: 0x06000305 RID: 773 RVA: 0x00014E94 File Offset: 0x00013094
		[global::Cpp2ILInjected.Token(Token = "0x6000361")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB264C", Offset = "0x1BB264C", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal TimeZoneInfo()
		{
			throw null;
		}

		// Token: 0x040000EC RID: 236
		[global::Cpp2ILInjected.Token(Token = "0x40001A3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly string _id;

		// Token: 0x040000ED RID: 237
		[global::Cpp2ILInjected.Token(Token = "0x40001A4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly string _displayName;

		// Token: 0x040000EE RID: 238
		[global::Cpp2ILInjected.Token(Token = "0x40001A5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private readonly string _standardDisplayName;

		// Token: 0x040000EF RID: 239
		[global::Cpp2ILInjected.Token(Token = "0x40001A6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private readonly string _daylightDisplayName;

		// Token: 0x040000F0 RID: 240
		[global::Cpp2ILInjected.Token(Token = "0x40001A7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private readonly global::System.TimeSpan _baseUtcOffset;

		// Token: 0x040000F1 RID: 241
		[global::Cpp2ILInjected.Token(Token = "0x40001A8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private readonly bool _supportsDaylightSavingTime;

		// Token: 0x040000F2 RID: 242
		[global::Cpp2ILInjected.Token(Token = "0x40001A9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private readonly global::System.TimeZoneInfo.AdjustmentRule[] _adjustmentRules;

		// Token: 0x040000F3 RID: 243
		[global::Cpp2ILInjected.Token(Token = "0x40001AA")]
		private static readonly global::System.TimeZoneInfo s_utcTimeZone;

		// Token: 0x040000F4 RID: 244
		[global::Cpp2ILInjected.Token(Token = "0x40001AB")]
		private static global::System.TimeZoneInfo.CachedData s_cachedData;

		// Token: 0x040000F5 RID: 245
		[global::Cpp2ILInjected.Token(Token = "0x40001AC")]
		private static readonly global::System.DateTime s_maxDateOnly;

		// Token: 0x040000F6 RID: 246
		[global::Cpp2ILInjected.Token(Token = "0x40001AD")]
		private static readonly global::System.DateTime s_minDateOnly;

		// Token: 0x040000F7 RID: 247
		[global::Cpp2ILInjected.Token(Token = "0x40001AE")]
		private static readonly global::System.TimeSpan MaxOffset;

		// Token: 0x040000F8 RID: 248
		[global::Cpp2ILInjected.Token(Token = "0x40001AF")]
		private static readonly global::System.TimeSpan MinOffset;

		// Token: 0x02000572 RID: 1394
		[global::Cpp2ILInjected.Token(Token = "0x200006B")]
		private struct TZifType
		{
			// Token: 0x06003F4B RID: 16203 RVA: 0x0001F8A7 File Offset: 0x0001DAA7
			[global::Cpp2ILInjected.Token(Token = "0x6000362")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BAD904", Offset = "0x1BAD904", Length = "0x118")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "TZif_ParseRaw", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(ref global::System.TimeZoneInfo.TZifHead),
				typeof(ref global::System.DateTime[]),
				typeof(ref byte[]),
				typeof(ref global::System.TimeZoneInfo.TZifType[]),
				typeof(ref string),
				typeof(ref bool[]),
				typeof(ref bool[]),
				typeof(ref string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeSpan), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			public TZifType(byte[] data, int index)
			{
				throw null;
			}

			// Token: 0x0400175E RID: 5982
			[global::Cpp2ILInjected.Token(Token = "0x40001B0")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public readonly global::System.TimeSpan UtcOffset;

			// Token: 0x0400175F RID: 5983
			[global::Cpp2ILInjected.Token(Token = "0x40001B1")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public readonly bool IsDst;

			// Token: 0x04001760 RID: 5984
			[global::Cpp2ILInjected.Token(Token = "0x40001B2")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x9")]
			public readonly byte AbbreviationIndex;
		}

		// Token: 0x02000573 RID: 1395
		[global::Cpp2ILInjected.Token(Token = "0x200006C")]
		private struct TZifHead
		{
			// Token: 0x06003F4C RID: 16204 RVA: 0x0001F8AA File Offset: 0x0001DAAA
			[global::Cpp2ILInjected.Token(Token = "0x6000363")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BAD764", Offset = "0x1BAD764", Length = "0x1A0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "TZif_ParseRaw", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(ref global::System.TimeZoneInfo.TZifHead),
				typeof(ref global::System.DateTime[]),
				typeof(ref byte[]),
				typeof(ref global::System.TimeZoneInfo.TZifType[]),
				typeof(ref string),
				typeof(ref bool[]),
				typeof(ref bool[]),
				typeof(ref string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
			public TZifHead(byte[] data, int index)
			{
				throw null;
			}

			// Token: 0x04001761 RID: 5985
			[global::Cpp2ILInjected.Token(Token = "0x40001B3")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public readonly uint Magic;

			// Token: 0x04001762 RID: 5986
			[global::Cpp2ILInjected.Token(Token = "0x40001B4")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
			public readonly global::System.TimeZoneInfo.TZVersion Version;

			// Token: 0x04001763 RID: 5987
			[global::Cpp2ILInjected.Token(Token = "0x40001B5")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public readonly uint IsGmtCount;

			// Token: 0x04001764 RID: 5988
			[global::Cpp2ILInjected.Token(Token = "0x40001B6")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
			public readonly uint IsStdCount;

			// Token: 0x04001765 RID: 5989
			[global::Cpp2ILInjected.Token(Token = "0x40001B7")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public readonly uint LeapCount;

			// Token: 0x04001766 RID: 5990
			[global::Cpp2ILInjected.Token(Token = "0x40001B8")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
			public readonly uint TimeCount;

			// Token: 0x04001767 RID: 5991
			[global::Cpp2ILInjected.Token(Token = "0x40001B9")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public readonly uint TypeCount;

			// Token: 0x04001768 RID: 5992
			[global::Cpp2ILInjected.Token(Token = "0x40001BA")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
			public readonly uint CharCount;
		}

		// Token: 0x02000574 RID: 1396
		[global::Cpp2ILInjected.Token(Token = "0x200006D")]
		private enum TZVersion : byte
		{
			// Token: 0x0400176A RID: 5994
			[global::Cpp2ILInjected.Token(Token = "0x40001BC")]
			V1,
			// Token: 0x0400176B RID: 5995
			[global::Cpp2ILInjected.Token(Token = "0x40001BD")]
			V2,
			// Token: 0x0400176C RID: 5996
			[global::Cpp2ILInjected.Token(Token = "0x40001BE")]
			V3
		}

		// Token: 0x02000575 RID: 1397
		[global::Cpp2ILInjected.Token(Token = "0x200006E")]
		[global::System.Serializable]
		public sealed class AdjustmentRule : global::System.IEquatable<global::System.TimeZoneInfo.AdjustmentRule>, global::System.Runtime.Serialization.ISerializable, global::System.Runtime.Serialization.IDeserializationCallback
		{
			// Token: 0x1700070A RID: 1802
			// (get) Token: 0x06003F4D RID: 16205 RVA: 0x0001F8AD File Offset: 0x0001DAAD
			[global::Cpp2ILInjected.Token(Token = "0x17000047")]
			public global::System.DateTime DateStart
			{
				[global::Cpp2ILInjected.Token(Token = "0x6000364")]
				[global::Cpp2ILInjected.Address(RVA = "0x1BB2684", Offset = "0x1BB2684", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x1700070B RID: 1803
			// (get) Token: 0x06003F4E RID: 16206 RVA: 0x0001F8B0 File Offset: 0x0001DAB0
			[global::Cpp2ILInjected.Token(Token = "0x17000048")]
			public global::System.DateTime DateEnd
			{
				[global::Cpp2ILInjected.Token(Token = "0x6000365")]
				[global::Cpp2ILInjected.Address(RVA = "0x1BB268C", Offset = "0x1BB268C", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x1700070C RID: 1804
			// (get) Token: 0x06003F4F RID: 16207 RVA: 0x0001F8B3 File Offset: 0x0001DAB3
			[global::Cpp2ILInjected.Token(Token = "0x17000049")]
			public global::System.TimeSpan DaylightDelta
			{
				[global::Cpp2ILInjected.Token(Token = "0x6000366")]
				[global::Cpp2ILInjected.Address(RVA = "0x1BB2694", Offset = "0x1BB2694", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x1700070D RID: 1805
			// (get) Token: 0x06003F50 RID: 16208 RVA: 0x0001F8B6 File Offset: 0x0001DAB6
			[global::Cpp2ILInjected.Token(Token = "0x1700004A")]
			public global::System.TimeZoneInfo.TransitionTime DaylightTransitionStart
			{
				[global::Cpp2ILInjected.Token(Token = "0x6000367")]
				[global::Cpp2ILInjected.Address(RVA = "0x1BB269C", Offset = "0x1BB269C", Length = "0x14")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x1700070E RID: 1806
			// (get) Token: 0x06003F51 RID: 16209 RVA: 0x0001F8B9 File Offset: 0x0001DAB9
			[global::Cpp2ILInjected.Token(Token = "0x1700004B")]
			public global::System.TimeZoneInfo.TransitionTime DaylightTransitionEnd
			{
				[global::Cpp2ILInjected.Token(Token = "0x6000368")]
				[global::Cpp2ILInjected.Address(RVA = "0x1BB26B0", Offset = "0x1BB26B0", Length = "0x14")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x1700070F RID: 1807
			// (get) Token: 0x06003F52 RID: 16210 RVA: 0x0001F8BC File Offset: 0x0001DABC
			[global::Cpp2ILInjected.Token(Token = "0x1700004C")]
			internal global::System.TimeSpan BaseUtcOffsetDelta
			{
				[global::Cpp2ILInjected.Token(Token = "0x6000369")]
				[global::Cpp2ILInjected.Address(RVA = "0x1BB26C4", Offset = "0x1BB26C4", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000710 RID: 1808
			// (get) Token: 0x06003F53 RID: 16211 RVA: 0x0001F8BF File Offset: 0x0001DABF
			[global::Cpp2ILInjected.Token(Token = "0x1700004D")]
			internal bool NoDaylightTransitions
			{
				[global::Cpp2ILInjected.Token(Token = "0x600036A")]
				[global::Cpp2ILInjected.Address(RVA = "0x1BB26CC", Offset = "0x1BB26CC", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000711 RID: 1809
			// (get) Token: 0x06003F54 RID: 16212 RVA: 0x0001F8C2 File Offset: 0x0001DAC2
			[global::Cpp2ILInjected.Token(Token = "0x1700004E")]
			internal bool HasDaylightSaving
			{
				[global::Cpp2ILInjected.Token(Token = "0x600036B")]
				[global::Cpp2ILInjected.Address(RVA = "0x1BAE8DC", Offset = "0x1BAE8DC", Length = "0x15C")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "IsDaylightSavingTime", MemberParameters = new object[]
				{
					typeof(global::System.DateTime),
					typeof(global::System.TimeZoneInfoOptions),
					"System.TimeZoneInfo.CachedData"
				}, ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "ConvertTime", MemberParameters = new object[]
				{
					typeof(global::System.DateTime),
					typeof(global::System.TimeZoneInfo),
					typeof(global::System.TimeZoneInfo),
					typeof(global::System.TimeZoneInfoOptions),
					"System.TimeZoneInfo.CachedData"
				}, ReturnType = typeof(global::System.DateTime))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "GetUtcOffset", MemberParameters = new object[]
				{
					typeof(global::System.DateTime),
					typeof(global::System.TimeZoneInfo),
					typeof(global::System.TimeZoneInfoOptions)
				}, ReturnType = typeof(global::System.TimeSpan))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "GetUtcOffsetFromUtc", MemberParameters = new object[]
				{
					typeof(global::System.DateTime),
					typeof(global::System.TimeZoneInfo),
					typeof(ref bool),
					typeof(ref bool)
				}, ReturnType = typeof(global::System.TimeSpan))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "GetUtcOffset", MemberParameters = new object[]
				{
					typeof(global::System.TimeSpan),
					typeof(global::System.TimeZoneInfo.AdjustmentRule)
				}, ReturnType = typeof(global::System.TimeSpan))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeSpan), Member = "op_Inequality", MemberParameters = new object[]
				{
					typeof(global::System.TimeSpan),
					typeof(global::System.TimeSpan)
				}, ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo.TransitionTime), Member = "Equals", MemberParameters = new object[] { typeof(global::System.TimeZoneInfo.TransitionTime) }, ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "op_Inequality", MemberParameters = new object[]
				{
					typeof(global::System.DateTime),
					typeof(global::System.DateTime)
				}, ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "AddMilliseconds", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(global::System.DateTime))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06003F55 RID: 16213 RVA: 0x0001F8C5 File Offset: 0x0001DAC5
			[global::Cpp2ILInjected.Token(Token = "0x600036C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BAF874", Offset = "0x1BAF874", Length = "0x164")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "HasSameRules", MemberParameters = new object[] { typeof(global::System.TimeZoneInfo) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(global::System.DateTime),
				typeof(global::System.DateTime)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeSpan), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(global::System.TimeSpan),
				typeof(global::System.TimeSpan)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo.TransitionTime), Member = "Equals", MemberParameters = new object[] { typeof(global::System.TimeZoneInfo.TransitionTime) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			public bool Equals(global::System.TimeZoneInfo.AdjustmentRule other)
			{
				throw null;
			}

			// Token: 0x06003F56 RID: 16214 RVA: 0x0001F8C8 File Offset: 0x0001DAC8
			[global::Cpp2ILInjected.Token(Token = "0x600036D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BB27E0", Offset = "0x1BB27E0", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "GetHashCode", ReturnType = typeof(int))]
			public override int GetHashCode()
			{
				throw null;
			}

			// Token: 0x06003F57 RID: 16215 RVA: 0x0001F8CB File Offset: 0x0001DACB
			[global::Cpp2ILInjected.Token(Token = "0x600036E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BB27EC", Offset = "0x1BB27EC", Length = "0xC8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo.AdjustmentRule), Member = "CreateAdjustmentRule", MemberParameters = new object[]
			{
				typeof(global::System.DateTime),
				typeof(global::System.DateTime),
				typeof(global::System.TimeSpan),
				typeof(global::System.TimeZoneInfo.TransitionTime),
				typeof(global::System.TimeZoneInfo.TransitionTime)
			}, ReturnType = typeof(global::System.TimeZoneInfo.AdjustmentRule))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo.AdjustmentRule), Member = "CreateAdjustmentRule", MemberParameters = new object[]
			{
				typeof(global::System.DateTime),
				typeof(global::System.DateTime),
				typeof(global::System.TimeSpan),
				typeof(global::System.TimeZoneInfo.TransitionTime),
				typeof(global::System.TimeZoneInfo.TransitionTime),
				typeof(global::System.TimeSpan),
				typeof(bool)
			}, ReturnType = typeof(global::System.TimeZoneInfo.AdjustmentRule))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo.AdjustmentRule), Member = "ValidateAdjustmentRule", MemberParameters = new object[]
			{
				typeof(global::System.DateTime),
				typeof(global::System.DateTime),
				typeof(global::System.TimeSpan),
				typeof(global::System.TimeZoneInfo.TransitionTime),
				typeof(global::System.TimeZoneInfo.TransitionTime),
				typeof(bool)
			}, ReturnType = typeof(void))]
			private AdjustmentRule(global::System.DateTime dateStart, global::System.DateTime dateEnd, global::System.TimeSpan daylightDelta, global::System.TimeZoneInfo.TransitionTime daylightTransitionStart, global::System.TimeZoneInfo.TransitionTime daylightTransitionEnd, global::System.TimeSpan baseUtcOffsetDelta, bool noDaylightTransitions)
			{
				throw null;
			}

			// Token: 0x06003F58 RID: 16216 RVA: 0x0001F8CE File Offset: 0x0001DACE
			[global::Cpp2ILInjected.Token(Token = "0x600036F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BA93C8", Offset = "0x1BA93C8", Length = "0x108")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "GetAdjustmentRules", ReturnType = typeof(global::System.TimeZoneInfo.AdjustmentRule[]))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "CreateAdjustmentRule", MemberParameters = new object[]
			{
				typeof(int),
				typeof(ref long[]),
				typeof(ref string[]),
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(global::System.Collections.Generic.List<global::System.TimeZoneInfo.AdjustmentRule>))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo.AdjustmentRule), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(global::System.DateTime),
				typeof(global::System.DateTime),
				typeof(global::System.TimeSpan),
				typeof(global::System.TimeZoneInfo.TransitionTime),
				typeof(global::System.TimeZoneInfo.TransitionTime),
				typeof(global::System.TimeSpan),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			public static global::System.TimeZoneInfo.AdjustmentRule CreateAdjustmentRule(global::System.DateTime dateStart, global::System.DateTime dateEnd, global::System.TimeSpan daylightDelta, global::System.TimeZoneInfo.TransitionTime daylightTransitionStart, global::System.TimeZoneInfo.TransitionTime daylightTransitionEnd)
			{
				throw null;
			}

			// Token: 0x06003F59 RID: 16217 RVA: 0x0001F8D1 File Offset: 0x0001DAD1
			[global::Cpp2ILInjected.Token(Token = "0x6000370")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BABB90", Offset = "0x1BABB90", Length = "0xC8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "TZif_GenerateAdjustmentRule", MemberParameters = new object[]
			{
				typeof(ref int),
				typeof(global::System.TimeSpan),
				typeof(global::System.Collections.Generic.List<global::System.TimeZoneInfo.AdjustmentRule>),
				typeof(global::System.DateTime[]),
				typeof(byte[]),
				typeof(global::System.TimeZoneInfo.TZifType[]),
				typeof(bool[]),
				typeof(bool[]),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "TZif_CreateAdjustmentRuleForPosixFormat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(global::System.DateTime),
				typeof(global::System.TimeSpan)
			}, ReturnType = typeof(global::System.TimeZoneInfo.AdjustmentRule))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "NormalizeAdjustmentRuleOffset", MemberParameters = new object[]
			{
				typeof(global::System.TimeSpan),
				typeof(ref global::System.TimeZoneInfo.AdjustmentRule)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo.AdjustmentRule), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(global::System.DateTime),
				typeof(global::System.DateTime),
				typeof(global::System.TimeSpan),
				typeof(global::System.TimeZoneInfo.TransitionTime),
				typeof(global::System.TimeZoneInfo.TransitionTime),
				typeof(global::System.TimeSpan),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal static global::System.TimeZoneInfo.AdjustmentRule CreateAdjustmentRule(global::System.DateTime dateStart, global::System.DateTime dateEnd, global::System.TimeSpan daylightDelta, global::System.TimeZoneInfo.TransitionTime daylightTransitionStart, global::System.TimeZoneInfo.TransitionTime daylightTransitionEnd, global::System.TimeSpan baseUtcOffsetDelta, bool noDaylightTransitions)
			{
				throw null;
			}

			// Token: 0x06003F5A RID: 16218 RVA: 0x0001F8D4 File Offset: 0x0001DAD4
			[global::Cpp2ILInjected.Token(Token = "0x6000371")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BB0BCC", Offset = "0x1BB0BCC", Length = "0xB0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "GetIsDaylightSavings", MemberParameters = new object[]
			{
				typeof(global::System.DateTime),
				typeof(global::System.TimeZoneInfo.AdjustmentRule),
				typeof(global::System.Globalization.DaylightTimeStruct),
				typeof(global::System.TimeZoneInfoOptions)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "GetIsDaylightSavingsFromUtc", MemberParameters = new object[]
			{
				typeof(global::System.DateTime),
				typeof(int),
				typeof(global::System.TimeSpan),
				typeof(global::System.TimeZoneInfo.AdjustmentRule),
				typeof(int?),
				typeof(ref bool),
				typeof(global::System.TimeZoneInfo)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "GetIsAmbiguousTime", MemberParameters = new object[]
			{
				typeof(global::System.DateTime),
				typeof(global::System.TimeZoneInfo.AdjustmentRule),
				typeof(global::System.Globalization.DaylightTimeStruct)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "GetIsInvalidTime", MemberParameters = new object[]
			{
				typeof(global::System.DateTime),
				typeof(global::System.TimeZoneInfo.AdjustmentRule),
				typeof(global::System.Globalization.DaylightTimeStruct)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "get_Hour", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "get_Minute", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "get_Second", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "get_Year", ReturnType = typeof(int))]
			internal bool IsStartDateMarkerForBeginningOfYear()
			{
				throw null;
			}

			// Token: 0x06003F5B RID: 16219 RVA: 0x0001F8D7 File Offset: 0x0001DAD7
			[global::Cpp2ILInjected.Token(Token = "0x6000372")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BB0C7C", Offset = "0x1BB0C7C", Length = "0xB0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "GetIsDaylightSavings", MemberParameters = new object[]
			{
				typeof(global::System.DateTime),
				typeof(global::System.TimeZoneInfo.AdjustmentRule),
				typeof(global::System.Globalization.DaylightTimeStruct),
				typeof(global::System.TimeZoneInfoOptions)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "GetIsDaylightSavingsFromUtc", MemberParameters = new object[]
			{
				typeof(global::System.DateTime),
				typeof(int),
				typeof(global::System.TimeSpan),
				typeof(global::System.TimeZoneInfo.AdjustmentRule),
				typeof(int?),
				typeof(ref bool),
				typeof(global::System.TimeZoneInfo)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "GetIsAmbiguousTime", MemberParameters = new object[]
			{
				typeof(global::System.DateTime),
				typeof(global::System.TimeZoneInfo.AdjustmentRule),
				typeof(global::System.Globalization.DaylightTimeStruct)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "GetIsInvalidTime", MemberParameters = new object[]
			{
				typeof(global::System.DateTime),
				typeof(global::System.TimeZoneInfo.AdjustmentRule),
				typeof(global::System.Globalization.DaylightTimeStruct)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "get_Hour", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "get_Minute", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "get_Second", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "get_Year", ReturnType = typeof(int))]
			internal bool IsEndDateMarkerForEndOfYear()
			{
				throw null;
			}

			// Token: 0x06003F5C RID: 16220 RVA: 0x0001F8DA File Offset: 0x0001DADA
			[global::Cpp2ILInjected.Token(Token = "0x6000373")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BB28B4", Offset = "0x1BB28B4", Length = "0x42C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo.AdjustmentRule), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(global::System.DateTime),
				typeof(global::System.DateTime),
				typeof(global::System.TimeSpan),
				typeof(global::System.TimeZoneInfo.TransitionTime),
				typeof(global::System.TimeZoneInfo.TransitionTime),
				typeof(global::System.TimeSpan),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo.AdjustmentRule), Member = "System.Runtime.Serialization.IDeserializationCallback.OnDeserialization", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "get_Kind", ReturnType = typeof(global::System.DateTimeKind))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo.TransitionTime), Member = "Equals", MemberParameters = new object[] { typeof(global::System.TimeZoneInfo.TransitionTime) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "op_GreaterThan", MemberParameters = new object[]
			{
				typeof(global::System.DateTime),
				typeof(global::System.DateTime)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeSpan), Member = "get_TotalHours", ReturnType = typeof(double))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "op_Inequality", MemberParameters = new object[]
			{
				typeof(global::System.DateTime),
				typeof(global::System.DateTime)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "get_TimeOfDay", ReturnType = typeof(global::System.TimeSpan))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeSpan), Member = "op_Inequality", MemberParameters = new object[]
			{
				typeof(global::System.TimeSpan),
				typeof(global::System.TimeSpan)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(object),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 36)]
			private static void ValidateAdjustmentRule(global::System.DateTime dateStart, global::System.DateTime dateEnd, global::System.TimeSpan daylightDelta, global::System.TimeZoneInfo.TransitionTime daylightTransitionStart, global::System.TimeZoneInfo.TransitionTime daylightTransitionEnd, bool noDaylightTransitions)
			{
				throw null;
			}

			// Token: 0x06003F5D RID: 16221 RVA: 0x0001F8DD File Offset: 0x0001DADD
			[global::Cpp2ILInjected.Token(Token = "0x6000374")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BB2D1C", Offset = "0x1BB2D1C", Length = "0x114")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo.AdjustmentRule), Member = "ValidateAdjustmentRule", MemberParameters = new object[]
			{
				typeof(global::System.DateTime),
				typeof(global::System.DateTime),
				typeof(global::System.TimeSpan),
				typeof(global::System.TimeZoneInfo.TransitionTime),
				typeof(global::System.TimeZoneInfo.TransitionTime),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(global::System.Exception)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
			private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender)
			{
				throw null;
			}

			// Token: 0x06003F5E RID: 16222 RVA: 0x0001F8E0 File Offset: 0x0001DAE0
			[global::Cpp2ILInjected.Token(Token = "0x6000375")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BB2E30", Offset = "0x1BB2E30", Length = "0x240")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "AddValue", MemberParameters = new object[]
			{
				typeof(string),
				typeof(global::System.DateTime)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "AddValue", MemberParameters = new object[]
			{
				typeof(string),
				typeof(object)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "AddValue", MemberParameters = new object[]
			{
				typeof(string),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
			private void System.Runtime.Serialization.ISerializable.GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
			{
				throw null;
			}

			// Token: 0x06003F5F RID: 16223 RVA: 0x0001F8E3 File Offset: 0x0001DAE3
			[global::Cpp2ILInjected.Token(Token = "0x6000376")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BB3070", Offset = "0x1BB3070", Length = "0x3FC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "GetValue", MemberParameters = new object[]
			{
				typeof(string),
				typeof(global::System.Type)
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "GetValueNoThrow", MemberParameters = new object[]
			{
				typeof(string),
				typeof(global::System.Type)
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 31)]
			private AdjustmentRule(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
			{
				throw null;
			}

			// Token: 0x06003F60 RID: 16224 RVA: 0x0001F8E6 File Offset: 0x0001DAE6
			[global::Cpp2ILInjected.Token(Token = "0x6000377")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BB346C", Offset = "0x1BB346C", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal AdjustmentRule()
			{
				throw null;
			}

			// Token: 0x0400176D RID: 5997
			[global::Cpp2ILInjected.Token(Token = "0x40001BF")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private readonly global::System.DateTime _dateStart;

			// Token: 0x0400176E RID: 5998
			[global::Cpp2ILInjected.Token(Token = "0x40001C0")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private readonly global::System.DateTime _dateEnd;

			// Token: 0x0400176F RID: 5999
			[global::Cpp2ILInjected.Token(Token = "0x40001C1")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private readonly global::System.TimeSpan _daylightDelta;

			// Token: 0x04001770 RID: 6000
			[global::Cpp2ILInjected.Token(Token = "0x40001C2")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			private readonly global::System.TimeZoneInfo.TransitionTime _daylightTransitionStart;

			// Token: 0x04001771 RID: 6001
			[global::Cpp2ILInjected.Token(Token = "0x40001C3")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
			private readonly global::System.TimeZoneInfo.TransitionTime _daylightTransitionEnd;

			// Token: 0x04001772 RID: 6002
			[global::Cpp2ILInjected.Token(Token = "0x40001C4")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
			private readonly global::System.TimeSpan _baseUtcOffsetDelta;

			// Token: 0x04001773 RID: 6003
			[global::Cpp2ILInjected.Token(Token = "0x40001C5")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
			private readonly bool _noDaylightTransitions;
		}

		// Token: 0x02000576 RID: 1398
		[global::Cpp2ILInjected.Token(Token = "0x200006F")]
		[global::System.Serializable]
		public readonly struct TransitionTime : global::System.IEquatable<global::System.TimeZoneInfo.TransitionTime>, global::System.Runtime.Serialization.ISerializable, global::System.Runtime.Serialization.IDeserializationCallback
		{
			// Token: 0x17000712 RID: 1810
			// (get) Token: 0x06003F61 RID: 16225 RVA: 0x0001F8E9 File Offset: 0x0001DAE9
			[global::Cpp2ILInjected.Token(Token = "0x1700004F")]
			public global::System.DateTime TimeOfDay
			{
				[global::Cpp2ILInjected.Token(Token = "0x6000378")]
				[global::Cpp2ILInjected.Address(RVA = "0x1BB34A4", Offset = "0x1BB34A4", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000713 RID: 1811
			// (get) Token: 0x06003F62 RID: 16226 RVA: 0x0001F8EC File Offset: 0x0001DAEC
			[global::Cpp2ILInjected.Token(Token = "0x17000050")]
			public int Month
			{
				[global::Cpp2ILInjected.Token(Token = "0x6000379")]
				[global::Cpp2ILInjected.Address(RVA = "0x1BB34AC", Offset = "0x1BB34AC", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000714 RID: 1812
			// (get) Token: 0x06003F63 RID: 16227 RVA: 0x0001F8EF File Offset: 0x0001DAEF
			[global::Cpp2ILInjected.Token(Token = "0x17000051")]
			public int Week
			{
				[global::Cpp2ILInjected.Token(Token = "0x600037A")]
				[global::Cpp2ILInjected.Address(RVA = "0x1BB34B4", Offset = "0x1BB34B4", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000715 RID: 1813
			// (get) Token: 0x06003F64 RID: 16228 RVA: 0x0001F8F2 File Offset: 0x0001DAF2
			[global::Cpp2ILInjected.Token(Token = "0x17000052")]
			public int Day
			{
				[global::Cpp2ILInjected.Token(Token = "0x600037B")]
				[global::Cpp2ILInjected.Address(RVA = "0x1BB34BC", Offset = "0x1BB34BC", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000716 RID: 1814
			// (get) Token: 0x06003F65 RID: 16229 RVA: 0x0001F8F5 File Offset: 0x0001DAF5
			[global::Cpp2ILInjected.Token(Token = "0x17000053")]
			public global::System.DayOfWeek DayOfWeek
			{
				[global::Cpp2ILInjected.Token(Token = "0x600037C")]
				[global::Cpp2ILInjected.Address(RVA = "0x1BB34C4", Offset = "0x1BB34C4", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000717 RID: 1815
			// (get) Token: 0x06003F66 RID: 16230 RVA: 0x0001F8F8 File Offset: 0x0001DAF8
			[global::Cpp2ILInjected.Token(Token = "0x17000054")]
			public bool IsFixedDateRule
			{
				[global::Cpp2ILInjected.Token(Token = "0x600037D")]
				[global::Cpp2ILInjected.Address(RVA = "0x1BB34CC", Offset = "0x1BB34CC", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06003F67 RID: 16231 RVA: 0x0001F8FB File Offset: 0x0001DAFB
			[global::Cpp2ILInjected.Token(Token = "0x600037E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BB34D4", Offset = "0x1BB34D4", Length = "0x90")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo.TransitionTime), Member = "Equals", MemberParameters = new object[] { typeof(global::System.TimeZoneInfo.TransitionTime) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public override bool Equals(object obj)
			{
				throw null;
			}

			// Token: 0x06003F68 RID: 16232 RVA: 0x0001F8FE File Offset: 0x0001DAFE
			[global::Cpp2ILInjected.Token(Token = "0x600037F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BB26D4", Offset = "0x1BB26D4", Length = "0x34")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo.TransitionTime), Member = "Equals", MemberParameters = new object[] { typeof(global::System.TimeZoneInfo.TransitionTime) }, ReturnType = typeof(bool))]
			public static bool operator !=(global::System.TimeZoneInfo.TransitionTime t1, global::System.TimeZoneInfo.TransitionTime t2)
			{
				throw null;
			}

			// Token: 0x06003F69 RID: 16233 RVA: 0x0001F901 File Offset: 0x0001DB01
			[global::Cpp2ILInjected.Token(Token = "0x6000380")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BB2708", Offset = "0x1BB2708", Length = "0xD8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo.AdjustmentRule), Member = "get_HasDaylightSaving", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo.AdjustmentRule), Member = "Equals", MemberParameters = new object[] { typeof(global::System.TimeZoneInfo.AdjustmentRule) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo.AdjustmentRule), Member = "ValidateAdjustmentRule", MemberParameters = new object[]
			{
				typeof(global::System.DateTime),
				typeof(global::System.DateTime),
				typeof(global::System.TimeSpan),
				typeof(global::System.TimeZoneInfo.TransitionTime),
				typeof(global::System.TimeZoneInfo.TransitionTime),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo.TransitionTime), Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo.TransitionTime), Member = "op_Inequality", MemberParameters = new object[]
			{
				typeof(global::System.TimeZoneInfo.TransitionTime),
				typeof(global::System.TimeZoneInfo.TransitionTime)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(global::System.DateTime),
				typeof(global::System.DateTime)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public bool Equals(global::System.TimeZoneInfo.TransitionTime other)
			{
				throw null;
			}

			// Token: 0x06003F6A RID: 16234 RVA: 0x0001F904 File Offset: 0x0001DB04
			[global::Cpp2ILInjected.Token(Token = "0x6000381")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BB3564", Offset = "0x1BB3564", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override int GetHashCode()
			{
				throw null;
			}

			// Token: 0x06003F6B RID: 16235 RVA: 0x0001F907 File Offset: 0x0001DB07
			[global::Cpp2ILInjected.Token(Token = "0x6000382")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BB3578", Offset = "0x1BB3578", Length = "0x70")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo.TransitionTime), Member = "ValidateTransitionTime", MemberParameters = new object[]
			{
				typeof(global::System.DateTime),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(global::System.DayOfWeek)
			}, ReturnType = typeof(void))]
			private TransitionTime(global::System.DateTime timeOfDay, int month, int week, int day, global::System.DayOfWeek dayOfWeek, bool isFixedDateRule)
			{
				throw null;
			}

			// Token: 0x06003F6C RID: 16236 RVA: 0x0001F90A File Offset: 0x0001DB0A
			[global::Cpp2ILInjected.Token(Token = "0x6000383")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BA9368", Offset = "0x1BA9368", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo.TransitionTime), Member = "ValidateTransitionTime", MemberParameters = new object[]
			{
				typeof(global::System.DateTime),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(global::System.DayOfWeek)
			}, ReturnType = typeof(void))]
			public static global::System.TimeZoneInfo.TransitionTime CreateFixedDateRule(global::System.DateTime timeOfDay, int month, int day)
			{
				throw null;
			}

			// Token: 0x06003F6D RID: 16237 RVA: 0x0001F90D File Offset: 0x0001DB0D
			[global::Cpp2ILInjected.Token(Token = "0x6000384")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BACCE0", Offset = "0x1BACCE0", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo.TransitionTime), Member = "ValidateTransitionTime", MemberParameters = new object[]
			{
				typeof(global::System.DateTime),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(global::System.DayOfWeek)
			}, ReturnType = typeof(void))]
			public static global::System.TimeZoneInfo.TransitionTime CreateFloatingDateRule(global::System.DateTime timeOfDay, int month, int week, global::System.DayOfWeek dayOfWeek)
			{
				throw null;
			}

			// Token: 0x06003F6E RID: 16238 RVA: 0x0001F910 File Offset: 0x0001DB10
			[global::Cpp2ILInjected.Token(Token = "0x6000385")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BB35E8", Offset = "0x1BB35E8", Length = "0x234")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo.TransitionTime), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(global::System.DateTime),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(global::System.DayOfWeek),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo.TransitionTime), Member = "CreateFixedDateRule", MemberParameters = new object[]
			{
				typeof(global::System.DateTime),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(global::System.TimeZoneInfo.TransitionTime))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo.TransitionTime), Member = "CreateFloatingDateRule", MemberParameters = new object[]
			{
				typeof(global::System.DateTime),
				typeof(int),
				typeof(int),
				typeof(global::System.DayOfWeek)
			}, ReturnType = typeof(global::System.TimeZoneInfo.TransitionTime))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo.TransitionTime), Member = "System.Runtime.Serialization.IDeserializationCallback.OnDeserialization", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "GetAdjustmentRules", ReturnType = typeof(global::System.TimeZoneInfo.AdjustmentRule[]))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "TZif_GenerateAdjustmentRule", MemberParameters = new object[]
			{
				typeof(ref int),
				typeof(global::System.TimeSpan),
				typeof(global::System.Collections.Generic.List<global::System.TimeZoneInfo.AdjustmentRule>),
				typeof(global::System.DateTime[]),
				typeof(byte[]),
				typeof(global::System.TimeZoneInfo.TZifType[]),
				typeof(bool[]),
				typeof(bool[]),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "TZif_CreateTransitionTimeFromPosixRule", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(global::System.TimeZoneInfo.TransitionTime))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "CreateAdjustmentRule", MemberParameters = new object[]
			{
				typeof(int),
				typeof(ref long[]),
				typeof(ref string[]),
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(global::System.Collections.Generic.List<global::System.TimeZoneInfo.AdjustmentRule>))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 15)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "get_Kind", ReturnType = typeof(global::System.DateTimeKind))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "GetDatePart", MemberParameters = new object[]
			{
				typeof(ref int),
				typeof(ref int),
				typeof(ref int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "get_Ticks", ReturnType = typeof(long))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
			private static void ValidateTransitionTime(global::System.DateTime timeOfDay, int month, int week, int day, global::System.DayOfWeek dayOfWeek)
			{
				throw null;
			}

			// Token: 0x06003F6F RID: 16239 RVA: 0x0001F913 File Offset: 0x0001DB13
			[global::Cpp2ILInjected.Token(Token = "0x6000386")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BB381C", Offset = "0x1BB381C", Length = "0xEC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo.TransitionTime), Member = "ValidateTransitionTime", MemberParameters = new object[]
			{
				typeof(global::System.DateTime),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(global::System.DayOfWeek)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(global::System.Exception)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
			private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender)
			{
				throw null;
			}

			// Token: 0x06003F70 RID: 16240 RVA: 0x0001F916 File Offset: 0x0001DB16
			[global::Cpp2ILInjected.Token(Token = "0x6000387")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BB3908", Offset = "0x1BB3908", Length = "0x1A8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "AddValue", MemberParameters = new object[]
			{
				typeof(string),
				typeof(global::System.DateTime)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "AddValue", MemberParameters = new object[]
			{
				typeof(string),
				typeof(byte)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "AddValue", MemberParameters = new object[]
			{
				typeof(string),
				typeof(object)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "AddValue", MemberParameters = new object[]
			{
				typeof(string),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
			private void System.Runtime.Serialization.ISerializable.GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
			{
				throw null;
			}

			// Token: 0x06003F71 RID: 16241 RVA: 0x0001F919 File Offset: 0x0001DB19
			[global::Cpp2ILInjected.Token(Token = "0x6000388")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BB3AB0", Offset = "0x1BB3AB0", Length = "0x35C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "GetValue", MemberParameters = new object[]
			{
				typeof(string),
				typeof(global::System.Type)
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 28)]
			private TransitionTime(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
			{
				throw null;
			}

			// Token: 0x04001774 RID: 6004
			[global::Cpp2ILInjected.Token(Token = "0x40001C6")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private readonly global::System.DateTime _timeOfDay;

			// Token: 0x04001775 RID: 6005
			[global::Cpp2ILInjected.Token(Token = "0x40001C7")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			private readonly byte _month;

			// Token: 0x04001776 RID: 6006
			[global::Cpp2ILInjected.Token(Token = "0x40001C8")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x9")]
			private readonly byte _week;

			// Token: 0x04001777 RID: 6007
			[global::Cpp2ILInjected.Token(Token = "0x40001C9")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xA")]
			private readonly byte _day;

			// Token: 0x04001778 RID: 6008
			[global::Cpp2ILInjected.Token(Token = "0x40001CA")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
			private readonly global::System.DayOfWeek _dayOfWeek;

			// Token: 0x04001779 RID: 6009
			[global::Cpp2ILInjected.Token(Token = "0x40001CB")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private readonly bool _isFixedDateRule;
		}

		// Token: 0x02000577 RID: 1399
		[global::Cpp2ILInjected.Token(Token = "0x2000070")]
		private sealed class CachedData
		{
			// Token: 0x06003F72 RID: 16242 RVA: 0x0001F91C File Offset: 0x0001DB1C
			[global::Cpp2ILInjected.Token(Token = "0x6000389")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BB3E0C", Offset = "0x1BB3E0C", Length = "0x178")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo.CachedData), Member = "get_Local", ReturnType = typeof(global::System.TimeZoneInfo))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "GetLocalUtcOffset", MemberParameters = new object[]
			{
				typeof(global::System.DateTime),
				typeof(global::System.TimeZoneInfoOptions)
			}, ReturnType = typeof(global::System.TimeSpan))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "GetUtcOffset", MemberParameters = new object[]
			{
				typeof(global::System.DateTime),
				typeof(global::System.TimeZoneInfoOptions),
				typeof(global::System.TimeZoneInfo.CachedData)
			}, ReturnType = typeof(global::System.TimeSpan))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "IsDaylightSavingTime", MemberParameters = new object[]
			{
				typeof(global::System.DateTime),
				typeof(global::System.TimeZoneInfoOptions),
				typeof(global::System.TimeZoneInfo.CachedData)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "ConvertTimeToUtc", MemberParameters = new object[]
			{
				typeof(global::System.DateTime),
				typeof(global::System.TimeZoneInfoOptions)
			}, ReturnType = typeof(global::System.DateTime))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "get_Local", ReturnType = typeof(global::System.TimeZoneInfo))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
			{
				typeof(object),
				typeof(ref bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "GetLocalTimeZone", MemberParameters = new object[] { typeof(global::System.TimeZoneInfo.CachedData) }, ReturnType = typeof(global::System.TimeZoneInfo))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(global::System.TimeSpan),
				typeof(string),
				typeof(string),
				typeof(string),
				typeof(global::System.TimeZoneInfo.AdjustmentRule[]),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
			private global::System.TimeZoneInfo CreateLocal()
			{
				throw null;
			}

			// Token: 0x17000718 RID: 1816
			// (get) Token: 0x06003F73 RID: 16243 RVA: 0x0001F91F File Offset: 0x0001DB1F
			[global::Cpp2ILInjected.Token(Token = "0x17000055")]
			public global::System.TimeZoneInfo Local
			{
				[global::Cpp2ILInjected.Token(Token = "0x600038A")]
				[global::Cpp2ILInjected.Address(RVA = "0x1BADE68", Offset = "0x1BADE68", Length = "0x38")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo.CachedData), Member = "CreateLocal", ReturnType = typeof(global::System.TimeZoneInfo))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06003F74 RID: 16244 RVA: 0x0001F922 File Offset: 0x0001DB22
			[global::Cpp2ILInjected.Token(Token = "0x600038B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BADF18", Offset = "0x1BADF18", Length = "0x8C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "GetUtcOffset", MemberParameters = new object[]
			{
				typeof(global::System.DateTime),
				typeof(global::System.TimeZoneInfoOptions),
				typeof(global::System.TimeZoneInfo.CachedData)
			}, ReturnType = typeof(global::System.TimeSpan))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "IsDaylightSavingTime", MemberParameters = new object[]
			{
				typeof(global::System.DateTime),
				typeof(global::System.TimeZoneInfoOptions),
				typeof(global::System.TimeZoneInfo.CachedData)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo), Member = "ConvertTime", MemberParameters = new object[]
			{
				typeof(global::System.DateTime),
				typeof(global::System.TimeZoneInfo),
				typeof(global::System.TimeZoneInfo),
				typeof(global::System.TimeZoneInfoOptions),
				typeof(global::System.TimeZoneInfo.CachedData)
			}, ReturnType = typeof(global::System.DateTime))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			public global::System.DateTimeKind GetCorrespondingKind(global::System.TimeZoneInfo timeZone)
			{
				throw null;
			}

			// Token: 0x06003F75 RID: 16245 RVA: 0x0001F925 File Offset: 0x0001DB25
			[global::Cpp2ILInjected.Token(Token = "0x600038C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BB2644", Offset = "0x1BB2644", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public CachedData()
			{
				throw null;
			}

			// Token: 0x0400177A RID: 6010
			[global::Cpp2ILInjected.Token(Token = "0x40001CC")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private global::System.TimeZoneInfo _localTimeZone;
		}

		// Token: 0x02000578 RID: 1400
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000071")]
		private sealed class <>c__DisplayClass16_0
		{
			// Token: 0x06003F76 RID: 16246 RVA: 0x0001F928 File Offset: 0x0001DB28
			[global::Cpp2ILInjected.Token(Token = "0x600038D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BAA644", Offset = "0x1BAA644", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass16_0()
			{
				throw null;
			}

			// Token: 0x06003F77 RID: 16247 RVA: 0x0001F92B File Offset: 0x0001DB2B
			[global::Cpp2ILInjected.Token(Token = "0x600038E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BB3F84", Offset = "0x1BB3F84", Length = "0xE0")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string),
				typeof(global::System.StringComparison)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo), Member = "CompareTimeZoneFile", MemberParameters = new object[]
			{
				typeof(string),
				typeof(byte[]),
				typeof(byte[])
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new object[]
			{
				typeof(string),
				typeof(global::System.StringComparison)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal bool <FindTimeZoneId>b__0(string filePath)
			{
				throw null;
			}

			// Token: 0x0400177B RID: 6011
			[global::Cpp2ILInjected.Token(Token = "0x40001CD")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public string localtimeFilePath;

			// Token: 0x0400177C RID: 6012
			[global::Cpp2ILInjected.Token(Token = "0x40001CE")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public string posixrulesFilePath;

			// Token: 0x0400177D RID: 6013
			[global::Cpp2ILInjected.Token(Token = "0x40001CF")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public byte[] buffer;

			// Token: 0x0400177E RID: 6014
			[global::Cpp2ILInjected.Token(Token = "0x40001D0")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public byte[] rawData;

			// Token: 0x0400177F RID: 6015
			[global::Cpp2ILInjected.Token(Token = "0x40001D1")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			public string id;

			// Token: 0x04001780 RID: 6016
			[global::Cpp2ILInjected.Token(Token = "0x40001D2")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			public string timeZoneDirectory;
		}

		// Token: 0x02000579 RID: 1401
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000072")]
		[global::System.Serializable]
		private sealed class <>c
		{
			// Token: 0x06003F78 RID: 16248 RVA: 0x0001F92E File Offset: 0x0001DB2E
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x600038F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BB4064", Offset = "0x1BB4064", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			static <>c()
			{
				throw null;
			}

			// Token: 0x06003F79 RID: 16249 RVA: 0x0001F931 File Offset: 0x0001DB31
			[global::Cpp2ILInjected.Token(Token = "0x6000390")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BB40C0", Offset = "0x1BB40C0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c()
			{
				throw null;
			}

			// Token: 0x06003F7A RID: 16250 RVA: 0x0001F934 File Offset: 0x0001DB34
			[global::Cpp2ILInjected.Token(Token = "0x6000391")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BB40C8", Offset = "0x1BB40C8", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal bool <TZif_ParsePosixName>b__34_1(char c)
			{
				throw null;
			}

			// Token: 0x06003F7B RID: 16251 RVA: 0x0001F937 File Offset: 0x0001DB37
			[global::Cpp2ILInjected.Token(Token = "0x6000392")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BB40D8", Offset = "0x1BB40D8", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "IsDigit", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal bool <TZif_ParsePosixName>b__34_0(char c)
			{
				throw null;
			}

			// Token: 0x06003F7C RID: 16252 RVA: 0x0001F93A File Offset: 0x0001DB3A
			[global::Cpp2ILInjected.Token(Token = "0x6000393")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BB41DC", Offset = "0x1BB41DC", Length = "0x88")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "IsDigit", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal bool <TZif_ParsePosixOffset>b__35_0(char c)
			{
				throw null;
			}

			// Token: 0x06003F7D RID: 16253 RVA: 0x0001F93D File Offset: 0x0001DB3D
			[global::Cpp2ILInjected.Token(Token = "0x6000394")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BB4264", Offset = "0x1BB4264", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal bool <TZif_ParsePosixDate>b__37_0(char c)
			{
				throw null;
			}

			// Token: 0x06003F7E RID: 16254 RVA: 0x0001F940 File Offset: 0x0001DB40
			[global::Cpp2ILInjected.Token(Token = "0x6000395")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BB4280", Offset = "0x1BB4280", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal bool <TZif_ParsePosixTime>b__38_0(char c)
			{
				throw null;
			}

			// Token: 0x06003F7F RID: 16255 RVA: 0x0001F943 File Offset: 0x0001DB43
			[global::Cpp2ILInjected.Token(Token = "0x6000396")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BB4290", Offset = "0x1BB4290", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "CompareTo", MemberParameters = new object[] { typeof(global::System.DateTime) }, ReturnType = typeof(int))]
			internal int <CreateLocalUnity>b__161_0(global::System.TimeZoneInfo.AdjustmentRule rule1, global::System.TimeZoneInfo.AdjustmentRule rule2)
			{
				throw null;
			}

			// Token: 0x04001781 RID: 6017
			[global::Cpp2ILInjected.Token(Token = "0x40001D3")]
			public static readonly global::System.TimeZoneInfo.<>c <>9;

			// Token: 0x04001782 RID: 6018
			[global::Cpp2ILInjected.Token(Token = "0x40001D4")]
			public static global::System.Func<char, bool> <>9__34_1;

			// Token: 0x04001783 RID: 6019
			[global::Cpp2ILInjected.Token(Token = "0x40001D5")]
			public static global::System.Func<char, bool> <>9__34_0;

			// Token: 0x04001784 RID: 6020
			[global::Cpp2ILInjected.Token(Token = "0x40001D6")]
			public static global::System.Func<char, bool> <>9__35_0;

			// Token: 0x04001785 RID: 6021
			[global::Cpp2ILInjected.Token(Token = "0x40001D7")]
			public static global::System.Func<char, bool> <>9__37_0;

			// Token: 0x04001786 RID: 6022
			[global::Cpp2ILInjected.Token(Token = "0x40001D8")]
			public static global::System.Func<char, bool> <>9__38_0;

			// Token: 0x04001787 RID: 6023
			[global::Cpp2ILInjected.Token(Token = "0x40001D9")]
			public static global::System.Comparison<global::System.TimeZoneInfo.AdjustmentRule> <>9__161_0;
		}
	}
}
