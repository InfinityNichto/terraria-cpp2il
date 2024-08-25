using System;
using System.Net.Security;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	[global::Cpp2ILInjected.Token(Token = "0x2000122")]
	internal static class ContextFlagsAdapterPal
	{
		[global::Cpp2ILInjected.Token(Token = "0x60006E3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE09D4", Offset = "0x1EE09D4", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NegotiateStreamPal), Member = "EstablishSecurityContext", MemberParameters = new object[]
		{
			typeof(SafeFreeNegoCredentials),
			typeof(ref SafeDeleteContext),
			typeof(string),
			typeof(ContextFlagsPal),
			typeof(SecurityBuffer),
			typeof(SecurityBuffer),
			typeof(ref ContextFlagsPal)
		}, ReturnType = typeof(SecurityStatusPal))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static ContextFlagsPal GetContextFlagsPalFromInterop(Interop.NetSecurityNative.GssFlags gssFlags, bool isServer)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60006E4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE0A90", Offset = "0x1EE0A90", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NegotiateStreamPal), Member = "EstablishSecurityContext", MemberParameters = new object[]
		{
			typeof(SafeFreeNegoCredentials),
			typeof(ref SafeDeleteContext),
			typeof(string),
			typeof(ContextFlagsPal),
			typeof(SecurityBuffer),
			typeof(SecurityBuffer),
			typeof(ref ContextFlagsPal)
		}, ReturnType = typeof(SecurityStatusPal))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static Interop.NetSecurityNative.GssFlags GetInteropFromContextFlagsPal(ContextFlagsPal flags, bool isServer)
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60006E5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE0B48", Offset = "0x1EE0B48", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static ContextFlagsAdapterPal()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400054C")]
		private static readonly ContextFlagsAdapterPal.ContextFlagMapping[] s_contextFlagMapping;

		[global::Cpp2ILInjected.Token(Token = "0x2000123")]
		private readonly struct ContextFlagMapping
		{
			[global::Cpp2ILInjected.Token(Token = "0x60006E6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EE0BD0", Offset = "0x1EE0BD0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public ContextFlagMapping(Interop.NetSecurityNative.GssFlags gssFlag, ContextFlagsPal contextFlag)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x400054D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public readonly Interop.NetSecurityNative.GssFlags GssFlags;

			[global::Cpp2ILInjected.Token(Token = "0x400054E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
			public readonly ContextFlagsPal ContextFlag;
		}
	}
}
