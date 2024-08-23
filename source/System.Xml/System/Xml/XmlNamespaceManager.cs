using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Xml.Schema;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml
{
	// Token: 0x02000083 RID: 131
	[global::Cpp2ILInjected.Token(Token = "0x20000AA")]
	public class XmlNamespaceManager : IXmlNamespaceResolver, IEnumerable
	{
		// Token: 0x0600070C RID: 1804 RVA: 0x000043C7 File Offset: 0x000025C7
		[global::Cpp2ILInjected.Token(Token = "0x6000795")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DAFB38", Offset = "0x1DAFB38", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlTextReaderImpl.NoNamespaceManager", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.DtdValidator.NamespaceManager", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdValidator), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal XmlNamespaceManager()
		{
			throw null;
		}

		// Token: 0x0600070D RID: 1805 RVA: 0x000043CA File Offset: 0x000025CA
		[global::Cpp2ILInjected.Token(Token = "0x6000796")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DAFB40", Offset = "0x1DAFB40", Length = "0x198")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(TextReader),
			typeof(XmlNameTable)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "set_Namespaces", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "InitFragmentReader", MemberParameters = new object[]
		{
			typeof(XmlNodeType),
			typeof(XmlParserContext),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlLoader), Member = "ParseDocumentType", MemberParameters = new object[]
		{
			typeof(XmlDocumentType),
			typeof(bool),
			typeof(XmlResolver)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlLoader), Member = "GetContext", MemberParameters = new object[] { typeof(XmlNode) }, ReturnType = typeof(XmlParserContext))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Converters.XmlNodeConverter", Member = "WriteJson", MemberParameters = new object[]
		{
			"Newtonsoft.Json.JsonWriter",
			typeof(object),
			"Newtonsoft.Json.JsonSerializer"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Converters.XmlNodeConverter", Member = "ReadJson", MemberParameters = new object[]
		{
			"Newtonsoft.Json.JsonReader",
			typeof(Type),
			typeof(object),
			"Newtonsoft.Json.JsonSerializer"
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public XmlNamespaceManager(XmlNameTable nameTable)
		{
			throw null;
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x0600070E RID: 1806 RVA: 0x000043CD File Offset: 0x000025CD
		[global::Cpp2ILInjected.Token(Token = "0x170001CC")]
		public virtual XmlNameTable NameTable
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000797")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DAFCE4", Offset = "0x1DAFCE4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x0600070F RID: 1807 RVA: 0x000043D0 File Offset: 0x000025D0
		[global::Cpp2ILInjected.Token(Token = "0x170001CD")]
		public virtual string DefaultNamespace
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000798")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DAFCEC", Offset = "0x1DAFCEC", Length = "0x70")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000710 RID: 1808 RVA: 0x000043D3 File Offset: 0x000025D3
		[global::Cpp2ILInjected.Token(Token = "0x6000799")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DAFD5C", Offset = "0x1DAFD5C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void PushScope()
		{
			throw null;
		}

		// Token: 0x06000711 RID: 1809 RVA: 0x000043D6 File Offset: 0x000025D6
		[global::Cpp2ILInjected.Token(Token = "0x600079A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DAFD6C", Offset = "0x1DAFD6C", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, int>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(object),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual bool PopScope()
		{
			throw null;
		}

		// Token: 0x06000712 RID: 1810 RVA: 0x000043D9 File Offset: 0x000025D9
		[global::Cpp2ILInjected.Token(Token = "0x600079B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DAFE38", Offset = "0x1DAFE38", Length = "0x348")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Ref), Member = "Equal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNamespaceManager), Member = "LookupNamespaceDecl", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, int>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(object),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, int>), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		public virtual void AddNamespace(string prefix, string uri)
		{
			throw null;
		}

		// Token: 0x06000713 RID: 1811 RVA: 0x000043DC File Offset: 0x000025DC
		[global::Cpp2ILInjected.Token(Token = "0x600079C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB02DC", Offset = "0x1DB02DC", Length = "0xFC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNamespaceManager), Member = "LookupNamespaceDecl", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public virtual void RemoveNamespace(string prefix, string uri)
		{
			throw null;
		}

		// Token: 0x06000714 RID: 1812 RVA: 0x000043DF File Offset: 0x000025DF
		[global::Cpp2ILInjected.Token(Token = "0x600079D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB03D8", Offset = "0x1DB03D8", Length = "0x160")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "get_Keys", ReturnType = "KeyCollection<TKey, TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>.KeyCollection), Member = "GetEnumerator", ReturnType = "Enumerator<TKey, TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public virtual IEnumerator GetEnumerator()
		{
			throw null;
		}

		// Token: 0x06000715 RID: 1813 RVA: 0x000043E2 File Offset: 0x000025E2
		[global::Cpp2ILInjected.Token(Token = "0x600079E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB0538", Offset = "0x1DB0538", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNamespaceManager), Member = "LookupNamespaceDecl", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		public virtual string LookupNamespace(string prefix)
		{
			throw null;
		}

		// Token: 0x06000716 RID: 1814 RVA: 0x000043E5 File Offset: 0x000025E5
		[global::Cpp2ILInjected.Token(Token = "0x600079F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB0180", Offset = "0x1DB0180", Length = "0x15C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlNamespaceManager), Member = "AddNamespace", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlNamespaceManager), Member = "RemoveNamespace", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlNamespaceManager), Member = "LookupNamespace", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, int>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private int LookupNamespaceDecl(string prefix)
		{
			throw null;
		}

		// Token: 0x06000717 RID: 1815 RVA: 0x000043E8 File Offset: 0x000025E8
		[global::Cpp2ILInjected.Token(Token = "0x60007A0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB056C", Offset = "0x1DB056C", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		public virtual string LookupPrefix(string uri)
		{
			throw null;
		}

		// Token: 0x0400025A RID: 602
		[global::Cpp2ILInjected.Token(Token = "0x40003C2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private XmlNamespaceManager.NamespaceDeclaration[] nsdecls;

		// Token: 0x0400025B RID: 603
		[global::Cpp2ILInjected.Token(Token = "0x40003C3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int lastDecl;

		// Token: 0x0400025C RID: 604
		[global::Cpp2ILInjected.Token(Token = "0x40003C4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private XmlNameTable nameTable;

		// Token: 0x0400025D RID: 605
		[global::Cpp2ILInjected.Token(Token = "0x40003C5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private int scopeId;

		// Token: 0x0400025E RID: 606
		[global::Cpp2ILInjected.Token(Token = "0x40003C6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private Dictionary<string, int> hashTable;

		// Token: 0x0400025F RID: 607
		[global::Cpp2ILInjected.Token(Token = "0x40003C7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private bool useHashtable;

		// Token: 0x04000260 RID: 608
		[global::Cpp2ILInjected.Token(Token = "0x40003C8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private string xml;

		// Token: 0x04000261 RID: 609
		[global::Cpp2ILInjected.Token(Token = "0x40003C9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private string xmlNs;

		// Token: 0x0200016D RID: 365
		[global::Cpp2ILInjected.Token(Token = "0x20000AB")]
		private struct NamespaceDeclaration
		{
			// Token: 0x06000CBC RID: 3260 RVA: 0x00005396 File Offset: 0x00003596
			[global::Cpp2ILInjected.Token(Token = "0x60007A1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DAFCD8", Offset = "0x1DAFCD8", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void Set(string prefix, string uri, int scopeId, int previousNsIndex)
			{
				throw null;
			}

			// Token: 0x04000656 RID: 1622
			[global::Cpp2ILInjected.Token(Token = "0x40003CA")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public string prefix;

			// Token: 0x04000657 RID: 1623
			[global::Cpp2ILInjected.Token(Token = "0x40003CB")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public string uri;

			// Token: 0x04000658 RID: 1624
			[global::Cpp2ILInjected.Token(Token = "0x40003CC")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public int scopeId;

			// Token: 0x04000659 RID: 1625
			[global::Cpp2ILInjected.Token(Token = "0x40003CD")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
			public int previousNsIndex;
		}
	}
}
