using System;
using Cpp2ILInjected;

namespace Terraria.Graphics.Renderers
{
	[global::Cpp2ILInjected.Token(Token = "0x2000752")]
	public interface IPooledParticle : IParticle
	{
		[global::Cpp2ILInjected.Token(Token = "0x17000784")]
		bool IsRestingInPool
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003DB7")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003DB8")]
		void RestInPool();

		[global::Cpp2ILInjected.Token(Token = "0x6003DB9")]
		void FetchFromPool();
	}
}
