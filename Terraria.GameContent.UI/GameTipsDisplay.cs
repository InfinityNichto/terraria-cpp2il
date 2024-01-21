using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Terraria.Localization;

namespace Terraria.GameContent.UI;

[Cpp2IlInjected.Token(Token = "0x200069F")]
public class GameTipsDisplay
{
	[Cpp2IlInjected.Token(Token = "0x2000A96")]
	private class GameTip
	{
		[Cpp2IlInjected.Token(Token = "0x4008ED2")]
		private const float APPEAR_FROM = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4008ED3")]
		private const float APPEAR_TO = 0.5f;

		[Cpp2IlInjected.Token(Token = "0x4008ED4")]
		private const float DISAPPEAR_TO = -1.5f;

		[Cpp2IlInjected.Token(Token = "0x4008ED5")]
		private const float APPEAR_TIME = 0.5f;

		[Cpp2IlInjected.Token(Token = "0x4008ED6")]
		private const float DISAPPEAR_TIME = 1f;

		[Cpp2IlInjected.Token(Token = "0x4008ED7")]
		private const float DURATION = 11.5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4008ED8")]
		private LocalizedText _textKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4008ED9")]
		private string _formattedText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4008EDA")]
		public float ScreenAnchorX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4008EDB")]
		public readonly float Duration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4008EDC")]
		public readonly double SpawnTime;

		[Cpp2IlInjected.Token(Token = "0x17000903")]
		public string Text
		{
			[Cpp2IlInjected.Token(Token = "0x600525B")]
			[Cpp2IlInjected.Address(RVA = "0x109A344", Offset = "0x109A344", VA = "0x109A344")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600525C")]
		[Cpp2IlInjected.Address(RVA = "0x109A494", Offset = "0x109A494", VA = "0x109A494")]
		public bool IsExpired(double currentTime)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600525D")]
		[Cpp2IlInjected.Address(RVA = "0x1099314", Offset = "0x1099314", VA = "0x1099314")]
		public bool IsExpiring(double currentTime)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600525E")]
		[Cpp2IlInjected.Address(RVA = "0x109A3A4", Offset = "0x109A3A4", VA = "0x109A3A4")]
		public GameTip(LocalizedText text, double spawnTime)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600525F")]
		[Cpp2IlInjected.Address(RVA = "0x10995B4", Offset = "0x10995B4", VA = "0x10995B4")]
		public void Update(double currentTime)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006EC4")]
	private LocalizedText[] _tipsDefault;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4006EC5")]
	private LocalizedText[] _tipsGamepad;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4006EC6")]
	private LocalizedText[] _tipsKeyboard;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4006EC7")]
	private readonly List<GameTip> _currentTips;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4006EC8")]
	private LocalizedText _lastTip;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4006EC9")]
	private int _lastTipIndex;

	[Cpp2IlInjected.Token(Token = "0x60042BC")]
	[Cpp2IlInjected.Address(RVA = "0x1098FA0", Offset = "0x1098FA0", VA = "0x1098FA0")]
	public GameTipsDisplay()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60042BD")]
	[Cpp2IlInjected.Address(RVA = "0x109902C", Offset = "0x109902C", VA = "0x109902C")]
	public void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60042BE")]
	[Cpp2IlInjected.Address(RVA = "0x1099724", Offset = "0x1099724", VA = "0x1099724")]
	public void ClearTips()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60042BF")]
	[Cpp2IlInjected.Address(RVA = "0x1099780", Offset = "0x1099780", VA = "0x1099780")]
	public void Draw([Optional] String_Layout layout, float MaxHeight = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60042C0")]
	[Cpp2IlInjected.Address(RVA = "0x1099344", Offset = "0x1099344", VA = "0x1099344")]
	private void AddNewTip(double currentTime)
	{
	}
}
