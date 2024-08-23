using System;
using System.IO;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x02000179 RID: 377
	[global::Cpp2ILInjected.Token(Token = "0x200021C")]
	internal sealed class FileWebStream : FileStream, ICloseEx
	{
		// Token: 0x06000C22 RID: 3106 RVA: 0x000050C6 File Offset: 0x000032C6
		[global::Cpp2ILInjected.Token(Token = "0x6000D80")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F37E54", Offset = "0x1F37E54", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileWebRequest), Member = "GetRequestStreamCallback", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(FileMode),
			typeof(FileAccess),
			typeof(FileShare)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public FileWebStream(FileWebRequest request, string path, FileMode mode, FileAccess access, FileShare sharing)
		{
			throw null;
		}

		// Token: 0x06000C23 RID: 3107 RVA: 0x000050C9 File Offset: 0x000032C9
		[global::Cpp2ILInjected.Token(Token = "0x6000D81")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F38A78", Offset = "0x1F38A78", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileWebResponse), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(FileWebRequest),
			typeof(Uri),
			typeof(FileAccess),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(FileMode),
			typeof(FileAccess),
			typeof(FileShare),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public FileWebStream(FileWebRequest request, string path, FileMode mode, FileAccess access, FileShare sharing, int length, bool async)
		{
			throw null;
		}

		// Token: 0x06000C24 RID: 3108 RVA: 0x000050CC File Offset: 0x000032CC
		[global::Cpp2ILInjected.Token(Token = "0x6000D82")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F38B2C", Offset = "0x1F38B2C", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileWebRequest), Member = "UnblockReader", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileStream), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		protected override void Dispose(bool disposing)
		{
			throw null;
		}

		// Token: 0x06000C25 RID: 3109 RVA: 0x000050CF File Offset: 0x000032CF
		[global::Cpp2ILInjected.Token(Token = "0x6000D83")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F38BDC", Offset = "0x1F38BDC", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeHandle), Member = "Close", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void System.Net.ICloseEx.CloseEx(CloseExState closeState)
		{
			throw null;
		}

		// Token: 0x06000C26 RID: 3110 RVA: 0x000050D2 File Offset: 0x000032D2
		[global::Cpp2ILInjected.Token(Token = "0x6000D84")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F38C10", Offset = "0x1F38C10", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileWebStream), Member = "CheckError", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileStream), Member = "Read", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public override int Read(byte[] buffer, int offset, int size)
		{
			throw null;
		}

		// Token: 0x06000C27 RID: 3111 RVA: 0x000050D5 File Offset: 0x000032D5
		[global::Cpp2ILInjected.Token(Token = "0x6000D85")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F38D4C", Offset = "0x1F38D4C", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileWebStream), Member = "CheckError", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileStream), Member = "Write", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public override void Write(byte[] buffer, int offset, int size)
		{
			throw null;
		}

		// Token: 0x06000C28 RID: 3112 RVA: 0x000050D8 File Offset: 0x000032D8
		[global::Cpp2ILInjected.Token(Token = "0x6000D86")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F38E14", Offset = "0x1F38E14", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileWebStream), Member = "CheckError", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileStream), Member = "BeginRead", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public override IAsyncResult BeginRead(byte[] buffer, int offset, int size, AsyncCallback callback, object state)
		{
			throw null;
		}

		// Token: 0x06000C29 RID: 3113 RVA: 0x000050DB File Offset: 0x000032DB
		[global::Cpp2ILInjected.Token(Token = "0x6000D87")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F38EF4", Offset = "0x1F38EF4", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileStream), Member = "EndRead", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileWebStream), Member = "CheckError", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public override int EndRead(IAsyncResult ar)
		{
			throw null;
		}

		// Token: 0x06000C2A RID: 3114 RVA: 0x000050DE File Offset: 0x000032DE
		[global::Cpp2ILInjected.Token(Token = "0x6000D88")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F38F94", Offset = "0x1F38F94", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileWebStream), Member = "CheckError", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileStream), Member = "BeginWrite", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int size, AsyncCallback callback, object state)
		{
			throw null;
		}

		// Token: 0x06000C2B RID: 3115 RVA: 0x000050E1 File Offset: 0x000032E1
		[global::Cpp2ILInjected.Token(Token = "0x6000D89")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F39074", Offset = "0x1F39074", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileStream), Member = "EndWrite", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileWebStream), Member = "CheckError", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public override void EndWrite(IAsyncResult ar)
		{
			throw null;
		}

		// Token: 0x06000C2C RID: 3116 RVA: 0x000050E4 File Offset: 0x000032E4
		[global::Cpp2ILInjected.Token(Token = "0x6000D8A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F38CD8", Offset = "0x1F38CD8", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileWebStream), Member = "Read", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileWebStream), Member = "Write", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileWebStream), Member = "BeginRead", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileWebStream), Member = "EndRead", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileWebStream), Member = "BeginWrite", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileWebStream), Member = "EndWrite", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetRes), Member = "GetWebStatusString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(WebExceptionStatus)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(WebExceptionStatus)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void CheckError()
		{
			throw null;
		}

		// Token: 0x040008F9 RID: 2297
		[global::Cpp2ILInjected.Token(Token = "0x4000B66")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private FileWebRequest m_request;
	}
}
