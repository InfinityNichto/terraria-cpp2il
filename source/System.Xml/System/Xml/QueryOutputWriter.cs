using System;
using System.Collections.Generic;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml
{
	// Token: 0x02000025 RID: 37
	[global::Cpp2ILInjected.Token(Token = "0x2000025")]
	internal class QueryOutputWriter : XmlRawWriter
	{
		// Token: 0x060000B7 RID: 183 RVA: 0x00003176 File Offset: 0x00001376
		[global::Cpp2ILInjected.Token(Token = "0x60000B7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D620A4", Offset = "0x1D620A4", Length = "0x2B0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWriterSettings), Member = "CreateWriter", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(XmlWriter))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWriterSettings), Member = "CreateWriter", MemberParameters = new object[] { typeof(TextWriter) }, ReturnType = typeof(XmlWriter))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWriter), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, int>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlQualifiedName), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, int>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(object),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitStack), Member = "PushCurr", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		public QueryOutputWriter(XmlRawWriter writer, XmlWriterSettings settings)
		{
			throw null;
		}

		// Token: 0x17000033 RID: 51
		// (set) Token: 0x060000B8 RID: 184 RVA: 0x00003179 File Offset: 0x00001379
		[global::Cpp2ILInjected.Token(Token = "0x17000033")]
		internal override IXmlNamespaceResolver NamespaceResolver
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000B8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D6235C", Offset = "0x1D6235C", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x0000317C File Offset: 0x0000137C
		[global::Cpp2ILInjected.Token(Token = "0x60000B9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D62378", Offset = "0x1D62378", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal override void WriteXmlDeclaration(XmlStandalone standalone)
		{
			throw null;
		}

		// Token: 0x060000BA RID: 186 RVA: 0x0000317F File Offset: 0x0000137F
		[global::Cpp2ILInjected.Token(Token = "0x60000BA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6238C", Offset = "0x1D6238C", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal override void WriteXmlDeclaration(string xmldecl)
		{
			throw null;
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00003182 File Offset: 0x00001382
		[global::Cpp2ILInjected.Token(Token = "0x60000BB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D623A0", Offset = "0x1D623A0", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void WriteDocType(string name, string pubid, string sysid, string subset)
		{
			throw null;
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00003185 File Offset: 0x00001385
		[global::Cpp2ILInjected.Token(Token = "0x60000BC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D623C4", Offset = "0x1D623C4", Length = "0x1A8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlQualifiedName), Member = "Init", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, int>), Member = "ContainsKey", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitStack), Member = "PushCurr", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public override void WriteStartElement(string prefix, string localName, string ns)
		{
			throw null;
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00003188 File Offset: 0x00001388
		[global::Cpp2ILInjected.Token(Token = "0x60000BD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D62574", Offset = "0x1D62574", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal override void WriteEndElement(string prefix, string localName, string ns)
		{
			throw null;
		}

		// Token: 0x060000BE RID: 190 RVA: 0x0000318B File Offset: 0x0000138B
		[global::Cpp2ILInjected.Token(Token = "0x60000BE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D625F0", Offset = "0x1D625F0", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal override void WriteFullEndElement(string prefix, string localName, string ns)
		{
			throw null;
		}

		// Token: 0x060000BF RID: 191 RVA: 0x0000318E File Offset: 0x0000138E
		[global::Cpp2ILInjected.Token(Token = "0x60000BF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6266C", Offset = "0x1D6266C", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal override void StartElementContent()
		{
			throw null;
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00003191 File Offset: 0x00001391
		[global::Cpp2ILInjected.Token(Token = "0x60000C0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D62680", Offset = "0x1D62680", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void WriteStartAttribute(string prefix, string localName, string ns)
		{
			throw null;
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00003194 File Offset: 0x00001394
		[global::Cpp2ILInjected.Token(Token = "0x60000C1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6269C", Offset = "0x1D6269C", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void WriteEndAttribute()
		{
			throw null;
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00003197 File Offset: 0x00001397
		[global::Cpp2ILInjected.Token(Token = "0x60000C2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D626B8", Offset = "0x1D626B8", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal override void WriteNamespaceDeclaration(string prefix, string ns)
		{
			throw null;
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x0000319A File Offset: 0x0000139A
		[global::Cpp2ILInjected.Token(Token = "0x17000034")]
		internal override bool SupportsNamespaceDeclarationInChunks
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000C3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D626CC", Offset = "0x1D626CC", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x0000319D File Offset: 0x0000139D
		[global::Cpp2ILInjected.Token(Token = "0x60000C4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D626E0", Offset = "0x1D626E0", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal override void WriteStartNamespaceDeclaration(string prefix)
		{
			throw null;
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x000031A0 File Offset: 0x000013A0
		[global::Cpp2ILInjected.Token(Token = "0x60000C5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D626F4", Offset = "0x1D626F4", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal override void WriteEndNamespaceDeclaration()
		{
			throw null;
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x000031A3 File Offset: 0x000013A3
		[global::Cpp2ILInjected.Token(Token = "0x60000C6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D62708", Offset = "0x1D62708", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void WriteCData(string text)
		{
			throw null;
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x000031A6 File Offset: 0x000013A6
		[global::Cpp2ILInjected.Token(Token = "0x60000C7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6271C", Offset = "0x1D6271C", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void WriteComment(string text)
		{
			throw null;
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x000031A9 File Offset: 0x000013A9
		[global::Cpp2ILInjected.Token(Token = "0x60000C8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D62738", Offset = "0x1D62738", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void WriteProcessingInstruction(string name, string text)
		{
			throw null;
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x000031AC File Offset: 0x000013AC
		[global::Cpp2ILInjected.Token(Token = "0x60000C9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D62754", Offset = "0x1D62754", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override void WriteWhitespace(string ws)
		{
			throw null;
		}

		// Token: 0x060000CA RID: 202 RVA: 0x000031AF File Offset: 0x000013AF
		[global::Cpp2ILInjected.Token(Token = "0x60000CA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D627D8", Offset = "0x1D627D8", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override void WriteString(string text)
		{
			throw null;
		}

		// Token: 0x060000CB RID: 203 RVA: 0x000031B2 File Offset: 0x000013B2
		[global::Cpp2ILInjected.Token(Token = "0x60000CB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D62830", Offset = "0x1D62830", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override void WriteChars(char[] buffer, int index, int count)
		{
			throw null;
		}

		// Token: 0x060000CC RID: 204 RVA: 0x000031B5 File Offset: 0x000013B5
		[global::Cpp2ILInjected.Token(Token = "0x60000CC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D628A8", Offset = "0x1D628A8", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void WriteEntityRef(string name)
		{
			throw null;
		}

		// Token: 0x060000CD RID: 205 RVA: 0x000031B8 File Offset: 0x000013B8
		[global::Cpp2ILInjected.Token(Token = "0x60000CD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D628C4", Offset = "0x1D628C4", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void WriteCharEntity(char ch)
		{
			throw null;
		}

		// Token: 0x060000CE RID: 206 RVA: 0x000031BB File Offset: 0x000013BB
		[global::Cpp2ILInjected.Token(Token = "0x60000CE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D628E0", Offset = "0x1D628E0", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void WriteSurrogateCharEntity(char lowChar, char highChar)
		{
			throw null;
		}

		// Token: 0x060000CF RID: 207 RVA: 0x000031BE File Offset: 0x000013BE
		[global::Cpp2ILInjected.Token(Token = "0x60000CF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D628FC", Offset = "0x1D628FC", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override void WriteRaw(char[] buffer, int index, int count)
		{
			throw null;
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x000031C1 File Offset: 0x000013C1
		[global::Cpp2ILInjected.Token(Token = "0x60000D0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D62974", Offset = "0x1D62974", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override void WriteRaw(string data)
		{
			throw null;
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x000031C4 File Offset: 0x000013C4
		[global::Cpp2ILInjected.Token(Token = "0x60000D1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D629CC", Offset = "0x1D629CC", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x000031C7 File Offset: 0x000013C7
		[global::Cpp2ILInjected.Token(Token = "0x60000D2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D62A68", Offset = "0x1D62A68", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void Flush()
		{
			throw null;
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x000031CA File Offset: 0x000013CA
		[global::Cpp2ILInjected.Token(Token = "0x60000D3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D627AC", Offset = "0x1D627AC", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private bool StartCDataSection()
		{
			throw null;
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x000031CD File Offset: 0x000013CD
		[global::Cpp2ILInjected.Token(Token = "0x60000D4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6256C", Offset = "0x1D6256C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void EndCDataSection()
		{
			throw null;
		}

		// Token: 0x04000051 RID: 81
		[global::Cpp2ILInjected.Token(Token = "0x4000051")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private XmlRawWriter wrapped;

		// Token: 0x04000052 RID: 82
		[global::Cpp2ILInjected.Token(Token = "0x4000052")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private bool inCDataSection;

		// Token: 0x04000053 RID: 83
		[global::Cpp2ILInjected.Token(Token = "0x4000053")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private Dictionary<XmlQualifiedName, int> lookupCDataElems;

		// Token: 0x04000054 RID: 84
		[global::Cpp2ILInjected.Token(Token = "0x4000054")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private BitStack bitsCData;

		// Token: 0x04000055 RID: 85
		[global::Cpp2ILInjected.Token(Token = "0x4000055")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private XmlQualifiedName qnameCData;

		// Token: 0x04000056 RID: 86
		[global::Cpp2ILInjected.Token(Token = "0x4000056")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private bool outputDocType;

		// Token: 0x04000057 RID: 87
		[global::Cpp2ILInjected.Token(Token = "0x4000057")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x49")]
		private bool checkWellFormedDoc;

		// Token: 0x04000058 RID: 88
		[global::Cpp2ILInjected.Token(Token = "0x4000058")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4A")]
		private bool hasDocElem;

		// Token: 0x04000059 RID: 89
		[global::Cpp2ILInjected.Token(Token = "0x4000059")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4B")]
		private bool inAttr;

		// Token: 0x0400005A RID: 90
		[global::Cpp2ILInjected.Token(Token = "0x400005A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private string systemId;

		// Token: 0x0400005B RID: 91
		[global::Cpp2ILInjected.Token(Token = "0x400005B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private string publicId;

		// Token: 0x0400005C RID: 92
		[global::Cpp2ILInjected.Token(Token = "0x400005C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private int depth;
	}
}
