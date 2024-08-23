using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Collections.ObjectModel
{
	// Token: 0x0200050E RID: 1294
	[global::System.Diagnostics.DebuggerDisplay("Count = {Count}")]
	[global::System.Diagnostics.DebuggerTypeProxy(typeof(global::System.Collections.Generic.CollectionDebugView<>))]
	[global::Cpp2ILInjected.Token(Token = "0x2000620")]
	[global::System.Serializable]
	public abstract class KeyedCollection<TKey, TItem> : Collection<TItem>
	{
		// Token: 0x06002BCB RID: 11211 RVA: 0x0001BF1A File Offset: 0x0001A11A
		[global::Cpp2ILInjected.Token(Token = "0x600300B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1726510", Offset = "0x1726510", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected KeyedCollection()
		{
			throw null;
		}

		// Token: 0x06002BCC RID: 11212 RVA: 0x0001BF1D File Offset: 0x0001A11D
		[global::Cpp2ILInjected.Token(Token = "0x600300C")]
		[global::Cpp2ILInjected.Address(RVA = "0x172652C", Offset = "0x172652C", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Serialization.JsonPropertyCollection", Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected KeyedCollection(global::System.Collections.Generic.IEqualityComparer<TKey> comparer)
		{
			throw null;
		}

		// Token: 0x06002BCD RID: 11213 RVA: 0x0001BF20 File Offset: 0x0001A120
		[global::Cpp2ILInjected.Token(Token = "0x600300D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1726544", Offset = "0x1726544", Length = "0x11C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		protected KeyedCollection(global::System.Collections.Generic.IEqualityComparer<TKey> comparer, int dictionaryCreationThreshold)
		{
			throw null;
		}

		// Token: 0x170006C7 RID: 1735
		// (get) Token: 0x06002BCE RID: 11214 RVA: 0x0001BF23 File Offset: 0x0001A123
		[global::Cpp2ILInjected.Token(Token = "0x170007A9")]
		private new global::System.Collections.Generic.List<TItem> Items
		{
			[global::Cpp2ILInjected.Token(Token = "0x600300E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1726660", Offset = "0x1726660", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170006C8 RID: 1736
		[global::Cpp2ILInjected.Token(Token = "0x170007AA")]
		public TItem this[TKey key]
		{
			[global::Cpp2ILInjected.Token(Token = "0x600300F")]
			[global::Cpp2ILInjected.Address(RVA = "0x17266E0", Offset = "0x17266E0", Length = "0xA4")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Serialization.JsonPropertyCollection", Member = "AddProperty", MemberParameters = new object[] { "Newtonsoft.Json.Serialization.JsonProperty" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::SR), Member = "Format", MemberParameters = new object[]
			{
				typeof(string),
				typeof(object)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.KeyNotFoundException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002BD0 RID: 11216 RVA: 0x0001BF29 File Offset: 0x0001A129
		[global::Cpp2ILInjected.Token(Token = "0x6003010")]
		[global::Cpp2ILInjected.Address(RVA = "0x1726784", Offset = "0x1726784", Length = "0x24C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Serialization.JsonPropertyCollection", Member = "AddProperty", MemberParameters = new object[] { "Newtonsoft.Json.Serialization.JsonProperty" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public bool Contains(TKey key)
		{
			throw null;
		}

		// Token: 0x06002BD1 RID: 11217 RVA: 0x0001BF2C File Offset: 0x0001A12C
		[global::Cpp2ILInjected.Token(Token = "0x6003011")]
		[global::Cpp2ILInjected.Address(RVA = "0x17269D0", Offset = "0x17269D0", Length = "0x274")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public bool TryGetValue(TKey key, out TItem item)
		{
			throw null;
		}

		// Token: 0x170006C9 RID: 1737
		// (get) Token: 0x06002BD2 RID: 11218 RVA: 0x0001BF2F File Offset: 0x0001A12F
		[global::Cpp2ILInjected.Token(Token = "0x170007AB")]
		protected global::System.Collections.Generic.IDictionary<TKey, TItem> Dictionary
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003012")]
			[global::Cpp2ILInjected.Address(RVA = "0x1726C44", Offset = "0x1726C44", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002BD3 RID: 11219 RVA: 0x0001BF32 File Offset: 0x0001A132
		[global::Cpp2ILInjected.Token(Token = "0x6003013")]
		[global::Cpp2ILInjected.Address(RVA = "0x1726C4C", Offset = "0x1726C4C", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected override void ClearItems()
		{
			throw null;
		}

		// Token: 0x06002BD4 RID: 11220
		[global::Cpp2ILInjected.Token(Token = "0x6003014")]
		protected abstract TKey GetKeyForItem(TItem item);

		// Token: 0x06002BD5 RID: 11221 RVA: 0x0001BF35 File Offset: 0x0001A135
		[global::Cpp2ILInjected.Token(Token = "0x6003015")]
		[global::Cpp2ILInjected.Address(RVA = "0x1726C9C", Offset = "0x1726C9C", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected override void InsertItem(int index, TItem item)
		{
			throw null;
		}

		// Token: 0x06002BD6 RID: 11222 RVA: 0x0001BF38 File Offset: 0x0001A138
		[global::Cpp2ILInjected.Token(Token = "0x6003016")]
		[global::Cpp2ILInjected.Address(RVA = "0x1726D1C", Offset = "0x1726D1C", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected override void RemoveItem(int index)
		{
			throw null;
		}

		// Token: 0x06002BD7 RID: 11223 RVA: 0x0001BF3B File Offset: 0x0001A13B
		[global::Cpp2ILInjected.Token(Token = "0x6003017")]
		[global::Cpp2ILInjected.Address(RVA = "0x1726DB8", Offset = "0x1726DB8", Length = "0x1A8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		protected override void SetItem(int index, TItem item)
		{
			throw null;
		}

		// Token: 0x06002BD8 RID: 11224 RVA: 0x0001BF3E File Offset: 0x0001A13E
		[global::Cpp2ILInjected.Token(Token = "0x6003018")]
		[global::Cpp2ILInjected.Address(RVA = "0x1726F60", Offset = "0x1726F60", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::SR), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private void AddKey(TKey key, TItem item)
		{
			throw null;
		}

		// Token: 0x06002BD9 RID: 11225 RVA: 0x0001BF41 File Offset: 0x0001A141
		[global::Cpp2ILInjected.Token(Token = "0x6003019")]
		[global::Cpp2ILInjected.Address(RVA = "0x1727064", Offset = "0x1727064", Length = "0x194")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private void CreateDictionary()
		{
			throw null;
		}

		// Token: 0x06002BDA RID: 11226 RVA: 0x0001BF44 File Offset: 0x0001A144
		[global::Cpp2ILInjected.Token(Token = "0x600301A")]
		[global::Cpp2ILInjected.Address(RVA = "0x17271F8", Offset = "0x17271F8", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void RemoveKey(TKey key)
		{
			throw null;
		}

		// Token: 0x040015FB RID: 5627
		[global::Cpp2ILInjected.Token(Token = "0x4001A44")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly global::System.Collections.Generic.IEqualityComparer<TKey> comparer;

		// Token: 0x040015FC RID: 5628
		[global::Cpp2ILInjected.Token(Token = "0x4001A45")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private global::System.Collections.Generic.Dictionary<TKey, TItem> dict;

		// Token: 0x040015FD RID: 5629
		[global::Cpp2ILInjected.Token(Token = "0x4001A46")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private int keyCount;

		// Token: 0x040015FE RID: 5630
		[global::Cpp2ILInjected.Token(Token = "0x4001A47")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly int threshold;
	}
}
