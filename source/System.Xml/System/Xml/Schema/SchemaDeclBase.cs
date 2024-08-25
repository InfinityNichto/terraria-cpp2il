using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	[global::Cpp2ILInjected.Token(Token = "0x200012F")]
	internal abstract class SchemaDeclBase
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000A3C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DCA644", Offset = "0x1DCA644", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SchemaElementDecl), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(XmlQualifiedName),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected SchemaDeclBase(XmlQualifiedName name, string prefix)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000A3D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DCA6D0", Offset = "0x1DCA6D0", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SchemaAttDef), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SchemaElementDecl), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SchemaElementDecl), Member = ".ctor", MemberParameters = new object[] { typeof(XmlSchemaDatatype) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected SchemaDeclBase()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002CB")]
		internal XmlQualifiedName Name
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A3E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCAC20", Offset = "0x1DCAC20", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002CC")]
		internal string Prefix
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A3F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCA78C", Offset = "0x1DCA78C", Length = "0x54")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDocument), Member = "AddDefaultAttributes", MemberParameters = new object[] { typeof(XmlElement) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlLoader), Member = "LoadDocumentType", MemberParameters = new object[]
			{
				typeof(IDtdInfo),
				typeof(XmlDocumentType)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseAttlistDecl", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002CD")]
		internal bool IsDeclaredInExternal
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A40")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCAC28", Offset = "0x1DCAC28", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000A41")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCAC30", Offset = "0x1DCAC30", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002CE")]
		internal SchemaDeclBase.Use Presence
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A42")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCAC3C", Offset = "0x1DCAC3C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000A43")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCAC44", Offset = "0x1DCAC44", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002CF")]
		internal XmlSchemaType SchemaType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A44")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCAC4C", Offset = "0x1DCAC4C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002D0")]
		internal XmlSchemaDatatype Datatype
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A45")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCAC54", Offset = "0x1DCAC54", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000A46")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCAC5C", Offset = "0x1DCAC5C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000A47")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DCAC64", Offset = "0x1DCAC64", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseAttlistType", MemberParameters = new object[]
		{
			typeof(SchemaAttDef),
			typeof(SchemaElementDecl),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal void AddValue(string value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002D1")]
		internal List<string> Values
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A48")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCAD54", Offset = "0x1DCAD54", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002D2")]
		internal string DefaultValueRaw
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A49")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCAD5C", Offset = "0x1DCAD5C", Length = "0x54")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDocument), Member = "PrepareDefaultAttribute", MemberParameters = new object[]
			{
				typeof(SchemaAttDef),
				typeof(string),
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(XmlAttribute))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002D3")]
		internal object DefaultValueTyped
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A4A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCADB0", Offset = "0x1DCADB0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000A4B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DCADB8", Offset = "0x1DCADB8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000524")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		protected XmlQualifiedName name;

		[global::Cpp2ILInjected.Token(Token = "0x4000525")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		protected string prefix;

		[global::Cpp2ILInjected.Token(Token = "0x4000526")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		protected bool isDeclaredInExternal;

		[global::Cpp2ILInjected.Token(Token = "0x4000527")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		protected SchemaDeclBase.Use presence;

		[global::Cpp2ILInjected.Token(Token = "0x4000528")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		protected XmlSchemaType schemaType;

		[global::Cpp2ILInjected.Token(Token = "0x4000529")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		protected XmlSchemaDatatype datatype;

		[global::Cpp2ILInjected.Token(Token = "0x400052A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		protected string defaultValueRaw;

		[global::Cpp2ILInjected.Token(Token = "0x400052B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		protected object defaultValueTyped;

		[global::Cpp2ILInjected.Token(Token = "0x400052C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		protected long maxLength;

		[global::Cpp2ILInjected.Token(Token = "0x400052D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		protected long minLength;

		[global::Cpp2ILInjected.Token(Token = "0x400052E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		protected List<string> values;

		[global::Cpp2ILInjected.Token(Token = "0x2000130")]
		internal enum Use
		{
			[global::Cpp2ILInjected.Token(Token = "0x4000530")]
			Default,
			[global::Cpp2ILInjected.Token(Token = "0x4000531")]
			Required,
			[global::Cpp2ILInjected.Token(Token = "0x4000532")]
			Implied,
			[global::Cpp2ILInjected.Token(Token = "0x4000533")]
			Fixed,
			[global::Cpp2ILInjected.Token(Token = "0x4000534")]
			RequiredFixed
		}
	}
}
