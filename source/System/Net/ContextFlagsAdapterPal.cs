using System;
using System.Net.Security;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x020000C2 RID: 194
	[global::Cpp2ILInjected.Token(Token = "0x2000122")]
	internal static class ContextFlagsAdapterPal
	{
		// Token: 0x06000635 RID: 1589 RVA: 0x00003FF2 File Offset: 0x000021F2
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

		// Token: 0x06000636 RID: 1590 RVA: 0x00003FF5 File Offset: 0x000021F5
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

		// Token: 0x06000637 RID: 1591 RVA: 0x00003FF8 File Offset: 0x000021F8
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60006E5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE0B48", Offset = "0x1EE0B48", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static ContextFlagsAdapterPal()
		{
			throw null;
		}

		// Token: 0x040003D9 RID: 985
		[global::Cpp2ILInjected.Token(Token = "0x400054C")]
		private static readonly ContextFlagsAdapterPal.ContextFlagMapping[] s_contextFlagMapping;

		// Token: 0x020003C8 RID: 968
		[global::Cpp2ILInjected.Token(Token = "0x2000123")]
		private readonly struct ContextFlagMapping
		{
			// Token: 0x06001D52 RID: 7506 RVA: 0x000080EA File Offset: 0x000062EA
			[global::Cpp2ILInjected.Token(Token = "0x60006E6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EE0BD0", Offset = "0x1EE0BD0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public ContextFlagMapping(Interop.NetSecurityNative.GssFlags gssFlag, ContextFlagsPal contextFlag)
			{
				throw null;
			}

			// Token: 0x04001124 RID: 4388
			[global::Cpp2ILInjected.Token(Token = "0x400054D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public readonly Interop.NetSecurityNative.GssFlags GssFlags;

			// Token: 0x04001125 RID: 4389
			[global::Cpp2ILInjected.Token(Token = "0x400054E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
			public readonly ContextFlagsPal ContextFlag;
		}
	}
}
