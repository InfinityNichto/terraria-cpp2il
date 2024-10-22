﻿using System;
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
	[XmlTypeConvertor("ConvertForAssignment")]
	[XmlSchemaProvider(null, IsAny = true)]
	[global::Cpp2ILInjected.Token(Token = "0x200000B")]
	public class XElement : XContainer
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x600005F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6CAAC", Offset = "0x1D6CAAC", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public XAttribute Attribute(XName name)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000060")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6CAD8", Offset = "0x1D6CAD8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Converters.XElementWrapper", Member = "get_Attributes", ReturnType = "System.Collections.Generic.List`1<IXmlNode>")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public IEnumerable<XAttribute> Attributes()
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x6000066")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6C948", Offset = "0x1D6C948", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal void AppendAttributeSkipNotify(XAttribute a)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000067")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6D1AC", Offset = "0x1D6D1AC", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XElement), Member = ".ctor", MemberParameters = new object[] { typeof(XElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal override XNode CloneNode()
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x4000013")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		internal XName name;

		[global::Cpp2ILInjected.Token(Token = "0x4000014")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		internal XAttribute lastAttr;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200000C")]
		private sealed class <GetAttributes>d__116 : IEnumerable<XAttribute>, IEnumerable, IEnumerator<XAttribute>, IDisposable, IEnumerator
		{
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

			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x600006C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D6D36C", Offset = "0x1D6D36C", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private void System.IDisposable.Dispose()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600006D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D6D370", Offset = "0x1D6D370", Length = "0x8C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private bool MoveNext()
			{
				throw null;
			}

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

			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x6000072")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D6D4E8", Offset = "0x1D6D4E8", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XElement.<GetAttributes>d__116), Member = "System.Collections.Generic.IEnumerable<System.Xml.Linq.XAttribute>.GetEnumerator", ReturnType = typeof(IEnumerator<XAttribute>))]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4000015")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[global::Cpp2ILInjected.Token(Token = "0x4000016")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private XAttribute <>2__current;

			[global::Cpp2ILInjected.Token(Token = "0x4000017")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[global::Cpp2ILInjected.Token(Token = "0x4000018")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public XElement <>4__this;

			[global::Cpp2ILInjected.Token(Token = "0x4000019")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			private XName name;

			[global::Cpp2ILInjected.Token(Token = "0x400001A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			public XName <>3__name;

			[global::Cpp2ILInjected.Token(Token = "0x400001B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
			private XAttribute <a>5__2;
		}
	}
}
