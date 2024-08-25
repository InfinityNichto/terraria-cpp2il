using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using MS.Internal.Xml.Cache;

namespace System.Xml.XPath
{
	[DebuggerDisplay("{debuggerDisplayProxy}")]
	[global::Cpp2ILInjected.Token(Token = "0x20000B7")]
	public abstract class XPathNavigator : XPathItem, ICloneable, IXmlNamespaceResolver
	{
		[global::Cpp2ILInjected.Token(Token = "0x60007D3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB1A38", Offset = "0x1DB1A38", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override string ToString()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170001DD")]
		public override XmlSchemaType XmlType
		{
			[global::Cpp2ILInjected.Token(Token = "0x60007D4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DB1A44", Offset = "0x1DB1A44", Length = "0x188")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170001DE")]
		public override object TypedValue
		{
			[global::Cpp2ILInjected.Token(Token = "0x60007D5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DB1BCC", Offset = "0x1DB1BCC", Length = "0x2CC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlSchemaType), Member = "get_ValueConverter", ReturnType = typeof(XmlValueConverter))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170001DF")]
		public override Type ValueType
		{
			[global::Cpp2ILInjected.Token(Token = "0x60007D6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DB1E98", Offset = "0x1DB1E98", Length = "0x20C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170001E0")]
		public override bool ValueAsBoolean
		{
			[global::Cpp2ILInjected.Token(Token = "0x60007D7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DB20A4", Offset = "0x1DB20A4", Length = "0x2BC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlSchemaType), Member = "get_ValueConverter", ReturnType = typeof(XmlValueConverter))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170001E1")]
		public override DateTime ValueAsDateTime
		{
			[global::Cpp2ILInjected.Token(Token = "0x60007D8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DB2360", Offset = "0x1DB2360", Length = "0x2C4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlSchemaType), Member = "get_ValueConverter", ReturnType = typeof(XmlValueConverter))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170001E2")]
		public override double ValueAsDouble
		{
			[global::Cpp2ILInjected.Token(Token = "0x60007D9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DB2624", Offset = "0x1DB2624", Length = "0x2C4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlSchemaType), Member = "get_ValueConverter", ReturnType = typeof(XmlValueConverter))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170001E3")]
		public override int ValueAsInt
		{
			[global::Cpp2ILInjected.Token(Token = "0x60007DA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DB28E8", Offset = "0x1DB28E8", Length = "0x2C4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlSchemaType), Member = "get_ValueConverter", ReturnType = typeof(XmlValueConverter))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170001E4")]
		public override long ValueAsLong
		{
			[global::Cpp2ILInjected.Token(Token = "0x60007DB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DB2BAC", Offset = "0x1DB2BAC", Length = "0x2C4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlSchemaType), Member = "get_ValueConverter", ReturnType = typeof(XmlValueConverter))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60007DC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB2E70", Offset = "0x1DB2E70", Length = "0x2E4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlSchemaType), Member = "get_ValueConverter", ReturnType = typeof(XmlValueConverter))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public override object ValueAs(Type returnType, IXmlNamespaceResolver nsResolver)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60007DD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB3154", Offset = "0x1DB3154", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private object System.ICloneable.Clone()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170001E5")]
		public abstract XmlNameTable NameTable
		{
			[global::Cpp2ILInjected.Token(Token = "0x60007DE")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60007DF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB3164", Offset = "0x1DB3164", Length = "0x19C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public virtual string LookupNamespace(string prefix)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60007E0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB3300", Offset = "0x1DB3300", Length = "0x1E8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public virtual string LookupPrefix(string namespaceURI)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60007E1")]
		public abstract XPathNavigator Clone();

		[global::Cpp2ILInjected.Token(Token = "0x170001E6")]
		public abstract XPathNodeType NodeType
		{
			[global::Cpp2ILInjected.Token(Token = "0x60007E2")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170001E7")]
		public abstract string LocalName
		{
			[global::Cpp2ILInjected.Token(Token = "0x60007E3")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170001E8")]
		public abstract string NamespaceURI
		{
			[global::Cpp2ILInjected.Token(Token = "0x60007E4")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170001E9")]
		public abstract string Prefix
		{
			[global::Cpp2ILInjected.Token(Token = "0x60007E5")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170001EA")]
		public virtual object UnderlyingObject
		{
			[global::Cpp2ILInjected.Token(Token = "0x60007E6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DB34E8", Offset = "0x1DB34E8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60007E7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB34F0", Offset = "0x1DB34F0", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		public virtual bool MoveToNamespace(string name)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60007E8")]
		public abstract bool MoveToFirstNamespace(XPathNamespaceScope namespaceScope);

		[global::Cpp2ILInjected.Token(Token = "0x60007E9")]
		public abstract bool MoveToNextNamespace(XPathNamespaceScope namespaceScope);

		[global::Cpp2ILInjected.Token(Token = "0x60007EA")]
		public abstract bool MoveToParent();

		[global::Cpp2ILInjected.Token(Token = "0x60007EB")]
		public abstract bool IsSamePosition(XPathNavigator other);

		[global::Cpp2ILInjected.Token(Token = "0x170001EB")]
		public virtual IXmlSchemaInfo SchemaInfo
		{
			[global::Cpp2ILInjected.Token(Token = "0x60007EC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DB3590", Offset = "0x1DB3590", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60007ED")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB35D8", Offset = "0x1DB35D8", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XPathNode), Member = "get_IsText", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		internal static bool IsText(XPathNodeType type)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60007EE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB35E8", Offset = "0x1DB35E8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XPathDocumentNavigator), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(XPathNode[]),
			typeof(int),
			typeof(XPathNode[]),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected XPathNavigator()
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60007EF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB35F0", Offset = "0x1DB35F0", Length = "0x164")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		static XPathNavigator()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40003F8")]
		internal static readonly XPathNavigatorKeyComparer comparer;

		[global::Cpp2ILInjected.Token(Token = "0x40003F9")]
		internal static readonly char[] NodeTypeLetter;

		[global::Cpp2ILInjected.Token(Token = "0x40003FA")]
		internal static readonly char[] UniqueIdTbl;

		[global::Cpp2ILInjected.Token(Token = "0x40003FB")]
		internal static readonly int[] ContentKindMasks;
	}
}
