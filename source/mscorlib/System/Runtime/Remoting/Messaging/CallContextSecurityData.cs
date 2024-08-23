using System;
using System.Security.Principal;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x020002F1 RID: 753
	[global::Cpp2ILInjected.Token(Token = "0x2000396")]
	[global::System.Serializable]
	internal class CallContextSecurityData : global::System.ICloneable
	{
		// Token: 0x1700033C RID: 828
		// (get) Token: 0x06001B6D RID: 7021 RVA: 0x000191C9 File Offset: 0x000173C9
		[global::Cpp2ILInjected.Token(Token = "0x17000396")]
		internal bool HasInfo
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001D9F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B445D8", Offset = "0x1B445D8", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001B6E RID: 7022 RVA: 0x000191CC File Offset: 0x000173CC
		[global::Cpp2ILInjected.Token(Token = "0x6001DA0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B44568", Offset = "0x1B44568", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LogicalCallContext), Member = "Clone", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public object Clone()
		{
			throw null;
		}

		// Token: 0x06001B6F RID: 7023 RVA: 0x000191CF File Offset: 0x000173CF
		[global::Cpp2ILInjected.Token(Token = "0x6001DA1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B44724", Offset = "0x1B44724", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public CallContextSecurityData()
		{
			throw null;
		}

		// Token: 0x04000C00 RID: 3072
		[global::Cpp2ILInjected.Token(Token = "0x4000EEC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private global::System.Security.Principal.IPrincipal _principal;
	}
}
