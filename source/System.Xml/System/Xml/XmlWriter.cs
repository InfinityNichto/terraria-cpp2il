using System;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml
{
	[global::Cpp2ILInjected.Token(Token = "0x200005C")]
	public abstract class XmlWriter : IDisposable
	{
		[global::Cpp2ILInjected.Token(Token = "0x600041A")]
		public abstract void WriteStartDocument();

		[global::Cpp2ILInjected.Token(Token = "0x600041B")]
		public abstract void WriteStartDocument(bool standalone);

		[global::Cpp2ILInjected.Token(Token = "0x600041C")]
		public abstract void WriteEndDocument();

		[global::Cpp2ILInjected.Token(Token = "0x600041D")]
		public abstract void WriteDocType(string name, string pubid, string sysid, string subset);

		[global::Cpp2ILInjected.Token(Token = "0x600041E")]
		public abstract void WriteStartElement(string prefix, string localName, string ns);

		[global::Cpp2ILInjected.Token(Token = "0x600041F")]
		public abstract void WriteEndElement();

		[global::Cpp2ILInjected.Token(Token = "0x6000420")]
		public abstract void WriteFullEndElement();

		[global::Cpp2ILInjected.Token(Token = "0x6000421")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D89ED8", Offset = "0x1D89ED8", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEventCache), Member = "EventsToWriter", MemberParameters = new object[] { typeof(XmlWriter) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Linq.XAttribute", Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Linq.ElementWriter", Member = "WriteStartElement", MemberParameters = new object[] { "System.Xml.Linq.XElement" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void WriteAttributeString(string prefix, string localName, string ns, string value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000422")]
		public abstract void WriteStartAttribute(string prefix, string localName, string ns);

		[global::Cpp2ILInjected.Token(Token = "0x6000423")]
		public abstract void WriteEndAttribute();

		[global::Cpp2ILInjected.Token(Token = "0x6000424")]
		public abstract void WriteCData(string text);

		[global::Cpp2ILInjected.Token(Token = "0x6000425")]
		public abstract void WriteComment(string text);

		[global::Cpp2ILInjected.Token(Token = "0x6000426")]
		public abstract void WriteProcessingInstruction(string name, string text);

		[global::Cpp2ILInjected.Token(Token = "0x6000427")]
		public abstract void WriteEntityRef(string name);

		[global::Cpp2ILInjected.Token(Token = "0x6000428")]
		public abstract void WriteCharEntity(char ch);

		[global::Cpp2ILInjected.Token(Token = "0x6000429")]
		public abstract void WriteWhitespace(string ws);

		[global::Cpp2ILInjected.Token(Token = "0x600042A")]
		public abstract void WriteString(string text);

		[global::Cpp2ILInjected.Token(Token = "0x600042B")]
		public abstract void WriteSurrogateCharEntity(char lowChar, char highChar);

		[global::Cpp2ILInjected.Token(Token = "0x600042C")]
		public abstract void WriteChars(char[] buffer, int index, int count);

		[global::Cpp2ILInjected.Token(Token = "0x600042D")]
		public abstract void WriteRaw(char[] buffer, int index, int count);

		[global::Cpp2ILInjected.Token(Token = "0x600042E")]
		public abstract void WriteRaw(string data);

		[global::Cpp2ILInjected.Token(Token = "0x600042F")]
		public abstract void WriteBase64(byte[] buffer, int index, int count);

		[global::Cpp2ILInjected.Token(Token = "0x6000430")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D88A20", Offset = "0x1D88A20", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BinHexEncoder), Member = "Encode", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(XmlWriter)
		}, ReturnType = typeof(void))]
		public virtual void WriteBinHex(byte[] buffer, int index, int count)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170000C8")]
		public abstract WriteState WriteState
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000431")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000432")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D89F28", Offset = "0x1D89F28", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void Close()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000433")]
		public abstract void Flush();

		[global::Cpp2ILInjected.Token(Token = "0x6000434")]
		public abstract string LookupPrefix(string ns);

		[global::Cpp2ILInjected.Token(Token = "0x6000435")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D89F2C", Offset = "0x1D89F2C", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual void WriteValue(string value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000436")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D89F44", Offset = "0x1D89F44", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAsyncCheckWriter), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Dispose()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000437")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D89F58", Offset = "0x1D89F58", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEventCache), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected virtual void Dispose(bool disposing)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000438")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D89F9C", Offset = "0x1D89F9C", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAutoDetectWriter), Member = "CreateWrappedWriter", MemberParameters = new object[] { typeof(XmlOutputMethod) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWriterSettings), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWriterSettings), Member = "CreateWriter", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(XmlWriter))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static XmlWriter Create(Stream output, XmlWriterSettings settings)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000439")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D8A4F8", Offset = "0x1D8A4F8", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAutoDetectWriter), Member = "CreateWrappedWriter", MemberParameters = new object[] { typeof(XmlOutputMethod) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Linq.XAttribute", Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Linq.XNode", Member = "GetXmlString", MemberParameters = new object[] { "System.Xml.Linq.SaveOptions" }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWriterSettings), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static XmlWriter Create(TextWriter output, XmlWriterSettings settings)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600043A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D83560", Offset = "0x1D83560", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(QueryOutputWriter), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(XmlRawWriter),
			typeof(XmlWriterSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAsyncCheckWriter), Member = ".ctor", MemberParameters = new object[] { typeof(XmlWriter) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAutoDetectWriter), Member = ".ctor", MemberParameters = new object[] { typeof(XmlWriterSettings) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEncodedRawTextWriter), Member = ".ctor", MemberParameters = new object[] { typeof(XmlWriterSettings) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEventCache), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlRawWriter), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected XmlWriter()
		{
			throw null;
		}
	}
}
