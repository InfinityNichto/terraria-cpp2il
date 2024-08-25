using System;
using Cpp2ILInjected;

namespace Microsoft.Xna.Framework
{
	[global::Cpp2ILInjected.Token(Token = "0x200033E")]
	public interface IUpdateable
	{
		[global::Cpp2ILInjected.Token(Token = "0x60014EF")]
		void Update(GameTime gameTime);

		[global::Cpp2ILInjected.Token(Token = "0x14000010")]
		event EventHandler<EventArgs> EnabledChanged;

		[global::Cpp2ILInjected.Token(Token = "0x14000011")]
		event EventHandler<EventArgs> UpdateOrderChanged;

		[global::Cpp2ILInjected.Token(Token = "0x1700021C")]
		bool Enabled
		{
			[global::Cpp2ILInjected.Token(Token = "0x60014F4")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700021D")]
		int UpdateOrder
		{
			[global::Cpp2ILInjected.Token(Token = "0x60014F5")]
			get;
		}
	}
}
