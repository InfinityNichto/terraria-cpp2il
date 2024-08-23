using System;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml
{
	// Token: 0x0200003F RID: 63
	[global::Cpp2ILInjected.Token(Token = "0x200005C")]
	public abstract class XmlWriter : IDisposable
	{
		// Token: 0x060003A2 RID: 930
		[global::Cpp2ILInjected.Token(Token = "0x600041A")]
		public abstract void WriteStartDocument();

		// Token: 0x060003A3 RID: 931
		[global::Cpp2ILInjected.Token(Token = "0x600041B")]
		public abstract void WriteStartDocument(bool standalone);

		// Token: 0x060003A4 RID: 932
		[global::Cpp2ILInjected.Token(Token = "0x600041C")]
		public abstract void WriteEndDocument();

		// Token: 0x060003A5 RID: 933
		[global::Cpp2ILInjected.Token(Token = "0x600041D")]
		public abstract void WriteDocType(string name, string pubid, string sysid, string subset);

		// Token: 0x060003A6 RID: 934
		[global::Cpp2ILInjected.Token(Token = "0x600041E")]
		public abstract void WriteStartElement(string prefix, string localName, string ns);

		// Token: 0x060003A7 RID: 935
		[global::Cpp2ILInjected.Token(Token = "0x600041F")]
		public abstract void WriteEndElement();

		// Token: 0x060003A8 RID: 936
		[global::Cpp2ILInjected.Token(Token = "0x6000420")]
		public abstract void WriteFullEndElement();

		// Token: 0x060003A9 RID: 937 RVA: 0x000039FB File Offset: 0x00001BFB
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

		// Token: 0x060003AA RID: 938
		[global::Cpp2ILInjected.Token(Token = "0x6000422")]
		public abstract void WriteStartAttribute(string prefix, string localName, string ns);

		// Token: 0x060003AB RID: 939
		[global::Cpp2ILInjected.Token(Token = "0x6000423")]
		public abstract void WriteEndAttribute();

		// Token: 0x060003AC RID: 940
		[global::Cpp2ILInjected.Token(Token = "0x6000424")]
		public abstract void WriteCData(string text);

		// Token: 0x060003AD RID: 941
		[global::Cpp2ILInjected.Token(Token = "0x6000425")]
		public abstract void WriteComment(string text);

		// Token: 0x060003AE RID: 942
		[global::Cpp2ILInjected.Token(Token = "0x6000426")]
		public abstract void WriteProcessingInstruction(string name, string text);

		// Token: 0x060003AF RID: 943
		[global::Cpp2ILInjected.Token(Token = "0x6000427")]
		public abstract void WriteEntityRef(string name);

		// Token: 0x060003B0 RID: 944
		[global::Cpp2ILInjected.Token(Token = "0x6000428")]
		public abstract void WriteCharEntity(char ch);

		// Token: 0x060003B1 RID: 945
		[global::Cpp2ILInjected.Token(Token = "0x6000429")]
		public abstract void WriteWhitespace(string ws);

		// Token: 0x060003B2 RID: 946
		[global::Cpp2ILInjected.Token(Token = "0x600042A")]
		public abstract void WriteString(string text);

		// Token: 0x060003B3 RID: 947
		[global::Cpp2ILInjected.Token(Token = "0x600042B")]
		public abstract void WriteSurrogateCharEntity(char lowChar, char highChar);

		// Token: 0x060003B4 RID: 948
		[global::Cpp2ILInjected.Token(Token = "0x600042C")]
		public abstract void WriteChars(char[] buffer, int index, int count);

		// Token: 0x060003B5 RID: 949
		[global::Cpp2ILInjected.Token(Token = "0x600042D")]
		public abstract void WriteRaw(char[] buffer, int index, int count);

		// Token: 0x060003B6 RID: 950
		[global::Cpp2ILInjected.Token(Token = "0x600042E")]
		public abstract void WriteRaw(string data);

		// Token: 0x060003B7 RID: 951
		[global::Cpp2ILInjected.Token(Token = "0x600042F")]
		public abstract void WriteBase64(byte[] buffer, int index, int count);

		// Token: 0x060003B8 RID: 952 RVA: 0x000039FE File Offset: 0x00001BFE
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

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060003B9 RID: 953
		[global::Cpp2ILInjected.Token(Token = "0x170000C8")]
		public abstract WriteState WriteState
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000431")]
			get;
		}

		// Token: 0x060003BA RID: 954 RVA: 0x00003A01 File Offset: 0x00001C01
		[global::Cpp2ILInjected.Token(Token = "0x6000432")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D89F28", Offset = "0x1D89F28", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void Close()
		{
			throw null;
		}

		// Token: 0x060003BB RID: 955
		[global::Cpp2ILInjected.Token(Token = "0x6000433")]
		public abstract void Flush();

		// Token: 0x060003BC RID: 956
		[global::Cpp2ILInjected.Token(Token = "0x6000434")]
		public abstract string LookupPrefix(string ns);

		// Token: 0x060003BD RID: 957 RVA: 0x00003A04 File Offset: 0x00001C04
		[global::Cpp2ILInjected.Token(Token = "0x6000435")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D89F2C", Offset = "0x1D89F2C", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual void WriteValue(string value)
		{
			throw null;
		}

		// Token: 0x060003BE RID: 958 RVA: 0x00003A07 File Offset: 0x00001C07
		[global::Cpp2ILInjected.Token(Token = "0x6000436")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D89F44", Offset = "0x1D89F44", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAsyncCheckWriter), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Dispose()
		{
			throw null;
		}

		// Token: 0x060003BF RID: 959 RVA: 0x00003A0A File Offset: 0x00001C0A
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

		// Token: 0x060003C0 RID: 960 RVA: 0x00003A0D File Offset: 0x00001C0D
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

		// Token: 0x060003C1 RID: 961 RVA: 0x00003A10 File Offset: 0x00001C10
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

		// Token: 0x060003C2 RID: 962 RVA: 0x00003A13 File Offset: 0x00001C13
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
