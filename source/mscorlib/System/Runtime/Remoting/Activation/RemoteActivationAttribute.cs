using System;
using System.Collections;
using System.Runtime.Remoting.Contexts;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Remoting.Activation
{
	// Token: 0x020002E7 RID: 743
	[global::Cpp2ILInjected.Token(Token = "0x200038B")]
	internal class RemoteActivationAttribute : global::System.Attribute, global::System.Runtime.Remoting.Contexts.IContextAttribute
	{
		// Token: 0x06001B3B RID: 6971 RVA: 0x00019133 File Offset: 0x00017333
		[global::Cpp2ILInjected.Token(Token = "0x6001D68")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B42690", Offset = "0x1B42690", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public RemoteActivationAttribute(global::System.Collections.IList contextProperties)
		{
			throw null;
		}

		// Token: 0x06001B3C RID: 6972 RVA: 0x00019136 File Offset: 0x00017336
		[global::Cpp2ILInjected.Token(Token = "0x6001D69")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B426B8", Offset = "0x1B426B8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool IsContextOK(global::System.Runtime.Remoting.Contexts.Context ctx, IConstructionCallMessage ctor)
		{
			throw null;
		}

		// Token: 0x06001B3D RID: 6973 RVA: 0x00019139 File Offset: 0x00017339
		[global::Cpp2ILInjected.Token(Token = "0x6001D6A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B426C0", Offset = "0x1B426C0", Length = "0x3C8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		public void GetPropertiesForNewContext(IConstructionCallMessage ctor)
		{
			throw null;
		}

		// Token: 0x04000BE2 RID: 3042
		[global::Cpp2ILInjected.Token(Token = "0x4000ECD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private global::System.Collections.IList _contextProperties;
	}
}
