using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.CompilerServices
{
	[global::System.AttributeUsage(global::System.AttributeTargets.Field | global::System.AttributeTargets.Parameter, Inherited = false)]
	[global::Cpp2ILInjected.Token(Token = "0x200046D")]
	[global::System.Serializable]
	public sealed class DateTimeConstantAttribute : CustomConstantAttribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x17000466")]
		public override object Value
		{
			[global::Cpp2ILInjected.Token(Token = "0x600220A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B73318", Offset = "0x1B73318", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x40012AE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private global::System.DateTime _date;
	}
}
