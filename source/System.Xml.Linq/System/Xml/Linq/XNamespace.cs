using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Linq
{
	// Token: 0x02000011 RID: 17
	[global::Cpp2ILInjected.Token(Token = "0x2000017")]
	public sealed class XNamespace
	{
		// Token: 0x06000081 RID: 129 RVA: 0x000021D0 File Offset: 0x000003D0
		[global::Cpp2ILInjected.Token(Token = "0x600009A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6E394", Offset = "0x1D6E394", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNamespace), Member = "Get", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(XNamespace))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNamespace), Member = "EnsureNamespace", MemberParameters = new object[]
		{
			typeof(ref WeakReference),
			typeof(string)
		}, ReturnType = typeof(XNamespace))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XHashtable<>.ExtractKeyDelegate), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XHashtable<>), Member = ".ctor", MemberParameters = new object[]
		{
			"ExtractKeyDelegate<TValue>",
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal XNamespace(string namespaceName)
		{
			throw null;
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000082 RID: 130 RVA: 0x000021D3 File Offset: 0x000003D3
		[global::Cpp2ILInjected.Token(Token = "0x1700001F")]
		public string NamespaceName
		{
			[global::Cpp2ILInjected.Token(Token = "0x600009B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D6E484", Offset = "0x1D6E484", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000083 RID: 131 RVA: 0x000021D6 File Offset: 0x000003D6
		[global::Cpp2ILInjected.Token(Token = "0x600009C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6E27C", Offset = "0x1D6E27C", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XName), Member = "Get", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(XName))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XName), Member = "Get", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(XName))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNamespace), Member = "GetName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(XName))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public XName GetName(string localName)
		{
			throw null;
		}

		// Token: 0x06000084 RID: 132 RVA: 0x000021D9 File Offset: 0x000003D9
		[global::Cpp2ILInjected.Token(Token = "0x600009D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6E48C", Offset = "0x1D6E48C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000085 RID: 133 RVA: 0x000021DC File Offset: 0x000003DC
		[global::Cpp2ILInjected.Token(Token = "0x17000020")]
		public static XNamespace None
		{
			[global::Cpp2ILInjected.Token(Token = "0x600009E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D6E214", Offset = "0x1D6E214", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XName), Member = "Get", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(XName))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNamespace), Member = "Get", MemberParameters = new object[]
			{
				typeof(string),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(XNamespace))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNamespace), Member = "EnsureNamespace", MemberParameters = new object[]
			{
				typeof(ref WeakReference),
				typeof(string)
			}, ReturnType = typeof(XNamespace))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000086 RID: 134 RVA: 0x000021DF File Offset: 0x000003DF
		[global::Cpp2ILInjected.Token(Token = "0x17000021")]
		public static XNamespace Xml
		{
			[global::Cpp2ILInjected.Token(Token = "0x600009F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D6E574", Offset = "0x1D6E574", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNamespace), Member = "Get", MemberParameters = new object[]
			{
				typeof(string),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(XNamespace))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNamespace), Member = "EnsureNamespace", MemberParameters = new object[]
			{
				typeof(ref WeakReference),
				typeof(string)
			}, ReturnType = typeof(XNamespace))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000087 RID: 135 RVA: 0x000021E2 File Offset: 0x000003E2
		[global::Cpp2ILInjected.Token(Token = "0x17000022")]
		public static XNamespace Xmlns
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000A0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D6E5D4", Offset = "0x1D6E5D4", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNamespace), Member = "Get", MemberParameters = new object[]
			{
				typeof(string),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(XNamespace))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNamespace), Member = "EnsureNamespace", MemberParameters = new object[]
			{
				typeof(ref WeakReference),
				typeof(string)
			}, ReturnType = typeof(XNamespace))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000088 RID: 136 RVA: 0x000021E5 File Offset: 0x000003E5
		[global::Cpp2ILInjected.Token(Token = "0x60000A1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6D924", Offset = "0x1D6D924", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ElementWriter), Member = "PushAncestors", MemberParameters = new object[] { typeof(XElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ElementWriter), Member = "PushElement", MemberParameters = new object[] { typeof(XElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XName), Member = "Get", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(XName))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNamespace), Member = "op_Implicit", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(XNamespace))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNamespace), Member = "Get", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(XNamespace))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static XNamespace Get(string namespaceName)
		{
			throw null;
		}

		// Token: 0x06000089 RID: 137 RVA: 0x000021E8 File Offset: 0x000003E8
		[CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x60000A2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6E634", Offset = "0x1D6E634", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Converters.XElementWrapper", Member = "GetPrefixOfNamespace", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNamespace), Member = "Get", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(XNamespace))]
		public static implicit operator XNamespace(string namespaceName)
		{
			throw null;
		}

		// Token: 0x0600008A RID: 138 RVA: 0x000021EB File Offset: 0x000003EB
		[global::Cpp2ILInjected.Token(Token = "0x60000A3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6E640", Offset = "0x1D6E640", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x0600008B RID: 139 RVA: 0x000021EE File Offset: 0x000003EE
		[global::Cpp2ILInjected.Token(Token = "0x60000A4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6E64C", Offset = "0x1D6E64C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x0600008C RID: 140 RVA: 0x000021F1 File Offset: 0x000003F1
		[global::Cpp2ILInjected.Token(Token = "0x60000A5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6CB60", Offset = "0x1D6CB60", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool operator ==(XNamespace left, XNamespace right)
		{
			throw null;
		}

		// Token: 0x0600008D RID: 141 RVA: 0x000021F4 File Offset: 0x000003F4
		[global::Cpp2ILInjected.Token(Token = "0x60000A6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6E654", Offset = "0x1D6E654", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool operator !=(XNamespace left, XNamespace right)
		{
			throw null;
		}

		// Token: 0x0600008E RID: 142 RVA: 0x000021F7 File Offset: 0x000003F7
		[global::Cpp2ILInjected.Token(Token = "0x60000A7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6E114", Offset = "0x1D6E114", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XName), Member = "Get", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(XName))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNamespace), Member = "GetName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(XName))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XHashtable<>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			"TValue&"
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XName), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(XNamespace),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XHashtable<>), Member = "Add", MemberParameters = new object[] { "TValue" }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal XName GetName(string localName, int index, int count)
		{
			throw null;
		}

		// Token: 0x0600008F RID: 143 RVA: 0x000021FA File Offset: 0x000003FA
		[global::Cpp2ILInjected.Token(Token = "0x60000A8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6DE54", Offset = "0x1D6DE54", Length = "0x2C0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XName), Member = "Get", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(XName))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNamespace), Member = "Get", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(XNamespace))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XHashtable<>.ExtractKeyDelegate), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XHashtable<>), Member = ".ctor", MemberParameters = new object[]
		{
			"ExtractKeyDelegate<TValue>",
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XHashtable<>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			"TValue&"
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CompareOrdinal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNamespace), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WeakReference), Member = ".ctor", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XHashtable<>), Member = "Add", MemberParameters = new object[] { "TValue" }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNamespace), Member = "get_None", ReturnType = typeof(XNamespace))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNamespace), Member = "get_Xml", ReturnType = typeof(XNamespace))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNamespace), Member = "get_Xmlns", ReturnType = typeof(XNamespace))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		internal static XNamespace Get(string namespaceName, int index, int count)
		{
			throw null;
		}

		// Token: 0x06000090 RID: 144 RVA: 0x000021FD File Offset: 0x000003FD
		[global::Cpp2ILInjected.Token(Token = "0x60000A9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6E660", Offset = "0x1D6E660", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static string ExtractLocalName(XName n)
		{
			throw null;
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00002200 File Offset: 0x00000400
		[global::Cpp2ILInjected.Token(Token = "0x60000AA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6E668", Offset = "0x1D6E668", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static string ExtractNamespace(WeakReference r)
		{
			throw null;
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00002203 File Offset: 0x00000403
		[global::Cpp2ILInjected.Token(Token = "0x60000AB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6E494", Offset = "0x1D6E494", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNamespace), Member = "get_None", ReturnType = typeof(XNamespace))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNamespace), Member = "get_Xml", ReturnType = typeof(XNamespace))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNamespace), Member = "get_Xmlns", ReturnType = typeof(XNamespace))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNamespace), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WeakReference), Member = ".ctor", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private static XNamespace EnsureNamespace(ref WeakReference refNmsp, string namespaceName)
		{
			throw null;
		}

		// Token: 0x04000022 RID: 34
		[global::Cpp2ILInjected.Token(Token = "0x4000039")]
		private static XHashtable<WeakReference> s_namespaces;

		// Token: 0x04000023 RID: 35
		[global::Cpp2ILInjected.Token(Token = "0x400003A")]
		private static WeakReference s_refNone;

		// Token: 0x04000024 RID: 36
		[global::Cpp2ILInjected.Token(Token = "0x400003B")]
		private static WeakReference s_refXml;

		// Token: 0x04000025 RID: 37
		[global::Cpp2ILInjected.Token(Token = "0x400003C")]
		private static WeakReference s_refXmlns;

		// Token: 0x04000026 RID: 38
		[global::Cpp2ILInjected.Token(Token = "0x400003D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string _namespaceName;

		// Token: 0x04000027 RID: 39
		[global::Cpp2ILInjected.Token(Token = "0x400003E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int _hashCode;

		// Token: 0x04000028 RID: 40
		[global::Cpp2ILInjected.Token(Token = "0x400003F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private XHashtable<XName> _names;
	}
}
