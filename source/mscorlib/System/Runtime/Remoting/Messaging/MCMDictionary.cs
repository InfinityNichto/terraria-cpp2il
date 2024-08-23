using System;
using System.Collections;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x0200030D RID: 781
	[global::Cpp2ILInjected.Token(Token = "0x20003B2")]
	internal class MCMDictionary : MessageDictionary
	{
		// Token: 0x06001C07 RID: 7175 RVA: 0x00019355 File Offset: 0x00017555
		[global::Cpp2ILInjected.Token(Token = "0x6001E39")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B4AD64", Offset = "0x1B4AD64", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MethodCall), Member = "InitDictionary", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MonoMethodMessage), Member = "get_Properties", ReturnType = typeof(global::System.Collections.IDictionary))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public MCMDictionary(IMethodMessage message)
		{
			throw null;
		}

		// Token: 0x06001C08 RID: 7176 RVA: 0x00019358 File Offset: 0x00017558
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6001E3A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B4B0A0", Offset = "0x1B4B0A0", Length = "0x1B4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		static MCMDictionary()
		{
			throw null;
		}

		// Token: 0x04000C46 RID: 3142
		[global::Cpp2ILInjected.Token(Token = "0x4000F32")]
		public static string[] InternalKeys;
	}
}
