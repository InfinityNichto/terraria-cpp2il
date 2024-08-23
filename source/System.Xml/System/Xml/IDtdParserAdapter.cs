using System;
using System.Text;
using Cpp2ILInjected;

namespace System.Xml
{
	// Token: 0x0200001C RID: 28
	[global::Cpp2ILInjected.Token(Token = "0x200001C")]
	internal interface IDtdParserAdapter
	{
		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000090 RID: 144
		[global::Cpp2ILInjected.Token(Token = "0x17000021")]
		XmlNameTable NameTable
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000090")]
			get;
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000091 RID: 145
		[global::Cpp2ILInjected.Token(Token = "0x17000022")]
		IXmlNamespaceResolver NamespaceResolver
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000091")]
			get;
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000092 RID: 146
		[global::Cpp2ILInjected.Token(Token = "0x17000023")]
		Uri BaseUri
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000092")]
			get;
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000093 RID: 147
		[global::Cpp2ILInjected.Token(Token = "0x17000024")]
		char[] ParsingBuffer
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000093")]
			get;
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000094 RID: 148
		[global::Cpp2ILInjected.Token(Token = "0x17000025")]
		int ParsingBufferLength
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000094")]
			get;
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000095 RID: 149
		// (set) Token: 0x06000096 RID: 150
		[global::Cpp2ILInjected.Token(Token = "0x17000026")]
		int CurrentPosition
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000095")]
			get;
			[global::Cpp2ILInjected.Token(Token = "0x6000096")]
			set;
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000097 RID: 151
		[global::Cpp2ILInjected.Token(Token = "0x17000027")]
		int LineNo
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000097")]
			get;
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000098 RID: 152
		[global::Cpp2ILInjected.Token(Token = "0x17000028")]
		int LineStartPosition
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000098")]
			get;
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000099 RID: 153
		[global::Cpp2ILInjected.Token(Token = "0x17000029")]
		bool IsEof
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000099")]
			get;
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600009A RID: 154
		[global::Cpp2ILInjected.Token(Token = "0x1700002A")]
		int EntityStackLength
		{
			[global::Cpp2ILInjected.Token(Token = "0x600009A")]
			get;
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600009B RID: 155
		[global::Cpp2ILInjected.Token(Token = "0x1700002B")]
		bool IsEntityEolNormalized
		{
			[global::Cpp2ILInjected.Token(Token = "0x600009B")]
			get;
		}

		// Token: 0x0600009C RID: 156
		[global::Cpp2ILInjected.Token(Token = "0x600009C")]
		int ReadData();

		// Token: 0x0600009D RID: 157
		[global::Cpp2ILInjected.Token(Token = "0x600009D")]
		void OnNewLine(int pos);

		// Token: 0x0600009E RID: 158
		[global::Cpp2ILInjected.Token(Token = "0x600009E")]
		int ParseNumericCharRef(StringBuilder internalSubsetBuilder);

		// Token: 0x0600009F RID: 159
		[global::Cpp2ILInjected.Token(Token = "0x600009F")]
		int ParseNamedCharRef(bool expand, StringBuilder internalSubsetBuilder);

		// Token: 0x060000A0 RID: 160
		[global::Cpp2ILInjected.Token(Token = "0x60000A0")]
		void ParsePI(StringBuilder sb);

		// Token: 0x060000A1 RID: 161
		[global::Cpp2ILInjected.Token(Token = "0x60000A1")]
		void ParseComment(StringBuilder sb);

		// Token: 0x060000A2 RID: 162
		[global::Cpp2ILInjected.Token(Token = "0x60000A2")]
		bool PushEntity(IDtdEntityInfo entity, out int entityId);

		// Token: 0x060000A3 RID: 163
		[global::Cpp2ILInjected.Token(Token = "0x60000A3")]
		bool PopEntity(out IDtdEntityInfo oldEntity, out int newEntityId);

		// Token: 0x060000A4 RID: 164
		[global::Cpp2ILInjected.Token(Token = "0x60000A4")]
		bool PushExternalSubset(string systemId, string publicId);

		// Token: 0x060000A5 RID: 165
		[global::Cpp2ILInjected.Token(Token = "0x60000A5")]
		void PushInternalDtd(string baseUri, string internalDtd);

		// Token: 0x060000A6 RID: 166
		[global::Cpp2ILInjected.Token(Token = "0x60000A6")]
		void OnSystemId(string systemId, LineInfo keywordLineInfo, LineInfo systemLiteralLineInfo);

		// Token: 0x060000A7 RID: 167
		[global::Cpp2ILInjected.Token(Token = "0x60000A7")]
		void OnPublicId(string publicId, LineInfo keywordLineInfo, LineInfo publicLiteralLineInfo);

		// Token: 0x060000A8 RID: 168
		[global::Cpp2ILInjected.Token(Token = "0x60000A8")]
		void Throw(Exception e);
	}
}
