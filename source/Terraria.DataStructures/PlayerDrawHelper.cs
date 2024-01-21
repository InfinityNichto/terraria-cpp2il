using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.DataStructures;

[Cpp2IlInjected.Token(Token = "0x2000445")]
public class PlayerDrawHelper
{
	[Cpp2IlInjected.Token(Token = "0x2000927")]
	public enum ShaderConfiguration
	{
		[Cpp2IlInjected.Token(Token = "0x4008AB7")]
		ArmorShader,
		[Cpp2IlInjected.Token(Token = "0x4008AB8")]
		HairShader,
		[Cpp2IlInjected.Token(Token = "0x4008AB9")]
		TileShader,
		[Cpp2IlInjected.Token(Token = "0x4008ABA")]
		TilePaintID,
		[Cpp2IlInjected.Token(Token = "0x4008ABB")]
		Misc
	}

	[Cpp2IlInjected.Token(Token = "0x4006326")]
	public static Color DISPLAY_DOLL_DEFAULT_SKIN_COLOR;

	[Cpp2IlInjected.Token(Token = "0x600317B")]
	[Cpp2IlInjected.Address(RVA = "0x101CE58", Offset = "0x101CE58", VA = "0x101CE58")]
	public static int PackShader(int localShaderIndex, ShaderConfiguration shaderType)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600317C")]
	[Cpp2IlInjected.Address(RVA = "0x101CE64", Offset = "0x101CE64", VA = "0x101CE64")]
	public static void UnpackShader(int packedShaderIndex, out int localShaderIndex, out ShaderConfiguration shaderType)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600317D")]
	[Cpp2IlInjected.Address(RVA = "0x101CE8C", Offset = "0x101CE8C", VA = "0x101CE8C")]
	public static bool SetShaderForData(Player player, int cHead, ref DrawData cdd, ref EffectPass effectPass)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600317E")]
	[Cpp2IlInjected.Address(RVA = "0x101B480", Offset = "0x101B480", VA = "0x101B480")]
	public static bool SetShaderForData(Player player, int cHead, ref DrawData cdd)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600317F")]
	[Cpp2IlInjected.Address(RVA = "0x101DE38", Offset = "0x101DE38", VA = "0x101DE38")]
	public PlayerDrawHelper()
	{
	}
}
