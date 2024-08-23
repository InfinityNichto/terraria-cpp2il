using System;
using System.Collections.Generic;
using System.Xml;
using Cpp2ILInjected;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000CB RID: 203
	[global::Cpp2ILInjected.Token(Token = "0x2000112")]
	internal interface IXmlNode
	{
		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x0600097A RID: 2426
		[global::Cpp2ILInjected.Token(Token = "0x170001F5")]
		XmlNodeType NodeType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000AB6")]
			get;
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x0600097B RID: 2427
		[global::Cpp2ILInjected.Token(Token = "0x170001F6")]
		string LocalName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000AB7")]
			get;
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x0600097C RID: 2428
		[global::Cpp2ILInjected.Token(Token = "0x170001F7")]
		List<IXmlNode> ChildNodes
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000AB8")]
			get;
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x0600097D RID: 2429
		[global::Cpp2ILInjected.Token(Token = "0x170001F8")]
		List<IXmlNode> Attributes
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000AB9")]
			get;
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x0600097E RID: 2430
		[global::Cpp2ILInjected.Token(Token = "0x170001F9")]
		IXmlNode ParentNode
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000ABA")]
			get;
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x0600097F RID: 2431
		// (set) Token: 0x06000980 RID: 2432
		[global::Cpp2ILInjected.Token(Token = "0x170001FA")]
		string Value
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000ABB")]
			get;
			[global::Cpp2ILInjected.Token(Token = "0x6000ABC")]
			set;
		}

		// Token: 0x06000981 RID: 2433
		[global::Cpp2ILInjected.Token(Token = "0x6000ABD")]
		IXmlNode AppendChild(IXmlNode newChild);

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x06000982 RID: 2434
		[global::Cpp2ILInjected.Token(Token = "0x170001FB")]
		string NamespaceUri
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000ABE")]
			get;
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x06000983 RID: 2435
		[global::Cpp2ILInjected.Token(Token = "0x170001FC")]
		object WrappedNode
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000ABF")]
			get;
		}
	}
}
