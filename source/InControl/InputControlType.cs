using System;
using Cpp2ILInjected;

namespace InControl
{
	[global::Cpp2ILInjected.Token(Token = "0x2000023")]
	public enum InputControlType
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000145")]
		None,
		[global::Cpp2ILInjected.Token(Token = "0x4000146")]
		LeftStickUp,
		[global::Cpp2ILInjected.Token(Token = "0x4000147")]
		LeftStickDown,
		[global::Cpp2ILInjected.Token(Token = "0x4000148")]
		LeftStickLeft,
		[global::Cpp2ILInjected.Token(Token = "0x4000149")]
		LeftStickRight,
		[global::Cpp2ILInjected.Token(Token = "0x400014A")]
		LeftStickButton,
		[global::Cpp2ILInjected.Token(Token = "0x400014B")]
		RightStickUp,
		[global::Cpp2ILInjected.Token(Token = "0x400014C")]
		RightStickDown,
		[global::Cpp2ILInjected.Token(Token = "0x400014D")]
		RightStickLeft,
		[global::Cpp2ILInjected.Token(Token = "0x400014E")]
		RightStickRight,
		[global::Cpp2ILInjected.Token(Token = "0x400014F")]
		RightStickButton,
		[global::Cpp2ILInjected.Token(Token = "0x4000150")]
		DPadUp,
		[global::Cpp2ILInjected.Token(Token = "0x4000151")]
		DPadDown,
		[global::Cpp2ILInjected.Token(Token = "0x4000152")]
		DPadLeft,
		[global::Cpp2ILInjected.Token(Token = "0x4000153")]
		DPadRight,
		[global::Cpp2ILInjected.Token(Token = "0x4000154")]
		LeftTrigger,
		[global::Cpp2ILInjected.Token(Token = "0x4000155")]
		RightTrigger,
		[global::Cpp2ILInjected.Token(Token = "0x4000156")]
		LeftBumper,
		[global::Cpp2ILInjected.Token(Token = "0x4000157")]
		RightBumper,
		[global::Cpp2ILInjected.Token(Token = "0x4000158")]
		Action1,
		[global::Cpp2ILInjected.Token(Token = "0x4000159")]
		Action2,
		[global::Cpp2ILInjected.Token(Token = "0x400015A")]
		Action3,
		[global::Cpp2ILInjected.Token(Token = "0x400015B")]
		Action4,
		[global::Cpp2ILInjected.Token(Token = "0x400015C")]
		Action5,
		[global::Cpp2ILInjected.Token(Token = "0x400015D")]
		Action6,
		[global::Cpp2ILInjected.Token(Token = "0x400015E")]
		Action7,
		[global::Cpp2ILInjected.Token(Token = "0x400015F")]
		Action8,
		[global::Cpp2ILInjected.Token(Token = "0x4000160")]
		Action9,
		[global::Cpp2ILInjected.Token(Token = "0x4000161")]
		Action10,
		[global::Cpp2ILInjected.Token(Token = "0x4000162")]
		Action11,
		[global::Cpp2ILInjected.Token(Token = "0x4000163")]
		Action12,
		[global::Cpp2ILInjected.Token(Token = "0x4000164")]
		Back = 100,
		[global::Cpp2ILInjected.Token(Token = "0x4000165")]
		Start,
		[global::Cpp2ILInjected.Token(Token = "0x4000166")]
		Select,
		[global::Cpp2ILInjected.Token(Token = "0x4000167")]
		System,
		[global::Cpp2ILInjected.Token(Token = "0x4000168")]
		Options,
		[global::Cpp2ILInjected.Token(Token = "0x4000169")]
		Pause,
		[global::Cpp2ILInjected.Token(Token = "0x400016A")]
		Menu,
		[global::Cpp2ILInjected.Token(Token = "0x400016B")]
		Share,
		[global::Cpp2ILInjected.Token(Token = "0x400016C")]
		Home,
		[global::Cpp2ILInjected.Token(Token = "0x400016D")]
		View,
		[global::Cpp2ILInjected.Token(Token = "0x400016E")]
		Power,
		[global::Cpp2ILInjected.Token(Token = "0x400016F")]
		Capture,
		[global::Cpp2ILInjected.Token(Token = "0x4000170")]
		Assistant,
		[global::Cpp2ILInjected.Token(Token = "0x4000171")]
		Plus,
		[global::Cpp2ILInjected.Token(Token = "0x4000172")]
		Minus,
		[global::Cpp2ILInjected.Token(Token = "0x4000173")]
		PedalLeft = 150,
		[global::Cpp2ILInjected.Token(Token = "0x4000174")]
		PedalRight,
		[global::Cpp2ILInjected.Token(Token = "0x4000175")]
		PedalMiddle,
		[global::Cpp2ILInjected.Token(Token = "0x4000176")]
		GearUp,
		[global::Cpp2ILInjected.Token(Token = "0x4000177")]
		GearDown,
		[global::Cpp2ILInjected.Token(Token = "0x4000178")]
		Pitch = 200,
		[global::Cpp2ILInjected.Token(Token = "0x4000179")]
		Roll,
		[global::Cpp2ILInjected.Token(Token = "0x400017A")]
		Yaw,
		[global::Cpp2ILInjected.Token(Token = "0x400017B")]
		ThrottleUp,
		[global::Cpp2ILInjected.Token(Token = "0x400017C")]
		ThrottleDown,
		[global::Cpp2ILInjected.Token(Token = "0x400017D")]
		ThrottleLeft,
		[global::Cpp2ILInjected.Token(Token = "0x400017E")]
		ThrottleRight,
		[global::Cpp2ILInjected.Token(Token = "0x400017F")]
		POVUp,
		[global::Cpp2ILInjected.Token(Token = "0x4000180")]
		POVDown,
		[global::Cpp2ILInjected.Token(Token = "0x4000181")]
		POVLeft,
		[global::Cpp2ILInjected.Token(Token = "0x4000182")]
		POVRight,
		[global::Cpp2ILInjected.Token(Token = "0x4000183")]
		TiltX = 250,
		[global::Cpp2ILInjected.Token(Token = "0x4000184")]
		TiltY,
		[global::Cpp2ILInjected.Token(Token = "0x4000185")]
		TiltZ,
		[global::Cpp2ILInjected.Token(Token = "0x4000186")]
		ScrollWheel,
		[Obsolete("Use InputControlType.TouchPadButton instead.", true)]
		[global::Cpp2ILInjected.Token(Token = "0x4000187")]
		TouchPadTap,
		[global::Cpp2ILInjected.Token(Token = "0x4000188")]
		TouchPadButton,
		[global::Cpp2ILInjected.Token(Token = "0x4000189")]
		TouchPadXAxis,
		[global::Cpp2ILInjected.Token(Token = "0x400018A")]
		TouchPadYAxis,
		[global::Cpp2ILInjected.Token(Token = "0x400018B")]
		LeftSL,
		[global::Cpp2ILInjected.Token(Token = "0x400018C")]
		LeftSR,
		[global::Cpp2ILInjected.Token(Token = "0x400018D")]
		RightSL,
		[global::Cpp2ILInjected.Token(Token = "0x400018E")]
		RightSR,
		[global::Cpp2ILInjected.Token(Token = "0x400018F")]
		Command = 300,
		[global::Cpp2ILInjected.Token(Token = "0x4000190")]
		LeftStickX,
		[global::Cpp2ILInjected.Token(Token = "0x4000191")]
		LeftStickY,
		[global::Cpp2ILInjected.Token(Token = "0x4000192")]
		RightStickX,
		[global::Cpp2ILInjected.Token(Token = "0x4000193")]
		RightStickY,
		[global::Cpp2ILInjected.Token(Token = "0x4000194")]
		DPadX,
		[global::Cpp2ILInjected.Token(Token = "0x4000195")]
		DPadY,
		[global::Cpp2ILInjected.Token(Token = "0x4000196")]
		Analog0 = 400,
		[global::Cpp2ILInjected.Token(Token = "0x4000197")]
		Analog1,
		[global::Cpp2ILInjected.Token(Token = "0x4000198")]
		Analog2,
		[global::Cpp2ILInjected.Token(Token = "0x4000199")]
		Analog3,
		[global::Cpp2ILInjected.Token(Token = "0x400019A")]
		Analog4,
		[global::Cpp2ILInjected.Token(Token = "0x400019B")]
		Analog5,
		[global::Cpp2ILInjected.Token(Token = "0x400019C")]
		Analog6,
		[global::Cpp2ILInjected.Token(Token = "0x400019D")]
		Analog7,
		[global::Cpp2ILInjected.Token(Token = "0x400019E")]
		Analog8,
		[global::Cpp2ILInjected.Token(Token = "0x400019F")]
		Analog9,
		[global::Cpp2ILInjected.Token(Token = "0x40001A0")]
		Analog10,
		[global::Cpp2ILInjected.Token(Token = "0x40001A1")]
		Analog11,
		[global::Cpp2ILInjected.Token(Token = "0x40001A2")]
		Analog12,
		[global::Cpp2ILInjected.Token(Token = "0x40001A3")]
		Analog13,
		[global::Cpp2ILInjected.Token(Token = "0x40001A4")]
		Analog14,
		[global::Cpp2ILInjected.Token(Token = "0x40001A5")]
		Analog15,
		[global::Cpp2ILInjected.Token(Token = "0x40001A6")]
		Analog16,
		[global::Cpp2ILInjected.Token(Token = "0x40001A7")]
		Analog17,
		[global::Cpp2ILInjected.Token(Token = "0x40001A8")]
		Analog18,
		[global::Cpp2ILInjected.Token(Token = "0x40001A9")]
		Analog19,
		[global::Cpp2ILInjected.Token(Token = "0x40001AA")]
		Button0 = 500,
		[global::Cpp2ILInjected.Token(Token = "0x40001AB")]
		Button1,
		[global::Cpp2ILInjected.Token(Token = "0x40001AC")]
		Button2,
		[global::Cpp2ILInjected.Token(Token = "0x40001AD")]
		Button3,
		[global::Cpp2ILInjected.Token(Token = "0x40001AE")]
		Button4,
		[global::Cpp2ILInjected.Token(Token = "0x40001AF")]
		Button5,
		[global::Cpp2ILInjected.Token(Token = "0x40001B0")]
		Button6,
		[global::Cpp2ILInjected.Token(Token = "0x40001B1")]
		Button7,
		[global::Cpp2ILInjected.Token(Token = "0x40001B2")]
		Button8,
		[global::Cpp2ILInjected.Token(Token = "0x40001B3")]
		Button9,
		[global::Cpp2ILInjected.Token(Token = "0x40001B4")]
		Button10,
		[global::Cpp2ILInjected.Token(Token = "0x40001B5")]
		Button11,
		[global::Cpp2ILInjected.Token(Token = "0x40001B6")]
		Button12,
		[global::Cpp2ILInjected.Token(Token = "0x40001B7")]
		Button13,
		[global::Cpp2ILInjected.Token(Token = "0x40001B8")]
		Button14,
		[global::Cpp2ILInjected.Token(Token = "0x40001B9")]
		Button15,
		[global::Cpp2ILInjected.Token(Token = "0x40001BA")]
		Button16,
		[global::Cpp2ILInjected.Token(Token = "0x40001BB")]
		Button17,
		[global::Cpp2ILInjected.Token(Token = "0x40001BC")]
		Button18,
		[global::Cpp2ILInjected.Token(Token = "0x40001BD")]
		Button19,
		[global::Cpp2ILInjected.Token(Token = "0x40001BE")]
		Count
	}
}
