using System;
using Cpp2ILInjected;

namespace Terraria.Map
{
	// Token: 0x020004A6 RID: 1190
	[global::Cpp2ILInjected.Token(Token = "0x20006B8")]
	public interface IMapLayer
	{
		// Token: 0x060033B7 RID: 13239
		[global::Cpp2ILInjected.Token(Token = "0x600390E")]
		void Draw(ref MapOverlayDrawContext context, ref string text);
	}
}
