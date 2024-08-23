using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Linq
{
	// Token: 0x0200000A RID: 10
	[XmlTypeConvertor("ConvertForAssignment")]
	[XmlSchemaProvider(null, IsAny = true)]
	[global::Cpp2ILInjected.Token(Token = "0x200000B")]
	public class XElement : XContainer
	{
		// Token: 0x0600004F RID: 79 RVA: 0x0000213A File Offset: 0x0000033A
		[global::Cpp2ILInjected.Token(Token = "0x6000057")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6C824", Offset = "0x1D6C824", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Converters.XDocumentWrapper", Member = "CreateElement", MemberParameters = new object[] { typeof(string) }, ReturnType = "Newtonsoft.Json.Converters.IXmlElement")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Converters.XDocumentWrapper", Member = "CreateElement", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = "Newtonsoft.Json.Converters.IXmlElement")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public XElement(XName name)
		{
			throw null;
		}

		// Token: 0x06000050 RID: 80 RVA: 0x0000213D File Offset: 0x0000033D
		[global::Cpp2ILInjected.Token(Token = "0x6000058")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6C898", Offset = "0x1D6C898", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XElement), Member = "CloneNode", ReturnType = typeof(XNode))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XContainer), Member = ".ctor", MemberParameters = new object[] { typeof(XContainer) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XAttribute), Member = ".ctor", MemberParameters = new object[] { typeof(XAttribute) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public XElement(XElement other)
		{
			throw null;
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002140 File Offset: 0x00000340
		[global::Cpp2ILInjected.Token(Token = "0x6000059")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6AE60", Offset = "0x1D6AE60", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XContainer), Member = "Add", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XContainer), Member = "AddContentSkipNotify", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XContainer), Member = "AddContentSkipNotify", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public XElement(XStreamingElement other)
		{
			throw null;
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000052 RID: 82 RVA: 0x00002143 File Offset: 0x00000343
		[global::Cpp2ILInjected.Token(Token = "0x17000016")]
		public bool IsEmpty
		{
			[global::Cpp2ILInjected.Token(Token = "0x600005A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D6C970", Offset = "0x1D6C970", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Converters.XElementWrapper", Member = "get_IsEmpty", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000053 RID: 83 RVA: 0x00002146 File Offset: 0x00000346
		[global::Cpp2ILInjected.Token(Token = "0x17000017")]
		public XName Name
		{
			[global::Cpp2ILInjected.Token(Token = "0x600005B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D6C980", Offset = "0x1D6C980", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000054 RID: 84 RVA: 0x00002149 File Offset: 0x00000349
		[global::Cpp2ILInjected.Token(Token = "0x17000018")]
		public override XmlNodeType NodeType
		{
			[global::Cpp2ILInjected.Token(Token = "0x600005C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D6C988", Offset = "0x1D6C988", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000055 RID: 85 RVA: 0x0000214C File Offset: 0x0000034C
		// (set) Token: 0x06000056 RID: 86 RVA: 0x0000214F File Offset: 0x0000034F
		[global::Cpp2ILInjected.Token(Token = "0x17000019")]
		public string Value
		{
			[global::Cpp2ILInjected.Token(Token = "0x600005D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D6C990", Offset = "0x1D6C990", Length = "0xA8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Converters.XElementWrapper", Member = "get_Value", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilderCache), Member = "Acquire", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(StringBuilder))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilderCache), Member = "Release", MemberParameters = new object[] { typeof(StringBuilder) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600005E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D6CA38", Offset = "0x1D6CA38", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Converters.XElementWrapper", Member = "set_Value", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XContainer), Member = "RemoveNodes", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XContainer), Member = "Add", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00002152 File Offset: 0x00000352
		[global::Cpp2ILInjected.Token(Token = "0x600005F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6CAAC", Offset = "0x1D6CAAC", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public XAttribute Attribute(XName name)
		{
			throw null;
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00002155 File Offset: 0x00000355
		[global::Cpp2ILInjected.Token(Token = "0x6000060")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6CAD8", Offset = "0x1D6CAD8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Converters.XElementWrapper", Member = "get_Attributes", ReturnType = "System.Collections.Generic.List`1<IXmlNode>")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public IEnumerable<XAttribute> Attributes()
		{
			throw null;
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00002158 File Offset: 0x00000358
		[global::Cpp2ILInjected.Token(Token = "0x6000061")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6980C", Offset = "0x1D6980C", Length = "0x204")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Converters.XElementWrapper", Member = "GetPrefixOfNamespace", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XAttribute), Member = "get_IsNamespaceDeclaration", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XElement), Member = "GetNamespaceOfPrefixInScope", MemberParameters = new object[]
		{
			typeof(string),
			typeof(XElement)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public string GetPrefixOfNamespace(XNamespace ns)
		{
			throw null;
		}

		// Token: 0x0600005A RID: 90 RVA: 0x0000215B File Offset: 0x0000035B
		[global::Cpp2ILInjected.Token(Token = "0x6000062")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6CC50", Offset = "0x1D6CC50", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ElementWriter), Member = "WriteElement", MemberParameters = new object[] { typeof(XElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override void WriteTo(XmlWriter writer)
		{
			throw null;
		}

		// Token: 0x0600005B RID: 91 RVA: 0x0000215E File Offset: 0x0000035E
		[global::Cpp2ILInjected.Token(Token = "0x6000063")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6CE9C", Offset = "0x1D6CE9C", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XAttribute), Member = ".ctor", MemberParameters = new object[] { typeof(XAttribute) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		internal override void AddAttribute(XAttribute a)
		{
			throw null;
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00002161 File Offset: 0x00000361
		[global::Cpp2ILInjected.Token(Token = "0x6000064")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6D0AC", Offset = "0x1D6D0AC", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XAttribute), Member = ".ctor", MemberParameters = new object[] { typeof(XAttribute) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		internal override void AddAttributeSkipNotify(XAttribute a)
		{
			throw null;
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00002164 File Offset: 0x00000364
		[global::Cpp2ILInjected.Token(Token = "0x6000065")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6CF80", Offset = "0x1D6CF80", Length = "0x12C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XObject), Member = "NotifyChanging", MemberParameters = new object[]
		{
			typeof(object),
			typeof(XObjectChangeEventArgs)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XObject), Member = "NotifyChanged", MemberParameters = new object[]
		{
			typeof(object),
			typeof(XObjectChangeEventArgs)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		internal void AppendAttribute(XAttribute a)
		{
			throw null;
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00002167 File Offset: 0x00000367
		[global::Cpp2ILInjected.Token(Token = "0x6000066")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6C948", Offset = "0x1D6C948", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal void AppendAttributeSkipNotify(XAttribute a)
		{
			throw null;
		}

		// Token: 0x0600005F RID: 95 RVA: 0x0000216A File Offset: 0x0000036A
		[global::Cpp2ILInjected.Token(Token = "0x6000067")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6D1AC", Offset = "0x1D6D1AC", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XElement), Member = ".ctor", MemberParameters = new object[] { typeof(XElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal override XNode CloneNode()
		{
			throw null;
		}

		// Token: 0x06000060 RID: 96 RVA: 0x0000216D File Offset: 0x0000036D
		[global::Cpp2ILInjected.Token(Token = "0x6000068")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6CAE0", Offset = "0x1D6CAE0", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Environment), Member = "get_CurrentManagedThreadId", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private IEnumerable<XAttribute> GetAttributes(XName name)
		{
			throw null;
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00002170 File Offset: 0x00000370
		[global::Cpp2ILInjected.Token(Token = "0x6000069")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6CB6C", Offset = "0x1D6CB6C", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XElement), Member = "GetPrefixOfNamespace", MemberParameters = new object[] { typeof(XNamespace) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XAttribute), Member = "get_IsNamespaceDeclaration", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private string GetNamespaceOfPrefixInScope(string prefix, XElement outOfScope)
		{
			throw null;
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00002173 File Offset: 0x00000373
		[global::Cpp2ILInjected.Token(Token = "0x600006A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6D238", Offset = "0x1D6D238", Length = "0x134")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SR), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		internal override void ValidateNode(XNode node, XNode previous)
		{
			throw null;
		}

		// Token: 0x0400000E RID: 14
		[global::Cpp2ILInjected.Token(Token = "0x4000013")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		internal XName name;

		// Token: 0x0400000F RID: 15
		[global::Cpp2ILInjected.Token(Token = "0x4000014")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		internal XAttribute lastAttr;

		// Token: 0x02000028 RID: 40
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200000C")]
		private sealed class <GetAttributes>d__116 : IEnumerable<XAttribute>, IEnumerable, IEnumerator<XAttribute>, IDisposable, IEnumerator
		{
			// Token: 0x060000CE RID: 206 RVA: 0x000022AE File Offset: 0x000004AE
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x600006B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D6D204", Offset = "0x1D6D204", Length = "0x34")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Environment), Member = "get_CurrentManagedThreadId", ReturnType = typeof(int))]
			public <GetAttributes>d__116(int <>1__state)
			{
				throw null;
			}

			// Token: 0x060000CF RID: 207 RVA: 0x000022B1 File Offset: 0x000004B1
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x600006C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D6D36C", Offset = "0x1D6D36C", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private void System.IDisposable.Dispose()
			{
				throw null;
			}

			// Token: 0x060000D0 RID: 208 RVA: 0x000022B4 File Offset: 0x000004B4
			[global::Cpp2ILInjected.Token(Token = "0x600006D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D6D370", Offset = "0x1D6D370", Length = "0x8C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private bool MoveNext()
			{
				throw null;
			}

			// Token: 0x17000028 RID: 40
			// (get) Token: 0x060000D1 RID: 209 RVA: 0x000022B7 File Offset: 0x000004B7
			[global::Cpp2ILInjected.Token(Token = "0x1700001A")]
			private XAttribute System.Collections.Generic.IEnumerator<System.Xml.Linq.XAttribute>.Current
			{
				[DebuggerHidden]
				[global::Cpp2ILInjected.Token(Token = "0x600006E")]
				[global::Cpp2ILInjected.Address(RVA = "0x1D6D3FC", Offset = "0x1D6D3FC", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x060000D2 RID: 210 RVA: 0x000022BA File Offset: 0x000004BA
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x600006F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D6D404", Offset = "0x1D6D404", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			private void System.Collections.IEnumerator.Reset()
			{
				throw null;
			}

			// Token: 0x17000029 RID: 41
			// (get) Token: 0x060000D3 RID: 211 RVA: 0x000022BD File Offset: 0x000004BD
			[global::Cpp2ILInjected.Token(Token = "0x1700001B")]
			private object System.Collections.IEnumerator.Current
			{
				[DebuggerHidden]
				[global::Cpp2ILInjected.Token(Token = "0x6000070")]
				[global::Cpp2ILInjected.Address(RVA = "0x1D6D43C", Offset = "0x1D6D43C", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x060000D4 RID: 212 RVA: 0x000022C0 File Offset: 0x000004C0
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x6000071")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D6D444", Offset = "0x1D6D444", Length = "0xA4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XElement.<GetAttributes>d__116), Member = "System.Collections.IEnumerable.GetEnumerator", ReturnType = typeof(IEnumerator))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Environment), Member = "get_CurrentManagedThreadId", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			private IEnumerator<XAttribute> System.Collections.Generic.IEnumerable<System.Xml.Linq.XAttribute>.GetEnumerator()
			{
				throw null;
			}

			// Token: 0x060000D5 RID: 213 RVA: 0x000022C3 File Offset: 0x000004C3
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x6000072")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D6D4E8", Offset = "0x1D6D4E8", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XElement.<GetAttributes>d__116), Member = "System.Collections.Generic.IEnumerable<System.Xml.Linq.XAttribute>.GetEnumerator", ReturnType = typeof(IEnumerator<XAttribute>))]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				throw null;
			}

			// Token: 0x04000050 RID: 80
			[global::Cpp2ILInjected.Token(Token = "0x4000015")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04000051 RID: 81
			[global::Cpp2ILInjected.Token(Token = "0x4000016")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private XAttribute <>2__current;

			// Token: 0x04000052 RID: 82
			[global::Cpp2ILInjected.Token(Token = "0x4000017")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			// Token: 0x04000053 RID: 83
			[global::Cpp2ILInjected.Token(Token = "0x4000018")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public XElement <>4__this;

			// Token: 0x04000054 RID: 84
			[global::Cpp2ILInjected.Token(Token = "0x4000019")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			private XName name;

			// Token: 0x04000055 RID: 85
			[global::Cpp2ILInjected.Token(Token = "0x400001A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			public XName <>3__name;

			// Token: 0x04000056 RID: 86
			[global::Cpp2ILInjected.Token(Token = "0x400001B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
			private XAttribute <a>5__2;
		}
	}
}
