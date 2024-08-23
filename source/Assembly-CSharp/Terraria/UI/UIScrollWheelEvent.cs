using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

namespace Terraria.UI
{
	// Token: 0x020004D4 RID: 1236
	[global::Cpp2ILInjected.Token(Token = "0x2000725")]
	public class UIScrollWheelEvent : UIMouseEvent
	{
		// Token: 0x06003643 RID: 13891 RVA: 0x0002BB11 File Offset: 0x00029D11
		[global::Cpp2ILInjected.Token(Token = "0x6003C93")]
		[global::Cpp2ILInjected.Address(RVA = "0x1491F10", Offset = "0x1491F10", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public UIScrollWheelEvent(UIElement target, Vector2 mousePosition, int scrollWheelValue)
		{
			throw null;
		}

		// Token: 0x040066E9 RID: 26345
		[global::Cpp2ILInjected.Token(Token = "0x4007BB5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public readonly int ScrollWheelValue;
	}
}
