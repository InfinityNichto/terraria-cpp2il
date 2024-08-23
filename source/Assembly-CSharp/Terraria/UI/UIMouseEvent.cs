using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

namespace Terraria.UI
{
	// Token: 0x020004D3 RID: 1235
	[global::Cpp2ILInjected.Token(Token = "0x2000724")]
	public class UIMouseEvent : UIEvent
	{
		// Token: 0x06003642 RID: 13890 RVA: 0x0002BB0E File Offset: 0x00029D0E
		[global::Cpp2ILInjected.Token(Token = "0x6003C92")]
		[global::Cpp2ILInjected.Address(RVA = "0x1491ED4", Offset = "0x1491ED4", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public UIMouseEvent(UIElement target, Vector2 mousePosition)
		{
			throw null;
		}

		// Token: 0x040066E8 RID: 26344
		[global::Cpp2ILInjected.Token(Token = "0x4007BB4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public readonly Vector2 MousePosition;
	}
}
