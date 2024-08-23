using System;
using System.Resources;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Serialization
{
	// Token: 0x02000346 RID: 838
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20003EE")]
	[global::System.Serializable]
	public readonly struct StreamingContext
	{
		// Token: 0x06001D89 RID: 7561 RVA: 0x000197A2 File Offset: 0x000179A2
		[global::Cpp2ILInjected.Token(Token = "0x6001FC7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5B348", Offset = "0x1B5B348", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Resources.ResourceReader), Member = "ReadResources", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public StreamingContext(StreamingContextStates state)
		{
			throw null;
		}

		// Token: 0x06001D8A RID: 7562 RVA: 0x000197A5 File Offset: 0x000179A5
		[global::Cpp2ILInjected.Token(Token = "0x6001FC8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5B354", Offset = "0x1B5B354", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.RemotingServices), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public StreamingContext(StreamingContextStates state, object additional)
		{
			throw null;
		}

		// Token: 0x06001D8B RID: 7563 RVA: 0x000197A8 File Offset: 0x000179A8
		[global::Cpp2ILInjected.Token(Token = "0x6001FC9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5B360", Offset = "0x1B5B360", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x06001D8C RID: 7564 RVA: 0x000197AB File Offset: 0x000179AB
		[global::Cpp2ILInjected.Token(Token = "0x6001FCA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5B410", Offset = "0x1B5B410", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x06001D8D RID: 7565 RVA: 0x000197AE File Offset: 0x000179AE
		[global::Cpp2ILInjected.Token(Token = "0x17000444")]
		public StreamingContextStates State
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001FCB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B5B418", Offset = "0x1B5B418", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x04000CE8 RID: 3304
		[global::Cpp2ILInjected.Token(Token = "0x4000FDA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		internal readonly object m_additionalContext;

		// Token: 0x04000CE9 RID: 3305
		[global::Cpp2ILInjected.Token(Token = "0x4000FDB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		internal readonly StreamingContextStates m_state;
	}
}
