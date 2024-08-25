using System;
using System.Globalization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Reflection
{
	[global::Cpp2ILInjected.Token(Token = "0x20004C9")]
	public abstract class Binder
	{
		[global::Cpp2ILInjected.Token(Token = "0x600236A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B80814", Offset = "0x1B80814", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DefaultBinder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected Binder()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600236B")]
		public abstract FieldInfo BindToField(BindingFlags bindingAttr, FieldInfo[] match, object value, global::System.Globalization.CultureInfo culture);

		[global::Cpp2ILInjected.Token(Token = "0x600236C")]
		public abstract MethodBase BindToMethod(BindingFlags bindingAttr, MethodBase[] match, ref object[] args, ParameterModifier[] modifiers, global::System.Globalization.CultureInfo culture, string[] names, out object state);

		[global::Cpp2ILInjected.Token(Token = "0x600236D")]
		public abstract object ChangeType(object value, global::System.Type type, global::System.Globalization.CultureInfo culture);

		[global::Cpp2ILInjected.Token(Token = "0x600236E")]
		public abstract void ReorderArgumentArray(ref object[] args, object state);

		[global::Cpp2ILInjected.Token(Token = "0x600236F")]
		public abstract MethodBase SelectMethod(BindingFlags bindingAttr, MethodBase[] match, global::System.Type[] types, ParameterModifier[] modifiers);

		[global::Cpp2ILInjected.Token(Token = "0x6002370")]
		public abstract PropertyInfo SelectProperty(BindingFlags bindingAttr, PropertyInfo[] match, global::System.Type returnType, global::System.Type[] indexes, ParameterModifier[] modifiers);
	}
}
