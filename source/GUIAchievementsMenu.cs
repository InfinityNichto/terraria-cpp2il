using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Achievements;

[Cpp2IlInjected.Token(Token = "0x20001C2")]
public class GUIAchievementsMenu
{
	[Cpp2IlInjected.Token(Token = "0x20007ED")]
	public class AchievementFileData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4007CA4")]
		public string Name;

		[Cpp2IlInjected.Token(Token = "0x6004924")]
		[Cpp2IlInjected.Address(RVA = "0x134E8A0", Offset = "0x134E8A0", VA = "0x134E8A0")]
		public AchievementFileData()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40013D5")]
	private GUIControllerAchievements _controllerInput;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40013D6")]
	private GUIContollerTransactionButtonList _filterListOptionsController;

	[Cpp2IlInjected.Token(Token = "0x40013D7")]
	private const double SINGLE_CLICK_TIME = 350.0;

	[Cpp2IlInjected.Token(Token = "0x40013D8")]
	private const float SINGLE_CLICK_DISTANCE = 30f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40013D9")]
	private DateTime LastTouchTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40013DA")]
	private Vector2 LastTouchMouse;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40013DB")]
	private int _source;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40013DC")]
	private bool allowItemClicking;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40013DD")]
	private float TitleScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40013DE")]
	private float BackScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40013DF")]
	public float ScrollOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40013E0")]
	private float ScrollMomentum;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40013E1")]
	private int ScrollDragging;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40013E2")]
	private Vector2 DragOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40013E3")]
	public int SelectedItem;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40013E4")]
	public int SelectedItemId;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40013E5")]
	private Vector2 InGameWindowShift;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40013E6")]
	private List<bool> catButtonsActive;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40013E7")]
	private List<Achievement> _achievements;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40013E8")]
	public List<Achievement> SortedAchievementsData;

	[Cpp2IlInjected.Token(Token = "0x40013E9")]
	private static Texture2D AchievementsIcons;

	[Cpp2IlInjected.Token(Token = "0x40013EA")]
	private static Texture2D AchievementsCategories;

	[Cpp2IlInjected.Token(Token = "0x40013EB")]
	private static Texture2D AchievementsIconBorder;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40013EC")]
	private string _tooltip;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40013ED")]
	private bool _tooltipShow;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40013EE")]
	private Vector2 _tooltipLocation;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40013EF")]
	private DateTime _tooltipTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40013F0")]
	private Vector2 startPoint;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40013F1")]
	private float[] catScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x40013F2")]
	private bool displayFilters;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40013F3")]
	private float filtersScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x40013F4")]
	private int achievementOver;

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	private GUIContollerTransactionButtonList FilterListOptionsController
	{
		[Cpp2IlInjected.Token(Token = "0x6000C52")]
		[Cpp2IlInjected.Address(RVA = "0x134AB78", Offset = "0x134AB78", VA = "0x134AB78")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	private List<Achievement> Achievements
	{
		[Cpp2IlInjected.Token(Token = "0x6000C54")]
		[Cpp2IlInjected.Address(RVA = "0x134AE24", Offset = "0x134AE24", VA = "0x134AE24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000C53")]
	[Cpp2IlInjected.Address(RVA = "0x134AD38", Offset = "0x134AD38", VA = "0x134AD38")]
	public void GotoAchievement(Achievement achievement)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C55")]
	[Cpp2IlInjected.Address(RVA = "0x134AEB4", Offset = "0x134AEB4", VA = "0x134AEB4")]
	public void Open(int backTo, int selected = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C56")]
	[Cpp2IlInjected.Address(RVA = "0x134B2F8", Offset = "0x134B2F8", VA = "0x134B2F8")]
	private void DrawFilters()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C57")]
	[Cpp2IlInjected.Address(RVA = "0x134B614", Offset = "0x134B614", VA = "0x134B614")]
	public void Draw()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C58")]
	[Cpp2IlInjected.Address(RVA = "0x134BD1C", Offset = "0x134BD1C", VA = "0x134BD1C")]
	public void Back()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C59")]
	[Cpp2IlInjected.Address(RVA = "0x134BF98", Offset = "0x134BF98", VA = "0x134BF98")]
	private void AchievementDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C5A")]
	[Cpp2IlInjected.Address(RVA = "0x134DEE4", Offset = "0x134DEE4", VA = "0x134DEE4")]
	private float AchievementScale(int index)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C5B")]
	[Cpp2IlInjected.Address(RVA = "0x134DEF0", Offset = "0x134DEF0", VA = "0x134DEF0")]
	private void AchievementOver(int index)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C5C")]
	[Cpp2IlInjected.Address(RVA = "0x134B178", Offset = "0x134B178", VA = "0x134B178")]
	public static void LoadContent()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C5D")]
	[Cpp2IlInjected.Address(RVA = "0x134B268", Offset = "0x134B268", VA = "0x134B268")]
	public void UpdateAchievements()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C5E")]
	[Cpp2IlInjected.Address(RVA = "0x134E40C", Offset = "0x134E40C", VA = "0x134E40C")]
	public void SortAndFilderAchievements()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C5F")]
	[Cpp2IlInjected.Address(RVA = "0x134E5A4", Offset = "0x134E5A4", VA = "0x134E5A4")]
	private int SortEntry(Achievement a, Achievement b)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C60")]
	[Cpp2IlInjected.Address(RVA = "0x134D218", Offset = "0x134D218", VA = "0x134D218")]
	private void DrawProgressBar(SpriteBatch spriteBatch, float progress, Vector2 spot, float Width = 169f, [Optional] Color BackColor, [Optional] Color FillingColor, [Optional] Color BlipColor)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C61")]
	[Cpp2IlInjected.Address(RVA = "0x134E640", Offset = "0x134E640", VA = "0x134E640")]
	public GUIAchievementsMenu()
	{
	}
}
