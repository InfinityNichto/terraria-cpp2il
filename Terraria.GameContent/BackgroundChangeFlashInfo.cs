using Cpp2IlInjected;

namespace Terraria.GameContent;

[Cpp2IlInjected.Token(Token = "0x2000574")]
public class BackgroundChangeFlashInfo
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006AC2")]
	private int[] _variations;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4006AC3")]
	private float[] _flashPower;

	[Cpp2IlInjected.Token(Token = "0x6003AF6")]
	[Cpp2IlInjected.Address(RVA = "0xFB785C", Offset = "0xFB785C", VA = "0xFB785C")]
	public void UpdateCache()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003AF7")]
	[Cpp2IlInjected.Address(RVA = "0xFB7B08", Offset = "0xFB7B08", VA = "0xFB7B08")]
	private void UpdateVariation(int areaId, int newVariationValue)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003AF8")]
	[Cpp2IlInjected.Address(RVA = "0xFB7B24", Offset = "0xFB7B24", VA = "0xFB7B24")]
	private void ValueChanged(int areaId)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003AF9")]
	[Cpp2IlInjected.Address(RVA = "0xFB7BB4", Offset = "0xFB7BB4", VA = "0xFB7BB4")]
	public void UpdateFlashValues()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003AFA")]
	[Cpp2IlInjected.Address(RVA = "0xFB7C28", Offset = "0xFB7C28", VA = "0xFB7C28")]
	public float GetFlashPower(int areaId)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6003AFB")]
	[Cpp2IlInjected.Address(RVA = "0xFB7C38", Offset = "0xFB7C38", VA = "0xFB7C38")]
	public BackgroundChangeFlashInfo()
	{
	}
}
