using System;
using System.IO;
using System.Net;
using System.Net.Cache;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml
{
	// Token: 0x02000073 RID: 115
	[global::Cpp2ILInjected.Token(Token = "0x200009A")]
	internal class XmlRegisteredNonCachedStream : Stream
	{
		// Token: 0x060006A8 RID: 1704 RVA: 0x000042A7 File Offset: 0x000024A7
		[global::Cpp2ILInjected.Token(Token = "0x6000731")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DAC804", Offset = "0x1DAC804", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlDownloadManager.<GetNonFileStreamAsync>d__5", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDownloadManager), Member = "GetNonFileStream", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(ICredentials),
			typeof(IWebProxy),
			typeof(RequestCachePolicy)
		}, ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stream), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal XmlRegisteredNonCachedStream(Stream stream, XmlDownloadManager downloadManager, string host)
		{
			throw null;
		}

		// Token: 0x060006A9 RID: 1705 RVA: 0x000042AA File Offset: 0x000024AA
		[global::Cpp2ILInjected.Token(Token = "0x6000732")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DAD538", Offset = "0x1DAD538", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlDownloadManager), Member = "Remove", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "Finalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		protected override void Finalize()
		{
			throw null;
		}

		// Token: 0x060006AA RID: 1706 RVA: 0x000042AD File Offset: 0x000024AD
		[global::Cpp2ILInjected.Token(Token = "0x6000733")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DAD5DC", Offset = "0x1DAD5DC", Length = "0x130")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlDownloadManager), Member = "Remove", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stream), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		protected override void Dispose(bool disposing)
		{
			throw null;
		}

		// Token: 0x060006AB RID: 1707 RVA: 0x000042B0 File Offset: 0x000024B0
		[global::Cpp2ILInjected.Token(Token = "0x6000734")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DAD70C", Offset = "0x1DAD70C", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			throw null;
		}

		// Token: 0x060006AC RID: 1708 RVA: 0x000042B3 File Offset: 0x000024B3
		[global::Cpp2ILInjected.Token(Token = "0x6000735")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DAD720", Offset = "0x1DAD720", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			throw null;
		}

		// Token: 0x060006AD RID: 1709 RVA: 0x000042B6 File Offset: 0x000024B6
		[global::Cpp2ILInjected.Token(Token = "0x6000736")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DAD734", Offset = "0x1DAD734", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override int EndRead(IAsyncResult asyncResult)
		{
			throw null;
		}

		// Token: 0x060006AE RID: 1710 RVA: 0x000042B9 File Offset: 0x000024B9
		[global::Cpp2ILInjected.Token(Token = "0x6000737")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DAD748", Offset = "0x1DAD748", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void EndWrite(IAsyncResult asyncResult)
		{
			throw null;
		}

		// Token: 0x060006AF RID: 1711 RVA: 0x000042BC File Offset: 0x000024BC
		[global::Cpp2ILInjected.Token(Token = "0x6000738")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DAD75C", Offset = "0x1DAD75C", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void Flush()
		{
			throw null;
		}

		// Token: 0x060006B0 RID: 1712 RVA: 0x000042BF File Offset: 0x000024BF
		[global::Cpp2ILInjected.Token(Token = "0x6000739")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DAD770", Offset = "0x1DAD770", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override int Read(byte[] buffer, int offset, int count)
		{
			throw null;
		}

		// Token: 0x060006B1 RID: 1713 RVA: 0x000042C2 File Offset: 0x000024C2
		[global::Cpp2ILInjected.Token(Token = "0x600073A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DAD784", Offset = "0x1DAD784", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override int ReadByte()
		{
			throw null;
		}

		// Token: 0x060006B2 RID: 1714 RVA: 0x000042C5 File Offset: 0x000024C5
		[global::Cpp2ILInjected.Token(Token = "0x600073B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DAD798", Offset = "0x1DAD798", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override long Seek(long offset, SeekOrigin origin)
		{
			throw null;
		}

		// Token: 0x060006B3 RID: 1715 RVA: 0x000042C8 File Offset: 0x000024C8
		[global::Cpp2ILInjected.Token(Token = "0x600073C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DAD7AC", Offset = "0x1DAD7AC", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void SetLength(long value)
		{
			throw null;
		}

		// Token: 0x060006B4 RID: 1716 RVA: 0x000042CB File Offset: 0x000024CB
		[global::Cpp2ILInjected.Token(Token = "0x600073D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DAD7C0", Offset = "0x1DAD7C0", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void Write(byte[] buffer, int offset, int count)
		{
			throw null;
		}

		// Token: 0x060006B5 RID: 1717 RVA: 0x000042CE File Offset: 0x000024CE
		[global::Cpp2ILInjected.Token(Token = "0x600073E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DAD7D4", Offset = "0x1DAD7D4", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void WriteByte(byte value)
		{
			throw null;
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x060006B6 RID: 1718 RVA: 0x000042D1 File Offset: 0x000024D1
		[global::Cpp2ILInjected.Token(Token = "0x170001B9")]
		public override bool CanRead
		{
			[global::Cpp2ILInjected.Token(Token = "0x600073F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DAD7E8", Offset = "0x1DAD7E8", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x060006B7 RID: 1719 RVA: 0x000042D4 File Offset: 0x000024D4
		[global::Cpp2ILInjected.Token(Token = "0x170001BA")]
		public override bool CanSeek
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000740")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DAD7F8", Offset = "0x1DAD7F8", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x060006B8 RID: 1720 RVA: 0x000042D7 File Offset: 0x000024D7
		[global::Cpp2ILInjected.Token(Token = "0x170001BB")]
		public override bool CanWrite
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000741")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DAD808", Offset = "0x1DAD808", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x060006B9 RID: 1721 RVA: 0x000042DA File Offset: 0x000024DA
		[global::Cpp2ILInjected.Token(Token = "0x170001BC")]
		public override long Length
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000742")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DAD818", Offset = "0x1DAD818", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x060006BA RID: 1722 RVA: 0x000042DD File Offset: 0x000024DD
		// (set) Token: 0x060006BB RID: 1723 RVA: 0x000042E0 File Offset: 0x000024E0
		[global::Cpp2ILInjected.Token(Token = "0x170001BD")]
		public override long Position
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000743")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DAD828", Offset = "0x1DAD828", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000744")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DAD838", Offset = "0x1DAD838", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0400024B RID: 587
		[global::Cpp2ILInjected.Token(Token = "0x40003B3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		protected Stream stream;

		// Token: 0x0400024C RID: 588
		[global::Cpp2ILInjected.Token(Token = "0x40003B4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private XmlDownloadManager downloadManager;

		// Token: 0x0400024D RID: 589
		[global::Cpp2ILInjected.Token(Token = "0x40003B5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private string host;
	}
}
