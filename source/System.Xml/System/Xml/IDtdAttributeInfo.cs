using System;
using Cpp2ILInjected;

namespace System.Xml
{
	// Token: 0x02000018 RID: 24
	[global::Cpp2ILInjected.Token(Token = "0x2000018")]
	internal interface IDtdAttributeInfo
	{
		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000077 RID: 119
		[global::Cpp2ILInjected.Token(Token = "0x1700000A")]
		string Prefix
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000077")]
			get;
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000078 RID: 120
		[global::Cpp2ILInjected.Token(Token = "0x1700000B")]
		string LocalName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000078")]
			get;
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000079 RID: 121
		[global::Cpp2ILInjected.Token(Token = "0x1700000C")]
		int LineNumber
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000079")]
			get;
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600007A RID: 122
		[global::Cpp2ILInjected.Token(Token = "0x1700000D")]
		int LinePosition
		{
			[global::Cpp2ILInjected.Token(Token = "0x600007A")]
			get;
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600007B RID: 123
		[global::Cpp2ILInjected.Token(Token = "0x1700000E")]
		bool IsNonCDataType
		{
			[global::Cpp2ILInjected.Token(Token = "0x600007B")]
			get;
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600007C RID: 124
		[global::Cpp2ILInjected.Token(Token = "0x1700000F")]
		bool IsDeclaredInExternal
		{
			[global::Cpp2ILInjected.Token(Token = "0x600007C")]
			get;
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600007D RID: 125
		[global::Cpp2ILInjected.Token(Token = "0x17000010")]
		bool IsXmlAttribute
		{
			[global::Cpp2ILInjected.Token(Token = "0x600007D")]
			get;
		}
	}
}
