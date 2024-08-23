using System;
using System.Collections.Generic;
using System.Xml.Xsl.Runtime;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml
{
	// Token: 0x02000033 RID: 51
	[global::Cpp2ILInjected.Token(Token = "0x2000034")]
	internal sealed class XmlEventCache : XmlRawWriter
	{
		// Token: 0x0600019D RID: 413 RVA: 0x00003428 File Offset: 0x00001628
		[global::Cpp2ILInjected.Token(Token = "0x600019F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D63778", Offset = "0x1D63778", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWriter), Member = ".ctor", ReturnType = typeof(void))]
		public XmlEventCache(string baseUri, bool hasRootNode)
		{
			throw null;
		}

		// Token: 0x0600019E RID: 414 RVA: 0x0000342B File Offset: 0x0000162B
		[global::Cpp2ILInjected.Token(Token = "0x60001A0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D64148", Offset = "0x1D64148", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
		public void EndEvents()
		{
			throw null;
		}

		// Token: 0x0600019F RID: 415 RVA: 0x0000342E File Offset: 0x0000162E
		[global::Cpp2ILInjected.Token(Token = "0x60001A1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D64174", Offset = "0x1D64174", Length = "0x67C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAutoDetectWriter), Member = "CreateWrappedWriter", MemberParameters = new object[] { typeof(XmlOutputMethod) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringConcat), Member = "GetResult", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWriter), Member = "WriteAttributeString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		public void EventsToWriter(XmlWriter writer)
		{
			throw null;
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00003431 File Offset: 0x00001631
		[global::Cpp2ILInjected.Token(Token = "0x60001A2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D669F8", Offset = "0x1D669F8", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
		public override void WriteDocType(string name, string pubid, string sysid, string subset)
		{
			throw null;
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00003434 File Offset: 0x00001634
		[global::Cpp2ILInjected.Token(Token = "0x60001A3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D66AA0", Offset = "0x1D66AA0", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
		public override void WriteStartElement(string prefix, string localName, string ns)
		{
			throw null;
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x00003437 File Offset: 0x00001637
		[global::Cpp2ILInjected.Token(Token = "0x60001A4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D66B38", Offset = "0x1D66B38", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
		public override void WriteStartAttribute(string prefix, string localName, string ns)
		{
			throw null;
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x0000343A File Offset: 0x0000163A
		[global::Cpp2ILInjected.Token(Token = "0x60001A5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D66B84", Offset = "0x1D66B84", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
		public override void WriteEndAttribute()
		{
			throw null;
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x0000343D File Offset: 0x0000163D
		[global::Cpp2ILInjected.Token(Token = "0x60001A6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D66BAC", Offset = "0x1D66BAC", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
		public override void WriteCData(string text)
		{
			throw null;
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00003440 File Offset: 0x00001640
		[global::Cpp2ILInjected.Token(Token = "0x60001A7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D66C1C", Offset = "0x1D66C1C", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
		public override void WriteComment(string text)
		{
			throw null;
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00003443 File Offset: 0x00001643
		[global::Cpp2ILInjected.Token(Token = "0x60001A8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D66C54", Offset = "0x1D66C54", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
		public override void WriteProcessingInstruction(string name, string text)
		{
			throw null;
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00003446 File Offset: 0x00001646
		[global::Cpp2ILInjected.Token(Token = "0x60001A9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D66CD4", Offset = "0x1D66CD4", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
		public override void WriteWhitespace(string ws)
		{
			throw null;
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00003449 File Offset: 0x00001649
		[global::Cpp2ILInjected.Token(Token = "0x60001AA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D66D0C", Offset = "0x1D66D0C", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringConcat), Member = "ConcatNoDelimiter", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public override void WriteString(string text)
		{
			throw null;
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x0000344C File Offset: 0x0000164C
		[global::Cpp2ILInjected.Token(Token = "0x60001AB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D66D68", Offset = "0x1D66D68", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void WriteChars(char[] buffer, int index, int count)
		{
			throw null;
		}

		// Token: 0x060001AA RID: 426 RVA: 0x0000344F File Offset: 0x0000164F
		[global::Cpp2ILInjected.Token(Token = "0x60001AC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D66D98", Offset = "0x1D66D98", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void WriteRaw(char[] buffer, int index, int count)
		{
			throw null;
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00003452 File Offset: 0x00001652
		[global::Cpp2ILInjected.Token(Token = "0x60001AD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D66DC8", Offset = "0x1D66DC8", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
		public override void WriteRaw(string data)
		{
			throw null;
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00003455 File Offset: 0x00001655
		[global::Cpp2ILInjected.Token(Token = "0x60001AE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D66E00", Offset = "0x1D66E00", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
		public override void WriteEntityRef(string name)
		{
			throw null;
		}

		// Token: 0x060001AD RID: 429 RVA: 0x00003458 File Offset: 0x00001658
		[global::Cpp2ILInjected.Token(Token = "0x60001AF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D66E38", Offset = "0x1D66E38", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override void WriteCharEntity(char ch)
		{
			throw null;
		}

		// Token: 0x060001AE RID: 430 RVA: 0x0000345B File Offset: 0x0000165B
		[global::Cpp2ILInjected.Token(Token = "0x60001B0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D66EF0", Offset = "0x1D66EF0", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override void WriteSurrogateCharEntity(char lowChar, char highChar)
		{
			throw null;
		}

		// Token: 0x060001AF RID: 431 RVA: 0x0000345E File Offset: 0x0000165E
		[global::Cpp2ILInjected.Token(Token = "0x60001B1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D66F78", Offset = "0x1D66F78", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEventCache), Member = "ToBytes", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
		public override void WriteBase64(byte[] buffer, int index, int count)
		{
			throw null;
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x00003461 File Offset: 0x00001661
		[global::Cpp2ILInjected.Token(Token = "0x60001B2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D67064", Offset = "0x1D67064", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEventCache), Member = "ToBytes", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
		public override void WriteBinHex(byte[] buffer, int index, int count)
		{
			throw null;
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x00003464 File Offset: 0x00001664
		[global::Cpp2ILInjected.Token(Token = "0x60001B3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D670B0", Offset = "0x1D670B0", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x00003467 File Offset: 0x00001667
		[global::Cpp2ILInjected.Token(Token = "0x60001B4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D670D8", Offset = "0x1D670D8", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
		public override void Flush()
		{
			throw null;
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x0000346A File Offset: 0x0000166A
		[global::Cpp2ILInjected.Token(Token = "0x60001B5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D67100", Offset = "0x1D67100", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void WriteValue(string value)
		{
			throw null;
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x0000346D File Offset: 0x0000166D
		[global::Cpp2ILInjected.Token(Token = "0x60001B6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D67110", Offset = "0x1D67110", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWriter), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		protected override void Dispose(bool disposing)
		{
			throw null;
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x00003470 File Offset: 0x00001670
		[global::Cpp2ILInjected.Token(Token = "0x60001B7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D671D0", Offset = "0x1D671D0", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal override void WriteXmlDeclaration(XmlStandalone standalone)
		{
			throw null;
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00003473 File Offset: 0x00001673
		[global::Cpp2ILInjected.Token(Token = "0x60001B8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D67250", Offset = "0x1D67250", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
		internal override void WriteXmlDeclaration(string xmldecl)
		{
			throw null;
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x00003476 File Offset: 0x00001676
		[global::Cpp2ILInjected.Token(Token = "0x60001B9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D67288", Offset = "0x1D67288", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
		internal override void StartElementContent()
		{
			throw null;
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00003479 File Offset: 0x00001679
		[global::Cpp2ILInjected.Token(Token = "0x60001BA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D672B0", Offset = "0x1D672B0", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
		internal override void WriteEndElement(string prefix, string localName, string ns)
		{
			throw null;
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x0000347C File Offset: 0x0000167C
		[global::Cpp2ILInjected.Token(Token = "0x60001BB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D672FC", Offset = "0x1D672FC", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
		internal override void WriteFullEndElement(string prefix, string localName, string ns)
		{
			throw null;
		}

		// Token: 0x060001BA RID: 442 RVA: 0x0000347F File Offset: 0x0000167F
		[global::Cpp2ILInjected.Token(Token = "0x60001BC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D67348", Offset = "0x1D67348", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
		internal override void WriteNamespaceDeclaration(string prefix, string ns)
		{
			throw null;
		}

		// Token: 0x060001BB RID: 443 RVA: 0x00003482 File Offset: 0x00001682
		[global::Cpp2ILInjected.Token(Token = "0x60001BD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D67384", Offset = "0x1D67384", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
		internal override void WriteEndBase64()
		{
			throw null;
		}

		// Token: 0x060001BC RID: 444 RVA: 0x00003485 File Offset: 0x00001685
		[global::Cpp2ILInjected.Token(Token = "0x60001BE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D669C8", Offset = "0x1D669C8", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
		private void AddEvent(XmlEventCache.XmlEventType eventType)
		{
			throw null;
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00003488 File Offset: 0x00001688
		[global::Cpp2ILInjected.Token(Token = "0x60001BF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D66BE4", Offset = "0x1D66BE4", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
		private void AddEvent(XmlEventCache.XmlEventType eventType, string s1)
		{
			throw null;
		}

		// Token: 0x060001BE RID: 446 RVA: 0x0000348B File Offset: 0x0000168B
		[global::Cpp2ILInjected.Token(Token = "0x60001C0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D66C90", Offset = "0x1D66C90", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
		private void AddEvent(XmlEventCache.XmlEventType eventType, string s1, string s2)
		{
			throw null;
		}

		// Token: 0x060001BF RID: 447 RVA: 0x0000348E File Offset: 0x0000168E
		[global::Cpp2ILInjected.Token(Token = "0x60001C1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D66AEC", Offset = "0x1D66AEC", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
		private void AddEvent(XmlEventCache.XmlEventType eventType, string s1, string s2, string s3)
		{
			throw null;
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x00003491 File Offset: 0x00001691
		[global::Cpp2ILInjected.Token(Token = "0x60001C2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D66A48", Offset = "0x1D66A48", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
		private void AddEvent(XmlEventCache.XmlEventType eventType, string s1, string s2, string s3, object o)
		{
			throw null;
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00003494 File Offset: 0x00001694
		[global::Cpp2ILInjected.Token(Token = "0x60001C3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D66EB8", Offset = "0x1D66EB8", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
		private void AddEvent(XmlEventCache.XmlEventType eventType, object o)
		{
			throw null;
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00003497 File Offset: 0x00001697
		[global::Cpp2ILInjected.Token(Token = "0x60001C4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D673AC", Offset = "0x1D673AC", Length = "0x1D4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 33)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringConcat), Member = "GetResult", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringConcat), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private int NewEvent()
		{
			throw null;
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x0000349A File Offset: 0x0000169A
		[global::Cpp2ILInjected.Token(Token = "0x60001C5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D66FC4", Offset = "0x1D66FC4", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEventCache), Member = "WriteBase64", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEventCache), Member = "WriteBinHex", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static byte[] ToBytes(byte[] buffer, int index, int count)
		{
			throw null;
		}

		// Token: 0x040000AD RID: 173
		[global::Cpp2ILInjected.Token(Token = "0x40000AD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private List<XmlEventCache.XmlEvent[]> pages;

		// Token: 0x040000AE RID: 174
		[global::Cpp2ILInjected.Token(Token = "0x40000AE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private XmlEventCache.XmlEvent[] pageCurr;

		// Token: 0x040000AF RID: 175
		[global::Cpp2ILInjected.Token(Token = "0x40000AF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private int pageSize;

		// Token: 0x040000B0 RID: 176
		[global::Cpp2ILInjected.Token(Token = "0x40000B0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		private bool hasRootNode;

		// Token: 0x040000B1 RID: 177
		[global::Cpp2ILInjected.Token(Token = "0x40000B1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private StringConcat singleText;

		// Token: 0x040000B2 RID: 178
		[global::Cpp2ILInjected.Token(Token = "0x40000B2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private string baseUri;

		// Token: 0x0200014B RID: 331
		[global::Cpp2ILInjected.Token(Token = "0x2000035")]
		private enum XmlEventType
		{
			// Token: 0x04000500 RID: 1280
			[global::Cpp2ILInjected.Token(Token = "0x40000B4")]
			Unknown,
			// Token: 0x04000501 RID: 1281
			[global::Cpp2ILInjected.Token(Token = "0x40000B5")]
			DocType,
			// Token: 0x04000502 RID: 1282
			[global::Cpp2ILInjected.Token(Token = "0x40000B6")]
			StartElem,
			// Token: 0x04000503 RID: 1283
			[global::Cpp2ILInjected.Token(Token = "0x40000B7")]
			StartAttr,
			// Token: 0x04000504 RID: 1284
			[global::Cpp2ILInjected.Token(Token = "0x40000B8")]
			EndAttr,
			// Token: 0x04000505 RID: 1285
			[global::Cpp2ILInjected.Token(Token = "0x40000B9")]
			CData,
			// Token: 0x04000506 RID: 1286
			[global::Cpp2ILInjected.Token(Token = "0x40000BA")]
			Comment,
			// Token: 0x04000507 RID: 1287
			[global::Cpp2ILInjected.Token(Token = "0x40000BB")]
			PI,
			// Token: 0x04000508 RID: 1288
			[global::Cpp2ILInjected.Token(Token = "0x40000BC")]
			Whitespace,
			// Token: 0x04000509 RID: 1289
			[global::Cpp2ILInjected.Token(Token = "0x40000BD")]
			String,
			// Token: 0x0400050A RID: 1290
			[global::Cpp2ILInjected.Token(Token = "0x40000BE")]
			Raw,
			// Token: 0x0400050B RID: 1291
			[global::Cpp2ILInjected.Token(Token = "0x40000BF")]
			EntRef,
			// Token: 0x0400050C RID: 1292
			[global::Cpp2ILInjected.Token(Token = "0x40000C0")]
			CharEnt,
			// Token: 0x0400050D RID: 1293
			[global::Cpp2ILInjected.Token(Token = "0x40000C1")]
			SurrCharEnt,
			// Token: 0x0400050E RID: 1294
			[global::Cpp2ILInjected.Token(Token = "0x40000C2")]
			Base64,
			// Token: 0x0400050F RID: 1295
			[global::Cpp2ILInjected.Token(Token = "0x40000C3")]
			BinHex,
			// Token: 0x04000510 RID: 1296
			[global::Cpp2ILInjected.Token(Token = "0x40000C4")]
			XmlDecl1,
			// Token: 0x04000511 RID: 1297
			[global::Cpp2ILInjected.Token(Token = "0x40000C5")]
			XmlDecl2,
			// Token: 0x04000512 RID: 1298
			[global::Cpp2ILInjected.Token(Token = "0x40000C6")]
			StartContent,
			// Token: 0x04000513 RID: 1299
			[global::Cpp2ILInjected.Token(Token = "0x40000C7")]
			EndElem,
			// Token: 0x04000514 RID: 1300
			[global::Cpp2ILInjected.Token(Token = "0x40000C8")]
			FullEndElem,
			// Token: 0x04000515 RID: 1301
			[global::Cpp2ILInjected.Token(Token = "0x40000C9")]
			Nmsp,
			// Token: 0x04000516 RID: 1302
			[global::Cpp2ILInjected.Token(Token = "0x40000CA")]
			EndBase64,
			// Token: 0x04000517 RID: 1303
			[global::Cpp2ILInjected.Token(Token = "0x40000CB")]
			Close,
			// Token: 0x04000518 RID: 1304
			[global::Cpp2ILInjected.Token(Token = "0x40000CC")]
			Flush,
			// Token: 0x04000519 RID: 1305
			[global::Cpp2ILInjected.Token(Token = "0x40000CD")]
			Dispose
		}

		// Token: 0x0200014C RID: 332
		[global::Cpp2ILInjected.Token(Token = "0x2000036")]
		private struct XmlEvent
		{
			// Token: 0x06000C3C RID: 3132 RVA: 0x0000521C File Offset: 0x0000341C
			[global::Cpp2ILInjected.Token(Token = "0x60001C6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D675C4", Offset = "0x1D675C4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void InitEvent(XmlEventCache.XmlEventType eventType)
			{
				throw null;
			}

			// Token: 0x06000C3D RID: 3133 RVA: 0x0000521F File Offset: 0x0000341F
			[global::Cpp2ILInjected.Token(Token = "0x60001C7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D67580", Offset = "0x1D67580", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void InitEvent(XmlEventCache.XmlEventType eventType, string s1)
			{
				throw null;
			}

			// Token: 0x06000C3E RID: 3134 RVA: 0x00005222 File Offset: 0x00003422
			[global::Cpp2ILInjected.Token(Token = "0x60001C8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D6758C", Offset = "0x1D6758C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void InitEvent(XmlEventCache.XmlEventType eventType, string s1, string s2)
			{
				throw null;
			}

			// Token: 0x06000C3F RID: 3135 RVA: 0x00005225 File Offset: 0x00003425
			[global::Cpp2ILInjected.Token(Token = "0x60001C9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D67598", Offset = "0x1D67598", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void InitEvent(XmlEventCache.XmlEventType eventType, string s1, string s2, string s3)
			{
				throw null;
			}

			// Token: 0x06000C40 RID: 3136 RVA: 0x00005228 File Offset: 0x00003428
			[global::Cpp2ILInjected.Token(Token = "0x60001CA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D675A8", Offset = "0x1D675A8", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void InitEvent(XmlEventCache.XmlEventType eventType, string s1, string s2, string s3, object o)
			{
				throw null;
			}

			// Token: 0x06000C41 RID: 3137 RVA: 0x0000522B File Offset: 0x0000342B
			[global::Cpp2ILInjected.Token(Token = "0x60001CB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D675B8", Offset = "0x1D675B8", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void InitEvent(XmlEventCache.XmlEventType eventType, object o)
			{
				throw null;
			}

			// Token: 0x17000346 RID: 838
			// (get) Token: 0x06000C42 RID: 3138 RVA: 0x0000522E File Offset: 0x0000342E
			[global::Cpp2ILInjected.Token(Token = "0x1700003B")]
			public XmlEventCache.XmlEventType EventType
			{
				[global::Cpp2ILInjected.Token(Token = "0x60001CC")]
				[global::Cpp2ILInjected.Address(RVA = "0x1D675CC", Offset = "0x1D675CC", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000347 RID: 839
			// (get) Token: 0x06000C43 RID: 3139 RVA: 0x00005231 File Offset: 0x00003431
			[global::Cpp2ILInjected.Token(Token = "0x1700003C")]
			public string String1
			{
				[global::Cpp2ILInjected.Token(Token = "0x60001CD")]
				[global::Cpp2ILInjected.Address(RVA = "0x1D675D4", Offset = "0x1D675D4", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000348 RID: 840
			// (get) Token: 0x06000C44 RID: 3140 RVA: 0x00005234 File Offset: 0x00003434
			[global::Cpp2ILInjected.Token(Token = "0x1700003D")]
			public string String2
			{
				[global::Cpp2ILInjected.Token(Token = "0x60001CE")]
				[global::Cpp2ILInjected.Address(RVA = "0x1D675DC", Offset = "0x1D675DC", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000349 RID: 841
			// (get) Token: 0x06000C45 RID: 3141 RVA: 0x00005237 File Offset: 0x00003437
			[global::Cpp2ILInjected.Token(Token = "0x1700003E")]
			public string String3
			{
				[global::Cpp2ILInjected.Token(Token = "0x60001CF")]
				[global::Cpp2ILInjected.Address(RVA = "0x1D675E4", Offset = "0x1D675E4", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x1700034A RID: 842
			// (get) Token: 0x06000C46 RID: 3142 RVA: 0x0000523A File Offset: 0x0000343A
			[global::Cpp2ILInjected.Token(Token = "0x1700003F")]
			public object Object
			{
				[global::Cpp2ILInjected.Token(Token = "0x60001D0")]
				[global::Cpp2ILInjected.Address(RVA = "0x1D675EC", Offset = "0x1D675EC", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x0400051A RID: 1306
			[global::Cpp2ILInjected.Token(Token = "0x40000CE")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private XmlEventCache.XmlEventType eventType;

			// Token: 0x0400051B RID: 1307
			[global::Cpp2ILInjected.Token(Token = "0x40000CF")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			private string s1;

			// Token: 0x0400051C RID: 1308
			[global::Cpp2ILInjected.Token(Token = "0x40000D0")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private string s2;

			// Token: 0x0400051D RID: 1309
			[global::Cpp2ILInjected.Token(Token = "0x40000D1")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private string s3;

			// Token: 0x0400051E RID: 1310
			[global::Cpp2ILInjected.Token(Token = "0x40000D2")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private object o;
		}
	}
}
