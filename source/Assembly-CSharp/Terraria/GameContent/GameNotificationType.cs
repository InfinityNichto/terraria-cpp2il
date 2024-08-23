using System;
using Cpp2ILInjected;

namespace Terraria.GameContent
{
	// Token: 0x0200054A RID: 1354
	[Flags]
	[global::Cpp2ILInjected.Token(Token = "0x20007C6")]
	public enum GameNotificationType
	{
		// Token: 0x040068E1 RID: 26849
		[global::Cpp2ILInjected.Token(Token = "0x4007E46")]
		None = 0,
		// Token: 0x040068E2 RID: 26850
		[global::Cpp2ILInjected.Token(Token = "0x4007E47")]
		Damage = 1,
		// Token: 0x040068E3 RID: 26851
		[global::Cpp2ILInjected.Token(Token = "0x4007E48")]
		SpawnOrDeath = 2,
		// Token: 0x040068E4 RID: 26852
		[global::Cpp2ILInjected.Token(Token = "0x4007E49")]
		WorldGen = 4,
		// Token: 0x040068E5 RID: 26853
		[global::Cpp2ILInjected.Token(Token = "0x4007E4A")]
		All = 7
	}
}
