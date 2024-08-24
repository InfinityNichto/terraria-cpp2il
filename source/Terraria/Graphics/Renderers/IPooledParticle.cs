using System;
using Cpp2ILInjected;

namespace Terraria.Graphics.Renderers
{
	// Token: 0x020004F6 RID: 1270
	[global::Cpp2ILInjected.Token(Token = "0x2000752")]
	public interface IPooledParticle : IParticle
	{
		// Token: 0x170006E9 RID: 1769
		// (get) Token: 0x06003740 RID: 14144
		[global::Cpp2ILInjected.Token(Token = "0x17000784")]
		bool IsRestingInPool
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003DB7")]
			get;
		}

		// Token: 0x06003741 RID: 14145
		[global::Cpp2ILInjected.Token(Token = "0x6003DB8")]
		void RestInPool();

		// Token: 0x06003742 RID: 14146
		[global::Cpp2ILInjected.Token(Token = "0x6003DB9")]
		void FetchFromPool();
	}
}
