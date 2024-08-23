using System;
using System.Collections.Concurrent;
using System.IO;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Security.Principal;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Win32.SafeHandles;
using Mono;

namespace System
{
	// Token: 0x02000137 RID: 311
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x200017D")]
	[global::System.Serializable]
	public readonly struct IntPtr : global::System.Runtime.Serialization.ISerializable, global::System.IEquatable<global::System.IntPtr>
	{
		// Token: 0x06000E03 RID: 3587 RVA: 0x00016CF1 File Offset: 0x00014EF1
		[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.MayCorruptInstance, global::System.Runtime.ConstrainedExecution.Cer.MayFail)]
		[global::Cpp2ILInjected.Token(Token = "0x6000EEB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7DA58", Offset = "0x1C7DA58", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Microsoft.Win32.SafeHandles.SafeHandleZeroOrMinusOneIsInvalid), Member = "get_IsInvalid", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Microsoft.Win32.SafeHandles.SafeHandleMinusOneIsInvalid), Member = ".ctor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Microsoft.Win32.SafeHandles.SafeHandleMinusOneIsInvalid), Member = "get_IsInvalid", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Microsoft.Win32.SafeHandles.CriticalHandleMinusOneIsInvalid), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Microsoft.Win32.SafeHandles.CriticalHandleMinusOneIsInvalid), Member = "get_IsInvalid", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Security.SafeCredentialReference", Member = ".ctor", MemberParameters = new object[] { "System.Net.Security.SafeFreeCredentials" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Display", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Display", Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		public IntPtr(int value)
		{
			throw null;
		}

		// Token: 0x06000E04 RID: 3588 RVA: 0x00016CF4 File Offset: 0x00014EF4
		[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.MayCorruptInstance, global::System.Runtime.ConstrainedExecution.Cer.MayFail)]
		[global::Cpp2ILInjected.Token(Token = "0x6000EEC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7DA64", Offset = "0x1C7DA64", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Claims.ClaimsPrincipal), Member = "DeserializeIdentities", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.NetworkInformation.MacOsStructs.sockaddr_dl", Member = "Read", MemberParameters = new object[] { typeof(global::System.IntPtr) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.NetworkInformation.AixStructs.sockaddr_dl", Member = "Read", MemberParameters = new object[] { typeof(global::System.IntPtr) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Object", Member = "GetInstanceID", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		public IntPtr(long value)
		{
			throw null;
		}

		// Token: 0x06000E05 RID: 3589 RVA: 0x00016CF7 File Offset: 0x00014EF7
		[global::System.CLSCompliant(false)]
		[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.MayCorruptInstance, global::System.Runtime.ConstrainedExecution.Cer.MayFail)]
		[global::Cpp2ILInjected.Token(Token = "0x6000EED")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7DA6C", Offset = "0x1C7DA6C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public unsafe IntPtr(void* value)
		{
			throw null;
		}

		// Token: 0x06000E06 RID: 3590 RVA: 0x00016CFA File Offset: 0x00014EFA
		[global::Cpp2ILInjected.Token(Token = "0x6000EEE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7DA74", Offset = "0x1C7DA74", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "GetInt64", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private IntPtr(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x06000E07 RID: 3591 RVA: 0x00016CFD File Offset: 0x00014EFD
		[global::Cpp2ILInjected.Token(Token = "0x17000158")]
		public unsafe static int Size
		{
			[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
			[global::Cpp2ILInjected.Token(Token = "0x6000EEF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C7DAD4", Offset = "0x1C7DAD4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "wcslen", MemberParameters = new object[] { typeof(char*) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Concurrent.ConcurrentDictionary<, >), Member = "IsValueWriteAtomic", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Uri", Member = "ParseSchemeCheckImplicitFile", MemberParameters = new object[]
			{
				"System.Char*",
				typeof(ushort),
				"System.ParsingError&",
				"Flags&",
				"System.UriParser&"
			}, ReturnType = typeof(ushort))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.SocketAddress", Member = ".ctor", MemberParameters = new object[]
			{
				"System.Net.Sockets.AddressFamily",
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.SocketAddress", Member = "CopyAddressSizeIntoBuffer", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.SocketAddress", Member = "GetAddressSizeOffset", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.Utility", Member = "get_Is32Bit", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.Utility", Member = "get_Is64Bit", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000E08 RID: 3592 RVA: 0x00016D00 File Offset: 0x00014F00
		[global::Cpp2ILInjected.Token(Token = "0x6000EF0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7DADC", Offset = "0x1C7DADC", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(long)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private void System.Runtime.Serialization.ISerializable.GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		// Token: 0x06000E09 RID: 3593 RVA: 0x00016D03 File Offset: 0x00014F03
		[global::Cpp2ILInjected.Token(Token = "0x6000EF1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7DB84", Offset = "0x1C7DB84", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.AnimationCurve", Member = "Equals", MemberParameters = new object[] { "UnityEngine.AnimationCurve" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Gradient", Member = "Equals", MemberParameters = new object[] { "UnityEngine.Gradient" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Rendering.ScriptableRenderContext", Member = "Equals", MemberParameters = new object[] { "UnityEngine.Rendering.ScriptableRenderContext" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x06000E0A RID: 3594 RVA: 0x00016D06 File Offset: 0x00014F06
		[global::Cpp2ILInjected.Token(Token = "0x6000EF2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C79D94", Offset = "0x1C79D94", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::Mono.RuntimeClassHandle), Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::Mono.RuntimeEventHandle), Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::Mono.RuntimePropertyHandle), Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ValueTuple<, , , , >), Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ValueTuple<, , , , , , , >), Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.InteropServices.GCHandle), Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.AnimationCurve", Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Gradient", Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Rendering.ScriptableRenderContext", Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Playables.PlayableOutputHandle", Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Playables.PlayableHandle", Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 23)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x06000E0B RID: 3595 RVA: 0x00016D09 File Offset: 0x00014F09
		[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
		[global::Cpp2ILInjected.Token(Token = "0x6000EF3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7DB7C", Offset = "0x1C7DB7C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Principal.WindowsIdentity), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Security.Claims.ClaimsIdentity),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Claims.ClaimsPrincipal), Member = "SerializeIdentities", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.NetworkInformation.AixNetworkInterfaceAPI", Member = "GetAllNetworkInterfaces", ReturnType = "System.Net.NetworkInformation.NetworkInterface[]")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.NetworkInformation.MacOsStructs.sockaddr_dl", Member = "Read", MemberParameters = new object[] { typeof(global::System.IntPtr) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.NetworkInformation.AixStructs.sockaddr_dl", Member = "Read", MemberParameters = new object[] { typeof(global::System.IntPtr) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Object", Member = "GetInstanceID", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.AndroidReflection", Member = "NewProxyInstance", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(global::System.IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.AndroidReflection", Member = "SetNativeExceptionOnProxy", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(global::System.Exception),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		public long ToInt64()
		{
			throw null;
		}

		// Token: 0x06000E0C RID: 3596 RVA: 0x00016D0C File Offset: 0x00014F0C
		[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6000EF4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7DBFC", Offset = "0x1C7DBFC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public unsafe void* ToPointer()
		{
			throw null;
		}

		// Token: 0x06000E0D RID: 3597 RVA: 0x00016D0F File Offset: 0x00014F0F
		[global::Cpp2ILInjected.Token(Token = "0x6000EF5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7DC04", Offset = "0x1C7DC04", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ValueTuple<, , , , >), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ValueTuple<, , , , >), Member = "System.IValueTupleInternal.ToStringEnd", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ValueTuple<, , , , , , , >), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ValueTuple<, , , , , , , >), Member = "System.IValueTupleInternal.ToStringEnd", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 16)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(long), Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(string))]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x06000E0E RID: 3598 RVA: 0x00016D12 File Offset: 0x00014F12
		[global::Cpp2ILInjected.Token(Token = "0x6000EF6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7DC2C", Offset = "0x1C7DC2C", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.ValidationHelper", Member = "ToString", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(long), Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(string))]
		public string ToString(string format)
		{
			throw null;
		}

		// Token: 0x06000E0F RID: 3599 RVA: 0x00016D15 File Offset: 0x00014F15
		[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
		[global::Cpp2ILInjected.Token(Token = "0x6000EF7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C75964", Offset = "0x1C75964", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 75)]
		public static bool operator ==(global::System.IntPtr value1, global::System.IntPtr value2)
		{
			throw null;
		}

		// Token: 0x06000E10 RID: 3600 RVA: 0x00016D18 File Offset: 0x00014F18
		[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
		[global::Cpp2ILInjected.Token(Token = "0x6000EF8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7D108", Offset = "0x1C7D108", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 50)]
		public static bool operator !=(global::System.IntPtr value1, global::System.IntPtr value2)
		{
			throw null;
		}

		// Token: 0x06000E11 RID: 3601 RVA: 0x00016D1B File Offset: 0x00014F1B
		[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.MayCorruptInstance, global::System.Runtime.ConstrainedExecution.Cer.MayFail)]
		[global::Cpp2ILInjected.Token(Token = "0x6000EF9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7DC50", Offset = "0x1C7DC50", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 35)]
		public static explicit operator global::System.IntPtr(int value)
		{
			throw null;
		}

		// Token: 0x06000E12 RID: 3602 RVA: 0x00016D1E File Offset: 0x00014F1E
		[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.MayCorruptInstance, global::System.Runtime.ConstrainedExecution.Cer.MayFail)]
		[global::Cpp2ILInjected.Token(Token = "0x6000EFA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7DC58", Offset = "0x1C7DC58", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.SpanHelpers), Member = "ClearWithReferences", MemberParameters = new object[]
		{
			typeof(ref global::System.IntPtr),
			typeof(ulong)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.RNGCryptoServiceProvider), Member = "GetBytes", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.RNGCryptoServiceProvider), Member = "GetNonZeroBytes", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.MonoIO), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.IntPtrHelper", Member = "Add", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(int)
		}, ReturnType = typeof(global::System.IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 16)]
		public static explicit operator global::System.IntPtr(long value)
		{
			throw null;
		}

		// Token: 0x06000E13 RID: 3603 RVA: 0x00016D21 File Offset: 0x00014F21
		[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.MayCorruptInstance, global::System.Runtime.ConstrainedExecution.Cer.MayFail)]
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6000EFB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7DC5C", Offset = "0x1C7DC5C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 60)]
		public unsafe static explicit operator global::System.IntPtr(void* value)
		{
			throw null;
		}

		// Token: 0x06000E14 RID: 3604 RVA: 0x00016D24 File Offset: 0x00014F24
		[global::Cpp2ILInjected.Token(Token = "0x6000EFC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7DC60", Offset = "0x1C7DC60", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Unity.UnityTlsContext", Member = "Read", MemberParameters = new object[]
		{
			"System.Byte[]",
			typeof(int),
			typeof(int)
		}, ReturnType = "System.ValueTuple`2<Int32, Boolean>")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Unity.UnityTlsContext", Member = "Write", MemberParameters = new object[]
		{
			"System.Byte[]",
			typeof(int),
			typeof(int)
		}, ReturnType = "System.ValueTuple`2<Int32, Boolean>")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Unity.UnityTlsContext", Member = "WriteCallback", MemberParameters = new object[]
		{
			"System.Byte*",
			typeof(global::System.IntPtr),
			"unitytls_errorstate*"
		}, ReturnType = typeof(global::System.IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Unity.UnityTlsContext", Member = "ReadCallback", MemberParameters = new object[]
		{
			"System.Byte*",
			typeof(global::System.IntPtr),
			"unitytls_errorstate*"
		}, ReturnType = typeof(global::System.IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Unity.X509ChainImplUnityTls", Member = "get_ChainElements", ReturnType = "System.Security.Cryptography.X509Certificates.X509ChainElementCollection")]
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
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 14)]
		public static explicit operator int(global::System.IntPtr value)
		{
			throw null;
		}

		// Token: 0x06000E15 RID: 3605 RVA: 0x00016D27 File Offset: 0x00014F27
		[global::Cpp2ILInjected.Token(Token = "0x6000EFD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7DC64", Offset = "0x1C7DC64", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.IntPtrHelper", Member = "Add", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(int)
		}, ReturnType = typeof(global::System.IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.IntPtrHelper", Member = "Subtract", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		public static explicit operator long(global::System.IntPtr value)
		{
			throw null;
		}

		// Token: 0x06000E16 RID: 3606 RVA: 0x00016D2A File Offset: 0x00014F2A
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6000EFE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7DC68", Offset = "0x1C7DC68", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 87)]
		public unsafe static explicit operator void*(global::System.IntPtr value)
		{
			throw null;
		}

		// Token: 0x06000E17 RID: 3607 RVA: 0x00016D2D File Offset: 0x00014F2D
		[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.MayCorruptInstance, global::System.Runtime.ConstrainedExecution.Cer.MayFail)]
		[global::Cpp2ILInjected.Token(Token = "0x6000EFF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7DC6C", Offset = "0x1C7DC6C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.InteropServices.Marshal), Member = "ClearBSTR", MemberParameters = new object[] { typeof(global::System.IntPtr) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.InteropServices.Marshal), Member = "ClearAnsi", MemberParameters = new object[] { typeof(global::System.IntPtr) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.InteropServices.Marshal), Member = "WriteByte", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(int),
			typeof(byte)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		public static global::System.IntPtr Add(global::System.IntPtr pointer, int offset)
		{
			throw null;
		}

		// Token: 0x06000E18 RID: 3608 RVA: 0x00016D30 File Offset: 0x00014F30
		[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.MayCorruptInstance, global::System.Runtime.ConstrainedExecution.Cer.MayFail)]
		[global::Cpp2ILInjected.Token(Token = "0x6000F00")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7DC74", Offset = "0x1C7DC74", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.SpanHelpers), Member = "IndexOf", MemberParameters = new object[]
		{
			typeof(ref byte),
			typeof(byte),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.SpanHelpers), Member = "SequenceEqual", MemberParameters = new object[]
		{
			typeof(ref byte),
			typeof(ref byte),
			typeof(ulong)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.SpanHelpers), Member = "SequenceCompareTo", MemberParameters = new object[]
		{
			typeof(ref char),
			typeof(int),
			typeof(ref char),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.SpanHelpers), Member = "IndexOf", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			"T&",
			"T",
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.SpanHelpers), Member = "SequenceEqual", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			"T&",
			"T&",
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.NetworkInformation.AixNetworkInterfaceAPI", Member = "GetAllNetworkInterfaces", ReturnType = "System.Net.NetworkInformation.NetworkInterface[]")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 63)]
		public static global::System.IntPtr operator +(global::System.IntPtr pointer, int offset)
		{
			throw null;
		}

		// Token: 0x06000E19 RID: 3609 RVA: 0x00016D33 File Offset: 0x00014F33
		[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.MayCorruptInstance, global::System.Runtime.ConstrainedExecution.Cer.MayFail)]
		[global::Cpp2ILInjected.Token(Token = "0x6000F01")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7DC7C", Offset = "0x1C7DC7C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.SpanHelpers), Member = "IndexOf", MemberParameters = new object[]
		{
			typeof(ref byte),
			typeof(byte),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.SpanHelpers), Member = "SequenceEqual", MemberParameters = new object[]
		{
			typeof(ref byte),
			typeof(ref byte),
			typeof(ulong)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.SpanHelpers), Member = "SequenceCompareTo", MemberParameters = new object[]
		{
			typeof(ref char),
			typeof(int),
			typeof(ref char),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		public static global::System.IntPtr operator -(global::System.IntPtr pointer, int offset)
		{
			throw null;
		}

		// Token: 0x06000E1A RID: 3610 RVA: 0x00016D36 File Offset: 0x00014F36
		[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
		[global::Cpp2ILInjected.Token(Token = "0x6000F02")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7DC84", Offset = "0x1C7DC84", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Microsoft.Win32.SafeHandles.SafeHandleZeroOrMinusOneIsInvalid), Member = "get_IsInvalid", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		internal bool IsNull()
		{
			throw null;
		}

		// Token: 0x06000E1B RID: 3611 RVA: 0x00016D39 File Offset: 0x00014F39
		[global::Cpp2ILInjected.Token(Token = "0x6000F03")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7DC94", Offset = "0x1C7DC94", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private bool System.IEquatable<System.IntPtr>.Equals(global::System.IntPtr other)
		{
			throw null;
		}

		// Token: 0x040004AB RID: 1195
		[global::Cpp2ILInjected.Token(Token = "0x400067A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private unsafe readonly void* m_value;

		// Token: 0x040004AC RID: 1196
		[global::Cpp2ILInjected.Token(Token = "0x400067B")]
		public static readonly global::System.IntPtr Zero;
	}
}
