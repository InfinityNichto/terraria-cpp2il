using System;
using System.IO;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	[global::Cpp2ILInjected.Token(Token = "0x2000232")]
	internal class ChunkedInputStream : RequestStream
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000E1A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F3F38C", Offset = "0x1F3F38C", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpConnection), Member = "GetRequestStream", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(long)
		}, ReturnType = typeof(RequestStream))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RequestStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoChunkParser), Member = ".ctor", MemberParameters = new object[] { typeof(WebHeaderCollection) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public ChunkedInputStream(HttpListenerContext context, Stream stream, byte[] buffer, int offset, int length)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002F1")]
		public MonoChunkParser Decoder
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000E1B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F3F480", Offset = "0x1F3F480", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000E1C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F3F488", Offset = "0x1F3F488", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000E1D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F3F490", Offset = "0x1F3F490", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override int Read([In] [Out] byte[] buffer, int offset, int count)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000E1E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F3F4CC", Offset = "0x1F3F4CC", Length = "0x2D8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpStreamAsyncResult), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoChunkParser), Member = "Read", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoChunkParser), Member = "get_WantMore", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncCallback), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RequestStream), Member = "BeginRead", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpStreamAsyncResult), Member = "Complete", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 23)]
		public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback cback, object state)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000E1F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F3F94C", Offset = "0x1F3F94C", Length = "0x33C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RequestStream), Member = "EndRead", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoChunkParser), Member = "Write", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoChunkParser), Member = "Read", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoChunkParser), Member = "get_WantMore", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoChunkParser), Member = "get_ChunkLeft", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Min", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncCallback), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RequestStream), Member = "BeginRead", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpStreamAsyncResult), Member = "Complete", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpConnection), Member = "SendError", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		private void OnRead(IAsyncResult base_ares)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000E20")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F3FE30", Offset = "0x1F3FE30", Length = "0x268")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpListenerException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public override int EndRead(IAsyncResult ares)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000E21")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F40098", Offset = "0x1F40098", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RequestStream), Member = "Close", ReturnType = typeof(void))]
		public override void Close()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000BBB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private bool disposed;

		[global::Cpp2ILInjected.Token(Token = "0x4000BBC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private MonoChunkParser decoder;

		[global::Cpp2ILInjected.Token(Token = "0x4000BBD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private HttpListenerContext context;

		[global::Cpp2ILInjected.Token(Token = "0x4000BBE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private bool no_more_data;

		[global::Cpp2ILInjected.Token(Token = "0x2000233")]
		private class ReadBufferState
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000E22")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F3F904", Offset = "0x1F3F904", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public ReadBufferState(byte[] buffer, int offset, int count, HttpStreamAsyncResult ares)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4000BBF")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public byte[] Buffer;

			[global::Cpp2ILInjected.Token(Token = "0x4000BC0")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public int Offset;

			[global::Cpp2ILInjected.Token(Token = "0x4000BC1")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
			public int Count;

			[global::Cpp2ILInjected.Token(Token = "0x4000BC2")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public int InitialCount;

			[global::Cpp2ILInjected.Token(Token = "0x4000BC3")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public HttpStreamAsyncResult Ares;
		}
	}
}
