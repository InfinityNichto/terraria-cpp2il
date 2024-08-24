using System;
using Cpp2ILInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x0200061E RID: 1566
	[global::Cpp2ILInjected.Token(Token = "0x2000941")]
	public interface IEntryIcon
	{
		// Token: 0x06003E82 RID: 16002
		[global::Cpp2ILInjected.Token(Token = "0x6004796")]
		void Update(BestiaryUICollectionInfo providedInfo, Rectangle hitbox, EntryIconDrawSettings settings);

		// Token: 0x06003E83 RID: 16003
		[global::Cpp2ILInjected.Token(Token = "0x6004797")]
		void Draw(BestiaryUICollectionInfo providedInfo, SpriteBatch spriteBatch, EntryIconDrawSettings settings);

		// Token: 0x06003E84 RID: 16004
		[global::Cpp2ILInjected.Token(Token = "0x6004798")]
		bool GetUnlockState(BestiaryUICollectionInfo providedInfo);

		// Token: 0x06003E85 RID: 16005
		[global::Cpp2ILInjected.Token(Token = "0x6004799")]
		string GetHoverText(BestiaryUICollectionInfo providedInfo);

		// Token: 0x06003E86 RID: 16006
		[global::Cpp2ILInjected.Token(Token = "0x600479A")]
		IEntryIcon CreateClone();
	}
}
