using System;
using Cpp2ILInjected;

namespace System.Xml
{
	// Token: 0x0200001A RID: 26
	[global::Cpp2ILInjected.Token(Token = "0x200001A")]
	internal interface IDtdEntityInfo
	{
		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000082 RID: 130
		[global::Cpp2ILInjected.Token(Token = "0x17000015")]
		string Name
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000082")]
			get;
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000083 RID: 131
		[global::Cpp2ILInjected.Token(Token = "0x17000016")]
		bool IsExternal
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000083")]
			get;
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000084 RID: 132
		[global::Cpp2ILInjected.Token(Token = "0x17000017")]
		bool IsDeclaredInExternal
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000084")]
			get;
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000085 RID: 133
		[global::Cpp2ILInjected.Token(Token = "0x17000018")]
		bool IsUnparsedEntity
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000085")]
			get;
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000086 RID: 134
		[global::Cpp2ILInjected.Token(Token = "0x17000019")]
		bool IsParameterEntity
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000086")]
			get;
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000087 RID: 135
		[global::Cpp2ILInjected.Token(Token = "0x1700001A")]
		string BaseUriString
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000087")]
			get;
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000088 RID: 136
		[global::Cpp2ILInjected.Token(Token = "0x1700001B")]
		string DeclaredUriString
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000088")]
			get;
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000089 RID: 137
		[global::Cpp2ILInjected.Token(Token = "0x1700001C")]
		string SystemId
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000089")]
			get;
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600008A RID: 138
		[global::Cpp2ILInjected.Token(Token = "0x1700001D")]
		string PublicId
		{
			[global::Cpp2ILInjected.Token(Token = "0x600008A")]
			get;
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600008B RID: 139
		[global::Cpp2ILInjected.Token(Token = "0x1700001E")]
		string Text
		{
			[global::Cpp2ILInjected.Token(Token = "0x600008B")]
			get;
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600008C RID: 140
		[global::Cpp2ILInjected.Token(Token = "0x1700001F")]
		int LineNumber
		{
			[global::Cpp2ILInjected.Token(Token = "0x600008C")]
			get;
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600008D RID: 141
		[global::Cpp2ILInjected.Token(Token = "0x17000020")]
		int LinePosition
		{
			[global::Cpp2ILInjected.Token(Token = "0x600008D")]
			get;
		}
	}
}
