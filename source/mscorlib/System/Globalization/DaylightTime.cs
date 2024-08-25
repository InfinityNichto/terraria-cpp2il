using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Globalization
{
	[global::Cpp2ILInjected.Token(Token = "0x200058F")]
	[global::System.Serializable]
	public class DaylightTime
	{
		[global::Cpp2ILInjected.Token(Token = "0x6002B1A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BE1030", Offset = "0x1BE1030", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.CurrentSystemTimeZone), Member = "CreateDaylightChanges", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(DaylightTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public DaylightTime(global::System.DateTime start, global::System.DateTime end, global::System.TimeSpan delta)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000654")]
		public global::System.DateTime Start
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002B1B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BE106C", Offset = "0x1BE106C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000655")]
		public global::System.DateTime End
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002B1C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BE1074", Offset = "0x1BE1074", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000656")]
		public global::System.TimeSpan Delta
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002B1D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BE107C", Offset = "0x1BE107C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x4001770")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly global::System.DateTime _start;

		[global::Cpp2ILInjected.Token(Token = "0x4001771")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly global::System.DateTime _end;

		[global::Cpp2ILInjected.Token(Token = "0x4001772")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private readonly global::System.TimeSpan _delta;
	}
}
