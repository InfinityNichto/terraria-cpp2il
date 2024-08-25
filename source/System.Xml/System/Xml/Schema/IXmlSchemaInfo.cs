using System;
using Cpp2ILInjected;

namespace System.Xml.Schema
{
	[global::Cpp2ILInjected.Token(Token = "0x200012A")]
	public interface IXmlSchemaInfo
	{
		[global::Cpp2ILInjected.Token(Token = "0x170002AF")]
		XmlSchemaValidity Validity
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A10")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002B0")]
		bool IsDefault
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A11")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002B1")]
		bool IsNil
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A12")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002B2")]
		XmlSchemaSimpleType MemberType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A13")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002B3")]
		XmlSchemaType SchemaType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A14")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002B4")]
		XmlSchemaElement SchemaElement
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A15")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002B5")]
		XmlSchemaAttribute SchemaAttribute
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A16")]
			get;
		}
	}
}
