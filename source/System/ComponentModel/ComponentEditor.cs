using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	// Token: 0x02000259 RID: 601
	[global::Cpp2ILInjected.Token(Token = "0x200034D")]
	public abstract class ComponentEditor
	{
		// Token: 0x060013B7 RID: 5047 RVA: 0x0000667D File Offset: 0x0000487D
		[global::Cpp2ILInjected.Token(Token = "0x60015F9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3F150", Offset = "0x1E3F150", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public bool EditComponent(object component)
		{
			throw null;
		}

		// Token: 0x060013B8 RID: 5048
		[global::Cpp2ILInjected.Token(Token = "0x60015FA")]
		public abstract bool EditComponent(ITypeDescriptorContext context, object component);

		// Token: 0x060013B9 RID: 5049 RVA: 0x00006680 File Offset: 0x00004880
		[global::Cpp2ILInjected.Token(Token = "0x60015FB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3F164", Offset = "0x1E3F164", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected ComponentEditor()
		{
			throw null;
		}
	}
}
