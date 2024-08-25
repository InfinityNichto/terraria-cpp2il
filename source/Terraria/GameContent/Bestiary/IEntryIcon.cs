using System;
using Cpp2ILInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.Bestiary
{
	[global::Cpp2ILInjected.Token(Token = "0x2000941")]
	public interface IEntryIcon
	{
		[global::Cpp2ILInjected.Token(Token = "0x6004796")]
		void Update(BestiaryUICollectionInfo providedInfo, Rectangle hitbox, EntryIconDrawSettings settings);

		[global::Cpp2ILInjected.Token(Token = "0x6004797")]
		void Draw(BestiaryUICollectionInfo providedInfo, SpriteBatch spriteBatch, EntryIconDrawSettings settings);

		[global::Cpp2ILInjected.Token(Token = "0x6004798")]
		bool GetUnlockState(BestiaryUICollectionInfo providedInfo);

		[global::Cpp2ILInjected.Token(Token = "0x6004799")]
		string GetHoverText(BestiaryUICollectionInfo providedInfo);

		[global::Cpp2ILInjected.Token(Token = "0x600479A")]
		IEntryIcon CreateClone();
	}
}
