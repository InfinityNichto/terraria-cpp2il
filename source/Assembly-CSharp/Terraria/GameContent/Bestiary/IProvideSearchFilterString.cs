using System;
using Cpp2ILInjected;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x02000642 RID: 1602
	[global::Cpp2ILInjected.Token(Token = "0x2000967")]
	public interface IProvideSearchFilterString
	{
		// Token: 0x06003F03 RID: 16131
		[global::Cpp2ILInjected.Token(Token = "0x600481B")]
		string GetSearchString(ref BestiaryUICollectionInfo info);
	}
}
