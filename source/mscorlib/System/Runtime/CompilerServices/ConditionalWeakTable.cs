using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.CompilerServices
{
	// Token: 0x020003E8 RID: 1000
	[global::Cpp2ILInjected.Token(Token = "0x20004A0")]
	public sealed class ConditionalWeakTable<TKey, TValue> : global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<TKey, TValue>>, global::System.Collections.IEnumerable where TKey : class where TValue : class
	{
		// Token: 0x06002021 RID: 8225 RVA: 0x00019F04 File Offset: 0x00018104
		[global::Cpp2ILInjected.Token(Token = "0x6002291")]
		[global::Cpp2ILInjected.Address(RVA = "0x191F998", Offset = "0x191F998", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.OSSpecificSynchronizationContext), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.HashHelpers), Member = "get_SerializationInfoTable", ReturnType = typeof(ConditionalWeakTable<object, global::System.Runtime.Serialization.SerializationInfo>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Http.NtlmClient", Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.GC), Member = "register_ephemeron_array", MemberParameters = new object[] { typeof(Ephemeron[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public ConditionalWeakTable()
		{
			throw null;
		}

		// Token: 0x06002022 RID: 8226 RVA: 0x00019F07 File Offset: 0x00018107
		[global::Cpp2ILInjected.Token(Token = "0x6002292")]
		[global::Cpp2ILInjected.Address(RVA = "0x191FA58", Offset = "0x191FA58", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "Finalize", ReturnType = typeof(void))]
		protected override void Finalize()
		{
			throw null;
		}

		// Token: 0x06002023 RID: 8227 RVA: 0x00019F0A File Offset: 0x0001810A
		[global::Cpp2ILInjected.Token(Token = "0x6002293")]
		[global::Cpp2ILInjected.Address(RVA = "0x191FA60", Offset = "0x191FA60", Length = "0x140")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "GetHashCode", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void RehashWithoutResize()
		{
			throw null;
		}

		// Token: 0x06002024 RID: 8228 RVA: 0x00019F0D File Offset: 0x0001810D
		[global::Cpp2ILInjected.Token(Token = "0x6002294")]
		[global::Cpp2ILInjected.Address(RVA = "0x191FBA0", Offset = "0x191FBA0", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void RecomputeSize()
		{
			throw null;
		}

		// Token: 0x06002025 RID: 8229 RVA: 0x00019F10 File Offset: 0x00018110
		[global::Cpp2ILInjected.Token(Token = "0x6002295")]
		[global::Cpp2ILInjected.Address(RVA = "0x191FBE8", Offset = "0x191FBE8", Length = "0x264")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.HashHelpers), Member = "GetPrime", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.GC), Member = "register_ephemeron_array", MemberParameters = new object[] { typeof(Ephemeron[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "GetHashCode", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private void Rehash()
		{
			throw null;
		}

		// Token: 0x06002026 RID: 8230 RVA: 0x00019F13 File Offset: 0x00018113
		[global::Cpp2ILInjected.Token(Token = "0x6002296")]
		[global::Cpp2ILInjected.Address(RVA = "0x191FE4C", Offset = "0x191FE4C", Length = "0x2C0")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Hashtable), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Generic.Dictionary<, >), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "GetHashCode", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		public void Add(TKey key, TValue value)
		{
			throw null;
		}

		// Token: 0x06002027 RID: 8231 RVA: 0x00019F16 File Offset: 0x00018116
		[global::Cpp2ILInjected.Token(Token = "0x6002297")]
		[global::Cpp2ILInjected.Address(RVA = "0x192010C", Offset = "0x192010C", Length = "0x208")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Hashtable), Member = "OnDeserialization", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Generic.Dictionary<, >), Member = "OnDeserialization", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "GetHashCode", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public bool Remove(TKey key)
		{
			throw null;
		}

		// Token: 0x06002028 RID: 8232 RVA: 0x00019F19 File Offset: 0x00018119
		[global::Cpp2ILInjected.Token(Token = "0x6002298")]
		[global::Cpp2ILInjected.Address(RVA = "0x1920314", Offset = "0x1920314", Length = "0x248")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Hashtable), Member = "OnDeserialization", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Generic.Dictionary<, >), Member = "OnDeserialization", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "GetHashCode", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		public bool TryGetValue(TKey key, out TValue value)
		{
			throw null;
		}

		// Token: 0x06002029 RID: 8233 RVA: 0x00019F1C File Offset: 0x0001811C
		[global::Cpp2ILInjected.Token(Token = "0x6002299")]
		[global::Cpp2ILInjected.Address(RVA = "0x192055C", Offset = "0x192055C", Length = "0x1D4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.OSSpecificSynchronizationContext), Member = "Get", ReturnType = typeof(global::System.Threading.OSSpecificSynchronizationContext))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Http.NtlmClient", Member = "Authenticate", MemberParameters = new object[]
		{
			typeof(string),
			"System.Net.WebRequest",
			"System.Net.ICredentials"
		}, ReturnType = "System.Net.Authorization")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public TValue GetValue(TKey key, ConditionalWeakTable<TKey, TValue>.CreateValueCallback createValueCallback)
		{
			throw null;
		}

		// Token: 0x0600202A RID: 8234 RVA: 0x00019F1F File Offset: 0x0001811F
		[global::Cpp2ILInjected.Token(Token = "0x600229A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1920730", Offset = "0x1920730", Length = "0x198")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<TKey, TValue>> Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_0()
		{
			throw null;
		}

		// Token: 0x0600202B RID: 8235 RVA: 0x00019F22 File Offset: 0x00018122
		[global::Cpp2ILInjected.Token(Token = "0x600229B")]
		[global::Cpp2ILInjected.Address(RVA = "0x19208C8", Offset = "0x19208C8", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private global::System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			throw null;
		}

		// Token: 0x04000FDF RID: 4063
		[global::Cpp2ILInjected.Token(Token = "0x40012EC")]
		private const int INITIAL_SIZE = 13;

		// Token: 0x04000FE0 RID: 4064
		[global::Cpp2ILInjected.Token(Token = "0x40012ED")]
		private const float LOAD_FACTOR = 0.7f;

		// Token: 0x04000FE1 RID: 4065
		[global::Cpp2ILInjected.Token(Token = "0x40012EE")]
		private const float COMPACT_FACTOR = 0.5f;

		// Token: 0x04000FE2 RID: 4066
		[global::Cpp2ILInjected.Token(Token = "0x40012EF")]
		private const float EXPAND_FACTOR = 1.1f;

		// Token: 0x04000FE3 RID: 4067
		[global::Cpp2ILInjected.Token(Token = "0x40012F0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private Ephemeron[] data;

		// Token: 0x04000FE4 RID: 4068
		[global::Cpp2ILInjected.Token(Token = "0x40012F1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private object _lock;

		// Token: 0x04000FE5 RID: 4069
		[global::Cpp2ILInjected.Token(Token = "0x40012F2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private int size;

		// Token: 0x02000603 RID: 1539
		// (Invoke) Token: 0x06004148 RID: 16712
		[global::Cpp2ILInjected.Token(Token = "0x20004A1")]
		public delegate TValue CreateValueCallback(TKey key);

		// Token: 0x02000604 RID: 1540
		[global::Cpp2ILInjected.Token(Token = "0x20004A2")]
		private sealed class Enumerator : global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<TKey, TValue>>, global::System.IDisposable, global::System.Collections.IEnumerator
		{
			// Token: 0x06004149 RID: 16713 RVA: 0x0001FE71 File Offset: 0x0001E071
			[global::Cpp2ILInjected.Token(Token = "0x600229E")]
			[global::Cpp2ILInjected.Address(RVA = "0x165A8F4", Offset = "0x165A8F4", Length = "0x34")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public Enumerator(ConditionalWeakTable<TKey, TValue> table)
			{
				throw null;
			}

			// Token: 0x0600414A RID: 16714 RVA: 0x0001FE74 File Offset: 0x0001E074
			[global::Cpp2ILInjected.Token(Token = "0x600229F")]
			[global::Cpp2ILInjected.Address(RVA = "0x165A928", Offset = "0x165A928", Length = "0xA4")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "Finalize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			protected override void Finalize()
			{
				throw null;
			}

			// Token: 0x0600414B RID: 16715 RVA: 0x0001FE77 File Offset: 0x0001E077
			[global::Cpp2ILInjected.Token(Token = "0x60022A0")]
			[global::Cpp2ILInjected.Address(RVA = "0x165A9CC", Offset = "0x165A9CC", Length = "0x78")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.GC), Member = "SuppressFinalize", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			public void Dispose()
			{
				throw null;
			}

			// Token: 0x0600414C RID: 16716 RVA: 0x0001FE7A File Offset: 0x0001E07A
			[global::Cpp2ILInjected.Token(Token = "0x60022A1")]
			[global::Cpp2ILInjected.Address(RVA = "0x165AA44", Offset = "0x165AA44", Length = "0x23C")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Enter", MemberParameters = new object[]
			{
				typeof(object),
				typeof(ref bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.KeyValuePair<object, object>), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(object)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
			public bool MoveNext()
			{
				throw null;
			}

			// Token: 0x1700075F RID: 1887
			// (get) Token: 0x0600414D RID: 16717 RVA: 0x0001FE7D File Offset: 0x0001E07D
			[global::Cpp2ILInjected.Token(Token = "0x1700047C")]
			public global::System.Collections.Generic.KeyValuePair<TKey, TValue> Current
			{
				[global::Cpp2ILInjected.Token(Token = "0x60022A2")]
				[global::Cpp2ILInjected.Address(RVA = "0x165AC80", Offset = "0x165AC80", Length = "0x24")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumOpCantHappen", ReturnType = typeof(void))]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000760 RID: 1888
			// (get) Token: 0x0600414E RID: 16718 RVA: 0x0001FE80 File Offset: 0x0001E080
			[global::Cpp2ILInjected.Token(Token = "0x1700047D")]
			private object System.Collections.IEnumerator.Current
			{
				[global::Cpp2ILInjected.Token(Token = "0x60022A3")]
				[global::Cpp2ILInjected.Address(RVA = "0x165ACA4", Offset = "0x165ACA4", Length = "0x50")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				get
				{
					throw null;
				}
			}

			// Token: 0x0600414F RID: 16719 RVA: 0x0001FE83 File Offset: 0x0001E083
			[global::Cpp2ILInjected.Token(Token = "0x60022A4")]
			[global::Cpp2ILInjected.Address(RVA = "0x165ACF4", Offset = "0x165ACF4", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void Reset()
			{
				throw null;
			}

			// Token: 0x04001995 RID: 6549
			[global::Cpp2ILInjected.Token(Token = "0x40012F3")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private ConditionalWeakTable<TKey, TValue> _table;

			// Token: 0x04001996 RID: 6550
			[global::Cpp2ILInjected.Token(Token = "0x40012F4")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private int _currentIndex;

			// Token: 0x04001997 RID: 6551
			[global::Cpp2ILInjected.Token(Token = "0x40012F5")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private global::System.Collections.Generic.KeyValuePair<TKey, TValue> _current;
		}
	}
}
