using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x2000132")]
public static class ControlAnchor
{
	[Cpp2IlInjected.Token(Token = "0x20007D3")]
	public enum ControlId
	{
		[Cpp2IlInjected.Token(Token = "0x4007B52")]
		Screen,
		[Cpp2IlInjected.Token(Token = "0x4007B53")]
		HeartsGrid,
		[Cpp2IlInjected.Token(Token = "0x4007B54")]
		GridItem,
		[Cpp2IlInjected.Token(Token = "0x4007B55")]
		ManaGrid,
		[Cpp2IlInjected.Token(Token = "0x4007B56")]
		Button,
		[Cpp2IlInjected.Token(Token = "0x4007B57")]
		LeftStick,
		[Cpp2IlInjected.Token(Token = "0x4007B58")]
		RightStick,
		[Cpp2IlInjected.Token(Token = "0x4007B59")]
		LeftInterface,
		[Cpp2IlInjected.Token(Token = "0x4007B5A")]
		RightInterface,
		[Cpp2IlInjected.Token(Token = "0x4007B5B")]
		PlayerCreateBacking,
		[Cpp2IlInjected.Token(Token = "0x4007B5C")]
		WorldCreateBacking,
		[Cpp2IlInjected.Token(Token = "0x4007B5D")]
		SelectedItemRegion,
		[Cpp2IlInjected.Token(Token = "0x4007B5E")]
		SelectedRightRegion,
		[Cpp2IlInjected.Token(Token = "0x4007B5F")]
		LeftPageRegion,
		[Cpp2IlInjected.Token(Token = "0x4007B60")]
		RightPageRegion,
		[Cpp2IlInjected.Token(Token = "0x4007B61")]
		MainMenuPageRegion,
		[Cpp2IlInjected.Token(Token = "0x4007B62")]
		Right_MainUI,
		[Cpp2IlInjected.Token(Token = "0x4007B63")]
		Right_InfoAccessories,
		[Cpp2IlInjected.Token(Token = "0x4007B64")]
		Right_TextNotifications,
		[Cpp2IlInjected.Token(Token = "0x4007B65")]
		Right_AchievementNotifiations,
		[Cpp2IlInjected.Token(Token = "0x4007B66")]
		Right_Event,
		[Cpp2IlInjected.Token(Token = "0x4007B67")]
		Right_BossBar,
		[Cpp2IlInjected.Token(Token = "0x4007B68")]
		Right_InfoAccessories2,
		[Cpp2IlInjected.Token(Token = "0x4007B69")]
		Right_StatusIndicator,
		[Cpp2IlInjected.Token(Token = "0x4007B6A")]
		PageGroup,
		[Cpp2IlInjected.Token(Token = "0x4007B6B")]
		PageContent,
		[Cpp2IlInjected.Token(Token = "0x4007B6C")]
		RightHUD_Root,
		[Cpp2IlInjected.Token(Token = "0x4007B6D")]
		WiringPopup,
		[Cpp2IlInjected.Token(Token = "0x4007B6E")]
		BottomCentre_Root,
		[Cpp2IlInjected.Token(Token = "0x4007B6F")]
		BottomCentre_ChatUI,
		[Cpp2IlInjected.Token(Token = "0x4007B70")]
		BottomCentre_BossBar,
		[Cpp2IlInjected.Token(Token = "0x4007B71")]
		BottomCentre_EventBar,
		[Cpp2IlInjected.Token(Token = "0x4007B72")]
		BottomCentre_ProgressIndicator,
		[Cpp2IlInjected.Token(Token = "0x4007B73")]
		BottomCentre_Notification,
		[Cpp2IlInjected.Token(Token = "0x4007B74")]
		SelectedItemBacking,
		[Cpp2IlInjected.Token(Token = "0x4007B75")]
		RubbleMakerPopup,
		[Cpp2IlInjected.Token(Token = "0x4007B76")]
		MenuScreen
	}

	[Cpp2IlInjected.Token(Token = "0x4000A64")]
	public static Rectangle _selectedItemBacking;

