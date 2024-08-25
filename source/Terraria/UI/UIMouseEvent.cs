using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

namespace Terraria.UI
{
	[global::Cpp2ILInjected.Token(Token = "0x2000724")]
	public class UIMouseEvent : UIEvent
	{
		[global::Cpp2ILInjected.Token(Token = "0x6003C92")]
		[global::Cpp2ILInjected.Address(RVA = "0x1491ED4", Offset = "0x1491ED4", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public UIMouseEvent(UIElement target, Vector2 mousePosition)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4007BB4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public readonly Vector2 MousePosition;
	}
}
