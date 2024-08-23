using System;
using Cpp2ILInjected;

namespace System.Xml.Schema
{
	// Token: 0x020000FD RID: 253
	[global::Cpp2ILInjected.Token(Token = "0x200012A")]
	public interface IXmlSchemaInfo
	{
		// Token: 0x17000289 RID: 649
		// (get) Token: 0x06000979 RID: 2425
		[global::Cpp2ILInjected.Token(Token = "0x170002AF")]
		XmlSchemaValidity Validity
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A10")]
			get;
		}

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x0600097A RID: 2426
		[global::Cpp2ILInjected.Token(Token = "0x170002B0")]
		bool IsDefault
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A11")]
			get;
		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x0600097B RID: 2427
		[global::Cpp2ILInjected.Token(Token = "0x170002B1")]
		bool IsNil
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A12")]
			get;
		}

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x0600097C RID: 2428
		[global::Cpp2ILInjected.Token(Token = "0x170002B2")]
		XmlSchemaSimpleType MemberType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A13")]
			get;
		}

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x0600097D RID: 2429
		[global::Cpp2ILInjected.Token(Token = "0x170002B3")]
		XmlSchemaType SchemaType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A14")]
			get;
		}

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x0600097E RID: 2430
		[global::Cpp2ILInjected.Token(Token = "0x170002B4")]
		XmlSchemaElement SchemaElement
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A15")]
			get;
		}

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x0600097F RID: 2431
		[global::Cpp2ILInjected.Token(Token = "0x170002B5")]
		XmlSchemaAttribute SchemaAttribute
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A16")]
			get;
		}
	}
}
