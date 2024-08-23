using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Internal.Cryptography
{
	// Token: 0x02000028 RID: 40
	[global::Cpp2ILInjected.Token(Token = "0x200006F")]
	internal static class OidLookup
	{
		// Token: 0x06000126 RID: 294 RVA: 0x0000314C File Offset: 0x0000134C
		[global::Cpp2ILInjected.Token(Token = "0x60001A0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D4F928", Offset = "0x1D4F928", Length = "0x1CC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Oid), Member = "FromOidValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(OidGroup)
		}, ReturnType = typeof(Oid))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Oid), Member = "get_FriendlyName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConcurrentDictionary<object, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OidLookup), Member = "NativeOidToFriendlyName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(OidGroup),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConcurrentDictionary<object, object>), Member = "TryAdd", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public static string ToFriendlyName(string oid, OidGroup oidGroup, bool fallBackToAllGroups)
		{
			throw null;
		}

		// Token: 0x06000127 RID: 295 RVA: 0x0000314F File Offset: 0x0000134F
		[global::Cpp2ILInjected.Token(Token = "0x60001A1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D4FE34", Offset = "0x1D4FE34", Length = "0x1AC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Oid), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConcurrentDictionary<object, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OidLookup), Member = "NativeFriendlyNameToOid", MemberParameters = new object[]
		{
			typeof(string),
			typeof(OidGroup),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConcurrentDictionary<object, object>), Member = "TryAdd", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public static string ToOid(string friendlyName, OidGroup oidGroup, bool fallBackToAllGroups)
		{
			throw null;
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00003152 File Offset: 0x00001352
		[global::Cpp2ILInjected.Token(Token = "0x60001A2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D4FAF4", Offset = "0x1D4FAF4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static bool ShouldUseCache(OidGroup oidGroup)
		{
			throw null;
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00003155 File Offset: 0x00001355
		[global::Cpp2ILInjected.Token(Token = "0x60001A3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D4FAFC", Offset = "0x1D4FAFC", Length = "0x338")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(OidLookup), Member = "ToFriendlyName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(OidGroup),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(<PrivateImplementationDetails>), Member = "ComputeStringHash", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		private static string NativeOidToFriendlyName(string oid, OidGroup oidGroup, bool fallBackToAllGroups)
		{
			throw null;
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00003158 File Offset: 0x00001358
		[global::Cpp2ILInjected.Token(Token = "0x60001A4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D4FFE0", Offset = "0x1D4FFE0", Length = "0x344")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(OidLookup), Member = "ToOid", MemberParameters = new object[]
		{
			typeof(string),
			typeof(OidGroup),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(<PrivateImplementationDetails>), Member = "ComputeStringHash", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		private static string NativeFriendlyNameToOid(string friendlyName, OidGroup oidGroup, bool fallBackToAllGroups)
		{
			throw null;
		}

		// Token: 0x0600012B RID: 299 RVA: 0x0000315B File Offset: 0x0000135B
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60001A5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D50324", Offset = "0x1D50324", Length = "0x1C80")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConcurrentDictionary<object, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConcurrentDictionary<object, object>), Member = ".ctor", MemberParameters = new object[] { typeof(IEqualityComparer<object>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = ".ctor", MemberParameters = new object[] { typeof(IEqualityComparer<object>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "Add", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<KeyValuePair<object, object>, object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "ToDictionary", MemberTypeParameters = new object[]
		{
			typeof(KeyValuePair<object, object>),
			typeof(object),
			typeof(object)
		}, MemberParameters = new object[]
		{
			typeof(IEnumerable<KeyValuePair<object, object>>),
			typeof(Func<KeyValuePair<object, object>, object>),
			typeof(Func<KeyValuePair<object, object>, object>)
		}, ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TElement>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 240)]
		static OidLookup()
		{
			throw null;
		}

		// Token: 0x0400006F RID: 111
		[global::Cpp2ILInjected.Token(Token = "0x4000135")]
		private static readonly ConcurrentDictionary<string, string> s_lateBoundOidToFriendlyName;

		// Token: 0x04000070 RID: 112
		[global::Cpp2ILInjected.Token(Token = "0x4000136")]
		private static readonly ConcurrentDictionary<string, string> s_lateBoundFriendlyNameToOid;

		// Token: 0x04000071 RID: 113
		[global::Cpp2ILInjected.Token(Token = "0x4000137")]
		private static readonly Dictionary<string, string> s_friendlyNameToOid;

		// Token: 0x04000072 RID: 114
		[global::Cpp2ILInjected.Token(Token = "0x4000138")]
		private static readonly Dictionary<string, string> s_oidToFriendlyName;

		// Token: 0x04000073 RID: 115
		[global::Cpp2ILInjected.Token(Token = "0x4000139")]
		private static readonly Dictionary<string, string> s_compatOids;

		// Token: 0x020003AF RID: 943
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000070")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06001D1E RID: 7454 RVA: 0x0000804E File Offset: 0x0000624E
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x60001A6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D51FA4", Offset = "0x1D51FA4", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			static <>c()
			{
				throw null;
			}

			// Token: 0x06001D1F RID: 7455 RVA: 0x00008051 File Offset: 0x00006251
			[global::Cpp2ILInjected.Token(Token = "0x60001A7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D52000", Offset = "0x1D52000", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c()
			{
				throw null;
			}

			// Token: 0x06001D20 RID: 7456 RVA: 0x00008054 File Offset: 0x00006254
			[global::Cpp2ILInjected.Token(Token = "0x60001A8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D52008", Offset = "0x1D52008", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal string <.cctor>b__10_0(KeyValuePair<string, string> kvp)
			{
				throw null;
			}

			// Token: 0x06001D21 RID: 7457 RVA: 0x00008057 File Offset: 0x00006257
			[global::Cpp2ILInjected.Token(Token = "0x60001A9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D52044", Offset = "0x1D52044", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal string <.cctor>b__10_1(KeyValuePair<string, string> kvp)
			{
				throw null;
			}

			// Token: 0x04001077 RID: 4215
			[global::Cpp2ILInjected.Token(Token = "0x400013A")]
			public static readonly OidLookup.<>c <>9;
		}
	}
}
