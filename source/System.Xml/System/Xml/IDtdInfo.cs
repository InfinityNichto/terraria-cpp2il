using System;
using Cpp2ILInjected;

namespace System.Xml
{
	// Token: 0x02000016 RID: 22
	[global::Cpp2ILInjected.Token(Token = "0x2000016")]
	internal interface IDtdInfo
	{
		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600006E RID: 110
		[global::Cpp2ILInjected.Token(Token = "0x17000005")]
		XmlQualifiedName Name
		{
			[global::Cpp2ILInjected.Token(Token = "0x600006E")]
			get;
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600006F RID: 111
		[global::Cpp2ILInjected.Token(Token = "0x17000006")]
		string InternalDtdSubset
		{
			[global::Cpp2ILInjected.Token(Token = "0x600006F")]
			get;
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000070 RID: 112
		[global::Cpp2ILInjected.Token(Token = "0x17000007")]
		bool HasDefaultAttributes
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000070")]
			get;
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000071 RID: 113
		[global::Cpp2ILInjected.Token(Token = "0x17000008")]
		bool HasNonCDataAttributes
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000071")]
			get;
		}

		// Token: 0x06000072 RID: 114
		[global::Cpp2ILInjected.Token(Token = "0x6000072")]
		IDtdAttributeListInfo LookupAttributeList(string prefix, string localName);

		// Token: 0x06000073 RID: 115
		[global::Cpp2ILInjected.Token(Token = "0x6000073")]
		IDtdEntityInfo LookupEntity(string name);
	}
}
