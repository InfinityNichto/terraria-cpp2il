using System;
using System.IO;
using System.Net.Mime;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x020000D2 RID: 210
	[global::Cpp2ILInjected.Token(Token = "0x2000134")]
	internal sealed class Base64Stream : DelegatedStream, IEncodableStream
	{
		// Token: 0x0600068B RID: 1675 RVA: 0x000040F4 File Offset: 0x000022F4
		[global::Cpp2ILInjected.Token(Token = "0x600073B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE57A8", Offset = "0x1EE57A8", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DelegatedStream), Member = ".ctor", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Base64WriteStateInfo), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal Base64Stream(Stream stream, Base64WriteStateInfo writeStateInfo)
		{
			throw null;
		}

		// Token: 0x0600068C RID: 1676 RVA: 0x000040F7 File Offset: 0x000022F7
		[global::Cpp2ILInjected.Token(Token = "0x600073C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE5928", Offset = "0x1EE5928", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryStream), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DelegatedStream), Member = ".ctor", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal Base64Stream(Base64WriteStateInfo writeStateInfo)
		{
			throw null;
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x0600068D RID: 1677 RVA: 0x000040FA File Offset: 0x000022FA
		[global::Cpp2ILInjected.Token(Token = "0x17000184")]
		private Base64Stream.ReadStateInfo ReadState
		{
			[global::Cpp2ILInjected.Token(Token = "0x600073D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EE59A0", Offset = "0x1EE59A0", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Base64Stream), Member = "DecodeBytes", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x0600068E RID: 1678 RVA: 0x000040FD File Offset: 0x000022FD
		[global::Cpp2ILInjected.Token(Token = "0x17000185")]
		internal Base64WriteStateInfo WriteState
		{
			[global::Cpp2ILInjected.Token(Token = "0x600073E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EE5A0C", Offset = "0x1EE5A0C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600068F RID: 1679 RVA: 0x00004100 File Offset: 0x00002300
		[global::Cpp2ILInjected.Token(Token = "0x600073F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE5A14", Offset = "0x1EE5A14", Length = "0x154")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LazyAsyncResult), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object),
			typeof(AsyncCallback)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Base64Stream.ReadAsyncResult), Member = "Read", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			throw null;
		}

		// Token: 0x06000690 RID: 1680 RVA: 0x00004103 File Offset: 0x00002303
		[global::Cpp2ILInjected.Token(Token = "0x6000740")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE5CD8", Offset = "0x1EE5CD8", Length = "0x154")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LazyAsyncResult), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object),
			typeof(AsyncCallback)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Base64Stream.WriteAsyncResult), Member = "Write", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			throw null;
		}

		// Token: 0x06000691 RID: 1681 RVA: 0x00004106 File Offset: 0x00002306
		[global::Cpp2ILInjected.Token(Token = "0x6000741")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE6014", Offset = "0x1EE6014", Length = "0x17C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WriteStateInfoBase), Member = "Append", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Base64Stream), Member = "FlushInternal", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x06000692 RID: 1682 RVA: 0x00004109 File Offset: 0x00002309
		[global::Cpp2ILInjected.Token(Token = "0x6000742")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE61D0", Offset = "0x1EE61D0", Length = "0x214")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Base64Stream.ReadAsyncResult), Member = "CompleteRead", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Base64Stream), Member = "Read", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Base64Stream), Member = "get_ReadState", ReturnType = typeof(Base64Stream.ReadStateInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public int DecodeBytes(byte[] buffer, int offset, int count)
		{
			throw null;
		}

		// Token: 0x06000693 RID: 1683 RVA: 0x0000410C File Offset: 0x0000230C
		[global::Cpp2ILInjected.Token(Token = "0x6000743")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE63E4", Offset = "0x1EE63E4", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public int EncodeBytes(byte[] buffer, int offset, int count)
		{
			throw null;
		}

		// Token: 0x06000694 RID: 1684 RVA: 0x0000410F File Offset: 0x0000230F
		[global::Cpp2ILInjected.Token(Token = "0x6000744")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE63F0", Offset = "0x1EE63F0", Length = "0x574")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Base64Stream.WriteAsyncResult), Member = "Write", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Base64Stream), Member = "Write", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WriteStateInfoBase), Member = "AppendHeader", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WriteStateInfoBase), Member = "Append", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WriteStateInfoBase), Member = "get_FooterLength", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WriteStateInfoBase), Member = "AppendCRLF", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WriteStateInfoBase), Member = "AppendFooter", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		internal int EncodeBytes(byte[] buffer, int offset, int count, bool dontDeferFinalBytes, bool shouldAppendSpaceToCRLF)
		{
			throw null;
		}

		// Token: 0x06000695 RID: 1685 RVA: 0x00004112 File Offset: 0x00002312
		[global::Cpp2ILInjected.Token(Token = "0x6000745")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE6964", Offset = "0x1EE6964", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public Stream GetStream()
		{
			throw null;
		}

		// Token: 0x06000696 RID: 1686 RVA: 0x00004115 File Offset: 0x00002315
		[global::Cpp2ILInjected.Token(Token = "0x6000746")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE6968", Offset = "0x1EE6968", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_ASCII", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public string GetEncodedString()
		{
			throw null;
		}

		// Token: 0x06000697 RID: 1687 RVA: 0x00004118 File Offset: 0x00002318
		[global::Cpp2ILInjected.Token(Token = "0x6000747")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE699C", Offset = "0x1EE699C", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public override int EndRead(IAsyncResult asyncResult)
		{
			throw null;
		}

		// Token: 0x06000698 RID: 1688 RVA: 0x0000411B File Offset: 0x0000231B
		[global::Cpp2ILInjected.Token(Token = "0x6000748")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE6AA8", Offset = "0x1EE6AA8", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public override void EndWrite(IAsyncResult asyncResult)
		{
			throw null;
		}

		// Token: 0x06000699 RID: 1689 RVA: 0x0000411E File Offset: 0x0000231E
		[global::Cpp2ILInjected.Token(Token = "0x6000749")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE6BAC", Offset = "0x1EE6BAC", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Base64Stream), Member = "FlushInternal", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void Flush()
		{
			throw null;
		}

		// Token: 0x0600069A RID: 1690 RVA: 0x00004121 File Offset: 0x00002321
		[global::Cpp2ILInjected.Token(Token = "0x600074A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE6190", Offset = "0x1EE6190", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Base64Stream), Member = "Close", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Base64Stream), Member = "Flush", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Base64Stream), Member = "Write", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DelegatedStream), Member = "Write", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WriteStateInfoBase), Member = "Reset", ReturnType = typeof(void))]
		private void FlushInternal()
		{
			throw null;
		}

		// Token: 0x0600069B RID: 1691 RVA: 0x00004124 File Offset: 0x00002324
		[global::Cpp2ILInjected.Token(Token = "0x600074B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE6CA0", Offset = "0x1EE6CA0", Length = "0x11C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DelegatedStream), Member = "Read", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Base64Stream), Member = "DecodeBytes", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public override int Read(byte[] buffer, int offset, int count)
		{
			throw null;
		}

		// Token: 0x0600069C RID: 1692 RVA: 0x00004127 File Offset: 0x00002327
		[global::Cpp2ILInjected.Token(Token = "0x600074C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE6E60", Offset = "0x1EE6E60", Length = "0x13C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Base64Stream), Member = "EncodeBytes", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Base64Stream), Member = "FlushInternal", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public override void Write(byte[] buffer, int offset, int count)
		{
			throw null;
		}

		// Token: 0x0600069D RID: 1693 RVA: 0x0000412A File Offset: 0x0000232A
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600074D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE6F9C", Offset = "0x1EE6F9C", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		static Base64Stream()
		{
			throw null;
		}

		// Token: 0x0400045C RID: 1116
		[global::Cpp2ILInjected.Token(Token = "0x40005D4")]
		private static readonly byte[] s_base64DecodeMap;

		// Token: 0x0400045D RID: 1117
		[global::Cpp2ILInjected.Token(Token = "0x40005D5")]
		private static readonly byte[] s_base64EncodeMap;

		// Token: 0x0400045E RID: 1118
		[global::Cpp2ILInjected.Token(Token = "0x40005D6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private readonly int _lineLength;

		// Token: 0x0400045F RID: 1119
		[global::Cpp2ILInjected.Token(Token = "0x40005D7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private readonly Base64WriteStateInfo _writeState;

		// Token: 0x04000460 RID: 1120
		[global::Cpp2ILInjected.Token(Token = "0x40005D8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private Base64Stream.ReadStateInfo _readState;

		// Token: 0x04000461 RID: 1121
		[global::Cpp2ILInjected.Token(Token = "0x40005D9")]
		private const int SizeOfBase64EncodedChar = 4;

		// Token: 0x04000462 RID: 1122
		[global::Cpp2ILInjected.Token(Token = "0x40005DA")]
		private const byte InvalidBase64Value = 255;

		// Token: 0x020003CA RID: 970
		[global::Cpp2ILInjected.Token(Token = "0x2000135")]
		private sealed class ReadAsyncResult : LazyAsyncResult
		{
			// Token: 0x06001D54 RID: 7508 RVA: 0x000080F0 File Offset: 0x000062F0
			[global::Cpp2ILInjected.Token(Token = "0x600074E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EE5B68", Offset = "0x1EE5B68", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LazyAsyncResult), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(object),
				typeof(AsyncCallback)
			}, ReturnType = typeof(void))]
			internal ReadAsyncResult(Base64Stream parent, byte[] buffer, int offset, int count, AsyncCallback callback, object state)
			{
				throw null;
			}

			// Token: 0x06001D55 RID: 7509 RVA: 0x000080F3 File Offset: 0x000062F3
			[global::Cpp2ILInjected.Token(Token = "0x600074F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EE706C", Offset = "0x1EE706C", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Base64Stream.ReadAsyncResult), Member = "Read", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Base64Stream.ReadAsyncResult), Member = "OnRead", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Base64Stream), Member = "DecodeBytes", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LazyAsyncResult), Member = "InvokeCallback", ReturnType = typeof(void))]
			private bool CompleteRead(IAsyncResult result)
			{
				throw null;
			}

			// Token: 0x06001D56 RID: 7510 RVA: 0x000080F6 File Offset: 0x000062F6
			[global::Cpp2ILInjected.Token(Token = "0x6000750")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EE5BB4", Offset = "0x1EE5BB4", Length = "0x124")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Base64Stream.ReadAsyncResult), Member = "OnRead", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Base64Stream), Member = "BeginRead", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(int),
				typeof(int),
				typeof(AsyncCallback),
				typeof(object)
			}, ReturnType = typeof(IAsyncResult))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Base64Stream.ReadAsyncResult), Member = "CompleteRead", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			internal void Read()
			{
				throw null;
			}

			// Token: 0x06001D57 RID: 7511 RVA: 0x000080F9 File Offset: 0x000062F9
			[global::Cpp2ILInjected.Token(Token = "0x6000751")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EE70D0", Offset = "0x1EE70D0", Length = "0x1EC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Base64Stream.ReadAsyncResult), Member = "CompleteRead", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Base64Stream.ReadAsyncResult), Member = "Read", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LazyAsyncResult), Member = "get_IsCompleted", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LazyAsyncResult), Member = "InvokeCallback", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
			private static void OnRead(IAsyncResult result)
			{
				throw null;
			}

			// Token: 0x06001D58 RID: 7512 RVA: 0x000080FC File Offset: 0x000062FC
			[global::Cpp2ILInjected.Token(Token = "0x6000752")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EE6A3C", Offset = "0x1EE6A3C", Length = "0x6C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LazyAsyncResult), Member = "InternalWaitForCompletion", ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal static int End(IAsyncResult result)
			{
				throw null;
			}

			// Token: 0x06001D59 RID: 7513 RVA: 0x000080FF File Offset: 0x000062FF
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x6000753")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EE72BC", Offset = "0x1EE72BC", Length = "0x94")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncCallback), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			static ReadAsyncResult()
			{
				throw null;
			}

			// Token: 0x04001129 RID: 4393
			[global::Cpp2ILInjected.Token(Token = "0x40005DB")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
			private readonly Base64Stream _parent;

			// Token: 0x0400112A RID: 4394
			[global::Cpp2ILInjected.Token(Token = "0x40005DC")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
			private readonly byte[] _buffer;

			// Token: 0x0400112B RID: 4395
			[global::Cpp2ILInjected.Token(Token = "0x40005DD")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
			private readonly int _offset;

			// Token: 0x0400112C RID: 4396
			[global::Cpp2ILInjected.Token(Token = "0x40005DE")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
			private readonly int _count;

			// Token: 0x0400112D RID: 4397
			[global::Cpp2ILInjected.Token(Token = "0x40005DF")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
			private int _read;

			// Token: 0x0400112E RID: 4398
			[global::Cpp2ILInjected.Token(Token = "0x40005E0")]
			private static readonly AsyncCallback s_onRead;
		}

		// Token: 0x020003CB RID: 971
		[global::Cpp2ILInjected.Token(Token = "0x2000136")]
		private sealed class WriteAsyncResult : LazyAsyncResult
		{
			// Token: 0x06001D5A RID: 7514 RVA: 0x00008102 File Offset: 0x00006302
			[global::Cpp2ILInjected.Token(Token = "0x6000754")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EE5E2C", Offset = "0x1EE5E2C", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LazyAsyncResult), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(object),
				typeof(AsyncCallback)
			}, ReturnType = typeof(void))]
			internal WriteAsyncResult(Base64Stream parent, byte[] buffer, int offset, int count, AsyncCallback callback, object state)
			{
				throw null;
			}

			// Token: 0x06001D5B RID: 7515 RVA: 0x00008105 File Offset: 0x00006305
			[global::Cpp2ILInjected.Token(Token = "0x6000755")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EE5E78", Offset = "0x1EE5E78", Length = "0x19C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Base64Stream.WriteAsyncResult), Member = "OnWrite", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Base64Stream), Member = "BeginWrite", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(int),
				typeof(int),
				typeof(AsyncCallback),
				typeof(object)
			}, ReturnType = typeof(IAsyncResult))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Base64Stream), Member = "EncodeBytes", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(int),
				typeof(int),
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WriteStateInfoBase), Member = "Reset", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LazyAsyncResult), Member = "InvokeCallback", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			internal void Write()
			{
				throw null;
			}

			// Token: 0x06001D5C RID: 7516 RVA: 0x00008108 File Offset: 0x00006308
			[global::Cpp2ILInjected.Token(Token = "0x6000756")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EE7350", Offset = "0x1EE7350", Length = "0x34")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WriteStateInfoBase), Member = "Reset", ReturnType = typeof(void))]
			private void CompleteWrite(IAsyncResult result)
			{
				throw null;
			}

			// Token: 0x06001D5D RID: 7517 RVA: 0x0000810B File Offset: 0x0000630B
			[global::Cpp2ILInjected.Token(Token = "0x6000757")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EE7384", Offset = "0x1EE7384", Length = "0x208")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WriteStateInfoBase), Member = "Reset", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Base64Stream.WriteAsyncResult), Member = "Write", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LazyAsyncResult), Member = "get_IsCompleted", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LazyAsyncResult), Member = "InvokeCallback", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
			private static void OnWrite(IAsyncResult result)
			{
				throw null;
			}

			// Token: 0x06001D5E RID: 7518 RVA: 0x0000810E File Offset: 0x0000630E
			[global::Cpp2ILInjected.Token(Token = "0x6000758")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EE6B48", Offset = "0x1EE6B48", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LazyAsyncResult), Member = "InternalWaitForCompletion", ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal static void End(IAsyncResult result)
			{
				throw null;
			}

			// Token: 0x06001D5F RID: 7519 RVA: 0x00008111 File Offset: 0x00006311
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x6000759")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EE758C", Offset = "0x1EE758C", Length = "0x94")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncCallback), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			static WriteAsyncResult()
			{
				throw null;
			}

			// Token: 0x0400112F RID: 4399
			[global::Cpp2ILInjected.Token(Token = "0x40005E1")]
			private static readonly AsyncCallback s_onWrite;

			// Token: 0x04001130 RID: 4400
			[global::Cpp2ILInjected.Token(Token = "0x40005E2")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
			private readonly Base64Stream _parent;

			// Token: 0x04001131 RID: 4401
			[global::Cpp2ILInjected.Token(Token = "0x40005E3")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
			private readonly byte[] _buffer;

			// Token: 0x04001132 RID: 4402
			[global::Cpp2ILInjected.Token(Token = "0x40005E4")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
			private readonly int _offset;

			// Token: 0x04001133 RID: 4403
			[global::Cpp2ILInjected.Token(Token = "0x40005E5")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
			private readonly int _count;

			// Token: 0x04001134 RID: 4404
			[global::Cpp2ILInjected.Token(Token = "0x40005E6")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
			private int _written;
		}

		// Token: 0x020003CC RID: 972
		[global::Cpp2ILInjected.Token(Token = "0x2000137")]
		private sealed class ReadStateInfo
		{
			// Token: 0x1700072B RID: 1835
			// (get) Token: 0x06001D60 RID: 7520 RVA: 0x00008114 File Offset: 0x00006314
			// (set) Token: 0x06001D61 RID: 7521 RVA: 0x00008117 File Offset: 0x00006317
			[global::Cpp2ILInjected.Token(Token = "0x17000186")]
			internal byte Val
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x600075A")]
				[global::Cpp2ILInjected.Address(RVA = "0x1EE7620", Offset = "0x1EE7620", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x600075B")]
				[global::Cpp2ILInjected.Address(RVA = "0x1EE7628", Offset = "0x1EE7628", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			// Token: 0x1700072C RID: 1836
			// (get) Token: 0x06001D62 RID: 7522 RVA: 0x0000811A File Offset: 0x0000631A
			// (set) Token: 0x06001D63 RID: 7523 RVA: 0x0000811D File Offset: 0x0000631D
			[global::Cpp2ILInjected.Token(Token = "0x17000187")]
			internal byte Pos
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x600075C")]
				[global::Cpp2ILInjected.Address(RVA = "0x1EE7630", Offset = "0x1EE7630", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x600075D")]
				[global::Cpp2ILInjected.Address(RVA = "0x1EE7638", Offset = "0x1EE7638", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			// Token: 0x06001D64 RID: 7524 RVA: 0x00008120 File Offset: 0x00006320
			[global::Cpp2ILInjected.Token(Token = "0x600075E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EE5A04", Offset = "0x1EE5A04", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public ReadStateInfo()
			{
				throw null;
			}

			// Token: 0x04001135 RID: 4405
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x40005E7")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private byte <Val>k__BackingField;

			// Token: 0x04001136 RID: 4406
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x40005E8")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x11")]
			private byte <Pos>k__BackingField;
		}
	}
}
