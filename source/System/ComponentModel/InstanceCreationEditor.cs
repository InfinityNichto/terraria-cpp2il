using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	// Token: 0x02000295 RID: 661
	[global::Cpp2ILInjected.Token(Token = "0x200038C")]
	public abstract class InstanceCreationEditor
	{
		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x06001563 RID: 5475 RVA: 0x00006A6D File Offset: 0x00004C6D
		[global::Cpp2ILInjected.Token(Token = "0x17000568")]
		public virtual string Text
		{
			[global::Cpp2ILInjected.Token(Token = "0x60017AE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E4D0DC", Offset = "0x1E4D0DC", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001564 RID: 5476
		[global::Cpp2ILInjected.Token(Token = "0x60017AF")]
		public abstract object CreateInstance(ITypeDescriptorContext context, Type instanceType);

		// Token: 0x06001565 RID: 5477 RVA: 0x00006A70 File Offset: 0x00004C70
		[global::Cpp2ILInjected.Token(Token = "0x60017B0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4D11C", Offset = "0x1E4D11C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected InstanceCreationEditor()
		{
			throw null;
		}
	}
}
