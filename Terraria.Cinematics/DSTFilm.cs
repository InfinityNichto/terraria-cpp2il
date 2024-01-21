using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria.Cinematics;

[Cpp2IlInjected.Token(Token = "0x2000529")]
public class DSTFilm : Film
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4006885")]
	private NPC _deerclops;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4006886")]
	private Projectile _chester;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4006887")]
	private Vector2 _startPoint;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4006888")]
	private Item _oldItem;

	[Cpp2IlInjected.Token(Token = "0x60038E8")]
	[Cpp2IlInjected.Address(RVA = "0x11AE2E4", Offset = "0x11AE2E4", VA = "0x11AE2E4")]
	public DSTFilm()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60038E9")]
	[Cpp2IlInjected.Address(RVA = "0x11AE72C", Offset = "0x11AE72C", VA = "0x11AE72C", Slot = "4")]
	public override void OnBegin()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60038EA")]
	[Cpp2IlInjected.Address(RVA = "0x11AEA0C", Offset = "0x11AEA0C", VA = "0x11AEA0C", Slot = "5")]
	public override void OnEnd()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60038EB")]
	[Cpp2IlInjected.Address(RVA = "0x11AE300", Offset = "0x11AE300", VA = "0x11AE300")]
	private void BuildSequence()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60038EC")]
	[Cpp2IlInjected.Address(RVA = "0x11AE7B8", Offset = "0x11AE7B8", VA = "0x11AE7B8")]
	private void PrepareScene()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60038ED")]
	[Cpp2IlInjected.Address(RVA = "0x11AEA98", Offset = "0x11AEA98", VA = "0x11AEA98")]
	private void ClearScene()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60038EE")]
	[Cpp2IlInjected.Address(RVA = "0x11AEBD8", Offset = "0x11AEBD8", VA = "0x11AEBD8")]
	private void EquipDSTShaderItem(FrameEventData evt)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60038EF")]
	[Cpp2IlInjected.Address(RVA = "0x11AECC8", Offset = "0x11AECC8", VA = "0x11AECC8")]
	private void RemoveDSTShaderItem(FrameEventData evt)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60038F0")]
	[Cpp2IlInjected.Address(RVA = "0x11AED78", Offset = "0x11AED78", VA = "0x11AED78")]
	private void CreateDeerclops(FrameEventData evt)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60038F1")]
	[Cpp2IlInjected.Address(RVA = "0x11AEEA0", Offset = "0x11AEEA0", VA = "0x11AEEA0")]
	private NPC PlaceNPCOnGround(int type, Vector2 position)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60038F2")]
	[Cpp2IlInjected.Address(RVA = "0x11AF0D8", Offset = "0x11AF0D8", VA = "0x11AF0D8")]
	private void CreateChester(FrameEventData evt)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60038F3")]
	[Cpp2IlInjected.Address(RVA = "0x11AF2B0", Offset = "0x11AF2B0", VA = "0x11AF2B0")]
	private void ControlPlayer(FrameEventData evt)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60038F4")]
	[Cpp2IlInjected.Address(RVA = "0x11AF420", Offset = "0x11AF420", VA = "0x11AF420")]
	private void StopBeforeCliff(FrameEventData evt)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60038F5")]
	[Cpp2IlInjected.Address(RVA = "0x11AF4B8", Offset = "0x11AF4B8", VA = "0x11AF4B8")]
	private void TurnPlayerToTheLeft(FrameEventData evt)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60038F6")]
	[Cpp2IlInjected.Address(RVA = "0x11AF5B0", Offset = "0x11AF5B0", VA = "0x11AF5B0")]
	private void DeerclopsAttack(FrameEventData evt)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60038F7")]
	[Cpp2IlInjected.Address(RVA = "0x11AEFF0", Offset = "0x11AEFF0", VA = "0x11AEFF0")]
	private static void FindFloorAt(Vector2 position, out int x, out int y)
	{
	}
}
