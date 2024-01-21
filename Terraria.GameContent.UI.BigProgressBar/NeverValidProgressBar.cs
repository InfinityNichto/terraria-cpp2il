using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.UI.BigProgressBar;

[Cpp2IlInjected.Token(Token = "0x2000703")]
public class NeverValidProgressBar : IBigProgressBar
{
	[Cpp2IlInjected.Token(Token = "0x60045E0")]
	[Cpp2IlInjected.Address(RVA = "0x1181B08", Offset = "0x1181B08", VA = "0x1181B08", Slot = "4")]
	public bool ValidateAndCollectNecessaryInfo(ref BigProgressBarInfo info)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60045E1")]
	[Cpp2IlInjected.Address(RVA = "0x1181B10", Offset = "0x1181B10", VA = "0x1181B10", Slot = "5")]
	public void Draw(ref BigProgressBarInfo info, SpriteBatch spriteBatch)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60045E2")]
	[Cpp2IlInjected.Address(RVA = "0x117F770", Offset = "0x117F770", VA = "0x117F770")]
	public NeverValidProgressBar()
	{
	}
}
