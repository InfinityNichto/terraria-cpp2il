using System;
using Cpp2ILInjected;

namespace System.Xml
{
	[global::Cpp2ILInjected.Token(Token = "0x200001A")]
	internal interface IDtdEntityInfo
	{
		[global::Cpp2ILInjected.Token(Token = "0x17000015")]
		string Name
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000082")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000016")]
		bool IsExternal
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000083")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000017")]
		bool IsDeclaredInExternal
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000084")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000018")]
		bool IsUnparsedEntity
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000085")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000019")]
		bool IsParameterEntity
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000086")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700001A")]
		string BaseUriString
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000087")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700001B")]
		string DeclaredUriString
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000088")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700001C")]
		string SystemId
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000089")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700001D")]
		string PublicId
		{
			[global::Cpp2ILInjected.Token(Token = "0x600008A")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700001E")]
		string Text
		{
			[global::Cpp2ILInjected.Token(Token = "0x600008B")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700001F")]
		int LineNumber
		{
			[global::Cpp2ILInjected.Token(Token = "0x600008C")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000020")]
		int LinePosition
		{
			[global::Cpp2ILInjected.Token(Token = "0x600008D")]
			get;
		}
	}
}
