using System;
using Cpp2ILInjected;

namespace System.Xml
{
	[global::Cpp2ILInjected.Token(Token = "0x2000019")]
	internal interface IDtdDefaultAttributeInfo : IDtdAttributeInfo
	{
		[global::Cpp2ILInjected.Token(Token = "0x17000011")]
		string DefaultValueExpanded
		{
			[global::Cpp2ILInjected.Token(Token = "0x600007E")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000012")]
		object DefaultValueTyped
		{
			[global::Cpp2ILInjected.Token(Token = "0x600007F")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000013")]
		int ValueLineNumber
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000080")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000014")]
		int ValueLinePosition
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000081")]
			get;
		}
	}
}
