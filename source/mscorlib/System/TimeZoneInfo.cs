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
	[global::System.Runtime.CompilerServices.TypeForwardedFrom("System.Core, Version=2.0.5.0, Culture=Neutral, PublicKeyToken=7cec85d7bea7798e")]
	[global::Cpp2ILInjected.Token(Token = "0x200006A")]
	[global::System.Serializable]
	public sealed class TimeZoneInfo : global::System.IEquatable<global::System.TimeZoneInfo>, global::System.Runtime.Serialization.ISerializable, global::System.Runtime.Serialization.IDeserializationCallback
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x6000304")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BA94D0", Offset = "0x1BA94D0", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TimeZoneInfo.CachedData), Member = "CreateLocal", ReturnType = typeof(global::System.TimeZoneInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static global::System.TimeZoneInfo GetLocalTimeZone(global::System.TimeZoneInfo.CachedData cachedData)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x6000323")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BAD5A8", Offset = "0x1BAD5A8", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static int TZif_ToInt32(byte[] value, int startIndex)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x6000332")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BAE228", Offset = "0x1BAE228", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DateTime), Member = "IsDaylightSavingTime", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal bool IsDaylightSavingTime(global::System.DateTime dateTime, global::System.TimeZoneInfoOptions flags)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x6000339")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BAF7DC", Offset = "0x1BAF7DC", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override int GetHashCode()
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x600033C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BAF9D8", Offset = "0x1BAF9D8", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override string ToString()
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x6000347")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB07AC", Offset = "0x1BB07AC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private global::System.DateTime ConvertToUtc(global::System.DateTime dateTime, global::System.TimeSpan daylightDelta, global::System.TimeSpan baseUtcOffsetDelta)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x600035D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB1D40", Offset = "0x1BB1D40", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private static string GetTimeZoneDirectoryUnity()
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x6000361")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB264C", Offset = "0x1BB264C", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal TimeZoneInfo()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40001A3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly string _id;

		[global::Cpp2ILInjected.Token(Token = "0x40001A4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly string _displayName;

		[global::Cpp2ILInjected.Token(Token = "0x40001A5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private readonly string _standardDisplayName;

		[global::Cpp2ILInjected.Token(Token = "0x40001A6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private readonly string _daylightDisplayName;

		[global::Cpp2ILInjected.Token(Token = "0x40001A7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private readonly global::System.TimeSpan _baseUtcOffset;

		[global::Cpp2ILInjected.Token(Token = "0x40001A8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private readonly bool _supportsDaylightSavingTime;

		[global::Cpp2ILInjected.Token(Token = "0x40001A9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private readonly global::System.TimeZoneInfo.AdjustmentRule[] _adjustmentRules;

		[global::Cpp2ILInjected.Token(Token = "0x40001AA")]
		private static readonly global::System.TimeZoneInfo s_utcTimeZone;

		[global::Cpp2ILInjected.Token(Token = "0x40001AB")]
		private static global::System.TimeZoneInfo.CachedData s_cachedData;

		[global::Cpp2ILInjected.Token(Token = "0x40001AC")]
		private static readonly global::System.DateTime s_maxDateOnly;

		[global::Cpp2ILInjected.Token(Token = "0x40001AD")]
		private static readonly global::System.DateTime s_minDateOnly;

		[global::Cpp2ILInjected.Token(Token = "0x40001AE")]
		private static readonly global::System.TimeSpan MaxOffset;

		[global::Cpp2ILInjected.Token(Token = "0x40001AF")]
		private static readonly global::System.TimeSpan MinOffset;

		[global::Cpp2ILInjected.Token(Token = "0x200006B")]
		private struct TZifType
		{
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

			[global::Cpp2ILInjected.Token(Token = "0x40001B0")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public readonly global::System.TimeSpan UtcOffset;

			[global::Cpp2ILInjected.Token(Token = "0x40001B1")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public readonly bool IsDst;

			[global::Cpp2ILInjected.Token(Token = "0x40001B2")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x9")]
			public readonly byte AbbreviationIndex;
		}

		[global::Cpp2ILInjected.Token(Token = "0x200006C")]
		private struct TZifHead
		{
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

			[global::Cpp2ILInjected.Token(Token = "0x40001B3")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public readonly uint Magic;

			[global::Cpp2ILInjected.Token(Token = "0x40001B4")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
			public readonly global::System.TimeZoneInfo.TZVersion Version;

			[global::Cpp2ILInjected.Token(Token = "0x40001B5")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public readonly uint IsGmtCount;

			[global::Cpp2ILInjected.Token(Token = "0x40001B6")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
			public readonly uint IsStdCount;

			[global::Cpp2ILInjected.Token(Token = "0x40001B7")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public readonly uint LeapCount;

			[global::Cpp2ILInjected.Token(Token = "0x40001B8")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
			public readonly uint TimeCount;

			[global::Cpp2ILInjected.Token(Token = "0x40001B9")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public readonly uint TypeCount;

			[global::Cpp2ILInjected.Token(Token = "0x40001BA")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
			public readonly uint CharCount;
		}

		[global::Cpp2ILInjected.Token(Token = "0x200006D")]
		private enum TZVersion : byte
		{
			[global::Cpp2ILInjected.Token(Token = "0x40001BC")]
			V1,
			[global::Cpp2ILInjected.Token(Token = "0x40001BD")]
			V2,
			[global::Cpp2ILInjected.Token(Token = "0x40001BE")]
			V3
		}

		[global::Cpp2ILInjected.Token(Token = "0x200006E")]
		[global::System.Serializable]
		public sealed class AdjustmentRule : global::System.IEquatable<global::System.TimeZoneInfo.AdjustmentRule>, global::System.Runtime.Serialization.ISerializable, global::System.Runtime.Serialization.IDeserializationCallback
		{
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

			[global::Cpp2ILInjected.Token(Token = "0x600036D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BB27E0", Offset = "0x1BB27E0", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "GetHashCode", ReturnType = typeof(int))]
			public override int GetHashCode()
			{
				throw null;
			}

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

			[global::Cpp2ILInjected.Token(Token = "0x6000377")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BB346C", Offset = "0x1BB346C", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal AdjustmentRule()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x40001BF")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private readonly global::System.DateTime _dateStart;

			[global::Cpp2ILInjected.Token(Token = "0x40001C0")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private readonly global::System.DateTime _dateEnd;

			[global::Cpp2ILInjected.Token(Token = "0x40001C1")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private readonly global::System.TimeSpan _daylightDelta;

			[global::Cpp2ILInjected.Token(Token = "0x40001C2")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			private readonly global::System.TimeZoneInfo.TransitionTime _daylightTransitionStart;

			[global::Cpp2ILInjected.Token(Token = "0x40001C3")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
			private readonly global::System.TimeZoneInfo.TransitionTime _daylightTransitionEnd;

			[global::Cpp2ILInjected.Token(Token = "0x40001C4")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
			private readonly global::System.TimeSpan _baseUtcOffsetDelta;

			[global::Cpp2ILInjected.Token(Token = "0x40001C5")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
			private readonly bool _noDaylightTransitions;
		}

		[global::Cpp2ILInjected.Token(Token = "0x200006F")]
		[global::System.Serializable]
		public readonly struct TransitionTime : global::System.IEquatable<global::System.TimeZoneInfo.TransitionTime>, global::System.Runtime.Serialization.ISerializable, global::System.Runtime.Serialization.IDeserializationCallback
		{
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

			[global::Cpp2ILInjected.Token(Token = "0x600037F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BB26D4", Offset = "0x1BB26D4", Length = "0x34")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeZoneInfo.TransitionTime), Member = "Equals", MemberParameters = new object[] { typeof(global::System.TimeZoneInfo.TransitionTime) }, ReturnType = typeof(bool))]
			public static bool operator !=(global::System.TimeZoneInfo.TransitionTime t1, global::System.TimeZoneInfo.TransitionTime t2)
			{
				throw null;
			}

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

			[global::Cpp2ILInjected.Token(Token = "0x6000381")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BB3564", Offset = "0x1BB3564", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override int GetHashCode()
			{
				throw null;
			}

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

			[global::Cpp2ILInjected.Token(Token = "0x40001C6")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private readonly global::System.DateTime _timeOfDay;

			[global::Cpp2ILInjected.Token(Token = "0x40001C7")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			private readonly byte _month;

			[global::Cpp2ILInjected.Token(Token = "0x40001C8")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x9")]
			private readonly byte _week;

			[global::Cpp2ILInjected.Token(Token = "0x40001C9")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xA")]
			private readonly byte _day;

			[global::Cpp2ILInjected.Token(Token = "0x40001CA")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
			private readonly global::System.DayOfWeek _dayOfWeek;

			[global::Cpp2ILInjected.Token(Token = "0x40001CB")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private readonly bool _isFixedDateRule;
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000070")]
		private sealed class CachedData
		{
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

			[global::Cpp2ILInjected.Token(Token = "0x600038C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BB2644", Offset = "0x1BB2644", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public CachedData()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x40001CC")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private global::System.TimeZoneInfo _localTimeZone;
		}

		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000071")]
		private sealed class <>c__DisplayClass16_0
		{
			[global::Cpp2ILInjected.Token(Token = "0x600038D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BAA644", Offset = "0x1BAA644", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass16_0()
			{
				throw null;
			}

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

			[global::Cpp2ILInjected.Token(Token = "0x40001CD")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public string localtimeFilePath;

			[global::Cpp2ILInjected.Token(Token = "0x40001CE")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public string posixrulesFilePath;

			[global::Cpp2ILInjected.Token(Token = "0x40001CF")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public byte[] buffer;

			[global::Cpp2ILInjected.Token(Token = "0x40001D0")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public byte[] rawData;

			[global::Cpp2ILInjected.Token(Token = "0x40001D1")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			public string id;

			[global::Cpp2ILInjected.Token(Token = "0x40001D2")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			public string timeZoneDirectory;
		}

		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000072")]
		[global::System.Serializable]
		private sealed class <>c
		{
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

			[global::Cpp2ILInjected.Token(Token = "0x6000390")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BB40C0", Offset = "0x1BB40C0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6000391")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BB40C8", Offset = "0x1BB40C8", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal bool <TZif_ParsePosixName>b__34_1(char c)
			{
				throw null;
			}

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

			[global::Cpp2ILInjected.Token(Token = "0x6000394")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BB4264", Offset = "0x1BB4264", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal bool <TZif_ParsePosixDate>b__37_0(char c)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6000395")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BB4280", Offset = "0x1BB4280", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal bool <TZif_ParsePosixTime>b__38_0(char c)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6000396")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BB4290", Offset = "0x1BB4290", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "CompareTo", MemberParameters = new object[] { typeof(global::System.DateTime) }, ReturnType = typeof(int))]
			internal int <CreateLocalUnity>b__161_0(global::System.TimeZoneInfo.AdjustmentRule rule1, global::System.TimeZoneInfo.AdjustmentRule rule2)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x40001D3")]
			public static readonly global::System.TimeZoneInfo.<>c <>9;

			[global::Cpp2ILInjected.Token(Token = "0x40001D4")]
			public static global::System.Func<char, bool> <>9__34_1;

			[global::Cpp2ILInjected.Token(Token = "0x40001D5")]
			public static global::System.Func<char, bool> <>9__34_0;

			[global::Cpp2ILInjected.Token(Token = "0x40001D6")]
			public static global::System.Func<char, bool> <>9__35_0;

			[global::Cpp2ILInjected.Token(Token = "0x40001D7")]
			public static global::System.Func<char, bool> <>9__37_0;

			[global::Cpp2ILInjected.Token(Token = "0x40001D8")]
			public static global::System.Func<char, bool> <>9__38_0;

			[global::Cpp2ILInjected.Token(Token = "0x40001D9")]
			public static global::System.Comparison<global::System.TimeZoneInfo.AdjustmentRule> <>9__161_0;
		}
	}
}
