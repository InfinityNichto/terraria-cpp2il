using System;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Mono.Net.Security
{
	// Token: 0x02000014 RID: 20
	[global::Cpp2ILInjected.Token(Token = "0x200004C")]
	internal class AsyncProtocolResult
	{
		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000064 RID: 100 RVA: 0x00002F5A File Offset: 0x0000115A
		[global::Cpp2ILInjected.Token(Token = "0x1700001A")]
		public int UserResult
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60000C3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D47B8C", Offset = "0x1D47B8C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000065 RID: 101 RVA: 0x00002F5D File Offset: 0x0000115D
		[global::Cpp2ILInjected.Token(Token = "0x1700001B")]
		public ExceptionDispatchInfo Error
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60000C4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D47B94", Offset = "0x1D47B94", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00002F60 File Offset: 0x00001160
		[global::Cpp2ILInjected.Token(Token = "0x60000C5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D47B9C", Offset = "0x1D47B9C", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public AsyncProtocolResult(int result)
		{
			throw null;
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00002F63 File Offset: 0x00001163
		[global::Cpp2ILInjected.Token(Token = "0x60000C6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D47BC4", Offset = "0x1D47BC4", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public AsyncProtocolResult(ExceptionDispatchInfo error)
		{
			throw null;
		}

		// Token: 0x0400002A RID: 42
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40000A6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly int <UserResult>k__BackingField;

		// Token: 0x0400002B RID: 43
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40000A7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly ExceptionDispatchInfo <Error>k__BackingField;
	}
}
