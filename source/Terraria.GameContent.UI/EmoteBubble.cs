using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.UI;

[Cpp2IlInjected.Token(Token = "0x200069A")]
public class EmoteBubble
{
	[Cpp2IlInjected.Token(Token = "0x4006E13")]
	private static int[] CountNPCs;

	[Cpp2IlInjected.Token(Token = "0x4006E14")]
	public static Dictionary<int, EmoteBubble> byID;

	[Cpp2IlInjected.Token(Token = "0x4006E15")]
	private static List<int> toClean;

	[Cpp2IlInjected.Token(Token = "0x4006E16")]
	public static int NextID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006E17")]
	public int ID;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4006E18")]
	public WorldUIAnchor anchor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4006E19")]
	public int lifeTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4006E1A")]
	public int lifeTimeStart;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4006E1B")]
	public int emote;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4006E1C")]
	public int metadata;

	[Cpp2IlInjected.Token(Token = "0x4006E1D")]
	private const int frameSpeed = 8;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4006E1E")]
	public int frameCounter;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4006E1F")]
	public int frame;

	[Cpp2IlInjected.Token(Token = "0x4006E20")]
	public const int EMOTE_SHEET_HORIZONTAL_FRAMES = 8;

	[Cpp2IlInjected.Token(Token = "0x4006E21")]
	public const int EMOTE_SHEET_EMOTES_PER_ROW = 4;

	[Cpp2IlInjected.Token(Token = "0x4006E22")]
	public static readonly int EMOTE_SHEET_VERTICAL_FRAMES;

	[Cpp2IlInjected.Token(Token = "0x6004281")]
	[Cpp2IlInjected.Address(RVA = "0x1092F8C", Offset = "0x1092F8C", VA = "0x1092F8C")]
	public static void UpdateAll()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004282")]
	[Cpp2IlInjected.Address(RVA = "0x109346C", Offset = "0x109346C", VA = "0x109346C")]
	public static void DrawAll(SpriteBatch sb)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004283")]
	[Cpp2IlInjected.Address(RVA = "0x1093E60", Offset = "0x1093E60", VA = "0x1093E60")]
	public static Tuple<int, int> SerializeNetAnchor(WorldUIAnchor anch)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6004284")]
	[Cpp2IlInjected.Address(RVA = "0x1093FA0", Offset = "0x1093FA0", VA = "0x1093FA0")]
	public static WorldUIAnchor DeserializeNetAnchor(int type, int meta)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6004285")]
	[Cpp2IlInjected.Address(RVA = "0x1094130", Offset = "0x1094130", VA = "0x1094130")]
	public static int AssignNewID()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6004286")]
	[Cpp2IlInjected.Address(RVA = "0x10941B0", Offset = "0x10941B0", VA = "0x10941B0")]
	public static int NewBubble(int emoticon, WorldUIAnchor bubbleAnchor, int time)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6004287")]
	[Cpp2IlInjected.Address(RVA = "0x1094624", Offset = "0x1094624", VA = "0x1094624")]
	public static int NewBubbleNPC(WorldUIAnchor bubbleAnchor, int time, [Optional] WorldUIAnchor other)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6004288")]
	[Cpp2IlInjected.Address(RVA = "0x1094D90", Offset = "0x1094D90", VA = "0x1094D90")]
	public static void CheckForNPCsToReactToEmoteBubble(int emoteID, Player player)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004289")]
	[Cpp2IlInjected.Address(RVA = "0x10943DC", Offset = "0x10943DC", VA = "0x10943DC")]
	public EmoteBubble(int emotion, WorldUIAnchor bubbleAnchor, int time = 180)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600428A")]
	[Cpp2IlInjected.Address(RVA = "0x1093424", Offset = "0x1093424", VA = "0x1093424")]
	private void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600428B")]
	[Cpp2IlInjected.Address(RVA = "0x1093660", Offset = "0x1093660", VA = "0x1093660")]
	private void Draw(SpriteBatch sb)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600428C")]
	[Cpp2IlInjected.Address(RVA = "0x1094FE0", Offset = "0x1094FE0", VA = "0x1094FE0")]
	private Vector2 GetPosition(out SpriteEffects effect)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600428D")]
	[Cpp2IlInjected.Address(RVA = "0x1094410", Offset = "0x1094410", VA = "0x1094410")]
	public static void OnBubbleChange(int bubbleID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600428E")]
	[Cpp2IlInjected.Address(RVA = "0x1095320", Offset = "0x1095320", VA = "0x1095320")]
	public static void MakeLocalPlayerEmote(int emoteId)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600428F")]
	[Cpp2IlInjected.Address(RVA = "0x109483C", Offset = "0x109483C", VA = "0x109483C")]
	public void PickNPCEmote([Optional] WorldUIAnchor other)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004290")]
	[Cpp2IlInjected.Address(RVA = "0x1098D78", Offset = "0x1098D78", VA = "0x1098D78")]
	private void ProbeCombat(List<int> list)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004291")]
	[Cpp2IlInjected.Address(RVA = "0x1097940", Offset = "0x1097940", VA = "0x1097940")]
	private void ProbeWeather(List<int> list, Player plr)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004292")]
	[Cpp2IlInjected.Address(RVA = "0x10972A4", Offset = "0x10972A4", VA = "0x10972A4")]
	private void ProbeEvents(List<int> list)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004293")]
	[Cpp2IlInjected.Address(RVA = "0x1096F84", Offset = "0x1096F84", VA = "0x1096F84")]
	private void ProbeDebuffs(List<int> list, Player plr)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004294")]
	[Cpp2IlInjected.Address(RVA = "0x10962F0", Offset = "0x10962F0", VA = "0x10962F0")]
	private void ProbeItems(List<int> list, Player plr)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004295")]
	[Cpp2IlInjected.Address(RVA = "0x10954EC", Offset = "0x10954EC", VA = "0x10954EC")]
	private void ProbeTownNPCs(List<int> list)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004296")]
	[Cpp2IlInjected.Address(RVA = "0x1095A50", Offset = "0x1095A50", VA = "0x1095A50")]
	private void ProbeBiomes(List<int> list, Player plr)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004297")]
	[Cpp2IlInjected.Address(RVA = "0x1095DA8", Offset = "0x1095DA8", VA = "0x1095DA8")]
	private void ProbeCritters(List<int> list)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004298")]
	[Cpp2IlInjected.Address(RVA = "0x10957BC", Offset = "0x10957BC", VA = "0x10957BC")]
	private void ProbeEmotions(List<int> list)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004299")]
	[Cpp2IlInjected.Address(RVA = "0x10963CC", Offset = "0x10963CC", VA = "0x10963CC")]
	private void ProbeBosses(List<int> list)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600429A")]
	[Cpp2IlInjected.Address(RVA = "0x1097BCC", Offset = "0x1097BCC", VA = "0x1097BCC")]
	private void ProbeExceptions(List<int> list, Player plr, WorldUIAnchor other)
	{
	}
}
