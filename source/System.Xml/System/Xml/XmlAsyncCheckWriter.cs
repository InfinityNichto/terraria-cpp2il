using System;
using System.IO;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml
{
	// Token: 0x0200002F RID: 47
	[global::Cpp2ILInjected.Token(Token = "0x2000030")]
	internal class XmlAsyncCheckWriter : XmlWriter
	{
		// Token: 0x0600010B RID: 267 RVA: 0x00003272 File Offset: 0x00001472
		[global::Cpp2ILInjected.Token(Token = "0x600010D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D63020", Offset = "0x1D63020", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWriterSettings), Member = "CreateWriter", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(XmlWriter))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlWriterSettings), Member = "CreateWriter", MemberParameters = new object[] { typeof(TextWriter) }, ReturnType = typeof(XmlWriter))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWriter), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public XmlAsyncCheckWriter(XmlWriter writer)
		{
			throw null;
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00003275 File Offset: 0x00001475
		[global::Cpp2ILInjected.Token(Token = "0x600010E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6309C", Offset = "0x1D6309C", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 28)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "get_IsCompleted", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void CheckAsync()
		{
			throw null;
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00003278 File Offset: 0x00001478
		[global::Cpp2ILInjected.Token(Token = "0x600010F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D63110", Offset = "0x1D63110", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlAsyncCheckWriter), Member = "CheckAsync", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void WriteStartDocument()
		{
			throw null;
		}

		// Token: 0x0600010E RID: 270 RVA: 0x0000327B File Offset: 0x0000147B
		[global::Cpp2ILInjected.Token(Token = "0x6000110")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D63130", Offset = "0x1D63130", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlAsyncCheckWriter), Member = "CheckAsync", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void WriteStartDocument(bool standalone)
		{
			throw null;
		}

		// Token: 0x0600010F RID: 271 RVA: 0x0000327E File Offset: 0x0000147E
		[global::Cpp2ILInjected.Token(Token = "0x6000111")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D63160", Offset = "0x1D63160", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlAsyncCheckWriter), Member = "CheckAsync", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void WriteEndDocument()
		{
			throw null;
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00003281 File Offset: 0x00001481
		[global::Cpp2ILInjected.Token(Token = "0x6000112")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D63180", Offset = "0x1D63180", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlAsyncCheckWriter), Member = "CheckAsync", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void WriteDocType(string name, string pubid, string sysid, string subset)
		{
			throw null;
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00003284 File Offset: 0x00001484
		[global::Cpp2ILInjected.Token(Token = "0x6000113")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D631D0", Offset = "0x1D631D0", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlAsyncCheckWriter), Member = "CheckAsync", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void WriteStartElement(string prefix, string localName, string ns)
		{
			throw null;
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00003287 File Offset: 0x00001487
		[global::Cpp2ILInjected.Token(Token = "0x6000114")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D63218", Offset = "0x1D63218", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlAsyncCheckWriter), Member = "CheckAsync", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void WriteEndElement()
		{
			throw null;
		}

		// Token: 0x06000113 RID: 275 RVA: 0x0000328A File Offset: 0x0000148A
		[global::Cpp2ILInjected.Token(Token = "0x6000115")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D63238", Offset = "0x1D63238", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlAsyncCheckWriter), Member = "CheckAsync", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void WriteFullEndElement()
		{
			throw null;
		}

		// Token: 0x06000114 RID: 276 RVA: 0x0000328D File Offset: 0x0000148D
		[global::Cpp2ILInjected.Token(Token = "0x6000116")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D63258", Offset = "0x1D63258", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlAsyncCheckWriter), Member = "CheckAsync", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void WriteStartAttribute(string prefix, string localName, string ns)
		{
			throw null;
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00003290 File Offset: 0x00001490
		[global::Cpp2ILInjected.Token(Token = "0x6000117")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D632A0", Offset = "0x1D632A0", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlAsyncCheckWriter), Member = "CheckAsync", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void WriteEndAttribute()
		{
			throw null;
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00003293 File Offset: 0x00001493
		[global::Cpp2ILInjected.Token(Token = "0x6000118")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D632C4", Offset = "0x1D632C4", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlAsyncCheckWriter), Member = "CheckAsync", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void WriteCData(string text)
		{
			throw null;
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00003296 File Offset: 0x00001496
		[global::Cpp2ILInjected.Token(Token = "0x6000119")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D632F8", Offset = "0x1D632F8", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlAsyncCheckWriter), Member = "CheckAsync", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void WriteComment(string text)
		{
			throw null;
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00003299 File Offset: 0x00001499
		[global::Cpp2ILInjected.Token(Token = "0x600011A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6332C", Offset = "0x1D6332C", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlAsyncCheckWriter), Member = "CheckAsync", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void WriteProcessingInstruction(string name, string text)
		{
			throw null;
		}

		// Token: 0x06000119 RID: 281 RVA: 0x0000329C File Offset: 0x0000149C
		[global::Cpp2ILInjected.Token(Token = "0x600011B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D63368", Offset = "0x1D63368", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlAsyncCheckWriter), Member = "CheckAsync", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void WriteEntityRef(string name)
		{
			throw null;
		}

		// Token: 0x0600011A RID: 282 RVA: 0x0000329F File Offset: 0x0000149F
		[global::Cpp2ILInjected.Token(Token = "0x600011C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6339C", Offset = "0x1D6339C", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlAsyncCheckWriter), Member = "CheckAsync", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void WriteCharEntity(char ch)
		{
			throw null;
		}

		// Token: 0x0600011B RID: 283 RVA: 0x000032A2 File Offset: 0x000014A2
		[global::Cpp2ILInjected.Token(Token = "0x600011D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D633D0", Offset = "0x1D633D0", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlAsyncCheckWriter), Member = "CheckAsync", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void WriteWhitespace(string ws)
		{
			throw null;
		}

		// Token: 0x0600011C RID: 284 RVA: 0x000032A5 File Offset: 0x000014A5
		[global::Cpp2ILInjected.Token(Token = "0x600011E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D63404", Offset = "0x1D63404", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlAsyncCheckWriter), Member = "CheckAsync", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void WriteString(string text)
		{
			throw null;
		}

		// Token: 0x0600011D RID: 285 RVA: 0x000032A8 File Offset: 0x000014A8
		[global::Cpp2ILInjected.Token(Token = "0x600011F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D63438", Offset = "0x1D63438", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlAsyncCheckWriter), Member = "CheckAsync", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void WriteSurrogateCharEntity(char lowChar, char highChar)
		{
			throw null;
		}

		// Token: 0x0600011E RID: 286 RVA: 0x000032AB File Offset: 0x000014AB
		[global::Cpp2ILInjected.Token(Token = "0x6000120")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D63474", Offset = "0x1D63474", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlAsyncCheckWriter), Member = "CheckAsync", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void WriteChars(char[] buffer, int index, int count)
		{
			throw null;
		}

		// Token: 0x0600011F RID: 287 RVA: 0x000032AE File Offset: 0x000014AE
		[global::Cpp2ILInjected.Token(Token = "0x6000121")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D634C0", Offset = "0x1D634C0", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlAsyncCheckWriter), Member = "CheckAsync", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void WriteRaw(char[] buffer, int index, int count)
		{
			throw null;
		}

		// Token: 0x06000120 RID: 288 RVA: 0x000032B1 File Offset: 0x000014B1
		[global::Cpp2ILInjected.Token(Token = "0x6000122")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6350C", Offset = "0x1D6350C", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlAsyncCheckWriter), Member = "CheckAsync", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void WriteRaw(string data)
		{
			throw null;
		}

		// Token: 0x06000121 RID: 289 RVA: 0x000032B4 File Offset: 0x000014B4
		[global::Cpp2ILInjected.Token(Token = "0x6000123")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D63540", Offset = "0x1D63540", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlAsyncCheckWriter), Member = "CheckAsync", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void WriteBase64(byte[] buffer, int index, int count)
		{
			throw null;
		}

		// Token: 0x06000122 RID: 290 RVA: 0x000032B7 File Offset: 0x000014B7
		[global::Cpp2ILInjected.Token(Token = "0x6000124")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6358C", Offset = "0x1D6358C", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlAsyncCheckWriter), Member = "CheckAsync", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void WriteBinHex(byte[] buffer, int index, int count)
		{
			throw null;
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000123 RID: 291 RVA: 0x000032BA File Offset: 0x000014BA
		[global::Cpp2ILInjected.Token(Token = "0x17000037")]
		public override WriteState WriteState
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000125")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D635D8", Offset = "0x1D635D8", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlAsyncCheckWriter), Member = "CheckAsync", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000124 RID: 292 RVA: 0x000032BD File Offset: 0x000014BD
		[global::Cpp2ILInjected.Token(Token = "0x6000126")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D635FC", Offset = "0x1D635FC", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlAsyncCheckWriter), Member = "CheckAsync", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x06000125 RID: 293 RVA: 0x000032C0 File Offset: 0x000014C0
		[global::Cpp2ILInjected.Token(Token = "0x6000127")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D63620", Offset = "0x1D63620", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlAsyncCheckWriter), Member = "CheckAsync", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void Flush()
		{
			throw null;
		}

		// Token: 0x06000126 RID: 294 RVA: 0x000032C3 File Offset: 0x000014C3
		[global::Cpp2ILInjected.Token(Token = "0x6000128")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D63644", Offset = "0x1D63644", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlAsyncCheckWriter), Member = "CheckAsync", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override string LookupPrefix(string ns)
		{
			throw null;
		}

		// Token: 0x06000127 RID: 295 RVA: 0x000032C6 File Offset: 0x000014C6
		[global::Cpp2ILInjected.Token(Token = "0x6000129")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D63678", Offset = "0x1D63678", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlAsyncCheckWriter), Member = "CheckAsync", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void WriteValue(string value)
		{
			throw null;
		}

		// Token: 0x06000128 RID: 296 RVA: 0x000032C9 File Offset: 0x000014C9
		[global::Cpp2ILInjected.Token(Token = "0x600012A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D636AC", Offset = "0x1D636AC", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlAsyncCheckWriter), Member = "CheckAsync", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWriter), Member = "Dispose", ReturnType = typeof(void))]
		protected override void Dispose(bool disposing)
		{
			throw null;
		}

		// Token: 0x0400007F RID: 127
		[global::Cpp2ILInjected.Token(Token = "0x400007F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly XmlWriter coreWriter;

		// Token: 0x04000080 RID: 128
		[global::Cpp2ILInjected.Token(Token = "0x4000080")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private Task lastTask;
	}
}
