using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;

namespace Terraria.GameContent.Bestiary;

[Cpp2IlInjected.Token(Token = "0x2000623")]
public class UnlockableNPCEntryIcon : IEntryIcon
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006C50")]
	private int lastFrameVisualsUpdated;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4006C51")]
	private int _npcNetId;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4006C52")]
	private NPC _npcCache;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4006C53")]
	private bool _firstUpdateDone;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4006C54")]
	private Asset<Texture2D> _customTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4006C55")]
	private Vector2 _positionOffsetCache;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4006C56")]
	private string _overrideNameKey;

	[Cpp2IlInjected.Token(Token = "0x6003EC3")]
	[Cpp2IlInjected.Address(RVA = "0x10F7F24", Offset = "0x10F7F24", VA = "0x10F7F24")]
	public UnlockableNPCEntryIcon(int npcNetId, float ai0 = 0f, float ai1 = 0f, float ai2 = 0f, float ai3 = 0f, [Optional] string overrideNameKey)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003EC4")]
	[Cpp2IlInjected.Address(RVA = "0x1105584", Offset = "0x1105584", VA = "0x1105584", Slot = "8")]
	public IEntryIcon CreateClone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003EC5")]
	[Cpp2IlInjected.Address(RVA = "0x1105614", Offset = "0x1105614", VA = "0x1105614", Slot = "4")]
	public void Update(BestiaryUICollectionInfo providedInfo, Rectangle hitbox, EntryIconDrawSettings settings)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003EC6")]
	[Cpp2IlInjected.Address(RVA = "0x1105B18", Offset = "0x1105B18", VA = "0x1105B18")]
	private void UpdatePosition(EntryIconDrawSettings settings)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003EC7")]
	[Cpp2IlInjected.Address(RVA = "0x1105DEC", Offset = "0x1105DEC", VA = "0x1105DEC")]
	private void AdjustSpecialSpawnRulesForVisuals(EntryIconDrawSettings settings)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003EC8")]
	[Cpp2IlInjected.Address(RVA = "0x1106180", Offset = "0x1106180", VA = "0x1106180")]
	private void SimulateFirstHover(float velocity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003EC9")]
	[Cpp2IlInjected.Address(RVA = "0x11061E0", Offset = "0x11061E0", VA = "0x11061E0", Slot = "5")]
	public void Draw(BestiaryUICollectionInfo providedInfo, SpriteBatch spriteBatch, EntryIconDrawSettings settings)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003ECA")]
	[Cpp2IlInjected.Address(RVA = "0x1106608", Offset = "0x1106608", VA = "0x1106608", Slot = "7")]
	public string GetHoverText(BestiaryUICollectionInfo providedInfo)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003ECB")]
	[Cpp2IlInjected.Address(RVA = "0x11066D0", Offset = "0x11066D0", VA = "0x11066D0", Slot = "6")]
	public bool GetUnlockState(BestiaryUICollectionInfo providedInfo)
	{
		return default(bool);
	}
}
