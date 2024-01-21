using System.IO;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria.DataStructures;

[Cpp2IlInjected.Token(Token = "0x2000441")]
public class NPCFollowState
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006312")]
	private NPC _npc;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4006313")]
	private int? _playerIndexBeingFollowed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4006314")]
	private Vector2 _floorBreadcrumb;

	[Cpp2IlInjected.Token(Token = "0x1700061E")]
	public Vector2 BreadcrumbPosition
	{
		[Cpp2IlInjected.Token(Token = "0x6003158")]
		[Cpp2IlInjected.Address(RVA = "0x1014890", Offset = "0x1014890", VA = "0x1014890")]
		get
		{
			return default(Vector2);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700061F")]
	public bool IsFollowingPlayer
	{
		[Cpp2IlInjected.Token(Token = "0x6003159")]
		[Cpp2IlInjected.Address(RVA = "0x10148A4", Offset = "0x10148A4", VA = "0x10148A4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000620")]
	public Player PlayerBeingFollowed
	{
		[Cpp2IlInjected.Token(Token = "0x600315A")]
		[Cpp2IlInjected.Address(RVA = "0x10148EC", Offset = "0x10148EC", VA = "0x10148EC")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600315B")]
	[Cpp2IlInjected.Address(RVA = "0x10149A0", Offset = "0x10149A0", VA = "0x10149A0")]
	public void FollowPlayer(int playerIndex)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600315C")]
	[Cpp2IlInjected.Address(RVA = "0x1014A8C", Offset = "0x1014A8C", VA = "0x1014A8C")]
	public void StopFollowing()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600315D")]
	[Cpp2IlInjected.Address(RVA = "0x1014B34", Offset = "0x1014B34", VA = "0x1014B34")]
	public void Clear(NPC npcToBelongTo)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600315E")]
	[Cpp2IlInjected.Address(RVA = "0x1014B48", Offset = "0x1014B48", VA = "0x1014B48")]
	private bool ShouldSync()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600315F")]
	[Cpp2IlInjected.Address(RVA = "0x1014B54", Offset = "0x1014B54", VA = "0x1014B54")]
	public void WriteTo(BinaryWriter writer)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003160")]
	[Cpp2IlInjected.Address(RVA = "0x1014BE0", Offset = "0x1014BE0", VA = "0x1014BE0")]
	public void ReadFrom(BinaryReader reader)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003161")]
	[Cpp2IlInjected.Address(RVA = "0x1014AE8", Offset = "0x1014AE8", VA = "0x1014AE8")]
	private void MoveNPCBackHome()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003162")]
	[Cpp2IlInjected.Address(RVA = "0x1014D08", Offset = "0x1014D08", VA = "0x1014D08")]
	public void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003163")]
	[Cpp2IlInjected.Address(RVA = "0x1014E98", Offset = "0x1014E98", VA = "0x1014E98")]
	private void UpdateBreadcrumbs(Player player)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003164")]
	[Cpp2IlInjected.Address(RVA = "0x101500C", Offset = "0x101500C", VA = "0x101500C")]
	public NPCFollowState()
	{
	}
}
