using System;
using System.Collections.Generic;
using Cpp2ILInjected;

namespace System.Xml
{
	// Token: 0x02000017 RID: 23
	[global::Cpp2ILInjected.Token(Token = "0x2000017")]
	internal interface IDtdAttributeListInfo
	{
		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000074 RID: 116
		[global::Cpp2ILInjected.Token(Token = "0x17000009")]
		bool HasNonCDataAttributes
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000074")]
			get;
		}

		// Token: 0x06000075 RID: 117
		[global::Cpp2ILInjected.Token(Token = "0x6000075")]
		IDtdAttributeInfo LookupAttribute(string prefix, string localName);

		// Token: 0x06000076 RID: 118
		[global::Cpp2ILInjected.Token(Token = "0x6000076")]
		IEnumerable<IDtdDefaultAttributeInfo> LookupDefaultAttributes();
	}
}
