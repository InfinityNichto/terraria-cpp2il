using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net.NetworkInformation
{
	// Token: 0x020001BC RID: 444
	[global::Cpp2ILInjected.Token(Token = "0x200029E")]
	public abstract class IPAddressInformation
	{
		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x06001084 RID: 4228
		[global::Cpp2ILInjected.Token(Token = "0x17000442")]
		public abstract IPAddress Address
		{
			[global::Cpp2ILInjected.Token(Token = "0x600127D")]
			get;
		}

		// Token: 0x06001085 RID: 4229 RVA: 0x00005DAA File Offset: 0x00003FAA
		[global::Cpp2ILInjected.Token(Token = "0x600127E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E1C858", Offset = "0x1E1C858", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected IPAddressInformation()
		{
			throw null;
		}
	}
}
