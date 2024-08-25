using System;
using Cpp2ILInjected;

namespace System.Xml
{
	[global::Cpp2ILInjected.Token(Token = "0x2000016")]
	internal interface IDtdInfo
	{
		[global::Cpp2ILInjected.Token(Token = "0x17000005")]
		XmlQualifiedName Name
		{
			[global::Cpp2ILInjected.Token(Token = "0x600006E")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000006")]
		string InternalDtdSubset
		{
			[global::Cpp2ILInjected.Token(Token = "0x600006F")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000007")]
		bool HasDefaultAttributes
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000070")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000008")]
		bool HasNonCDataAttributes
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000071")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000072")]
		IDtdAttributeListInfo LookupAttributeList(string prefix, string localName);

		[global::Cpp2ILInjected.Token(Token = "0x6000073")]
		IDtdEntityInfo LookupEntity(string name);
	}
}
