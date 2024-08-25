using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

namespace Terraria.UI
{
	[global::Cpp2ILInjected.Token(Token = "0x2000725")]
	public class UIScrollWheelEvent : UIMouseEvent
	{
		[global::Cpp2ILInjected.Token(Token = "0x6003C93")]
		[global::Cpp2ILInjected.Address(RVA = "0x1491F10", Offset = "0x1491F10", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public UIScrollWheelEvent(UIElement target, Vector2 mousePosition, int scrollWheelValue)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4007BB5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public readonly int ScrollWheelValue;
	}
}
