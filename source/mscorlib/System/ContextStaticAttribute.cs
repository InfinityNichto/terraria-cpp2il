using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	[global::System.AttributeUsage(global::System.AttributeTargets.Field, Inherited = false)]
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000148")]
	[global::System.Serializable]
	public class ContextStaticAttribute : global::System.Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000CFD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C608B4", Offset = "0x1C608B4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public ContextStaticAttribute()
		{
			throw null;
		}
	}
}
