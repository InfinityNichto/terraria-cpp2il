using System;
using System.Collections.Generic;
using System.Xml.Xsl.Runtime;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml
{
	[global::Cpp2ILInjected.Token(Token = "0x2000034")]
	internal sealed class XmlEventCache : XmlRawWriter
	{
		[global::Cpp2ILInjected.Token(Token = "0x600019F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D63778", Offset = "0x1D63778", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWriter), Member = ".ctor", ReturnType = typeof(void))]
		public XmlEventCache(string baseUri, bool hasRootNode)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60001A0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D64148", Offset = "0x1D64148", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
		public void EndEvents()
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x60001A2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D669F8", Offset = "0x1D669F8", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
		public override void WriteDocType(string name, string pubid, string sysid, string subset)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60001A3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D66AA0", Offset = "0x1D66AA0", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
		public override void WriteStartElement(string prefix, string localName, string ns)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60001A4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D66B38", Offset = "0x1D66B38", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
		public override void WriteStartAttribute(string prefix, string localName, string ns)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60001A5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D66B84", Offset = "0x1D66B84", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
		public override void WriteEndAttribute()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60001A6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D66BAC", Offset = "0x1D66BAC", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
		public override void WriteCData(string text)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60001A7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D66C1C", Offset = "0x1D66C1C", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
		public override void WriteComment(string text)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60001A8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D66C54", Offset = "0x1D66C54", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
		public override void WriteProcessingInstruction(string name, string text)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60001A9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D66CD4", Offset = "0x1D66CD4", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
		public override void WriteWhitespace(string ws)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x60001AD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D66DC8", Offset = "0x1D66DC8", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
		public override void WriteRaw(string data)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60001AE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D66E00", Offset = "0x1D66E00", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
		public override void WriteEntityRef(string name)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x60001B3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D670B0", Offset = "0x1D670B0", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
		public override void Close()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60001B4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D670D8", Offset = "0x1D670D8", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
		public override void Flush()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60001B5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D67100", Offset = "0x1D67100", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void WriteValue(string value)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x60001B8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D67250", Offset = "0x1D67250", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
		internal override void WriteXmlDeclaration(string xmldecl)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60001B9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D67288", Offset = "0x1D67288", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
		internal override void StartElementContent()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60001BA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D672B0", Offset = "0x1D672B0", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
		internal override void WriteEndElement(string prefix, string localName, string ns)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60001BB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D672FC", Offset = "0x1D672FC", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
		internal override void WriteFullEndElement(string prefix, string localName, string ns)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60001BC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D67348", Offset = "0x1D67348", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
		internal override void WriteNamespaceDeclaration(string prefix, string ns)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60001BD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D67384", Offset = "0x1D67384", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
		internal override void WriteEndBase64()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60001BE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D669C8", Offset = "0x1D669C8", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
		private void AddEvent(XmlEventCache.XmlEventType eventType)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60001BF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D66BE4", Offset = "0x1D66BE4", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
		private void AddEvent(XmlEventCache.XmlEventType eventType, string s1)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60001C0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D66C90", Offset = "0x1D66C90", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
		private void AddEvent(XmlEventCache.XmlEventType eventType, string s1, string s2)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60001C1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D66AEC", Offset = "0x1D66AEC", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
		private void AddEvent(XmlEventCache.XmlEventType eventType, string s1, string s2, string s3)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60001C2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D66A48", Offset = "0x1D66A48", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
		private void AddEvent(XmlEventCache.XmlEventType eventType, string s1, string s2, string s3, object o)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60001C3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D66EB8", Offset = "0x1D66EB8", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
		private void AddEvent(XmlEventCache.XmlEventType eventType, object o)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60001C4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D673AC", Offset = "0x1D673AC", Length = "0x1D4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAutoDetectWriter), Member = "CreateWrappedWriter", MemberParameters = new object[] { typeof(XmlOutputMethod) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEventCache), Member = "EndEvents", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEventCache), Member = "WriteDocType", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEventCache), Member = "WriteStartElement", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEventCache), Member = "WriteStartAttribute", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEventCache), Member = "WriteEndAttribute", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEventCache), Member = "WriteCData", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEventCache), Member = "WriteComment", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEventCache), Member = "WriteProcessingInstruction", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEventCache), Member = "WriteWhitespace", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEventCache), Member = "WriteString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEventCache), Member = "WriteRaw", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEventCache), Member = "WriteEntityRef", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEventCache), Member = "WriteCharEntity", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEventCache), Member = "WriteSurrogateCharEntity", MemberParameters = new object[]
		{
			typeof(char),
			typeof(char)
		}, ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEventCache), Member = "Close", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEventCache), Member = "Flush", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEventCache), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEventCache), Member = "WriteXmlDeclaration", MemberParameters = new object[] { typeof(XmlStandalone) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEventCache), Member = "WriteXmlDeclaration", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEventCache), Member = "StartElementContent", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEventCache), Member = "WriteEndElement", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEventCache), Member = "WriteFullEndElement", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEventCache), Member = "WriteNamespaceDeclaration", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEventCache), Member = "WriteEndBase64", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEventCache), Member = "AddEvent", MemberParameters = new object[] { typeof(XmlEventCache.XmlEventType) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEventCache), Member = "AddEvent", MemberParameters = new object[]
		{
			typeof(XmlEventCache.XmlEventType),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEventCache), Member = "AddEvent", MemberParameters = new object[]
		{
			typeof(XmlEventCache.XmlEventType),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEventCache), Member = "AddEvent", MemberParameters = new object[]
		{
			typeof(XmlEventCache.XmlEventType),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEventCache), Member = "AddEvent", MemberParameters = new object[]
		{
			typeof(XmlEventCache.XmlEventType),
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEventCache), Member = "AddEvent", MemberParameters = new object[]
		{
			typeof(XmlEventCache.XmlEventType),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 33)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringConcat), Member = "GetResult", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringConcat), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private int NewEvent()
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x40000AD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private List<XmlEventCache.XmlEvent[]> pages;

		[global::Cpp2ILInjected.Token(Token = "0x40000AE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private XmlEventCache.XmlEvent[] pageCurr;

		[global::Cpp2ILInjected.Token(Token = "0x40000AF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private int pageSize;

		[global::Cpp2ILInjected.Token(Token = "0x40000B0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		private bool hasRootNode;

		[global::Cpp2ILInjected.Token(Token = "0x40000B1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private StringConcat singleText;

		[global::Cpp2ILInjected.Token(Token = "0x40000B2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private string baseUri;

		[global::Cpp2ILInjected.Token(Token = "0x2000035")]
		private enum XmlEventType
		{
			[global::Cpp2ILInjected.Token(Token = "0x40000B4")]
			Unknown,
			[global::Cpp2ILInjected.Token(Token = "0x40000B5")]
			DocType,
			[global::Cpp2ILInjected.Token(Token = "0x40000B6")]
			StartElem,
			[global::Cpp2ILInjected.Token(Token = "0x40000B7")]
			StartAttr,
			[global::Cpp2ILInjected.Token(Token = "0x40000B8")]
			EndAttr,
			[global::Cpp2ILInjected.Token(Token = "0x40000B9")]
			CData,
			[global::Cpp2ILInjected.Token(Token = "0x40000BA")]
			Comment,
			[global::Cpp2ILInjected.Token(Token = "0x40000BB")]
			PI,
			[global::Cpp2ILInjected.Token(Token = "0x40000BC")]
			Whitespace,
			[global::Cpp2ILInjected.Token(Token = "0x40000BD")]
			String,
			[global::Cpp2ILInjected.Token(Token = "0x40000BE")]
			Raw,
			[global::Cpp2ILInjected.Token(Token = "0x40000BF")]
			EntRef,
			[global::Cpp2ILInjected.Token(Token = "0x40000C0")]
			CharEnt,
			[global::Cpp2ILInjected.Token(Token = "0x40000C1")]
			SurrCharEnt,
			[global::Cpp2ILInjected.Token(Token = "0x40000C2")]
			Base64,
			[global::Cpp2ILInjected.Token(Token = "0x40000C3")]
			BinHex,
			[global::Cpp2ILInjected.Token(Token = "0x40000C4")]
			XmlDecl1,
			[global::Cpp2ILInjected.Token(Token = "0x40000C5")]
			XmlDecl2,
			[global::Cpp2ILInjected.Token(Token = "0x40000C6")]
			StartContent,
			[global::Cpp2ILInjected.Token(Token = "0x40000C7")]
			EndElem,
			[global::Cpp2ILInjected.Token(Token = "0x40000C8")]
			FullEndElem,
			[global::Cpp2ILInjected.Token(Token = "0x40000C9")]
			Nmsp,
			[global::Cpp2ILInjected.Token(Token = "0x40000CA")]
			EndBase64,
			[global::Cpp2ILInjected.Token(Token = "0x40000CB")]
			Close,
			[global::Cpp2ILInjected.Token(Token = "0x40000CC")]
			Flush,
			[global::Cpp2ILInjected.Token(Token = "0x40000CD")]
			Dispose
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000036")]
		private struct XmlEvent
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001C6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D675C4", Offset = "0x1D675C4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void InitEvent(XmlEventCache.XmlEventType eventType)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60001C7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D67580", Offset = "0x1D67580", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void InitEvent(XmlEventCache.XmlEventType eventType, string s1)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60001C8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D6758C", Offset = "0x1D6758C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void InitEvent(XmlEventCache.XmlEventType eventType, string s1, string s2)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60001C9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D67598", Offset = "0x1D67598", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void InitEvent(XmlEventCache.XmlEventType eventType, string s1, string s2, string s3)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60001CA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D675A8", Offset = "0x1D675A8", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void InitEvent(XmlEventCache.XmlEventType eventType, string s1, string s2, string s3, object o)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60001CB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D675B8", Offset = "0x1D675B8", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void InitEvent(XmlEventCache.XmlEventType eventType, object o)
			{
				throw null;
			}

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

			[global::Cpp2ILInjected.Token(Token = "0x40000CE")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private XmlEventCache.XmlEventType eventType;

			[global::Cpp2ILInjected.Token(Token = "0x40000CF")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			private string s1;

			[global::Cpp2ILInjected.Token(Token = "0x40000D0")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private string s2;

			[global::Cpp2ILInjected.Token(Token = "0x40000D1")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private string s3;

			[global::Cpp2ILInjected.Token(Token = "0x40000D2")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private object o;
		}
	}
}
