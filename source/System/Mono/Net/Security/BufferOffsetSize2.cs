using System;
using System.IO;
using System.Net.Security;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Security.Interface;

namespace Mono.Net.Security
{
	// Token: 0x02000012 RID: 18
	[global::Cpp2ILInjected.Token(Token = "0x200004A")]
	internal class BufferOffsetSize2 : BufferOffsetSize
	{
		// Token: 0x06000060 RID: 96 RVA: 0x00002F4E File Offset: 0x0000114E
		[global::Cpp2ILInjected.Token(Token = "0x60000BF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D479B8", Offset = "0x1D479B8", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MobileAuthenticatedStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(bool),
			typeof(SslStream),
			typeof(MonoTlsSettings),
			typeof(MobileTlsProvider)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BufferOffsetSize), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public BufferOffsetSize2(int size)
		{
			throw null;
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00002F51 File Offset: 0x00001151
		[global::Cpp2ILInjected.Token(Token = "0x60000C0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D47A28", Offset = "0x1D47A28", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Net.Security.MobileAuthenticatedStream.<ProcessAuthentication>d__48", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Net.Security.MobileAuthenticatedStream.<StartOperation>d__57", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MobileAuthenticatedStream), Member = "InternalWrite", MemberParameters = new object[]
		{
			typeof(AsyncProtocolRequest),
			typeof(BufferOffsetSize2),
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Reset()
		{
			throw null;
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00002F54 File Offset: 0x00001154
		[global::Cpp2ILInjected.Token(Token = "0x60000C1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D47A84", Offset = "0x1D47A84", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BufferOffsetSize2), Member = "AppendData", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "CopyTo", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void MakeRoom(int size)
		{
			throw null;
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00002F57 File Offset: 0x00001157
		[global::Cpp2ILInjected.Token(Token = "0x60000C2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D47B2C", Offset = "0x1D47B2C", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MobileAuthenticatedStream), Member = "InternalWrite", MemberParameters = new object[]
		{
			typeof(AsyncProtocolRequest),
			typeof(BufferOffsetSize2),
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BufferOffsetSize2), Member = "MakeRoom", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		public void AppendData(byte[] buffer, int offset, int size)
		{
			throw null;
		}

		// Token: 0x04000024 RID: 36
		[global::Cpp2ILInjected.Token(Token = "0x40000A0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public readonly int InitialSize;
	}
}
