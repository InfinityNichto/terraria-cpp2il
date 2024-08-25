using System;
using Cpp2ILInjected;

namespace System.Xml
{
	[global::Cpp2ILInjected.Token(Token = "0x2000018")]
	internal interface IDtdAttributeInfo
	{
		[global::Cpp2ILInjected.Token(Token = "0x1700000A")]
		string Prefix
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000077")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700000B")]
		string LocalName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000078")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700000C")]
		int LineNumber
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000079")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700000D")]
		int LinePosition
		{
			[global::Cpp2ILInjected.Token(Token = "0x600007A")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700000E")]
		bool IsNonCDataType
		{
			[global::Cpp2ILInjected.Token(Token = "0x600007B")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700000F")]
		bool IsDeclaredInExternal
		{
			[global::Cpp2ILInjected.Token(Token = "0x600007C")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000010")]
		bool IsXmlAttribute
		{
			[global::Cpp2ILInjected.Token(Token = "0x600007D")]
			get;
		}
	}
}
