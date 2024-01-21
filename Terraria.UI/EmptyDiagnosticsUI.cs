using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.UI;

[Cpp2IlInjected.Token(Token = "0x20004CE")]
public class EmptyDiagnosticsUI : INetDiagnosticsUI
{
	[Cpp2IlInjected.Token(Token = "0x6003612")]
	[Cpp2IlInjected.Address(RVA = "0x13A4344", Offset = "0x13A4344", VA = "0x13A4344", Slot = "4")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003613")]
	[Cpp2IlInjected.Address(RVA = "0x13A4348", Offset = "0x13A4348", VA = "0x13A4348", Slot = "6")]
	public void CountReadMessage(int messageId, int messageLength)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003614")]
	[Cpp2IlInjected.Address(RVA = "0x13A434C", Offset = "0x13A434C", VA = "0x13A434C", Slot = "7")]
	public void CountSentMessage(int messageId, int messageLength)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003615")]
	[Cpp2IlInjected.Address(RVA = "0x13A4350", Offset = "0x13A4350", VA = "0x13A4350", Slot = "8")]
	public void CountReadModuleMessage(int moduleMessageId, int messageLength)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003616")]
	[Cpp2IlInjected.Address(RVA = "0x13A4354", Offset = "0x13A4354", VA = "0x13A4354", Slot = "9")]
	public void CountSentModuleMessage(int moduleMessageId, int messageLength)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003617")]
	[Cpp2IlInjected.Address(RVA = "0x13A4358", Offset = "0x13A4358", VA = "0x13A4358", Slot = "5")]
	public void Draw(SpriteBatch spriteBatch)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003618")]
	[Cpp2IlInjected.Address(RVA = "0x13A435C", Offset = "0x13A435C", VA = "0x13A435C")]
	public EmptyDiagnosticsUI()
	{
	}
}
