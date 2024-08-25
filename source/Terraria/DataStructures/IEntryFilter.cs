using System;
using Cpp2ILInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.UI;

namespace Terraria.DataStructures
{
	[global::Cpp2ILInjected.Token(Token = "0x2000625")]
	public interface IEntryFilter<T>
	{
		[global::Cpp2ILInjected.Token(Token = "0x60035F1")]
		bool FitsFilter(T entry);

		[global::Cpp2ILInjected.Token(Token = "0x60035F2")]
		string GetDisplayNameKey();

		[global::Cpp2ILInjected.Token(Token = "0x60035F3")]
		UIElement GetImage();

		[global::Cpp2ILInjected.Token(Token = "0x60035F4")]
		void GetDisplay(out Texture2D texture, out Rectangle frame);
	}
}
