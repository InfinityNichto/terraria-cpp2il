﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.ExceptionServices;
using System.Security;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Win32.SafeHandles;
using Mono;
using Mono.Globalization.Unicode;

namespace System.Runtime.InteropServices
{
	// Token: 0x020003A6 RID: 934
	[global::Cpp2ILInjected.Token(Token = "0x2000450")]
	public static class Marshal
	{
		// Token: 0x06001F69 RID: 8041
		[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.MayFail)]
		[global::Cpp2ILInjected.Token(Token = "0x60021AA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B7108C", Offset = "0x1B7108C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		public static extern global::System.IntPtr AllocHGlobal(global::System.IntPtr cb);

		// Token: 0x06001F6A RID: 8042 RVA: 0x00019D18 File Offset: 0x00017F18
		[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.MayFail)]
		[global::Cpp2ILInjected.Token(Token = "0x60021AB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B71090", Offset = "0x1B71090", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "nativefiledialog", Member = "Utf8EncodeNullable", MemberParameters = new object[] { typeof(string) }, ReturnType = "System.Byte*")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Social.Discord.DiscordRpc.RichPresence", Member = "StrToPtr", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Marshal), Member = "SecureStringGlobalAllocator", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(global::System.IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Platform", Member = "CheckOS", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.NetworkInformation.AixNetworkInterfaceAPI", Member = "GetAllNetworkInterfaces", ReturnType = "System.Net.NetworkInformation.NetworkInterface[]")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IntPtr), Member = "op_Explicit", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(global::System.IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static global::System.IntPtr AllocHGlobal(int cb)
		{
			throw null;
		}

		// Token: 0x06001F6B RID: 8043
		[global::Cpp2ILInjected.Token(Token = "0x60021AC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B710F8", Offset = "0x1B710F8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private unsafe static extern void copy_to_unmanaged_fixed(global::System.Array source, int startIndex, global::System.IntPtr destination, int length, void* fixed_source_element);

		// Token: 0x06001F6C RID: 8044 RVA: 0x00019D1B File Offset: 0x00017F1B
		[global::Cpp2ILInjected.Token(Token = "0x60021AD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B710FC", Offset = "0x1B710FC", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "get_Length", ReturnType = typeof(int))]
		private static bool skip_fixed(global::System.Array array, int startIndex)
		{
			throw null;
		}

		// Token: 0x06001F6D RID: 8045 RVA: 0x00019D1E File Offset: 0x00017F1E
		[global::Cpp2ILInjected.Token(Token = "0x60021AE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B71128", Offset = "0x1B71128", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Marshal), Member = "Copy", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(global::System.IntPtr),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal static void copy_to_unmanaged(byte[] source, int startIndex, global::System.IntPtr destination, int length)
		{
			throw null;
		}

		// Token: 0x06001F6E RID: 8046 RVA: 0x00019D21 File Offset: 0x00017F21
		[global::Cpp2ILInjected.Token(Token = "0x60021AF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B711F8", Offset = "0x1B711F8", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Social.Discord.DiscordRpc.RichPresence", Member = "StrToPtr", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Unity.UnityTlsContext", Member = "ReadCallback", MemberParameters = new object[]
		{
			"System.Byte*",
			typeof(global::System.IntPtr),
			"unitytls_errorstate*"
		}, ReturnType = typeof(global::System.IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.IO.Compression.DeflateStreamNative", Member = "UnmanagedRead", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Marshal), Member = "copy_to_unmanaged", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(global::System.IntPtr),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static void Copy(byte[] source, int startIndex, global::System.IntPtr destination, int length)
		{
			throw null;
		}

		// Token: 0x06001F6F RID: 8047 RVA: 0x00019D24 File Offset: 0x00017F24
		[global::Cpp2ILInjected.Token(Token = "0x60021B0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B712E4", Offset = "0x1B712E4", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Marshal), Member = "Copy", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Marshal), Member = "Copy", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Marshal), Member = "Copy", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(short[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Marshal), Member = "Copy", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(int[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal static void copy_from_unmanaged(global::System.IntPtr source, int startIndex, global::System.Array destination, int length)
		{
			throw null;
		}

		// Token: 0x06001F70 RID: 8048
		[global::Cpp2ILInjected.Token(Token = "0x60021B1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B71364", Offset = "0x1B71364", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private unsafe static extern void copy_from_unmanaged_fixed(global::System.IntPtr source, int startIndex, global::System.Array destination, int length, void* fixed_destination_element);

		// Token: 0x06001F71 RID: 8049 RVA: 0x00019D27 File Offset: 0x00017F27
		[global::Cpp2ILInjected.Token(Token = "0x60021B2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B71368", Offset = "0x1B71368", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::Mono.RuntimeMarshal), Member = "DecodeBlobArray", MemberParameters = new object[] { typeof(global::System.IntPtr) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Interop.NetSecurityNative.GssBuffer", Member = "Copy", MemberParameters = new object[]
		{
			"System.Byte[]",
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Interop.NetSecurityNative.GssBuffer", Member = "ToByteArray", ReturnType = "System.Byte[]")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Unity.UnityTlsContext", Member = "WriteCallback", MemberParameters = new object[]
		{
			"System.Byte*",
			typeof(global::System.IntPtr),
			"unitytls_errorstate*"
		}, ReturnType = typeof(global::System.IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.NetworkInformation.MacOsStructs.sockaddr_dl", Member = "Read", MemberParameters = new object[] { typeof(global::System.IntPtr) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.NetworkInformation.AixStructs.sockaddr_dl", Member = "Read", MemberParameters = new object[] { typeof(global::System.IntPtr) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.IO.Compression.DeflateStreamNative", Member = "UnmanagedWrite", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Networking.PlayerConnection.PlayerConnection", Member = "MessageCallbackInternal", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(ulong),
			typeof(ulong),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Marshal), Member = "copy_from_unmanaged", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(int),
			typeof(global::System.Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static void Copy(global::System.IntPtr source, byte[] destination, int startIndex, int length)
		{
			throw null;
		}

		// Token: 0x06001F72 RID: 8050 RVA: 0x00019D2A File Offset: 0x00017F2A
		[global::Cpp2ILInjected.Token(Token = "0x60021B3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B71454", Offset = "0x1B71454", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::Mono.Globalization.Unicode.MSCompatUnicodeTable), Member = "BuildTailoringTables", MemberParameters = new object[]
		{
			typeof(global::System.Globalization.CultureInfo),
			typeof(global::Mono.Globalization.Unicode.TailoringInfo),
			typeof(ref global::Mono.Globalization.Unicode.Contraction[]),
			typeof(ref global::Mono.Globalization.Unicode.Level2Map[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Marshal), Member = "copy_from_unmanaged", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(int),
			typeof(global::System.Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static void Copy(global::System.IntPtr source, char[] destination, int startIndex, int length)
		{
			throw null;
		}

		// Token: 0x06001F73 RID: 8051 RVA: 0x00019D2D File Offset: 0x00017F2D
		[global::Cpp2ILInjected.Token(Token = "0x60021B4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B71540", Offset = "0x1B71540", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Marshal), Member = "copy_from_unmanaged", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(int),
			typeof(global::System.Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static void Copy(global::System.IntPtr source, short[] destination, int startIndex, int length)
		{
			throw null;
		}

		// Token: 0x06001F74 RID: 8052 RVA: 0x00019D30 File Offset: 0x00017F30
		[global::Cpp2ILInjected.Token(Token = "0x60021B5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B7162C", Offset = "0x1B7162C", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.MarshalUtility", Member = "Copy", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			"System.UInt32[]",
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Marshal), Member = "copy_from_unmanaged", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(int),
			typeof(global::System.Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static void Copy(global::System.IntPtr source, int[] destination, int startIndex, int length)
		{
			throw null;
		}

		// Token: 0x06001F75 RID: 8053
		[global::Cpp2ILInjected.Token(Token = "0x60021B6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B71718", Offset = "0x1B71718", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Variant), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		public static extern void FreeBSTR(global::System.IntPtr ptr);

		// Token: 0x06001F76 RID: 8054
		[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
		[global::Cpp2ILInjected.Token(Token = "0x60021B7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B7171C", Offset = "0x1B7171C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "nativefiledialog", Member = "NFD_OpenDialog", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(ref string)
		}, ReturnType = "nativefiledialog.nfdresult_t")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "nativefiledialog", Member = "NFD_OpenDialogMultiple", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			"nfdpathset_t&"
		}, ReturnType = "nativefiledialog.nfdresult_t")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "nativefiledialog", Member = "NFD_SaveDialog", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(ref string)
		}, ReturnType = "nativefiledialog.nfdresult_t")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "nativefiledialog", Member = "NFD_PickFolder", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref string)
		}, ReturnType = "nativefiledialog.nfdresult_t")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Social.Discord.DiscordRpc.RichPresence", Member = "FreeMem", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Platform", Member = "CheckOS", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.NetworkInformation.AixNetworkInterfaceAPI", Member = "GetAllNetworkInterfaces", ReturnType = "System.Net.NetworkInformation.NetworkInterface[]")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		public static extern void FreeHGlobal(global::System.IntPtr hglobal);

		// Token: 0x06001F77 RID: 8055 RVA: 0x00019D33 File Offset: 0x00017F33
		[global::Cpp2ILInjected.Token(Token = "0x60021B8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B71720", Offset = "0x1B71720", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Marshal), Member = "ZeroFreeBSTR", MemberParameters = new object[] { typeof(global::System.IntPtr) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Marshal), Member = "ReadInt32", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IntPtr), Member = "Add", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(int)
		}, ReturnType = typeof(global::System.IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IntPtr), Member = "op_Explicit", MemberParameters = new object[] { typeof(global::System.IntPtr) }, ReturnType = typeof(void*))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private unsafe static void ClearBSTR(global::System.IntPtr ptr)
		{
			throw null;
		}

		// Token: 0x06001F78 RID: 8056 RVA: 0x00019D36 File Offset: 0x00017F36
		[global::Cpp2ILInjected.Token(Token = "0x60021B9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B7183C", Offset = "0x1B7183C", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Diagnostics.Process", Member = "StartWithShellExecuteEx", MemberParameters = new object[] { "System.Diagnostics.ProcessStartInfo" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Diagnostics.Process", Member = "StartWithCreateProcess", MemberParameters = new object[] { "System.Diagnostics.ProcessStartInfo" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Marshal), Member = "ClearBSTR", MemberParameters = new object[] { typeof(global::System.IntPtr) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static void ZeroFreeBSTR(global::System.IntPtr s)
		{
			throw null;
		}

		// Token: 0x06001F79 RID: 8057 RVA: 0x00019D39 File Offset: 0x00017F39
		[global::Cpp2ILInjected.Token(Token = "0x60021BA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B71898", Offset = "0x1B71898", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Marshal), Member = "ZeroFreeGlobalAllocAnsi", MemberParameters = new object[] { typeof(global::System.IntPtr) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IntPtr), Member = "op_Explicit", MemberParameters = new object[] { typeof(global::System.IntPtr) }, ReturnType = typeof(void*))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IntPtr), Member = "Add", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(int)
		}, ReturnType = typeof(global::System.IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private unsafe static void ClearAnsi(global::System.IntPtr ptr)
		{
			throw null;
		}

		// Token: 0x06001F7A RID: 8058 RVA: 0x00019D3C File Offset: 0x00017F3C
		[global::Cpp2ILInjected.Token(Token = "0x60021BB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B71950", Offset = "0x1B71950", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Marshal), Member = "ZeroFreeGlobalAllocUnicode", MemberParameters = new object[] { typeof(global::System.IntPtr) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Marshal), Member = "ReadInt16", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(int)
		}, ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Marshal), Member = "WriteInt16", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(int),
			typeof(short)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private static void ClearUnicode(global::System.IntPtr ptr)
		{
			throw null;
		}

		// Token: 0x06001F7B RID: 8059 RVA: 0x00019D3F File Offset: 0x00017F3F
		[global::Cpp2ILInjected.Token(Token = "0x60021BC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B71A74", Offset = "0x1B71A74", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Microsoft.Win32.SafeHandles.SafePasswordHandle), Member = "FreeHandle", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Marshal), Member = "ClearAnsi", MemberParameters = new object[] { typeof(global::System.IntPtr) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static void ZeroFreeGlobalAllocAnsi(global::System.IntPtr s)
		{
			throw null;
		}

		// Token: 0x06001F7C RID: 8060 RVA: 0x00019D42 File Offset: 0x00017F42
		[global::Cpp2ILInjected.Token(Token = "0x60021BD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B71AD0", Offset = "0x1B71AD0", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.UnsafeNclNativeMethods.SecureStringHelper", Member = "CreateString", MemberParameters = new object[] { typeof(global::System.Security.SecureString) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Marshal), Member = "ClearUnicode", MemberParameters = new object[] { typeof(global::System.IntPtr) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static void ZeroFreeGlobalAllocUnicode(global::System.IntPtr s)
		{
			throw null;
		}

		// Token: 0x06001F7D RID: 8061 RVA: 0x00019D45 File Offset: 0x00017F45
		[global::Cpp2ILInjected.Token(Token = "0x60021BE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B71B2C", Offset = "0x1B71B2C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.SharedUtilities", Member = "_HRForException", MemberParameters = new object[] { typeof(global::System.Exception) }, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static int GetHRForException(global::System.Exception e)
		{
			throw null;
		}

		// Token: 0x06001F7E RID: 8062 RVA: 0x00019D48 File Offset: 0x00017F48
		[global::Cpp2ILInjected.Token(Token = "0x60021BF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B71B38", Offset = "0x1B71B38", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ReferenceConverter", Member = "ConvertTo", MemberParameters = new object[]
		{
			"System.ComponentModel.ITypeDescriptorContext",
			typeof(global::System.Globalization.CultureInfo),
			typeof(object),
			typeof(global::System.Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static bool IsComObject(object o)
		{
			throw null;
		}

		// Token: 0x06001F7F RID: 8063
		[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
		[global::Cpp2ILInjected.Token(Token = "0x60021C0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B70660", Offset = "0x1B70660", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::Interop.Sys), Member = "GetLastErrorInfo", ReturnType = typeof(global::Interop.ErrorInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.WindowsConsoleDriver), Member = "ReadKey", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(global::System.ConsoleKeyInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpListenerException", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.NetworkInformation.NetworkInformationException", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.Win32Exception", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.Win32Exception", Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.Win32Exception", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.NetCfFile", Member = "SetTimes", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.DateTime),
			typeof(global::System.DateTime),
			typeof(global::System.DateTime)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.NetCfFile", Member = "SetLastWriteTime", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.DateTime)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		public static extern int GetLastWin32Error();

		// Token: 0x06001F80 RID: 8064
		[global::Cpp2ILInjected.Token(Token = "0x60021C1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B71B40", Offset = "0x1B71B40", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::Interop.Sys), Member = "StrError", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Microsoft.Win32.SafeHandles.SafePasswordHandle), Member = "Mono_DangerousGetString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Interop.NetSecurityNative.GssApiException", Member = "GetGssApiDisplayStatus", MemberParameters = new object[]
		{
			"Interop.NetSecurityNative.Status",
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Platform", Member = "CheckOS", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.NetworkInformation.AixNetworkInterfaceAPI", Member = "GetAllNetworkInterfaces", ReturnType = "System.Net.NetworkInformation.NetworkInterface[]")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		public static extern string PtrToStringAnsi(global::System.IntPtr ptr);

		// Token: 0x06001F81 RID: 8065
		[global::Cpp2ILInjected.Token(Token = "0x60021C2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B71B44", Offset = "0x1B71B44", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.UnsafeNclNativeMethods.SecureStringHelper", Member = "CreateString", MemberParameters = new object[] { typeof(global::System.Security.SecureString) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		public static extern string PtrToStringUni(global::System.IntPtr ptr);

		// Token: 0x06001F82 RID: 8066
		[ComVisible(true)]
		[global::Cpp2ILInjected.Token(Token = "0x60021C3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B71B48", Offset = "0x1B71B48", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Marshal), Member = "PtrToStructure", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { typeof(global::System.IntPtr) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.NetworkInformation.AixNetworkInterfaceAPI", Member = "GetAllNetworkInterfaces", ReturnType = "System.Net.NetworkInformation.NetworkInterface[]")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.NetworkInformation.LinuxNetworkInterfaceAPI", Member = "GetAllNetworkInterfaces", ReturnType = "System.Net.NetworkInformation.NetworkInterface[]")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.NetworkInformation.MacOsNetworkInterfaceAPI", Member = "GetAllNetworkInterfaces", ReturnType = "System.Net.NetworkInformation.NetworkInterface[]")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		public static extern object PtrToStructure(global::System.IntPtr ptr, global::System.Type structureType);

		// Token: 0x06001F83 RID: 8067 RVA: 0x00019D4B File Offset: 0x00017F4B
		[global::Cpp2ILInjected.Token(Token = "0x60021C4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1590384", Offset = "0x1590384", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Unity.UnityTls", Member = "get_NativeInterface", ReturnType = "Mono.Unity.UnityTls.unitytls_interface_struct")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Marshal), Member = "PtrToStructure", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(global::System.Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static T PtrToStructure<T>(global::System.IntPtr ptr)
		{
			throw null;
		}

		// Token: 0x06001F84 RID: 8068 RVA: 0x00019D4E File Offset: 0x00017F4E
		[global::Cpp2ILInjected.Token(Token = "0x60021C5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B71934", Offset = "0x1B71934", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.NetworkInformation.MacOsStructs.sockaddr_dl", Member = "Read", MemberParameters = new object[] { typeof(global::System.IntPtr) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.NetworkInformation.AixStructs.sockaddr_dl", Member = "Read", MemberParameters = new object[] { typeof(global::System.IntPtr) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IntPtr), Member = "op_Explicit", MemberParameters = new object[] { typeof(global::System.IntPtr) }, ReturnType = typeof(void*))]
		public unsafe static byte ReadByte(global::System.IntPtr ptr, int ofs)
		{
			throw null;
		}

		// Token: 0x06001F85 RID: 8069 RVA: 0x00019D51 File Offset: 0x00017F51
		[global::Cpp2ILInjected.Token(Token = "0x60021C6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B71A2C", Offset = "0x1B71A2C", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Marshal), Member = "ClearUnicode", MemberParameters = new object[] { typeof(global::System.IntPtr) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.NetworkInformation.MacOsStructs.sockaddr_dl", Member = "Read", MemberParameters = new object[] { typeof(global::System.IntPtr) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.NetworkInformation.AixStructs.sockaddr_dl", Member = "Read", MemberParameters = new object[] { typeof(global::System.IntPtr) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IntPtr), Member = "op_Explicit", MemberParameters = new object[] { typeof(global::System.IntPtr) }, ReturnType = typeof(void*))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "Memcpy", MemberParameters = new object[]
		{
			typeof(byte*),
			typeof(byte*),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		public unsafe static short ReadInt16(global::System.IntPtr ptr, int ofs)
		{
			throw null;
		}

		// Token: 0x06001F86 RID: 8070 RVA: 0x00019D54 File Offset: 0x00017F54
		[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
		[global::Cpp2ILInjected.Token(Token = "0x60021C7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B717CC", Offset = "0x1B717CC", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Marshal), Member = "ClearBSTR", MemberParameters = new object[] { typeof(global::System.IntPtr) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IntPtr), Member = "op_Explicit", MemberParameters = new object[] { typeof(global::System.IntPtr) }, ReturnType = typeof(void*))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "Memcpy", MemberParameters = new object[]
		{
			typeof(byte*),
			typeof(byte*),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		public unsafe static int ReadInt32(global::System.IntPtr ptr, int ofs)
		{
			throw null;
		}

		// Token: 0x06001F87 RID: 8071
		[global::Cpp2ILInjected.Token(Token = "0x60021C8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B71B4C", Offset = "0x1B71B4C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private unsafe static extern global::System.IntPtr StringToHGlobalAnsi(char* s, int length);

		// Token: 0x06001F88 RID: 8072 RVA: 0x00019D57 File Offset: 0x00017F57
		[global::Cpp2ILInjected.Token(Token = "0x60021C9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B71B50", Offset = "0x1B71B50", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Microsoft.Win32.SafeHandles.SafePasswordHandle), Member = "CreateHandle", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static global::System.IntPtr StringToHGlobalAnsi(string s)
		{
			throw null;
		}

		// Token: 0x06001F89 RID: 8073 RVA: 0x00019D5A File Offset: 0x00017F5A
		[global::Cpp2ILInjected.Token(Token = "0x60021CA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B71BC4", Offset = "0x1B71BC4", Length = "0x150")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Diagnostics.Process", Member = "FillUserInfo", MemberParameters = new object[] { "System.Diagnostics.ProcessStartInfo", "ProcInfo&" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Security.SecureString), Member = "GetBuffer", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Security.SecureString), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public static global::System.IntPtr SecureStringToBSTR(global::System.Security.SecureString s)
		{
			throw null;
		}

		// Token: 0x06001F8A RID: 8074 RVA: 0x00019D5D File Offset: 0x00017F5D
		[global::Cpp2ILInjected.Token(Token = "0x60021CB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B71D18", Offset = "0x1B71D18", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Marshal), Member = "AllocHGlobal", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(global::System.IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static global::System.IntPtr SecureStringGlobalAllocator(int len)
		{
			throw null;
		}

		// Token: 0x06001F8B RID: 8075 RVA: 0x00019D60 File Offset: 0x00017F60
		[global::Cpp2ILInjected.Token(Token = "0x60021CC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B71D6C", Offset = "0x1B71D6C", Length = "0x264")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Marshal), Member = "SecureStringToGlobalAllocUnicode", MemberParameters = new object[] { typeof(global::System.Security.SecureString) }, ReturnType = typeof(global::System.IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Security.SecureString), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Security.SecureString), Member = "GetBuffer", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Marshal), Member = "WriteInt16", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(int),
			typeof(short)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		internal static global::System.IntPtr SecureStringToUnicode(global::System.Security.SecureString s, Marshal.SecureStringAllocator allocator)
		{
			throw null;
		}

		// Token: 0x06001F8C RID: 8076 RVA: 0x00019D63 File Offset: 0x00017F63
		[global::Cpp2ILInjected.Token(Token = "0x60021CD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B71FD0", Offset = "0x1B71FD0", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.UnsafeNclNativeMethods.SecureStringHelper", Member = "CreateString", MemberParameters = new object[] { typeof(global::System.Security.SecureString) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Marshal.SecureStringAllocator), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Marshal), Member = "SecureStringToUnicode", MemberParameters = new object[]
		{
			typeof(global::System.Security.SecureString),
			typeof(Marshal.SecureStringAllocator)
		}, ReturnType = typeof(global::System.IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public static global::System.IntPtr SecureStringToGlobalAllocUnicode(global::System.Security.SecureString s)
		{
			throw null;
		}

		// Token: 0x06001F8D RID: 8077
		[ComVisible(true)]
		[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.MayFail)]
		[global::Cpp2ILInjected.Token(Token = "0x60021CE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B72178", Offset = "0x1B72178", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Marshal), Member = "StructureToPtr", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			"T",
			typeof(global::System.IntPtr),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		public static extern void StructureToPtr(object structure, global::System.IntPtr ptr, bool fDeleteOld);

		// Token: 0x06001F8E RID: 8078 RVA: 0x00019D66 File Offset: 0x00017F66
		[global::Cpp2ILInjected.Token(Token = "0x60021CF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1590474", Offset = "0x1590474", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Marshal), Member = "StructureToPtr", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IntPtr),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void StructureToPtr<T>(T structure, global::System.IntPtr ptr, bool fDeleteOld)
		{
			throw null;
		}

		// Token: 0x06001F8F RID: 8079
		[global::Cpp2ILInjected.Token(Token = "0x60021D0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B71D14", Offset = "0x1B71D14", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private unsafe static extern global::System.IntPtr BufferToBSTR(char* ptr, int slen);

		// Token: 0x06001F90 RID: 8080
		[global::Cpp2ILInjected.Token(Token = "0x60021D1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B72180", Offset = "0x1B72180", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Marshal), Member = "UnsafeAddrOfPinnedArrayElement", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			"T[]",
			typeof(int)
		}, ReturnType = typeof(global::System.IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		public static extern global::System.IntPtr UnsafeAddrOfPinnedArrayElement(global::System.Array arr, int index);

		// Token: 0x06001F91 RID: 8081 RVA: 0x00019D69 File Offset: 0x00017F69
		[global::Cpp2ILInjected.Token(Token = "0x60021D2")]
		[global::Cpp2ILInjected.Address(RVA = "0x15904E4", Offset = "0x15904E4", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket", Member = "Receive", MemberParameters = new object[] { "System.Collections.Generic.IList`1<ArraySegment`1<Byte>>", "System.Net.Sockets.SocketFlags", "System.Net.Sockets.SocketError&" }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket", Member = "Send", MemberParameters = new object[] { "System.Collections.Generic.IList`1<ArraySegment`1<Byte>>", "System.Net.Sockets.SocketFlags", "System.Net.Sockets.SocketError&" }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Marshal), Member = "UnsafeAddrOfPinnedArrayElement", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int)
		}, ReturnType = typeof(global::System.IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static global::System.IntPtr UnsafeAddrOfPinnedArrayElement<T>(T[] arr, int index)
		{
			throw null;
		}

		// Token: 0x06001F92 RID: 8082 RVA: 0x00019D6C File Offset: 0x00017F6C
		[global::Cpp2ILInjected.Token(Token = "0x60021D3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B71818", Offset = "0x1B71818", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Social.Discord.DiscordRpc.RichPresence", Member = "StrToPtr", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IntPtr), Member = "Add", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(int)
		}, ReturnType = typeof(global::System.IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IntPtr), Member = "op_Explicit", MemberParameters = new object[] { typeof(global::System.IntPtr) }, ReturnType = typeof(void*))]
		public unsafe static void WriteByte(global::System.IntPtr ptr, int ofs, byte val)
		{
			throw null;
		}

		// Token: 0x06001F93 RID: 8083 RVA: 0x00019D6F File Offset: 0x00017F6F
		[global::Cpp2ILInjected.Token(Token = "0x60021D4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B719E0", Offset = "0x1B719E0", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Marshal), Member = "ClearUnicode", MemberParameters = new object[] { typeof(global::System.IntPtr) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Marshal), Member = "SecureStringToUnicode", MemberParameters = new object[]
		{
			typeof(global::System.Security.SecureString),
			typeof(Marshal.SecureStringAllocator)
		}, ReturnType = typeof(global::System.IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IntPtr), Member = "op_Explicit", MemberParameters = new object[] { typeof(global::System.IntPtr) }, ReturnType = typeof(void*))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "Memcpy", MemberParameters = new object[]
		{
			typeof(byte*),
			typeof(byte*),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		public unsafe static void WriteInt16(global::System.IntPtr ptr, int ofs, short val)
		{
			throw null;
		}

		// Token: 0x06001F94 RID: 8084
		[global::Cpp2ILInjected.Token(Token = "0x60021D5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B72184", Offset = "0x1B72184", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Marshal), Member = "GetFunctionPointerForDelegate", MemberTypeParameters = new object[] { "TDelegate" }, MemberParameters = new object[] { "TDelegate" }, ReturnType = typeof(global::System.IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern global::System.IntPtr GetFunctionPointerForDelegateInternal(global::System.Delegate d);

		// Token: 0x06001F95 RID: 8085 RVA: 0x00019D72 File Offset: 0x00017F72
		[global::Cpp2ILInjected.Token(Token = "0x60021D6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1590298", Offset = "0x1590298", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.OSSpecificSynchronizationContext), Member = "Post", MemberParameters = new object[]
		{
			typeof(global::System.Threading.SendOrPostCallback),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Marshal), Member = "GetFunctionPointerForDelegateInternal", MemberParameters = new object[] { typeof(global::System.Delegate) }, ReturnType = typeof(global::System.IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public static global::System.IntPtr GetFunctionPointerForDelegate<TDelegate>(TDelegate d)
		{
			throw null;
		}

		// Token: 0x06001F96 RID: 8086
		[global::Cpp2ILInjected.Token(Token = "0x60021D7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B70668", Offset = "0x1B70668", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		internal static extern void SetLastWin32Error(int error);

		// Token: 0x06001F97 RID: 8087 RVA: 0x00019D75 File Offset: 0x00017F75
		[global::Cpp2ILInjected.Token(Token = "0x60021D8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B72188", Offset = "0x1B72188", Length = "0x7A4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ValueTuple<object, object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Func<object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.LazyInitializer), Member = "EnsureInitialized", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "T&", "System.Func`1<T>" }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.Dictionary<, >), Member = "TryGetValue", MemberParameters = new object[] { "TKey", "TValue&" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetMethod", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.Reflection.Binder),
			typeof(global::System.Type[]),
			typeof(global::System.Reflection.ParameterModifier[])
		}, ReturnType = typeof(global::System.Reflection.MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.MethodInfo), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.MethodInfo),
			typeof(global::System.Reflection.MethodInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.RuntimeMethodInfo), Member = "InternalInvoke", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object[]),
			typeof(ref global::System.Exception)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.Dictionary<, >), Member = "set_Item", MemberParameters = new object[] { "TKey", "TValue" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.ExceptionServices.ExceptionDispatchInfo), Member = "Capture", MemberParameters = new object[] { typeof(global::System.Exception) }, ReturnType = typeof(global::System.Runtime.ExceptionServices.ExceptionDispatchInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.ExceptionServices.ExceptionDispatchInfo), Member = "Throw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ApplicationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 69)]
		internal static ICustomMarshaler GetCustomMarshalerInstance(global::System.Type type, string cookie)
		{
			throw null;
		}

		// Token: 0x06001F98 RID: 8088 RVA: 0x00019D78 File Offset: 0x00017F78
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60021D9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B72A20", Offset = "0x1B72A20", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "get_IsRunningOnWindows", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static Marshal()
		{
			throw null;
		}

		// Token: 0x04000F8F RID: 3983
		[global::Cpp2ILInjected.Token(Token = "0x4001284")]
		public static readonly int SystemMaxDBCSCharSize;

		// Token: 0x04000F90 RID: 3984
		[global::Cpp2ILInjected.Token(Token = "0x4001285")]
		public static readonly int SystemDefaultCharSize;

		// Token: 0x04000F91 RID: 3985
		[global::Cpp2ILInjected.Token(Token = "0x4001286")]
		internal static global::System.Collections.Generic.Dictionary<global::System.ValueTuple<global::System.Type, string>, ICustomMarshaler> MarshalerInstanceCache;

		// Token: 0x04000F92 RID: 3986
		[global::Cpp2ILInjected.Token(Token = "0x4001287")]
		internal static readonly object MarshalerInstanceCacheLock;

		// Token: 0x020005F5 RID: 1525
		// (Invoke) Token: 0x06004119 RID: 16665
		[global::Cpp2ILInjected.Token(Token = "0x2000451")]
		internal delegate global::System.IntPtr SecureStringAllocator(int len);

		// Token: 0x020005F6 RID: 1526
		[global::Cpp2ILInjected.Token(Token = "0x2000452")]
		internal class MarshalerInstanceKeyComparer : global::System.Collections.Generic.IEqualityComparer<global::System.ValueTuple<global::System.Type, string>>
		{
			// Token: 0x0600411A RID: 16666 RVA: 0x0001FDEA File Offset: 0x0001DFEA
			[global::Cpp2ILInjected.Token(Token = "0x60021DC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B72AD4", Offset = "0x1B72AD4", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ValueTuple<object, object>), Member = "CompareTo", MemberParameters = new object[] { typeof(global::System.ValueTuple<object, object>) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public bool Equals(global::System.ValueTuple<global::System.Type, string> lhs, global::System.ValueTuple<global::System.Type, string> rhs)
			{
				throw null;
			}

			// Token: 0x0600411B RID: 16667 RVA: 0x0001FDED File Offset: 0x0001DFED
			[global::Cpp2ILInjected.Token(Token = "0x60021DD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B72B48", Offset = "0x1B72B48", Length = "0x54")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ValueTuple<object, object>), Member = "GetHashCode", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public int GetHashCode(global::System.ValueTuple<global::System.Type, string> key)
			{
				throw null;
			}

			// Token: 0x0600411C RID: 16668 RVA: 0x0001FDF0 File Offset: 0x0001DFF0
			[global::Cpp2ILInjected.Token(Token = "0x60021DE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B72B9C", Offset = "0x1B72B9C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public MarshalerInstanceKeyComparer()
			{
				throw null;
			}
		}

		// Token: 0x020005F7 RID: 1527
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000453")]
		[global::System.Serializable]
		private sealed class <>c
		{
			// Token: 0x0600411D RID: 16669 RVA: 0x0001FDF3 File Offset: 0x0001DFF3
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x60021DF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B72BA4", Offset = "0x1B72BA4", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			static <>c()
			{
				throw null;
			}

			// Token: 0x0600411E RID: 16670 RVA: 0x0001FDF6 File Offset: 0x0001DFF6
			[global::Cpp2ILInjected.Token(Token = "0x60021E0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B72C00", Offset = "0x1B72C00", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c()
			{
				throw null;
			}

			// Token: 0x0600411F RID: 16671 RVA: 0x0001FDF9 File Offset: 0x0001DFF9
			[global::Cpp2ILInjected.Token(Token = "0x60021E1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B72C08", Offset = "0x1B72C08", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.Dictionary<, >), Member = ".ctor", MemberParameters = new object[] { "System.Collections.Generic.IEqualityComparer`1<TKey>" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			internal global::System.Collections.Generic.Dictionary<global::System.ValueTuple<global::System.Type, string>, ICustomMarshaler> <GetCustomMarshalerInstance>b__201_0()
			{
				throw null;
			}

			// Token: 0x0400197D RID: 6525
			[global::Cpp2ILInjected.Token(Token = "0x4001288")]
			public static readonly Marshal.<>c <>9;

			// Token: 0x0400197E RID: 6526
			[global::Cpp2ILInjected.Token(Token = "0x4001289")]
			public static global::System.Func<global::System.Collections.Generic.Dictionary<global::System.ValueTuple<global::System.Type, string>, ICustomMarshaler>> <>9__201_0;
		}
	}
}