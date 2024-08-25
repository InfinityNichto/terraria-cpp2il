using System;
using System.Collections.Generic;
using Cpp2ILInjected;

namespace System.Xml
{
	[global::Cpp2ILInjected.Token(Token = "0x2000017")]
	internal interface IDtdAttributeListInfo
	{
		[global::Cpp2ILInjected.Token(Token = "0x17000009")]
		bool HasNonCDataAttributes
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000074")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000075")]
		IDtdAttributeInfo LookupAttribute(string prefix, string localName);

		[global::Cpp2ILInjected.Token(Token = "0x6000076")]
		IEnumerable<IDtdDefaultAttributeInfo> LookupDefaultAttributes();
	}
}
