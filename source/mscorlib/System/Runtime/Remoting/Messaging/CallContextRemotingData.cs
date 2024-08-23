using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x020002F2 RID: 754
	[global::Cpp2ILInjected.Token(Token = "0x2000397")]
	[global::System.Serializable]
	internal class CallContextRemotingData : global::System.ICloneable
	{
		// Token: 0x1700033D RID: 829
		// (get) Token: 0x06001B70 RID: 7024 RVA: 0x000191D2 File Offset: 0x000173D2
		// (set) Token: 0x06001B71 RID: 7025 RVA: 0x000191D5 File Offset: 0x000173D5
		[global::Cpp2ILInjected.Token(Token = "0x17000397")]
		internal string LogicalCallID
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001DA2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B4472C", Offset = "0x1B4472C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001DA3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B44734", Offset = "0x1B44734", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x06001B72 RID: 7026 RVA: 0x000191D8 File Offset: 0x000173D8
		[global::Cpp2ILInjected.Token(Token = "0x17000398")]
		internal bool HasInfo
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001DA4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B445C8", Offset = "0x1B445C8", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001B73 RID: 7027 RVA: 0x000191DB File Offset: 0x000173DB
		[global::Cpp2ILInjected.Token(Token = "0x6001DA5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B44508", Offset = "0x1B44508", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LogicalCallContext), Member = "Clone", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public object Clone()
		{
			throw null;
		}

		// Token: 0x06001B74 RID: 7028 RVA: 0x000191DE File Offset: 0x000173DE
		[global::Cpp2ILInjected.Token(Token = "0x6001DA6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B4473C", Offset = "0x1B4473C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public CallContextRemotingData()
		{
			throw null;
		}

		// Token: 0x04000C01 RID: 3073
		[global::Cpp2ILInjected.Token(Token = "0x4000EED")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string _logicalCallID;
	}
}
