using System;
using System.Text;
using Cpp2ILInjected;

namespace System.Xml
{
	[global::Cpp2ILInjected.Token(Token = "0x200001C")]
	internal interface IDtdParserAdapter
	{
		[global::Cpp2ILInjected.Token(Token = "0x17000021")]
		XmlNameTable NameTable
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000090")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000022")]
		IXmlNamespaceResolver NamespaceResolver
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000091")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000023")]
		Uri BaseUri
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000092")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000024")]
		char[] ParsingBuffer
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000093")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000025")]
		int ParsingBufferLength
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000094")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000026")]
		int CurrentPosition
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000095")]
			get;
			[global::Cpp2ILInjected.Token(Token = "0x6000096")]
			set;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000027")]
		int LineNo
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000097")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000028")]
		int LineStartPosition
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000098")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000029")]
		bool IsEof
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000099")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700002A")]
		int EntityStackLength
		{
			[global::Cpp2ILInjected.Token(Token = "0x600009A")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700002B")]
		bool IsEntityEolNormalized
		{
			[global::Cpp2ILInjected.Token(Token = "0x600009B")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600009C")]
		int ReadData();

		[global::Cpp2ILInjected.Token(Token = "0x600009D")]
		void OnNewLine(int pos);

		[global::Cpp2ILInjected.Token(Token = "0x600009E")]
		int ParseNumericCharRef(StringBuilder internalSubsetBuilder);

		[global::Cpp2ILInjected.Token(Token = "0x600009F")]
		int ParseNamedCharRef(bool expand, StringBuilder internalSubsetBuilder);

		[global::Cpp2ILInjected.Token(Token = "0x60000A0")]
		void ParsePI(StringBuilder sb);

		[global::Cpp2ILInjected.Token(Token = "0x60000A1")]
		void ParseComment(StringBuilder sb);

		[global::Cpp2ILInjected.Token(Token = "0x60000A2")]
		bool PushEntity(IDtdEntityInfo entity, out int entityId);

		[global::Cpp2ILInjected.Token(Token = "0x60000A3")]
		bool PopEntity(out IDtdEntityInfo oldEntity, out int newEntityId);

		[global::Cpp2ILInjected.Token(Token = "0x60000A4")]
		bool PushExternalSubset(string systemId, string publicId);

		[global::Cpp2ILInjected.Token(Token = "0x60000A5")]
		void PushInternalDtd(string baseUri, string internalDtd);

		[global::Cpp2ILInjected.Token(Token = "0x60000A6")]
		void OnSystemId(string systemId, LineInfo keywordLineInfo, LineInfo systemLiteralLineInfo);

		[global::Cpp2ILInjected.Token(Token = "0x60000A7")]
		void OnPublicId(string publicId, LineInfo keywordLineInfo, LineInfo publicLiteralLineInfo);

		[global::Cpp2ILInjected.Token(Token = "0x60000A8")]
		void Throw(Exception e);
	}
}
