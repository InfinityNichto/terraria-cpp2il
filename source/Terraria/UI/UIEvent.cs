using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.UI
{
	[global::Cpp2ILInjected.Token(Token = "0x2000723")]
	public class UIEvent
	{
		[global::Cpp2ILInjected.Token(Token = "0x6003C91")]
		[global::Cpp2ILInjected.Address(RVA = "0x1491EAC", Offset = "0x1491EAC", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public UIEvent(UIElement target)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4007BB3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public readonly UIElement Target;
	}
}
