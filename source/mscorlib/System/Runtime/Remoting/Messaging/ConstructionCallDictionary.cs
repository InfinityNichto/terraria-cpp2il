using System;
using System.Runtime.Remoting.Activation;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x020002FF RID: 767
	[global::Cpp2ILInjected.Token(Token = "0x20003A4")]
	internal class ConstructionCallDictionary : MessageDictionary
	{
		// Token: 0x06001BC0 RID: 7104 RVA: 0x000192BF File Offset: 0x000174BF
		[global::Cpp2ILInjected.Token(Token = "0x6001DF2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B47F48", Offset = "0x1B47F48", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ConstructionCall), Member = "InitDictionary", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public ConstructionCallDictionary(global::System.Runtime.Remoting.Activation.IConstructionCallMessage message)
		{
			throw null;
		}

		// Token: 0x06001BC1 RID: 7105 RVA: 0x000192C2 File Offset: 0x000174C2
		[global::Cpp2ILInjected.Token(Token = "0x6001DF3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B48ECC", Offset = "0x1B48ECC", Length = "0x3C4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		protected override object GetMethodProperty(string key)
		{
			throw null;
		}

		// Token: 0x06001BC2 RID: 7106 RVA: 0x000192C5 File Offset: 0x000174C5
		[global::Cpp2ILInjected.Token(Token = "0x6001DF4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B497E0", Offset = "0x1B497E0", Length = "0x260")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		protected override void SetMethodProperty(string key, object value)
		{
			throw null;
		}

		// Token: 0x06001BC3 RID: 7107 RVA: 0x000192C8 File Offset: 0x000174C8
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6001DF5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B49D1C", Offset = "0x1B49D1C", Length = "0x2B8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 27)]
		static ConstructionCallDictionary()
		{
			throw null;
		}

		// Token: 0x04000C34 RID: 3124
		[global::Cpp2ILInjected.Token(Token = "0x4000F20")]
		public static string[] InternalKeys;
	}
}
