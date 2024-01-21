using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria;
using Terraria.Graphics.Renderers;

[Cpp2IlInjected.Token(Token = "0x20000FD")]
public class GUIResearch
{
	[Cpp2IlInjected.Token(Token = "0x20007C6")]
	public enum ResearchState
	{
		[Cpp2IlInjected.Token(Token = "0x4007A67")]
		Invalid,
		[Cpp2IlInjected.Token(Token = "0x4007A68")]
		Valid,
		[Cpp2IlInjected.Token(Token = "0x4007A69")]
		Complete
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000764")]
	private int OpenedFrame;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000765")]
	public bool Displaying;

	[Cpp2IlInjected.Token(Token = "0x4000766")]
	private static Asset<Texture2D> pistonsAsset;

	[Cpp2IlInjected.Token(Token = "0x4000767")]
	private static Asset<Texture2D> pistonParticleAsset;

	[Cpp2IlInjected.Token(Token = "0x4000768")]
	private static Asset<Texture2D> cogsSmall;

	[Cpp2IlInjected.Token(Token = "0x4000769")]
	private static Asset<Texture2D> cogsMedium;

	[Cpp2IlInjected.Token(Token = "0x400076A")]
	private static Asset<Texture2D> cogsLarge;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400076B")]
	private float inventoryResearchScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400076C")]
	private GUIInputRegionExclusive PickingInterceptor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400076D")]
	private int selectedResearchItem;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400076E")]
	private float closeScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400076F")]
	private float researchScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000770")]
	public bool ResearchAnimationInProgress;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000771")]
	private DateTime ResearchAnimationTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000772")]
	private int ResearchItem;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000773")]
	private int ResearchItemStart;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000774")]
	private int ResearchItemCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000775")]
	private int ResearchFrame;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000776")]
	private bool ResearchCompleted;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000777")]
	private ParticleRendererSettings ResearchParticleSettings;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000778")]
	private List<CreativeSacrificeParticle> ResearchParticles;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000779")]
	private float _smallRotation;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400077A")]
	private float _mediumRotation;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400077B")]
	private float _largeRotation;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400077C")]
	private float testProgress;

	[Cpp2IlInjected.Token(Token = "0x600093E")]
	[Cpp2IlInjected.Address(RVA = "0x1152C38", Offset = "0x1152C38", VA = "0x1152C38")]
	public static void LoadContent()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600093F")]
	[Cpp2IlInjected.Address(RVA = "0x11530A0", Offset = "0x11530A0", VA = "0x11530A0")]
	public Rectangle GetRegion()
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000940")]
	[Cpp2IlInjected.Address(RVA = "0x1153130", Offset = "0x1153130", VA = "0x1153130")]
	public ResearchState CanBeResearched(Item item, out int percent)
	{
		return default(ResearchState);
	}

	[Cpp2IlInjected.Token(Token = "0x6000941")]
	[Cpp2IlInjected.Address(RVA = "0x1153268", Offset = "0x1153268", VA = "0x1153268")]
	public void DrawInventoryResearchBinding()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000942")]
	[Cpp2IlInjected.Address(RVA = "0x1153504", Offset = "0x1153504", VA = "0x1153504")]
	public void DrawInventoryResearchButton()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000943")]
	[Cpp2IlInjected.Address(RVA = "0x1153BE0", Offset = "0x1153BE0", VA = "0x1153BE0")]
	public bool IsOver(Vector2 cursorPosition)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000944")]
	[Cpp2IlInjected.Address(RVA = "0x11539E4", Offset = "0x11539E4", VA = "0x11539E4")]
	public void Open(int item)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000945")]
	[Cpp2IlInjected.Address(RVA = "0x1153EF4", Offset = "0x1153EF4", VA = "0x1153EF4")]
	public void Close()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000946")]
	[Cpp2IlInjected.Address(RVA = "0x1153F84", Offset = "0x1153F84", VA = "0x1153F84")]
	public void Draw()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000947")]
	[Cpp2IlInjected.Address(RVA = "0x1154C80", Offset = "0x1154C80", VA = "0x1154C80")]
	private void DrawResearchParticles()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000948")]
	[Cpp2IlInjected.Address(RVA = "0x1154D60", Offset = "0x1154D60", VA = "0x1154D60")]
	private void DrawMainButtons()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000949")]
	[Cpp2IlInjected.Address(RVA = "0x11552F4", Offset = "0x11552F4", VA = "0x11552F4")]
	private void BeginResearchAnimation(int itemResearched, int amountStart, int amountSubmitted, bool completed)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600094A")]
	[Cpp2IlInjected.Address(RVA = "0x1154FEC", Offset = "0x1154FEC", VA = "0x1154FEC")]
	private void ActionResearch()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600094B")]
	[Cpp2IlInjected.Address(RVA = "0x1154274", Offset = "0x1154274", VA = "0x1154274")]
	private void DrawBacking()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600094C")]
	[Cpp2IlInjected.Address(RVA = "0x1155574", Offset = "0x1155574", VA = "0x1155574")]
	private int UpdateResearchAnimation()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600094D")]
	[Cpp2IlInjected.Address(RVA = "0x1154384", Offset = "0x1154384", VA = "0x1154384")]
	private void DrawResearchBacking()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600094E")]
	[Cpp2IlInjected.Address(RVA = "0x11561C0", Offset = "0x11561C0", VA = "0x11561C0")]
	public Rectangle SetupFrame(Texture2D texture, int frameCountHorizontal, int frameCountVertical, int frameX, int frameY)
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x600094F")]
	[Cpp2IlInjected.Address(RVA = "0x11545BC", Offset = "0x11545BC", VA = "0x11545BC")]
	public void DrawResearchCogs()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000950")]
	[Cpp2IlInjected.Address(RVA = "0x1156274", Offset = "0x1156274", VA = "0x1156274")]
	public void DrawTexture(Panel_Layout layout, Texture2D texture, float rotation)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000951")]
	[Cpp2IlInjected.Address(RVA = "0x11563A8", Offset = "0x11563A8", VA = "0x11563A8")]
	public void DrawTexture(Vector2 position, Vector2 size, Texture2D texture, Color color, float rotation)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000952")]
	[Cpp2IlInjected.Address(RVA = "0x1155478", Offset = "0x1155478", VA = "0x1155478")]
	private Item GetResearchItem()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000953")]
	[Cpp2IlInjected.Address(RVA = "0x115471C", Offset = "0x115471C", VA = "0x115471C")]
	private void DrawItemProgress()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000954")]
	[Cpp2IlInjected.Address(RVA = "0x1155B04", Offset = "0x1155B04", VA = "0x1155B04")]
	private void DrawResearchItem()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000955")]
	[Cpp2IlInjected.Address(RVA = "0x115658C", Offset = "0x115658C", VA = "0x115658C")]
	public GUIResearch()
	{
	}
}
