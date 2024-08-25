using System;
using Cpp2ILInjected;

namespace Microsoft.Xna.Framework
{
	[global::Cpp2ILInjected.Token(Token = "0x200033C")]
	public interface IDrawable
	{
		[global::Cpp2ILInjected.Token(Token = "0x1700021A")]
		int DrawOrder
		{
			[global::Cpp2ILInjected.Token(Token = "0x60014E7")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700021B")]
		bool Visible
		{
			[global::Cpp2ILInjected.Token(Token = "0x60014E8")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1400000E")]
		event EventHandler<EventArgs> DrawOrderChanged;

		[global::Cpp2ILInjected.Token(Token = "0x1400000F")]
		event EventHandler<EventArgs> VisibleChanged;

		[global::Cpp2ILInjected.Token(Token = "0x60014ED")]
		void Draw(GameTime gameTime);
	}
}
