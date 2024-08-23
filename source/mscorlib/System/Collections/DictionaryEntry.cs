using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Resources;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Collections
{
	// Token: 0x020004ED RID: 1261
	[global::Cpp2ILInjected.Token(Token = "0x20005E1")]
	[global::System.Serializable]
	public struct DictionaryEntry
	{
		// Token: 0x06002A37 RID: 10807 RVA: 0x0001BADF File Offset: 0x00019CDF
		[global::Cpp2ILInjected.Token(Token = "0x6002D9B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C06EB4", Offset = "0x1C06EB4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Runtime.Remoting.Messaging.MessageDictionary.DictionaryEnumerator", Member = "get_Entry", ReturnType = typeof(DictionaryEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Resources.ResourceReader.ResourceEnumerator), Member = "get_Entry", ReturnType = typeof(DictionaryEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Collections.Concurrent.ConcurrentDictionary`2.DictionaryEnumerator", Member = "get_Entry", ReturnType = typeof(DictionaryEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Concurrent.ConcurrentDictionary<, >), Member = "CopyToEntries", MemberParameters = new object[]
		{
			typeof(DictionaryEntry[]),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Generic.Dictionary<, >.Enumerator), Member = "System.Collections.IEnumerator.get_Current", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Generic.Dictionary<, >.Enumerator), Member = "System.Collections.IDictionaryEnumerator.get_Entry", ReturnType = typeof(DictionaryEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Generic.Dictionary<, >), Member = "System.Collections.ICollection.CopyTo", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.PropertyDescriptorCollection.PropertyDescriptorEnumerator", Member = "get_Entry", ReturnType = typeof(DictionaryEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Collections.Specialized.ListDictionary.NodeEnumerator", Member = "get_Entry", ReturnType = typeof(DictionaryEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Collections.Specialized.ListDictionary", Member = "CopyTo", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Collections.Specialized.OrderedDictionary.OrderedDictionaryEnumerator", Member = "get_Entry", ReturnType = typeof(DictionaryEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Collections.Specialized.OrderedDictionary", Member = "set_Item", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Collections.Specialized.OrderedDictionary", Member = "Add", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Collections.Generic.SortedList`2.Enumerator", Member = "System.Collections.IDictionaryEnumerator.get_Entry", ReturnType = typeof(DictionaryEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Collections.Generic.SortedList`2.Enumerator", Member = "System.Collections.IEnumerator.get_Current", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.DictionaryWrapper`2.DictionaryEnumerator`2", Member = "get_Current", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 16)]
		public DictionaryEntry(object key, object value)
		{
			throw null;
		}

		// Token: 0x1700065C RID: 1628
		// (get) Token: 0x06002A38 RID: 10808 RVA: 0x0001BAE2 File Offset: 0x00019CE2
		[global::Cpp2ILInjected.Token(Token = "0x170006F3")]
		public object Key
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002D9C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C06EBC", Offset = "0x1C06EBC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700065D RID: 1629
		// (get) Token: 0x06002A39 RID: 10809 RVA: 0x0001BAE5 File Offset: 0x00019CE5
		[global::Cpp2ILInjected.Token(Token = "0x170006F4")]
		public object Value
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002D9D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C06EC4", Offset = "0x1C06EC4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x040015AF RID: 5551
		[global::Cpp2ILInjected.Token(Token = "0x400199F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private object _key;

		// Token: 0x040015B0 RID: 5552
		[global::Cpp2ILInjected.Token(Token = "0x40019A0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		private object _value;
	}
}