	[Cpp2IlInjected.Token(Token = "0x4000A65")]
	private static Rectangle _selectedRightRegion;

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public static Rectangle BottomCentre_Root
	{
		[Cpp2IlInjected.Token(Token = "0x6000A7F")]
		[Cpp2IlInjected.Address(RVA = "0x12053C0", Offset = "0x12053C0", VA = "0x12053C0")]
		get
		{
			return default(Rectangle);
		}
		[Cpp2IlInjected.Token(Token = "0x6000A80")]
		[Cpp2IlInjected.Address(RVA = "0x12013F0", Offset = "0x12013F0", VA = "0x12013F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public static Rectangle BottomCentre_ChatUI
	{
		[Cpp2IlInjected.Token(Token = "0x6000A81")]
		[Cpp2IlInjected.Address(RVA = "0x1205428", Offset = "0x1205428", VA = "0x1205428")]
		get
		{
			return default(Rectangle);
		}
		[Cpp2IlInjected.Token(Token = "0x6000A82")]
		[Cpp2IlInjected.Address(RVA = "0x1201698", Offset = "0x1201698", VA = "0x1201698")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public static Rectangle BottomCentre_BossBar
	{
		[Cpp2IlInjected.Token(Token = "0x6000A83")]
		[Cpp2IlInjected.Address(RVA = "0x1205490", Offset = "0x1205490", VA = "0x1205490")]
		get
		{
			return default(Rectangle);
		}
		[Cpp2IlInjected.Token(Token = "0x6000A84")]
		[Cpp2IlInjected.Address(RVA = "0x1201710", Offset = "0x1201710", VA = "0x1201710")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public static Rectangle BottomCentre_EventBar
	{
		[Cpp2IlInjected.Token(Token = "0x6000A85")]
		[Cpp2IlInjected.Address(RVA = "0x12054F8", Offset = "0x12054F8", VA = "0x12054F8")]
		get
		{
			return default(Rectangle);
		}
		[Cpp2IlInjected.Token(Token = "0x6000A86")]
		[Cpp2IlInjected.Address(RVA = "0x1201788", Offset = "0x1201788", VA = "0x1201788")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	public static Rectangle BottomCentre_ProgressIndicator
	{
		[Cpp2IlInjected.Token(Token = "0x6000A87")]
		[Cpp2IlInjected.Address(RVA = "0x1205560", Offset = "0x1205560", VA = "0x1205560")]
		get
		{
			return default(Rectangle);
		}
		[Cpp2IlInjected.Token(Token = "0x6000A88")]
		[Cpp2IlInjected.Address(RVA = "0x1201800", Offset = "0x1201800", VA = "0x1201800")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	public static Rectangle BottomCentre_Notification
	{
		[Cpp2IlInjected.Token(Token = "0x6000A89")]
		[Cpp2IlInjected.Address(RVA = "0x12055C8", Offset = "0x12055C8", VA = "0x12055C8")]
		get
		{
			return default(Rectangle);
		}
		[Cpp2IlInjected.Token(Token = "0x6000A8A")]
		[Cpp2IlInjected.Address(RVA = "0x1201878", Offset = "0x1201878", VA = "0x1201878")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	public static Rectangle Right_Root
	{
		[Cpp2IlInjected.Token(Token = "0x6000A8B")]
		[Cpp2IlInjected.Address(RVA = "0x1205630", Offset = "0x1205630", VA = "0x1205630")]
		get
		{
			return default(Rectangle);
		}
		[Cpp2IlInjected.Token(Token = "0x6000A8C")]
		[Cpp2IlInjected.Address(RVA = "0x1205698", Offset = "0x1205698", VA = "0x1205698")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	public static Rectangle Right_MainUI
	{
		[Cpp2IlInjected.Token(Token = "0x6000A8D")]
		[Cpp2IlInjected.Address(RVA = "0x1205710", Offset = "0x1205710", VA = "0x1205710")]
		get
		{
			return default(Rectangle);
		}
		[Cpp2IlInjected.Token(Token = "0x6000A8E")]
		[Cpp2IlInjected.Address(RVA = "0x1205778", Offset = "0x1205778", VA = "0x1205778")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public static Rectangle Right_TextNotifications
	{
		[Cpp2IlInjected.Token(Token = "0x6000A8F")]
		[Cpp2IlInjected.Address(RVA = "0x12057F0", Offset = "0x12057F0", VA = "0x12057F0")]
		get
		{
			return default(Rectangle);
		}
		[Cpp2IlInjected.Token(Token = "0x6000A90")]
		[Cpp2IlInjected.Address(RVA = "0x1205858", Offset = "0x1205858", VA = "0x1205858")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public static Rectangle Right_Event
	{
		[Cpp2IlInjected.Token(Token = "0x6000A91")]
		[Cpp2IlInjected.Address(RVA = "0x12058D0", Offset = "0x12058D0", VA = "0x12058D0")]
		get
		{
			return default(Rectangle);
		}
		[Cpp2IlInjected.Token(Token = "0x6000A92")]
		[Cpp2IlInjected.Address(RVA = "0x1205938", Offset = "0x1205938", VA = "0x1205938")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public static Rectangle Right_BossBar
	{
		[Cpp2IlInjected.Token(Token = "0x6000A93")]
		[Cpp2IlInjected.Address(RVA = "0x12059B0", Offset = "0x12059B0", VA = "0x12059B0")]
		get
		{
			return default(Rectangle);
		}
		[Cpp2IlInjected.Token(Token = "0x6000A94")]
		[Cpp2IlInjected.Address(RVA = "0x1205A18", Offset = "0x1205A18", VA = "0x1205A18")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public static Rectangle Right_StatusIndicator
	{
		[Cpp2IlInjected.Token(Token = "0x6000A95")]
		[Cpp2IlInjected.Address(RVA = "0x1205A90", Offset = "0x1205A90", VA = "0x1205A90")]
		get
		{
			return default(Rectangle);
		}
		[Cpp2IlInjected.Token(Token = "0x6000A96")]
		[Cpp2IlInjected.Address(RVA = "0x1205AF8", Offset = "0x1205AF8", VA = "0x1205AF8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public static Rectangle Right_InfoAccessories
	{
		[Cpp2IlInjected.Token(Token = "0x6000A97")]
		[Cpp2IlInjected.Address(RVA = "0x1205B70", Offset = "0x1205B70", VA = "0x1205B70")]
		get
		{
			return default(Rectangle);
		}
		[Cpp2IlInjected.Token(Token = "0x6000A98")]
		[Cpp2IlInjected.Address(RVA = "0x1205BD8", Offset = "0x1205BD8", VA = "0x1205BD8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public static Rectangle Right_InfoAccessories2
	{
		[Cpp2IlInjected.Token(Token = "0x6000A99")]
		[Cpp2IlInjected.Address(RVA = "0x1205C50", Offset = "0x1205C50", VA = "0x1205C50")]
		get
		{
			return default(Rectangle);
		}
		[Cpp2IlInjected.Token(Token = "0x6000A9A")]
		[Cpp2IlInjected.Address(RVA = "0x1205CB8", Offset = "0x1205CB8", VA = "0x1205CB8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	public static Rectangle Right_AchievementNotifiations
	{
		[Cpp2IlInjected.Token(Token = "0x6000A9B")]
		[Cpp2IlInjected.Address(RVA = "0x1205D30", Offset = "0x1205D30", VA = "0x1205D30")]
		get
		{
			return default(Rectangle);
		}
		[Cpp2IlInjected.Token(Token = "0x6000A9C")]
		[Cpp2IlInjected.Address(RVA = "0x1205D98", Offset = "0x1205D98", VA = "0x1205D98")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	public static Rectangle _gridItemRegion
	{
		[Cpp2IlInjected.Token(Token = "0x6000A9D")]
		[Cpp2IlInjected.Address(RVA = "0x1205E10", Offset = "0x1205E10", VA = "0x1205E10")]
		get
		{
			return default(Rectangle);
		}
		[Cpp2IlInjected.Token(Token = "0x6000A9E")]
		[Cpp2IlInjected.Address(RVA = "0x1205E78", Offset = "0x1205E78", VA = "0x1205E78")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public static Rectangle PageGroupRegion
	{
		[Cpp2IlInjected.Token(Token = "0x6000A9F")]
		[Cpp2IlInjected.Address(RVA = "0x1205EF0", Offset = "0x1205EF0", VA = "0x1205EF0")]
		get
		{
			return default(Rectangle);
		}
		[Cpp2IlInjected.Token(Token = "0x6000AA0")]
		[Cpp2IlInjected.Address(RVA = "0x1205F58", Offset = "0x1205F58", VA = "0x1205F58")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public static Rectangle PageContentRegion
	{
		[Cpp2IlInjected.Token(Token = "0x6000AA1")]
		[Cpp2IlInjected.Address(RVA = "0x1205FD0", Offset = "0x1205FD0", VA = "0x1205FD0")]
		get
		{
			return default(Rectangle);
		}
		[Cpp2IlInjected.Token(Token = "0x6000AA2")]
		[Cpp2IlInjected.Address(RVA = "0x1206038", Offset = "0x1206038", VA = "0x1206038")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	private static Rectangle _buttonRegion
	{
		[Cpp2IlInjected.Token(Token = "0x6000AA4")]
		[Cpp2IlInjected.Address(RVA = "0x12060C8", Offset = "0x12060C8", VA = "0x12060C8")]
		get
		{
			return default(Rectangle);
		}
		[Cpp2IlInjected.Token(Token = "0x6000AA5")]
		[Cpp2IlInjected.Address(RVA = "0x1206130", Offset = "0x1206130", VA = "0x1206130")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	private static Rectangle _selectedItemRegion
	{
		[Cpp2IlInjected.Token(Token = "0x6000AA7")]
		[Cpp2IlInjected.Address(RVA = "0x12061C0", Offset = "0x12061C0", VA = "0x12061C0")]
		get
		{
			return default(Rectangle);
		}
		[Cpp2IlInjected.Token(Token = "0x6000AA8")]
		[Cpp2IlInjected.Address(RVA = "0x1206228", Offset = "0x1206228", VA = "0x1206228")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	private static Rectangle _leftPageRegion
	{
		[Cpp2IlInjected.Token(Token = "0x6000AAB")]
		[Cpp2IlInjected.Address(RVA = "0x120632C", Offset = "0x120632C", VA = "0x120632C")]
		get
		{
			return default(Rectangle);
		}
		[Cpp2IlInjected.Token(Token = "0x6000AAC")]
		[Cpp2IlInjected.Address(RVA = "0x1206394", Offset = "0x1206394", VA = "0x1206394")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	private static Rectangle _rightPageRegion
	{
		[Cpp2IlInjected.Token(Token = "0x6000AAD")]
		[Cpp2IlInjected.Address(RVA = "0x120640C", Offset = "0x120640C", VA = "0x120640C")]
		get
		{
			return default(Rectangle);
		}
		[Cpp2IlInjected.Token(Token = "0x6000AAE")]
		[Cpp2IlInjected.Address(RVA = "0x1206474", Offset = "0x1206474", VA = "0x1206474")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	private static Rectangle _mainMenuPageRegion
	{
		[Cpp2IlInjected.Token(Token = "0x6000AB1")]
		[Cpp2IlInjected.Address(RVA = "0x120651C", Offset = "0x120651C", VA = "0x120651C")]
		get
		{
			return default(Rectangle);
		}
		[Cpp2IlInjected.Token(Token = "0x6000AB2")]
		[Cpp2IlInjected.Address(RVA = "0x1206584", Offset = "0x1206584", VA = "0x1206584")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public static Vector2 LeftInterface
	{
		[Cpp2IlInjected.Token(Token = "0x6000AB4")]
		[Cpp2IlInjected.Address(RVA = "0x1206614", Offset = "0x1206614", VA = "0x1206614")]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000AB5")]
		[Cpp2IlInjected.Address(RVA = "0x1206680", Offset = "0x1206680", VA = "0x1206680")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public static Vector2 RightInterface
	{
		[Cpp2IlInjected.Token(Token = "0x6000AB6")]
		[Cpp2IlInjected.Address(RVA = "0x12066E8", Offset = "0x12066E8", VA = "0x12066E8")]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000AB7")]
		[Cpp2IlInjected.Address(RVA = "0x1206754", Offset = "0x1206754", VA = "0x1206754")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public static Vector2 LeftControls
	{
		[Cpp2IlInjected.Token(Token = "0x6000AB8")]
		[Cpp2IlInjected.Address(RVA = "0x12067BC", Offset = "0x12067BC", VA = "0x12067BC")]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000AB9")]
		[Cpp2IlInjected.Address(RVA = "0x1206838", Offset = "0x1206838", VA = "0x1206838")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public static Vector2 RightControls
	{
		[Cpp2IlInjected.Token(Token = "0x6000ABA")]
		[Cpp2IlInjected.Address(RVA = "0x12068B0", Offset = "0x12068B0", VA = "0x12068B0")]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000ABB")]
		[Cpp2IlInjected.Address(RVA = "0x120692C", Offset = "0x120692C", VA = "0x120692C")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA3")]
	[Cpp2IlInjected.Address(RVA = "0x12060B0", Offset = "0x12060B0", VA = "0x12060B0")]
	public static void SetGridItemRegion(Rectangle region)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA6")]
	[Cpp2IlInjected.Address(RVA = "0x12061A8", Offset = "0x12061A8", VA = "0x12061A8")]
	public static void SetButtonRegion(Rectangle region)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA9")]
	[Cpp2IlInjected.Address(RVA = "0x12062A0", Offset = "0x12062A0", VA = "0x12062A0")]
	public static void SetSelectedItemRegion(Rectangle region)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AAA")]
	[Cpp2IlInjected.Address(RVA = "0x12062B8", Offset = "0x12062B8", VA = "0x12062B8")]
	public static void SetSelectedRightRegion(Rectangle region)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AAF")]
	[Cpp2IlInjected.Address(RVA = "0x12064EC", Offset = "0x12064EC", VA = "0x12064EC")]
	public static void SetLeftPageRegion(Rectangle region)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB0")]
	[Cpp2IlInjected.Address(RVA = "0x1206504", Offset = "0x1206504", VA = "0x1206504")]
	public static void SetRightPageRegion(Rectangle region)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB3")]
	[Cpp2IlInjected.Address(RVA = "0x12065FC", Offset = "0x12065FC", VA = "0x12065FC")]
	public static void SetMainMenuPageRegion(Rectangle region)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ABC")]
	[Cpp2IlInjected.Address(RVA = "0x12069A4", Offset = "0x12069A4", VA = "0x12069A4")]
	public static Rectangle GetControlRegion(ControlId controlId)
	{
		return default(Rectangle);
	}
}
