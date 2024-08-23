using System;
using System.Globalization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Reflection
{
	// Token: 0x0200040B RID: 1035
	[global::Cpp2ILInjected.Token(Token = "0x20004C9")]
	public abstract class Binder
	{
		// Token: 0x060020D2 RID: 8402 RVA: 0x0001A102 File Offset: 0x00018302
		[global::Cpp2ILInjected.Token(Token = "0x600236A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B80814", Offset = "0x1B80814", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DefaultBinder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected Binder()
		{
			throw null;
		}

		// Token: 0x060020D3 RID: 8403
		[global::Cpp2ILInjected.Token(Token = "0x600236B")]
		public abstract FieldInfo BindToField(BindingFlags bindingAttr, FieldInfo[] match, object value, global::System.Globalization.CultureInfo culture);

		// Token: 0x060020D4 RID: 8404
		[global::Cpp2ILInjected.Token(Token = "0x600236C")]
		public abstract MethodBase BindToMethod(BindingFlags bindingAttr, MethodBase[] match, ref object[] args, ParameterModifier[] modifiers, global::System.Globalization.CultureInfo culture, string[] names, out object state);

		// Token: 0x060020D5 RID: 8405
		[global::Cpp2ILInjected.Token(Token = "0x600236D")]
		public abstract object ChangeType(object value, global::System.Type type, global::System.Globalization.CultureInfo culture);

		// Token: 0x060020D6 RID: 8406
		[global::Cpp2ILInjected.Token(Token = "0x600236E")]
		public abstract void ReorderArgumentArray(ref object[] args, object state);

		// Token: 0x060020D7 RID: 8407
		[global::Cpp2ILInjected.Token(Token = "0x600236F")]
		public abstract MethodBase SelectMethod(BindingFlags bindingAttr, MethodBase[] match, global::System.Type[] types, ParameterModifier[] modifiers);

		// Token: 0x060020D8 RID: 8408
		[global::Cpp2ILInjected.Token(Token = "0x6002370")]
		public abstract PropertyInfo SelectProperty(BindingFlags bindingAttr, PropertyInfo[] match, global::System.Type returnType, global::System.Type[] indexes, ParameterModifier[] modifiers);
	}
}
