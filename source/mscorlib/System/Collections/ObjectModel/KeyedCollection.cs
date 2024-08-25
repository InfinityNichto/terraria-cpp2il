using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Collections.ObjectModel
{
	[global::System.Diagnostics.DebuggerDisplay("Count = {Count}")]
	[global::System.Diagnostics.DebuggerTypeProxy(typeof(global::System.Collections.Generic.CollectionDebugView<>))]
	[global::Cpp2ILInjected.Token(Token = "0x2000620")]
	[global::System.Serializable]
	public abstract class KeyedCollection<TKey, TItem> : Collection<TItem>
	{
		[global::Cpp2ILInjected.Token(Token = "0x600300B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1726510", Offset = "0x1726510", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected KeyedCollection()
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x6003013")]
		[global::Cpp2ILInjected.Address(RVA = "0x1726C4C", Offset = "0x1726C4C", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected override void ClearItems()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003014")]
		protected abstract TKey GetKeyForItem(TItem item);

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

		[global::Cpp2ILInjected.Token(Token = "0x600301A")]
		[global::Cpp2ILInjected.Address(RVA = "0x17271F8", Offset = "0x17271F8", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void RemoveKey(TKey key)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4001A44")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly global::System.Collections.Generic.IEqualityComparer<TKey> comparer;

		[global::Cpp2ILInjected.Token(Token = "0x4001A45")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private global::System.Collections.Generic.Dictionary<TKey, TItem> dict;

		[global::Cpp2ILInjected.Token(Token = "0x4001A46")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private int keyCount;

		[global::Cpp2ILInjected.Token(Token = "0x4001A47")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly int threshold;
	}
}
