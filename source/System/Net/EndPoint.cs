using System;
using System.Net.Sockets;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x02000109 RID: 265
	[global::Cpp2ILInjected.Token(Token = "0x200018E")]
	[Serializable]
	public abstract class EndPoint
	{
		// Token: 0x17000208 RID: 520
		// (get) Token: 0x06000932 RID: 2354 RVA: 0x00004859 File Offset: 0x00002A59
		[global::Cpp2ILInjected.Token(Token = "0x17000213")]
		public virtual AddressFamily AddressFamily
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A41")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F0C1C4", Offset = "0x1F0C1C4", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExceptionHelper), Member = "get_PropertyNotImplementedException", ReturnType = typeof(NotImplementedException))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000933 RID: 2355 RVA: 0x0000485C File Offset: 0x00002A5C
		[global::Cpp2ILInjected.Token(Token = "0x6000A42")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F0C268", Offset = "0x1F0C268", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExceptionHelper), Member = "get_MethodNotImplementedException", ReturnType = typeof(NotImplementedException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual SocketAddress Serialize()
		{
			throw null;
		}

		// Token: 0x06000934 RID: 2356 RVA: 0x0000485F File Offset: 0x00002A5F
		[global::Cpp2ILInjected.Token(Token = "0x6000A43")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F0C30C", Offset = "0x1F0C30C", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExceptionHelper), Member = "get_MethodNotImplementedException", ReturnType = typeof(NotImplementedException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual EndPoint Create(SocketAddress socketAddress)
		{
			throw null;
		}

		// Token: 0x06000935 RID: 2357 RVA: 0x00004862 File Offset: 0x00002A62
		[global::Cpp2ILInjected.Token(Token = "0x6000A44")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F0BEC4", Offset = "0x1F0BEC4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IPEndPoint), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(long),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IPEndPoint), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(IPAddress),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected EndPoint()
		{
			throw null;
		}
	}
}
