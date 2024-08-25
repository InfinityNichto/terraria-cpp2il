using System;
using Cpp2ILInjected;

namespace Terraria.Map
{
	[global::Cpp2ILInjected.Token(Token = "0x20006B8")]
	public interface IMapLayer
	{
		[global::Cpp2ILInjected.Token(Token = "0x600390E")]
		void Draw(ref MapOverlayDrawContext context, ref string text);
	}
}
