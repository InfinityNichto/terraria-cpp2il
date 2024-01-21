using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;
using Terraria.IO;

namespace Terraria.GameContent.UI.BigProgressBar;

[Cpp2IlInjected.Token(Token = "0x20006F9")]
public class BigProgressBarSystem
{
	[Cpp2IlInjected.Token(Token = "0x40070F8")]
	private static TwinsBigProgressBar _twinsBar;

	[Cpp2IlInjected.Token(Token = "0x40070F9")]
	private static EaterOfWorldsProgressBar _eaterOfWorldsBar;

	[Cpp2IlInjected.Token(Token = "0x40070FA")]
	private static BrainOfCthuluBigProgressBar _brainOfCthuluBar;

	[Cpp2IlInjected.Token(Token = "0x40070FB")]
	private static GolemHeadProgressBar _golemBar;

	[Cpp2IlInjected.Token(Token = "0x40070FC")]
	private static MoonLordProgressBar _moonlordBar;

	[Cpp2IlInjected.Token(Token = "0x40070FD")]
	private static SolarFlarePillarBigProgressBar _solarPillarBar;

	[Cpp2IlInjected.Token(Token = "0x40070FE")]
	private static VortexPillarBigProgressBar _vortexPillarBar;

	[Cpp2IlInjected.Token(Token = "0x40070FF")]
	private static NebulaPillarBigProgressBar _nebulaPillarBar;

	[Cpp2IlInjected.Token(Token = "0x4007100")]
	private static StardustPillarBigProgressBar _stardustPillarBar;

	[Cpp2IlInjected.Token(Token = "0x4007101")]
	private static NeverValidProgressBar _neverValid;

	[Cpp2IlInjected.Token(Token = "0x4007102")]
	private static PirateShipBigProgressBar _pirateShipBar;

	[Cpp2IlInjected.Token(Token = "0x4007103")]
	private static MartianSaucerBigProgressBar _martianSaucerBar;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4007104")]
	private IBigProgressBar _currentBar;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4007105")]
	private CommonBossBigProgressBar _bossBar;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4007106")]
	private BigProgressBarInfo _info;

	[Cpp2IlInjected.Token(Token = "0x4007107")]
	private static DeerclopsBigProgressBar _deerclopsBar;

	[Cpp2IlInjected.Token(Token = "0x4007108")]
	public static bool ShowText;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4007109")]
	private Dictionary<int, IBigProgressBar> _bossBarsByNpcNetId;

	[Cpp2IlInjected.Token(Token = "0x400710A")]
	private const string _preferencesKey = "ShowBossBarHealthText";

	[Cpp2IlInjected.Token(Token = "0x60045B9")]
	[Cpp2IlInjected.Address(RVA = "0x117E6C8", Offset = "0x117E6C8", VA = "0x117E6C8")]
	public bool IsTracking()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60045BA")]
	[Cpp2IlInjected.Address(RVA = "0x117E6D8", Offset = "0x117E6D8", VA = "0x117E6D8")]
	public void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60045BB")]
	[Cpp2IlInjected.Address(RVA = "0x117E9D8", Offset = "0x117E9D8", VA = "0x117E9D8")]
	public void Draw(SpriteBatch spriteBatch)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60045BC")]
	[Cpp2IlInjected.Address(RVA = "0x117E7C8", Offset = "0x117E7C8", VA = "0x117E7C8")]
	private void TryFindingNPCToTrack()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60045BD")]
	[Cpp2IlInjected.Address(RVA = "0x117EAB4", Offset = "0x117EAB4", VA = "0x117EAB4")]
	public bool TryTracking(int npcIndex)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60045BE")]
	[Cpp2IlInjected.Address(RVA = "0x117EC48", Offset = "0x117EC48", VA = "0x117EC48")]
	private void Configuration_Save(Preferences obj)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60045BF")]
	[Cpp2IlInjected.Address(RVA = "0x117ED08", Offset = "0x117ED08", VA = "0x117ED08")]
	private void Configuration_OnLoad(Preferences obj)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60045C0")]
	[Cpp2IlInjected.Address(RVA = "0x117EDEC", Offset = "0x117EDEC", VA = "0x117EDEC")]
	public static void ToggleShowText()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60045C1")]
	[Cpp2IlInjected.Address(RVA = "0x117EE6C", Offset = "0x117EE6C", VA = "0x117EE6C")]
	public BigProgressBarSystem()
	{
	}
}
