using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.UI;

[Cpp2IlInjected.Token(Token = "0x20004CD")]
public class LegacyNetDiagnosticsUI : INetDiagnosticsUI
{
	[Cpp2IlInjected.Token(Token = "0x400669E")]
	public static bool netDiag;

	[Cpp2IlInjected.Token(Token = "0x400669F")]
	public static int txData;

	[Cpp2IlInjected.Token(Token = "0x40066A0")]
	public static int rxData;

	[Cpp2IlInjected.Token(Token = "0x40066A1")]
	public static int txMsg;

	[Cpp2IlInjected.Token(Token = "0x40066A2")]
	public static int rxMsg;

	[Cpp2IlInjected.Token(Token = "0x40066A3")]
	private static readonly int maxMsg;

	[Cpp2IlInjected.Token(Token = "0x40066A4")]
	public static int[] rxMsgType;

	[Cpp2IlInjected.Token(Token = "0x40066A5")]
	public static int[] rxDataType;

	[Cpp2IlInjected.Token(Token = "0x40066A6")]
	public static int[] txMsgType;

	[Cpp2IlInjected.Token(Token = "0x40066A7")]
	public static int[] txDataType;

	[Cpp2IlInjected.Token(Token = "0x6003607")]
	[Cpp2IlInjected.Address(RVA = "0x1342F8C", Offset = "0x1342F8C", VA = "0x1342F8C")]
	public LegacyNetDiagnosticsUI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003608")]
	[Cpp2IlInjected.Address(RVA = "0x1342F94", Offset = "0x1342F94", VA = "0x1342F94", Slot = "4")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003609")]
	[Cpp2IlInjected.Address(RVA = "0x13430C8", Offset = "0x13430C8", VA = "0x13430C8", Slot = "6")]
	public void CountReadMessage(int messageId, int messageLength)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600360A")]
	[Cpp2IlInjected.Address(RVA = "0x1343194", Offset = "0x1343194", VA = "0x1343194", Slot = "7")]
	public void CountSentMessage(int messageId, int messageLength)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600360B")]
	[Cpp2IlInjected.Address(RVA = "0x1343260", Offset = "0x1343260", VA = "0x1343260", Slot = "5")]
	public void Draw(SpriteBatch spriteBatch)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600360C")]
	[Cpp2IlInjected.Address(RVA = "0x134371C", Offset = "0x134371C", VA = "0x134371C")]
	private static void DrawMesageLines(SpriteBatch spriteBatch)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600360D")]
	[Cpp2IlInjected.Address(RVA = "0x13432E0", Offset = "0x13432E0", VA = "0x13432E0")]
	private static void DrawTitles(SpriteBatch spriteBatch)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600360E")]
	[Cpp2IlInjected.Address(RVA = "0x1343810", Offset = "0x1343810", VA = "0x1343810")]
	private static void PrintNetDiagnosticsLineForMessage(SpriteBatch spriteBatch, int msgId, int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600360F")]
	[Cpp2IlInjected.Address(RVA = "0x1343ECC", Offset = "0x1343ECC", VA = "0x1343ECC", Slot = "8")]
	public void CountReadModuleMessage(int moduleMessageId, int messageLength)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003610")]
	[Cpp2IlInjected.Address(RVA = "0x1343ED0", Offset = "0x1343ED0", VA = "0x1343ED0", Slot = "9")]
	public void CountSentModuleMessage(int moduleMessageId, int messageLength)
	{
	}
}
