using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Remoting.Channels
{
	// Token: 0x020002D3 RID: 723
	[global::Cpp2ILInjected.Token(Token = "0x2000376")]
	[global::System.Serializable]
	internal class CrossAppDomainData
	{
		// Token: 0x06001AFD RID: 6909 RVA: 0x000190AF File Offset: 0x000172AF
		[global::Cpp2ILInjected.Token(Token = "0x6001D2A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B3FF8C", Offset = "0x1B3FF8C", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjRef), Member = "DeserializeInTheCurrentDomain", MemberParameters = new object[]
		{
			typeof(int),
			typeof(byte[])
		}, ReturnType = typeof(ObjRef))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CrossAppDomainChannel), Member = "get_ChannelData", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RemotingConfiguration), Member = "get_ProcessId", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal CrossAppDomainData(int domainId)
		{
			throw null;
		}

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06001AFE RID: 6910 RVA: 0x000190B2 File Offset: 0x000172B2
		[global::Cpp2ILInjected.Token(Token = "0x17000369")]
		internal int DomainID
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001D2B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B40034", Offset = "0x1B40034", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x06001AFF RID: 6911 RVA: 0x000190B5 File Offset: 0x000172B5
		[global::Cpp2ILInjected.Token(Token = "0x1700036A")]
		internal string ProcessID
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001D2C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B4003C", Offset = "0x1B4003C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x04000BD2 RID: 3026
		[global::Cpp2ILInjected.Token(Token = "0x4000EBB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private object _ContextID;

		// Token: 0x04000BD3 RID: 3027
		[global::Cpp2ILInjected.Token(Token = "0x4000EBC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int _DomainID;

		// Token: 0x04000BD4 RID: 3028
		[global::Cpp2ILInjected.Token(Token = "0x4000EBD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private string _processGuid;
	}
}
