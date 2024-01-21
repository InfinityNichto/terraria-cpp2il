using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Achievements;
using Terraria.UI.Chat;

namespace Terraria.GameContent.UI.Chat;

[Cpp2IlInjected.Token(Token = "0x20006EF")]
public class AchievementTagHandler : ITagHandler
{
	[Cpp2IlInjected.Token(Token = "0x2000ABD")]
	private class AchievementSnippet : TextSnippet
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4008F48")]
		private Achievement _achievement;

		[Cpp2IlInjected.Token(Token = "0x60052CA")]
		[Cpp2IlInjected.Address(RVA = "0x1182804", Offset = "0x1182804", VA = "0x1182804")]
		public AchievementSnippet(Achievement achievement)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60052CB")]
		[Cpp2IlInjected.Address(RVA = "0x1182930", Offset = "0x1182930", VA = "0x1182930", Slot = "6")]
		public override void OnClick()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6004577")]
	[Cpp2IlInjected.Address(RVA = "0x1182728", Offset = "0x1182728", VA = "0x1182728", Slot = "4")]
	TextSnippet ITagHandler.Parse(string text, Color baseColor, string options)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6004578")]
	[Cpp2IlInjected.Address(RVA = "0x11828B8", Offset = "0x11828B8", VA = "0x11828B8")]
	public static string GenerateTag(Achievement achievement)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6004579")]
	[Cpp2IlInjected.Address(RVA = "0x1182928", Offset = "0x1182928", VA = "0x1182928")]
	public AchievementTagHandler()
	{
	}
}
