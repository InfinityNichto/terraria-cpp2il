using System;
using System.Globalization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Reflection
{
	// Token: 0x02000449 RID: 1097
	[global::Cpp2ILInjected.Token(Token = "0x200050B")]
	internal abstract class RtFieldInfo : FieldInfo
	{
		// Token: 0x06002300 RID: 8960
		[global::Cpp2ILInjected.Token(Token = "0x600259E")]
		internal abstract object UnsafeGetValue(object obj);

		// Token: 0x06002301 RID: 8961
		[global::Cpp2ILInjected.Token(Token = "0x600259F")]
		internal abstract void UnsafeSetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, global::System.Globalization.CultureInfo culture);

		// Token: 0x06002302 RID: 8962
		[global::Cpp2ILInjected.Token(Token = "0x60025A0")]
		internal abstract void CheckConsistency(object target);

		// Token: 0x06002303 RID: 8963 RVA: 0x0001A66F File Offset: 0x0001886F
		[global::Cpp2ILInjected.Token(Token = "0x60025A1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8E028", Offset = "0x1B8E028", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FieldInfo), Member = ".ctor", ReturnType = typeof(void))]
		protected RtFieldInfo()
		{
			throw null;
		}
	}
}
